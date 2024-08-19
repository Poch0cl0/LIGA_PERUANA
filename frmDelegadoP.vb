Public Class frmDelegadoP
    Private Sub DELEGADO_PARTIDOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DELEGADO_PARTIDOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DELEGADO_PARTIDOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LIGA_01_DBDataSet)

    End Sub

    Private Sub frmDelegadoP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LIGA_01_DBDataSet.DELEGADO_PARTIDO' Puede moverla o quitarla según sea necesario.
        Me.DELEGADO_PARTIDOTableAdapter.Fill(Me.LIGA_01_DBDataSet.DELEGADO_PARTIDO)

    End Sub
End Class