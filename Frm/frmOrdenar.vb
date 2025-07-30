Public Class frmOrdenar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Me.txtVa.Text.Trim = "" Then
            MsgBox("Digite o valor 1")
            Exit Sub
        End If
        If Me.txtVb.Text.Trim = "" Then
            MsgBox("Digite o valor 2")
            Exit Sub
        End If
        If Me.txtVc.Text.Trim = "" Then
            MsgBox("Digite o valor 3")
            Exit Sub
        End If

        Dim v1, v2, v3, maior, meio, menor As Integer

        maior = 0
        meio = 0
        menor = 0

        v1 = CInt(Me.txtVa.Text)
        v2 = CInt(Me.txtVb.Text)
        v3 = CInt(Me.txtVc.Text)

        If v1 > v2 And v1 > v3 Then
            maior = v1
            If v2 > v3 Then
                menor = v3
                meio = v2
            Else
                menor = v2
                meio = v3
            End If
        Else
            If v2 > v1 And v2 > v3 Then
                maior = v2
                If v1 > v3 Then
                    menor = v3
                    meio = v1
                Else
                    menor = v1
                    meio = v3
                End If
            Else
                If v3 > v1 And v3 > v2 Then
                    maior = v3
                    If v1 > v2 Then
                        menor = v2
                        meio = v1
                    Else
                        menor = v1
                        meio = v2
                    End If
                End If
            End If
        End If

        Me.lblOrdem.Text = menor.ToString & " - " & meio.ToString & " - " & maior.ToString

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.txtVa.Text.Trim = "" Then
            MsgBox("Digite o valor 1")
            Exit Sub
        End If
        If Me.txtVb.Text.Trim = "" Then
            MsgBox("Digite o valor 2")
            Exit Sub
        End If
        If Me.txtVc.Text.Trim = "" Then
            MsgBox("Digite o valor 3")
            Exit Sub
        End If

        Dim v1, v2, v3 As Integer

        v1 = CInt(Me.txtVa.Text)
        v2 = CInt(Me.txtVb.Text)
        v3 = CInt(Me.txtVc.Text)


        If v1 < v2 And v1 < v3 And v2 < v3 Then
            Me.lblOrdem.Text = v1.ToString & " - " & v2.ToString & " - " & v3.ToString

        ElseIf v1 < v3 And v1 < v2 And v3 < v2 Then
            Me.lblOrdem.Text = v1.ToString & " - " & v3.ToString & " - " & v2.ToString

        ElseIf v2 < v1 And v2 < v3 And v1 < v3 Then
            Me.lblOrdem.Text = v2.ToString & " - " & v1.ToString & " - " & v3.ToString

        ElseIf v2 < v3 And v2 < v1 And v3 < v1 Then
            Me.lblOrdem.Text = v2.ToString & " - " & v3.ToString & " - " & v1.ToString

        ElseIf v3 < v1 And v3 < v2 And v1 < v2 Then
            Me.lblOrdem.Text = v3.ToString & " - " & v1.ToString & " - " & v2.ToString

        ElseIf v3 < v2 And v3 < v1 And v2 < v1 Then
            Me.lblOrdem.Text = v1.ToString & " - " & v2.ToString & " - " & v3.ToString

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.lblOrdem.Text = String.Empty
    End Sub

End Class