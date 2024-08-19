<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnfrentamiento
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
        Dim FechaEnfrentamientoLabel As System.Windows.Forms.Label
        Dim IdEquipoArbitrajeLabel As System.Windows.Forms.Label
        Dim IdEstadioLabel As System.Windows.Forms.Label
        Dim CodigoIdentificacionLabel As System.Windows.Forms.Label
        Dim IdTipoIdenticacionLabel As System.Windows.Forms.Label
        Dim IdClubLocalLabel As System.Windows.Forms.Label
        Dim IdClubVisitanteLabel As System.Windows.Forms.Label
        Dim IdEtapaLabel As System.Windows.Forms.Label
        Dim IdTorneoLabel As System.Windows.Forms.Label
        Dim IdFechaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnfrentamiento))
        Me.LIGA_01_DBDataSet = New WindowsApplication2.LIGA_01_DBDataSet()
        Me.DETALLE_ENFRENTAMIENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DETALLE_ENFRENTAMIENTOTableAdapter = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.DETALLE_ENFRENTAMIENTOTableAdapter()
        Me.TableAdapterManager = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.TableAdapterManager()
        Me.DETALLE_ENFRENTAMIENTOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DETALLE_ENFRENTAMIENTOBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ESTADIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ESTADIOTableAdapter = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.ESTADIOTableAdapter()
        Me.DETALLE_ENFRENTAMIENTODataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEnfrentamientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IdEquipoArbitrajeTextBox = New System.Windows.Forms.TextBox()
        Me.IdEstadioTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoIdentificacionTextBox = New System.Windows.Forms.TextBox()
        Me.IdTipoIdenticacionTextBox = New System.Windows.Forms.TextBox()
        Me.IdClubLocalTextBox = New System.Windows.Forms.TextBox()
        Me.IdClubVisitanteTextBox = New System.Windows.Forms.TextBox()
        Me.IdEtapaTextBox = New System.Windows.Forms.TextBox()
        Me.IdTorneoTextBox = New System.Windows.Forms.TextBox()
        Me.IdFechaTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ESTADIOBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.EQUIPOARBITRAJEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EQUIPO_ARBITRAJETableAdapter = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.EQUIPO_ARBITRAJETableAdapter()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.CLUBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.CLUBBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLUBTableAdapter = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.CLUBTableAdapter()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ETAPABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.TORNEOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.FECHABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ETAPATableAdapter = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.ETAPATableAdapter()
        Me.TORNEOTableAdapter = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.TORNEOTableAdapter()
        Me.FECHATableAdapter = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.FECHATableAdapter()
        Me.FECHABindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        FechaEnfrentamientoLabel = New System.Windows.Forms.Label()
        IdEquipoArbitrajeLabel = New System.Windows.Forms.Label()
        IdEstadioLabel = New System.Windows.Forms.Label()
        CodigoIdentificacionLabel = New System.Windows.Forms.Label()
        IdTipoIdenticacionLabel = New System.Windows.Forms.Label()
        IdClubLocalLabel = New System.Windows.Forms.Label()
        IdClubVisitanteLabel = New System.Windows.Forms.Label()
        IdEtapaLabel = New System.Windows.Forms.Label()
        IdTorneoLabel = New System.Windows.Forms.Label()
        IdFechaLabel = New System.Windows.Forms.Label()
        CType(Me.LIGA_01_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DETALLE_ENFRENTAMIENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DETALLE_ENFRENTAMIENTOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DETALLE_ENFRENTAMIENTOBindingNavigator.SuspendLayout()
        CType(Me.ESTADIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DETALLE_ENFRENTAMIENTODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESTADIOBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQUIPOARBITRAJEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLUBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLUBBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ETAPABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TORNEOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHABindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FechaEnfrentamientoLabel
        '
        FechaEnfrentamientoLabel.AutoSize = True
        FechaEnfrentamientoLabel.Location = New System.Drawing.Point(80, 51)
        FechaEnfrentamientoLabel.Name = "FechaEnfrentamientoLabel"
        FechaEnfrentamientoLabel.Size = New System.Drawing.Size(114, 13)
        FechaEnfrentamientoLabel.TabIndex = 22
        FechaEnfrentamientoLabel.Text = "Fecha Enfrentamiento:"
        '
        'IdEquipoArbitrajeLabel
        '
        IdEquipoArbitrajeLabel.AutoSize = True
        IdEquipoArbitrajeLabel.Location = New System.Drawing.Point(80, 76)
        IdEquipoArbitrajeLabel.Name = "IdEquipoArbitrajeLabel"
        IdEquipoArbitrajeLabel.Size = New System.Drawing.Size(96, 13)
        IdEquipoArbitrajeLabel.TabIndex = 24
        IdEquipoArbitrajeLabel.Text = "Id Equipo Arbitraje:"
        '
        'IdEstadioLabel
        '
        IdEstadioLabel.AutoSize = True
        IdEstadioLabel.Location = New System.Drawing.Point(80, 102)
        IdEstadioLabel.Name = "IdEstadioLabel"
        IdEstadioLabel.Size = New System.Drawing.Size(57, 13)
        IdEstadioLabel.TabIndex = 26
        IdEstadioLabel.Text = "Id Estadio:"
        '
        'CodigoIdentificacionLabel
        '
        CodigoIdentificacionLabel.AutoSize = True
        CodigoIdentificacionLabel.Location = New System.Drawing.Point(80, 128)
        CodigoIdentificacionLabel.Name = "CodigoIdentificacionLabel"
        CodigoIdentificacionLabel.Size = New System.Drawing.Size(109, 13)
        CodigoIdentificacionLabel.TabIndex = 28
        CodigoIdentificacionLabel.Text = "Codigo Identificacion:"
        '
        'IdTipoIdenticacionLabel
        '
        IdTipoIdenticacionLabel.AutoSize = True
        IdTipoIdenticacionLabel.Location = New System.Drawing.Point(80, 154)
        IdTipoIdenticacionLabel.Name = "IdTipoIdenticacionLabel"
        IdTipoIdenticacionLabel.Size = New System.Drawing.Size(104, 13)
        IdTipoIdenticacionLabel.TabIndex = 30
        IdTipoIdenticacionLabel.Text = "Id Tipo Identicacion:"
        '
        'IdClubLocalLabel
        '
        IdClubLocalLabel.AutoSize = True
        IdClubLocalLabel.Location = New System.Drawing.Point(80, 180)
        IdClubLocalLabel.Name = "IdClubLocalLabel"
        IdClubLocalLabel.Size = New System.Drawing.Size(72, 13)
        IdClubLocalLabel.TabIndex = 32
        IdClubLocalLabel.Text = "Id Club Local:"
        '
        'IdClubVisitanteLabel
        '
        IdClubVisitanteLabel.AutoSize = True
        IdClubVisitanteLabel.Location = New System.Drawing.Point(80, 206)
        IdClubVisitanteLabel.Name = "IdClubVisitanteLabel"
        IdClubVisitanteLabel.Size = New System.Drawing.Size(86, 13)
        IdClubVisitanteLabel.TabIndex = 34
        IdClubVisitanteLabel.Text = "Id Club Visitante:"
        '
        'IdEtapaLabel
        '
        IdEtapaLabel.AutoSize = True
        IdEtapaLabel.Location = New System.Drawing.Point(80, 232)
        IdEtapaLabel.Name = "IdEtapaLabel"
        IdEtapaLabel.Size = New System.Drawing.Size(50, 13)
        IdEtapaLabel.TabIndex = 36
        IdEtapaLabel.Text = "Id Etapa:"
        '
        'IdTorneoLabel
        '
        IdTorneoLabel.AutoSize = True
        IdTorneoLabel.Location = New System.Drawing.Point(80, 258)
        IdTorneoLabel.Name = "IdTorneoLabel"
        IdTorneoLabel.Size = New System.Drawing.Size(56, 13)
        IdTorneoLabel.TabIndex = 38
        IdTorneoLabel.Text = "Id Torneo:"
        '
        'IdFechaLabel
        '
        IdFechaLabel.AutoSize = True
        IdFechaLabel.Location = New System.Drawing.Point(80, 284)
        IdFechaLabel.Name = "IdFechaLabel"
        IdFechaLabel.Size = New System.Drawing.Size(52, 13)
        IdFechaLabel.TabIndex = 40
        IdFechaLabel.Text = "Id Fecha:"
        '
        'LIGA_01_DBDataSet
        '
        Me.LIGA_01_DBDataSet.DataSetName = "LIGA_01_DBDataSet"
        Me.LIGA_01_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DETALLE_ENFRENTAMIENTOBindingSource
        '
        Me.DETALLE_ENFRENTAMIENTOBindingSource.DataMember = "DETALLE_ENFRENTAMIENTO"
        Me.DETALLE_ENFRENTAMIENTOBindingSource.DataSource = Me.LIGA_01_DBDataSet
        '
        'DETALLE_ENFRENTAMIENTOTableAdapter
        '
        Me.DETALLE_ENFRENTAMIENTOTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.DETALLE_ENFRENTAMIENTOTableAdapter = Me.DETALLE_ENFRENTAMIENTOTableAdapter
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
        'DETALLE_ENFRENTAMIENTOBindingNavigator
        '
        Me.DETALLE_ENFRENTAMIENTOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DETALLE_ENFRENTAMIENTOBindingNavigator.BindingSource = Me.DETALLE_ENFRENTAMIENTOBindingSource
        Me.DETALLE_ENFRENTAMIENTOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DETALLE_ENFRENTAMIENTOBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DETALLE_ENFRENTAMIENTOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DETALLE_ENFRENTAMIENTOBindingNavigatorSaveItem})
        Me.DETALLE_ENFRENTAMIENTOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DETALLE_ENFRENTAMIENTOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DETALLE_ENFRENTAMIENTOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DETALLE_ENFRENTAMIENTOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DETALLE_ENFRENTAMIENTOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DETALLE_ENFRENTAMIENTOBindingNavigator.Name = "DETALLE_ENFRENTAMIENTOBindingNavigator"
        Me.DETALLE_ENFRENTAMIENTOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DETALLE_ENFRENTAMIENTOBindingNavigator.Size = New System.Drawing.Size(1148, 25)
        Me.DETALLE_ENFRENTAMIENTOBindingNavigator.TabIndex = 0
        Me.DETALLE_ENFRENTAMIENTOBindingNavigator.Text = "BindingNavigator1"
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
        'DETALLE_ENFRENTAMIENTOBindingNavigatorSaveItem
        '
        Me.DETALLE_ENFRENTAMIENTOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DETALLE_ENFRENTAMIENTOBindingNavigatorSaveItem.Image = CType(resources.GetObject("DETALLE_ENFRENTAMIENTOBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DETALLE_ENFRENTAMIENTOBindingNavigatorSaveItem.Name = "DETALLE_ENFRENTAMIENTOBindingNavigatorSaveItem"
        Me.DETALLE_ENFRENTAMIENTOBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DETALLE_ENFRENTAMIENTOBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(493, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(560, 37)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "FORMULARIO ENFRENTAMIENTO"
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
        'DETALLE_ENFRENTAMIENTODataGridView
        '
        Me.DETALLE_ENFRENTAMIENTODataGridView.AutoGenerateColumns = False
        Me.DETALLE_ENFRENTAMIENTODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DETALLE_ENFRENTAMIENTODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.DETALLE_ENFRENTAMIENTODataGridView.DataSource = Me.DETALLE_ENFRENTAMIENTOBindingSource
        Me.DETALLE_ENFRENTAMIENTODataGridView.Location = New System.Drawing.Point(83, 352)
        Me.DETALLE_ENFRENTAMIENTODataGridView.Name = "DETALLE_ENFRENTAMIENTODataGridView"
        Me.DETALLE_ENFRENTAMIENTODataGridView.Size = New System.Drawing.Size(910, 220)
        Me.DETALLE_ENFRENTAMIENTODataGridView.TabIndex = 22
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "FechaEnfrentamiento"
        Me.DataGridViewTextBoxColumn1.HeaderText = "FechaEnfrentamiento"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdEquipoArbitraje"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdEquipoArbitraje"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IdEstadio"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IdEstadio"
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
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IdClubLocal"
        Me.DataGridViewTextBoxColumn6.HeaderText = "IdClubLocal"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "IdClubVisitante"
        Me.DataGridViewTextBoxColumn7.HeaderText = "IdClubVisitante"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "IdEtapa"
        Me.DataGridViewTextBoxColumn8.HeaderText = "IdEtapa"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "IdTorneo"
        Me.DataGridViewTextBoxColumn9.HeaderText = "IdTorneo"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "IdFecha"
        Me.DataGridViewTextBoxColumn10.HeaderText = "IdFecha"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'FechaEnfrentamientoDateTimePicker
        '
        Me.FechaEnfrentamientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DETALLE_ENFRENTAMIENTOBindingSource, "FechaEnfrentamiento", True))
        Me.FechaEnfrentamientoDateTimePicker.Location = New System.Drawing.Point(200, 47)
        Me.FechaEnfrentamientoDateTimePicker.Name = "FechaEnfrentamientoDateTimePicker"
        Me.FechaEnfrentamientoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaEnfrentamientoDateTimePicker.TabIndex = 23
        '
        'IdEquipoArbitrajeTextBox
        '
        Me.IdEquipoArbitrajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DETALLE_ENFRENTAMIENTOBindingSource, "IdEquipoArbitraje", True))
        Me.IdEquipoArbitrajeTextBox.Location = New System.Drawing.Point(200, 73)
        Me.IdEquipoArbitrajeTextBox.Name = "IdEquipoArbitrajeTextBox"
        Me.IdEquipoArbitrajeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdEquipoArbitrajeTextBox.TabIndex = 25
        Me.IdEquipoArbitrajeTextBox.Visible = False
        '
        'IdEstadioTextBox
        '
        Me.IdEstadioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DETALLE_ENFRENTAMIENTOBindingSource, "IdEstadio", True))
        Me.IdEstadioTextBox.Location = New System.Drawing.Point(200, 99)
        Me.IdEstadioTextBox.Name = "IdEstadioTextBox"
        Me.IdEstadioTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdEstadioTextBox.TabIndex = 27
        Me.IdEstadioTextBox.Visible = False
        '
        'CodigoIdentificacionTextBox
        '
        Me.CodigoIdentificacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DETALLE_ENFRENTAMIENTOBindingSource, "CodigoIdentificacion", True))
        Me.CodigoIdentificacionTextBox.Location = New System.Drawing.Point(200, 125)
        Me.CodigoIdentificacionTextBox.Name = "CodigoIdentificacionTextBox"
        Me.CodigoIdentificacionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CodigoIdentificacionTextBox.TabIndex = 29
        '
        'IdTipoIdenticacionTextBox
        '
        Me.IdTipoIdenticacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DETALLE_ENFRENTAMIENTOBindingSource, "IdTipoIdenticacion", True))
        Me.IdTipoIdenticacionTextBox.Location = New System.Drawing.Point(200, 151)
        Me.IdTipoIdenticacionTextBox.Name = "IdTipoIdenticacionTextBox"
        Me.IdTipoIdenticacionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdTipoIdenticacionTextBox.TabIndex = 31
        '
        'IdClubLocalTextBox
        '
        Me.IdClubLocalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DETALLE_ENFRENTAMIENTOBindingSource, "IdClubLocal", True))
        Me.IdClubLocalTextBox.Location = New System.Drawing.Point(200, 177)
        Me.IdClubLocalTextBox.Name = "IdClubLocalTextBox"
        Me.IdClubLocalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdClubLocalTextBox.TabIndex = 33
        Me.IdClubLocalTextBox.Visible = False
        '
        'IdClubVisitanteTextBox
        '
        Me.IdClubVisitanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DETALLE_ENFRENTAMIENTOBindingSource, "IdClubVisitante", True))
        Me.IdClubVisitanteTextBox.Location = New System.Drawing.Point(200, 203)
        Me.IdClubVisitanteTextBox.Name = "IdClubVisitanteTextBox"
        Me.IdClubVisitanteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdClubVisitanteTextBox.TabIndex = 35
        Me.IdClubVisitanteTextBox.Visible = False
        '
        'IdEtapaTextBox
        '
        Me.IdEtapaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DETALLE_ENFRENTAMIENTOBindingSource, "IdEtapa", True))
        Me.IdEtapaTextBox.Location = New System.Drawing.Point(200, 229)
        Me.IdEtapaTextBox.Name = "IdEtapaTextBox"
        Me.IdEtapaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdEtapaTextBox.TabIndex = 37
        Me.IdEtapaTextBox.Visible = False
        '
        'IdTorneoTextBox
        '
        Me.IdTorneoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DETALLE_ENFRENTAMIENTOBindingSource, "IdTorneo", True))
        Me.IdTorneoTextBox.Location = New System.Drawing.Point(200, 255)
        Me.IdTorneoTextBox.Name = "IdTorneoTextBox"
        Me.IdTorneoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdTorneoTextBox.TabIndex = 39
        Me.IdTorneoTextBox.Visible = False
        '
        'IdFechaTextBox
        '
        Me.IdFechaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DETALLE_ENFRENTAMIENTOBindingSource, "IdFecha", True))
        Me.IdFechaTextBox.Location = New System.Drawing.Point(200, 281)
        Me.IdFechaTextBox.Name = "IdFechaTextBox"
        Me.IdFechaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdFechaTextBox.TabIndex = 41
        Me.IdFechaTextBox.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DETALLE_ENFRENTAMIENTOBindingSource, "IdEstadio", True))
        Me.ComboBox1.DataSource = Me.ESTADIOBindingSource1
        Me.ComboBox1.DisplayMember = "NombreEstadio"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(200, 99)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 42
        Me.ComboBox1.ValueMember = "IdEstadio"
        '
        'ESTADIOBindingSource1
        '
        Me.ESTADIOBindingSource1.DataMember = "ESTADIO"
        Me.ESTADIOBindingSource1.DataSource = Me.LIGA_01_DBDataSet
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DETALLE_ENFRENTAMIENTOBindingSource, "IdEquipoArbitraje", True))
        Me.ComboBox2.DataSource = Me.EQUIPOARBITRAJEBindingSource
        Me.ComboBox2.DisplayMember = "DescripciónEquipo"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(200, 73)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox2.TabIndex = 43
        Me.ComboBox2.ValueMember = "IdEquipoArbitraje"
        '
        'EQUIPOARBITRAJEBindingSource
        '
        Me.EQUIPOARBITRAJEBindingSource.DataMember = "EQUIPO_ARBITRAJE"
        Me.EQUIPOARBITRAJEBindingSource.DataSource = Me.LIGA_01_DBDataSet
        '
        'EQUIPO_ARBITRAJETableAdapter
        '
        Me.EQUIPO_ARBITRAJETableAdapter.ClearBeforeFill = True
        '
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DETALLE_ENFRENTAMIENTOBindingSource, "IdClubLocal", True))
        Me.ComboBox3.DataSource = Me.CLUBBindingSource
        Me.ComboBox3.DisplayMember = "NombreClub"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(200, 176)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox3.TabIndex = 44
        Me.ComboBox3.ValueMember = "IdClub"
        '
        'CLUBBindingSource
        '
        Me.CLUBBindingSource.DataMember = "CLUB"
        Me.CLUBBindingSource.DataSource = Me.LIGA_01_DBDataSet
        '
        'ComboBox4
        '
        Me.ComboBox4.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DETALLE_ENFRENTAMIENTOBindingSource, "IdClubVisitante", True))
        Me.ComboBox4.DataSource = Me.CLUBBindingSource1
        Me.ComboBox4.DisplayMember = "NombreClub"
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(200, 203)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox4.TabIndex = 45
        Me.ComboBox4.ValueMember = "IdClub"
        '
        'CLUBBindingSource1
        '
        Me.CLUBBindingSource1.DataMember = "CLUB"
        Me.CLUBBindingSource1.DataSource = Me.LIGA_01_DBDataSet
        '
        'CLUBTableAdapter
        '
        Me.CLUBTableAdapter.ClearBeforeFill = True
        '
        'ComboBox5
        '
        Me.ComboBox5.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DETALLE_ENFRENTAMIENTOBindingSource, "IdEtapa", True))
        Me.ComboBox5.DataSource = Me.ETAPABindingSource
        Me.ComboBox5.DisplayMember = "NombreEtapa"
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(200, 229)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox5.TabIndex = 46
        Me.ComboBox5.ValueMember = "IdEtapa"
        '
        'ETAPABindingSource
        '
        Me.ETAPABindingSource.DataMember = "ETAPA"
        Me.ETAPABindingSource.DataSource = Me.LIGA_01_DBDataSet
        '
        'ComboBox6
        '
        Me.ComboBox6.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DETALLE_ENFRENTAMIENTOBindingSource, "IdTorneo", True))
        Me.ComboBox6.DataSource = Me.TORNEOBindingSource
        Me.ComboBox6.DisplayMember = "IdTorneo"
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(200, 254)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox6.TabIndex = 47
        Me.ComboBox6.ValueMember = "NombreTorneo"
        '
        'TORNEOBindingSource
        '
        Me.TORNEOBindingSource.DataMember = "TORNEO"
        Me.TORNEOBindingSource.DataSource = Me.LIGA_01_DBDataSet
        '
        'ComboBox7
        '
        Me.ComboBox7.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DETALLE_ENFRENTAMIENTOBindingSource, "IdFecha", True))
        Me.ComboBox7.DataSource = Me.FECHABindingSource1
        Me.ComboBox7.DisplayMember = "NumeroFecha"
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Location = New System.Drawing.Point(200, 281)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox7.TabIndex = 48
        Me.ComboBox7.ValueMember = "IdFecha"
        '
        'FECHABindingSource
        '
        Me.FECHABindingSource.DataMember = "FECHA"
        Me.FECHABindingSource.DataSource = Me.LIGA_01_DBDataSet
        '
        'ETAPATableAdapter
        '
        Me.ETAPATableAdapter.ClearBeforeFill = True
        '
        'TORNEOTableAdapter
        '
        Me.TORNEOTableAdapter.ClearBeforeFill = True
        '
        'FECHATableAdapter
        '
        Me.FECHATableAdapter.ClearBeforeFill = True
        '
        'FECHABindingSource1
        '
        Me.FECHABindingSource1.DataMember = "FECHA"
        Me.FECHABindingSource1.DataSource = Me.LIGA_01_DBDataSet
        '
        'frmEnfrentamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1148, 617)
        Me.Controls.Add(Me.ComboBox7)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(FechaEnfrentamientoLabel)
        Me.Controls.Add(Me.FechaEnfrentamientoDateTimePicker)
        Me.Controls.Add(IdEquipoArbitrajeLabel)
        Me.Controls.Add(Me.IdEquipoArbitrajeTextBox)
        Me.Controls.Add(IdEstadioLabel)
        Me.Controls.Add(Me.IdEstadioTextBox)
        Me.Controls.Add(CodigoIdentificacionLabel)
        Me.Controls.Add(Me.CodigoIdentificacionTextBox)
        Me.Controls.Add(IdTipoIdenticacionLabel)
        Me.Controls.Add(Me.IdTipoIdenticacionTextBox)
        Me.Controls.Add(IdClubLocalLabel)
        Me.Controls.Add(Me.IdClubLocalTextBox)
        Me.Controls.Add(IdClubVisitanteLabel)
        Me.Controls.Add(Me.IdClubVisitanteTextBox)
        Me.Controls.Add(IdEtapaLabel)
        Me.Controls.Add(Me.IdEtapaTextBox)
        Me.Controls.Add(IdTorneoLabel)
        Me.Controls.Add(Me.IdTorneoTextBox)
        Me.Controls.Add(IdFechaLabel)
        Me.Controls.Add(Me.IdFechaTextBox)
        Me.Controls.Add(Me.DETALLE_ENFRENTAMIENTODataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DETALLE_ENFRENTAMIENTOBindingNavigator)
        Me.Name = "frmEnfrentamiento"
        Me.Text = "frmEnfrentamiento"
        CType(Me.LIGA_01_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DETALLE_ENFRENTAMIENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DETALLE_ENFRENTAMIENTOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DETALLE_ENFRENTAMIENTOBindingNavigator.ResumeLayout(False)
        Me.DETALLE_ENFRENTAMIENTOBindingNavigator.PerformLayout()
        CType(Me.ESTADIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DETALLE_ENFRENTAMIENTODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESTADIOBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQUIPOARBITRAJEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLUBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLUBBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ETAPABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TORNEOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHABindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LIGA_01_DBDataSet As LIGA_01_DBDataSet
    Friend WithEvents DETALLE_ENFRENTAMIENTOBindingSource As BindingSource
    Friend WithEvents DETALLE_ENFRENTAMIENTOTableAdapter As LIGA_01_DBDataSetTableAdapters.DETALLE_ENFRENTAMIENTOTableAdapter
    Friend WithEvents TableAdapterManager As LIGA_01_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DETALLE_ENFRENTAMIENTOBindingNavigator As BindingNavigator
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
    Friend WithEvents DETALLE_ENFRENTAMIENTOBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents ESTADIOBindingSource As BindingSource
    Friend WithEvents ESTADIOTableAdapter As LIGA_01_DBDataSetTableAdapters.ESTADIOTableAdapter
    Friend WithEvents DETALLE_ENFRENTAMIENTODataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents FechaEnfrentamientoDateTimePicker As DateTimePicker
    Friend WithEvents IdEquipoArbitrajeTextBox As TextBox
    Friend WithEvents IdEstadioTextBox As TextBox
    Friend WithEvents CodigoIdentificacionTextBox As TextBox
    Friend WithEvents IdTipoIdenticacionTextBox As TextBox
    Friend WithEvents IdClubLocalTextBox As TextBox
    Friend WithEvents IdClubVisitanteTextBox As TextBox
    Friend WithEvents IdEtapaTextBox As TextBox
    Friend WithEvents IdTorneoTextBox As TextBox
    Friend WithEvents IdFechaTextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ESTADIOBindingSource1 As BindingSource
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents EQUIPOARBITRAJEBindingSource As BindingSource
    Friend WithEvents EQUIPO_ARBITRAJETableAdapter As LIGA_01_DBDataSetTableAdapters.EQUIPO_ARBITRAJETableAdapter
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents CLUBBindingSource As BindingSource
    Friend WithEvents CLUBTableAdapter As LIGA_01_DBDataSetTableAdapters.CLUBTableAdapter
    Friend WithEvents CLUBBindingSource1 As BindingSource
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents ETAPABindingSource As BindingSource
    Friend WithEvents ETAPATableAdapter As LIGA_01_DBDataSetTableAdapters.ETAPATableAdapter
    Friend WithEvents TORNEOBindingSource As BindingSource
    Friend WithEvents TORNEOTableAdapter As LIGA_01_DBDataSetTableAdapters.TORNEOTableAdapter
    Friend WithEvents FECHABindingSource As BindingSource
    Friend WithEvents FECHATableAdapter As LIGA_01_DBDataSetTableAdapters.FECHATableAdapter
    Friend WithEvents FECHABindingSource1 As BindingSource
End Class
