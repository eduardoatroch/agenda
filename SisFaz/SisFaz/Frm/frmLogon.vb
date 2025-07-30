Public Class frmLogon

    Private Sub btnSenha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSenha.Click

        Me.VerificarSenha()

        If Me.txtUsuario.Text.Trim = "" Then
            MsgBox("Senha não informada ou não confere", MsgBoxStyle.Information)
            Me.txtSenha.Text = ""
        Else
            MsgBox("Bom trabalho " & Chr(13) & Me.txtUsuario.Text.Trim, MsgBoxStyle.Information)
            Me.Close()
        End If

    End Sub

    Private Sub txtSenha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSenha.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtSenha.Text.Trim = "" Then
                MsgBox("Senha não informada", MsgBoxStyle.Information)
                Me.txtSenha.Focus()
                Exit Sub
            End If

            VerificarSenha()

            If Me.txtUsuario.Text.Trim = "" Then
                MsgBox("Senha não informada ou não confere", MsgBoxStyle.Information)
                Me.txtSenha.Text = ""
            Else
                MsgBox("Bom trabalho " & Chr(13) & Me.txtUsuario.Text.Trim, MsgBoxStyle.Information)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub VerificarSenha()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spVerificarSenhaDoUsuario", cnn)

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@Senha", SqlDbType.VarChar, 10, "Senha")
                .Parameters(0).Value = Me.txtSenha.Text.Trim
                .Parameters.Add("@Usuario", SqlDbType.VarChar, 20, "Usuario")
                .Parameters(1).Direction = ParameterDirection.Output

                cnn.Open()
                .ExecuteNonQuery()
                cnn.Close()

                Me.txtUsuario.Text = .Parameters(1).Value

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