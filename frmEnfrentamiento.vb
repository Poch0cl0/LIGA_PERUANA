Public Class frmEnfrentamiento
    Private Sub DETALLE_ENFRENTAMIENTOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DETALLE_ENFRENTAMIENTOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DETALLE_ENFRENTAMIENTOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LIGA_01_DBDataSet)

    End Sub

    Private Sub frmEnfrentamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LIGA_01_DBDataSet.FECHA' Puede moverla o quitarla según sea necesario.
        Me.FECHATableAdapter.Fill(Me.LIGA_01_DBDataSet.FECHA)
        'TODO: esta línea de código carga datos en la tabla 'LIGA_01_DBDataSet.TORNEO' Puede moverla o quitarla según sea necesario.
        Me.TORNEOTableAdapter.Fill(Me.LIGA_01_DBDataSet.TORNEO)
        'TODO: esta línea de código carga datos en la tabla 'LIGA_01_DBDataSet.ETAPA' Puede moverla o quitarla según sea necesario.
        Me.ETAPATableAdapter.Fill(Me.LIGA_01_DBDataSet.ETAPA)
        'TODO: esta línea de código carga datos en la tabla 'LIGA_01_DBDataSet.CLUB' Puede moverla o quitarla según sea necesario.
        Me.CLUBTableAdapter.Fill(Me.LIGA_01_DBDataSet.CLUB)
        'TODO: esta línea de código carga datos en la tabla 'LIGA_01_DBDataSet.EQUIPO_ARBITRAJE' Puede moverla o quitarla según sea necesario.
        Me.EQUIPO_ARBITRAJETableAdapter.Fill(Me.LIGA_01_DBDataSet.EQUIPO_ARBITRAJE)
        'TODO: esta línea de código carga datos en la tabla 'LIGA_01_DBDataSet.ESTADIO' Puede moverla o quitarla según sea necesario.
        Me.ESTADIOTableAdapter.Fill(Me.LIGA_01_DBDataSet.ESTADIO)
        'TODO: esta línea de código carga datos en la tabla 'LIGA_01_DBDataSet.DETALLE_ENFRENTAMIENTO' Puede moverla o quitarla según sea necesario.
        Me.DETALLE_ENFRENTAMIENTOTableAdapter.Fill(Me.LIGA_01_DBDataSet.DETALLE_ENFRENTAMIENTO)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        If ComboBox1.SelectedValue IsNot Nothing Then
            IdEstadioTextBox.Text = ComboBox1.SelectedValue.ToString()
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedValue IsNot Nothing Then
            IdEquipoArbitrajeTextBox.Text = ComboBox2.SelectedValue.ToString()
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        If ComboBox4.SelectedValue IsNot Nothing Then
            IdClubVisitanteTextBox.Text = ComboBox4.SelectedValue.ToString()
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.SelectedValue IsNot Nothing Then
            IdClubLocalTextBox.Text = ComboBox3.SelectedValue.ToString()
        End If
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        If ComboBox5.SelectedValue IsNot Nothing Then
            IdEtapaTextBox.Text = ComboBox5.SelectedValue.ToString()
        End If
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        If ComboBox6.SelectedValue IsNot Nothing Then
            IdTorneoTextBox.Text = ComboBox6.SelectedValue.ToString()
        End If
    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedIndexChanged
        If ComboBox7.SelectedValue IsNot Nothing Then
            IdFechaTextBox.Text = ComboBox7.SelectedValue.ToString()
        End If
    End Sub
End Class