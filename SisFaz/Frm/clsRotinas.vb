Public Class clsRotinas
    Public Shared Usuario As System.Security.Principal.WindowsPrincipal
    Public Shared BancoEscolhido As String

    Public Shared Function PermissaoAcesso(ByVal Codigo As Integer, ByVal Funcao As String) As Boolean
        'Funcao que verifica se o usuário tem acesso a uma dada Rotina do Sistema
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spVerificarPermissaoAcesso", cnn)

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@CodigoUsuario", SqlDbType.SmallInt, 2, "CodigoUsuario")
                .Parameters(0).Value = Codigo
                .Parameters.Add("@Funcao", SqlDbType.VarChar, 20, "Funcao")
                .Parameters(1).Value = Funcao
                .Parameters.Add("@Ret", SqlDbType.Bit, 1, "Ret")
                .Parameters(2).Direction = ParameterDirection.Output
                cnn.Open()
                .ExecuteNonQuery()
                cnn.Close()
                If CBool(.Parameters(2).Value) = True Then
                    Return True
                Else
                    Return False
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Source & Chr(13) & ex.Message)
        Finally
            cnn.Dispose()
            GC.Collect()
        End Try

    End Function

    Public Shared Function CasasDecimais(ByVal Valor As String, ByVal Casas As Byte) As String

        Dim iStr As Integer
        Dim str As String

        str = Decimal.Round(CDec(Valor), Casas)
        iStr = InStr(str, ",")
        If iStr = 0 Then
            str &= ","
            str &= PreenchimentoCasas(Casas)
            Return str
        ElseIf iStr = str.Length - Casas Then
            Return str
        Else
            str &= PreenchimentoCasas(Casas - (str.Length - iStr))
        End If

        Return str

    End Function

    Protected Shared Function PreenchimentoCasas(ByVal NumeroDeCasas As String) As String
        Dim i As Integer
        Dim str As String = ""

        For i = 1 To NumeroDeCasas
            str &= "0"
        Next

        Return str

    End Function

    Public Shared Function Moeda(ByVal Valor As Decimal) As String

        On Error GoTo erro

        Return Valor.ToString("N")

