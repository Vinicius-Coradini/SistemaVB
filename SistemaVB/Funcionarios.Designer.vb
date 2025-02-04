<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Funcionarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Funcionarios))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.cbTurno = New System.Windows.Forms.ComboBox()
        Me.dtData = New System.Windows.Forms.DateTimePicker()
        Me.txtTel = New System.Windows.Forms.MaskedTextBox()
        Me.txtCPF = New System.Windows.Forms.MaskedTextBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.rbNome = New System.Windows.Forms.RadioButton()
        Me.rbCPF = New System.Windows.Forms.RadioButton()
        Me.txtBuscarCPF = New System.Windows.Forms.MaskedTextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(390, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(567, 21)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(129, 20)
        Me.txtBuscar.TabIndex = 1
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(113, 67)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(129, 20)
        Me.txtNome.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nome:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(287, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sexo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(522, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "CPF:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(567, 115)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(129, 20)
        Me.txtEmail.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(522, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Email:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(285, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Telefone:"
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(113, 109)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(129, 20)
        Me.txtEndereco.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(59, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Endereço:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(287, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Data"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(59, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Turno:"
        '
        'cbSexo
        '
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Items.AddRange(New Object() {"Masculino", "Feminino"})
        Me.cbSexo.Location = New System.Drawing.Point(335, 67)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(129, 21)
        Me.cbSexo.TabIndex = 18
        '
        'cbTurno
        '
        Me.cbTurno.FormattingEnabled = True
        Me.cbTurno.Items.AddRange(New Object() {"Manhã", "Tarde", "Noite", "Madrugada"})
        Me.cbTurno.Location = New System.Drawing.Point(113, 151)
        Me.cbTurno.Name = "cbTurno"
        Me.cbTurno.Size = New System.Drawing.Size(129, 21)
        Me.cbTurno.TabIndex = 19
        '
        'dtData
        '
        Me.dtData.Checked = False
        Me.dtData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtData.Location = New System.Drawing.Point(335, 154)
        Me.dtData.Name = "dtData"
        Me.dtData.Size = New System.Drawing.Size(129, 20)
        Me.dtData.TabIndex = 20
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(335, 110)
        Me.txtTel.Mask = "(00) 00000-0000"
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(129, 20)
        Me.txtTel.TabIndex = 21
        '
        'txtCPF
        '
        Me.txtCPF.Location = New System.Drawing.Point(567, 73)
        Me.txtCPF.Mask = "999,999,999-99"
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(129, 20)
        Me.txtCPF.TabIndex = 22
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(19, 193)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(730, 179)
        Me.dg.TabIndex = 23
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
        Me.btnNovo.Location = New System.Drawing.Point(193, 397)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(60, 60)
        Me.btnNovo.TabIndex = 24
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNovo.UseVisualStyleBackColor = False
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
        Me.btnSalvar.Location = New System.Drawing.Point(288, 397)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(60, 60)
        Me.btnSalvar.TabIndex = 25
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalvar.UseVisualStyleBackColor = False
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
        Me.btnEditar.Location = New System.Drawing.Point(382, 397)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(65, 65)
        Me.btnEditar.TabIndex = 26
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEditar.UseVisualStyleBackColor = False
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
        Me.btnExcluir.Location = New System.Drawing.Point(481, 397)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(65, 65)
        Me.btnExcluir.TabIndex = 27
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'rbNome
        '
        Me.rbNome.AutoSize = True
        Me.rbNome.Location = New System.Drawing.Point(444, 22)
        Me.rbNome.Name = "rbNome"
        Me.rbNome.Size = New System.Drawing.Size(53, 17)
        Me.rbNome.TabIndex = 28
        Me.rbNome.TabStop = True
        Me.rbNome.Text = "Nome"
        Me.rbNome.UseVisualStyleBackColor = True
        '
        'rbCPF
        '
        Me.rbCPF.AutoSize = True
        Me.rbCPF.Location = New System.Drawing.Point(512, 22)
        Me.rbCPF.Name = "rbCPF"
        Me.rbCPF.Size = New System.Drawing.Size(45, 17)
        Me.rbCPF.TabIndex = 29
        Me.rbCPF.TabStop = True
        Me.rbCPF.Text = "CPF"
        Me.rbCPF.UseVisualStyleBackColor = True
        '
        'txtBuscarCPF
        '
        Me.txtBuscarCPF.Location = New System.Drawing.Point(567, 21)
        Me.txtBuscarCPF.Mask = "999,999,999-99"
        Me.txtBuscarCPF.Name = "txtBuscarCPF"
        Me.txtBuscarCPF.Size = New System.Drawing.Size(129, 20)
        Me.txtBuscarCPF.TabIndex = 30
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(734, 379)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(10, 13)
        Me.lblTotal.TabIndex = 31
        Me.lblTotal.Text = "-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(695, 379)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Total"
        '
        'Funcionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(772, 481)
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
        Me.Controls.Add(Me.dtData)
        Me.Controls.Add(Me.cbTurno)
        Me.Controls.Add(Me.cbSexo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
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
        Me.Name = "Funcionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Funcionarios"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbSexo As ComboBox
    Friend WithEvents cbTurno As ComboBox
    Friend WithEvents dtData As DateTimePicker
    Friend WithEvents txtTel As MaskedTextBox
    Friend WithEvents txtCPF As MaskedTextBox
    Friend WithEvents dg As DataGridView
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents rbNome As RadioButton
    Friend WithEvents rbCPF As RadioButton
    Friend WithEvents txtBuscarCPF As MaskedTextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label11 As Label
End Class
