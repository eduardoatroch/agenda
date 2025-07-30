<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheques
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
        Me.cboBanco = New System.Windows.Forms.ComboBox()
        Me.cboAgencia = New System.Windows.Forms.ComboBox()
        Me.cboConta = New System.Windows.Forms.ComboBox()
        Me.grpPeriodo = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDataFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpDataInicial = New System.Windows.Forms.DateTimePicker()
        Me.grpStatus = New System.Windows.Forms.GroupBox()
        Me.rbStatusCancelado = New System.Windows.Forms.RadioButton()
        Me.rbStatusNaoCancelado = New System.Windows.Forms.RadioButton()
        Me.rbStatusGeral = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbImpSim = New System.Windows.Forms.RadioButton()
        Me.rbImpNao = New System.Windows.Forms.RadioButton()
        Me.rbImpGeral = New System.Windows.Forms.RadioButton()
        Me.lstvCheques = New System.Windows.Forms.ListView()
        Me.CodigoCheque = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NumCheque = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DataEmissao = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Valor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nominativo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Impresso = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cancelado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DtCancelamento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Banco = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Agencia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Conta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ValorExtenso = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grpDataCancelamento = New System.Windows.Forms.GroupBox()
        Me.btnConfirmarCancelamento = New System.Windows.Forms.Button()
        Me.dtpDataCancelamento = New System.Windows.Forms.DateTimePicker()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.grpPeriodo.SuspendLayout()
        Me.grpStatus.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpDataCancelamento.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboBanco
        '
        Me.cboBanco.FormattingEnabled = True
        Me.cboBanco.Location = New System.Drawing.Point(12, 28)
        Me.cboBanco.Name = "cboBanco"
        Me.cboBanco.Size = New System.Drawing.Size(336, 21)
        Me.cboBanco.TabIndex = 0
        '
        'cboAgencia
        '
        Me.cboAgencia.FormattingEnabled = True
        Me.cboAgencia.Location = New System.Drawing.Point(369, 28)
        Me.cboAgencia.Name = "cboAgencia"
        Me.cboAgencia.Size = New System.Drawing.Size(151, 21)
        Me.cboAgencia.TabIndex = 1
        '
        'cboConta
        '
        Me.cboConta.FormattingEnabled = True
        Me.cboConta.Location = New System.Drawing.Point(541, 28)
        Me.cboConta.Name = "cboConta"
        Me.cboConta.Size = New System.Drawing.Size(127, 21)
        Me.cboConta.TabIndex = 2
        '
        'grpPeriodo
        '
        Me.grpPeriodo.Controls.Add(Me.Label2)
        Me.grpPeriodo.Controls.Add(Me.Label1)
        Me.grpPeriodo.Controls.Add(Me.dtpDataFinal)
        Me.grpPeriodo.Controls.Add(Me.dtpDataInicial)
        Me.grpPeriodo.Location = New System.Drawing.Point(12, 65)
        Me.grpPeriodo.Name = "grpPeriodo"
        Me.grpPeriodo.Size = New System.Drawing.Size(232, 84)
        Me.grpPeriodo.TabIndex = 3
        Me.grpPeriodo.TabStop = False
        Me.grpPeriodo.Text = "Período"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(117, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Data inicial"
        '
        'dtpDataFinal
        '
        Me.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataFinal.Location = New System.Drawing.Point(120, 41)
        Me.dtpDataFinal.Name = "dtpDataFinal"
        Me.dtpDataFinal.Size = New System.Drawing.Size(94, 20)
        Me.dtpDataFinal.TabIndex = 1
        '
        'dtpDataInicial
        '
        Me.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataInicial.Location = New System.Drawing.Point(14, 41)
        Me.dtpDataInicial.Name = "dtpDataInicial"
        Me.dtpDataInicial.Size = New System.Drawing.Size(94, 20)
        Me.dtpDataInicial.TabIndex = 0
        '
        'grpStatus
        '
        Me.grpStatus.Controls.Add(Me.rbStatusCancelado)
        Me.grpStatus.Controls.Add(Me.rbStatusNaoCancelado)
        Me.grpStatus.Controls.Add(Me.rbStatusGeral)
        Me.grpStatus.Location = New System.Drawing.Point(262, 65)
        Me.grpStatus.Name = "grpStatus"
        Me.grpStatus.Size = New System.Drawing.Size(125, 84)
        Me.grpStatus.TabIndex = 4
        Me.grpStatus.TabStop = False
        Me.grpStatus.Text = "Status do cheque"
        '
        'rbStatusCancelado
        '
        Me.rbStatusCancelado.AutoSize = True
        Me.rbStatusCancelado.Location = New System.Drawing.Point(10, 41)
        Me.rbStatusCancelado.Name = "rbStatusCancelado"
        Me.rbStatusCancelado.Size = New System.Drawing.Size(76, 17)
        Me.rbStatusCancelado.TabIndex = 2
        Me.rbStatusCancelado.Text = "Cancelado"
        Me.rbStatusCancelado.UseVisualStyleBackColor = True
        '
        'rbStatusNaoCancelado
        '
        Me.rbStatusNaoCancelado.AutoSize = True
        Me.rbStatusNaoCancelado.Checked = True
        Me.rbStatusNaoCancelado.Location = New System.Drawing.Point(10, 19)
        Me.rbStatusNaoCancelado.Name = "rbStatusNaoCancelado"
        Me.rbStatusNaoCancelado.Size = New System.Drawing.Size(98, 17)
        Me.rbStatusNaoCancelado.TabIndex = 1
        Me.rbStatusNaoCancelado.TabStop = True
        Me.rbStatusNaoCancelado.Text = "Não cancelado"
        Me.rbStatusNaoCancelado.UseVisualStyleBackColor = True
        '
        'rbStatusGeral
        '
        Me.rbStatusGeral.AutoSize = True
        Me.rbStatusGeral.Location = New System.Drawing.Point(10, 61)
        Me.rbStatusGeral.Name = "rbStatusGeral"
        Me.rbStatusGeral.Size = New System.Drawing.Size(50, 17)
        Me.rbStatusGeral.TabIndex = 0
        Me.rbStatusGeral.Text = "Geral"
        Me.rbStatusGeral.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Banco"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(366, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Agência"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(539, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Conta corrente"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbImpSim)
        Me.GroupBox1.Controls.Add(Me.rbImpNao)
        Me.GroupBox1.Controls.Add(Me.rbImpGeral)
        Me.GroupBox1.Location = New System.Drawing.Point(407, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(113, 84)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status impressão"
        '
        'rbImpSim
        '
        Me.rbImpSim.AutoSize = True
        Me.rbImpSim.Location = New System.Drawing.Point(15, 40)
        Me.rbImpSim.Name = "rbImpSim"
        Me.rbImpSim.Size = New System.Drawing.Size(67, 17)
        Me.rbImpSim.TabIndex = 3
        Me.rbImpSim.Text = "Impresso"
        Me.rbImpSim.UseVisualStyleBackColor = True
        '
        'rbImpNao
        '
        Me.rbImpNao.AutoSize = True
        Me.rbImpNao.Checked = True
        Me.rbImpNao.Location = New System.Drawing.Point(15, 19)
        Me.rbImpNao.Name = "rbImpNao"
        Me.rbImpNao.Size = New System.Drawing.Size(89, 17)
        Me.rbImpNao.TabIndex = 2
        Me.rbImpNao.TabStop = True
        Me.rbImpNao.Text = "Não impresso"
        Me.rbImpNao.UseVisualStyleBackColor = True
        '
        'rbImpGeral
        '
        Me.rbImpGeral.AutoSize = True
        Me.rbImpGeral.Location = New System.Drawing.Point(15, 61)
        Me.rbImpGeral.Name = "rbImpGeral"
        Me.rbImpGeral.Size = New System.Drawing.Size(50, 17)
        Me.rbImpGeral.TabIndex = 1
        Me.rbImpGeral.Text = "Geral"
        Me.rbImpGeral.UseVisualStyleBackColor = True
        '
        'lstvCheques
        '
        Me.lstvCheques.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CodigoCheque, Me.NumCheque, Me.DataEmissao, Me.Valor, Me.Nominativo, Me.Impresso, Me.Cancelado, Me.DtCancelamento, Me.Banco, Me.Agencia, Me.Conta, Me.ValorExtenso})
        Me.lstvCheques.FullRowSelect = True
        Me.lstvCheques.Location = New System.Drawing.Point(12, 171)
        Me.lstvCheques.Name = "lstvCheques"
        Me.lstvCheques.Size = New System.Drawing.Size(690, 204)
        Me.lstvCheques.TabIndex = 9
        Me.lstvCheques.UseCompatibleStateImageBehavior = False
        Me.lstvCheques.View = System.Windows.Forms.View.Details
        '
        'CodigoCheque
        '
        Me.CodigoCheque.Text = "Código"
        '
        'NumCheque
        '
        Me.NumCheque.Text = "Nº do Cheque"
        Me.NumCheque.Width = 85
        '
        'DataEmissao
        '
        Me.DataEmissao.Text = "Dt.Emissão"
        Me.DataEmissao.Width = 80
        '
        'Valor
        '
        Me.Valor.Text = "Valor R$"
        Me.Valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Valor.Width = 80
        '
        'Nominativo
        '
        Me.Nominativo.Text = "Nominativo"
        Me.Nominativo.Width = 150
        '
        'Impresso
        '
        Me.Impresso.Text = "Impresso"
        Me.Impresso.Width = 70
        '
        'Cancelado
        '
        Me.Cancelado.Text = "Cancelado"
        Me.Cancelado.Width = 70
        '
        'DtCancelamento
        '
        Me.DtCancelamento.Text = "Dt.Cancel."
        Me.DtCancelamento.Width = 80
        '
        'Banco
        '
        Me.Banco.Text = "Banco"
        '
        'Agencia
        '
        Me.Agencia.Text = "Agência"
        Me.Agencia.Width = 70
        '
        'Conta
        '
        Me.Conta.Text = "Conta"
        Me.Conta.Width = 80
        '
        'ValorExtenso
        '
        Me.ValorExtenso.Text = "Vlr. por Extenso "
        Me.ValorExtenso.Width = 400
        '
        'grpDataCancelamento
        '
        Me.grpDataCancelamento.Controls.Add(Me.btnConfirmarCancelamento)
        Me.grpDataCancelamento.Controls.Add(Me.dtpDataCancelamento)
        Me.grpDataCancelamento.Location = New System.Drawing.Point(541, 65)
        Me.grpDataCancelamento.Name = "grpDataCancelamento"
        Me.grpDataCancelamento.Size = New System.Drawing.Size(161, 59)
        Me.grpDataCancelamento.TabIndex = 10
        Me.grpDataCancelamento.TabStop = False
        Me.grpDataCancelamento.Text = "Data cancelamento"
        Me.grpDataCancelamento.Visible = False
        '
        'btnConfirmarCancelamento
        '
        Me.btnConfirmarCancelamento.BackgroundImage = Global.SisFaz.My.Resources.Resources.CHECKMRK
        Me.btnConfirmarCancelamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConfirmarCancelamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirmarCancelamento.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConfirmarCancelamento.Location = New System.Drawing.Point(114, 16)
        Me.btnConfirmarCancelamento.Name = "btnConfirmarCancelamento"
        Me.btnConfirmarCancelamento.Size = New System.Drawing.Size(34, 34)
        Me.btnConfirmarCancelamento.TabIndex = 13
        Me.btnConfirmarCancelamento.Text = "ok"
        Me.btnConfirmarCancelamento.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.btnConfirmarCancelamento, "Confirmar o cancelamento")
        Me.btnConfirmarCancelamento.UseVisualStyleBackColor = True
        '
        'dtpDataCancelamento
        '
        Me.dtpDataCancelamento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataCancelamento.Location = New System.Drawing.Point(14, 24)
        Me.dtpDataCancelamento.Name = "dtpDataCancelamento"
        Me.dtpDataCancelamento.Size = New System.Drawing.Size(94, 20)
        Me.dtpDataCancelamento.TabIndex = 1
        '
        'btnImprimir
        '
        Me.btnImprimir.BackgroundImage = Global.SisFaz.My.Resources.Resources.printer
        Me.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(88, 381)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(70, 59)
        Me.btnImprimir.TabIndex = 11
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnImprimir, "Imprimir o(s) cheque(s) selecionado(s)")
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = Global.SisFaz.My.Resources.Resources.W95MBX01
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelar.Location = New System.Drawing.Point(164, 381)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(70, 59)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnCancelar, "Cancelar o(s) cheque(s) selecionado(s)")
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.BackgroundImage = Global.SisFaz.My.Resources.Resources.EXITS
        Me.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSair.Location = New System.Drawing.Point(632, 381)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(70, 59)
        Me.btnSair.TabIndex = 13
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnSair, "Sair")
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnPesquisar
        '
        Me.btnPesquisar.BackgroundImage = Global.SisFaz.My.Resources.Resources.BINOCULR
        Me.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPesquisar.Location = New System.Drawing.Point(12, 381)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(70, 59)
        Me.btnPesquisar.TabIndex = 14
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnPesquisar, "Pesquisar baseado nos parâmetros")
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'frmCheques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 452)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.grpDataCancelamento)
        Me.Controls.Add(Me.lstvCheques)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grpStatus)
        Me.Controls.Add(Me.grpPeriodo)
        Me.Controls.Add(Me.cboConta)
        Me.Controls.Add(Me.cboAgencia)
        Me.Controls.Add(Me.cboBanco)
        Me.Name = "frmCheques"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cheques"
        Me.grpPeriodo.ResumeLayout(False)
        Me.grpPeriodo.PerformLayout()
        Me.grpStatus.ResumeLayout(False)
        Me.grpStatus.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpDataCancelamento.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboBanco As System.Windows.Forms.ComboBox
    Friend WithEvents cboAgencia As System.Windows.Forms.ComboBox
    Friend WithEvents cboConta As System.Windows.Forms.ComboBox
    Friend WithEvents grpPeriodo As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDataFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDataInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents grpStatus As System.Windows.Forms.GroupBox
    Friend WithEvents rbStatusGeral As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rbStatusCancelado As System.Windows.Forms.RadioButton
    Friend WithEvents rbStatusNaoCancelado As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbImpSim As System.Windows.Forms.RadioButton
    Friend WithEvents rbImpNao As System.Windows.Forms.RadioButton
    Friend WithEvents rbImpGeral As System.Windows.Forms.RadioButton
    Friend WithEvents lstvCheques As System.Windows.Forms.ListView
    Friend WithEvents CodigoCheque As System.Windows.Forms.ColumnHeader
    Friend WithEvents NumCheque As System.Windows.Forms.ColumnHeader
    Friend WithEvents DataEmissao As System.Windows.Forms.ColumnHeader
    Friend WithEvents Valor As System.Windows.Forms.ColumnHeader
    Friend WithEvents Nominativo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Impresso As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cancelado As System.Windows.Forms.ColumnHeader
    Friend WithEvents DtCancelamento As System.Windows.Forms.ColumnHeader
    Friend WithEvents grpDataCancelamento As System.Windows.Forms.GroupBox
    Friend WithEvents dtpDataCancelamento As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnPesquisar As System.Windows.Forms.Button
    Friend WithEvents btnConfirmarCancelamento As System.Windows.Forms.Button
    Friend WithEvents Banco As System.Windows.Forms.ColumnHeader
    Friend WithEvents Agencia As System.Windows.Forms.ColumnHeader
    Friend WithEvents Conta As System.Windows.Forms.ColumnHeader
    Friend WithEvents ValorExtenso As System.Windows.Forms.ColumnHeader
End Class
