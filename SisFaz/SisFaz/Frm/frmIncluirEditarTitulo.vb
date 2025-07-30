Public Class frmIncluirEditarTitulo
    Private CodigoCAP As Long
    Private Incluir As Boolean

    Public Sub New(ByVal Cap As Long, ByVal Inc As Boolean)
        MyBase.New()
        InitializeComponent()

        CodigoCAP = Cap
        Incluir = Inc

    End Sub

    Private Sub frmIncluirEditarTitulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PreencherComboTiposDocumento()
        PreencherComboFornecedores()
        PreencherComboFazendas()

        If Not Me.Incluir Then
            RetornarDadosTitulo()
        Else
            Me.dtpDataPagamento.Enabled = False
            Me.txtValorPago.Enabled = False
        End If
    End Sub

    Private Sub PreencherComboTiposDocumento()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarListaTipoDocumento", cnn)
        Dim dtr As SqlClient.SqlDataReader

        Try
            Me.cboTipoDocumento.Items.Clear()

            With cmd
                .CommandType = CommandType.StoredProcedure
                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    Me.cboTipoDocumento.Items.Add(dtr(0) & " - " & dtr(1))
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

    Private Sub PreencherComboFornecedores()
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
                    Me.cboFazenda.Items.Add(dtr(0) & " - " & dtr(1))
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


    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        If Me.cboTipoDocumento.Text.Trim = "" Then
            MsgBox("Selecione o tipo de documento", MsgBoxStyle.Exclamation)
            Me.cboTipoDocumento.Focus()
            Exit Sub
        End If
        If Me.cboFornecedor.Text.Trim = "" Then
            MsgBox("Selecione um fornecedor", MsgBoxStyle.Exclamation)
            Me.cboFornecedor.Focus()
            Exit Sub
        End If
        If Me.txtValorOriginal.Text.Trim = "" Then
            MsgBox("Informe o valor original", MsgBoxStyle.Exclamation)
            Me.txtValorOriginal.Focus()
            Exit Sub
        End If
        If Me.cboFazenda.Text.Trim = "" Then
            MsgBox("Selecione a fazenda", MsgBoxStyle.Exclamation)
            Me.cboFazenda.Focus()
            Exit Sub
        End If
        If Me.txtHistorico.Text.Trim = "" Then
            MsgBox("Informe o histórico do lançamento", MsgBoxStyle.Exclamation)
            Me.txtHistorico.Focus()
            Exit Sub
        End If
        If MsgBox("Confirma salvar ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SalvarTitulo()
            Me.Close()
        End If
    End Sub

    Private Sub SalvarTitulo()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand
        Dim tam As Integer

        Try

            With cmd
                .CommandType = CommandType.StoredProcedure
                .Connection = cnn

                If Me.Incluir Then
                    .CommandText = "spIncluirTitulo"
                Else
                    .CommandText = "spAlterarTitulo"
                End If

                .Parameters.Add("@Documento", SqlDbType.VarChar, 20, "Documento")
                .Parameters(0).Value = Me.txtDocumento.Text.Trim
                .Parameters.Add("@CodigoFornecedor", SqlDbType.Int, 4, "CodigoFornecedor")
                tam = Me.cboFornecedor.Text.Length
                .Parameters(1).Value = CLng(Me.cboFornecedor.Text.Substring(tam - 6, 6))
                .Parameters.Add("@Vencimento", SqlDbType.DateTime, 8, "Vencimento")
                .Parameters(2).Value = Me.dtpVencimento.Value.ToShortDateString
                .Parameters.Add("@ValorOriginal", SqlDbType.Decimal, 9, "ValorOriginal")
                .Parameters(3).Value = CDec(Me.txtValorOriginal.Text.Replace(".", ""))
                .Parameters.Add("@DataPagto", SqlDbType.DateTime, 8, "DataPagto")
                .Parameters(4).Value = Me.dtpDataPagamento.Value.ToShortDateString
                .Parameters.Add("@ValorPago", SqlDbType.Decimal, 9, "ValorPago")
                If Me.txtValorPago.Text.Trim <> "" Then
                    .Parameters(5).Value = CDec(Me.txtValorPago.Text.Replace(".", ""))
                Else
                    .Parameters(5).Value = 0
                End If
                .Parameters.Add("@Historico", SqlDbType.VarChar, 100, "Historico")
                .Parameters(6).Value = Me.txtHistorico.Text.Trim
                .Parameters.Add("@CodigoFazenda", SqlDbType.SmallInt, 2, "CodigoFazenda")
                .Parameters(7).Value = CInt(Me.cboFazenda.Text.Substring(0, 2))
                .Parameters.Add("@CodigoTipoDocumento", SqlDbType.VarChar, 2, "CodigoTipoDocumento")
                .Parameters(8).Value = Me.cboTipoDocumento.Text.Substring(0, 2)

                If Not Incluir Then
                    .Parameters.Add("@CodigoCap", SqlDbType.Int, 4, "CodigoCap")
                    .Parameters(9).Value = Me.CodigoCAP
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

    Private Sub RetornarDadosTitulo()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarDadosTitulo", cnn)
        Dim dtr As SqlClient.SqlDataReader

        Try

            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@CodigoCap", SqlDbType.Int, 4, "CodigoCap")
                .Parameters(0).Value = Me.CodigoCAP
                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    Me.txtDocumento.Text = dtr(0).ToString
                    Me.cboTipoDocumento.Text = dtr(8).ToString
                    Me.cboFornecedor.Text = dtr(1).ToString
                    Me.dtpVencimento.Value = CDate(dtr(2))
                    Me.txtValorOriginal.Text = clsRotinas.Moeda(CDec(dtr(3)))
                    Me.cboFazenda.Text = dtr(7).ToString
                    Me.dtpDataPagamento.Value = CDate(dtr(4))
                    Me.txtValorPago.Text = clsRotinas.Moeda(CDec(dtr(5)))
                    Me.txtHistorico.Text = dtr(6).ToString
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

    Private Sub btnCadastroFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastroFornecedor.Click
        Dim frm As New frmFornecedores
        frm.ShowDialog()
        Me.PreencherComboFornecedores()
    End Sub

End Class