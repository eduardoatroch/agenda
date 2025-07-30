Public Class frmRelatorioContatos
    Private CaminhoRelatorio As String

    Private Sub frmRelatorioContatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblMensagem.Visible = False
        CaminhoRelatorio = clsRotinas.ObterCaminhoRelatorio
    End Sub

    Private Sub frmRelatorioContatos_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.crvRelatorio.Height = Me.Height - 110
        Me.crvRelatorio.Width = Me.Width - 45
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If MessageBox.Show("Confirma impressão?", "Aviso", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Imprimir()
        End If
    End Sub

    Private Sub Imprimir()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand
        Dim ds As New dsContatos
        Dim da As SqlClient.SqlDataAdapter
        Dim novoDocumento As New CrystalDecisions.CrystalReports.Engine.ReportDocument

        Try
            With cmd
                .CommandType = CommandType.Text
                .CommandTimeout = 7200
                .Connection = cnn
                .CommandText = "select * from vwRetornarListaContatos order by NomeContato"
            End With

            ds.EnforceConstraints = False
            da = New SqlClient.SqlDataAdapter(cmd)
            da.Fill(ds, "vwRetornarListaContatos")

            If ds.vwRetornarListaContatos.Count = 0 Then
                MessageBox.Show("Contatos vazios", "Aviso", MessageBoxButtons.OK)
                Exit Sub
            End If
            If CaminhoRelatorio.Trim = "vazio" Then
                novoDocumento.Load(Application.StartupPath & "\rpt\rptContatos.rpt")
            Else
                novoDocumento.Load(CaminhoRelatorio & "rptContatos.rpt")
            End If
            novoDocumento.SetDataSource(ds)
            crvRelatorio.ReportSource = novoDocumento

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class