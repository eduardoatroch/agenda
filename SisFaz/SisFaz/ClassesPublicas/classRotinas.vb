Public Class classRotinas

    Public Shared Function PermissaoAcesso(ByVal Codigo As Long, ByVal Funcao As String) As Boolean
        'Funcao que verifica se o usuário tem acesso a uma dada Rotina do Sistema
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spVerificarPermissaoAcesso", cnn)

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@CodigoUsuario", SqlDbType.Int, 4, "CodigoUsuario")
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
            Case 0 'Ok
            Case Else
                MsgBox("Erro na formatação do valor em moeda - classRotinas.vb" & Chr(13) & _
                       "o valor em moeda não deve ter ponto para separar milhar" & Chr(13) & _
                       "e o separador decimal deve ser a vírgula.", MsgBoxStyle.Exclamation)

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

    Public Shared Function DataParaSQLServer(ByVal Data As DateTime) As String
        Dim str As String

        str = Data.Year & "-" & Data.Month & "-" & Data.Day & " 00:00:00.000"

        Return str

    End Function

    Public Shared Function DataParaSQLServer2355(ByVal Data As DateTime) As String
        Dim str As String

        str = Data.Year & "-" & Data.Month & "-" & Data.Day & " 23:55:00.000"

        Return str

    End Function

    Public Shared Function NovaData(ByVal DataInicial As DateTime, _
                                    ByVal DataFinal As DateTime, _
                                    ByVal Dia As Integer, _
                                    ByVal Periodo As String) As DateTime

        Dim ProxMes, ProxAno, Tam, MesIni, MesFim As Integer
        Dim Resto As Decimal
        Dim DiaS, MesS, AnoS As String
        Dim DataNova As DateTime

        Try

            Tam = Dia + 100
            DiaS = Tam.ToString.Substring(1, 2) & "/"
            ProxMes = DataFinal.Month + 1
            ProxAno = DataFinal.Year
            MesIni = DataInicial.Month
            MesFim = DataFinal.Month

            If ProxMes > 12 Then
                ProxMes = 1
                ProxAno += 1
            End If

            If Periodo = "I" Then
                If MesIni <> MesFim Then
                    ProxMes = MesFim
                End If
            End If

            Tam = ProxMes + 100
            MesS = Tam.ToString.Substring(1, 2) & "/"

            Tam = ProxAno + 10000
            AnoS = Tam.ToString.Substring(1, 4)

            If Dia >= 29 And ProxMes = 2 Then
                Resto = ProxAno Mod 4

                'Se resto = 0 então Ano bissexto
                If Resto = 0 Then
                    DataNova = CDate("29/" & MesS & AnoS)
                Else
                    DataNova = CDate("28/" & MesS & AnoS)
                End If
            Else
                DataNova = CDate(DiaS & MesS & AnoS)
            End If

            Return DataNova

        Catch ex As Exception
            MsgBox(ex.Source & Chr(13) & ex.Message)

        End Try

    End Function


    Public Shared Function NovaData(ByVal DataFinal As DateTime, ByVal Dia As Integer) As DateTime
        Dim ProxMes, ProxAno, Tam As Integer
        Dim Resto As Decimal
        Dim DiaS, MesS, AnoS As String
        Dim NovaDataFim As DateTime

        Try

            Tam = Dia + 100
            DiaS = Tam.ToString.Substring(1, 2) & "/"
            ProxMes = DataFinal.Month + 1
            ProxAno = DataFinal.Year

            If ProxMes > 12 Then
                ProxMes = 1
                ProxAno += 1
            End If

            Tam = ProxMes + 100
            MesS = Tam.ToString.Substring(1, 2) & "/"

            Tam = ProxAno + 10000
            AnoS = Tam.ToString.Substring(1, 4)


            If Dia > 29 And ProxMes = 2 Then
                Resto = ProxAno Mod 4
                'Se resto = 0 então Ano bissexto
                If Resto = 0 Then
                    NovaDataFim = CDate("29/" & MesS & AnoS)
                Else
                    NovaDataFim = CDate("28/" & MesS & AnoS)
                End If
            Else
                NovaDataFim = CDate(DiaS & MesS & AnoS)
            End If

            Return NovaDataFim

        Catch ex As Exception
            MsgBox(ex.Source & Chr(13) & ex.Message)

        End Try

    End Function

    Public Shared Function DiaDoMesExtenso(ByVal Dia As Integer) As String

        Dim DiaPorExtenso As String = ""

        If Dia = 1 Then
            DiaPorExtenso = "Um"
        ElseIf Dia = 2 Then
            DiaPorExtenso = "Dois"
        ElseIf Dia = 3 Then
            DiaPorExtenso = "Três"
        ElseIf Dia = 4 Then
            DiaPorExtenso = "Quatro"
        ElseIf Dia = 5 Then
            DiaPorExtenso = "Cinco"
        ElseIf Dia = 6 Then
            DiaPorExtenso = "Seis"
        ElseIf Dia = 7 Then
            DiaPorExtenso = "Sete"
        ElseIf Dia = 8 Then
            DiaPorExtenso = "Oito"
        ElseIf Dia = 9 Then
            DiaPorExtenso = "Nove"
        ElseIf Dia = 10 Then
            DiaPorExtenso = "Dez"
        ElseIf Dia = 11 Then
            DiaPorExtenso = "Onze"
        ElseIf Dia = 12 Then
            DiaPorExtenso = "Doze"
        ElseIf Dia = 13 Then
            DiaPorExtenso = "Treze"
        ElseIf Dia = 14 Then
            DiaPorExtenso = "Quatorze"
        ElseIf Dia = 15 Then
            DiaPorExtenso = "Quinze"
        ElseIf Dia = 16 Then
            DiaPorExtenso = "Dezesseis"
        ElseIf Dia = 17 Then
            DiaPorExtenso = "Dezessete"
        ElseIf Dia = 18 Then
            DiaPorExtenso = "Dezoito"
        ElseIf Dia = 19 Then
            DiaPorExtenso = "Dezenove"
        ElseIf Dia = 20 Then
            DiaPorExtenso = "Vinte"
        ElseIf Dia = 21 Then
            DiaPorExtenso = "Vinte e um"
        ElseIf Dia = 22 Then
            DiaPorExtenso = "Vinte e dois"
        ElseIf Dia = 23 Then
            DiaPorExtenso = "Vinte e três"
        ElseIf Dia = 24 Then
            DiaPorExtenso = "Vinte e quatro"
        ElseIf Dia = 25 Then
            DiaPorExtenso = "Vinte e cinco"
        ElseIf Dia = 26 Then
            DiaPorExtenso = "Vinte e seis"
        ElseIf Dia = 27 Then
            DiaPorExtenso = "Vinte e sete"
        ElseIf Dia = 28 Then
            DiaPorExtenso = "Vinte e oito"
        ElseIf Dia = 29 Then
            DiaPorExtenso = "Vinte e nove"
        ElseIf Dia = 30 Then
            DiaPorExtenso = "Trinta"
        ElseIf Dia = 31 Then
            DiaPorExtenso = "Trinta e um"
        End If

        Return DiaPorExtenso

    End Function

    Public Shared Function DataExtenso(ByVal DataRef As DateTime) As String
        Dim ExtensoData As String = ""

        Try
            If DataRef.Month = 1 Then
                ExtensoData = DataRef.Day.ToString & " de janeiro de " & DataRef.Year.ToString
            ElseIf DataRef.Month = 2 Then
                ExtensoData = DataRef.Day.ToString & " de fevereiro de " & DataRef.Year.ToString
            ElseIf DataRef.Month = 3 Then
                ExtensoData = DataRef.Day.ToString & " de março de " & DataRef.Year.ToString
            ElseIf DataRef.Month = 4 Then
                ExtensoData = DataRef.Day.ToString & " de abril de " & DataRef.Year.ToString
            ElseIf DataRef.Month = 5 Then
                ExtensoData = DataRef.Day.ToString & " de maio de " & DataRef.Year.ToString
            ElseIf DataRef.Month = 6 Then
                ExtensoData = DataRef.Day.ToString & " de junho de " & DataRef.Year.ToString
            ElseIf DataRef.Month = 7 Then
                ExtensoData = DataRef.Day.ToString & " de julho de " & DataRef.Year.ToString
            ElseIf DataRef.Month = 8 Then
                ExtensoData = DataRef.Day.ToString & " de agosto de " & DataRef.Year.ToString
            ElseIf DataRef.Month = 9 Then
                ExtensoData = DataRef.Day.ToString & " de setembro de " & DataRef.Year.ToString
            ElseIf DataRef.Month = 10 Then
                ExtensoData = DataRef.Day.ToString & " de outubro de " & DataRef.Year.ToString
            ElseIf DataRef.Month = 11 Then
                ExtensoData = DataRef.Day.ToString & " de novembro de " & DataRef.Year.ToString
            ElseIf DataRef.Month = 12 Then
                ExtensoData = DataRef.Day.ToString & " de dezembro de " & DataRef.Year.ToString
            End If

            Return ExtensoData

        Catch ex As Exception
            MsgBox(ex.Source & Chr(13) & ex.Message)
        End Try

    End Function

End Class


