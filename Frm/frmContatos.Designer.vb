<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContatos
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
        Me.lstvContatos = New System.Windows.Forms.ListView()
        Me.Codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Atividade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Telefones = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NovoCodigoContato = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.endereco = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bairro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cidade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.uf = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cep = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.site = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pessoaContato = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.observacoes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dataNasc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TipoPessoa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnMigrarContatos = New System.Windows.Forms.Button()
        Me.btnUsuario = New System.Windows.Forms.Button()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.btnLerXML = New System.Windows.Forms.Button()
        Me.btnGerarXml = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnIncluir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbPesqGeral = New System.Windows.Forms.RadioButton()
        Me.rbPesqAtividade = New System.Windows.Forms.RadioButton()
        Me.rbPesqNome = New System.Windows.Forms.RadioButton()
        Me.txtPesquisar = New System.Windows.Forms.TextBox()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.chkQualquerParteDoNome = New System.Windows.Forms.CheckBox()
        Me.lstvContatosLidosXML = New System.Windows.Forms.ListView()
        Me.xmlCodigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xmlNome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xmlEndereco = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xmlBairro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xmlCidade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xmlUF = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xmlCep = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xmlPaginaWeb = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xmlEmail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xmlPessoaContato = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xmlAtividade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xmlObs = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.xmlCodigoNovo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstvTelefones = New System.Windows.Forms.ListView()
        Me.idContatoTelefone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NumeroTelefone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TipoTelefone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Principal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CodigoContato = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.descricao = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Comando = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstvEmails = New System.Windows.Forms.ListView()
        Me.idContatoEmail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.flagPrincipal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.eml_CodigoContato = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSair = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstvContatos
        '
        Me.lstvContatos.AllowColumnReorder = True
        Me.lstvContatos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Codigo, Me.Nome, Me.Atividade, Me.Telefones, Me.NovoCodigoContato, Me.endereco, Me.bairro, Me.cidade, Me.uf, Me.cep, Me.site, Me.pessoaContato, Me.observacoes, Me.dataNasc, Me.TipoPessoa})
        Me.lstvContatos.FullRowSelect = True
        Me.lstvContatos.HideSelection = False
        Me.lstvContatos.Location = New System.Drawing.Point(18, 137)
        Me.lstvContatos.Name = "lstvContatos"
        Me.lstvContatos.Size = New System.Drawing.Size(1278, 534)
        Me.lstvContatos.TabIndex = 1
        Me.lstvContatos.UseCompatibleStateImageBehavior = False
        Me.lstvContatos.View = System.Windows.Forms.View.Details
        '
        'Codigo
        '
        Me.Codigo.Text = "Código"
        Me.Codigo.Width = 0
        '
        'Nome
        '
        Me.Nome.Text = "Nome"
        Me.Nome.Width = 350
        '
        'Atividade
        '
        Me.Atividade.DisplayIndex = 3
        Me.Atividade.Text = "Atividade/Ocupação"
        Me.Atividade.Width = 250
        '
        'Telefones
        '
        Me.Telefones.DisplayIndex = 4
        Me.Telefones.Text = "Telefones"
        Me.Telefones.Width = 400
        '
        'NovoCodigoContato
        '
        Me.NovoCodigoContato.DisplayIndex = 5
        Me.NovoCodigoContato.Text = "Cód.Contato inserido pelo XML"
        Me.NovoCodigoContato.Width = 0
        '
        'endereco
        '
        Me.endereco.DisplayIndex = 6
        Me.endereco.Text = "Endereço"
        Me.endereco.Width = 200
        '
        'bairro
        '
        Me.bairro.DisplayIndex = 7
        Me.bairro.Text = "Bairro"
        Me.bairro.Width = 150
        '
        'cidade
        '
        Me.cidade.DisplayIndex = 8
        Me.cidade.Text = "Cidade"
        Me.cidade.Width = 150
        '
        'uf
        '
        Me.uf.DisplayIndex = 9
        Me.uf.Text = "UF"
        Me.uf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.uf.Width = 40
        '
        'cep
        '
        Me.cep.DisplayIndex = 10
        Me.cep.Text = "Cep"
        Me.cep.Width = 75
        '
        'site
        '
        Me.site.DisplayIndex = 11
        Me.site.Text = "Site"
        Me.site.Width = 200
        '
        'pessoaContato
        '
        Me.pessoaContato.DisplayIndex = 12
        Me.pessoaContato.Text = "Pessoa de Contato"
        Me.pessoaContato.Width = 150
        '
        'observacoes
        '
        Me.observacoes.DisplayIndex = 13
        Me.observacoes.Text = "Observações"
        Me.observacoes.Width = 200
        '
        'dataNasc
        '
        Me.dataNasc.DisplayIndex = 14
        Me.dataNasc.Text = "Data Nasc."
        Me.dataNasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.dataNasc.Width = 80
        '
        'TipoPessoa
        '
        Me.TipoPessoa.DisplayIndex = 2
        Me.TipoPessoa.Text = "Tipo"
        Me.TipoPessoa.Width = 80
        '
        'btnMigrarContatos
        '
        Me.btnMigrarContatos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMigrarContatos.Image = Global.Agenda.My.Resources.Resources.pessoas
        Me.btnMigrarContatos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMigrarContatos.Location = New System.Drawing.Point(523, 6)
        Me.btnMigrarContatos.Name = "btnMigrarContatos"
        Me.btnMigrarContatos.Size = New System.Drawing.Size(77, 55)
        Me.btnMigrarContatos.TabIndex = 14
        Me.btnMigrarContatos.Text = "Migrar"
        Me.btnMigrarContatos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnMigrarContatos, "Migrar contatos para nova estrutura")
        Me.btnMigrarContatos.UseVisualStyleBackColor = True
        '
        'btnUsuario
        '
        Me.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUsuario.Image = Global.Agenda.My.Resources.Resources.silhueta_do_usuario_318_79814
        Me.btnUsuario.Location = New System.Drawing.Point(606, 6)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Size = New System.Drawing.Size(77, 55)
        Me.btnUsuario.TabIndex = 13
        Me.btnUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnUsuario, "Usuários do sistema")
        Me.btnUsuario.UseVisualStyleBackColor = True
        Me.btnUsuario.Visible = False
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPesquisar.Image = Global.Agenda.My.Resources.Resources.BINOCULR
        Me.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPesquisar.Location = New System.Drawing.Point(311, 31)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(87, 29)
        Me.btnPesquisar.TabIndex = 8
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnPesquisar, "Pesquisar Contato pelo Nome")
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'btnLerXML
        '
        Me.btnLerXML.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLerXML.Image = Global.Agenda.My.Resources.Resources.ARW10NE
        Me.btnLerXML.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLerXML.Location = New System.Drawing.Point(440, 6)
        Me.btnLerXML.Name = "btnLerXML"
        Me.btnLerXML.Size = New System.Drawing.Size(77, 55)
        Me.btnLerXML.TabIndex = 6
        Me.btnLerXML.Text = "Ler XML"
        Me.btnLerXML.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnLerXML, "Importar Contatos de Arquivo XML")
        Me.btnLerXML.UseVisualStyleBackColor = True
        '
        'btnGerarXml
        '
        Me.btnGerarXml.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGerarXml.Image = Global.Agenda.My.Resources.Resources.ARW10SE
        Me.btnGerarXml.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGerarXml.Location = New System.Drawing.Point(360, 6)
        Me.btnGerarXml.Name = "btnGerarXml"
        Me.btnGerarXml.Size = New System.Drawing.Size(74, 55)
        Me.btnGerarXml.TabIndex = 5
        Me.btnGerarXml.Text = "Gerar XML"
        Me.btnGerarXml.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnGerarXml, "Gerar arquivo XML com Contatos")
        Me.btnGerarXml.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.Image = Global.Agenda.My.Resources.Resources.printer
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(292, 6)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(62, 55)
        Me.btnImprimir.TabIndex = 4
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnImprimir, "Imprimir Relatório de Contatos")
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.Image = Global.Agenda.My.Resources.Resources.WASTE
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExcluir.Location = New System.Drawing.Point(224, 6)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(62, 55)
        Me.btnExcluir.TabIndex = 3
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnExcluir, "Excluir Contato")
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlterar.Image = Global.Agenda.My.Resources.Resources.NOTE14
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAlterar.Location = New System.Drawing.Point(156, 6)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(62, 55)
        Me.btnAlterar.TabIndex = 2
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnAlterar, "Alterar Contato")
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnIncluir
        '
        Me.btnIncluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIncluir.Image = Global.Agenda.My.Resources.Resources.NOTE11
        Me.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnIncluir.Location = New System.Drawing.Point(88, 6)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(62, 55)
        Me.btnIncluir.TabIndex = 0
        Me.btnIncluir.Text = "Incluir"
        Me.btnIncluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnIncluir, "Incluir Novo Contato")
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbPesqGeral)
        Me.GroupBox1.Controls.Add(Me.rbPesqAtividade)
        Me.GroupBox1.Controls.Add(Me.rbPesqNome)
        Me.GroupBox1.Controls.Add(Me.btnPesquisar)
        Me.GroupBox1.Controls.Add(Me.txtPesquisar)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 67)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesquisar"
        '
        'rbPesqGeral
        '
        Me.rbPesqGeral.AutoSize = True
        Me.rbPesqGeral.Location = New System.Drawing.Point(352, 10)
        Me.rbPesqGeral.Name = "rbPesqGeral"
        Me.rbPesqGeral.Size = New System.Drawing.Size(50, 17)
        Me.rbPesqGeral.TabIndex = 11
        Me.rbPesqGeral.Text = "Geral"
        Me.rbPesqGeral.UseVisualStyleBackColor = True
        '
        'rbPesqAtividade
        '
        Me.rbPesqAtividade.AutoSize = True
        Me.rbPesqAtividade.Location = New System.Drawing.Point(282, 10)
        Me.rbPesqAtividade.Name = "rbPesqAtividade"
        Me.rbPesqAtividade.Size = New System.Drawing.Size(69, 17)
        Me.rbPesqAtividade.TabIndex = 10
        Me.rbPesqAtividade.Text = "Atividade"
        Me.rbPesqAtividade.UseVisualStyleBackColor = True
        '
        'rbPesqNome
        '
        Me.rbPesqNome.AutoSize = True
        Me.rbPesqNome.Checked = True
        Me.rbPesqNome.Location = New System.Drawing.Point(228, 10)
        Me.rbPesqNome.Name = "rbPesqNome"
        Me.rbPesqNome.Size = New System.Drawing.Size(53, 17)
        Me.rbPesqNome.TabIndex = 9
        Me.rbPesqNome.TabStop = True
        Me.rbPesqNome.Text = "Nome"
        Me.rbPesqNome.UseVisualStyleBackColor = True
        '
        'txtPesquisar
        '
        Me.txtPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPesquisar.Location = New System.Drawing.Point(6, 39)
        Me.txtPesquisar.Name = "txtPesquisar"
        Me.txtPesquisar.Size = New System.Drawing.Size(284, 20)
        Me.txtPesquisar.TabIndex = 0
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'chkQualquerParteDoNome
        '
        Me.chkQualquerParteDoNome.AutoSize = True
        Me.chkQualquerParteDoNome.Checked = True
        Me.chkQualquerParteDoNome.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkQualquerParteDoNome.Location = New System.Drawing.Point(26, 85)
        Me.chkQualquerParteDoNome.Margin = New System.Windows.Forms.Padding(2)
        Me.chkQualquerParteDoNome.Name = "chkQualquerParteDoNome"
        Me.chkQualquerParteDoNome.Size = New System.Drawing.Size(140, 17)
        Me.chkQualquerParteDoNome.TabIndex = 9
        Me.chkQualquerParteDoNome.Text = "Qualquer parte do nome"
        Me.chkQualquerParteDoNome.UseVisualStyleBackColor = True
        '
        'lstvContatosLidosXML
        '
        Me.lstvContatosLidosXML.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.xmlCodigo, Me.xmlNome, Me.xmlEndereco, Me.xmlBairro, Me.xmlCidade, Me.xmlUF, Me.xmlCep, Me.xmlPaginaWeb, Me.xmlEmail, Me.xmlPessoaContato, Me.xmlAtividade, Me.xmlObs, Me.xmlCodigoNovo})
        Me.lstvContatosLidosXML.HideSelection = False
        Me.lstvContatosLidosXML.Location = New System.Drawing.Point(1309, 24)
        Me.lstvContatosLidosXML.Name = "lstvContatosLidosXML"
        Me.lstvContatosLidosXML.Size = New System.Drawing.Size(457, 229)
        Me.lstvContatosLidosXML.TabIndex = 10
        Me.lstvContatosLidosXML.UseCompatibleStateImageBehavior = False
        Me.lstvContatosLidosXML.View = System.Windows.Forms.View.Details
        Me.lstvContatosLidosXML.Visible = False
        '
        'xmlCodigo
        '
        Me.xmlCodigo.Text = "Código"
        '
        'xmlNome
        '
        Me.xmlNome.Text = "Nome"
        '
        'xmlEndereco
        '
        Me.xmlEndereco.Text = "Endereço"
        '
        'xmlBairro
        '
        Me.xmlBairro.Text = "Bairro"
        '
        'xmlCidade
        '
        Me.xmlCidade.Text = "Cidade"
        '
        'xmlUF
        '
        Me.xmlUF.Text = "UF"
        '
        'xmlCep
        '
        Me.xmlCep.Text = "Cep"
        '
        'xmlPaginaWeb
        '
        Me.xmlPaginaWeb.Text = "Site"
        '
        'xmlEmail
        '
        Me.xmlEmail.Text = "E-mail"
        '
        'xmlPessoaContato
        '
        Me.xmlPessoaContato.Text = "Pessoa Contato"
        '
        'xmlAtividade
        '
        Me.xmlAtividade.Text = "Atividade"
        '
        'xmlObs
        '
        Me.xmlObs.Text = "OBS"
        '
        'xmlCodigoNovo
        '
        Me.xmlCodigoNovo.Text = "Código novo"
        '
        'lstvTelefones
        '
        Me.lstvTelefones.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idContatoTelefone, Me.NumeroTelefone, Me.TipoTelefone, Me.Principal, Me.CodigoContato, Me.descricao, Me.Comando})
        Me.lstvTelefones.FullRowSelect = True
        Me.lstvTelefones.HideSelection = False
        Me.lstvTelefones.Location = New System.Drawing.Point(1309, 494)
        Me.lstvTelefones.Name = "lstvTelefones"
        Me.lstvTelefones.Size = New System.Drawing.Size(262, 229)
        Me.lstvTelefones.TabIndex = 11
        Me.lstvTelefones.UseCompatibleStateImageBehavior = False
        Me.lstvTelefones.View = System.Windows.Forms.View.Details
        Me.lstvTelefones.Visible = False
        '
        'idContatoTelefone
        '
        Me.idContatoTelefone.Text = "ID"
        '
        'NumeroTelefone
        '
        Me.NumeroTelefone.Text = "Nº Fone"
        Me.NumeroTelefone.Width = 150
        '
        'TipoTelefone
        '
        Me.TipoTelefone.Text = "Tipo"
        Me.TipoTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TipoTelefone.Width = 50
        '
        'Principal
        '
        Me.Principal.Text = "Principal"
        Me.Principal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Principal.Width = 55
        '
        'CodigoContato
        '
        Me.CodigoContato.Text = "Código Contato"
        Me.CodigoContato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CodigoContato.Width = 100
        '
        'descricao
        '
        Me.descricao.Text = "Descrição"
        Me.descricao.Width = 100
        '
        'Comando
        '
        Me.Comando.Text = "CMD"
        Me.Comando.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Comando.Width = 40
        '
        'lstvEmails
        '
        Me.lstvEmails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idContatoEmail, Me.Email, Me.flagPrincipal, Me.eml_CodigoContato})
        Me.lstvEmails.FullRowSelect = True
        Me.lstvEmails.HideSelection = False
        Me.lstvEmails.Location = New System.Drawing.Point(1309, 259)
        Me.lstvEmails.Name = "lstvEmails"
        Me.lstvEmails.Size = New System.Drawing.Size(322, 229)
        Me.lstvEmails.TabIndex = 12
        Me.lstvEmails.UseCompatibleStateImageBehavior = False
        Me.lstvEmails.View = System.Windows.Forms.View.Details
        Me.lstvEmails.Visible = False
        '
        'idContatoEmail
        '
        Me.idContatoEmail.Text = "ID"
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
        'eml_CodigoContato
        '
        Me.eml_CodigoContato.Text = "Código Contato"
        Me.eml_CodigoContato.Width = 100
        '
        'btnSair
        '
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSair.Image = Global.Agenda.My.Resources.Resources.EXITS1
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSair.Location = New System.Drawing.Point(18, 6)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(62, 55)
        Me.btnSair.TabIndex = 7
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'frmContatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.CancelButton = Me.btnSair
        Me.ClientSize = New System.Drawing.Size(1324, 686)
        Me.Controls.Add(Me.btnMigrarContatos)
        Me.Controls.Add(Me.btnUsuario)
        Me.Controls.Add(Me.lstvEmails)
        Me.Controls.Add(Me.lstvTelefones)
        Me.Controls.Add(Me.lstvContatosLidosXML)
        Me.Controls.Add(Me.chkQualquerParteDoNome)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnLerXML)
        Me.Controls.Add(Me.btnGerarXml)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.lstvContatos)
        Me.Controls.Add(Me.btnIncluir)
        Me.Name = "frmContatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contatos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnIncluir As System.Windows.Forms.Button
    Friend WithEvents lstvContatos As System.Windows.Forms.ListView
    Friend WithEvents Codigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Nome As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnGerarXml As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnLerXML As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPesquisar As System.Windows.Forms.Button
    Friend WithEvents txtPesquisar As System.Windows.Forms.TextBox
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Atividade As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkQualquerParteDoNome As System.Windows.Forms.CheckBox
    Friend WithEvents Telefones As System.Windows.Forms.ColumnHeader
    Friend WithEvents NovoCodigoContato As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstvContatosLidosXML As System.Windows.Forms.ListView
    Friend WithEvents xmlCodigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents xmlNome As System.Windows.Forms.ColumnHeader
    Friend WithEvents xmlEndereco As System.Windows.Forms.ColumnHeader
    Friend WithEvents xmlBairro As System.Windows.Forms.ColumnHeader
    Friend WithEvents xmlCidade As System.Windows.Forms.ColumnHeader
    Friend WithEvents xmlUF As System.Windows.Forms.ColumnHeader
    Friend WithEvents xmlCep As System.Windows.Forms.ColumnHeader
    Friend WithEvents xmlPaginaWeb As System.Windows.Forms.ColumnHeader
    Friend WithEvents xmlEmail As System.Windows.Forms.ColumnHeader
    Friend WithEvents xmlPessoaContato As System.Windows.Forms.ColumnHeader
    Friend WithEvents xmlAtividade As System.Windows.Forms.ColumnHeader
    Friend WithEvents xmlObs As System.Windows.Forms.ColumnHeader
    Friend WithEvents xmlCodigoNovo As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstvTelefones As System.Windows.Forms.ListView
    Friend WithEvents idContatoTelefone As System.Windows.Forms.ColumnHeader
    Friend WithEvents NumeroTelefone As System.Windows.Forms.ColumnHeader
    Friend WithEvents TipoTelefone As System.Windows.Forms.ColumnHeader
    Friend WithEvents Principal As System.Windows.Forms.ColumnHeader
    Friend WithEvents CodigoContato As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstvEmails As System.Windows.Forms.ListView
    Friend WithEvents idContatoEmail As System.Windows.Forms.ColumnHeader
    Friend WithEvents Email As System.Windows.Forms.ColumnHeader
    Friend WithEvents flagPrincipal As System.Windows.Forms.ColumnHeader
    Friend WithEvents eml_CodigoContato As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnUsuario As Button
    Friend WithEvents btnMigrarContatos As Button
    Friend WithEvents descricao As ColumnHeader
    Friend WithEvents Comando As ColumnHeader
    Friend WithEvents endereco As ColumnHeader
    Friend WithEvents bairro As ColumnHeader
    Friend WithEvents cidade As ColumnHeader
    Friend WithEvents uf As ColumnHeader
    Friend WithEvents cep As ColumnHeader
    Friend WithEvents site As ColumnHeader
    Friend WithEvents pessoaContato As ColumnHeader
    Friend WithEvents observacoes As ColumnHeader
    Friend WithEvents dataNasc As ColumnHeader
    Friend WithEvents TipoPessoa As ColumnHeader
    Friend WithEvents rbPesqGeral As RadioButton
    Friend WithEvents rbPesqAtividade As RadioButton
    Friend WithEvents rbPesqNome As RadioButton
End Class
