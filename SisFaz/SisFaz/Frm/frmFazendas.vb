Public Class frmFazendas

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        If Me.lstvFazendas.SelectedItems.Count = 0 Then
            MsgBox("Selecione a fazenda que deseja alterar", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim frm As New frmIncluirEditarFazendas(CInt(Me.lstvFazendas.SelectedItems(0).Text), False)
        frm.ShowDialog()
        Me.PreencherListaFazendas()
    End Sub

    Private Sub frmFazendas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PreencherListaFazendas()
    End Sub

    Private Sub PreencherListaFazendas()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarListaFazendas", cnn)
        Dim dtr As SqlClient.SqlDataReader
        Dim lvi As ListViewItem

        Try
            Me.lstvFazendas.Items.Clear()
            With cmd
                .CommandType = CommandType.StoredProcedure
                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    lvi = Me.lstvFazendas.Items.Add(dtr(0).ToString) 'Código Fazenda
                    lvi.SubItems.Add(dtr(1).ToString) 'Nome Fazenda
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

    Private Sub btnIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncluir.Click
        Dim frm As New frmIncluirEditarFazendas(0, True)
        frm.ShowDialog()
        Me.PreencherListaFazendas()
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        If Me.lstvFazendas.SelectedItems.Count = 0 Then
            MsgBox("Selecione a fazenda que deseja excluir", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If MsgBox("Confirma a exclusão da fazenda: " & Me.lstvFazendas.SelectedItems(0).SubItems(1).Text.Trim, MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ExcluirFazenda()
            Me.PreencherListaFazendas()
        End If
    End Sub

    Private Sub ExcluirFazenda()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spExcluirFazenda", cnn)

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@CodigoFazenda", SqlDbType.SmallInt, 2, "CodigoFazenda")
                .Parameters(0).Value = CInt(Me.lstvFazendas.SelectedItems(0).Text)
                .Parameters.Add("@ret", SqlDbType.Bit, 1, "ret")
                .Parameters(1).Direction = ParameterDirection.Output
                cnn.Open()
                .ExecuteNonQuery()
                cnn.Close()

                If CByte(.Parameters(1).Value) = 0 Then
                    MsgBox("Existe título vinculado a esta fazenda, exclusão abortada!", MsgBoxStyle.Information)
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

End Class