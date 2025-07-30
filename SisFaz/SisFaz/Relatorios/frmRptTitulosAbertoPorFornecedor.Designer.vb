<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptTitulosAbertoPorFornecedor
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
        Me.dtpDataFinal = New System.Windows.Forms.DateTimePicker
        Me.dtpDataInicio = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cboFornecedor = New System.Windows.Forms.ComboBox
        Me.btnSair = New System.Windows.Forms.Button
        Me.crvTitAbertoPorFornec = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpDataFinal)
        Me.GroupBox1.Controls.Add(Me.dtpDataInicio)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(205, 60)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Período"
        '
        'dtpDataFinal
        '
        Me.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataFinal.Location = New System.Drawing.Point(104, 22)
        Me.dtpDataFinal.Name = "dtpDataFinal"
        Me.dtpDataFinal.Size = New System.Drawing.Size(88, 20)
        Me.dtpDataFinal.TabIndex = 1
        '
        'dtpDataInicio
        '
        Me.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataInicio.Location = New System.Drawing.Point(10, 22)
        Me.dtpDataInicio.Name = "dtpDataInicio"
        Me.dtpDataInicio.Size = New System.Drawing.Size(88, 20)
        Me.dtpDataInicio.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboFornecedor)
        Me.GroupBox2.Location = New System.Drawing.Point(223, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(399, 60)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fornecedor"
        '
        'cboFornecedor
        '
        Me.cboFornecedor.FormattingEnabled = True
        Me.cboFornecedor.Location = New System.Drawing.Point(6, 23)
        Me.cboFornecedor.Name = "cboFornecedor"
        Me.cboFornecedor.Size = New System.Drawing.Size(387, 21)
        Me.cboFornecedor.TabIndex = 0
        '
        'btnSair
        '
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.Image = Global.SisFaz.My.Resources.Resources.EXITS
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSair.Location = New System.Drawing.Point(695, 18)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(61, 53)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnSair, "Sair")
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'crvTitAbertoPorFornec
        '
        Me.crvTitAbertoPorFornec.ActiveViewIndex = -1
        Me.crvTitAbertoPorFornec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvTitAbertoPorFornec.DisplayGroupTree = False
        Me.crvTitAbertoPorFornec.Location = New System.Drawing.Point(12, 78)
        Me.crvTitAbertoPorFornec.Name = "crvTitAbertoPorFornec"
        Me.crvTitAbertoPorFornec.SelectionFormula = ""
        Me.crvTitAbertoPorFornec.Size = New System.Drawing.Size(768, 476)
        Me.crvTitAbertoPorFornec.TabIndex = 4
        Me.crvTitAbertoPorFornec.ViewTimeSelectionFormula = ""
        '
        'btnImprimir
        '
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.Image = Global.SisFaz.My.Resources.Resources.printer
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(628, 18)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(61, 53)
        Me.btnImprimir.TabIndex = 2
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnImprimir, "Iniciar a impressão")
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'frmRptTitulosAbertoPorFornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.crvTitAbertoPorFornec)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmRptTitulosAbertoPorFornecedor"
        Me.Text = "Títulos em aberto por fornecedor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents dtpDataFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDataInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboFornecedor As System.Windows.Forms.ComboBox
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents crvTitAbertoPorFornec As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
