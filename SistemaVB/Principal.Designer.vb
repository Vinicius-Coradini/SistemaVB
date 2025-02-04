<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarVendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeVendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrosToolStripMenuItem, Me.VendasToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1111, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastrosToolStripMenuItem
        '
        Me.CadastrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProdutosToolStripMenuItem, Me.FuncionáriosToolStripMenuItem, Me.ClienteToolStripMenuItem})
        Me.CadastrosToolStripMenuItem.Image = CType(resources.GetObject("CadastrosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CadastrosToolStripMenuItem.Name = "CadastrosToolStripMenuItem"
        Me.CadastrosToolStripMenuItem.Size = New System.Drawing.Size(108, 24)
        Me.CadastrosToolStripMenuItem.Text = "Cadastros"
        '
        'ProdutosToolStripMenuItem
        '
        Me.ProdutosToolStripMenuItem.Name = "ProdutosToolStripMenuItem"
        Me.ProdutosToolStripMenuItem.Size = New System.Drawing.Size(175, 26)
        Me.ProdutosToolStripMenuItem.Text = "Produtos"
        '
        'FuncionáriosToolStripMenuItem
        '
        Me.FuncionáriosToolStripMenuItem.Enabled = False
        Me.FuncionáriosToolStripMenuItem.Name = "FuncionáriosToolStripMenuItem"
        Me.FuncionáriosToolStripMenuItem.Size = New System.Drawing.Size(175, 26)
        Me.FuncionáriosToolStripMenuItem.Text = "Funcionários"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(175, 26)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'VendasToolStripMenuItem
        '
        Me.VendasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarVendaToolStripMenuItem, Me.ListaDeVendasToolStripMenuItem})
        Me.VendasToolStripMenuItem.Image = CType(resources.GetObject("VendasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VendasToolStripMenuItem.Name = "VendasToolStripMenuItem"
        Me.VendasToolStripMenuItem.Size = New System.Drawing.Size(90, 24)
        Me.VendasToolStripMenuItem.Text = "Vendas"
        '
        'RegistrarVendaToolStripMenuItem
        '
        Me.RegistrarVendaToolStripMenuItem.Name = "RegistrarVendaToolStripMenuItem"
        Me.RegistrarVendaToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.RegistrarVendaToolStripMenuItem.Text = "Registrar Venda"
        '
        'ListaDeVendasToolStripMenuItem
        '
        Me.ListaDeVendasToolStripMenuItem.Name = "ListaDeVendasToolStripMenuItem"
        Me.ListaDeVendasToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ListaDeVendasToolStripMenuItem.Text = "Lista de Vendas"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairToolStripMenuItem1})
        Me.SairToolStripMenuItem.Image = CType(resources.GetObject("SairToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'SairToolStripMenuItem1
        '
        Me.SairToolStripMenuItem1.Name = "SairToolStripMenuItem1"
        Me.SairToolStripMenuItem1.Size = New System.Drawing.Size(117, 26)
        Me.SairToolStripMenuItem1.Text = "Sair"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(93, 32)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(11, 15)
        Me.lblUsuario.TabIndex = 1
        Me.lblUsuario.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bem Vindo"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData.Location = New System.Drawing.Point(8, 59)
        Me.lblData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(11, 15)
        Me.lblData.TabIndex = 3
        Me.lblData.Text = "-"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Location = New System.Drawing.Point(93, 59)
        Me.lblHora.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(11, 15)
        Me.lblHora.TabIndex = 4
        Me.lblHora.Text = "-"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblHora)
        Me.GroupBox1.Controls.Add(Me.lblUsuario)
        Me.GroupBox1.Controls.Add(Me.lblData)
        Me.GroupBox1.Location = New System.Drawing.Point(895, 33)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(216, 92)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(45, 133)
        Me.dg.Margin = New System.Windows.Forms.Padding(4)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.RowHeadersWidth = 51
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(1005, 257)
        Me.dg.TabIndex = 97
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Vendas do dia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(860, 407)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Total Vendido"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.ForeColor = System.Drawing.Color.Green
        Me.lblTotal.Location = New System.Drawing.Point(965, 407)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(11, 16)
        Me.lblTotal.TabIndex = 100
        Me.lblTotal.Text = "-"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1111, 434)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CadastrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarVendaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDeVendasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblUsuario As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblData As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dg As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotal As Label
End Class
