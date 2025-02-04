Imports System.Data.SqlClient

Public Class Funcionarios
    Private Sub Funcionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesabilitarCampos()
        dtData.Value = Now
        btnSalvar.Enabled = False
        txtBuscarCPF.Visible = False


        Listar()

        btnEditar.Enabled = False
        btnExcluir.Enabled = False
        rbNome.Checked = True

    End Sub



    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("SELECT * FROM funcionarios", con)
            da.Fill(dt)
            dg.DataSource = dt

            ContarLinhas()
            FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar" + ex.Message)
            fechar()
        End Try

    End Sub

    Private Sub FormatarDG()
        dg.Columns(0).Visible = False
        dg.Columns(3).Visible = False

        dg.Columns(1).HeaderText = "Nome"
        dg.Columns(2).HeaderText = "Sexo"
        dg.Columns(3).HeaderText = "CPF"
        dg.Columns(4).HeaderText = "Endereço"
        dg.Columns(5).HeaderText = "Telefone"
        dg.Columns(6).HeaderText = "Email"
        dg.Columns(7).HeaderText = "Turno"
        dg.Columns(8).HeaderText = "Data Contratação"

        dg.Columns(6).Width = 130
        dg.Columns(7).Width = 80

    End Sub

    Private Sub DesabilitarCampos()
        txtNome.Enabled = False
        txtCPF.Enabled = False
        txtEndereco.Enabled = False
        txtTel.Enabled = False
        txtEmail.Enabled = False
        cbSexo.Enabled = False
        cbTurno.Enabled = False
        dtData.Enabled = False
    End Sub

    Private Sub HabilitarCampos()
        txtNome.Enabled = True
        txtCPF.Enabled = True
        txtEndereco.Enabled = True
        txtTel.Enabled = True
        txtEmail.Enabled = True
        cbSexo.Enabled = True
        cbTurno.Enabled = True
        dtData.Enabled = True
    End Sub

    Private Sub Limpar()
        txtNome.Focus()
        txtNome.Text = ""
        txtCPF.Text = ""
        txtEndereco.Text = ""
        txtTel.Text = ""
        txtEmail.Text = ""
        txtBuscar.Text = ""
        dtData.Value = Now
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        HabilitarCampos()
        Limpar()
        btnSalvar.Enabled = True
    End Sub

    Private Sub rbNome_CheckedChanged(sender As Object, e As EventArgs) Handles rbNome.CheckedChanged
        txtBuscarCPF.Text = ""
        txtBuscar.Text = ""
        txtBuscar.Visible = True
        txtBuscarCPF.Visible = False
        txtBuscar.Focus()
        Listar()
    End Sub

    Private Sub rbCPF_CheckedChanged(sender As Object, e As EventArgs) Handles rbCPF.CheckedChanged
        txtBuscar.Text = ""
        txtBuscarCPF.Text = ""
        txtBuscar.Visible = False
        txtBuscarCPF.Visible = True
        txtBuscarCPF.Focus()
        Listar()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Dim cmd As SqlCommand

        If txtCPF.Text <> "" And txtNome.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("sp_salvarfunc", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@nome", txtNome.Text)
                cmd.Parameters.AddWithValue("@sexo", cbSexo.Text)
                cmd.Parameters.AddWithValue("@cpf", txtCPF.Text)
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text)
                cmd.Parameters.AddWithValue("@telefone", txtTel.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@turno", cbTurno.Text)
                cmd.Parameters.AddWithValue("@data_contratado", dtData.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


                Listar()
                Limpar()

                btnSalvar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message)
                fechar()
            End Try
        End If

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim cmd As SqlCommand

        If txtCPF.Text <> "" And txtNome.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("sp_editarfunc", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@nome", txtNome.Text)
                cmd.Parameters.AddWithValue("@sexo", cbSexo.Text)
                cmd.Parameters.AddWithValue("@cpf", txtCPF.Text)
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text)
                cmd.Parameters.AddWithValue("@telefone", txtTel.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@turno", cbTurno.Text)
                cmd.Parameters.AddWithValue("@data_contratado", dtData.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


                Listar()
                Limpar()

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        btnEditar.Enabled = True
        btnExcluir.Enabled = True
        HabilitarCampos()
        txtCPF.Enabled = False

        txtNome.Text = dg.CurrentRow.Cells(1).Value
        cbSexo.Text = dg.CurrentRow.Cells(2).Value
        txtCPF.Text = dg.CurrentRow.Cells(3).Value
        txtEndereco.Text = dg.CurrentRow.Cells(4).Value
        txtTel.Text = dg.CurrentRow.Cells(5).Value
        txtEmail.Text = dg.CurrentRow.Cells(6).Value
        cbTurno.Text = dg.CurrentRow.Cells(7).Value
        dtData.Text = dg.CurrentRow.Cells(8).Value


    End Sub

    Private Sub txtBuscarCPF_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCPF.TextChanged
        If txtBuscarCPF.Text = "   .   .   -" And dg.Rows.Count > 0 Then
            Listar()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("sp_buscarFuncCpf", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@cpf", txtBuscarCPF.Text)

                da.Fill(dt)
                dg.DataSource = dt

                ContarLinhas()


            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message)
                fechar()
            End Try
        End If

    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dg.Rows.Count
        lblTotal.Text = CInt(total)

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text = "" And dg.Rows.Count > 0 Then

            Listar()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("sp_buscarFuncNome", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@nome", txtBuscar.Text)

                da.Fill(dt)
                dg.DataSource = dt

                ContarLinhas()


            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim cmd As SqlCommand

        If txtCPF.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("sp_excluirFunc", con)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@cpf", txtCPF.Text)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


                Listar()
                Limpar()

                btnExcluir.Enabled = False
                btnEditar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message)
                fechar()
            End Try
        End If
    End Sub
End Class