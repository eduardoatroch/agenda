Imports System.IO
Imports System.Drawing.Printing
Public Class frmCheques

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub frmCheques_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PreencherComboBanco()
        'PreencherListaCheques()
    End Sub

    Private Sub PreencherComboBanco()
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
                    Me.cboBanco.Items.Add(dtr(0) & " - " & dtr(1)) 'Código + Nº do banco
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

    Private Sub cboBanco_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBanco.SelectedIndexChanged
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarAgenciasDoBanco", cnn)
        Dim dtr As SqlClient.SqlDataReader

        Try

            Me.cboConta.Items.Clear()
            Me.cboAgencia.Items.Clear()
            Me.cboConta.Text = ""
            Me.cboAgencia.Text = ""

            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@Banco", SqlDbType.SmallInt, 2, "Banco")
                .Parameters(0).Value = CInt(Me.cboBanco.Text.Substring(0, 3))
                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    Me.cboAgencia.Items.Add(dtr(1).ToString)
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

    Private Sub cboAgencia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAgencia.SelectedIndexChanged
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarContasDaAgencia", cnn)
        Dim dtr As SqlClient.SqlDataReader

        Try

            Me.cboConta.Items.Clear()
            Me.cboConta.Text = ""

            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@Agencia", SqlDbType.VarChar, 10, "Agencia")
                .Parameters(0).Value = Me.cboAgencia.Text.Trim
                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    Me.cboConta.Items.Add(dtr(1) & " - " & dtr(0)) 'Nº da conta + Código da Conta
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

    Private Sub PreencherListaCheques()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand
        Dim dtr As SqlClient.SqlDataReader
        Dim lvi As ListViewItem
        Dim tam As Integer
        Dim valorExtenso As String

        Try

            Me.lstvCheques.Items.Clear()

            With cmd

                .CommandType = CommandType.StoredProcedure
                .Connection = cnn

                .Parameters.Add("@DtIni", SqlDbType.DateTime, 8, "DtIni")
                .Parameters(0).Value = Me.dtpDataInicial.Value.ToShortDateString
                .Parameters.Add("@DtFim", SqlDbType.DateTime, 8, "DtFim")
                .Parameters(1).Value = Me.dtpDataFinal.Value.ToShortDateString

                If Me.cboConta.Text.Trim = "" Then

                    If Me.rbStatusNaoCancelado.Checked Then
                        If Me.rbImpNao.Checked Then
                            .CommandText = "spRetornarListaCheques"
                        ElseIf Me.rbImpSim.Checked Then
                            .CommandText = "spRetornarListaCheques;2"
                        ElseIf Me.rbImpGeral.Checked Then
                            .CommandText = "spRetornarListaCheques;3"
                        End If
                    ElseIf Me.rbStatusCancelado.Checked Then
                        If Me.rbImpNao.Checked Then
                            .CommandText = "spRetornarListaCheques;4"
                        ElseIf Me.rbImpSim.Checked Then
                            .CommandText = "spRetornarListaCheques;5"
                        ElseIf Me.rbImpGeral.Checked Then
                            .CommandText = "spRetornarListaCheques;6"
                        End If
                    ElseIf Me.rbStatusGeral.Checked Then
                        If Me.rbImpNao.Checked Then
                            .CommandText = "spRetornarListaCheques;7"
                        ElseIf Me.rbImpSim.Checked Then
                            .CommandText = "spRetornarListaCheques;8"
                        ElseIf Me.rbImpGeral.Checked Then
                            .CommandText = "spRetornarListaCheques;9"
                        End If
                    End If

                Else

                    .Parameters.Add("@CodigoConta", SqlDbType.Int, 4, "CodigoConta")
                    tam = Me.cboConta.Text.Length
                    .Parameters(2).Value = CLng(Me.cboConta.Text.Substring(tam - 4, 4))

                    If Me.rbStatusNaoCancelado.Checked Then
                        If Me.rbImpNao.Checked Then
                            .CommandText = "spRetornarListaCheques;10"
                        ElseIf Me.rbImpSim.Checked Then
                            .CommandText = "spRetornarListaCheques;11"
                        ElseIf Me.rbImpGeral.Checked Then
                            .CommandText = "spRetornarListaCheques;12"
                        End If
                    ElseIf Me.rbStatusCancelado.Checked Then
                        If Me.rbImpNao.Checked Then
                            .CommandText = "spRetornarListaCheques;13"
                        ElseIf Me.rbImpSim.Checked Then
                            .CommandText = "spRetornarListaCheques;14"
                        ElseIf Me.rbImpGeral.Checked Then
                            .CommandText = "spRetornarListaCheques;15"
                        End If
                    ElseIf Me.rbStatusGeral.Checked Then
                        If Me.rbImpNao.Checked Then
                            .CommandText = "spRetornarListaCheques;16"
                        ElseIf Me.rbImpSim.Checked Then
                            .CommandText = "spRetornarListaCheques;17"
                        ElseIf Me.rbImpGeral.Checked Then
                            .CommandText = "spRetornarListaCheques;18"
                        End If
                    End If
                End If

                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    lvi = Me.lstvCheques.Items.Add(dtr(0).ToString) 'Código Cheque
                    lvi.SubItems.Add(dtr(1).ToString) 'Nº do cheque
                    lvi.SubItems.Add(CDate(dtr(2)).ToShortDateString) 'Data de Emissão
                    lvi.SubItems.Add(clsRotinas.Moeda(CDec(dtr(3)))) 'Valor do Cheque
                    lvi.SubItems.Add(dtr(4).ToString) 'Nominativo
                    lvi.SubItems.Add(dtr(5).ToString) 'Impresso 0=Não, 1=Sim
                    lvi.SubItems.Add(dtr(6).ToString) 'Cancelado 0=Não, 1=Sim
                    If CDate("01/01/1900") = CDate(dtr(7)) Then
                        lvi.SubItems.Add("")
                    Else
                        lvi.SubItems.Add(CDate(dtr(7)).ToShortDateString) 'Data do Cancelamento
                    End If
                    lvi.SubItems.Add(dtr(8).ToString) 'Banco
                    lvi.SubItems.Add(dtr(9).ToString) 'Agência
                    lvi.SubItems.Add(dtr(10).ToString) 'Conta Bancária

                    valorExtenso = CDec(dtr(3)).ToString("N")
                    lvi.SubItems.Add(Extenso.RetornarValorExtenso(valorExtenso))

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
        PreencherListaCheques()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        If Me.lstvCheques.SelectedItems.Count = 0 Then
            MsgBox("Selecione o(s) cheque(s) que deseja cancelar", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Me.grpDataCancelamento.Visible = True
    End Sub

    Private Sub btnConfirmarCancelamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmarCancelamento.Click
        If MsgBox("Confirma cancelar o(s) cheque(s) selecionado(s) agora ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            CancelarCheques()
            Me.grpDataCancelamento.Visible = False
            Me.PreencherListaCheques()
        End If
    End Sub

    Private Sub CancelarCheques()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spCancelarCheque", cnn)
        Dim I As Integer

        Try
            With cmd

                .CommandType = CommandType.StoredProcedure

                For I = Me.lstvCheques.SelectedItems.Count - 1 To 0 Step -1
                    .Parameters.Clear()
                    .Parameters.Add("@CodigoCheque", SqlDbType.Int, 4, "CodigoCheque")
                    .Parameters(0).Value = CLng(Me.lstvCheques.SelectedItems(I).Text)
                    .Parameters.Add("@DataCancelamento", SqlDbType.DateTime, 8, "DataCancelamento")
                    .Parameters(1).Value = Me.dtpDataCancelamento.Value.ToShortDateString
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

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        If Me.lstvCheques.SelectedItems.Count = 0 Then
            MsgBox("Selecione o(s) cheque(s) que deseja imprimir", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If MsgBox("Confirma imprimir o(s) cheque(s) selecionado(s) agora ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ImprimirCheques()
            Me.PreencherListaCheques()
        End If

    End Sub

    Private Sub ImprimirCheques()
        Dim Arquivo, I, J, L, mCodigoCheque, DiaCheque, AnoCheque, TamExtenso, Asteriscos As Integer
        Dim cmdLer As SqlClient.SqlCommand
        Dim cExtenso, cExtenso2, Nominativo, MesExtenso, cValor, cBanco, LinhaArquivoTexto As String
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)

        If Me.lstvCheques.SelectedItems(0).SubItems(5).Text.Substring(0, 1) = "1" Then
            MsgBox("Este cheque já foi impresso, re-impressão negada", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Arquivo = FreeFile()
        FileOpen(Arquivo, "c:\SisFaz\Cheques.txt", OpenMode.Output, OpenAccess.Write)

        For I = 0 To Me.lstvCheques.SelectedItems.Count - 1

            'Verificar se o cheque não foi impresso ainda
            If Me.lstvCheques.SelectedItems(I).SubItems(5).Text.Substring(0, 1) = "0" Then
                '------- Formatar os Dados a serem impressos -------
                cBanco = lstvCheques.SelectedItems(I).SubItems(8).Text.Substring(0, 3)

                mCodigoCheque = CLng(Me.lstvCheques.SelectedItems(I).Text)

                cValor = clsRotinas.Moeda(CDec(lstvCheques.SelectedItems(I).SubItems(3).Text))

                cExtenso = Extenso.RetornarValorExtenso(cValor)

                cValor = "****" & cValor

                TamExtenso = cExtenso.Length
                Asteriscos = 75 - TamExtenso

                For J = 1 To Asteriscos
                    cExtenso = cExtenso & "*"
                Next

                cExtenso = "(" & cExtenso
                cExtenso2 = "***************************************************************************)"

                'Nominal = CByte(Me.lstvCheques.SelectedItems(I).SubItems(4).Text.Substring(0, 1))

                If Me.lstvCheques.SelectedItems(I).SubItems(4).Text.Trim <> "" Then
                    Nominativo = Me.lstvCheques.SelectedItems(I).SubItems(4).Text.Trim
                Else
                    Nominativo = ""
                End If

                MesExtenso = clsRotinas.MesPorExtenso(CDate(Me.lstvCheques.SelectedItems(I).SubItems(2).Text).Month)
                DiaCheque = CDate(Me.lstvCheques.SelectedItems(I).SubItems(2).Text).Day
                AnoCheque = CDate(Me.lstvCheques.SelectedItems(I).SubItems(2).Text).Year

                '--- Inicio da Impressao do Cheque
                If cBanco = "070" Then

                    LinhaArquivoTexto = Space(120) & cValor
                    PrintLine(Arquivo, LinhaArquivoTexto)

                    LinhaArquivoTexto = Space(44) & cExtenso
                    PrintLine(Arquivo, LinhaArquivoTexto)

                    LinhaArquivoTexto = Space(40) & cExtenso2
                    PrintLine(Arquivo, LinhaArquivoTexto)

                    LinhaArquivoTexto = "  "
                    PrintLine(Arquivo, LinhaArquivoTexto)

                    LinhaArquivoTexto = Space(35) & Nominativo
                    PrintLine(Arquivo, LinhaArquivoTexto)

                    LinhaArquivoTexto = "  "
                    PrintLine(Arquivo, LinhaArquivoTexto)

                    LinhaArquivoTexto = Space(80) & "Brasilia         " & DiaCheque & "       " & MesExtenso & "                  " & AnoCheque
                    PrintLine(Arquivo, LinhaArquivoTexto)

                    For L = 1 To 11
                        LinhaArquivoTexto = Space(10)
                        PrintLine(Arquivo, LinhaArquivoTexto)
                    Next

                ElseIf cBanco = "104" Then

                    LinhaArquivoTexto = Space(92) & cValor
                    PrintLine(Arquivo, LinhaArquivoTexto)

                    LinhaArquivoTexto = Space(10)
                    PrintLine(Arquivo, LinhaArquivoTexto)

                    LinhaArquivoTexto = Space(24) & cExtenso
                    PrintLine(Arquivo, LinhaArquivoTexto)

                    LinhaArquivoTexto = Space(24) & cExtenso2
                    PrintLine(Arquivo, LinhaArquivoTexto)

                    LinhaArquivoTexto = "  "
                    PrintLine(Arquivo, LinhaArquivoTexto)

                    LinhaArquivoTexto = Space(9) & Nominativo
                    PrintLine(Arquivo, LinhaArquivoTexto)

                    LinhaArquivoTexto = Space(10)
                    PrintLine(Arquivo, LinhaArquivoTexto)

                    LinhaArquivoTexto = Space(65) & "Brasilia     " & DiaCheque & "         " & MesExtenso & "                  " & AnoCheque
                    PrintLine(Arquivo, LinhaArquivoTexto)

                    For L = 1 To 10
                        LinhaArquivoTexto = Space(10)
                        PrintLine(Arquivo, LinhaArquivoTexto)
                    Next

                ElseIf cBanco = "237" Then

                    LinhaArquivoTexto = Space(62) & cValor
                    PrintLine(Arquivo, LinhaArquivoTexto)

                    LinhaArquivoTexto = Space(10)
                    PrintLine(Arquivo, LinhaArquivoTexto)

                    LinhaArquivoTexto = Space(6) & cExtenso
                    PrintLine(Arquivo, LinhaArquivoTexto)

                    LinhaArquivoTexto = Space(4) & cExtenso2
                    PrintLine(Arquivo, LinhaArquivoTexto)

                    LinhaArquivoTexto = "  "
                    PrintLine(Arquivo, LinhaArquivoTexto)
                    LinhaArquivoTexto = "  "
                    PrintLine(Arquivo, LinhaArquivoTexto)

                    LinhaArquivoTexto = Space(1) & Nominativo
                    PrintLine(Arquivo, LinhaArquivoTexto)

                    LinhaArquivoTexto = Space(10)
                    PrintLine(Arquivo, LinhaArquivoTexto)

                    LinhaArquivoTexto = Space(28) & "Brasilia         " & DiaCheque & "     " & MesExtenso & "            " & AnoCheque
                    PrintLine(Arquivo, LinhaArquivoTexto)

                    For L = 1 To 9
                        LinhaArquivoTexto = Space(10)
                        PrintLine(Arquivo, LinhaArquivoTexto)
                    Next

                End If

                '--- Final da Impressao do Cheque

                '--- Atualizando o Status de Impressao no cheque impresso                
                cmdLer = New SqlClient.SqlCommand("spAtualizarStatusImpressaoCheque", cnn)
                cmdLer.CommandType = CommandType.StoredProcedure
                cmdLer.Parameters.Add("@CodigoCheque", SqlDbType.Int, 4, "CodigoCheque")
                cmdLer.Parameters(0).Value = mCodigoCheque
                cnn.Open()
                cmdLer.ExecuteNonQuery()
                cnn.Close()

            End If

        Next

        FileClose(Arquivo)

        PreencherListaCheques()

        If MsgBox("Já posicionou o(s) cheque(s) corretamente na impressora ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            'Imprimir o texto atraves do prompt de comando
            'Shell("command.com /c type c:\sisfaz\Cheques.txt > prn")
            System.IO.File.Copy("C:\Sisfaz\Cheques.txt", BancoDeDados.mapeamentoImpressora, True)
        Else
            Exit Sub
        End If

    End Sub

    
End Class