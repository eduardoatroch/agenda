Public Class frmMovimentoCaixa
    Private Erro As Boolean = False

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub frmMovimentoCaixa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.grpFazenda.Visible = False
        Me.grpPeriodo.Visible = False
        Me.grpValores.Visible = False
        PreencherComboFazenda()
        'PreencherListaMovimentoCaixa()
    End Sub

    Private Sub PreencherComboFazenda()
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

    Private Sub PreencherListaMovimentoCaixa()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand
        Dim dtr As SqlClient.SqlDataReader
        Dim lvi As ListViewItem
        Dim vDataIni, vDataFim As String

        Try
            Me.lstvMovimentoCaixa.Items.Clear()
            vDataIni = classRotinas.DataParaSQLServer(Me.dtpDataInicial.Value.Date)
            vDataFim = classRotinas.DataParaSQLServer2355(Me.dtpDataFinal.Value.Date)

            With cmd
                .CommandType = CommandType.StoredProcedure
                .Connection = cnn

                If Me.rbFiltroGeral.Checked Then

                    If Me.rbRbTpMovGeral.Checked Then
                        If Me.rbOrdemData.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa"
                        ElseIf Me.rbOrdemValor.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;2"
                        ElseIf Me.rbOrdemFazendaData.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;3"
                        End If
                    ElseIf Me.rbTpMovDebito.Checked Then
                        If Me.rbOrdemData.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;13"
                        ElseIf Me.rbOrdemValor.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;14"
                        ElseIf Me.rbOrdemFazendaData.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;15"
                        End If
                    ElseIf Me.rbTpMovCredito.Checked Then
                        If Me.rbOrdemData.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;16"
                        ElseIf Me.rbOrdemValor.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;17"
                        ElseIf Me.rbOrdemFazendaData.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;18"
                        End If
                    End If

                ElseIf Me.rbFiltroPeriodo.Checked Then

                    .Parameters.Add("@DataInicio", SqlDbType.DateTime, 8, "DataInicio")
                    .Parameters(0).Value = vDataIni ' Me.dtpDataInicial.Value.ToShortDateString
                    .Parameters.Add("@DataFim", SqlDbType.DateTime, 8, "DataFim")
                    .Parameters(1).Value = vDataFim 'Me.dtpDataFinal.Value.ToShortDateString

                    If Me.rbRbTpMovGeral.Checked Then
                        If Me.rbOrdemData.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;4"
                        ElseIf Me.rbOrdemValor.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;5"
                        ElseIf Me.rbOrdemFazendaData.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;6"
                        End If
                    ElseIf Me.rbTpMovDebito.Checked Then
                        If Me.rbOrdemData.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;19"
                        ElseIf Me.rbOrdemValor.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;20"
                        ElseIf Me.rbOrdemFazendaData.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;21"
                        End If
                    ElseIf Me.rbTpMovCredito.Checked Then
                        If Me.rbOrdemData.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;22"
                        ElseIf Me.rbOrdemValor.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;23"
                        ElseIf Me.rbOrdemFazendaData.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;24"
                        End If
                    End If
                    

                ElseIf Me.rbFiltroValor.Checked Then

                    If Me.txtValorInicial.Text.Trim = "" Then
                        MsgBox("Informe o valor inicial", MsgBoxStyle.Exclamation)
                        Me.grpValores.Visible = True
                        Me.txtValorInicial.Focus()
                        Me.Erro = True
                        Exit Try
                    End If
                    If Me.txtValorFinal.Text.Trim = "" Then
                        MsgBox("Informe o valor final", MsgBoxStyle.Exclamation)
                        Me.grpValores.Visible = True
                        Me.txtValorFinal.Focus()
                        Me.Erro = True
                        Exit Try
                    End If

                    Me.Erro = False

                    .Parameters.Add("@ValorInicio", SqlDbType.Decimal, 9, "ValorInicio")
                    .Parameters(0).Value = CDec(Me.txtValorInicial.Text.Trim)
                    .Parameters.Add("@ValorFim", SqlDbType.Decimal, 9, "ValorFim")
                    .Parameters(1).Value = CDec(Me.txtValorFinal.Text.Trim)

                    If Me.rbRbTpMovGeral.Checked Then
                        If Me.rbOrdemData.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;7"
                        ElseIf Me.rbOrdemValor.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;8"
                        ElseIf Me.rbOrdemFazendaData.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;9"
                        End If
                    ElseIf Me.rbTpMovDebito.Checked Then
                        If Me.rbOrdemData.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;25"
                        ElseIf Me.rbOrdemValor.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;26"
                        ElseIf Me.rbOrdemFazendaData.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;27"
                        End If
                    ElseIf Me.rbTpMovCredito.Checked Then
                        If Me.rbOrdemData.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;28"
                        ElseIf Me.rbOrdemValor.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;29"
                        ElseIf Me.rbOrdemFazendaData.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;30"
                        End If
                    End If

                ElseIf Me.rbFiltroFazenda.Checked Then

                    If Me.cboFazenda.Text.Trim = "" Then
                        MsgBox("Selecione a fazenda", MsgBoxStyle.Exclamation)
                        Me.grpFazenda.Visible = True
                        Me.cboFazenda.Focus()
                        Me.Erro = True
                        Exit Try
                    End If

                    Me.Erro = False

                    .Parameters.Add("@CodigoFazenda", SqlDbType.SmallInt, 2, "CodigoFazenda")
                    .Parameters(0).Value = CInt(Me.cboFazenda.Text.Substring(0, 2))

                    If Me.rbRbTpMovGeral.Checked Then
                        If Me.rbOrdemData.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;10"
                        ElseIf Me.rbOrdemValor.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;11"
                        ElseIf Me.rbOrdemFazendaData.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;12"
                        End If
                    ElseIf Me.rbTpMovDebito.Checked Then
                        If Me.rbOrdemData.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;31"
                        ElseIf Me.rbOrdemValor.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;32"
                        ElseIf Me.rbOrdemFazendaData.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;33"
                        End If
                    ElseIf Me.rbTpMovCredito.Checked Then
                        If Me.rbOrdemData.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;34"
                        ElseIf Me.rbOrdemValor.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;35"
                        ElseIf Me.rbOrdemFazendaData.Checked Then
                            .CommandText = "spRetornarMovimentoCaixa;36"
                        End If
                    End If

                Else

                    MsgBox("Condição não tratada !", MsgBoxStyle.Information)
                    Exit Try

                End If

                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    lvi = Me.lstvMovimentoCaixa.Items.Add(dtr(0).ToString) 'Lançamento
                    lvi.SubItems.Add(CDate(dtr(1)).ToShortDateString) 'Data Baixa
                    lvi.SubItems.Add(clsRotinas.Moeda(CDec(dtr(2)))) 'Valor Baixado
                    lvi.SubItems.Add(dtr(3).ToString) 'Código Fornecedor
                    lvi.SubItems.Add(dtr(4).ToString) 'Nome do Fornecedor
                    lvi.SubItems.Add(dtr(5).ToString) 'Histórico
                    lvi.SubItems.Add(dtr(6) & " - " & dtr(7)) 'Banco
                    lvi.SubItems.Add(dtr(8).ToString) 'Agência
                    lvi.SubItems.Add(dtr(9).ToString) 'Conta Bancária
                    lvi.SubItems.Add(dtr(10).ToString) 'Nº do Cheque
                    lvi.SubItems.Add(dtr(11).ToString) 'Fazenda
                    lvi.SubItems.Add(dtr(12).ToString) 'Código Cap
                    lvi.SubItems.Add(dtr(13).ToString) 'Tipo de Movimento
                Loop
                dtr.Close()
                dtr = Nothing
                cnn.Close()
            End With

        Catch ex As Exception
            MsgBox(ex.Source & Chr(13) & ex.Message)
        Finally
            cnn.Dispose()
            GC.Collect()
        End Try

    End Sub

    Private Sub rbFiltroData_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFiltroPeriodo.CheckedChanged
        ValidarFiltroData()
    End Sub

    Private Sub ValidarFiltroData()
        If Me.rbFiltroPeriodo.Checked Then
            Me.grpPeriodo.Visible = True
            Me.dtpDataInicial.Focus()
            Me.grpFazenda.Visible = False
            Me.grpValores.Visible = False
        Else
            Me.grpPeriodo.Visible = False
        End If
    End Sub

    Private Sub rbFiltroValor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFiltroValor.CheckedChanged
        ValidarFiltroValor()
    End Sub

    Private Sub ValidarFiltroValor()
        If Me.rbFiltroValor.Checked Then
            Me.grpValores.Visible = True
            Me.txtValorInicial.Text = ""
            Me.txtValorFinal.Text = ""
            Me.txtValorInicial.Focus()
            Me.grpFazenda.Visible = False
            Me.grpPeriodo.Visible = False
        Else
            Me.grpValores.Visible = False
            Me.txtValorInicial.Text = ""
            Me.txtValorFinal.Text = ""
        End If
    End Sub

    Private Sub rbFiltroFazenda_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFiltroFazenda.CheckedChanged
        ValidarFiltroFazenda()
    End Sub

    Private Sub ValidarFiltrofazenda()
        If Me.rbFiltroFazenda.Checked Then
            Me.grpFazenda.Visible = True
            Me.cboFazenda.Focus()
            Me.grpPeriodo.Visible = False
            Me.grpValores.Visible = False
        Else
            Me.grpFazenda.Visible = False
        End If
    End Sub

    Private Sub rbFiltroGeral_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFiltroGeral.CheckedChanged
        ValidarFiltroGeral()
    End Sub

    Private Sub ValidarFiltroGeral()
        If Me.rbFiltroGeral.Checked Then
            Me.grpFazenda.Visible = False
            Me.grpPeriodo.Visible = False
            Me.grpValores.Visible = False
        End If
    End Sub

    Private Sub btnPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisar.Click

        PreencherListaMovimentoCaixa()

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        If Me.lstvMovimentoCaixa.SelectedItems.Count = 0 Then
            MsgBox("Selecione o(s) lançamento(s) que deseja excluir", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim i As Integer

        For i = 0 To Me.lstvMovimentoCaixa.SelectedItems.Count - 1
            If Me.lstvMovimentoCaixa.SelectedItems(i).SubItems(9).Text.Trim <> "" Then
                MsgBox("Existe o cheque nº " & Me.lstvMovimentoCaixa.SelectedItems(i).SubItems(9).Text.Trim & Chr(13) & _
                       "vinculado a este lançamento, exclusão negada", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If Me.lstvMovimentoCaixa.SelectedItems(i).SubItems(11).Text.Trim <> "0" Then
                MsgBox("Existe o título de código nº " & Me.lstvMovimentoCaixa.SelectedItems(i).SubItems(11).Text.Trim & Chr(13) & _
                       "vinculado a este lançamento, exclusão negada", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        Next

        If MsgBox("Confirma a exclusão do(s) lançamento(s) selecionado(s) agora ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ExcluirLancamentos()
            PreencherListaMovimentoCaixa()
        End If
    End Sub

    Private Sub ExcluirLancamentos()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spExcluirMovimentoCaixa", cnn)
        Dim I As Integer

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                For I = 0 To Me.lstvMovimentoCaixa.SelectedItems.Count - 1
                    .Parameters.Clear()
                    .Parameters.Add("@CodigoLancamento", SqlDbType.Int, 4, "CodigoLancamento")
                    .Parameters(0).Value = CLng(Me.lstvMovimentoCaixa.SelectedItems(I).Text)
                    cnn.Open()
                    .ExecuteNonQuery()
                    cnn.Close()
                Next
            End With
        Catch ex As Exception
            MsgBox(ex.Source & Chr(13) & ex.Message)
        Finally
            cnn.Dispose()
            cmd.Dispose()
            GC.Collect()
        End Try

    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        If Me.lstvMovimentoCaixa.SelectedItems.Count = 0 Then
            MsgBox("Selecione o lançamento que deseja alterar", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim frm As New frmIncluirEditarMovimentoCaixa(CLng(Me.lstvMovimentoCaixa.SelectedItems(0).Text), False)
        frm.ShowDialog()
        Me.PreencherListaMovimentoCaixa()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim frm As New frmRptMovimentoCaixa
        frm.ShowDialog()
    End Sub

    Private Sub btnIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncluir.Click
        Dim frm As New frmIncluirEditarMovimentoCaixa(0, True)
        frm.ShowDialog()
        Me.PreencherListaMovimentoCaixa()
    End Sub

End Class