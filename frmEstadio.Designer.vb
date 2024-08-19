<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstadio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NombreEstadioLabel As System.Windows.Forms.Label
        Dim UbicaciónEstadioLabel As System.Windows.Forms.Label
        Dim AforoEstadioLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstadio))
        Me.LIGA_01_DBDataSet = New WindowsApplication2.LIGA_01_DBDataSet()
        Me.ESTADIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ESTADIOTableAdapter = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.ESTADIOTableAdapter()
        Me.TableAdapterManager = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.TableAdapterManager()
        Me.ESTADIOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ESTADIOBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ESTADIODataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreEstadioTextBox = New System.Windows.Forms.TextBox()
        Me.UbicaciónEstadioTextBox = New System.Windows.Forms.TextBox()
        Me.AforoEstadioTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        NombreEstadioLabel = New System.Windows.Forms.Label()
        UbicaciónEstadioLabel = New System.Windows.Forms.Label()
        AforoEstadioLabel = New System.Windows.Forms.Label()
        CType(Me.LIGA_01_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESTADIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESTADIOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ESTADIOBindingNavigator.SuspendLayout()
        CType(Me.ESTADIODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreEstadioLabel
        '
        NombreEstadioLabel.AutoSize = True
        NombreEstadioLabel.Location = New System.Drawing.Point(107, 136)
        NombreEstadioLabel.Name = "NombreEstadioLabel"
        NombreEstadioLabel.Size = New System.Drawing.Size(85, 13)
        NombreEstadioLabel.TabIndex = 4
        NombreEstadioLabel.Text = "Nombre Estadio:"
        '
        'UbicaciónEstadioLabel
        '
        UbicaciónEstadioLabel.AutoSize = True
        UbicaciónEstadioLabel.Location = New System.Drawing.Point(107, 162)
        UbicaciónEstadioLabel.Name = "UbicaciónEstadioLabel"
        UbicaciónEstadioLabel.Size = New System.Drawing.Size(96, 13)
        UbicaciónEstadioLabel.TabIndex = 6
        UbicaciónEstadioLabel.Text = "Ubicación Estadio:"
        '
        'AforoEstadioLabel
        '
        AforoEstadioLabel.AutoSize = True
        AforoEstadioLabel.Location = New System.Drawing.Point(107, 188)
        AforoEstadioLabel.Name = "AforoEstadioLabel"
        AforoEstadioLabel.Size = New System.Drawing.Size(73, 13)
        AforoEstadioLabel.TabIndex = 8
        AforoEstadioLabel.Text = "Aforo Estadio:"
        '
        'LIGA_01_DBDataSet
        '
        Me.LIGA_01_DBDataSet.DataSetName = "LIGA_01_DBDataSet"
        Me.LIGA_01_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ESTADIOBindingSource
        '
        Me.ESTADIOBindingSource.DataMember = "ESTADIO"
        Me.ESTADIOBindingSource.DataSource = Me.LIGA_01_DBDataSet
        '
        'ESTADIOTableAdapter
        '
        Me.ESTADIOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ARBITROTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CERTIFICADO_LESIONTableAdapter = Nothing
        Me.TableAdapterManager.CERTIFICADO_MEDICOTableAdapter = Nothing
        Me.TableAdapterManager.CLUBTableAdapter = Nothing
        Me.TableAdapterManager.CONTRATOTableAdapter = Nothing
        Me.TableAdapterManager.DELEGADO_PARTIDOTableAdapter = Nothing
        Me.TableAdapterManager.DETALLE_ENFRENTAMIENTOTableAdapter = Nothing
        Me.TableAdapterManager.DETALLE_SOLICITUDTableAdapter = Nothing
        Me.TableAdapterManager.E_ARBITRAJE_ARBITROTableAdapter = Nothing
        Me.TableAdapterManager.ENFRENTAMIENTOTableAdapter = Nothing
        Me.TableAdapterManager.EQUIPO_ARBITRAJETableAdapter = Nothing
        Me.TableAdapterManager.ESTADIOTableAdapter = Me.ESTADIOTableAdapter
        Me.TableAdapterManager.ESTADOSTableAdapter = Nothing
        Me.TableAdapterManager.ETAPA_FECHATableAdapter = Nothing
        Me.TableAdapterManager.ETAPATableAdapter = Nothing
        Me.TableAdapterManager.FECHATableAdapter = Nothing
        Me.TableAdapterManager.FICHA_PROGRAMACIÓNTableAdapter = Nothing
        Me.TableAdapterManager.IDENTIFICACIONTableAdapter = Nothing
        Me.TableAdapterManager.JUGADOR_CLUBTableAdapter = Nothing
        Me.TableAdapterManager.JUGADORTableAdapter = Nothing
        Me.TableAdapterManager.LESIONTableAdapter = Nothing
        Me.TableAdapterManager.OPERACION_FICHAPROGRAMACIONTableAdapter = Nothing
        Me.TableAdapterManager.OPERACION_REPORTE_ADMISIONTableAdapter = Nothing
        Me.TableAdapterManager.REPORTE_ADMISIONTableAdapter = Nothing
        Me.TableAdapterManager.REPRESENTANTE_CLUBTableAdapter = Nothing
        Me.TableAdapterManager.SOLICITUDTableAdapter = Nothing
        Me.TableAdapterManager.TELEFONO_JUGADORTableAdapter = Nothing
        Me.TableAdapterManager.TELEFONOTableAdapter = Nothing
        Me.TableAdapterManager.TIPO_ARBITROTableAdapter = Nothing
        Me.TableAdapterManager.TIPO_IDENTIFICACIONTableAdapter = Nothing
        Me.TableAdapterManager.TIPO_USUARIOTableAdapter = Nothing
        Me.TableAdapterManager.TORNEO_ETAPATableAdapter = Nothing
        Me.TableAdapterManager.TORNEOTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication2.LIGA_01_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USUARIOTableAdapter = Nothing
        '
        'ESTADIOBindingNavigator
        '
        Me.ESTADIOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ESTADIOBindingNavigator.BindingSource = Me.ESTADIOBindingSource
        Me.ESTADIOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ESTADIOBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ESTADIOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ESTADIOBindingNavigatorSaveItem})
        Me.ESTADIOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ESTADIOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ESTADIOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ESTADIOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ESTADIOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ESTADIOBindingNavigator.Name = "ESTADIOBindingNavigator"
        Me.ESTADIOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ESTADIOBindingNavigator.Size = New System.Drawing.Size(627, 25)
        Me.ESTADIOBindingNavigator.TabIndex = 0
        Me.ESTADIOBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ESTADIOBindingNavigatorSaveItem
        '
        Me.ESTADIOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ESTADIOBindingNavigatorSaveItem.Image = CType(resources.GetObject("ESTADIOBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ESTADIOBindingNavigatorSaveItem.Name = "ESTADIOBindingNavigatorSaveItem"
        Me.ESTADIOBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ESTADIOBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ESTADIODataGridView
        '
        Me.ESTADIODataGridView.AutoGenerateColumns = False
        Me.ESTADIODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ESTADIODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ESTADIODataGridView.DataSource = Me.ESTADIOBindingSource
        Me.ESTADIODataGridView.Location = New System.Drawing.Point(91, 234)
        Me.ESTADIODataGridView.Name = "ESTADIODataGridView"
        Me.ESTADIODataGridView.Size = New System.Drawing.Size(442, 220)
        Me.ESTADIODataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdEstadio"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdEstadio"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NombreEstadio"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NombreEstadio"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "UbicaciónEstadio"
        Me.DataGridViewTextBoxColumn3.HeaderText = "UbicaciónEstadio"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "AforoEstadio"
        Me.DataGridViewTextBoxColumn4.HeaderText = "AforoEstadio"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'NombreEstadioTextBox
        '
        Me.NombreEstadioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ESTADIOBindingSource, "NombreEstadio", True))
        Me.NombreEstadioTextBox.Location = New System.Drawing.Point(209, 133)
        Me.NombreEstadioTextBox.Name = "NombreEstadioTextBox"
        Me.NombreEstadioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreEstadioTextBox.TabIndex = 5
        '
        'UbicaciónEstadioTextBox
        '
        Me.UbicaciónEstadioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ESTADIOBindingSource, "UbicaciónEstadio", True))
        Me.UbicaciónEstadioTextBox.Location = New System.Drawing.Point(209, 159)
        Me.UbicaciónEstadioTextBox.Name = "UbicaciónEstadioTextBox"
        Me.UbicaciónEstadioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UbicaciónEstadioTextBox.TabIndex = 7
        '
        'AforoEstadioTextBox
        '
        Me.AforoEstadioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ESTADIOBindingSource, "AforoEstadio", True))
        Me.AforoEstadioTextBox.Location = New System.Drawing.Point(209, 185)
        Me.AforoEstadioTextBox.Name = "AforoEstadioTextBox"
        Me.AforoEstadioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AforoEstadioTextBox.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(395, 37)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "FORMULARIO ESTADIO"
        '
        'frmEstadio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 480)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(NombreEstadioLabel)
        Me.Controls.Add(Me.NombreEstadioTextBox)
        Me.Controls.Add(UbicaciónEstadioLabel)
        Me.Controls.Add(Me.UbicaciónEstadioTextBox)
        Me.Controls.Add(AforoEstadioLabel)
        Me.Controls.Add(Me.AforoEstadioTextBox)
        Me.Controls.Add(Me.ESTADIODataGridView)
        Me.Controls.Add(Me.ESTADIOBindingNavigator)
        Me.Name = "frmEstadio"
        Me.Text = "frmEstadio"
        CType(Me.LIGA_01_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESTADIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESTADIOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ESTADIOBindingNavigator.ResumeLayout(False)
        Me.ESTADIOBindingNavigator.PerformLayout()
        CType(Me.ESTADIODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LIGA_01_DBDataSet As LIGA_01_DBDataSet
    Friend WithEvents ESTADIOBindingSource As BindingSource
    Friend WithEvents ESTADIOTableAdapter As LIGA_01_DBDataSetTableAdapters.ESTADIOTableAdapter
    Friend WithEvents TableAdapterManager As LIGA_01_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ESTADIOBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ESTADIOBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ESTADIODataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents NombreEstadioTextBox As TextBox
    Friend WithEvents UbicaciónEstadioTextBox As TextBox
    Friend WithEvents AforoEstadioTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
