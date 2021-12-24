Public Class FrmCadClientes
    Private Sub FrmCadClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtNome.Focus()
        BtnSalvar.BackgroundImage = My.Resources.BtnSalvarInativo
        BtnEditar.BackgroundImage = My.Resources.BtnEditarInativo
        BtnExcluir.BackgroundImage = My.Resources.BtnExcluirInativo
    End Sub

    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        Limpar()
        HabilitarCampos()
        TxtNome.Focus()
        BtnSalvar.BackgroundImage = My.Resources.BtnSalvar
        BtnSalvar.Enabled = True
        'BtnEditar.BackgroundImage = My.Resources.BtnEditar
        'BtnEditar.Enabled = True
        'BtnExcluir.BackgroundImage = My.Resources.BtnExcluir
        'BtnExcluir.Enabled = True
    End Sub

    Private Sub RadBtnCPF_CheckedChanged(sender As Object, e As EventArgs) Handles RadBtnCPF.CheckedChanged
        TxtBuscarCpf.Visible = True
        TxtBuscarCpf.Focus()
        TxtBuscarNome.Visible = False
    End Sub

    Private Sub RadBtnNome_CheckedChanged(sender As Object, e As EventArgs) Handles RadBtnNome.CheckedChanged
        TxtBuscarNome.Visible = True
        TxtBuscarNome.Focus()
        TxtBuscarCpf.Visible = False
    End Sub

    Private Sub HabilitarCampos()
        TxtNome.Enabled = True
        TxtCpf.Enabled = True
        TxtEndereco.Enabled = True
        TxtTelefone.Enabled = True
    End Sub

    Private Sub DesabilitarCampos()
        TxtNome.Enabled = False
        TxtCpf.Enabled = False
        TxtEndereco.Enabled = False
        TxtTelefone.Enabled = False
    End Sub

    Private Sub Limpar()
        TxtNome.Text = ""
        TxtCpf.Text = ""
        TxtEndereco.Text = ""
        TxtTelefone.Text = ""
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click

        If TxtNome.Text <> "" And TxtCpf.Text <> "   .   .   -" Then
            Try
                MsgBox("Salvo com sucesso.", MsgBoxStyle.OkOnly, "Dados salvos")
                DesabilitarCampos()
                BtnSalvar.Enabled = False
            Catch ex As Exception
                MsgBox("Erro ao salvar.", MsgBoxStyle.Critical, +ex.Message)
            End Try
        Else
            MsgBox("Preecha os dados obrigatórios!", MsgBoxStyle.Critical, "Erro!")
            TxtNome.Focus()
            TxtNome.BackColor = Color.LightSalmon
            TxtCpf.BackColor = Color.LightSalmon
        End If
    End Sub

    Private Sub TxtNome_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtNome.KeyDown
        TxtNome.BackColor = Color.White
    End Sub

    Private Sub TxtCpf_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCpf.KeyDown
        TxtCpf.BackColor = Color.White
    End Sub


    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If TxtNome.Text <> "" And TxtCpf.Text <> "   .   .   -" Then
            Try
                MsgBox("Editado com sucesso.", MsgBoxStyle.OkOnly, "Dados editados")
                DesabilitarCampos()
                BtnEditar.Enabled = False
                BtnExcluir.Enabled = False
            Catch ex As Exception
                MsgBox("Erro ao editar!", MsgBoxStyle.Critical, +ex.Message)
            End Try
        Else
            MsgBox("Preecha os dados obrigatórios!", MsgBoxStyle.Critical, "Erro!")
            TxtNome.Focus()
            TxtNome.BackColor = Color.LightSalmon
            TxtCpf.BackColor = Color.LightSalmon
        End If
    End Sub

    Private Sub Grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellClick
        HabilitarCampos()
        BtnEditar.Enabled = True
        BtnExcluir.Enabled = True
    End Sub

    'Private Sub Grid_Click(sender As Object, e As EventArgs) Handles Grid.Click
    '    HabilitarCampos()
    '    BtnEditar.Enabled = True
    '    BtnExcluir.Enabled = True
    'End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If MsgBox("Deseja excluir o registro?", vbYesNo, "Excluir?") = vbYes Then
            Try
                MsgBox("Excluído com sucesso.", MsgBoxStyle.OkOnly, "Dados excluídos")
                DesabilitarCampos()
                BtnEditar.Enabled = False
                BtnExcluir.Enabled = False
            Catch ex As Exception
                MsgBox("Erro ao excluir!", MsgBoxStyle.Critical, +ex.Message)
            End Try
        End If
    End Sub


End Class