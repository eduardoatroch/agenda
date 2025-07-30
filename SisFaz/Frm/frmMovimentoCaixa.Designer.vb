<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimentoCaixa
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
        Me.components = New System.ComponentModel.Container
        Me.lstvMovimentoCaixa = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.DataBaixa = New System.Windows.Forms.ColumnHeader
        Me.ValorBaixado = New System.Windows.Forms.ColumnHeader
        Me.CodForn = New System.Windows.Forms.ColumnHeader
        Me.NomeFornec = New System.Windows.Forms.ColumnHeader
        Me.Historico = New System.Windows.Forms.ColumnHeader
        Me.Banco = New System.Windows.Forms.ColumnHeader
        Me.Agencia = New System.Windows.Forms.ColumnHeader
        Me.Conta = New System.Windows.Forms.ColumnHeader
        Me.Cheque = New System.Windows.Forms.ColumnHeader
        Me.Fazenda = New System.Windows.Forms.ColumnHeader
        Me.CodCap = New System.Windows.Forms.ColumnHeader
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSair = New System.Windows.Forms.Button
        Me.btnPesquisar = New System.Windows.Forms.Button
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnAlterar = New System.Windows.Forms.Button
        Me.btnIncluir = New System.Windows.Forms.Button
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbOrdemFazendaData = New System.Windows.Forms.RadioButton
        Me.rbOrdemValor = New System.Windows.Forms.RadioButton
        Me.rbOrdemData = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbFiltroFazenda = New System.Windows.Forms.RadioButton
        Me.rbFiltroValor = New System.Windows.Forms.RadioButton
        Me.rbFiltroPeriodo = New System.Windows.Forms.RadioButton
        Me.rbFiltroGeral = New System.Windows.Forms.RadioButton
        Me.grpFazenda = New System.Windows.Forms.GroupBox
        Me.cboFazenda = New System.Windows.Forms.ComboBox
        Me.grpPeriodo = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpDataFinal = New System.Windows.Forms.DateTimePicker
        Me.dtpDataInicial = New System.Windows.Forms.DateTimePicker
        Me.grpValores = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtValorFinal = New System.Windows.Forms.TextBox
        Me.txtValorInicial = New System.Windows.Forms.TextBox
        Me.TipoMov = New System.Windows.Forms.ColumnHeader
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rbRbTpMovGeral = New System.Windows.Forms.RadioButton
        Me.rbTpMovDebito = New System.Windows.Forms.RadioButton
        Me.rbTpMovCredito = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpFazenda.SuspendLayout()
        Me.grpPeriodo.SuspendLayout()
        Me.grpValores.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstvMovimentoCaixa
        '
        Me.lstvMovimentoCaixa.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.DataBaixa, Me.ValorBaixado, Me.CodForn, Me.NomeFornec, Me.Historico, Me.Banco, Me.Agencia, Me.Conta, Me.Cheque, Me.Fazenda, Me.CodCap, Me.TipoMov})
        Me.lstvMovimentoCaixa.FullRowSelect = True
        Me.lstvMovimentoCaixa.GridLines = True
        Me.lstvMovimentoCaixa.Location = New System.Drawing.Point(12, 60)
        Me.lstvMovimentoCaixa.Name = "lstvMovimentoCaixa"
        Me.lstvMovimentoCaixa.Size = New System.Drawing.Size(768, 333)
        Me.lstvMovimentoCaixa.TabIndex = 1
        Me.lstvMovimentoCaixa.UseCompatibleStateImageBehavior = False
        Me.lstvMovimentoCaixa.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nº Lanc."
        '
        'DataBaixa
        '
        Me.DataBaixa.Text = "Data Baixa"
        Me.DataBaixa.Width = 80
        '
        'ValorBaixado
        '
        Me.ValorBaixado.Text = "Valor Pago R$"
        Me.ValorBaixado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorBaixado.Width = 85
        '
        'CodForn
        '
        Me.CodForn.Text = "Cód.Fornec."
        Me.CodForn.Width = 75
        '
        'NomeFornec
        '
        Me.NomeFornec.Text = "Nome do Fornecedor"
        Me.NomeFornec.Width = 180
        '
        'Historico
        '
        Me.Historico.Text = "Histórico"
        Me.Historico.Width = 200
        '
        'Banco
        '
        Me.Banco.Text = "Banco"
        Me.Banco.Width = 100
        '
        'Agencia
        '
        Me.Agencia.Text = "Agência"
        Me.Agencia.Width = 80
        '
        'Conta
        '
        Me.Conta.Text = "Conta"
        Me.Conta.Width = 80
        '
        'Cheque
        '
        Me.Cheque.Text = "Nº Cheque"
        Me.Cheque.Width = 75
        '
        'Fazenda
        '
        Me.Fazenda.Text = "Fazenda"
        Me.Fazenda.Width = 150
        '
        'CodCap
        '
        Me.CodCap.Text = "CodCap"
        Me.CodCap.Width = 65
        '
        'btnSair
        '
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.Image = Global.SisFaz.My.Resources.Resources.EXITS
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSair.Location = New System.Drawing.Point(705, 3)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 51)
        Me.btnSair.TabIndex = 7
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnSair, "Sair")
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPesquisar.Image = Global.SisFaz.My.Resources.Resources.BINOCULR
        Me.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPesquisar.Location = New System.Drawing.Point(255, 3)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(75, 51)
        Me.btnPesquisar.TabIndex = 6
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnPesquisar, "Pesquisa baseada nos parâmetros")
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.Image = Global.SisFaz.My.Resources.Resources.WASTE
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExcluir.Location = New System.Drawing.Point(174, 3)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 51)
        Me.btnExcluir.TabIndex = 5
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnExcluir, "Excluir lançamento")
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlterar.Image = Global.SisFaz.My.Resources.Resources.NOTE14
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAlterar.Location = New System.Drawing.Point(93, 3)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(75, 51)
        Me.btnAlterar.TabIndex = 4
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnAlterar, "Alterar lançamento")
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnIncluir
        '
        Me.btnIncluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIncluir.Image = Global.SisFaz.My.Resources.Resources.NOTE11
        Me.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnIncluir.Location = New System.Drawing.Point(12, 3)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(75, 51)
        Me.btnIncluir.TabIndex = 0
        Me.btnIncluir.Text = "Incluir"
        Me.btnIncluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnIncluir, "Incluir movimentação no caixa")
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.Image = Global.SisFaz.My.Resources.Resources.printer
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(336, 3)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 51)
        Me.btnImprimir.TabIndex = 11
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnImprimir, "Imprimir")
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbOrdemFazendaData)
        Me.GroupBox1.Controls.Add(Me.rbOrdemValor)
        Me.GroupBox1.Controls.Add(Me.rbOrdemData)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 404)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(149, 86)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ordem"
        '
        'rbOrdemFazendaData
        '
        Me.rbOrdemFazendaData.AutoSize = True
        Me.rbOrdemFazendaData.Location = New System.Drawing.Point(16, 57)
        Me.rbOrdemFazendaData.Name = "rbOrdemFazendaData"
        Me.rbOrdemFazendaData.Size = New System.Drawing.Size(129, 17)
        Me.rbOrdemFazendaData.TabIndex = 3
        Me.rbOrdemFazendaData.Text = "Fazenda + Data baixa"
        Me.rbOrdemFazendaData.UseVisualStyleBackColor = True
        '
        'rbOrdemValor
        '
        Me.rbOrdemValor.AutoSize = True
        Me.rbOrdemValor.Location = New System.Drawing.Point(16, 39)
        Me.rbOrdemValor.Name = "rbOrdemValor"
        Me.rbOrdemValor.Size = New System.Drawing.Size(66, 17)
        Me.rbOrdemValor.TabIndex = 2
        Me.rbOrdemValor.Text = "Valor R$"
        Me.rbOrdemValor.UseVisualStyleBackColor = True
        '
        'rbOrdemData
        '
        Me.rbOrdemData.AutoSize = True
        Me.rbOrdemData.Checked = True
        Me.rbOrdemData.Location = New System.Drawing.Point(16, 19)
        Me.rbOrdemData.Name = "rbOrdemData"
        Me.rbOrdemData.Size = New System.Drawing.Size(91, 17)
        Me.rbOrdemData.TabIndex = 1
        Me.rbOrdemData.TabStop = True
        Me.rbOrdemData.Text = "Data da baixa"
        Me.rbOrdemData.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbFiltroFazenda)
        Me.GroupBox2.Controls.Add(Me.rbFiltroValor)
        Me.GroupBox2.Controls.Add(Me.rbFiltroPeriodo)
        Me.GroupBox2.Controls.Add(Me.rbFiltroGeral)
        Me.GroupBox2.Location = New System.Drawing.Point(174, 402)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(97, 108)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtro"
        '
        'rbFiltroFazenda
        '
        Me.rbFiltroFazenda.AutoSize = True
        Me.rbFiltroFazenda.Location = New System.Drawing.Point(16, 81)
        Me.rbFiltroFazenda.Name = "rbFiltroFazenda"
        Me.rbFiltroFazenda.Size = New System.Drawing.Size(66, 17)
        Me.rbFiltroFazenda.TabIndex = 3
        Me.rbFiltroFazenda.Text = "Fazenda"
        Me.rbFiltroFazenda.UseVisualStyleBackColor = True
        '
        'rbFiltroValor
        '
        Me.rbFiltroValor.AutoSize = True
        Me.rbFiltroValor.Location = New System.Drawing.Point(16, 59)
        Me.rbFiltroValor.Name = "rbFiltroValor"
        Me.rbFiltroValor.Size = New System.Drawing.Size(66, 17)
        Me.rbFiltroValor.TabIndex = 2
        Me.rbFiltroValor.Text = "Valor R$"
        Me.rbFiltroValor.UseVisualStyleBackColor = True
        '
        'rbFiltroPeriodo
        '
        Me.rbFiltroPeriodo.AutoSize = True
        Me.rbFiltroPeriodo.Location = New System.Drawing.Point(16, 38)
        Me.rbFiltroPeriodo.Name = "rbFiltroPeriodo"
        Me.rbFiltroPeriodo.Size = New System.Drawing.Size(63, 17)
        Me.rbFiltroPeriodo.TabIndex = 1
        Me.rbFiltroPeriodo.Text = "Período"
        Me.rbFiltroPeriodo.UseVisualStyleBackColor = True
        '
        'rbFiltroGeral
        '
        Me.rbFiltroGeral.AutoSize = True
        Me.rbFiltroGeral.Checked = True
        Me.rbFiltroGeral.Location = New System.Drawing.Point(16, 19)
        Me.rbFiltroGeral.Name = "rbFiltroGeral"
        Me.rbFiltroGeral.Size = New System.Drawing.Size(50, 17)
        Me.rbFiltroGeral.TabIndex = 0
        Me.rbFiltroGeral.TabStop = True
        Me.rbFiltroGeral.Text = "Geral"
        Me.rbFiltroGeral.UseVisualStyleBackColor = True
        '
        'grpFazenda
        '
        Me.grpFazenda.Controls.Add(Me.cboFazenda)
        Me.grpFazenda.Location = New System.Drawing.Point(280, 404)
        Me.grpFazenda.Name = "grpFazenda"
        Me.grpFazenda.Size = New System.Drawing.Size(304, 52)
        Me.grpFazenda.TabIndex = 8
        Me.grpFazenda.TabStop = False
        Me.grpFazenda.Text = "Fazenda"
        '
        'cboFazenda
        '
        Me.cboFazenda.FormattingEnabled = True
        Me.cboFazenda.Location = New System.Drawing.Point(6, 19)
        Me.cboFazenda.Name = "cboFazenda"
        Me.cboFazenda.Size = New System.Drawing.Size(292, 21)
        Me.cboFazenda.TabIndex = 0
        '
        'grpPeriodo
        '
        Me.grpPeriodo.Controls.Add(Me.Label2)
        Me.grpPeriodo.Controls.Add(Me.Label1)
        Me.grpPeriodo.Controls.Add(Me.dtpDataFinal)
        Me.grpPeriodo.Controls.Add(Me.dtpDataInicial)
        Me.grpPeriodo.Location = New System.Drawing.Point(280, 462)
        Me.grpPeriodo.Name = "grpPeriodo"
        Me.grpPeriodo.Size = New System.Drawing.Size(223, 64)
        Me.grpPeriodo.TabIndex = 9
        Me.grpPeriodo.TabStop = False
        Me.grpPeriodo.Text = "Período"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Data inicial"
        '
        'dtpDataFinal
        '
        Me.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataFinal.Location = New System.Drawing.Point(118, 28)
        Me.dtpDataFinal.Name = "dtpDataFinal"
        Me.dtpDataFinal.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataFinal.TabIndex = 1
        '
        'dtpDataInicial
        '
        Me.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataInicial.Location = New System.Drawing.Point(20, 29)
        Me.dtpDataInicial.Name = "dtpDataInicial"
        Me.dtpDataInicial.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataInicial.TabIndex = 0
        '
        'grpValores
        '
        Me.grpValores.Controls.Add(Me.Label4)
        Me.grpValores.Controls.Add(Me.Label3)
        Me.grpValores.Controls.Add(Me.txtValorFinal)
        Me.grpValores.Controls.Add(Me.txtValorInicial)
        Me.grpValores.Location = New System.Drawing.Point(509, 462)
        Me.grpValores.Name = "grpValores"
        Me.grpValores.Size = New System.Drawing.Size(246, 64)
        Me.grpValores.TabIndex = 10
        Me.grpValores.TabStop = False
        Me.grpValores.Text = "Intervalo de valor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(124, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Valor final"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Valor inicial"
        '
        'txtValorFinal
        '
        Me.txtValorFinal.Location = New System.Drawing.Point(127, 28)
        Me.txtValorFinal.Name = "txtValorFinal"
        Me.txtValorFinal.Size = New System.Drawing.Size(100, 20)
        Me.txtValorFinal.TabIndex = 1
        '
        'txtValorInicial
        '
        Me.txtValorInicial.Location = New System.Drawing.Point(18, 28)
        Me.txtValorInicial.Name = "txtValorInicial"
        Me.txtValorInicial.Size = New System.Drawing.Size(100, 20)
        Me.txtValorInicial.TabIndex = 0
        '
        'TipoMov
        '
        Me.TipoMov.Text = "Deb/Cre"
        Me.TipoMov.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbTpMovCredito)
        Me.GroupBox3.Controls.Add(Me.rbTpMovDebito)
        Me.GroupBox3.Controls.Add(Me.rbRbTpMovGeral)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 492)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(149, 66)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo Movimento"
        '
        'rbRbTpMovGeral
        '
        Me.rbRbTpMovGeral.AutoSize = True
        Me.rbRbTpMovGeral.Checked = True
        Me.rbRbTpMovGeral.Location = New System.Drawing.Point(17, 14)
        Me.rbRbTpMovGeral.Name = "rbRbTpMovGeral"
        Me.rbRbTpMovGeral.Size = New System.Drawing.Size(111, 17)
        Me.rbRbTpMovGeral.TabIndex = 0
        Me.rbRbTpMovGeral.TabStop = True
        Me.rbRbTpMovGeral.Text = "Débitos e Créditos"
        Me.rbRbTpMovGeral.UseVisualStyleBackColor = True
        '
        'rbTpMovDebito
        '
        Me.rbTpMovDebito.AutoSize = True
        Me.rbTpMovDebito.Location = New System.Drawing.Point(17, 30)
        Me.rbTpMovDebito.Name = "rbTpMovDebito"
        Me.rbTpMovDebito.Size = New System.Drawing.Size(77, 17)
        Me.rbTpMovDebito.TabIndex = 1
        Me.rbTpMovDebito.Text = "Só Débitos"
        Me.rbTpMovDebito.UseVisualStyleBackColor = True
        '
        'rbTpMovCredito
        '
        Me.rbTpMovCredito.AutoSize = True
        Me.rbTpMovCredito.Location = New System.Drawing.Point(17, 45)
        Me.rbTpMovCredito.Name = "rbTpMovCredito"
        Me.rbTpMovCredito.Size = New System.Drawing.Size(79, 17)
        Me.rbTpMovCredito.TabIndex = 2
        Me.rbTpMovCredito.Text = "Só Créditos"
        Me.rbTpMovCredito.UseVisualStyleBackColor = True
        '
        'frmMovimentoCaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.grpValores)
        Me.Controls.Add(Me.grpPeriodo)
        Me.Controls.Add(Me.grpFazenda)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstvMovimentoCaixa)
        Me.Controls.Add(Me.btnIncluir)
        Me.Name = "frmMovimentoCaixa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimento do Caixa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpFazenda.ResumeLayout(False)
        Me.grpPeriodo.ResumeLayout(False)
        Me.grpPeriodo.PerformLayout()
        Me.grpValores.ResumeLayout(False)
        Me.grpValores.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnIncluir As System.Windows.Forms.Button
    Friend WithEvents lstvMovimentoCaixa As System.Windows.Forms.ListView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnPesquisar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents rbOrdemFazendaData As System.Windows.Forms.RadioButton
    Friend WithEvents rbOrdemValor As System.Windows.Forms.RadioButton
    Friend WithEvents rbOrdemData As System.Windows.Forms.RadioButton
    Friend WithEvents rbFiltroValor As System.Windows.Forms.RadioButton
    Friend WithEvents rbFiltroPeriodo As System.Windows.Forms.RadioButton
    Friend WithEvents rbFiltroGeral As System.Windows.Forms.RadioButton
    Friend WithEvents grpFazenda As System.Windows.Forms.GroupBox
    Friend WithEvents rbFiltroFazenda As System.Windows.Forms.RadioButton
    Friend WithEvents cboFazenda As System.Windows.Forms.ComboBox
    Friend WithEvents grpPeriodo As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDataFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDataInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents grpValores As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtValorFinal As System.Windows.Forms.TextBox
    Friend WithEvents txtValorInicial As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DataBaixa As System.Windows.Forms.ColumnHeader
    Friend WithEvents ValorBaixado As System.Windows.Forms.ColumnHeader
    Friend WithEvents CodForn As System.Windows.Forms.ColumnHeader
    Friend WithEvents NomeFornec As System.Windows.Forms.ColumnHeader
    Friend WithEvents Historico As System.Windows.Forms.ColumnHeader
    Friend WithEvents Banco As System.Windows.Forms.ColumnHeader
    Friend WithEvents Agencia As System.Windows.Forms.ColumnHeader
    Friend WithEvents Conta As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cheque As System.Windows.Forms.ColumnHeader
    Friend WithEvents Fazenda As System.Windows.Forms.ColumnHeader
    Friend WithEvents CodCap As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents TipoMov As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbTpMovCredito As System.Windows.Forms.RadioButton
    Friend WithEvents rbTpMovDebito As System.Windows.Forms.RadioButton
    Friend WithEvents rbRbTpMovGeral As System.Windows.Forms.RadioButton
End Class
