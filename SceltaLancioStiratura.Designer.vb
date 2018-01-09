<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SceltaLancioStiratura
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
        Me.TextBoxLancioProduzione = New System.Windows.Forms.TextBox()
        Me.LabelMateriale = New System.Windows.Forms.Label()
        Me.LabelCodice = New System.Windows.Forms.Label()
        Me.LabelQP = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelQuantitàMancante = New System.Windows.Forms.Label()
        Me.LabelQuantitàLancio = New System.Windows.Forms.Label()
        Me.LabelTurno = New System.Windows.Forms.Label()
        Me.ComboBoxTurno = New System.Windows.Forms.ComboBox()
        Me.LabelLancio = New System.Windows.Forms.Label()
        Me.LabelCavalletti = New System.Windows.Forms.Label()
        Me.LabelProduzioneTurno = New System.Windows.Forms.Label()
        Me.LabelScartoTurno = New System.Windows.Forms.Label()
        Me.LabelPiastre = New System.Windows.Forms.Label()
        Me.LabelScartoDivider = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxCavalletti = New System.Windows.Forms.TextBox()
        Me.TextBoxProduzionePiastre = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBoxLancio = New System.Windows.Forms.ComboBox()
        Me.ButtonSalvaTurno = New System.Windows.Forms.Button()
        Me.ButtonConfermaLancio = New System.Windows.Forms.Button()
        Me.ButtonChiudiLancio = New System.Windows.Forms.Button()
        Me.ButtonCancella = New System.Windows.Forms.Button()
        Me.LabelCodiceLinea = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxLancioProduzione
        '
        Me.TextBoxLancioProduzione.Location = New System.Drawing.Point(12, 42)
        Me.TextBoxLancioProduzione.Name = "TextBoxLancioProduzione"
        Me.TextBoxLancioProduzione.Size = New System.Drawing.Size(118, 20)
        Me.TextBoxLancioProduzione.TabIndex = 0
        '
        'LabelMateriale
        '
        Me.LabelMateriale.AutoSize = True
        Me.LabelMateriale.Location = New System.Drawing.Point(138, 20)
        Me.LabelMateriale.Name = "LabelMateriale"
        Me.LabelMateriale.Size = New System.Drawing.Size(40, 13)
        Me.LabelMateriale.TabIndex = 1
        Me.LabelMateriale.Text = "Codice"
        '
        'LabelCodice
        '
        Me.LabelCodice.AutoSize = True
        Me.LabelCodice.Location = New System.Drawing.Point(174, 20)
        Me.LabelCodice.Name = "LabelCodice"
        Me.LabelCodice.Size = New System.Drawing.Size(39, 13)
        Me.LabelCodice.TabIndex = 1
        Me.LabelCodice.Text = "Label1"
        '
        'LabelQP
        '
        Me.LabelQP.AutoSize = True
        Me.LabelQP.Location = New System.Drawing.Point(232, 20)
        Me.LabelQP.Name = "LabelQP"
        Me.LabelQP.Size = New System.Drawing.Size(88, 13)
        Me.LabelQP.TabIndex = 1
        Me.LabelQP.Text = "Quantità Prevista"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(232, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Quantità Mancante"
        '
        'LabelQuantitàMancante
        '
        Me.LabelQuantitàMancante.AutoSize = True
        Me.LabelQuantitàMancante.Location = New System.Drawing.Point(328, 45)
        Me.LabelQuantitàMancante.Name = "LabelQuantitàMancante"
        Me.LabelQuantitàMancante.Size = New System.Drawing.Size(39, 13)
        Me.LabelQuantitàMancante.TabIndex = 1
        Me.LabelQuantitàMancante.Text = "Label1"
        '
        'LabelQuantitàLancio
        '
        Me.LabelQuantitàLancio.AutoSize = True
        Me.LabelQuantitàLancio.Location = New System.Drawing.Point(328, 20)
        Me.LabelQuantitàLancio.Name = "LabelQuantitàLancio"
        Me.LabelQuantitàLancio.Size = New System.Drawing.Size(39, 13)
        Me.LabelQuantitàLancio.TabIndex = 1
        Me.LabelQuantitàLancio.Text = "Label1"
        '
        'LabelTurno
        '
        Me.LabelTurno.AutoSize = True
        Me.LabelTurno.Location = New System.Drawing.Point(387, 9)
        Me.LabelTurno.Name = "LabelTurno"
        Me.LabelTurno.Size = New System.Drawing.Size(35, 13)
        Me.LabelTurno.TabIndex = 1
        Me.LabelTurno.Text = "Turno"
        '
        'ComboBoxTurno
        '
        Me.ComboBoxTurno.FormattingEnabled = True
        Me.ComboBoxTurno.Items.AddRange(New Object() {"1", "2", "3"})
        Me.ComboBoxTurno.Location = New System.Drawing.Point(428, 2)
        Me.ComboBoxTurno.Name = "ComboBoxTurno"
        Me.ComboBoxTurno.Size = New System.Drawing.Size(41, 21)
        Me.ComboBoxTurno.TabIndex = 2
        '
        'LabelLancio
        '
        Me.LabelLancio.AutoSize = True
        Me.LabelLancio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLancio.Location = New System.Drawing.Point(12, 20)
        Me.LabelLancio.Name = "LabelLancio"
        Me.LabelLancio.Size = New System.Drawing.Size(82, 20)
        Me.LabelLancio.TabIndex = 1
        Me.LabelLancio.Text = "Sequenza"
        '
        'LabelCavalletti
        '
        Me.LabelCavalletti.AutoSize = True
        Me.LabelCavalletti.Location = New System.Drawing.Point(14, 105)
        Me.LabelCavalletti.Name = "LabelCavalletti"
        Me.LabelCavalletti.Size = New System.Drawing.Size(50, 13)
        Me.LabelCavalletti.TabIndex = 1
        Me.LabelCavalletti.Text = "Cavalletti"
        '
        'LabelProduzioneTurno
        '
        Me.LabelProduzioneTurno.AutoSize = True
        Me.LabelProduzioneTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProduzioneTurno.Location = New System.Drawing.Point(50, 71)
        Me.LabelProduzioneTurno.Name = "LabelProduzioneTurno"
        Me.LabelProduzioneTurno.Size = New System.Drawing.Size(122, 17)
        Me.LabelProduzioneTurno.TabIndex = 1
        Me.LabelProduzioneTurno.Text = "Produzione Turno"
        '
        'LabelScartoTurno
        '
        Me.LabelScartoTurno.AutoSize = True
        Me.LabelScartoTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelScartoTurno.Location = New System.Drawing.Point(303, 71)
        Me.LabelScartoTurno.Name = "LabelScartoTurno"
        Me.LabelScartoTurno.Size = New System.Drawing.Size(91, 17)
        Me.LabelScartoTurno.TabIndex = 1
        Me.LabelScartoTurno.Text = "Scarto Turno"
        Me.LabelScartoTurno.Visible = False
        '
        'LabelPiastre
        '
        Me.LabelPiastre.AutoSize = True
        Me.LabelPiastre.Location = New System.Drawing.Point(22, 127)
        Me.LabelPiastre.Name = "LabelPiastre"
        Me.LabelPiastre.Size = New System.Drawing.Size(39, 13)
        Me.LabelPiastre.TabIndex = 1
        Me.LabelPiastre.Text = "Piastre"
        '
        'LabelScartoDivider
        '
        Me.LabelScartoDivider.AutoSize = True
        Me.LabelScartoDivider.Location = New System.Drawing.Point(208, 121)
        Me.LabelScartoDivider.Name = "LabelScartoDivider"
        Me.LabelScartoDivider.Size = New System.Drawing.Size(40, 13)
        Me.LabelScartoDivider.TabIndex = 1
        Me.LabelScartoDivider.Text = "Divider"
        Me.LabelScartoDivider.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(208, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Impilatore"
        Me.Label6.Visible = False
        '
        'TextBoxCavalletti
        '
        Me.TextBoxCavalletti.Location = New System.Drawing.Point(69, 102)
        Me.TextBoxCavalletti.Name = "TextBoxCavalletti"
        Me.TextBoxCavalletti.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCavalletti.TabIndex = 0
        '
        'TextBoxProduzionePiastre
        '
        Me.TextBoxProduzionePiastre.Location = New System.Drawing.Point(69, 124)
        Me.TextBoxProduzionePiastre.Name = "TextBoxProduzionePiastre"
        Me.TextBoxProduzionePiastre.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxProduzionePiastre.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(266, 118)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(266, 140)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(371, 118)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 0
        Me.TextBox3.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(371, 140)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 0
        Me.TextBox4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(431, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Divider"
        Me.Label5.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(269, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 9)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Peso Primo Cassone (Kg)"
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(371, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 9)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Peso Secondo Cassone (Kg)"
        Me.Label8.Visible = False
        '
        'ComboBoxLancio
        '
        Me.ComboBoxLancio.FormattingEnabled = True
        Me.ComboBoxLancio.Location = New System.Drawing.Point(12, 12)
        Me.ComboBoxLancio.Name = "ComboBoxLancio"
        Me.ComboBoxLancio.Size = New System.Drawing.Size(118, 21)
        Me.ComboBoxLancio.TabIndex = 3
        '
        'ButtonSalvaTurno
        '
        Me.ButtonSalvaTurno.Location = New System.Drawing.Point(16, 235)
        Me.ButtonSalvaTurno.Name = "ButtonSalvaTurno"
        Me.ButtonSalvaTurno.Size = New System.Drawing.Size(127, 52)
        Me.ButtonSalvaTurno.TabIndex = 4
        Me.ButtonSalvaTurno.Text = "Salva Turno"
        Me.ButtonSalvaTurno.UseVisualStyleBackColor = True
        '
        'ButtonConfermaLancio
        '
        Me.ButtonConfermaLancio.Location = New System.Drawing.Point(218, 235)
        Me.ButtonConfermaLancio.Name = "ButtonConfermaLancio"
        Me.ButtonConfermaLancio.Size = New System.Drawing.Size(99, 34)
        Me.ButtonConfermaLancio.TabIndex = 4
        Me.ButtonConfermaLancio.Text = "Conferma Produzione"
        Me.ButtonConfermaLancio.UseVisualStyleBackColor = True
        '
        'ButtonChiudiLancio
        '
        Me.ButtonChiudiLancio.Location = New System.Drawing.Point(323, 235)
        Me.ButtonChiudiLancio.Name = "ButtonChiudiLancio"
        Me.ButtonChiudiLancio.Size = New System.Drawing.Size(106, 34)
        Me.ButtonChiudiLancio.TabIndex = 4
        Me.ButtonChiudiLancio.Text = "Cambio Produzione"
        Me.ButtonChiudiLancio.UseVisualStyleBackColor = True
        '
        'ButtonCancella
        '
        Me.ButtonCancella.Location = New System.Drawing.Point(218, 272)
        Me.ButtonCancella.Name = "ButtonCancella"
        Me.ButtonCancella.Size = New System.Drawing.Size(99, 34)
        Me.ButtonCancella.TabIndex = 4
        Me.ButtonCancella.Text = "Cancella"
        Me.ButtonCancella.UseVisualStyleBackColor = True
        '
        'LabelCodiceLinea
        '
        Me.LabelCodiceLinea.AutoSize = True
        Me.LabelCodiceLinea.Location = New System.Drawing.Point(232, 5)
        Me.LabelCodiceLinea.Name = "LabelCodiceLinea"
        Me.LabelCodiceLinea.Size = New System.Drawing.Size(35, 13)
        Me.LabelCodiceLinea.TabIndex = 1
        Me.LabelCodiceLinea.Text = "Turno"
        Me.LabelCodiceLinea.Visible = False
        '
        'SceltaLancioStiratura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 309)
        Me.Controls.Add(Me.ButtonChiudiLancio)
        Me.Controls.Add(Me.ButtonCancella)
        Me.Controls.Add(Me.ButtonConfermaLancio)
        Me.Controls.Add(Me.ButtonSalvaTurno)
        Me.Controls.Add(Me.ComboBoxLancio)
        Me.Controls.Add(Me.ComboBoxTurno)
        Me.Controls.Add(Me.LabelQuantitàMancante)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelCodiceLinea)
        Me.Controls.Add(Me.LabelTurno)
        Me.Controls.Add(Me.LabelQuantitàLancio)
        Me.Controls.Add(Me.LabelQP)
        Me.Controls.Add(Me.LabelCodice)
        Me.Controls.Add(Me.LabelLancio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabelPiastre)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabelScartoDivider)
        Me.Controls.Add(Me.LabelCavalletti)
        Me.Controls.Add(Me.LabelScartoTurno)
        Me.Controls.Add(Me.LabelProduzioneTurno)
        Me.Controls.Add(Me.LabelMateriale)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBoxProduzionePiastre)
        Me.Controls.Add(Me.TextBoxCavalletti)
        Me.Controls.Add(Me.TextBoxLancioProduzione)
        Me.Name = "SceltaLancioStiratura"
        Me.Text = "SceltaLancioStiratura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxLancioProduzione As System.Windows.Forms.TextBox
    Friend WithEvents LabelMateriale As System.Windows.Forms.Label
    Friend WithEvents LabelCodice As System.Windows.Forms.Label
    Friend WithEvents LabelQP As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelQuantitàMancante As System.Windows.Forms.Label
    Friend WithEvents LabelQuantitàLancio As System.Windows.Forms.Label
    Friend WithEvents LabelTurno As System.Windows.Forms.Label
    Friend WithEvents ComboBoxTurno As System.Windows.Forms.ComboBox
    Friend WithEvents LabelLancio As System.Windows.Forms.Label
    Friend WithEvents LabelCavalletti As System.Windows.Forms.Label
    Friend WithEvents LabelProduzioneTurno As System.Windows.Forms.Label
    Friend WithEvents LabelScartoTurno As System.Windows.Forms.Label
    Friend WithEvents LabelPiastre As System.Windows.Forms.Label
    Friend WithEvents LabelScartoDivider As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCavalletti As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxProduzionePiastre As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxLancio As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonSalvaTurno As System.Windows.Forms.Button
    Friend WithEvents ButtonConfermaLancio As System.Windows.Forms.Button
    Friend WithEvents ButtonChiudiLancio As System.Windows.Forms.Button
    Friend WithEvents ButtonCancella As System.Windows.Forms.Button
    Friend WithEvents LabelCodiceLinea As System.Windows.Forms.Label
End Class