erro:
        Select Case Err.Number
            Case 0
            Case Else
                MsgBox("A rotina de formatação de moeda falhou!" & Chr(13) & _
                       "Provavelmente um valor inválido foi passado." & Chr(13) & _
                       "Verifique se o valor é um número válido antes de convertê-lo para moeda!", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, _
                       "Rotina de formatação de moeda - Classe clsRotinas")
                Exit Function
        End Select
    End Function

    Public Shared Function MascaraCGC(ByVal NumeroCGC As String) As String

        If NumeroCGC.Trim.Length <> 14 Then
            Return NumeroCGC
        Else

            Dim i, j As Integer
            Dim vetCGC(), vetMascara() As Char
            Dim RetVal As String

            vetMascara = New Char(17) {}
            vetCGC = New Char(13) {}

            For i = 0 To 13
                vetCGC(i) = NumeroCGC.Substring(i, 1)
            Next

            vetMascara(2) = "."
            vetMascara(6) = "."
            vetMascara(10) = "/"
            vetMascara(15) = "-"

            j = 0

            For i = 0 To 13

                Select Case j
                    Case 2, 6, 10, 15
                        j += 1
                End Select

                vetMascara(j) = vetCGC(i)
                j += 1

            Next

            RetVal = vetMascara(0).ToString

            For i = 1 To vetMascara.Length - 1
                RetVal &= vetMascara(i).ToString.Trim
            Next

            Return RetVal

        End If

    End Function

    Public Shared Function MascaraCPF(ByVal NumeroCPF As String) As String

        If NumeroCPF.Trim.Length <> 11 Then
            Return NumeroCPF
        Else

            Dim i, j As Integer
            Dim vetCPF(), vetMascara() As Char
            Dim RetVal As String

            vetMascara = New Char(13) {}
            vetCPF = New Char(10) {}

            For i = 0 To 10
                vetCPF(i) = NumeroCPF.Substring(i, 1)
            Next

            vetMascara(3) = "."
            vetMascara(7) = "."
            vetMascara(11) = "-"

            j = 0

            For i = 0 To 10

                Select Case j
                    Case 3, 7, 11
                        j += 1
                End Select

                vetMascara(j) = vetCPF(i)
                j += 1

            Next

            RetVal = vetMascara(0).ToString

            For i = 1 To vetMascara.Length - 1
                RetVal &= vetMascara(i).ToString.Trim
            Next

            Return RetVal

        End If

    End Function

    Public Shared Function ValidarData(ByVal Dta As String) As Boolean
        Dim cDAta As String
        Dim Dia, Mes As Integer
        Dim Ano As Long

        cDAta = Dta

        If cDAta.Substring(2, 1) <> "/" Or cDAta.Substring(5, 1) <> "/" Then
            MsgBox("Data deve estar no Formato dd/mm/aaaa", MsgBoxStyle.Exclamation)
            Return False
        End If
        If cDAta.Length < 10 Then
            MsgBox("Data deve estar no Formato dd/mm/aaaa", MsgBoxStyle.Exclamation)
            Return False
        End If

        Dia = CInt(cDAta.Substring(0, 2))
        Mes = CInt(cDAta.Substring(3, 2))
        Ano = CLng(cDAta.Substring(6, 4))

        If Dia > 28 And Mes = 2 Then
            Return False
        ElseIf Dia > 30 Then
            If Mes = 4 Or Mes = 6 Or Mes = 9 Or Mes = 11 Then
                MsgBox("Dia 31 não válido para o mês digitado.", MsgBoxStyle.Exclamation)
                Return False
            End If
        End If

        If (Ano Mod 4) > 0 Then
            If Mes = 2 Then
                If Dia > 28 Then
                    MsgBox(Ano.ToString & " Não é bissexto, portanto dia não pode ser maior que 28", MsgBoxStyle.Exclamation)
                    Return False
                End If
            End If
        Else
            If Mes = 2 And Dia > 29 Then
                MsgBox("Mês de fevereiro, dia não pode ultrapassar 29, mesmo num ano bissexto.", MsgBoxStyle.Exclamation)
                Return False
            End If
        End If

        Return True

    End Function

    Public Shared Function ValidarExistenciaCnpj(ByVal CNPJ As String) As Boolean
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spVerificarExistenciaMesmoCpf", cnn)

        Try

            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@Cnpj", SqlDbType.VarChar, 14, "Cnpj")
                .Parameters(0).Value = CNPJ
                .Parameters.Add("@Existe", SqlDbType.Bit, 1, "Existe")
                .Parameters(1).Direction = ParameterDirection.Output

                cnn.Open()
                .ExecuteNonQuery()
                cnn.Close()

                If CByte(.Parameters(1).Value) = 0 Then
                    Return False
                Else
                    Return True
                End If

            End With

        Catch ex As Exception
            MsgBox(ex.Source & Chr(13) & ex.Message)
        Finally
            cnn.Dispose()
            cmd.Dispose()
            GC.Collect()
        End Try
    End Function

    Public Shared Function MesPorExtenso(ByVal Mes As Integer) As String
        Dim NomeMes As String

        If Mes = 1 Then
            NomeMes = "JANEIRO"
        ElseIf Mes = 2 Then
            NomeMes = "FEVEREIRO"
        ElseIf Mes = 3 Then
            NomeMes = "MARÇO"
        ElseIf Mes = 4 Then
            NomeMes = "ABRIL"
        ElseIf Mes = 5 Then
            NomeMes = "MAIO"
        ElseIf Mes = 6 Then
            NomeMes = "JUNHO"
        ElseIf Mes = 7 Then
            NomeMes = "JULHO"
        ElseIf Mes = 8 Then
            NomeMes = "AGOSTO"
        ElseIf Mes = 9 Then
            NomeMes = "SETEMBRO"
        ElseIf Mes = 10 Then
            NomeMes = "OUTUBRO"
        ElseIf Mes = 11 Then
            NomeMes = "NOVEMBRO"
        ElseIf Mes = 12 Then
            NomeMes = "DEZEMBRO"
        Else
            NomeMes = ""
        End If

        Return NomeMes

    End Function

    Public Shared Function DataParaSQLServer(ByVal Data As DateTime) As String
        Dim str As String

        str = Data.Year & "-" & Data.Month & "-" & Data.Day & " 00:00:00.000"

        Return str

    End Function

    Public Shared Function NomeDoUsuario() As String

        Try
            AppDomain.CurrentDomain.SetPrincipalPolicy(Security.Principal.PrincipalPolicy.WindowsPrincipal)
            Usuario = Threading.Thread.CurrentPrincipal
            Return Usuario.Identity.Name.Trim
        Catch ex As Exception
            MessageBox.Show("Erro ao tentar capturar o nome do usuário do Windows." & Chr(13) & ex.Message, "Nome da usuário", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End Try

    End Function

    Public Shared Function BancoSelecionado() As String
        Try
            If clsRotinas.NomeDoUsuario = "EMPLAVI_NT\u780" Then
                If MsgBox("Vai usar banco de Desenvolvimento Eduardo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    BancoEscolhido = "D"
                Else
                    BancoEscolhido = "P"
                End If
            Else
                BancoEscolhido = "P"
            End If
            Return BancoEscolhido

        Catch ex As Exception
            MsgBox(ex.Source & Chr(13) & ex.Message)
            Return ""
        End Try
    End Function

End Class
