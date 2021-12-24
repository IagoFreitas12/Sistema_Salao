Public Class FrmTelaPrincipal
    Private Sub FrmTelaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BarraMenu.BackColor = Color.FromArgb(209, 251, 241)
        'btnAddCliente.BackColor = Color.FromArgb(242, 255, 252)
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim Form = New FrmCadClientes
        Form.ShowDialog()
    End Sub

    Private Sub CadastroDeProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeProdutosToolStripMenuItem.Click
        Dim Form = New FrmCadProdutos
        Form.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim Form = New FrmLogin
        Form.ShowDialog()
    End Sub
End Class