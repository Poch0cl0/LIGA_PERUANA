Imports System.Data.SqlClient
Public Class frmLogin

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usuario As String = TextBox1.Text
        Dim connectionString As String = "Server=.;Database=LIGA_01_DB; Integrated security=true;"

        Using connection As New SqlConnection(connectionString)
            Try
                ' Abrir la conexión
                connection.Open()

                ' Crear un comando para verificar el usuario y obtener IdTipoUsuario
                Dim query As String = "SELECT IdTipoUsuario FROM Usuario WHERE NombreUsuario = @usuario"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@usuario", usuario)

                ' Ejecutar el comando
                Dim idTipoUsuario As Object = command.ExecuteScalar()

                ' Verificar si se obtuvo un resultado
                If idTipoUsuario IsNot Nothing Then
                    ' Convertir el resultado a Integer
                    Dim tipoUsuario As Integer = Convert.ToInt32(idTipoUsuario)

                    Dim frmPrincipal As New frmPrincipal()
                    frmPrincipal.TipoUsuario = tipoUsuario
                    frmPrincipal.Show()
                Else
                    MessageBox.Show("Usuario inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class