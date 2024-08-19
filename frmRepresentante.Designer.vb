<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepresentante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepresentante))
        Dim NombreRepresentanteClubLabel As System.Windows.Forms.Label
        Dim ApellidoRepresentanteClubLabel As System.Windows.Forms.Label
        Dim CodigoIdentificacionLabel As System.Windows.Forms.Label
        Dim IdTipoIdenticacionLabel As System.Windows.Forms.Label
        Me.LIGA_01_DBDataSet = New WindowsApplication2.LIGA_01_DBDataSet()
        Me.REPRESENTANTE_CLUBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.REPRESENTANTE_CLUBTableAdapter = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.REPRESENTANTE_CLUBTableAdapter()
        Me.TableAdapterManager = New WindowsApplication2.LIGA_01_DBDataSetTableAdapters.TableAdapterManager()
        Me.REPRESENTANTE_CLUBBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.REPRESENTANTE_CLUBBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.REPRESENTANTE_CLUBDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreRepresentanteClubTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoRepresentanteClubTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoIdentificacionTextBox = New System.Windows.Forms.TextBox()
        Me.IdTipoIdenticacionTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        NombreRepresentanteClubLabel = New System.Windows.Forms.Label()
        ApellidoRepresentanteClubLabel = New System.Windows.Forms.Label()
        CodigoIdentificacionLabel = New System.Windows.Forms.Label()
        IdTipoIdenticacionLabel = New System.Windows.Forms.Label()
        CType(Me.LIGA_01_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REPRESENTANTE_CLUBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REPRESENTANTE_CLUBBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.REPRESENTANTE_CLUBBindingNavigator.SuspendLayout()
        CType(Me.REPRESENTANTE_CLUBDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LIGA_01_DBDataSet
        '
        Me.LIGA_01_DBDataSet.DataSetName = "LIGA_01_DBDataSet"
        Me.LIGA_01_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'REPRESENTANTE_CLUBBindingSource
        '
        Me.REPRESENTANTE_CLUBBindingSource.DataMember = "REPRESENTANTE_CLUB"
        Me.REPRESENTANTE_CLUBBindingSource.DataSource = Me.LIGA_01_DBDataSet
        '
        'REPRESENTANTE_CLUBTableAdapter
        '
        Me.REPRESENTANTE_CLUBTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.JUGADORTableAdapter = Nothing
        Me.TableAdapterManager.LESIONTableAdapter = Nothing
        Me.TableAdapterManager.OPERACION_FICHAPROGRAMACIONTableAdapter = Nothing
        Me.TableAdapterManager.OPERACION_REPORTE_ADMISIONTableAdapter = Nothing
        Me.TableAdapterManager.REPORTE_ADMISIONTableAdapter = Nothing
        Me.TableAdapterManager.REPRESENTANTE_CLUBTableAdapter = Me.REPRESENTANTE_CLUBTableAdapter
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
        'REPRESENTANTE_CLUBBindingNavigator
        '
        Me.REPRESENTANTE_CLUBBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.REPRESENTANTE_CLUBBindingNavigator.BindingSource = Me.REPRESENTANTE_CLUBBindingSource
        Me.REPRESENTANTE_CLUBBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.REPRESENTANTE_CLUBBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.REPRESENTANTE_CLUBBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.REPRESENTANTE_CLUBBindingNavigatorSaveItem})
        Me.REPRESENTANTE_CLUBBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.REPRESENTANTE_CLUBBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.REPRESENTANTE_CLUBBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.REPRESENTANTE_CLUBBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.REPRESENTANTE_CLUBBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.REPRESENTANTE_CLUBBindingNavigator.Name = "REPRESENTANTE_CLUBBindingNavigator"
        Me.REPRESENTANTE_CLUBBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.REPRESENTANTE_CLUBBindingNavigator.Size = New System.Drawing.Size(782, 25)
        Me.REPRESENTANTE_CLUBBindingNavigator.TabIndex = 0
        Me.REPRESENTANTE_CLUBBindingNavigator.Text = "BindingNavigator1"
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
        'REPRESENTANTE_CLUBBindingNavigatorSaveItem
        '
        Me.REPRESENTANTE_CLUBBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.REPRESENTANTE_CLUBBindingNavigatorSaveItem.Image = CType(resources.GetObject("REPRESENTANTE_CLUBBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.REPRESENTANTE_CLUBBindingNavigatorSaveItem.Name = "REPRESENTANTE_CLUBBindingNavigatorSaveItem"
        Me.REPRESENTANTE_CLUBBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.REPRESENTANTE_CLUBBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'REPRESENTANTE_CLUBDataGridView
        '
        Me.REPRESENTANTE_CLUBDataGridView.AutoGenerateColumns = False
        Me.REPRESENTANTE_CLUBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.REPRESENTANTE_CLUBDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.REPRESENTANTE_CLUBDataGridView.DataSource = Me.REPRESENTANTE_CLUBBindingSource
        Me.REPRESENTANTE_CLUBDataGridView.Location = New System.Drawing.Point(155, 314)
        Me.REPRESENTANTE_CLUBDataGridView.Name = "REPRESENTANTE_CLUBDataGridView"
        Me.REPRESENTANTE_CLUBDataGridView.Size = New System.Drawing.Size(442, 220)
        Me.REPRESENTANTE_CLUBDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NombreRepresentanteClub"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NombreRepresentanteClub"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ApellidoRepresentanteClub"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ApellidoRepresentanteClub"
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
        'NombreRepresentanteClubLabel
        '
        NombreRepresentanteClubLabel.AutoSize = True
        NombreRepresentanteClubLabel.Location = New System.Drawing.Point(154, 176)
        NombreRepresentanteClubLabel.Name = "NombreRepresentanteClubLabel"
        NombreRepresentanteClubLabel.Size = New System.Drawing.Size(144, 13)
        NombreRepresentanteClubLabel.TabIndex = 2
        NombreRepresentanteClubLabel.Text = "Nombre Representante Club:"
        '
        'NombreRepresentanteClubTextBox
        '
        Me.NombreRepresentanteClubTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REPRESENTANTE_CLUBBindingSource, "NombreRepresentanteClub", True))
        Me.NombreRepresentanteClubTextBox.Location = New System.Drawing.Point(304, 173)
        Me.NombreRepresentanteClubTextBox.Name = "NombreRepresentanteClubTextBox"
        Me.NombreRepresentanteClubTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreRepresentanteClubTextBox.TabIndex = 3
        '
        'ApellidoRepresentanteClubLabel
        '
        ApellidoRepresentanteClubLabel.AutoSize = True
        ApellidoRepresentanteClubLabel.Location = New System.Drawing.Point(154, 202)
        ApellidoRepresentanteClubLabel.Name = "ApellidoRepresentanteClubLabel"
        ApellidoRepresentanteClubLabel.Size = New System.Drawing.Size(144, 13)
        ApellidoRepresentanteClubLabel.TabIndex = 4
        ApellidoRepresentanteClubLabel.Text = "Apellido Representante Club:"
        '
        'ApellidoRepresentanteClubTextBox
        '
        Me.ApellidoRepresentanteClubTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REPRESENTANTE_CLUBBindingSource, "ApellidoRepresentanteClub", True))
        Me.ApellidoRepresentanteClubTextBox.Location = New System.Drawing.Point(304, 199)
        Me.ApellidoRepresentanteClubTextBox.Name = "ApellidoRepresentanteClubTextBox"
        Me.ApellidoRepresentanteClubTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ApellidoRepresentanteClubTextBox.TabIndex = 5
        '
        'CodigoIdentificacionLabel
        '
        CodigoIdentificacionLabel.AutoSize = True
        CodigoIdentificacionLabel.Location = New System.Drawing.Point(154, 228)
        CodigoIdentificacionLabel.Name = "CodigoIdentificacionLabel"
        CodigoIdentificacionLabel.Size = New System.Drawing.Size(109, 13)
        CodigoIdentificacionLabel.TabIndex = 6
        CodigoIdentificacionLabel.Text = "Codigo Identificacion:"
        '
        'CodigoIdentificacionTextBox
        '
        Me.CodigoIdentificacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REPRESENTANTE_CLUBBindingSource, "CodigoIdentificacion", True))
        Me.CodigoIdentificacionTextBox.Location = New System.Drawing.Point(304, 225)
        Me.CodigoIdentificacionTextBox.Name = "CodigoIdentificacionTextBox"
        Me.CodigoIdentificacionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoIdentificacionTextBox.TabIndex = 7
        '
        'IdTipoIdenticacionLabel
        '
        IdTipoIdenticacionLabel.AutoSize = True
        IdTipoIdenticacionLabel.Location = New System.Drawing.Point(154, 254)
        IdTipoIdenticacionLabel.Name = "IdTipoIdenticacionLabel"
        IdTipoIdenticacionLabel.Size = New System.Drawing.Size(104, 13)
        IdTipoIdenticacionLabel.TabIndex = 8
        IdTipoIdenticacionLabel.Text = "Id Tipo Identicacion:"
        '
        'IdTipoIdenticacionTextBox
        '
        Me.IdTipoIdenticacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.REPRESENTANTE_CLUBBindingSource, "IdTipoIdenticacion", True))
        Me.IdTipoIdenticacionTextBox.Location = New System.Drawing.Point(304, 251)
        Me.IdTipoIdenticacionTextBox.Name = "IdTipoIdenticacionTextBox"
        Me.IdTipoIdenticacionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTipoIdenticacionTextBox.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(148, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(541, 37)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "FORMULARIO REPRESENTANTE"
        '
        'frmRepresentante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 585)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(NombreRepresentanteClubLabel)
        Me.Controls.Add(Me.NombreRepresentanteClubTextBox)
        Me.Controls.Add(ApellidoRepresentanteClubLabel)
        Me.Controls.Add(Me.ApellidoRepresentanteClubTextBox)
        Me.Controls.Add(CodigoIdentificacionLabel)
        Me.Controls.Add(Me.CodigoIdentificacionTextBox)
        Me.Controls.Add(IdTipoIdenticacionLabel)
        Me.Controls.Add(Me.IdTipoIdenticacionTextBox)
        Me.Controls.Add(Me.REPRESENTANTE_CLUBDataGridView)
        Me.Controls.Add(Me.REPRESENTANTE_CLUBBindingNavigator)
        Me.Name = "frmRepresentante"
        Me.Text = "frmRepresentante"
        CType(Me.LIGA_01_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REPRESENTANTE_CLUBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REPRESENTANTE_CLUBBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.REPRESENTANTE_CLUBBindingNavigator.ResumeLayout(False)
        Me.REPRESENTANTE_CLUBBindingNavigator.PerformLayout()
        CType(Me.REPRESENTANTE_CLUBDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LIGA_01_DBDataSet As LIGA_01_DBDataSet
    Friend WithEvents REPRESENTANTE_CLUBBindingSource As BindingSource
    Friend WithEvents REPRESENTANTE_CLUBTableAdapter As LIGA_01_DBDataSetTableAdapters.REPRESENTANTE_CLUBTableAdapter
    Friend WithEvents TableAdapterManager As LIGA_01_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents REPRESENTANTE_CLUBBindingNavigator As BindingNavigator
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
    Friend WithEvents REPRESENTANTE_CLUBBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents REPRESENTANTE_CLUBDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents NombreRepresentanteClubTextBox As TextBox
    Friend WithEvents ApellidoRepresentanteClubTextBox As TextBox
    Friend WithEvents CodigoIdentificacionTextBox As TextBox
    Friend WithEvents IdTipoIdenticacionTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
