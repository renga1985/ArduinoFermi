<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisualizzaFermate
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridFermate As System.Windows.Forms.DataGridView
        Me.VRNFermiDataSet = New ArduinoFermi.VRNFermiDataSet()
        Me.FermiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FermiTableAdapter = New ArduinoFermi.VRNFermiDataSetTableAdapters.FermiTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescRepartoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdRepartoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdLineaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescLineaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdMacchinaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdFermoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescMacchinaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescFermoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DurataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescFermoEstesoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        DataGridFermate = New System.Windows.Forms.DataGridView()
        CType(DataGridFermate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VRNFermiDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FermiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridFermate
        '
        DataGridFermate.AutoGenerateColumns = False
        DataGridFermate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridFermate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridFermate.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.DataDataGridViewTextBoxColumn, Me.DescRepartoDataGridViewTextBoxColumn, Me.IdRepartoDataGridViewTextBoxColumn, Me.IdLineaDataGridViewTextBoxColumn, Me.DescLineaDataGridViewTextBoxColumn, Me.IdMacchinaDataGridViewTextBoxColumn, Me.IdFermoDataGridViewTextBoxColumn, Me.DescMacchinaDataGridViewTextBoxColumn, Me.DescFermoDataGridViewTextBoxColumn, Me.DurataDataGridViewTextBoxColumn, Me.DescFermoEstesoDataGridViewTextBoxColumn})
        DataGridFermate.DataSource = Me.FermiBindingSource
        DataGridFermate.Location = New System.Drawing.Point(3, 65)
        DataGridFermate.Name = "DataGridFermate"
        DataGridFermate.Size = New System.Drawing.Size(983, 417)
        DataGridFermate.TabIndex = 0
        '
        'VRNFermiDataSet
        '
        Me.VRNFermiDataSet.DataSetName = "VRNFermiDataSet"
        Me.VRNFermiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FermiBindingSource
        '
        Me.FermiBindingSource.DataMember = "Fermi"
        Me.FermiBindingSource.DataSource = Me.VRNFermiDataSet
        '
        'FermiTableAdapter
        '
        Me.FermiTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Width = 41
        '
        'DataDataGridViewTextBoxColumn
        '
        Me.DataDataGridViewTextBoxColumn.DataPropertyName = "Data"
        Me.DataDataGridViewTextBoxColumn.HeaderText = "Data"
        Me.DataDataGridViewTextBoxColumn.Name = "DataDataGridViewTextBoxColumn"
        Me.DataDataGridViewTextBoxColumn.Width = 55
        '
        'DescRepartoDataGridViewTextBoxColumn
        '
        Me.DescRepartoDataGridViewTextBoxColumn.DataPropertyName = "DescReparto"
        Me.DescRepartoDataGridViewTextBoxColumn.HeaderText = "DescReparto"
        Me.DescRepartoDataGridViewTextBoxColumn.Name = "DescRepartoDataGridViewTextBoxColumn"
        Me.DescRepartoDataGridViewTextBoxColumn.Width = 95
        '
        'IdRepartoDataGridViewTextBoxColumn
        '
        Me.IdRepartoDataGridViewTextBoxColumn.DataPropertyName = "IdReparto"
        Me.IdRepartoDataGridViewTextBoxColumn.HeaderText = "IdReparto"
        Me.IdRepartoDataGridViewTextBoxColumn.Name = "IdRepartoDataGridViewTextBoxColumn"
        Me.IdRepartoDataGridViewTextBoxColumn.Width = 79
        '
        'IdLineaDataGridViewTextBoxColumn
        '
        Me.IdLineaDataGridViewTextBoxColumn.DataPropertyName = "IdLinea"
        Me.IdLineaDataGridViewTextBoxColumn.HeaderText = "IdLinea"
        Me.IdLineaDataGridViewTextBoxColumn.Name = "IdLineaDataGridViewTextBoxColumn"
        Me.IdLineaDataGridViewTextBoxColumn.Width = 67
        '
        'DescLineaDataGridViewTextBoxColumn
        '
        Me.DescLineaDataGridViewTextBoxColumn.DataPropertyName = "DescLinea"
        Me.DescLineaDataGridViewTextBoxColumn.HeaderText = "DescLinea"
        Me.DescLineaDataGridViewTextBoxColumn.Name = "DescLineaDataGridViewTextBoxColumn"
        Me.DescLineaDataGridViewTextBoxColumn.Width = 83
        '
        'IdMacchinaDataGridViewTextBoxColumn
        '
        Me.IdMacchinaDataGridViewTextBoxColumn.DataPropertyName = "IdMacchina"
        Me.IdMacchinaDataGridViewTextBoxColumn.HeaderText = "IdMacchina"
        Me.IdMacchinaDataGridViewTextBoxColumn.Name = "IdMacchinaDataGridViewTextBoxColumn"
        Me.IdMacchinaDataGridViewTextBoxColumn.Width = 88
        '
        'IdFermoDataGridViewTextBoxColumn
        '
        Me.IdFermoDataGridViewTextBoxColumn.DataPropertyName = "IdFermo"
        Me.IdFermoDataGridViewTextBoxColumn.HeaderText = "IdFermo"
        Me.IdFermoDataGridViewTextBoxColumn.Name = "IdFermoDataGridViewTextBoxColumn"
        Me.IdFermoDataGridViewTextBoxColumn.Width = 70
        '
        'DescMacchinaDataGridViewTextBoxColumn
        '
        Me.DescMacchinaDataGridViewTextBoxColumn.DataPropertyName = "DescMacchina"
        Me.DescMacchinaDataGridViewTextBoxColumn.HeaderText = "DescMacchina"
        Me.DescMacchinaDataGridViewTextBoxColumn.Name = "DescMacchinaDataGridViewTextBoxColumn"
        Me.DescMacchinaDataGridViewTextBoxColumn.Width = 104
        '
        'DescFermoDataGridViewTextBoxColumn
        '
        Me.DescFermoDataGridViewTextBoxColumn.DataPropertyName = "DescFermo"
        Me.DescFermoDataGridViewTextBoxColumn.HeaderText = "DescFermo"
        Me.DescFermoDataGridViewTextBoxColumn.Name = "DescFermoDataGridViewTextBoxColumn"
        Me.DescFermoDataGridViewTextBoxColumn.Width = 86
        '
        'DurataDataGridViewTextBoxColumn
        '
        Me.DurataDataGridViewTextBoxColumn.DataPropertyName = "Durata"
        Me.DurataDataGridViewTextBoxColumn.HeaderText = "Durata"
        Me.DurataDataGridViewTextBoxColumn.Name = "DurataDataGridViewTextBoxColumn"
        Me.DurataDataGridViewTextBoxColumn.Width = 64
        '
        'DescFermoEstesoDataGridViewTextBoxColumn
        '
        Me.DescFermoEstesoDataGridViewTextBoxColumn.DataPropertyName = "DescFermoEsteso"
        Me.DescFermoEstesoDataGridViewTextBoxColumn.HeaderText = "DescFermoEsteso"
        Me.DescFermoEstesoDataGridViewTextBoxColumn.Name = "DescFermoEstesoDataGridViewTextBoxColumn"
        Me.DescFermoEstesoDataGridViewTextBoxColumn.Width = 118
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(3, 26)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'VisualizzaFermate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 485)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(DataGridFermate)
        Me.Name = "VisualizzaFermate"
        Me.Text = "VisualizzaFermate"
        CType(DataGridFermate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VRNFermiDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FermiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VRNFermiDataSet As ArduinoFermi.VRNFermiDataSet
    Friend WithEvents FermiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FermiTableAdapter As ArduinoFermi.VRNFermiDataSetTableAdapters.FermiTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescRepartoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdRepartoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdLineaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescLineaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdMacchinaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdFermoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescMacchinaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescFermoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DurataDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescFermoEstesoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
