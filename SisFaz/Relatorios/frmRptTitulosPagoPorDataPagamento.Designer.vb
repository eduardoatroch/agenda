<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptTitulosPagoPorDataPagamento
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
        Me.dtpDataFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpDataInicio = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboFazenda = New System.Windows.Forms.ComboBox()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.crvTituloPagoPorDataPagto = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
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
        Me.GroupBox1.Size = New System.Drawing.Size(200, 61)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Período"
        '
        'dtpDataFinal
        '
        Me.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataFinal.Location = New System.Drawing.Point(103, 24)
        Me.dtpDataFinal.Name = "dtpDataFinal"
        Me.dtpDataFinal.Size = New System.Drawing.Size(87, 20)
        Me.dtpDataFinal.TabIndex = 1
        '
        'dtpDataInicio
        '
        Me.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataInicio.Location = New System.Drawing.Point(10, 23)
        Me.dtpDataInicio.Name = "dtpDataInicio"
        Me.dtpDataInicio.Size = New System.Drawing.Size(87, 20)
        Me.dtpDataInicio.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboFazenda)
        Me.GroupBox2.Location = New System.Drawing.Point(231, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(346, 63)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fazenda"
        '
        'cboFazenda
        '
        Me.cboFazenda.FormattingEnabled = True
        Me.cboFazenda.Location = New System.Drawing.Point(11, 25)
        Me.cboFazenda.Name = "cboFazenda"
        Me.cboFazenda.Size = New System.Drawing.Size(329, 21)
        Me.cboFazenda.TabIndex = 0
        '
        'btnSair
        '
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.Image = Global.SisFaz.My.Resources.Resources.EXITS
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSair.Location = New System.Drawing.Point(668, 24)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(61, 51)
        Me.btnSair.TabIndex = 3
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
        Me.btnImprimir.Location = New System.Drawing.Point(600, 24)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(62, 51)
        Me.btnImprimir.TabIndex = 2
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnImprimir, "Iniciar a impressão")
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'crvTituloPagoPorDataPagto
        '
        Me.crvTituloPagoPorDataPagto.ActiveViewIndex = -1
        Me.crvTituloPagoPorDataPagto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvTituloPagoPorDataPagto.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvTituloPagoPorDataPagto.Location = New System.Drawing.Point(12, 81)
        Me.crvTituloPagoPorDataPagto.Name = "crvTituloPagoPorDataPagto"
        Me.crvTituloPagoPorDataPagto.SelectionFormula = ""
        Me.crvTituloPagoPorDataPagto.Size = New System.Drawing.Size(768, 473)
        Me.crvTituloPagoPorDataPagto.TabIndex = 4
        Me.crvTituloPagoPorDataPagto.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.crvTituloPagoPorDataPagto.ViewTimeSelectionFormula = ""
        '
        'frmRptTitulosPagoPorDataPagamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.crvTituloPagoPorDataPagto)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmRptTitulosPagoPorDataPagamento"
        Me.Text = "Títulos pagos por data de pagamento"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpDataFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDataInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboFazenda As System.Windows.Forms.ComboBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents crvTituloPagoPorDataPagto As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
