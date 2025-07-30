<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstvUsuarios = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Ativo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.senha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grpEdicaoUsuario = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkAtivo = New System.Windows.Forms.CheckBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnIncluir = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.grpEdicaoUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstvUsuarios)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 81)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(380, 431)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Usuários"
        '
        'lstvUsuarios
        '
        Me.lstvUsuarios.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Nome, Me.Ativo, Me.senha})
        Me.lstvUsuarios.FullRowSelect = True
        Me.lstvUsuarios.HideSelection = False
        Me.lstvUsuarios.Location = New System.Drawing.Point(7, 17)
        Me.lstvUsuarios.Margin = New System.Windows.Forms.Padding(2)
        Me.lstvUsuarios.Name = "lstvUsuarios"
        Me.lstvUsuarios.Size = New System.Drawing.Size(367, 398)
        Me.lstvUsuarios.TabIndex = 0
        Me.lstvUsuarios.UseCompatibleStateImageBehavior = False
        Me.lstvUsuarios.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        '
        'Nome
        '
        Me.Nome.Text = "Nome"
        Me.Nome.Width = 200
        '
        'Ativo
        '
        Me.Ativo.Text = "Ativo (S/N)"
        Me.Ativo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Ativo.Width = 95
        '
        'senha
        '
        Me.senha.Text = "Senha"
        Me.senha.Width = 0
        '
        'grpEdicaoUsuario
        '
        Me.grpEdicaoUsuario.Controls.Add(Me.Label5)
        Me.grpEdicaoUsuario.Controls.Add(Me.txtLogin)
        Me.grpEdicaoUsuario.Controls.Add(Me.Label4)
        Me.grpEdicaoUsuario.Controls.Add(Me.cboTipoUsuario)
        Me.grpEdicaoUsuario.Controls.Add(Me.Label3)
        Me.grpEdicaoUsuario.Controls.Add(Me.txtEmail)
        Me.grpEdicaoUsuario.Controls.Add(Me.btnCancelar)
        Me.grpEdicaoUsuario.Controls.Add(Me.btnSalvar)
        Me.grpEdicaoUsuario.Controls.Add(Me.Label2)
        Me.grpEdicaoUsuario.Controls.Add(Me.Label1)
        Me.grpEdicaoUsuario.Controls.Add(Me.chkAtivo)
        Me.grpEdicaoUsuario.Controls.Add(Me.txtSenha)
        Me.grpEdicaoUsuario.Controls.Add(Me.txtNome)
        Me.grpEdicaoUsuario.Location = New System.Drawing.Point(413, 81)
        Me.grpEdicaoUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.grpEdicaoUsuario.Name = "grpEdicaoUsuario"
        Me.grpEdicaoUsuario.Padding = New System.Windows.Forms.Padding(2)
        Me.grpEdicaoUsuario.Size = New System.Drawing.Size(380, 431)
        Me.grpEdicaoUsuario.TabIndex = 6
        Me.grpEdicaoUsuario.TabStop = False
        Me.grpEdicaoUsuario.Text = " Editar Usuário "
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Location = New System.Drawing.Point(126, 300)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(71, 33)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.Location = New System.Drawing.Point(27, 300)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(71, 33)
        Me.btnSalvar.TabIndex = 5
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 221)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Senha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nome"
        '
        'chkAtivo
        '
        Me.chkAtivo.AutoSize = True
        Me.chkAtivo.Location = New System.Drawing.Point(28, 18)
        Me.chkAtivo.Margin = New System.Windows.Forms.Padding(2)
        Me.chkAtivo.Name = "chkAtivo"
        Me.chkAtivo.Size = New System.Drawing.Size(50, 17)
        Me.chkAtivo.TabIndex = 2
        Me.chkAtivo.Text = "Ativo"
        Me.chkAtivo.UseVisualStyleBackColor = True
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(26, 236)
        Me.txtSenha.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSenha.MaxLength = 50
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txtSenha.Size = New System.Drawing.Size(172, 20)
        Me.txtSenha.TabIndex = 1
        '
        'txtNome
        '
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.Location = New System.Drawing.Point(26, 56)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNome.MaxLength = 50
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(255, 20)
        Me.txtNome.TabIndex = 0
        '
        'btnSair
        '
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSair.Image = Global.Agenda.My.Resources.Resources.EXITS1
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSair.Location = New System.Drawing.Point(10, 11)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(62, 49)
        Me.btnSair.TabIndex = 8
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.Image = Global.Agenda.My.Resources.Resources.WASTE
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExcluir.Location = New System.Drawing.Point(274, 11)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(62, 49)
        Me.btnExcluir.TabIndex = 4
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlterar.Image = Global.Agenda.My.Resources.Resources.NOTE14
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAlterar.Location = New System.Drawing.Point(186, 11)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(62, 49)
        Me.btnAlterar.TabIndex = 3
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnIncluir
        '
        Me.btnIncluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIncluir.Image = Global.Agenda.My.Resources.Resources.NOTE11
        Me.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnIncluir.Location = New System.Drawing.Point(96, 11)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(62, 49)
        Me.btnIncluir.TabIndex = 1
        Me.btnIncluir.Text = "Incluir"
        Me.btnIncluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Location = New System.Drawing.Point(28, 98)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtEmail.Size = New System.Drawing.Size(255, 20)
        Me.txtEmail.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 83)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "E-mail"
        '
        'cboTipoUsuario
        '
        Me.cboTipoUsuario.FormattingEnabled = True
        Me.cboTipoUsuario.Items.AddRange(New Object() {"Administrador", "Usuário comum"})
        Me.cboTipoUsuario.Location = New System.Drawing.Point(26, 143)
        Me.cboTipoUsuario.Name = "cboTipoUsuario"
        Me.cboTipoUsuario.Size = New System.Drawing.Size(172, 21)
        Me.cboTipoUsuario.TabIndex = 9
        Me.cboTipoUsuario.Text = "Selecione"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 127)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Tipo Usuário"
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(26, 190)
        Me.txtLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLogin.MaxLength = 50
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(255, 20)
        Me.txtLogin.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 176)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Login"
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.CancelButton = Me.btnSair
        Me.ClientSize = New System.Drawing.Size(439, 529)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.grpEdicaoUsuario)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnIncluir)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuários"
        Me.GroupBox1.ResumeLayout(False)
        Me.grpEdicaoUsuario.ResumeLayout(False)
        Me.grpEdicaoUsuario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnIncluir As Button
    Friend WithEvents btnAlterar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstvUsuarios As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents Nome As ColumnHeader
    Friend WithEvents Ativo As ColumnHeader
    Friend WithEvents grpEdicaoUsuario As GroupBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chkAtivo As CheckBox
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents btnSair As Button
    Friend WithEvents senha As ColumnHeader
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLogin As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboTipoUsuario As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmail As TextBox
End Class
