Public Class BancoDeDados
    Public Shared lclString As String
    Public Shared BancoSelecionado As String

    Public Shared Property StringDeConexao() As String
        Get
            lclString = MontarStringConexao()
            Return lclString
        End Get
        Set(ByVal Value As String)
            lclString = Value
        End Set
    End Property

    Public Shared Function MontarStringConexao() As String
        Dim arquivo As Integer
        arquivo = FreeFile()

        If clsRotinas.NomeDoUsuario = "EMPLAVI_NT\u780" Then
            If clsRotinas.BancoEscolhido = "D" Then
                FileOpen(arquivo, Application.StartupPath & "\StringDeConexaoNotebook.txt", OpenMode.Input, OpenAccess.Read)
            Else
                FileOpen(arquivo, Application.StartupPath & "\StringDeConexao.txt", OpenMode.Input, OpenAccess.Read)
            End If
        Else
            FileOpen(arquivo, Application.StartupPath & "\StringDeConexao.txt", OpenMode.Input, OpenAccess.Read)
        End If

        While Not EOF(arquivo)
            lclString = LineInput(arquivo)
        End While

        FileClose(arquivo)
        Return lclString

    End Function

End Class