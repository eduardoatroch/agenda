<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtVa = New System.Windows.Forms.TextBox()
        Me.txtVb = New System.Windows.Forms.TextBox()
        Me.txtVc = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblOrdem = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(154, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Valor 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(272, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Valor 3"
        '
        'txtVa
        '
        Me.txtVa.Location = New System.Drawing.Point(33, 60)
        Me.txtVa.Name = "txtVa"
        Me.txtVa.Size = New System.Drawing.Size(100, 20)
        Me.txtVa.TabIndex = 3
        Me.txtVa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVb
        '
        Me.txtVb.Location = New System.Drawing.Point(157, 60)
        Me.txtVb.Name = "txtVb"
        Me.txtVb.Size = New System.Drawing.Size(100, 20)
        Me.txtVb.TabIndex = 4
        Me.txtVb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVc
        '
        Me.txtVc.Location = New System.Drawing.Point(276, 60)
        Me.txtVc.Name = "txtVc"
        Me.txtVc.Size = New System.Drawing.Size(99, 20)
        Me.txtVc.TabIndex = 5
        Me.txtVc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(33, 205)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Ordenar método Edu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "A ordem crescente é:"
        '
        'lblOrdem
        '
        Me.lblOrdem.AutoSize = True
        Me.lblOrdem.Location = New System.Drawing.Point(154, 269)
        Me.lblOrdem.Name = "lblOrdem"
        Me.lblOrdem.Size = New System.Drawing.Size(0, 13)
        Me.lblOrdem.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(189, 205)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Ordenar método Prof."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(34, 313)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(130, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Limpar Ordenação"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmOrdenar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 392)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblOrdem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtVc)
        Me.Controls.Add(Me.txtVb)
        Me.Controls.Add(Me.txtVa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmOrdenar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordenar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtVa As TextBox
    Friend WithEvents txtVb As TextBox
    Friend WithEvents txtVc As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblOrdem As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
