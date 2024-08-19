<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArbitro
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
        Dim IdTipoIdenticacionLabel As System.Windows.Forms.Label
        Dim CodigoIdentificacionLabel As System.Windows.Forms.Label
        Dim IdTipoArbitroLabel As System.Windows.Forms.Label
        Dim NombreArbitroLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArbitro))
        Me.LIGA_01_DBDataSet = New WindowsApplication2.LIGA_01_DBDataSet()
        Me.ARBITROBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ARBITROTableAdapter = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.ARBITROTableAdapter()
        Me.TableAdapterManager = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.TableAdapterManager()
        Me.IDENTIFICACIONTableAdapter = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.IDENTIFICACIONTableAdapter()
        Me.ARBITROBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ARBITROBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ARBITRODataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LIGA_01_DBDataSet1 = New WindowsApplication2.LIGA_01_DBDataSet1()
        Me.TIPOARBITROBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TIPO_ARBITROTableAdapter = New WindowsApplication2.LIGA_01_DBDataSet1TableAdapters.TIPO_ARBITROTableAdapter()
        Me.IDENTIFICACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdTipoIdenticacionTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoIdentificacionTextBox = New System.Windows.Forms.TextBox()
        Me.IdTipoArbitroTextBox = New System.Windows.Forms.TextBox()
        Me.NombreArbitroTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        IdTipoIdenticacionLabel = New System.Windows.Forms.Label()
        CodigoIdentificacionLabel = New System.Windows.Forms.Label()
        IdTipoArbitroLabel = New System.Windows.Forms.Label()
        NombreArbitroLabel = New System.Windows.Forms.Label()
        CType(Me.LIGA_01_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARBITROBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARBITROBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ARBITROBindingNavigator.SuspendLayout()
        CType(Me.ARBITRODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIGA_01_DBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIPOARBITROBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDENTIFICACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdTipoIdenticacionLabel
        '
        IdTipoIdenticacionLabel.AutoSize = True
        IdTipoIdenticacionLabel.Location = New System.Drawing.Point(142, 205)
        IdTipoIdenticacionLabel.Name = "IdTipoIdenticacionLabel"
        IdTipoIdenticacionLabel.Size = New System.Drawing.Size(104, 13)
        IdTipoIdenticacionLabel.TabIndex = 20
        IdTipoIdenticacionLabel.Text = "Id Tipo Identicacion:"
        '
        'CodigoIdentificacionLabel
        '
        CodigoIdentificacionLabel.AutoSize = True
        CodigoIdentificacionLabel.Location = New System.Drawing.Point(142, 179)
        CodigoIdentificacionLabel.Name = "CodigoIdentificacionLabel"
        CodigoIdentificacionLabel.Size = New System.Drawing.Size(109, 13)
        CodigoIdentificacionLabel.TabIndex = 18
        CodigoIdentificacionLabel.Text = "Codigo Identificacion:"
        '
        'IdTipoArbitroLabel
        '
        IdTipoArbitroLabel.AutoSize = True
        IdTipoArbitroLabel.Location = New System.Drawing.Point(142, 153)
        IdTipoArbitroLabel.Name = "IdTipoArbitroLabel"
        IdTipoArbitroLabel.Size = New System.Drawing.Size(76, 13)
        IdTipoArbitroLabel.TabIndex = 16
        IdTipoArbitroLabel.Text = "Id Tipo Arbitro:"
        '
        'NombreArbitroLabel
        '
        NombreArbitroLabel.AutoSize = True
        NombreArbitroLabel.Location = New System.Drawing.Point(142, 127)
        NombreArbitroLabel.Name = "NombreArbitroLabel"
        NombreArbitroLabel.Size = New System.Drawing.Size(80, 13)
        NombreArbitroLabel.TabIndex = 14
        NombreArbitroLabel.Text = "Nombre Arbitro:"
        '
        'LIGA_01_DBDataSet
        '
        Me.LIGA_01_DBDataSet.DataSetName = "LIGA_01_DBDataSet"
        Me.LIGA_01_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ARBITROBindingSource
        '
        Me.ARBITROBindingSource.DataMember = "ARBITRO"
        Me.ARBITROBindingSource.DataSource = Me.LIGA_01_DBDataSet
        '
        'ARBITROTableAdapter
        '
        Me.ARBITROTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ARBITROTableAdapter = Me.ARBITROTableAdapter
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
        Me.TableAdapterManager.ESTADIOTableAdapter = Nothing
        Me.TableAdapterManager.ESTADOSTableAdapter = Nothing
        Me.TableAdapterManager.ETAPA_FECHATableAdapter = Nothing
        Me.TableAdapterManager.ETAPATableAdapter = Nothing
        Me.TableAdapterManager.FECHATableAdapter = Nothing
        Me.TableAdapterManager.FICHA_PROGRAMACIÓNTableAdapter = Nothing
        Me.TableAdapterManager.IDENTIFICACIONTableAdapter = Me.IDENTIFICACIONTableAdapter
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
        'IDENTIFICACIONTableAdapter
        '
        Me.IDENTIFICACIONTableAdapter.ClearBeforeFill = True
        '
        'ARBITROBindingNavigator
        '
        Me.ARBITROBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ARBITROBindingNavigator.BindingSource = Me.ARBITROBindingSource
        Me.ARBITROBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ARBITROBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ARBITROBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ARBITROBindingNavigatorSaveItem})
        Me.ARBITROBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ARBITROBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ARBITROBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ARBITROBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ARBITROBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ARBITROBindingNavigator.Name = "ARBITROBindingNavigator"
        Me.ARBITROBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ARBITROBindingNavigator.Size = New System.Drawing.Size(862, 25)
        Me.ARBITROBindingNavigator.TabIndex = 0
        Me.ARBITROBindingNavigator.Text = "BindingNavigator1"
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
        'ARBITROBindingNavigatorSaveItem
        '
        Me.ARBITROBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ARBITROBindingNavigatorSaveItem.Image = CType(resources.GetObject("ARBITROBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ARBITROBindingNavigatorSaveItem.Name = "ARBITROBindingNavigatorSaveItem"
        Me.ARBITROBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ARBITROBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ARBITRODataGridView
        '
        Me.ARBITRODataGridView.AutoGenerateColumns = False
        Me.ARBITRODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ARBITRODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.ARBITRODataGridView.DataSource = Me.ARBITROBindingSource
        Me.ARBITRODataGridView.Location = New System.Drawing.Point(145, 253)
        Me.ARBITRODataGridView.Name = "ARBITRODataGridView"
        Me.ARBITRODataGridView.Size = New System.Drawing.Size(543, 220)
        Me.ARBITRODataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdArbitro"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdArbitro"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NombreArbitro"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NombreArbitro"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IdTipoArbitro"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IdTipoArbitro"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CodigoIdentificacion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CodigoIdentificacion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "IdTipoIdenticacion"
        Me.DataGridViewTextBoxColumn5.HeaderText = "IdTipoIdenticacion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(231, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(395, 37)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "FORMULARIO ARBITRO"
        '
        'LIGA_01_DBDataSet1
        '
        Me.LIGA_01_DBDataSet1.DataSetName = "LIGA_01_DBDataSet1"
        Me.LIGA_01_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TIPOARBITROBindingSource
        '
        Me.TIPOARBITROBindingSource.DataMember = "TIPO_ARBITRO"
        Me.TIPOARBITROBindingSource.DataSource = Me.LIGA_01_DBDataSet1
        '
        'TIPO_ARBITROTableAdapter
        '
        Me.TIPO_ARBITROTableAdapter.ClearBeforeFill = True
        '
        'IDENTIFICACIONBindingSource
        '
        Me.IDENTIFICACIONBindingSource.DataMember = "IDENTIFICACION"
        Me.IDENTIFICACIONBindingSource.DataSource = Me.LIGA_01_DBDataSet
        '
        'IdTipoIdenticacionTextBox
        '
        Me.IdTipoIdenticacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ARBITROBindingSource, "IdTipoIdenticacion", True))
        Me.IdTipoIdenticacionTextBox.Location = New System.Drawing.Point(257, 202)
        Me.IdTipoIdenticacionTextBox.Name = "IdTipoIdenticacionTextBox"
        Me.IdTipoIdenticacionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTipoIdenticacionTextBox.TabIndex = 21
        '
        'CodigoIdentificacionTextBox
        '
        Me.CodigoIdentificacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ARBITROBindingSource, "CodigoIdentificacion", True))
        Me.CodigoIdentificacionTextBox.Location = New System.Drawing.Point(257, 176)
        Me.CodigoIdentificacionTextBox.Name = "CodigoIdentificacionTextBox"
        Me.CodigoIdentificacionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoIdentificacionTextBox.TabIndex = 19
        '
        'IdTipoArbitroTextBox
        '
        Me.IdTipoArbitroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ARBITROBindingSource, "IdTipoArbitro", True))
        Me.IdTipoArbitroTextBox.Location = New System.Drawing.Point(257, 150)
        Me.IdTipoArbitroTextBox.Name = "IdTipoArbitroTextBox"
        Me.IdTipoArbitroTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTipoArbitroTextBox.TabIndex = 17
        Me.IdTipoArbitroTextBox.Visible = False
        '
        'NombreArbitroTextBox
        '
        Me.NombreArbitroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ARBITROBindingSource, "NombreArbitro", True))
        Me.NombreArbitroTextBox.Location = New System.Drawing.Point(257, 124)
        Me.NombreArbitroTextBox.Name = "NombreArbitroTextBox"
        Me.NombreArbitroTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreArbitroTextBox.TabIndex = 15
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ARBITROBindingSource, "IdTipoArbitro", True))
        Me.ComboBox1.DataSource = Me.TIPOARBITROBindingSource
        Me.ComboBox1.DisplayMember = "NombreTipo"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(257, 150)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 22
        Me.ComboBox1.ValueMember = "IdTipoArbitro"
        '
        'frmArbitro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(862, 504)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(NombreArbitroLabel)
        Me.Controls.Add(Me.NombreArbitroTextBox)
        Me.Controls.Add(IdTipoArbitroLabel)
        Me.Controls.Add(Me.IdTipoArbitroTextBox)
        Me.Controls.Add(CodigoIdentificacionLabel)
        Me.Controls.Add(Me.CodigoIdentificacionTextBox)
        Me.Controls.Add(IdTipoIdenticacionLabel)
        Me.Controls.Add(Me.IdTipoIdenticacionTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ARBITRODataGridView)
        Me.Controls.Add(Me.ARBITROBindingNavigator)
        Me.Name = "frmArbitro"
        Me.Text = "frmArbitro"
        CType(Me.LIGA_01_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARBITROBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARBITROBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ARBITROBindingNavigator.ResumeLayout(False)
        Me.ARBITROBindingNavigator.PerformLayout()
        CType(Me.ARBITRODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIGA_01_DBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIPOARBITROBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDENTIFICACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LIGA_01_DBDataSet As LIGA_01_DBDataSet
    Friend WithEvents ARBITROBindingSource As BindingSource
    Friend WithEvents ARBITROTableAdapter As LIGA_01_DBDataSetTableAdapters.ARBITROTableAdapter
    Friend WithEvents TableAdapterManager As LIGA_01_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ARBITROBindingNavigator As BindingNavigator
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
    Friend WithEvents ARBITROBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ARBITRODataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents LIGA_01_DBDataSet1 As LIGA_01_DBDataSet1
    Friend WithEvents TIPOARBITROBindingSource As BindingSource
    Friend WithEvents TIPO_ARBITROTableAdapter As LIGA_01_DBDataSet1TableAdapters.TIPO_ARBITROTableAdapter
    Friend WithEvents IDENTIFICACIONTableAdapter As LIGA_01_DBDataSetTableAdapters.IDENTIFICACIONTableAdapter
    Friend WithEvents IDENTIFICACIONBindingSource As BindingSource
    Friend WithEvents IdTipoIdenticacionTextBox As TextBox
    Friend WithEvents CodigoIdentificacionTextBox As TextBox
    Friend WithEvents IdTipoArbitroTextBox As TextBox
    Friend WithEvents NombreArbitroTextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
