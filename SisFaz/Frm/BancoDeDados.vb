Public Class BancoDeDados
    Public Shared lclString As String
    Public Shared BancoSelecionado As String
    Public Shared mapeamentoImpressora As String = ""

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
        Dim arquivo, contador As Integer
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
        contador = 1
        While Not EOF(arquivo)
            If contador = 1 Then
                lclString = LineInput(arquivo)
            ElseIf contador = 2 Then
                mapeamentoImpressora = LineInput(arquivo)
            End If
            contador += 1
        End While

        FileClose(arquivo)
        Return lclString

    End Function

End Class