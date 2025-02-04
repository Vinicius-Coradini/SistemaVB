Imports System.Data.SqlClient

Public Class Vendas
    Private Sub Vendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesabilitarCampos()

        btnSalvar.Enabled = False

        CarregarProdutos()
        CarregarClientes()

        Listar()

        btnExcluir.Enabled = False
        totalizar()

    End Sub


    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("SELECT ven.id_vendas, ven.num_vendas, pro.nome, cli.nome, pro.valor, ven.quantidade, ven.valor, ven.funcionario, ven.data_venda, ven.id_produto, ven.id_cliente FROM vendas as ven INNER JOIN produtos as pro on ven.id_produto = pro.id_produto INNER JOIN clientes as cli on ven.id_cliente = cli.id_cliente order by num_vendas desc", con)
            da.Fill(dt)
            dg.DataSource = dt


            FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar" + ex.Message)
            fechar()
        End Try

    End Sub

    Private Sub FormatarDG()
        dg.Columns(0).Visible = False
        dg.Columns(9).Visible = False
        dg.Columns(10).Visible = False

        dg.Columns(1).HeaderText = "Núm Venda"
        dg.Columns(2).HeaderText = "Produto"
        dg.Columns(3).HeaderText = "Cliente"
        dg.Columns(4).HeaderText = "Valor Unit"
        dg.Columns(5).HeaderText = "Quantidade"
        dg.Columns(6).HeaderText = "Valor Total"
        dg.Columns(7).HeaderText = "Funcionário"
        dg.Columns(8).HeaderText = "Data Venda"


        dg.Columns(4).Width = 80
        dg.Columns(5).Width = 80
        dg.Columns(6).Width = 90

    End Sub

    Private Sub DesabilitarCampos()
        txtNum.Enabled = False
        txtQuantidade.Enabled = False
        cbCliente.Enabled = False
        cbProduto.Enabled = False


    End Sub

    Private Sub HabilitarCampos()
        txtNum.Enabled = True
        txtQuantidade.Enabled = True
        cbCliente.Enabled = True
        cbProduto.Enabled = True


    End Sub

    Private Sub Limpar()
        txtNum.Focus()
        txtNum.Text = ""
        txtQuantidade.Text = ""

        txtBuscar.Text = ""

    End Sub

    Sub CarregarProdutos()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("SELECT * FROM produtos", con)
            DA.Fill(DT)
            cbProduto.DisplayMember = "nome"
            cbProduto.ValueMember = "id_produto"
            Debug.Print(cbProduto.SelectedValue)
            cbProduto.DataSource = DT
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        fechar()
    End Sub


    Sub CarregarClientes()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("SELECT * FROM clientes", con)
            DA.Fill(DT)
            cbCliente.DisplayMember = "nome"
            cbCliente.ValueMember = "id_cliente"
            cbCliente.DataSource = DT
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        fechar()
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        HabilitarCampos()
        Limpar()
        atualizarNumeroVenda()
        btnSalvar.Enabled = True
    End Sub

    Private Sub atualizarNumeroVenda()
        Dim cmd As New SqlCommand("sp_buscarNumVenda", con)

        Try
            abrir()
            cmd.CommandType = 4
            cmd.Parameters.Add("@num_venda", SqlDbType.Int).Direction = 2
            cmd.ExecuteNonQuery()

            Dim num As Integer = cmd.Parameters("@num_venda").Value

            txtNum.Text = CStr(num + 1)

        Catch ex As Exception
            MessageBox.Show("Erro ao encontrar ultima venda", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProduto.SelectedIndexChanged
        atualizarValor()
    End Sub

    Private Sub atualizarValor()
        Dim cmd As New SqlCommand("sp_buscarValorProd", con)
        Try
            abrir()
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
            cmd.Parameters.Add("@valor", SqlDbType.Decimal).Direction = 2
            cmd.Parameters.Add("@quant", SqlDbType.Int).Direction = 2
            cmd.ExecuteNonQuery()

            Dim valor As Decimal = cmd.Parameters("@valor").Value
            txtValor.Text = CStr(valor)

            Dim quant As Int32 = cmd.Parameters("@quant").Value
            txtEstoque.Text = CStr(quant)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        fechar()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim cmd As SqlCommand
        Dim atualizarEstoqueCmd As SqlCommand


        Dim quantidade As Decimal
        Dim estoque As Decimal
        Dim totalEstoque As Decimal

        quantidade = txtQuantidade.Text
        estoque = txtEstoque.Text
        totalEstoque = estoque - quantidade


        If txtNum.Text <> "" And totalEstoque >= 0 Then
            Dim total As Decimal
            Dim valor As Decimal
            Dim quant As Decimal

            valor = txtValor.Text
            quant = txtQuantidade.Text

            total = valor * quant

            Try
                abrir()
                cmd = New SqlCommand("sp_salvarvenda", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@num_vendas", txtNum.Text)
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.Parameters.AddWithValue("@id_cliente", cbCliente.SelectedValue)
                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
                cmd.Parameters.AddWithValue("@valor", total)
                cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
                cmd.Parameters.AddWithValue("@data_venda", Now.Date())

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString

                atualizarEstoqueCmd = New SqlCommand("sp_EditarEstoquePro", con)
                atualizarEstoqueCmd.CommandType = CommandType.StoredProcedure
                atualizarEstoqueCmd.Parameters.AddWithValue("@quantidade", totalEstoque)
                atualizarEstoqueCmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                txtEstoque.Text = totalEstoque
                atualizarEstoqueCmd.ExecuteNonQuery()
                atualizarValor()

                'Listar()
                BuscarVenda()
                totalizar()

                cbCliente.Enabled = False
                txtNum.Enabled = False

                txtQuantidade.Text = ""

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message)
                fechar()
            End Try
        Else
            MessageBox.Show("Quantidade indisponível em estoque")
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs)
        Dim cmd As SqlCommand

        If txtNum.Text <> "" Then

            Dim total As Decimal
            Dim valor As Decimal
            Dim quant As Decimal

            valor = txtValor.Text
            quant = txtQuantidade.Text

            total = valor * quant

            Try
                abrir()
                cmd = New SqlCommand("sp_editarvenda", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id_vendas", txtCodigo.Text)
                cmd.Parameters.AddWithValue("@num_vendas", txtNum.Text)
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)

                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
                cmd.Parameters.AddWithValue("@valor", total)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


                Listar()
                Limpar()
                totalizar()

            Catch ex As Exception
                MessageBox.Show("Erro ao editar os dados" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim cmd As SqlCommand
        Dim atualizarEstoqueCmd As SqlCommand

        Dim quantidade As Decimal
        Dim estoque As Decimal
        Dim totalEstoque As Decimal

        quantidade = txtQuantidade.Text
        estoque = txtEstoque.Text
        totalEstoque = estoque + quantidade

        If txtCodigo.Text <> "" Then

            Try
                abrir()
                atualizarEstoqueCmd = New SqlCommand("sp_EditarEstoquePro", con)
                atualizarEstoqueCmd.CommandType = CommandType.StoredProcedure
                atualizarEstoqueCmd.Parameters.AddWithValue("@quantidade", totalEstoque)
                atualizarEstoqueCmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                txtEstoque.Text = totalEstoque
                atualizarEstoqueCmd.ExecuteNonQuery()

                cmd = New SqlCommand("sp_excluirVenda", con)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@id_vendas", txtCodigo.Text)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                atualizarValor()

                Listar()
                Limpar()
                totalizar()

                btnExcluir.Enabled = False
            Catch ex As Exception
                MessageBox.Show("Erro ao excluir os dados" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        btnExcluir.Enabled = True
        HabilitarCampos()

        txtCodigo.Text = dg.CurrentRow.Cells(0).Value
        txtNum.Text = dg.CurrentRow.Cells(1).Value
        cbProduto.SelectedValue = dg.CurrentRow.Cells(9).Value
        cbCliente.SelectedValue = dg.CurrentRow.Cells(10).Value
        txtQuantidade.Text = CInt(dg.CurrentRow.Cells(5).Value)



    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text = "" And dg.Rows.Count > 0 Then
            Listar()
            totalizar()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("sp_buscarVenda", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@num_vendas", txtBuscar.Text)

                da.Fill(dt)
                Debug.Print(dt.ToString())
                dg.DataSource = dt


                totalizar()


            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub BuscarVenda()
        If txtNum.Text = "" Then
            Listar()
            totalizar()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("sp_buscarVenda", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@num_vendas", txtNum.Text)

                da.Fill(dt)
                dg.DataSource = dt


                totalizar()


            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub totalizar()
        Dim total As Decimal
        For Each lin As DataGridViewRow In dg.Rows
            total = total + lin.Cells(6).Value
        Next

        lblTotal.Text = total
    End Sub

    Private Sub txtEstoque_TextChanged(sender As Object, e As EventArgs) Handles txtEstoque.TextChanged

    End Sub
End Class