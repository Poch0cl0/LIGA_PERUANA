<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCertificadoM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCertificadoM))
        Dim IdCertificadoMedicoLabel As System.Windows.Forms.Label
        Dim FechaDeEmisionLabel As System.Windows.Forms.Label
        Dim PesoLabel As System.Windows.Forms.Label
        Dim AlturaLabel As System.Windows.Forms.Label
        Dim IdEstadoLabel As System.Windows.Forms.Label
        Dim CodigoIdentificacionLabel As System.Windows.Forms.Label
        Dim IdTipoIdenticacionLabel As System.Windows.Forms.Label
        Me.LIGA_01_DBDataSet = New WindowsApplication2.LIGA_01_DBDataSet()
        Me.CERTIFICADO_MEDICOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CERTIFICADO_MEDICOTableAdapter = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.CERTIFICADO_MEDICOTableAdapter()
        Me.TableAdapterManager = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.TableAdapterManager()
        Me.CERTIFICADO_MEDICOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CERTIFICADO_MEDICOBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CERTIFICADO_MEDICODataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCertificadoMedicoTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDeEmisionTextBox = New System.Windows.Forms.TextBox()
        Me.PesoTextBox = New System.Windows.Forms.TextBox()
        Me.AlturaTextBox = New System.Windows.Forms.TextBox()
        Me.IdEstadoTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoIdentificacionTextBox = New System.Windows.Forms.TextBox()
        Me.IdTipoIdenticacionTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        IdCertificadoMedicoLabel = New System.Windows.Forms.Label()
        FechaDeEmisionLabel = New System.Windows.Forms.Label()
        PesoLabel = New System.Windows.Forms.Label()
        AlturaLabel = New System.Windows.Forms.Label()
        IdEstadoLabel = New System.Windows.Forms.Label()
        CodigoIdentificacionLabel = New System.Windows.Forms.Label()
        IdTipoIdenticacionLabel = New System.Windows.Forms.Label()
        CType(Me.LIGA_01_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CERTIFICADO_MEDICOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CERTIFICADO_MEDICOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CERTIFICADO_MEDICOBindingNavigator.SuspendLayout()
        CType(Me.CERTIFICADO_MEDICODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LIGA_01_DBDataSet
        '
        Me.LIGA_01_DBDataSet.DataSetName = "LIGA_01_DBDataSet"
        Me.LIGA_01_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CERTIFICADO_MEDICOBindingSource
        '
        Me.CERTIFICADO_MEDICOBindingSource.DataMember = "CERTIFICADO_MEDICO"
        Me.CERTIFICADO_MEDICOBindingSource.DataSource = Me.LIGA_01_DBDataSet
        '
        'CERTIFICADO_MEDICOTableAdapter
        '
        Me.CERTIFICADO_MEDICOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ARBITROTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CERTIFICADO_LESIONTableAdapter = Nothing
        Me.TableAdapterManager.CERTIFICADO_MEDICOTableAdapter = Me.CERTIFICADO_MEDICOTableAdapter
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
        'CERTIFICADO_MEDICOBindingNavigator
        '
        Me.CERTIFICADO_MEDICOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CERTIFICADO_MEDICOBindingNavigator.BindingSource = Me.CERTIFICADO_MEDICOBindingSource
        Me.CERTIFICADO_MEDICOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CERTIFICADO_MEDICOBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CERTIFICADO_MEDICOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CERTIFICADO_MEDICOBindingNavigatorSaveItem})
        Me.CERTIFICADO_MEDICOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CERTIFICADO_MEDICOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CERTIFICADO_MEDICOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CERTIFICADO_MEDICOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CERTIFICADO_MEDICOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CERTIFICADO_MEDICOBindingNavigator.Name = "CERTIFICADO_MEDICOBindingNavigator"
        Me.CERTIFICADO_MEDICOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CERTIFICADO_MEDICOBindingNavigator.Size = New System.Drawing.Size(951, 25)
        Me.CERTIFICADO_MEDICOBindingNavigator.TabIndex = 0
        Me.CERTIFICADO_MEDICOBindingNavigator.Text = "BindingNavigator1"
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
        'CERTIFICADO_MEDICOBindingNavigatorSaveItem
        '
        Me.CERTIFICADO_MEDICOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CERTIFICADO_MEDICOBindingNavigatorSaveItem.Image = CType(resources.GetObject("CERTIFICADO_MEDICOBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CERTIFICADO_MEDICOBindingNavigatorSaveItem.Name = "CERTIFICADO_MEDICOBindingNavigatorSaveItem"
        Me.CERTIFICADO_MEDICOBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.CERTIFICADO_MEDICOBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CERTIFICADO_MEDICODataGridView
        '
        Me.CERTIFICADO_MEDICODataGridView.AutoGenerateColumns = False
        Me.CERTIFICADO_MEDICODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CERTIFICADO_MEDICODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.CERTIFICADO_MEDICODataGridView.DataSource = Me.CERTIFICADO_MEDICOBindingSource
        Me.CERTIFICADO_MEDICODataGridView.Location = New System.Drawing.Point(104, 254)
        Me.CERTIFICADO_MEDICODataGridView.Name = "CERTIFICADO_MEDICODataGridView"
        Me.CERTIFICADO_MEDICODataGridView.Size = New System.Drawing.Size(743, 273)
        Me.CERTIFICADO_MEDICODataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdCertificadoMedico"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdCertificadoMedico"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FechaDeEmision"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FechaDeEmision"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Peso"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Peso"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Altura"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Altura"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "IdEstado"
        Me.DataGridViewTextBoxColumn5.HeaderText = "IdEstado"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CodigoIdentificacion"
        Me.DataGridViewTextBoxColumn6.HeaderText = "CodigoIdentificacion"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "IdTipoIdenticacion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "IdTipoIdenticacion"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'IdCertificadoMedicoLabel
        '
        IdCertificadoMedicoLabel.AutoSize = True
        IdCertificadoMedicoLabel.Location = New System.Drawing.Point(101, 56)
        IdCertificadoMedicoLabel.Name = "IdCertificadoMedicoLabel"
        IdCertificadoMedicoLabel.Size = New System.Drawing.Size(110, 13)
        IdCertificadoMedicoLabel.TabIndex = 2
        IdCertificadoMedicoLabel.Text = "Id Certificado Medico:"
        '
        'IdCertificadoMedicoTextBox
        '
        Me.IdCertificadoMedicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CERTIFICADO_MEDICOBindingSource, "IdCertificadoMedico", True))
        Me.IdCertificadoMedicoTextBox.Location = New System.Drawing.Point(217, 53)
        Me.IdCertificadoMedicoTextBox.Name = "IdCertificadoMedicoTextBox"
        Me.IdCertificadoMedicoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdCertificadoMedicoTextBox.TabIndex = 3
        '
        'FechaDeEmisionLabel
        '
        FechaDeEmisionLabel.AutoSize = True
        FechaDeEmisionLabel.Location = New System.Drawing.Point(101, 82)
        FechaDeEmisionLabel.Name = "FechaDeEmisionLabel"
        FechaDeEmisionLabel.Size = New System.Drawing.Size(96, 13)
        FechaDeEmisionLabel.TabIndex = 4
        FechaDeEmisionLabel.Text = "Fecha De Emision:"
        '
        'FechaDeEmisionTextBox
        '
        Me.FechaDeEmisionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CERTIFICADO_MEDICOBindingSource, "FechaDeEmision", True))
        Me.FechaDeEmisionTextBox.Location = New System.Drawing.Point(217, 79)
        Me.FechaDeEmisionTextBox.Name = "FechaDeEmisionTextBox"
        Me.FechaDeEmisionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FechaDeEmisionTextBox.TabIndex = 5
        '
        'PesoLabel
        '
        PesoLabel.AutoSize = True
        PesoLabel.Location = New System.Drawing.Point(101, 108)
        PesoLabel.Name = "PesoLabel"
        PesoLabel.Size = New System.Drawing.Size(34, 13)
        PesoLabel.TabIndex = 6
        PesoLabel.Text = "Peso:"
        '
        'PesoTextBox
        '
        Me.PesoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CERTIFICADO_MEDICOBindingSource, "Peso", True))
        Me.PesoTextBox.Location = New System.Drawing.Point(217, 105)
        Me.PesoTextBox.Name = "PesoTextBox"
        Me.PesoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PesoTextBox.TabIndex = 7
        '
        'AlturaLabel
        '
        AlturaLabel.AutoSize = True
        AlturaLabel.Location = New System.Drawing.Point(101, 134)
        AlturaLabel.Name = "AlturaLabel"
        AlturaLabel.Size = New System.Drawing.Size(37, 13)
        AlturaLabel.TabIndex = 8
        AlturaLabel.Text = "Altura:"
        '
        'AlturaTextBox
        '
        Me.AlturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CERTIFICADO_MEDICOBindingSource, "Altura", True))
        Me.AlturaTextBox.Location = New System.Drawing.Point(217, 131)
        Me.AlturaTextBox.Name = "AlturaTextBox"
        Me.AlturaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AlturaTextBox.TabIndex = 9
        '
        'IdEstadoLabel
        '
        IdEstadoLabel.AutoSize = True
        IdEstadoLabel.Location = New System.Drawing.Point(101, 160)
        IdEstadoLabel.Name = "IdEstadoLabel"
        IdEstadoLabel.Size = New System.Drawing.Size(55, 13)
        IdEstadoLabel.TabIndex = 10
        IdEstadoLabel.Text = "Id Estado:"
        '
        'IdEstadoTextBox
        '
        Me.IdEstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CERTIFICADO_MEDICOBindingSource, "IdEstado", True))
        Me.IdEstadoTextBox.Location = New System.Drawing.Point(217, 157)
        Me.IdEstadoTextBox.Name = "IdEstadoTextBox"
        Me.IdEstadoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdEstadoTextBox.TabIndex = 11
        '
        'CodigoIdentificacionLabel
        '
        CodigoIdentificacionLabel.AutoSize = True
        CodigoIdentificacionLabel.Location = New System.Drawing.Point(101, 186)
        CodigoIdentificacionLabel.Name = "CodigoIdentificacionLabel"
        CodigoIdentificacionLabel.Size = New System.Drawing.Size(109, 13)
        CodigoIdentificacionLabel.TabIndex = 12
        CodigoIdentificacionLabel.Text = "Codigo Identificacion:"
        '
        'CodigoIdentificacionTextBox
        '
        Me.CodigoIdentificacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CERTIFICADO_MEDICOBindingSource, "CodigoIdentificacion", True))
        Me.CodigoIdentificacionTextBox.Location = New System.Drawing.Point(217, 183)
        Me.CodigoIdentificacionTextBox.Name = "CodigoIdentificacionTextBox"
        Me.CodigoIdentificacionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoIdentificacionTextBox.TabIndex = 13
        '
        'IdTipoIdenticacionLabel
        '
        IdTipoIdenticacionLabel.AutoSize = True
        IdTipoIdenticacionLabel.Location = New System.Drawing.Point(101, 212)
        IdTipoIdenticacionLabel.Name = "IdTipoIdenticacionLabel"
        IdTipoIdenticacionLabel.Size = New System.Drawing.Size(104, 13)
        IdTipoIdenticacionLabel.TabIndex = 14
        IdTipoIdenticacionLabel.Text = "Id Tipo Identicacion:"
        '
        'IdTipoIdenticacionTextBox
        '
        Me.IdTipoIdenticacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CERTIFICADO_MEDICOBindingSource, "IdTipoIdenticacion", True))
        Me.IdTipoIdenticacionTextBox.Location = New System.Drawing.Point(217, 209)
        Me.IdTipoIdenticacionTextBox.Name = "IdTipoIdenticacionTextBox"
        Me.IdTipoIdenticacionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTipoIdenticacionTextBox.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(360, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(512, 37)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "FORMULARO CERTIFICADO M."
        '
        'frmCertificadoM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 552)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(IdCertificadoMedicoLabel)
        Me.Controls.Add(Me.IdCertificadoMedicoTextBox)
        Me.Controls.Add(FechaDeEmisionLabel)
        Me.Controls.Add(Me.FechaDeEmisionTextBox)
        Me.Controls.Add(PesoLabel)
        Me.Controls.Add(Me.PesoTextBox)
        Me.Controls.Add(AlturaLabel)
        Me.Controls.Add(Me.AlturaTextBox)
        Me.Controls.Add(IdEstadoLabel)
        Me.Controls.Add(Me.IdEstadoTextBox)
        Me.Controls.Add(CodigoIdentificacionLabel)
        Me.Controls.Add(Me.CodigoIdentificacionTextBox)
        Me.Controls.Add(IdTipoIdenticacionLabel)
        Me.Controls.Add(Me.IdTipoIdenticacionTextBox)
        Me.Controls.Add(Me.CERTIFICADO_MEDICODataGridView)
        Me.Controls.Add(Me.CERTIFICADO_MEDICOBindingNavigator)
        Me.Name = "frmCertificadoM"
        Me.Text = "frmCertificadoM"
        CType(Me.LIGA_01_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CERTIFICADO_MEDICOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CERTIFICADO_MEDICOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CERTIFICADO_MEDICOBindingNavigator.ResumeLayout(False)
        Me.CERTIFICADO_MEDICOBindingNavigator.PerformLayout()
        CType(Me.CERTIFICADO_MEDICODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LIGA_01_DBDataSet As LIGA_01_DBDataSet
    Friend WithEvents CERTIFICADO_MEDICOBindingSource As BindingSource
    Friend WithEvents CERTIFICADO_MEDICOTableAdapter As LIGA_01_DBDataSetTableAdapters.CERTIFICADO_MEDICOTableAdapter
    Friend WithEvents TableAdapterManager As LIGA_01_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CERTIFICADO_MEDICOBindingNavigator As BindingNavigator
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
    Friend WithEvents CERTIFICADO_MEDICOBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CERTIFICADO_MEDICODataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents IdCertificadoMedicoTextBox As TextBox
    Friend WithEvents FechaDeEmisionTextBox As TextBox
    Friend WithEvents PesoTextBox As TextBox
    Friend WithEvents AlturaTextBox As TextBox
    Friend WithEvents IdEstadoTextBox As TextBox
    Friend WithEvents CodigoIdentificacionTextBox As TextBox
    Friend WithEvents IdTipoIdenticacionTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
