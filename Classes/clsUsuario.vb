Public Class clsUsuario
    Public Shared DadosUsuario As clsUsuario.sUsuario

    Public Structure sUsuario
        Public IDUsuario As Long
        Public Nome As String
        Public Senha As String
        Public Ativo As String
        Public Email As String
        Public TipoUsuario As String
        Public LoginRede As String
    End Structure

    Public Shared Sub CarregarDadosUsuario(ByVal pCodigoUsuario As Long)
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand
        Dim dtr As SqlClient.SqlDataReader

        Try
            With cmd
                .CommandType = CommandType.Text
                .Connection = cnn
                .CommandText = "select * from vwRetornarDadosUsuario where IDUsuario=" & pCodigoUsuario.ToString
                cnn.Open()
                dtr = .ExecuteReader
                While dtr.Read
                    clsUsuario.DadosUsuario.IDUsuario = pCodigoUsuario
                    clsUsuario.DadosUsuario.Nome = dtr(1).ToString
                    clsUsuario.DadosUsuario.Senha = dtr(2).ToString
                    clsUsuario.DadosUsuario.Ativo = dtr(3).ToString
                    clsUsuario.DadosUsuario.Email = dtr(4).ToString
                    clsUsuario.DadosUsuario.TipoUsuario = dtr(5).ToString
                    clsUsuario.DadosUsuario.LoginRede = dtr(6).ToString
                End While
                dtr.Close()
                cnn.Close()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared Function VerificarExistenciaUsuarioPeloLogin(ByVal pLogin As String) As Long
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spVerificarExistenciaUsuarioPeloLogin", cnn)
        Dim vCodigoUsuario As Long

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@loginUsuario", SqlDbType.VarChar, 50)
                .Parameters(0).Value = pLogin
                .Parameters.Add("@codigoUsuario", SqlDbType.Int, 4)
                .Parameters(1).Direction = ParameterDirection.Output
                cnn.Open()
                .ExecuteNonQuery()
                cnn.Close()
                vCodigoUsuario = CLng(.Parameters(1).Value)
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try

        Return vCodigoUsuario

    End Function

    Public Shared Function ValidarSenha(ByVal pLogin As String, ByVal pSenhaDescriptografada As String) As Boolean
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spValidarSenha", cnn)
        Dim vRet As Boolean = False
        Dim vSenhaCriptografada As String

        Try
            vSenhaCriptografada = clsCriptografarSenha.CriptografarSenha(pSenhaDescriptografada, True)
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@LoginUsuario", SqlDbType.VarChar, 50)
                .Parameters(0).Value = pLogin
                .Parameters.Add("@SenhaCriptografada", SqlDbType.VarChar, 50)
                .Parameters(1).Value = vSenhaCriptografada
                .Parameters.Add("@Valida", SqlDbType.Bit, 1)
                .Parameters(2).Direction = ParameterDirection.Output
                cnn.Open()
                .ExecuteNonQuery()
                cnn.Close()
                vRet = CBool(.Parameters(2).Value)
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return vRet

    End Function

    Public Shared Function ObterNomeUsuarioSemDominio(ByVal pNomeUsuario As String) As String
        Dim vNomeUsuarioSemDominio As String = ""
        Dim vNomeUsuario, caracter As String
        Dim tam As Integer
        Dim vDaqui As Boolean = False

        vNomeUsuario = pNomeUsuario 'Me.txtLogin.Text.Trim
        tam = vNomeUsuario.Length
        vNomeUsuarioSemDominio = String.Empty
        If tam > 0 Then
            For i As Integer = 0 To tam - 1
                caracter = vNomeUsuario.Substring(i, 1)
                If vDaqui = True Then
                    vNomeUsuarioSemDominio &= caracter
                End If
                If caracter = "\" Then
                    vDaqui = True
                End If
            Next
            If vDaqui = False Then
                vNomeUsuarioSemDominio = vNomeUsuario.Trim
            End If
        Else
            vNomeUsuarioSemDominio = vNomeUsuario.Trim
        End If

        Return vNomeUsuarioSemDominio

    End Function

End Class
