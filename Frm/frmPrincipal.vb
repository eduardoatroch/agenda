Imports System.IO

Public Class frmPrincipal

    Public Shared Logado As Boolean = False
    Public Shared TentativasLogin As Integer = 0

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Application.Exit()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblMensagem.Visible = False
        Me.grpTipoConexao.BringToFront()
        Me.grpLogin.BringToFront()
        Me.ValidarTipoAcesso()

        BancoDeDados.MontarStringConexao()

        Me.lblVersao.Text = "Agenda versão: " & My.Application.Info.Version.ToString

        '--Identificação do usuário do Active Directory da Rede
        Dim vCodigoUsuario As Long
        Dim tam As Integer
        Dim vNomeUsuarioSemDominio, vNomeUsuario, caracter As String
        Dim vDaqui As Boolean = False

        Me.txtLogin.Text = clsRotinas.NomeDoUsuario()

        vNomeUsuario = Me.txtLogin.Text.Trim 'clsRotinas.NomeDoUsuario()
        tam = vNomeUsuario.Length
        vNomeUsuarioSemDominio = clsUsuario.ObterNomeUsuarioSemDominio(vNomeUsuario) 'String.Empty
        vCodigoUsuario = clsUsuario.VerificarExistenciaUsuarioPeloLogin(vNomeUsuarioSemDominio)
        If vCodigoUsuario > 0 Then
            clsUsuario.CarregarDadosUsuario(vCodigoUsuario)
            If clsUsuario.DadosUsuario.Ativo = "S" Then
                Me.txtLogin.Text = clsUsuario.DadosUsuario.LoginRede.Trim
                frmPrincipal.Logado = True
            Else
                Me.txtLogin.Text = clsUsuario.DadosUsuario.LoginRede.Trim
                frmPrincipal.Logado = False
                Me.lblMensagem.Text = "Falha no login"
            End If
        Else
            frmPrincipal.Logado = False
        End If

        If frmPrincipal.Logado = True Then
            Dim frm As New frmContatos
            frm.ShowDialog()
        End If
        '--Fim da Rotina de identificação do usuário
    End Sub

    Private Sub AcessarSistema()
        Dim vNomeUsuarioSemDominio As String = ""
        Dim vCodigoUsuario As Long

        If Me.cboTipoAcesso.Text.Trim = "Selecione" Or Me.cboTipoAcesso.Text.Trim = "" Then
            MessageBox.Show("Selecione o Tipo de Acesso ao banco de Dados", "Aviso", MessageBoxButtons.OK)
        Else
            If frmPrincipal.Logado = False Then
                If Me.txtLogin.Text.Trim = "" Then
                    MsgBox("Informe o Login por favor", MsgBoxStyle.Critical)
                    Me.txtLogin.Focus()
                    Exit Sub
                End If
                If Me.txtSenha.Text.Trim = "" Then
                    MsgBox("Informe a senha por favor", MsgBoxStyle.Critical)
                    Me.txtSenha.Focus()
                    Exit Sub
                End If
                vNomeUsuarioSemDominio = clsUsuario.ObterNomeUsuarioSemDominio(Me.txtLogin.Text.Trim)
                If clsUsuario.ValidarSenha(vNomeUsuarioSemDominio, Me.txtSenha.Text.Trim) = False Then
                    MsgBox("Usuário ou senha inválido", MsgBoxStyle.Critical)
                    Me.txtSenha.Focus()
                    frmPrincipal.TentativasLogin += 1
                    If frmPrincipal.TentativasLogin > 4 Then
                        MsgBox("Ultrapassadas as tentativas de login, reveja sua senha", MsgBoxStyle.Critical)
                        Application.Exit()
                    End If
                    Exit Sub
                End If
                frmPrincipal.Logado = True
                vCodigoUsuario = clsUsuario.VerificarExistenciaUsuarioPeloLogin(vNomeUsuarioSemDominio)
                If vCodigoUsuario > 0 Then
                    clsUsuario.CarregarDadosUsuario(vCodigoUsuario)
                End If
                If clsUsuario.DadosUsuario.Ativo.Trim = "S" Then
                    Me.txtLogin.Text = clsUsuario.DadosUsuario.Nome.Trim
                    Me.txtLogin.Text = clsUsuario.DadosUsuario.LoginRede.Trim
                Else
                    Me.txtLogin.Text = clsUsuario.DadosUsuario.Nome.Trim & " - infelizmente o usuário não está ativo"
                    Me.txtLogin.Text = clsUsuario.DadosUsuario.LoginRede.Trim
                    Exit Sub
                End If
            End If

            If frmPrincipal.Logado = True Then
                Dim frm As New frmContatos
                frm.ShowDialog()
            End If

        End If

    End Sub

    Private Sub frmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub



    Private Sub cboTipoAcesso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoAcesso.SelectedIndexChanged
        Me.ValidarTipoAcesso()
    End Sub

    Private Sub ValidarTipoAcesso()
        If Me.cboTipoAcesso.Text.Trim <> "Selecione" And Me.cboTipoAcesso.Text.Trim <> "" Then
            BancoDeDados.pTipoConexaobancoDados = Me.cboTipoAcesso.Text.Substring(0, 2)
        Else
            BancoDeDados.pTipoConexaobancoDados = "01"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New frmOrdenar
        frm.ShowDialog()
    End Sub

    Private Sub txtSenha_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSenha.KeyDown
        If e.KeyCode = Keys.Enter Then
            frmPrincipal.Logado = False
            Me.AcessarSistema()
        End If
    End Sub

    Private Sub btnAcessar_Click(sender As Object, e As EventArgs) Handles btnAcessar.Click
        frmPrincipal.Logado = False
        Me.AcessarSistema()
    End Sub

End Class