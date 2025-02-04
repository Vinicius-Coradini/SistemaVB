Imports System.Data.SqlClient

Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim usuario As String = txtUsuario.Text
        Dim senha As String = txtSenha.Text

        If usuario = "" Or senha = "" Then
            MsgBox("Preencha os Campos!!")
        Else

            Dim cmd As New SqlCommand("login", con)

            Try
                abrir()
                cmd.CommandType = 4
                With cmd.Parameters
                    .AddWithValue("@nome", usuario)
                    .AddWithValue("@cpf", senha)
                    .Add("@msg", SqlDbType.VarChar, 100).Direction = 2
                    cmd.ExecuteNonQuery()
                End With

                usuarioNome = txtUsuario.Text

                Dim msg As String = cmd.Parameters("@msg").Value
                MsgBox(msg, vbInformation)

                If (msg = "Dados Incorretos") Then
                    txtSenha.Clear()
                    txtUsuario.Clear()
                    txtUsuario.Focus()
                Else
                    Dim form = New Principal
                    Me.Hide()
                    form.ShowDialog()
                End If


            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message)
                fechar()
            End Try

        End If


    End Sub
End Class
