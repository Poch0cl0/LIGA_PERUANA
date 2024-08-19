
Imports System.Data.SqlClient
Public Class frmJugador
    Private Sub JUGADORBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles JUGADORBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.JUGADORBindingSource.EndEdit()
            ' Crear adaptadores para las tablas IDENTIFICACION y ARBITRO
            Dim identificacionTableAdapter As New LIGA_01_DBDataSetTableAdapters.IDENTIFICACIONTableAdapter()
            Dim jugadorTableAdapter As New LIGA_01_DBDataSetTableAdapters.JUGADORTableAdapter()

            ' Obtener datos de la tabla IDENTIFICACION
            Dim codigoIdentificacion As String = CodigoIdentificacionTextBox.Text
            Dim idTipoIdentificacion As Integer = CInt(IdTipoIdenticacionTextBox.Text)

            ' Verificar si el CodigoIdentificacion ya existe en IDENTIFICACION
            Dim identificacionRow As LIGA_01_DBDataSet.IDENTIFICACIONRow = Nothing
            Dim identificacionDataTable As LIGA_01_DBDataSet.IDENTIFICACIONDataTable = identificacionTableAdapter.GetDataByCodigoIdentificacion(codigoIdentificacion)

            If identificacionDataTable IsNot Nothing Then
                If identificacionDataTable.Rows IsNot Nothing Then
                    identificacionRow = DirectCast(identificacionDataTable.Rows(0), LIGA_01_DBDataSet.IDENTIFICACIONRow)
                End If
            End If

            If identificacionRow Is Nothing Then
                ' Si el CodigoIdentificacion no existe, crear un nuevo registro en IDENTIFICACION
                identificacionRow = Me.LIGA_01_DBDataSet.IDENTIFICACION.NewIDENTIFICACIONRow()
                identificacionRow.CodigoIdentificacion = codigoIdentificacion
                identificacionRow.IdTipoIdenticacion = idTipoIdentificacion
                Me.LIGA_01_DBDataSet.IDENTIFICACION.Rows.Add(identificacionRow)
                identificacionTableAdapter.Update(Me.LIGA_01_DBDataSet.IDENTIFICACION)
            End If

            ' Guardar los cambios en ARBITRO
            Me.TableAdapterManager.UpdateAll(Me.LIGA_01_DBDataSet)
        Catch ex As Exception
            ' Mostrar un mensaje de error en un pop-up
            MessageBox.Show("Se ha producido un error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmJugador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LIGA_01_DBDataSet.JUGADOR' Puede moverla o quitarla según sea necesario.
        Me.JUGADORTableAdapter.Fill(Me.LIGA_01_DBDataSet.JUGADOR)

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs) Handles FillToolStripButton.Click
        Try
            Me.Fn_jugadores_por_nacionalidadTableAdapter.Fill(Me.LIGA_01_DBDataSet.fn_jugadores_por_nacionalidad, NacionalidadJugadorToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Establecer la cadena de conexión
        Dim connectionString As String = "Server=.;Database=LIGA_01_DB;Integrated security=true;"

        ' Crear la consulta SQL
        Dim query As String = "SELECT * FROM fn_jugadores_por_nacionalidad('Peruano') ORDER BY NombreJugador ASC, ApellidoJugador ASC;"

        ' Usar la conexión a la base de datos
        Using connection As New SqlConnection(connectionString)
            Try
                ' Abrir la conexión
                connection.Open()

                ' Crear el comando SQL
                Dim command As New SqlCommand(query, connection)

                ' Crear un adaptador para ejecutar la consulta y llenar el DataTable
                Dim adapter As New SqlDataAdapter(command)
                Dim dataTable As New DataTable()

                ' Llenar el DataTable con los resultados de la consulta
                adapter.Fill(dataTable)

                ' Asignar el DataTable como fuente de datos del DataGridView
                Fn_jugadores_por_nacionalidadDataGridView.DataSource = dataTable

            Catch ex As Exception
                ' Manejar errores
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Definir la cadena de conexión a la base de datos
        Dim connectionString As String = "Server=.;Database=PRESENTACION_FINAL;Integrated Security=True;"

        ' Obtener la fecha de nacimiento desde el TextBox
        Dim fechaNacimiento As Date = DateTime.Parse(TextNacimiento.Text)

        ' Establecer la conexión y el comando SQL
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Definir el comando SQL para ejecutar la función fn_calcular_edad
            Dim query As String = "SELECT dbo.fn_calcular_edad(@FechaNacimiento)"

            Using command As New SqlCommand(query, connection)
                ' Agregar el parámetro al comando SQL
                command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento)

                ' Ejecutar el comando y obtener el resultado
                Dim edad As Integer = Convert.ToInt32(command.ExecuteScalar())

                ' Mostrar el resultado en el TextBox TextEdad
                TextEdad.Text = edad.ToString()
            End Using
        End Using
    End Sub

    Private Sub TextNacimiento_TextChanged(sender As Object, e As EventArgs) Handles TextNacimiento.TextChanged

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub
End Class