<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ffrmOrdem
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtV1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtV2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtV3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblOrdem = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor 1"
        '
        'txtV1
        '
        Me.txtV1.Location = New System.Drawing.Point(26, 50)
        Me.txtV1.Name = "txtV1"
        Me.txtV1.Size = New System.Drawing.Size(100, 20)
        Me.txtV1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Valor 2"
        '
        'txtV2
        '
        Me.txtV2.Location = New System.Drawing.Point(26, 107)
        Me.txtV2.Name = "txtV2"
        Me.txtV2.Size = New System.Drawing.Size(100, 20)
        Me.txtV2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Valor 3"
        '
        'txtV3
        '
        Me.txtV3.Location = New System.Drawing.Point(26, 173)
        Me.txtV3.Name = "txtV3"
        Me.txtV3.Size = New System.Drawing.Size(100, 20)
        Me.txtV3.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(209, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Ordem dos valores:"
        '
        'lblOrdem
        '
        Me.lblOrdem.AutoSize = True
        Me.lblOrdem.Location = New System.Drawing.Point(313, 112)
        Me.lblOrdem.Name = "lblOrdem"
        Me.lblOrdem.Size = New System.Drawing.Size(0, 13)
        Me.lblOrdem.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(26, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Ordenar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ffrmOrdem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 295)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblOrdem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtV3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtV2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtV1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ffrmOrdem"
        Me.Text = "ffrmOrdem"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtV1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtV2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtV3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblOrdem As Label
    Friend WithEvents Button1 As Button
End Class
