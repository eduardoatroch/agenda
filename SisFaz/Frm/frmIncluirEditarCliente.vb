Public Class frmIncluirEditarCliente
    Private CodigoCliente As Long
    Private Incluir As Boolean

    Public Sub New(ByVal CodCli As Long, ByVal Inc As Boolean)
        MyBase.New()
        InitializeComponent()
        CodigoCliente = CodCli
        Incluir = Inc
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub frmIncluirEditarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.Incluir = False Then
            RetornarDadosCliente()
        End If
    End Sub

    Private Sub RetornarDadosCliente()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarDadosCliente", cnn)
        Dim dtr As SqlClient.SqlDataReader

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@CodigoCliente", SqlDbType.Int, 4, "CodigoCliente")
                .Parameters(0).Value = CodigoCliente
                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    Me.txtNomeCliente.Text = dtr(0).ToString
                    Me.txtEndereco.Text = dtr(1).ToString
                    Me.cboUF.Text = dtr(2).ToString
                    Me.txtCidade.Text = dtr(3).ToString
                    Me.txtBairro.Text = dtr(4).ToString
                    Me.txtTelefone.Text = dtr(5).ToString
                    Me.txtCep.Text = dtr(6).ToString
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
        If Me.txtNomeCliente.Text.Trim = "" Then
            MsgBox("Informe o nome do cliente por favor!", MsgBoxStyle.Critical)
            Me.txtNomeCliente.Focus()
            Exit Sub
        End If
        If Me.txtEndereco.Text.Trim = "" Then
            MsgBox("Informe o endereço por favor!", MsgBoxStyle.Critical)
            Me.txtEndereco.Focus()
            Exit Sub
        End If
        If Me.cboUF.Text.Trim = "" Then
            MsgBox("Selecione o Estado por favor", MsgBoxStyle.Critical)
            Me.cboUF.Focus()
            Exit Sub
        End If
        If Me.txtCidade.Text.Trim = "" Then
            Me.txtCidade.Focus()
            Exit Sub
        End If
        If Me.txtBairro.Text.Trim = "" Then
            MsgBox("Informe o bairro por favor!", MsgBoxStyle.Critical)
            Me.txtBairro.Focus()
            Exit Sub
        End If
        If Me.txtCep.Text.Trim = "" Then
            MsgBox("Informe o CEP por favor!", MsgBoxStyle.Critical)
            Me.txtCep.Focus()
            Exit Sub
        End If
        If MsgBox("Confirma salvar os dados agora?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SalvarCliente()
            Me.Close()
        End If
    End Sub

    Private Sub SalvarCliente()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand

        Try

            With cmd

                .CommandType = CommandType.StoredProcedure
                .Connection = cnn

                If Incluir Then
                    .CommandText = "spIncluirCliente"
                Else
                    .CommandText = "spAlterarCliente"
                End If

                .Parameters.Add("@NomeCliente", SqlDbType.VarChar, 40, "NomeCliente")
                .Parameters(0).Value = Me.txtNomeCliente.Text.Trim
                .Parameters.Add("@Endereco", SqlDbType.VarChar, 50, "Endereco")
                .Parameters(1).Value = Me.txtEndereco.Text.Trim
                .Parameters.Add("@UF", SqlDbType.Char, 2, "UF")
                .Parameters(2).Value = Me.cboUF.Text.Trim
                .Parameters.Add("@Cidade", SqlDbType.VarChar, 30, "Cidade")
                .Parameters(3).Value = Me.txtCidade.Text.Trim
                .Parameters.Add("@Bairro", SqlDbType.VarChar, 40, "Bairro")
                .Parameters(4).Value = Me.txtBairro.Text.Trim
                .Parameters.Add("@Fone", SqlDbType.VarChar, 15, "Fone")
                .Parameters(5).Value = Me.txtTelefone.Text.Trim
                .Parameters.Add("@Cep", SqlDbType.Char, 8, "Cep")
                .Parameters(6).Value = Me.txtCep.Text.Trim

                If Me.Incluir = False Then
                    .Parameters.Add("@CodigoCliente", SqlDbType.Int, 4, "CodigoCliente")
                    .Parameters(7).Value = CodigoCliente
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