<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormManualInput
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelData = New System.Windows.Forms.Label()
        Me.LabelReparto = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxReparto = New System.Windows.Forms.TextBox()
        Me.LabelLinea = New System.Windows.Forms.Label()
        Me.TextBoxLinea = New System.Windows.Forms.TextBox()
        Me.LabelMacchina = New System.Windows.Forms.Label()
        Me.TextBoxMacchina = New System.Windows.Forms.TextBox()
        Me.LabelFermo = New System.Windows.Forms.Label()
        Me.TextBoxFermo = New System.Windows.Forms.TextBox()
        Me.LabelInizio = New System.Windows.Forms.Label()
        Me.TextBoxInizio = New System.Windows.Forms.TextBox()
        Me.LabelDurata = New System.Windows.Forms.Label()
        Me.TextBoxDurata = New System.Windows.Forms.TextBox()
        Me.ButtonRegistra = New System.Windows.Forms.Button()
        Me.LabelRepartoSelected = New System.Windows.Forms.Label()
        Me.LabelLineaSelected = New System.Windows.Forms.Label()
        Me.LabelMacchinaSelected = New System.Windows.Forms.Label()
        Me.LabelFermoSelected = New System.Windows.Forms.Label()
        Me.LabelPath = New System.Windows.Forms.Label()
        Me.LastLinea = New System.Windows.Forms.Label()
        Me.LastReparto = New System.Windows.Forms.Label()
        Me.TextBoxDA = New System.Windows.Forms.TextBox()
        Me.TextBoxA = New System.Windows.Forms.TextBox()
        Me.LabelDASelected = New System.Windows.Forms.Label()
        Me.LabelSecondarioSelected = New System.Windows.Forms.Label()
        Me.LabelASelected = New System.Windows.Forms.Label()
        Me.ComboBoxSecondario = New System.Windows.Forms.ComboBox()
        Me.LastMacchina = New System.Windows.Forms.Label()
        Me.LastFermo = New System.Windows.Forms.Label()
        Me.LastInizio = New System.Windows.Forms.Label()
        Me.LastDurata = New System.Windows.Forms.Label()
        Me.LastSecondario = New System.Windows.Forms.Label()
        Me.LastDA = New System.Windows.Forms.Label()
        Me.LastA = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelData
        '
        Me.LabelData.AutoSize = True
        Me.LabelData.Location = New System.Drawing.Point(65, 118)
        Me.LabelData.Name = "LabelData"
        Me.LabelData.Size = New System.Drawing.Size(30, 13)
        Me.LabelData.TabIndex = 0
        Me.LabelData.Text = "Data"
        '
        'LabelReparto
        '
        Me.LabelReparto.AutoSize = True
        Me.LabelReparto.Location = New System.Drawing.Point(65, 167)
        Me.LabelReparto.Name = "LabelReparto"
        Me.LabelReparto.Size = New System.Drawing.Size(45, 13)
        Me.LabelReparto.TabIndex = 1
        Me.LabelReparto.Text = "Reparto"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(163, 111)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'TextBoxReparto
        '
        Me.TextBoxReparto.Location = New System.Drawing.Point(163, 160)
        Me.TextBoxReparto.Name = "TextBoxReparto"
        Me.TextBoxReparto.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxReparto.TabIndex = 2
        '
        'LabelLinea
        '
        Me.LabelLinea.AutoSize = True
        Me.LabelLinea.Location = New System.Drawing.Point(65, 208)
        Me.LabelLinea.Name = "LabelLinea"
        Me.LabelLinea.Size = New System.Drawing.Size(33, 13)
        Me.LabelLinea.TabIndex = 4
        Me.LabelLinea.Text = "Linea"
        '
        'TextBoxLinea
        '
        Me.TextBoxLinea.Location = New System.Drawing.Point(163, 201)
        Me.TextBoxLinea.Name = "TextBoxLinea"
        Me.TextBoxLinea.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxLinea.TabIndex = 3
        '
        'LabelMacchina
        '
        Me.LabelMacchina.AutoSize = True
        Me.LabelMacchina.Location = New System.Drawing.Point(65, 248)
        Me.LabelMacchina.Name = "LabelMacchina"
        Me.LabelMacchina.Size = New System.Drawing.Size(54, 13)
        Me.LabelMacchina.TabIndex = 6
        Me.LabelMacchina.Text = "Macchina"
        '
        'TextBoxMacchina
        '
        Me.TextBoxMacchina.Location = New System.Drawing.Point(163, 241)
        Me.TextBoxMacchina.Name = "TextBoxMacchina"
        Me.TextBoxMacchina.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMacchina.TabIndex = 4
        '
        'LabelFermo
        '
        Me.LabelFermo.AutoSize = True
        Me.LabelFermo.Location = New System.Drawing.Point(65, 293)
        Me.LabelFermo.Name = "LabelFermo"
        Me.LabelFermo.Size = New System.Drawing.Size(36, 13)
        Me.LabelFermo.TabIndex = 8
        Me.LabelFermo.Text = "Fermo"
        '
        'TextBoxFermo
        '
        Me.TextBoxFermo.Location = New System.Drawing.Point(163, 286)
        Me.TextBoxFermo.Name = "TextBoxFermo"
        Me.TextBoxFermo.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxFermo.TabIndex = 5
        '
        'LabelInizio
        '
        Me.LabelInizio.AutoSize = True
        Me.LabelInizio.Location = New System.Drawing.Point(65, 349)
        Me.LabelInizio.Name = "LabelInizio"
        Me.LabelInizio.Size = New System.Drawing.Size(31, 13)
        Me.LabelInizio.TabIndex = 10
        Me.LabelInizio.Text = "Inizio"
        '
        'TextBoxInizio
        '
        Me.TextBoxInizio.Location = New System.Drawing.Point(163, 342)
        Me.TextBoxInizio.Name = "TextBoxInizio"
        Me.TextBoxInizio.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxInizio.TabIndex = 6
        '
        'LabelDurata
        '
        Me.LabelDurata.AutoSize = True
        Me.LabelDurata.Location = New System.Drawing.Point(65, 395)
        Me.LabelDurata.Name = "LabelDurata"
        Me.LabelDurata.Size = New System.Drawing.Size(39, 13)
        Me.LabelDurata.TabIndex = 12
        Me.LabelDurata.Text = "Durata"
        '
        'TextBoxDurata
        '
        Me.TextBoxDurata.Location = New System.Drawing.Point(163, 388)
        Me.TextBoxDurata.Name = "TextBoxDurata"
        Me.TextBoxDurata.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDurata.TabIndex = 7
        '
        'ButtonRegistra
        '
        Me.ButtonRegistra.Location = New System.Drawing.Point(399, 432)
        Me.ButtonRegistra.Name = "ButtonRegistra"
        Me.ButtonRegistra.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRegistra.TabIndex = 11
        Me.ButtonRegistra.Text = "Registra"
        Me.ButtonRegistra.UseVisualStyleBackColor = True
        '
        'LabelRepartoSelected
        '
        Me.LabelRepartoSelected.AutoSize = True
        Me.LabelRepartoSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRepartoSelected.Location = New System.Drawing.Point(369, 155)
        Me.LabelRepartoSelected.Name = "LabelRepartoSelected"
        Me.LabelRepartoSelected.Size = New System.Drawing.Size(0, 25)
        Me.LabelRepartoSelected.TabIndex = 15
        '
        'LabelLineaSelected
        '
        Me.LabelLineaSelected.AutoSize = True
        Me.LabelLineaSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLineaSelected.Location = New System.Drawing.Point(369, 196)
        Me.LabelLineaSelected.Name = "LabelLineaSelected"
        Me.LabelLineaSelected.Size = New System.Drawing.Size(0, 25)
        Me.LabelLineaSelected.TabIndex = 16
        Me.LabelLineaSelected.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelMacchinaSelected
        '
        Me.LabelMacchinaSelected.AutoSize = True
        Me.LabelMacchinaSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMacchinaSelected.Location = New System.Drawing.Point(369, 236)
        Me.LabelMacchinaSelected.Name = "LabelMacchinaSelected"
        Me.LabelMacchinaSelected.Size = New System.Drawing.Size(0, 25)
        Me.LabelMacchinaSelected.TabIndex = 17
        '
        'LabelFermoSelected
        '
        Me.LabelFermoSelected.AutoSize = True
        Me.LabelFermoSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFermoSelected.Location = New System.Drawing.Point(369, 281)
        Me.LabelFermoSelected.Name = "LabelFermoSelected"
        Me.LabelFermoSelected.Size = New System.Drawing.Size(0, 25)
        Me.LabelFermoSelected.TabIndex = 18
        '
        'LabelPath
        '
        Me.LabelPath.AutoSize = True
        Me.LabelPath.Location = New System.Drawing.Point(787, 82)
        Me.LabelPath.Name = "LabelPath"
        Me.LabelPath.Size = New System.Drawing.Size(49, 13)
        Me.LabelPath.TabIndex = 19
        Me.LabelPath.Text = "Percorso"
        '
        'LastLinea
        '
        Me.LastLinea.AutoSize = True
        Me.LastLinea.Location = New System.Drawing.Point(572, 187)
        Me.LastLinea.Name = "LastLinea"
        Me.LastLinea.Size = New System.Drawing.Size(62, 13)
        Me.LastLinea.TabIndex = 20
        Me.LastLinea.Text = "UltimaLinea"
        '
        'LastReparto
        '
        Me.LastReparto.AutoSize = True
        Me.LastReparto.Location = New System.Drawing.Point(572, 155)
        Me.LastReparto.Name = "LastReparto"
        Me.LastReparto.Size = New System.Drawing.Size(74, 13)
        Me.LastReparto.TabIndex = 21
        Me.LastReparto.Text = "UltimoReparto"
        '
        'TextBoxDA
        '
        Me.TextBoxDA.Location = New System.Drawing.Point(163, 482)
        Me.TextBoxDA.Name = "TextBoxDA"
        Me.TextBoxDA.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDA.TabIndex = 9
        '
        'TextBoxA
        '
        Me.TextBoxA.Location = New System.Drawing.Point(163, 508)
        Me.TextBoxA.Name = "TextBoxA"
        Me.TextBoxA.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxA.TabIndex = 10
        '
        'LabelDASelected
        '
        Me.LabelDASelected.AutoSize = True
        Me.LabelDASelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDASelected.Location = New System.Drawing.Point(91, 482)
        Me.LabelDASelected.Name = "LabelDASelected"
        Me.LabelDASelected.Size = New System.Drawing.Size(32, 20)
        Me.LabelDASelected.TabIndex = 18
        Me.LabelDASelected.Text = "DA"
        '
        'LabelSecondarioSelected
        '
        Me.LabelSecondarioSelected.AutoSize = True
        Me.LabelSecondarioSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabelSecondarioSelected.Location = New System.Drawing.Point(65, 440)
        Me.LabelSecondarioSelected.Name = "LabelSecondarioSelected"
        Me.LabelSecondarioSelected.Size = New System.Drawing.Size(61, 13)
        Me.LabelSecondarioSelected.TabIndex = 18
        Me.LabelSecondarioSelected.Text = "Secondario"
        '
        'LabelASelected
        '
        Me.LabelASelected.AutoSize = True
        Me.LabelASelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelASelected.Location = New System.Drawing.Point(91, 508)
        Me.LabelASelected.Name = "LabelASelected"
        Me.LabelASelected.Size = New System.Drawing.Size(20, 20)
        Me.LabelASelected.TabIndex = 18
        Me.LabelASelected.Text = "A"
        '
        'ComboBoxSecondario
        '
        Me.ComboBoxSecondario.FormattingEnabled = True
        Me.ComboBoxSecondario.Items.AddRange(New Object() {"VERO", "FALSO"})
        Me.ComboBoxSecondario.Location = New System.Drawing.Point(163, 432)
        Me.ComboBoxSecondario.Name = "ComboBoxSecondario"
        Me.ComboBoxSecondario.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxSecondario.TabIndex = 8
        Me.ComboBoxSecondario.Text = "FALSO"
        '
        'LastMacchina
        '
        Me.LastMacchina.AutoSize = True
        Me.LastMacchina.Location = New System.Drawing.Point(572, 217)
        Me.LastMacchina.Name = "LastMacchina"
        Me.LastMacchina.Size = New System.Drawing.Size(83, 13)
        Me.LastMacchina.TabIndex = 21
        Me.LastMacchina.Text = "UltimaMacchina"
        '
        'LastFermo
        '
        Me.LastFermo.AutoSize = True
        Me.LastFermo.Location = New System.Drawing.Point(572, 248)
        Me.LastFermo.Name = "LastFermo"
        Me.LastFermo.Size = New System.Drawing.Size(65, 13)
        Me.LastFermo.TabIndex = 21
        Me.LastFermo.Text = "UltimoFermo"
        '
        'LastInizio
        '
        Me.LastInizio.AutoSize = True
        Me.LastInizio.Location = New System.Drawing.Point(572, 297)
        Me.LastInizio.Name = "LastInizio"
        Me.LastInizio.Size = New System.Drawing.Size(60, 13)
        Me.LastInizio.TabIndex = 21
        Me.LastInizio.Text = "UltimoInizio"
        '
        'LastDurata
        '
        Me.LastDurata.AutoSize = True
        Me.LastDurata.Location = New System.Drawing.Point(572, 320)
        Me.LastDurata.Name = "LastDurata"
        Me.LastDurata.Size = New System.Drawing.Size(68, 13)
        Me.LastDurata.TabIndex = 21
        Me.LastDurata.Text = "UltimaDurata"
        '
        'LastSecondario
        '
        Me.LastSecondario.AutoSize = True
        Me.LastSecondario.Location = New System.Drawing.Point(572, 361)
        Me.LastSecondario.Name = "LastSecondario"
        Me.LastSecondario.Size = New System.Drawing.Size(90, 13)
        Me.LastSecondario.TabIndex = 21
        Me.LastSecondario.Text = "UltimoSecondario"
        '
        'LastDA
        '
        Me.LastDA.AutoSize = True
        Me.LastDA.Location = New System.Drawing.Point(572, 395)
        Me.LastDA.Name = "LastDA"
        Me.LastDA.Size = New System.Drawing.Size(51, 13)
        Me.LastDA.TabIndex = 21
        Me.LastDA.Text = "UltimoDA"
        '
        'LastA
        '
        Me.LastA.AutoSize = True
        Me.LastA.Location = New System.Drawing.Point(572, 420)
        Me.LastA.Name = "LastA"
        Me.LastA.Size = New System.Drawing.Size(43, 13)
        Me.LastA.TabIndex = 21
        Me.LastA.Text = "UltimoA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(572, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 20)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Ultimo fermo inserito"
        '
        'FormManualInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.ComboBoxSecondario)
        Me.Controls.Add(Me.LastA)
        Me.Controls.Add(Me.LastDA)
        Me.Controls.Add(Me.LastSecondario)
        Me.Controls.Add(Me.LastDurata)
        Me.Controls.Add(Me.LastInizio)
        Me.Controls.Add(Me.LastFermo)
        Me.Controls.Add(Me.LastMacchina)
        Me.Controls.Add(Me.LastReparto)
        Me.Controls.Add(Me.LastLinea)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelPath)
        Me.Controls.Add(Me.LabelDASelected)
        Me.Controls.Add(Me.LabelSecondarioSelected)
        Me.Controls.Add(Me.LabelASelected)
        Me.Controls.Add(Me.LabelFermoSelected)
        Me.Controls.Add(Me.LabelMacchinaSelected)
        Me.Controls.Add(Me.LabelLineaSelected)
        Me.Controls.Add(Me.LabelRepartoSelected)
        Me.Controls.Add(Me.ButtonRegistra)
        Me.Controls.Add(Me.TextBoxA)
        Me.Controls.Add(Me.TextBoxDA)
        Me.Controls.Add(Me.TextBoxDurata)
        Me.Controls.Add(Me.LabelDurata)
        Me.Controls.Add(Me.TextBoxInizio)
        Me.Controls.Add(Me.LabelInizio)
        Me.Controls.Add(Me.TextBoxFermo)
        Me.Controls.Add(Me.LabelFermo)
        Me.Controls.Add(Me.TextBoxMacchina)
        Me.Controls.Add(Me.LabelMacchina)
        Me.Controls.Add(Me.TextBoxLinea)
        Me.Controls.Add(Me.LabelLinea)
        Me.Controls.Add(Me.TextBoxReparto)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.LabelReparto)
        Me.Controls.Add(Me.LabelData)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Name = "FormManualInput"
        Me.Text = "FormManualInput"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelData As System.Windows.Forms.Label
    Friend WithEvents LabelReparto As System.Windows.Forms.Label
    Friend WithEvents TextBoxReparto As System.Windows.Forms.TextBox
    Friend WithEvents LabelLinea As System.Windows.Forms.Label
    Friend WithEvents TextBoxLinea As System.Windows.Forms.TextBox
    Friend WithEvents LabelMacchina As System.Windows.Forms.Label
    Friend WithEvents TextBoxMacchina As System.Windows.Forms.TextBox
    Friend WithEvents LabelFermo As System.Windows.Forms.Label
    Friend WithEvents TextBoxFermo As System.Windows.Forms.TextBox
    Friend WithEvents LabelInizio As System.Windows.Forms.Label
    Friend WithEvents TextBoxInizio As System.Windows.Forms.TextBox
    Friend WithEvents LabelDurata As System.Windows.Forms.Label
    Friend WithEvents TextBoxDurata As System.Windows.Forms.TextBox
    Friend WithEvents ButtonRegistra As System.Windows.Forms.Button
    Friend WithEvents LabelRepartoSelected As System.Windows.Forms.Label
    Friend WithEvents LabelLineaSelected As System.Windows.Forms.Label
    Friend WithEvents LabelMacchinaSelected As System.Windows.Forms.Label
    Friend WithEvents LabelFermoSelected As System.Windows.Forms.Label
    Friend WithEvents LabelPath As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents LastLinea As System.Windows.Forms.Label
    Friend WithEvents LastReparto As System.Windows.Forms.Label
    Friend WithEvents TextBoxDA As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxA As System.Windows.Forms.TextBox
    Friend WithEvents LabelDASelected As System.Windows.Forms.Label
    Friend WithEvents LabelSecondarioSelected As System.Windows.Forms.Label
    Friend WithEvents LabelASelected As System.Windows.Forms.Label
    Friend WithEvents ComboBoxSecondario As System.Windows.Forms.ComboBox
    Friend WithEvents LastMacchina As System.Windows.Forms.Label
    Friend WithEvents LastFermo As System.Windows.Forms.Label
    Friend WithEvents LastInizio As System.Windows.Forms.Label
    Friend WithEvents LastDurata As System.Windows.Forms.Label
    Friend WithEvents LastSecondario As System.Windows.Forms.Label
    Friend WithEvents LastDA As System.Windows.Forms.Label
    Friend WithEvents LastA As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
