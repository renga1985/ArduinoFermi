﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.DataGridViewTestProd = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridViewLanci = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewOperatori = New System.Windows.Forms.DataGridView()
        Me.DataGridViewFermi = New System.Windows.Forms.DataGridView()
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
        Me.LabelTitolo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.ChartMacchine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridViewTestProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewLanci, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewOperatori, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewFermi, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ChartMacchine.Size = New System.Drawing.Size(479, 346)
        Me.ChartMacchine.TabIndex = 0
        Me.ChartMacchine.Text = "Chart"
        '
        'DateTimePickerDa
        '
        Me.DateTimePickerDa.CustomFormat = ""
        Me.DateTimePickerDa.Location = New System.Drawing.Point(768, 7)
        Me.DateTimePickerDa.Name = "DateTimePickerDa"
        Me.DateTimePickerDa.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerDa.TabIndex = 1
        '
        'DateTimePickerA
        '
        Me.DateTimePickerA.Location = New System.Drawing.Point(768, 33)
        Me.DateTimePickerA.Name = "DateTimePickerA"
        Me.DateTimePickerA.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerA.TabIndex = 2
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(768, 83)
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
        Me.TabControl1.Location = New System.Drawing.Point(13, 46)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1209, 629)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.DataGridViewTestProd)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.DataGridViewLanci)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.DataGridViewOperatori)
        Me.TabPage1.Controls.Add(Me.DataGridViewFermi)
        Me.TabPage1.Controls.Add(Me.ComboBoxA)
        Me.TabPage1.Controls.Add(Me.ComboBoxDa)
        Me.TabPage1.Controls.Add(Me.ChartMacchine)
        Me.TabPage1.Controls.Add(Me.ButtonUpdate)
        Me.TabPage1.Controls.Add(Me.DateTimePickerDa)
        Me.TabPage1.Controls.Add(Me.DateTimePickerA)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1201, 603)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Fermi"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridViewTestProd
        '
        Me.DataGridViewTestProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTestProd.Location = New System.Drawing.Point(507, 174)
        Me.DataGridViewTestProd.Name = "DataGridViewTestProd"
        Me.DataGridViewTestProd.Size = New System.Drawing.Size(240, 178)
        Me.DataGridViewTestProd.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(765, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Lanci di produzione"
        '
        'DataGridViewLanci
        '
        Me.DataGridViewLanci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewLanci.Location = New System.Drawing.Point(768, 174)
        Me.DataGridViewLanci.Name = "DataGridViewLanci"
        Me.DataGridViewLanci.Size = New System.Drawing.Size(427, 178)
        Me.DataGridViewLanci.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(728, 364)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Personale caricato in linea"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 364)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Elenco fermate"
        '
        'DataGridViewOperatori
        '
        Me.DataGridViewOperatori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewOperatori.Location = New System.Drawing.Point(731, 383)
        Me.DataGridViewOperatori.Name = "DataGridViewOperatori"
        Me.DataGridViewOperatori.Size = New System.Drawing.Size(464, 242)
        Me.DataGridViewOperatori.TabIndex = 7
        '
        'DataGridViewFermi
        '
        Me.DataGridViewFermi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewFermi.Location = New System.Drawing.Point(6, 383)
        Me.DataGridViewFermi.Name = "DataGridViewFermi"
        Me.DataGridViewFermi.Size = New System.Drawing.Size(719, 242)
        Me.DataGridViewFermi.TabIndex = 6
        '
        'ComboBoxA
        '
        Me.ComboBoxA.FormattingEnabled = True
        Me.ComboBoxA.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.ComboBoxA.Location = New System.Drawing.Point(974, 32)
        Me.ComboBoxA.Name = "ComboBoxA"
        Me.ComboBoxA.Size = New System.Drawing.Size(44, 21)
        Me.ComboBoxA.TabIndex = 5
        '
        'ComboBoxDa
        '
        Me.ComboBoxDa.FormattingEnabled = True
        Me.ComboBoxDa.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.ComboBoxDa.Location = New System.Drawing.Point(974, 6)
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
        Me.TabPage2.Size = New System.Drawing.Size(1201, 603)
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
        'LabelTitolo
        '
        Me.LabelTitolo.AutoSize = True
        Me.LabelTitolo.Location = New System.Drawing.Point(13, 13)
        Me.LabelTitolo.Name = "LabelTitolo"
        Me.LabelTitolo.Size = New System.Drawing.Size(59, 13)
        Me.LabelTitolo.TabIndex = 9
        Me.LabelTitolo.Text = "LabelTitolo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(507, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Dati di produzione"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(726, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Da"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(726, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "A"
        '
        'AnalisiFermi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1218, 729)
        Me.Controls.Add(Me.LabelTitolo)
        Me.Controls.Add(Me.LabelPathDatabase)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "AnalisiFermi"
        Me.Text = "AnalisiFermi"
        CType(Me.ChartMacchine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridViewTestProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewLanci, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewOperatori, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewFermi, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridViewFermi As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewOperatori As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelTitolo As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewLanci As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTestProd As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
