Public Class frmCadastroCliente
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub frmCadastroCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PreencherListaClientes()
    End Sub

    Private Sub PreencherListaClientes()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand
        Dim dtr As SqlClient.SqlDataReader
        Dim lvi As ListViewItem

        Try

            Me.lstvClientes.Items.Clear()

            With cmd
                .CommandType = CommandType.StoredProcedure
                .Connection = cnn

                If Me.txtPesquisar.Text.Trim = "" Then
                    .CommandText = "spRetornarListaClientes"
                Else
                    .CommandText = "spRetornarListaClientes;2"
                    .Parameters.Add("@Busca", SqlDbType.VarChar, 30, "Busca")
                    .Parameters(0).Value = Me.txtPesquisar.Text.Trim & "%"
                End If

                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    lvi = Me.lstvClientes.Items.Add(dtr(0).ToString) 'Código Cliente
                    lvi.SubItems.Add(dtr(1).ToString) 'Nome do Cliente
                    lvi.SubItems.Add(dtr(2).ToString) 'Telefone
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

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        If Me.lstvClientes.SelectedItems.Count = 0 Then
            MsgBox("Selecione o(s) cliente(s) que deseja excluir!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If MsgBox("Confirma a exclusão do(s) cliente(s) selecionado(s)?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ExcluirCliente()
            Me.PreencherListaClientes()
        End If
    End Sub

    Private Sub ExcluirCliente()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spExcluirCliente", cnn)
        Dim I As Integer

        Try

            With cmd
                .CommandType = CommandType.StoredProcedure

                For I = 0 To Me.lstvClientes.SelectedItems.Count - 1
                    .Parameters.Clear()
                    .Parameters.Add("@CodigoCliente", SqlDbType.Int, 4, "CodigoCliente")
                    .Parameters(0).Value = CLng(Me.lstvClientes.SelectedItems(I).Text)

                    cnn.Open()
                    .ExecuteNonQuery()
                    cnn.Close()

                Next

            End With

        Catch ex As Exception
            MsgBox(ex.Source & Chr(13) & ex.Message)
        Finally
            cnn.Dispose()
            cmd.Dispose()
            GC.Collect()
        End Try
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        If Me.lstvClientes.SelectedItems.Count = 0 Then
            MsgBox("Selecione o cliente que deseja alterar!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim frm As New frmIncluirEditarCliente(CLng(Me.lstvClientes.SelectedItems(0).Text), False)
        frm.ShowDialog()
        Me.PreencherListaClientes()
    End Sub

    Private Sub btnIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncluir.Click
        Dim frm As New frmIncluirEditarCliente(0, True)
        frm.ShowDialog()
        Me.PreencherListaClientes()
    End Sub

End Class