<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJugador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJugador))
        Dim NombreJugadorLabel As System.Windows.Forms.Label
        Dim ApellidoJugadorLabel As System.Windows.Forms.Label
        Dim FechaNacimientoLabel As System.Windows.Forms.Label
        Dim NacionalidadJugadorLabel As System.Windows.Forms.Label
        Dim CodigoIdentificacionLabel As System.Windows.Forms.Label
        Dim IdTipoIdenticacionLabel As System.Windows.Forms.Label
        Me.LIGA_01_DBDataSet = New WindowsApplication2.LIGA_01_DBDataSet()
        Me.JUGADORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JUGADORTableAdapter = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.JUGADORTableAdapter()
        Me.TableAdapterManager = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.TableAdapterManager()
        Me.JUGADORBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.JUGADORBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.JUGADORDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreJugadorTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoJugadorTextBox = New System.Windows.Forms.TextBox()
        Me.FechaNacimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NacionalidadJugadorTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoIdentificacionTextBox = New System.Windows.Forms.TextBox()
        Me.IdTipoIdenticacionTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        NombreJugadorLabel = New System.Windows.Forms.Label()
        ApellidoJugadorLabel = New System.Windows.Forms.Label()
        FechaNacimientoLabel = New System.Windows.Forms.Label()
        NacionalidadJugadorLabel = New System.Windows.Forms.Label()
        CodigoIdentificacionLabel = New System.Windows.Forms.Label()
        IdTipoIdenticacionLabel = New System.Windows.Forms.Label()
        CType(Me.LIGA_01_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JUGADORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JUGADORBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.JUGADORBindingNavigator.SuspendLayout()
        CType(Me.JUGADORDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LIGA_01_DBDataSet
        '
        Me.LIGA_01_DBDataSet.DataSetName = "LIGA_01_DBDataSet"
        Me.LIGA_01_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JUGADORBindingSource
        '
        Me.JUGADORBindingSource.DataMember = "JUGADOR"
        Me.JUGADORBindingSource.DataSource = Me.LIGA_01_DBDataSet
        '
        'JUGADORTableAdapter
        '
        Me.JUGADORTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.FICHA_PROGRAMACIÓNTableAdapter = Nothing
        Me.TableAdapterManager.IDENTIFICACIONTableAdapter = Nothing
        Me.TableAdapterManager.JUGADOR_CLUBTableAdapter = Nothing
        Me.TableAdapterManager.JUGADORTableAdapter = Me.JUGADORTableAdapter
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
        'JUGADORBindingNavigator
        '
        Me.JUGADORBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.JUGADORBindingNavigator.BindingSource = Me.JUGADORBindingSource
        Me.JUGADORBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.JUGADORBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.JUGADORBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.JUGADORBindingNavigatorSaveItem})
        Me.JUGADORBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.JUGADORBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.JUGADORBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.JUGADORBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.JUGADORBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.JUGADORBindingNavigator.Name = "JUGADORBindingNavigator"
        Me.JUGADORBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.JUGADORBindingNavigator.Size = New System.Drawing.Size(911, 25)
        Me.JUGADORBindingNavigator.TabIndex = 0
        Me.JUGADORBindingNavigator.Text = "BindingNavigator1"
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
        'JUGADORBindingNavigatorSaveItem
        '
        Me.JUGADORBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.JUGADORBindingNavigatorSaveItem.Image = CType(resources.GetObject("JUGADORBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.JUGADORBindingNavigatorSaveItem.Name = "JUGADORBindingNavigatorSaveItem"
        Me.JUGADORBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.JUGADORBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'JUGADORDataGridView
        '
        Me.JUGADORDataGridView.AutoGenerateColumns = False
        Me.JUGADORDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.JUGADORDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.JUGADORDataGridView.DataSource = Me.JUGADORBindingSource
        Me.JUGADORDataGridView.Location = New System.Drawing.Point(107, 363)
        Me.JUGADORDataGridView.Name = "JUGADORDataGridView"
        Me.JUGADORDataGridView.Size = New System.Drawing.Size(643, 220)
        Me.JUGADORDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NombreJugador"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NombreJugador"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ApellidoJugador"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ApellidoJugador"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FechaNacimiento"
        Me.DataGridViewTextBoxColumn3.HeaderText = "FechaNacimiento"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NacionalidadJugador"
        Me.DataGridViewTextBoxColumn4.HeaderText = "NacionalidadJugador"
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
        'NombreJugadorLabel
        '
        NombreJugadorLabel.AutoSize = True
        NombreJugadorLabel.Location = New System.Drawing.Point(104, 176)
        NombreJugadorLabel.Name = "NombreJugadorLabel"
        NombreJugadorLabel.Size = New System.Drawing.Size(88, 13)
        NombreJugadorLabel.TabIndex = 2
        NombreJugadorLabel.Text = "Nombre Jugador:"
        '
        'NombreJugadorTextBox
        '
        Me.NombreJugadorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JUGADORBindingSource, "NombreJugador", True))
        Me.NombreJugadorTextBox.Location = New System.Drawing.Point(223, 173)
        Me.NombreJugadorTextBox.Name = "NombreJugadorTextBox"
        Me.NombreJugadorTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NombreJugadorTextBox.TabIndex = 3
        '
        'ApellidoJugadorLabel
        '
        ApellidoJugadorLabel.AutoSize = True
        ApellidoJugadorLabel.Location = New System.Drawing.Point(104, 202)
        ApellidoJugadorLabel.Name = "ApellidoJugadorLabel"
        ApellidoJugadorLabel.Size = New System.Drawing.Size(88, 13)
        ApellidoJugadorLabel.TabIndex = 4
        ApellidoJugadorLabel.Text = "Apellido Jugador:"
        '
        'ApellidoJugadorTextBox
        '
        Me.ApellidoJugadorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JUGADORBindingSource, "ApellidoJugador", True))
        Me.ApellidoJugadorTextBox.Location = New System.Drawing.Point(223, 199)
        Me.ApellidoJugadorTextBox.Name = "ApellidoJugadorTextBox"
        Me.ApellidoJugadorTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ApellidoJugadorTextBox.TabIndex = 5
        '
        'FechaNacimientoLabel
        '
        FechaNacimientoLabel.AutoSize = True
        FechaNacimientoLabel.Location = New System.Drawing.Point(104, 229)
        FechaNacimientoLabel.Name = "FechaNacimientoLabel"
        FechaNacimientoLabel.Size = New System.Drawing.Size(96, 13)
        FechaNacimientoLabel.TabIndex = 6
        FechaNacimientoLabel.Text = "Fecha Nacimiento:"
        '
        'FechaNacimientoDateTimePicker
        '
        Me.FechaNacimientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.JUGADORBindingSource, "FechaNacimiento", True))
        Me.FechaNacimientoDateTimePicker.Location = New System.Drawing.Point(223, 225)
        Me.FechaNacimientoDateTimePicker.Name = "FechaNacimientoDateTimePicker"
        Me.FechaNacimientoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaNacimientoDateTimePicker.TabIndex = 7
        '
        'NacionalidadJugadorLabel
        '
        NacionalidadJugadorLabel.AutoSize = True
        NacionalidadJugadorLabel.Location = New System.Drawing.Point(104, 254)
        NacionalidadJugadorLabel.Name = "NacionalidadJugadorLabel"
        NacionalidadJugadorLabel.Size = New System.Drawing.Size(113, 13)
        NacionalidadJugadorLabel.TabIndex = 8
        NacionalidadJugadorLabel.Text = "Nacionalidad Jugador:"
        '
        'NacionalidadJugadorTextBox
        '
        Me.NacionalidadJugadorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JUGADORBindingSource, "NacionalidadJugador", True))
        Me.NacionalidadJugadorTextBox.Location = New System.Drawing.Point(223, 251)
        Me.NacionalidadJugadorTextBox.Name = "NacionalidadJugadorTextBox"
        Me.NacionalidadJugadorTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NacionalidadJugadorTextBox.TabIndex = 9
        '
        'CodigoIdentificacionLabel
        '
        CodigoIdentificacionLabel.AutoSize = True
        CodigoIdentificacionLabel.Location = New System.Drawing.Point(104, 280)
        CodigoIdentificacionLabel.Name = "CodigoIdentificacionLabel"
        CodigoIdentificacionLabel.Size = New System.Drawing.Size(109, 13)
        CodigoIdentificacionLabel.TabIndex = 10
        CodigoIdentificacionLabel.Text = "Codigo Identificacion:"
        '
        'CodigoIdentificacionTextBox
        '
        Me.CodigoIdentificacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JUGADORBindingSource, "CodigoIdentificacion", True))
        Me.CodigoIdentificacionTextBox.Location = New System.Drawing.Point(223, 277)
        Me.CodigoIdentificacionTextBox.Name = "CodigoIdentificacionTextBox"
        Me.CodigoIdentificacionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CodigoIdentificacionTextBox.TabIndex = 11
        '
        'IdTipoIdenticacionLabel
        '
        IdTipoIdenticacionLabel.AutoSize = True
        IdTipoIdenticacionLabel.Location = New System.Drawing.Point(104, 306)
        IdTipoIdenticacionLabel.Name = "IdTipoIdenticacionLabel"
        IdTipoIdenticacionLabel.Size = New System.Drawing.Size(104, 13)
        IdTipoIdenticacionLabel.TabIndex = 12
        IdTipoIdenticacionLabel.Text = "Id Tipo Identicacion:"
        '
        'IdTipoIdenticacionTextBox
        '
        Me.IdTipoIdenticacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JUGADORBindingSource, "IdTipoIdenticacion", True))
        Me.IdTipoIdenticacionTextBox.Location = New System.Drawing.Point(223, 303)
        Me.IdTipoIdenticacionTextBox.Name = "IdTipoIdenticacionTextBox"
        Me.IdTipoIdenticacionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdTipoIdenticacionTextBox.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(277, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(411, 37)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "FORMULARIO JUGADOR"
        '
        'frmJugador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 625)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(NombreJugadorLabel)
        Me.Controls.Add(Me.NombreJugadorTextBox)
        Me.Controls.Add(ApellidoJugadorLabel)
        Me.Controls.Add(Me.ApellidoJugadorTextBox)
        Me.Controls.Add(FechaNacimientoLabel)
        Me.Controls.Add(Me.FechaNacimientoDateTimePicker)
        Me.Controls.Add(NacionalidadJugadorLabel)
        Me.Controls.Add(Me.NacionalidadJugadorTextBox)
        Me.Controls.Add(CodigoIdentificacionLabel)
        Me.Controls.Add(Me.CodigoIdentificacionTextBox)
        Me.Controls.Add(IdTipoIdenticacionLabel)
        Me.Controls.Add(Me.IdTipoIdenticacionTextBox)
        Me.Controls.Add(Me.JUGADORDataGridView)
        Me.Controls.Add(Me.JUGADORBindingNavigator)
        Me.Name = "frmJugador"
        Me.Text = "frmJugador"
        CType(Me.LIGA_01_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JUGADORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JUGADORBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.JUGADORBindingNavigator.ResumeLayout(False)
        Me.JUGADORBindingNavigator.PerformLayout()
        CType(Me.JUGADORDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LIGA_01_DBDataSet As LIGA_01_DBDataSet
    Friend WithEvents JUGADORBindingSource As BindingSource
    Friend WithEvents JUGADORTableAdapter As LIGA_01_DBDataSetTableAdapters.JUGADORTableAdapter
    Friend WithEvents TableAdapterManager As LIGA_01_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents JUGADORBindingNavigator As BindingNavigator
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
    Friend WithEvents JUGADORBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents JUGADORDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents NombreJugadorTextBox As TextBox
    Friend WithEvents ApellidoJugadorTextBox As TextBox
    Friend WithEvents FechaNacimientoDateTimePicker As DateTimePicker
    Friend WithEvents NacionalidadJugadorTextBox As TextBox
    Friend WithEvents CodigoIdentificacionTextBox As TextBox
    Friend WithEvents IdTipoIdenticacionTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
