<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipoDocumento
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
        Me.lstvTipos = New System.Windows.Forms.ListView
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpTipo = New System.Windows.Forms.GroupBox
        Me.txtCodigoTipo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTipo = New System.Windows.Forms.TextBox
        Me.Codigo = New System.Windows.Forms.ColumnHeader
        Me.Tipo = New System.Windows.Forms.ColumnHeader
        Me.btnAlterar = New System.Windows.Forms.Button
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnSair = New System.Windows.Forms.Button
        Me.btnIncluir = New System.Windows.Forms.Button
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.grpTipo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstvTipos
        '
        Me.lstvTipos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Codigo, Me.Tipo})
        Me.lstvTipos.FullRowSelect = True
        Me.lstvTipos.GridLines = True
        Me.lstvTipos.Location = New System.Drawing.Point(12, 56)
        Me.lstvTipos.Name = "lstvTipos"
        Me.lstvTipos.Size = New System.Drawing.Size(346, 140)
        Me.lstvTipos.TabIndex = 2
        Me.lstvTipos.UseCompatibleStateImageBehavior = False
        Me.lstvTipos.View = System.Windows.Forms.View.Details
        '
        'grpTipo
        '
        Me.grpTipo.Controls.Add(Me.txtTipo)
        Me.grpTipo.Controls.Add(Me.Label3)
        Me.grpTipo.Controls.Add(Me.Label2)
        Me.grpTipo.Controls.Add(Me.txtCodigoTipo)
        Me.grpTipo.Location = New System.Drawing.Point(12, 232)
        Me.grpTipo.Name = "grpTipo"
        Me.grpTipo.Size = New System.Drawing.Size(249, 70)
        Me.grpTipo.TabIndex = 4
        Me.grpTipo.TabStop = False
        Me.grpTipo.Text = "Tipo selecionado"
        '
        'txtCodigoTipo
        '
        Me.txtCodigoTipo.Location = New System.Drawing.Point(9, 32)
        Me.txtCodigoTipo.MaxLength = 2
        Me.txtCodigoTipo.Name = "txtCodigoTipo"
        Me.txtCodigoTipo.Size = New System.Drawing.Size(54, 20)
        Me.txtCodigoTipo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Código"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nome do Tipo de Documento"
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(81, 32)
        Me.txtTipo.MaxLength = 30
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(144, 20)
        Me.txtTipo.TabIndex = 7
        '
        'Codigo
        '
        Me.Codigo.Text = "Código"
        '
        'Tipo
        '
        Me.Tipo.Text = "Tipo Documento"
        Me.Tipo.Width = 200
        '
        'btnAlterar
        '
        Me.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlterar.Image = Global.SisFaz.My.Resources.Resources.NOTE14
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlterar.Location = New System.Drawing.Point(81, 12)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(66, 23)
        Me.btnAlterar.TabIndex = 5
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnAlterar, "Alterar tipo de documento")
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.Image = Global.SisFaz.My.Resources.Resources.WASTE
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.Location = New System.Drawing.Point(153, 12)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(63, 23)
        Me.btnExcluir.TabIndex = 6
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnExcluir, "Excluir tipo de documento")
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.Image = Global.SisFaz.My.Resources.Resources.EXITS
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(294, 12)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(64, 23)
        Me.btnSair.TabIndex = 7
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnSair, "Sair")
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnIncluir
        '
        Me.btnIncluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIncluir.Image = Global.SisFaz.My.Resources.Resources.NOTE11
        Me.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIncluir.Location = New System.Drawing.Point(12, 12)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(63, 23)
        Me.btnIncluir.TabIndex = 0
        Me.btnIncluir.Text = "Incluir"
        Me.btnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnIncluir, "Incluir novo tipo de documento")
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.Image = Global.SisFaz.My.Resources.Resources.DISK04
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(222, 12)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(66, 23)
        Me.btnSalvar.TabIndex = 8
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnSalvar, "Salvar Tipo de Documento")
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'frmTipoDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 329)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.grpTipo)
        Me.Controls.Add(Me.lstvTipos)
        Me.Controls.Add(Me.btnIncluir)
        Me.Name = "frmTipoDocumento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tabela de Tipos de Documento"
        Me.grpTipo.ResumeLayout(False)
        Me.grpTipo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnIncluir As System.Windows.Forms.Button
    Friend WithEvents lstvTipos As System.Windows.Forms.ListView
    Friend WithEvents Codigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Tipo As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents grpTipo As System.Windows.Forms.GroupBox
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoTipo As System.Windows.Forms.TextBox
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
End Class
