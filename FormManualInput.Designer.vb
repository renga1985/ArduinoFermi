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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelPath = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelData
        '
        Me.LabelData.AutoSize = True
        Me.LabelData.Location = New System.Drawing.Point(35, 118)
        Me.LabelData.Name = "LabelData"
        Me.LabelData.Size = New System.Drawing.Size(30, 13)
        Me.LabelData.TabIndex = 0
        Me.LabelData.Text = "Data"
        '
        'LabelReparto
        '
        Me.LabelReparto.AutoSize = True
        Me.LabelReparto.Location = New System.Drawing.Point(35, 163)
        Me.LabelReparto.Name = "LabelReparto"
        Me.LabelReparto.Size = New System.Drawing.Size(45, 13)
        Me.LabelReparto.TabIndex = 1
        Me.LabelReparto.Text = "Reparto"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(172, 111)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'TextBoxReparto
        '
        Me.TextBoxReparto.Location = New System.Drawing.Point(272, 160)
        Me.TextBoxReparto.Name = "TextBoxReparto"
        Me.TextBoxReparto.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxReparto.TabIndex = 3
        '
        'LabelLinea
        '
        Me.LabelLinea.AutoSize = True
        Me.LabelLinea.Location = New System.Drawing.Point(35, 220)
        Me.LabelLinea.Name = "LabelLinea"
        Me.LabelLinea.Size = New System.Drawing.Size(33, 13)
        Me.LabelLinea.TabIndex = 4
        Me.LabelLinea.Text = "Linea"
        '
        'TextBoxLinea
        '
        Me.TextBoxLinea.Location = New System.Drawing.Point(272, 213)
        Me.TextBoxLinea.Name = "TextBoxLinea"
        Me.TextBoxLinea.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxLinea.TabIndex = 5
        '
        'LabelMacchina
        '
        Me.LabelMacchina.AutoSize = True
        Me.LabelMacchina.Location = New System.Drawing.Point(35, 259)
        Me.LabelMacchina.Name = "LabelMacchina"
        Me.LabelMacchina.Size = New System.Drawing.Size(54, 13)
        Me.LabelMacchina.TabIndex = 6
        Me.LabelMacchina.Text = "Macchina"
        '
        'TextBoxMacchina
        '
        Me.TextBoxMacchina.Location = New System.Drawing.Point(272, 252)
        Me.TextBoxMacchina.Name = "TextBoxMacchina"
        Me.TextBoxMacchina.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMacchina.TabIndex = 7
        '
        'LabelFermo
        '
        Me.LabelFermo.AutoSize = True
        Me.LabelFermo.Location = New System.Drawing.Point(35, 318)
        Me.LabelFermo.Name = "LabelFermo"
        Me.LabelFermo.Size = New System.Drawing.Size(36, 13)
        Me.LabelFermo.TabIndex = 8
        Me.LabelFermo.Text = "Fermo"
        '
        'TextBoxFermo
        '
        Me.TextBoxFermo.Location = New System.Drawing.Point(272, 311)
        Me.TextBoxFermo.Name = "TextBoxFermo"
        Me.TextBoxFermo.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxFermo.TabIndex = 9
        '
        'LabelInizio
        '
        Me.LabelInizio.AutoSize = True
        Me.LabelInizio.Location = New System.Drawing.Point(35, 368)
        Me.LabelInizio.Name = "LabelInizio"
        Me.LabelInizio.Size = New System.Drawing.Size(31, 13)
        Me.LabelInizio.TabIndex = 10
        Me.LabelInizio.Text = "Inizio"
        '
        'TextBoxInizio
        '
        Me.TextBoxInizio.Location = New System.Drawing.Point(272, 365)
        Me.TextBoxInizio.Name = "TextBoxInizio"
        Me.TextBoxInizio.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxInizio.TabIndex = 11
        '
        'LabelDurata
        '
        Me.LabelDurata.AutoSize = True
        Me.LabelDurata.Location = New System.Drawing.Point(35, 413)
        Me.LabelDurata.Name = "LabelDurata"
        Me.LabelDurata.Size = New System.Drawing.Size(39, 13)
        Me.LabelDurata.TabIndex = 12
        Me.LabelDurata.Text = "Durata"
        '
        'TextBoxDurata
        '
        Me.TextBoxDurata.Location = New System.Drawing.Point(272, 406)
        Me.TextBoxDurata.Name = "TextBoxDurata"
        Me.TextBoxDurata.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDurata.TabIndex = 13
        '
        'ButtonRegistra
        '
        Me.ButtonRegistra.Location = New System.Drawing.Point(297, 445)
        Me.ButtonRegistra.Name = "ButtonRegistra"
        Me.ButtonRegistra.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRegistra.TabIndex = 14
        Me.ButtonRegistra.Text = "Registra"
        Me.ButtonRegistra.UseVisualStyleBackColor = True
        '
        'LabelRepartoSelected
        '
        Me.LabelRepartoSelected.AutoSize = True
        Me.LabelRepartoSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRepartoSelected.Location = New System.Drawing.Point(474, 151)
        Me.LabelRepartoSelected.Name = "LabelRepartoSelected"
        Me.LabelRepartoSelected.Size = New System.Drawing.Size(95, 25)
        Me.LabelRepartoSelected.TabIndex = 15
        Me.LabelRepartoSelected.Text = "Reparto"
        '
        'LabelLineaSelected
        '
        Me.LabelLineaSelected.AutoSize = True
        Me.LabelLineaSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLineaSelected.Location = New System.Drawing.Point(474, 207)
        Me.LabelLineaSelected.Name = "LabelLineaSelected"
        Me.LabelLineaSelected.Size = New System.Drawing.Size(70, 25)
        Me.LabelLineaSelected.TabIndex = 16
        Me.LabelLineaSelected.Text = "Linea"
        Me.LabelLineaSelected.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelMacchinaSelected
        '
        Me.LabelMacchinaSelected.AutoSize = True
        Me.LabelMacchinaSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMacchinaSelected.Location = New System.Drawing.Point(474, 250)
        Me.LabelMacchinaSelected.Name = "LabelMacchinaSelected"
        Me.LabelMacchinaSelected.Size = New System.Drawing.Size(113, 25)
        Me.LabelMacchinaSelected.TabIndex = 17
        Me.LabelMacchinaSelected.Text = "Macchina"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(474, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 25)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Fermo"
        '
        'LabelPath
        '
        Me.LabelPath.AutoSize = True
        Me.LabelPath.Location = New System.Drawing.Point(751, 118)
        Me.LabelPath.Name = "LabelPath"
        Me.LabelPath.Size = New System.Drawing.Size(39, 13)
        Me.LabelPath.TabIndex = 19
        Me.LabelPath.Text = "Label5"
        '
        'FormManualInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.LabelPath)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabelMacchinaSelected)
        Me.Controls.Add(Me.LabelLineaSelected)
        Me.Controls.Add(Me.LabelRepartoSelected)
        Me.Controls.Add(Me.ButtonRegistra)
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
        Me.Name = "FormManualInput"
        Me.Text = "FormManualInput"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelData As System.Windows.Forms.Label
    Friend WithEvents LabelReparto As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LabelPath As System.Windows.Forms.Label
End Class
