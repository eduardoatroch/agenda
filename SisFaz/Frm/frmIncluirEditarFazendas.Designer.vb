<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncluirEditarFazendas
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
        Me.txtNomeFazenda = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtResponsavel = New System.Windows.Forms.TextBox
        Me.txtInscricao = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCpfResponsavel = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtEndereco = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtBairro = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCidade = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cboUF = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCep = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.btnSair = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCaminhoRelatorios = New System.Windows.Forms.TextBox
        Me.txtTelefone = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNomeFazenda
        '
        Me.txtNomeFazenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomeFazenda.Location = New System.Drawing.Point(24, 42)
        Me.txtNomeFazenda.MaxLength = 60
        Me.txtNomeFazenda.Name = "txtNomeFazenda"
        Me.txtNomeFazenda.Size = New System.Drawing.Size(396, 20)
        Me.txtNomeFazenda.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome da Fazenda"
        '
        'txtResponsavel
        '
        Me.txtResponsavel.Location = New System.Drawing.Point(25, 210)
        Me.txtResponsavel.MaxLength = 40
        Me.txtResponsavel.Name = "txtResponsavel"
        Me.txtResponsavel.Size = New System.Drawing.Size(225, 20)
        Me.txtResponsavel.TabIndex = 8
        '
        'txtInscricao
        '
        Me.txtInscricao.Location = New System.Drawing.Point(426, 42)
        Me.txtInscricao.MaxLength = 12
        Me.txtInscricao.Name = "txtInscricao"
        Me.txtInscricao.Size = New System.Drawing.Size(154, 20)
        Me.txtInscricao.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(423, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Inscrição"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nome do Responsável"
        '
        'txtCpfResponsavel
        '
        Me.txtCpfResponsavel.Location = New System.Drawing.Point(256, 210)
        Me.txtCpfResponsavel.MaxLength = 11
        Me.txtCpfResponsavel.Name = "txtCpfResponsavel"
        Me.txtCpfResponsavel.Size = New System.Drawing.Size(112, 20)
        Me.txtCpfResponsavel.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(253, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "CPF do Responsável"
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(24, 100)
        Me.txtEndereco.MaxLength = 50
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(276, 20)
        Me.txtEndereco.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Endereço da Fazenda"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(306, 100)
        Me.txtBairro.MaxLength = 40
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(274, 20)
        Me.txtBairro.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(303, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Bairro da Fazenda"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(24, 154)
        Me.txtCidade.MaxLength = 30
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(248, 20)
        Me.txtCidade.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Cidade da Fazenda"
        '
        'cboUF
        '
        Me.cboUF.FormattingEnabled = True
        Me.cboUF.Items.AddRange(New Object() {"AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO"})
        Me.cboUF.Location = New System.Drawing.Point(278, 153)
        Me.cboUF.Name = "cboUF"
        Me.cboUF.Size = New System.Drawing.Size(66, 21)
        Me.cboUF.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(276, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "UF"
        '
        'txtCep
        '
        Me.txtCep.Location = New System.Drawing.Point(350, 153)
        Me.txtCep.MaxLength = 8
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(112, 20)
        Me.txtCep.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(347, 137)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "CEP"
        '
        'btnSalvar
        '
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.Image = Global.SisFaz.My.Resources.Resources.DISK04
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalvar.Location = New System.Drawing.Point(452, 304)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(61, 48)
        Me.btnSalvar.TabIndex = 11
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnSalvar, "Salvar fazenda")
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.Image = Global.SisFaz.My.Resources.Resources.EXITS
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSair.Location = New System.Drawing.Point(519, 304)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(61, 48)
        Me.btnSair.TabIndex = 12
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnSair, "Sair")
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCaminhoRelatorios)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 293)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 59)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Local dos relatórios na rede"
        '
        'txtCaminhoRelatorios
        '
        Me.txtCaminhoRelatorios.Location = New System.Drawing.Point(6, 25)
        Me.txtCaminhoRelatorios.MaxLength = 100
        Me.txtCaminhoRelatorios.Name = "txtCaminhoRelatorios"
        Me.txtCaminhoRelatorios.Size = New System.Drawing.Size(330, 20)
        Me.txtCaminhoRelatorios.TabIndex = 10
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(468, 153)
        Me.txtTelefone.MaxLength = 15
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(112, 20)
        Me.txtTelefone.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(465, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Telefone"
        '
        'frmIncluirEditarFazendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 375)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCep)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboUF)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCpfResponsavel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtInscricao)
        Me.Controls.Add(Me.txtResponsavel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNomeFazenda)
        Me.Name = "frmIncluirEditarFazendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Incluir/Editar Fazendas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNomeFazenda As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtResponsavel As System.Windows.Forms.TextBox
    Friend WithEvents txtInscricao As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCpfResponsavel As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboUF As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCep As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCaminhoRelatorios As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefone As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
