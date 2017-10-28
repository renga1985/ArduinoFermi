<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ChartArea28 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend28 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series10 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea29 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend29 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Title19 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea30 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend30 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Title20 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.SerialPortArduino = New System.IO.Ports.SerialPort(Me.components)
        Me.ButtonSvolgitore = New System.Windows.Forms.Button()
        Me.ButtonEspansore = New System.Windows.Forms.Button()
        Me.ButtonTabBlanker = New System.Windows.Forms.Button()
        Me.ButtonMolazza = New System.Windows.Forms.Button()
        Me.ButtonSpalmatrice = New System.Windows.Forms.Button()
        Me.ButtonDivider = New System.Windows.Forms.Button()
        Me.ButtonTunnel = New System.Windows.Forms.Button()
        Me.ButtonImpilatore = New System.Windows.Forms.Button()
        Me.ButtonPaletizzatore = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelContatoreProduzione = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.OvalShapeGreen = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShapeYellow = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShapeRed = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.TimerForRoutineRegistrationData = New System.Windows.Forms.Timer(Me.components)
        Me.LabelProduzioneOldNascosto = New System.Windows.Forms.Label()
        Me.LabelContatoreFermata = New System.Windows.Forms.Label()
        Me.LabelCurrentTime = New System.Windows.Forms.Label()
        Me.LabelProduzioneNascosto = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelContatoreRipartenza = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ButtonLineaGenerale = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LabelIdFermo = New System.Windows.Forms.Label()
        Me.LabelContatoreGiustificativo = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.ButtonStop = New System.Windows.Forms.Button()
        Me.TimerMain = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBoxFiamm = New System.Windows.Forms.PictureBox()
        Me.LabelFermataDopo = New System.Windows.Forms.Label()
        Me.LabelRipartenzaDopo = New System.Windows.Forms.Label()
        Me.LabelGiustificativoDopo = New System.Windows.Forms.Label()
        Me.LabelFermataDopoValue = New System.Windows.Forms.Label()
        Me.LabelRipartenzaDopoValue = New System.Windows.Forms.Label()
        Me.LabelGiustificativoDopoValue = New System.Windows.Forms.Label()
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.LabelPz = New System.Windows.Forms.Label()
        Me.LabelPz2 = New System.Windows.Forms.Label()
        Me.LabelNotaProduzione = New System.Windows.Forms.Label()
        Me.ChartProduzioneOraria = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LblIdLinea = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LblIdDepartment = New System.Windows.Forms.Label()
        Me.LblDepartmentDescription = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LblLineDescription = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ButtonRitentaConnessione = New System.Windows.Forms.Button()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VisualizzaFermateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualizzaProduzioneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnalisiFermiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBoxProduzione = New System.Windows.Forms.TextBox()
        Me.LabelContatoreProduzioneHidden = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChartMacchine = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ChartCausali = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LabelMinutiFermo = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.LabelUptime = New System.Windows.Forms.Label()
        Me.LblPathDatabase = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.LblPezziOgniImpulso = New System.Windows.Forms.Label()
        Me.Tab = New System.Windows.Forms.TabControl()
        Me.TabStiratura = New System.Windows.Forms.TabPage()
        Me.TabMontaggio = New System.Windows.Forms.TabPage()
        Me.ButtonPinzaPaletizzatore = New System.Windows.Forms.Button()
        Me.ButtonNastriTrasportatori = New System.Windows.Forms.Button()
        Me.ButtonSaldapolari = New System.Windows.Forms.Button()
        Me.ButtonRobot = New System.Windows.Forms.Button()
        Me.ButtonTermosaldatrice = New System.Windows.Forms.Button()
        Me.ButtonPosaCoperchi = New System.Windows.Forms.Button()
        Me.ButtonMarcatore = New System.Windows.Forms.Button()
        Me.ButtonProvaCorti2 = New System.Windows.Forms.Button()
        Me.ButtonProvaAltezzaPolari = New System.Windows.Forms.Button()
        Me.ButtonPuntatrice = New System.Windows.Forms.Button()
        Me.ButtonProvaPneumatica = New System.Windows.Forms.Button()
        Me.ButtonProvaCorti1 = New System.Windows.Forms.Button()
        Me.ButtonCOS = New System.Windows.Forms.Button()
        Me.ButtonBuffer = New System.Windows.Forms.Button()
        Me.ButtonImbustatrice2 = New System.Windows.Forms.Button()
        Me.ButtonImbustatrice1 = New System.Windows.Forms.Button()
        Me.ButtonTranciasetti = New System.Windows.Forms.Button()
        Me.ButtonLineaGeneraleMontaggio = New System.Windows.Forms.Button()
        Me.TabCarica = New System.Windows.Forms.TabPage()
        Me.ButtonAKSI = New System.Windows.Forms.Button()
        Me.ButtonNastriTrasporto = New System.Windows.Forms.Button()
        Me.ButtonDielettrico = New System.Windows.Forms.Button()
        Me.ButtonScaricoManuale = New System.Windows.Forms.Button()
        Me.ButtonRobotCarica = New System.Windows.Forms.Button()
        Me.ButtonControlloVestizione = New System.Windows.Forms.Button()
        Me.ButtonVestizione = New System.Windows.Forms.Button()
        Me.ButtonMarcatoreCarica = New System.Windows.Forms.Button()
        Me.ButtonControlloLivelli = New System.Windows.Forms.Button()
        Me.ButtonScaricaRapida = New System.Windows.Forms.Button()
        Me.ButtonTappatrice = New System.Windows.Forms.Button()
        Me.ButtonPulisciPoli = New System.Windows.Forms.Button()
        Me.ButtonTunnelLavaggio = New System.Windows.Forms.Button()
        Me.ButtonPosaTogliRampe = New System.Windows.Forms.Button()
        Me.Button2Riempimento = New System.Windows.Forms.Button()
        Me.ButtonDiluitore = New System.Windows.Forms.Button()
        Me.ButtonRovesciatore = New System.Windows.Forms.Button()
        Me.ButtonRotatore = New System.Windows.Forms.Button()
        Me.ButtonLineaGeneraleCarica = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.LabelProduzioneSalvata = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextBoxTimbratura = New System.Windows.Forms.TextBox()
        Me.DataGridViewManPower = New System.Windows.Forms.DataGridView()
        Me.LabelCognome = New System.Windows.Forms.Label()
        Me.LabelNome = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.ButtonScegliLancioProduzione = New System.Windows.Forms.Button()
        Me.TabFormazione = New System.Windows.Forms.TabPage()
        Me.ButtonLineaGeneraleFormazione = New System.Windows.Forms.Button()
        Me.ButtonPinzaCarico = New System.Windows.Forms.Button()
        Me.ButtonInseritoreOcchioMagico = New System.Windows.Forms.Button()
        Me.ButtonPrimoRiempimento = New System.Windows.Forms.Button()
        Me.ButtonPosaRampeFormazione = New System.Windows.Forms.Button()
        Me.ButtonRotatoreSpintore1 = New System.Windows.Forms.Button()
        Me.ButtonCarrelloCarico = New System.Windows.Forms.Button()
        Me.ButtonNastriCarico = New System.Windows.Forms.Button()
        Me.ButtonNastriScarico = New System.Windows.Forms.Button()
        Me.ButtonCarrelloScarico = New System.Windows.Forms.Button()
        CType(Me.PictureBoxFiamm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartProduzioneOraria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ChartMacchine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartCausali, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab.SuspendLayout()
        Me.TabStiratura.SuspendLayout()
        Me.TabMontaggio.SuspendLayout()
        Me.TabCarica.SuspendLayout()
        CType(Me.DataGridViewManPower, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabFormazione.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonSvolgitore
        '
        Me.ButtonSvolgitore.Enabled = False
        Me.ButtonSvolgitore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSvolgitore.Location = New System.Drawing.Point(16, 71)
        Me.ButtonSvolgitore.Name = "ButtonSvolgitore"
        Me.ButtonSvolgitore.Size = New System.Drawing.Size(176, 73)
        Me.ButtonSvolgitore.TabIndex = 2
        Me.ButtonSvolgitore.Text = "Svolgitore"
        Me.ButtonSvolgitore.UseVisualStyleBackColor = True
        '
        'ButtonEspansore
        '
        Me.ButtonEspansore.Enabled = False
        Me.ButtonEspansore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEspansore.Location = New System.Drawing.Point(198, 71)
        Me.ButtonEspansore.Name = "ButtonEspansore"
        Me.ButtonEspansore.Size = New System.Drawing.Size(176, 73)
        Me.ButtonEspansore.TabIndex = 3
        Me.ButtonEspansore.Text = "Espansore"
        Me.ButtonEspansore.UseVisualStyleBackColor = True
        '
        'ButtonTabBlanker
        '
        Me.ButtonTabBlanker.Enabled = False
        Me.ButtonTabBlanker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTabBlanker.Location = New System.Drawing.Point(380, 71)
        Me.ButtonTabBlanker.Name = "ButtonTabBlanker"
        Me.ButtonTabBlanker.Size = New System.Drawing.Size(176, 73)
        Me.ButtonTabBlanker.TabIndex = 4
        Me.ButtonTabBlanker.Text = "Tab blanker"
        Me.ButtonTabBlanker.UseVisualStyleBackColor = True
        '
        'ButtonMolazza
        '
        Me.ButtonMolazza.Enabled = False
        Me.ButtonMolazza.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMolazza.Location = New System.Drawing.Point(562, 71)
        Me.ButtonMolazza.Name = "ButtonMolazza"
        Me.ButtonMolazza.Size = New System.Drawing.Size(176, 73)
        Me.ButtonMolazza.TabIndex = 5
        Me.ButtonMolazza.Text = "Molazza"
        Me.ButtonMolazza.UseVisualStyleBackColor = True
        '
        'ButtonSpalmatrice
        '
        Me.ButtonSpalmatrice.Enabled = False
        Me.ButtonSpalmatrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSpalmatrice.Location = New System.Drawing.Point(744, 71)
        Me.ButtonSpalmatrice.Name = "ButtonSpalmatrice"
        Me.ButtonSpalmatrice.Size = New System.Drawing.Size(176, 73)
        Me.ButtonSpalmatrice.TabIndex = 6
        Me.ButtonSpalmatrice.Text = "Spalmatrice"
        Me.ButtonSpalmatrice.UseVisualStyleBackColor = True
        '
        'ButtonDivider
        '
        Me.ButtonDivider.Enabled = False
        Me.ButtonDivider.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDivider.Location = New System.Drawing.Point(926, 71)
        Me.ButtonDivider.Name = "ButtonDivider"
        Me.ButtonDivider.Size = New System.Drawing.Size(176, 73)
        Me.ButtonDivider.TabIndex = 7
        Me.ButtonDivider.Text = "Divider"
        Me.ButtonDivider.UseVisualStyleBackColor = True
        '
        'ButtonTunnel
        '
        Me.ButtonTunnel.Enabled = False
        Me.ButtonTunnel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTunnel.Location = New System.Drawing.Point(1108, 71)
        Me.ButtonTunnel.Name = "ButtonTunnel"
        Me.ButtonTunnel.Size = New System.Drawing.Size(176, 73)
        Me.ButtonTunnel.TabIndex = 8
        Me.ButtonTunnel.Text = "Tunnel"
        Me.ButtonTunnel.UseVisualStyleBackColor = True
        '
        'ButtonImpilatore
        '
        Me.ButtonImpilatore.Enabled = False
        Me.ButtonImpilatore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonImpilatore.Location = New System.Drawing.Point(1290, 71)
        Me.ButtonImpilatore.Name = "ButtonImpilatore"
        Me.ButtonImpilatore.Size = New System.Drawing.Size(176, 73)
        Me.ButtonImpilatore.TabIndex = 9
        Me.ButtonImpilatore.Text = "Impilatore"
        Me.ButtonImpilatore.UseVisualStyleBackColor = True
        '
        'ButtonPaletizzatore
        '
        Me.ButtonPaletizzatore.Enabled = False
        Me.ButtonPaletizzatore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPaletizzatore.Location = New System.Drawing.Point(1472, 71)
        Me.ButtonPaletizzatore.Name = "ButtonPaletizzatore"
        Me.ButtonPaletizzatore.Size = New System.Drawing.Size(176, 73)
        Me.ButtonPaletizzatore.TabIndex = 10
        Me.ButtonPaletizzatore.Text = "Paletizzatore"
        Me.ButtonPaletizzatore.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1058, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(235, 46)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Pz. prodotti"
        '
        'LabelContatoreProduzione
        '
        Me.LabelContatoreProduzione.AutoSize = True
        Me.LabelContatoreProduzione.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelContatoreProduzione.Location = New System.Drawing.Point(1079, 131)
        Me.LabelContatoreProduzione.Name = "LabelContatoreProduzione"
        Me.LabelContatoreProduzione.Size = New System.Drawing.Size(99, 108)
        Me.LabelContatoreProduzione.TabIndex = 16
        Me.LabelContatoreProduzione.Text = "0"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.OvalShapeGreen, Me.OvalShapeYellow, Me.OvalShapeRed, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1680, 993)
        Me.ShapeContainer1.TabIndex = 17
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 1
        Me.LineShape1.X2 = 1680
        Me.LineShape1.Y1 = 277
        Me.LineShape1.Y2 = 277
        '
        'OvalShapeGreen
        '
        Me.OvalShapeGreen.BorderWidth = 2
        Me.OvalShapeGreen.FillColor = System.Drawing.Color.Silver
        Me.OvalShapeGreen.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShapeGreen.Location = New System.Drawing.Point(9, 191)
        Me.OvalShapeGreen.Name = "OvalShapeGreen"
        Me.OvalShapeGreen.Size = New System.Drawing.Size(80, 80)
        '
        'OvalShapeYellow
        '
        Me.OvalShapeYellow.BorderWidth = 2
        Me.OvalShapeYellow.FillColor = System.Drawing.Color.Silver
        Me.OvalShapeYellow.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShapeYellow.Location = New System.Drawing.Point(9, 109)
        Me.OvalShapeYellow.Name = "OvalShapeYellow"
        Me.OvalShapeYellow.Size = New System.Drawing.Size(80, 80)
        '
        'OvalShapeRed
        '
        Me.OvalShapeRed.BorderWidth = 2
        Me.OvalShapeRed.FillColor = System.Drawing.Color.Silver
        Me.OvalShapeRed.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShapeRed.Location = New System.Drawing.Point(9, 27)
        Me.OvalShapeRed.Name = "OvalShapeRed"
        Me.OvalShapeRed.Size = New System.Drawing.Size(80, 80)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderWidth = 2
        Me.RectangleShape1.Location = New System.Drawing.Point(7, 26)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(85, 248)
        '
        'TimerForRoutineRegistrationData
        '
        Me.TimerForRoutineRegistrationData.Interval = 200
        '
        'LabelProduzioneOldNascosto
        '
        Me.LabelProduzioneOldNascosto.AutoSize = True
        Me.LabelProduzioneOldNascosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProduzioneOldNascosto.Location = New System.Drawing.Point(675, 88)
        Me.LabelProduzioneOldNascosto.Name = "LabelProduzioneOldNascosto"
        Me.LabelProduzioneOldNascosto.Size = New System.Drawing.Size(43, 46)
        Me.LabelProduzioneOldNascosto.TabIndex = 18
        Me.LabelProduzioneOldNascosto.Text = "0"
        Me.LabelProduzioneOldNascosto.Visible = False
        '
        'LabelContatoreFermata
        '
        Me.LabelContatoreFermata.AutoSize = True
        Me.LabelContatoreFermata.Location = New System.Drawing.Point(931, 188)
        Me.LabelContatoreFermata.Name = "LabelContatoreFermata"
        Me.LabelContatoreFermata.Size = New System.Drawing.Size(13, 13)
        Me.LabelContatoreFermata.TabIndex = 19
        Me.LabelContatoreFermata.Text = "0"
        '
        'LabelCurrentTime
        '
        Me.LabelCurrentTime.AutoSize = True
        Me.LabelCurrentTime.Location = New System.Drawing.Point(1389, 243)
        Me.LabelCurrentTime.Name = "LabelCurrentTime"
        Me.LabelCurrentTime.Size = New System.Drawing.Size(90, 13)
        Me.LabelCurrentTime.TabIndex = 20
        Me.LabelCurrentTime.Text = "LabelCurrentTime"
        '
        'LabelProduzioneNascosto
        '
        Me.LabelProduzioneNascosto.AutoSize = True
        Me.LabelProduzioneNascosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProduzioneNascosto.Location = New System.Drawing.Point(675, 132)
        Me.LabelProduzioneNascosto.Name = "LabelProduzioneNascosto"
        Me.LabelProduzioneNascosto.Size = New System.Drawing.Size(43, 46)
        Me.LabelProduzioneNascosto.TabIndex = 21
        Me.LabelProduzioneNascosto.Text = "0"
        Me.LabelProduzioneNascosto.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(789, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Contatore fermata"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(593, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "ProduzioneOld"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(593, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "ProduzioneNew"
        Me.Label6.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(791, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Contatore ripartenza"
        Me.Label3.Visible = False
        '
        'LabelContatoreRipartenza
        '
        Me.LabelContatoreRipartenza.AutoSize = True
        Me.LabelContatoreRipartenza.Location = New System.Drawing.Point(931, 218)
        Me.LabelContatoreRipartenza.Name = "LabelContatoreRipartenza"
        Me.LabelContatoreRipartenza.Size = New System.Drawing.Size(13, 13)
        Me.LabelContatoreRipartenza.TabIndex = 26
        Me.LabelContatoreRipartenza.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(101, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(259, 46)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Linea in stop"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(101, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(305, 46)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Linea in marcia"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(101, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(439, 46)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Richiesto giustificativo"
        '
        'ButtonLineaGenerale
        '
        Me.ButtonLineaGenerale.Enabled = False
        Me.ButtonLineaGenerale.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLineaGenerale.Location = New System.Drawing.Point(665, 0)
        Me.ButtonLineaGenerale.Name = "ButtonLineaGenerale"
        Me.ButtonLineaGenerale.Size = New System.Drawing.Size(339, 73)
        Me.ButtonLineaGenerale.TabIndex = 30
        Me.ButtonLineaGenerale.Text = "Linea Generale"
        Me.ButtonLineaGenerale.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(950, 131)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Id fermo"
        Me.Label10.Visible = False
        '
        'LabelIdFermo
        '
        Me.LabelIdFermo.AutoSize = True
        Me.LabelIdFermo.Location = New System.Drawing.Point(1001, 131)
        Me.LabelIdFermo.Name = "LabelIdFermo"
        Me.LabelIdFermo.Size = New System.Drawing.Size(13, 13)
        Me.LabelIdFermo.TabIndex = 32
        Me.LabelIdFermo.Text = "1"
        Me.LabelIdFermo.Visible = False
        '
        'LabelContatoreGiustificativo
        '
        Me.LabelContatoreGiustificativo.AutoSize = True
        Me.LabelContatoreGiustificativo.Location = New System.Drawing.Point(931, 250)
        Me.LabelContatoreGiustificativo.Name = "LabelContatoreGiustificativo"
        Me.LabelContatoreGiustificativo.Size = New System.Drawing.Size(13, 13)
        Me.LabelContatoreGiustificativo.TabIndex = 33
        Me.LabelContatoreGiustificativo.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(789, 250)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 13)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Contatore giustificativo"
        Me.Label11.Visible = False
        '
        'ButtonStart
        '
        Me.ButtonStart.BackColor = System.Drawing.Color.Transparent
        Me.ButtonStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonStart.Location = New System.Drawing.Point(366, 27)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(101, 37)
        Me.ButtonStart.TabIndex = 35
        Me.ButtonStart.Text = "Start"
        Me.ButtonStart.UseVisualStyleBackColor = False
        Me.ButtonStart.Visible = False
        '
        'ButtonStop
        '
        Me.ButtonStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStop.Location = New System.Drawing.Point(467, 27)
        Me.ButtonStop.Name = "ButtonStop"
        Me.ButtonStop.Size = New System.Drawing.Size(101, 37)
        Me.ButtonStop.TabIndex = 36
        Me.ButtonStop.Text = "Stop"
        Me.ButtonStop.UseVisualStyleBackColor = True
        Me.ButtonStop.Visible = False
        '
        'TimerMain
        '
        Me.TimerMain.Enabled = True
        Me.TimerMain.Interval = 1000
        '
        'PictureBoxFiamm
        '
        Me.PictureBoxFiamm.Image = CType(resources.GetObject("PictureBoxFiamm.Image"), System.Drawing.Image)
        Me.PictureBoxFiamm.InitialImage = Nothing
        Me.PictureBoxFiamm.Location = New System.Drawing.Point(1389, 50)
        Me.PictureBoxFiamm.Name = "PictureBoxFiamm"
        Me.PictureBoxFiamm.Size = New System.Drawing.Size(287, 175)
        Me.PictureBoxFiamm.TabIndex = 37
        Me.PictureBoxFiamm.TabStop = False
        '
        'LabelFermataDopo
        '
        Me.LabelFermataDopo.AutoSize = True
        Me.LabelFermataDopo.Location = New System.Drawing.Point(593, 188)
        Me.LabelFermataDopo.Name = "LabelFermataDopo"
        Me.LabelFermataDopo.Size = New System.Drawing.Size(72, 13)
        Me.LabelFermataDopo.TabIndex = 38
        Me.LabelFermataDopo.Text = "Fermata dopo"
        Me.LabelFermataDopo.Visible = False
        '
        'LabelRipartenzaDopo
        '
        Me.LabelRipartenzaDopo.AutoSize = True
        Me.LabelRipartenzaDopo.Location = New System.Drawing.Point(593, 218)
        Me.LabelRipartenzaDopo.Name = "LabelRipartenzaDopo"
        Me.LabelRipartenzaDopo.Size = New System.Drawing.Size(85, 13)
        Me.LabelRipartenzaDopo.TabIndex = 39
        Me.LabelRipartenzaDopo.Text = "Ripartenza dopo"
        Me.LabelRipartenzaDopo.Visible = False
        '
        'LabelGiustificativoDopo
        '
        Me.LabelGiustificativoDopo.AutoSize = True
        Me.LabelGiustificativoDopo.Location = New System.Drawing.Point(593, 250)
        Me.LabelGiustificativoDopo.Name = "LabelGiustificativoDopo"
        Me.LabelGiustificativoDopo.Size = New System.Drawing.Size(93, 13)
        Me.LabelGiustificativoDopo.TabIndex = 40
        Me.LabelGiustificativoDopo.Text = "GiustificativoDopo"
        Me.LabelGiustificativoDopo.Visible = False
        '
        'LabelFermataDopoValue
        '
        Me.LabelFermataDopoValue.AutoSize = True
        Me.LabelFermataDopoValue.Location = New System.Drawing.Point(705, 188)
        Me.LabelFermataDopoValue.Name = "LabelFermataDopoValue"
        Me.LabelFermataDopoValue.Size = New System.Drawing.Size(13, 13)
        Me.LabelFermataDopoValue.TabIndex = 41
        Me.LabelFermataDopoValue.Text = "0"
        Me.LabelFermataDopoValue.Visible = False
        '
        'LabelRipartenzaDopoValue
        '
        Me.LabelRipartenzaDopoValue.AutoSize = True
        Me.LabelRipartenzaDopoValue.Location = New System.Drawing.Point(706, 218)
        Me.LabelRipartenzaDopoValue.Name = "LabelRipartenzaDopoValue"
        Me.LabelRipartenzaDopoValue.Size = New System.Drawing.Size(13, 13)
        Me.LabelRipartenzaDopoValue.TabIndex = 42
        Me.LabelRipartenzaDopoValue.Text = "0"
        Me.LabelRipartenzaDopoValue.Visible = False
        '
        'LabelGiustificativoDopoValue
        '
        Me.LabelGiustificativoDopoValue.AutoSize = True
        Me.LabelGiustificativoDopoValue.Location = New System.Drawing.Point(706, 250)
        Me.LabelGiustificativoDopoValue.Name = "LabelGiustificativoDopoValue"
        Me.LabelGiustificativoDopoValue.Size = New System.Drawing.Size(13, 13)
        Me.LabelGiustificativoDopoValue.TabIndex = 43
        Me.LabelGiustificativoDopoValue.Text = "0"
        Me.LabelGiustificativoDopoValue.Visible = False
        '
        'LabelTime
        '
        Me.LabelTime.AutoSize = True
        Me.LabelTime.Location = New System.Drawing.Point(745, 188)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(29, 13)
        Me.LabelTime.TabIndex = 44
        Me.LabelTime.Text = "Sec."
        Me.LabelTime.Visible = False
        '
        'LabelPz
        '
        Me.LabelPz.AutoSize = True
        Me.LabelPz.Location = New System.Drawing.Point(745, 219)
        Me.LabelPz.Name = "LabelPz"
        Me.LabelPz.Size = New System.Drawing.Size(22, 13)
        Me.LabelPz.TabIndex = 45
        Me.LabelPz.Text = "Pz."
        Me.LabelPz.Visible = False
        '
        'LabelPz2
        '
        Me.LabelPz2.AutoSize = True
        Me.LabelPz2.Location = New System.Drawing.Point(745, 250)
        Me.LabelPz2.Name = "LabelPz2"
        Me.LabelPz2.Size = New System.Drawing.Size(22, 13)
        Me.LabelPz2.TabIndex = 46
        Me.LabelPz2.Text = "Pz."
        Me.LabelPz2.Visible = False
        '
        'LabelNotaProduzione
        '
        Me.LabelNotaProduzione.AutoSize = True
        Me.LabelNotaProduzione.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNotaProduzione.ForeColor = System.Drawing.Color.DarkGray
        Me.LabelNotaProduzione.Location = New System.Drawing.Point(1063, 34)
        Me.LabelNotaProduzione.Name = "LabelNotaProduzione"
        Me.LabelNotaProduzione.Size = New System.Drawing.Size(349, 13)
        Me.LabelNotaProduzione.TabIndex = 47
        Me.LabelNotaProduzione.Text = "Nota: Non utilizzare questo dato per dichiarare la produzione"
        '
        'ChartProduzioneOraria
        '
        Me.ChartProduzioneOraria.BackColor = System.Drawing.SystemColors.Control
        ChartArea28.AxisX.Title = "Orario"
        ChartArea28.AxisY.Title = "Pz."
        ChartArea28.BackColor = System.Drawing.SystemColors.Control
        ChartArea28.Name = "ChartArea1"
        Me.ChartProduzioneOraria.ChartAreas.Add(ChartArea28)
        Legend28.BackColor = System.Drawing.SystemColors.Control
        Legend28.Name = "Legend1"
        Me.ChartProduzioneOraria.Legends.Add(Legend28)
        Me.ChartProduzioneOraria.Location = New System.Drawing.Point(-255, 435)
        Me.ChartProduzioneOraria.Name = "ChartProduzioneOraria"
        Series10.BorderWidth = 4
        Series10.ChartArea = "ChartArea1"
        Series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series10.IsValueShownAsLabel = True
        Series10.Legend = "Legend1"
        Series10.LegendText = "Produzione oraria"
        Series10.Name = "Series1"
        Series10.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Me.ChartProduzioneOraria.Series.Add(Series10)
        Me.ChartProduzioneOraria.Size = New System.Drawing.Size(1918, 269)
        Me.ChartProduzioneOraria.TabIndex = 49
        Me.ChartProduzioneOraria.Text = "Chart1"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(789, 132)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "Id linea"
        Me.Label12.Visible = False
        '
        'LblIdLinea
        '
        Me.LblIdLinea.AutoSize = True
        Me.LblIdLinea.Location = New System.Drawing.Point(926, 132)
        Me.LblIdLinea.Name = "LblIdLinea"
        Me.LblIdLinea.Size = New System.Drawing.Size(13, 13)
        Me.LblIdLinea.TabIndex = 51
        Me.LblIdLinea.Text = "0"
        Me.LblIdLinea.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(789, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Id reparto"
        Me.Label13.Visible = False
        '
        'LblIdDepartment
        '
        Me.LblIdDepartment.AutoSize = True
        Me.LblIdDepartment.Location = New System.Drawing.Point(926, 80)
        Me.LblIdDepartment.Name = "LblIdDepartment"
        Me.LblIdDepartment.Size = New System.Drawing.Size(13, 13)
        Me.LblIdDepartment.TabIndex = 53
        Me.LblIdDepartment.Text = "0"
        Me.LblIdDepartment.Visible = False
        '
        'LblDepartmentDescription
        '
        Me.LblDepartmentDescription.AutoSize = True
        Me.LblDepartmentDescription.Location = New System.Drawing.Point(926, 102)
        Me.LblDepartmentDescription.Name = "LblDepartmentDescription"
        Me.LblDepartmentDescription.Size = New System.Drawing.Size(13, 13)
        Me.LblDepartmentDescription.TabIndex = 59
        Me.LblDepartmentDescription.Text = "0"
        Me.LblDepartmentDescription.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(789, 102)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(118, 13)
        Me.Label14.TabIndex = 60
        Me.Label14.Text = "Department Description"
        Me.Label14.Visible = False
        '
        'LblLineDescription
        '
        Me.LblLineDescription.AutoSize = True
        Me.LblLineDescription.Location = New System.Drawing.Point(926, 158)
        Me.LblLineDescription.Name = "LblLineDescription"
        Me.LblLineDescription.Size = New System.Drawing.Size(13, 13)
        Me.LblLineDescription.TabIndex = 61
        Me.LblLineDescription.Text = "0"
        Me.LblLineDescription.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(789, 158)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 13)
        Me.Label15.TabIndex = 62
        Me.Label15.Text = "Line Description"
        Me.Label15.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DarkGray
        Me.Label16.Location = New System.Drawing.Point(1535, 209)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(122, 13)
        Me.Label16.TabIndex = 63
        Me.Label16.Text = "Developed by RECO"
        '
        'ButtonRitentaConnessione
        '
        Me.ButtonRitentaConnessione.BackColor = System.Drawing.Color.Transparent
        Me.ButtonRitentaConnessione.Location = New System.Drawing.Point(1251, 206)
        Me.ButtonRitentaConnessione.Name = "ButtonRitentaConnessione"
        Me.ButtonRitentaConnessione.Size = New System.Drawing.Size(135, 19)
        Me.ButtonRitentaConnessione.TabIndex = 65
        Me.ButtonRitentaConnessione.Text = "Ritenta connessione"
        Me.ButtonRitentaConnessione.UseVisualStyleBackColor = False
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Location = New System.Drawing.Point(1248, 198)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(0, 13)
        Me.LblStatus.TabIndex = 66
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisualizzaFermateToolStripMenuItem, Me.VisualizzaProduzioneToolStripMenuItem, Me.AnalisiFermiToolStripMenuItem, Me.UtilityToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1680, 24)
        Me.MenuStrip1.TabIndex = 67
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VisualizzaFermateToolStripMenuItem
        '
        Me.VisualizzaFermateToolStripMenuItem.Name = "VisualizzaFermateToolStripMenuItem"
        Me.VisualizzaFermateToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.VisualizzaFermateToolStripMenuItem.Text = "Visualizza fermate"
        '
        'VisualizzaProduzioneToolStripMenuItem
        '
        Me.VisualizzaProduzioneToolStripMenuItem.Name = "VisualizzaProduzioneToolStripMenuItem"
        Me.VisualizzaProduzioneToolStripMenuItem.Size = New System.Drawing.Size(132, 20)
        Me.VisualizzaProduzioneToolStripMenuItem.Text = "Visualizza produzione"
        '
        'AnalisiFermiToolStripMenuItem
        '
        Me.AnalisiFermiToolStripMenuItem.Name = "AnalisiFermiToolStripMenuItem"
        Me.AnalisiFermiToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.AnalisiFermiToolStripMenuItem.Text = "Analisi fermi"
        '
        'UtilityToolStripMenuItem
        '
        Me.UtilityToolStripMenuItem.Name = "UtilityToolStripMenuItem"
        Me.UtilityToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.UtilityToolStripMenuItem.Text = "Utility"
        '
        'TextBoxProduzione
        '
        Me.TextBoxProduzione.Location = New System.Drawing.Point(929, 30)
        Me.TextBoxProduzione.Name = "TextBoxProduzione"
        Me.TextBoxProduzione.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxProduzione.TabIndex = 68
        Me.TextBoxProduzione.Text = "0"
        '
        'LabelContatoreProduzioneHidden
        '
        Me.LabelContatoreProduzioneHidden.AutoSize = True
        Me.LabelContatoreProduzioneHidden.Location = New System.Drawing.Point(688, 65)
        Me.LabelContatoreProduzioneHidden.Name = "LabelContatoreProduzioneHidden"
        Me.LabelContatoreProduzioneHidden.Size = New System.Drawing.Size(13, 13)
        Me.LabelContatoreProduzioneHidden.TabIndex = 69
        Me.LabelContatoreProduzioneHidden.Text = "0"
        Me.LabelContatoreProduzioneHidden.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(589, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Produzione"
        Me.Label1.Visible = False
        '
        'ChartMacchine
        '
        ChartArea29.Name = "ChartArea1"
        Me.ChartMacchine.ChartAreas.Add(ChartArea29)
        Legend29.Name = "Legend1"
        Me.ChartMacchine.Legends.Add(Legend29)
        Me.ChartMacchine.Location = New System.Drawing.Point(0, 693)
        Me.ChartMacchine.Name = "ChartMacchine"
        Me.ChartMacchine.Size = New System.Drawing.Size(705, 300)
        Me.ChartMacchine.TabIndex = 71
        Me.ChartMacchine.Text = "Chart"
        Title19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title19.Name = "Title1"
        Title19.Text = "Causali fermi - ultime 8 ore"
        Me.ChartMacchine.Titles.Add(Title19)
        '
        'ChartCausali
        '
        ChartArea30.Name = "ChartArea1"
        Me.ChartCausali.ChartAreas.Add(ChartArea30)
        Legend30.Name = "Legend1"
        Me.ChartCausali.Legends.Add(Legend30)
        Me.ChartCausali.Location = New System.Drawing.Point(740, 693)
        Me.ChartCausali.Name = "ChartCausali"
        Me.ChartCausali.Size = New System.Drawing.Size(705, 300)
        Me.ChartCausali.TabIndex = 72
        Me.ChartCausali.Text = "Chart"
        Title20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title20.Name = "Title1"
        Title20.Text = "Causali fermi -LINEA GENERALE - ultime 8 ore"
        Me.ChartCausali.Titles.Add(Title20)
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(1494, 790)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(136, 25)
        Me.Label17.TabIndex = 73
        Me.Label17.Text = "ultime 8 ore"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(1462, 856)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(142, 25)
        Me.Label18.TabIndex = 74
        Me.Label18.Text = "Minuti fermo"
        '
        'LabelMinutiFermo
        '
        Me.LabelMinutiFermo.AutoSize = True
        Me.LabelMinutiFermo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMinutiFermo.Location = New System.Drawing.Point(1638, 856)
        Me.LabelMinutiFermo.Name = "LabelMinutiFermo"
        Me.LabelMinutiFermo.Size = New System.Drawing.Size(25, 25)
        Me.LabelMinutiFermo.TabIndex = 75
        Me.LabelMinutiFermo.Text = "0"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(1462, 894)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(116, 25)
        Me.Label21.TabIndex = 76
        Me.Label21.Text = "% up time"
        '
        'LabelUptime
        '
        Me.LabelUptime.AutoSize = True
        Me.LabelUptime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUptime.Location = New System.Drawing.Point(1638, 894)
        Me.LabelUptime.Name = "LabelUptime"
        Me.LabelUptime.Size = New System.Drawing.Size(25, 25)
        Me.LabelUptime.TabIndex = 77
        Me.LabelUptime.Text = "0"
        '
        'LblPathDatabase
        '
        Me.LblPathDatabase.AutoSize = True
        Me.LblPathDatabase.Location = New System.Drawing.Point(926, 59)
        Me.LblPathDatabase.Name = "LblPathDatabase"
        Me.LblPathDatabase.Size = New System.Drawing.Size(13, 13)
        Me.LblPathDatabase.TabIndex = 78
        Me.LblPathDatabase.Text = "0"
        Me.LblPathDatabase.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(791, 59)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(78, 13)
        Me.Label19.TabIndex = 79
        Me.Label19.Text = "Path Database"
        Me.Label19.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(978, 250)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(111, 13)
        Me.Label20.TabIndex = 80
        Me.Label20.Text = "Pezzi per ogni impulso"
        Me.Label20.Visible = False
        '
        'LblPezziOgniImpulso
        '
        Me.LblPezziOgniImpulso.AutoSize = True
        Me.LblPezziOgniImpulso.Location = New System.Drawing.Point(1132, 250)
        Me.LblPezziOgniImpulso.Name = "LblPezziOgniImpulso"
        Me.LblPezziOgniImpulso.Size = New System.Drawing.Size(13, 13)
        Me.LblPezziOgniImpulso.TabIndex = 81
        Me.LblPezziOgniImpulso.Text = "0"
        Me.LblPezziOgniImpulso.Visible = False
        '
        'Tab
        '
        Me.Tab.Controls.Add(Me.TabStiratura)
        Me.Tab.Controls.Add(Me.TabMontaggio)
        Me.Tab.Controls.Add(Me.TabFormazione)
        Me.Tab.Controls.Add(Me.TabCarica)
        Me.Tab.Location = New System.Drawing.Point(0, 266)
        Me.Tab.Multiline = True
        Me.Tab.Name = "Tab"
        Me.Tab.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tab.SelectedIndex = 0
        Me.Tab.Size = New System.Drawing.Size(1680, 170)
        Me.Tab.TabIndex = 82
        '
        'TabStiratura
        '
        Me.TabStiratura.Controls.Add(Me.ButtonSvolgitore)
        Me.TabStiratura.Controls.Add(Me.ButtonEspansore)
        Me.TabStiratura.Controls.Add(Me.ButtonTabBlanker)
        Me.TabStiratura.Controls.Add(Me.ButtonMolazza)
        Me.TabStiratura.Controls.Add(Me.ButtonSpalmatrice)
        Me.TabStiratura.Controls.Add(Me.ButtonLineaGenerale)
        Me.TabStiratura.Controls.Add(Me.ButtonDivider)
        Me.TabStiratura.Controls.Add(Me.ButtonImpilatore)
        Me.TabStiratura.Controls.Add(Me.ButtonPaletizzatore)
        Me.TabStiratura.Controls.Add(Me.ButtonTunnel)
        Me.TabStiratura.Location = New System.Drawing.Point(4, 22)
        Me.TabStiratura.Name = "TabStiratura"
        Me.TabStiratura.Padding = New System.Windows.Forms.Padding(3)
        Me.TabStiratura.Size = New System.Drawing.Size(1672, 144)
        Me.TabStiratura.TabIndex = 0
        Me.TabStiratura.Text = "Stiratura"
        Me.TabStiratura.UseVisualStyleBackColor = True
        '
        'TabMontaggio
        '
        Me.TabMontaggio.Controls.Add(Me.ButtonPinzaPaletizzatore)
        Me.TabMontaggio.Controls.Add(Me.ButtonNastriTrasportatori)
        Me.TabMontaggio.Controls.Add(Me.ButtonSaldapolari)
        Me.TabMontaggio.Controls.Add(Me.ButtonRobot)
        Me.TabMontaggio.Controls.Add(Me.ButtonTermosaldatrice)
        Me.TabMontaggio.Controls.Add(Me.ButtonPosaCoperchi)
        Me.TabMontaggio.Controls.Add(Me.ButtonMarcatore)
        Me.TabMontaggio.Controls.Add(Me.ButtonProvaCorti2)
        Me.TabMontaggio.Controls.Add(Me.ButtonProvaAltezzaPolari)
        Me.TabMontaggio.Controls.Add(Me.ButtonPuntatrice)
        Me.TabMontaggio.Controls.Add(Me.ButtonProvaPneumatica)
        Me.TabMontaggio.Controls.Add(Me.ButtonProvaCorti1)
        Me.TabMontaggio.Controls.Add(Me.ButtonCOS)
        Me.TabMontaggio.Controls.Add(Me.ButtonBuffer)
        Me.TabMontaggio.Controls.Add(Me.ButtonImbustatrice2)
        Me.TabMontaggio.Controls.Add(Me.ButtonImbustatrice1)
        Me.TabMontaggio.Controls.Add(Me.ButtonTranciasetti)
        Me.TabMontaggio.Controls.Add(Me.ButtonLineaGeneraleMontaggio)
        Me.TabMontaggio.Location = New System.Drawing.Point(4, 22)
        Me.TabMontaggio.Name = "TabMontaggio"
        Me.TabMontaggio.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMontaggio.Size = New System.Drawing.Size(1672, 144)
        Me.TabMontaggio.TabIndex = 1
        Me.TabMontaggio.Text = "Montaggio"
        Me.TabMontaggio.UseVisualStyleBackColor = True
        '
        'ButtonPinzaPaletizzatore
        '
        Me.ButtonPinzaPaletizzatore.Enabled = False
        Me.ButtonPinzaPaletizzatore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPinzaPaletizzatore.Location = New System.Drawing.Point(948, 100)
        Me.ButtonPinzaPaletizzatore.Name = "ButtonPinzaPaletizzatore"
        Me.ButtonPinzaPaletizzatore.Size = New System.Drawing.Size(174, 48)
        Me.ButtonPinzaPaletizzatore.TabIndex = 85
        Me.ButtonPinzaPaletizzatore.Text = "Pinza\Paletizzatore"
        Me.ButtonPinzaPaletizzatore.UseVisualStyleBackColor = True
        '
        'ButtonNastriTrasportatori
        '
        Me.ButtonNastriTrasportatori.Enabled = False
        Me.ButtonNastriTrasportatori.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNastriTrasportatori.Location = New System.Drawing.Point(1328, 100)
        Me.ButtonNastriTrasportatori.Name = "ButtonNastriTrasportatori"
        Me.ButtonNastriTrasportatori.Size = New System.Drawing.Size(172, 48)
        Me.ButtonNastriTrasportatori.TabIndex = 87
        Me.ButtonNastriTrasportatori.Text = "Nastri Trasportatori"
        Me.ButtonNastriTrasportatori.UseVisualStyleBackColor = True
        '
        'ButtonSaldapolari
        '
        Me.ButtonSaldapolari.Enabled = False
        Me.ButtonSaldapolari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSaldapolari.Location = New System.Drawing.Point(187, 100)
        Me.ButtonSaldapolari.Name = "ButtonSaldapolari"
        Me.ButtonSaldapolari.Size = New System.Drawing.Size(174, 48)
        Me.ButtonSaldapolari.TabIndex = 42
        Me.ButtonSaldapolari.Text = "Saldapolari"
        Me.ButtonSaldapolari.UseVisualStyleBackColor = True
        '
        'ButtonRobot
        '
        Me.ButtonRobot.Enabled = False
        Me.ButtonRobot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRobot.Location = New System.Drawing.Point(1144, 100)
        Me.ButtonRobot.Name = "ButtonRobot"
        Me.ButtonRobot.Size = New System.Drawing.Size(174, 48)
        Me.ButtonRobot.TabIndex = 86
        Me.ButtonRobot.Text = "Robot"
        Me.ButtonRobot.UseVisualStyleBackColor = True
        '
        'ButtonTermosaldatrice
        '
        Me.ButtonTermosaldatrice.Enabled = False
        Me.ButtonTermosaldatrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTermosaldatrice.Location = New System.Drawing.Point(2, 100)
        Me.ButtonTermosaldatrice.Name = "ButtonTermosaldatrice"
        Me.ButtonTermosaldatrice.Size = New System.Drawing.Size(174, 48)
        Me.ButtonTermosaldatrice.TabIndex = 41
        Me.ButtonTermosaldatrice.Text = "Termosaldatrice"
        Me.ButtonTermosaldatrice.UseVisualStyleBackColor = True
        '
        'ButtonPosaCoperchi
        '
        Me.ButtonPosaCoperchi.Enabled = False
        Me.ButtonPosaCoperchi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPosaCoperchi.Location = New System.Drawing.Point(1516, 43)
        Me.ButtonPosaCoperchi.Name = "ButtonPosaCoperchi"
        Me.ButtonPosaCoperchi.Size = New System.Drawing.Size(174, 48)
        Me.ButtonPosaCoperchi.TabIndex = 40
        Me.ButtonPosaCoperchi.Text = "Posa Coperchi"
        Me.ButtonPosaCoperchi.UseVisualStyleBackColor = True
        '
        'ButtonMarcatore
        '
        Me.ButtonMarcatore.Enabled = False
        Me.ButtonMarcatore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMarcatore.Location = New System.Drawing.Point(756, 100)
        Me.ButtonMarcatore.Name = "ButtonMarcatore"
        Me.ButtonMarcatore.Size = New System.Drawing.Size(174, 48)
        Me.ButtonMarcatore.TabIndex = 84
        Me.ButtonMarcatore.Text = "Marcatore"
        Me.ButtonMarcatore.UseVisualStyleBackColor = True
        '
        'ButtonProvaCorti2
        '
        Me.ButtonProvaCorti2.Enabled = False
        Me.ButtonProvaCorti2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonProvaCorti2.Location = New System.Drawing.Point(1328, 43)
        Me.ButtonProvaCorti2.Name = "ButtonProvaCorti2"
        Me.ButtonProvaCorti2.Size = New System.Drawing.Size(174, 48)
        Me.ButtonProvaCorti2.TabIndex = 39
        Me.ButtonProvaCorti2.Text = "Prova Corti 2"
        Me.ButtonProvaCorti2.UseVisualStyleBackColor = True
        '
        'ButtonProvaAltezzaPolari
        '
        Me.ButtonProvaAltezzaPolari.Enabled = False
        Me.ButtonProvaAltezzaPolari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonProvaAltezzaPolari.Location = New System.Drawing.Point(567, 100)
        Me.ButtonProvaAltezzaPolari.Name = "ButtonProvaAltezzaPolari"
        Me.ButtonProvaAltezzaPolari.Size = New System.Drawing.Size(174, 48)
        Me.ButtonProvaAltezzaPolari.TabIndex = 83
        Me.ButtonProvaAltezzaPolari.Text = "Prova Altezza Polari"
        Me.ButtonProvaAltezzaPolari.UseVisualStyleBackColor = True
        '
        'ButtonPuntatrice
        '
        Me.ButtonPuntatrice.Enabled = False
        Me.ButtonPuntatrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPuntatrice.Location = New System.Drawing.Point(1144, 43)
        Me.ButtonPuntatrice.Name = "ButtonPuntatrice"
        Me.ButtonPuntatrice.Size = New System.Drawing.Size(174, 48)
        Me.ButtonPuntatrice.TabIndex = 38
        Me.ButtonPuntatrice.Text = "Puntatrice"
        Me.ButtonPuntatrice.UseVisualStyleBackColor = True
        '
        'ButtonProvaPneumatica
        '
        Me.ButtonProvaPneumatica.Enabled = False
        Me.ButtonProvaPneumatica.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonProvaPneumatica.Location = New System.Drawing.Point(378, 100)
        Me.ButtonProvaPneumatica.Name = "ButtonProvaPneumatica"
        Me.ButtonProvaPneumatica.Size = New System.Drawing.Size(172, 48)
        Me.ButtonProvaPneumatica.TabIndex = 43
        Me.ButtonProvaPneumatica.Text = "Prova Pneumatica"
        Me.ButtonProvaPneumatica.UseVisualStyleBackColor = True
        '
        'ButtonProvaCorti1
        '
        Me.ButtonProvaCorti1.Enabled = False
        Me.ButtonProvaCorti1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonProvaCorti1.Location = New System.Drawing.Point(948, 43)
        Me.ButtonProvaCorti1.Name = "ButtonProvaCorti1"
        Me.ButtonProvaCorti1.Size = New System.Drawing.Size(174, 48)
        Me.ButtonProvaCorti1.TabIndex = 37
        Me.ButtonProvaCorti1.Text = "Prova corti 1"
        Me.ButtonProvaCorti1.UseVisualStyleBackColor = True
        '
        'ButtonCOS
        '
        Me.ButtonCOS.Enabled = False
        Me.ButtonCOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCOS.Location = New System.Drawing.Point(756, 43)
        Me.ButtonCOS.Name = "ButtonCOS"
        Me.ButtonCOS.Size = New System.Drawing.Size(174, 48)
        Me.ButtonCOS.TabIndex = 36
        Me.ButtonCOS.Text = "COS"
        Me.ButtonCOS.UseVisualStyleBackColor = True
        '
        'ButtonBuffer
        '
        Me.ButtonBuffer.Enabled = False
        Me.ButtonBuffer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBuffer.Location = New System.Drawing.Point(567, 43)
        Me.ButtonBuffer.Name = "ButtonBuffer"
        Me.ButtonBuffer.Size = New System.Drawing.Size(174, 48)
        Me.ButtonBuffer.TabIndex = 35
        Me.ButtonBuffer.Text = "Buffer"
        Me.ButtonBuffer.UseVisualStyleBackColor = True
        '
        'ButtonImbustatrice2
        '
        Me.ButtonImbustatrice2.Enabled = False
        Me.ButtonImbustatrice2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonImbustatrice2.Location = New System.Drawing.Point(376, 43)
        Me.ButtonImbustatrice2.Name = "ButtonImbustatrice2"
        Me.ButtonImbustatrice2.Size = New System.Drawing.Size(174, 48)
        Me.ButtonImbustatrice2.TabIndex = 34
        Me.ButtonImbustatrice2.Text = "Imbustatrice 2"
        Me.ButtonImbustatrice2.UseVisualStyleBackColor = True
        '
        'ButtonImbustatrice1
        '
        Me.ButtonImbustatrice1.Enabled = False
        Me.ButtonImbustatrice1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonImbustatrice1.Location = New System.Drawing.Point(187, 43)
        Me.ButtonImbustatrice1.Name = "ButtonImbustatrice1"
        Me.ButtonImbustatrice1.Size = New System.Drawing.Size(174, 48)
        Me.ButtonImbustatrice1.TabIndex = 33
        Me.ButtonImbustatrice1.Text = "Imbustatrice 1"
        Me.ButtonImbustatrice1.UseVisualStyleBackColor = True
        '
        'ButtonTranciasetti
        '
        Me.ButtonTranciasetti.Enabled = False
        Me.ButtonTranciasetti.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTranciasetti.Location = New System.Drawing.Point(2, 43)
        Me.ButtonTranciasetti.Name = "ButtonTranciasetti"
        Me.ButtonTranciasetti.Size = New System.Drawing.Size(174, 48)
        Me.ButtonTranciasetti.TabIndex = 32
        Me.ButtonTranciasetti.Text = "Tranciasetti"
        Me.ButtonTranciasetti.UseVisualStyleBackColor = True
        '
        'ButtonLineaGeneraleMontaggio
        '
        Me.ButtonLineaGeneraleMontaggio.Enabled = False
        Me.ButtonLineaGeneraleMontaggio.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLineaGeneraleMontaggio.Location = New System.Drawing.Point(679, 0)
        Me.ButtonLineaGeneraleMontaggio.Name = "ButtonLineaGeneraleMontaggio"
        Me.ButtonLineaGeneraleMontaggio.Size = New System.Drawing.Size(339, 43)
        Me.ButtonLineaGeneraleMontaggio.TabIndex = 31
        Me.ButtonLineaGeneraleMontaggio.Text = "Linea Generale"
        Me.ButtonLineaGeneraleMontaggio.UseVisualStyleBackColor = True
        '
        'TabCarica
        '
        Me.TabCarica.Controls.Add(Me.ButtonAKSI)
        Me.TabCarica.Controls.Add(Me.ButtonNastriTrasporto)
        Me.TabCarica.Controls.Add(Me.ButtonDielettrico)
        Me.TabCarica.Controls.Add(Me.ButtonScaricoManuale)
        Me.TabCarica.Controls.Add(Me.ButtonRobotCarica)
        Me.TabCarica.Controls.Add(Me.ButtonControlloVestizione)
        Me.TabCarica.Controls.Add(Me.ButtonVestizione)
        Me.TabCarica.Controls.Add(Me.ButtonMarcatoreCarica)
        Me.TabCarica.Controls.Add(Me.ButtonControlloLivelli)
        Me.TabCarica.Controls.Add(Me.ButtonScaricaRapida)
        Me.TabCarica.Controls.Add(Me.ButtonTappatrice)
        Me.TabCarica.Controls.Add(Me.ButtonPulisciPoli)
        Me.TabCarica.Controls.Add(Me.ButtonTunnelLavaggio)
        Me.TabCarica.Controls.Add(Me.ButtonPosaTogliRampe)
        Me.TabCarica.Controls.Add(Me.Button2Riempimento)
        Me.TabCarica.Controls.Add(Me.ButtonDiluitore)
        Me.TabCarica.Controls.Add(Me.ButtonRovesciatore)
        Me.TabCarica.Controls.Add(Me.ButtonRotatore)
        Me.TabCarica.Controls.Add(Me.ButtonLineaGeneraleCarica)
        Me.TabCarica.Location = New System.Drawing.Point(4, 22)
        Me.TabCarica.Name = "TabCarica"
        Me.TabCarica.Size = New System.Drawing.Size(1672, 144)
        Me.TabCarica.TabIndex = 2
        Me.TabCarica.Text = "Carica"
        Me.TabCarica.UseVisualStyleBackColor = True
        '
        'ButtonAKSI
        '
        Me.ButtonAKSI.Enabled = False
        Me.ButtonAKSI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAKSI.Location = New System.Drawing.Point(394, 109)
        Me.ButtonAKSI.Name = "ButtonAKSI"
        Me.ButtonAKSI.Size = New System.Drawing.Size(174, 48)
        Me.ButtonAKSI.TabIndex = 85
        Me.ButtonAKSI.Text = "AKSI"
        Me.ButtonAKSI.UseVisualStyleBackColor = True
        '
        'ButtonNastriTrasporto
        '
        Me.ButtonNastriTrasporto.Enabled = False
        Me.ButtonNastriTrasporto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNastriTrasporto.Location = New System.Drawing.Point(1472, 109)
        Me.ButtonNastriTrasporto.Name = "ButtonNastriTrasporto"
        Me.ButtonNastriTrasporto.Size = New System.Drawing.Size(174, 48)
        Me.ButtonNastriTrasporto.TabIndex = 91
        Me.ButtonNastriTrasporto.Text = "Nastri Trasporto"
        Me.ButtonNastriTrasporto.UseVisualStyleBackColor = True
        '
        'ButtonDielettrico
        '
        Me.ButtonDielettrico.Enabled = False
        Me.ButtonDielettrico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDielettrico.Location = New System.Drawing.Point(214, 109)
        Me.ButtonDielettrico.Name = "ButtonDielettrico"
        Me.ButtonDielettrico.Size = New System.Drawing.Size(174, 48)
        Me.ButtonDielettrico.TabIndex = 84
        Me.ButtonDielettrico.Text = "Dielettrico"
        Me.ButtonDielettrico.UseVisualStyleBackColor = True
        '
        'ButtonScaricoManuale
        '
        Me.ButtonScaricoManuale.Enabled = False
        Me.ButtonScaricoManuale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonScaricoManuale.Location = New System.Drawing.Point(1294, 109)
        Me.ButtonScaricoManuale.Name = "ButtonScaricoManuale"
        Me.ButtonScaricoManuale.Size = New System.Drawing.Size(174, 48)
        Me.ButtonScaricoManuale.TabIndex = 90
        Me.ButtonScaricoManuale.Text = "Scarico Manuale"
        Me.ButtonScaricoManuale.UseVisualStyleBackColor = True
        '
        'ButtonRobotCarica
        '
        Me.ButtonRobotCarica.Enabled = False
        Me.ButtonRobotCarica.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRobotCarica.Location = New System.Drawing.Point(1113, 109)
        Me.ButtonRobotCarica.Name = "ButtonRobotCarica"
        Me.ButtonRobotCarica.Size = New System.Drawing.Size(174, 48)
        Me.ButtonRobotCarica.TabIndex = 89
        Me.ButtonRobotCarica.Text = "Robot"
        Me.ButtonRobotCarica.UseVisualStyleBackColor = True
        '
        'ButtonControlloVestizione
        '
        Me.ButtonControlloVestizione.Enabled = False
        Me.ButtonControlloVestizione.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonControlloVestizione.Location = New System.Drawing.Point(933, 109)
        Me.ButtonControlloVestizione.Name = "ButtonControlloVestizione"
        Me.ButtonControlloVestizione.Size = New System.Drawing.Size(174, 48)
        Me.ButtonControlloVestizione.TabIndex = 88
        Me.ButtonControlloVestizione.Text = "ControlloVestizione"
        Me.ButtonControlloVestizione.UseVisualStyleBackColor = True
        '
        'ButtonVestizione
        '
        Me.ButtonVestizione.Enabled = False
        Me.ButtonVestizione.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonVestizione.Location = New System.Drawing.Point(753, 109)
        Me.ButtonVestizione.Name = "ButtonVestizione"
        Me.ButtonVestizione.Size = New System.Drawing.Size(174, 48)
        Me.ButtonVestizione.TabIndex = 87
        Me.ButtonVestizione.Text = "Vestizione"
        Me.ButtonVestizione.UseVisualStyleBackColor = True
        '
        'ButtonMarcatoreCarica
        '
        Me.ButtonMarcatoreCarica.Enabled = False
        Me.ButtonMarcatoreCarica.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMarcatoreCarica.Location = New System.Drawing.Point(574, 109)
        Me.ButtonMarcatoreCarica.Name = "ButtonMarcatoreCarica"
        Me.ButtonMarcatoreCarica.Size = New System.Drawing.Size(174, 48)
        Me.ButtonMarcatoreCarica.TabIndex = 86
        Me.ButtonMarcatoreCarica.Text = "Marcatore"
        Me.ButtonMarcatoreCarica.UseVisualStyleBackColor = True
        '
        'ButtonControlloLivelli
        '
        Me.ButtonControlloLivelli.Enabled = False
        Me.ButtonControlloLivelli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonControlloLivelli.Location = New System.Drawing.Point(1113, 55)
        Me.ButtonControlloLivelli.Name = "ButtonControlloLivelli"
        Me.ButtonControlloLivelli.Size = New System.Drawing.Size(174, 48)
        Me.ButtonControlloLivelli.TabIndex = 39
        Me.ButtonControlloLivelli.Text = "Controllo Livelli"
        Me.ButtonControlloLivelli.UseVisualStyleBackColor = True
        '
        'ButtonScaricaRapida
        '
        Me.ButtonScaricaRapida.Enabled = False
        Me.ButtonScaricaRapida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonScaricaRapida.Location = New System.Drawing.Point(34, 109)
        Me.ButtonScaricaRapida.Name = "ButtonScaricaRapida"
        Me.ButtonScaricaRapida.Size = New System.Drawing.Size(174, 48)
        Me.ButtonScaricaRapida.TabIndex = 83
        Me.ButtonScaricaRapida.Text = "Scarica Rapida"
        Me.ButtonScaricaRapida.UseVisualStyleBackColor = True
        '
        'ButtonTappatrice
        '
        Me.ButtonTappatrice.Enabled = False
        Me.ButtonTappatrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTappatrice.Location = New System.Drawing.Point(1292, 55)
        Me.ButtonTappatrice.Name = "ButtonTappatrice"
        Me.ButtonTappatrice.Size = New System.Drawing.Size(174, 48)
        Me.ButtonTappatrice.TabIndex = 40
        Me.ButtonTappatrice.Text = "Tappatrice"
        Me.ButtonTappatrice.UseVisualStyleBackColor = True
        '
        'ButtonPulisciPoli
        '
        Me.ButtonPulisciPoli.Enabled = False
        Me.ButtonPulisciPoli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPulisciPoli.Location = New System.Drawing.Point(1472, 55)
        Me.ButtonPulisciPoli.Name = "ButtonPulisciPoli"
        Me.ButtonPulisciPoli.Size = New System.Drawing.Size(174, 48)
        Me.ButtonPulisciPoli.TabIndex = 41
        Me.ButtonPulisciPoli.Text = "PulisciPoli"
        Me.ButtonPulisciPoli.UseVisualStyleBackColor = True
        '
        'ButtonTunnelLavaggio
        '
        Me.ButtonTunnelLavaggio.Enabled = False
        Me.ButtonTunnelLavaggio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTunnelLavaggio.Location = New System.Drawing.Point(933, 55)
        Me.ButtonTunnelLavaggio.Name = "ButtonTunnelLavaggio"
        Me.ButtonTunnelLavaggio.Size = New System.Drawing.Size(174, 48)
        Me.ButtonTunnelLavaggio.TabIndex = 38
        Me.ButtonTunnelLavaggio.Text = "Tunnel Lavaggio"
        Me.ButtonTunnelLavaggio.UseVisualStyleBackColor = True
        '
        'ButtonPosaTogliRampe
        '
        Me.ButtonPosaTogliRampe.Enabled = False
        Me.ButtonPosaTogliRampe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPosaTogliRampe.Location = New System.Drawing.Point(753, 55)
        Me.ButtonPosaTogliRampe.Name = "ButtonPosaTogliRampe"
        Me.ButtonPosaTogliRampe.Size = New System.Drawing.Size(174, 48)
        Me.ButtonPosaTogliRampe.TabIndex = 37
        Me.ButtonPosaTogliRampe.Text = "Posa/Togli rampe"
        Me.ButtonPosaTogliRampe.UseVisualStyleBackColor = True
        '
        'Button2Riempimento
        '
        Me.Button2Riempimento.Enabled = False
        Me.Button2Riempimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2Riempimento.Location = New System.Drawing.Point(574, 55)
        Me.Button2Riempimento.Name = "Button2Riempimento"
        Me.Button2Riempimento.Size = New System.Drawing.Size(174, 48)
        Me.Button2Riempimento.TabIndex = 36
        Me.Button2Riempimento.Text = "2°Riempimento"
        Me.Button2Riempimento.UseVisualStyleBackColor = True
        '
        'ButtonDiluitore
        '
        Me.ButtonDiluitore.Enabled = False
        Me.ButtonDiluitore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDiluitore.Location = New System.Drawing.Point(394, 55)
        Me.ButtonDiluitore.Name = "ButtonDiluitore"
        Me.ButtonDiluitore.Size = New System.Drawing.Size(174, 48)
        Me.ButtonDiluitore.TabIndex = 35
        Me.ButtonDiluitore.Text = "Diluitore"
        Me.ButtonDiluitore.UseVisualStyleBackColor = True
        '
        'ButtonRovesciatore
        '
        Me.ButtonRovesciatore.Enabled = False
        Me.ButtonRovesciatore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRovesciatore.Location = New System.Drawing.Point(214, 55)
        Me.ButtonRovesciatore.Name = "ButtonRovesciatore"
        Me.ButtonRovesciatore.Size = New System.Drawing.Size(174, 48)
        Me.ButtonRovesciatore.TabIndex = 34
        Me.ButtonRovesciatore.Text = "Rovesciatore"
        Me.ButtonRovesciatore.UseVisualStyleBackColor = True
        '
        'ButtonRotatore
        '
        Me.ButtonRotatore.Enabled = False
        Me.ButtonRotatore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRotatore.Location = New System.Drawing.Point(34, 55)
        Me.ButtonRotatore.Name = "ButtonRotatore"
        Me.ButtonRotatore.Size = New System.Drawing.Size(174, 48)
        Me.ButtonRotatore.TabIndex = 33
        Me.ButtonRotatore.Text = "Rotatore e spintore 2°riemp"
        Me.ButtonRotatore.UseVisualStyleBackColor = True
        '
        'ButtonLineaGeneraleCarica
        '
        Me.ButtonLineaGeneraleCarica.Enabled = False
        Me.ButtonLineaGeneraleCarica.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLineaGeneraleCarica.Location = New System.Drawing.Point(679, 6)
        Me.ButtonLineaGeneraleCarica.Name = "ButtonLineaGeneraleCarica"
        Me.ButtonLineaGeneraleCarica.Size = New System.Drawing.Size(339, 43)
        Me.ButtonLineaGeneraleCarica.TabIndex = 32
        Me.ButtonLineaGeneraleCarica.Text = "Linea Generale"
        Me.ButtonLineaGeneraleCarica.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(447, 250)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 13)
        Me.Label22.TabIndex = 83
        Me.Label22.Text = "ProduzioneSalvata"
        Me.Label22.Visible = False
        '
        'LabelProduzioneSalvata
        '
        Me.LabelProduzioneSalvata.AutoSize = True
        Me.LabelProduzioneSalvata.Location = New System.Drawing.Point(563, 250)
        Me.LabelProduzioneSalvata.Name = "LabelProduzioneSalvata"
        Me.LabelProduzioneSalvata.Size = New System.Drawing.Size(21, 13)
        Me.LabelProduzioneSalvata.TabIndex = 84
        Me.LabelProduzioneSalvata.Text = "No"
        Me.LabelProduzioneSalvata.UseWaitCursor = True
        Me.LabelProduzioneSalvata.Visible = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(444, 218)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(96, 13)
        Me.Label23.TabIndex = 85
        Me.Label23.Text = "ProduzioneSalvata"
        Me.Label23.Visible = False
        '
        'TextBoxTimbratura
        '
        Me.TextBoxTimbratura.Location = New System.Drawing.Point(748, 36)
        Me.TextBoxTimbratura.Name = "TextBoxTimbratura"
        Me.TextBoxTimbratura.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTimbratura.TabIndex = 86
        '
        'DataGridViewManPower
        '
        Me.DataGridViewManPower.AllowUserToResizeRows = False
        Me.DataGridViewManPower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewManPower.Location = New System.Drawing.Point(574, 58)
        Me.DataGridViewManPower.Name = "DataGridViewManPower"
        Me.DataGridViewManPower.Size = New System.Drawing.Size(370, 173)
        Me.DataGridViewManPower.TabIndex = 87
        '
        'LabelCognome
        '
        Me.LabelCognome.AutoSize = True
        Me.LabelCognome.Location = New System.Drawing.Point(363, 109)
        Me.LabelCognome.Name = "LabelCognome"
        Me.LabelCognome.Size = New System.Drawing.Size(52, 13)
        Me.LabelCognome.TabIndex = 89
        Me.LabelCognome.Text = "Cognome"
        Me.LabelCognome.Visible = False
        '
        'LabelNome
        '
        Me.LabelNome.AutoSize = True
        Me.LabelNome.Location = New System.Drawing.Point(465, 109)
        Me.LabelNome.Name = "LabelNome"
        Me.LabelNome.Size = New System.Drawing.Size(35, 13)
        Me.LabelNome.TabIndex = 90
        Me.LabelNome.Text = "Nome"
        Me.LabelNome.Visible = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(575, 39)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(132, 13)
        Me.Label24.TabIndex = 91
        Me.Label24.Text = "Personale Caricato in linea"
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Location = New System.Drawing.Point(571, 236)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(134, 13)
        Me.LabelStatus.TabIndex = 92
        Me.LabelStatus.Text = "Registrazione dati in STOP"
        '
        'ButtonScegliLancioProduzione
        '
        Me.ButtonScegliLancioProduzione.Location = New System.Drawing.Point(1052, 231)
        Me.ButtonScegliLancioProduzione.Name = "ButtonScegliLancioProduzione"
        Me.ButtonScegliLancioProduzione.Size = New System.Drawing.Size(148, 23)
        Me.ButtonScegliLancioProduzione.TabIndex = 93
        Me.ButtonScegliLancioProduzione.Text = "Scegli Lancio Produzione"
        Me.ButtonScegliLancioProduzione.UseVisualStyleBackColor = True
        '
        'TabFormazione
        '
        Me.TabFormazione.Controls.Add(Me.ButtonCarrelloScarico)
        Me.TabFormazione.Controls.Add(Me.ButtonNastriScarico)
        Me.TabFormazione.Controls.Add(Me.ButtonNastriCarico)
        Me.TabFormazione.Controls.Add(Me.ButtonCarrelloCarico)
        Me.TabFormazione.Controls.Add(Me.ButtonRotatoreSpintore1)
        Me.TabFormazione.Controls.Add(Me.ButtonPosaRampeFormazione)
        Me.TabFormazione.Controls.Add(Me.ButtonPrimoRiempimento)
        Me.TabFormazione.Controls.Add(Me.ButtonInseritoreOcchioMagico)
        Me.TabFormazione.Controls.Add(Me.ButtonPinzaCarico)
        Me.TabFormazione.Controls.Add(Me.ButtonLineaGeneraleFormazione)
        Me.TabFormazione.Location = New System.Drawing.Point(4, 22)
        Me.TabFormazione.Name = "TabFormazione"
        Me.TabFormazione.Size = New System.Drawing.Size(1672, 144)
        Me.TabFormazione.TabIndex = 3
        Me.TabFormazione.Text = "Formazione"
        Me.TabFormazione.UseVisualStyleBackColor = True
        '
        'ButtonLineaGeneraleFormazione
        '
        Me.ButtonLineaGeneraleFormazione.Enabled = False
        Me.ButtonLineaGeneraleFormazione.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLineaGeneraleFormazione.Location = New System.Drawing.Point(635, 3)
        Me.ButtonLineaGeneraleFormazione.Name = "ButtonLineaGeneraleFormazione"
        Me.ButtonLineaGeneraleFormazione.Size = New System.Drawing.Size(339, 43)
        Me.ButtonLineaGeneraleFormazione.TabIndex = 32
        Me.ButtonLineaGeneraleFormazione.Text = "Linea Generale"
        Me.ButtonLineaGeneraleFormazione.UseVisualStyleBackColor = True
        '
        'ButtonPinzaCarico
        '
        Me.ButtonPinzaCarico.Enabled = False
        Me.ButtonPinzaCarico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPinzaCarico.Location = New System.Drawing.Point(8, 48)
        Me.ButtonPinzaCarico.Name = "ButtonPinzaCarico"
        Me.ButtonPinzaCarico.Size = New System.Drawing.Size(174, 48)
        Me.ButtonPinzaCarico.TabIndex = 33
        Me.ButtonPinzaCarico.Text = "Pinza carico manuale"
        Me.ButtonPinzaCarico.UseVisualStyleBackColor = True
        '
        'ButtonInseritoreOcchioMagico
        '
        Me.ButtonInseritoreOcchioMagico.Enabled = False
        Me.ButtonInseritoreOcchioMagico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInseritoreOcchioMagico.Location = New System.Drawing.Point(188, 48)
        Me.ButtonInseritoreOcchioMagico.Name = "ButtonInseritoreOcchioMagico"
        Me.ButtonInseritoreOcchioMagico.Size = New System.Drawing.Size(174, 48)
        Me.ButtonInseritoreOcchioMagico.TabIndex = 34
        Me.ButtonInseritoreOcchioMagico.Text = "Inseritore occhio magico"
        Me.ButtonInseritoreOcchioMagico.UseVisualStyleBackColor = True
        '
        'ButtonPrimoRiempimento
        '
        Me.ButtonPrimoRiempimento.Enabled = False
        Me.ButtonPrimoRiempimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrimoRiempimento.Location = New System.Drawing.Point(368, 48)
        Me.ButtonPrimoRiempimento.Name = "ButtonPrimoRiempimento"
        Me.ButtonPrimoRiempimento.Size = New System.Drawing.Size(174, 48)
        Me.ButtonPrimoRiempimento.TabIndex = 35
        Me.ButtonPrimoRiempimento.Text = "1° riempimento"
        Me.ButtonPrimoRiempimento.UseVisualStyleBackColor = True
        '
        'ButtonPosaRampeFormazione
        '
        Me.ButtonPosaRampeFormazione.Enabled = False
        Me.ButtonPosaRampeFormazione.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPosaRampeFormazione.Location = New System.Drawing.Point(548, 48)
        Me.ButtonPosaRampeFormazione.Name = "ButtonPosaRampeFormazione"
        Me.ButtonPosaRampeFormazione.Size = New System.Drawing.Size(174, 48)
        Me.ButtonPosaRampeFormazione.TabIndex = 36
        Me.ButtonPosaRampeFormazione.Text = "Posa Rampe Formazione"
        Me.ButtonPosaRampeFormazione.UseVisualStyleBackColor = True
        '
        'ButtonRotatoreSpintore1
        '
        Me.ButtonRotatoreSpintore1.Enabled = False
        Me.ButtonRotatoreSpintore1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRotatoreSpintore1.Location = New System.Drawing.Point(728, 48)
        Me.ButtonRotatoreSpintore1.Name = "ButtonRotatoreSpintore1"
        Me.ButtonRotatoreSpintore1.Size = New System.Drawing.Size(174, 48)
        Me.ButtonRotatoreSpintore1.TabIndex = 37
        Me.ButtonRotatoreSpintore1.Text = "Rotatore e Spintore 1°riemp"
        Me.ButtonRotatoreSpintore1.UseVisualStyleBackColor = True
        '
        'ButtonCarrelloCarico
        '
        Me.ButtonCarrelloCarico.Enabled = False
        Me.ButtonCarrelloCarico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCarrelloCarico.Location = New System.Drawing.Point(908, 48)
        Me.ButtonCarrelloCarico.Name = "ButtonCarrelloCarico"
        Me.ButtonCarrelloCarico.Size = New System.Drawing.Size(174, 48)
        Me.ButtonCarrelloCarico.TabIndex = 38
        Me.ButtonCarrelloCarico.Text = "Carrello carico"
        Me.ButtonCarrelloCarico.UseVisualStyleBackColor = True
        '
        'ButtonNastriCarico
        '
        Me.ButtonNastriCarico.Enabled = False
        Me.ButtonNastriCarico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNastriCarico.Location = New System.Drawing.Point(1088, 48)
        Me.ButtonNastriCarico.Name = "ButtonNastriCarico"
        Me.ButtonNastriCarico.Size = New System.Drawing.Size(174, 48)
        Me.ButtonNastriCarico.TabIndex = 39
        Me.ButtonNastriCarico.Text = "Nastri carico"
        Me.ButtonNastriCarico.UseVisualStyleBackColor = True
        '
        'ButtonNastriScarico
        '
        Me.ButtonNastriScarico.Enabled = False
        Me.ButtonNastriScarico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNastriScarico.Location = New System.Drawing.Point(548, 100)
        Me.ButtonNastriScarico.Name = "ButtonNastriScarico"
        Me.ButtonNastriScarico.Size = New System.Drawing.Size(174, 48)
        Me.ButtonNastriScarico.TabIndex = 40
        Me.ButtonNastriScarico.Text = "Nastri scarico"
        Me.ButtonNastriScarico.UseVisualStyleBackColor = True
        '
        'ButtonCarrelloScarico
        '
        Me.ButtonCarrelloScarico.Enabled = False
        Me.ButtonCarrelloScarico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCarrelloScarico.Location = New System.Drawing.Point(729, 100)
        Me.ButtonCarrelloScarico.Name = "ButtonCarrelloScarico"
        Me.ButtonCarrelloScarico.Size = New System.Drawing.Size(174, 48)
        Me.ButtonCarrelloScarico.TabIndex = 41
        Me.ButtonCarrelloScarico.Text = "Carrello scarico"
        Me.ButtonCarrelloScarico.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.ButtonScegliLancioProduzione)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.LabelNome)
        Me.Controls.Add(Me.LabelCognome)
        Me.Controls.Add(Me.TextBoxTimbratura)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.LabelProduzioneSalvata)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.LblPezziOgniImpulso)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.LblPathDatabase)
        Me.Controls.Add(Me.LabelUptime)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.LabelMinutiFermo)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.ChartCausali)
        Me.Controls.Add(Me.ChartMacchine)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelContatoreProduzioneHidden)
        Me.Controls.Add(Me.TextBoxProduzione)
        Me.Controls.Add(Me.LblStatus)
        Me.Controls.Add(Me.ButtonRitentaConnessione)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.LblLineDescription)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.LblDepartmentDescription)
        Me.Controls.Add(Me.LblIdDepartment)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LblIdLinea)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.LabelNotaProduzione)
        Me.Controls.Add(Me.LabelPz2)
        Me.Controls.Add(Me.LabelPz)
        Me.Controls.Add(Me.LabelTime)
        Me.Controls.Add(Me.LabelGiustificativoDopoValue)
        Me.Controls.Add(Me.LabelRipartenzaDopoValue)
        Me.Controls.Add(Me.LabelFermataDopoValue)
        Me.Controls.Add(Me.LabelGiustificativoDopo)
        Me.Controls.Add(Me.LabelRipartenzaDopo)
        Me.Controls.Add(Me.LabelFermataDopo)
        Me.Controls.Add(Me.PictureBoxFiamm)
        Me.Controls.Add(Me.ButtonStop)
        Me.Controls.Add(Me.ButtonStart)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LabelContatoreGiustificativo)
        Me.Controls.Add(Me.LabelIdFermo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LabelContatoreRipartenza)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabelProduzioneNascosto)
        Me.Controls.Add(Me.LabelCurrentTime)
        Me.Controls.Add(Me.LabelContatoreFermata)
        Me.Controls.Add(Me.LabelProduzioneOldNascosto)
        Me.Controls.Add(Me.LabelContatoreProduzione)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ChartProduzioneOraria)
        Me.Controls.Add(Me.Tab)
        Me.Controls.Add(Me.DataGridViewManPower)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Rilevazione Dati Produzione"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBoxFiamm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartProduzioneOraria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ChartMacchine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartCausali, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab.ResumeLayout(False)
        Me.TabStiratura.ResumeLayout(False)
        Me.TabMontaggio.ResumeLayout(False)
        Me.TabCarica.ResumeLayout(False)
        CType(Me.DataGridViewManPower, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabFormazione.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialPortArduino As System.IO.Ports.SerialPort
    Friend WithEvents ButtonSvolgitore As System.Windows.Forms.Button
    Friend WithEvents ButtonEspansore As System.Windows.Forms.Button
    Friend WithEvents ButtonTabBlanker As System.Windows.Forms.Button
    Friend WithEvents ButtonMolazza As System.Windows.Forms.Button
    Friend WithEvents ButtonSpalmatrice As System.Windows.Forms.Button
    Friend WithEvents ButtonDivider As System.Windows.Forms.Button
    Friend WithEvents ButtonTunnel As System.Windows.Forms.Button
    Friend WithEvents ButtonImpilatore As System.Windows.Forms.Button
    Friend WithEvents ButtonPaletizzatore As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelContatoreProduzione As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents TimerForRoutineRegistrationData As System.Windows.Forms.Timer
    Friend WithEvents LabelProduzioneOldNascosto As System.Windows.Forms.Label
    Friend WithEvents LabelContatoreFermata As System.Windows.Forms.Label
    Friend WithEvents LabelCurrentTime As System.Windows.Forms.Label
    Friend WithEvents LabelProduzioneNascosto As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabelContatoreRipartenza As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents OvalShapeGreen As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents OvalShapeYellow As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents OvalShapeRed As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LabelIdFermo As System.Windows.Forms.Label
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LabelContatoreGiustificativo As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ButtonStart As System.Windows.Forms.Button
    Friend WithEvents ButtonStop As System.Windows.Forms.Button
    Friend WithEvents TimerMain As System.Windows.Forms.Timer
    Friend WithEvents PictureBoxFiamm As System.Windows.Forms.PictureBox
    Friend WithEvents LabelFermataDopo As System.Windows.Forms.Label
    Friend WithEvents LabelRipartenzaDopo As System.Windows.Forms.Label
    Friend WithEvents LabelGiustificativoDopo As System.Windows.Forms.Label
    Friend WithEvents LabelFermataDopoValue As System.Windows.Forms.Label
    Friend WithEvents LabelRipartenzaDopoValue As System.Windows.Forms.Label
    Friend WithEvents LabelGiustificativoDopoValue As System.Windows.Forms.Label
    Friend WithEvents ButtonLineaGenerale As System.Windows.Forms.Button
    Friend WithEvents LabelTime As System.Windows.Forms.Label
    Friend WithEvents LabelPz As System.Windows.Forms.Label
    Friend WithEvents LabelPz2 As System.Windows.Forms.Label
    Friend WithEvents LabelNotaProduzione As System.Windows.Forms.Label
    Friend WithEvents ChartProduzioneOraria As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LblIdLinea As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LblIdDepartment As System.Windows.Forms.Label
    Friend WithEvents LblDepartmentDescription As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LblLineDescription As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ButtonRitentaConnessione As System.Windows.Forms.Button
    Friend WithEvents LblStatus As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents VisualizzaFermateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisualizzaProduzioneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBoxProduzione As System.Windows.Forms.TextBox
    Friend WithEvents LabelContatoreProduzioneHidden As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AnalisiFermiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtilityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChartMacchine As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents ChartCausali As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents LabelMinutiFermo As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents LabelUptime As System.Windows.Forms.Label
    Friend WithEvents LblPathDatabase As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents LblPezziOgniImpulso As System.Windows.Forms.Label
    Friend WithEvents Tab As System.Windows.Forms.TabControl
    Friend WithEvents TabStiratura As System.Windows.Forms.TabPage
    Friend WithEvents TabMontaggio As System.Windows.Forms.TabPage
    Friend WithEvents TabCarica As System.Windows.Forms.TabPage
    Friend WithEvents ButtonLineaGeneraleMontaggio As System.Windows.Forms.Button
    Friend WithEvents ButtonCOS As System.Windows.Forms.Button
    Friend WithEvents ButtonBuffer As System.Windows.Forms.Button
    Friend WithEvents ButtonImbustatrice2 As System.Windows.Forms.Button
    Friend WithEvents ButtonImbustatrice1 As System.Windows.Forms.Button
    Friend WithEvents ButtonTranciasetti As System.Windows.Forms.Button
    Friend WithEvents ButtonSaldapolari As System.Windows.Forms.Button
    Friend WithEvents ButtonTermosaldatrice As System.Windows.Forms.Button
    Friend WithEvents ButtonPosaCoperchi As System.Windows.Forms.Button
    Friend WithEvents ButtonProvaCorti2 As System.Windows.Forms.Button
    Friend WithEvents ButtonPuntatrice As System.Windows.Forms.Button
    Friend WithEvents ButtonProvaCorti1 As System.Windows.Forms.Button
    Friend WithEvents ButtonMarcatore As System.Windows.Forms.Button
    Friend WithEvents ButtonProvaAltezzaPolari As System.Windows.Forms.Button
    Friend WithEvents ButtonProvaPneumatica As System.Windows.Forms.Button
    Friend WithEvents ButtonPinzaPaletizzatore As System.Windows.Forms.Button
    Friend WithEvents ButtonRobot As System.Windows.Forms.Button
    Friend WithEvents ButtonNastriTrasportatori As System.Windows.Forms.Button
    Friend WithEvents ButtonNastriTrasporto As System.Windows.Forms.Button
    Friend WithEvents ButtonScaricoManuale As System.Windows.Forms.Button
    Friend WithEvents ButtonRobotCarica As System.Windows.Forms.Button
    Friend WithEvents ButtonControlloVestizione As System.Windows.Forms.Button
    Friend WithEvents ButtonVestizione As System.Windows.Forms.Button
    Friend WithEvents ButtonMarcatoreCarica As System.Windows.Forms.Button
    Friend WithEvents ButtonControlloLivelli As System.Windows.Forms.Button
    Friend WithEvents ButtonScaricaRapida As System.Windows.Forms.Button
    Friend WithEvents ButtonTappatrice As System.Windows.Forms.Button
    Friend WithEvents ButtonPulisciPoli As System.Windows.Forms.Button
    Friend WithEvents ButtonTunnelLavaggio As System.Windows.Forms.Button
    Friend WithEvents ButtonPosaTogliRampe As System.Windows.Forms.Button
    Friend WithEvents Button2Riempimento As System.Windows.Forms.Button
    Friend WithEvents ButtonDiluitore As System.Windows.Forms.Button
    Friend WithEvents ButtonRovesciatore As System.Windows.Forms.Button
    Friend WithEvents ButtonRotatore As System.Windows.Forms.Button
    Friend WithEvents ButtonLineaGeneraleCarica As System.Windows.Forms.Button
    Friend WithEvents ButtonAKSI As System.Windows.Forms.Button
    Friend WithEvents ButtonDielettrico As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents LabelProduzioneSalvata As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTimbratura As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewManPower As System.Windows.Forms.DataGridView
    Friend WithEvents LabelCognome As System.Windows.Forms.Label
    Friend WithEvents LabelNome As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents LabelStatus As System.Windows.Forms.Label
    Friend WithEvents ButtonScegliLancioProduzione As System.Windows.Forms.Button
    Friend WithEvents TabFormazione As System.Windows.Forms.TabPage
    Friend WithEvents ButtonLineaGeneraleFormazione As System.Windows.Forms.Button
    Friend WithEvents ButtonCarrelloScarico As System.Windows.Forms.Button
    Friend WithEvents ButtonNastriScarico As System.Windows.Forms.Button
    Friend WithEvents ButtonNastriCarico As System.Windows.Forms.Button
    Friend WithEvents ButtonCarrelloCarico As System.Windows.Forms.Button
    Friend WithEvents ButtonRotatoreSpintore1 As System.Windows.Forms.Button
    Friend WithEvents ButtonPosaRampeFormazione As System.Windows.Forms.Button
    Friend WithEvents ButtonPrimoRiempimento As System.Windows.Forms.Button
    Friend WithEvents ButtonInseritoreOcchioMagico As System.Windows.Forms.Button
    Friend WithEvents ButtonPinzaCarico As System.Windows.Forms.Button

End Class
