<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptFornecedores
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
        Me.chkAtivos = New System.Windows.Forms.CheckBox
        Me.btnSair = New System.Windows.Forms.Button
        Me.crvFornecedores = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'chkAtivos
        '
        Me.chkAtivos.AutoSize = True
        Me.chkAtivos.Checked = True
        Me.chkAtivos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAtivos.Location = New System.Drawing.Point(12, 12)
        Me.chkAtivos.Name = "chkAtivos"
        Me.chkAtivos.Size = New System.Drawing.Size(113, 17)
        Me.chkAtivos.TabIndex = 0
        Me.chkAtivos.Text = "Somente os ativos"
        Me.chkAtivos.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.Image = Global.SisFaz.My.Resources.Resources.EXITS
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSair.Location = New System.Drawing.Point(195, 12)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(58, 46)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'crvFornecedores
        '
        Me.crvFornecedores.ActiveViewIndex = -1
        Me.crvFornecedores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvFornecedores.DisplayGroupTree = False
        Me.crvFornecedores.Location = New System.Drawing.Point(12, 64)
        Me.crvFornecedores.Name = "crvFornecedores"
        Me.crvFornecedores.SelectionFormula = ""
        Me.crvFornecedores.Size = New System.Drawing.Size(560, 397)
        Me.crvFornecedores.TabIndex = 3
        Me.crvFornecedores.ViewTimeSelectionFormula = ""
        '
        'btnImprimir
        '
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.Image = Global.SisFaz.My.Resources.Resources.printer
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(131, 12)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(58, 46)
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'frmRptFornecedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 473)
        Me.Controls.Add(Me.crvFornecedores)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.chkAtivos)
        Me.Name = "frmRptFornecedores"
        Me.Text = "Relatório de Fornecedores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkAtivos As System.Windows.Forms.CheckBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents crvFornecedores As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
