Public Class Extenso

    Private Shared varDoisFeminino As Boolean

    Public Sub New()
    End Sub

    Public Shared Property DoisFeminino() As Boolean
        Get
            Return varDoisFeminino
        End Get
        Set(ByVal Value As Boolean)
            varDoisFeminino = Value
        End Set
    End Property

    Public Shared Function RetornarValorExtenso(ByVal Valor As String) As String

        Dim strResult, strDecimal, strInteiro As String
        Dim VetorValorInteiro() As Char
        Dim Matrix() As String
        Dim CasasDecimais As String
        Dim i, ctd, Grupo, indMat As Integer


        'DIVISÃO DO VALOR EM PARTE INTEIRA E PARTE DECIMAL
        strDecimal = Valor.Substring(Valor.Length - 3, 3)
        strDecimal = strDecimal.Replace(",", "")

        strInteiro = Valor.Substring(0, Valor.Length - 3)
        strInteiro = strInteiro.Replace(".", "")

        'GERAÇÃO DO EXTENSO DA PARTE DECIMAL DO VALOR
        If CInt(strDecimal) = 1 Then
            CasasDecimais = " E UM CENTAVO"
        ElseIf CInt(strDecimal) = 0 Then
            CasasDecimais = ""
        Else
            CasasDecimais = " E " & MontarDezena(strDecimal) & " CENTAVOS"
        End If

        'CRIAÇÃO DO VETOR DE CARACTERES QUE ARMAZENARÁ A PARTE INTEIRA DO VALOR
        VetorValorInteiro = New Char(strInteiro.Length - 1) {}

        ctd = 0
        indMat = 0

        'PREENCHIMENTO DO VETOR COM A PARTE INTEIRA DO VALOR
        For i = 1 To strInteiro.Length
            ctd += 1
            If ctd = 3 Then
                indMat += 1
                ctd = 0
            End If
            VetorValorInteiro(i - 1) = strInteiro.Substring(strInteiro.Length - (i), 1)
        Next

        If ctd > 0 Then indMat += 1

        ctd = 0
        Grupo = 0
        Dim str As String = ""
        Matrix = New String(indMat - 1) {}

        For i = 0 To VetorValorInteiro.Length - 1
            ctd += 1
            str = VetorValorInteiro(i) & str
            If ctd = 3 Then
                Matrix(Grupo) = str
                str = ""
                Grupo += 1
                ctd = 0
            End If
        Next

        If ctd < 3 And ctd > 0 Then Matrix(Grupo) = str

        strInteiro = ""
        For i = 0 To Matrix.Length - 1

            Select Case i
                Case 0
                    strInteiro = MontarGrupoInteiro(Matrix(i)) & strInteiro
                    strInteiro &= " REAIS"
                    If CInt(Matrix(i)) <> 0 Then
                        'Dim DEC As String = OperacoesDecimais.CasasDecimais(CDec(CInt(Matrix(i)) / 100).ToString, 2)
                        Dim DEC As String = clsRotinas.CasasDecimais(CDec(CInt(Matrix(i)) / 100), 2)
                        If CInt(Matrix(i)) > 99 Then
                            If Not Matrix.Length - 1 = i Then
                                If DEC.Substring(DEC.ToString.Length - 2, 2) = "00" And CInt(DEC) <> 0 Then
                                    strInteiro = " E " & strInteiro
                                Else
                                    strInteiro = ", " & strInteiro
                                End If
                            End If
                        End If
                        If CInt(Matrix(i)) < 100 And Matrix(i).Length > 2 Then
                            strInteiro = " E " & strInteiro
                        End If
                    End If
                Case 1
                    strInteiro = " MIL" & strInteiro
                    strInteiro = MontarGrupoInteiro(Matrix(i)) & strInteiro
            End Select

        Next

        strResult = strInteiro & CasasDecimais

        Matrix = Nothing

        Return strResult

    End Function

    Private Shared Function MontarDezena(ByVal Dezena As String) As String

        Dim strTemp As String
        Dim Centenas = New String(9) {}
        Dim Dezenas = New String(9) {}
        Dim Unidades = New String(9) {}
        Dim Teens = New String(9) {}

        Centenas(0) = ""
        Centenas(1) = "CENTO"
        Centenas(2) = "DUZENTOS"
        Centenas(3) = "TREZENTOS"
        Centenas(4) = "QUATROCENTOS"
        Centenas(5) = "QUINHENTOS"
        Centenas(6) = "SEISCENTOS"
        Centenas(7) = "SETECENTOS"
        Centenas(8) = "OITOCENTOS"
        Centenas(9) = "NOVECENTOS"

        Dezenas(0) = ""
        Dezenas(1) = "DEZ"
        Dezenas(2) = "VINTE"
        Dezenas(3) = "TRINTA"
        Dezenas(4) = "QUARENTA"
        Dezenas(5) = "CINQUENTA"
        Dezenas(6) = "SESSENTA"
        Dezenas(7) = "SETENTA"
        Dezenas(8) = "OITENTA"
        Dezenas(9) = "NOVENTA"

        Unidades(0) = ""
        Unidades(1) = "UM"
        Unidades(2) = "DOIS"
        Unidades(3) = "TRES"
        Unidades(4) = "QUATRO"
        Unidades(5) = "CINCO"
        Unidades(6) = "SEIS"
        Unidades(7) = "SETE"
        Unidades(8) = "OITO"
        Unidades(9) = "NOVE"

        Teens(0) = "ONZE"
        Teens(1) = "DOZE"
        Teens(2) = "TREZE"
        Teens(3) = "QUATORZE"
        Teens(4) = "QUINZE"
        Teens(5) = "DEZESSEIS"
        Teens(6) = "DEZESSETE"
        Teens(7) = "DEZOITO"
        Teens(8) = "DEZENOVE"

        'clsRotinas.PreencherVetores()

        Select Case CInt(Dezena)
            Case 0
                strTemp = ""
            Case 10
                strTemp = "DEZ"
            Case 1, 3 To 9
                strTemp = Unidades(CInt(Dezena)).Trim
            Case 2
                'If Extenso.DoisFeminino Then
                '    strTemp = "DUAS"
                'Else
                strTemp = "DOIS"
                'End If
            Case 11 To 19
                strTemp = Teens(CInt(Dezena) - 11).Trim
            Case 20, 30, 40, 50, 60, 70, 80, 90
                strTemp = Dezenas(CInt(Dezena.Substring(0, 1))).Trim
            Case Else
                If Extenso.DoisFeminino Then
                    If CInt(Dezena.Substring(1, 1)) = 2 Then
                        strTemp = Dezenas(CInt(Dezena.Substring(0, 1))) & " E DUAS"
                    Else
                        strTemp = Dezenas(CInt(Dezena.Substring(0, 1))) & " E " & Unidades(CInt(Dezena.Substring(1, 1)))
                    End If
                Else
                    strTemp = Dezenas(CInt(Dezena.Substring(0, 1))) & " E " & Unidades(CInt(Dezena.Substring(1, 1)))
                End If
        End Select

        Return strTemp

    End Function

    Public Shared Function MontarGrupoInteiro(ByVal Grupo As String) As String

        Dim strTemp As String

        Dim Centenas = New String(9) {}
        Dim Dezenas = New String(9) {}
        Dim Unidades = New String(9) {}
        Dim Teens = New String(9) {}

        Centenas(0) = ""
        Centenas(1) = "CENTO"
        Centenas(2) = "DUZENTOS"
        Centenas(3) = "TREZENTOS"
        Centenas(4) = "QUATROCENTOS"
        Centenas(5) = "QUINHENTOS"
        Centenas(6) = "SEISCENTOS"
        Centenas(7) = "SETECENTOS"
        Centenas(8) = "OITOCENTOS"
        Centenas(9) = "NOVECENTOS"

        Dezenas(0) = ""
        Dezenas(1) = "DEZ"
        Dezenas(2) = "VINTE"
        Dezenas(3) = "TRINTA"
        Dezenas(4) = "QUARENTA"
        Dezenas(5) = "CINQUENTA"
        Dezenas(6) = "SESSENTA"
        Dezenas(7) = "SETENTA"
        Dezenas(8) = "OITENTA"
        Dezenas(9) = "NOVENTA"

        Unidades(0) = ""
        Unidades(1) = "UM"
        Unidades(2) = "DOIS"
        Unidades(3) = "TRES"
        Unidades(4) = "QUATRO"
        Unidades(5) = "CINCO"
        Unidades(6) = "SEIS"
        Unidades(7) = "SETE"
        Unidades(8) = "OITO"
        Unidades(9) = "NOVE"

        Teens(0) = "ONZE"
        Teens(1) = "DOZE"
        Teens(2) = "TREZE"
        Teens(3) = "QUATORZE"
        Teens(4) = "QUINZE"
        Teens(5) = "DEZESSEIS"
        Teens(6) = "DEZESSETE"
        Teens(7) = "DEZOITO"
        Teens(8) = "DEZENOVE"

        'clsRotinas.PreencherVetores()

        If CInt(Grupo) > 99 Then
            Select Case CInt(Grupo)
                Case 100
                    strTemp = "CEM"
                Case 200, 300, 400, 500, 600, 700, 800, 900
                    strTemp = Centenas(CInt(Grupo) / 100)
                Case Else
                    strTemp = Centenas(CInt(Grupo.Substring(0, 1))) & " E " & MontarDezena(Grupo.Substring(1, 2))
            End Select
        Else
            strTemp = MontarDezena(CInt(Grupo).ToString)
        End If

        Return strTemp

    End Function

End Class

