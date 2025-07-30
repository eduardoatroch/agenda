<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncluirEditarVenda
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
        Me.cboCliente = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpDataVenda = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtParcelas = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtIntervalo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtpVencParcela = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtValorParcela = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtAnimal = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtTaxaJurosMes = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnSair = New System.Windows.Forms.Button
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pbCadastroCliente = New System.Windows.Forms.PictureBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblValorVenda = New System.Windows.Forms.Label
        Me.cboFazenda = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        CType(Me.pbCadastroCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboCliente
        '
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(25, 28)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(341, 21)
        Me.cboCliente.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome do Cliente"
        '
        'dtpDataVenda
        '
        Me.dtpDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataVenda.Location = New System.Drawing.Point(420, 29)
        Me.dtpDataVenda.Name = "dtpDataVenda"
        Me.dtpDataVenda.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataVenda.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(417, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data da Venda"
        '
        'txtParcelas
        '
        Me.txtParcelas.Location = New System.Drawing.Point(25, 112)
        Me.txtParcelas.Name = "txtParcelas"
        Me.txtParcelas.Size = New System.Drawing.Size(45, 20)
        Me.txtParcelas.TabIndex = 2
        Me.txtParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(23, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Qtde Parcelas"
        '
        'txtIntervalo
        '
        Me.txtIntervalo.Location = New System.Drawing.Point(108, 112)
        Me.txtIntervalo.Name = "txtIntervalo"
        Me.txtIntervalo.Size = New System.Drawing.Size(50, 20)
        Me.txtIntervalo.TabIndex = 3
        Me.txtIntervalo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(108, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 40)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Intervalo entre Parcelas"
        '
        'dtpVencParcela
        '
        Me.dtpVencParcela.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVencParcela.Location = New System.Drawing.Point(195, 112)
        Me.dtpVencParcela.Name = "dtpVencParcela"
        Me.dtpVencParcela.Size = New System.Drawing.Size(89, 20)
        Me.dtpVencParcela.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(192, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 29)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Vencimento Inicial"
        '
        'txtValorParcela
        '
        Me.txtValorParcela.Location = New System.Drawing.Point(308, 112)
        Me.txtValorParcela.Name = "txtValorParcela"
        Me.txtValorParcela.Size = New System.Drawing.Size(78, 20)
        Me.txtValorParcela.TabIndex = 5
        Me.txtValorParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(305, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 29)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Valor das Parcelas"
        '
        'txtAnimal
        '
        Me.txtAnimal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAnimal.Location = New System.Drawing.Point(25, 194)
        Me.txtAnimal.MaxLength = 50
        Me.txtAnimal.Name = "txtAnimal"
        Me.txtAnimal.Size = New System.Drawing.Size(355, 20)
        Me.txtAnimal.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Nome do Animal"
        '
        'txtTaxaJurosMes
        '
        Me.txtTaxaJurosMes.Location = New System.Drawing.Point(418, 112)
        Me.txtTaxaJurosMes.Name = "txtTaxaJurosMes"
        Me.txtTaxaJurosMes.Size = New System.Drawing.Size(78, 20)
        Me.txtTaxaJurosMes.TabIndex = 6
        Me.txtTaxaJurosMes.Text = "10,00"
        Me.txtTaxaJurosMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(415, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 29)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Taxa Juros mês para atrasos"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(496, 113)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 19)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "%"
        '
        'btnSair
        '
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.Image = Global.SisFaz.My.Resources.Resources.EXITS
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSair.Location = New System.Drawing.Point(460, 268)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(59, 48)
        Me.btnSair.TabIndex = 18
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnSair, "Sair da tela")
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.Image = Global.SisFaz.My.Resources.Resources.DISK04
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalvar.Location = New System.Drawing.Point(395, 268)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(59, 48)
        Me.btnSalvar.TabIndex = 17
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnSalvar, "Salvar venda")
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'pbCadastroCliente
        '
        Me.pbCadastroCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbCadastroCliente.Image = Global.SisFaz.My.Resources.Resources.pessoas
        Me.pbCadastroCliente.Location = New System.Drawing.Point(372, 18)
        Me.pbCadastroCliente.Name = "pbCadastroCliente"
        Me.pbCadastroCliente.Size = New System.Drawing.Size(33, 31)
        Me.pbCadastroCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCadastroCliente.TabIndex = 19
        Me.pbCadastroCliente.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbCadastroCliente, "Cadastro de Clientes")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 299)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Valor da Venda R$"
        '
        'lblValorVenda
        '
        Me.lblValorVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorVenda.Location = New System.Drawing.Point(142, 297)
        Me.lblValorVenda.Name = "lblValorVenda"
        Me.lblValorVenda.Size = New System.Drawing.Size(97, 19)
        Me.lblValorVenda.TabIndex = 22
        Me.lblValorVenda.Text = "0,00"
        Me.lblValorVenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboFazenda
        '
        Me.cboFazenda.FormattingEnabled = True
        Me.cboFazenda.Location = New System.Drawing.Point(25, 240)
        Me.cboFazenda.Name = "cboFazenda"
        Me.cboFazenda.Size = New System.Drawing.Size(353, 21)
        Me.cboFazenda.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 226)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Fazenda"
        '
        'frmIncluirEditarVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 346)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cboFazenda)
        Me.Controls.Add(Me.lblValorVenda)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.pbCadastroCliente)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTaxaJurosMes)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAnimal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtValorParcela)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpVencParcela)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtIntervalo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtParcelas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpDataVenda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboCliente)
        Me.Name = "frmIncluirEditarVenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Incluir / Alterar Venda"
        CType(Me.pbCadastroCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDataVenda As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtParcelas As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIntervalo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpVencParcela As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtValorParcela As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAnimal As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTaxaJurosMes As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents pbCadastroCliente As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblValorVenda As System.Windows.Forms.Label
    Friend WithEvents cboFazenda As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
