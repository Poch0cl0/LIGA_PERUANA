<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContrato
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContrato))
        Dim IdContratoLabel As System.Windows.Forms.Label
        Dim FechaInicioLabel As System.Windows.Forms.Label
        Dim FechaFinalLabel As System.Windows.Forms.Label
        Dim IdEstadoLabel As System.Windows.Forms.Label
        Dim CodigoIdentificacionLabel As System.Windows.Forms.Label
        Dim IdTipoIdenticacionLabel As System.Windows.Forms.Label
        Dim IdClubLabel As System.Windows.Forms.Label
        Me.LIGA_01_DBDataSet = New WindowsApplication2.LIGA_01_DBDataSet()
        Me.CONTRATOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONTRATOTableAdapter = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.CONTRATOTableAdapter()
        Me.TableAdapterManager = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.TableAdapterManager()
        Me.CONTRATOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.CONTRATOBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CONTRATODataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdContratoTextBox = New System.Windows.Forms.TextBox()
        Me.FechaInicioDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FechaFinalDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IdEstadoTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoIdentificacionTextBox = New System.Windows.Forms.TextBox()
        Me.IdTipoIdenticacionTextBox = New System.Windows.Forms.TextBox()
        Me.IdClubTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        IdContratoLabel = New System.Windows.Forms.Label()
        FechaInicioLabel = New System.Windows.Forms.Label()
        FechaFinalLabel = New System.Windows.Forms.Label()
        IdEstadoLabel = New System.Windows.Forms.Label()
        CodigoIdentificacionLabel = New System.Windows.Forms.Label()
        IdTipoIdenticacionLabel = New System.Windows.Forms.Label()
        IdClubLabel = New System.Windows.Forms.Label()
        CType(Me.LIGA_01_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTRATOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTRATOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CONTRATOBindingNavigator.SuspendLayout()
        CType(Me.CONTRATODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LIGA_01_DBDataSet
        '
        Me.LIGA_01_DBDataSet.DataSetName = "LIGA_01_DBDataSet"
        Me.LIGA_01_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONTRATOBindingSource
        '
        Me.CONTRATOBindingSource.DataMember = "CONTRATO"
        Me.CONTRATOBindingSource.DataSource = Me.LIGA_01_DBDataSet
        '
        'CONTRATOTableAdapter
        '
        Me.CONTRATOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ARBITROTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CERTIFICADO_LESIONTableAdapter = Nothing
        Me.TableAdapterManager.CERTIFICADO_MEDICOTableAdapter = Nothing
        Me.TableAdapterManager.CLUBTableAdapter = Nothing
        Me.TableAdapterManager.CONTRATOTableAdapter = Me.CONTRATOTableAdapter
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
        'CONTRATOBindingNavigator
        '
        Me.CONTRATOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CONTRATOBindingNavigator.BindingSource = Me.CONTRATOBindingSource
        Me.CONTRATOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CONTRATOBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CONTRATOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CONTRATOBindingNavigatorSaveItem})
        Me.CONTRATOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CONTRATOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CONTRATOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CONTRATOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CONTRATOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CONTRATOBindingNavigator.Name = "CONTRATOBindingNavigator"
        Me.CONTRATOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CONTRATOBindingNavigator.Size = New System.Drawing.Size(953, 25)
        Me.CONTRATOBindingNavigator.TabIndex = 0
        Me.CONTRATOBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'CONTRATOBindingNavigatorSaveItem
        '
        Me.CONTRATOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CONTRATOBindingNavigatorSaveItem.Image = CType(resources.GetObject("CONTRATOBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CONTRATOBindingNavigatorSaveItem.Name = "CONTRATOBindingNavigatorSaveItem"
        Me.CONTRATOBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.CONTRATOBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CONTRATODataGridView
        '
        Me.CONTRATODataGridView.AutoGenerateColumns = False
        Me.CONTRATODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CONTRATODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.CONTRATODataGridView.DataSource = Me.CONTRATOBindingSource
        Me.CONTRATODataGridView.Location = New System.Drawing.Point(55, 276)
        Me.CONTRATODataGridView.Name = "CONTRATODataGridView"
        Me.CONTRATODataGridView.Size = New System.Drawing.Size(743, 220)
        Me.CONTRATODataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdContrato"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdContrato"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FechaInicio"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FechaInicio"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FechaFinal"
        Me.DataGridViewTextBoxColumn3.HeaderText = "FechaFinal"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IdEstado"
        Me.DataGridViewTextBoxColumn4.HeaderText = "IdEstado"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CodigoIdentificacion"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CodigoIdentificacion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IdTipoIdenticacion"
        Me.DataGridViewTextBoxColumn6.HeaderText = "IdTipoIdenticacion"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "IdClub"
        Me.DataGridViewTextBoxColumn7.HeaderText = "IdClub"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'IdContratoLabel
        '
        IdContratoLabel.AutoSize = True
        IdContratoLabel.Location = New System.Drawing.Point(73, 78)
        IdContratoLabel.Name = "IdContratoLabel"
        IdContratoLabel.Size = New System.Drawing.Size(62, 13)
        IdContratoLabel.TabIndex = 2
        IdContratoLabel.Text = "Id Contrato:"
        '
        'IdContratoTextBox
        '
        Me.IdContratoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTRATOBindingSource, "IdContrato", True))
        Me.IdContratoTextBox.Location = New System.Drawing.Point(188, 75)
        Me.IdContratoTextBox.Name = "IdContratoTextBox"
        Me.IdContratoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdContratoTextBox.TabIndex = 3
        '
        'FechaInicioLabel
        '
        FechaInicioLabel.AutoSize = True
        FechaInicioLabel.Location = New System.Drawing.Point(73, 105)
        FechaInicioLabel.Name = "FechaInicioLabel"
        FechaInicioLabel.Size = New System.Drawing.Size(68, 13)
        FechaInicioLabel.TabIndex = 4
        FechaInicioLabel.Text = "Fecha Inicio:"
        '
        'FechaInicioDateTimePicker
        '
        Me.FechaInicioDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CONTRATOBindingSource, "FechaInicio", True))
        Me.FechaInicioDateTimePicker.Location = New System.Drawing.Point(188, 101)
        Me.FechaInicioDateTimePicker.Name = "FechaInicioDateTimePicker"
        Me.FechaInicioDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaInicioDateTimePicker.TabIndex = 5
        '
        'FechaFinalLabel
        '
        FechaFinalLabel.AutoSize = True
        FechaFinalLabel.Location = New System.Drawing.Point(73, 131)
        FechaFinalLabel.Name = "FechaFinalLabel"
        FechaFinalLabel.Size = New System.Drawing.Size(65, 13)
        FechaFinalLabel.TabIndex = 6
        FechaFinalLabel.Text = "Fecha Final:"
        '
        'FechaFinalDateTimePicker
        '
        Me.FechaFinalDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CONTRATOBindingSource, "FechaFinal", True))
        Me.FechaFinalDateTimePicker.Location = New System.Drawing.Point(188, 127)
        Me.FechaFinalDateTimePicker.Name = "FechaFinalDateTimePicker"
        Me.FechaFinalDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaFinalDateTimePicker.TabIndex = 7
        '
        'IdEstadoLabel
        '
        IdEstadoLabel.AutoSize = True
        IdEstadoLabel.Location = New System.Drawing.Point(73, 156)
        IdEstadoLabel.Name = "IdEstadoLabel"
        IdEstadoLabel.Size = New System.Drawing.Size(55, 13)
        IdEstadoLabel.TabIndex = 8
        IdEstadoLabel.Text = "Id Estado:"
        '
        'IdEstadoTextBox
        '
        Me.IdEstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTRATOBindingSource, "IdEstado", True))
        Me.IdEstadoTextBox.Location = New System.Drawing.Point(188, 153)
        Me.IdEstadoTextBox.Name = "IdEstadoTextBox"
        Me.IdEstadoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdEstadoTextBox.TabIndex = 9
        '
        'CodigoIdentificacionLabel
        '
        CodigoIdentificacionLabel.AutoSize = True
        CodigoIdentificacionLabel.Location = New System.Drawing.Point(73, 182)
        CodigoIdentificacionLabel.Name = "CodigoIdentificacionLabel"
        CodigoIdentificacionLabel.Size = New System.Drawing.Size(109, 13)
        CodigoIdentificacionLabel.TabIndex = 10
        CodigoIdentificacionLabel.Text = "Codigo Identificacion:"
        '
        'CodigoIdentificacionTextBox
        '
        Me.CodigoIdentificacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTRATOBindingSource, "CodigoIdentificacion", True))
        Me.CodigoIdentificacionTextBox.Location = New System.Drawing.Point(188, 179)
        Me.CodigoIdentificacionTextBox.Name = "CodigoIdentificacionTextBox"
        Me.CodigoIdentificacionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CodigoIdentificacionTextBox.TabIndex = 11
        '
        'IdTipoIdenticacionLabel
        '
        IdTipoIdenticacionLabel.AutoSize = True
        IdTipoIdenticacionLabel.Location = New System.Drawing.Point(73, 208)
        IdTipoIdenticacionLabel.Name = "IdTipoIdenticacionLabel"
        IdTipoIdenticacionLabel.Size = New System.Drawing.Size(104, 13)
        IdTipoIdenticacionLabel.TabIndex = 12
        IdTipoIdenticacionLabel.Text = "Id Tipo Identicacion:"
        '
        'IdTipoIdenticacionTextBox
        '
        Me.IdTipoIdenticacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTRATOBindingSource, "IdTipoIdenticacion", True))
        Me.IdTipoIdenticacionTextBox.Location = New System.Drawing.Point(188, 205)
        Me.IdTipoIdenticacionTextBox.Name = "IdTipoIdenticacionTextBox"
        Me.IdTipoIdenticacionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdTipoIdenticacionTextBox.TabIndex = 13
        '
        'IdClubLabel
        '
        IdClubLabel.AutoSize = True
        IdClubLabel.Location = New System.Drawing.Point(73, 234)
        IdClubLabel.Name = "IdClubLabel"
        IdClubLabel.Size = New System.Drawing.Size(43, 13)
        IdClubLabel.TabIndex = 14
        IdClubLabel.Text = "Id Club:"
        '
        'IdClubTextBox
        '
        Me.IdClubTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTRATOBindingSource, "IdClub", True))
        Me.IdClubTextBox.Location = New System.Drawing.Point(188, 231)
        Me.IdClubTextBox.Name = "IdClubTextBox"
        Me.IdClubTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdClubTextBox.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(452, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(437, 37)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "FORMULARIO CONTRATO"
        '
        'frmContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 531)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(IdContratoLabel)
        Me.Controls.Add(Me.IdContratoTextBox)
        Me.Controls.Add(FechaInicioLabel)
        Me.Controls.Add(Me.FechaInicioDateTimePicker)
        Me.Controls.Add(FechaFinalLabel)
        Me.Controls.Add(Me.FechaFinalDateTimePicker)
        Me.Controls.Add(IdEstadoLabel)
        Me.Controls.Add(Me.IdEstadoTextBox)
        Me.Controls.Add(CodigoIdentificacionLabel)
        Me.Controls.Add(Me.CodigoIdentificacionTextBox)
        Me.Controls.Add(IdTipoIdenticacionLabel)
        Me.Controls.Add(Me.IdTipoIdenticacionTextBox)
        Me.Controls.Add(IdClubLabel)
        Me.Controls.Add(Me.IdClubTextBox)
        Me.Controls.Add(Me.CONTRATODataGridView)
        Me.Controls.Add(Me.CONTRATOBindingNavigator)
        Me.Name = "frmContrato"
        Me.Text = "frmContrato"
        CType(Me.LIGA_01_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTRATOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTRATOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CONTRATOBindingNavigator.ResumeLayout(False)
        Me.CONTRATOBindingNavigator.PerformLayout()
        CType(Me.CONTRATODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LIGA_01_DBDataSet As LIGA_01_DBDataSet
    Friend WithEvents CONTRATOBindingSource As BindingSource
    Friend WithEvents CONTRATOTableAdapter As LIGA_01_DBDataSetTableAdapters.CONTRATOTableAdapter
    Friend WithEvents TableAdapterManager As LIGA_01_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CONTRATOBindingNavigator As BindingNavigator
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
    Friend WithEvents CONTRATOBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CONTRATODataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents IdContratoTextBox As TextBox
    Friend WithEvents FechaInicioDateTimePicker As DateTimePicker
    Friend WithEvents FechaFinalDateTimePicker As DateTimePicker
    Friend WithEvents IdEstadoTextBox As TextBox
    Friend WithEvents CodigoIdentificacionTextBox As TextBox
    Friend WithEvents IdTipoIdenticacionTextBox As TextBox
    Friend WithEvents IdClubTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
