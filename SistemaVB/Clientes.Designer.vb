<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtBuscarCPF = New System.Windows.Forms.MaskedTextBox()
        Me.rbCPF = New System.Windows.Forms.RadioButton()
        Me.rbNome = New System.Windows.Forms.RadioButton()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.txtCPF = New System.Windows.Forms.MaskedTextBox()
        Me.txtTel = New System.Windows.Forms.MaskedTextBox()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(728, 363)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "Total"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(767, 363)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(10, 13)
        Me.lblTotal.TabIndex = 59
        Me.lblTotal.Text = "-"
        '
        'txtBuscarCPF
        '
        Me.txtBuscarCPF.Location = New System.Drawing.Point(607, 27)
        Me.txtBuscarCPF.Mask = "999,999,999-99"
        Me.txtBuscarCPF.Name = "txtBuscarCPF"
        Me.txtBuscarCPF.Size = New System.Drawing.Size(129, 20)
        Me.txtBuscarCPF.TabIndex = 58
        '
        'rbCPF
        '
        Me.rbCPF.AutoSize = True
        Me.rbCPF.Location = New System.Drawing.Point(552, 27)
        Me.rbCPF.Name = "rbCPF"
        Me.rbCPF.Size = New System.Drawing.Size(45, 17)
        Me.rbCPF.TabIndex = 57
        Me.rbCPF.TabStop = True
        Me.rbCPF.Text = "CPF"
        Me.rbCPF.UseVisualStyleBackColor = True
        '
        'rbNome
        '
        Me.rbNome.AutoSize = True
        Me.rbNome.Location = New System.Drawing.Point(484, 27)
        Me.rbNome.Name = "rbNome"
        Me.rbNome.Size = New System.Drawing.Size(53, 17)
        Me.rbNome.TabIndex = 56
        Me.rbNome.TabStop = True
        Me.rbNome.Text = "Nome"
        Me.rbNome.UseVisualStyleBackColor = True
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
        Me.btnExcluir.Location = New System.Drawing.Point(514, 381)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(65, 65)
        Me.btnExcluir.TabIndex = 55
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Transparent
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(415, 381)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(65, 65)
        Me.btnEditar.TabIndex = 54
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEditar.UseVisualStyleBackColor = False
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
        Me.btnSalvar.Location = New System.Drawing.Point(321, 381)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(60, 60)
        Me.btnSalvar.TabIndex = 53
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
        Me.btnNovo.Location = New System.Drawing.Point(226, 381)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(60, 60)
        Me.btnNovo.TabIndex = 52
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(52, 177)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(730, 179)
        Me.dg.TabIndex = 51
        '
        'txtCPF
        '
        Me.txtCPF.Location = New System.Drawing.Point(607, 78)
        Me.txtCPF.Mask = "999,999,999-99"
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(129, 20)
        Me.txtCPF.TabIndex = 50
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(375, 115)
        Me.txtTel.Mask = "(00) 00000-0000"
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(129, 20)
        Me.txtTel.TabIndex = 49
        '
        'cbSexo
        '
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Items.AddRange(New Object() {"Masculino", "Feminino"})
        Me.cbSexo.Location = New System.Drawing.Point(375, 72)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(129, 21)
        Me.cbSexo.TabIndex = 46
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(607, 120)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(129, 20)
        Me.txtEmail.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(562, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Email:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(325, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Telefone:"
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(153, 114)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(129, 20)
        Me.txtEndereco.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(99, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Endereço:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(562, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "CPF:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(327, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Sexo:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(153, 72)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(129, 20)
        Me.txtNome.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Nome:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(607, 26)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(129, 20)
        Me.txtBuscar.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(430, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Buscar:"
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(834, 457)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtBuscarCPF)
        Me.Controls.Add(Me.rbCPF)
        Me.Controls.Add(Me.rbNome)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.txtCPF)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.cbSexo)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtBuscarCPF As MaskedTextBox
    Friend WithEvents rbCPF As RadioButton
    Friend WithEvents rbNome As RadioButton
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents dg As DataGridView
    Friend WithEvents txtCPF As MaskedTextBox
    Friend WithEvents txtTel As MaskedTextBox
    Friend WithEvents cbSexo As ComboBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label1 As Label
End Class
