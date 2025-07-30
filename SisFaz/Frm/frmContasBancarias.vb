Public Class frmContasBancarias
    Private Incluir As Boolean = False

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub frmContasBancarias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.grpConta.Enabled = False
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

    Private Sub cboBanco_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBanco.SelectedIndexChanged
        PreencherComboAgencias()
    End Sub

    Private Sub PreencherComboAgencias()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarAgenciasDoBanco", cnn)
        Dim dtr As SqlClient.SqlDataReader

        Try

            Me.cboAgencia.Items.Clear()
            Me.cboAgencia.Text = ""
            Me.lstvContas.Items.Clear()

            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@Banco", SqlDbType.SmallInt, 2, "Banco")
                .Parameters(0).Value = CInt(Me.cboBanco.Text.Substring(0, 3))

                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    Me.cboAgencia.Items.Add(dtr(1).ToString)
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

    Private Sub cboAgencia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAgencia.SelectedIndexChanged
        PreencherListaContasBancarias()
    End Sub

    Private Sub PreencherListaContasBancarias()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarContasDaAgencia", cnn)
        Dim dtr As SqlClient.SqlDataReader
        Dim lvi As ListViewItem

        Try
            Me.lstvContas.Items.Clear()

            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@Agencia", SqlDbType.VarChar, 10, "Agencia")
                .Parameters(0).Value = Me.cboAgencia.Text.Trim
                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    lvi = Me.lstvContas.Items.Add(dtr(0).ToString) 'Código da Conta
                    lvi.SubItems.Add(dtr(1).ToString) 'Nº da Conta
                    lvi.SubItems.Add(dtr(2).ToString) 'Nº do último cheque emitido                   

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
        If Me.cboBanco.Text.Trim = "" Then
            MsgBox("Selecione um Banco por favor", MsgBoxStyle.Exclamation)
            Me.cboBanco.Focus()
            Exit Sub
        End If
        If Me.cboAgencia.Text.Trim = "" Then
            MsgBox("Selecione uma agência", MsgBoxStyle.Exclamation)
            Me.cboAgencia.Focus()
            Exit Sub
        End If
        Me.grpConta.Enabled = True
        Me.Incluir = True
        Me.txtNumeroConta.Focus()
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        If Me.lstvContas.SelectedItems.Count = 0 Then
            MsgBox("Selecione a Conta que deseja alterar", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Me.grpConta.Enabled = True
        Me.txtNumeroConta.Focus()
    End Sub

    Private Sub lstvContas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstvContas.SelectedIndexChanged
        If Me.lstvContas.SelectedItems.Count > 0 Then
            Me.Incluir = False
            Me.txtNumeroConta.Text = Me.lstvContas.SelectedItems(0).SubItems(1).Text.Trim
            Me.txtUltimoCheque.Text = Me.lstvContas.SelectedItems(0).SubItems(2).Text.Trim
        End If
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        If Me.txtNumeroConta.Text.Trim = "" Then
            MsgBox("Informe o nº da Conta", MsgBoxStyle.Exclamation)
            Me.txtNumeroConta.Focus()
            Exit Sub
        End If
        If MsgBox("Confirma salvar conta agora ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SalvarConta()
            Me.txtNumeroConta.Text = ""
            Me.txtUltimoCheque.Text = ""
            Me.grpConta.Enabled = False
            Me.Incluir = False
            PreencherListaContasBancarias()
        End If
    End Sub

    Private Sub SalvarConta()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Connection = cnn

                If Me.Incluir Then
                    .CommandText = "spIncluirContaBancaria"
                Else
                    .CommandText = "spAlterarContaBancaria"
                End If

                .Parameters.Add("@NumeroConta", SqlDbType.VarChar, 10, "NumeroConta")
                .Parameters(0).Value = Me.txtNumeroConta.Text.Trim
                .Parameters.Add("@UltimoCheque", SqlDbType.Int, 4, "UltimoCheque")
                If Me.txtUltimoCheque.Text.Trim = "" Then
                    .Parameters(1).Value = 0
                Else
                    .Parameters(1).Value = CLng(Me.txtUltimoCheque.Text)
                End If
                .Parameters.Add("@Agencia", SqlDbType.VarChar, 10, "Agencia")
                .Parameters(2).Value = Me.cboAgencia.Text.Trim

                If Not Me.Incluir Then
                    .Parameters.Add("@CodigoConta", SqlDbType.Int, 4, "CodigoConta")
                    .Parameters(3).Value = CLng(Me.lstvContas.SelectedItems(0).Text)
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

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        If Me.lstvContas.SelectedItems.Count = 0 Then
            MsgBox("Selecione a Conta que deseja excluir", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If MsgBox("Confirma a exclusão da conta nº " & Me.lstvContas.SelectedItems(0).SubItems(1).Text.Trim, MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ExcluirConta()
            Me.txtNumeroConta.Text = ""
            Me.txtUltimoCheque.Text = ""
            Me.PreencherListaContasBancarias()
        End If
    End Sub

    Private Sub ExcluirConta()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spExcluirContaBancaria", cnn)

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@CodigoConta", SqlDbType.Int, 4, "CodigoConta")
                .Parameters(0).Value = CLng(Me.lstvContas.SelectedItems(0).Text)
                .Parameters.Add("@ret", SqlDbType.Bit, 1, "ret")
                .Parameters(1).Direction = ParameterDirection.Output

                cnn.Open()
                .ExecuteNonQuery()
                cnn.Close()

                If CByte(.Parameters(1).Value) = 0 Then
                    MsgBox("Existem movimentações no caixa vinculadas à Conta" & Chr(13) & "exclusão abortada", MsgBoxStyle.Information)
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