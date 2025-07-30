Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmRptTitulosPagarVencimento
    Private crDocumento As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Private CaminhoImp, NomeFilial, FoneFilial As String

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub frmRptTitulosPagarVencimento_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.crvTitAbertoVenc.Height = Me.Height - 100
        Me.crvTitAbertoVenc.Width = Me.Width - 30
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim DS As New dsRptTitulos
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim DA As SqlClient.SqlDataAdapter
        Dim sSQL As String
        Dim tam As Integer

        Try

            If Me.CaminhoImp.Trim = "" Then
                MsgBox("Informar o caminho dos relatórios para a Fazenda," & Chr(13) & _
                       "impressão abortada.", MsgBoxStyle.Exclamation)
                Exit Try
            End If

            If Me.cboFazenda.Text.Trim = "" Then
                If MsgBox("Não selecionou a fazenda, sairão todas ok ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Exit Try
                End If
            End If

            If Me.cboFazenda.Text.Trim <> "" Then
                sSQL = "select * from vwRptTitulosAbertoPorVencimento" & _
                       " where CodigoFazenda='" & Me.cboFazenda.Text.Substring(0, 2) & "'" & _
                       " and Venc between '" & clsRotinas.DataParaSQLServer(Me.dtpDataInicial.Value) & "' and '" & clsRotinas.DataParaSQLServer(Me.dtpDataFinal.Value) & "'" & _
                       " and Pago=0" & _
                       " order by CodigoFazenda, Venc"

            Else
                sSQL = "select * from vwRptTitulosAbertoPorVencimento" & _
                       " where Venc between '" & clsRotinas.DataParaSQLServer(Me.dtpDataInicial.Value) & "' and '" & clsRotinas.DataParaSQLServer(Me.dtpDataFinal.Value) & "'" & _
                       " and Pago=0" & _
                       " order by CodigoFazenda, Venc"
            End If

            DS.Clear()
            DA = New SqlClient.SqlDataAdapter(sSQL, cnn)
            DA.Fill(DS, "vwRptTitulosAbertoPorVencimento")

            'Filtrar a Data de Vencimento no DataSet
            'For I = DS.vwRptTitulosAbertoPorVencimento.Count - 1 To 0 Step -1
            '    If CDate(DS.vwRptTitulosAbertoPorVencimento(I).Venc) >= Me.dtpDataInicial.Value.Date And CDate(DS.vwRptTitulosAbertoPorVencimento(I).Venc) <= Me.dtpDataFinal.Value.Date Then
            '    Else
            '        DS.vwRptTitulosAbertoPorVencimento(I).Delete()
            '    End If
            'Next

            Me.crDocumento = New CrystalDecisions.CrystalReports.Engine.ReportDocument()

            Me.crDocumento.Load(Me.CaminhoImp & "\rptTitulosAbertoVencimento.rpt")

            Dim pfs As New ParameterFields 'Coleção de Parâmetros
            Dim pf As New ParameterField 'Campo de Parâmetro
            Dim pdv As New ParameterDiscreteValue 'Valor do Parâmetro

            tam = Me.cboFazenda.Text.Length

            pf.Name = "empresa"
            If Me.cboFazenda.Text.Trim <> "" Then
                pdv.Value = Me.cboFazenda.Text.Substring(5, tam - 5)
            Else
                pdv.Value = "GERAL"
            End If

            pf.CurrentValues.Add(pdv)
            pfs.Add(pf)

            pf = New ParameterField
            pdv = New ParameterDiscreteValue

            pf.Name = "datainicio"
            pdv.Value = Me.dtpDataInicial.Value.ToShortDateString
            pf.CurrentValues.Add(pdv)
            pfs.Add(pf)

            pf = New ParameterField
            pdv = New ParameterDiscreteValue

            pf.Name = "datafinal"
            pdv.Value = Me.dtpDataFinal.Value.ToShortDateString
            pf.CurrentValues.Add(pdv)
            pfs.Add(pf)

            Me.crvTitAbertoVenc.ParameterFieldInfo = pfs
            Me.crDocumento.SetDataSource(DS)
            Me.crvTitAbertoVenc.ReportSource = Me.crDocumento

        Catch ex As Exception
            MsgBox(ex.Source & Chr(13) & ex.Message)
        Finally
            cnn.Dispose()
            DS.Dispose()
            GC.Collect()
        End Try
    End Sub

    Private Sub frmRptTitulosPagarVencimento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PreencherComboFazenda()
        Me.ObterCaminhoRpt()
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

End Class