Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmRptImprimirBoletos
    Private NovoDocumento As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Private CaminhoImp, NomeFilial, FoneFilial As String

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub frmRptImprimirBoletos_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.crvBoletos.Height = Me.Height - 150
        Me.crvBoletos.Width = Me.Width - 40
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If Me.cboCLiente.Text.Trim = "" Then
            MsgBox("Selecione o cliente que deseja imprimir os boletos não pagos", MsgBoxStyle.Critical)
            Me.cboCLiente.Focus()
            Exit Sub
        End If
        Imprimir()
    End Sub

    Private Sub Imprimir()
        Dim DS As New dsImprimirBoletos
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRptImprimirBoletos", cnn)
        Dim DA As SqlClient.SqlDataAdapter
        Dim Tam As Integer

        Try

            Tam = Me.cboCLiente.Text.Length

            If Me.CaminhoImp.Trim = "" Then
                MsgBox("Informar o caminho dos relatórios para a Fazenda," & Chr(13) & _
                       "impressão abortada.", MsgBoxStyle.Exclamation)
                Exit Try
            End If

            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@DataIni", SqlDbType.DateTime, 8, "DataIni")
                .Parameters(0).Value = Me.dtpDataIni.Value.Date
                .Parameters.Add("@DataFim", SqlDbType.DateTime, 8, "DataFim")
                .Parameters(1).Value = Me.dtpDataFim.Value.Date
                .Parameters.Add("@CodigoCli", SqlDbType.Int, 4, "CodigoCli")
                .Parameters(2).Value = CLng(Me.cboCLiente.Text.Substring(Tam - 6, 6))
            End With

            DA = New SqlClient.SqlDataAdapter(cmd)
            DS.EnforceConstraints = False
            DA.Fill(DS, "spRptImprimirBoletos")

            Me.NovoDocumento = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            'Me.NovoDocumento.Load(Me.CaminhoImp & "rptBoletos.rpt")
            'Me.NovoDocumento.Load("C:\SisFaz\SisFaz\Rpt\rptBoletos.rpt")
            Me.NovoDocumento.Load("C:\SisFaz\SisFaz\Rpt\rptBoletoTaxaItau.rpt")

            'Dim pfs As New ParameterFields 'Coleção de Parâmetros
            'Dim pf As New ParameterField 'Campo de Parâmetro
            'Dim pdv As New ParameterDiscreteValue 'Valor do Parâmetro

            'pf.Name = "empresa"
            'pdv.Value = Me.NomeFilial
            'pf.CurrentValues.Add(pdv)
            'pfs.Add(pf)

            'pf = New ParameterField
            'pdv = New ParameterDiscreteValue

            'pf.Name = "cabecalho"
            'pdv.Value = "IMÓVEIS/CONTRATOS INATIVOS"
            'pf.CurrentValues.Add(pdv)
            'pfs.Add(pf)

            'Me.crvBoletos.ParameterFieldInfo = pfs

            Me.NovoDocumento.SetDataSource(DS)
            Me.crvBoletos.ReportSource = Me.NovoDocumento

        Catch ex As Exception
            MsgBox(ex.Source & Chr(13) & ex.Message)
        Finally
            cnn.Dispose()
            DS.Dispose()
            GC.Collect()
        End Try
    End Sub

    Private Sub frmRptImprimirBoletos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PreencherComboCliente()
        ObterCaminhoRpt()
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

End Class