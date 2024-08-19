<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSolicitud
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
        Dim IdClubLabel As System.Windows.Forms.Label
        Dim IdTorneoLabel As System.Windows.Forms.Label
        Dim IdCertificadoMedicoLabel As System.Windows.Forms.Label
        Dim CodigoIdentificacionLabel As System.Windows.Forms.Label
        Dim IdTipoIdenticacionLabel As System.Windows.Forms.Label
        Dim IdEtapaLabel As System.Windows.Forms.Label
        Dim IdContratoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSolicitud))
        Me.LIGA_01_DBDataSet = New WindowsApplication2.LIGA_01_DBDataSet()
        Me.DETALLE_SOLICITUDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DETALLE_SOLICITUDTableAdapter = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.DETALLE_SOLICITUDTableAdapter()
        Me.TableAdapterManager = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.TableAdapterManager()
        Me.DETALLE_SOLICITUDBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DETALLE_SOLICITUDBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DETALLE_SOLICITUDDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdClubTextBox = New System.Windows.Forms.TextBox()
        Me.IdTorneoTextBox = New System.Windows.Forms.TextBox()
        Me.IdCertificadoMedicoTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoIdentificacionTextBox = New System.Windows.Forms.TextBox()
        Me.IdTipoIdenticacionTextBox = New System.Windows.Forms.TextBox()
        Me.IdEtapaTextBox = New System.Windows.Forms.TextBox()
        Me.IdContratoTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CLUBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLUBTableAdapter = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.CLUBTableAdapter()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TORNEOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TORNEOTableAdapter = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.TORNEOTableAdapter()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ETAPABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ETAPATableAdapter = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.ETAPATableAdapter()
        IdClubLabel = New System.Windows.Forms.Label()
        IdTorneoLabel = New System.Windows.Forms.Label()
        IdCertificadoMedicoLabel = New System.Windows.Forms.Label()
        CodigoIdentificacionLabel = New System.Windows.Forms.Label()
        IdTipoIdenticacionLabel = New System.Windows.Forms.Label()
        IdEtapaLabel = New System.Windows.Forms.Label()
        IdContratoLabel = New System.Windows.Forms.Label()
        CType(Me.LIGA_01_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DETALLE_SOLICITUDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DETALLE_SOLICITUDBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DETALLE_SOLICITUDBindingNavigator.SuspendLayout()
        CType(Me.DETALLE_SOLICITUDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLUBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TORNEOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ETAPABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdClubLabel
        '
        IdClubLabel.AutoSize = True
        IdClubLabel.Location = New System.Drawing.Point(142, 123)
        IdClubLabel.Name = "IdClubLabel"
        IdClubLabel.Size = New System.Drawing.Size(43, 13)
        IdClubLabel.TabIndex = 20
        IdClubLabel.Text = "Id Club:"
        '
        'IdTorneoLabel
        '
        IdTorneoLabel.AutoSize = True
        IdTorneoLabel.Location = New System.Drawing.Point(142, 149)
        IdTorneoLabel.Name = "IdTorneoLabel"
        IdTorneoLabel.Size = New System.Drawing.Size(56, 13)
        IdTorneoLabel.TabIndex = 22
        IdTorneoLabel.Text = "Id Torneo:"
        '
        'IdCertificadoMedicoLabel
        '
        IdCertificadoMedicoLabel.AutoSize = True
        IdCertificadoMedicoLabel.Location = New System.Drawing.Point(142, 175)
        IdCertificadoMedicoLabel.Name = "IdCertificadoMedicoLabel"
        IdCertificadoMedicoLabel.Size = New System.Drawing.Size(110, 13)
        IdCertificadoMedicoLabel.TabIndex = 24
        IdCertificadoMedicoLabel.Text = "Id Certificado Medico:"
        '
        'CodigoIdentificacionLabel
        '
        CodigoIdentificacionLabel.AutoSize = True
        CodigoIdentificacionLabel.Location = New System.Drawing.Point(142, 201)
        CodigoIdentificacionLabel.Name = "CodigoIdentificacionLabel"
        CodigoIdentificacionLabel.Size = New System.Drawing.Size(109, 13)
        CodigoIdentificacionLabel.TabIndex = 26
        CodigoIdentificacionLabel.Text = "Codigo Identificacion:"
        '
        'IdTipoIdenticacionLabel
        '
        IdTipoIdenticacionLabel.AutoSize = True
        IdTipoIdenticacionLabel.Location = New System.Drawing.Point(142, 227)
        IdTipoIdenticacionLabel.Name = "IdTipoIdenticacionLabel"
        IdTipoIdenticacionLabel.Size = New System.Drawing.Size(104, 13)
        IdTipoIdenticacionLabel.TabIndex = 28
        IdTipoIdenticacionLabel.Text = "Id Tipo Identicacion:"
        '
        'IdEtapaLabel
        '
        IdEtapaLabel.AutoSize = True
        IdEtapaLabel.Location = New System.Drawing.Point(142, 253)
        IdEtapaLabel.Name = "IdEtapaLabel"
        IdEtapaLabel.Size = New System.Drawing.Size(50, 13)
        IdEtapaLabel.TabIndex = 30
        IdEtapaLabel.Text = "Id Etapa:"
        '
        'IdContratoLabel
        '
        IdContratoLabel.AutoSize = True
        IdContratoLabel.Location = New System.Drawing.Point(142, 279)
        IdContratoLabel.Name = "IdContratoLabel"
        IdContratoLabel.Size = New System.Drawing.Size(62, 13)
        IdContratoLabel.TabIndex = 32
        IdContratoLabel.Text = "Id Contrato:"
        '
        'LIGA_01_DBDataSet
        '
        Me.LIGA_01_DBDataSet.DataSetName = "LIGA_01_DBDataSet"
        Me.LIGA_01_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DETALLE_SOLICITUDBindingSource
        '
        Me.DETALLE_SOLICITUDBindingSource.DataMember = "DETALLE_SOLICITUD"
        Me.DETALLE_SOLICITUDBindingSource.DataSource = Me.LIGA_01_DBDataSet
        '
        'DETALLE_SOLICITUDTableAdapter
        '
        Me.DETALLE_SOLICITUDTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.DETALLE_SOLICITUDTableAdapter = Me.DETALLE_SOLICITUDTableAdapter
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
        'DETALLE_SOLICITUDBindingNavigator
        '
        Me.DETALLE_SOLICITUDBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DETALLE_SOLICITUDBindingNavigator.BindingSource = Me.DETALLE_SOLICITUDBindingSource
        Me.DETALLE_SOLICITUDBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DETALLE_SOLICITUDBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DETALLE_SOLICITUDBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DETALLE_SOLICITUDBindingNavigatorSaveItem})
        Me.DETALLE_SOLICITUDBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DETALLE_SOLICITUDBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DETALLE_SOLICITUDBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DETALLE_SOLICITUDBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DETALLE_SOLICITUDBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DETALLE_SOLICITUDBindingNavigator.Name = "DETALLE_SOLICITUDBindingNavigator"
        Me.DETALLE_SOLICITUDBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DETALLE_SOLICITUDBindingNavigator.Size = New System.Drawing.Size(1073, 25)
        Me.DETALLE_SOLICITUDBindingNavigator.TabIndex = 0
        Me.DETALLE_SOLICITUDBindingNavigator.Text = "BindingNavigator1"
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
        'DETALLE_SOLICITUDBindingNavigatorSaveItem
        '
        Me.DETALLE_SOLICITUDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DETALLE_SOLICITUDBindingNavigatorSaveItem.Image = CType(resources.GetObject("DETALLE_SOLICITUDBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DETALLE_SOLICITUDBindingNavigatorSaveItem.Name = "DETALLE_SOLICITUDBindingNavigatorSaveItem"
        Me.DETALLE_SOLICITUDBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DETALLE_SOLICITUDBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(514, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(426, 37)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "FORMULARIO SOLICITUD"
        '
        'DETALLE_SOLICITUDDataGridView
        '
        Me.DETALLE_SOLICITUDDataGridView.AutoGenerateColumns = False
        Me.DETALLE_SOLICITUDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DETALLE_SOLICITUDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.DETALLE_SOLICITUDDataGridView.DataSource = Me.DETALLE_SOLICITUDBindingSource
        Me.DETALLE_SOLICITUDDataGridView.Location = New System.Drawing.Point(107, 344)
        Me.DETALLE_SOLICITUDDataGridView.Name = "DETALLE_SOLICITUDDataGridView"
        Me.DETALLE_SOLICITUDDataGridView.Size = New System.Drawing.Size(843, 220)
        Me.DETALLE_SOLICITUDDataGridView.TabIndex = 18
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdSolicitud"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdSolicitud"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdClub"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdClub"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IdTorneo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IdTorneo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IdCertificadoMedico"
        Me.DataGridViewTextBoxColumn4.HeaderText = "IdCertificadoMedico"
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
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "IdEtapa"
        Me.DataGridViewTextBoxColumn7.HeaderText = "IdEtapa"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "IdContrato"
        Me.DataGridViewTextBoxColumn8.HeaderText = "IdContrato"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'IdClubTextBox
        '
        Me.IdClubTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DETALLE_SOLICITUDBindingSource, "IdClub", True))
        Me.IdClubTextBox.Location = New System.Drawing.Point(258, 120)
        Me.IdClubTextBox.Name = "IdClubTextBox"
        Me.IdClubTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdClubTextBox.TabIndex = 21
        Me.IdClubTextBox.Visible = False
        '
        'IdTorneoTextBox
        '
        Me.IdTorneoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DETALLE_SOLICITUDBindingSource, "IdTorneo", True))
        Me.IdTorneoTextBox.Location = New System.Drawing.Point(258, 146)
        Me.IdTorneoTextBox.Name = "IdTorneoTextBox"
        Me.IdTorneoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTorneoTextBox.TabIndex = 23
        Me.IdTorneoTextBox.Visible = False
        '
        'IdCertificadoMedicoTextBox
        '
        Me.IdCertificadoMedicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DETALLE_SOLICITUDBindingSource, "IdCertificadoMedico", True))
        Me.IdCertificadoMedicoTextBox.Location = New System.Drawing.Point(258, 172)
        Me.IdCertificadoMedicoTextBox.Name = "IdCertificadoMedicoTextBox"
        Me.IdCertificadoMedicoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdCertificadoMedicoTextBox.TabIndex = 25
        '
        'CodigoIdentificacionTextBox
        '
        Me.CodigoIdentificacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DETALLE_SOLICITUDBindingSource, "CodigoIdentificacion", True))
        Me.CodigoIdentificacionTextBox.Location = New System.Drawing.Point(258, 198)
        Me.CodigoIdentificacionTextBox.Name = "CodigoIdentificacionTextBox"
        Me.CodigoIdentificacionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoIdentificacionTextBox.TabIndex = 27
        '
        'IdTipoIdenticacionTextBox
        '
        Me.IdTipoIdenticacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DETALLE_SOLICITUDBindingSource, "IdTipoIdenticacion", True))
        Me.IdTipoIdenticacionTextBox.Location = New System.Drawing.Point(258, 224)
        Me.IdTipoIdenticacionTextBox.Name = "IdTipoIdenticacionTextBox"
        Me.IdTipoIdenticacionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTipoIdenticacionTextBox.TabIndex = 29
        '
        'IdEtapaTextBox
        '
        Me.IdEtapaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DETALLE_SOLICITUDBindingSource, "IdEtapa", True))
        Me.IdEtapaTextBox.Location = New System.Drawing.Point(258, 250)
        Me.IdEtapaTextBox.Name = "IdEtapaTextBox"
        Me.IdEtapaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdEtapaTextBox.TabIndex = 31
        Me.IdEtapaTextBox.Visible = False
        '
        'IdContratoTextBox
        '
        Me.IdContratoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DETALLE_SOLICITUDBindingSource, "IdContrato", True))
        Me.IdContratoTextBox.Location = New System.Drawing.Point(258, 276)
        Me.IdContratoTextBox.Name = "IdContratoTextBox"
        Me.IdContratoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdContratoTextBox.TabIndex = 33
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DETALLE_SOLICITUDBindingSource, "IdClub", True))
        Me.ComboBox1.DataSource = Me.CLUBBindingSource
        Me.ComboBox1.DisplayMember = "NombreClub"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(258, 120)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 34
        Me.ComboBox1.ValueMember = "IdClub"
        '
        'CLUBBindingSource
        '
        Me.CLUBBindingSource.DataMember = "CLUB"
        Me.CLUBBindingSource.DataSource = Me.LIGA_01_DBDataSet
        '
        'CLUBTableAdapter
        '
        Me.CLUBTableAdapter.ClearBeforeFill = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DETALLE_SOLICITUDBindingSource, "IdTorneo", True))
        Me.ComboBox2.DataSource = Me.TORNEOBindingSource
        Me.ComboBox2.DisplayMember = "NombreTorneo"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(258, 146)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 35
        Me.ComboBox2.ValueMember = "IdTorneo"
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
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DETALLE_SOLICITUDBindingSource, "IdEtapa", True))
        Me.ComboBox3.DataSource = Me.ETAPABindingSource
        Me.ComboBox3.DisplayMember = "NombreEtapa"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(258, 250)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 36
        Me.ComboBox3.ValueMember = "IdEtapa"
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
        'frmSolicitud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 625)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(IdClubLabel)
        Me.Controls.Add(Me.IdClubTextBox)
        Me.Controls.Add(IdTorneoLabel)
        Me.Controls.Add(Me.IdTorneoTextBox)
        Me.Controls.Add(IdCertificadoMedicoLabel)
        Me.Controls.Add(Me.IdCertificadoMedicoTextBox)
        Me.Controls.Add(CodigoIdentificacionLabel)
        Me.Controls.Add(Me.CodigoIdentificacionTextBox)
        Me.Controls.Add(IdTipoIdenticacionLabel)
        Me.Controls.Add(Me.IdTipoIdenticacionTextBox)
        Me.Controls.Add(IdEtapaLabel)
        Me.Controls.Add(Me.IdEtapaTextBox)
        Me.Controls.Add(IdContratoLabel)
        Me.Controls.Add(Me.IdContratoTextBox)
        Me.Controls.Add(Me.DETALLE_SOLICITUDDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DETALLE_SOLICITUDBindingNavigator)
        Me.Name = "frmSolicitud"
        Me.Text = "frmSolicitud"
        CType(Me.LIGA_01_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DETALLE_SOLICITUDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DETALLE_SOLICITUDBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DETALLE_SOLICITUDBindingNavigator.ResumeLayout(False)
        Me.DETALLE_SOLICITUDBindingNavigator.PerformLayout()
        CType(Me.DETALLE_SOLICITUDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLUBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TORNEOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ETAPABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LIGA_01_DBDataSet As LIGA_01_DBDataSet
    Friend WithEvents DETALLE_SOLICITUDBindingSource As BindingSource
    Friend WithEvents DETALLE_SOLICITUDTableAdapter As LIGA_01_DBDataSetTableAdapters.DETALLE_SOLICITUDTableAdapter
    Friend WithEvents TableAdapterManager As LIGA_01_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DETALLE_SOLICITUDBindingNavigator As BindingNavigator
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
    Friend WithEvents DETALLE_SOLICITUDBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents DETALLE_SOLICITUDDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents IdClubTextBox As TextBox
    Friend WithEvents IdTorneoTextBox As TextBox
    Friend WithEvents IdCertificadoMedicoTextBox As TextBox
    Friend WithEvents CodigoIdentificacionTextBox As TextBox
    Friend WithEvents IdTipoIdenticacionTextBox As TextBox
    Friend WithEvents IdEtapaTextBox As TextBox
    Friend WithEvents IdContratoTextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CLUBBindingSource As BindingSource
    Friend WithEvents CLUBTableAdapter As LIGA_01_DBDataSetTableAdapters.CLUBTableAdapter
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TORNEOBindingSource As BindingSource
    Friend WithEvents TORNEOTableAdapter As LIGA_01_DBDataSetTableAdapters.TORNEOTableAdapter
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ETAPABindingSource As BindingSource
    Friend WithEvents ETAPATableAdapter As LIGA_01_DBDataSetTableAdapters.ETAPATableAdapter
End Class
