<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vendas
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vendas))
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbProduto = New System.Windows.Forms.ComboBox()
        Me.cbCliente = New System.Windows.Forms.ComboBox()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEstoque = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(109, 6)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(53, 22)
        Me.txtCodigo.TabIndex = 104
        Me.txtCodigo.Visible = False
        '
        'txtValor
        '
        Me.txtValor.Enabled = False
        Me.txtValor.Location = New System.Drawing.Point(473, 127)
        Me.txtValor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(168, 22)
        Me.txtValor.TabIndex = 90
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(403, 132)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 16)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Valor:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(947, 446)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 16)
        Me.Label11.TabIndex = 102
        Me.Label11.Text = "Total"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(996, 446)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(11, 16)
        Me.lblTotal.TabIndex = 101
        Me.lblTotal.Text = "-"
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.Transparent
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.Location = New System.Drawing.Point(680, 447)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(87, 79)
        Me.btnExcluir.TabIndex = 100
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.Transparent
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.FlatAppearance.BorderSize = 0
        Me.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.Location = New System.Drawing.Point(530, 452)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(80, 74)
        Me.btnSalvar.TabIndex = 98
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.Transparent
        Me.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovo.FlatAppearance.BorderSize = 0
        Me.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.Location = New System.Drawing.Point(380, 452)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(80, 74)
        Me.btnNovo.TabIndex = 97
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(43, 172)
        Me.dg.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.RowHeadersWidth = 51
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(1005, 257)
        Me.dg.TabIndex = 96
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(716, 70)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Cliente:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(172, 127)
        Me.txtQuantidade.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(149, 22)
        Me.txtQuantidade.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(77, 132)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "Quantidade:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(403, 73)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Produto:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(780, 15)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(171, 22)
        Me.txtBuscar.TabIndex = 92
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(715, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Buscar:"
        '
        'cbProduto
        '
        Me.cbProduto.FormattingEnabled = True
        Me.cbProduto.Location = New System.Drawing.Point(473, 66)
        Me.cbProduto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbProduto.Name = "cbProduto"
        Me.cbProduto.Size = New System.Drawing.Size(171, 24)
        Me.cbProduto.TabIndex = 1
        '
        'cbCliente
        '
        Me.cbCliente.FormattingEnabled = True
        Me.cbCliente.Location = New System.Drawing.Point(780, 66)
        Me.cbCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Size = New System.Drawing.Size(171, 24)
        Me.cbCliente.TabIndex = 2
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(172, 69)
        Me.txtNum.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(149, 22)
        Me.txtNum.TabIndex = 105
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(80, 73)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 16)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Núm Venda:"
        '
        'txtEstoque
        '
        Me.txtEstoque.Enabled = False
        Me.txtEstoque.Location = New System.Drawing.Point(780, 128)
        Me.txtEstoque.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEstoque.Name = "txtEstoque"
        Me.txtEstoque.Size = New System.Drawing.Size(171, 22)
        Me.txtEstoque.TabIndex = 107
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(707, 132)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 16)
        Me.Label6.TabIndex = 108
        Me.Label6.Text = "Estoque:"
        '
        'Vendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1104, 554)
        Me.Controls.Add(Me.txtEstoque)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbCliente)
        Me.Controls.Add(Me.cbProduto)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Vendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendas"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents dg As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbProduto As ComboBox
    Friend WithEvents cbCliente As ComboBox
    Friend WithEvents txtNum As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEstoque As TextBox
    Friend WithEvents Label6 As Label
End Class
