Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmRptTitulosPagosPorFornecedor
    Private crDocumento As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Private CaminhoImp, NomeFilial, FoneFilial As String

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub frmRptTitulosPagosPorFornecedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ObterCaminhoRpt()
        PreencherComboFornecedor()
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
                    Me.NomeFilial = dtr(1).ToString
                    Me.FoneFilial = dtr(2).ToString
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

    Private Sub frmRptTitulosPagosPorFornecedor_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.crvTitPagoPorFornecedor.Height = Me.Height - 100
        Me.crvTitPagoPorFornecedor.Width = Me.Width - 30
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim DS As New dsRptTitulos
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim DA As SqlClient.SqlDataAdapter
        Dim sSQL As String
        Dim tam, I As Integer

        Try

            If Me.CaminhoImp.Trim = "" Then
                MsgBox("Informar o caminho dos relatórios para a Fazenda," & Chr(13) & _
                       "impressão abortada.", MsgBoxStyle.Exclamation)
                Exit Try
            End If

            If Me.cboFornecedor.Text.Trim = "" Then
                If MsgBox("Não selecionou o Fornecedor, sairão todos ok ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Exit Try
                End If
            End If

            If Me.cboFornecedor.Text.Trim <> "" Then
                tam = Me.cboFornecedor.Text.Length
                sSQL = "select * from vwRptTitulosAbertoPorVencimento" & _
                       " where CodFornec='" & Me.cboFornecedor.Text.Substring(tam - 6, 6) & "'" & _
                       " and Pago=1" & _
                       " order by CodFornec"
                '" and DtPagto between '" & clsRotinas.DataParaSQLServer(Me.dtpDataInicio.Value) & "' and '" & clsRotinas.DataParaSQLServer(Me.dtpDataFinal.Value) & "'" & _

            Else
                sSQL = "select * from vwRptTitulosAbertoPorVencimento" & _
                       " where Pago=1" & _
                       " order by CodFornec"
                '" where DtPagto between '" & clsRotinas.DataParaSQLServer(Me.dtpDataInicio.Value) & "' and '" & clsRotinas.DataParaSQLServer(Me.dtpDataFinal.Value) & "'" & _
            End If

            DS.Clear()
            DA = New SqlClient.SqlDataAdapter(sSQL, cnn)
            DA.Fill(DS, "vwRptTitulosAbertoPorVencimento")

            'Filtrar a Data de Vencimento no DataSet
            For I = DS.vwRptTitulosAbertoPorVencimento.Count - 1 To 0 Step -1
                If CDate(DS.vwRptTitulosAbertoPorVencimento(I).DtPagto) >= Me.dtpDataInicio.Value.Date And CDate(DS.vwRptTitulosAbertoPorVencimento(I).DtPagto) <= Me.dtpDataFinal.Value.Date Then
                Else
                    DS.vwRptTitulosAbertoPorVencimento(I).Delete()
                End If
            Next

            Me.crDocumento = New CrystalDecisions.CrystalReports.Engine.ReportDocument()

            Me.crDocumento.Load(Me.CaminhoImp & "\rptTitulosPagosPorFornecedor.rpt")

            Dim pfs As New ParameterFields 'Coleção de Parâmetros
            Dim pf As New ParameterField 'Campo de Parâmetro
            Dim pdv As New ParameterDiscreteValue 'Valor do Parâmetro

            pf.Name = "empresa"
            pdv.Value = " "

            pf.CurrentValues.Add(pdv)
            pfs.Add(pf)

            pf = New ParameterField
            pdv = New ParameterDiscreteValue

            pf.Name = "datainicio"
            pdv.Value = Me.dtpDataInicio.Value.ToShortDateString
            pf.CurrentValues.Add(pdv)
            pfs.Add(pf)

            pf = New ParameterField
            pdv = New ParameterDiscreteValue

            pf.Name = "datafinal"
            pdv.Value = Me.dtpDataFinal.Value.ToShortDateString
            pf.CurrentValues.Add(pdv)
            pfs.Add(pf)

            Me.crvTitPagoPorFornecedor.ParameterFieldInfo = pfs
            Me.crDocumento.SetDataSource(DS)
            Me.crvTitPagoPorFornecedor.ReportSource = Me.crDocumento

        Catch ex As Exception
            MsgBox(ex.Source & Chr(13) & ex.Message)
        Finally
            cnn.Dispose()
            DS.Dispose()
            GC.Collect()
        End Try
    End Sub

End Class