<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTelaPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTelaPrincipal))
        Me.BarraMenu = New System.Windows.Forms.MenuStrip()
        Me.CadastrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FornecedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiçosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EspecialidadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiçosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgendamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuadroDeHoráriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimentaçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovaVendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GastosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatóriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAddCliente = New System.Windows.Forms.Button()
        Me.btnAddAgendamento = New System.Windows.Forms.Button()
        Me.btnAddHorario = New System.Windows.Forms.Button()
        Me.btnAddVenda = New System.Windows.Forms.Button()
        Me.BarraMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarraMenu
        '
        Me.BarraMenu.BackColor = System.Drawing.Color.Transparent
        Me.BarraMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BarraMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrosToolStripMenuItem, Me.ProdutosToolStripMenuItem, Me.ServiçosToolStripMenuItem, Me.MovimentaçõesToolStripMenuItem, Me.RelatóriosToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.BarraMenu.Location = New System.Drawing.Point(0, 0)
        Me.BarraMenu.Name = "BarraMenu"
        Me.BarraMenu.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.BarraMenu.Size = New System.Drawing.Size(788, 28)
        Me.BarraMenu.TabIndex = 0
        Me.BarraMenu.Text = "MenuStrip1"
        '
        'CadastrosToolStripMenuItem
        '
        Me.CadastrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.FornecedoresToolStripMenuItem, Me.FuncionáriosToolStripMenuItem, Me.ServiçosToolStripMenuItem1, Me.EspecialidadeToolStripMenuItem})
        Me.CadastrosToolStripMenuItem.Image = CType(resources.GetObject("CadastrosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CadastrosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CadastrosToolStripMenuItem.Name = "CadastrosToolStripMenuItem"
        Me.CadastrosToolStripMenuItem.Size = New System.Drawing.Size(91, 24)
        Me.CadastrosToolStripMenuItem.Text = "Cadastros"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'FornecedoresToolStripMenuItem
        '
        Me.FornecedoresToolStripMenuItem.Name = "FornecedoresToolStripMenuItem"
        Me.FornecedoresToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.FornecedoresToolStripMenuItem.Text = "Fornecedores"
        '
        'FuncionáriosToolStripMenuItem
        '
        Me.FuncionáriosToolStripMenuItem.Name = "FuncionáriosToolStripMenuItem"
        Me.FuncionáriosToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.FuncionáriosToolStripMenuItem.Text = "Funcionários"
        '
        'ServiçosToolStripMenuItem1
        '
        Me.ServiçosToolStripMenuItem1.Name = "ServiçosToolStripMenuItem1"
        Me.ServiçosToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.ServiçosToolStripMenuItem1.Text = "Serviços"
        '
        'EspecialidadeToolStripMenuItem
        '
        Me.EspecialidadeToolStripMenuItem.Name = "EspecialidadeToolStripMenuItem"
        Me.EspecialidadeToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.EspecialidadeToolStripMenuItem.Text = "Especialidade"
        '
        'ProdutosToolStripMenuItem
        '
        Me.ProdutosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroDeProdutosToolStripMenuItem, Me.EntradasToolStripMenuItem})
        Me.ProdutosToolStripMenuItem.Image = CType(resources.GetObject("ProdutosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProdutosToolStripMenuItem.Name = "ProdutosToolStripMenuItem"
        Me.ProdutosToolStripMenuItem.Size = New System.Drawing.Size(87, 24)
        Me.ProdutosToolStripMenuItem.Text = "Produtos"
        '
        'CadastroDeProdutosToolStripMenuItem
        '
        Me.CadastroDeProdutosToolStripMenuItem.Name = "CadastroDeProdutosToolStripMenuItem"
        Me.CadastroDeProdutosToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.CadastroDeProdutosToolStripMenuItem.Text = "Cadastro de Produtos"
        '
        'EntradasToolStripMenuItem
        '
        Me.EntradasToolStripMenuItem.Name = "EntradasToolStripMenuItem"
        Me.EntradasToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.EntradasToolStripMenuItem.Text = "Entradas"
        '
        'ServiçosToolStripMenuItem
        '
        Me.ServiçosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgendamentoToolStripMenuItem, Me.QuadroDeHoráriosToolStripMenuItem})
        Me.ServiçosToolStripMenuItem.Image = CType(resources.GetObject("ServiçosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ServiçosToolStripMenuItem.Name = "ServiçosToolStripMenuItem"
        Me.ServiçosToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.ServiçosToolStripMenuItem.Text = "Serviços"
        '
        'AgendamentoToolStripMenuItem
        '
        Me.AgendamentoToolStripMenuItem.Name = "AgendamentoToolStripMenuItem"
        Me.AgendamentoToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.AgendamentoToolStripMenuItem.Text = "Agendamento"
        '
        'QuadroDeHoráriosToolStripMenuItem
        '
        Me.QuadroDeHoráriosToolStripMenuItem.Name = "QuadroDeHoráriosToolStripMenuItem"
        Me.QuadroDeHoráriosToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.QuadroDeHoráriosToolStripMenuItem.Text = "Quadro de Horários"
        '
        'MovimentaçõesToolStripMenuItem
        '
        Me.MovimentaçõesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovaVendaToolStripMenuItem, Me.GastosToolStripMenuItem, Me.PagamentosToolStripMenuItem})
        Me.MovimentaçõesToolStripMenuItem.Image = CType(resources.GetObject("MovimentaçõesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MovimentaçõesToolStripMenuItem.Name = "MovimentaçõesToolStripMenuItem"
        Me.MovimentaçõesToolStripMenuItem.Size = New System.Drawing.Size(124, 24)
        Me.MovimentaçõesToolStripMenuItem.Text = "Movimentações"
        '
        'NovaVendaToolStripMenuItem
        '
        Me.NovaVendaToolStripMenuItem.Name = "NovaVendaToolStripMenuItem"
        Me.NovaVendaToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.NovaVendaToolStripMenuItem.Text = "Nova Venda"
        '
        'GastosToolStripMenuItem
        '
        Me.GastosToolStripMenuItem.Name = "GastosToolStripMenuItem"
        Me.GastosToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.GastosToolStripMenuItem.Text = "Gastos"
        '
        'PagamentosToolStripMenuItem
        '
        Me.PagamentosToolStripMenuItem.Name = "PagamentosToolStripMenuItem"
        Me.PagamentosToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.PagamentosToolStripMenuItem.Text = "Pagamentos"
        '
        'RelatóriosToolStripMenuItem
        '
        Me.RelatóriosToolStripMenuItem.Image = CType(resources.GetObject("RelatóriosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RelatóriosToolStripMenuItem.Name = "RelatóriosToolStripMenuItem"
        Me.RelatóriosToolStripMenuItem.Size = New System.Drawing.Size(91, 24)
        Me.RelatóriosToolStripMenuItem.Text = "Relatórios"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.SairToolStripMenuItem.Image = CType(resources.GetObject("SairToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'btnAddCliente
        '
        Me.btnAddCliente.BackColor = System.Drawing.Color.Transparent
        Me.btnAddCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddCliente.FlatAppearance.BorderSize = 0
        Me.btnAddCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen
        Me.btnAddCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.btnAddCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCliente.Image = CType(resources.GetObject("btnAddCliente.Image"), System.Drawing.Image)
        Me.btnAddCliente.Location = New System.Drawing.Point(151, 34)
        Me.btnAddCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddCliente.Name = "btnAddCliente"
        Me.btnAddCliente.Size = New System.Drawing.Size(45, 49)
        Me.btnAddCliente.TabIndex = 1
        Me.btnAddCliente.UseVisualStyleBackColor = False
        '
        'btnAddAgendamento
        '
        Me.btnAddAgendamento.BackColor = System.Drawing.Color.Transparent
        Me.btnAddAgendamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddAgendamento.FlatAppearance.BorderSize = 0
        Me.btnAddAgendamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen
        Me.btnAddAgendamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.btnAddAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAgendamento.Image = CType(resources.GetObject("btnAddAgendamento.Image"), System.Drawing.Image)
        Me.btnAddAgendamento.Location = New System.Drawing.Point(200, 34)
        Me.btnAddAgendamento.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddAgendamento.Name = "btnAddAgendamento"
        Me.btnAddAgendamento.Size = New System.Drawing.Size(45, 49)
        Me.btnAddAgendamento.TabIndex = 1
        Me.btnAddAgendamento.UseVisualStyleBackColor = False
        '
        'btnAddHorario
        '
        Me.btnAddHorario.BackColor = System.Drawing.Color.Transparent
        Me.btnAddHorario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddHorario.FlatAppearance.BorderSize = 0
        Me.btnAddHorario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen
        Me.btnAddHorario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.btnAddHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddHorario.Image = CType(resources.GetObject("btnAddHorario.Image"), System.Drawing.Image)
        Me.btnAddHorario.Location = New System.Drawing.Point(250, 34)
        Me.btnAddHorario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddHorario.Name = "btnAddHorario"
        Me.btnAddHorario.Size = New System.Drawing.Size(45, 49)
        Me.btnAddHorario.TabIndex = 1
        Me.btnAddHorario.UseVisualStyleBackColor = False
        '
        'btnAddVenda
        '
        Me.btnAddVenda.BackColor = System.Drawing.Color.Transparent
        Me.btnAddVenda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddVenda.FlatAppearance.BorderSize = 0
        Me.btnAddVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen
        Me.btnAddVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.btnAddVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddVenda.Image = CType(resources.GetObject("btnAddVenda.Image"), System.Drawing.Image)
        Me.btnAddVenda.Location = New System.Drawing.Point(299, 34)
        Me.btnAddVenda.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddVenda.Name = "btnAddVenda"
        Me.btnAddVenda.Size = New System.Drawing.Size(45, 49)
        Me.btnAddVenda.TabIndex = 1
        Me.btnAddVenda.UseVisualStyleBackColor = False
        '
        'FrmTelaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(788, 457)
        Me.Controls.Add(Me.btnAddVenda)
        Me.Controls.Add(Me.btnAddHorario)
        Me.Controls.Add(Me.btnAddAgendamento)
        Me.Controls.Add(Me.btnAddCliente)
        Me.Controls.Add(Me.BarraMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.BarraMenu
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmTelaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.BarraMenu.ResumeLayout(False)
        Me.BarraMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarraMenu As MenuStrip
    Friend WithEvents CadastrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiçosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovimentaçõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatóriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FornecedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiçosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EspecialidadeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroDeProdutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgendamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuadroDeHoráriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovaVendaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GastosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnAddCliente As Button
    Friend WithEvents btnAddAgendamento As Button
    Friend WithEvents btnAddHorario As Button
    Friend WithEvents btnAddVenda As Button
End Class
