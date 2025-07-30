Public Class frmPrincipal
    Private Versao As String

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim frm As New frmLogon

        frm.ShowDialog()

        If frm.txtUsuario.Text.Trim = "" Then
            Me.Close()
        End If

        Me.lblUsuario.Text = frm.txtUsuario.Text.Trim 'clsRotinas.NomeDoUsuario

        If clsRotinas.BancoSelecionado = "P" Then
            Me.lblBancoEscolhido.Text = "Banco de produção"
        Else
            Me.lblBancoEscolhido.Text = "Banco de desenvolv."
        End If

        Me.Versao = My.Application.Info.Version.ToString
        Me.Text = "Sistema de Controle das Fazendas - v" & Me.Versao

    End Sub

    Private Sub FazendasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FazendasToolStripMenuItem1.Click
        Dim frm As New frmUsuarios
        frm.ShowDialog()
    End Sub

    Private Sub FazendasToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FazendasToolStripMenuItem2.Click
        Dim frm As New frmFazendas
        frm.ShowDialog()
    End Sub

    Private Sub TiposDeDocumentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiposDeDocumentoToolStripMenuItem.Click
        Dim frm As New frmTipoDocumento
        frm.ShowDialog()
    End Sub

    Private Sub FormasDePagamentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormasDePagamentoToolStripMenuItem.Click
        Dim frm As New frmFormasPagamento
        frm.ShowDialog()
    End Sub

    Private Sub FornecedoresToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FornecedoresToolStripMenuItem1.Click
        Dim frm As New frmFornecedores
        frm.ShowDialog()
    End Sub


    Private Sub BancosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BancosToolStripMenuItem1.Click
        Dim frm As New frmBancos
        frm.ShowDialog()
    End Sub

    Private Sub AgênciasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgênciasToolStripMenuItem1.Click
        Dim frm As New frmAgencias
        frm.ShowDialog()
    End Sub

    Private Sub ContasBancáriasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContasBancáriasToolStripMenuItem.Click
        Dim frm As New frmContasBancarias
        frm.ShowDialog()
    End Sub

    Private Sub MovimentoDeTítulosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimentoDeTítulosToolStripMenuItem.Click
        Dim frm As New frmTitulos
        frm.ShowDialog()
    End Sub

    Private Sub MovimentoDeChequesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimentoDeChequesToolStripMenuItem1.Click
        Dim frm As New frmCheques
        frm.ShowDialog()
    End Sub

    Private Sub TítuloAPagarAgrupadosPorVencimentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TítuloAPagarAgrupadosPorVencimentoToolStripMenuItem.Click
        Dim frm As New frmRptTitulosPagarVencimento
        frm.ShowDialog()
    End Sub

    Private Sub TítulosPagosAgrupadosPorDataDePagamentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TítulosPagosAgrupadosPorDataDePagamentoToolStripMenuItem.Click
        Dim frm As New frmRptTitulosPagoPorDataPagamento
        frm.ShowDialog()
    End Sub

    Private Sub TítulosAPagarAgrupadosPorFornecedorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TítulosAPagarAgrupadosPorFornecedorToolStripMenuItem1.Click
        Dim frm As New frmRptTitulosAbertoPorFornecedor
        frm.ShowDialog()
    End Sub

    Private Sub TítulosPagosAgrupadosPorForToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TítulosPagosAgrupadosPorForToolStripMenuItem.Click
        Dim frm As New frmRptTitulosPagosPorFornecedor
        frm.ShowDialog()
    End Sub

    Private Sub RelaçãoDeChequesEmitidosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelaçãoDeChequesEmitidosToolStripMenuItem.Click
        Dim frm As New frmRptChequesEmitidos
        frm.ShowDialog()
    End Sub

    Private Sub MovimentoDoCaixaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimentoDoCaixaToolStripMenuItem1.Click
        Dim frm As New frmMovimentoCaixa
        frm.ShowDialog()
    End Sub

    Private Sub SairToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem2.Click
        Me.Close()
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem1.Click
        Dim frm As New frmCadastroCliente
        frm.ShowDialog()
    End Sub

    Private Sub VendaDeBoiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendaDeBoiToolStripMenuItem.Click
        Dim frm As New frmVendas
        frm.ShowDialog()
    End Sub

    Private Sub TítulosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TítulosToolStripMenuItem1.Click
        Dim frm As New frmTitulosReceber
        frm.ShowDialog()
    End Sub

    Private Sub MovimentoDoCaixaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimentoDoCaixaToolStripMenuItem2.Click
        Dim frm As New frmRptMovimentoCaixa
        frm.ShowDialog()
    End Sub

    Private Sub ImpressãoDeBoletosBancáriosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImpressãoDeBoletosBancáriosToolStripMenuItem.Click
        Dim frm As New frmRptBoletos
        frm.ShowDialog()
    End Sub

    Private Sub frmPrincipal_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.pbTelaInicial.Height = Me.Height - 20
        Me.pbTelaInicial.Width = Me.Width - 10
    End Sub
End Class
