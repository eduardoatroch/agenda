Public Class frmIncluirEditarFornecedor
    Private CodigoFornecedor As Long
    Private Incluir As Boolean
    Private ValidarCNPJ As String

    Public Sub New(ByVal CodFornec As Long, ByVal Inc As Boolean)
        MyBase.New()
        InitializeComponent()

        CodigoFornecedor = CodFornec
        Incluir = Inc

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub frmIncluirEditarFornecedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PreencherCombobanco()
        If Not Incluir Then
            RetornarDadosFornecedor()
        End If
    End Sub

    Private Sub PreencherCombobanco()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarListaBanco", cnn)
        Dim dtr As SqlClient.SqlDataReader

        Try
            Me.cboBanco.Items.Clear()

            With cmd
                .CommandType = CommandType.StoredProcedure
            
                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    Me.cboBanco.Items.Add(dtr(0) & " - " & dtr(1))
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

    Private Sub RetornarDadosFornecedor()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarDadosFornecedor", cnn)
        Dim dtr As SqlClient.SqlDataReader

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@CodigoFornecedor", SqlDbType.Int, 4, "CodigoFornecedor")
                .Parameters(0).Value = CodigoFornecedor

                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    Me.txtFornecedor.Text = dtr(0).ToString
                    Me.txtCnpj.Text = dtr(1).ToString
                    Me.ValidarCNPJ = dtr(1)
                    Me.cboTipoFornecedor.Text = dtr(2).ToString
                    Me.txtEndereco.Text = dtr(3).ToString
                    Me.txtBairro.Text = dtr(4).ToString
                    Me.txtCidade.Text = dtr(5).ToString
                    Me.cboUF.Text = dtr(6).ToString
                    Me.txtCep.Text = dtr(7).ToString
                    Me.txtEmail.Text = dtr(8).ToString
                    If dtr(9).ToString <> "" Then
                        Me.cboBanco.Text = dtr(9).ToString
                    End If
                    If dtr(10).ToString <> "" Then
                        Me.txtAgencia.Text = dtr(10).ToString
                    End If
                    If dtr(11).ToString <> "" Then
                        Me.txtConta.Text = dtr(11).ToString
                    End If
                    Me.chkAtivo.Checked = CBool(dtr(12))
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
        If Me.txtFornecedor.Text.Trim = "" Then
            MsgBox("Informe o nome do fornecedor", MsgBoxStyle.Exclamation)
            Me.txtFornecedor.Focus()
            Exit Sub
        End If
        If Me.cboTipoFornecedor.Text.Trim = "" Then
            MsgBox("Selecione o Tipo de Fornecedor", MsgBoxStyle.Exclamation)
            Me.cboTipoFornecedor.Focus()
            Exit Sub
        End If

        If MsgBox("Confirma salvar os dados agora ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            If Incluir Then
                If clsRotinas.ValidarExistenciaCnpj(Me.txtCnpj.Text.Trim) = True Then
                    MsgBox("Já existe um Fornecedor com o CNPJ informado", MsgBoxStyle.Information)
                    Exit Sub
                End If
            Else
                If Me.txtCnpj.Text.Trim <> ValidarCNPJ Then
                    If clsRotinas.ValidarExistenciaCnpj(Me.txtCnpj.Text.Trim) = True Then
                        MsgBox("Já existe um Fornecedor com o CNPJ informado", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                End If
            End If
            
            SalvarFornecedor()
            Me.Close()

        End If

    End Sub

    Private Sub SalvarFornecedor()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Connection = cnn

                If Incluir Then
                    .CommandText = "spIncluirFornecedor"
                Else
                    .CommandText = "spAlterarFornecedor"
                End If

                .Parameters.Add("@Fornecedor", SqlDbType.VarChar, 60, "Fornecedor")
                .Parameters(0).Value = Me.txtFornecedor.Text.Trim
                .Parameters.Add("@Cnpj", SqlDbType.VarChar, 14, "Cnpj")
                .Parameters(1).Value = Me.txtCnpj.Text.Trim
                .Parameters.Add("@Tipo", SqlDbType.Bit, 1, "Tipo")
                .Parameters(2).Value = CByte(Me.cboTipoFornecedor.Text.Substring(0, 1))
                .Parameters.Add("@Endereco", SqlDbType.VarChar, 50, "Endereco")
                .Parameters(3).Value = Me.txtEndereco.Text.Trim
                .Parameters.Add("@Bairro", SqlDbType.VarChar, 40, "Bairro")
                .Parameters(4).Value = Me.txtBairro.Text.Trim
                .Parameters.Add("@Cidade", SqlDbType.VarChar, 30, "Cidade")
                .Parameters(5).Value = Me.txtCidade.Text.Trim
                .Parameters.Add("@Uf", SqlDbType.Char, 2, "Uf")
                .Parameters(6).Value = Me.cboUF.Text.Trim
                .Parameters.Add("@Cep", SqlDbType.Char, 8, "Cep")
                .Parameters(7).Value = Me.txtCep.Text.Trim
                .Parameters.Add("@Email", SqlDbType.VarChar, 50, "Email")
                .Parameters(8).Value = Me.txtEmail.Text.Trim
                .Parameters.Add("@Banco", SqlDbType.VarChar, 3, "Banco")
                If Me.cboBanco.Text.Trim <> "" Then
                    .Parameters(9).Value = Me.cboBanco.Text.Substring(0, 3)
                End If
                .Parameters.Add("@Agencia", SqlDbType.VarChar, 10, "Agencia")
                If Me.txtAgencia.Text.Trim <> "" Then
                    .Parameters(10).Value = Me.txtAgencia.Text.Trim
                End If
                .Parameters.Add("@Conta", SqlDbType.VarChar, 10, "Conta")
                If Me.txtConta.Text.Trim <> "" Then
                    .Parameters(11).Value = Me.txtConta.Text.Trim
                End If
                .Parameters.Add("@Ativo", SqlDbType.Bit, 1, "Ativo")
                .Parameters(12).Value = CByte(Me.chkAtivo.Checked)

                If Not Incluir Then
                    .Parameters.Add("@CodigoFornecedor", SqlDbType.Int, 4, "CodigoFornecedor")
                    .Parameters(13).Value = CodigoFornecedor
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