Imports System.Configuration
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class FormLineaGeneraleMontaggio

    Dim eid As String = ""
    Public Sub New(ByVal empid As String)
        InitializeComponent()
        eid = empid
    End Sub

    Sub UpdateForm1()
        'We disable the button of the main form
        Form1.ButtonLineaGeneraleMontaggio.Enabled = False
        Form1.ButtonTranciasetti.Enabled = False
        Form1.ButtonImbustatrice1.Enabled = False
        Form1.ButtonImbustatrice2.Enabled = False
        Form1.ButtonBuffer.Enabled = False
        Form1.ButtonCOS.Enabled = False
        Form1.ButtonProvaCorti1.Enabled = False
        Form1.ButtonPuntatrice.Enabled = False
        Form1.ButtonProvaCorti2.Enabled = False
        Form1.ButtonTermosaldatrice.Enabled = False
        Form1.ButtonPosaCoperchi.Enabled = False
        Form1.ButtonSaldapolari.Enabled = False
        Form1.ButtonProvaPneumatica.Enabled = False
        Form1.ButtonProvaAltezzaPolari.Enabled = False
        Form1.ButtonMarcatore.Enabled = False
        Form1.ButtonPinzaPaletizzatore.Enabled = False
        Form1.ButtonRobot.Enabled = False
        Form1.ButtonNastriTrasportatori.Enabled = False
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


        Dim myConn = New SqlConnection(Form1.LblPathDatabase.Text)
        Dim myCmd As SqlCommand
        myCmd = myConn.CreateCommand()

        myCmd.CommandText = "UPDATE StatoLinee SET Stato='Marcia' WHERE (Id_Reparto=" & Form1.LblIdDepartment.Text & " AND Id_Linea=" & Form1.LblIdLinea.Text & ")"

        myCmd.Connection.Open()
        myCmd.ExecuteNonQuery()
        myCmd.Connection.Close()
        '-------------------------
        ''We disable the button of the main form
        'Form1.ButtonLineaGeneraleMontaggio.Enabled = False
        'Form1.ButtonTranciasetti.Enabled = False
        'Form1.ButtonImbustatrice1.Enabled = False
        'Form1.ButtonImbustatrice2.Enabled = False
        'Form1.ButtonBuffer.Enabled = False
        'Form1.ButtonCOS.Enabled = False
        'Form1.ButtonProvaCorti1.Enabled = False
        'Form1.ButtonPuntatrice.Enabled = False
        'Form1.ButtonProvaCorti2.Enabled = False
        'Form1.ButtonTermosaldatrice.Enabled = False
        'Form1.ButtonPosaCoperchi.Enabled = False
        'Form1.ButtonSaldapolari.Enabled = False
        'Form1.ButtonProvaPneumatica.Enabled = False
        'Form1.ButtonProvaAltezzaPolari.Enabled = False
        'Form1.ButtonMarcatore.Enabled = False
        'Form1.ButtonPinzaPaletizzatore.Enabled = False
        'Form1.ButtonRobot.Enabled = False
        'Form1.ButtonNastriTrasportatori.Enabled = False
        ''Disable the button of Montaggio
        'Form1.ButtonLineaGeneraleMontaggio.Enabled = False
        'Form1.ButtonTranciasetti.Enabled = False
        'Form1.ButtonImbustatrice1.Enabled = False
        'Form1.ButtonImbustatrice2.Enabled = False
        'Form1.ButtonBuffer.Enabled = False
        'Form1.ButtonCOS.Enabled = False
        'Form1.ButtonProvaCorti1.Enabled = False
        'Form1.ButtonPuntatrice.Enabled = False
        'Form1.ButtonProvaCorti2.Enabled = False
        'Form1.ButtonPosaCoperchi.Enabled = False
        'Form1.ButtonTermosaldatrice.Enabled = False
        'Form1.ButtonSaldapolari.Enabled = False
        'Form1.ButtonProvaPneumatica.Enabled = False
        'Form1.ButtonProvaAltezzaPolari.Enabled = False
        'Form1.ButtonMarcatore.Enabled = False
        'Form1.ButtonPinzaPaletizzatore.Enabled = False
        'Form1.ButtonRobot.Enabled = False
        'Form1.ButtonNastriTrasportatori.Enabled = False
        ''Disable the button of carica
        'Form1.ButtonLineaGeneraleCarica.Enabled = False
        'Form1.ButtonRotatore.Enabled = False
        'Form1.ButtonRovesciatore.Enabled = False
        'Form1.ButtonDiluitore.Enabled = False
        'Form1.Button2Riempimento.Enabled = False
        'Form1.ButtonPosaTogliRampe.Enabled = False
        'Form1.ButtonTunnelLavaggio.Enabled = False
        'Form1.ButtonControlloLivelli.Enabled = False
        'Form1.ButtonTappatrice.Enabled = False
        'Form1.ButtonPulisciPoli.Enabled = False
        'Form1.ButtonScaricaRapida.Enabled = False
        'Form1.ButtonDielettrico.Enabled = False
        'Form1.ButtonAKSI.Enabled = False
        'Form1.ButtonMarcatoreCarica.Enabled = False
        'Form1.ButtonVestizione.Enabled = False
        'Form1.ButtonControlloVestizione.Enabled = False
        'Form1.ButtonRobotCarica.Enabled = False
        'Form1.ButtonScaricoManuale.Enabled = False
        'Form1.ButtonNastriTrasporto.Enabled = False
        ''The we reset the counter
        'Form1.LabelContatoreRipartenza.Text = "0"
        ''Turn off the yellow lamp
        'Try
        '    Form1.OvalShapeYellow.FillColor = Color.Silver
        '    Form1.SerialPortArduino.Open()
        '    Form1.SerialPortArduino.Write("2")
        '    Form1.SerialPortArduino.Close()
        'Catch ex As Exception
        '    Dim ans = MsgBox("Arduino is not connected", MsgBoxStyle.RetryCancel)
        '    If ans = MsgBoxResult.Retry Then
        '        'Timer1.Start()
        '    End If
        'End Try
        'Form1.LabelContatoreGiustificativo.Text = "0"
        ''We put the line in Marcia in the DB
        'Dim fileAccess As String = Form1.LblPathDatabase.Text
        'Dim conAccess = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & fileAccess & ";")
        'Dim queryaccess5 As String = "UPDATE StatoLinee SET Stato='Marcia' WHERE (Id_Reparto=" & Form1.LblIdDepartment.Text & " AND Id_Linea=" & Form1.LblIdLinea.Text & ")"
        'Dim cmd5 As New OleDbCommand(queryaccess5, conAccess)
        'conAccess.Open()
        'cmd5.ExecuteNonQuery()
        'conAccess.Close()
    End Sub

    Private Sub RegistraCausale(Id As String, Desc As String)

        Dim myConn = New SqlConnection(Form1.LblPathDatabase.Text)
        Dim myCmd As SqlCommand
        myCmd = myConn.CreateCommand()

        myCmd.CommandText = "SELECT DataInizioFermo FROM Fermi WHERE Id=" & eid.ToString() & ""
        myCmd.Connection.Open()

        Dim DataInizio As Date

        DataInizio = myCmd.ExecuteScalar()
        myCmd.Connection.Close()

        Dim myCmd2 As SqlCommand
        myCmd2 = myConn.CreateCommand()

        myCmd2.CommandText = ("UPDATE Fermi SET IdMacchina=0,DescMacchina='Linea Generale',IdFermo=" & Id & ",DescFermo='" & Desc & "',DescFermoEsteso='" & TextBoxLineaGeneraleMontaggio.Text & "' WHERE (Id=" & Form1.LabelIdFermo.Text & " AND IdReparto=" & Form1.LblIdDepartment.Text & " AND IdLinea=" & Form1.LblIdLinea.Text & ")")
        myCmd2.Connection.Open()
        Dim numberOfRow As Int16 = myCmd2.ExecuteNonQuery()
        myCmd2.Connection.Close()
        '------------------
        'Dim fileAccess As String = ConfigurationManager.ConnectionStrings("ArduinoFermi.My.MySettings.DatabaseFermiConnectionString").ConnectionString
        'Dim conAccess = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & fileAccess & ";")
        'Dim queryAccess2 As String = "SELECT DataInizioFermo FROM Fermi WHERE Id=" & eid.ToString() & ""
        'Dim cmd2 As New OleDb.OleDbCommand(queryAccess2, conAccess)
        'Dim DataInizio As Date
        'conAccess.Open()
        'DataInizio = cmd2.ExecuteScalar()
        'Dim queryAccess As String
        'queryAccess = ("UPDATE Fermi SET IdMacchina=0,DescMacchina='Linea Generale',IdFermo=" & Id & ",DescFermo='" & Desc & "',DescFermoEsteso='" & TextBoxLineaGeneraleMontaggio.Text & "' WHERE (Id=" & Form1.LabelIdFermo.Text & " AND IdReparto=" & Form1.LblIdDepartment.Text & " AND IdLinea=" & Form1.LblIdLinea.Text & ")")
        'Dim cmd As New OleDb.OleDbCommand(queryAccess, conAccess)
        'Dim numberOfRow As Int16 = cmd.ExecuteNonQuery()
        'conAccess.Close()
    End Sub

    Private Sub ButtonPuliziaLinea_Click(sender As Object, e As EventArgs) Handles ButtonPuliziaLinea.Click
        RegistraCausale("1", "Pulizia Linea")
        UpdateForm1()
        Me.Close()
    End Sub

    Private Sub ButtonMancanzaOperatore_Click(sender As Object, e As EventArgs) Handles ButtonMancanzaOperatore.Click
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

    Private Sub ButtonMancanzaPiastre_Click(sender As Object, e As EventArgs) Handles ButtonMancanzaPiastre.Click
        RegistraCausale("10", "Mancanza piastre")
        UpdateForm1()
        Me.Close()
    End Sub

    Private Sub ButtonMancanzaSeparatore_Click(sender As Object, e As EventArgs) Handles ButtonMancanzaSeparatore.Click
        RegistraCausale("11", "Mancanza separatore")
        UpdateForm1()
        Me.Close()
    End Sub

    Private Sub ButtonMancanzaMonoblocco_Click(sender As Object, e As EventArgs) Handles ButtonMancanzaMonoblocco.Click
        RegistraCausale("12", "Mancanza monoblocco")
        UpdateForm1()
        Me.Close()
    End Sub

    Private Sub ButtonMancanzaCoperchio_Click(sender As Object, e As EventArgs) Handles ButtonMancanzaCoperchio.Click
        RegistraCausale("13", "Mancanza coperchio")
        UpdateForm1()
        Me.Close()
    End Sub

    Private Sub ButtonMancanzaPiombo_Click(sender As Object, e As EventArgs) Handles ButtonMancanzaPiombo.Click
        RegistraCausale("14", "Mancanza piombo")
        UpdateForm1()
        Me.Close()
    End Sub

    Private Sub ButtonMancanzaPallet_Click(sender As Object, e As EventArgs) Handles ButtonMancanzaPallet.Click
        RegistraCausale("15", "Mancanza pallet")
        UpdateForm1()
        Me.Close()
    End Sub

    Private Sub ButtonCambioTipo_Click(sender As Object, e As EventArgs) Handles ButtonCambioTipo.Click
        RegistraCausale("20", "Cambio tipo produz.")
        UpdateForm1()
        Me.Close()
    End Sub


    Private Sub ButtonCambioStampo_Click(sender As Object, e As EventArgs) Handles ButtonCambioStampo.Click
        RegistraCausale("21", "Cambio stampo")
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

    Private Sub ButtonMancanzaGas_Click(sender As Object, e As EventArgs) Handles ButtonMancanzaGas.Click
        RegistraCausale("33", "Mancanza Gas")
        UpdateForm1()
        Me.Close()
    End Sub

    Private Sub ButtonMancanzaAspirazione_Click(sender As Object, e As EventArgs) Handles ButtonMancanzaAspirazione.Click
        RegistraCausale("34", "Mancanza Aspirazione")
        UpdateForm1()
        Me.Close()
    End Sub
End Class