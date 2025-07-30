Public Class frmIncluirEditarTelefone
    Public flagCancelar As Boolean = False
    Private idContatoFone, codigoContato As Long
    Private incluir As Boolean

    Public Sub New(ByVal pIdContatoFone As Long, ByVal pIncluir As Boolean, ByVal pCodigoContato As Long)
        MyBase.New()
        InitializeComponent()
        Me.idContatoFone = pIdContatoFone
        Me.incluir = pIncluir
        Me.codigoContato = pCodigoContato
    End Sub

    Private Sub frmIncluirEditarTelefone_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.flagCancelar = False Then
            If Me.ValidarDigitacoes() = False Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Me.flagCancelar = False

        If Me.ValidarDigitacoes() = True Then
            Me.SalvarContatoTelefone()
            Me.Close()
        End If

    End Sub

    Private Sub SalvarContatoTelefone()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand '("spSalvarContatoTelefone", cnn)

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Connection = cnn
                .Parameters.Add("@CodigoContato", SqlDbType.Int, 4)
                .Parameters(0).Value = Me.codigoContato
                .Parameters.Add("@Numero", SqlDbType.VarChar, 20)
                .Parameters(1).Value = Me.txtNumeroTelefone.Text.Trim
                .Parameters.Add("@tipo", SqlDbType.Char, 3)
                .Parameters(2).Value = Me.cboTipo.Text.Substring(0, 3)
                .Parameters.Add("@principal", SqlDbType.Bit, 1)
                .Parameters(3).Value = CByte(Me.chkPrincipal.Checked)
                .Parameters.Add("@descricao", SqlDbType.VarChar, 30)
                .Parameters(4).Value = Me.txtDescricaoTelefone.Text.Trim
                If Me.incluir = False Then
                    .Parameters.Add("@idContatoFone", SqlDbType.SmallInt, 2)
                    .Parameters(5).Value = Me.idContatoFone
                    .CommandText = "spAlterarContatoTelefone"
                Else
                    .CommandText = "spIncluirContatoTelefone"
                End If
                cnn.Open()
                .ExecuteNonQuery()
                cnn.Close()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.flagCancelar = True
        Me.Close()
    End Sub

    Private Function ValidarDigitacoes() As Boolean
        Dim vRet As Boolean = True

        If Me.txtNumeroTelefone.Text.Trim <> "" Then
            If Me.cboTipo.Text.Trim = "Selecione" Or Me.cboTipo.Text.Trim = "" Then
                vRet = False
                MsgBox("Selecione o Tipo de Telefone", MsgBoxStyle.Exclamation)
            End If
        Else
            If Me.txtNumeroTelefone.Text.Trim = "" Then
                vRet = False
                MsgBox("Informe o Nº do Telefone", MsgBoxStyle.Exclamation)
            End If
            If Me.cboTipo.Text.Trim = "Selecione" Or Me.cboTipo.Text.Trim = "" Then
                vRet = False
                MsgBox("Selecione o Tipo de Telefone", MsgBoxStyle.Exclamation)
            End If
        End If

        Return vRet

    End Function

    Private Sub frmIncluirEditarTelefone_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Me.incluir = True Then
            Me.Text = "Incluir Telefone"
        Else
            Me.Text = "Alterar Telefone"
            Me.ExibirDadosTelefone()
        End If

    End Sub

    Private Sub ExibirDadosTelefone()

        ContatoTelefone.CarregarDadosContatoFone(Me.idContatoFone)

        Me.txtNumeroTelefone.Text = ContatoTelefone.DadosContatoFone.numeroTelefone.Trim
        Me.txtDescricaoTelefone.Text = ContatoTelefone.DadosContatoFone.descricaoTelefone.Trim

        If ContatoTelefone.DadosContatoFone.tipo = "CEL" Then
            Me.cboTipo.Text = "CELULAR"
        ElseIf ContatoTelefone.DadosContatoFone.tipo = "COM" Then
            Me.cboTipo.Text = "COMERCIAL"
        ElseIf ContatoTelefone.DadosContatoFone.tipo = "FAX" Then
            Me.cboTipo.Text = "FAX"
        ElseIf ContatoTelefone.DadosContatoFone.tipo = "REC" Then
            Me.cboTipo.Text = "RECADO"
        ElseIf ContatoTelefone.DadosContatoFone.tipo = "RES" Then
            Me.cboTipo.Text = "RESIDENCIAL"
        Else
            Me.cboTipo.Text = "COMERCIAL"
        End If

        If ContatoTelefone.DadosContatoFone.flagPrincipal = True Then
            Me.chkPrincipal.Checked = True
        Else
            Me.chkPrincipal.Checked = False
        End If

    End Sub

End Class