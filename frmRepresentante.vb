Public Class frmRepresentante
    Private Sub REPRESENTANTE_CLUBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles REPRESENTANTE_CLUBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.REPRESENTANTE_CLUBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LIGA_01_DBDataSet)

    End Sub

    Private Sub frmRepresentante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LIGA_01_DBDataSet.REPRESENTANTE_CLUB' Puede moverla o quitarla según sea necesario.
        Me.REPRESENTANTE_CLUBTableAdapter.Fill(Me.LIGA_01_DBDataSet.REPRESENTANTE_CLUB)

    End Sub
End Class