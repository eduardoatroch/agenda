<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBancos
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
        Me.lstvBancos = New System.Windows.Forms.ListView
        Me.Codigo = New System.Windows.Forms.ColumnHeader
        Me.Banco = New System.Windows.Forms.ColumnHeader
        Me.grpBanco = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtBanco = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnAlterar = New System.Windows.Forms.Button
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.btnSair = New System.Windows.Forms.Button
        Me.btnIncluir = New System.Windows.Forms.Button
        Me.grpBanco.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstvBancos
        '
        Me.lstvBancos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Codigo, Me.Banco})
        Me.lstvBancos.FullRowSelect = True
        Me.lstvBancos.GridLines = True
        Me.lstvBancos.Location = New System.Drawing.Point(22, 65)
        Me.lstvBancos.Name = "lstvBancos"
        Me.lstvBancos.Size = New System.Drawing.Size(331, 152)
        Me.lstvBancos.TabIndex = 1
        Me.lstvBancos.UseCompatibleStateImageBehavior = False
        Me.lstvBancos.View = System.Windows.Forms.View.Details
        '
        'Codigo
        '
        Me.Codigo.Text = "Código"
        '
        'Banco
        '
        Me.Banco.Text = "Banco"
        Me.Banco.Width = 200
        '
        'grpBanco
        '
        Me.grpBanco.Controls.Add(Me.Label2)
        Me.grpBanco.Controls.Add(Me.txtBanco)
        Me.grpBanco.Controls.Add(Me.Label1)
        Me.grpBanco.Controls.Add(Me.txtCodigo)
        Me.grpBanco.Location = New System.Drawing.Point(22, 223)
        Me.grpBanco.Name = "grpBanco"
        Me.grpBanco.Size = New System.Drawing.Size(331, 100)
        Me.grpBanco.TabIndex = 2
        Me.grpBanco.TabStop = False
        Me.grpBanco.Text = "Banco selecionado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nome do Banco"
        '
        'txtBanco
        '
        Me.txtBanco.Location = New System.Drawing.Point(71, 52)
        Me.txtBanco.MaxLength = 40
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(241, 20)
        Me.txtBanco.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Código"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(20, 52)
        Me.txtCodigo.MaxLength = 3
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(45, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'btnAlterar
        '
        Me.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlterar.Image = Global.SisFaz.My.Resources.Resources.NOTE14
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAlterar.Location = New System.Drawing.Point(84, 12)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(53, 47)
        Me.btnAlterar.TabIndex = 3
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnAlterar, "Alterar Banco")
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.Image = Global.SisFaz.My.Resources.Resources.WASTE
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExcluir.Location = New System.Drawing.Point(143, 12)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(52, 47)
        Me.btnExcluir.TabIndex = 4
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnExcluir, "Excluir Banco")
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.Image = Global.SisFaz.My.Resources.Resources.DISK04
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalvar.Location = New System.Drawing.Point(201, 12)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(53, 47)
        Me.btnSalvar.TabIndex = 5
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnSalvar, "Salvar Banco")
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.Image = Global.SisFaz.My.Resources.Resources.EXITS
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSair.Location = New System.Drawing.Point(260, 12)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(53, 47)
        Me.btnSair.TabIndex = 6
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
        Me.btnIncluir.Location = New System.Drawing.Point(22, 12)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(56, 47)
        Me.btnIncluir.TabIndex = 0
        Me.btnIncluir.Text = "Incluir"
        Me.btnIncluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnIncluir, "Incluir Banco")
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'frmBancos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 349)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.grpBanco)
        Me.Controls.Add(Me.lstvBancos)
        Me.Controls.Add(Me.btnIncluir)
        Me.Name = "frmBancos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bancos"
        Me.grpBanco.ResumeLayout(False)
        Me.grpBanco.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnIncluir As System.Windows.Forms.Button
    Friend WithEvents lstvBancos As System.Windows.Forms.ListView
    Friend WithEvents grpBanco As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents Codigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Banco As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBanco As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
End Class
