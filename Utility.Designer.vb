<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Utility
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
        Me.ButtonResetCounter = New System.Windows.Forms.Button()
        Me.SerialPortArduino = New System.IO.Ports.SerialPort(Me.components)
        Me.LabelProduzioneNascosto = New System.Windows.Forms.Label()
        Me.TimerForRoutineRegistrationData = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ButtonResetCounter
        '
        Me.ButtonResetCounter.Location = New System.Drawing.Point(185, 36)
        Me.ButtonResetCounter.Name = "ButtonResetCounter"
        Me.ButtonResetCounter.Size = New System.Drawing.Size(75, 23)
        Me.ButtonResetCounter.TabIndex = 0
        Me.ButtonResetCounter.Text = "ResetCounter"
        Me.ButtonResetCounter.UseVisualStyleBackColor = True
        '
        'SerialPortArduino
        '
        Me.SerialPortArduino.PortName = "COM3"
        '
        'LabelProduzioneNascosto
        '
        Me.LabelProduzioneNascosto.AutoSize = True
        Me.LabelProduzioneNascosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProduzioneNascosto.Location = New System.Drawing.Point(217, 131)
        Me.LabelProduzioneNascosto.Name = "LabelProduzioneNascosto"
        Me.LabelProduzioneNascosto.Size = New System.Drawing.Size(43, 46)
        Me.LabelProduzioneNascosto.TabIndex = 22
        Me.LabelProduzioneNascosto.Text = "0"
        '
        'TimerForRoutineRegistrationData
        '
        Me.TimerForRoutineRegistrationData.Enabled = True
        Me.TimerForRoutineRegistrationData.Interval = 200
        '
        'Utility
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 471)
        Me.Controls.Add(Me.LabelProduzioneNascosto)
        Me.Controls.Add(Me.ButtonResetCounter)
        Me.Name = "Utility"
        Me.Text = "Utility"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonResetCounter As System.Windows.Forms.Button
    Friend WithEvents SerialPortArduino As System.IO.Ports.SerialPort
    Friend WithEvents LabelProduzioneNascosto As System.Windows.Forms.Label
    Friend WithEvents TimerForRoutineRegistrationData As System.Windows.Forms.Timer
End Class
