Public Class frmSolicitud
    Private Sub DETALLE_SOLICITUDBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DETALLE_SOLICITUDBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DETALLE_SOLICITUDBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LIGA_01_DBDataSet)

    End Sub

    Private Sub frmSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LIGA_01_DBDataSet.ETAPA' Puede moverla o quitarla según sea necesario.
        Me.ETAPATableAdapter.Fill(Me.LIGA_01_DBDataSet.ETAPA)
        'TODO: esta línea de código carga datos en la tabla 'LIGA_01_DBDataSet.TORNEO' Puede moverla o quitarla según sea necesario.
        Me.TORNEOTableAdapter.Fill(Me.LIGA_01_DBDataSet.TORNEO)
        'TODO: esta línea de código carga datos en la tabla 'LIGA_01_DBDataSet.CLUB' Puede moverla o quitarla según sea necesario.
        Me.CLUBTableAdapter.Fill(Me.LIGA_01_DBDataSet.CLUB)
        'TODO: esta línea de código carga datos en la tabla 'LIGA_01_DBDataSet.DETALLE_SOLICITUD' Puede moverla o quitarla según sea necesario.
        Me.DETALLE_SOLICITUDTableAdapter.Fill(Me.LIGA_01_DBDataSet.DETALLE_SOLICITUD)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedValue IsNot Nothing Then
            IdClubTextBox.Text = ComboBox1.SelectedValue.ToString()
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedValue IsNot Nothing Then
            IdTorneoTextBox.Text = ComboBox2.SelectedValue.ToString()
        End If
    End Sub
End Class