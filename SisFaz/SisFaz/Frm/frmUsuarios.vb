Public Class frmUsuarios
    Private Incluir As Boolean = False

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub


    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PreencherListaUsuarios()
        Me.grpUsuario.Enabled = False
    End Sub

    Private Sub PreencherListaUsuarios()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarListaUsuarios", cnn)
        Dim dtr As SqlClient.SqlDataReader
        Dim lvi As ListViewItem

        Try
            Me.lstvUsuarios.Items.Clear()
            With cmd
                .CommandType = CommandType.StoredProcedure
                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    lvi = Me.lstvUsuarios.Items.Add(dtr(0).ToString) 'Código
                    lvi.SubItems.Add(dtr(1).ToString) 'Nome do Usuário
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

    Private Sub LimparEdicao()
        Me.txtCodigo.Text = ""
        Me.txtSenha.Text = ""
        Me.txtUsuario.Text = ""
    End Sub

    Private Sub btnIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncluir.Click
        Me.Incluir = True
        LimparEdicao()
        Me.grpUsuario.Enabled = True
        Me.txtSenha.Focus()
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        If Me.lstvUsuarios.SelectedItems.Count = 0 Then
            MsgBox("Selecione primeiro o usuário que deseja alterar", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            Me.grpUsuario.Enabled = True
            EditarUsuario()
        End If
    End Sub

    Private Sub EditarUsuario()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarDadosUsuario", cnn)
        Dim dtr As SqlClient.SqlDataReader

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@CodigoUsuario", SqlDbType.SmallInt, 2, "CodigoUsuario")
                .Parameters(0).Value = CInt(Me.lstvUsuarios.SelectedItems(0).Text)
                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    Me.txtSenha.Text = dtr(0).ToString
                    Me.txtUsuario.Text = dtr(1).ToString
                    Me.txtCodigo.Text = dtr(2).ToString
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

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Incluir = False
        LimparEdicao()
        Me.grpUsuario.Enabled = False
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        If Me.lstvUsuarios.SelectedItems.Count = 0 Then
            MsgBox("Selecione primeiro o usuário que deseja excluir", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If MsgBox("Confirma excluir o usuário: " & Me.lstvUsuarios.SelectedItems(0).SubItems(1).Text.Trim, MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ExcluirUsuario()
            LimparEdicao()
            Me.grpUsuario.Enabled = False
            PreencherListaUsuarios()
        End If
    End Sub

    Private Sub ExcluirUsuario()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spExcluirUsuario", cnn)

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@CodigoUsuario", SqlDbType.SmallInt, 2, "CodigoUsuario")
                .Parameters(0).Value = CInt(Me.lstvUsuarios.SelectedItems(0).Text)
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

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        If Me.txtSenha.Text.Trim = "" Then
            MsgBox("É necessário uma senha para o usuário", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If Me.txtUsuario.Text.Trim = "" Then
            MsgBox("É necessário um nome o usuário", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If MsgBox("Confirma salvar agora ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SalvarUsuario()
            LimparEdicao()
            Me.grpUsuario.Enabled = False
            PreencherListaUsuarios()
        End If
    End Sub

    Private Sub SalvarUsuario()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand

        Try
            With cmd

                .CommandType = CommandType.StoredProcedure
                .Connection = cnn

                If Incluir Then
                    .CommandText = "spIncluirUsuario"
                Else
                    .CommandText = "spAlterarUsuario"
                End If

                .Parameters.Add("@Senha", SqlDbType.VarChar, 10, "Senha")
                .Parameters(0).Value = Me.txtSenha.Text.Trim
                .Parameters.Add("@Usuario", SqlDbType.VarChar, 20, "Usuario")
                .Parameters(1).Value = Me.txtUsuario.Text.Trim

                If Not Incluir Then
                    .Parameters.Add("@CodigoUsuario", SqlDbType.SmallInt, 2, "CodigoUsuario")
                    .Parameters(2).Value = CInt(Me.lstvUsuarios.SelectedItems(0).Text)
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

    Private Sub lstvUsuarios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstvUsuarios.SelectedIndexChanged
        If Me.lstvUsuarios.SelectedItems.Count > 0 Then
            Me.Incluir = False
        End If
    End Sub

End Class