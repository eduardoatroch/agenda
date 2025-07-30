Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Drawing.Printing
Imports System.IO

Public Class frmRptBoletos
    Private ImpressoraSelecionada, CaminhoImp As String
    Private ContadorLinhas, LinhasPorPagina As Integer
    Private StreamArquivo As StreamReader
    Private Fonte As Font
    Private CodigoCliente As Long = 0

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub frmRptBoletos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PreencherComboImpressorasInstaladas()
        ObterCaminhoRpt()
        PreencherListaClientes()
    End Sub

    Private Sub PreencherComboImpressorasInstaladas()
        Dim i As Integer

        For i = 0 To PrinterSettings.InstalledPrinters.Count - 1
            Me.cboImpressorasRede.Items.Add(PrinterSettings.InstalledPrinters(i))
        Next

    End Sub

    Private Sub cboImpressorasRede_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboImpressorasRede.SelectedIndexChanged
        Me.ImpressoraSelecionada = Me.cboImpressorasRede.Text.Trim
        Me.PintarLista()
    End Sub

    Private Sub ObterCaminhoRpt()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarCaminhoRelatorios", cnn)
        Dim dtr As SqlClient.SqlDataReader

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    Me.CaminhoImp = dtr(0).ToString
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

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Me.PintarLista()
        'If Me.cboImpressorasRede.Text.Trim = "" Then
        '    MsgBox("Selecione uma impressora por favor!", MsgBoxStyle.Exclamation)
        '    Me.cboImpressorasRede.Focus()
        '    Exit Sub
        'End If
        If Me.lstvTitulosReceber.SelectedItems.Count = 0 Then
            MsgBox("Selecione o(s) título(s) para impressão", MsgBoxStyle.Information)
            Exit Sub
        End If
        If MsgBox("Confirma a impressão agora?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ImprimirViaStreamer()
        End If
    End Sub

    Private Sub ImprimirViaStreamer()
        Dim I, J, Arquivo, Tam, Espacos As Integer
        Dim LinhaArquivoTexto, sDataDocumento, sDocumento, sAceite As String

        Arquivo = FreeFile()
        'FileOpen(Arquivo, Me.CaminhoImp & "\Boletos.txt", OpenMode.Output, OpenAccess.Write)
        FileOpen(Arquivo, "c:\temp\Boletos.txt", OpenMode.Output, OpenAccess.Write)

        Me.ContadorLinhas = 0

        For I = 0 To Me.lstvTitulosReceber.SelectedItems.Count - 1

            'Vencimento
            LinhaArquivoTexto = Space(63) & Me.lstvTitulosReceber.SelectedItems(I).SubItems(2).Text.Trim
            PrintLine(Arquivo, LinhaArquivoTexto)
            ContadorLinhas += 1

            For J = 1 To 3
                LinhaArquivoTexto = Space(5)
                PrintLine(Arquivo, LinhaArquivoTexto)
                ContadorLinhas += 1
            Next

            'Data Documento+Nº Documento+Aceite
            sDataDocumento = Now.Date.ToShortDateString
            Tam = Me.lstvTitulosReceber.SelectedItems(I).SubItems(1).Text.Length
            If Tam >= 20 Then
                sDocumento = Me.lstvTitulosReceber.SelectedItems(I).SubItems(1).Text.Substring(0, 20)
            Else
                Espacos = 2 - -Tam
                sDocumento = Me.lstvTitulosReceber.SelectedItems(I).SubItems(1).Text.Trim & Space(Espacos)
            End If
            If Me.chkAceite.Checked Then
                sAceite = "S"
            Else
                sAceite = "N"
            End If
            LinhaArquivoTexto = sDataDocumento & Space(4) & sDocumento & Space(14) & sAceite
            PrintLine(Arquivo, LinhaArquivoTexto)
            ContadorLinhas += 1

            'Valor
            LinhaArquivoTexto = Space(65) & Me.lstvTitulosReceber.SelectedItems(I).SubItems(3).Text.Trim
            PrintLine(Arquivo, LinhaArquivoTexto)
            ContadorLinhas += 1

            For J = 1 To 3
                LinhaArquivoTexto = Space(5)
                PrintLine(Arquivo, LinhaArquivoTexto)
                ContadorLinhas += 1
            Next

            'Juros por atraso
            LinhaArquivoTexto = "APOS VENCIMENTO MORA DIA DE R$ " & Me.lstvTitulosReceber.Items(I).SubItems(4).Text.Trim
            PrintLine(Arquivo, LinhaArquivoTexto)
            ContadorLinhas += 1

            LinhaArquivoTexto = "SUJEITO A PROTESTO APOS O QUINTO DIA UTIL DO VENCIMENTO"
            PrintLine(Arquivo, LinhaArquivoTexto)
            ContadorLinhas += 1

            For J = 1 To 3
                LinhaArquivoTexto = Space(5)
                PrintLine(Arquivo, LinhaArquivoTexto)
                ContadorLinhas += 1
            Next

            'Sacado
            LinhaArquivoTexto = Space(5) & Me.lstvTitulosReceber.SelectedItems(I).SubItems(5).Text.Trim
            PrintLine(Arquivo, LinhaArquivoTexto)
            ContadorLinhas += 1

            'Endereço+Bairro
            LinhaArquivoTexto = Space(5) & Me.lstvTitulosReceber.SelectedItems(I).SubItems(6).Text.Trim & ", " & _
                                           Me.lstvTitulosReceber.SelectedItems(I).SubItems(7).Text.Trim
            PrintLine(Arquivo, LinhaArquivoTexto)
            ContadorLinhas += 1

            'Cidade+UF+Cep
            LinhaArquivoTexto = Space(5) & Me.lstvTitulosReceber.SelectedItems(I).SubItems(8).Text.Trim & "/" & _
                                           Me.lstvTitulosReceber.SelectedItems(I).SubItems(9).Text.Trim & Space(10) & _
                                           "CEP: " & Me.lstvTitulosReceber.SelectedItems(I).SubItems(10).Text.Trim
            PrintLine(Arquivo, LinhaArquivoTexto)
            ContadorLinhas += 1

            For J = 1 To 7
                LinhaArquivoTexto = Space(5)
                PrintLine(Arquivo, LinhaArquivoTexto)
                ContadorLinhas += 1
            Next

        Next

        FileClose(Arquivo)

        'CriarStreamer()

        Shell("command.com /c type c:\temp\Boletos.txt > prn")
        MsgBox("Impressão concluída!", MsgBoxStyle.Information)
    End Sub

    Private Sub CriarStreamer()

        Try
            'StreamArquivo = New StreamReader(Me.CaminhoImp & "c:\temp\Boletos.txt")
            StreamArquivo = New StreamReader("c:\temp\Boletos.txt")
            Try
                Fonte = New Font("Courier New", 9)
                Dim pd As New PrintDocument()
                AddHandler pd.PrintPage, AddressOf Me.EventoPrintPage

                pd.PrinterSettings.PrinterName = Me.ImpressoraSelecionada
                pd.DefaultPageSettings.Landscape = False
                pd.DefaultPageSettings.Margins.Top = 2
                pd.DefaultPageSettings.Margins.Left = 2

                pd.Print()

            Finally
                StreamArquivo.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub EventoPrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Dim ypos As Single = 0
        Dim Linhas As Long = 0
        Dim RegistroCorrente As String = Nothing

        LinhasPorPagina = e.MarginBounds.Height / Fonte.GetHeight(e.Graphics)
        'LinhasPorPagina = 85 'Me.ContadorLinhas

        While Linhas < LinhasPorPagina

            RegistroCorrente = Me.StreamArquivo.ReadLine()

            If RegistroCorrente = Nothing Then
                'Exit While
            End If

            ypos = e.MarginBounds.Top + Linhas * Fonte.GetHeight(e.Graphics)

            e.Graphics.DrawString(RegistroCorrente, Fonte, Brushes.Black, e.MarginBounds.Left, ypos, New StringFormat())

            Linhas += 1

        End While

        If Not (RegistroCorrente Is Nothing) Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If

    End Sub

    Private Sub PreencherListaClientes()
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

    Private Sub btnPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisar.Click
        Me.PreencherListaRecebimentos()
    End Sub

    Private Sub PreencherListaRecebimentos()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand
        Dim DS As New dsRecebimentos
        Dim DA As SqlClient.SqlDataAdapter
        Dim LVI As ListViewItem
        Dim SQL, sCodigo As String
        Dim I As Integer


        Try

            Me.lstvTitulosReceber.Items.Clear()

            If Me.cboCliente.Text.Trim = "" Then
                SQL = "select * from vwRecebimentos order by NomeCli,Venc"
            Else
                Me.CodigoCliente = 1000000 + Me.CodigoCliente
                sCodigo = Me.CodigoCliente.ToString.Substring(1, 6)
                SQL = "select * from vwRecebimentos where CodCli='" & sCodigo & "' order by NomeCli,Venc"
            End If

            With cmd
                .CommandType = CommandType.Text
                .Connection = cnn
                .CommandText = SQL
            End With

            DS.Clear()
            DA = New SqlClient.SqlDataAdapter(cmd)
            DA.Fill(DS, "vwRecebimentos")

            If DS.vwRecebimentos.Count > 0 Then

                'Filtrar a Data de baixa no DataSet
                For I = 0 To DS.vwRecebimentos.Count - 1
                    If CDate(DS.vwRecebimentos(I).Venc) >= Me.dtpDataIni.Value.Date And CDate(DS.vwRecebimentos(I).Venc) <= Me.dtpDataFim.Value.Date Then
                        LVI = Me.lstvTitulosReceber.Items.Add(DS.vwRecebimentos(I).CodREC)
                        LVI.SubItems.Add(DS.vwRecebimentos(I).Documento)
                        LVI.SubItems.Add(DS.vwRecebimentos(I).Venc)
                        LVI.SubItems.Add(classRotinas.Moeda(CDec(DS.vwRecebimentos(I).ValorOrig)))
                        LVI.SubItems.Add(classRotinas.Moeda(CDec(DS.vwRecebimentos(I).juros)))
                        LVI.SubItems.Add(DS.vwRecebimentos(I).NomeCli)
                        LVI.SubItems.Add(DS.vwRecebimentos(I).Endereco)
                        LVI.SubItems.Add(DS.vwRecebimentos(I).Bairro)
                        LVI.SubItems.Add(DS.vwRecebimentos(I).Cidade)
                        LVI.SubItems.Add(DS.vwRecebimentos(I).UF)
                        LVI.SubItems.Add(DS.vwRecebimentos(I).Cep)
                    Else
                        DS.vwRecebimentos(I).Delete()
                    End If
                Next

            Else
                MsgBox("Não existe Recebimentos para os parâmetros informados", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            MsgBox(ex.Source & Chr(13) & ex.Message)
        Finally
            cnn.Dispose()
            cmd.Dispose()
            GC.Collect()
        End Try

    End Sub

    Private Sub cboCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCliente.SelectedIndexChanged
        InicializarCodigoCliente()
    End Sub

    Private Sub InicializarCodigoCliente()
        Dim tam As Integer
        If Me.cboCliente.Text.Trim <> "" Then
            tam = Me.cboCliente.Text.Length
            Me.CodigoCliente = CLng(Me.cboCliente.Text.Substring(tam - 6, 6))
        End If
    End Sub

    Private Sub lstvTitulosReceber_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstvTitulosReceber.SelectedIndexChanged
        If Me.lstvTitulosReceber.SelectedItems.Count > 0 Then
            Me.lstvTitulosReceber.SelectedItems(0).BackColor = Color.Blue
            Me.lstvTitulosReceber.SelectedItems(0).ForeColor = Color.White
        Else
            PintarLista()
        End If
    End Sub

    Private Sub PintarLista()
        Dim I As Integer
        For I = 0 To Me.lstvTitulosReceber.Items.Count - 1
            If Me.lstvTitulosReceber.Items(I).Selected = True Then
                Me.lstvTitulosReceber.Items(I).BackColor = Color.Blue
                Me.lstvTitulosReceber.Items(I).ForeColor = Color.White
            Else
                Me.lstvTitulosReceber.Items(I).BackColor = Color.White
                Me.lstvTitulosReceber.Items(I).ForeColor = Color.Black
            End If
        Next
    End Sub

End Class