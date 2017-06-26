<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMacchina
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
        Me.ButtonInceppamento = New System.Windows.Forms.Button()
        Me.ButtonInterventoManutenzione = New System.Windows.Forms.Button()
        Me.ButtonRegolazione = New System.Windows.Forms.Button()
        Me.TextBoxMacchina = New System.Windows.Forms.TextBox()
        Me.LabelDescrizioneEstesa = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonInceppamento
        '
        Me.ButtonInceppamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInceppamento.Location = New System.Drawing.Point(172, 149)
        Me.ButtonInceppamento.Name = "ButtonInceppamento"
        Me.ButtonInceppamento.Size = New System.Drawing.Size(417, 85)
        Me.ButtonInceppamento.TabIndex = 16
        Me.ButtonInceppamento.Text = "Inceppamento"
        Me.ButtonInceppamento.UseVisualStyleBackColor = True
        '
        'ButtonInterventoManutenzione
        '
        Me.ButtonInterventoManutenzione.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInterventoManutenzione.Location = New System.Drawing.Point(172, 240)
        Me.ButtonInterventoManutenzione.Name = "ButtonInterventoManutenzione"
        Me.ButtonInterventoManutenzione.Size = New System.Drawing.Size(417, 85)
        Me.ButtonInterventoManutenzione.TabIndex = 17
        Me.ButtonInterventoManutenzione.Text = "Intervento manutenzione"
        Me.ButtonInterventoManutenzione.UseVisualStyleBackColor = True
        '
        'ButtonRegolazione
        '
        Me.ButtonRegolazione.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegolazione.Location = New System.Drawing.Point(172, 331)
        Me.ButtonRegolazione.Name = "ButtonRegolazione"
        Me.ButtonRegolazione.Size = New System.Drawing.Size(417, 85)
        Me.ButtonRegolazione.TabIndex = 18
        Me.ButtonRegolazione.Text = "Regolazione"
        Me.ButtonRegolazione.UseVisualStyleBackColor = True
        '
        'TextBoxMacchina
        '
        Me.TextBoxMacchina.Location = New System.Drawing.Point(28, 480)
        Me.TextBoxMacchina.Multiline = True
        Me.TextBoxMacchina.Name = "TextBoxMacchina"
        Me.TextBoxMacchina.Size = New System.Drawing.Size(744, 57)
        Me.TextBoxMacchina.TabIndex = 34
        '
        'LabelDescrizioneEstesa
        '
        Me.LabelDescrizioneEstesa.AutoSize = True
        Me.LabelDescrizioneEstesa.Location = New System.Drawing.Point(589, 464)
        Me.LabelDescrizioneEstesa.Name = "LabelDescrizioneEstesa"
        Me.LabelDescrizioneEstesa.Size = New System.Drawing.Size(183, 13)
        Me.LabelDescrizioneEstesa.TabIndex = 35
        Me.LabelDescrizioneEstesa.Text = "Descrizione estesa fermo (facoltativa)"
        '
        'FormMacchina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.LabelDescrizioneEstesa)
        Me.Controls.Add(Me.TextBoxMacchina)
        Me.Controls.Add(Me.ButtonRegolazione)
        Me.Controls.Add(Me.ButtonInterventoManutenzione)
        Me.Controls.Add(Me.ButtonInceppamento)
        Me.Name = "FormMacchina"
        Me.Text = "Inserimento Giustificativo - Macchina"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonInceppamento As System.Windows.Forms.Button
    Friend WithEvents ButtonInterventoManutenzione As System.Windows.Forms.Button
    Friend WithEvents ButtonRegolazione As System.Windows.Forms.Button
    Friend WithEvents TextBoxMacchina As System.Windows.Forms.TextBox
    Friend WithEvents LabelDescrizioneEstesa As System.Windows.Forms.Label
End Class
