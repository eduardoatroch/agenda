Public Class ffrmOrdem
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.txtV1.Text.Trim = "" Then
            MsgBox("Digite o valor 1")
            Exit Sub
        End If
        If Me.txtV2.Text.Trim = "" Then
            MsgBox("Digite o valor 2")
            Exit Sub
        End If
        If Me.txtV3.Text.Trim = "" Then
            MsgBox("Digite o valor 3")
            Exit Sub
        End If

        Dim vA, vB, vC, maior, meio, menor, troca As Integer

        vA = CInt(Me.txtV1.Text)
        vB = CInt(Me.txtV2.Text)
        vC = CInt(Me.txtV3.Text)

        If vA > vB Then
            maior = vA
        Else

        End If


        If (vA > vB) And (vA > vC) Then
            maior = vA
            If vB > vC Then
                meio = vB
                menor = vC
            Else
                meio = vC
                menor = vB
            End If
        Else
            If (vB > vA) And (vB > vC) Then
                maior = vB
                If vA > vC Then
                    meio = vA
                    menor = vC
                Else
                    meio = vC
                    menor = vA
                End If
            Else
                If (vC > vA) And (vC > vB) Then
                    maior = vC
                    If vB > vA Then
                        meio = vA
                        menor = vB
                    Else
                        meio = vB
                        menor = vA
                    End If
                End If
            End If
        End If


        Me.lblOrdem.Text = menor.ToString & ", " & meio.ToString & ", " & maior.ToString

    End Sub

End Class