Imports System.Data.SqlClient

Public Class Principal
    Private Sub SairToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub FuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionáriosToolStripMenuItem.Click
        Dim form = New Funcionarios
        form.ShowDialog()
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        Dim form = New Clientes
        form.ShowDialog()
    End Sub

    Private Sub ProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem.Click
        Dim form = New Produtos
        form.ShowDialog()
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsuario.Text = usuarioNome
        If (usuarioNome = "Admin") Then
            FuncionáriosToolStripMenuItem.Enabled = True
        End If

        Listar()
        totalizar()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = Now.ToLongTimeString()
        lblData.Text = Now.ToShortDateString()
    End Sub

    Private Sub RegistrarVendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarVendaToolStripMenuItem.Click
        Dim form = New Vendas
        form.ShowDialog()
    End Sub


    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As SqlCommand

        Try
            abrir()
            cmd = New SqlCommand("SELECT ven.id_vendas, ven.num_vendas, pro.nome, cli.nome, pro.valor, ven.quantidade, ven.valor, ven.funcionario, ven.data_venda, ven.id_produto, ven.id_cliente FROM vendas as ven INNER JOIN produtos as pro on ven.id_produto = pro.id_produto INNER JOIN clientes as cli on ven.id_cliente = cli.id_cliente where ven.data_venda = @data and ven.funcionario = @funcionario order by num_vendas desc", con)
            cmd.Parameters.AddWithValue("@data", Now.Date())
            cmd.Parameters.AddWithValue("@funcionario", usuarioNome)

            da = New SqlDataAdapter(cmd)
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

    Private Sub totalizar()
        Dim total As Decimal
        For Each lin As DataGridViewRow In dg.Rows
            total = total + lin.Cells(6).Value
        Next

        lblTotal.Text = total
    End Sub

    Private Sub Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub

    Private Sub Principal_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Listar()
    End Sub

    Private Sub ListaDeVendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeVendasToolStripMenuItem.Click
        Dim form = New ListaVendas
        form.ShowDialog()
    End Sub
End Class