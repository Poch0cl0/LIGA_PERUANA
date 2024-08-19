Public Class frmEstadio
    Private Sub ESTADIOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ESTADIOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ESTADIOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LIGA_01_DBDataSet)

    End Sub

    Private Sub frmEstadio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LIGA_01_DBDataSet.ESTADIO' Puede moverla o quitarla según sea necesario.
        Me.ESTADIOTableAdapter.Fill(Me.LIGA_01_DBDataSet.ESTADIO)

    End Sub
End Class