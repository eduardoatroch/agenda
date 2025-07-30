Imports System.Text
Public Class Criptografia

    Public Shared Function CriptografarSenha(ByVal Texto As String, ByVal Operacao As Boolean) As String
        Dim Senha As String

        If Operacao Then
            Senha = Cifra(Texto)
        Else
            Senha = DeCifra(Texto)
        End If

        Return Senha

    End Function

    Private Shared Function Cifra(ByVal Texto As String) As String
        Dim SenhaCifrada As String
        Dim i As Integer
        Dim vCaracteres() As Byte = ASCIIEncoding.ASCII.GetBytes(Texto)

        SenhaCifrada = ""

        For i = 0 To vCaracteres.Length - 1
            SenhaCifrada &= Chr(vCaracteres(i) + 3)
        Next

        Return SenhaCifrada

    End Function

    Private Shared Function DeCifra(ByVal Texto As String) As String
        Dim SenhaDecifrada As String
        Dim i As Integer
        Dim vCaracteres() As Byte = ASCIIEncoding.ASCII.GetBytes(Texto)

        SenhaDecifrada = ""

        For i = 0 To vCaracteres.Length - 1
            SenhaDecifrada &= Chr(vCaracteres(i) - 3)
        Next

        Return SenhaDecifrada

    End Function

End Class
