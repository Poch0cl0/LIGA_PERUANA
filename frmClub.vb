Public Class frmClub
    Private Sub CLUBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CLUBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CLUBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LIGA_01_DBDataSet)

    End Sub

    Private Sub frmClub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LIGA_01_DBDataSet.CLUB' Puede moverla o quitarla según sea necesario.
        Me.CLUBTableAdapter.Fill(Me.LIGA_01_DBDataSet.CLUB)

    End Sub
End Class