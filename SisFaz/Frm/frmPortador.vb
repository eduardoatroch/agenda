Public Class frmPortador


    Private Sub frmPortador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PreencherComboBanco()
        Me.grpCheque.Enabled = False
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
                    Me.cboBanco.Items.Add(dtr(0) & " - " & dtr(1))
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
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarAgenciasDoBanco", cnn)
        Dim dtr As SqlClient.SqlDataReader

        Try

            Me.cboConta.Items.Clear()
            Me.cboAgencia.Items.Clear()

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
        Dim cnn As New SqlClient.SqlConnection(BancoDeDados.StringDeConexao)
        Dim cmd As New SqlClient.SqlCommand("spRetornarContasDaAgencia", cnn)
        Dim dtr As SqlClient.SqlDataReader

        Try

            Me.cboConta.Items.Clear()

            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@Agencia", SqlDbType.VarChar, 10, "Agencia")
                .Parameters(0).Value = Me.cboAgencia.Text.Trim
                cnn.Open()
                dtr = .ExecuteReader
                Do Until dtr.Read = False
                    Me.cboConta.Items.Add(dtr(1) & " - " & dtr(0)) 'Nº da conta + Código da Conta
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

    Private Sub chkEmitirCheque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEmitirCheque.CheckedChanged
        ValidarEmitirCheque()
    End Sub

    Private Sub ValidarEmitirCheque()
        If Me.chkEmitirCheque.Checked Then
            Me.grpCheque.Enabled = True
        Else
            Me.grpCheque.Enabled = False
        End If
    End Sub

    Private Sub chkChequeIndividual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkChequeIndividual.CheckedChanged
        ValidarChequeIndividual()
    End Sub

    Private Sub ValidarChequeIndividual()
        If Me.chkChequeIndividual.Checked Then
            Me.chkNominalFornecedor.Checked = True
            Me.txtNominativoCheque.Enabled = False
        Else
            Me.chkNominalFornecedor.Checked = False
            Me.txtNominativoCheque.Enabled = True
        End If
    End Sub

    Private Sub chkNominalFornecedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNominalFornecedor.CheckedChanged
        ValidarNominalFornecedor()
    End Sub

    Private Sub ValidarNominalFornecedor()
        If Me.chkNominalFornecedor.Checked Then
            Me.txtNominativoCheque.Enabled = False
        Else
            Me.txtNominativoCheque.Enabled = True
        End If
    End Sub

    Private Sub btnSelecionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelecionar.Click
        If ValidarNominativo() Then
            Me.Close()
        End If
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        If ValidarNominativo() Then
            Me.Close()
        End If
    End Sub

    Private Function ValidarNominativo() As Boolean
        If Me.chkNominalFornecedor.Checked = False Then
            If Me.txtNominativoCheque.Text.Trim = "" Then
                MsgBox("O cheque não vai ser nominal ao fornecedor," & Chr(13) & _
                       "então deve ser informado um Nominativo para o cheque", MsgBoxStyle.Exclamation)
                Return False
            Else
                Return True
            End If
        Else
            Return True
        End If
    End Function

End Class