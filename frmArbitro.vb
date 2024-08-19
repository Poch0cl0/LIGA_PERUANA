Public Class frmArbitro
    Private Sub ARBITROBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ARBITROBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ARBITROBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LIGA_01_DBDataSet)

    End Sub

    Private Sub frmArbitro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LIGA_01_DBDataSet.IDENTIFICACION' Puede moverla o quitarla según sea necesario.
        Me.IDENTIFICACIONTableAdapter.Fill(Me.LIGA_01_DBDataSet.IDENTIFICACION)
        'TODO: esta línea de código carga datos en la tabla 'LIGA_01_DBDataSet1.TIPO_ARBITRO' Puede moverla o quitarla según sea necesario.
        Me.TIPO_ARBITROTableAdapter.Fill(Me.LIGA_01_DBDataSet1.TIPO_ARBITRO)
        'TODO: esta línea de código carga datos en la tabla 'LIGA_01_DBDataSet.ARBITRO' Puede moverla o quitarla según sea necesario.
        Me.ARBITROTableAdapter.Fill(Me.LIGA_01_DBDataSet.ARBITRO)

    End Sub

    Private Sub NombreArbitroTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CodigoIdentificacionTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) 

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_2(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedValue IsNot Nothing Then
            IdTipoArbitroTextBox.Text = ComboBox1.SelectedValue.ToString()
        End If
    End Sub
End Class