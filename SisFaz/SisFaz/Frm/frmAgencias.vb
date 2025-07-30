Public Class frmAgencias
    Private Incluir As Boolean = False

    Private Sub frmAgencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.grpAgencia.Enabled = False
        PreencherComboBanco()
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

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncluir.Click
        Me.Incluir = True
        Me.grpAgencia.Enabled = True
        Me.txtNumeroAgencia.Focus()
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        If Me.cboBanco.Text.Trim = "" Then
            MsgBox("Selecione um Banco por favor", MsgBoxStyle.Exclamation)
            Me.cboBanco.Focus()
            Exit Sub
        End If
        If Me.txtNumeroAgencia.Text.Trim = "" Then
            MsgBox("Informe o nº da agência", MsgBoxStyle.Exclamation)
            Me.txtNumeroAgencia.Focus()
        End If
        If MsgBox("Confirma salvar agora ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SalvarAgencia()
            Me.txtNumeroAgencia.Text = ""
            Me.grpAgencia.Enabled = False
            Me.Incluir = False
            Me.PreencherListaAgencias()
        End If
    End Sub

    Private Sub SalvarAgencia()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Connection = cnn

                If Me.Incluir Then
                    .CommandText = "spIncluirAgencia"
                Else
                    .CommandText = "spAlterarAgencia"
                End If

                .Parameters.Add("@NumeroAgencia", SqlDbType.VarChar, 10, "NumeroAgencia")
                .Parameters(0).Value = Me.txtNumeroAgencia.Text.Trim
                .Parameters.Add("@Banco", SqlDbType.SmallInt, 2, "Banco")
                .Parameters(1).Value = CInt(Me.cboBanco.Text.Substring(0, 3))

                If Not Incluir Then
                    .Parameters.Add("@CodigoAgencia", SqlDbType.SmallInt, 2, "CodigoAgencia")
                    .Parameters(2).Value = CInt(Me.lstvAgencias.SelectedItems(0).Text)
                End If

                cnn.Open()
                .ExecuteNonQuery()
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
        PreencherListaAgencias()
    End Sub

    Private Sub PreencherListaAgencias()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarAgenciasDoBanco", cnn)
        Dim dtr As SqlClient.SqlDataReader
        Dim lvi As ListViewItem

        Try
            Me.lstvAgencias.Items.Clear()

            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@Banco", SqlDbType.SmallInt, 2, "Banco")
                .Parameters(0).Value = CInt(Me.cboBanco.Text.Substring(0, 3))

                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    lvi = Me.lstvAgencias.Items.Add(dtr(0).ToString) 'Código
                    lvi.SubItems.Add(dtr(1).ToString) 'Nº da Agência
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

    Private Sub lstvAgencias_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstvAgencias.SelectedIndexChanged
        Me.Incluir = False
        If Me.lstvAgencias.SelectedItems.Count > 0 Then
            Me.txtNumeroAgencia.Text = Me.lstvAgencias.SelectedItems(0).SubItems(1).Text
        End If
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Me.grpAgencia.Enabled = True
        Me.txtNumeroAgencia.Focus()
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        If Me.lstvAgencias.SelectedItems.Count = 0 Then
            MsgBox("Selecione a agência que deseja excluir", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If MsgBox("Confirma a exclusão da agência nº " & Me.lstvAgencias.SelectedItems(0).SubItems(1).Text.Trim, MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ExcluirAgencia()
            Me.txtNumeroAgencia.Text = ""
            Me.PreencherListaAgencias()
        End If
    End Sub

    Private Sub ExcluirAgencia()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spExcluirAgencia", cnn)

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@CodigoAgencia", SqlDbType.SmallInt, 2, "CodigoAgencia")
                .Parameters(0).Value = CInt(Me.lstvAgencias.SelectedItems(0).Text)
                .Parameters.Add("@Agencia", SqlDbType.VarChar, 10, "Agencia")
                .Parameters(1).Value = Me.lstvAgencias.SelectedItems(0).SubItems(1).Text.Trim
                .Parameters.Add("@ret", SqlDbType.Bit, 1, "ret")
                .Parameters(2).Direction = ParameterDirection.Output
                cnn.Open()
                .ExecuteNonQuery()
                cnn.Close()

                If CByte(.Parameters(2).Value) = 0 Then
                    MsgBox("Existe Conta Bancária vinculada à agência, exclusão abortada", MsgBoxStyle.Information)
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