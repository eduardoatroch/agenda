<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendas
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
        Me.lstvVendas = New System.Windows.Forms.ListView
        Me.Codigo = New System.Windows.Forms.ColumnHeader
        Me.DataVenda = New System.Windows.Forms.ColumnHeader
        Me.VlrVenda = New System.Windows.Forms.ColumnHeader
        Me.Cliente = New System.Windows.Forms.ColumnHeader
        Me.GerarParcela = New System.Windows.Forms.ColumnHeader
        Me.QtdParc = New System.Windows.Forms.ColumnHeader
        Me.ValorParc = New System.Windows.Forms.ColumnHeader
        Me.VencInic = New System.Windows.Forms.ColumnHeader
        Me.Intervalo = New System.Windows.Forms.ColumnHeader
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnPesquisar = New System.Windows.Forms.Button
        Me.btnSair = New System.Windows.Forms.Button
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnAlterar = New System.Windows.Forms.Button
        Me.btnGerarParcelas = New System.Windows.Forms.Button
        Me.grpPeriodo = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpDataFim = New System.Windows.Forms.DateTimePicker
        Me.dtpDataIni = New System.Windows.Forms.DateTimePicker
        Me.btnIncluir = New System.Windows.Forms.Button
        Me.chkPeriodo = New System.Windows.Forms.CheckBox
        Me.grpPeriodo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstvVendas
        '
        Me.lstvVendas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Codigo, Me.DataVenda, Me.VlrVenda, Me.Cliente, Me.GerarParcela, Me.QtdParc, Me.ValorParc, Me.VencInic, Me.Intervalo})
        Me.lstvVendas.FullRowSelect = True
        Me.lstvVendas.Location = New System.Drawing.Point(12, 64)
        Me.lstvVendas.Name = "lstvVendas"
        Me.lstvVendas.Size = New System.Drawing.Size(668, 259)
        Me.lstvVendas.TabIndex = 1
        Me.lstvVendas.UseCompatibleStateImageBehavior = False
        Me.lstvVendas.View = System.Windows.Forms.View.Details
        '
        'Codigo
        '
        Me.Codigo.Text = "Código"
        '
        'DataVenda
        '
        Me.DataVenda.Text = "Dt.venda"
        Me.DataVenda.Width = 80
        '
        'VlrVenda
        '
        Me.VlrVenda.Text = "Valor R$"
        Me.VlrVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.VlrVenda.Width = 80
        '
        'Cliente
        '
        Me.Cliente.Text = "Cliente"
        Me.Cliente.Width = 215
        '
        'GerarParcela
        '
        Me.GerarParcela.Text = "Parcs.Geradas"
        Me.GerarParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GerarParcela.Width = 85
        '
        'QtdParc
        '
        Me.QtdParc.Text = "Qtde.Parc."
        Me.QtdParc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.QtdParc.Width = 70
        '
        'ValorParc
        '
        Me.ValorParc.Text = "Vlr.Parc."
        Me.ValorParc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ValorParc.Width = 70
        '
        'VencInic
        '
        Me.VencInic.Text = "Venc.Inic."
        Me.VencInic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.VencInic.Width = 80
        '
        'Intervalo
        '
        Me.Intervalo.Text = "Intervalo"
        Me.Intervalo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Intervalo.Width = 70
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPesquisar.Image = Global.SisFaz.My.Resources.Resources.BINOCULR
        Me.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPesquisar.Location = New System.Drawing.Point(263, 364)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(75, 36)
        Me.btnPesquisar.TabIndex = 6
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnPesquisar, "Busca rápida")
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.Image = Global.SisFaz.My.Resources.Resources.EXITS
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(605, 12)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 36)
        Me.btnSair.TabIndex = 4
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnSair, "Sair da tela")
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.Image = Global.SisFaz.My.Resources.Resources.WASTE
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.Location = New System.Drawing.Point(174, 12)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 36)
        Me.btnExcluir.TabIndex = 3
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnExcluir, "Excluir venda")
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlterar.Image = Global.SisFaz.My.Resources.Resources.NOTE14
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlterar.Location = New System.Drawing.Point(93, 12)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(75, 36)
        Me.btnAlterar.TabIndex = 2
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnAlterar, "Alterar venda")
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnGerarParcelas
        '
        Me.btnGerarParcelas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGerarParcelas.Image = Global.SisFaz.My.Resources.Resources.Dinheiro4
        Me.btnGerarParcelas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGerarParcelas.Location = New System.Drawing.Point(255, 12)
        Me.btnGerarParcelas.Name = "btnGerarParcelas"
        Me.btnGerarParcelas.Size = New System.Drawing.Size(93, 36)
        Me.btnGerarParcelas.TabIndex = 8
        Me.btnGerarParcelas.Text = "Parcelas"
        Me.btnGerarParcelas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnGerarParcelas, "Gerar Parcelas nos Títulos a Receber")
        Me.btnGerarParcelas.UseVisualStyleBackColor = True
        '
        'grpPeriodo
        '
        Me.grpPeriodo.Controls.Add(Me.Label2)
        Me.grpPeriodo.Controls.Add(Me.Label1)
        Me.grpPeriodo.Controls.Add(Me.dtpDataFim)
        Me.grpPeriodo.Controls.Add(Me.dtpDataIni)
        Me.grpPeriodo.Location = New System.Drawing.Point(14, 354)
        Me.grpPeriodo.Name = "grpPeriodo"
        Me.grpPeriodo.Size = New System.Drawing.Size(235, 59)
        Me.grpPeriodo.TabIndex = 5
        Me.grpPeriodo.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Data final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Data inicial"
        '
        'dtpDataFim
        '
        Me.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataFim.Location = New System.Drawing.Point(121, 32)
        Me.dtpDataFim.Name = "dtpDataFim"
        Me.dtpDataFim.Size = New System.Drawing.Size(93, 20)
        Me.dtpDataFim.TabIndex = 2
        '
        'dtpDataIni
        '
        Me.dtpDataIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataIni.Location = New System.Drawing.Point(22, 32)
        Me.dtpDataIni.Name = "dtpDataIni"
        Me.dtpDataIni.Size = New System.Drawing.Size(93, 20)
        Me.dtpDataIni.TabIndex = 1
        '
        'btnIncluir
        '
        Me.btnIncluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIncluir.Image = Global.SisFaz.My.Resources.Resources.NOTE11
        Me.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIncluir.Location = New System.Drawing.Point(12, 12)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(75, 36)
        Me.btnIncluir.TabIndex = 0
        Me.btnIncluir.Text = "Incluir"
        Me.btnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'chkPeriodo
        '
        Me.chkPeriodo.AutoSize = True
        Me.chkPeriodo.Location = New System.Drawing.Point(24, 350)
        Me.chkPeriodo.Name = "chkPeriodo"
        Me.chkPeriodo.Size = New System.Drawing.Size(62, 17)
        Me.chkPeriodo.TabIndex = 7
        Me.chkPeriodo.Text = "Periodo"
        Me.chkPeriodo.UseVisualStyleBackColor = True
        '
        'frmVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 425)
        Me.Controls.Add(Me.btnGerarParcelas)
        Me.Controls.Add(Me.chkPeriodo)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Controls.Add(Me.grpPeriodo)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.lstvVendas)
        Me.Controls.Add(Me.btnIncluir)
        Me.Name = "frmVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendas"
        Me.grpPeriodo.ResumeLayout(False)
        Me.grpPeriodo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnIncluir As System.Windows.Forms.Button
    Friend WithEvents lstvVendas As System.Windows.Forms.ListView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents grpPeriodo As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDataFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDataIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnPesquisar As System.Windows.Forms.Button
    Friend WithEvents Codigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents DataVenda As System.Windows.Forms.ColumnHeader
    Friend WithEvents VlrVenda As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cliente As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkPeriodo As System.Windows.Forms.CheckBox
    Friend WithEvents GerarParcela As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnGerarParcelas As System.Windows.Forms.Button
    Friend WithEvents QtdParc As System.Windows.Forms.ColumnHeader
    Friend WithEvents ValorParc As System.Windows.Forms.ColumnHeader
    Friend WithEvents VencInic As System.Windows.Forms.ColumnHeader
    Friend WithEvents Intervalo As System.Windows.Forms.ColumnHeader
End Class
