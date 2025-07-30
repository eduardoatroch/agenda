Public Class frmFornecedores

    Private Sub frmFornecedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PreencherListaFornecedores()
    End Sub

    Private Sub PreencherListaFornecedores()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarListaFornecedores", cnn)
        Dim dtr As SqlClient.SqlDataReader
        Dim lvi As ListViewItem

        Try
            Me.lstvFornecedores.Items.Clear()
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Connection = cnn

                If Me.txtPesquisar.Text.Trim = "" Then
                    .CommandText = "spRetornarListaFornecedores"
                Else
                    .CommandText = "spRetornarListaFornecedores;2"
                    .Parameters.Add("@texto", SqlDbType.VarChar, 30, "Texto")
                    .Parameters(0).Value = Me.txtPesquisar.Text & "%"
                End If

                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    lvi = Me.lstvFornecedores.Items.Add(dtr(0).ToString) 'Código
                    lvi.SubItems.Add(dtr(1).ToString) 'Nome do Fornecedor
                    lvi.SubItems.Add(dtr(2).ToString) 'CNPJ/CPF do Fornecedor
                    lvi.SubItems.Add(dtr(3).ToString) 'Ativo : 0=Não, 1=Sim
                Loop
                dtr.Close()
                dtr = Nothing
                cnn.Close()
            End With
        Catch ex As Exception
            MsgBox(ex.Source & Chr(13) & ex.Message)
        Finally
            cnn.Dispose()
            cmd.Dispose()
            GC.Collect()
        End Try
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub txtPesquisar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPesquisar.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.PreencherListaFornecedores()
        End If
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        If Me.lstvFornecedores.SelectedItems.Count = 0 Then
            MsgBox("Selecione o Fornecedor que deseja alterar", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim frm As New frmIncluirEditarFornecedor(CLng(Me.lstvFornecedores.SelectedItems(0).Text), False)
        frm.ShowDialog()
        Me.PreencherListaFornecedores()
    End Sub

    Private Sub btnIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncluir.Click
        Dim frm As New frmIncluirEditarFornecedor(0, True)
        frm.ShowDialog()
        Me.PreencherListaFornecedores()
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        If Me.lstvFornecedores.SelectedItems.Count = 0 Then
            MsgBox("Selecione o Fornecedor que deseja excluir", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If MsgBox("Confirma a exclusão do Fornecedor: " & Me.lstvFornecedores.SelectedItems(0).SubItems(1).Text.Trim, MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ExcluirFornecedor()
            Me.PreencherListaFornecedores()
        End If
    End Sub

    Private Sub ExcluirFornecedor()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spExcluirFornecedor", cnn)

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@CodigoFornecedor", SqlDbType.Int, 4, "CodigoFornecedor")
                .Parameters(0).Value = CLng(Me.lstvFornecedores.SelectedItems(0).Text)
                .Parameters.Add("@ret", SqlDbType.Bit, 1, "ret")
                .Parameters(1).Direction = ParameterDirection.Output
                cnn.Open()
                .ExecuteNonQuery()
                cnn.Close()

                If CByte(.Parameters(1).Value) = 0 Then
                    MsgBox("Existe título vinculado ao fornecedor," & Chr(13) & "exclusão abortada", MsgBoxStyle.Information)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Source & Chr(13) & ex.Message)
        Finally
            cnn.Dispose()
            cmd.Dispose()
            GC.Collect()
        End Try
    End Sub

    Private Sub btnPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisar.Click
        Me.PreencherListaFornecedores()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim frm As New frmRptFornecedores
        frm.ShowDialog()
    End Sub

End Class