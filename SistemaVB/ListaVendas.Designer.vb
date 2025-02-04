Imports System.Data.SqlClient

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListaVendas
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
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.rbFuncionario = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbData = New System.Windows.Forms.RadioButton()
        Me.cbCliente = New System.Windows.Forms.ComboBox()
        Me.dt = New System.Windows.Forms.DateTimePicker()
        Me.cbFuncionario = New System.Windows.Forms.ComboBox()
        Me.rbCliente = New System.Windows.Forms.RadioButton()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(23, 75)
        Me.dg.Margin = New System.Windows.Forms.Padding(4)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.RowHeadersWidth = 51
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(990, 257)
        Me.dg.TabIndex = 97
        '
        'rbFuncionario
        '
        Me.rbFuncionario.AutoSize = True
        Me.rbFuncionario.Location = New System.Drawing.Point(653, 24)
        Me.rbFuncionario.Margin = New System.Windows.Forms.Padding(4)
        Me.rbFuncionario.Name = "rbFuncionario"
        Me.rbFuncionario.Size = New System.Drawing.Size(98, 20)
        Me.rbFuncionario.TabIndex = 104
        Me.rbFuncionario.TabStop = True
        Me.rbFuncionario.Text = "Funcionario"
        Me.rbFuncionario.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(490, 27)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Buscar:"
        '
        'rbData
        '
        Me.rbData.AutoSize = True
        Me.rbData.Location = New System.Drawing.Point(766, 25)
        Me.rbData.Margin = New System.Windows.Forms.Padding(4)
        Me.rbData.Name = "rbData"
        Me.rbData.Size = New System.Drawing.Size(57, 20)
        Me.rbData.TabIndex = 106
        Me.rbData.TabStop = True
        Me.rbData.Text = "Data"
        Me.rbData.UseVisualStyleBackColor = True
        '
        'cbCliente
        '
        Me.cbCliente.FormattingEnabled = True
        Me.cbCliente.Location = New System.Drawing.Point(842, 24)
        Me.cbCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Size = New System.Drawing.Size(171, 24)
        Me.cbCliente.TabIndex = 107
        '
        'dt
        '
        Me.dt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt.Location = New System.Drawing.Point(842, 27)
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(171, 22)
        Me.dt.TabIndex = 108
        Me.dt.Visible = False
        '
        'cbFuncionario
        '
        Me.cbFuncionario.FormattingEnabled = True
        Me.cbFuncionario.Location = New System.Drawing.Point(842, 24)
        Me.cbFuncionario.Margin = New System.Windows.Forms.Padding(4)
        Me.cbFuncionario.Name = "cbFuncionario"
        Me.cbFuncionario.Size = New System.Drawing.Size(171, 24)
        Me.cbFuncionario.TabIndex = 109
        Me.cbFuncionario.Visible = False
        '
        'rbCliente
        '
        Me.rbCliente.AutoSize = True
        Me.rbCliente.Location = New System.Drawing.Point(561, 25)
        Me.rbCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.rbCliente.Name = "rbCliente"
        Me.rbCliente.Size = New System.Drawing.Size(69, 20)
        Me.rbCliente.TabIndex = 110
        Me.rbCliente.TabStop = True
        Me.rbCliente.Text = "Cliente"
        Me.rbCliente.UseVisualStyleBackColor = True
        '
        'ListaVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1040, 384)
        Me.Controls.Add(Me.rbCliente)
        Me.Controls.Add(Me.cbFuncionario)
        Me.Controls.Add(Me.dt)
        Me.Controls.Add(Me.cbCliente)
        Me.Controls.Add(Me.rbData)
        Me.Controls.Add(Me.rbFuncionario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dg)
        Me.Name = "ListaVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ListaVendas"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dg As DataGridView
    Friend WithEvents rbFuncionario As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents rbData As RadioButton
    Friend WithEvents cbCliente As ComboBox
    Friend WithEvents dt As DateTimePicker
    Friend WithEvents cbFuncionario As ComboBox
    Friend WithEvents rbCliente As RadioButton

    Private Sub rbCliente_CheckedChanged(sender As Object, e As EventArgs) Handles rbCliente.CheckedChanged
        cbCliente.Text = ""
        cbFuncionario.Text = ""

        cbCliente.Visible = True
        cbFuncionario.Visible = False
        dt.Visible = False
    End Sub

    Private Sub rbFuncionario_CheckedChanged(sender As Object, e As EventArgs) Handles rbFuncionario.CheckedChanged
        cbCliente.Text = ""
        cbFuncionario.Text = ""

        cbFuncionario.Visible = True
        cbCliente.Visible = False
        dt.Visible = False
    End Sub

    Private Sub rbData_CheckedChanged(sender As Object, e As EventArgs) Handles rbData.CheckedChanged
        cbCliente.Text = ""
        cbFuncionario.Text = ""

        dt.Visible = True
        cbCliente.Visible = False
        cbFuncionario.Visible = False
    End Sub

    Private Sub ListaVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarFuncionarios()
        CarregarClientes()
    End Sub

    Private Sub CarregarFuncionarios()
        Dim DA As New SqlDataAdapter
        Dim DT As New DataTable

        Try
            DA = New SqlDataAdapter("SELECT * FROM funcionarios", con)
            DA.Fill(DT)
            cbFuncionario.DisplayMember = "nome"
            cbFuncionario.ValueMember = "id_fun"
            cbFuncionario.DataSource = DT
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar funcionario")
        End Try
    End Sub
    Private Sub CarregarClientes()
        Dim DA As New SqlDataAdapter
        Dim DT As New DataTable

        Try
            DA = New SqlDataAdapter("SELECT * FROM clientes", con)
            DA.Fill(DT)
            cbCliente.DisplayMember = "nome"
            cbCliente.ValueMember = "id_cliente"
            cbCliente.DataSource = DT
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar cliente")
        End Try
    End Sub

End Class
