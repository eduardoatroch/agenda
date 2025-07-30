Public Class frmBancos

    Private Sub frmBancos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PreencherListaBancos()
        Me.grpBanco.Enabled = False
    End Sub

    Private Sub PreencherListaBancos()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarListaBanco", cnn)
        Dim dtr As SqlClient.SqlDataReader
        Dim lvi As ListViewItem

        Try
            Me.lstvBancos.Items.Clear()

            With cmd
                .CommandType = CommandType.StoredProcedure
                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    lvi = Me.lstvBancos.Items.Add(dtr(0).ToString) 'Código
                    lvi.SubItems.Add(dtr(1).ToString) 'Banco
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

    Private Sub btnIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncluir.Click
        Me.grpBanco.Enabled = True
        Me.txtCodigo.Focus()
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        If Me.txtCodigo.Text.Trim = "" Then
            MsgBox("Informe o código do Banco", MsgBoxStyle.Exclamation)
            Me.txtCodigo.Focus()
            Exit Sub
        End If
        If Me.txtBanco.Text.Trim = "" Then
            MsgBox("Informe o Nome do Banco", MsgBoxStyle.Exclamation)
            Me.txtBanco.Focus()
            Exit Sub
        End If
        If MsgBox("Confirma salvar agora ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SalvarBanco()
            Me.txtCodigo.Text = ""
            Me.txtBanco.Text = ""
            Me.grpBanco.Enabled = False
            Me.PreencherListaBancos()
        End If
    End Sub

    Private Sub SalvarBanco()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spSalvarBanco", cnn)

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@CodigoBanco", SqlDbType.SmallInt, 2, "CodigoBanco")
                .Parameters(0).Value = CInt(Me.txtCodigo.Text)
                .Parameters.Add("@NomeBanco", SqlDbType.VarChar, 40, "NomeBanco")
                .Parameters(1).Value = Me.txtBanco.Text.Trim
                cnn.Open()
                .ExecuteNonQuery()
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

    Private Sub lstvBancos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstvBancos.SelectedIndexChanged
        If Me.lstvBancos.SelectedItems.Count > 0 Then
            EditarBanco()
        End If
    End Sub

    Private Sub EditarBanco()
        Me.txtCodigo.Text = Me.lstvBancos.SelectedItems(0).Text
        Me.txtBanco.Text = Me.lstvBancos.SelectedItems(0).SubItems(1).Text.Trim
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        If Me.lstvBancos.SelectedItems.Count = 0 Then
            MsgBox("Selecione o Banco que deseja alterar", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Me.grpBanco.Enabled = True
        Me.txtCodigo.Focus()
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        If Me.lstvBancos.SelectedItems.Count = 0 Then
            MsgBox("Selecione o Banco que deseja excluir", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If MsgBox("Confirma a exclusão do Banco: " & Me.lstvBancos.SelectedItems(0).SubItems(1).Text.Trim, MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ExcluirBanco()
            Me.PreencherListaBancos()
        End If
    End Sub

    Private Sub ExcluirBanco()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spExcluirBanco", cnn)

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@CodigoBanco", SqlDbType.SmallInt, 2, "CodigoBanco")
                .Parameters(0).Value = CInt(Me.lstvBancos.SelectedItems(0).Text)
                .Parameters.Add("@ret", SqlDbType.Bit, 1, "ret")
                .Parameters(1).Direction = ParameterDirection.Output
                cnn.Open()
                .ExecuteNonQuery()
                cnn.Close()

                If CByte(.Parameters(1).Value = 0) Then
                    MsgBox("Existe movimento de caixa vinculado ao Banco, exclusão abortada", MsgBoxStyle.Information)
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

End Class