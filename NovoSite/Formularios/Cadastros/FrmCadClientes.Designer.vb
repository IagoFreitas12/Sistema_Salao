<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadClientes))
        Me.BtnBuscar = New System.Windows.Forms.Label()
        Me.TxtBuscarNome = New System.Windows.Forms.TextBox()
        Me.TxtBuscarCpf = New System.Windows.Forms.MaskedTextBox()
        Me.RadBtnNome = New System.Windows.Forms.RadioButton()
        Me.RadBtnCPF = New System.Windows.Forms.RadioButton()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtEndereco = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnNovo = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBuscar
        '
        Me.BtnBuscar.AutoSize = True
        Me.BtnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.BtnBuscar.Location = New System.Drawing.Point(194, 41)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(40, 13)
        Me.BtnBuscar.TabIndex = 2
        Me.BtnBuscar.Text = "Buscar"
        '
        'TxtBuscarNome
        '
        Me.TxtBuscarNome.Location = New System.Drawing.Point(73, 12)
        Me.TxtBuscarNome.Name = "TxtBuscarNome"
        Me.TxtBuscarNome.Size = New System.Drawing.Size(161, 20)
        Me.TxtBuscarNome.TabIndex = 0
        '
        'TxtBuscarCpf
        '
        Me.TxtBuscarCpf.Location = New System.Drawing.Point(73, 38)
        Me.TxtBuscarCpf.Mask = "000,000,000-00"
        Me.TxtBuscarCpf.Name = "TxtBuscarCpf"
        Me.TxtBuscarCpf.Size = New System.Drawing.Size(84, 20)
        Me.TxtBuscarCpf.TabIndex = 1
        Me.TxtBuscarCpf.Visible = False
        '
        'RadBtnNome
        '
        Me.RadBtnNome.AutoSize = True
        Me.RadBtnNome.BackColor = System.Drawing.Color.Transparent
        Me.RadBtnNome.Checked = True
        Me.RadBtnNome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadBtnNome.Location = New System.Drawing.Point(16, 13)
        Me.RadBtnNome.Name = "RadBtnNome"
        Me.RadBtnNome.Size = New System.Drawing.Size(56, 17)
        Me.RadBtnNome.TabIndex = 0
        Me.RadBtnNome.TabStop = True
        Me.RadBtnNome.Text = "Nome:"
        Me.RadBtnNome.UseVisualStyleBackColor = False
        '
        'RadBtnCPF
        '
        Me.RadBtnCPF.AutoSize = True
        Me.RadBtnCPF.BackColor = System.Drawing.Color.Transparent
        Me.RadBtnCPF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadBtnCPF.Location = New System.Drawing.Point(16, 41)
        Me.RadBtnCPF.Name = "RadBtnCPF"
        Me.RadBtnCPF.Size = New System.Drawing.Size(48, 17)
        Me.RadBtnCPF.TabIndex = 1
        Me.RadBtnCPF.TabStop = True
        Me.RadBtnCPF.Text = "CPF:"
        Me.RadBtnCPF.UseVisualStyleBackColor = False
        '
        'TxtNome
        '
        Me.TxtNome.Location = New System.Drawing.Point(72, 95)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(162, 20)
        Me.TxtNome.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(34, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nome:"
        '
        'TxtCpf
        '
        Me.TxtCpf.Location = New System.Drawing.Point(267, 95)
        Me.TxtCpf.Mask = "000,000,000-00"
        Me.TxtCpf.Name = "TxtCpf"
        Me.TxtCpf.Size = New System.Drawing.Size(83, 20)
        Me.TxtCpf.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(237, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "CPF:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(356, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Endereço:"
        '
        'TxtEndereco
        '
        Me.TxtEndereco.Location = New System.Drawing.Point(412, 95)
        Me.TxtEndereco.Name = "TxtEndereco"
        Me.TxtEndereco.Size = New System.Drawing.Size(162, 20)
        Me.TxtEndereco.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(580, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "TEL:"
        '
        'TxtTelefone
        '
        Me.TxtTelefone.Location = New System.Drawing.Point(619, 96)
        Me.TxtTelefone.Mask = "(99) 00000-0000"
        Me.TxtTelefone.Name = "TxtTelefone"
        Me.TxtTelefone.Size = New System.Drawing.Size(85, 20)
        Me.TxtTelefone.TabIndex = 6
        '
        'TxtCliente
        '
        Me.TxtCliente.Location = New System.Drawing.Point(662, 13)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(70, 20)
        Me.TxtCliente.TabIndex = 1
        Me.TxtCliente.Visible = False
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.BackgroundColor = System.Drawing.Color.LightCyan
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Location = New System.Drawing.Point(17, 145)
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.Size = New System.Drawing.Size(715, 179)
        Me.Grid.TabIndex = 12
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackColor = System.Drawing.Color.Transparent
        Me.BtnSalvar.BackgroundImage = CType(resources.GetObject("BtnSalvar.BackgroundImage"), System.Drawing.Image)
        Me.BtnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvar.Enabled = False
        Me.BtnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnSalvar.FlatAppearance.BorderSize = 0
        Me.BtnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvar.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.ForeColor = System.Drawing.Color.Black
        Me.BtnSalvar.Location = New System.Drawing.Point(290, 348)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(54, 50)
        Me.BtnSalvar.TabIndex = 8
        Me.BtnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSalvar.UseVisualStyleBackColor = False
        '
        'BtnNovo
        '
        Me.BtnNovo.BackColor = System.Drawing.Color.Transparent
        Me.BtnNovo.BackgroundImage = CType(resources.GetObject("BtnNovo.BackgroundImage"), System.Drawing.Image)
        Me.BtnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNovo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnNovo.FlatAppearance.BorderSize = 0
        Me.BtnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.BtnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNovo.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNovo.Location = New System.Drawing.Point(192, 348)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(54, 50)
        Me.BtnNovo.TabIndex = 7
        Me.BtnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnNovo.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.Transparent
        Me.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditar.Enabled = False
        Me.BtnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.Color.Black
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.Location = New System.Drawing.Point(393, 348)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(54, 50)
        Me.BtnEditar.TabIndex = 9
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnExcluir
        '
        Me.BtnExcluir.BackColor = System.Drawing.Color.Transparent
        Me.BtnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExcluir.Enabled = False
        Me.BtnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnExcluir.FlatAppearance.BorderSize = 0
        Me.BtnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExcluir.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcluir.ForeColor = System.Drawing.Color.Transparent
        Me.BtnExcluir.Image = CType(resources.GetObject("BtnExcluir.Image"), System.Drawing.Image)
        Me.BtnExcluir.Location = New System.Drawing.Point(491, 352)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(54, 50)
        Me.BtnExcluir.TabIndex = 10
        Me.BtnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnExcluir.UseVisualStyleBackColor = False
        '
        'FrmCadClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(750, 423)
        Me.Controls.Add(Me.BtnNovo)
        Me.Controls.Add(Me.BtnExcluir)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnSalvar)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.TxtTelefone)
        Me.Controls.Add(Me.RadBtnCPF)
        Me.Controls.Add(Me.RadBtnNome)
        Me.Controls.Add(Me.TxtCpf)
        Me.Controls.Add(Me.TxtBuscarCpf)
        Me.Controls.Add(Me.TxtCliente)
        Me.Controls.Add(Me.TxtEndereco)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.TxtBuscarNome)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnBuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "FrmCadClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Clientes"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBuscar As Label
    Friend WithEvents TxtBuscarNome As TextBox
    Friend WithEvents TxtBuscarCpf As MaskedTextBox
    Friend WithEvents RadBtnNome As RadioButton
    Friend WithEvents RadBtnCPF As RadioButton
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCpf As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtEndereco As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtTelefone As MaskedTextBox
    Friend WithEvents TxtCliente As TextBox
    Friend WithEvents Grid As DataGridView
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnNovo As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnExcluir As Button
End Class
