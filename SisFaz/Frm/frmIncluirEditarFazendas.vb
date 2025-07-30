Public Class frmIncluirEditarFazendas
    Private CodigoFazenda As Integer
    Private Incluir As Boolean

    Public Sub New(ByVal CodFazenda As Integer, ByVal Inc As Boolean)
        MyBase.New()
        InitializeComponent()

        CodigoFazenda = CodFazenda
        Incluir = Inc

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub frmIncluirEditarFazendas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Incluir Then
            RetornarDadosFazenda()
        End If
    End Sub

    Private Sub RetornarDadosFazenda()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarDadosFazenda", cnn)
        Dim dtr As SqlClient.SqlDataReader

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@CodigoFazenda", SqlDbType.SmallInt, 2, "CodigoFazenda")
                .Parameters(0).Value = Me.CodigoFazenda
                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    Me.txtNomeFazenda.Text = dtr(0).ToString
                    Me.txtInscricao.Text = dtr(1).ToString
                    Me.txtEndereco.Text = dtr(2).ToString
                    Me.txtBairro.Text = dtr(3).ToString
                    Me.txtCidade.Text = dtr(4).ToString
                    Me.cboUF.Text = dtr(5).ToString
                    Me.txtCep.Text = dtr(6).ToString
                    Me.txtResponsavel.Text = dtr(7).ToString
                    Me.txtCpfResponsavel.Text = dtr(8).ToString
                    Me.txtTelefone.Text = dtr(9).ToString
                    Me.txtCaminhoRelatorios.Text = dtr(10).ToString
                Loop
                dtr.Close()
                dtr = Nothing
                cnn.Close()
            End With
        Catch ex As Exception
            MsgBox(ex.Source & Chr(13) & ex.Message)
        Finally
            cnn.Dispose()
            cmd.Dispose()
            GC.Collect()
        End Try
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        If Me.txtNomeFazenda.Text.Trim = "" Then
            MsgBox("Informe o nome da fazenda", MsgBoxStyle.Exclamation)
            Me.txtNomeFazenda.Focus()
            Exit Sub
        End If
        If MsgBox("Confirma salvar agora ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SalvarFazenda()
            Me.Close()
        End If
    End Sub

    Private Sub SalvarFazenda()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Connection = cnn

                If Incluir Then
                    .CommandText = "spIncluirFazenda"
                Else
                    .CommandText = "spAlterarFazenda"
                End If

                .Parameters.Add("@NomeFazenda", SqlDbType.VarChar, 60, "NomeFazenda")
                .Parameters(0).Value = Me.txtNomeFazenda.Text.Trim
                .Parameters.Add("@Responsavel", SqlDbType.VarChar, 40, "Responsavel")
                .Parameters(1).Value = Me.txtResponsavel.Text.Trim
                .Parameters.Add("@CpfResponsavel", SqlDbType.VarChar, 11, "CpfResponsavel")
                .Parameters(2).Value = Me.txtCpfResponsavel.Text.Trim
                .Parameters.Add("@Endereco", SqlDbType.VarChar, 50, "Endereco")
                .Parameters(3).Value = Me.txtEndereco.Text.Trim
                .Parameters.Add("@Bairro", SqlDbType.VarChar, 40, "Bairro")
                .Parameters(4).Value = Me.txtBairro.Text.Trim
                .Parameters.Add("@Cidade", SqlDbType.VarChar, 30, "Cidade")
                .Parameters(5).Value = Me.txtCidade.Text.Trim
                .Parameters.Add("@UF", SqlDbType.Char, 2, "UF")
                .Parameters(6).Value = Me.cboUF.Text.Trim
                .Parameters.Add("@Cep", SqlDbType.Char, 8, "Cep")
                .Parameters(7).Value = Me.txtCep.Text.Trim
                .Parameters.Add("@Inscricao", SqlDbType.VarChar, 12, "Inscricao")
                .Parameters(8).Value = Me.txtInscricao.Text.Trim
                .Parameters.Add("@Telefone", SqlDbType.VarChar, 15, "Telefone")
                .Parameters(9).Value = Me.txtTelefone.Text.Trim
                .Parameters.Add("@CaminhoRpt", SqlDbType.VarChar, 100, "CaminhoRpt")
                .Parameters(10).Value = Me.txtCaminhoRelatorios.Text.Trim

                If Not Incluir Then
                    .Parameters.Add("@CodigoFazenda", SqlDbType.SmallInt, 2, "CodigoFazenda")
                    .Parameters(11).Value = Me.CodigoFazenda
                End If

                cnn.Open()
                .ExecuteNonQuery()
                cnn.Close()
            End With
        Catch ex As Exception
            MsgBox(ex.Source & Chr(13) & ex.Message)
        Finally
            cnn.Dispose()
            cmd.Dispose()
            GC.Collect()
        End Try
    End Sub
End Class