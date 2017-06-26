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
        Me.DataGridViewFernate = New System.Windows.Forms.DataGridView()
        Me.DatabaseFermiDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateTimePickerTo = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerFrom = New System.Windows.Forms.DateTimePicker()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.BtnExportInExcel = New System.Windows.Forms.Button()
        CType(Me.DataGridViewFernate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseFermiDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewFernate
        '
        Me.DataGridViewFernate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewFernate.Location = New System.Drawing.Point(12, 75)
        Me.DataGridViewFernate.Name = "DataGridViewFernate"
        Me.DataGridViewFernate.Size = New System.Drawing.Size(984, 643)
        Me.DataGridViewFernate.TabIndex = 0
        '
        'DatabaseFermiDataSet
        '
        '
        'DatabaseFermiDataSetBindingSource
        '
        Me.DatabaseFermiDataSetBindingSource.Position = 0
        '
        'DateTimePickerTo
        '
        Me.DateTimePickerTo.Location = New System.Drawing.Point(61, 49)
        Me.DateTimePickerTo.Name = "DateTimePickerTo"
        Me.DateTimePickerTo.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerTo.TabIndex = 1
        '
        'DateTimePickerFrom
        '
        Me.DateTimePickerFrom.Location = New System.Drawing.Point(61, 23)
        Me.DateTimePickerFrom.Name = "DateTimePickerFrom"
        Me.DateTimePickerFrom.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerFrom.TabIndex = 2
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(267, 46)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUpdate.TabIndex = 3
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'BtnExportInExcel
        '
        Me.BtnExportInExcel.Location = New System.Drawing.Point(724, 46)
        Me.BtnExportInExcel.Name = "BtnExportInExcel"
        Me.BtnExportInExcel.Size = New System.Drawing.Size(92, 23)
        Me.BtnExportInExcel.TabIndex = 4
        Me.BtnExportInExcel.Text = "Export in Excel"
        Me.BtnExportInExcel.UseVisualStyleBackColor = True
        '
        'VisualizzaFermate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.BtnExportInExcel)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.DateTimePickerFrom)
        Me.Controls.Add(Me.DateTimePickerTo)
        Me.Controls.Add(Me.DataGridViewFernate)
        Me.Name = "VisualizzaFermate"
        Me.Text = "VisualizzaFermate"
        CType(Me.DataGridViewFernate, System.ComponentModel.ISupportInitialize).EndInit()
       CType(Me.DatabaseFermiDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewFernate As System.Windows.Forms.DataGridView
    Friend WithEvents DatabaseFermiDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DateTimePickerTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnExportInExcel As System.Windows.Forms.Button
End Class
