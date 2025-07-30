<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgencias
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
        Me.lstvAgencias = New System.Windows.Forms.ListView
        Me.cboBanco = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Codigo = New System.Windows.Forms.ColumnHeader
        Me.Agencia = New System.Windows.Forms.ColumnHeader
        Me.grpAgencia = New System.Windows.Forms.GroupBox
        Me.txtNumeroAgencia = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnAlterar = New System.Windows.Forms.Button
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.btnSair = New System.Windows.Forms.Button
        Me.btnIncluir = New System.Windows.Forms.Button
        Me.grpAgencia.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstvAgencias
        '
        Me.lstvAgencias.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Codigo, Me.Agencia})
        Me.lstvAgencias.FullRowSelect = True
        Me.lstvAgencias.GridLines = True
        Me.lstvAgencias.Location = New System.Drawing.Point(12, 132)
        Me.lstvAgencias.Name = "lstvAgencias"
        Me.lstvAgencias.Size = New System.Drawing.Size(349, 121)
        Me.lstvAgencias.TabIndex = 0
        Me.lstvAgencias.UseCompatibleStateImageBehavior = False
        Me.lstvAgencias.View = System.Windows.Forms.View.Details
        '
        'cboBanco
        '
        Me.cboBanco.FormattingEnabled = True
        Me.cboBanco.Location = New System.Drawing.Point(12, 85)
        Me.cboBanco.Name = "cboBanco"
        Me.cboBanco.Size = New System.Drawing.Size(349, 21)
        Me.cboBanco.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Banco"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Agências do Banco"
        '
        'Codigo
        '
        Me.Codigo.Text = "Código"
        '
        'Agencia
        '
        Me.Agencia.Text = "Nº da Agência"
        Me.Agencia.Width = 150
        '
        'grpAgencia
        '
        Me.grpAgencia.Controls.Add(Me.Label3)
        Me.grpAgencia.Controls.Add(Me.txtNumeroAgencia)
        Me.grpAgencia.Location = New System.Drawing.Point(12, 262)
        Me.grpAgencia.Name = "grpAgencia"
        Me.grpAgencia.Size = New System.Drawing.Size(135, 81)
        Me.grpAgencia.TabIndex = 4
        Me.grpAgencia.TabStop = False
        Me.grpAgencia.Text = "Agência selecionada"
        '
        'txtNumeroAgencia
        '
        Me.txtNumeroAgencia.Location = New System.Drawing.Point(21, 43)
        Me.txtNumeroAgencia.MaxLength = 10
        Me.txtNumeroAgencia.Name = "txtNumeroAgencia"
        Me.txtNumeroAgencia.Size = New System.Drawing.Size(91, 20)
        Me.txtNumeroAgencia.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nº da Agência"
        '
        'btnAlterar
        '
        Me.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlterar.Image = Global.SisFaz.My.Resources.Resources.NOTE14
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAlterar.Location = New System.Drawing.Point(83, 12)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(65, 49)
        Me.btnAlterar.TabIndex = 6
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnAlterar, "Alterar agência")
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.Image = Global.SisFaz.My.Resources.Resources.WASTE
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExcluir.Location = New System.Drawing.Point(154, 12)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(65, 49)
        Me.btnExcluir.TabIndex = 7
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnExcluir, "Excluir agência")
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.Image = Global.SisFaz.My.Resources.Resources.DISK04
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalvar.Location = New System.Drawing.Point(225, 12)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(65, 49)
        Me.btnSalvar.TabIndex = 8
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnSalvar, "Salvar agência")
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.Image = Global.SisFaz.My.Resources.Resources.EXITS
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSair.Location = New System.Drawing.Point(296, 12)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(65, 49)
        Me.btnSair.TabIndex = 9
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnSair, "Sair")
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnIncluir
        '
        Me.btnIncluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIncluir.Image = Global.SisFaz.My.Resources.Resources.NOTE11
        Me.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnIncluir.Location = New System.Drawing.Point(12, 12)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(65, 49)
        Me.btnIncluir.TabIndex = 5
        Me.btnIncluir.Text = "Incluir"
        Me.btnIncluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnIncluir, "Incluir nova agência")
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'frmAgencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 355)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnIncluir)
        Me.Controls.Add(Me.grpAgencia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboBanco)
        Me.Controls.Add(Me.lstvAgencias)
        Me.Name = "frmAgencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agências Bancárias"
        Me.grpAgencia.ResumeLayout(False)
        Me.grpAgencia.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstvAgencias As System.Windows.Forms.ListView
    Friend WithEvents cboBanco As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Codigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Agencia As System.Windows.Forms.ColumnHeader
    Friend WithEvents grpAgencia As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroAgencia As System.Windows.Forms.TextBox
    Friend WithEvents btnIncluir As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
End Class
