Imports System.Configuration
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class FormLineaGenerale
    Dim eid As String = ""
    Public Sub New(ByVal empid As String)
        InitializeComponent()
        eid = empid
    End Sub

    Private Sub RegistraCausale(Id As String, Desc As String)

        'Dim fileAccess As String = ConfigurationManager.ConnectionStrings("ArduinoFermi.My.MySettings.DatabaseFermiConnectionString").ConnectionString
        Dim myConn = New SqlConnection(Form1.LblPathDatabase.Text)
        Dim myCmd As SqlCommand
        myCmd = myConn.CreateCommand()
        myCmd.CommandText = "SELECT DataInizioFermo FROM Fermi WHERE Id=" & eid.ToString() & ""

        Dim DataInizio As Date
        myCmd.Connection.Open()
        DataInizio = myCmd.ExecuteScalar()
        myCmd.Connection.Close()
        Dim myCmd2 As SqlCommand
        myCmd2 = myConn.CreateCommand()
        myCmd2.CommandText = ("UPDATE Fermi SET IdMacchina=0,DescMacchina='Linea Generale',IdFermo=" & Id & ",DescFermo='" & Desc & "',DescFermoEsteso='" & TextBoxLineaGeneraleStiratura.Text & "' WHERE (Id=" & Form1.LabelIdFermo.Text & " AND IdReparto=" & Form1.LblIdDepartment.Text & " AND IdLinea=" & Form1.LblIdLinea.Text & ")")
        myCmd2.Connection.Open()
        Dim numberOfRow As Int16 = myCmd2.ExecuteNonQuery()
        myCmd2.Connection.Close()
        End Sub

    Sub UpdateForm1()
        'We disable the button of the main form
        Form1.ButtonLineaGenerale.Enabled = False
        Form1.ButtonSvolgitore.Enabled = False
        Form1.ButtonEspansore.Enabled = False
        Form1.ButtonTabBlanker.Enabled = False
        Form1.ButtonMolazza.Enabled = False
        Form1.ButtonSpalmatrice.Enabled = False
        Form1.ButtonDivider.Enabled = False
        Form1.ButtonTunnel.Enabled = False
        Form1.ButtonImpilatore.Enabled = False
        Form1.ButtonPaletizzatore.Enabled = False
        'Disable the button of Montaggio
        Form1.ButtonLineaGeneraleMontaggio.Enabled = False
        Form1.ButtonTranciasetti.Enabled = False
        Form1.ButtonImbustatrice1.Enabled = False
        Form1.ButtonImbustatrice2.Enabled = False
        Form1.ButtonBuffer.Enabled = False
        Form1.ButtonCOS.Enabled = False
        Form1.ButtonProvaCorti1.Enabled = False
        Form1.ButtonPuntatrice.Enabled = False
        Form1.ButtonProvaCorti2.Enabled = False
        Form1.ButtonPosaCoperchi.Enabled = False
        Form1.ButtonTermosaldatrice.Enabled = False
        Form1.ButtonSaldapolari.Enabled = False
        Form1.ButtonProvaPneumatica.Enabled = False
        Form1.ButtonProvaAltezzaPolari.Enabled = False
        Form1.ButtonMarcatore.Enabled = False
        Form1.ButtonPinzaPaletizzatore.Enabled = False
        Form1.ButtonRobot.Enabled = False
        Form1.ButtonNastriTrasportatori.Enabled = False
        'Disable the button of carica
        Form1.ButtonLineaGeneraleCarica.Enabled = False
        Form1.ButtonRotatore.Enabled = False
        Form1.ButtonRovesciatore.Enabled = False
        Form1.ButtonDiluitore.Enabled = False
        Form1.Button2Riempimento.Enabled = False
        Form1.ButtonPosaTogliRampe.Enabled = False
        Form1.ButtonTunnelLavaggio.Enabled = False
        Form1.ButtonControlloLivelli.Enabled = False
        Form1.ButtonTappatrice.Enabled = False
        Form1.ButtonPulisciPoli.Enabled = False
        Form1.ButtonScaricaRapida.Enabled = False
        Form1.ButtonDielettrico.Enabled = False
        Form1.ButtonAKSI.Enabled = False
        Form1.ButtonMarcatoreCarica.Enabled = False
        Form1.ButtonVestizione.Enabled = False
        Form1.ButtonControlloVestizione.Enabled = False
        Form1.ButtonRobotCarica.Enabled = False
        Form1.ButtonScaricoManuale.Enabled = False
        Form1.ButtonNastriTrasporto.Enabled = False
        'The we reset the counter
        Form1.LabelContatoreRipartenza.Text = "0"
        'Turn off the yellow lamp
        Try
            Form1.OvalShapeYellow.FillColor = Color.Silver
            'Form1.SerialPortArduino.Open()
            Form1.SerialPortArduino.Write("2")
            'Form1.SerialPortArduino.Close()
        Catch ex As Exception
            Dim ans = MsgBox("Arduino is not connected", MsgBoxStyle.RetryCancel)
            If ans = MsgBoxResult.Retry Then
                'Timer1.Start()
            End If
        End Try
        Form1.LabelContatoreGiustificativo.Text = "0"
        'We put the line in Marcia in the DB

        'Dim fileAccess As String = Form1.LblPathDatabase.Text
        Dim myConn = New SqlConnection(Form1.LblPathDatabase.Text)
        Dim myCmd As SqlCommand
        myCmd = myConn.CreateCommand()
        myCmd.CommandText = "UPDATE StatoLinee SET Stato='Marcia' WHERE (Id_Reparto=" & Form1.LblIdDepartment.Text & " AND Id_Linea=" & Form1.LblIdLinea.Text & ")"

        myCmd.Connection.Open()
        myCmd.ExecuteNonQuery()
        myCmd.Connection.Close()

    End Sub

    Private Sub ButtonPuliziaLinea_Click(sender As Object, e As EventArgs) Handles ButtonPuliziaLinea.Click
        RegistraCausale("1", "Pulizia Linea")
        UpdateForm1()
        Me.Close()
    End Sub

    Private Sub ButtonMancanzaOperatore_click(sender As Object, e As EventArgs) Handles ButtonMancanzaOperatore.Click
        RegistraCausale("2", "Mancanza operatore")
        UpdateForm1()
        Me.Close()
    End Sub

    Private Sub ButtonSciopero_Click(sender As Object, e As EventArgs) Handles ButtonSciopero.Click
        RegistraCausale("3", "Assem.sind. / Sciopero")
        UpdateForm1()
        Me.Close()
    End Sub

    Private Sub ButtonAttesaManutentore_Click(sender As Object, e As EventArgs) Handles ButtonAttesaManutentore.Click
        RegistraCausale("4", "Attesa manutentore")
        UpdateForm1()
        Me.Close()
    End Sub

    Private Sub ButtonAvvioLinea_Click(sender As Object, e As EventArgs) Handles ButtonAvvioLinea.Click
        RegistraCausale("5", "Accensione / Avvio Linea")
        UpdateForm1()
        Me.Close()
    End Sub

    Private Sub ButtonRecuperoMensa_Click(sender As Object, e As EventArgs) Handles ButtonRecuperoMensa.Click
        RegistraCausale("6", "Mancato recupero pausa mensa")
        UpdateForm1()
        Me.Close()
    End Sub


    Private Sub ButtonMancanzaLamierino_Click(sender As Object, e As EventArgs) Handles ButtonMancanzaLamierino.Click
        RegistraCausale("10", "Mancanza lamierino")
        UpdateForm1()
        Me.Close()
    End Sub

    Private Sub ButtonMancanzaImpasto_Click(sender As Object, e As EventArgs) Handles ButtonMancanzaImpasto.Click
        RegistraCausale("11", "Mancanza impasto")
        UpdateForm1()
        Me.Close()
    End Sub

    Private Sub ButtonMancanzaAcido_Click(sender As Object, e As EventArgs) Handles ButtonMancanzaAcido.Click
        RegistraCausale("12", "Mancanza acido solf.")
        UpdateForm1()
        Me.Close()
    End Sub

    Private Sub ButtonMancanzaOssido_Click(sender As Object, e As EventArgs) Handles ButtonMancanzaOssido.Click
        RegistraCausale("13", "Mancanza ossido")
        UpdateForm1()
        Me.Close()
    End Sub


    Private Sub ButtonCambioTipo_Click(sender As Object, e As EventArgs) Handles ButtonCambioTipo.Click
        RegistraCausale("20", "Cambio tipo produz.")
        UpdateForm1()
        Me.Close()
    End Sub

    Private Sub ButtonCambioPallet_Click(sender As Object, e As EventArgs) Handles ButtonCambioPallet.Click
        RegistraCausale("21", "Cambio pallet")
        UpdateForm1()
        Me.Close()
    End Sub

    Private Sub ButtonCambioCoil_Click(sender As Object, e As EventArgs) Handles ButtonCambioCoil.Click
        RegistraCausale("22", "Cambio coil")
        UpdateForm1()
        Me.Close()
    End Sub

    Private Sub ButtonCambioCarta_Click(sender As Object, e As EventArgs) Handles ButtonCambioCarta.Click
        RegistraCausale("23", "Cambio carta")
        UpdateForm1()
        Me.Close()
    End Sub

    Private Sub ButtonCambioTappeto_Click(sender As Object, e As EventArgs) Handles ButtonCambioTappeto.Click
        RegistraCausale("24", "Cambio tappeto")
        UpdateForm1()
        Me.Close()
    End Sub

    Private Sub ButtonMancanzaCavalletti_Click(sender As Object, e As EventArgs) Handles ButtonMancanzaCavalletti.Click
        RegistraCausale("25", "Mancanza cavalletti")
        UpdateForm1()
        Me.Close()
    End Sub


    Private Sub ButtonRotturaGriglia_Click(sender As Object, e As EventArgs) Handles ButtonRotturaGriglia.Click
        RegistraCausale("26", "Rottura griglia")
        UpdateForm1()
        Me.Close()
    End Sub

    Private Sub ButtonMancanzaEnergiaElettrica_Click(sender As Object, e As EventArgs) Handles ButtonMancanzaEnergiaElettrica.Click
        RegistraCausale("30", "Manc. energia elettrica")
        UpdateForm1()
        Me.Close()
    End Sub

    Private Sub ButtonMancanzaAriaCompressa_Click(sender As Object, e As EventArgs) Handles ButtonMancanzaAriaCompressa.Click
        RegistraCausale("31", "Manc. aria compressa")
        UpdateForm1()
        Me.Close()
    End Sub

    Private Sub ButtonMancanzaH20_Click(sender As Object, e As EventArgs) Handles ButtonMancanzaH20.Click
        RegistraCausale("32", "Mancanza H2O Demi")
        UpdateForm1()
        Me.Close()
    End Sub

End Class