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
        Dim ChartArea11 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend11 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim ChartArea12 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend12 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.ChartMacchine = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.DateTimePickerDa = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerA = New System.Windows.Forms.DateTimePicker()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ComboBoxA = New System.Windows.Forms.ComboBox()
        Me.ComboBoxDa = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ComboBoxGeneraleA = New System.Windows.Forms.ComboBox()
        Me.ComboBoxGeneraleDa = New System.Windows.Forms.ComboBox()
        Me.ButtonUpdateCausali = New System.Windows.Forms.Button()
        Me.DateTimePickerGENERALIDa = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerGENERALIA = New System.Windows.Forms.DateTimePicker()
        Me.ChartCausali = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.LabelPathDatabase = New System.Windows.Forms.Label()
        CType(Me.ChartMacchine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.ChartCausali, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChartMacchine
        '
        ChartArea11.Name = "ChartArea1"
        Me.ChartMacchine.ChartAreas.Add(ChartArea11)
        Legend11.Name = "Legend1"
        Me.ChartMacchine.Legends.Add(Legend11)
        Me.ChartMacchine.Location = New System.Drawing.Point(3, 6)
        Me.ChartMacchine.Name = "ChartMacchine"
        Me.ChartMacchine.Size = New System.Drawing.Size(936, 624)
        Me.ChartMacchine.TabIndex = 0
        Me.ChartMacchine.Text = "Chart"
        '
        'DateTimePickerDa
        '
        Me.DateTimePickerDa.CustomFormat = ""
        Me.DateTimePickerDa.Location = New System.Drawing.Point(945, 7)
        Me.DateTimePickerDa.Name = "DateTimePickerDa"
        Me.DateTimePickerDa.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerDa.TabIndex = 1
        '
        'DateTimePickerA
        '
        Me.DateTimePickerA.Location = New System.Drawing.Point(945, 32)
        Me.DateTimePickerA.Name = "DateTimePickerA"
        Me.DateTimePickerA.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerA.TabIndex = 2
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(945, 84)
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
        Me.TabPage1.Controls.Add(Me.ComboBoxA)
        Me.TabPage1.Controls.Add(Me.ComboBoxDa)
        Me.TabPage1.Controls.Add(Me.ChartMacchine)
        Me.TabPage1.Controls.Add(Me.ButtonUpdate)
        Me.TabPage1.Controls.Add(Me.DateTimePickerDa)
        Me.TabPage1.Controls.Add(Me.DateTimePickerA)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1201, 636)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Fermi"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ComboBoxA
        '
        Me.ComboBoxA.FormattingEnabled = True
        Me.ComboBoxA.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.ComboBoxA.Location = New System.Drawing.Point(1151, 32)
        Me.ComboBoxA.Name = "ComboBoxA"
        Me.ComboBoxA.Size = New System.Drawing.Size(44, 21)
        Me.ComboBoxA.TabIndex = 5
        '
        'ComboBoxDa
        '
        Me.ComboBoxDa.FormattingEnabled = True
        Me.ComboBoxDa.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.ComboBoxDa.Location = New System.Drawing.Point(1151, 6)
        Me.ComboBoxDa.Name = "ComboBoxDa"
        Me.ComboBoxDa.Size = New System.Drawing.Size(44, 21)
        Me.ComboBoxDa.TabIndex = 4
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ComboBoxGeneraleA)
        Me.TabPage2.Controls.Add(Me.ComboBoxGeneraleDa)
        Me.TabPage2.Controls.Add(Me.ButtonUpdateCausali)
        Me.TabPage2.Controls.Add(Me.DateTimePickerGENERALIDa)
        Me.TabPage2.Controls.Add(Me.DateTimePickerGENERALIA)
        Me.TabPage2.Controls.Add(Me.ChartCausali)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1201, 636)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Fermi-LINEA GENERALE"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ComboBoxGeneraleA
        '
        Me.ComboBoxGeneraleA.FormattingEnabled = True
        Me.ComboBoxGeneraleA.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.ComboBoxGeneraleA.Location = New System.Drawing.Point(1154, 35)
        Me.ComboBoxGeneraleA.Name = "ComboBoxGeneraleA"
        Me.ComboBoxGeneraleA.Size = New System.Drawing.Size(44, 21)
        Me.ComboBoxGeneraleA.TabIndex = 8
        '
        'ComboBoxGeneraleDa
        '
        Me.ComboBoxGeneraleDa.FormattingEnabled = True
        Me.ComboBoxGeneraleDa.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.ComboBoxGeneraleDa.Location = New System.Drawing.Point(1154, 6)
        Me.ComboBoxGeneraleDa.Name = "ComboBoxGeneraleDa"
        Me.ComboBoxGeneraleDa.Size = New System.Drawing.Size(44, 21)
        Me.ComboBoxGeneraleDa.TabIndex = 7
        '
        'ButtonUpdateCausali
        '
        Me.ButtonUpdateCausali.Location = New System.Drawing.Point(945, 88)
        Me.ButtonUpdateCausali.Name = "ButtonUpdateCausali"
        Me.ButtonUpdateCausali.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUpdateCausali.TabIndex = 6
        Me.ButtonUpdateCausali.Text = "Update"
        Me.ButtonUpdateCausali.UseVisualStyleBackColor = True
        '
        'DateTimePickerGENERALIDa
        '
        Me.DateTimePickerGENERALIDa.Location = New System.Drawing.Point(945, 6)
        Me.DateTimePickerGENERALIDa.Name = "DateTimePickerGENERALIDa"
        Me.DateTimePickerGENERALIDa.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerGENERALIDa.TabIndex = 4
        '
        'DateTimePickerGENERALIA
        '
        Me.DateTimePickerGENERALIA.Location = New System.Drawing.Point(945, 36)
        Me.DateTimePickerGENERALIA.Name = "DateTimePickerGENERALIA"
        Me.DateTimePickerGENERALIA.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerGENERALIA.TabIndex = 5
        '
        'ChartCausali
        '
        ChartArea12.Name = "ChartArea1"
        Me.ChartCausali.ChartAreas.Add(ChartArea12)
        Legend12.Name = "Legend1"
        Me.ChartCausali.Legends.Add(Legend12)
        Me.ChartCausali.Location = New System.Drawing.Point(6, 3)
        Me.ChartCausali.Name = "ChartCausali"
        Me.ChartCausali.Size = New System.Drawing.Size(893, 624)
        Me.ChartCausali.TabIndex = 1
        Me.ChartCausali.Text = "Chart"
        '
        'LabelPathDatabase
        '
        Me.LabelPathDatabase.AutoSize = True
        Me.LabelPathDatabase.Location = New System.Drawing.Point(566, -3)
        Me.LabelPathDatabase.Name = "LabelPathDatabase"
        Me.LabelPathDatabase.Size = New System.Drawing.Size(89, 13)
        Me.LabelPathDatabase.TabIndex = 8
        Me.LabelPathDatabase.Text = "LblPathDatabase"
        Me.LabelPathDatabase.Visible = False
        '
        'AnalisiFermi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1227, 672)
        Me.Controls.Add(Me.LabelPathDatabase)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "AnalisiFermi"
        Me.Text = "AnalisiFermi"
        CType(Me.ChartMacchine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.ChartCausali, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ChartMacchine As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents DateTimePickerDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerA As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonUpdate As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ButtonUpdateCausali As System.Windows.Forms.Button
    Friend WithEvents DateTimePickerGENERALIDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerGENERALIA As System.Windows.Forms.DateTimePicker
    Friend WithEvents ChartCausali As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents LabelPathDatabase As System.Windows.Forms.Label
    Friend WithEvents ComboBoxDa As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxA As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxGeneraleA As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxGeneraleDa As System.Windows.Forms.ComboBox

End Class
