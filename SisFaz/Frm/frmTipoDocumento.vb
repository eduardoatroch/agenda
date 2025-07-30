Public Class frmTipoDocumento
    Private Incluir As Boolean = False

    Private Sub frmTipoDocumento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PreencherListaTipoDocumento()
        Me.grpTipo.Enabled = False
    End Sub

    Private Sub PreencherListaTipoDocumento()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarListaTipoDocumento", cnn)
        Dim dtr As SqlClient.SqlDataReader
        Dim lvi As ListViewItem

        Try
            Me.lstvTipos.Items.Clear()

            With cmd
                .CommandType = CommandType.StoredProcedure
                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    lvi = Me.lstvTipos.Items.Add(dtr(0).ToString) 'Código do Tipo de Documento
                    lvi.SubItems.Add(dtr(1).ToString) 'Descrição do Tipo
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

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub lstvTipos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstvTipos.SelectedIndexChanged
        If Me.lstvTipos.SelectedItems.Count > 0 Then
            Me.Incluir = False
            EditarTipo()
        End If
    End Sub

    Private Sub EditarTipo()
        Me.grpTipo.Enabled = True
        Me.txtCodigoTipo.Text = Me.lstvTipos.SelectedItems(0).Text
        Me.txtTipo.Text = Me.lstvTipos.SelectedItems(0).SubItems(1).Text
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        If Me.lstvTipos.SelectedItems.Count = 0 Then
            MsgBox("Selecione o Tipo de Documento que deseja alterar", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Me.txtCodigoTipo.Enabled = False
        Me.txtTipo.Focus()
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        If Me.lstvTipos.SelectedItems.Count = 0 Then
            MsgBox("Selecione o Tipo de Documento que deseja excluir", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If MsgBox("Confirma a exclusão do Tipo: " & Me.lstvTipos.SelectedItems(0).Text.Trim & " - " & _
                                                    Me.lstvTipos.SelectedItems(0).SubItems(1).Text.Trim, MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ExcluirTipoDocumento()
            Me.Incluir = False
            Me.PreencherListaTipoDocumento()
        End If
    End Sub

    Private Sub ExcluirTipoDocumento()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spExcluirTipoDocumento", cnn)

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@CodigoTipo", SqlDbType.VarChar, 2, "CodigoTipo")
                .Parameters(0).Value = Me.lstvTipos.SelectedItems(0).Text.Trim
                .Parameters.Add("@ret", SqlDbType.Bit, 1, "ret")
                .Parameters(1).Direction = ParameterDirection.Output

                cnn.Open()
                .ExecuteNonQuery()
                cnn.Close()

                If CByte(.Parameters(1).Value) = 0 Then
                    MsgBox("Exclusão negada, há títulos vinculados a este Tipo de Documento", MsgBoxStyle.Exclamation)
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

    Private Sub btnIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncluir.Click
        Me.Incluir = True
        Me.grpTipo.Enabled = True
        Me.txtCodigoTipo.Focus()
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        If Me.txtCodigoTipo.Text.Trim = "" Then
            MsgBox("Informe o Código do Tipo de Documento", MsgBoxStyle.Exclamation)
            Me.txtCodigoTipo.Focus()
            Exit Sub
        End If
        If Me.txtTipo.Text.Trim = "" Then
            MsgBox("Informe a Descrição do Tipo de Documento", MsgBoxStyle.Exclamation)
            Me.txtTipo.Focus()
            Exit Sub
        End If
        If MsgBox("Confirma salvar agora?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SalvarTipoDocumento()
            Me.txtCodigoTipo.Text = ""
            Me.txtTipo.Text = ""
            Me.txtCodigoTipo.Enabled = True
            Me.grpTipo.Enabled = False
            Me.Incluir = False
            Me.PreencherListaTipoDocumento()
        End If
    End Sub

    Private Sub SalvarTipoDocumento()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Connection = cnn

                If Me.Incluir Then
                    .CommandText = "spIncluirTipoDocumento"
                Else
                    .CommandText = "spAlterarTipoDocumento"
                End If

                .Parameters.Add("@CodigoTipo", SqlDbType.VarChar, 2, "CodigoTipo")
                .Parameters(0).Value = Me.txtCodigoTipo.Text.Trim
                .Parameters.Add("@Tipo", SqlDbType.VarChar, 30, "Tipo")
                .Parameters(1).Value = Me.txtTipo.Text.Trim

                If Me.Incluir Then
                    .Parameters.Add("@ret", SqlDbType.Bit, 1, "ret")
                    .Parameters(2).Direction = ParameterDirection.Output
                End If

                cnn.Open()
                .ExecuteNonQuery()
                cnn.Close()

                If Me.Incluir Then
                    If CByte(.Parameters(2).Value) = 0 Then
                        MsgBox("Já existe um Tipo de Documento com o código informado, escolha outro", MsgBoxStyle.Exclamation)
                    End If
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