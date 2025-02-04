Imports System.Data.SqlClient

Module Conexao
    Public con As New SqlConnection("Server=DESKTOP-5V5QO3E; DataBase=SistemaVb; Integrated Security=SSPI")

    Sub abrir()
        If con.State = 0 Then
            con.Open()
        End If
    End Sub

    Sub fechar()
        If con.State = 1 Then
            con.Close()
        End If
    End Sub


    Public usuarioNome As String

End Module
