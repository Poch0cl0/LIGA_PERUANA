Public Class frmCertificadoM
    Private Sub CERTIFICADO_MEDICOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CERTIFICADO_MEDICOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CERTIFICADO_MEDICOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LIGA_01_DBDataSet)

    End Sub

    Private Sub frmCertificadoM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LIGA_01_DBDataSet.CERTIFICADO_MEDICO' Puede moverla o quitarla según sea necesario.
        Me.CERTIFICADO_MEDICOTableAdapter.Fill(Me.LIGA_01_DBDataSet.CERTIFICADO_MEDICO)

    End Sub
End Class