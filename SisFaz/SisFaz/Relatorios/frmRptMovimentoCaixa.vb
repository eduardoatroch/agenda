Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmRptMovimentoCaixa
    Private crDocumento As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Private CaminhoImp, NomeFilial, FoneFilial As String

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub frmRptMovimentoCaixa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ObterCaminhoRpt()
        Me.PreencherListaPortador()
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

    Private Sub PreencherListaPortador()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarPortador", cnn)
        Dim DTR As SqlClient.SqlDataReader
        Dim LVI As ListViewItem

        Try
            Me.lstvPortador.Items.Clear()
            With cmd
                .CommandType = CommandType.StoredProcedure
                cnn.Open()
                DTR = .ExecuteReader
                Do Until DTR.Read = False
                    LVI = Me.lstvPortador.Items.Add(DTR(0) & " - " & DTR(1))
                    LVI.SubItems.Add(DTR(2).ToString)
                    LVI.SubItems.Add(DTR(3).ToString)
                Loop
                DTR.Close()
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

    Private Sub lstvPortador_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstvPortador.SelectedIndexChanged
        If Me.lstvPortador.SelectedItems.Count > 0 Then
            Me.lstvPortador.SelectedItems(0).BackColor = Color.Blue
            Me.lstvPortador.SelectedItems(0).ForeColor = Color.White
        Else
            Dim i As Integer
            For i = 0 To Me.lstvPortador.Items.Count - 1
                If Me.lstvPortador.Items(i).Selected Then
                    Me.lstvPortador.Items(i).BackColor = Color.Blue
                    Me.lstvPortador.Items(i).ForeColor = Color.White
                Else
                    Me.lstvPortador.Items(i).BackColor = Color.White
                    Me.lstvPortador.Items(i).ForeColor = Color.Black
                End If
            Next
        End If
    End Sub

    Private Sub frmRptMovimentoCaixa_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.CRV.Height = Me.Height - 160
        Me.CRV.Width = Me.Width - 40
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim DS As New dsMovimentoCaixa
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand
        Dim DA As SqlClient.SqlDataAdapter
        Dim sSQL, sBanco As String
        Dim I As Integer

        Try

            If Me.CaminhoImp.Trim = "" Then
                MsgBox("Informar o caminho dos relatórios para a Fazenda," & Chr(13) & _
                       "impressão abortada.", MsgBoxStyle.Exclamation)
                Exit Try
            End If

            Me.LBLmensagem.Left = Me.Left + 90
            Me.LBLmensagem.Top = Me.Top + 160
            Me.LBLmensagem.Text = "Obtendo lançamentos com os parâmetros informados..."
            Me.LBLmensagem.Visible = True
            Application.DoEvents()

            If Me.lstvPortador.SelectedItems.Count > 0 Then
                sBanco = Me.lstvPortador.SelectedItems(0).Text.Substring(0, 3)
                sSQL = "select * from vwMovimentoCaixa where CodBanco='" & sBanco & "' order by Fazenda,CodBanco,Agenc,Conta,TpMov"
                '" and DataBaixa between '" & clsRotinas.DataParaSQLServer(Me.dtpDataIni.Value) & "' and '" & clsRotinas.DataParaSQLServer(Me.dtpDataFim.Value) & "'" & _
            Else
                sSQL = "select * from vwMovimentoCaixa order by Fazenda,CodBanco,Agenc,Conta,TpMov"
                '" where DataBaixa between '" & clsRotinas.DataParaSQLServer(Me.dtpDataIni.Value) & "' and '" & clsRotinas.DataParaSQLServer(Me.dtpDataFim.Value) & "'" & _
            End If

            With cmd
                .CommandType = CommandType.Text
                .Connection = cnn
                .CommandText = sSQL
            End With

            DS.Clear()
            DA = New SqlClient.SqlDataAdapter(cmd)
            DA.Fill(DS, "vwMovimentoCaixa")

            'Filtrar a Data de baixa no DataSet
            For I = DS.vwMovimentoCaixa.Count - 1 To 0 Step -1
                If CDate(DS.vwMovimentoCaixa(I).DataBaixa) >= Me.dtpDataIni.Value.Date And CDate(DS.vwMovimentoCaixa(I).DataBaixa) <= Me.dtpDataFim.Value.Date Then
                Else
                    DS.vwMovimentoCaixa(I).Delete()
                End If
            Next

            Me.LBLmensagem.Visible = False

            Me.crDocumento = New CrystalDecisions.CrystalReports.Engine.ReportDocument()

            Me.crDocumento.Load(Me.CaminhoImp & "\rptMovimentoCaixa.rpt")

            Dim pfs As New ParameterFields 'Coleção de Parâmetros
            Dim pf As New ParameterField 'Campo de Parâmetro
            Dim pdv As New ParameterDiscreteValue 'Valor do Parâmetro

            pf.Name = "datainicial"
            pdv.Value = Me.dtpDataIni.Value.Date.ToShortDateString
            pf.CurrentValues.Add(pdv)
            pfs.Add(pf)

            pf = New ParameterField
            pdv = New ParameterDiscreteValue

            pf.Name = "datafinal"
            pdv.Value = Me.dtpDataFim.Value.ToShortDateString
            pf.CurrentValues.Add(pdv)
            pfs.Add(pf)

            Me.CRV.ParameterFieldInfo = pfs
            Me.crDocumento.SetDataSource(DS)
            Me.CRV.ReportSource = Me.crDocumento

        Catch ex As Exception
            MsgBox(ex.Source & Chr(13) & ex.Message)
        Finally
            cnn.Dispose()
            DS.Dispose()
            GC.Collect()
        End Try
    End Sub
End Class