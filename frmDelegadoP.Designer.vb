<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDelegadoP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDelegadoP))
        Dim NombreDelegadoPartidoLabel As System.Windows.Forms.Label
        Dim ApellidoDelegadoPartidoLabel As System.Windows.Forms.Label
        Dim CodigoIdentificacionLabel As System.Windows.Forms.Label
        Dim IdTipoIdenticacionLabel As System.Windows.Forms.Label
        Me.LIGA_01_DBDataSet = New WindowsApplication2.LIGA_01_DBDataSet()
        Me.DELEGADO_PARTIDOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DELEGADO_PARTIDOTableAdapter = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.DELEGADO_PARTIDOTableAdapter()
        Me.TableAdapterManager = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.TableAdapterManager()
        Me.DELEGADO_PARTIDOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DELEGADO_PARTIDOBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DELEGADO_PARTIDODataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDelegadoPartidoTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoDelegadoPartidoTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoIdentificacionTextBox = New System.Windows.Forms.TextBox()
        Me.IdTipoIdenticacionTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        NombreDelegadoPartidoLabel = New System.Windows.Forms.Label()
        ApellidoDelegadoPartidoLabel = New System.Windows.Forms.Label()
        CodigoIdentificacionLabel = New System.Windows.Forms.Label()
        IdTipoIdenticacionLabel = New System.Windows.Forms.Label()
        CType(Me.LIGA_01_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DELEGADO_PARTIDOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DELEGADO_PARTIDOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DELEGADO_PARTIDOBindingNavigator.SuspendLayout()
        CType(Me.DELEGADO_PARTIDODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LIGA_01_DBDataSet
        '
        Me.LIGA_01_DBDataSet.DataSetName = "LIGA_01_DBDataSet"
        Me.LIGA_01_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DELEGADO_PARTIDOBindingSource
        '
        Me.DELEGADO_PARTIDOBindingSource.DataMember = "DELEGADO_PARTIDO"
        Me.DELEGADO_PARTIDOBindingSource.DataSource = Me.LIGA_01_DBDataSet
        '
        'DELEGADO_PARTIDOTableAdapter
        '
        Me.DELEGADO_PARTIDOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ARBITROTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CERTIFICADO_LESIONTableAdapter = Nothing
        Me.TableAdapterManager.CERTIFICADO_MEDICOTableAdapter = Nothing
        Me.TableAdapterManager.CLUBTableAdapter = Nothing
        Me.TableAdapterManager.CONTRATOTableAdapter = Nothing
        Me.TableAdapterManager.DELEGADO_PARTIDOTableAdapter = Me.DELEGADO_PARTIDOTableAdapter
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
        'DELEGADO_PARTIDOBindingNavigator
        '
        Me.DELEGADO_PARTIDOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DELEGADO_PARTIDOBindingNavigator.BindingSource = Me.DELEGADO_PARTIDOBindingSource
        Me.DELEGADO_PARTIDOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DELEGADO_PARTIDOBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DELEGADO_PARTIDOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DELEGADO_PARTIDOBindingNavigatorSaveItem})
        Me.DELEGADO_PARTIDOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DELEGADO_PARTIDOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DELEGADO_PARTIDOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DELEGADO_PARTIDOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DELEGADO_PARTIDOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DELEGADO_PARTIDOBindingNavigator.Name = "DELEGADO_PARTIDOBindingNavigator"
        Me.DELEGADO_PARTIDOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DELEGADO_PARTIDOBindingNavigator.Size = New System.Drawing.Size(811, 25)
        Me.DELEGADO_PARTIDOBindingNavigator.TabIndex = 0
        Me.DELEGADO_PARTIDOBindingNavigator.Text = "BindingNavigator1"
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
        'DELEGADO_PARTIDOBindingNavigatorSaveItem
        '
        Me.DELEGADO_PARTIDOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DELEGADO_PARTIDOBindingNavigatorSaveItem.Image = CType(resources.GetObject("DELEGADO_PARTIDOBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DELEGADO_PARTIDOBindingNavigatorSaveItem.Name = "DELEGADO_PARTIDOBindingNavigatorSaveItem"
        Me.DELEGADO_PARTIDOBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.DELEGADO_PARTIDOBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'DELEGADO_PARTIDODataGridView
        '
        Me.DELEGADO_PARTIDODataGridView.AutoGenerateColumns = False
        Me.DELEGADO_PARTIDODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DELEGADO_PARTIDODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.DELEGADO_PARTIDODataGridView.DataSource = Me.DELEGADO_PARTIDOBindingSource
        Me.DELEGADO_PARTIDODataGridView.Location = New System.Drawing.Point(175, 290)
        Me.DELEGADO_PARTIDODataGridView.Name = "DELEGADO_PARTIDODataGridView"
        Me.DELEGADO_PARTIDODataGridView.Size = New System.Drawing.Size(444, 220)
        Me.DELEGADO_PARTIDODataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NombreDelegadoPartido"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NombreDelegadoPartido"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ApellidoDelegadoPartido"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ApellidoDelegadoPartido"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CodigoIdentificacion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CodigoIdentificacion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IdTipoIdenticacion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "IdTipoIdenticacion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'NombreDelegadoPartidoLabel
        '
        NombreDelegadoPartidoLabel.AutoSize = True
        NombreDelegadoPartidoLabel.Location = New System.Drawing.Point(172, 159)
        NombreDelegadoPartidoLabel.Name = "NombreDelegadoPartidoLabel"
        NombreDelegadoPartidoLabel.Size = New System.Drawing.Size(132, 13)
        NombreDelegadoPartidoLabel.TabIndex = 2
        NombreDelegadoPartidoLabel.Text = "Nombre Delegado Partido:"
        '
        'NombreDelegadoPartidoTextBox
        '
        Me.NombreDelegadoPartidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DELEGADO_PARTIDOBindingSource, "NombreDelegadoPartido", True))
        Me.NombreDelegadoPartidoTextBox.Location = New System.Drawing.Point(310, 156)
        Me.NombreDelegadoPartidoTextBox.Name = "NombreDelegadoPartidoTextBox"
        Me.NombreDelegadoPartidoTextBox.Size = New System.Drawing.Size(246, 20)
        Me.NombreDelegadoPartidoTextBox.TabIndex = 3
        '
        'ApellidoDelegadoPartidoLabel
        '
        ApellidoDelegadoPartidoLabel.AutoSize = True
        ApellidoDelegadoPartidoLabel.Location = New System.Drawing.Point(172, 185)
        ApellidoDelegadoPartidoLabel.Name = "ApellidoDelegadoPartidoLabel"
        ApellidoDelegadoPartidoLabel.Size = New System.Drawing.Size(132, 13)
        ApellidoDelegadoPartidoLabel.TabIndex = 4
        ApellidoDelegadoPartidoLabel.Text = "Apellido Delegado Partido:"
        '
        'ApellidoDelegadoPartidoTextBox
        '
        Me.ApellidoDelegadoPartidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DELEGADO_PARTIDOBindingSource, "ApellidoDelegadoPartido", True))
        Me.ApellidoDelegadoPartidoTextBox.Location = New System.Drawing.Point(310, 182)
        Me.ApellidoDelegadoPartidoTextBox.Name = "ApellidoDelegadoPartidoTextBox"
        Me.ApellidoDelegadoPartidoTextBox.Size = New System.Drawing.Size(246, 20)
        Me.ApellidoDelegadoPartidoTextBox.TabIndex = 5
        '
        'CodigoIdentificacionLabel
        '
        CodigoIdentificacionLabel.AutoSize = True
        CodigoIdentificacionLabel.Location = New System.Drawing.Point(172, 211)
        CodigoIdentificacionLabel.Name = "CodigoIdentificacionLabel"
        CodigoIdentificacionLabel.Size = New System.Drawing.Size(109, 13)
        CodigoIdentificacionLabel.TabIndex = 6
        CodigoIdentificacionLabel.Text = "Codigo Identificacion:"
        '
        'CodigoIdentificacionTextBox
        '
        Me.CodigoIdentificacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DELEGADO_PARTIDOBindingSource, "CodigoIdentificacion", True))
        Me.CodigoIdentificacionTextBox.Location = New System.Drawing.Point(310, 208)
        Me.CodigoIdentificacionTextBox.Name = "CodigoIdentificacionTextBox"
        Me.CodigoIdentificacionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoIdentificacionTextBox.TabIndex = 7
        '
        'IdTipoIdenticacionLabel
        '
        IdTipoIdenticacionLabel.AutoSize = True
        IdTipoIdenticacionLabel.Location = New System.Drawing.Point(172, 237)
        IdTipoIdenticacionLabel.Name = "IdTipoIdenticacionLabel"
        IdTipoIdenticacionLabel.Size = New System.Drawing.Size(104, 13)
        IdTipoIdenticacionLabel.TabIndex = 8
        IdTipoIdenticacionLabel.Text = "Id Tipo Identicacion:"
        '
        'IdTipoIdenticacionTextBox
        '
        Me.IdTipoIdenticacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DELEGADO_PARTIDOBindingSource, "IdTipoIdenticacion", True))
        Me.IdTipoIdenticacionTextBox.Location = New System.Drawing.Point(310, 234)
        Me.IdTipoIdenticacionTextBox.Name = "IdTipoIdenticacionTextBox"
        Me.IdTipoIdenticacionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTipoIdenticacionTextBox.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(145, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(551, 37)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "FORMULARIO DELEGADO DEL P."
        '
        'frmDelegadoP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 547)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(NombreDelegadoPartidoLabel)
        Me.Controls.Add(Me.NombreDelegadoPartidoTextBox)
        Me.Controls.Add(ApellidoDelegadoPartidoLabel)
        Me.Controls.Add(Me.ApellidoDelegadoPartidoTextBox)
        Me.Controls.Add(CodigoIdentificacionLabel)
        Me.Controls.Add(Me.CodigoIdentificacionTextBox)
        Me.Controls.Add(IdTipoIdenticacionLabel)
        Me.Controls.Add(Me.IdTipoIdenticacionTextBox)
        Me.Controls.Add(Me.DELEGADO_PARTIDODataGridView)
        Me.Controls.Add(Me.DELEGADO_PARTIDOBindingNavigator)
        Me.Name = "frmDelegadoP"
        Me.Text = "frmDelegadoP"
        CType(Me.LIGA_01_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DELEGADO_PARTIDOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DELEGADO_PARTIDOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DELEGADO_PARTIDOBindingNavigator.ResumeLayout(False)
        Me.DELEGADO_PARTIDOBindingNavigator.PerformLayout()
        CType(Me.DELEGADO_PARTIDODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LIGA_01_DBDataSet As LIGA_01_DBDataSet
    Friend WithEvents DELEGADO_PARTIDOBindingSource As BindingSource
    Friend WithEvents DELEGADO_PARTIDOTableAdapter As LIGA_01_DBDataSetTableAdapters.DELEGADO_PARTIDOTableAdapter
    Friend WithEvents TableAdapterManager As LIGA_01_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DELEGADO_PARTIDOBindingNavigator As BindingNavigator
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
    Friend WithEvents DELEGADO_PARTIDOBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DELEGADO_PARTIDODataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents NombreDelegadoPartidoTextBox As TextBox
    Friend WithEvents ApellidoDelegadoPartidoTextBox As TextBox
    Friend WithEvents CodigoIdentificacionTextBox As TextBox
    Friend WithEvents IdTipoIdenticacionTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
