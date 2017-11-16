<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SceltaLancioMontaggio
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
        Me.ComboBoxLancio = New System.Windows.Forms.ComboBox()
        Me.LabelMateriale = New System.Windows.Forms.Label()
        Me.LabelCodice = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelQuantitàLancio = New System.Windows.Forms.Label()
        Me.LabelQM = New System.Windows.Forms.Label()
        Me.LabelQuantitàMancante = New System.Windows.Forms.Label()
        Me.LabelProduzioneTurno = New System.Windows.Forms.Label()
        Me.LabelScartoTurno = New System.Windows.Forms.Label()
        Me.TextBoxPallett = New System.Windows.Forms.TextBox()
        Me.TextBoxScartoFuoriCella = New System.Windows.Forms.TextBox()
        Me.LabelNote = New System.Windows.Forms.Label()
        Me.ButtonConfermaLancio = New System.Windows.Forms.Button()
        Me.ButtonCancella = New System.Windows.Forms.Button()
        Me.ButtonChiudiLancio = New System.Windows.Forms.Button()
        Me.TextBoxLancioProduzione = New System.Windows.Forms.TextBox()
        Me.LabelTurno = New System.Windows.Forms.Label()
        Me.ButtonSalvaTurno = New System.Windows.Forms.Button()
        Me.LabelPallett = New System.Windows.Forms.Label()
        Me.LabelPezzi = New System.Windows.Forms.Label()
        Me.TextBoxProduzionePezzi = New System.Windows.Forms.TextBox()
        Me.RichTextBoxNote = New System.Windows.Forms.RichTextBox()
        Me.TextBoxPoliRifatti = New System.Windows.Forms.TextBox()
        Me.LabelPoliRifatti = New System.Windows.Forms.Label()
        Me.TextBoxScartoPoloPiantato = New System.Windows.Forms.TextBox()
        Me.TextBoxScartoPoloFuso = New System.Windows.Forms.TextBox()
        Me.LabelFuoriCella = New System.Windows.Forms.Label()
        Me.LabelPoloPiantato = New System.Windows.Forms.Label()
        Me.LabelPoloFuso = New System.Windows.Forms.Label()
        Me.LabelAltro = New System.Windows.Forms.Label()
        Me.TextBoxScartoAltro = New System.Windows.Forms.TextBox()
        Me.LabelControlloDistruttivo = New System.Windows.Forms.Label()
        Me.TextBoxControlloDistruttivo = New System.Windows.Forms.TextBox()
        Me.ComboBoxTurno = New System.Windows.Forms.ComboBox()
        Me.LabelLancio = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBoxLancio
        '
        Me.ComboBoxLancio.FormattingEnabled = True
        Me.ComboBoxLancio.Location = New System.Drawing.Point(12, 12)
        Me.ComboBoxLancio.Name = "ComboBoxLancio"
        Me.ComboBoxLancio.Size = New System.Drawing.Size(118, 21)
        Me.ComboBoxLancio.TabIndex = 0
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
        Me.LabelCodice.TabIndex = 2
        Me.LabelCodice.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(232, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Quantità Prevista"
        '
        'LabelQuantitàLancio
        '
        Me.LabelQuantitàLancio.AutoSize = True
        Me.LabelQuantitàLancio.Location = New System.Drawing.Point(328, 20)
        Me.LabelQuantitàLancio.Name = "LabelQuantitàLancio"
        Me.LabelQuantitàLancio.Size = New System.Drawing.Size(39, 13)
        Me.LabelQuantitàLancio.TabIndex = 2
        Me.LabelQuantitàLancio.Text = "Label2"
        '
        'LabelQM
        '
        Me.LabelQM.AutoSize = True
        Me.LabelQM.Location = New System.Drawing.Point(232, 45)
        Me.LabelQM.Name = "LabelQM"
        Me.LabelQM.Size = New System.Drawing.Size(98, 13)
        Me.LabelQM.TabIndex = 3
        Me.LabelQM.Text = "Quantità Mancante"
        '
        'LabelQuantitàMancante
        '
        Me.LabelQuantitàMancante.AutoSize = True
        Me.LabelQuantitàMancante.Location = New System.Drawing.Point(328, 45)
        Me.LabelQuantitàMancante.Name = "LabelQuantitàMancante"
        Me.LabelQuantitàMancante.Size = New System.Drawing.Size(39, 13)
        Me.LabelQuantitàMancante.TabIndex = 2
        Me.LabelQuantitàMancante.Text = "Label2"
        '
        'LabelProduzioneTurno
        '
        Me.LabelProduzioneTurno.AutoSize = True
        Me.LabelProduzioneTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProduzioneTurno.Location = New System.Drawing.Point(60, 71)
        Me.LabelProduzioneTurno.Name = "LabelProduzioneTurno"
        Me.LabelProduzioneTurno.Size = New System.Drawing.Size(122, 17)
        Me.LabelProduzioneTurno.TabIndex = 3
        Me.LabelProduzioneTurno.Text = "Produzione Turno"
        '
        'LabelScartoTurno
        '
        Me.LabelScartoTurno.AutoSize = True
        Me.LabelScartoTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelScartoTurno.Location = New System.Drawing.Point(303, 71)
        Me.LabelScartoTurno.Name = "LabelScartoTurno"
        Me.LabelScartoTurno.Size = New System.Drawing.Size(91, 17)
        Me.LabelScartoTurno.TabIndex = 3
        Me.LabelScartoTurno.Text = "Scarto Turno"
        '
        'TextBoxPallett
        '
        Me.TextBoxPallett.Location = New System.Drawing.Point(69, 102)
        Me.TextBoxPallett.Name = "TextBoxPallett"
        Me.TextBoxPallett.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPallett.TabIndex = 4
        '
        'TextBoxScartoFuoriCella
        '
        Me.TextBoxScartoFuoriCella.Location = New System.Drawing.Point(279, 98)
        Me.TextBoxScartoFuoriCella.Name = "TextBoxScartoFuoriCella"
        Me.TextBoxScartoFuoriCella.Size = New System.Drawing.Size(53, 20)
        Me.TextBoxScartoFuoriCella.TabIndex = 7
        '
        'LabelNote
        '
        Me.LabelNote.AutoSize = True
        Me.LabelNote.Location = New System.Drawing.Point(12, 186)
        Me.LabelNote.Name = "LabelNote"
        Me.LabelNote.Size = New System.Drawing.Size(30, 13)
        Me.LabelNote.TabIndex = 3
        Me.LabelNote.Text = "Note"
        '
        'ButtonConfermaLancio
        '
        Me.ButtonConfermaLancio.Location = New System.Drawing.Point(218, 235)
        Me.ButtonConfermaLancio.Name = "ButtonConfermaLancio"
        Me.ButtonConfermaLancio.Size = New System.Drawing.Size(99, 34)
        Me.ButtonConfermaLancio.TabIndex = 6
        Me.ButtonConfermaLancio.Text = "Conferma Lancio"
        Me.ButtonConfermaLancio.UseVisualStyleBackColor = True
        '
        'ButtonCancella
        '
        Me.ButtonCancella.Location = New System.Drawing.Point(218, 272)
        Me.ButtonCancella.Name = "ButtonCancella"
        Me.ButtonCancella.Size = New System.Drawing.Size(99, 34)
        Me.ButtonCancella.TabIndex = 6
        Me.ButtonCancella.Text = "Cancella"
        Me.ButtonCancella.UseVisualStyleBackColor = True
        '
        'ButtonChiudiLancio
        '
        Me.ButtonChiudiLancio.Location = New System.Drawing.Point(323, 235)
        Me.ButtonChiudiLancio.Name = "ButtonChiudiLancio"
        Me.ButtonChiudiLancio.Size = New System.Drawing.Size(99, 34)
        Me.ButtonChiudiLancio.TabIndex = 13
        Me.ButtonChiudiLancio.Text = "Chiudi Lancio"
        Me.ButtonChiudiLancio.UseVisualStyleBackColor = True
        '
        'TextBoxLancioProduzione
        '
        Me.TextBoxLancioProduzione.Location = New System.Drawing.Point(12, 42)
        Me.TextBoxLancioProduzione.Name = "TextBoxLancioProduzione"
        Me.TextBoxLancioProduzione.Size = New System.Drawing.Size(118, 20)
        Me.TextBoxLancioProduzione.TabIndex = 2
        '
        'LabelTurno
        '
        Me.LabelTurno.AutoSize = True
        Me.LabelTurno.Location = New System.Drawing.Point(387, 9)
        Me.LabelTurno.Name = "LabelTurno"
        Me.LabelTurno.Size = New System.Drawing.Size(35, 13)
        Me.LabelTurno.TabIndex = 2
        Me.LabelTurno.Text = "Turno"
        '
        'ButtonSalvaTurno
        '
        Me.ButtonSalvaTurno.Location = New System.Drawing.Point(16, 235)
        Me.ButtonSalvaTurno.Name = "ButtonSalvaTurno"
        Me.ButtonSalvaTurno.Size = New System.Drawing.Size(127, 52)
        Me.ButtonSalvaTurno.TabIndex = 13
        Me.ButtonSalvaTurno.Text = "Salva Turno"
        Me.ButtonSalvaTurno.UseVisualStyleBackColor = True
        '
        'LabelPallett
        '
        Me.LabelPallett.AutoSize = True
        Me.LabelPallett.Location = New System.Drawing.Point(24, 105)
        Me.LabelPallett.Name = "LabelPallett"
        Me.LabelPallett.Size = New System.Drawing.Size(36, 13)
        Me.LabelPallett.TabIndex = 3
        Me.LabelPallett.Text = "Pallett"
        '
        'LabelPezzi
        '
        Me.LabelPezzi.AutoSize = True
        Me.LabelPezzi.Location = New System.Drawing.Point(28, 127)
        Me.LabelPezzi.Name = "LabelPezzi"
        Me.LabelPezzi.Size = New System.Drawing.Size(32, 13)
        Me.LabelPezzi.TabIndex = 3
        Me.LabelPezzi.Text = "Pezzi"
        '
        'TextBoxProduzionePezzi
        '
        Me.TextBoxProduzionePezzi.Location = New System.Drawing.Point(69, 124)
        Me.TextBoxProduzionePezzi.Name = "TextBoxProduzionePezzi"
        Me.TextBoxProduzionePezzi.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxProduzionePezzi.TabIndex = 5
        '
        'RichTextBoxNote
        '
        Me.RichTextBoxNote.Location = New System.Drawing.Point(63, 183)
        Me.RichTextBoxNote.Name = "RichTextBoxNote"
        Me.RichTextBoxNote.Size = New System.Drawing.Size(390, 46)
        Me.RichTextBoxNote.TabIndex = 7
        Me.RichTextBoxNote.Text = ""
        '
        'TextBoxPoliRifatti
        '
        Me.TextBoxPoliRifatti.Location = New System.Drawing.Point(69, 146)
        Me.TextBoxPoliRifatti.Name = "TextBoxPoliRifatti"
        Me.TextBoxPoliRifatti.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPoliRifatti.TabIndex = 6
        '
        'LabelPoliRifatti
        '
        Me.LabelPoliRifatti.AutoSize = True
        Me.LabelPoliRifatti.Location = New System.Drawing.Point(6, 149)
        Me.LabelPoliRifatti.Name = "LabelPoliRifatti"
        Me.LabelPoliRifatti.Size = New System.Drawing.Size(54, 13)
        Me.LabelPoliRifatti.TabIndex = 3
        Me.LabelPoliRifatti.Text = "Poli Rifatti"
        '
        'TextBoxScartoPoloPiantato
        '
        Me.TextBoxScartoPoloPiantato.Location = New System.Drawing.Point(279, 120)
        Me.TextBoxScartoPoloPiantato.Name = "TextBoxScartoPoloPiantato"
        Me.TextBoxScartoPoloPiantato.Size = New System.Drawing.Size(53, 20)
        Me.TextBoxScartoPoloPiantato.TabIndex = 8
        '
        'TextBoxScartoPoloFuso
        '
        Me.TextBoxScartoPoloFuso.Location = New System.Drawing.Point(400, 98)
        Me.TextBoxScartoPoloFuso.Name = "TextBoxScartoPoloFuso"
        Me.TextBoxScartoPoloFuso.Size = New System.Drawing.Size(53, 20)
        Me.TextBoxScartoPoloFuso.TabIndex = 9
        '
        'LabelFuoriCella
        '
        Me.LabelFuoriCella.AutoSize = True
        Me.LabelFuoriCella.Location = New System.Drawing.Point(217, 102)
        Me.LabelFuoriCella.Name = "LabelFuoriCella"
        Me.LabelFuoriCella.Size = New System.Drawing.Size(56, 13)
        Me.LabelFuoriCella.TabIndex = 3
        Me.LabelFuoriCella.Text = "Fuori Cella"
        '
        'LabelPoloPiantato
        '
        Me.LabelPoloPiantato.AutoSize = True
        Me.LabelPoloPiantato.Location = New System.Drawing.Point(203, 123)
        Me.LabelPoloPiantato.Name = "LabelPoloPiantato"
        Me.LabelPoloPiantato.Size = New System.Drawing.Size(70, 13)
        Me.LabelPoloPiantato.TabIndex = 3
        Me.LabelPoloPiantato.Text = "Polo Piantato"
        '
        'LabelPoloFuso
        '
        Me.LabelPoloFuso.AutoSize = True
        Me.LabelPoloFuso.Location = New System.Drawing.Point(340, 102)
        Me.LabelPoloFuso.Name = "LabelPoloFuso"
        Me.LabelPoloFuso.Size = New System.Drawing.Size(54, 13)
        Me.LabelPoloFuso.TabIndex = 3
        Me.LabelPoloFuso.Text = "Polo Fuso"
        '
        'LabelAltro
        '
        Me.LabelAltro.AutoSize = True
        Me.LabelAltro.Location = New System.Drawing.Point(366, 124)
        Me.LabelAltro.Name = "LabelAltro"
        Me.LabelAltro.Size = New System.Drawing.Size(28, 13)
        Me.LabelAltro.TabIndex = 3
        Me.LabelAltro.Text = "Altro"
        '
        'TextBoxScartoAltro
        '
        Me.TextBoxScartoAltro.Location = New System.Drawing.Point(400, 120)
        Me.TextBoxScartoAltro.Name = "TextBoxScartoAltro"
        Me.TextBoxScartoAltro.Size = New System.Drawing.Size(53, 20)
        Me.TextBoxScartoAltro.TabIndex = 10
        '
        'LabelControlloDistruttivo
        '
        Me.LabelControlloDistruttivo.AutoSize = True
        Me.LabelControlloDistruttivo.Location = New System.Drawing.Point(242, 153)
        Me.LabelControlloDistruttivo.Name = "LabelControlloDistruttivo"
        Me.LabelControlloDistruttivo.Size = New System.Drawing.Size(98, 13)
        Me.LabelControlloDistruttivo.TabIndex = 3
        Me.LabelControlloDistruttivo.Text = "Controllo Distruttivo"
        '
        'TextBoxControlloDistruttivo
        '
        Me.TextBoxControlloDistruttivo.Location = New System.Drawing.Point(353, 150)
        Me.TextBoxControlloDistruttivo.Name = "TextBoxControlloDistruttivo"
        Me.TextBoxControlloDistruttivo.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxControlloDistruttivo.TabIndex = 11
        '
        'ComboBoxTurno
        '
        Me.ComboBoxTurno.FormattingEnabled = True
        Me.ComboBoxTurno.Items.AddRange(New Object() {"1", "2", "3"})
        Me.ComboBoxTurno.Location = New System.Drawing.Point(428, 2)
        Me.ComboBoxTurno.Name = "ComboBoxTurno"
        Me.ComboBoxTurno.Size = New System.Drawing.Size(41, 21)
        Me.ComboBoxTurno.TabIndex = 13
        '
        'LabelLancio
        '
        Me.LabelLancio.AutoSize = True
        Me.LabelLancio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLancio.Location = New System.Drawing.Point(12, 13)
        Me.LabelLancio.Name = "LabelLancio"
        Me.LabelLancio.Size = New System.Drawing.Size(56, 20)
        Me.LabelLancio.TabIndex = 3
        Me.LabelLancio.Text = "Lancio"
        '
        'SceltaLancio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 309)
        Me.Controls.Add(Me.ComboBoxTurno)
        Me.Controls.Add(Me.RichTextBoxNote)
        Me.Controls.Add(Me.ButtonCancella)
        Me.Controls.Add(Me.ButtonChiudiLancio)
        Me.Controls.Add(Me.ButtonSalvaTurno)
        Me.Controls.Add(Me.ButtonConfermaLancio)
        Me.Controls.Add(Me.TextBoxScartoAltro)
        Me.Controls.Add(Me.TextBoxScartoPoloFuso)
        Me.Controls.Add(Me.TextBoxScartoPoloPiantato)
        Me.Controls.Add(Me.TextBoxScartoFuoriCella)
        Me.Controls.Add(Me.TextBoxLancioProduzione)
        Me.Controls.Add(Me.TextBoxControlloDistruttivo)
        Me.Controls.Add(Me.TextBoxPoliRifatti)
        Me.Controls.Add(Me.TextBoxProduzionePezzi)
        Me.Controls.Add(Me.TextBoxPallett)
        Me.Controls.Add(Me.LabelQM)
        Me.Controls.Add(Me.LabelPoloFuso)
        Me.Controls.Add(Me.LabelPoloPiantato)
        Me.Controls.Add(Me.LabelAltro)
        Me.Controls.Add(Me.LabelFuoriCella)
        Me.Controls.Add(Me.LabelControlloDistruttivo)
        Me.Controls.Add(Me.LabelScartoTurno)
        Me.Controls.Add(Me.LabelNote)
        Me.Controls.Add(Me.LabelPoliRifatti)
        Me.Controls.Add(Me.LabelPezzi)
        Me.Controls.Add(Me.LabelPallett)
        Me.Controls.Add(Me.LabelLancio)
        Me.Controls.Add(Me.LabelProduzioneTurno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelQuantitàMancante)
        Me.Controls.Add(Me.LabelQuantitàLancio)
        Me.Controls.Add(Me.LabelTurno)
        Me.Controls.Add(Me.LabelCodice)
        Me.Controls.Add(Me.LabelMateriale)
        Me.Controls.Add(Me.ComboBoxLancio)
        Me.Name = "SceltaLancio"
        Me.Text = "SceltaLancio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBoxLancio As System.Windows.Forms.ComboBox
    Friend WithEvents LabelMateriale As System.Windows.Forms.Label
    Friend WithEvents LabelCodice As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabelQuantitàLancio As System.Windows.Forms.Label
    Friend WithEvents LabelQM As System.Windows.Forms.Label
    Friend WithEvents LabelQuantitàMancante As System.Windows.Forms.Label
    Friend WithEvents LabelProduzioneTurno As System.Windows.Forms.Label
    Friend WithEvents LabelScartoTurno As System.Windows.Forms.Label
    Friend WithEvents TextBoxPallett As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxScartoFuoriCella As System.Windows.Forms.TextBox
    Friend WithEvents LabelNote As System.Windows.Forms.Label
    Friend WithEvents ButtonConfermaLancio As System.Windows.Forms.Button
    Friend WithEvents ButtonCancella As System.Windows.Forms.Button
    Friend WithEvents ButtonChiudiLancio As System.Windows.Forms.Button
    Friend WithEvents TextBoxLancioProduzione As System.Windows.Forms.TextBox
    Friend WithEvents LabelTurno As System.Windows.Forms.Label
    Friend WithEvents ButtonSalvaTurno As System.Windows.Forms.Button
    Friend WithEvents LabelPallett As System.Windows.Forms.Label
    Friend WithEvents LabelPezzi As System.Windows.Forms.Label
    Friend WithEvents TextBoxProduzionePezzi As System.Windows.Forms.TextBox
    Friend WithEvents RichTextBoxNote As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBoxPoliRifatti As System.Windows.Forms.TextBox
    Friend WithEvents LabelPoliRifatti As System.Windows.Forms.Label
    Friend WithEvents TextBoxScartoPoloPiantato As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxScartoPoloFuso As System.Windows.Forms.TextBox
    Friend WithEvents LabelFuoriCella As System.Windows.Forms.Label
    Friend WithEvents LabelPoloPiantato As System.Windows.Forms.Label
    Friend WithEvents LabelPoloFuso As System.Windows.Forms.Label
    Friend WithEvents LabelAltro As System.Windows.Forms.Label
    Friend WithEvents TextBoxScartoAltro As System.Windows.Forms.TextBox
    Friend WithEvents LabelControlloDistruttivo As System.Windows.Forms.Label
    Friend WithEvents TextBoxControlloDistruttivo As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxTurno As System.Windows.Forms.ComboBox
    Friend WithEvents LabelLancio As System.Windows.Forms.Label
End Class
