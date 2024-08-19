Public Class frmJugador
    Private Sub JUGADORBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles JUGADORBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.JUGADORBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LIGA_01_DBDataSet)

    End Sub

    Private Sub frmJugador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LIGA_01_DBDataSet.JUGADOR' Puede moverla o quitarla según sea necesario.
        Me.JUGADORTableAdapter.Fill(Me.LIGA_01_DBDataSet.JUGADOR)

    End Sub
End Class