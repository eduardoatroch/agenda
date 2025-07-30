Public Class frmIncluirEditarTituloReceber
    Private CodigoREC As Long
    Private Incluir As Boolean
    Private DataPagto As DateTime

    Public Sub New(ByVal CodREC As Long, ByVal Inc As Boolean)
        MyBase.New()
        InitializeComponent()
        CodigoREC = CodREC
        Incluir = Inc
    End Sub

    Private Sub frmIncluirEditarTituloReceber_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PreencherComboCliente()
        Me.PreencherComboFazendas()
        Me.PreencherComboFormasPagamento()

        If Not Me.Incluir Then
            RetornarDadosRecebimento()
        End If

        Me.cboCliente.Focus()

    End Sub

    Private Sub PreencherComboCliente()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarListaClientes", cnn)
        Dim dtr As SqlClient.SqlDataReader

        Try

            Me.cboCliente.Items.Clear()

            With cmd

                .CommandType = CommandType.StoredProcedure

                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    Me.cboCliente.Items.Add(dtr(1) & " - " & dtr(0).ToString) 'Nome+Código Cliente                    
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

    Private Sub RetornarDadosRecebimento()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarDadosTitulosReceber", cnn)
        Dim dtr As SqlClient.SqlDataReader

        Try

            Me.cboCliente.Items.Clear()

            With cmd

                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@CodigoRec", SqlDbType.Int, 4, "CodigoRec")
                .Parameters(0).Value = Me.CodigoREC

                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    Me.cboCliente.Text = dtr(7).ToString
                    Me.lblVenda.Text = dtr(8).ToString
                    Me.txtDocumento.Text = dtr(1).ToString
                    Me.dtpVencimento.Value = CDate(dtr(2))
                    Me.txtValorOriginal.Text = classRotinas.Moeda(CDec(dtr(3)))
                    Me.txtHistorico.Text = dtr(6).ToString
                    If CDate("01/01/1900") <> CDate(dtr(4)) Then
                        Me.txtDataPagto.Text = CDate(dtr(4)).ToShortDateString
                    End If
                    If CDec(dtr(5)) > 0 Then
                        Me.txtValorPago.Text = classRotinas.Moeda(CDec(dtr(5)))
                    End If
                    Me.cboFormaPagamento.Text = dtr(11).ToString
                    Me.cboFazenda.Text = dtr(10).ToString
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
        
        If Me.cboCliente.Text.Trim = "" Then
            MsgBox("Selecione um Cliente por favor", MsgBoxStyle.Critical)
            Me.cboCliente.Focus()
            Exit Sub
        End If

        If Me.txtValorOriginal.Text.Trim = "" Then
            MsgBox("Informe o Valor do Recebimento!", MsgBoxStyle.Critical)
            Me.txtValorOriginal.Focus()
            Exit Sub
        End If

        If Me.txtHistorico.Text.Trim = "" Then
            MsgBox("Informe o Histórico do Recebimento por favor!", MsgBoxStyle.Critical)
            Me.txtHistorico.Focus()
            Exit Sub
        End If

        If Me.txtDataPagto.Text.Trim <> "" Then
            If Not classRotinas.ValidarData(Me.txtDataPagto.Text.Trim) Then
                Me.txtDataPagto.Focus()
                Exit Sub
            End If
            Me.DataPagto = CDate(Me.txtDataPagto.Text.Trim)
            If Me.txtValorPago.Text.Trim = "" Then
                MsgBox("ERRO - Foi informada a data de pagamento," & Chr(13) & "logo é necessário informar o valor pago!", MsgBoxStyle.Critical)
                Me.txtValorPago.Focus()
                Exit Sub
            End If
        Else
            Me.DataPagto = CDate("01/01/1900")
        End If

        If MsgBox("Confirma salvar os dados agora?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SalvarRecebimento()
            Me.Close()
        End If

    End Sub

    Private Sub SalvarRecebimento()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand
        Dim Tam As Integer

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Connection = cnn

                If Me.Incluir Then
                    .CommandText = "spIncluirRecebimento"
                Else
                    .CommandText = "spAlterarRecebimento"
                End If

                .Parameters.Add("@NumDocto", SqlDbType.VarChar, 20, "NumDocto")
                .Parameters(0).Value = Me.txtDocumento.Text.Trim
                .Parameters.Add("@Venc", SqlDbType.DateTime, 8, "Venc")
                .Parameters(1).Value = Me.dtpVencimento.Value.Date
                .Parameters.Add("@ValorOrig", SqlDbType.Decimal, 9, "ValorOrig")
                .Parameters(2).Value = CDec(Me.txtValorOriginal.Text.Trim)
                Tam = Me.cboCliente.Text.Length
                .Parameters.Add("@CodigoCli", SqlDbType.Int, 4, "CodigoCli")
                .Parameters(3).Value = CLng(Me.cboCliente.Text.Substring(Tam - 6, 6))
                .Parameters.Add("@Hist", SqlDbType.VarChar, 100, "Hist")
                .Parameters(4).Value = Me.txtHistorico.Text.Trim
                .Parameters.Add("@Pago", SqlDbType.Bit, 1, "Pago")
                If CDate("01/01/1900") = Me.DataPagto Then
                    .Parameters(5).Value = 0
                Else
                    .Parameters(5).Value = 1
                End If
                .Parameters.Add("@DataPagto", SqlDbType.DateTime, 8, "DataPagto")
                .Parameters(6).Value = Me.DataPagto
                .Parameters.Add("@valorPago", SqlDbType.Decimal, 9, "ValorPago")
                If Me.txtValorPago.Text.Trim = "" Then
                    .Parameters(7).Value = 0
                Else
                    .Parameters(7).Value = CDec(Me.txtValorPago.Text.Trim)
                End If
                .Parameters.Add("@CodigoVenda", SqlDbType.Int, 4, "CodigoVenda")
                .Parameters(8).Value = CLng(Me.lblVenda.Text.Trim)
                .Parameters.Add("@CodigoFazenda", SqlDbType.SmallInt, 2)
                .Parameters(9).Value = CInt(Me.cboFazenda.Text.Substring(0, 2))
                .Parameters.Add("@FormaPagto", SqlDbType.VarChar, 2)
                .Parameters(10).Value = Me.cboFormaPagamento.Text.Substring(0, 2)

                If Me.Incluir = False Then
                    .Parameters.Add("@CodigoRec", SqlDbType.Int, 4, "CodigoRec")
                    .Parameters(11).Value = Me.CodigoREC
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

    Private Sub PreencherComboFormasPagamento()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarListaFormasPagamento", cnn)
        Dim dtr As SqlClient.SqlDataReader

        Try
            Me.cboFormaPagamento.Items.Clear()
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