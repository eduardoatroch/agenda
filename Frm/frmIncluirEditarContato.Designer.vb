<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncluirEditarContato
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cboUF = New System.Windows.Forms.ComboBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSite = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPessoaContato = New System.Windows.Forms.TextBox()
        Me.txtAtividade = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtObservacao = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnExcluirTelefone = New System.Windows.Forms.Button()
        Me.btnIncluirTelefone = New System.Windows.Forms.Button()
        Me.btnExcluirEmail = New System.Windows.Forms.Button()
        Me.btnIncluirEmail = New System.Windows.Forms.Button()
        Me.btnSalvarEmail = New System.Windows.Forms.Button()
        Me.btnCancelarEdicao = New System.Windows.Forms.Button()
        Me.btnAlterarEmail = New System.Windows.Forms.Button()
        Me.btnAlterarTelefone = New System.Windows.Forms.Button()
        Me.btnSalvarTelefone = New System.Windows.Forms.Button()
        Me.btnCancelarEdicaoTelefone = New System.Windows.Forms.Button()
        Me.grpTelefones = New System.Windows.Forms.GroupBox()
        Me.lstvTelefones = New System.Windows.Forms.ListView()
        Me.idContatoTelefone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NumeroTelefone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TipoTelefone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Principal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Comando = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Descricao = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grpEmail = New System.Windows.Forms.GroupBox()
        Me.lstvEmails = New System.Windows.Forms.ListView()
        Me.idContatoEmail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.flagPrincipal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EmailComando = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grpEdicaoEmail = New System.Windows.Forms.GroupBox()
        Me.chkEmailPrincipal = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.mtxtDataNascimento = New System.Windows.Forms.MaskedTextBox()
        Me.mtxCep = New System.Windows.Forms.MaskedTextBox()
        Me.grpEdicaoTelefone = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkTelefonePrincipal = New System.Windows.Forms.CheckBox()
        Me.txtFinalidadeTelefone = New System.Windows.Forms.TextBox()
        Me.cboTipoTelefone = New System.Windows.Forms.ComboBox()
        Me.txtNumeroTelefone = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cboTipoPessoa = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.grpTelefones.SuspendLayout()
        Me.grpEmail.SuspendLayout()
        Me.grpEdicaoEmail.SuspendLayout()
        Me.grpEdicaoTelefone.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboUF
        '
        Me.cboUF.FormattingEnabled = True
        Me.cboUF.Items.AddRange(New Object() {"AC - Acre", "AL - Alagoas", "AM - Amazonas", "AP - Amapá", "BA - Bahia", "CE - Ceará", "DF - Distrito Federal", "ES - Espírito Santo", "GO - Goiás", "MA - Maranhão", "MG - Minas Gerais", "MS - Mato Grosso do Sul", "MT - Mato Grosso", "PA - Pará", "PB - Paraíba", "PE - Pernambuco", "PI - Piauí", "PR - Paraná", "RJ - Rio de Janeiro", "RN - Rio Grande do Norte", "RO - Rondônia", "RR - Roraima", "RS - Rio Grande do Sul", "SC - Santa Catarina", "SE - Sergipe", "SP - São Paulo", "TO - Tocantins"})
        Me.cboUF.Location = New System.Drawing.Point(122, 155)
        Me.cboUF.MaxLength = 2
        Me.cboUF.Name = "cboUF"
        Me.cboUF.Size = New System.Drawing.Size(207, 21)
        Me.cboUF.TabIndex = 5
        '
        'txtNome
        '
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.Location = New System.Drawing.Point(122, 30)
        Me.txtNome.MaxLength = 100
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(422, 20)
        Me.txtNome.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(81, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nome:"
        '
        'txtEndereco
        '
        Me.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEndereco.Location = New System.Drawing.Point(122, 80)
        Me.txtEndereco.MaxLength = 100
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(422, 20)
        Me.txtEndereco.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(63, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Endereço:"
        '
        'txtCidade
        '
        Me.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCidade.Location = New System.Drawing.Point(122, 130)
        Me.txtCidade.MaxLength = 50
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(209, 20)
        Me.txtCidade.TabIndex = 4
        '
        'txtBairro
        '
        Me.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBairro.Location = New System.Drawing.Point(122, 105)
        Me.txtBairro.MaxLength = 50
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(279, 20)
        Me.txtBairro.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(82, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Bairro:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(76, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Cidade:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(96, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "UF:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(88, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "CEP:"
        '
        'txtSite
        '
        Me.txtSite.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtSite.Location = New System.Drawing.Point(122, 227)
        Me.txtSite.MaxLength = 200
        Me.txtSite.Name = "txtSite"
        Me.txtSite.Size = New System.Drawing.Size(422, 20)
        Me.txtSite.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(6, 230)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Página na WEB (Site):"
        '
        'txtPessoaContato
        '
        Me.txtPessoaContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPessoaContato.Location = New System.Drawing.Point(122, 252)
        Me.txtPessoaContato.MaxLength = 150
        Me.txtPessoaContato.Name = "txtPessoaContato"
        Me.txtPessoaContato.Size = New System.Drawing.Size(422, 20)
        Me.txtPessoaContato.TabIndex = 9
        '
        'txtAtividade
        '
        Me.txtAtividade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAtividade.Location = New System.Drawing.Point(122, 275)
        Me.txtAtividade.MaxLength = 200
        Me.txtAtividade.Name = "txtAtividade"
        Me.txtAtividade.Size = New System.Drawing.Size(422, 20)
        Me.txtAtividade.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(11, 255)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Pessoa para Contato:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(18, 278)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Profissão/Atividade:"
        '
        'txtObservacao
        '
        Me.txtObservacao.Location = New System.Drawing.Point(35, 451)
        Me.txtObservacao.MaxLength = 1000
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(929, 145)
        Me.txtObservacao.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(34, 435)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Observações:"
        '
        'btnSair
        '
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSair.Image = Global.Agenda.My.Resources.Resources.EXITS1
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSair.Location = New System.Drawing.Point(982, 542)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(58, 54)
        Me.btnSair.TabIndex = 12
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnSair, "Sair")
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.Image = Global.Agenda.My.Resources.Resources.DISK04
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalvar.Location = New System.Drawing.Point(982, 482)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(58, 54)
        Me.btnSalvar.TabIndex = 11
        Me.btnSalvar.Text = "Salvar Contato"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnSalvar, "Salvar Contato")
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnExcluirTelefone
        '
        Me.btnExcluirTelefone.Location = New System.Drawing.Point(492, 73)
        Me.btnExcluirTelefone.Name = "btnExcluirTelefone"
        Me.btnExcluirTelefone.Size = New System.Drawing.Size(59, 23)
        Me.btnExcluirTelefone.TabIndex = 15
        Me.btnExcluirTelefone.Text = "Excluir"
        Me.ToolTip1.SetToolTip(Me.btnExcluirTelefone, "Excluir telefone")
        Me.btnExcluirTelefone.UseVisualStyleBackColor = True
        '
        'btnIncluirTelefone
        '
        Me.btnIncluirTelefone.Location = New System.Drawing.Point(492, 17)
        Me.btnIncluirTelefone.Name = "btnIncluirTelefone"
        Me.btnIncluirTelefone.Size = New System.Drawing.Size(59, 23)
        Me.btnIncluirTelefone.TabIndex = 13
        Me.btnIncluirTelefone.Text = "Incluir"
        Me.ToolTip1.SetToolTip(Me.btnIncluirTelefone, "Incluir telefone")
        Me.btnIncluirTelefone.UseVisualStyleBackColor = True
        '
        'btnExcluirEmail
        '
        Me.btnExcluirEmail.Location = New System.Drawing.Point(352, 73)
        Me.btnExcluirEmail.Name = "btnExcluirEmail"
        Me.btnExcluirEmail.Size = New System.Drawing.Size(59, 23)
        Me.btnExcluirEmail.TabIndex = 19
        Me.btnExcluirEmail.Text = "Excluir"
        Me.ToolTip1.SetToolTip(Me.btnExcluirEmail, "Excluir E-mail")
        Me.btnExcluirEmail.UseVisualStyleBackColor = True
        '
        'btnIncluirEmail
        '
        Me.btnIncluirEmail.Location = New System.Drawing.Point(352, 17)
        Me.btnIncluirEmail.Name = "btnIncluirEmail"
        Me.btnIncluirEmail.Size = New System.Drawing.Size(59, 23)
        Me.btnIncluirEmail.TabIndex = 17
        Me.btnIncluirEmail.Text = "Incluir"
        Me.ToolTip1.SetToolTip(Me.btnIncluirEmail, "Incluir E-mail")
        Me.btnIncluirEmail.UseVisualStyleBackColor = True
        '
        'btnSalvarEmail
        '
        Me.btnSalvarEmail.Location = New System.Drawing.Point(286, 95)
        Me.btnSalvarEmail.Name = "btnSalvarEmail"
        Me.btnSalvarEmail.Size = New System.Drawing.Size(59, 23)
        Me.btnSalvarEmail.TabIndex = 2
        Me.btnSalvarEmail.Text = "Confirmar"
        Me.ToolTip1.SetToolTip(Me.btnSalvarEmail, "Incluir E-mail")
        Me.btnSalvarEmail.UseVisualStyleBackColor = True
        '
        'btnCancelarEdicao
        '
        Me.btnCancelarEdicao.Location = New System.Drawing.Point(351, 95)
        Me.btnCancelarEdicao.Name = "btnCancelarEdicao"
        Me.btnCancelarEdicao.Size = New System.Drawing.Size(59, 23)
        Me.btnCancelarEdicao.TabIndex = 3
        Me.btnCancelarEdicao.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.btnCancelarEdicao, "Incluir E-mail")
        Me.btnCancelarEdicao.UseVisualStyleBackColor = True
        '
        'btnAlterarEmail
        '
        Me.btnAlterarEmail.Location = New System.Drawing.Point(352, 44)
        Me.btnAlterarEmail.Name = "btnAlterarEmail"
        Me.btnAlterarEmail.Size = New System.Drawing.Size(59, 23)
        Me.btnAlterarEmail.TabIndex = 18
        Me.btnAlterarEmail.Text = "Alterar"
        Me.ToolTip1.SetToolTip(Me.btnAlterarEmail, "Incluir E-mail")
        Me.btnAlterarEmail.UseVisualStyleBackColor = True
        '
        'btnAlterarTelefone
        '
        Me.btnAlterarTelefone.Location = New System.Drawing.Point(492, 44)
        Me.btnAlterarTelefone.Name = "btnAlterarTelefone"
        Me.btnAlterarTelefone.Size = New System.Drawing.Size(59, 23)
        Me.btnAlterarTelefone.TabIndex = 14
        Me.btnAlterarTelefone.Text = "Alterar"
        Me.ToolTip1.SetToolTip(Me.btnAlterarTelefone, "Alterar telefone")
        Me.btnAlterarTelefone.UseVisualStyleBackColor = True
        '
        'btnSalvarTelefone
        '
        Me.btnSalvarTelefone.Location = New System.Drawing.Point(288, 120)
        Me.btnSalvarTelefone.Name = "btnSalvarTelefone"
        Me.btnSalvarTelefone.Size = New System.Drawing.Size(59, 23)
        Me.btnSalvarTelefone.TabIndex = 4
        Me.btnSalvarTelefone.Text = "Confirmar"
        Me.ToolTip1.SetToolTip(Me.btnSalvarTelefone, "Incluir E-mail")
        Me.btnSalvarTelefone.UseVisualStyleBackColor = True
        '
        'btnCancelarEdicaoTelefone
        '
        Me.btnCancelarEdicaoTelefone.Location = New System.Drawing.Point(353, 120)
        Me.btnCancelarEdicaoTelefone.Name = "btnCancelarEdicaoTelefone"
        Me.btnCancelarEdicaoTelefone.Size = New System.Drawing.Size(59, 23)
        Me.btnCancelarEdicaoTelefone.TabIndex = 5
        Me.btnCancelarEdicaoTelefone.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.btnCancelarEdicaoTelefone, "Incluir E-mail")
        Me.btnCancelarEdicaoTelefone.UseVisualStyleBackColor = True
        '
        'grpTelefones
        '
        Me.grpTelefones.Controls.Add(Me.btnAlterarTelefone)
        Me.grpTelefones.Controls.Add(Me.btnExcluirTelefone)
        Me.grpTelefones.Controls.Add(Me.btnIncluirTelefone)
        Me.grpTelefones.Controls.Add(Me.lstvTelefones)
        Me.grpTelefones.Location = New System.Drawing.Point(35, 300)
        Me.grpTelefones.Name = "grpTelefones"
        Me.grpTelefones.Size = New System.Drawing.Size(565, 134)
        Me.grpTelefones.TabIndex = 12
        Me.grpTelefones.TabStop = False
        Me.grpTelefones.Text = " Telefones (Clicar na coluna pra ordenar)"
        '
        'lstvTelefones
        '
        Me.lstvTelefones.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idContatoTelefone, Me.NumeroTelefone, Me.TipoTelefone, Me.Principal, Me.Comando, Me.Descricao})
        Me.lstvTelefones.FullRowSelect = True
        Me.lstvTelefones.HideSelection = False
        Me.lstvTelefones.Location = New System.Drawing.Point(6, 17)
        Me.lstvTelefones.Name = "lstvTelefones"
        Me.lstvTelefones.Size = New System.Drawing.Size(478, 111)
        Me.lstvTelefones.TabIndex = 0
        Me.lstvTelefones.UseCompatibleStateImageBehavior = False
        Me.lstvTelefones.View = System.Windows.Forms.View.Details
        '
        'idContatoTelefone
        '
        Me.idContatoTelefone.Text = "ID"
        Me.idContatoTelefone.Width = 0
        '
        'NumeroTelefone
        '
        Me.NumeroTelefone.Text = "Nº Fone"
        Me.NumeroTelefone.Width = 120
        '
        'TipoTelefone
        '
        Me.TipoTelefone.DisplayIndex = 3
        Me.TipoTelefone.Text = "Tipo"
        Me.TipoTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TipoTelefone.Width = 50
        '
        'Principal
        '
        Me.Principal.DisplayIndex = 4
        Me.Principal.Text = "Principal"
        Me.Principal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Principal.Width = 55
        '
        'Comando
        '
        Me.Comando.DisplayIndex = 5
        Me.Comando.Text = "CMD"
        Me.Comando.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Comando.Width = 40
        '
        'Descricao
        '
        Me.Descricao.DisplayIndex = 2
        Me.Descricao.Text = "Descrição"
        Me.Descricao.Width = 200
        '
        'grpEmail
        '
        Me.grpEmail.Controls.Add(Me.btnAlterarEmail)
        Me.grpEmail.Controls.Add(Me.btnExcluirEmail)
        Me.grpEmail.Controls.Add(Me.btnIncluirEmail)
        Me.grpEmail.Controls.Add(Me.lstvEmails)
        Me.grpEmail.Location = New System.Drawing.Point(618, 300)
        Me.grpEmail.Name = "grpEmail"
        Me.grpEmail.Size = New System.Drawing.Size(422, 134)
        Me.grpEmail.TabIndex = 16
        Me.grpEmail.TabStop = False
        Me.grpEmail.Text = " E-mails "
        '
        'lstvEmails
        '
        Me.lstvEmails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idContatoEmail, Me.Email, Me.flagPrincipal, Me.EmailComando})
        Me.lstvEmails.FullRowSelect = True
        Me.lstvEmails.HideSelection = False
        Me.lstvEmails.Location = New System.Drawing.Point(6, 17)
        Me.lstvEmails.Name = "lstvEmails"
        Me.lstvEmails.Size = New System.Drawing.Size(340, 111)
        Me.lstvEmails.TabIndex = 0
        Me.lstvEmails.UseCompatibleStateImageBehavior = False
        Me.lstvEmails.View = System.Windows.Forms.View.Details
        '
        'idContatoEmail
        '
        Me.idContatoEmail.Text = "ID"
        Me.idContatoEmail.Width = 0
        '
        'Email
        '
        Me.Email.Text = "E-mail"
        Me.Email.Width = 240
        '
        'flagPrincipal
        '
        Me.flagPrincipal.Text = "Principal"
        Me.flagPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.flagPrincipal.Width = 55
        '
        'EmailComando
        '
        Me.EmailComando.Text = "CMD"
        Me.EmailComando.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.EmailComando.Width = 40
        '
        'grpEdicaoEmail
        '
        Me.grpEdicaoEmail.Controls.Add(Me.chkEmailPrincipal)
        Me.grpEdicaoEmail.Controls.Add(Me.Label7)
        Me.grpEdicaoEmail.Controls.Add(Me.btnCancelarEdicao)
        Me.grpEdicaoEmail.Controls.Add(Me.btnSalvarEmail)
        Me.grpEdicaoEmail.Controls.Add(Me.txtEmail)
        Me.grpEdicaoEmail.Location = New System.Drawing.Point(619, 163)
        Me.grpEdicaoEmail.Name = "grpEdicaoEmail"
        Me.grpEdicaoEmail.Size = New System.Drawing.Size(424, 132)
        Me.grpEdicaoEmail.TabIndex = 20
        Me.grpEdicaoEmail.TabStop = False
        Me.grpEdicaoEmail.Text = "Edição de E-mail"
        '
        'chkEmailPrincipal
        '
        Me.chkEmailPrincipal.AutoSize = True
        Me.chkEmailPrincipal.Location = New System.Drawing.Point(12, 88)
        Me.chkEmailPrincipal.Name = "chkEmailPrincipal"
        Me.chkEmailPrincipal.Size = New System.Drawing.Size(66, 17)
        Me.chkEmailPrincipal.TabIndex = 1
        Me.chkEmailPrincipal.Text = "Principal"
        Me.chkEmailPrincipal.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(8, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "E-Mail"
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Location = New System.Drawing.Point(11, 45)
        Me.txtEmail.MaxLength = 200
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(400, 20)
        Me.txtEmail.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(27, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Data Nascimento:"
        '
        'mtxtDataNascimento
        '
        Me.mtxtDataNascimento.Location = New System.Drawing.Point(122, 203)
        Me.mtxtDataNascimento.Margin = New System.Windows.Forms.Padding(2)
        Me.mtxtDataNascimento.Mask = "00/00/0000"
        Me.mtxtDataNascimento.Name = "mtxtDataNascimento"
        Me.mtxtDataNascimento.Size = New System.Drawing.Size(83, 20)
        Me.mtxtDataNascimento.TabIndex = 7
        Me.mtxtDataNascimento.ValidatingType = GetType(Date)
        '
        'mtxCep
        '
        Me.mtxCep.Location = New System.Drawing.Point(122, 180)
        Me.mtxCep.Mask = "00.000-000"
        Me.mtxCep.Name = "mtxCep"
        Me.mtxCep.Size = New System.Drawing.Size(70, 20)
        Me.mtxCep.TabIndex = 6
        '
        'grpEdicaoTelefone
        '
        Me.grpEdicaoTelefone.Controls.Add(Me.Label15)
        Me.grpEdicaoTelefone.Controls.Add(Me.Label11)
        Me.grpEdicaoTelefone.Controls.Add(Me.Label9)
        Me.grpEdicaoTelefone.Controls.Add(Me.btnCancelarEdicaoTelefone)
        Me.grpEdicaoTelefone.Controls.Add(Me.btnSalvarTelefone)
        Me.grpEdicaoTelefone.Controls.Add(Me.chkTelefonePrincipal)
        Me.grpEdicaoTelefone.Controls.Add(Me.txtFinalidadeTelefone)
        Me.grpEdicaoTelefone.Controls.Add(Me.cboTipoTelefone)
        Me.grpEdicaoTelefone.Controls.Add(Me.txtNumeroTelefone)
        Me.grpEdicaoTelefone.Location = New System.Drawing.Point(617, 5)
        Me.grpEdicaoTelefone.Name = "grpEdicaoTelefone"
        Me.grpEdicaoTelefone.Size = New System.Drawing.Size(426, 154)
        Me.grpEdicaoTelefone.TabIndex = 33
        Me.grpEdicaoTelefone.TabStop = False
        Me.grpEdicaoTelefone.Text = "Edição de Telefone"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(43, 89)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Finalidade:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Tipo do Telefone:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Nº do Telefone:"
        '
        'chkTelefonePrincipal
        '
        Me.chkTelefonePrincipal.AutoSize = True
        Me.chkTelefonePrincipal.Location = New System.Drawing.Point(32, 126)
        Me.chkTelefonePrincipal.Name = "chkTelefonePrincipal"
        Me.chkTelefonePrincipal.Size = New System.Drawing.Size(66, 17)
        Me.chkTelefonePrincipal.TabIndex = 3
        Me.chkTelefonePrincipal.Text = "Principal"
        Me.chkTelefonePrincipal.UseVisualStyleBackColor = True
        '
        'txtFinalidadeTelefone
        '
        Me.txtFinalidadeTelefone.Location = New System.Drawing.Point(104, 85)
        Me.txtFinalidadeTelefone.MaxLength = 50
        Me.txtFinalidadeTelefone.Name = "txtFinalidadeTelefone"
        Me.txtFinalidadeTelefone.Size = New System.Drawing.Size(309, 20)
        Me.txtFinalidadeTelefone.TabIndex = 2
        '
        'cboTipoTelefone
        '
        Me.cboTipoTelefone.FormattingEnabled = True
        Me.cboTipoTelefone.Items.AddRange(New Object() {"CELULAR", "COMERCIAL", "FAX", "RECADO", "RESIDENCIAL", "WHATSAPP"})
        Me.cboTipoTelefone.Location = New System.Drawing.Point(104, 52)
        Me.cboTipoTelefone.Name = "cboTipoTelefone"
        Me.cboTipoTelefone.Size = New System.Drawing.Size(167, 21)
        Me.cboTipoTelefone.TabIndex = 1
        Me.cboTipoTelefone.Text = "Selecione"
        '
        'txtNumeroTelefone
        '
        Me.txtNumeroTelefone.Location = New System.Drawing.Point(104, 21)
        Me.txtNumeroTelefone.MaxLength = 20
        Me.txtNumeroTelefone.Name = "txtNumeroTelefone"
        Me.txtNumeroTelefone.Size = New System.Drawing.Size(167, 20)
        Me.txtNumeroTelefone.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(51, 58)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 13)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Tipo Pessoa:"
        '
        'cboTipoPessoa
        '
        Me.cboTipoPessoa.FormattingEnabled = True
        Me.cboTipoPessoa.Items.AddRange(New Object() {"Física", "Jurídica"})
        Me.cboTipoPessoa.Location = New System.Drawing.Point(122, 54)
        Me.cboTipoPessoa.Name = "cboTipoPessoa"
        Me.cboTipoPessoa.Size = New System.Drawing.Size(207, 21)
        Me.cboTipoPessoa.TabIndex = 1
        Me.cboTipoPessoa.Text = "Selecione"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(98, 8)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(21, 13)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "ID:"
        '
        'txtID
        '
        Me.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtID.Location = New System.Drawing.Point(122, 5)
        Me.txtID.MaxLength = 100
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(422, 20)
        Me.txtID.TabIndex = 36
        '
        'frmIncluirEditarContato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.CancelButton = Me.btnSair
        Me.ClientSize = New System.Drawing.Size(1067, 603)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cboTipoPessoa)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.grpEdicaoTelefone)
        Me.Controls.Add(Me.mtxCep)
        Me.Controls.Add(Me.mtxtDataNascimento)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.grpEdicaoEmail)
        Me.Controls.Add(Me.grpEmail)
        Me.Controls.Add(Me.grpTelefones)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtObservacao)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtAtividade)
        Me.Controls.Add(Me.txtPessoaContato)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtSite)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.cboUF)
        Me.Controls.Add(Me.btnSalvar)
        Me.Name = "frmIncluirEditarContato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Incluir/Editar Contato"
        Me.grpTelefones.ResumeLayout(False)
        Me.grpEmail.ResumeLayout(False)
        Me.grpEdicaoEmail.ResumeLayout(False)
        Me.grpEdicaoEmail.PerformLayout()
        Me.grpEdicaoTelefone.ResumeLayout(False)
        Me.grpEdicaoTelefone.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents cboUF As System.Windows.Forms.ComboBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSite As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPessoaContato As System.Windows.Forms.TextBox
    Friend WithEvents txtAtividade As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtObservacao As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents grpTelefones As System.Windows.Forms.GroupBox
    Friend WithEvents btnExcluirTelefone As System.Windows.Forms.Button
    Friend WithEvents btnIncluirTelefone As System.Windows.Forms.Button
    Friend WithEvents lstvTelefones As System.Windows.Forms.ListView
    Friend WithEvents idContatoTelefone As System.Windows.Forms.ColumnHeader
    Friend WithEvents NumeroTelefone As System.Windows.Forms.ColumnHeader
    Friend WithEvents TipoTelefone As System.Windows.Forms.ColumnHeader
    Friend WithEvents Principal As System.Windows.Forms.ColumnHeader
    Friend WithEvents Comando As System.Windows.Forms.ColumnHeader
    Friend WithEvents grpEmail As System.Windows.Forms.GroupBox
    Friend WithEvents btnExcluirEmail As System.Windows.Forms.Button
    Friend WithEvents btnIncluirEmail As System.Windows.Forms.Button
    Friend WithEvents lstvEmails As System.Windows.Forms.ListView
    Friend WithEvents idContatoEmail As System.Windows.Forms.ColumnHeader
    Friend WithEvents Email As System.Windows.Forms.ColumnHeader
    Friend WithEvents flagPrincipal As System.Windows.Forms.ColumnHeader
    Friend WithEvents EmailComando As System.Windows.Forms.ColumnHeader
    Friend WithEvents grpEdicaoEmail As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnCancelarEdicao As System.Windows.Forms.Button
    Friend WithEvents btnSalvarEmail As System.Windows.Forms.Button
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents chkEmailPrincipal As System.Windows.Forms.CheckBox
    Friend WithEvents btnAlterarEmail As System.Windows.Forms.Button
    Friend WithEvents btnAlterarTelefone As System.Windows.Forms.Button
    Friend WithEvents Descricao As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents mtxtDataNascimento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxCep As MaskedTextBox
    Friend WithEvents grpEdicaoTelefone As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnCancelarEdicaoTelefone As Button
    Friend WithEvents btnSalvarTelefone As Button
    Friend WithEvents chkTelefonePrincipal As CheckBox
    Friend WithEvents txtFinalidadeTelefone As TextBox
    Friend WithEvents cboTipoTelefone As ComboBox
    Friend WithEvents txtNumeroTelefone As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents cboTipoPessoa As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtID As TextBox
End Class
