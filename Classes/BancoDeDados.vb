Public Class BancoDeDados
    Public Shared pString As String
    Public Shared pTipoConexaobancoDados As String

    Public Shared Property StringDeConexao() As String
        Get
            pString = MontarStringConexao()
            Return pString
        End Get
        Set(ByVal Value As String)
            pString = Value
        End Set
    End Property

    Public Shared Function MontarStringConexao() As String
        Dim arquivo, Contador As Integer
        Dim Servidor, Login, BD, vSenha, vSenhaCriptografada As String

        Servidor = ""
        BD = ""
        Login = ""
        vSenha = "login@1010"
        vSenhaCriptografada = ""

        arquivo = FreeFile()

        FileOpen(arquivo, Application.StartupPath & "\StringDeConexao.txt", OpenMode.Input, OpenAccess.Read)

        Contador = 1

        While Not EOF(arquivo)

            If Contador = 1 Then
                Servidor = LineInput(arquivo)
            ElseIf Contador = 2 Then
                Login = LineInput(arquivo)
            ElseIf Contador = 3 Then
                BD = LineInput(arquivo)
            End If

            Contador += 1

        End While

        FileClose(arquivo)

        vSenhaCriptografada = Criptografia.CriptografarSenha(vSenha, True)

        'If BancoDeDados.pTipoConexaobancoDados = "01" Then
        pString = "data source=" & Servidor & "; initial catalog=" & BD & ";password=" & vSenha & "; persist security info=false" & "; user id=" & Login & "; workstation id=" & Servidor & "; packet size=4096"
        'ElseIf BancoDeDados.pTipoConexaobancoDados = "02" Then
        '    'String para o Azure
        '    Servidor = "tcp:evtec.database.windows.net,1433"
        '    BD = "EVagenda"
        '    Login = "evteclogin"
        '    pString = "data source=" & Servidor & ";initial catalog=" & BD & ";password=vTGwaoGa1010" & ";persist security info=False" & ";user id=" & Login & ";MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30"
        'ElseIf BancoDeDados.pTipoConexaobancoDados = "03" Then
        '    'Acesso a Somee.com
        '    pString = "data source=EVLOCAWEB.mssql.somee.com; initial catalog=EVLOCAWEB; persist security info=False; user id=aspnetfree_SQLLogin_1; password=474wjowti4; packet size=4096"
        'Else
        '    pString = "data source=" & Servidor & "; initial catalog=" & BD & ";password=" & vSenha & "; persist security info=True" & "; user id=" & Login & "; packet size=4096"
        'End If

        Return pString

    End Function

End Class
