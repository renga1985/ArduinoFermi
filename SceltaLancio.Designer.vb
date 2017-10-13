<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SceltaLancio
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
        Me.SuspendLayout()
        '
        'ComboBoxLancio
        '
        Me.ComboBoxLancio.FormattingEnabled = True
        Me.ComboBoxLancio.Location = New System.Drawing.Point(149, 85)
        Me.ComboBoxLancio.Name = "ComboBoxLancio"
        Me.ComboBoxLancio.Size = New System.Drawing.Size(341, 21)
        Me.ComboBoxLancio.TabIndex = 0
        '
        'SceltaLancio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 261)
        Me.Controls.Add(Me.ComboBoxLancio)
        Me.Name = "SceltaLancio"
        Me.Text = "SceltaLancio"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboBoxLancio As System.Windows.Forms.ComboBox
End Class
