Public Class frmTitulosReceber
    Private ContaCorrente As String

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisar.Click
        Me.PreencherListaTitulos()
    End Sub

    Private Sub frmTitulosReceber_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PreencherListaTitulos()
        Me.PreencherComboCliente()
        Me.grpDataBaixa.Visible = False
    End Sub

    Private Sub PreencherListaTitulos()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand
        Dim dtr As SqlClient.SqlDataReader
        Dim lvi As ListViewItem
        Dim Tam As Integer

        Try

            Me.lstvTitulos.Items.Clear()

            With cmd

                .CommandType = CommandType.StoredProcedure
                .Connection = cnn

                If Me.rbStatusAberto.Checked Then

                    If Me.chkPeriodo.Checked = False Then
                        If Me.cboCliente.Text.Trim = "" Then
                            .CommandText = "spRetornarTitulosReceber"
                        Else
                            .CommandText = "spRetornarTitulosReceber;5"
                            Tam = Me.cboCliente.Text.Length
                            .Parameters.Add("@CodigoCli", SqlDbType.Int, 4, "CodigoCli")
                            .Parameters(0).Value = CLng(Me.cboCliente.Text.Substring(Tam - 6, 6))
                        End If
                    Else
                        .Parameters.Add("@DataIni", SqlDbType.DateTime, 8, "DataIni")
                        .Parameters(0).Value = Me.dtpDataInicio.Value.Date
                        .Parameters.Add("@DataFim", SqlDbType.DateTime, 8, "DataFim")
                        .Parameters(1).Value = Me.dtpDataFim.Value.Date
                        If Me.cboCliente.Text.Trim = "" Then
                            .CommandText = "spRetornarTitulosReceber;2"
                        Else
                            .CommandText = "spRetornarTitulosReceber;6"
                            .Parameters.Add("@CodigoCli", SqlDbType.Int, 4, "CodigoCli")
                            Tam = Me.cboCliente.Text.Length
                            .Parameters(2).Value = CLng(Me.cboCliente.Text.Substring(Tam - 6, 6))
                        End If
                    End If

                Else

                    If Me.chkPeriodo.Checked = False Then

                        If Me.cboCliente.Text.Trim = "" Then
                            .CommandText = "spRetornarTitulosReceber;3"
                        Else
                            .CommandText = "spRetornarTitulosReceber;7"
                            .Parameters.Add("@CodigoCli", SqlDbType.Int, 4, "CodigoCli")
                            Tam = Me.cboCliente.Text.Length
                            .Parameters(0).Value = CLng(Me.cboCliente.Text.Substring(Tam - 6, 6))
                        End If
                    Else
                        .Parameters.Add("@DataIni", SqlDbType.DateTime, 8, "DataIni")
                        .Parameters(0).Value = Me.dtpDataInicio.Value.Date
                        .Parameters.Add("@DataFim", SqlDbType.DateTime, 8, "DataFim")
                        .Parameters(1).Value = Me.dtpDataFim.Value.Date
                        If Me.cboCliente.Text.Trim = "" Then
                            .CommandText = "spRetornarTitulosReceber;4"
                        Else
                            .CommandText = "spRetornarTitulosReceber;8"
                            .Parameters.Add("@CodigoCli", SqlDbType.Int, 4, "CodigoCli")
                            Tam = Me.cboCliente.Text.Length
                            .Parameters(2).Value = CLng(Me.cboCliente.Text.Substring(Tam - 6, 6))
                        End If
                    End If

                End If

                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    lvi = Me.lstvTitulos.Items.Add(dtr(0).ToString) 'Código REC
                    lvi.SubItems.Add(dtr(1).ToString) 'Documento
                    lvi.SubItems.Add(CDate(dtr(2)).ToShortDateString) 'Vencimento
                    lvi.SubItems.Add(classRotinas.Moeda(dtr(3))) 'Valor Original
                    If CDate(dtr(4)) = CDate("01/01/1900") Then
                        lvi.SubItems.Add("")
                    Else
                        lvi.SubItems.Add(CDate(dtr(4)).ToShortDateString) 'Data Pagamento
                    End If
                    If CDec(dtr(5)) > 0 Then
                        lvi.SubItems.Add(classRotinas.Moeda(CDec(dtr(5)))) 'Valor Pago
                    Else
                        lvi.SubItems.Add("")
                    End If
                    lvi.SubItems.Add(dtr(6).ToString) 'Hitórico
                    lvi.SubItems.Add(dtr(7).ToString) 'Cliente
                    lvi.SubItems.Add(dtr(8).ToString) 'Status de Pagamento (0-Não, 1-Sim)
                    lvi.SubItems.Add(dtr(9).ToString) 'Endereço
                    lvi.SubItems.Add(dtr(10).ToString) 'Bairro
                    lvi.SubItems.Add(dtr(11).ToString) 'Cidade
                    lvi.SubItems.Add(dtr(12).ToString) 'UF
                    lvi.SubItems.Add(dtr(13).ToString) 'Cep
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

    Private Sub PreencherComboCliente()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarListaClientes", cnn)
        Dim dtr As SqlClient.SqlDataReader

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    Me.cboCLiente.Items.Add(dtr(1) & " - " & dtr(0))
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

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        If Me.lstvTitulos.SelectedItems.Count = 0 Then
            MsgBox("Selecione o Recebimento que deseja alterar na lista abaixo!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim frm As New frmIncluirEditarTituloReceber(CLng(Me.lstvTitulos.SelectedItems(0).Text), False)
        frm.ShowDialog()
        Me.PreencherListaTitulos()
    End Sub

    Private Sub btnIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncluir.Click
        Dim frm As New frmIncluirEditarTituloReceber(0, True)
        frm.ShowDialog()
        Me.PreencherListaTitulos()
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        If Me.lstvTitulos.SelectedItems.Count = 0 Then
            MsgBox("Selecione o Recebimento que deseja excluir na lista abaixo!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If MsgBox("Confirma a exclusão do Recebimento: " & Me.lstvTitulos.SelectedItems(0).Text.Trim, MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.ExcluirRecebimento()
            Me.PreencherListaTitulos()
        End If
    End Sub

    Private Sub ExcluirRecebimento()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spExcluirTituloReceber", cnn)

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@CodigoRec", SqlDbType.Int, 4, "CodigoRec")
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

    Private Sub btnBaixar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaixar.Click
        If Me.lstvTitulos.SelectedItems.Count = 0 Then
            MsgBox("Selecione o(s) recebimento(s) que deja Baixar", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If MsgBox("Confirma baixar o(s) recebimento(s) selecionado(s)?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If MsgBox("Vai creditar a Conta Corrente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim Portador As New frmPortador
                Dim Tam As Integer
                Portador.ShowDialog()
                If Portador.cboConta.Text.Trim <> "" Then
                    Tam = Portador.cboConta.Text.Length
                    Me.ContaCorrente = Portador.cboConta.Text.Substring(Tam - 4, 4)
                Else
                    Me.ContaCorrente = "0"
                End If

                MsgBox(ContaCorrente)

            End If
            If MsgBox("Confirma a data de pagamento abaixo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                BaixarRecebimentos()
                Me.grpDataBaixa.Visible = False
                Me.PreencherListaTitulos()
            Else
                Exit Sub
            End If

        End If

    End Sub

    Private Sub BaixarRecebimentos()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand
        Dim I As Integer

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Connection = cnn
                If Me.ContaCorrente <> "" Then
                    .CommandText = "spBaixarRecebimentoCreditarBanco"
                Else
                    .CommandText = "spBaixarRecebimento"
                End If
                For I = 0 To Me.lstvTitulos.SelectedItems.Count - 1
                    If Me.lstvTitulos.SelectedItems(I).SubItems(8).Text.Substring(0, 1) <> "1" Then
                        .Parameters.Clear()
                        .Parameters.Add("@CodigoRec", SqlDbType.Int, 4, "CodigoRec")
                        .Parameters(0).Value = CLng(Me.lstvTitulos.SelectedItems(I).Text)
                        .Parameters.Add("@DataBaixa", SqlDbType.DateTime, 8, "DataBaixa")
                        .Parameters(1).Value = Me.dtpDataBaixa.Value.Date
                        If Me.ContaCorrente <> "" Then
                            .Parameters.Add("@ContaCorrente", SqlDbType.VarChar, 10)
                            .Parameters(2).Value = Me.ContaCorrente
                        End If
                        cnn.Open()
                        .ExecuteNonQuery()
                        cnn.Close()
                    End If
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

    Private Sub lstvTitulos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstvTitulos.SelectedIndexChanged

        If Me.lstvTitulos.SelectedItems.Count > 0 Then
            Me.lstvTitulos.SelectedItems(0).BackColor = Color.Blue
            Me.lstvTitulos.SelectedItems(0).ForeColor = Color.White
            Me.grpDataBaixa.Visible = True
        Else
            Dim i As Integer
            For i = 0 To Me.lstvTitulos.Items.Count - 1
                If Me.lstvTitulos.Items(i).Selected = False Then
                    Me.lstvTitulos.Items(i).BackColor = Color.White
                    Me.lstvTitulos.Items(i).ForeColor = Color.Black
                End If
            Next
        End If

    End Sub

    Private Sub btnBoletos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBoletos.Click
        Dim frm As New frmRptBoletos
        frm.ShowDialog()
    End Sub

End Class