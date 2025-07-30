Public Class ContatoTelefone
    Public Shared DadosContatoFone As New sContatoTelefone

    Public Structure sContatoTelefone
        Public idContatoFone As Integer
        Public codigoContato As Long
        Public numeroTelefone As String
        Public tipo As String
        Public flagPrincipal As Boolean
        Public descricaoTelefone As String
    End Structure

    Public Shared Sub CarregarDadosContatoFone(ByVal pIdContatoFone As Integer)
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand
        Dim dtr As SqlClient.SqlDataReader

        Try
            With cmd
                .CommandType = CommandType.Text
                .Connection = cnn
                .CommandText = "select * from vwRetornarListaContatosTelefone where idContatoFone=" & pIdContatoFone.ToString
                cnn.Open()
                dtr = .ExecuteReader
                While dtr.Read
                    ContatoTelefone.DadosContatoFone.idContatoFone = CInt(dtr(0))
                    ContatoTelefone.DadosContatoFone.codigoContato = CLng(dtr(4))
                    ContatoTelefone.DadosContatoFone.numeroTelefone = dtr(1).ToString
                    ContatoTelefone.DadosContatoFone.tipo = dtr(2).ToString
                    ContatoTelefone.DadosContatoFone.flagPrincipal = CBool(dtr(3))
                    ContatoTelefone.DadosContatoFone.descricaoTelefone = dtr(5).ToString
                End While
                dtr.Close()
                cnn.Close()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class
