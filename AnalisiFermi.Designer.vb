<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnalisiFermi
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.ChartMacchine = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.DateTimePickerDa = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerA = New System.Windows.Forms.DateTimePicker()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ComboBoxMacchina = New System.Windows.Forms.ComboBox()
        Me.ButtonUpdateCausali = New System.Windows.Forms.Button()
        Me.DateTimePickerCausaliDa = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerCausaliA = New System.Windows.Forms.DateTimePicker()
        Me.ChartCausali = New System.Windows.Forms.DataVisualization.Charting.Chart()

        CType(Me.ChartMacchine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.ChartCausali, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChartMacchine
        '
        ChartArea1.Name = "ChartArea1"
        Me.ChartMacchine.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.ChartMacchine.Legends.Add(Legend1)
        Me.ChartMacchine.Location = New System.Drawing.Point(3, 6)
        Me.ChartMacchine.Name = "ChartMacchine"
        Me.ChartMacchine.Size = New System.Drawing.Size(893, 624)
        Me.ChartMacchine.TabIndex = 0
        Me.ChartMacchine.Text = "Chart"
        '
        'DateTimePickerDa
        '
        Me.DateTimePickerDa.Location = New System.Drawing.Point(995, 6)
        Me.DateTimePickerDa.Name = "DateTimePickerDa"
        Me.DateTimePickerDa.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerDa.TabIndex = 1
        '
        'DateTimePickerA
        '
        Me.DateTimePickerA.Location = New System.Drawing.Point(995, 32)
        Me.DateTimePickerA.Name = "DateTimePickerA"
        Me.DateTimePickerA.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerA.TabIndex = 2
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(995, 109)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUpdate.TabIndex = 3
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1209, 662)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ChartMacchine)
        Me.TabPage1.Controls.Add(Me.ButtonUpdate)
        Me.TabPage1.Controls.Add(Me.DateTimePickerDa)
        Me.TabPage1.Controls.Add(Me.DateTimePickerA)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1201, 636)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Macchine"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ComboBoxMacchina)
        Me.TabPage2.Controls.Add(Me.ButtonUpdateCausali)
        Me.TabPage2.Controls.Add(Me.DateTimePickerCausaliDa)
        Me.TabPage2.Controls.Add(Me.DateTimePickerCausaliA)
        Me.TabPage2.Controls.Add(Me.ChartCausali)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1201, 636)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Causali"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ComboBoxMacchina
        '
        Me.ComboBoxMacchina.FormattingEnabled = True
        Me.ComboBoxMacchina.Items.AddRange(New Object() {"Linea Generale"})
        Me.ComboBoxMacchina.Location = New System.Drawing.Point(995, 58)
        Me.ComboBoxMacchina.Name = "ComboBoxMacchina"
        Me.ComboBoxMacchina.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxMacchina.TabIndex = 7
        '
        'ButtonUpdateCausali
        '
        Me.ButtonUpdateCausali.Location = New System.Drawing.Point(995, 107)
        Me.ButtonUpdateCausali.Name = "ButtonUpdateCausali"
        Me.ButtonUpdateCausali.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUpdateCausali.TabIndex = 6
        Me.ButtonUpdateCausali.Text = "Update"
        Me.ButtonUpdateCausali.UseVisualStyleBackColor = True
        '
        'DateTimePickerCausaliDa
        '
        Me.DateTimePickerCausaliDa.Location = New System.Drawing.Point(995, 6)
        Me.DateTimePickerCausaliDa.Name = "DateTimePickerCausaliDa"
        Me.DateTimePickerCausaliDa.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerCausaliDa.TabIndex = 4
        '
        'DateTimePickerCausaliA
        '
        Me.DateTimePickerCausaliA.Location = New System.Drawing.Point(995, 32)
        Me.DateTimePickerCausaliA.Name = "DateTimePickerCausaliA"
        Me.DateTimePickerCausaliA.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerCausaliA.TabIndex = 5
        '
        'ChartCausali
        '
        ChartArea2.Name = "ChartArea1"
        Me.ChartCausali.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.ChartCausali.Legends.Add(Legend2)
        Me.ChartCausali.Location = New System.Drawing.Point(6, 3)
        Me.ChartCausali.Name = "ChartCausali"
        Me.ChartCausali.Size = New System.Drawing.Size(893, 624)
        Me.ChartCausali.TabIndex = 1
        Me.ChartCausali.Text = "Chart"
        '
        'DatabaseFermiDataSet1
        '
        '
        'AnalisiFermi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1227, 672)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "AnalisiFermi"
        Me.Text = "AnalisiFermi"
        CType(Me.ChartMacchine,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabControl1.ResumeLayout(false)
        Me.TabPage1.ResumeLayout(false)
        Me.TabPage2.ResumeLayout(false)
        CType(Me.ChartCausali,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents ChartMacchine As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents DateTimePickerDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerA As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonUpdate As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ButtonUpdateCausali As System.Windows.Forms.Button
    Friend WithEvents DateTimePickerCausaliDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerCausaliA As System.Windows.Forms.DateTimePicker
    Friend WithEvents ChartCausali As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents ComboBoxMacchina As System.Windows.Forms.ComboBox

End Class
