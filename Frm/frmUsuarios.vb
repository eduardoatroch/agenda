Public Class frmUsuarios
    Private IDUsuario As Long = 0

    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.grpEdicaoUsuario.Visible = False
        Me.PrencherListaUsuarios()
    End Sub

    Private Sub PrencherListaUsuarios()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand
        Dim dtr As SqlClient.SqlDataReader
        Dim lvi As ListViewItem

        Try
            Me.lstvUsuarios.Items.Clear()
            With cmd
                .CommandType = CommandType.Text
                .CommandTimeout = 9600
                .Connection = cnn
                .CommandText = "select * from Usuario order by Nome"
                cnn.Open()
                dtr = .ExecuteReader
                While dtr.Read
                    lvi = Me.lstvUsuarios.Items.Add(dtr(0).ToString)
                    lvi.SubItems.Add(dtr(1).ToString)
                    lvi.SubItems.Add(dtr(3).ToString)
                    lvi.SubItems.Add(dtr(2).ToString)
                End While
                dtr.Close()
                cnn.Close()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click

        Me.txtNome.Text = String.Empty
        Me.txtSenha.Text = String.Empty
        Me.chkAtivo.Checked = True
        Me.txtEmail.Text = String.Empty
        Me.cboTipoUsuario.Text = "Selecione"
        Me.txtLogin.Text = String.Empty

        Me.grpEdicaoUsuario.Left = 10
        Me.grpEdicaoUsuario.Top = 81
        Me.grpEdicaoUsuario.BringToFront()
        Me.grpEdicaoUsuario.Visible = True
        Me.txtNome.Focus()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.grpEdicaoUsuario.Visible = False
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If Me.txtNome.Text.Trim = "" Then
            MsgBox("Informe o Nome", MsgBoxStyle.Critical)
            Me.txtNome.Focus()
            Exit Sub
        End If
        If Me.txtSenha.Text.Trim = "" Then
            MsgBox("Informe a Senha", MsgBoxStyle.Critical)
            Me.txtSenha.Focus()
            Exit Sub
        End If
        If Me.cboTipoUsuario.Text.Trim = "Selecione" Or Me.cboTipoUsuario.Text.Trim = "" Then
            MsgBox("Selecione o Tipo de Usuário", MsgBoxStyle.Critical)
            Me.cboTipoUsuario.Focus()
            Exit Sub
        End If
        Me.SalvarUsuario()
        Me.PrencherListaUsuarios()
        Me.grpEdicaoUsuario.Visible = False
    End Sub

    Private Sub SalvarUsuario()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand
        Dim vSenhaCriptografada As String = ""
        Dim vFlagAtivo As String = ""

        Try
            vSenhaCriptografada = Criptografia.CriptografarSenha(Me.txtSenha.Text.Trim, True)
            If Me.chkAtivo.Checked Then
                vFlagAtivo = "S"
            Else
                vFlagAtivo = "N"
            End If
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 9600
                .Connection = cnn
                .Parameters.Add("@nome", SqlDbType.VarChar, 50)
                .Parameters(0).Value = Me.txtNome.Text.Trim
                .Parameters.Add("@senhaCriptografada", SqlDbType.VarChar, 50)
                .Parameters(1).Value = vSenhaCriptografada
                .Parameters.Add("@ativo", SqlDbType.Char, 1)
                .Parameters(2).Value = vFlagAtivo
                .Parameters.Add("@Email", SqlDbType.VarChar, 50)
                .Parameters(3).Value = Me.txtEmail.Text.Trim
                .Parameters.Add("@Tipo", SqlDbType.Char, 1)
                .Parameters(4).Value = Me.cboTipoUsuario.Text.Substring(0, 1)
                .Parameters.Add("@Login", SqlDbType.VarChar, 50)
                .Parameters(5).Value = Me.txtLogin.Text.Trim

                If Me.IDUsuario = 0 Then
                    .CommandText = "spIncluirUsuario"
                Else
                    .CommandText = "spAlterarUsuario"
                    .Parameters.Add("@id", SqlDbType.Int, 4)
                    .Parameters(6).Value = Me.IDUsuario
                End If
                cnn.Open()
                .ExecuteNonQuery()
                cnn.Close()

            End With

            MsgBox("Usuário salvo com sucesso", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click

        If Me.lstvUsuarios.SelectedItems.Count = 0 Then
            MsgBox("Selecione o usuário que deseja alterar", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim vSenhaDescriptografada As String
        vSenhaDescriptografada = Criptografia.CriptografarSenha(Me.lstvUsuarios.SelectedItems(0).SubItems(3).Text.Trim, False)

        Me.IDUsuario = CLng(Me.lstvUsuarios.SelectedItems(0).Text)

        clsUsuario.CarregarDadosUsuario(Me.IDUsuario)

        If clsUsuario.DadosUsuario.Ativo.ToUpper = "S" Then
            Me.chkAtivo.Checked = True
        Else
            Me.chkAtivo.Checked = False
        End If

        Me.txtNome.Text = clsUsuario.DadosUsuario.Nome.Trim
        Me.txtEmail.Text = clsUsuario.DadosUsuario.Email.Trim
        If clsUsuario.DadosUsuario.TipoUsuario.Trim.ToUpper = "A" Then
            Me.cboTipoUsuario.Text = "Administrador"
        Else
            Me.cboTipoUsuario.Text = "Usuário comum"
        End If
        Me.txtLogin.Text = clsUsuario.DadosUsuario.LoginRede.Trim
        Me.txtSenha.Text = vSenhaDescriptografada

        Me.grpEdicaoUsuario.Left = 10
        Me.grpEdicaoUsuario.Top = 81
        Me.grpEdicaoUsuario.BringToFront()
        Me.grpEdicaoUsuario.Visible = True
        Me.txtNome.Focus()

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If Me.lstvUsuarios.SelectedItems.Count = 0 Then
            MsgBox("Selecione o usuário que deseja excluir", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If MessageBox.Show("Confirma excluir o Usuário selecionado?", "Aviso", MessageBoxButtons.YesNo) = DialogResult.No Then
            MsgBox("Cancelado pelo operador", MsgBoxStyle.Information)
            Exit Sub
        End If
        Me.ExcluirUsuario()
        Me.PrencherListaUsuarios()
    End Sub

    Private Sub ExcluirUsuario()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand
        Dim vSenhaCriptografada As String = ""
        Dim vFlagAtivo As String = ""

        Try
            vSenhaCriptografada = Criptografia.CriptografarSenha(Me.txtSenha.Text.Trim, True)
            If Me.chkAtivo.Checked Then
                vFlagAtivo = "S"
            Else
                vFlagAtivo = "N"
            End If
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 9600
                .Connection = cnn
                .CommandText = "spExcluirUsuario"
                .Parameters.Add("@id", SqlDbType.Int, 4)
                .Parameters(0).Value = CLng(Me.lstvUsuarios.SelectedItems(0).Text)

                cnn.Open()
                .ExecuteNonQuery()
                cnn.Close()

                Me.IDUsuario = 0

            End With

            MsgBox("Usuário excluído com sucesso", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lstvUsuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstvUsuarios.SelectedIndexChanged

    End Sub
End Class