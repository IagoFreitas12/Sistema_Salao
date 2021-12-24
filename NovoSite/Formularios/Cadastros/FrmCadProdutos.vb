Public Class FrmCadProdutos
    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        Limpar()
        HabilitarCampos()
        TxtNome.Focus()
        BtnSalvar.BackgroundImage = My.Resources.BtnSalvar
        BtnSalvar.Enabled = True
    End Sub

    Private Sub HabilitarCampos()
        TxtNome.Enabled = True
        TxtDescricao.Enabled = True
        TxtValor.Enabled = True
        TxtQuantidade.Enabled = True
        CbFornecedor.Enabled = True
        BtnAddImagem.Enabled = True
    End Sub

    Private Sub DesabilitarCampos()
        TxtNome.Enabled = False
        TxtDescricao.Enabled = False
        TxtValor.Enabled = False
        TxtQuantidade.Enabled = False
        CbFornecedor.Enabled = False
        BtnAddImagem.Enabled = False
    End Sub

    Private Sub Limpar()
        TxtNome.Text = ""
        TxtDescricao.Text = ""
        TxtValor.Text = ""
        TxtQuantidade.Text = ""
        Img.Image = My.Resources.sem_foto
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click

        If TxtNome.Text <> "" Then
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
        End If
    End Sub

    Private Sub TxtNome_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtNome.KeyDown
        TxtNome.BackColor = Color.White
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If TxtNome.Text <> "" Then
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

    Private Sub BtnAddImagem_Click(sender As Object, e As EventArgs) Handles BtnAddImagem.Click
        Dim DlgImagem As FileDialog = New OpenFileDialog
        DlgImagem.Filter = "Arquivo de Imagem(*.jpg; *.bmp; *.png) | *.jpg; *.bmp; *.png"

        If (DlgImagem.ShowDialog) = DialogResult.OK Then
            MsgBox("Escolhi uma imagem.")
        Else
            MsgBox("Ação cancelada.")
        End If
    End Sub
End Class