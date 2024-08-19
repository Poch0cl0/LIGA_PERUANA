Public Class frmContrato
    Private Sub CONTRATOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CONTRATOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CONTRATOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LIGA_01_DBDataSet)

    End Sub

    Private Sub frmContrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LIGA_01_DBDataSet.CONTRATO' Puede moverla o quitarla según sea necesario.
        Me.CONTRATOTableAdapter.Fill(Me.LIGA_01_DBDataSet.CONTRATO)

    End Sub
End Class