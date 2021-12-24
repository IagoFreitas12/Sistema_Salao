<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadProdutos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadProdutos))
        Me.BtnNovo = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.TxtDescricao = New System.Windows.Forms.TextBox()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.TxtBuscarNome = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Label()
        Me.LblNome = New System.Windows.Forms.Label()
        Me.LblValor = New System.Windows.Forms.Label()
        Me.LblQuantidade = New System.Windows.Forms.Label()
        Me.TxtQuantidade = New System.Windows.Forms.TextBox()
        Me.LblFornecedor = New System.Windows.Forms.Label()
        Me.CbFornecedor = New System.Windows.Forms.ComboBox()
        Me.TxtValor = New System.Windows.Forms.MaskedTextBox()
        Me.Img = New System.Windows.Forms.PictureBox()
        Me.BtnAddImagem = New System.Windows.Forms.Button()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BtnNovo.Location = New System.Drawing.Point(193, 354)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(54, 50)
        Me.BtnNovo.TabIndex = 53
        Me.BtnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnNovo.UseVisualStyleBackColor = False
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
        Me.BtnExcluir.Location = New System.Drawing.Point(492, 358)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(54, 50)
        Me.BtnExcluir.TabIndex = 53
        Me.BtnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnExcluir.UseVisualStyleBackColor = False
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
        Me.BtnEditar.Location = New System.Drawing.Point(394, 354)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(54, 50)
        Me.BtnEditar.TabIndex = 53
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEditar.UseVisualStyleBackColor = False
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
        Me.BtnSalvar.Location = New System.Drawing.Point(291, 354)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(54, 50)
        Me.BtnSalvar.TabIndex = 53
        Me.BtnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSalvar.UseVisualStyleBackColor = False
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.BackgroundColor = System.Drawing.Color.LightCyan
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Location = New System.Drawing.Point(18, 212)
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.Size = New System.Drawing.Size(715, 118)
        Me.Grid.TabIndex = 52
        '
        'TxtCliente
        '
        Me.TxtCliente.Location = New System.Drawing.Point(663, 31)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.ReadOnly = True
        Me.TxtCliente.Size = New System.Drawing.Size(70, 20)
        Me.TxtCliente.TabIndex = 1
        Me.TxtCliente.Visible = False
        '
        'TxtDescricao
        '
        Me.TxtDescricao.Enabled = False
        Me.TxtDescricao.Location = New System.Drawing.Point(306, 123)
        Me.TxtDescricao.Name = "TxtDescricao"
        Me.TxtDescricao.Size = New System.Drawing.Size(230, 20)
        Me.TxtDescricao.TabIndex = 30
        '
        'TxtNome
        '
        Me.TxtNome.Location = New System.Drawing.Point(63, 123)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(162, 20)
        Me.TxtNome.TabIndex = 20
        '
        'TxtBuscarNome
        '
        Me.TxtBuscarNome.Location = New System.Drawing.Point(63, 31)
        Me.TxtBuscarNome.Name = "TxtBuscarNome"
        Me.TxtBuscarNome.Size = New System.Drawing.Size(162, 20)
        Me.TxtBuscarNome.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(242, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Descrição:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(19, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Nome:"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.AutoSize = True
        Me.BtnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.BtnBuscar.Location = New System.Drawing.Point(185, 58)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(40, 13)
        Me.BtnBuscar.TabIndex = 10
        Me.BtnBuscar.Text = "Buscar"
        '
        'LblNome
        '
        Me.LblNome.AutoSize = True
        Me.LblNome.BackColor = System.Drawing.Color.Transparent
        Me.LblNome.Location = New System.Drawing.Point(19, 34)
        Me.LblNome.Name = "LblNome"
        Me.LblNome.Size = New System.Drawing.Size(38, 13)
        Me.LblNome.TabIndex = 120
        Me.LblNome.Text = "Nome:"
        '
        'LblValor
        '
        Me.LblValor.AutoSize = True
        Me.LblValor.BackColor = System.Drawing.Color.Transparent
        Me.LblValor.Location = New System.Drawing.Point(23, 171)
        Me.LblValor.Name = "LblValor"
        Me.LblValor.Size = New System.Drawing.Size(34, 13)
        Me.LblValor.TabIndex = 64
        Me.LblValor.Text = "Valor:"
        '
        'LblQuantidade
        '
        Me.LblQuantidade.AutoSize = True
        Me.LblQuantidade.BackColor = System.Drawing.Color.Transparent
        Me.LblQuantidade.Location = New System.Drawing.Point(181, 171)
        Me.LblQuantidade.Name = "LblQuantidade"
        Me.LblQuantidade.Size = New System.Drawing.Size(65, 13)
        Me.LblQuantidade.TabIndex = 65
        Me.LblQuantidade.Text = "Quantidade:"
        '
        'TxtQuantidade
        '
        Me.TxtQuantidade.Enabled = False
        Me.TxtQuantidade.Location = New System.Drawing.Point(252, 168)
        Me.TxtQuantidade.Name = "TxtQuantidade"
        Me.TxtQuantidade.Size = New System.Drawing.Size(46, 20)
        Me.TxtQuantidade.TabIndex = 51
        '
        'LblFornecedor
        '
        Me.LblFornecedor.AutoSize = True
        Me.LblFornecedor.BackColor = System.Drawing.Color.Transparent
        Me.LblFornecedor.Location = New System.Drawing.Point(330, 171)
        Me.LblFornecedor.Name = "LblFornecedor"
        Me.LblFornecedor.Size = New System.Drawing.Size(64, 13)
        Me.LblFornecedor.TabIndex = 66
        Me.LblFornecedor.Text = "Fornecedor:"
        '
        'CbFornecedor
        '
        Me.CbFornecedor.Enabled = False
        Me.CbFornecedor.FormattingEnabled = True
        Me.CbFornecedor.Location = New System.Drawing.Point(400, 168)
        Me.CbFornecedor.Name = "CbFornecedor"
        Me.CbFornecedor.Size = New System.Drawing.Size(136, 21)
        Me.CbFornecedor.TabIndex = 51
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(63, 168)
        Me.TxtValor.Mask = "$"
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(91, 20)
        Me.TxtValor.TabIndex = 50
        '
        'Img
        '
        Me.Img.BackColor = System.Drawing.Color.Honeydew
        Me.Img.Location = New System.Drawing.Point(566, 69)
        Me.Img.Name = "Img"
        Me.Img.Size = New System.Drawing.Size(120, 120)
        Me.Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Img.TabIndex = 121
        Me.Img.TabStop = False
        '
        'BtnAddImagem
        '
        Me.BtnAddImagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddImagem.BackColor = System.Drawing.Color.Transparent
        Me.BtnAddImagem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddImagem.Enabled = False
        Me.BtnAddImagem.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.BtnAddImagem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew
        Me.BtnAddImagem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream
        Me.BtnAddImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddImagem.Location = New System.Drawing.Point(696, 164)
        Me.BtnAddImagem.Name = "BtnAddImagem"
        Me.BtnAddImagem.Size = New System.Drawing.Size(25, 25)
        Me.BtnAddImagem.TabIndex = 122
        Me.BtnAddImagem.Text = "+"
        Me.BtnAddImagem.UseVisualStyleBackColor = False
        '
        'FrmCadProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(750, 427)
        Me.Controls.Add(Me.BtnAddImagem)
        Me.Controls.Add(Me.Img)
        Me.Controls.Add(Me.TxtValor)
        Me.Controls.Add(Me.CbFornecedor)
        Me.Controls.Add(Me.BtnNovo)
        Me.Controls.Add(Me.BtnExcluir)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnSalvar)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.TxtCliente)
        Me.Controls.Add(Me.TxtDescricao)
        Me.Controls.Add(Me.TxtQuantidade)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.TxtBuscarNome)
        Me.Controls.Add(Me.LblFornecedor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LblQuantidade)
        Me.Controls.Add(Me.LblValor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblNome)
        Me.Controls.Add(Me.BtnBuscar)
        Me.MaximizeBox = False
        Me.Name = "FrmCadProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCadProdutos"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnNovo As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents Grid As DataGridView
    Friend WithEvents TxtCliente As TextBox
    Friend WithEvents TxtDescricao As TextBox
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents TxtBuscarNome As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnBuscar As Label
    Friend WithEvents LblNome As Label
    Friend WithEvents LblValor As Label
    Friend WithEvents LblQuantidade As Label
    Friend WithEvents TxtQuantidade As TextBox
    Friend WithEvents LblFornecedor As Label
    Friend WithEvents CbFornecedor As ComboBox
    Friend WithEvents TxtValor As MaskedTextBox
    Friend WithEvents Img As PictureBox
    Friend WithEvents BtnAddImagem As Button
End Class
