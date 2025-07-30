Public Class clsRotinas

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
            Throw New Exception(ex.Message)
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
                       "Verifique se o valor é um número válido antes de convertê-lo para moeda!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, _
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

    Public Shared Function MascaraCEP(ByVal pCep As String) As String
        Dim vCep As String = ""

        If pCep.Trim.Length <> 8 Then
            Return pCep
        Else

            Dim i, j As Integer
            Dim vetCEP(), vetMascara() As Char

            vetMascara = New Char(13) {}
            vetCEP = New Char(10) {}

            For i = 0 To 7
                vetCEP(i) = pCep.Substring(i, 1)
            Next

            vetMascara(2) = "."
            vetMascara(6) = "-"

            j = 0

            For i = 0 To 7

                Select Case j
                    Case 2
                        j += 1
                    Case 6
                        j += 1
                End Select

                vetMascara(j) = vetCEP(i)
                j += 1

            Next

            vCep = vetMascara(0).ToString

            For i = 1 To vetMascara.Length - 1
                vCep &= vetMascara(i).ToString.Trim
            Next

            Return vCep

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

        'Teste de Ano Bissexto
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

        If Dia > 30 Then
            If Mes = 4 Or Mes = 6 Or Mes = 9 Or Mes = 11 Then
                MsgBox("Dia 31 não válido para o mês digitado.", MsgBoxStyle.Exclamation)
                Return False
            End If
        End If
        If Dia > 31 Then
            MsgBox("Não existe dia maior que 31 nos meses", MsgBoxStyle.Exclamation)
            Return False
        End If

        Return True

    End Function

    Public Shared Function ObterNomeEstado(ByVal pSigla As String) As String
        Dim ArraySigla(27) As String
        Dim ArrayNomes(27) As String
        Dim vNomeEstado As String = ""
        Dim vPosicao As Integer = 0

        Try

            ArraySigla(0) = "AC"
            ArrayNomes(0) = "Acre"
            ArraySigla(1) = "AL"
            ArrayNomes(1) = "Alagoas"
            ArraySigla(2) = "AM"
            ArrayNomes(2) = "Amazonas"
            ArraySigla(3) = "AP"
            ArrayNomes(3) = "Amapá"
            ArraySigla(4) = "BA"
            ArrayNomes(4) = "Bahia"
            ArraySigla(5) = "CE"
            ArrayNomes(5) = "Ceará"
            ArraySigla(6) = "DF"
            ArrayNomes(6) = "Distrito Federal"
            ArraySigla(7) = "ES"
            ArrayNomes(7) = "Espírito Santo"
            ArraySigla(8) = "GO"
            ArrayNomes(8) = "Goiás"
            ArraySigla(9) = "MA"
            ArrayNomes(9) = "Maranhão"
            ArraySigla(10) = "MG"
            ArrayNomes(10) = "Minas Gerais"
            ArraySigla(11) = "MS"
            ArrayNomes(11) = "Mato Grosso do Sul"
            ArraySigla(12) = "MT"
            ArrayNomes(12) = "Mato Grosso"
            ArraySigla(13) = "PA"
            ArrayNomes(13) = "Pará"
            ArraySigla(14) = "PB"
            ArrayNomes(14) = "Paraíba"
            ArraySigla(15) = "PE"
            ArrayNomes(15) = "Pernambuco"
            ArraySigla(16) = "PI"
            ArrayNomes(16) = "Piauí"
            ArraySigla(17) = "PR"
            ArrayNomes(17) = "Paraná"
            ArraySigla(18) = "RJ"
            ArrayNomes(18) = "Rio de Janeiro"
            ArraySigla(19) = "RN"
            ArrayNomes(19) = "Rio Grande do Norte"
            ArraySigla(20) = "RO"
            ArrayNomes(20) = "Rondônia"
            ArraySigla(21) = "RR"
            ArrayNomes(21) = "Roraima"
            ArraySigla(22) = "RS"
            ArrayNomes(22) = "Rio Grande do Sul"
            ArraySigla(23) = "SC"
            ArrayNomes(23) = "Santa Catarina"
            ArraySigla(24) = "SE"
            ArrayNomes(24) = "Sergipe"
            ArraySigla(25) = "SP"
            ArrayNomes(25) = "São Paulo"
            ArraySigla(26) = "TO"
            ArrayNomes(26) = "Tocantins"

            For i As Integer = 0 To 26
                If ArraySigla(i) = pSigla Then
                    vPosicao = i
                    Exit For
                End If
            Next

            vNomeEstado = ArrayNomes(vPosicao)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
        Return vNomeEstado

    End Function

    Public Shared Sub PintarLista(ByRef pLista As ListView)

        Dim I As Integer

        For I = 0 To pLista.Items.Count - 1

            If pLista.Items(I).Selected Then
                pLista.Items(I).BackColor = Color.Blue
                pLista.Items(I).ForeColor = Color.White
            Else
                pLista.Items(I).BackColor = Color.White
                pLista.Items(I).ForeColor = Color.Black
            End If

        Next

    End Sub

    Public Shared Function ObterCaminhoRelatorio() As String
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand
        Dim vRet As String = ""

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 7200
                .Connection = cnn
                .CommandText = "spRetornarCaminhoRelatorio"
                .Parameters.Add("@CaminhoRelatorio", SqlDbType.VarChar, 100)
                .Parameters(0).Direction = ParameterDirection.Output
                cnn.Open()
                .ExecuteNonQuery()
                cnn.Close()
                vRet = .Parameters(0).Value
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return vRet

    End Function

    Public Shared Function NomeDoUsuario() As String
        Dim User As System.Security.Principal.WindowsPrincipal

        Try
            AppDomain.CurrentDomain.SetPrincipalPolicy(Security.Principal.PrincipalPolicy.WindowsPrincipal)
            User = Threading.Thread.CurrentPrincipal
            Return User.Identity.Name.Trim
        Catch ex As Exception
            MessageBox.Show("Erro ao tentar capturar o nome do usuário do Windows." & Chr(13) & ex.Message, "Nome da usuário", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End Try

    End Function

End Class
