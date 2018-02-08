<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LineViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LineViewer))
        Me.PictureBoxFiamm = New System.Windows.Forms.PictureBox()
        Me.LabelPathDatabase = New System.Windows.Forms.Label()
        Me.LabelReparto = New System.Windows.Forms.Label()
        Me.LabelLinea = New System.Windows.Forms.Label()
        Me.LabelPz = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimerUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.LabelIdDepartment = New System.Windows.Forms.Label()
        Me.LabelIdLine = New System.Windows.Forms.Label()
        CType(Me.PictureBoxFiamm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxFiamm
        '
        Me.PictureBoxFiamm.Image = CType(resources.GetObject("PictureBoxFiamm.Image"), System.Drawing.Image)
        Me.PictureBoxFiamm.InitialImage = Nothing
        Me.PictureBoxFiamm.Location = New System.Drawing.Point(731, 2)
        Me.PictureBoxFiamm.Name = "PictureBoxFiamm"
        Me.PictureBoxFiamm.Size = New System.Drawing.Size(287, 175)
        Me.PictureBoxFiamm.TabIndex = 141
        Me.PictureBoxFiamm.TabStop = False
        '
        'LabelPathDatabase
        '
        Me.LabelPathDatabase.AutoSize = True
        Me.LabelPathDatabase.Location = New System.Drawing.Point(728, 194)
        Me.LabelPathDatabase.Name = "LabelPathDatabase"
        Me.LabelPathDatabase.Size = New System.Drawing.Size(101, 13)
        Me.LabelPathDatabase.TabIndex = 142
        Me.LabelPathDatabase.Text = "LabelPathDatabase"
        Me.LabelPathDatabase.Visible = False
        '
        'LabelReparto
        '
        Me.LabelReparto.AutoSize = True
        Me.LabelReparto.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelReparto.Location = New System.Drawing.Point(35, 33)
        Me.LabelReparto.Name = "LabelReparto"
        Me.LabelReparto.Size = New System.Drawing.Size(431, 73)
        Me.LabelReparto.TabIndex = 143
        Me.LabelReparto.Text = "LabelReparto"
        '
        'LabelLinea
        '
        Me.LabelLinea.AutoSize = True
        Me.LabelLinea.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLinea.Location = New System.Drawing.Point(35, 204)
        Me.LabelLinea.Name = "LabelLinea"
        Me.LabelLinea.Size = New System.Drawing.Size(358, 73)
        Me.LabelLinea.TabIndex = 144
        Me.LabelLinea.Text = "LabelLinea"
        '
        'LabelPz
        '
        Me.LabelPz.AutoSize = True
        Me.LabelPz.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPz.Location = New System.Drawing.Point(188, 552)
        Me.LabelPz.Name = "LabelPz"
        Me.LabelPz.Size = New System.Drawing.Size(397, 108)
        Me.LabelPz.TabIndex = 145
        Me.LabelPz.Text = "LabelPz"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(713, 552)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 108)
        Me.Label1.TabIndex = 146
        Me.Label1.Text = "Pz."
        '
        'TimerUpdate
        '
        Me.TimerUpdate.Interval = 60000
        '
        'LabelIdDepartment
        '
        Me.LabelIdDepartment.AutoSize = True
        Me.LabelIdDepartment.Location = New System.Drawing.Point(546, 81)
        Me.LabelIdDepartment.Name = "LabelIdDepartment"
        Me.LabelIdDepartment.Size = New System.Drawing.Size(71, 13)
        Me.LabelIdDepartment.TabIndex = 147
        Me.LabelIdDepartment.Text = "IdDepartment"
        Me.LabelIdDepartment.Visible = False
        '
        'LabelIdLine
        '
        Me.LabelIdLine.AutoSize = True
        Me.LabelIdLine.Location = New System.Drawing.Point(546, 252)
        Me.LabelIdLine.Name = "LabelIdLine"
        Me.LabelIdLine.Size = New System.Drawing.Size(36, 13)
        Me.LabelIdLine.TabIndex = 148
        Me.LabelIdLine.Text = "IdLine"
        Me.LabelIdLine.Visible = False
        '
        'LineViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 729)
        Me.Controls.Add(Me.LabelIdLine)
        Me.Controls.Add(Me.LabelIdDepartment)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelPz)
        Me.Controls.Add(Me.LabelLinea)
        Me.Controls.Add(Me.LabelReparto)
        Me.Controls.Add(Me.LabelPathDatabase)
        Me.Controls.Add(Me.PictureBoxFiamm)
        Me.DoubleBuffered = True
        Me.Name = "LineViewer"
        Me.Text = "LineViewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBoxFiamm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBoxFiamm As System.Windows.Forms.PictureBox
    Friend WithEvents LabelPathDatabase As System.Windows.Forms.Label
    Friend WithEvents LabelReparto As System.Windows.Forms.Label
    Friend WithEvents LabelLinea As System.Windows.Forms.Label
    Friend WithEvents LabelPz As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TimerUpdate As System.Windows.Forms.Timer
    Friend WithEvents LabelIdDepartment As System.Windows.Forms.Label
    Friend WithEvents LabelIdLine As System.Windows.Forms.Label
End Class
