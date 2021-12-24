Public Class FrmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuario.BackColor = Color.FromArgb(117, 207, 182)
        txtSenha.BackColor = Color.FromArgb(117, 207, 182)
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim Usuario As String
        Dim Senha As String
        Usuario = txtUsuario.Text
        Senha = txtSenha.Text

        If Usuario <> "" And Senha <> "" Then
            'Login
            Dim Form = New FrmTelaPrincipal
            Form.ShowDialog()
        Else
            MsgBox("Preencha todos os campos.", MsgBoxStyle.Exclamation, "Login")
            txtUsuario.Focus()
        End If
    End Sub
End Class