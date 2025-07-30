<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSenhaGeral
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtUsuarioGeral = New System.Windows.Forms.TextBox()
        Me.txtSenhaGeral = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnConfirmarSenha = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtUsuarioGeral
        '
        Me.txtUsuarioGeral.Location = New System.Drawing.Point(94, 123)
        Me.txtUsuarioGeral.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsuarioGeral.Name = "txtUsuarioGeral"
        Me.txtUsuarioGeral.Size = New System.Drawing.Size(245, 22)
        Me.txtUsuarioGeral.TabIndex = 1
        '
        'txtSenhaGeral
        '
        Me.txtSenhaGeral.Location = New System.Drawing.Point(94, 215)
        Me.txtSenhaGeral.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSenhaGeral.Name = "txtSenhaGeral"
        Me.txtSenhaGeral.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txtSenhaGeral.Size = New System.Drawing.Size(245, 22)
        Me.txtSenhaGeral.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(91, 102)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Usuário"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(91, 194)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Senha"
        '
        'btnConfirmarSenha
        '
        Me.btnConfirmarSenha.Location = New System.Drawing.Point(239, 294)
        Me.btnConfirmarSenha.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConfirmarSenha.Name = "btnConfirmarSenha"
        Me.btnConfirmarSenha.Size = New System.Drawing.Size(100, 28)
        Me.btnConfirmarSenha.TabIndex = 5
        Me.btnConfirmarSenha.Text = "Confirmar"
        Me.btnConfirmarSenha.UseVisualStyleBackColor = True
        '
        'frmSenhaGeral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(438, 435)
        Me.Controls.Add(Me.btnConfirmarSenha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSenhaGeral)
        Me.Controls.Add(Me.txtUsuarioGeral)
        Me.Name = "frmSenhaGeral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Senha Administrativa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUsuarioGeral As TextBox
    Friend WithEvents txtSenhaGeral As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnConfirmarSenha As Button
End Class
