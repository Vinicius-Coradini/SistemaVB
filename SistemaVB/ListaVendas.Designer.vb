<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaVendas
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
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.rbCPF = New System.Windows.Forms.RadioButton()
        Me.rbNome = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.cbCliente = New System.Windows.Forms.ComboBox()
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
        'rbCPF
        '
        Me.rbCPF.AutoSize = True
        Me.rbCPF.Location = New System.Drawing.Point(653, 24)
        Me.rbCPF.Margin = New System.Windows.Forms.Padding(4)
        Me.rbCPF.Name = "rbCPF"
        Me.rbCPF.Size = New System.Drawing.Size(98, 20)
        Me.rbCPF.TabIndex = 104
        Me.rbCPF.TabStop = True
        Me.rbCPF.Text = "Funcionario"
        Me.rbCPF.UseVisualStyleBackColor = True
        '
        'rbNome
        '
        Me.rbNome.AutoSize = True
        Me.rbNome.Location = New System.Drawing.Point(562, 24)
        Me.rbNome.Margin = New System.Windows.Forms.Padding(4)
        Me.rbNome.Name = "rbNome"
        Me.rbNome.Size = New System.Drawing.Size(69, 20)
        Me.rbNome.TabIndex = 103
        Me.rbNome.TabStop = True
        Me.rbNome.Text = "Cliente"
        Me.rbNome.UseVisualStyleBackColor = True
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
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(766, 25)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(57, 20)
        Me.RadioButton1.TabIndex = 106
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Data"
        Me.RadioButton1.UseVisualStyleBackColor = True
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
        'ListaVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1040, 384)
        Me.Controls.Add(Me.cbCliente)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.rbCPF)
        Me.Controls.Add(Me.rbNome)
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
    Friend WithEvents rbCPF As RadioButton
    Friend WithEvents rbNome As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents cbCliente As ComboBox
End Class
