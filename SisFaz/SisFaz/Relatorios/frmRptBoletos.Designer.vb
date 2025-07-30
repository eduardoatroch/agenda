<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptBoletos
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpDataFim = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpDataIni = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cboCliente = New System.Windows.Forms.ComboBox
        Me.lstvTitulosReceber = New System.Windows.Forms.ListView
        Me.Codigo = New System.Windows.Forms.ColumnHeader
        Me.Documento = New System.Windows.Forms.ColumnHeader
        Me.Venc = New System.Windows.Forms.ColumnHeader
        Me.Valor = New System.Windows.Forms.ColumnHeader
        Me.JurosMora = New System.Windows.Forms.ColumnHeader
        Me.Cliente = New System.Windows.Forms.ColumnHeader
        Me.Endereco = New System.Windows.Forms.ColumnHeader
        Me.Bairro = New System.Windows.Forms.ColumnHeader
        Me.Cidade = New System.Windows.Forms.ColumnHeader
        Me.UF = New System.Windows.Forms.ColumnHeader
        Me.CEP = New System.Windows.Forms.ColumnHeader
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSair = New System.Windows.Forms.Button
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.btnPesquisar = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cboImpressorasRede = New System.Windows.Forms.ComboBox
        Me.chkAceite = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpDataFim)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpDataIni)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Período"
        '
        'dtpDataFim
        '
        Me.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataFim.Location = New System.Drawing.Point(10, 69)
        Me.dtpDataFim.Name = "dtpDataFim"
        Me.dtpDataFim.Size = New System.Drawing.Size(94, 20)
        Me.dtpDataFim.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Data Final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data inicial"
        '
        'dtpDataIni
        '
        Me.dtpDataIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataIni.Location = New System.Drawing.Point(10, 30)
        Me.dtpDataIni.Name = "dtpDataIni"
        Me.dtpDataIni.Size = New System.Drawing.Size(94, 20)
        Me.dtpDataIni.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboCliente)
        Me.GroupBox2.Location = New System.Drawing.Point(134, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(380, 43)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cliente"
        '
        'cboCliente
        '
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(6, 15)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(368, 21)
        Me.cboCliente.TabIndex = 0
        '
        'lstvTitulosReceber
        '
        Me.lstvTitulosReceber.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Codigo, Me.Documento, Me.Venc, Me.Valor, Me.JurosMora, Me.Cliente, Me.Endereco, Me.Bairro, Me.Cidade, Me.UF, Me.CEP})
        Me.lstvTitulosReceber.FullRowSelect = True
        Me.lstvTitulosReceber.Location = New System.Drawing.Point(8, 110)
        Me.lstvTitulosReceber.Name = "lstvTitulosReceber"
        Me.lstvTitulosReceber.Size = New System.Drawing.Size(745, 302)
        Me.lstvTitulosReceber.TabIndex = 2
        Me.lstvTitulosReceber.UseCompatibleStateImageBehavior = False
        Me.lstvTitulosReceber.View = System.Windows.Forms.View.Details
        '
        'Codigo
        '
        Me.Codigo.Text = "Código"
        '
        'Documento
        '
        Me.Documento.Text = "Documento"
        Me.Documento.Width = 100
        '
        'Venc
        '
        Me.Venc.Text = "Vencimento"
        Me.Venc.Width = 80
        '
        'Valor
        '
        Me.Valor.Text = "Valor R$"
        Me.Valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Valor.Width = 100
        '
        'JurosMora
        '
        Me.JurosMora.Text = "Juros Mora R$"
        Me.JurosMora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.JurosMora.Width = 100
        '
        'Cliente
        '
        Me.Cliente.Text = "Cliente"
        Me.Cliente.Width = 200
        '
        'Endereco
        '
        Me.Endereco.Text = "Endereco"
        Me.Endereco.Width = 200
        '
        'Bairro
        '
        Me.Bairro.Text = "Bairro"
        Me.Bairro.Width = 100
        '
        'Cidade
        '
        Me.Cidade.Text = "Cidade"
        Me.Cidade.Width = 100
        '
        'UF
        '
        Me.UF.Text = "UF"
        Me.UF.Width = 50
        '
        'CEP
        '
        Me.CEP.Text = "CEP"
        '
        'btnSair
        '
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.Image = Global.SisFaz.My.Resources.Resources.EXITS
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSair.Location = New System.Drawing.Point(683, 8)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(70, 53)
        Me.btnSair.TabIndex = 4
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnSair, "Sair da tela")
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.Image = Global.SisFaz.My.Resources.Resources.printer
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(607, 8)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(70, 53)
        Me.btnImprimir.TabIndex = 3
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnImprimir, "Iniciar a impressão")
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPesquisar.Image = Global.SisFaz.My.Resources.Resources.BINOCULR
        Me.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPesquisar.Location = New System.Drawing.Point(531, 8)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(70, 53)
        Me.btnPesquisar.TabIndex = 6
        Me.btnPesquisar.Text = "Recebíveis"
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnPesquisar, "Preencher lista de recebimentos")
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboImpressorasRede)
        Me.GroupBox3.Location = New System.Drawing.Point(134, 61)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(380, 43)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Seleção de impressora"
        Me.GroupBox3.Visible = False
        '
        'cboImpressorasRede
        '
        Me.cboImpressorasRede.FormattingEnabled = True
        Me.cboImpressorasRede.Location = New System.Drawing.Point(6, 16)
        Me.cboImpressorasRede.Name = "cboImpressorasRede"
        Me.cboImpressorasRede.Size = New System.Drawing.Size(368, 21)
        Me.cboImpressorasRede.TabIndex = 0
        '
        'chkAceite
        '
        Me.chkAceite.AutoSize = True
        Me.chkAceite.Location = New System.Drawing.Point(532, 77)
        Me.chkAceite.Name = "chkAceite"
        Me.chkAceite.Size = New System.Drawing.Size(56, 17)
        Me.chkAceite.TabIndex = 7
        Me.chkAceite.Text = "Aceite"
        Me.chkAceite.UseVisualStyleBackColor = True
        '
        'frmRptBoletos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 424)
        Me.Controls.Add(Me.chkAceite)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lstvTitulosReceber)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmRptBoletos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impressão de Boletos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpDataFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDataIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboCliente As System.Windows.Forms.ComboBox
    Friend WithEvents lstvTitulosReceber As System.Windows.Forms.ListView
    Friend WithEvents Codigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Documento As System.Windows.Forms.ColumnHeader
    Friend WithEvents Venc As System.Windows.Forms.ColumnHeader
    Friend WithEvents Valor As System.Windows.Forms.ColumnHeader
    Friend WithEvents JurosMora As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cliente As System.Windows.Forms.ColumnHeader
    Friend WithEvents Endereco As System.Windows.Forms.ColumnHeader
    Friend WithEvents Bairro As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cidade As System.Windows.Forms.ColumnHeader
    Friend WithEvents UF As System.Windows.Forms.ColumnHeader
    Friend WithEvents CEP As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cboImpressorasRede As System.Windows.Forms.ComboBox
    Friend WithEvents btnPesquisar As System.Windows.Forms.Button
    Friend WithEvents chkAceite As System.Windows.Forms.CheckBox
End Class
