Imports System.Configuration
Imports System.Data.OleDb
Imports System.Data.SqlClient


Public Class FormMacchina

    Dim eid As String = ""
    Dim Mid As String = ""
    Dim MascDesc As String = ""
    Public Sub New(ByVal empid As String, ByVal Machineid As String, ByVal MaschineDesc As String)
        InitializeComponent()
        eid = empid
        Mid = Machineid
        MascDesc = MaschineDesc
    End Sub

    Private Sub RegistraCausale(Id As String, Desc As String)
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

        myCmd2.CommandText = ("UPDATE Fermi SET IdMacchina=" & Mid & ",DescMacchina='" & MascDesc & "',IdFermo=" & Id & ",DescFermo='" & Desc & "',DescFermoEsteso='" & TextBoxMacchina.Text & "' WHERE (Id=" & Form1.LabelIdFermo.Text & " AND IdReparto=" & Form1.LblIdDepartment.Text & " AND IdLinea=" & Form1.LblIdLinea.Text & ")")
        myCmd2.Connection.Open()
        Dim numberOfRow As Int16 = myCmd2.ExecuteNonQuery()
        myCmd2.Connection.Close()
        '--------------------------------
        'Dim fileAccess As String = ConfigurationManager.ConnectionStrings("ArduinoFermi.My.MySettings.DatabaseFermiConnectionString").ConnectionString
        'Dim conAccess = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & fileAccess & ";")
        'Dim queryAccess2 As String = "SELECT DataInizioFermo FROM Fermi WHERE Id=" & eid.ToString() & ""
        'Dim cmd2 As New OleDb.OleDbCommand(queryAccess2, conAccess)
        'Dim DataInizio As Date
        'conAccess.Open()
        'DataInizio = cmd2.ExecuteScalar()
        'Dim queryAccess As String
        'queryAccess = ("UPDATE Fermi SET IdMacchina=" & Mid & ",DescMacchina='" & MascDesc & "',IdFermo=" & Id & ",DescFermo='" & Desc & "',DescFermoEsteso='" & TextBoxMacchina.Text & "' WHERE (Id=" & Form1.LabelIdFermo.Text & " AND IdReparto=" & Form1.LblIdDepartment.Text & " AND IdLinea=" & Form1.LblIdLinea.Text & ")")
        'Dim cmd As New OleDb.OleDbCommand(queryAccess, conAccess)
        'Dim numberOfRow As Int16 = cmd.ExecuteNonQuery()
        'conAccess.Close()
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
        'Disable the button of formazione
        Form1.ButtonLineaGeneraleFormazione.Enabled = False
        Form1.ButtonPinzaCarico.Enabled = False
        Form1.ButtonInseritoreOcchioMagico.Enabled = False
        Form1.ButtonPrimoRiempimento.Enabled = False
        Form1.ButtonPosaRampeFormazione.Enabled = False
        Form1.ButtonRotatoreSpintore1.Enabled = False
        Form1.ButtonCarrelloCarico.Enabled = False
        Form1.ButtonNastriCarico.Enabled = False
        Form1.ButtonNastriScarico.Enabled = False
        Form1.ButtonCarrelloScarico.Enabled = False
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
            'If ans = MsgBoxResult.Retry Then
            'Timer1.Start()
            'End If
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
        '-----------------------
        ''We disable the button of the main form
        'Form1.ButtonLineaGenerale.Enabled = False
        'Form1.ButtonSvolgitore.Enabled = False
        'Form1.ButtonEspansore.Enabled = False
        'Form1.ButtonTabBlanker.Enabled = False
        'Form1.ButtonMolazza.Enabled = False
        'Form1.ButtonSpalmatrice.Enabled = False
        'Form1.ButtonDivider.Enabled = False
        'Form1.ButtonTunnel.Enabled = False
        'Form1.ButtonImpilatore.Enabled = False
        'Form1.ButtonPaletizzatore.Enabled = False
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

    Private Sub ButtonInceppamento_Click(sender As Object, e As EventArgs) Handles ButtonInceppamento.Click
        RegistraCausale("40", "Inceppamento")
        UpdateForm1()
        Me.Close()
    End Sub

    Private Sub ButtonInterventoManutenzione_Click(sender As Object, e As EventArgs) Handles ButtonInterventoManutenzione.Click
        RegistraCausale("45", "Intervento manutenzione")
        UpdateForm1()
        Me.Close()
    End Sub

    Private Sub ButtonRegolazione_Click(sender As Object, e As EventArgs) Handles ButtonRegolazione.Click
        RegistraCausale("80", "Regolazione")
        UpdateForm1()
        Me.Close()
    End Sub
End Class