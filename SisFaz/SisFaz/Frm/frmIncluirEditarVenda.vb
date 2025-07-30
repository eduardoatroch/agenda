Public Class frmIncluirEditarVenda
    Private CodigoVenda As Long
    Private ValorVenda As Decimal
    Private Incluir As Boolean

    Public Sub New(ByVal CodVenda As Long, ByVal Inc As Boolean)
        MyBase.New()
        InitializeComponent()
        CodigoVenda = CodVenda
        Incluir = Inc
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub frmIncluirEditarVenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PreencherComboCliente()
        Me.PreencherComboFazendas()

        If Not Me.Incluir Then
            RetornarDadosVenda()
        End If
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
                    Me.cboCliente.Items.Add(dtr(1) & " - " & dtr(0))
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
        If Me.cboCliente.Text.Trim = "" Then
            MsgBox("Selecione o cliente por favor", MsgBoxStyle.Critical)
            Me.cboCliente.Focus()
            Exit Sub
        End If
        If Me.txtParcelas.Text.Trim = "" Then
            MsgBox("Informe a quantidade de parcelas por favor", MsgBoxStyle.Critical)
            Me.txtParcelas.Focus()
            Exit Sub
        End If
        If Me.txtIntervalo.Text.Trim = "" Then
            MsgBox("Informe o intervalo de meses entre os vencimentos por favor", MsgBoxStyle.Critical)
            Me.txtIntervalo.Focus()
            Exit Sub
        End If
        If Me.txtValorParcela.Text.Trim = "" Then
            MsgBox("Informe o valior das parcelas por favor", MsgBoxStyle.Critical)
            Me.txtValorParcela.Focus()
            Exit Sub
        End If
        If Me.txtTaxaJurosMes.Text.Trim = "" Then
            MsgBox("Informe a taxa de juros mês para eventual atraso", MsgBoxStyle.Critical)
            Me.txtTaxaJurosMes.Focus()
            Exit Sub
        End If
        If Me.cboFazenda.Text.Trim = "" Then
            MsgBox("Selecione a fazenda por favor!", MsgBoxStyle.Exclamation)
            Me.cboFazenda.Focus()
            Exit Sub
        End If

        CalcularValorVenda()

        If MsgBox("Confirma salvar os dados agora?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SalvarVenda()
            Me.Close()
        End If

    End Sub

    Private Sub SalvarVenda()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand
        Dim Tam As Integer

        Try

            Tam = Me.cboCliente.Text.Length

            With cmd

                .CommandType = CommandType.StoredProcedure
                .Connection = cnn

                If Me.Incluir Then
                    .CommandText = "spIncluirVenda"
                Else
                    .CommandText = "spAlterarVenda"
                End If

                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@CodigoCliente", SqlDbType.Int, 4, "CodigoCliente")
                .Parameters(0).Value = CLng(Me.cboCliente.Text.Substring(Tam - 6, 6))
                .Parameters.Add("@DataVenda", SqlDbType.DateTime, 8, "DataVenda")
                .Parameters(1).Value = Me.dtpDataVenda.Value.Date
                .Parameters.Add("@QtdeParc", SqlDbType.TinyInt, 1, "QtdeParc")
                .Parameters(2).Value = CByte(Me.txtParcelas.Text)
                .Parameters.Add("@Intervalo", SqlDbType.TinyInt, 1, "Intervalo")
                .Parameters(3).Value = CByte(Me.txtIntervalo.Text)
                .Parameters.Add("@VencInicial", SqlDbType.DateTime, 8, "VencInicial")
                .Parameters(4).Value = Me.dtpVencParcela.Value.Date
                .Parameters.Add("@ValorParc", SqlDbType.Decimal, 9, "ValorParc")
                .Parameters(5).Value = CDec(Me.txtValorParcela.Text)
                .Parameters.Add("@JurosMes", SqlDbType.Decimal, 9, "JurosMes")
                .Parameters(6).Value = CDec(Me.txtTaxaJurosMes.Text)
                .Parameters.Add("@Animal", SqlDbType.VarChar, 50, "Animal")
                .Parameters(7).Value = Me.txtAnimal.Text.Trim
                .Parameters.Add("@ValorVenda", SqlDbType.Decimal, 9, "ValorVenda")
                .Parameters(8).Value = Me.ValorVenda
                .Parameters.Add("@CodigoFazenda", SqlDbType.SmallInt, 2)
                .Parameters(9).Value = CInt(Me.cboFazenda.Text.Substring(0, 2))

                If Not Incluir Then
                    .Parameters.Add("@CodigoVenda", SqlDbType.Int, 4, "CodigoVenda")
                    .Parameters(10).Value = CodigoVenda
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

    Private Sub pbCadastroCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbCadastroCliente.Click
        Dim frm As New frmCadastroCliente
        frm.ShowDialog()
        Me.PreencherComboCliente()
    End Sub

    Private Sub CalcularValorVenda()
        ValorVenda = CInt(Me.txtParcelas.Text) * CDec(Me.txtValorParcela.Text)
        Me.lblValorVenda.Text = classRotinas.Moeda(ValorVenda)
    End Sub

    Private Sub RetornarDadosVenda()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarDadosVenda", cnn)
        Dim dtr As SqlClient.SqlDataReader

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@CodigoVenda", SqlDbType.Int, 4, "CodigoVenda")
                .Parameters(0).Value = Me.CodigoVenda
                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    Me.cboCliente.Text = dtr(6).ToString
                    Me.dtpDataVenda.Value = CDate(dtr(0))
                    Me.txtParcelas.Text = dtr(2).ToString
                    Me.txtIntervalo.Text = dtr(3).ToString
                    Me.dtpVencParcela.Value = CDate(dtr(4))
                    Me.txtValorParcela.Text = classRotinas.Moeda(CDec(dtr(5)))
                    Me.txtTaxaJurosMes.Text = classRotinas.Moeda(CDec(dtr(8)))
                    Me.txtAnimal.Text = dtr(7).ToString
                    Me.lblValorVenda.Text = classRotinas.Moeda(CDec(dtr(1)))
                    Me.cboFazenda.Text = dtr(9).ToString
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

End Class