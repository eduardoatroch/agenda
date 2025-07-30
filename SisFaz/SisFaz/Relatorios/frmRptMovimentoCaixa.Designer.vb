<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptMovimentoCaixa
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDataFim = New System.Windows.Forms.DateTimePicker()
        Me.dtpDataIni = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstvPortador = New System.Windows.Forms.ListView()
        Me.Banco = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Agenc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Conta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.CRV = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.LBLmensagem = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpDataFim)
        Me.GroupBox1.Controls.Add(Me.dtpDataIni)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(111, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Período"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Data inicial"
        '
        'dtpDataFim
        '
        Me.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataFim.Location = New System.Drawing.Point(6, 67)
        Me.dtpDataFim.Name = "dtpDataFim"
        Me.dtpDataFim.Size = New System.Drawing.Size(90, 20)
        Me.dtpDataFim.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.dtpDataFim, "Data final")
        '
        'dtpDataIni
        '
        Me.dtpDataIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataIni.Location = New System.Drawing.Point(6, 28)
        Me.dtpDataIni.Name = "dtpDataIni"
        Me.dtpDataIni.Size = New System.Drawing.Size(90, 20)
        Me.dtpDataIni.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.dtpDataIni, "Data inicial")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstvPortador)
        Me.GroupBox2.Location = New System.Drawing.Point(124, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(377, 101)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Banco/Agência/Conta Corrente"
        '
        'lstvPortador
        '
        Me.lstvPortador.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Banco, Me.Agenc, Me.Conta})
        Me.lstvPortador.FullRowSelect = True
        Me.lstvPortador.Location = New System.Drawing.Point(6, 16)
        Me.lstvPortador.Name = "lstvPortador"
        Me.lstvPortador.Size = New System.Drawing.Size(365, 79)
        Me.lstvPortador.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.lstvPortador, "Lista de Bancos+Agências+Conta Correntes")
        Me.lstvPortador.UseCompatibleStateImageBehavior = False
        Me.lstvPortador.View = System.Windows.Forms.View.Details
        '
        'Banco
        '
        Me.Banco.Text = "Banco"
        Me.Banco.Width = 200
        '
        'Agenc
        '
        Me.Agenc.Text = "Agência"
        '
        'Conta
        '
        Me.Conta.Text = "Conta"
        Me.Conta.Width = 100
        '
        'btnSair
        '
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.Image = Global.SisFaz.My.Resources.Resources.EXITS
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSair.Location = New System.Drawing.Point(579, 12)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(66, 52)
        Me.btnSair.TabIndex = 3
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
        Me.btnImprimir.Location = New System.Drawing.Point(507, 12)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(66, 52)
        Me.btnImprimir.TabIndex = 2
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnImprimir, "Imprimir")
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'CRV
        '
        Me.CRV.ActiveViewIndex = -1
        Me.CRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV.Location = New System.Drawing.Point(7, 112)
        Me.CRV.Name = "CRV"
        Me.CRV.SelectionFormula = ""
        Me.CRV.Size = New System.Drawing.Size(638, 374)
        Me.CRV.TabIndex = 4
        Me.CRV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CRV.ViewTimeSelectionFormula = ""
        '
        'LBLmensagem
        '
        Me.LBLmensagem.AutoSize = True
        Me.LBLmensagem.Location = New System.Drawing.Point(523, 81)
        Me.LBLmensagem.Name = "LBLmensagem"
        Me.LBLmensagem.Size = New System.Drawing.Size(59, 13)
        Me.LBLmensagem.TabIndex = 5
        Me.LBLmensagem.Text = "Mensagem"
        Me.LBLmensagem.Visible = False
        '
        'frmRptMovimentoCaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 498)
        Me.Controls.Add(Me.LBLmensagem)
        Me.Controls.Add(Me.CRV)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmRptMovimentoCaixa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listagem de Movimentação do Caixa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDataFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDataIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lstvPortador As System.Windows.Forms.ListView
    Friend WithEvents Banco As System.Windows.Forms.ColumnHeader
    Friend WithEvents Agenc As System.Windows.Forms.ColumnHeader
    Friend WithEvents Conta As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents CRV As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents LBLmensagem As System.Windows.Forms.Label
End Class
