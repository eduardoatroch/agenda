Public Class frmSenhaGeral
    Public Shared usuarioGeral As String = ""
    Public Shared senhaGeral As String = ""

    Private Sub frmSenhaGeral_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnConfirmarSenha_Click(sender As Object, e As EventArgs) Handles btnConfirmarSenha.Click
        Me.ValidarClickBotaoSenha()
    End Sub

    Private Sub ValidarClickBotaoSenha()
        frmSenhaGeral.usuarioGeral = Me.txtUsuarioGeral.Text.Trim
        frmSenhaGeral.senhaGeral = Me.txtSenhaGeral.Text.Trim
    End Sub

    Private Sub txtSenhaGeral_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSenhaGeral.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ValidarClickBotaoSenha()
            Me.Close()
        End If
    End Sub

End Class