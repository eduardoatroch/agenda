Public Class frmFormasPagamento
    Private Incluir As Boolean = False

    Private Sub frmFormasPagamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PreencherListaFormasPagamento()
        Me.grpForma.Enabled = False
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub PreencherListaFormasPagamento()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarListaFormasPagamento", cnn)
        Dim dtr As SqlClient.SqlDataReader
        Dim lvi As ListViewItem

        Try
            Me.lstvFormaPagamento.Items.Clear()

            With cmd
                .CommandType = CommandType.StoredProcedure
                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    lvi = Me.lstvFormaPagamento.Items.Add(dtr(0).ToString) 'Código do Tipo de Documento
                    lvi.SubItems.Add(dtr(1).ToString) 'Descrição do Tipo
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

    Private Sub btnIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncluir.Click
        Me.Incluir = True
        Me.grpForma.Enabled = True
        Me.txtCodigo.Focus()
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        If Me.lstvFormaPagamento.SelectedItems.Count = 0 Then
            MsgBox("Selecione o Tipo de Documento que deseja alterar", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Me.txtCodigo.Enabled = False
        Me.txtForma.Focus()
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        If Me.lstvFormaPagamento.SelectedItems.Count = 0 Then
            MsgBox("Selecione o Tipo de Documento que deseja excluir", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If MsgBox("Confirma a exclusão da Forma de Pagamento: " & Me.lstvFormaPagamento.SelectedItems(0).Text.Trim & " - " & _
                                                                  Me.lstvFormaPagamento.SelectedItems(0).SubItems(1).Text.Trim, MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ExcluirFormaPagamento()
            Me.Incluir = False
            Me.PreencherListaFormasPagamento()
        End If
    End Sub

    Private Sub ExcluirFormaPagamento()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spExcluirFormaPagamento", cnn)

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@CodigoForma", SqlDbType.VarChar, 2, "CodigoForma")
                .Parameters(0).Value = Me.lstvFormaPagamento.SelectedItems(0).Text.Trim
                .Parameters.Add("@ret", SqlDbType.Bit, 1, "ret")
                .Parameters(1).Direction = ParameterDirection.Output

                cnn.Open()
                .ExecuteNonQuery()
                cnn.Close()

                If CByte(.Parameters(1).Value) = 0 Then
                    MsgBox("Exclusão negada, há movimentação do caixa com esta Forma de Pagamento", MsgBoxStyle.Exclamation)
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

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        If Me.txtCodigo.Text.Trim = "" Then
            MsgBox("Informe o Código da Forma de Pagamento", MsgBoxStyle.Exclamation)
            Me.txtCodigo.Focus()
            Exit Sub
        End If
        If Me.txtForma.Text.Trim = "" Then
            MsgBox("Informe a Descrição da Forma de Pagamento", MsgBoxStyle.Exclamation)
            Me.txtForma.Focus()
            Exit Sub
        End If
        If MsgBox("Confirma salvar agora?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SalvarFormaPagamento()
            Me.txtCodigo.Text = ""
            Me.txtForma.Text = ""
            Me.txtCodigo.Enabled = True
            Me.grpForma.Enabled = False
            Me.Incluir = False
            Me.PreencherListaFormasPagamento()
        End If
    End Sub

    Private Sub SalvarFormaPagamento()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Connection = cnn

                If Me.Incluir Then
                    .CommandText = "spIncluirFormaPagamento"
                Else
                    .CommandText = "spAlterarFormaPagamento"
                End If

                .Parameters.Add("@CodigoForma", SqlDbType.VarChar, 2, "CodigoForma")
                .Parameters(0).Value = Me.txtCodigo.Text.Trim
                .Parameters.Add("@Forma", SqlDbType.VarChar, 40, "Forma")
                .Parameters(1).Value = Me.txtForma.Text.Trim

                If Me.Incluir Then
                    .Parameters.Add("@ret", SqlDbType.Bit, 1, "ret")
                    .Parameters(2).Direction = ParameterDirection.Output
                End If

                cnn.Open()
                .ExecuteNonQuery()
                cnn.Close()

                If Me.Incluir Then
                    If CByte(.Parameters(2).Value) = 0 Then
                        MsgBox("Já existe uma Forma de Pagamento com o código informado, escolha outro", MsgBoxStyle.Exclamation)
                    End If
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

    Private Sub lstvFormaPagamento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstvFormaPagamento.SelectedIndexChanged
        If Me.lstvFormaPagamento.SelectedItems.Count > 0 Then
            Me.Incluir = False
            EditarTipo()
        End If
    End Sub

    Private Sub EditarTipo()
        Me.grpForma.Enabled = True
        Me.txtCodigo.Text = Me.lstvFormaPagamento.SelectedItems(0).Text
        Me.txtForma.Text = Me.lstvFormaPagamento.SelectedItems(0).SubItems(1).Text
    End Sub

End Class