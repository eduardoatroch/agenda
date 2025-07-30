Public Class clsContato
    Public Shared DadosContato As sContato

    Public Structure sContato
        Public idContato As Guid
        Public CodigoContato As Long
        Public Nome As String
        Public Endereco As String
        Public Bairro As String
        Public Cidade As String
        Public UF As String
        Public UFNome As String
        Public Cep As String
        Public Site As String
        Public Email As String
        Public PessoaContato As String
        Public Atividade As String
        Public Observacoes As String
        Public Telefones As String
        Public DataNascimento As Date
        Public TipoFisicaJuridica As String
    End Structure

    Public Shared Sub CarregarContato(ByVal idContato As String)
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand
        Dim dtr As SqlClient.SqlDataReader
        Dim vIDContato As Guid

        Try
            With cmd
                .CommandType = CommandType.Text
                .Connection = cnn
                '.CommandText = "select * from vwRetornarListaContatos where Codigo=" & pCodigoContato.ToString
                .CommandText = "select * from vwRetornarListaContatosNovo where IDContato='" & idContato & "' "
                cnn.Open()
                dtr = .ExecuteReader
                While dtr.Read
                    'vIDContato = New Guid(idContato)
                    DadosContato.idContato = New Guid(idContato)
                    DadosContato.CodigoContato = CLng(dtr(1))
                    DadosContato.Nome = dtr(2).ToString
                    DadosContato.Endereco = dtr(3).ToString
                    DadosContato.Bairro = dtr(4).ToString
                    DadosContato.Cidade = dtr(5).ToString
                    DadosContato.UF = dtr(6).ToString
                    DadosContato.UFNome = clsRotinas.ObterNomeEstado(DadosContato.UF)
                    DadosContato.Cep = dtr(7).ToString
                    DadosContato.Site = dtr(8).ToString
                    DadosContato.PessoaContato = dtr(9).ToString
                    DadosContato.Atividade = dtr(10).ToString
                    DadosContato.Observacoes = dtr(11).ToString
                    DadosContato.Telefones = dtr(12).ToString
                    DadosContato.DataNascimento = CDate(dtr(13))
                    If dtr(15).ToString.Trim = "" Then
                        DadosContato.TipoFisicaJuridica = "F"
                    Else
                        DadosContato.TipoFisicaJuridica = dtr(15).ToString
                    End If
                End While
                dtr.Close()
                cnn.Close()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Dispose()
            cmd.Dispose()
            GC.Collect()
        End Try

    End Sub

End Class
