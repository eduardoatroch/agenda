<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTitulos
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
        Me.lstvTitulos = New System.Windows.Forms.ListView
        Me.CodigoCap = New System.Windows.Forms.ColumnHeader
        Me.Documento = New System.Windows.Forms.ColumnHeader
        Me.Venc = New System.Windows.Forms.ColumnHeader
        Me.Valor = New System.Windows.Forms.ColumnHeader
        Me.Pago = New System.Windows.Forms.ColumnHeader
        Me.DataPagto = New System.Windows.Forms.ColumnHeader
        Me.ValorPago = New System.Windows.Forms.ColumnHeader
        Me.Historico = New System.Windows.Forms.ColumnHeader
        Me.Fornecedor = New System.Windows.Forms.ColumnHeader
        Me.Fazenda = New System.Windows.Forms.ColumnHeader
        Me.banco = New System.Windows.Forms.ColumnHeader
        Me.Agencia = New System.Windows.Forms.ColumnHeader
        Me.Conta = New System.Windows.Forms.ColumnHeader
        Me.Cheque = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbStatusGeral = New System.Windows.Forms.RadioButton
        Me.rbStatusBaixado = New System.Windows.Forms.RadioButton
        Me.rbStatusAberto = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbPesqFazenda = New System.Windows.Forms.RadioButton
        Me.rbPesqValor = New System.Windows.Forms.RadioButton
        Me.rbPesqPeriodo = New System.Windows.Forms.RadioButton
        Me.grpPeriodo = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpDataFinal = New System.Windows.Forms.DateTimePicker
        Me.dtpDataInicial = New System.Windows.Forms.DateTimePicker
        Me.grpValor = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtVlrFinal = New System.Windows.Forms.TextBox
        Me.txtVlrInicial = New System.Windows.Forms.TextBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpFazenda = New System.Windows.Forms.GroupBox
        Me.cboFazenda = New System.Windows.Forms.ComboBox
        Me.btnVoltarFiltroPadrao = New System.Windows.Forms.Button
        Me.btnSair = New System.Windows.Forms.Button
        Me.btnPesquisar = New System.Windows.Forms.Button
        Me.btnBaixar = New System.Windows.Forms.Button
        Me.btnEstornarBaixa = New System.Windows.Forms.Button
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnAlterar = New System.Windows.Forms.Button
        Me.btnIncluir = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpPeriodo.SuspendLayout()
        Me.grpValor.SuspendLayout()
        Me.grpFazenda.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstvTitulos
        '
        Me.lstvTitulos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CodigoCap, Me.Documento, Me.Venc, Me.Valor, Me.Pago, Me.DataPagto, Me.ValorPago, Me.Historico, Me.Fornecedor, Me.Fazenda, Me.banco, Me.Agencia, Me.Conta, Me.Cheque})
        Me.lstvTitulos.FullRowSelect = True
        Me.lstvTitulos.GridLines = True
        Me.lstvTitulos.Location = New System.Drawing.Point(12, 72)
        Me.lstvTitulos.Name = "lstvTitulos"
        Me.lstvTitulos.Size = New System.Drawing.Size(668, 276)
        Me.lstvTitulos.TabIndex = 0
        Me.lstvTitulos.UseCompatibleStateImageBehavior = False
        Me.lstvTitulos.View = System.Windows.Forms.View.Details
        '
        'CodigoCap
        '
        Me.CodigoCap.Text = "CódigoCAP"
        Me.CodigoCap.Width = 70
        '
        'Documento
        '
        Me.Documento.Text = "Nº Título"
        Me.Documento.Width = 80
        '
        'Venc
        '
        Me.Venc.Text = "Vencimento"
        Me.Venc.Width = 80
        '
        'Valor
        '
        Me.Valor.Text = "Valor Original"
        Me.Valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Valor.Width = 80
        '
        'Pago
        '
        Me.Pago.Text = "Baixado"
        '
        'DataPagto
        '
        Me.DataPagto.Text = "Dt.Pagamento"
        Me.DataPagto.Width = 90
        '
        'ValorPago
        '
        Me.ValorPago.Text = "ValorPago"
        Me.ValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorPago.Width = 90
        '
        'Historico
        '
        Me.Historico.Text = "Historico"
        Me.Historico.Width = 200
        '
        'Fornecedor
        '
        Me.Fornecedor.Text = "Fornecedor"
        Me.Fornecedor.Width = 200
        '
        'Fazenda
        '
        Me.Fazenda.Text = "Fazenda"
        Me.Fazenda.Width = 200
        '
        'banco
        '
        Me.banco.Text = "Banco"
        '
        'Agencia
        '
        Me.Agencia.Text = "Agência"
        Me.Agencia.Width = 90
        '
        'Conta
        '
        Me.Conta.Text = "Conta"
        Me.Conta.Width = 90
        '
        'Cheque
        '
        Me.Cheque.Text = "Nº Cheque"
        Me.Cheque.Width = 90
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbStatusGeral)
        Me.GroupBox1.Controls.Add(Me.rbStatusBaixado)
        Me.GroupBox1.Controls.Add(Me.rbStatusAberto)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 367)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(126, 125)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Satatus Pagamento"
        '
        'rbStatusGeral
        '
        Me.rbStatusGeral.AutoSize = True
        Me.rbStatusGeral.Location = New System.Drawing.Point(27, 90)
        Me.rbStatusGeral.Name = "rbStatusGeral"
        Me.rbStatusGeral.Size = New System.Drawing.Size(50, 17)
        Me.rbStatusGeral.TabIndex = 2
        Me.rbStatusGeral.Text = "Geral"
        Me.rbStatusGeral.UseVisualStyleBackColor = True
        '
        'rbStatusBaixado
        '
        Me.rbStatusBaixado.AutoSize = True
        Me.rbStatusBaixado.Location = New System.Drawing.Point(27, 56)
        Me.rbStatusBaixado.Name = "rbStatusBaixado"
        Me.rbStatusBaixado.Size = New System.Drawing.Size(63, 17)
        Me.rbStatusBaixado.TabIndex = 1
        Me.rbStatusBaixado.Text = "Baixado"
        Me.rbStatusBaixado.UseVisualStyleBackColor = True
        '
        'rbStatusAberto
        '
        Me.rbStatusAberto.AutoSize = True
        Me.rbStatusAberto.Checked = True
        Me.rbStatusAberto.Location = New System.Drawing.Point(27, 26)
        Me.rbStatusAberto.Name = "rbStatusAberto"
        Me.rbStatusAberto.Size = New System.Drawing.Size(73, 17)
        Me.rbStatusAberto.TabIndex = 0
        Me.rbStatusAberto.TabStop = True
        Me.rbStatusAberto.Text = "Em aberto"
        Me.rbStatusAberto.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbPesqFazenda)
        Me.GroupBox2.Controls.Add(Me.rbPesqValor)
        Me.GroupBox2.Controls.Add(Me.rbPesqPeriodo)
        Me.GroupBox2.Location = New System.Drawing.Point(144, 367)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(82, 125)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pesquisar"
        '
        'rbPesqFazenda
        '
        Me.rbPesqFazenda.AutoSize = True
        Me.rbPesqFazenda.Location = New System.Drawing.Point(6, 90)
        Me.rbPesqFazenda.Name = "rbPesqFazenda"
        Me.rbPesqFazenda.Size = New System.Drawing.Size(66, 17)
        Me.rbPesqFazenda.TabIndex = 2
        Me.rbPesqFazenda.TabStop = True
        Me.rbPesqFazenda.Text = "Fazenda"
        Me.rbPesqFazenda.UseVisualStyleBackColor = True
        '
        'rbPesqValor
        '
        Me.rbPesqValor.AutoSize = True
        Me.rbPesqValor.Location = New System.Drawing.Point(6, 57)
        Me.rbPesqValor.Name = "rbPesqValor"
        Me.rbPesqValor.Size = New System.Drawing.Size(49, 17)
        Me.rbPesqValor.TabIndex = 1
        Me.rbPesqValor.TabStop = True
        Me.rbPesqValor.Text = "Valor"
        Me.rbPesqValor.UseVisualStyleBackColor = True
        '
        'rbPesqPeriodo
        '
        Me.rbPesqPeriodo.AutoSize = True
        Me.rbPesqPeriodo.Location = New System.Drawing.Point(6, 27)
        Me.rbPesqPeriodo.Name = "rbPesqPeriodo"
        Me.rbPesqPeriodo.Size = New System.Drawing.Size(63, 17)
        Me.rbPesqPeriodo.TabIndex = 0
        Me.rbPesqPeriodo.TabStop = True
        Me.rbPesqPeriodo.Text = "Período"
        Me.rbPesqPeriodo.UseVisualStyleBackColor = True
        '
        'grpPeriodo
        '
        Me.grpPeriodo.Controls.Add(Me.Label2)
        Me.grpPeriodo.Controls.Add(Me.Label1)
        Me.grpPeriodo.Controls.Add(Me.dtpDataFinal)
        Me.grpPeriodo.Controls.Add(Me.dtpDataInicial)
        Me.grpPeriodo.Location = New System.Drawing.Point(232, 367)
        Me.grpPeriodo.Name = "grpPeriodo"
        Me.grpPeriodo.Size = New System.Drawing.Size(242, 63)
        Me.grpPeriodo.TabIndex = 3
        Me.grpPeriodo.TabStop = False
        Me.grpPeriodo.Text = "Período"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Data inicial"
        '
        'dtpDataFinal
        '
        Me.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataFinal.Location = New System.Drawing.Point(122, 35)
        Me.dtpDataFinal.Name = "dtpDataFinal"
        Me.dtpDataFinal.Size = New System.Drawing.Size(90, 20)
        Me.dtpDataFinal.TabIndex = 1
        '
        'dtpDataInicial
        '
        Me.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataInicial.Location = New System.Drawing.Point(16, 35)
        Me.dtpDataInicial.Name = "dtpDataInicial"
        Me.dtpDataInicial.Size = New System.Drawing.Size(90, 20)
        Me.dtpDataInicial.TabIndex = 0
        '
        'grpValor
        '
        Me.grpValor.Controls.Add(Me.Label4)
        Me.grpValor.Controls.Add(Me.Label3)
        Me.grpValor.Controls.Add(Me.txtVlrFinal)
        Me.grpValor.Controls.Add(Me.txtVlrInicial)
        Me.grpValor.Location = New System.Drawing.Point(480, 367)
        Me.grpValor.Name = "grpValor"
        Me.grpValor.Size = New System.Drawing.Size(200, 63)
        Me.grpValor.TabIndex = 4
        Me.grpValor.TabStop = False
        Me.grpValor.Text = "Valor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(96, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Valor final"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Valor inicial"
        '
        'txtVlrFinal
        '
        Me.txtVlrFinal.Location = New System.Drawing.Point(99, 36)
        Me.txtVlrFinal.Name = "txtVlrFinal"
        Me.txtVlrFinal.Size = New System.Drawing.Size(80, 20)
        Me.txtVlrFinal.TabIndex = 1
        '
        'txtVlrInicial
        '
        Me.txtVlrInicial.Location = New System.Drawing.Point(13, 37)
        Me.txtVlrInicial.Name = "txtVlrInicial"
        Me.txtVlrInicial.Size = New System.Drawing.Size(80, 20)
        Me.txtVlrInicial.TabIndex = 0
        '
        'grpFazenda
        '
        Me.grpFazenda.Controls.Add(Me.cboFazenda)
        Me.grpFazenda.Location = New System.Drawing.Point(232, 436)
        Me.grpFazenda.Name = "grpFazenda"
        Me.grpFazenda.Size = New System.Drawing.Size(448, 56)
        Me.grpFazenda.TabIndex = 12
        Me.grpFazenda.TabStop = False
        Me.grpFazenda.Text = "Fazenda"
        '
        'cboFazenda
        '
        Me.cboFazenda.FormattingEnabled = True
        Me.cboFazenda.Location = New System.Drawing.Point(6, 19)
        Me.cboFazenda.Name = "cboFazenda"
        Me.cboFazenda.Size = New System.Drawing.Size(436, 21)
        Me.cboFazenda.TabIndex = 0
        '
        'btnVoltarFiltroPadrao
        '
        Me.btnVoltarFiltroPadrao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVoltarFiltroPadrao.Image = Global.SisFaz.My.Resources.Resources.UNDO3
        Me.btnVoltarFiltroPadrao.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnVoltarFiltroPadrao.Location = New System.Drawing.Point(426, 12)
        Me.btnVoltarFiltroPadrao.Name = "btnVoltarFiltroPadrao"
        Me.btnVoltarFiltroPadrao.Size = New System.Drawing.Size(63, 54)
        Me.btnVoltarFiltroPadrao.TabIndex = 13
        Me.btnVoltarFiltroPadrao.Text = "Voltar Filtro"
        Me.btnVoltarFiltroPadrao.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnVoltarFiltroPadrao, "Voltar Filtro para o padrão")
        Me.btnVoltarFiltroPadrao.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.Image = Global.SisFaz.My.Resources.Resources.EXITS
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSair.Location = New System.Drawing.Point(495, 12)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(63, 54)
        Me.btnSair.TabIndex = 11
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
        Me.btnPesquisar.Location = New System.Drawing.Point(357, 12)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(63, 54)
        Me.btnPesquisar.TabIndex = 10
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnPesquisar, "Pesquisar")
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'btnBaixar
        '
        Me.btnBaixar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBaixar.Image = Global.SisFaz.My.Resources.Resources.Dinheiro4
        Me.btnBaixar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBaixar.Location = New System.Drawing.Point(219, 12)
        Me.btnBaixar.Name = "btnBaixar"
        Me.btnBaixar.Size = New System.Drawing.Size(63, 54)
        Me.btnBaixar.TabIndex = 9
        Me.btnBaixar.Text = "Baixar"
        Me.btnBaixar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnBaixar, "Baixar título")
        Me.btnBaixar.UseVisualStyleBackColor = True
        '
        'btnEstornarBaixa
        '
        Me.btnEstornarBaixa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEstornarBaixa.Image = Global.SisFaz.My.Resources.Resources.W95MBX011
        Me.btnEstornarBaixa.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEstornarBaixa.Location = New System.Drawing.Point(288, 12)
        Me.btnEstornarBaixa.Name = "btnEstornarBaixa"
        Me.btnEstornarBaixa.Size = New System.Drawing.Size(63, 54)
        Me.btnEstornarBaixa.TabIndex = 8
        Me.btnEstornarBaixa.Text = "Estornar Baixa"
        Me.btnEstornarBaixa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnEstornarBaixa, "Estornar baixa")
        Me.btnEstornarBaixa.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.Image = Global.SisFaz.My.Resources.Resources.WASTE
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExcluir.Location = New System.Drawing.Point(150, 12)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(63, 54)
        Me.btnExcluir.TabIndex = 7
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnExcluir, "Excluir título")
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlterar.Image = Global.SisFaz.My.Resources.Resources.NOTE14
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAlterar.Location = New System.Drawing.Point(81, 12)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(63, 54)
        Me.btnAlterar.TabIndex = 6
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnAlterar, "Alterar título")
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnIncluir
        '
        Me.btnIncluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIncluir.Image = Global.SisFaz.My.Resources.Resources.NOTE11
        Me.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnIncluir.Location = New System.Drawing.Point(12, 12)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(63, 54)
        Me.btnIncluir.TabIndex = 5
        Me.btnIncluir.Text = "Incluir"
        Me.btnIncluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnIncluir, "Incluir novo título")
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'frmTitulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 504)
        Me.Controls.Add(Me.btnVoltarFiltroPadrao)
        Me.Controls.Add(Me.grpFazenda)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Controls.Add(Me.btnBaixar)
        Me.Controls.Add(Me.btnEstornarBaixa)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnIncluir)
        Me.Controls.Add(Me.grpValor)
        Me.Controls.Add(Me.grpPeriodo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstvTitulos)
        Me.Name = "frmTitulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Títulos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpPeriodo.ResumeLayout(False)
        Me.grpPeriodo.PerformLayout()
        Me.grpValor.ResumeLayout(False)
        Me.grpValor.PerformLayout()
        Me.grpFazenda.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstvTitulos As System.Windows.Forms.ListView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbStatusGeral As System.Windows.Forms.RadioButton
    Friend WithEvents rbStatusBaixado As System.Windows.Forms.RadioButton
    Friend WithEvents rbStatusAberto As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbPesqValor As System.Windows.Forms.RadioButton
    Friend WithEvents rbPesqPeriodo As System.Windows.Forms.RadioButton
    Friend WithEvents grpPeriodo As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDataFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDataInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents grpValor As System.Windows.Forms.GroupBox
    Friend WithEvents txtVlrInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtVlrFinal As System.Windows.Forms.TextBox
    Friend WithEvents btnIncluir As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnEstornarBaixa As System.Windows.Forms.Button
    Friend WithEvents btnBaixar As System.Windows.Forms.Button
    Friend WithEvents btnPesquisar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents CodigoCap As System.Windows.Forms.ColumnHeader
    Friend WithEvents Documento As System.Windows.Forms.ColumnHeader
    Friend WithEvents Venc As System.Windows.Forms.ColumnHeader
    Friend WithEvents Valor As System.Windows.Forms.ColumnHeader
    Friend WithEvents Pago As System.Windows.Forms.ColumnHeader
    Friend WithEvents DataPagto As System.Windows.Forms.ColumnHeader
    Friend WithEvents ValorPago As System.Windows.Forms.ColumnHeader
    Friend WithEvents Historico As System.Windows.Forms.ColumnHeader
    Friend WithEvents Fornecedor As System.Windows.Forms.ColumnHeader
    Friend WithEvents Fazenda As System.Windows.Forms.ColumnHeader
    Friend WithEvents rbPesqFazenda As System.Windows.Forms.RadioButton
    Friend WithEvents grpFazenda As System.Windows.Forms.GroupBox
    Friend WithEvents cboFazenda As System.Windows.Forms.ComboBox
    Friend WithEvents btnVoltarFiltroPadrao As System.Windows.Forms.Button
    Friend WithEvents banco As System.Windows.Forms.ColumnHeader
    Friend WithEvents Agencia As System.Windows.Forms.ColumnHeader
    Friend WithEvents Conta As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cheque As System.Windows.Forms.ColumnHeader
End Class
