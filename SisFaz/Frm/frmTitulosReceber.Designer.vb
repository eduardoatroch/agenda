<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTitulosReceber
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
        Me.btnIncluir = New System.Windows.Forms.Button
        Me.lstvTitulos = New System.Windows.Forms.ListView
        Me.CodigoREC = New System.Windows.Forms.ColumnHeader
        Me.NumDoc = New System.Windows.Forms.ColumnHeader
        Me.Venc = New System.Windows.Forms.ColumnHeader
        Me.ValorOrig = New System.Windows.Forms.ColumnHeader
        Me.DataPagto = New System.Windows.Forms.ColumnHeader
        Me.VlrPago = New System.Windows.Forms.ColumnHeader
        Me.Historico = New System.Windows.Forms.ColumnHeader
        Me.Cliente = New System.Windows.Forms.ColumnHeader
        Me.Pago = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbStatusBaixado = New System.Windows.Forms.RadioButton
        Me.rbStatusAberto = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpDataFim = New System.Windows.Forms.DateTimePicker
        Me.dtpDataInicio = New System.Windows.Forms.DateTimePicker
        Me.chkPeriodo = New System.Windows.Forms.CheckBox
        Me.btnAlterar = New System.Windows.Forms.Button
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnBaixar = New System.Windows.Forms.Button
        Me.btnSair = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnPesquisar = New System.Windows.Forms.Button
        Me.btnBoletos = New System.Windows.Forms.Button
        Me.grpDataBaixa = New System.Windows.Forms.GroupBox
        Me.dtpDataBaixa = New System.Windows.Forms.DateTimePicker
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cboCliente = New System.Windows.Forms.ComboBox
        Me.Endereco = New System.Windows.Forms.ColumnHeader
        Me.Bairro = New System.Windows.Forms.ColumnHeader
        Me.Cidade = New System.Windows.Forms.ColumnHeader
        Me.UF = New System.Windows.Forms.ColumnHeader
        Me.Cep = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpDataBaixa.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnIncluir
        '
        Me.btnIncluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIncluir.Image = Global.SisFaz.My.Resources.Resources.NOTE11
        Me.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIncluir.Location = New System.Drawing.Point(12, 12)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(75, 40)
        Me.btnIncluir.TabIndex = 0
        Me.btnIncluir.Text = "Incluir"
        Me.btnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnIncluir, "Incluir novo título")
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'lstvTitulos
        '
        Me.lstvTitulos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CodigoREC, Me.NumDoc, Me.Venc, Me.ValorOrig, Me.DataPagto, Me.VlrPago, Me.Historico, Me.Cliente, Me.Pago, Me.Endereco, Me.Bairro, Me.Cidade, Me.UF, Me.Cep})
        Me.lstvTitulos.FullRowSelect = True
        Me.lstvTitulos.Location = New System.Drawing.Point(12, 68)
        Me.lstvTitulos.Name = "lstvTitulos"
        Me.lstvTitulos.Size = New System.Drawing.Size(768, 270)
        Me.lstvTitulos.TabIndex = 1
        Me.lstvTitulos.UseCompatibleStateImageBehavior = False
        Me.lstvTitulos.View = System.Windows.Forms.View.Details
        '
        'CodigoREC
        '
        Me.CodigoREC.Text = "Código"
        '
        'NumDoc
        '
        Me.NumDoc.Text = "Documento"
        Me.NumDoc.Width = 100
        '
        'Venc
        '
        Me.Venc.Text = "Vencimento"
        Me.Venc.Width = 75
        '
        'ValorOrig
        '
        Me.ValorOrig.Text = "Vlr.Orig.R$"
        Me.ValorOrig.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorOrig.Width = 70
        '
        'DataPagto
        '
        Me.DataPagto.Text = "Dt.Pagto."
        Me.DataPagto.Width = 70
        '
        'VlrPago
        '
        Me.VlrPago.Text = "Vlr Pago R$"
        Me.VlrPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.VlrPago.Width = 75
        '
        'Historico
        '
        Me.Historico.Text = "Historico"
        Me.Historico.Width = 150
        '
        'Cliente
        '
        Me.Cliente.Text = "Cliente"
        Me.Cliente.Width = 200
        '
        'Pago
        '
        Me.Pago.Text = "Pago"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbStatusBaixado)
        Me.GroupBox1.Controls.Add(Me.rbStatusAberto)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 364)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(115, 109)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status"
        '
        'rbStatusBaixado
        '
        Me.rbStatusBaixado.AutoSize = True
        Me.rbStatusBaixado.Location = New System.Drawing.Point(22, 62)
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
        Me.rbStatusAberto.Location = New System.Drawing.Point(22, 29)
        Me.rbStatusAberto.Name = "rbStatusAberto"
        Me.rbStatusAberto.Size = New System.Drawing.Size(73, 17)
        Me.rbStatusAberto.TabIndex = 0
        Me.rbStatusAberto.TabStop = True
        Me.rbStatusAberto.Text = "Em aberto"
        Me.rbStatusAberto.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dtpDataFim)
        Me.GroupBox2.Controls.Add(Me.dtpDataInicio)
        Me.GroupBox2.Location = New System.Drawing.Point(135, 365)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 54)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(105, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Data inicial"
        '
        'dtpDataFim
        '
        Me.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataFim.Location = New System.Drawing.Point(108, 27)
        Me.dtpDataFim.Name = "dtpDataFim"
        Me.dtpDataFim.Size = New System.Drawing.Size(89, 20)
        Me.dtpDataFim.TabIndex = 1
        '
        'dtpDataInicio
        '
        Me.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataInicio.Location = New System.Drawing.Point(13, 27)
        Me.dtpDataInicio.Name = "dtpDataInicio"
        Me.dtpDataInicio.Size = New System.Drawing.Size(89, 20)
        Me.dtpDataInicio.TabIndex = 0
        '
        'chkPeriodo
        '
        Me.chkPeriodo.AutoSize = True
        Me.chkPeriodo.Location = New System.Drawing.Point(142, 361)
        Me.chkPeriodo.Name = "chkPeriodo"
        Me.chkPeriodo.Size = New System.Drawing.Size(64, 17)
        Me.chkPeriodo.TabIndex = 4
        Me.chkPeriodo.Text = "Período"
        Me.chkPeriodo.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlterar.Image = Global.SisFaz.My.Resources.Resources.NOTE14
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlterar.Location = New System.Drawing.Point(93, 12)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(75, 40)
        Me.btnAlterar.TabIndex = 5
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnAlterar, "Alterar título")
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.Image = Global.SisFaz.My.Resources.Resources.WASTE
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.Location = New System.Drawing.Point(174, 12)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 40)
        Me.btnExcluir.TabIndex = 6
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnExcluir, "Excluir título")
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnBaixar
        '
        Me.btnBaixar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBaixar.Image = Global.SisFaz.My.Resources.Resources.Dinheiro4
        Me.btnBaixar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBaixar.Location = New System.Drawing.Point(255, 12)
        Me.btnBaixar.Name = "btnBaixar"
        Me.btnBaixar.Size = New System.Drawing.Size(75, 40)
        Me.btnBaixar.TabIndex = 7
        Me.btnBaixar.Text = "Baixar"
        Me.btnBaixar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnBaixar, "Baixar título")
        Me.btnBaixar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.Image = Global.SisFaz.My.Resources.Resources.EXITS
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(717, 12)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(63, 40)
        Me.btnSair.TabIndex = 8
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnSair, "Sair da tela")
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPesquisar.Image = Global.SisFaz.My.Resources.Resources.BINOCULR
        Me.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPesquisar.Location = New System.Drawing.Point(392, 370)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(75, 40)
        Me.btnPesquisar.TabIndex = 9
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnPesquisar, "Busca rápida")
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'btnBoletos
        '
        Me.btnBoletos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBoletos.Image = Global.SisFaz.My.Resources.Resources.printer
        Me.btnBoletos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBoletos.Location = New System.Drawing.Point(336, 12)
        Me.btnBoletos.Name = "btnBoletos"
        Me.btnBoletos.Size = New System.Drawing.Size(79, 40)
        Me.btnBoletos.TabIndex = 11
        Me.btnBoletos.Text = "Boletos"
        Me.btnBoletos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnBoletos, "Impressão de Boletos")
        Me.btnBoletos.UseVisualStyleBackColor = True
        '
        'grpDataBaixa
        '
        Me.grpDataBaixa.Controls.Add(Me.dtpDataBaixa)
        Me.grpDataBaixa.Location = New System.Drawing.Point(651, 364)
        Me.grpDataBaixa.Name = "grpDataBaixa"
        Me.grpDataBaixa.Size = New System.Drawing.Size(129, 79)
        Me.grpDataBaixa.TabIndex = 10
        Me.grpDataBaixa.TabStop = False
        Me.grpDataBaixa.Text = "Data da Baixa"
        '
        'dtpDataBaixa
        '
        Me.dtpDataBaixa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataBaixa.Location = New System.Drawing.Point(14, 33)
        Me.dtpDataBaixa.Name = "dtpDataBaixa"
        Me.dtpDataBaixa.Size = New System.Drawing.Size(96, 20)
        Me.dtpDataBaixa.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboCliente)
        Me.GroupBox3.Location = New System.Drawing.Point(133, 425)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(334, 48)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cliente"
        '
        'cboCliente
        '
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(12, 19)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(310, 21)
        Me.cboCliente.TabIndex = 0
        '
        'Endereco
        '
        Me.Endereco.Text = "Endereço"
        Me.Endereco.Width = 100
        '
        'Bairro
        '
        Me.Bairro.Text = "Bairro"
        Me.Bairro.Width = 80
        '
        'Cidade
        '
        Me.Cidade.Text = "Cidade"
        Me.Cidade.Width = 80
        '
        'UF
        '
        Me.UF.Text = "UF"
        Me.UF.Width = 40
        '
        'Cep
        '
        Me.Cep.Text = "CEP"
        Me.Cep.Width = 50
        '
        'frmTitulosReceber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 478)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnBoletos)
        Me.Controls.Add(Me.grpDataBaixa)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnBaixar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.chkPeriodo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstvTitulos)
        Me.Controls.Add(Me.btnIncluir)
        Me.Name = "frmTitulosReceber"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Títulos a Receber"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpDataBaixa.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnIncluir As System.Windows.Forms.Button
    Friend WithEvents lstvTitulos As System.Windows.Forms.ListView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbStatusBaixado As System.Windows.Forms.RadioButton
    Friend WithEvents rbStatusAberto As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpDataFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDataInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkPeriodo As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnBaixar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents CodigoREC As System.Windows.Forms.ColumnHeader
    Friend WithEvents NumDoc As System.Windows.Forms.ColumnHeader
    Friend WithEvents Venc As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnPesquisar As System.Windows.Forms.Button
    Friend WithEvents ValorOrig As System.Windows.Forms.ColumnHeader
    Friend WithEvents DataPagto As System.Windows.Forms.ColumnHeader
    Friend WithEvents VlrPago As System.Windows.Forms.ColumnHeader
    Friend WithEvents Historico As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cliente As System.Windows.Forms.ColumnHeader
    Friend WithEvents Pago As System.Windows.Forms.ColumnHeader
    Friend WithEvents grpDataBaixa As System.Windows.Forms.GroupBox
    Friend WithEvents dtpDataBaixa As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnBoletos As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cboCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Endereco As System.Windows.Forms.ColumnHeader
    Friend WithEvents Bairro As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cidade As System.Windows.Forms.ColumnHeader
    Friend WithEvents UF As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cep As System.Windows.Forms.ColumnHeader
End Class
