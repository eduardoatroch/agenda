Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmRptFornecedores
    Private crDocumento As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Private CaminhoImp, NomeFilial, FoneFilial As String

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub frmRptFornecedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim DS As New dsFornecedores
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim DA As SqlClient.SqlDataAdapter
        Dim sSQL As String

        Try

            If Me.CaminhoImp.Trim = "" Then
                MsgBox("Informar o caminho dos relatórios para a Fazenda," & Chr(13) & _
                       "impressão abortada.", MsgBoxStyle.Exclamation)
                Exit Try
            End If

            If Me.chkAtivos.Checked Then
                sSQL = "select * from vwFornecdores where ativo=1 order by NomeFornecedor"
            Else
                sSQL = "select * from vwFornecdores order by NomeFornecedor"
            End If

            DA = New SqlClient.SqlDataAdapter(sSQL, cnn)
            DA.Fill(DS, "vwFornecdores")

            Me.crDocumento = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            Me.crDocumento.Load(Me.CaminhoImp & "rptFornecedores.rpt")

            Dim pfs As New ParameterFields 'Coleção de Parâmetros
            Dim pf As New ParameterField 'Campo de Parâmetro
            Dim pdv As New ParameterDiscreteValue 'Valor do Parâmetro

            pf.Name = "empresa"
            pdv.Value = Me.NomeFilial
            pf.CurrentValues.Add(pdv)
            pfs.Add(pf)

            'pf = New ParameterField
            'pdv = New ParameterDiscreteValue

            'pf.Name = "datainicio"
            'pdv.Value = Me.dtpDataInicial.Value.ToShortDateString
            'pf.CurrentValues.Add(pdv)
            'pfs.Add(pf)


            Me.crvFornecedores.ParameterFieldInfo = pfs
            Me.crDocumento.SetDataSource(DS)
            Me.crvFornecedores.ReportSource = Me.crDocumento

        Catch ex As Exception
            MsgBox(ex.Source & Chr(13) & ex.Message)
        Finally
            cnn.Dispose()
            DS.Dispose()
            GC.Collect()
        End Try
    End Sub

    Private Sub frmRptFornecedores_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.crvFornecedores.Height = Me.Height - 100
        Me.crvFornecedores.Width = Me.Width - 30
    End Sub

End Class