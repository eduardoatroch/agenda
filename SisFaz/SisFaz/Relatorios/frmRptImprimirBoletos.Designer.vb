<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptImprimirBoletos
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
        Me.cboCLiente = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDataFim = New System.Windows.Forms.DateTimePicker()
        Me.dtpDataIni = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.crvBoletos = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboCLiente
        '
        Me.cboCLiente.FormattingEnabled = True
        Me.cboCLiente.Location = New System.Drawing.Point(13, 28)
        Me.cboCLiente.Name = "cboCLiente"
        Me.cboCLiente.Size = New System.Drawing.Size(291, 21)
        Me.cboCLiente.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpDataFim)
        Me.GroupBox1.Controls.Add(Me.dtpDataIni)
        Me.GroupBox1.Location = New System.Drawing.Point(320, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(213, 68)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Período"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(108, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Data inicial"
        '
        'dtpDataFim
        '
        Me.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataFim.Location = New System.Drawing.Point(111, 31)
        Me.dtpDataFim.Name = "dtpDataFim"
        Me.dtpDataFim.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataFim.TabIndex = 1
        '
        'dtpDataIni
        '
        Me.dtpDataIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataIni.Location = New System.Drawing.Point(14, 31)
        Me.dtpDataIni.Name = "dtpDataIni"
        Me.dtpDataIni.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataIni.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cliente"
        '
        'crvBoletos
        '
        Me.crvBoletos.ActiveViewIndex = -1
        Me.crvBoletos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvBoletos.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvBoletos.Location = New System.Drawing.Point(12, 120)
        Me.crvBoletos.Name = "crvBoletos"
        Me.crvBoletos.SelectionFormula = ""
        Me.crvBoletos.Size = New System.Drawing.Size(681, 409)
        Me.crvBoletos.TabIndex = 4
        Me.crvBoletos.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.crvBoletos.ViewTimeSelectionFormula = ""
        '
        'btnSair
        '
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.Image = Global.SisFaz.My.Resources.Resources.EXITS
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSair.Location = New System.Drawing.Point(617, 29)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(62, 50)
        Me.btnSair.TabIndex = 5
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnSair, "Sair")
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.Image = Global.SisFaz.My.Resources.Resources.printer
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(549, 29)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(62, 50)
        Me.btnImprimir.TabIndex = 3
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnImprimir, "Iniciar a impressão")
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'frmRptImprimirBoletos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 541)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.crvBoletos)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cboCLiente)
        Me.Name = "frmRptImprimirBoletos"
        Me.Text = "Imprimir Boletos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboCLiente As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDataFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDataIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents crvBoletos As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
