<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPortador
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboBanco = New System.Windows.Forms.ComboBox
        Me.cboAgencia = New System.Windows.Forms.ComboBox
        Me.cboConta = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnSair = New System.Windows.Forms.Button
        Me.btnSelecionar = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.dtpDataBaixa = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.chkEmitirCheque = New System.Windows.Forms.CheckBox
        Me.grpCheque = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNominativoCheque = New System.Windows.Forms.TextBox
        Me.chkNominalFornecedor = New System.Windows.Forms.CheckBox
        Me.chkChequeIndividual = New System.Windows.Forms.CheckBox
        Me.grpCheque.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Banco"
        '
        'cboBanco
        '
        Me.cboBanco.FormattingEnabled = True
        Me.cboBanco.Location = New System.Drawing.Point(15, 39)
        Me.cboBanco.Name = "cboBanco"
        Me.cboBanco.Size = New System.Drawing.Size(290, 21)
        Me.cboBanco.TabIndex = 1
        '
        'cboAgencia
        '
        Me.cboAgencia.FormattingEnabled = True
        Me.cboAgencia.Location = New System.Drawing.Point(15, 89)
        Me.cboAgencia.Name = "cboAgencia"
        Me.cboAgencia.Size = New System.Drawing.Size(178, 21)
        Me.cboAgencia.TabIndex = 2
        '
        'cboConta
        '
        Me.cboConta.FormattingEnabled = True
        Me.cboConta.Location = New System.Drawing.Point(15, 140)
        Me.cboConta.Name = "cboConta"
        Me.cboConta.Size = New System.Drawing.Size(126, 21)
        Me.cboConta.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Agência"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Conta"
        '
        'btnSair
        '
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.Image = Global.SisFaz.My.Resources.Resources.EXITS
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(241, 368)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(61, 23)
        Me.btnSair.TabIndex = 7
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnSair, "Sair")
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnSelecionar
        '
        Me.btnSelecionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelecionar.Image = Global.SisFaz.My.Resources.Resources.CHECKMRK
        Me.btnSelecionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSelecionar.Location = New System.Drawing.Point(180, 368)
        Me.btnSelecionar.Name = "btnSelecionar"
        Me.btnSelecionar.Size = New System.Drawing.Size(55, 23)
        Me.btnSelecionar.TabIndex = 6
        Me.btnSelecionar.Text = "Ok"
        Me.btnSelecionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnSelecionar, "Selecionar")
        Me.btnSelecionar.UseVisualStyleBackColor = True
        '
        'dtpDataBaixa
        '
        Me.dtpDataBaixa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataBaixa.Location = New System.Drawing.Point(209, 140)
        Me.dtpDataBaixa.Name = "dtpDataBaixa"
        Me.dtpDataBaixa.Size = New System.Drawing.Size(96, 20)
        Me.dtpDataBaixa.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(206, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Data da Baixa"
        '
        'chkEmitirCheque
        '
        Me.chkEmitirCheque.AutoSize = True
        Me.chkEmitirCheque.Location = New System.Drawing.Point(12, 191)
        Me.chkEmitirCheque.Name = "chkEmitirCheque"
        Me.chkEmitirCheque.Size = New System.Drawing.Size(90, 17)
        Me.chkEmitirCheque.TabIndex = 10
        Me.chkEmitirCheque.Text = "Emitir cheque"
        Me.chkEmitirCheque.UseVisualStyleBackColor = True
        '
        'grpCheque
        '
        Me.grpCheque.Controls.Add(Me.Label5)
        Me.grpCheque.Controls.Add(Me.txtNominativoCheque)
        Me.grpCheque.Controls.Add(Me.chkNominalFornecedor)
        Me.grpCheque.Controls.Add(Me.chkChequeIndividual)
        Me.grpCheque.Location = New System.Drawing.Point(12, 230)
        Me.grpCheque.Name = "grpCheque"
        Me.grpCheque.Size = New System.Drawing.Size(290, 132)
        Me.grpCheque.TabIndex = 11
        Me.grpCheque.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Nominativo do cheque"
        '
        'txtNominativoCheque
        '
        Me.txtNominativoCheque.Location = New System.Drawing.Point(16, 79)
        Me.txtNominativoCheque.MaxLength = 70
        Me.txtNominativoCheque.Name = "txtNominativoCheque"
        Me.txtNominativoCheque.Size = New System.Drawing.Size(268, 20)
        Me.txtNominativoCheque.TabIndex = 13
        '
        'chkNominalFornecedor
        '
        Me.chkNominalFornecedor.AutoSize = True
        Me.chkNominalFornecedor.Checked = True
        Me.chkNominalFornecedor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNominalFornecedor.Location = New System.Drawing.Point(148, 23)
        Me.chkNominalFornecedor.Name = "chkNominalFornecedor"
        Me.chkNominalFornecedor.Size = New System.Drawing.Size(136, 17)
        Me.chkNominalFornecedor.TabIndex = 12
        Me.chkNominalFornecedor.Text = "Nominal ao Fornecedor"
        Me.chkNominalFornecedor.UseVisualStyleBackColor = True
        '
        'chkChequeIndividual
        '
        Me.chkChequeIndividual.AutoSize = True
        Me.chkChequeIndividual.Checked = True
        Me.chkChequeIndividual.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkChequeIndividual.Location = New System.Drawing.Point(16, 23)
        Me.chkChequeIndividual.Name = "chkChequeIndividual"
        Me.chkChequeIndividual.Size = New System.Drawing.Size(110, 17)
        Me.chkChequeIndividual.TabIndex = 11
        Me.chkChequeIndividual.Text = "Cheque individual"
        Me.chkChequeIndividual.UseVisualStyleBackColor = True
        '
        'frmPortador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 402)
        Me.Controls.Add(Me.grpCheque)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpDataBaixa)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnSelecionar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkEmitirCheque)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboConta)
        Me.Controls.Add(Me.cboAgencia)
        Me.Controls.Add(Me.cboBanco)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPortador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Portador (Banco+Agência+Conta)"
        Me.grpCheque.ResumeLayout(False)
        Me.grpCheque.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboBanco As System.Windows.Forms.ComboBox
    Friend WithEvents cboAgencia As System.Windows.Forms.ComboBox
    Friend WithEvents cboConta As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSelecionar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents dtpDataBaixa As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkEmitirCheque As System.Windows.Forms.CheckBox
    Friend WithEvents grpCheque As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNominativoCheque As System.Windows.Forms.TextBox
    Friend WithEvents chkNominalFornecedor As System.Windows.Forms.CheckBox
    Friend WithEvents chkChequeIndividual As System.Windows.Forms.CheckBox
End Class
