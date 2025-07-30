Public Class frmTitulos

    Private Sub frmTitulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.grpPeriodo.Enabled = False
        Me.grpValor.Enabled = False
        Me.grpFazenda.Enabled = False
        PreencherListaTitulos()
        PreencherComboFazendas()
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
                    Me.cboFazenda.Items.Add(dtr(0) & " - " & dtr(1)) 'Código + Nome da Fazenda
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

    Private Sub PreencherListaTitulos()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand
        Dim dtr As SqlClient.SqlDataReader
        Dim lvi As ListViewItem
        Dim TextoComando, vDataIni, vDataFim As String

        Try
            vDataIni = classRotinas.DataParaSQLServer(Me.dtpDataInicial.Value.Date)
            vDataFim = classRotinas.DataParaSQLServer2355(Me.dtpDataFinal.Value.Date)

            Me.lstvTitulos.Items.Clear()
            TextoComando = "spRetornarListaTitulos"

            With cmd

                .CommandType = CommandType.StoredProcedure
                .Connection = cnn

                If Me.rbStatusAberto.Checked Then

                    If Me.rbPesqPeriodo.Checked = False And Me.rbPesqValor.Checked = False And Me.rbPesqFazenda.Checked = False Then
                        TextoComando = "spRetornarListaTitulos"
                    Else
                        If Me.rbPesqPeriodo.Checked Then
                            TextoComando &= ";2"
                            .Parameters.Add("@DataInicio", SqlDbType.DateTime, 8, "DataInicio")
                            .Parameters(0).Value = vDataIni 'Me.dtpDataInicial.Value.ToShortDateString
                            .Parameters.Add("@DataFinal", SqlDbType.DateTime, 8, "DataFinal")
                            .Parameters(1).Value = vDataFim 'Me.dtpDataFinal.Value.ToShortDateString
                        ElseIf Me.rbPesqValor.Checked Then
                            TextoComando &= ";3"
                            .Parameters.Add("@ValorInicio", SqlDbType.Decimal, 9, "ValorInicio")
                            If Me.txtVlrInicial.Text <> "" Then
                                .Parameters(0).Value = CDec(Me.txtVlrInicial.Text)
                            Else
                                .Parameters(0).Value = 0
                            End If
                            .Parameters.Add("@ValorFinal", SqlDbType.Decimal, 9, "ValorFinal")
                            If Me.txtVlrFinal.Text.Trim <> "" Then
                                .Parameters(1).Value = CDec(Me.txtVlrFinal.Text)
                            Else
                                .Parameters(1).Value = 0
                            End If
                        ElseIf Me.rbPesqFazenda.Checked Then
                            TextoComando &= ";4"
                            .Parameters.Add("@CodigoFazenda", SqlDbType.SmallInt, 2, "CodigoFazenda")
                            If Me.cboFazenda.Text.Trim <> "" Then
                                .Parameters(0).Value = CInt(Me.cboFazenda.Text.Substring(0, 2))
                            Else
                                .Parameters(0).Value = 1
                            End If
                        End If
                    End If

                ElseIf Me.rbStatusBaixado.Checked Then

                    If Me.rbPesqPeriodo.Checked = False And Me.rbPesqValor.Checked = False And Me.rbPesqFazenda.Checked = False Then
                        TextoComando &= ";5"
                    Else
                        If Me.rbPesqPeriodo.Checked Then
                            TextoComando &= ";6"
                            .Parameters.Add("@DataInicio", SqlDbType.DateTime, 8, "DataInicio")
                            .Parameters(0).Value = vDataIni 'Me.dtpDataInicial.Value.ToShortDateString
                            .Parameters.Add("@DataFinal", SqlDbType.DateTime, 8, "DataFinal")
                            .Parameters(1).Value = vDataFim 'Me.dtpDataFinal.Value.ToShortDateString
                        ElseIf Me.rbPesqValor.Checked Then
                            TextoComando &= ";7"
                            .Parameters.Add("@ValorInicio", SqlDbType.Decimal, 9, "ValorInicio")
                            If Me.txtVlrInicial.Text <> "" Then
                                .Parameters(0).Value = CDec(Me.txtVlrInicial.Text)
                            Else
                                .Parameters(0).Value = 0
                            End If
                            .Parameters.Add("@ValorFinal", SqlDbType.Decimal, 9, "ValorFinal")
                            If Me.txtVlrFinal.Text.Trim <> "" Then
                                .Parameters(1).Value = CDec(Me.txtVlrFinal.Text)
                            Else
                                .Parameters(1).Value = 0
                            End If
                        ElseIf Me.rbPesqFazenda.Checked Then
                            TextoComando &= ";8"
                            .Parameters.Add("@CodigoFazenda", SqlDbType.SmallInt, 2, "CodigoFazenda")
                            If Me.cboFazenda.Text.Trim <> "" Then
                                .Parameters(0).Value = CInt(Me.cboFazenda.Text.Substring(0, 2))
                            Else
                                .Parameters(0).Value = 1
                            End If
                        End If
                    End If

                ElseIf Me.rbStatusGeral.Checked Then

                    If Me.rbPesqPeriodo.Checked = False And Me.rbPesqValor.Checked = False And Me.rbPesqFazenda.Checked = False Then
                        TextoComando &= ";9"
                    Else
                        If Me.rbPesqPeriodo.Checked Then
                            TextoComando &= ";10"
                            .Parameters.Add("@DataInicio", SqlDbType.DateTime, 8, "DataInicio")
                            .Parameters(0).Value = vDataIni 'Me.dtpDataInicial.Value.ToShortDateString
                            .Parameters.Add("@DataFinal", SqlDbType.DateTime, 8, "DataFinal")
                            .Parameters(1).Value = vDataFim 'Me.dtpDataFinal.Value.ToShortDateString
                        ElseIf Me.rbPesqValor.Checked Then
                            TextoComando &= ";11"
                            .Parameters.Add("@ValorInicio", SqlDbType.Decimal, 9, "ValorInicio")
                            If Me.txtVlrInicial.Text <> "" Then
                                .Parameters(0).Value = CDec(Me.txtVlrInicial.Text)
                            Else
                                .Parameters(0).Value = 0
                            End If
                            .Parameters.Add("@ValorFinal", SqlDbType.Decimal, 9, "ValorFinal")
                            If Me.txtVlrFinal.Text.Trim <> "" Then
                                .Parameters(1).Value = CDec(Me.txtVlrFinal.Text)
                            Else
                                .Parameters(1).Value = 0
                            End If
                        ElseIf Me.rbPesqFazenda.Checked Then
                            TextoComando &= ";12"
                            .Parameters.Add("@CodigoFazenda", SqlDbType.SmallInt, 2, "CodigoFazenda")
                            If Me.cboFazenda.Text.Trim <> "" Then
                                .Parameters(0).Value = CInt(Me.cboFazenda.Text.Substring(0, 2))
                            Else
                                .Parameters(0).Value = 1
                            End If
                        End If
                    End If

                End If

                .CommandText = TextoComando

                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    lvi = Me.lstvTitulos.Items.Add(dtr(0).ToString) 'Código Cap
                    lvi.SubItems.Add(dtr(1).ToString) 'Nº do Título
                    lvi.SubItems.Add(CDate(dtr(2)).ToShortDateString) 'Vencimento
                    lvi.SubItems.Add(clsRotinas.Moeda(CDec(dtr(3)))) 'Valor original
                    lvi.SubItems.Add(dtr(4).ToString) 'Baixado 0=Não, 1=Sim
                    If CDate(dtr(5)) = CDate("01/01/1900") Then
                        lvi.SubItems.Add("")
                    Else
                        lvi.SubItems.Add(CDate(dtr(5)).ToShortDateString) 'Data Pagamento
                    End If
                    lvi.SubItems.Add(clsRotinas.Moeda(CDec(dtr(6)))) 'Valor Pago
                    lvi.SubItems.Add(dtr(7).ToString) 'Histórico
                    lvi.SubItems.Add(dtr(8).ToString) 'Fornecedor
                    lvi.SubItems.Add(dtr(9).ToString) 'Fazenda
                    lvi.SubItems.Add(dtr(10).ToString) 'Banco
                    lvi.SubItems.Add(dtr(11).ToString) 'Agência
                    lvi.SubItems.Add(dtr(12).ToString) 'Conta
                    lvi.SubItems.Add(dtr(13).ToString) 'Cheque

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

    Private Sub rbPesqPeriodo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPesqPeriodo.CheckedChanged
        ValidarPesqPeriodo()
    End Sub

    Private Sub ValidarPesqPeriodo()
        If Me.rbPesqPeriodo.Checked Then
            Me.grpPeriodo.Enabled = True
        Else
            Me.grpPeriodo.Enabled = False
        End If
    End Sub

    Private Sub rbPesqValor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPesqValor.CheckedChanged
        ValidarPesqValor()
    End Sub

    Private Sub ValidarPesqValor()
        If Me.rbPesqValor.Checked Then
            Me.grpValor.Enabled = True
        Else
            Me.grpValor.Enabled = False
        End If
    End Sub

    Private Sub rbPesqFazenda_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPesqFazenda.CheckedChanged
        ValidarPesqFazenda()
    End Sub

    Private Sub ValidarPesqFazenda()
        If Me.rbPesqFazenda.Checked Then
            Me.grpFazenda.Enabled = True
        Else
            Me.grpFazenda.Enabled = False
        End If
    End Sub

    Private Sub btnPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisar.Click
        PreencherListaTitulos()
    End Sub

    Private Sub btnVoltarFiltroPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltarFiltroPadrao.Click
        Me.txtVlrInicial.Text = ""
        Me.txtVlrFinal.Text = ""
        Me.cboFazenda.Text = ""
        Me.grpPeriodo.Enabled = False
        Me.grpValor.Enabled = False
        Me.grpFazenda.Enabled = False
        Me.rbStatusAberto.Checked = True
        Me.rbStatusBaixado.Checked = False
        Me.rbStatusGeral.Checked = False
        Me.rbPesqFazenda.Checked = False
        Me.rbPesqValor.Checked = False
        Me.rbPesqPeriodo.Checked = False
    End Sub

    Private Sub btnIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncluir.Click
        Dim frm As New frmIncluirEditarTitulo(0, True)
        frm.ShowDialog()
        PreencherListaTitulos()
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        If Me.lstvTitulos.SelectedItems.Count = 0 Then
            MsgBox("Selecione o título que deseja alterar", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim frm As New frmIncluirEditarTitulo(CLng(Me.lstvTitulos.SelectedItems(0).Text), False)
        frm.ShowDialog()
        PreencherListaTitulos()
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        If Me.lstvTitulos.SelectedItems.Count = 0 Then
            MsgBox("Selecione o título que deseja excluir", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If Me.lstvTitulos.SelectedItems(0).SubItems(4).Text.Substring(0, 1) = "1" Then
            MsgBox("Título já baixado, exclusão abortada", MsgBoxStyle.Information)
            Exit Sub
        End If
        If MsgBox("Confirma a exclusão do título nº " & Me.lstvTitulos.SelectedItems(0).SubItems(1).Text.Trim, MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ExcluirTitulo()
            PreencherListaTitulos()
        End If
    End Sub

    Private Sub ExcluirTitulo()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spExcluirTitulo", cnn)

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@CodigoCap", SqlDbType.Int, 4, "CodigoCap")
                .Parameters(0).Value = CLng(Me.lstvTitulos.SelectedItems(0).Text)
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

    Private Sub btnEstornarBaixa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEstornarBaixa.Click
        If Me.lstvTitulos.SelectedItems.Count = 0 Then
            MsgBox("Selecione o título que deseja estornar a baixa", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If MsgBox("Confirma o estorno da baixa do título nº " & Me.lstvTitulos.SelectedItems(0).SubItems(1).Text.Trim, MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            EstornarBaixa()
            Me.PreencherListaTitulos()
        End If
    End Sub

    Private Sub EstornarBaixa()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spEstornarBaixaTitulo", cnn)

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@CodigoCap", SqlDbType.Int, 4, "CodigoCap")
                .Parameters(0).Value = CLng(Me.lstvTitulos.SelectedItems(0).Text)
                .Parameters.Add("@ret", SqlDbType.Bit, 1, "ret")
                .Parameters(1).Direction = ParameterDirection.Output
                cnn.Open()
                .ExecuteNonQuery()
                cnn.Close()

                If CByte(.Parameters(1).Value) = 0 Then
                    MsgBox("O título foi baixado através de um cheque" & Chr(13) & _
                           "para estornar o pagamento, cancela o cheque", MsgBoxStyle.Information)
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

    Private Sub btnBaixar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaixar.Click
        If Me.lstvTitulos.SelectedItems.Count = 0 Then
            MsgBox("Selecione o(s) título(s) que deseja baixar," & Chr(13) & _
                   "para selecionar vários mantenha a tecla CTRL pressionada e " & Chr(13) & _
                   "dê um click em cada título desejado", MsgBoxStyle.Information)
            Exit Sub
        End If
        BaixarTitulos()
        Me.PreencherListaTitulos()
    End Sub

    Private Sub BaixarTitulos()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand
        Dim cmdChequeColetivo As New SqlClient.SqlCommand("spGerarChequeColetivo", cnn)
        Dim nValor As Decimal
        Dim i, tam As Integer
        Dim DebitarCta As Boolean = False
        Dim ChequeGerado As Boolean = False
        Dim frm As New frmPortador
        Dim CodigoChequeColetivo As Long

        Try
            nValor = 0
            CodigoChequeColetivo = 0

            With cmd

                .CommandType = CommandType.StoredProcedure
                .Connection = cnn

                'Obter o valor total da baixa para gerar cheque coletivo, quando for o caso
                For i = 0 To Me.lstvTitulos.SelectedItems.Count - 1
                    nValor += CDec(Me.lstvTitulos.SelectedItems(i).SubItems(3).Text)
                Next

                If MsgBox("Vai debitar conta bancária ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    frm.ShowDialog()
                    DebitarCta = True
                    If frm.cboBanco.Text.Trim = "" Then
                        MsgBox("Não selecionou o banco", MsgBoxStyle.Exclamation)
                        Exit Try
                    End If
                    If frm.cboAgencia.Text.Trim = "" Then
                        MsgBox("Não selecionou a agência", MsgBoxStyle.Exclamation)
                        Exit Try
                    End If
                    If frm.cboConta.Text.Trim = "" Then
                        MsgBox("Não selecionou a Conta Bancária", MsgBoxStyle.Exclamation)
                        Exit Try
                    End If
                Else
                    DebitarCta = False
                End If

                MsgBox("Soma dos valores dos Títulos -->> " & clsRotinas.Moeda(nValor))

                If MsgBox("Ainda dá para desistir da baixa," & Chr(13) & _
                          "vai continuar ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Exit Try
                End If

                For i = Me.lstvTitulos.SelectedItems.Count - 1 To 0 Step -1

                    .Parameters.Clear()

                    .Parameters.Add("@CodigoCap", SqlDbType.Int, 4, "CodigoCap")
                    .Parameters(0).Value = CLng(Me.lstvTitulos.SelectedItems(i).Text)
                    .Parameters.Add("@DataBaixa", SqlDbType.DateTime, 8, "DataBaixa")
                    .Parameters(1).Value = frm.dtpDataBaixa.Value.ToShortDateString

                    If DebitarCta Then

                        .Parameters.Add("@CodigoConta", SqlDbType.Int, 4, "CodigoConta")
                        tam = frm.cboConta.Text.Length
                        .Parameters(2).Value = CLng(frm.cboConta.Text.Substring(tam - 4, 4))
                        .Parameters.Add("@ValorTitulo", SqlDbType.Decimal, 9, "ValorTitulo")
                        .Parameters(3).Value = CDec(Me.lstvTitulos.SelectedItems(i).SubItems(3).Text)

                        If frm.chkEmitirCheque.Checked Then
                            If frm.chkChequeIndividual.Checked Then
                                If frm.chkNominalFornecedor.Checked Then
                                    .CommandText = "spBaixarTituloDebitarContaGerarChequeIndividualNominalFornecedor"
                                Else
                                    .CommandText = "spBaixarTituloDebitarContaGerarChequeIndividualComNominativo"
                                    .Parameters.Add("@Nominativo", SqlDbType.VarChar, 70, "Nominativo")
                                    .Parameters(4).Value = frm.txtNominativoCheque.Text.Trim
                                End If
                            Else
                                'Só vai gerar o cheque na primeira rodada do for..next
                                If Not ChequeGerado Then
                                    ChequeGerado = True
                                    cmdChequeColetivo.CommandType = CommandType.StoredProcedure
                                    cmdChequeColetivo.Parameters.Add("@Nominativo", SqlDbType.VarChar, 70, "Nominativo")
                                    cmdChequeColetivo.Parameters(0).Value = frm.txtNominativoCheque.Text.Trim
                                    cmdChequeColetivo.Parameters.Add("@DataBaixa", SqlDbType.DateTime, 8, "DataBaixa")
                                    cmdChequeColetivo.Parameters(1).Value = frm.dtpDataBaixa.Value.ToShortDateString
                                    cmdChequeColetivo.Parameters.Add("@ValorCheque", SqlDbType.Decimal, 9, "ValorCheque")
                                    cmdChequeColetivo.Parameters(2).Value = nValor
                                    cmdChequeColetivo.Parameters.Add("@CodigoConta", SqlDbType.Int, 4, "CodigoConta")
                                    tam = frm.cboConta.Text.Length
                                    cmdChequeColetivo.Parameters(3).Value = CLng(frm.cboConta.Text.Substring(tam - 4, 4))
                                    cmdChequeColetivo.Parameters.Add("@CodigoCheque", SqlDbType.Int, 4, "CodigoCheque")
                                    cmdChequeColetivo.Parameters(4).Direction = ParameterDirection.Output
                                    cnn.Open()
                                    cmdChequeColetivo.ExecuteNonQuery()
                                    cnn.Close()
                                    CodigoChequeColetivo = CLng(cmdChequeColetivo.Parameters(4).Value)
                                End If

                                .CommandText = "spBaixarTituloDebitarContaComChequeColetivo"
                                
                                .Parameters.Add("@CodigoCheque", SqlDbType.Int, 4, "CodigoCheque")
                                .Parameters(4).Value = CodigoChequeColetivo

                            End If
                        Else
                            .CommandText = "spBaixarTituloDebitarContaNaoGerarCheque"
                        End If
                    Else
                        .CommandText = "spBaixarTituloNaoDebitarConta"
                    End If

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

End Class