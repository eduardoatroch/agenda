<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContasBancarias
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnAlterar = New System.Windows.Forms.Button
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.btnSair = New System.Windows.Forms.Button
        Me.btnIncluir = New System.Windows.Forms.Button
        Me.cboBanco = New System.Windows.Forms.ComboBox
        Me.cboAgencia = New System.Windows.Forms.ComboBox
        Me.lstvContas = New System.Windows.Forms.ListView
        Me.grpConta = New System.Windows.Forms.GroupBox
        Me.txtNumeroConta = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtUltimoCheque = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Codigo = New System.Windows.Forms.ColumnHeader
        Me.NumConta = New System.Windows.Forms.ColumnHeader
        Me.UltCheque = New System.Windows.Forms.ColumnHeader
        Me.grpConta.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAlterar
        '
        Me.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlterar.Image = Global.SisFaz.My.Resources.Resources.NOTE14
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAlterar.Location = New System.Drawing.Point(75, 12)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(57, 45)
        Me.btnAlterar.TabIndex = 1
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnAlterar, "Alterar conta bancária")
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.Image = Global.SisFaz.My.Resources.Resources.WASTE
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExcluir.Location = New System.Drawing.Point(138, 12)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(57, 45)
        Me.btnExcluir.TabIndex = 2
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnExcluir, "Excluir conta bancária")
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.Image = Global.SisFaz.My.Resources.Resources.DISK04
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalvar.Location = New System.Drawing.Point(201, 12)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(57, 45)
        Me.btnSalvar.TabIndex = 3
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnSalvar, "Salvar conta")
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.Image = Global.SisFaz.My.Resources.Resources.EXITS
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSair.Location = New System.Drawing.Point(264, 12)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(57, 45)
        Me.btnSair.TabIndex = 4
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
        Me.btnIncluir.Size = New System.Drawing.Size(57, 45)
        Me.btnIncluir.TabIndex = 0
        Me.btnIncluir.Text = "Incluir"
        Me.btnIncluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnIncluir, "Incluir nova conta")
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'cboBanco
        '
        Me.cboBanco.FormattingEnabled = True
        Me.cboBanco.Location = New System.Drawing.Point(12, 90)
        Me.cboBanco.Name = "cboBanco"
        Me.cboBanco.Size = New System.Drawing.Size(309, 21)
        Me.cboBanco.TabIndex = 5
        '
        'cboAgencia
        '
        Me.cboAgencia.FormattingEnabled = True
        Me.cboAgencia.Location = New System.Drawing.Point(12, 138)
        Me.cboAgencia.Name = "cboAgencia"
        Me.cboAgencia.Size = New System.Drawing.Size(183, 21)
        Me.cboAgencia.TabIndex = 6
        '
        'lstvContas
        '
        Me.lstvContas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Codigo, Me.NumConta, Me.UltCheque})
        Me.lstvContas.FullRowSelect = True
        Me.lstvContas.GridLines = True
        Me.lstvContas.Location = New System.Drawing.Point(12, 183)
        Me.lstvContas.Name = "lstvContas"
        Me.lstvContas.Size = New System.Drawing.Size(369, 97)
        Me.lstvContas.TabIndex = 7
        Me.lstvContas.UseCompatibleStateImageBehavior = False
        Me.lstvContas.View = System.Windows.Forms.View.Details
        '
        'grpConta
        '
        Me.grpConta.Controls.Add(Me.Label2)
        Me.grpConta.Controls.Add(Me.txtUltimoCheque)
        Me.grpConta.Controls.Add(Me.Label1)
        Me.grpConta.Controls.Add(Me.txtNumeroConta)
        Me.grpConta.Location = New System.Drawing.Point(12, 293)
        Me.grpConta.Name = "grpConta"
        Me.grpConta.Size = New System.Drawing.Size(369, 56)
        Me.grpConta.TabIndex = 8
        Me.grpConta.TabStop = False
        Me.grpConta.Text = "Conta selecionada"
        '
        'txtNumeroConta
        '
        Me.txtNumeroConta.Location = New System.Drawing.Point(6, 30)
        Me.txtNumeroConta.MaxLength = 10
        Me.txtNumeroConta.Name = "txtNumeroConta"
        Me.txtNumeroConta.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroConta.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nº da Conta"
        '
        'txtUltimoCheque
        '
        Me.txtUltimoCheque.Location = New System.Drawing.Point(126, 30)
        Me.txtUltimoCheque.Name = "txtUltimoCheque"
        Me.txtUltimoCheque.Size = New System.Drawing.Size(88, 20)
        Me.txtUltimoCheque.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(123, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nº Último Cheque"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Banco"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Agências do Banco"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Contas da Agência"
        '
        'Codigo
        '
        Me.Codigo.Text = "Código"
        '
        'NumConta
        '
        Me.NumConta.Text = "Nº da Conta"
        Me.NumConta.Width = 100
        '
        'UltCheque
        '
        Me.UltCheque.Text = "Nº Últ. Cheque"
        Me.UltCheque.Width = 90
        '
        'frmContasBancarias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 361)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grpConta)
        Me.Controls.Add(Me.lstvContas)
        Me.Controls.Add(Me.cboAgencia)
        Me.Controls.Add(Me.cboBanco)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnIncluir)
        Me.Name = "frmContasBancarias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contas Bancárias"
        Me.grpConta.ResumeLayout(False)
        Me.grpConta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnIncluir As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents cboBanco As System.Windows.Forms.ComboBox
    Friend WithEvents cboAgencia As System.Windows.Forms.ComboBox
    Friend WithEvents lstvContas As System.Windows.Forms.ListView
    Friend WithEvents grpConta As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUltimoCheque As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroConta As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Codigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents NumConta As System.Windows.Forms.ColumnHeader
    Friend WithEvents UltCheque As System.Windows.Forms.ColumnHeader
End Class
