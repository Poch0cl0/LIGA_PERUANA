Public Class frmFichaP
    Private Sub FICHA_PROGRAMACIÓNBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FICHA_PROGRAMACIÓNBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FICHA_PROGRAMACIÓNBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LIGA_01_DBDataSet)

    End Sub

    Private Sub frmFichaP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LIGA_01_DBDataSet.FECHA' Puede moverla o quitarla según sea necesario.
        Me.FECHATableAdapter.Fill(Me.LIGA_01_DBDataSet.FECHA)
        'TODO: esta línea de código carga datos en la tabla 'LIGA_01_DBDataSet.TORNEO' Puede moverla o quitarla según sea necesario.
        Me.TORNEOTableAdapter.Fill(Me.LIGA_01_DBDataSet.TORNEO)
        'TODO: esta línea de código carga datos en la tabla 'LIGA_01_DBDataSet.ETAPA' Puede moverla o quitarla según sea necesario.
        Me.ETAPATableAdapter.Fill(Me.LIGA_01_DBDataSet.ETAPA)
        'TODO: esta línea de código carga datos en la tabla 'LIGA_01_DBDataSet.FICHA_PROGRAMACIÓN' Puede moverla o quitarla según sea necesario.
        Me.FICHA_PROGRAMACIÓNTableAdapter.Fill(Me.LIGA_01_DBDataSet.FICHA_PROGRAMACIÓN)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedValue IsNot Nothing Then
            IdEtapaTextBox.Text = ComboBox1.SelectedValue.ToString()
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedValue IsNot Nothing Then
            IdTorneoTextBox.Text = ComboBox2.SelectedValue.ToString()
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.SelectedValue IsNot Nothing Then
            IdFechaTextBox.Text = ComboBox3.SelectedValue.ToString()
        End If
    End Sub
End Class