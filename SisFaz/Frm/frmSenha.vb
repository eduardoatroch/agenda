Public Class frmSenha

    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Private Sub frmSenha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtSenha.Focus()
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

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
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

    Private Sub InitializeComponent()
        Me.txtSenha = New System.Windows.Forms.TextBox
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(80, 91)
        Me.txtSenha.MaxLength = 10
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txtSenha.Size = New System.Drawing.Size(100, 20)
        Me.txtSenha.TabIndex = 0
        '
        'txtUsuario
        '
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(80, 140)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(168, 20)
        Me.txtUsuario.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Senha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Usuário"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(203, 92)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmSenha
        '
        Me.ClientSize = New System.Drawing.Size(310, 253)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtSenha)
        Me.Name = "frmSenha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class