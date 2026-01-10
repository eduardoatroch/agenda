Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO

Public Class frmContatos
    Private nomeArquivo As String = ""

    Private Sub frmContatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.PreencherListaContatos()

        If clsUsuario.DadosUsuario.TipoUsuario = "A" Then
            Me.btnUsuario.Visible = True
        Else
            Me.btnUsuario.Visible = False
        End If
        Me.txtPesquisar.Focus()
        Me.Text = "Agenda de Contatos - Versão: " & Application.ProductVersion

    End Sub

    'Private Sub frmContatos_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    '    If MessageBox.Show("Confirma sair?", "Sair", MessageBoxButtons.YesNo) = DialogResult.No Then
    '        Exit Sub
    '    End If
    'End Sub

    Private Sub btnLerXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLerXML.Click
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmdZerar As New SqlClient.SqlCommand("spZerarTabelaContatos", cnn)
        Dim cmdContato As New SqlClient.SqlCommand
        Dim cmdTelefone As New SqlClient.SqlCommand
        Dim cmdEmail As New SqlClient.SqlCommand
        Dim DS As New dsSalvarLerContatos
        Dim NomeArquivo As String
        Dim vCodigoContato As Long = 0
        Dim lvi As ListViewItem
        Dim vErro As Boolean = False

        Try

            If MessageBox.Show("Atenção, a leitura do XML apagará os Contatos atuais no Banco de Dados," & Chr(13) &
                               "e lançará os Contatos do XML." & Chr(13) &
                               "Vai continuar?", "Importar Contatos", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

            'Contatos
            OFD.Title = "Informe o nome do arquivo de Contatos."
            OFD.ShowDialog()
            NomeArquivo = OFD.FileName

            If NomeArquivo.Trim <> "" Then

                Dim FS As New FileStream(NomeArquivo, FileMode.Open)
                Dim xml As New Xml.XmlTextReader(FS)

                DS.ReadXml(xml, XmlReadMode.IgnoreSchema)
                FS.Close()
                xml.Close()

                Me.Cursor = Cursors.WaitCursor

                Me.lstvContatosLidosXML.Items.Clear()

                For I As Integer = 0 To DS.vwContatosXML.Count - 1
                    lvi = Me.lstvContatosLidosXML.Items.Add(DS.vwContatosXML(I).codigoContato.ToString)
                    lvi.SubItems.Add(DS.vwContatosXML(I).NomeContato)
                    lvi.SubItems.Add(DS.vwContatosXML(I).Endereco)
                    lvi.SubItems.Add(DS.vwContatosXML(I).Bairro)
                    lvi.SubItems.Add(DS.vwContatosXML(I).Cidade)
                    lvi.SubItems.Add(DS.vwContatosXML(I).UF)
                    lvi.SubItems.Add(DS.vwContatosXML(I).Cep)
                    lvi.SubItems.Add(DS.vwContatosXML(I).EnderecoEletronico)
                    lvi.SubItems.Add(DS.vwContatosXML(I).PessoaContato)
                    lvi.SubItems.Add(DS.vwContatosXML(I).Atividade)
                    lvi.SubItems.Add(DS.vwContatosXML(I).Observacoes)
                    lvi.SubItems.Add("0")
                Next

            Else
                vErro = True
                MsgBox("O nome do arquivo de Contatos deve ser informado," & Chr(13) & "leitura abortada.", MsgBoxStyle.Exclamation)
            End If

            'E-mails dos Contatos
            NomeArquivo = String.Empty
            OFD.Title = "Informe o nome do arquivo de E-mails dos Contatos."
            OFD.ShowDialog()
            NomeArquivo = OFD.FileName

            If NomeArquivo.Trim <> "" Then

                Dim FS As New FileStream(NomeArquivo, FileMode.Open)
                Dim xml As New Xml.XmlTextReader(FS)

                DS.ReadXml(xml, XmlReadMode.IgnoreSchema)
                FS.Close()
                xml.Close()

                Me.lstvEmails.Items.Clear()
                For I As Integer = 0 To DS.vwContatoEmailsXML.Count - 1
                    lvi = Me.lstvEmails.Items.Add("0")
                    lvi.SubItems.Add(DS.vwContatoEmailsXML(I).descricaoEmail)
                    lvi.SubItems.Add(DS.vwContatoEmailsXML(I).flagPrincipal)
                    lvi.SubItems.Add(DS.vwContatoEmailsXML(I).codigoContato.ToString)
                Next

            Else
                vErro = True
                MsgBox("O nome do arquivo de E-mails dos Contatos deve ser informado," & Chr(13) & "leitura abortada.", MsgBoxStyle.Exclamation)
            End If

            'Telefones dos Contatos
            NomeArquivo = String.Empty
            OFD.Title = "Informe o nome do arquivo de Telefones dos Contatos."
            OFD.ShowDialog()
            NomeArquivo = OFD.FileName

            If NomeArquivo.Trim <> "" Then

                Dim FS As New FileStream(NomeArquivo, FileMode.Open)
                Dim xml As New Xml.XmlTextReader(FS)

                DS.ReadXml(xml, XmlReadMode.IgnoreSchema)
                FS.Close()
                xml.Close()

                Me.lstvTelefones.Items.Clear()
                For I As Integer = 0 To DS.vwContatoTelefonesXML.Count - 1
                    lvi = Me.lstvTelefones.Items.Add("0")
                    lvi.SubItems.Add(DS.vwContatoTelefonesXML(I).numeroTelefone)
                    lvi.SubItems.Add(DS.vwContatoTelefonesXML(I).tipo)
                    lvi.SubItems.Add(DS.vwContatoTelefonesXML(I).flagPrincipal)
                    lvi.SubItems.Add(DS.vwContatoTelefonesXML(I).codigoContato.ToString)
                Next

            Else
                vErro = True
                MsgBox("O nome do arquivo de Telefones dos Contatos deve ser informado," & Chr(13) & "leitura abortada.", MsgBoxStyle.Exclamation)
            End If


            If vErro = False Then

                If MessageBox.Show("Confirma a gravação no Banco de Dados?", "Leitura do XML", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    MsgBox("Importação cancelada pelo usuário.", MsgBoxStyle.Information)
                    Exit Sub
                End If

                'Zerar Contatos/Telefones/Emails
                With cmdZerar
                    .CommandType = CommandType.StoredProcedure
                    cnn.Open()
                    .ExecuteNonQuery()
                    cnn.Close()
                End With

                'Salvar os Contatos no Banco de Dados
                With cmdContato
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .CommandText = "spIncluirContato"
                    For i As Integer = 0 To Me.lstvContatosLidosXML.Items.Count - 1
                        .Parameters.Clear()
                        .Parameters.Add("@Nome", SqlDbType.VarChar, 100)
                        .Parameters(0).Value = Me.lstvContatosLidosXML.Items(i).SubItems(1).Text.Trim
                        .Parameters.Add("@Endereco", SqlDbType.VarChar, 100)
                        .Parameters(1).Value = Me.lstvContatosLidosXML.Items(i).SubItems(2).Text.Trim
                        .Parameters.Add("@Bairro", SqlDbType.VarChar, 50)
                        .Parameters(2).Value = Me.lstvContatosLidosXML.Items(i).SubItems(3).Text.Trim
                        .Parameters.Add("@Cidade", SqlDbType.VarChar, 50)
                        .Parameters(3).Value = Me.lstvContatosLidosXML.Items(i).SubItems(4).Text.Trim
                        .Parameters.Add("@Uf", SqlDbType.Char, 2)
                        .Parameters(4).Value = Me.lstvContatosLidosXML.Items(i).SubItems(5).Text.Trim
                        .Parameters.Add("@Cep", SqlDbType.Char, 8)
                        .Parameters(5).Value = Me.lstvContatosLidosXML.Items(i).SubItems(6).Text.Trim
                        .Parameters.Add("@WWW", SqlDbType.VarChar, 200)
                        .Parameters(6).Value = Me.lstvContatosLidosXML.Items(i).SubItems(7).Text.Trim
                        .Parameters.Add("@Email", SqlDbType.VarChar, 200)
                        .Parameters(7).Value = Me.lstvContatosLidosXML.Items(i).SubItems(8).Text.Trim
                        .Parameters.Add("@PessoaContato", SqlDbType.VarChar, 150)
                        .Parameters(8).Value = Me.lstvContatosLidosXML.Items(i).SubItems(9).Text.Trim
                        .Parameters.Add("@Atividade", SqlDbType.VarChar, 200)
                        .Parameters(9).Value = Me.lstvContatosLidosXML.Items(i).SubItems(10).Text.Trim
                        .Parameters.Add("@Obs", SqlDbType.VarChar, 700)
                        .Parameters(10).Value = Me.lstvContatosLidosXML.Items(i).SubItems(11).Text.Trim
                        .Parameters.Add("@CodigoContato", SqlDbType.Int, 4)
                        .Parameters(11).Direction = ParameterDirection.Output
                        cnn.Open()
                        .ExecuteNonQuery()
                        cnn.Close()
                        Me.lstvContatosLidosXML.Items(i).SubItems(12).Text = CLng(.Parameters(11).Value).ToString 'salvando na lista o novo id do contato
                    Next
                End With

                'Salvando os Telefones do Contato
                With cmdTelefone
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .CommandText = "spSalvarContatoTelefone"
                    For i As Integer = 0 To Me.lstvTelefones.Items.Count - 1
                        vCodigoContato = Me.ObterNovoCodigoContato(CLng(Me.lstvTelefones.Items(i).SubItems(4).Text))
                        If vCodigoContato > 0 Then
                            .Parameters.Clear()
                            .Parameters.Add("@CodigoContato", SqlDbType.Int, 4)
                            .Parameters(0).Value = vCodigoContato
                            .Parameters.Add("@Numero", SqlDbType.VarChar, 20)
                            .Parameters(1).Value = Me.lstvTelefones.Items(i).SubItems(1).Text.Trim
                            .Parameters.Add("@tipo", SqlDbType.Char, 3)
                            .Parameters(2).Value = Me.lstvTelefones.Items(i).SubItems(2).Text.Trim.ToUpper
                            .Parameters.Add("@principal", SqlDbType.Bit, 1)
                            If CByte(Me.lstvTelefones.Items(i).SubItems(3).Text) = 1 Then
                                .Parameters(3).Value = 1
                            Else
                                .Parameters(3).Value = 0
                            End If
                            cnn.Open()
                            .ExecuteNonQuery()
                            cnn.Close()
                        End If
                    Next
                End With

                'Salvando os Emails do Contato
                With cmdEmail
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .CommandText = "spIncluirContatoEmail"
                    For j As Integer = 0 To Me.lstvEmails.Items.Count - 1
                        vCodigoContato = Me.ObterNovoCodigoContato(CLng(Me.lstvEmails.Items(j).SubItems(3).Text))
                        If vCodigoContato > 0 Then
                            .Parameters.Clear()
                            .Parameters.Add("@CodigoContato", SqlDbType.Int, 4)
                            .Parameters(0).Value = vCodigoContato
                            .Parameters.Add("@DescricaoEmail", SqlDbType.VarChar, 50)
                            .Parameters(1).Value = Me.lstvEmails.Items(j).SubItems(1).Text.Trim
                            .Parameters.Add("@Principal", SqlDbType.Bit, 1)
                            If CByte(Me.lstvEmails.Items(j).SubItems(2).Text) = 1 Then
                                .Parameters(2).Value = 1
                            Else
                                .Parameters(2).Value = 0
                            End If
                            cnn.Open()
                            .ExecuteNonQuery()
                            cnn.Close()
                        End If
                    Next
                End With

                Me.Cursor = Cursors.Arrow

                Me.PreencherListaContatos()
                Application.DoEvents()

                MsgBox("Importação concluída com sucesso.", MsgBoxStyle.Information)

            End If

        Catch ex As Exception
            MsgBox(ex.Source & Chr(13) & ex.Message)
        Finally
            cnn.Dispose()
            GC.Collect()
            Me.Cursor = Cursors.Arrow
        End Try
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Application.Exit()
    End Sub

    Private Sub PreencherListaContatos()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand
        Dim lvi As ListViewItem
        Dim dtr As SqlClient.SqlDataReader

        Try

            With cmd
                .CommandType = CommandType.Text
                .Connection = cnn

                If Me.rbPesqGeral.Checked Then
                    .CommandText = "select * from vwRetornarListaContatosNovo order by NomeContato"

                ElseIf Me.rbPesqNome.Checked Then

                    If Me.txtPesquisar.Text.Trim = "" Then
                        .CommandText = "select * from vwRetornarListaContatosNovo order by NomeContato"
                    Else
                        If Me.chkQualquerParteDoNome.Checked Then
                            .CommandText = "select * from vwRetornarListaContatosNovo where NomeContato like '%" & Me.txtPesquisar.Text.Trim & "%' order by NomeContato"
                        Else
                            .CommandText = "select * from vwRetornarListaContatosNovo where NomeContato like '" & Me.txtPesquisar.Text.Trim & "%' order by NomeContato"
                        End If
                    End If

                ElseIf Me.rbPesqAtividade.Checked Then

                    If Me.txtPesquisar.Text.Trim = "" Then
                        .CommandText = "select * from vwRetornarListaContatosNovo order by Atividade,NomeContato"
                    Else
                        If Me.chkQualquerParteDoNome.Checked Then
                            .CommandText = "select * from vwRetornarListaContatosNovo where Atividade like '%" & Me.txtPesquisar.Text.Trim & "%' order by Atividade,NomeContato"
                        Else
                            .CommandText = "select * from vwRetornarListaContatosNovo where Atividade like '" & Me.txtPesquisar.Text.Trim & "%' order by Atividade,NomeContato"
                        End If
                    End If

                End If

                Me.lstvContatos.Items.Clear()

                cnn.Open()
                dtr = .ExecuteReader
                While dtr.Read
                    lvi = Me.lstvContatos.Items.Add(dtr(0).ToString) 'Código
                    lvi.SubItems.Add(dtr(2).ToString) 'Nome do Contato
                    lvi.SubItems.Add(dtr(10).ToString) 'Atividade/Ocupação
                    lvi.SubItems.Add(dtr(12).ToString) 'Telefones
                    lvi.SubItems.Add("0") 'campo para guardar o código do contato na importação pelo XML
                    lvi.SubItems.Add(dtr(3).ToString) 'endereço
                    lvi.SubItems.Add(dtr(4).ToString) 'bairro
                    lvi.SubItems.Add(dtr(5).ToString) 'cidade
                    lvi.SubItems.Add(dtr(6).ToString) 'uf
                    lvi.SubItems.Add(dtr(7).ToString) 'cep
                    lvi.SubItems.Add(dtr(8).ToString) 'site
                    lvi.SubItems.Add(dtr(9).ToString) 'pessoa contato
                    lvi.SubItems.Add(dtr(11).ToString) 'observação
                    If CDate(dtr(13)) <> CDate("01/01/1900") Then
                        lvi.SubItems.Add(CDate(dtr(13)).ToShortDateString)
                    Else
                        lvi.SubItems.Add("")
                    End If
                    If dtr(15).ToString = "J" Then
                        lvi.SubItems.Add("Jurídica")
                    Else
                        lvi.SubItems.Add("Física")
                    End If
                End While
                dtr.Close()
                dtr = Nothing
                cnn.Close()
            End With

        Catch ex As Exception
            MsgBox(ex.Source & Chr(13) & ex.Message)
        Finally
            cnn.Dispose()
            GC.Collect()
        End Try

    End Sub

    Private Sub btnPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisar.Click
        Me.PreencherListaContatos()
    End Sub

    Private Sub txtPesquisar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPesquisar.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.PreencherListaContatos()
        End If
    End Sub

    Private Sub btnGerarXml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarXml.Click

        Me.GerarXML_Contatos()
        Me.GerarXML_ContatoTelefones()
        Me.GerarXML_ContatoEmail()

        MessageBox.Show("Geração do XML comcluída com sucesso.", "Exportar Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub GerarXML_Contatos()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim NomeArq As String

        SFD.Title = "Informe o Nome do arquivo para os Contatos."
        SFD.ShowDialog()

        NomeArq = SFD.FileName

        If NomeArq.Trim <> "" Then

            Dim DS As New dsSalvarLerContatos()
            Dim DA As SqlDataAdapter
            Dim sSQL As String

            sSQL = "select * from vwContatosXML order by NomeContato"

            DA = New SqlDataAdapter(sSQL, cnn)
            DA.Fill(DS, "vwContatosXML")

            If DS.vwContatosXML.Count = 0 Then
                MsgBox("Lista de Contatos está vazia!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            DS.WriteXml(NomeArq)

        Else
            MsgBox("Informe o nome do arquivo.", MsgBoxStyle.Critical, "Erro: Nome de arquivo inválido.")
        End If

    End Sub

    Private Sub GerarXML_ContatoTelefones()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim NomeArq As String

        SFD.Title = "Informe o Nome do arquivo para Telefones dos Contatos."
        SFD.ShowDialog()

        NomeArq = SFD.FileName

        If NomeArq.Trim <> "" Then

            Dim DS As New dsSalvarLerContatos()
            Dim DA As SqlDataAdapter
            Dim sSQL As String

            sSQL = "select * from vwContatoTelefonesXML order by codigoContato"

            DA = New SqlDataAdapter(sSQL, cnn)
            DA.Fill(DS, "vwContatoTelefonesXML")

            If DS.vwContatoTelefonesXML.Count = 0 Then
                MsgBox("Lista de Telefones de Contato está vazia!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            DS.WriteXml(NomeArq)

        Else
            MsgBox("Informe o nome do arquivo.", MsgBoxStyle.Critical, "Erro: Nome de arquivo inválido.")
        End If

    End Sub

    Private Sub GerarXML_ContatoEmail()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim NomeArq As String

        SFD.Title = "Informe o Nome do arquivo para Emails dos Contatos."
        SFD.ShowDialog()

        NomeArq = SFD.FileName

        If NomeArq.Trim <> "" Then

            Dim DS As New dsSalvarLerContatos()
            Dim DA As SqlDataAdapter
            Dim sSQL As String

            sSQL = "select * from vwContatoEmailsXML order by codigoContato"

            DA = New SqlDataAdapter(sSQL, cnn)
            DA.Fill(DS, "vwContatoEmailsXML")

            If DS.vwContatoEmailsXML.Count = 0 Then
                MsgBox("Lista de Emails de Contato está vazia!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            DS.WriteXml(NomeArq)

        Else
            MsgBox("Informe o nome do arquivo.", MsgBoxStyle.Critical, "Erro: Nome de arquivo inválido.")
        End If

    End Sub


    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click

        If Me.lstvContatos.SelectedItems.Count = 0 Then
            MsgBox("Selecione o Contato que deseja fazer alteraçções.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If Me.lstvContatos.SelectedItems.Count > 1 Then
            MsgBox("Só pode alterar um Contato po vez.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        clsContato.CarregarContato(Me.lstvContatos.SelectedItems(0).Text)

        Dim frm As New frmIncluirEditarContato(Me.lstvContatos.SelectedItems(0).Text, False)
        frm.ShowDialog()

        'Me.lstvContatos.SelectedItems(0).SubItems(1).Text = clsContato.DadosContato.Nome.Trim
        'Me.lstvContatos.SelectedItems(0).SubItems(2).Text = clsContato.DadosContato.Atividade.Trim
        'Me.lstvContatos.SelectedItems(0).SubItems(3).Text = clsContato.DadosContato.Telefones.Trim

    End Sub

    Private Sub btnIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncluir.Click

        Dim frm As New frmIncluirEditarContato(0, True)
        frm.ShowDialog()

        Me.PreencherListaContatos()

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        If Me.lstvContatos.SelectedItems.Count = 0 Then
            MsgBox("Você não selecionou o(s) Contato(s) que deseja excluir.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If MsgBox("ATENÇÃO, a exclusão de um Contato causa exclusão em cascata de seus Telefones e Emails" & Chr(13) & Chr(13) & "Confirma a exclusão do(s) Contato(s) selecionado(s) ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ExcluirContato()
            PreencherListaContatos()
        End If
    End Sub

    Private Sub ExcluirContato()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        'Dim cmd As New SqlClient.SqlCommand("spExcluirContato", cnn)
        Dim cmd As New SqlClient.SqlCommand("spExcluirContatoNovo", cnn)
        Dim I As Integer

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                For I = 0 To Me.lstvContatos.SelectedItems.Count - 1
                    .Parameters.Clear()
                    '.Parameters.Add("@CodigoContato", SqlDbType.Int, 4, "CodigoContato")
                    '.Parameters(0).Value = CLng(Me.lstvContatos.SelectedItems(I).Text)
                    .Parameters.Add("@idContato", SqlDbType.UniqueIdentifier)
                    .Parameters(0).Value = New Guid(Me.lstvContatos.SelectedItems(0).Text)
                    cnn.Open()
                    .ExecuteNonQuery()
                    cnn.Close()
                Next
            End With
        Catch ex As Exception
            MsgBox(ex.Source & Chr(13) & ex.Message)
        Finally
            cnn.Dispose()
            cmd.Dispose()
            GC.Collect()
        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim frm As New frmRelatorioContatos
        frm.ShowDialog()
    End Sub



    Private Sub lstvContatos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstvContatos.DoubleClick

        'clsContato.CarregarContato(CLng(Me.lstvContatos.SelectedItems(0).Text))
        clsContato.CarregarContato(Me.lstvContatos.SelectedItems(0).Text)

        Dim frm As New frmIncluirEditarContato(Me.lstvContatos.SelectedItems(0).Text, False)
        frm.ShowDialog()

        'Me.lstvContatos.SelectedItems(0).SubItems(1).Text = clsContato.DadosContato.Nome.Trim
        'Me.lstvContatos.SelectedItems(0).SubItems(3).Text = clsContato.DadosContato.Telefones.Trim

    End Sub

    Private Sub lstvContatos_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstvContatos.Leave
        clsRotinas.PintarLista(Me.lstvContatos)
    End Sub

    Private Sub lstvContatos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstvContatos.SelectedIndexChanged
        If Me.lstvContatos.SelectedItems.Count = 1 Then
            clsRotinas.PintarLista(Me.lstvContatos)
        End If
    End Sub

    Private Sub lstvContatos_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lstvContatos.ColumnClick
        If Me.lstvContatos.Sorting = SortOrder.Ascending Then
            Me.lstvContatos.Sorting = SortOrder.Descending
        Else
            Me.lstvContatos.Sorting = SortOrder.Ascending
        End If
        Me.lstvContatos.ListViewItemSorter = New ListViewItemComparer(e.Column, Me.lstvContatos.Sorting)
    End Sub


    Private Sub rbPesqNome_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.rbPesqNome.Checked Then
            Me.txtPesquisar.Focus()
        End If
    End Sub

    Private Sub rbPesqAtividade_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.rbPesqAtividade.Checked Then
            Me.txtPesquisar.Focus()
        End If
    End Sub

    Private Sub rbPesqGeral_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.rbPesqGeral.Checked Then
            Me.txtPesquisar.Text = ""
            Me.btnPesquisar.Focus()
        End If
    End Sub

    Private Sub frmContatos_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.lstvContatos.Width = Me.Width - 40
        Me.lstvContatos.Height = Me.Height - 200
    End Sub

    Private Function ObterNovoCodigoContato(ByVal pCodigoContato As Long) As Long
        Dim vCodigo As Long

        Try
            vCodigo = 0
            For i As Integer = 0 To Me.lstvContatosLidosXML.Items.Count - 1
                If CLng(Me.lstvContatosLidosXML.Items(i).Text) = pCodigoContato Then
                    vCodigo = CLng(Me.lstvContatosLidosXML.Items(i).SubItems(12).Text)
                    Exit For
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return vCodigo

    End Function

    Private Sub btnUsuario_Click(sender As Object, e As EventArgs) Handles btnUsuario.Click

        'Dim frmSenha As New frmSenhaGeral
        'frmSenha.ShowDialog()

        'If frmSenhaGeral.usuarioGeral.Trim = "" Then
        '    MessageBox.Show("Usuário não informado!", "Aviso", MessageBoxButtons.OK)
        '    Exit Sub
        'End If
        'If frmSenhaGeral.usuarioGeral.Trim.ToUpper <> "ADMIN" Then
        '    MsgBox("Acesso negado.", MsgBoxStyle.Exclamation)
        '    Exit Sub
        'Else
        '    If frmSenhaGeral.senhaGeral.Trim.ToUpper <> "ADMIN@1010" Then
        '        MsgBox("Acesso negado.", MsgBoxStyle.Exclamation)
        '        Exit Sub
        '    End If
        'End If

        Dim frm As New frmUsuarios
        frm.Show()
    End Sub

    Private Sub btnMigrarContatos_Click(sender As Object, e As EventArgs) Handles btnMigrarContatos.Click
        If clsUsuario.DadosUsuario.TipoUsuario = "A" Then
            If MessageBox.Show("Confirma a migracao dos Contatos para Contatos Novos?", "Migração", MessageBoxButtons.YesNo) = DialogResult.No Then
                MsgBox("Migração cancelada pelo usuário", MsgBoxStyle.Information)
                Exit Sub
            End If
        Else
            MsgBox("Opção disponível apenas para usuário administrador", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Me.MigrarContatos()
    End Sub

    Private Sub MigrarContatos()
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmdContato As New SqlCommand("spIncluirContatoNovo", cnn)
        Dim cmdTelefone As New SqlCommand("spIncluirContatoFoneNovo", cnn)
        Dim cmdEmail As New SqlCommand("spIncluirContatoEmailNovo", cnn)
        Dim idContato As Guid
        Dim idContatoFone As Guid
        Dim idContatoEmail As Guid

        Try
            With cmdTelefone
                .CommandType = CommandType.StoredProcedure
            End With
            With cmdEmail
                .CommandType = CommandType.StoredProcedure
            End With

            With cmdContato
                .CommandType = CommandType.StoredProcedure
                For i As Integer = 0 To Me.lstvContatos.Items.Count - 1

                    'Me.PreencherContatoFone(CLng(Me.lstvContatos.Items(i).Text))
                    'Me.PreencherContatoEmail(CLng(Me.lstvContatos.Items(i).Text))

                    idContato = Guid.NewGuid

                    .Parameters.Clear()

                    .Parameters.Add("@idContato", SqlDbType.UniqueIdentifier)
                    .Parameters(0).Value = idContato
                    .Parameters.Add("@CodigoContato", SqlDbType.Int, 4)
                    .Parameters(1).Value = CLng(Me.lstvContatos.Items(i).Text)
                    .Parameters.Add("@NomeContato", SqlDbType.VarChar, 100)
                    .Parameters(2).Value = Me.lstvContatos.Items(i).SubItems(1).Text.Trim
                    .Parameters.Add("@Endereco", SqlDbType.VarChar, 100)
                    .Parameters(3).Value = Me.lstvContatos.Items(i).SubItems(5).Text.Trim
                    .Parameters.Add("@Bairro", SqlDbType.VarChar, 50)
                    .Parameters(4).Value = Me.lstvContatos.Items(i).SubItems(6).Text.Trim
                    .Parameters.Add("@Cidade", SqlDbType.VarChar, 50)
                    .Parameters(5).Value = Me.lstvContatos.Items(i).SubItems(7).Text.Trim
                    .Parameters.Add("@UF", SqlDbType.Char, 2)
                    .Parameters(6).Value = Me.lstvContatos.Items(i).SubItems(8).Text.Trim
                    .Parameters.Add("@Cep", SqlDbType.Char, 8)
                    .Parameters(7).Value = Me.lstvContatos.Items(i).SubItems(9).Text.Trim
                    .Parameters.Add("@Site", SqlDbType.VarChar, 200)
                    .Parameters(8).Value = Me.lstvContatos.Items(i).SubItems(10).Text.Trim
                    .Parameters.Add("@PssoaContato", SqlDbType.VarChar, 150)
                    .Parameters(9).Value = Me.lstvContatos.Items(i).SubItems(11).Text.Trim
                    .Parameters.Add("@Atividade", SqlDbType.VarChar, 200)
                    .Parameters(10).Value = Me.lstvContatos.Items(i).SubItems(2).Text.Trim
                    .Parameters.Add("@Observacao", SqlDbType.VarChar, 1000)
                    .Parameters(11).Value = Me.lstvContatos.Items(i).SubItems(12).Text.Trim
                    .Parameters.Add("@DataNascimentoFundacao", SqlDbType.DateTime, 8)
                    If Me.lstvContatos.Items(i).SubItems(13).Text.Trim <> "" Then
                        .Parameters(12).Value = CDate(Me.lstvContatos.Items(i).SubItems(13).Text.Trim)
                    End If
                    .Parameters.Add("@TipoPessoaFisicaJuridica", SqlDbType.Char, 1)
                    .Parameters(13).Value = ""
                    cnn.Open()
                    .ExecuteNonQuery()
                    cnn.Close()

                    'Incluir os Telefones
                    If Me.lstvTelefones.Items.Count > 0 Then
                        With cmdTelefone
                            For t As Integer = 0 To Me.lstvTelefones.Items.Count - 1
                                .Parameters.Clear()
                                idContatoFone = Guid.NewGuid
                                .Parameters.Add("@idContatoFone", SqlDbType.UniqueIdentifier)
                                .Parameters(0).Value = idContatoFone
                                .Parameters.Add("@idContato", SqlDbType.UniqueIdentifier)
                                .Parameters(1).Value = idContato
                                .Parameters.Add("@NumeroTelefone", SqlDbType.VarChar, 20)
                                .Parameters(2).Value = Me.lstvTelefones.Items(t).SubItems(1).Text.Trim
                                .Parameters.Add("@Tipo", SqlDbType.Char, 3)
                                .Parameters(3).Value = Me.lstvTelefones.Items(t).SubItems(2).Text.Substring(0, 3)
                                .Parameters.Add("@FlagPrncipal", SqlDbType.Bit, 1)
                                .Parameters(4).Value = CByte(Me.lstvTelefones.Items(t).SubItems(3).Text.Trim)
                                .Parameters.Add("@Descricao", SqlDbType.VarChar, 50)
                                .Parameters(5).Value = Me.lstvTelefones.Items(t).SubItems(5).Text.Trim
                                cnn.Open()
                                .ExecuteNonQuery()
                                cnn.Close()
                            Next
                        End With
                    End If

                    'Incluir os Emails
                    If Me.lstvEmails.Items.Count > 0 Then
                        With cmdEmail
                            For e As Integer = 0 To Me.lstvEmails.Items.Count - 1
                                .Parameters.Clear()
                                idContatoEmail = Guid.NewGuid
                                .Parameters.Add("@idContatoEmail", SqlDbType.UniqueIdentifier)
                                .Parameters(0).Value = idContatoEmail
                                .Parameters.Add("@idContato", SqlDbType.UniqueIdentifier)
                                .Parameters(1).Value = idContato
                                .Parameters.Add("@Email", SqlDbType.VarChar, 50)
                                .Parameters(2).Value = Me.lstvEmails.Items(e).SubItems(1).Text.Trim.ToLower
                                .Parameters.Add("@FlagPrincipal", SqlDbType.Bit, 1)
                                .Parameters(3).Value = CByte(Me.lstvEmails.Items(e).SubItems(2).Text)
                                cnn.Open()
                                .ExecuteNonQuery()
                                cnn.Close()
                            Next
                        End With
                    End If
                Next
            End With

            MsgBox("Migração concluída com sucesso!", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub PreencherContatoFone(ByVal pCodigoContato As Long)
    '    Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
    '    Dim cmd As New SqlCommand
    '    Dim dtr As SqlClient.SqlDataReader
    '    Dim lvi As ListViewItem

    '    Try
    '        Me.lstvTelefones.Items.Clear()
    '        With cmd
    '            .CommandType = CommandType.Text
    '            .Connection = cnn
    '            .CommandText = "select * from ContatoFone where CodigoContato=" & pCodigoContato.ToString
    '            cnn.Open()
    '            dtr = .ExecuteReader
    '            While dtr.Read
    '                lvi = Me.lstvTelefones.Items.Add("0") 'idcontatofone
    '                lvi.SubItems.Add(dtr(2).ToString) 'telefone
    '                lvi.SubItems.Add(dtr(3).ToString) 'tipo
    '                If CBool(dtr(4)) = True Then
    '                    lvi.SubItems.Add("1")
    '                Else
    '                    lvi.SubItems.Add("0")
    '                End If
    '                lvi.SubItems.Add("0") 'contato
    '                lvi.SubItems.Add(dtr(5).ToString) 'descrição
    '                lvi.SubItems.Add("") 'comando
    '            End While
    '            dtr.Close()
    '            cnn.Close()
    '        End With
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Sub PreencherContatoEmail(ByVal pCodigoContato As Long)
    '    Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
    '    Dim cmd As New SqlCommand
    '    Dim dtr As SqlClient.SqlDataReader
    '    Dim lvi As ListViewItem

    '    Try
    '        Me.lstvEmails.Items.Clear()
    '        With cmd
    '            .CommandType = CommandType.Text
    '            .Connection = cnn
    '            .CommandText = "select * from ContatoEmail where CodigoContato=" & pCodigoContato.ToString
    '            cnn.Open()
    '            dtr = .ExecuteReader
    '            While dtr.Read
    '                lvi = Me.lstvEmails.Items.Add("0") 'idcontatoemail
    '                lvi.SubItems.Add(dtr(2).ToString) 'email
    '                If CBool(dtr(3)) = True Then
    '                    lvi.SubItems.Add("1")
    '                Else
    '                    lvi.SubItems.Add("0")
    '                End If
    '                lvi.SubItems.Add("0") 'contato
    '            End While
    '            dtr.Close()
    '            cnn.Close()
    '        End With
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

End Class