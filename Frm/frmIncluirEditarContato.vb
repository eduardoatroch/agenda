Imports System.ComponentModel
Imports System.IO

Public Class frmIncluirEditarContato
    Private CodigoContato As Long
    Private IncluirContato As Boolean
    Private IncluirTelefone As Boolean
    Private IncluirEmail As Boolean
    Private idContato As String

    Public Sub New(ByVal id As String, ByVal Inc As Boolean)
        MyBase.New()
        InitializeComponent()
        'Me.CodigoContato = Cod
        Me.idContato = id
        Me.IncluirContato = Inc
    End Sub

    Private Sub frmIncluirEditarContato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim vVersao As String

        vVersao = My.Application.Info.Version.ToString

        Me.Text = "Agenda versão: " & vVersao
        Me.grpEdicaoEmail.Visible = False
        Me.grpEdicaoTelefone.Visible = False

        If IncluirContato = False Then
            clsContato.CarregarContato(Me.idContato)
            Me.ExibirDadosContato()
            Me.ObterTelefonesContato(Me.idContato)
            Me.ObterEmailsContato(Me.idContato)
        End If

    End Sub

    'Private Sub frmIncluirEditarContato_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    '    If MessageBox.Show("Confirma sair?", "Sair", MessageBoxButtons.YesNo) = DialogResult.No Then
    '        Exit Sub
    '    End If
    'End Sub

    Private Sub ExibirDadosContato()

        'Classe foi instanciada acima

        Try

            Me.txtNome.Text = clsContato.DadosContato.Nome.Trim
            Me.txtEndereco.Text = clsContato.DadosContato.Endereco.Trim
            Me.txtBairro.Text = clsContato.DadosContato.Bairro.Trim
            Me.txtCidade.Text = clsContato.DadosContato.Cidade.Trim

            If clsContato.DadosContato.TipoFisicaJuridica.Trim = "F" Then
                Me.cboTipoPessoa.Text = "Física"
            Else
                Me.cboTipoPessoa.Text = "Jurídica"
            End If

            If clsContato.DadosContato.UF.Trim <> "" Then
                Me.cboUF.Text = clsContato.DadosContato.UF & " - " & clsContato.DadosContato.UFNome
            Else
                Me.cboUF.Text = ""
            End If

            If clsContato.DadosContato.Cep.Trim <> "" Then
                Me.mtxCep.Text = clsContato.DadosContato.Cep 'clsRotinas.MascaraCEP(clsContato.DadosContato.Cep)
            Else
                Me.mtxCep.Text = "" 'Me.txtCep.Text = ""
            End If

            If clsContato.DadosContato.DataNascimento = CDate("01/01/1900") Then
                Me.mtxtDataNascimento.Text = ""
            Else
                Me.mtxtDataNascimento.Text = clsContato.DadosContato.DataNascimento.ToShortDateString
            End If

            Me.txtSite.Text = clsContato.DadosContato.Site.Trim
            Me.txtPessoaContato.Text = clsContato.DadosContato.PessoaContato.Trim
            Me.txtAtividade.Text = clsContato.DadosContato.Atividade.Trim
            Me.txtObservacao.Text = clsContato.DadosContato.Observacoes.Trim

        Catch ex As Exception
            MsgBox(ex.Source & Chr(13) & ex.Message)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim vDataNasc As String = ""
        'Dim vIDContato As Guid

        If Me.txtNome.Text.Trim = "" Then
            MsgBox("Informe o Nome do Contato, por favor!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        vDataNasc = Me.mtxtDataNascimento.Text.Trim.Replace("/", "")
        If vDataNasc.Trim <> "" Then
            If clsRotinas.ValidarData(Me.mtxtDataNascimento.Text.Trim) = False Then
                Me.mtxtDataNascimento.Focus()
                Exit Sub
            End If
        End If

        If Me.cboTipoPessoa.Text.Trim = "Selecione" Or Me.cboTipoPessoa.Text.Trim = "" Then
            MsgBox("Selecione o Tipo do Contato", MsgBoxStyle.Critical)
            Me.cboTipoPessoa.Focus()
            Exit Sub
        End If

        If MsgBox("Confirma salvar os dados do Contato agora ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            If Me.IncluirContato = True Then
                If Me.IncluirContatoNovo() = True Then
                    Me.Close()
                End If
            Else
                If AlterarContatoNovo(Me.idContato) = True Then
                    Me.Close()
                End If
            End If

        End If

    End Sub

    Private Function IncluirContatoNovo() As Boolean
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmdContato As New SqlClient.SqlCommand("spIncluirContatoNovo", cnn)

        'Dim cmdEmail As New SqlClient.SqlCommand("spIncluirContatoEmailNovo", cnn)
        Dim idContato As Guid

        'Dim idContatoEmail As Guid
        Dim vRet As Boolean = False
        Dim vCepSalvar, vDataNasc As String

        Try
            With cmdContato
                .CommandType = CommandType.StoredProcedure

                idContato = Guid.NewGuid

                .Parameters.Add("@idContato", SqlDbType.UniqueIdentifier)
                .Parameters(0).Value = idContato
                .Parameters.Add("@CodigoContato", SqlDbType.Int, 4)
                .Parameters(1).Value = 0
                .Parameters.Add("@NomeContato", SqlDbType.VarChar, 100)
                .Parameters(2).Value = Me.txtNome.Text.Trim
                .Parameters.Add("@Endereco", SqlDbType.VarChar, 100)
                .Parameters(3).Value = Me.txtEndereco.Text.Trim
                .Parameters.Add("@Bairro", SqlDbType.VarChar, 50)
                .Parameters(4).Value = Me.txtBairro.Text.Trim
                .Parameters.Add("@Cidade", SqlDbType.VarChar, 50)
                .Parameters(5).Value = Me.txtCidade.Text.Trim
                .Parameters.Add("@UF", SqlDbType.Char, 2)
                If Me.cboUF.Text.Trim <> "" Then
                    .Parameters(6).Value = Me.cboUF.Text.Substring(0, 2)
                Else
                    .Parameters(6).Value = ""
                End If
                .Parameters.Add("@Cep", SqlDbType.Char, 8)
                If Me.mtxCep.Text.Trim <> "" Then
                    vCepSalvar = Me.mtxCep.Text.Trim
                    .Parameters(7).Value = Me.mtxCep.Text.Replace(".", "").Replace(",", "").Replace("-", "") 'Me.txtCep.Text.Trim.Replace(".", "").Replace("-", "")
                Else
                    .Parameters(7).Value = ""
                End If
                .Parameters.Add("@Site", SqlDbType.VarChar, 200)
                .Parameters(8).Value = Me.txtSite.Text.Trim 'Me.lstvContatos.Items(i).SubItems(10).Text.Trim
                .Parameters.Add("@PssoaContato", SqlDbType.VarChar, 150)
                .Parameters(9).Value = Me.txtPessoaContato.Text.Trim 'Me.lstvContatos.Items(i).SubItems(11).Text.Trim
                .Parameters.Add("@Atividade", SqlDbType.VarChar, 200)
                .Parameters(10).Value = Me.txtAtividade.Text.Trim 'Me.lstvContatos.Items(i).SubItems(2).Text.Trim
                .Parameters.Add("@Observacao", SqlDbType.VarChar, 1000)
                .Parameters(11).Value = Me.txtObservacao.Text.Trim 'Me.lstvContatos.Items(i).SubItems(12).Text.Trim
                .Parameters.Add("@DataNascimentoFundacao", SqlDbType.DateTime, 8)
                vDataNasc = Me.mtxtDataNascimento.Text.Replace("/", "")
                If vDataNasc.Trim <> "" Then
                    vDataNasc = vDataNasc.Substring(0, 2) & "/" & vDataNasc.Substring(2, 2) & "/" & vDataNasc.Substring(4, 4)
                    .Parameters(12).Value = CDate(vDataNasc)
                End If
                .Parameters.Add("@TipoPessoaFisicaJuridica", SqlDbType.Char, 1)
                .Parameters(13).Value = Me.cboTipoPessoa.Text.Substring(0, 1).ToUpper
                cnn.Open()
                .ExecuteNonQuery()
                cnn.Close()

                'Incluir os Telefones
                If Me.lstvTelefones.Items.Count > 0 Then
                    For t As Integer = 0 To Me.lstvTelefones.Items.Count - 1
                        Me.IncluirTelefoneNovo(Me.lstvTelefones.Items(t).SubItems(1).Text.Trim,
                                               Me.lstvTelefones.Items(t).SubItems(2).Text.Substring(0, 3),
                                               CBool(Me.lstvTelefones.Items(t).SubItems(3).Text.Trim),
                                               Me.lstvTelefones.Items(t).SubItems(5).Text.Trim,
                                               idContato)

                    Next
                End If

                'Incluir os Emails
                If Me.lstvEmails.Items.Count > 0 Then
                    For e As Integer = 0 To Me.lstvEmails.Items.Count - 1
                        Me.IncluirEmailNovo(Me.idContato, Me.lstvEmails.Items(e).SubItems(1).Text.Trim, CBool(Me.lstvEmails.Items(e).SubItems(2).Text))
                    Next
                End If

            End With

            vRet = True
            MsgBox("Contato incluído com sucesso", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        Return vRet

    End Function

    Private Function AlterarContatoNovo(ByVal pIdContato As String) As Boolean
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmdContato As New SqlClient.SqlCommand("spAlterarContatoNovo", cnn)

        Dim idContato As Guid

        Dim vCepSalvar, vDataNasc As String
        Dim vRet As Boolean = True

        Try
            With cmdContato
                .CommandType = CommandType.StoredProcedure

                idContato = New Guid(pIdContato)

                .Parameters.Add("@idContato", SqlDbType.UniqueIdentifier)
                .Parameters(0).Value = idContato
                .Parameters.Add("@NomeContato", SqlDbType.VarChar, 100)
                .Parameters(1).Value = Me.txtNome.Text.Trim
                .Parameters.Add("@Endereco", SqlDbType.VarChar, 100)
                .Parameters(2).Value = Me.txtEndereco.Text.Trim
                .Parameters.Add("@Bairro", SqlDbType.VarChar, 50)
                .Parameters(3).Value = Me.txtBairro.Text.Trim
                .Parameters.Add("@Cidade", SqlDbType.VarChar, 50)
                .Parameters(4).Value = Me.txtCidade.Text.Trim
                .Parameters.Add("@UF", SqlDbType.Char, 2)
                If Me.cboUF.Text.Trim <> "" Then
                    .Parameters(5).Value = Me.cboUF.Text.Substring(0, 2)
                Else
                    .Parameters(5).Value = ""
                End If
                .Parameters.Add("@Cep", SqlDbType.Char, 8)
                If Me.mtxCep.Text.Trim <> "" Then
                    vCepSalvar = Me.mtxCep.Text.Trim
                    .Parameters(6).Value = Me.mtxCep.Text.Replace(".", "").Replace(",", "").Replace("-", "")
                Else
                    .Parameters(6).Value = ""
                End If
                .Parameters.Add("@WWW", SqlDbType.VarChar, 200)
                .Parameters(7).Value = Me.txtSite.Text.Trim
                .Parameters.Add("@PessoaContato", SqlDbType.VarChar, 150)
                .Parameters(8).Value = Me.txtPessoaContato.Text.Trim
                .Parameters.Add("@Atividade", SqlDbType.VarChar, 200)
                .Parameters(9).Value = Me.txtAtividade.Text.Trim
                .Parameters.Add("@Observacao", SqlDbType.VarChar, 1000)
                .Parameters(10).Value = Me.txtObservacao.Text.Trim
                .Parameters.Add("@DataNascimentoFundacao", SqlDbType.DateTime, 8)
                vDataNasc = Me.mtxtDataNascimento.Text.Replace("/", "")
                If vDataNasc.Trim <> "" Then
                    vDataNasc = vDataNasc.Substring(0, 2) & "/" & vDataNasc.Substring(2, 2) & "/" & vDataNasc.Substring(4, 4)
                    .Parameters(11).Value = CDate(vDataNasc)
                End If
                .Parameters.Add("@TipoPessoaFisicaJuridica", SqlDbType.Char, 1)
                .Parameters(12).Value = Me.cboTipoPessoa.Text.Substring(0, 1).ToUpper
                cnn.Open()
                .ExecuteNonQuery()
                cnn.Close()

                'Atualizar os Telefones
                If Me.lstvTelefones.Items.Count > 0 Then

                    For t As Integer = 0 To Me.lstvTelefones.Items.Count - 1
                        If Me.lstvTelefones.Items(t).SubItems(4).Text.Trim <> "" Then
                            If Me.lstvTelefones.Items(t).SubItems(4).Text = "I" Then
                                Me.IncluirTelefoneNovo(Me.lstvTelefones.Items(t).SubItems(1).Text.Trim,
                                                       Me.lstvTelefones.Items(t).SubItems(2).Text.Substring(0, 3),
                                                       CBool(Me.lstvTelefones.Items(t).SubItems(3).Text.Trim),
                                                       Me.lstvTelefones.Items(t).SubItems(5).Text.Trim,
                                                       idContato)
                            Else
                                Me.AlterarTelefoneNovo(Me.lstvTelefones.Items(t).SubItems(1).Text.Trim,
                                                       Me.lstvTelefones.Items(t).SubItems(2).Text.Substring(0, 3),
                                                       CBool(Me.lstvTelefones.Items(t).SubItems(3).Text.Trim),
                                                       Me.lstvTelefones.Items(t).SubItems(5).Text.Trim,
                                                       Me.idContato,
                                                       Me.lstvTelefones.Items(t).Text)
                            End If
                        End If
                    Next

                End If

                'Incluir os Emails
                If Me.lstvEmails.Items.Count > 0 Then

                    For e As Integer = 0 To Me.lstvEmails.Items.Count - 1
                        If Me.lstvEmails.Items(e).SubItems(3).Text.Trim <> "" Then
                            If Me.lstvEmails.Items(e).SubItems(3).Text = "I" Then
                                Me.IncluirEmailNovo(Me.idContato,
                                                    Me.lstvEmails.Items(e).SubItems(1).Text.Trim,
                                                    CBool(Me.lstvEmails.Items(e).SubItems(2).Text))
                            Else
                                Me.AlterarEmailNovo(Me.lstvEmails.Items(e).Text.Trim,
                                                    Me.lstvEmails.Items(e).SubItems(1).Text.Trim,
                                                    CBool(Me.lstvEmails.Items(e).SubItems(2).Text),
                                                    Me.idContato)
                            End If
                        End If

                    Next

                End If

            End With

            'Linpando o comando após salvar no Banco de Dados
            For i As Integer = 0 To Me.lstvTelefones.Items.Count - 1
                Me.lstvTelefones.Items(i).SubItems(4).Text = ""
            Next
            For j As Integer = 0 To Me.lstvEmails.Items.Count - 1
                Me.lstvEmails.Items(j).SubItems(3).Text = ""
            Next

            vRet = True
            MsgBox("Contato alterado com sucesso", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        Return vRet

    End Function

    Private Sub IncluirTelefoneNovo(ByVal pNumeroTelefone As String,
                                    ByVal pTipoTelefone As String,
                                    ByVal pFlagPrincipal As Boolean,
                                    ByVal pDescricao As String,
                                    ByVal pIdContato As Guid)
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmdTelefone As New SqlClient.SqlCommand("spIncluirContatoFoneNovo", cnn)
        Dim idContatoFone As Guid

        Try
            idContatoFone = Guid.NewGuid()
            With cmdTelefone
                .CommandType = CommandType.StoredProcedure

                .Parameters.Add("@idContatoFone", SqlDbType.UniqueIdentifier)
                .Parameters(0).Value = idContatoFone
                .Parameters.Add("@idContato", SqlDbType.UniqueIdentifier)
                .Parameters(1).Value = pIdContato
                .Parameters.Add("@NumeroTelefone", SqlDbType.VarChar, 20)
                .Parameters(2).Value = pNumeroTelefone.Trim 'Me.lstvTelefones.Items(t).SubItems(1).Text.Trim
                .Parameters.Add("@Tipo", SqlDbType.Char, 3)
                .Parameters(3).Value = pTipoTelefone.ToUpper 'Me.lstvTelefones.Items(t).SubItems(2).Text.Substring(0, 3)
                .Parameters.Add("@FlagPrincipal", SqlDbType.Bit, 1)
                If pFlagPrincipal = True Then
                    .Parameters(4).Value = 1
                Else
                    .Parameters(4).Value = 0
                End If
                .Parameters.Add("@Descricao", SqlDbType.VarChar, 50)
                .Parameters(5).Value = pDescricao.Trim 'Me.lstvTelefones.Items(t).SubItems(5).Text.Trim
                cnn.Open()
                .ExecuteNonQuery()
                cnn.Close()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub AlterarTelefoneNovo(ByVal pNumeroTelefone As String,
                                    ByVal pTipoTelefone As String,
                                    ByVal pFlagPrincipal As Boolean,
                                    ByVal pDescricao As String,
                                    ByVal pIdContato As String,
                                    ByVal pIDContatoFone As String)
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmdTelefone As New SqlClient.SqlCommand("spAlterarContatoFoneNovo", cnn)
        Dim vIdContatoFone As Guid
        Dim vIdContato As Guid

        Try
            vIdContatoFone = New Guid(pIDContatoFone)
            vIdContato = New Guid(pIdContato)

            With cmdTelefone
                .CommandType = CommandType.StoredProcedure

                .Parameters.Add("@idContatoFone", SqlDbType.UniqueIdentifier)
                .Parameters(0).Value = vIdContatoFone

                .Parameters.Add("@idContato", SqlDbType.UniqueIdentifier)
                .Parameters(1).Value = vIdContato

                .Parameters.Add("@NumeroTelefone", SqlDbType.VarChar, 20)
                .Parameters(2).Value = pNumeroTelefone.Trim

                .Parameters.Add("@Tipo", SqlDbType.Char, 3)
                .Parameters(3).Value = pTipoTelefone.ToUpper

                .Parameters.Add("@FlagPrincipal", SqlDbType.Bit, 1)
                If pFlagPrincipal = True Then
                    .Parameters(4).Value = 1
                Else
                    .Parameters(4).Value = 0
                End If

                .Parameters.Add("@Descricao", SqlDbType.VarChar, 50)
                .Parameters(5).Value = pDescricao.Trim 'Me.lstvTelefones.Items(t).SubItems(5).Text.Trim

                cnn.Open()
                .ExecuteNonQuery()
                cnn.Close()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub IncluirEmailNovo(ByVal pIDContato As String, ByVal pEmail As String, ByVal pFlagPrincipal As Boolean)
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spIncluirContatoEmailNovo", cnn)
        Dim vIdContatoEmail As Guid
        Dim vIDContato As Guid

        Try
            vIdContatoEmail = Guid.NewGuid
            vIDContato = New Guid(pIDContato)
            With cmd
                .CommandType = CommandType.StoredProcedure

                .Parameters.Add("@idContatoEmail", SqlDbType.UniqueIdentifier)
                .Parameters(0).Value = vIdContatoEmail
                .Parameters.Add("@idContato", SqlDbType.UniqueIdentifier)
                .Parameters(1).Value = vIDContato
                .Parameters.Add("@Email", SqlDbType.VarChar, 50)
                .Parameters(2).Value = pEmail.Trim.ToLower
                .Parameters.Add("@FlagPrincipal", SqlDbType.Bit, 1)
                If pFlagPrincipal = True Then
                    .Parameters(3).Value = 1
                Else
                    .Parameters(3).Value = 0
                End If
                cnn.Open()
                .ExecuteNonQuery()
                cnn.Close()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub AlterarEmailNovo(ByVal pIDContatoEmail As String, ByVal pEmail As String, ByVal pFlagPrincipal As Boolean, ByVal pIDContato As String)
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spAlterarContatoEmailNovo", cnn)
        Dim vIdContatoEmail As Guid
        Dim vIDContato As Guid

        Try
            vIdContatoEmail = New Guid(pIDContatoEmail)
            vIDContato = New Guid(pIDContato)
            With cmd
                .CommandType = CommandType.StoredProcedure

                .Parameters.Add("@idContatoEmail", SqlDbType.UniqueIdentifier)
                .Parameters(0).Value = vIdContatoEmail
                .Parameters.Add("@idContato", SqlDbType.UniqueIdentifier)
                .Parameters(1).Value = vIDContato
                .Parameters.Add("@Email", SqlDbType.VarChar, 50)
                .Parameters(2).Value = pEmail.Trim.ToLower
                .Parameters.Add("@FlagPrincipal", SqlDbType.Bit, 1)
                If pFlagPrincipal = True Then
                    .Parameters(3).Value = 1
                Else
                    .Parameters(3).Value = 0
                End If
                cnn.Open()
                .ExecuteNonQuery()
                cnn.Close()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Function SalvarContato() As Boolean
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand
        Dim cmdSalvarTelefones As New SqlClient.SqlCommand
        Dim vRet As Boolean = True
        Dim vPrincipal As Boolean = False
        Dim vDataNasc As String = ""
        Dim vCepSalvar As String = ""

        Try
            vDataNasc = Me.mtxtDataNascimento.Text.Trim.Replace("/", "")

            With cmd
                .CommandType = CommandType.StoredProcedure
                .Connection = cnn
                If IncluirContato Then
                    .CommandText = "spIncluirContato"
                Else
                    .CommandText = "spAlterarContato"
                End If
                .Parameters.Add("@Nome", SqlDbType.VarChar, 100)
                .Parameters(0).Value = Me.txtNome.Text.Trim
                .Parameters.Add("@Endereco", SqlDbType.VarChar, 100)
                .Parameters(1).Value = Me.txtEndereco.Text.Trim
                .Parameters.Add("@Bairro", SqlDbType.VarChar, 50)
                .Parameters(2).Value = Me.txtBairro.Text.Trim
                .Parameters.Add("@Cidade", SqlDbType.VarChar, 50)
                .Parameters(3).Value = Me.txtCidade.Text.Trim
                .Parameters.Add("@UF", SqlDbType.Char, 2)
                If Me.cboUF.Text.Trim <> "" Then
                    .Parameters(4).Value = Me.cboUF.Text.Substring(0, 2)
                Else
                    .Parameters(4).Value = ""
                End If
                .Parameters.Add("@Cep", SqlDbType.Char, 8)
                If Me.mtxCep.Text.Trim <> "" Then
                    vCepSalvar = Me.mtxCep.Text.Trim
                    .Parameters(5).Value = Me.mtxCep.Text.Replace(".", "").Replace(",", "").Replace("-", "") 'Me.txtCep.Text.Trim.Replace(".", "").Replace("-", "")
                Else
                    .Parameters(5).Value = ""
                End If
                .Parameters.Add("@www", SqlDbType.VarChar, 200)
                .Parameters(6).Value = Me.txtSite.Text.Trim
                .Parameters.Add("@PessoaContato", SqlDbType.VarChar, 150)
                .Parameters(7).Value = Me.txtPessoaContato.Text.Trim
                .Parameters.Add("@Atividade", SqlDbType.VarChar, 200)
                .Parameters(8).Value = Me.txtAtividade.Text.Trim
                .Parameters.Add("@Obs", SqlDbType.VarChar, 700)
                .Parameters(9).Value = Me.txtObservacao.Text.Trim
                .Parameters.Add("@DataNascimento", SqlDbType.DateTime, 8)
                If vDataNasc.Trim <> "" Then
                    .Parameters(10).Value = CDate(Me.mtxtDataNascimento.Text)
                End If
                .Parameters.Add("@CodigoContato", SqlDbType.Int, 4)
                If Me.IncluirContato Then
                    .Parameters(11).Direction = ParameterDirection.Output
                Else
                    .Parameters(11).Value = Me.CodigoContato
                End If
                cnn.Open()
                .ExecuteNonQuery()
                cnn.Close()
                If Me.IncluirContato = True Then
                    Me.CodigoContato = CLng(.Parameters(11).Value)
                End If
            End With

            If Me.CodigoContato > 0 Then

                'Salvar Telefones
                'If Me.lstvTelefones.Items.Count > 0 Then
                '    For i As Integer = 0 To Me.lstvTelefones.Items.Count - 1
                '        If Me.lstvTelefones.Items(i).SubItems(4).Text.Trim = "I" Then
                '            If Me.lstvTelefones.Items(i).SubItems(3).Text.Trim <> "" Then
                '                vPrincipal = CBool(Me.lstvTelefones.Items(i).SubItems(3).Text)
                '            Else
                '                vPrincipal = False
                '            End If
                '            Me.SalvarContatoTelefone(Me.CodigoContato, _
                '                                     Me.lstvTelefones.Items(i).SubItems(1).Text.Trim, _
                '                                     Me.lstvTelefones.Items(i).SubItems(2).Text.Trim, _
                '                                     vPrincipal)
                '        End If
                '    Next
                'End If
                'Salvar E-mails
                'If Me.lstvEmails.Items.Count > 0 Then
                '    For i As Integer = 0 To Me.lstvEmails.Items.Count - 1
                '        If Me.lstvEmails.Items(i).SubItems(3).Text.Trim = "I" Then
                '            vPrincipal = CByte(Me.lstvEmails.Items(i).SubItems(2).Text)
                '            Me.SalvarContatoEmail(Me.lstvEmails.Items(i).SubItems(1).Text.Trim, vPrincipal, 0)
                '        End If
                '    Next
                'End If

            End If

        Catch ex As Exception
            vRet = False
            MsgBox(ex.Source & Chr(13) & ex.Message)
        Finally
            cnn.Dispose()
            cmd.Dispose()
            GC.Collect()
        End Try

        Return vRet

    End Function

    'Private Sub SalvarContatoTelefone(ByVal pCodigoContato As Long, ByVal pNumero As String, ByVal pTipo As String, ByVal pPrincipal As Boolean)
    '    Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
    '    Dim cmd As New SqlClient.SqlCommand("spSalvarContatoTelefone", cnn)
    '    Try
    '        With cmd
    '            .CommandType = CommandType.StoredProcedure
    '            .Parameters.Add("@CodigoContato", SqlDbType.Int, 4)
    '            .Parameters(0).Value = pCodigoContato
    '            .Parameters.Add("@Numero", SqlDbType.VarChar, 20)
    '            .Parameters(1).Value = pNumero
    '            .Parameters.Add("@tipo", SqlDbType.Char, 3)
    '            .Parameters(2).Value = pTipo
    '            .Parameters.Add("@principal", SqlDbType.Bit, 1)
    '            If pPrincipal = True Then
    '                .Parameters(3).Value = 1
    '            Else
    '                .Parameters(3).Value = 0
    '            End If
    '            cnn.Open()
    '            .ExecuteNonQuery()
    '            cnn.Close()
    '        End With
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub AtualizarClasseContato()
        Dim vTelefones As String = ""
        Dim tam As Integer

        clsContato.DadosContato.CodigoContato = Me.CodigoContato
        clsContato.DadosContato.Nome = Me.txtNome.Text.Trim
        clsContato.DadosContato.Endereco = Me.txtEndereco.Text.Trim
        clsContato.DadosContato.Bairro = Me.txtBairro.Text.Trim
        clsContato.DadosContato.Cidade = Me.txtCidade.Text.Trim
        If Me.cboUF.Text.Trim <> "" Then
            clsContato.DadosContato.UF = Me.cboUF.Text.Substring(0, 2)
            clsContato.DadosContato.UFNome = clsRotinas.ObterNomeEstado(clsContato.DadosContato.UF)
        Else
            clsContato.DadosContato.UF = ""
        End If
        If Me.mtxCep.Text.Trim <> "" Then
            clsContato.DadosContato.Cep = Me.mtxCep.Text.Replace(".", "").Replace(",", "").Replace("-", "")
        Else
            clsContato.DadosContato.Cep = ""
        End If
        clsContato.DadosContato.Site = Me.txtSite.Text.Trim
        clsContato.DadosContato.Email = Me.txtEmail.Text.Trim
        clsContato.DadosContato.PessoaContato = Me.txtPessoaContato.Text.Trim
        clsContato.DadosContato.Atividade = Me.txtAtividade.Text.Trim
        clsContato.DadosContato.Observacoes = Me.txtObservacao.Text.Trim

        If Me.lstvTelefones.Items.Count > 0 Then
            For i As Integer = 0 To Me.lstvTelefones.Items.Count - 1
                vTelefones &= Me.lstvTelefones.Items(i).SubItems(1).Text.Trim & "(" & Me.lstvTelefones.Items(i).SubItems(2).Text.Trim & "),"
            Next
            tam = vTelefones.Length
            If tam > 0 Then
                vTelefones = vTelefones.Substring(0, tam - 1)
                clsContato.DadosContato.Telefones = vTelefones
            Else
                clsContato.DadosContato.Telefones = ""
            End If
        Else
            clsContato.DadosContato.Telefones = ""
        End If

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnIncluirTelefone_Click(sender As Object, e As EventArgs) Handles btnIncluirTelefone.Click

        Me.IncluirTelefone = True
        Me.grpEdicaoTelefone.Left = 35
        Me.grpEdicaoTelefone.Top = 300
        Me.grpEdicaoTelefone.BringToFront()
        Me.LimparEdicaoTelefone()
        Me.grpEdicaoTelefone.Visible = True
        Me.txtNumeroTelefone.Focus()

    End Sub

    Private Sub LimparEdicaoTelefone()
        Me.txtNumeroTelefone.Text = String.Empty
        Me.cboTipoTelefone.Text = "Selecione"
        Me.txtFinalidadeTelefone.Text = String.Empty
        Me.chkTelefonePrincipal.Checked = False
    End Sub

    Private Sub InserirTelefoneNaLista(ByVal pNumero As String, ByVal pTipo As String, ByVal pPrincipal As Boolean)
        Dim lvi As ListViewItem

        lvi = Me.lstvTelefones.Items.Add("0") 'id
        lvi.SubItems.Add(pNumero.Trim)
        lvi.SubItems.Add(pTipo.Trim)
        If pPrincipal = True Then
            lvi.SubItems.Add("1")
        Else
            lvi.SubItems.Add("")
        End If
        lvi.SubItems.Add("I")

    End Sub

    Private Sub btnExcluirTelefone_Click(sender As Object, e As EventArgs) Handles btnExcluirTelefone.Click

        If Me.lstvTelefones.SelectedItems.Count = 0 Then
            MsgBox("Selecione o(s) Telefone(s) que deseja excluir!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Me.lstvTelefones.SelectedItems(0).SubItems(4).Text = "E"
        If MessageBox.Show("Confirma a exclusão do Contato selecionado?", "Excluir", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            If ExcluirTelefone() = True Then
                Me.ObterTelefonesContato(Me.idContato)
            End If
            MsgBox("Telefone excluído com sucesso!", MsgBoxStyle.Information)
        End If

    End Sub

    Private Function ExcluirTelefone() As Boolean
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        'Dim cmd As New SqlClient.SqlCommand("spExcluirContatoTelefone", cnn)
        Dim cmd As New SqlClient.SqlCommand("spExcluirContatoTelefoneNovo", cnn)
        Dim vExcluiuFoneDoBancoDados As Boolean = False

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure

                For i As Integer = Me.lstvTelefones.SelectedItems.Count - 1 To 0 Step -1
                    If Me.lstvTelefones.SelectedItems(i).SubItems(4).Text.Trim <> "" Then
                        If Me.lstvTelefones.SelectedItems(i).SubItems(4).Text.Trim = "E" Then
                            .Parameters.Clear()
                            .Parameters.Add("@idContatoFone", SqlDbType.UniqueIdentifier)
                            .Parameters(0).Value = New Guid(Me.lstvTelefones.SelectedItems(i).Text)
                            cnn.Open()
                            .ExecuteNonQuery()
                            cnn.Close()
                            vExcluiuFoneDoBancoDados = True
                        End If
                    End If
                    'If Me.lstvTelefones.SelectedItems(i).Text.Trim <> "" And Me.lstvTelefones.SelectedItems(i).Text.Trim <> "0" Then
                    '    .Parameters.Clear()
                    '    .Parameters.Add("@idContatoFone", SqlDbType.SmallInt, 2)
                    '    .Parameters(0).Value = CInt(Me.lstvTelefones.SelectedItems(i).Text)
                    '    cnn.Open()
                    '    .ExecuteNonQuery()
                    '    cnn.Close()
                    '    vExcluiuFoneDoBancoDados = True
                    'Else
                    '    Me.lstvTelefones.SelectedItems(i).Remove()
                    'End If

                Next

            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return vExcluiuFoneDoBancoDados

    End Function

    Private Sub ObterTelefonesContato(ByVal pIDContato As String)
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand
        Dim dtr As SqlClient.SqlDataReader
        Dim lvi As ListViewItem

        Try
            Me.lstvTelefones.Items.Clear()
            With cmd
                .CommandType = CommandType.Text
                .Connection = cnn
                .CommandText = "select * from vwRetornarListaContatosTelefoneNovo where IDContato='" & pIDContato & "' order by descricaoTelefone"
                cnn.Open()
                dtr = .ExecuteReader
                While dtr.Read
                    lvi = Me.lstvTelefones.Items.Add(dtr(0).ToString) 'id
                    lvi.SubItems.Add(dtr(1).ToString) 'número do telefone
                    lvi.SubItems.Add(dtr(2).ToString) 'tipo
                    If CBool(dtr(3)) = True Then
                        lvi.SubItems.Add("1") 'flag principal
                    Else
                        lvi.SubItems.Add("0")
                    End If
                    lvi.SubItems.Add("") 'cmd
                    lvi.SubItems.Add(dtr(5).ToString) 'descrição do telefone
                End While
                dtr.Close()
                cnn.Close()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub lstvTelefones_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lstvTelefones.ColumnClick
        'If Me.lstvTelefones.Sorting = SortOrder.Ascending Then
        '    Me.lstvTelefones.Sorting = SortOrder.Descending
        'Else
        '    Me.lstvTelefones.Sorting = SortOrder.Ascending
        'End If
        'Me.lstvTelefones.ListViewItemSorter = New ListViewItemComparer(e.Column, Me.lstvTelefones.Sorting)
    End Sub

    Private Sub lstvTelefones_Leave(sender As Object, e As EventArgs) Handles lstvTelefones.Leave
        clsRotinas.PintarLista(Me.lstvTelefones)
    End Sub

    Private Sub lstvTelefones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstvTelefones.SelectedIndexChanged
        If Me.lstvTelefones.SelectedItems.Count = 1 Then
            clsRotinas.PintarLista(Me.lstvTelefones)
        End If
    End Sub

    Private Sub btnIncluirEmail_Click(sender As Object, e As EventArgs) Handles btnIncluirEmail.Click
        Me.IncluirEmail = True
        Me.grpEdicaoEmail.Left = 618
        Me.grpEdicaoEmail.Top = 300
        Me.grpEdicaoEmail.BringToFront()
        Me.grpEdicaoEmail.Visible = True
        Me.txtEmail.Focus()
    End Sub

    Private Sub btnCancelarEdicao_Click(sender As Object, e As EventArgs) Handles btnCancelarEdicao.Click
        Me.grpEdicaoEmail.Visible = False
        If Me.lstvEmails.Items.Count > 0 Then
            For i As Integer = 0 To Me.lstvTelefones.Items.Count - 1
                Me.lstvEmails.SelectedItems(0).SubItems(4).Text = ""
            Next
        End If
    End Sub

    Private Sub btnSalvarEmail_Click(sender As Object, e As EventArgs) Handles btnSalvarEmail.Click
        Dim idEmail As Guid

        If Me.IncluirEmail = True Then
            idEmail = Guid.NewGuid()
            Dim lvi As ListViewItem
            lvi = Me.lstvEmails.Items.Add(idEmail.ToString)
            lvi.SubItems.Add(Me.txtEmail.Text.Trim)
            If Me.chkEmailPrincipal.Checked Then
                lvi.SubItems.Add("1")
            Else
                lvi.SubItems.Add("0")
            End If
            lvi.SubItems.Add("I")
        Else
            Me.lstvEmails.SelectedItems(0).SubItems(1).Text = Me.txtEmail.Text.Trim
            If Me.chkEmailPrincipal.Checked = True Then
                Me.lstvEmails.SelectedItems(0).SubItems(2).Text = "1"
            Else
                Me.lstvEmails.SelectedItems(0).SubItems(2).Text = "0"
            End If
            Me.lstvEmails.SelectedItems(0).SubItems(3).Text = "A"
        End If

        MsgBox("Atenção, é necessário salvar o contato para guardar o e-mail.", MsgBoxStyle.Information)

        Me.txtEmail.Text = String.Empty
        Me.grpEdicaoEmail.Visible = False

    End Sub

    Private Sub SalvarContatoEmail(ByVal pEmail As String, ByVal pPrincipal As Byte, ByVal pIdContatoEmail As Integer)
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand '("spIncluirContatoEmail", cnn)

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Connection = cnn
                .Parameters.Add("@CodigoContato", SqlDbType.Int, 4)
                .Parameters(0).Value = Me.CodigoContato
                .Parameters.Add("@DescricaoEmail", SqlDbType.VarChar, 50)
                .Parameters(1).Value = pEmail
                .Parameters.Add("@Principal", SqlDbType.Bit, 1)
                .Parameters(2).Value = pPrincipal
                If pIdContatoEmail = 0 Then
                    .CommandText = "spIncluirContatoEmail"
                Else
                    .CommandText = "spAlterarContatoEmail"
                    .Parameters.Add("@idContatoEmail", SqlDbType.SmallInt, 2)
                    .Parameters(3).Value = pIdContatoEmail
                End If
                cnn.Open()
                .ExecuteNonQuery()
                cnn.Close()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ObterEmailsContato(ByVal pIdContato As String)
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand
        Dim dtr As SqlClient.SqlDataReader
        Dim lvi As ListViewItem

        Try
            Me.lstvEmails.Items.Clear()
            With cmd
                .CommandType = CommandType.Text
                .Connection = cnn
                '.CommandText = "select * from vwRetornarListaContatosEmail where codigoContato=" & pCodigoContato.ToString & " order by Email"
                .CommandText = "select * from vwRetornarListaContatosEmailNovo where idContato='" & pIdContato & "' order by Email"
                cnn.Open()
                dtr = .ExecuteReader
                While dtr.Read
                    lvi = Me.lstvEmails.Items.Add(dtr(0).ToString) 'id
                    lvi.SubItems.Add(dtr(2).ToString) 'Email
                    If CBool(dtr(3)) = True Then
                        lvi.SubItems.Add("1") 'flag principal
                    Else
                        lvi.SubItems.Add("")
                    End If
                    lvi.SubItems.Add("") 'cmd
                End While
                dtr.Close()
                cnn.Close()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnExcluirEmail_Click(sender As Object, e As EventArgs) Handles btnExcluirEmail.Click

        If Me.lstvEmails.SelectedItems.Count = 0 Then
            MsgBox("Selecione o E-mail que deseja excluir.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If MessageBox.Show("Confirma a exclusão do E-mail selecionado?", "Excluir E-mail", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            If Me.lstvEmails.SelectedItems(0).Text.Trim <> "" Then
                Me.ExcluirContatoEmail(New Guid(Me.lstvEmails.SelectedItems(0).Text))
                Me.ObterEmailsContato(Me.idContato)
            Else
                Me.lstvEmails.SelectedItems(0).Remove()
            End If

            MsgBox("Email excluído com sucesso!", MsgBoxStyle.Information)

        End If

    End Sub

    Private Sub ExcluirContatoEmail(ByVal pIdContatoEmail As Guid)
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spExcluirContatoEmailNovo", cnn)

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idContatoEmail", SqlDbType.UniqueIdentifier)
                .Parameters(0).Value = pIdContatoEmail
                cnn.Open()
                .ExecuteNonQuery()
                cnn.Close()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub lstvEmails_Leave(sender As Object, e As EventArgs) Handles lstvEmails.Leave
        clsRotinas.PintarLista(Me.lstvEmails)
    End Sub

    Private Sub lstvEmails_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstvEmails.SelectedIndexChanged
        If Me.lstvEmails.SelectedItems.Count = 1 Then
            clsRotinas.PintarLista(Me.lstvEmails)
        End If
    End Sub

    Private Sub btnAlterarEmail_Click(sender As Object, e As EventArgs) Handles btnAlterarEmail.Click

        If Me.lstvEmails.SelectedItems.Count = 0 Then
            MsgBox("Selecione o e-mail que deseja alterar.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If Me.lstvEmails.SelectedItems(0).Text.Trim = "" Then
            Me.IncluirEmail = True
            Me.lstvEmails.SelectedItems(0).SubItems(3).Text = "I"
        Else
            Me.IncluirEmail = False
            Me.lstvEmails.SelectedItems(0).SubItems(3).Text = "A"
        End If

        Me.grpEdicaoEmail.Left = 618
        Me.grpEdicaoEmail.Top = 300
        Me.grpEdicaoEmail.BringToFront()
        Me.grpEdicaoEmail.Visible = True

        Me.lstvEmails.SelectedItems(0).SubItems(3).Text = "A"

        Me.txtEmail.Text = Me.lstvEmails.SelectedItems(0).SubItems(1).Text.Trim
        If Me.lstvEmails.SelectedItems(0).SubItems(2).Text.Trim = "" Then
            Me.chkEmailPrincipal.Checked = False
        Else
            Me.chkEmailPrincipal.Checked = True
        End If
        Me.txtEmail.Focus()

    End Sub

    Private Sub btnAlterarTelefone_Click(sender As Object, e As EventArgs) Handles btnAlterarTelefone.Click

        If Me.lstvTelefones.SelectedItems.Count = 0 Then
            MsgBox("Selecione o Telefone que deseja alterar.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If Me.lstvTelefones.SelectedItems(0).Text.Trim = "" Then
            Me.IncluirTelefone = True
            Me.lstvTelefones.SelectedItems(0).SubItems(4).Text = "I"
        Else
            Me.IncluirTelefone = False
            Me.lstvTelefones.SelectedItems(0).SubItems(4).Text = "A"
        End If

        Me.grpEdicaoTelefone.Left = 35
        Me.grpEdicaoTelefone.Top = 300
        Me.grpEdicaoTelefone.BringToFront()

        Me.txtNumeroTelefone.Text = Me.lstvTelefones.SelectedItems(0).SubItems(1).Text.Trim
        Me.cboTipoTelefone.Text = Me.lstvTelefones.SelectedItems(0).SubItems(2).Text.Trim
        Me.txtFinalidadeTelefone.Text = Me.lstvTelefones.SelectedItems(0).SubItems(5).Text.Trim

        If Me.lstvTelefones.SelectedItems(0).SubItems(3).Text.Trim <> "" Then
            If CBool(Me.lstvTelefones.SelectedItems(0).SubItems(3).Text.Trim) Then
                Me.chkTelefonePrincipal.Checked = True
            Else
                Me.chkTelefonePrincipal.Checked = False
            End If
        Else
            Me.chkTelefonePrincipal.Checked = False
        End If

        Me.grpEdicaoTelefone.Visible = True
        Me.txtNumeroTelefone.Focus()

    End Sub

    Private Sub btnCancelarEdicaoTelefone_Click(sender As Object, e As EventArgs) Handles btnCancelarEdicaoTelefone.Click
        Me.grpEdicaoTelefone.Visible = False
        Me.grpEdicaoTelefone.Left = 642
        Me.grpEdicaoTelefone.Top = 136
        If Me.lstvEmails.Items.Count > 0 Then
            For i As Integer = 0 To Me.lstvEmails.Items.Count - 1
                Me.lstvEmails.Items(i).SubItems(3).Text = ""
            Next
        End If
    End Sub

    Private Sub btnSalvarTelefone_Click(sender As Object, e As EventArgs) Handles btnSalvarTelefone.Click

        If Me.txtNumeroTelefone.Text.Trim = "" Then
            MsgBox("Informe o nº do telefone por favor", MsgBoxStyle.Critical)
            Me.txtNumeroTelefone.Focus()
            Exit Sub
        End If

        If Me.cboTipoTelefone.Text.Trim = "Selecione" Or Me.cboTipoTelefone.Text.Trim = "" Then
            MsgBox("Selecione o tipo do telefone por favor", MsgBoxStyle.Critical)
            Me.cboTipoTelefone.Focus()
            Exit Sub
        End If
        Dim idTelefone As Guid

        If Me.IncluirTelefone = True Then
            idTelefone = Guid.NewGuid()
            Dim lvi As ListViewItem
            lvi = Me.lstvTelefones.Items.Add(idTelefone.ToString)
            lvi.SubItems.Add(Me.txtNumeroTelefone.Text.Trim)
            lvi.SubItems.Add(Me.cboTipoTelefone.Text.Substring(0, 3).ToUpper)
            If Me.chkTelefonePrincipal.Checked Then
                lvi.SubItems.Add("1")
            Else
                lvi.SubItems.Add("0")
            End If
            If Me.IncluirTelefone = True Then
                lvi.SubItems.Add("I")
            Else
                lvi.SubItems.Add("A")
            End If
            lvi.SubItems.Add(Me.txtFinalidadeTelefone.Text.Trim)
        Else
            Me.lstvTelefones.SelectedItems(0).SubItems(1).Text = Me.txtNumeroTelefone.Text.Trim
            Me.lstvTelefones.SelectedItems(0).SubItems(2).Text = Me.cboTipoTelefone.Text.Substring(0, 3).ToUpper
            If Me.chkTelefonePrincipal.Checked = True Then
                Me.lstvTelefones.SelectedItems(0).SubItems(3).Text = "1"
            Else
                Me.lstvTelefones.SelectedItems(0).SubItems(3).Text = "0"
            End If
            Me.lstvTelefones.SelectedItems(0).SubItems(4).Text = "A"
            Me.lstvTelefones.SelectedItems(0).SubItems(5).Text = Me.txtFinalidadeTelefone.Text.Trim
        End If

        Me.LimparEdicaoTelefone()
        MsgBox("Atenção, é necessário salvar o contato para guardar o Telefone.", MsgBoxStyle.Information)
        Me.grpEdicaoTelefone.Visible = False

    End Sub

End Class