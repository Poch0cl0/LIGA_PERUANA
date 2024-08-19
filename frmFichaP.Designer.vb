<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFichaP
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
        Dim IdEtapaLabel As System.Windows.Forms.Label
        Dim IdTorneoLabel As System.Windows.Forms.Label
        Dim IdFechaLabel As System.Windows.Forms.Label
        Dim FechaInicioLabel As System.Windows.Forms.Label
        Dim FechaFinalLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFichaP))
        Me.LIGA_01_DBDataSet = New WindowsApplication2.LIGA_01_DBDataSet()
        Me.FICHA_PROGRAMACIÓNBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FICHA_PROGRAMACIÓNTableAdapter = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.FICHA_PROGRAMACIÓNTableAdapter()
        Me.TableAdapterManager = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.TableAdapterManager()
        Me.FICHA_PROGRAMACIÓNBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.FICHA_PROGRAMACIÓNBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FICHA_PROGRAMACIÓNDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEtapaTextBox = New System.Windows.Forms.TextBox()
        Me.IdTorneoTextBox = New System.Windows.Forms.TextBox()
        Me.IdFechaTextBox = New System.Windows.Forms.TextBox()
        Me.FechaInicioDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FechaFinalDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ETAPABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ETAPATableAdapter = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.ETAPATableAdapter()
        Me.TORNEOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TORNEOTableAdapter = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.TORNEOTableAdapter()
        Me.FECHABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FECHATableAdapter = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.FECHATableAdapter()
        IdEtapaLabel = New System.Windows.Forms.Label()
        IdTorneoLabel = New System.Windows.Forms.Label()
        IdFechaLabel = New System.Windows.Forms.Label()
        FechaInicioLabel = New System.Windows.Forms.Label()
        FechaFinalLabel = New System.Windows.Forms.Label()
        CType(Me.LIGA_01_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FICHA_PROGRAMACIÓNBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FICHA_PROGRAMACIÓNBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FICHA_PROGRAMACIÓNBindingNavigator.SuspendLayout()
        CType(Me.FICHA_PROGRAMACIÓNDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ETAPABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TORNEOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdEtapaLabel
        '
        IdEtapaLabel.AutoSize = True
        IdEtapaLabel.Location = New System.Drawing.Point(153, 153)
        IdEtapaLabel.Name = "IdEtapaLabel"
        IdEtapaLabel.Size = New System.Drawing.Size(50, 13)
        IdEtapaLabel.TabIndex = 2
        IdEtapaLabel.Text = "Id Etapa:"
        '
        'IdTorneoLabel
        '
        IdTorneoLabel.AutoSize = True
        IdTorneoLabel.Location = New System.Drawing.Point(153, 179)
        IdTorneoLabel.Name = "IdTorneoLabel"
        IdTorneoLabel.Size = New System.Drawing.Size(56, 13)
        IdTorneoLabel.TabIndex = 4
        IdTorneoLabel.Text = "Id Torneo:"
        '
        'IdFechaLabel
        '
        IdFechaLabel.AutoSize = True
        IdFechaLabel.Location = New System.Drawing.Point(153, 205)
        IdFechaLabel.Name = "IdFechaLabel"
        IdFechaLabel.Size = New System.Drawing.Size(52, 13)
        IdFechaLabel.TabIndex = 6
        IdFechaLabel.Text = "Id Fecha:"
        '
        'FechaInicioLabel
        '
        FechaInicioLabel.AutoSize = True
        FechaInicioLabel.Location = New System.Drawing.Point(153, 232)
        FechaInicioLabel.Name = "FechaInicioLabel"
        FechaInicioLabel.Size = New System.Drawing.Size(68, 13)
        FechaInicioLabel.TabIndex = 8
        FechaInicioLabel.Text = "Fecha Inicio:"
        '
        'FechaFinalLabel
        '
        FechaFinalLabel.AutoSize = True
        FechaFinalLabel.Location = New System.Drawing.Point(153, 258)
        FechaFinalLabel.Name = "FechaFinalLabel"
        FechaFinalLabel.Size = New System.Drawing.Size(65, 13)
        FechaFinalLabel.TabIndex = 10
        FechaFinalLabel.Text = "Fecha Final:"
        '
        'LIGA_01_DBDataSet
        '
        Me.LIGA_01_DBDataSet.DataSetName = "LIGA_01_DBDataSet"
        Me.LIGA_01_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FICHA_PROGRAMACIÓNBindingSource
        '
        Me.FICHA_PROGRAMACIÓNBindingSource.DataMember = "FICHA_PROGRAMACIÓN"
        Me.FICHA_PROGRAMACIÓNBindingSource.DataSource = Me.LIGA_01_DBDataSet
        '
        'FICHA_PROGRAMACIÓNTableAdapter
        '
        Me.FICHA_PROGRAMACIÓNTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ESTADIOTableAdapter = Nothing
        Me.TableAdapterManager.ESTADOSTableAdapter = Nothing
        Me.TableAdapterManager.ETAPA_FECHATableAdapter = Nothing
        Me.TableAdapterManager.ETAPATableAdapter = Nothing
        Me.TableAdapterManager.FECHATableAdapter = Nothing
        Me.TableAdapterManager.FICHA_PROGRAMACIÓNTableAdapter = Me.FICHA_PROGRAMACIÓNTableAdapter
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
        'FICHA_PROGRAMACIÓNBindingNavigator
        '
        Me.FICHA_PROGRAMACIÓNBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FICHA_PROGRAMACIÓNBindingNavigator.BindingSource = Me.FICHA_PROGRAMACIÓNBindingSource
        Me.FICHA_PROGRAMACIÓNBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FICHA_PROGRAMACIÓNBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FICHA_PROGRAMACIÓNBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FICHA_PROGRAMACIÓNBindingNavigatorSaveItem})
        Me.FICHA_PROGRAMACIÓNBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FICHA_PROGRAMACIÓNBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FICHA_PROGRAMACIÓNBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FICHA_PROGRAMACIÓNBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FICHA_PROGRAMACIÓNBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FICHA_PROGRAMACIÓNBindingNavigator.Name = "FICHA_PROGRAMACIÓNBindingNavigator"
        Me.FICHA_PROGRAMACIÓNBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FICHA_PROGRAMACIÓNBindingNavigator.Size = New System.Drawing.Size(891, 25)
        Me.FICHA_PROGRAMACIÓNBindingNavigator.TabIndex = 0
        Me.FICHA_PROGRAMACIÓNBindingNavigator.Text = "BindingNavigator1"
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
        'FICHA_PROGRAMACIÓNBindingNavigatorSaveItem
        '
        Me.FICHA_PROGRAMACIÓNBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FICHA_PROGRAMACIÓNBindingNavigatorSaveItem.Image = CType(resources.GetObject("FICHA_PROGRAMACIÓNBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FICHA_PROGRAMACIÓNBindingNavigatorSaveItem.Name = "FICHA_PROGRAMACIÓNBindingNavigatorSaveItem"
        Me.FICHA_PROGRAMACIÓNBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.FICHA_PROGRAMACIÓNBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'FICHA_PROGRAMACIÓNDataGridView
        '
        Me.FICHA_PROGRAMACIÓNDataGridView.AutoGenerateColumns = False
        Me.FICHA_PROGRAMACIÓNDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FICHA_PROGRAMACIÓNDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.FICHA_PROGRAMACIÓNDataGridView.DataSource = Me.FICHA_PROGRAMACIÓNBindingSource
        Me.FICHA_PROGRAMACIÓNDataGridView.Location = New System.Drawing.Point(147, 313)
        Me.FICHA_PROGRAMACIÓNDataGridView.Name = "FICHA_PROGRAMACIÓNDataGridView"
        Me.FICHA_PROGRAMACIÓNDataGridView.Size = New System.Drawing.Size(542, 220)
        Me.FICHA_PROGRAMACIÓNDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdEtapa"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdEtapa"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdTorneo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdTorneo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IdFecha"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IdFecha"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FechaInicio"
        Me.DataGridViewTextBoxColumn4.HeaderText = "FechaInicio"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "FechaFinal"
        Me.DataGridViewTextBoxColumn5.HeaderText = "FechaFinal"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'IdEtapaTextBox
        '
        Me.IdEtapaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FICHA_PROGRAMACIÓNBindingSource, "IdEtapa", True))
        Me.IdEtapaTextBox.Location = New System.Drawing.Point(227, 150)
        Me.IdEtapaTextBox.Name = "IdEtapaTextBox"
        Me.IdEtapaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdEtapaTextBox.TabIndex = 3
        Me.IdEtapaTextBox.Visible = False
        '
        'IdTorneoTextBox
        '
        Me.IdTorneoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FICHA_PROGRAMACIÓNBindingSource, "IdTorneo", True))
        Me.IdTorneoTextBox.Location = New System.Drawing.Point(227, 176)
        Me.IdTorneoTextBox.Name = "IdTorneoTextBox"
        Me.IdTorneoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdTorneoTextBox.TabIndex = 5
        Me.IdTorneoTextBox.Visible = False
        '
        'IdFechaTextBox
        '
        Me.IdFechaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FICHA_PROGRAMACIÓNBindingSource, "IdFecha", True))
        Me.IdFechaTextBox.Location = New System.Drawing.Point(227, 202)
        Me.IdFechaTextBox.Name = "IdFechaTextBox"
        Me.IdFechaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdFechaTextBox.TabIndex = 7
        Me.IdFechaTextBox.Visible = False
        '
        'FechaInicioDateTimePicker
        '
        Me.FechaInicioDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FICHA_PROGRAMACIÓNBindingSource, "FechaInicio", True))
        Me.FechaInicioDateTimePicker.Location = New System.Drawing.Point(227, 228)
        Me.FechaInicioDateTimePicker.Name = "FechaInicioDateTimePicker"
        Me.FechaInicioDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaInicioDateTimePicker.TabIndex = 9
        '
        'FechaFinalDateTimePicker
        '
        Me.FechaFinalDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FICHA_PROGRAMACIÓNBindingSource, "FechaFinal", True))
        Me.FechaFinalDateTimePicker.Location = New System.Drawing.Point(227, 254)
        Me.FechaFinalDateTimePicker.Name = "FechaFinalDateTimePicker"
        Me.FechaFinalDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaFinalDateTimePicker.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(242, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(391, 37)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "FORMULARIO FICHA P."
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FICHA_PROGRAMACIÓNBindingSource, "IdEtapa", True))
        Me.ComboBox1.DataSource = Me.ETAPABindingSource
        Me.ComboBox1.DisplayMember = "NombreEtapa"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(227, 149)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 13
        Me.ComboBox1.ValueMember = "IdEtapa"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FICHA_PROGRAMACIÓNBindingSource, "IdTorneo", True))
        Me.ComboBox2.DataSource = Me.TORNEOBindingSource
        Me.ComboBox2.DisplayMember = "NombreTorneo"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(227, 175)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox2.TabIndex = 14
        Me.ComboBox2.ValueMember = "IdTorneo"
        '
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FICHA_PROGRAMACIÓNBindingSource, "IdFecha", True))
        Me.ComboBox3.DataSource = Me.FECHABindingSource
        Me.ComboBox3.DisplayMember = "NumeroFecha"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(227, 201)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox3.TabIndex = 15
        Me.ComboBox3.ValueMember = "IdFecha"
        '
        'ETAPABindingSource
        '
        Me.ETAPABindingSource.DataMember = "ETAPA"
        Me.ETAPABindingSource.DataSource = Me.LIGA_01_DBDataSet
        '
        'ETAPATableAdapter
        '
        Me.ETAPATableAdapter.ClearBeforeFill = True
        '
        'TORNEOBindingSource
        '
        Me.TORNEOBindingSource.DataMember = "TORNEO"
        Me.TORNEOBindingSource.DataSource = Me.LIGA_01_DBDataSet
        '
        'TORNEOTableAdapter
        '
        Me.TORNEOTableAdapter.ClearBeforeFill = True
        '
        'FECHABindingSource
        '
        Me.FECHABindingSource.DataMember = "FECHA"
        Me.FECHABindingSource.DataSource = Me.LIGA_01_DBDataSet
        '
        'FECHATableAdapter
        '
        Me.FECHATableAdapter.ClearBeforeFill = True
        '
        'frmFichaP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 568)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(IdEtapaLabel)
        Me.Controls.Add(Me.IdEtapaTextBox)
        Me.Controls.Add(IdTorneoLabel)
        Me.Controls.Add(Me.IdTorneoTextBox)
        Me.Controls.Add(IdFechaLabel)
        Me.Controls.Add(Me.IdFechaTextBox)
        Me.Controls.Add(FechaInicioLabel)
        Me.Controls.Add(Me.FechaInicioDateTimePicker)
        Me.Controls.Add(FechaFinalLabel)
        Me.Controls.Add(Me.FechaFinalDateTimePicker)
        Me.Controls.Add(Me.FICHA_PROGRAMACIÓNDataGridView)
        Me.Controls.Add(Me.FICHA_PROGRAMACIÓNBindingNavigator)
        Me.Name = "frmFichaP"
        Me.Text = "frmFichaP"
        CType(Me.LIGA_01_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FICHA_PROGRAMACIÓNBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FICHA_PROGRAMACIÓNBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FICHA_PROGRAMACIÓNBindingNavigator.ResumeLayout(False)
        Me.FICHA_PROGRAMACIÓNBindingNavigator.PerformLayout()
        CType(Me.FICHA_PROGRAMACIÓNDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ETAPABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TORNEOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LIGA_01_DBDataSet As LIGA_01_DBDataSet
    Friend WithEvents FICHA_PROGRAMACIÓNBindingSource As BindingSource
    Friend WithEvents FICHA_PROGRAMACIÓNTableAdapter As LIGA_01_DBDataSetTableAdapters.FICHA_PROGRAMACIÓNTableAdapter
    Friend WithEvents TableAdapterManager As LIGA_01_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FICHA_PROGRAMACIÓNBindingNavigator As BindingNavigator
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
    Friend WithEvents FICHA_PROGRAMACIÓNBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FICHA_PROGRAMACIÓNDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents IdEtapaTextBox As TextBox
    Friend WithEvents IdTorneoTextBox As TextBox
    Friend WithEvents IdFechaTextBox As TextBox
    Friend WithEvents FechaInicioDateTimePicker As DateTimePicker
    Friend WithEvents FechaFinalDateTimePicker As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ETAPABindingSource As BindingSource
    Friend WithEvents ETAPATableAdapter As LIGA_01_DBDataSetTableAdapters.ETAPATableAdapter
    Friend WithEvents TORNEOBindingSource As BindingSource
    Friend WithEvents TORNEOTableAdapter As LIGA_01_DBDataSetTableAdapters.TORNEOTableAdapter
    Friend WithEvents FECHABindingSource As BindingSource
    Friend WithEvents FECHATableAdapter As LIGA_01_DBDataSetTableAdapters.FECHATableAdapter
End Class
