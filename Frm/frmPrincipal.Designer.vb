<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grpTipoConexao = New System.Windows.Forms.GroupBox()
        Me.cboTipoAcesso = New System.Windows.Forms.ComboBox()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblVersao = New System.Windows.Forms.Label()
        Me.grpLogin = New System.Windows.Forms.GroupBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.btnAcessar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMensagem = New System.Windows.Forms.Label()
        Me.pbImagemTela = New System.Windows.Forms.PictureBox()
        Me.grpTipoConexao.SuspendLayout()
        Me.grpLogin.SuspendLayout()
        CType(Me.pbImagemTela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpTipoConexao
        '
        Me.grpTipoConexao.BackColor = System.Drawing.Color.White
        Me.grpTipoConexao.Controls.Add(Me.cboTipoAcesso)
        Me.grpTipoConexao.ForeColor = System.Drawing.Color.Black
        Me.grpTipoConexao.Location = New System.Drawing.Point(299, 12)
        Me.grpTipoConexao.Name = "grpTipoConexao"
        Me.grpTipoConexao.Size = New System.Drawing.Size(162, 57)
        Me.grpTipoConexao.TabIndex = 1
        Me.grpTipoConexao.TabStop = False
        Me.grpTipoConexao.Text = "Tipo de conexão "
        Me.grpTipoConexao.Visible = False
        '
        'cboTipoAcesso
        '
        Me.cboTipoAcesso.FormattingEnabled = True
        Me.cboTipoAcesso.Items.AddRange(New Object() {"01 - Local", "02 - Microsoft Azure", "03 - Somee.com"})
        Me.cboTipoAcesso.Location = New System.Drawing.Point(14, 21)
        Me.cboTipoAcesso.Name = "cboTipoAcesso"
        Me.cboTipoAcesso.Size = New System.Drawing.Size(129, 21)
        Me.cboTipoAcesso.TabIndex = 2
        Me.cboTipoAcesso.Text = "01 - Local"
        '
        'btnSair
        '
        Me.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSair.Location = New System.Drawing.Point(887, 12)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(74, 33)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(833, 631)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Exemplo de Ordenação"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'lblVersao
        '
        Me.lblVersao.AutoSize = True
        Me.lblVersao.BackColor = System.Drawing.Color.White
        Me.lblVersao.Location = New System.Drawing.Point(5, 642)
        Me.lblVersao.Name = "lblVersao"
        Me.lblVersao.Size = New System.Drawing.Size(79, 13)
        Me.lblVersao.TabIndex = 5
        Me.lblVersao.Text = "Versão: 0.0.0.0"
        '
        'grpLogin
        '
        Me.grpLogin.BackColor = System.Drawing.Color.White
        Me.grpLogin.Controls.Add(Me.lblMensagem)
        Me.grpLogin.Controls.Add(Me.txtSenha)
        Me.grpLogin.Controls.Add(Me.txtLogin)
        Me.grpLogin.Controls.Add(Me.btnAcessar)
        Me.grpLogin.Controls.Add(Me.Label4)
        Me.grpLogin.Controls.Add(Me.Label3)
        Me.grpLogin.Location = New System.Drawing.Point(12, 12)
        Me.grpLogin.Name = "grpLogin"
        Me.grpLogin.Size = New System.Drawing.Size(281, 127)
        Me.grpLogin.TabIndex = 11
        Me.grpLogin.TabStop = False
        Me.grpLogin.Text = "Login"
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(59, 48)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txtSenha.Size = New System.Drawing.Size(144, 20)
        Me.txtSenha.TabIndex = 2
        '
        'txtLogin
        '
        Me.txtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLogin.Location = New System.Drawing.Point(59, 23)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(212, 20)
        Me.txtLogin.TabIndex = 1
        '
        'btnAcessar
        '
        Me.btnAcessar.Location = New System.Drawing.Point(197, 75)
        Me.btnAcessar.Name = "btnAcessar"
        Me.btnAcessar.Size = New System.Drawing.Size(74, 33)
        Me.btnAcessar.TabIndex = 0
        Me.btnAcessar.Text = "Acessar ->"
        Me.btnAcessar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(15, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Senha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Usuário:"
        '
        'lblMensagem
        '
        Me.lblMensagem.AutoSize = True
        Me.lblMensagem.BackColor = System.Drawing.Color.White
        Me.lblMensagem.Location = New System.Drawing.Point(10, 107)
        Me.lblMensagem.Name = "lblMensagem"
        Me.lblMensagem.Size = New System.Drawing.Size(59, 13)
        Me.lblMensagem.TabIndex = 14
        Me.lblMensagem.Text = "Mensagem"
        '
        'pbImagemTela
        '
        Me.pbImagemTela.BackgroundImage = Global.Agenda.My.Resources.Resources.Telefone
        Me.pbImagemTela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbImagemTela.Location = New System.Drawing.Point(8, 145)
        Me.pbImagemTela.Name = "pbImagemTela"
        Me.pbImagemTela.Size = New System.Drawing.Size(953, 480)
        Me.pbImagemTela.TabIndex = 12
        Me.pbImagemTela.TabStop = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnSair
        Me.ClientSize = New System.Drawing.Size(973, 659)
        Me.Controls.Add(Me.pbImagemTela)
        Me.Controls.Add(Me.grpLogin)
        Me.Controls.Add(Me.lblVersao)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.grpTipoConexao)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda Telefônica"
        Me.grpTipoConexao.ResumeLayout(False)
        Me.grpLogin.ResumeLayout(False)
        Me.grpLogin.PerformLayout()
        CType(Me.pbImagemTela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpTipoConexao As System.Windows.Forms.GroupBox
    Friend WithEvents cboTipoAcesso As System.Windows.Forms.ComboBox
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblVersao As Label
    Friend WithEvents grpLogin As GroupBox
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents txtLogin As TextBox
    Friend WithEvents btnAcessar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMensagem As Label
    Friend WithEvents pbImagemTela As PictureBox
End Class
