Public Class frmIncluirEditarMovimentoCaixa
    Private CodigoLancamento As Long
    Private Incluir As Boolean

    Public Sub New(ByVal CodLanc As Long, ByVal Inc As Boolean)
        MyBase.New()
        InitializeComponent()

        CodigoLancamento = CodLanc
        Incluir = Inc

    End Sub

    Private Sub frmIncluirEditarMovimentoCaixa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PreencherComboFornecedor()
        Me.PreencherComboFazendas()
        Me.PreencherComboBancos()
        Me.PreencherComboFormasPagamento()
        If Not Incluir Then
            EditarLancamento()
            Me.dtpDataBaixa.Focus()
        End If
    End Sub

    Private Sub EditarLancamento()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarDadosMovimentoCaixa", cnn)
        Dim dtr As SqlClient.SqlDataReader

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@CodigoLancamento", SqlDbType.Int, 4, "CodigoLancamento")
                .Parameters(0).Value = Me.CodigoLancamento
                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    Me.dtpDataBaixa.Value = CDate(dtr(0))
                    Me.txtValorBaixa.Text = classRotinas.Moeda(CDec(dtr(1)))
                    Me.cboFornecedor.Text = dtr(2).ToString
                    Me.cboFazenda.Text = dtr(4).ToString
                    Me.cboTipoMov.Text = dtr(3).ToString
                    Me.cboFormaPagamento.Text = dtr(9).ToString
                    Me.cboBanco.Text = dtr(5).ToString
                    Me.cboAgencia.Text = dtr(6).ToString
                    Me.cboConta.Text = dtr(7).ToString
                    Me.txtHistorico.Text = dtr(8).ToString
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

    Private Sub PreencherComboFornecedor()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarListaFornecedores", cnn)
        Dim dtr As SqlClient.SqlDataReader

        Try
            Me.cboFornecedor.Items.Clear()
            With cmd
                .CommandType = CommandType.StoredProcedure
                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    Me.cboFornecedor.Items.Add(dtr(1) & " - " & dtr(0))
                Loop
                dtr.Close()
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

    Private Sub PreencherComboFazendas()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarListaFazendas", cnn)
        Dim dtr As SqlClient.SqlDataReader

        Try
            Me.cboFazenda.Items.Clear()
            With cmd
                .CommandType = CommandType.StoredProcedure
                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    Me.cboFazenda.Items.Add(dtr(1) & " - " & dtr(0))
                Loop
                dtr.Close()
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

    Private Sub PreencherComboBancos()
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

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        If Me.txtValorBaixa.Text.Trim = "" Then
            MsgBox("Informe o valior da baixa por favor!", MsgBoxStyle.Exclamation)
            Me.txtValorBaixa.Focus()
            Exit Sub
        End If
        If Me.cboFornecedor.Text.Trim = "" Then
            MsgBox("Selecione um Fornecedor por favor!", MsgBoxStyle.Exclamation)
            Me.cboFornecedor.Focus()
            Exit Sub
        End If
        If Me.cboFazenda.Text.Trim = "" Then
            MsgBox("Selecione a fazenda por favor!", MsgBoxStyle.Exclamation)
            Me.cboFazenda.Focus()
            Exit Sub
        End If
        If Me.cboFormaPagamento.Text.Trim = "" Then
            MsgBox("Selecione a forma de pagamento por favor!", MsgBoxStyle.Exclamation)
            Me.cboFormaPagamento.Focus()
            Exit Sub
        End If
        If Me.cboTipoMov.Text.Trim = "" Then
            MsgBox("Selecione o tipo de movimento por favor!", MsgBoxStyle.Exclamation)
            Me.cboTipoMov.Focus()
            Exit Sub
        End If
        If Me.cboConta.Text.Trim = "" Then
            MsgBox("Selecione o Banco+Agência+Conta Corrente", MsgBoxStyle.Exclamation)
            Me.cboBanco.Focus()
            Exit Sub
        End If
        If MsgBox("Confirma salvar agora?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Salvar()
        End If
    End Sub

    Private Sub Salvar()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand
        Dim tam As Integer

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Connection = cnn

                If Me.Incluir Then
                    .CommandText = "spIncluirMovimentoCaixa"
                Else
                    .CommandText = "spAlterarMovimentoCaixa"
                End If
                .Parameters.Add("@DataLancamento", SqlDbType.DateTime, 8)
                .Parameters(0).Value = Me.dtpDataBaixa.Value.Date
                .Parameters.Add("@ValorBaixa", SqlDbType.Decimal, 9)
                .Parameters(1).Value = CDec(Me.txtValorBaixa.Text.Trim)
                .Parameters.Add("@CodigoFornecedor", SqlDbType.Int, 4)
                tam = Me.cboFornecedor.Text.Length
                .Parameters(2).Value = CLng(Me.cboFornecedor.Text.Substring(tam - 6, 6))
                .Parameters.Add("@Historico", SqlDbType.VarChar, 100)
                .Parameters(3).Value = Me.txtHistorico.Text.Trim
                .Parameters.Add("@CodigoConta", SqlDbType.Int, 4)
                tam = Me.cboConta.Text.Length
                .Parameters(4).Value = CLng(Me.cboConta.Text.Substring(tam - 4, 4))
                .Parameters.Add("@CodigoFazenda", SqlDbType.SmallInt, 2)
                tam = Me.cboFazenda.Text.Length
                .Parameters(5).Value = CInt(Me.cboFazenda.Text.Substring(tam - 2, 2))
                .Parameters.Add("@FormaPagto", SqlDbType.VarChar, 2)
                .Parameters(6).Value = Me.cboFormaPagamento.Text.Substring(0, 2)
                .Parameters.Add("@TipoMov", SqlDbType.Bit, 1)
                .Parameters(7).Value = CByte(Me.cboTipoMov.Text.Substring(0, 1))
                If Not Me.Incluir Then
                    .Parameters.Add("@CodigoLancamento", SqlDbType.Int, 4)
                    .Parameters(8).Value = Me.CodigoLancamento
                End If
                cnn.Open()
                .ExecuteNonQuery()
                cnn.Close()
                MsgBox("Salvo com sucesso!", MsgBoxStyle.Information)
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Dispose()
            cmd.Dispose()
            GC.Collect()
        End Try
    End Sub

    Private Sub cboBanco_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBanco.SelectedIndexChanged
        PreencherComboAgencias()
    End Sub

    Private Sub PreencherComboAgencias()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarAgenciasDoBanco", cnn)
        Dim dtr As SqlClient.SqlDataReader

        Try
            Me.cboAgencia.Items.Clear()
            Me.cboConta.Items.Clear()
            Me.cboAgencia.Text = ""
            Me.cboConta.Text = ""
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@Banco", SqlDbType.SmallInt, 2)
                .Parameters(0).Value = CInt(Me.cboBanco.Text.Substring(0, 3))
                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    Me.cboAgencia.Items.Add(dtr(1).ToString)
                Loop
                dtr.Close()
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

    Private Sub cboAgencia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAgencia.SelectedIndexChanged
        PreencherComboContas()
    End Sub

    Private Sub PreencherComboContas()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarContasDaAgencia", cnn)
        Dim dtr As SqlClient.SqlDataReader

        Try
            Me.cboConta.Items.Clear()
            Me.cboConta.Text = ""
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@Agencia", SqlDbType.VarChar, 10)
                .Parameters(0).Value = Me.cboAgencia.Text.Trim
                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    Me.cboConta.Items.Add(dtr(1) & " - " & dtr(0))
                Loop
                dtr.Close()
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

    Private Sub PreencherComboFormasPagamento()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarListaFormasPagamento", cnn)
        Dim dtr As SqlClient.SqlDataReader

        Try

            Me.cboFormaPagamento.Text = ""
            With cmd
                .CommandType = CommandType.StoredProcedure
                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    Me.cboFormaPagamento.Items.Add(dtr(0) & " - " & dtr(1))
                Loop
                dtr.Close()
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