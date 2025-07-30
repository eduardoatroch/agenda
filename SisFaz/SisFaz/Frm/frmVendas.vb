Public Class frmVendas

    Private Sub frmVendas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ValidarPeriodo()
        RetornarListaVendas()
    End Sub

    Private Sub ValidarPeriodo()
        If Me.chkPeriodo.Checked = False Then
            Me.grpPeriodo.Enabled = False
        Else
            Me.grpPeriodo.Enabled = True
        End If
    End Sub

    Private Sub RetornarListaVendas()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand
        Dim dtr As SqlClient.SqlDataReader
        Dim lvi As ListViewItem

        Try

            Me.lstvVendas.Items.Clear()

            With cmd

                .CommandType = CommandType.StoredProcedure
                .Connection = cnn

                If Me.chkPeriodo.Checked Then
                    .CommandText = "spRetornarListaVendas;2"
                    .Parameters.Add("@DataIni", SqlDbType.DateTime, 8, "DataIni")
                    .Parameters(0).Value = Me.dtpDataIni.Value.Date
                    .Parameters.Add("@DataFim", SqlDbType.DateTime, 8, "DataFim")
                    .Parameters(1).Value = Me.dtpDataFim.Value.Date
                Else
                    .CommandText = "spRetornarListaVendas"
                End If

                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    lvi = Me.lstvVendas.Items.Add(dtr(0).ToString) 'código venda
                    lvi.SubItems.Add(CDate(dtr(1)).ToShortDateString) 'data da venda
                    lvi.SubItems.Add(classRotinas.Moeda(CDec(dtr(2)))) 'valor
                    lvi.SubItems.Add(dtr(3).ToString) 'cliente
                    lvi.SubItems.Add(dtr(4).ToString) 'gerou parcelas (0=Não, 1=Sim)
                    lvi.SubItems.Add(dtr(5).ToString) 'qtde.parcelas
                    lvi.SubItems.Add(classRotinas.Moeda(CDec(dtr(6)))) 'valor parcela
                    lvi.SubItems.Add(CDate(dtr(7)).ToShortDateString) 'venc.inicial parcela
                    lvi.SubItems.Add(dtr(8).ToString) 'intervalo
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

    Private Sub btnPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisar.Click
        Me.RetornarListaVendas()
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub chkPeriodo_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPeriodo.CheckedChanged
        ValidarPeriodo()
    End Sub

    Private Sub btnIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncluir.Click
        Dim frm As New frmIncluirEditarVenda(0, True)
        frm.ShowDialog()
        Me.RetornarListaVendas()
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        If Me.lstvVendas.SelectedItems.Count = 0 Then
            MsgBox("Selecione a Venda que deseja alterar!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim frm As New frmIncluirEditarVenda(CLng(Me.lstvVendas.SelectedItems(0).Text), False)
        frm.ShowDialog()
        Me.RetornarListaVendas()
    End Sub

    Private Sub btnGerarParcelas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarParcelas.Click
        If Me.lstvVendas.SelectedItems.Count = 0 Then
            MsgBox("Selecione a Venda que deseja gerar as parcelas por favor!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If Me.lstvVendas.SelectedItems(0).SubItems(3).Text.Substring(0, 1) = "1" Then
            MsgBox("Já foram geradas as parcelas desta venda!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If MsgBox("Confirma a geração das parcelas da Venda agora?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            GerarParcelas()
            Me.RetornarListaVendas()
        End If
    End Sub

    Private Sub GerarParcelas()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spGerarParcelasVenda", cnn)
        Dim I, QtdParc, Dia, Mes, Ano, Resto, Tam As Integer
        Dim cDia, cMes, cAno As String

        Try

            QtdParc = CInt(Me.lstvVendas.SelectedItems(0).SubItems(5).Text)

            With cmd

                .CommandType = CommandType.StoredProcedure

                Dia = CDate(Me.lstvVendas.SelectedItems(0).SubItems(7).Text).Day
                Mes = CDate(Me.lstvVendas.SelectedItems(0).SubItems(7).Text).Month
                Ano = CDate(Me.lstvVendas.SelectedItems(0).SubItems(7).Text).Year

                For I = 1 To QtdParc
                    .Parameters.Clear()
                    .Parameters.Add("@NumDocto", SqlDbType.VarChar, 20, "NumDocto")
                    .Parameters(0).Value = "Parcela " & I.ToString
                    .Parameters.Add("@Vencimento", SqlDbType.DateTime, 8, "Vencimento")

                    If Mes = 2 And Dia > 28 Then
                        Resto = Ano Mod 4
                        If Resto = 0 Then
                            cDia = "29"
                        Else
                            cDia = "28"
                        End If
                    Else
                        Tam = 100 + Dia
                        cDia = Tam.ToString.Substring(1, 2)
                    End If

                    Tam = Mes + 100
                    cMes = Tam.ToString.Substring(1, 2)

                    Tam = Ano + 10000
                    cAno = Tam.ToString.Substring(1, 4)

                    .Parameters(1).Value = CDate(cDia & "/" & cMes & "/" & cAno)

                    Mes += 1

                    If Mes > 12 Then
                        Mes = 1
                        Ano += 1
                    End If

                    .Parameters.Add("@ValorParcela", SqlDbType.Decimal, 9, "ValorParcela")
                    .Parameters(2).Value = CDec(Me.lstvVendas.SelectedItems(0).SubItems(6).Text)
                    .Parameters.Add("@CodigoCliente", SqlDbType.Int, 4, "CodigoCliente")
                    Tam = Me.lstvVendas.SelectedItems(0).SubItems(3).Text.Length
                    .Parameters(3).Value = CLng(Me.lstvVendas.SelectedItems(0).SubItems(3).Text.Substring(Tam - 6, 6))
                    .Parameters.Add("@Historico", SqlDbType.VarChar, 100, "Historico")
                    .Parameters(4).Value = "Venda de Animal"
                    .Parameters.Add("@CodigoVenda", SqlDbType.Int, 4, "CodigoVenda")
                    .Parameters(5).Value = CLng(Me.lstvVendas.SelectedItems(0).Text)

                    cnn.Open()
                    .ExecuteNonQuery()
                    cnn.Close()

                Next

                MsgBox("Geração concluída!", MsgBoxStyle.Information)

            End With

        Catch ex As Exception
            MsgBox(ex.Source & Chr(13) & ex.Message)
        Finally
            cnn.Dispose()
            cmd.Dispose()
            GC.Collect()
        End Try
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        If Me.lstvVendas.SelectedItems.Count = 0 Then
            MsgBox("Selecione a venda que deseja excluir!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If MsgBox("Confirma a exclusão da venda " & Me.lstvVendas.SelectedItems(0).Text, MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Excluirvenda()
            RetornarListaVendas()
        End If
    End Sub

    Private Sub ExcluirVenda()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spExcluirVendaBoi", cnn)

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@CodigoVenda", SqlDbType.Int, 4, "CodigoVenda")
                .Parameters(0).Value = CLng(Me.lstvVendas.SelectedItems(0).Text)
                .Parameters.Add("@ret", SqlDbType.Bit, 1, "ret")
                .Parameters(1).Direction = ParameterDirection.Output
                cnn.Open()
                .ExecuteNonQuery()
                cnn.Close()

                If CByte(.Parameters(1).Value = 0) Then
                    MsgBox("Exitem parcelas lançadas para a venda," & Chr(13) & "exclusão abortada!", MsgBoxStyle.Critical)
                End If

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