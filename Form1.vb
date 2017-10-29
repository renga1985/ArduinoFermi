Imports System.IO.Ports
Imports System.Data.OleDb
Imports System.Configuration
Imports System.IO
Imports System.Data.SqlClient

Public Class Form1
    Dim SerialPort As New IO.Ports.SerialPort

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        LabelContatoreFermata.Text = "0"
        RetriveParametersFromConfigTxt()
        SetUpSerialConnection()
        SerialPortArduino.Open()
        UpdateIstogram()
        UpdateChartCausali()
        UpdateStatistic()
        LoadProductionDataOfCurrentShift()
        CheckOperatorLoadedInLine()
        SendToArduino("6")
        LoadManpower()
    End Sub

    Private Sub LoadProductionDataOfCurrentShift()
        '-----------Section to retrive the last data of production into the db
        Dim myConn = New SqlConnection(LblPathDatabase.Text)
        Dim myCmd As SqlCommand
        'First we have to know in which shift we are
        Dim OraAttuale As DateTime
        OraAttuale = DateTime.Now()
        Dim dataDa As String
        Dim dataA As String

        If OraAttuale.Hour.ToString >= 6 And OraAttuale.Hour.ToString < 14 Then
            'Shift 1
            dataDa = DateTime.Now.Year.ToString & "-" & DateTime.Now.Day.ToString & "-" & DateTime.Now.Month.ToString & " 6:00:00"
            dataA = DateTime.Now.Year.ToString & "-" & DateTime.Now.Day.ToString & "-" & DateTime.Now.Month.ToString & " 13:59:59"

        End If

        If OraAttuale.Hour.ToString >= 14 And OraAttuale.Hour.ToString < 22 Then
            'Shift 2
            dataDa = DateTime.Now.Year.ToString & "-" & DateTime.Now.Day.ToString & "-" & DateTime.Now.Month.ToString & " 14:00:00"
            dataA = DateTime.Now.Year.ToString & "-" & DateTime.Now.Day.ToString & "-" & DateTime.Now.Month.ToString & " 21:59:59"

        End If

        If OraAttuale.Hour.ToString >= 22 And OraAttuale.Hour.ToString < 24 Then
            'Shift 3
            dataDa = DateTime.Now.Year.ToString & "-" & DateTime.Now.Day.ToString & "-" & DateTime.Now.Month.ToString & " 22:00:00"
            dataA = DateTime.Now.Year.ToString & "-" & DateTime.Now.Day.ToString & "-" & DateTime.Now.Month.ToString & " 23:59:59"

        End If

        If OraAttuale.Hour.ToString >= 0 And OraAttuale.Hour.ToString < 6 Then
            'Shift 3
            dataDa = DateTime.Now.AddDays(-1).Year.ToString & "-" & DateTime.Now.AddDays(-1).Day.ToString & "-" & DateTime.Now.AddDays(-1).Month.ToString & " 22:00:00"
            dataA = DateTime.Now.Year.ToString & "-" & DateTime.Now.Day.ToString & "-" & DateTime.Now.Month.ToString & " 05:59:59"

        End If
        'Then we make the relative query
        myCmd = myConn.CreateCommand()
        myCmd.CommandText = "SELECT SUM(ProduzioneStep) FROM DatiProduzione WHERE ((Id_reparto=" & LblIdDepartment.Text & ")AND(Id_linea=" & LblIdLinea.Text & ")AND(Data>='" & dataDa.ToString & "')AND(Data<='" & dataA.ToString() & "'))"
        myCmd.Connection.Open()
        If (IsDBNull(myCmd.ExecuteScalar())) Then
            myCmd.Connection.Close()
        Else
            TextBoxProduzione.Text = myCmd.ExecuteScalar()
            myCmd.Connection.Close()
        End If
    End Sub

    Private Sub LoadManpower()
        'Load manpower that are actually loaded into the line
        Dim myConn As New SqlConnection(LblPathDatabase.Text)
        Dim myCmd As SqlCommand
        myCmd = myConn.CreateCommand()


        myCmd.CommandText = "SELECT Cognome,Nome,DataEntrata FROM OreOperatori WHERE ((Id_reparto=" & LblIdDepartment.Text & ") AND (Id_linea=" & LblIdLinea.Text & ") AND (DataUscita IS NULL))"
        ' Open the connection    
        myCmd.Connection.Open()
        Dim dtRegistro As DataTable = New DataTable
        Dim myDataAdapter As New SqlDataAdapter(myCmd)
        myDataAdapter.Fill(dtRegistro)
        DataGridViewManPower.DataSource = dtRegistro
        myCmd.Connection.Close()


    End Sub

    Private Sub SetUpSerialConnection()
        '    Try
        'Now we can set up the serial connection
        SerialPortArduino.BaudRate = 9600
        SerialPortArduino.DataBits = 8
        SerialPortArduino.Parity = Parity.None
        SerialPortArduino.StopBits = StopBits.One
        SerialPortArduino.Handshake = Handshake.None
        SerialPortArduino.Encoding = System.Text.Encoding.Default 'very important!
        'SerialPortArduino.ReadTimeout = 200

        LblStatus.Text = ""
        ButtonRitentaConnessione.Visible = False
        'Catch ex As Exception
        'TimerForRoutineRegistrationData.Stop()
        'LblStatus.Text = "Connessione seriale non presente"
        'Dim ans = MsgBox("Arduino is not connected", MsgBoxStyle.RetryCancel)
        'If ans = MsgBoxResult.Retry Then
        'SetUpSerialConnection()
        'End If
        'If ans = MsgBoxResult.Cancel Then
        'LblStatus.Text = "Connessione seriale non presente"
        'ButtonRitentaConnessione.Visible = True
        'End If
        'End Try
    End Sub

    Private Sub RetriveParametersFromConfigTxt()
        'We take some other parameters from config.txt
        Dim path As String = "C:\ArduinoFermi\config.txt"
        'Try
        Dim sr As StreamReader = New StreamReader(path)
        Do While sr.Peek() >= 0
            Dim rowstring As String = sr.ReadLine()
            'Retrive DatabasePath
            If Strings.Left(rowstring, 14) = "[DatabasePath]" Then
                'We save this also in a label of the application
                LblPathDatabase.Text = rowstring.Substring(15, rowstring.Length - 15)
            End If
            'Retrive IdDepartment
            If Strings.Left(rowstring, 14) = "[IdDepartment]" Then
                ''We save this also in a label of the application
                LblIdDepartment.Text = rowstring.Substring(15, rowstring.Length - 15)
            End If
            'Retrive DepartmentDescription
            If Strings.Left(rowstring, 23) = "[DepartmentDescription]" Then
                ''We save this also in a label of the application
                LblDepartmentDescription.Text = rowstring.Substring(24, rowstring.Length - 24)
                'We delete the tab page that we don not use
                If LblDepartmentDescription.Text = "Stiratura" Then
                    Tab.TabPages.Remove(TabMontaggio)
                    Tab.TabPages.Remove(TabFormazione)
                    Tab.TabPages.Remove(TabCarica)
                End If
                If LblDepartmentDescription.Text = "Montaggio" Then
                    Tab.TabPages.Remove(TabStiratura)
                    Tab.TabPages.Remove(TabFormazione)
                    Tab.TabPages.Remove(TabCarica)
                End If
                If LblDepartmentDescription.Text = "Formazione" Then
                    Tab.TabPages.Remove(TabStiratura)
                    Tab.TabPages.Remove(TabMontaggio)
                    Tab.TabPages.Remove(TabCarica)
                End If
                If LblDepartmentDescription.Text = "Carica" Then
                    Tab.TabPages.Remove(TabStiratura)
                    Tab.TabPages.Remove(TabMontaggio)
                    Tab.TabPages.Remove(TabFormazione)
                End If
                'Here we have to use Me instead of Form1 to don't have an error
                Me.Text = Me.Text & " - " & rowstring.Substring(24, rowstring.Length - 24)
            End If
            'Retrive IdLine
            If Strings.Left(rowstring, 8) = "[IdLine]" Then
                ''We save this also in a label of the application
                LblIdLinea.Text = rowstring.Substring(9, rowstring.Length - 9)
            End If
            'Retrive LineDescription
            If Strings.Left(rowstring, 17) = "[LineDescription]" Then
                ''We save this also in a label of the application
                LblLineDescription.Text = rowstring.Substring(18, rowstring.Length - 18)
                'Here we have to use Me instead of Form1 to don't have an error
                Me.Text = Me.Text & " - " & rowstring.Substring(18, rowstring.Length - 18)
            End If
            'We retrive the serial port for connection
            If Strings.Left(rowstring, 9) = "[COMPort]" Then
                ''We save this also in a string to set up after the serial connection
                Dim COMPort As String = rowstring.Substring(10, rowstring.Length - 10)
                'SerialPortArduino.Close()
                SerialPortArduino.PortName = COMPort 'change com port to match your Arduino port
            End If
            'We retrive FermataDopoSecondi
            If Strings.Left(rowstring, 20) = "[FermataDopoSecondi]" Then
                'We save this also in a label of the application
                LabelFermataDopoValue.Text = rowstring.Substring(21, rowstring.Length - 21)
            End If
            'We retrive RipartenzaDopoPezzi
            If Strings.Left(rowstring, 21) = "[RipartenzaDopoPezzi]" Then
                'We save this also in a label of the application
                LabelRipartenzaDopoValue.Text = rowstring.Substring(22, rowstring.Length - 22)
            End If
            'We retrive GiustificativoDopoPezzi
            If Strings.Left(rowstring, 25) = "[GiustificativoDopoPezzi]" Then
                'We save this also in a label of the application
                LabelGiustificativoDopoValue.Text = rowstring.Substring(26, rowstring.Length - 26)
            End If
            'We retrive PezziPerOgniImpulso
            If Strings.Left(rowstring, 21) = "[PezziPerOgniImpulso]" Then
                'We save this also in a label of the application
                LblPezziOgniImpulso.Text = rowstring.Substring(22, rowstring.Length - 22)
            End If
        Loop
        sr.Close()
        'Now we have to check if into the DB there are a stop not closed in the correct way
        'If we erase it and we show a message to the user
        EraseNotClosedStop()
        'Everything is ok so we can update the graph
        UpdateChart()
    End Sub

    Private Sub TimerForRoutineRegistrationData_Tick(sender As Object, e As EventArgs) Handles TimerForRoutineRegistrationData.Tick
        'The timer update every 0,2 second
        If OvalShapeYellow.FillColor = Color.Orange Then
            If LabelContatoreGiustificativo.Text = LabelGiustificativoDopoValue.Text Then
                'In this case we have to close the record in the database with a stop not declared by the operator
                CloseNotJustifiedStop()
                'Then we reset the counter
                LabelContatoreGiustificativo.Text = "0"
                LabelContatoreRipartenza.Text = "0"
            End If
        End If
        'Try
        'If SerialPortArduino.IsOpen() Then

        'Else

        '    SerialPortArduino.Open()

        'End If

        'Aggiunta questa condizione if perchè altrimenti se la scrittura sulla porta e il timer non sono sincronizzati 
        'l'applicazione aspetta che Arduino scrive sulla porta e va in ritardo lasciando che il tempo sia dettato da Arduino
        'il tempo di scrittura sul seriale da Arduino è stato rallentato perchè la stessa velocità Scrittura su seriale-Timer applicazione
        'dava problemi di perdita di dati
        If SerialPortArduino.BytesToRead() > 0 Then
            LabelProduzioneNascosto.Text = SerialPortArduino.ReadLine()
        Else
        End If
        'MsgBox(LabelProduzioneNascosto.Text)
        'SerialPortArduino.DiscardInBuffer()
        'SerialPortArduino.Close()
        'SerialPortArduino.Dispose()

        Dim LabelProduzioneNascostoAsInt As Integer
        If Integer.TryParse(LabelProduzioneNascosto.Text, LabelProduzioneNascostoAsInt) Then
            ' LabelProduzioneNascosto successfully parsed as Integer
            Dim LabelProduzioneNascostoOldAsInt As Integer
            If Integer.TryParse(LabelProduzioneOldNascosto.Text, LabelProduzioneNascostoOldAsInt) Then
                'check if the new value is near the old
                If (Math.Abs(LabelProduzioneNascostoAsInt - LabelProduzioneNascostoOldAsInt)) < 8 Then
                    'Here  we have a lot of propability to have a clean number
                    If (LabelProduzioneNascostoAsInt = LabelProduzioneNascostoOldAsInt) Then
                        'PRODUCTION=OLD PRODUCTION...The line is really in stop?
                        LabelContatoreFermata.Text = Convert.ToString(CInt(LabelContatoreFermata.Text) + 1)
                        If LabelContatoreFermata.Text = (CInt(LabelFermataDopoValue.Text) * 5).ToString Then 'With this value(150) we wait 30 seconds to stop the line
                            'If we have the yellow lamp on we are arriving from another line stop
                            'so we don't insert another in database but we consider part of the previous stop
                            If OvalShapeYellow.FillColor = Color.Orange Then
                                AnotherStopDuringAskJustify()
                                LabelContatoreRipartenza.Text = "0"
                                LabelContatoreGiustificativo.Text = "0"
                            Else
                                'We are sure that the line is stopped
                                RecognizedStopInLine()
                                LabelContatoreRipartenza.Text = "0"
                            End If
                        End If
                    Else
                        'PRODUCTION!=OLD PRODUCTION so the line is going on
                        LabelContatoreFermata.Text = "0"
                        'We increment the counter of the restart of the line but only if we are in stopped state
                        If OvalShapeRed.FillColor = Color.Red Then
                            LabelContatoreRipartenza.Text = Convert.ToString(CInt(LabelContatoreRipartenza.Text) + 1)
                        End If
                        If LabelContatoreRipartenza.Text = LabelRipartenzaDopoValue.Text Then 'With this value(150) we wait 30 seconds to restart the line
                            RestartLineAndAskJustify()
                        End If
                        If OvalShapeYellow.FillColor = Color.Orange Then 'If we have the yellow lamp on we increment the counter of the causal
                            LabelContatoreGiustificativo.Text = Convert.ToString(CInt(LabelContatoreGiustificativo.Text) + 1)
                        End If
                    End If
                    '15/06/2017
                    'REmoved +1 on the following expression.CInt(LabelProduzioneNascostoAsInt)+1 
                    '------------
                    'LabelContatoreProduzione.Text = Convert.ToString(((CInt(LabelProduzioneNascostoAsInt)+1) * CInt(LblPezziOgniImpulso.Text)) + CInt(TextBoxProduzione.Text)) 'We can update tha value of the counter
                    'LabelContatoreProduzioneHidden.Text = Convert.ToString(((CInt(LabelProduzioneNascostoAsInt)+1) * CInt(LblPezziOgniImpulso.Text)) + CInt(TextBoxProduzione.Text)) 'We can update tha value of the counter
                    '------------
                    LabelContatoreProduzione.Text = Convert.ToString(((CInt(LabelProduzioneNascostoAsInt)) * CInt(LblPezziOgniImpulso.Text)) + CInt(TextBoxProduzione.Text)) 'We can update tha value of the counter
                    LabelContatoreProduzioneHidden.Text = Convert.ToString(((CInt(LabelProduzioneNascostoAsInt)) * CInt(LblPezziOgniImpulso.Text)) + CInt(TextBoxProduzione.Text)) 'We can update tha value of the counter
                    '---------------------------------
                    'With this section we insert the dot to separate thousand
                    Dim LenghtCounter = LabelContatoreProduzione.Text.Length()
                    If LenghtCounter > 3 Then
                        LabelContatoreProduzione.Text = LabelContatoreProduzione.Text.Insert(LenghtCounter - 3, ".")
                    End If
                End If
                LabelProduzioneOldNascosto.Text = LabelProduzioneNascostoAsInt.ToString()
            End If
        Else
            ' childAge is not an Integer then not do anything and ignore the value passed from arduino
        End If



        'Sezione per resettare il contapezzi al cambio turno
        Dim Dt As String = Strings.Right(LabelCurrentTime.Text, 8)
        If Dt = "06:00:00" Then

            'Reset the counter
            SendToArduino("7")
            LabelContatoreProduzioneHidden.Text = 0

            TextBoxProduzione.Text = "0"
        End If
        If Dt = "14:00:00" Then

            'Reset the counter
            SendToArduino("7")
            LabelContatoreProduzioneHidden.Text = 0

            TextBoxProduzione.Text = "0"
        End If
        If Dt = "22:00:00" Then

            'Reset the counter
            SendToArduino("7")
            LabelContatoreProduzioneHidden.Text = 0

            TextBoxProduzione.Text = "0"
        End If
        'ONLY FOR TEST TO SAVE PRODUCTION EVERY 10 MINUTES
        Dim stringTime As String = Strings.Mid(LabelCurrentTime.Text, 16, 4)
        Label23.Text = stringTime
        If stringTime = "0:00" And LabelProduzioneSalvata.Text = "No" Then

            SaveProduction()
            UpdateChart()
            UpdateIstogram()
            UpdateChartCausali()
        Else
            If stringTime <> "0:00" Then
                LabelProduzioneSalvata.Text = "No"
            End If
        End If
        ''ONLY FOR TEST TO SAVE PRODUCTION EVERY 1 MINUTE

        'Dim stringTime As String = Strings.Mid(LabelCurrentTime.Text, 17, 3)
        'Label23.Text = stringTime
        'If stringTime = ":00" And LabelProduzioneSalvata.Text = "No" Then
        '    SaveProduction()
        '    UpdateChart()
        '    UpdateIstogram()
        '    UpdateChartCausali()
        'Else
        '    If stringTime <> ":00" Then
        '        LabelProduzioneSalvata.Text = "No"
        '    End If
        'End If

    End Sub

    Private Sub CloseNotJustifiedStop()
        'In this case we have to close the record in the database with a stop not declared by the operator
        '--------------------------------------
        Dim myConn = New SqlConnection(LblPathDatabase.Text)
        'Dim myCmd As SqlCommand
        'myCmd = myConn.CreateCommand()

        'myCmd.CommandText = "SELECT DataInizioFermo FROM Fermi WHERE (Id=" & LabelIdFermo.Text & " AND IdReparto=" & LblIdDepartment.Text & " AND IdLinea=" & LblIdLinea.Text & ")"

        'Dim DataInizio As Date
        'myCmd.Connection.Open()
        'DataInizio = myCmd.ExecuteScalar()
        'myCmd.Connection.Close()
        'Dim Duration As TimeSpan = DateTime.Now().Subtract(DataInizio)
        'Dim TotalMinutesDuration As String = CInt(Duration.TotalMinutes()).ToString()

        Dim myCmd2 As SqlCommand
        myCmd2 = myConn.CreateCommand()

        'myCmd2.CommandText = ("UPDATE Fermi SET IdMacchina=999,DescMacchina='Non Dichiarato',IdFermo=999,DescFermo='Non dichiarato',Durata='" & TotalMinutesDuration & "',DataFineFermo='" & DataFormatting(DateTime.Now()) & "' WHERE (Id=" & LabelIdFermo.Text & " AND IdReparto=" & LblIdDepartment.Text & " AND IdLinea=" & LblIdLinea.Text & ")")
        myCmd2.CommandText = ("UPDATE Fermi SET IdMacchina=999,DescMacchina='Non Dichiarato',IdFermo=999,DescFermo='Non dichiarato' WHERE (Id=" & LabelIdFermo.Text & " AND IdReparto=" & LblIdDepartment.Text & " AND IdLinea=" & LblIdLinea.Text & ")")
        myCmd2.Connection.Open()
        Dim numberOfRow As Int16 = myCmd2.ExecuteNonQuery()

        myCmd2.Connection.Close()
        'We turn off the Yellow led
        OvalShapeYellow.FillColor = Color.Silver
        SendToArduino("2")
        'We put the line in Marcia in the DB

        Dim myCmd3 As SqlCommand
        myCmd3 = myConn.CreateCommand()

        myCmd3.CommandText = "UPDATE StatoLinee SET Stato='Marcia' WHERE (Id_Reparto=" & LblIdDepartment.Text & " AND Id_Linea=" & LblIdLinea.Text & ")"

        myCmd3.Connection.Open()
        myCmd3.ExecuteNonQuery()
        myCmd3.Connection.Close()
        'We disable the button of the main form
        disableButton()

    End Sub

    Private Sub RecognizedStopInLine()
        'First we need to check if it is the first time we see the stop on the line
        If OvalShapeRed.FillColor = Color.Red Then
            'Do Nothing
        Else
            'We are sure that the line is stopped and is the first time that we see the line stopped
            OvalShapeRed.FillColor = Color.Red
            'Turn on the red lamp
            SendToArduino("1")
            'Turn off yellow lamp
            OvalShapeYellow.FillColor = Color.Silver
            SendToArduino("2")
            'Turn off green lamp
            OvalShapeGreen.FillColor = Color.Silver
            SendToArduino("4")
            'We put the line in STOP in the DB

            Dim myConn = New SqlConnection(LblPathDatabase.Text)
            Dim myCmd As SqlCommand
            myCmd = myConn.CreateCommand()
            myCmd.CommandText = "UPDATE StatoLinee SET Stato='Stop' WHERE (Id_Reparto=" & LblIdDepartment.Text & " AND Id_Linea=" & LblIdLinea.Text & ")"

            myCmd.Connection.Open()
            myCmd.ExecuteNonQuery()
            myCmd.Connection.Close()
            'We insert a row into the db and we save the current time

            Dim myCmd2 As SqlCommand
            myCmd2 = myConn.CreateCommand()
            myCmd2.CommandText = "SELECT COUNT(ID) FROM Fermi"

            myCmd2.Connection.Open()
            Dim rowcount = myCmd2.ExecuteScalar()
            myCmd2.Connection.Close()

            Dim myCmd3 As SqlCommand
            myCmd3 = myConn.CreateCommand()
            myCmd3.CommandText = "SELECT MAX (ID) FROM Fermi"

            myCmd3.Connection.Open()
            Dim Id As String
            If rowcount = "0" Then
                Id = 0
            Else
                Id = myCmd3.ExecuteScalar()
            End If
            myCmd3.Connection.Close()

            Dim myCmd4 As SqlCommand
            myCmd4 = myConn.CreateCommand()
            myCmd4.CommandText = ("INSERT INTO Fermi (Id,Data,Datainiziofermo,IdReparto,DescReparto,IdLinea,DescLinea)VALUES (" & CInt(Id) + 1 & ",'" & DataFormatting(DateTime.Now()) & "','" & DataFormatting(DateTime.Now()) & "'," & LblIdDepartment.Text & ",'" & LblDepartmentDescription.Text & "'," & LblIdLinea.Text & ",'" & LblLineDescription.Text & "')")

            myCmd4.Connection.Open()
            Dim numberOfRow As Int16 = myCmd4.ExecuteNonQuery()
            myCmd4.Connection.Close()

            Dim myCmd5 As SqlCommand
            myCmd5 = myConn.CreateCommand()
            myCmd5.CommandText = ("SELECT Id FROM Fermi WHERE (IdMacchina IS NULL AND IdReparto=" & LblIdDepartment.Text & " AND IdLinea=" & LblIdLinea.Text & " )")
            myCmd5.Connection.Open()
            LabelIdFermo.Text = myCmd5.ExecuteScalar()
            myCmd5.Connection.Close()
        End If
    End Sub

    Private Sub AnotherStopDuringAskJustify()
        'If we have the yellow lamp on we are arriving from another line stop
        'so we don't insert another in database but we consider part of the previous stop
        OvalShapeRed.FillColor = Color.Red
        SendToArduino("1")
        OvalShapeYellow.FillColor = Color.Silver
        SendToArduino("2")
        OvalShapeGreen.FillColor = Color.Silver
        SendToArduino("4")
        'We put the line in STOP in the DB

        Dim myConn As New SqlConnection(LblPathDatabase.Text)
        Dim myCmd As SqlCommand
        myCmd = myConn.CreateCommand()
        myCmd.CommandText = "UPDATE StatoLinee SET Stato='Stop' WHERE (Id_Reparto=" & LblIdDepartment.Text & " AND Id_Linea=" & LblIdLinea.Text & ")"

        myCmd.Connection.Open()
        myCmd.ExecuteNonQuery()
        myCmd.Connection.Close()
        'We disable the button on the main form
        disableButton()
    End Sub

    Private Sub RestartLineAndAskJustify()
        OvalShapeRed.FillColor = Color.Silver
        'Turn off the red lamp
        SendToArduino("0")
        OvalShapeYellow.FillColor = Color.Orange
        'Turn on the yellow lamp
        SendToArduino("3")
        'Turn on the green lamp
        SendToArduino("5")
        OvalShapeGreen.FillColor = Color.Green
        'We put the line in Giustificativo in the DB


        Dim myConn = New SqlConnection(LblPathDatabase.Text)
        Dim myCmd As SqlCommand
        myCmd = myConn.CreateCommand()

        myCmd.CommandText = "UPDATE StatoLinee SET Stato='Giustificativo' WHERE (Id_Reparto=" & LblIdDepartment.Text & " AND Id_Linea=" & LblIdLinea.Text & ")"

        myCmd.Connection.Open()
        myCmd.ExecuteNonQuery()
        myCmd.Connection.Close()

        'Enable the button of the main form
        EnableButton()

        'Then we need to save the time of the restart of the linea
        Dim myCmd2 As SqlCommand
        myCmd2 = myConn.CreateCommand()

        myCmd2.CommandText = "SELECT DataInizioFermo FROM Fermi WHERE Id=" & LabelIdFermo.Text & ""

        Dim DataInizio As Date
        myCmd2.Connection.Open()
        DataInizio = myCmd2.ExecuteScalar()
        myCmd2.Connection.Close()

        Dim myCmd3 As SqlCommand
        myCmd3 = myConn.CreateCommand()

        Dim Duration As TimeSpan = DateTime.Now().Subtract(DataInizio)
        Dim TotalMinutesDuration As String = CInt((Duration.TotalMinutes()).ToString())
        ' Duration = Strings.Left((DateTime.Now() - DataInizio).ToString, 8)
        'Dim DurationString As String
        'DurationString = CInt(Strings.Left(Duration.ToString(), 2)) * 60 + CInt(Strings.Mid(Duration.ToString(), 3, 2))
        myCmd3.CommandText = ("UPDATE Fermi SET Durata='" & TotalMinutesDuration & "',DataFineFermo='" & DataFormatting(DateTime.Now()) & "'WHERE (Id=" & LabelIdFermo.Text & " AND IdReparto=" & LblIdDepartment.Text & " AND IdLinea=" & LblIdLinea.Text & ")")
        myCmd3.Connection.Open()
        Dim numberOfRow As Int16 = myCmd3.ExecuteNonQuery()
        myCmd3.Connection.Close()
        LabelContatoreRipartenza.Text = "0"
    End Sub

    Private Sub ButtonLineaGenerale_Click(sender As Object, e As EventArgs) Handles ButtonLineaGenerale.Click
        Dim pass As String = LabelIdFermo.Text
        Dim Frm As New FormLineaGenerale(pass)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonSvolgitore_Click(sender As Object, e As EventArgs) Handles ButtonSvolgitore.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "10"
        Dim DescMacchina As String = "Svolgitore"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonEspansore_Click(sender As Object, e As EventArgs) Handles ButtonEspansore.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "20"
        Dim DescMacchina As String = "Espansore"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonTabBlanker_Click(sender As Object, e As EventArgs) Handles ButtonTabBlanker.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "24"
        Dim DescMacchina As String = "TabBlanker"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonMolazza_Click(sender As Object, e As EventArgs) Handles ButtonMolazza.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "25"
        Dim DescMacchina As String = "Molazza"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonSpalamtrice_Click(sender As Object, e As EventArgs) Handles ButtonSpalmatrice.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "30"
        Dim DescMacchina As String = "Spalmatrice"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonDivider_Click(sender As Object, e As EventArgs) Handles ButtonDivider.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "40"
        Dim DescMacchina As String = "Divider"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonTunnel_Click(sender As Object, e As EventArgs) Handles ButtonTunnel.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "50"
        Dim DescMacchina As String = "Tunnel"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonImpilatore_Click(sender As Object, e As EventArgs) Handles ButtonImpilatore.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "60"
        Dim DescMacchina As String = "Impilatore"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonPaletizzatore_Click(sender As Object, e As EventArgs) Handles ButtonPaletizzatore.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "70"
        Dim DescMacchina As String = "Paletizzatore"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        Try
            'Turn on the green lamp
            SendToArduino("5")
            OvalShapeGreen.FillColor = Color.Green


            Dim myConn = New SqlConnection(LblPathDatabase.Text)
            Dim myCmd As SqlCommand
            myCmd = myConn.CreateCommand()
            myCmd.CommandText = "UPDATE StatoLinee SET Stato='Marcia' WHERE (Id_Reparto=" & LblIdDepartment.Text & " AND Id_Linea=" & LblIdLinea.Text & ")"

            myCmd.Connection.Open()
            myCmd.ExecuteNonQuery()
            myCmd.Connection.Close()


        Catch ex As Exception
            TimerForRoutineRegistrationData.Stop()
            Dim ans = MsgBox("Arduino is not connected", MsgBoxStyle.RetryCancel)
            If ans = MsgBoxResult.Retry Then

            End If
        End Try
        TimerForRoutineRegistrationData.Start()

    End Sub

    Private Sub ButtonStop_Click(sender As Object, e As EventArgs) Handles ButtonStop.Click
        TimerForRoutineRegistrationData.Stop()
    End Sub

    Private Sub TimerMain_Tick(sender As Object, e As EventArgs) Handles TimerMain.Tick
        'This tick is enabled from the beginning
        LabelCurrentTime.Text = DateTime.Now.ToString()
        'MsgBox(LabelCurrentTime.Text)
        If ButtonRitentaConnessione.Visible = True Then
            If ButtonRitentaConnessione.BackColor = Color.Transparent Then
                ButtonRitentaConnessione.BackColor = Color.Silver
            Else
                ButtonRitentaConnessione.BackColor = Color.Transparent
            End If
        End If
        If TimerForRoutineRegistrationData.Enabled = True Then
            ButtonStart.BackColor = Color.Transparent
        Else
            If ButtonStart.BackColor = Color.Transparent Then
                ButtonStart.BackColor = Color.Silver
            Else
                ButtonStart.BackColor = Color.Transparent
            End If
        End If

    End Sub

    Sub EraseNotClosedStop()
        'La presente funzione controlla se è presente in database un fermo di cui non è stato inserito il giustificativo
        Dim myConn = New SqlConnection(LblPathDatabase.Text)
        Dim myCmd As SqlCommand
        myCmd = myConn.CreateCommand()
        myCmd.CommandText = "SELECT COUNT (ID) FROM Fermi WHERE (IdReparto=" & LblIdDepartment.Text & " AND IdLinea=" & LblIdLinea.Text & ")"

        myCmd.Connection.Open()
        Dim TotalStop As String
        TotalStop = myCmd.ExecuteScalar()
        myCmd.Connection.Close()
        Dim myCmd2 As SqlCommand
        myCmd2 = myConn.CreateCommand()
        myCmd2.Connection.Open()
        myCmd2.CommandText = (" SELECT COUNT (IdMacchina) FROM Fermi WHERE (IdReparto=" & LblIdDepartment.Text & " AND IdLinea=" & LblIdLinea.Text & ")")

        Dim StopJustified As String
        StopJustified = myCmd2.ExecuteScalar()
        myCmd2.Connection.Close()
        If TotalStop = StopJustified Then
            'Here we are sure that we don't have pending stop in DB
        Else
            'Here we have to erase the pending record
            Dim myCmd3 As SqlCommand
            myCmd3 = myConn.CreateCommand()
            myCmd3.CommandText = "SELECT Id FROM Fermi WHERE (IdReparto=" & LblIdDepartment.Text & " AND IdLinea=" & LblIdLinea.Text & " AND IdMacchina IS NULL)"
            myCmd3.Connection.Open()
            Dim IdToErase As String
            IdToErase = myCmd3.ExecuteScalar()
            myCmd3.Connection.Close()
            Dim myCmd4 As SqlCommand
            myCmd4 = myConn.CreateCommand()
            myCmd4.CommandText = "DELETE FROM Fermi WHERE (Id=" & IdToErase & " AND IdReparto=" & LblIdDepartment.Text & " AND IdLinea=" & LblIdLinea.Text & " AND IdMacchina IS NULL)"
            myCmd4.Connection.Open()

            myCmd4.ExecuteNonQuery()
            myCmd4.Connection.Close()
            MsgBox("E' stato rilevato in database un fermo precedente di cui non è stato inserito il giustificativo. Per evitare problemi di corenza nel database il record verrà cancellato")
        End If


    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'If the VB.NET program is closed we send the info to arduino to reset counter and turn off the lamp
        Try
            SendToArduino("6")
        Catch ex As Exception
            TimerForRoutineRegistrationData.Stop()
        End Try
        SerialPortArduino.Close()
    End Sub

    Private Sub UpdateChart()
        Try
            'ROUTINE PER AGGIORNARE IL GRAFICO DELLA PRODUZIONE

            Dim myConn = New SqlConnection(LblPathDatabase.Text)

            Dim DataFine As DateTime = DateTime.Now()
            Dim DataInizio As DateTime = DateAdd(DateInterval.Hour, -8, DataFine)

            Dim myCmd As SqlCommand
            myCmd = myConn.CreateCommand()
            myCmd.CommandText = ("SELECT Data, ProduzioneStep FROM DatiProduzione WHERE ((Id_Reparto='" & LblIdDepartment.Text & "') AND (Id_linea='" & LblIdLinea.Text & "')AND(DATA >= '" & DataFormatting(DataInizio) & "')AND(DATA <= '" & DataFormatting(DataFine) & "'))ORDER BY Data ")

            myCmd.Connection.Open()
            Dim myReader As SqlDataReader = myCmd.ExecuteReader(CommandBehavior.CloseConnection)
            'Since the reader implements IEnumerable, pass the reader directly into
            'the DataBind method with the name of the Column selected in the query    
            ChartProduzioneOraria.Series("Series1").Points.DataBindXY(myReader, "Data", myReader, "ProduzioneStep")
            Dim ds As New DataSet
            Dim adapter As New SqlDataAdapter(myCmd.CommandText, myConn)
            adapter.Fill(ds)
            myReader.Close()
            myCmd.Connection.Close()
        Catch ex As Exception
            MsgBox("Non è stato possibile connettersi al database")
        End Try

    End Sub

    Private Sub SaveProduction()
        Dim myConn = New SqlConnection(LblPathDatabase.Text)
        'we retrive what is the last recent record of that department\line
        Dim myCmd As SqlCommand
        myCmd = myConn.CreateCommand()

        myCmd.CommandText = ("INSERT INTO DatiProduzione (Data,Id_reparto,Reparto,Id_linea,Linea,ProduzioneStep)VALUES ('" & DataFormatting(DateTime.Now) & "','" & LblIdDepartment.Text & "','" & LblDepartmentDescription.Text & "','" & LblIdLinea.Text & "','" & LblLineDescription.Text & "'," & (CInt(LabelProduzioneNascosto.Text) * CInt(LblPezziOgniImpulso.Text)) & ")")
        myCmd.Connection.Open()
        myCmd.ExecuteNonQuery()
        myCmd.Connection.Close()

        'we update the textbox of the production
        LoadProductionDataOfCurrentShift()


        'reset the counter on arduino
        SendToArduino("7")

        LabelProduzioneSalvata.Text = "Si"
        '------------------------------------------
        'Dim myConn = New SqlConnection(LblPathDatabase.Text)
        ''we retrive what is the last recent record of that department\line
        'Dim PreviousData As DateTime
        'Dim myCmd As SqlCommand
        'myCmd = myConn.CreateCommand()

        'myCmd.CommandText = "SELECT MAX(DATA) FROM DatiProduzione WHERE ((Id_reparto='" & LblIdDepartment.Text & "')AND(Id_linea='" & LblIdLinea.Text & "'))"

        'Dim myCmd2 As SqlCommand
        'myCmd2 = myConn.CreateCommand()

        'myCmd.Connection.Open()


        'If (IsDBNull(myCmd.ExecuteScalar())) Then
        '    myCmd.Connection.Close()
        '    'if null we don't have record in database so we insert directly the data
        '    myCmd2.CommandText = ("INSERT INTO DatiProduzione (Data,Id_reparto,Reparto,Id_linea,Linea,ProgressivoProduzioneStepPrecedente,ProduzioneStep,ProgressivoProduzione)VALUES ('" & DataFormatting(DateTime.Now) & "','" & LblIdDepartment.Text & "','" & LblDepartmentDescription.Text & "','" & LblIdLinea.Text & "','" & LblLineDescription.Text & "','0'," & CInt(LabelContatoreProduzioneHidden.Text) & "," & CInt(LabelContatoreProduzioneHidden.Text) & ")")
        'Else
        '    'we retrive the last production data
        '    PreviousData = myCmd.ExecuteScalar()
        '    myCmd.Connection.Close()

        '    Dim myCmd3 As SqlCommand
        '    myCmd3 = myConn.CreateCommand()

        '    myCmd3.CommandText = "SELECT ProgressivoPRODUZIONE FROM DatiProduzione WHERE ((DATA='" & DataFormatting(PreviousData) & "')AND(Id_linea='" & LblIdLinea.Text & "')AND(Id_reparto='" & LblIdDepartment.Text & "'))"
        '    myCmd3.Connection.Open()
        '    Dim PreviousProduction As String
        '    If (IsDBNull(myCmd3.ExecuteScalar())) Then
        '        myCmd3.Connection.Close()
        '        myCmd2.CommandText = ("INSERT INTO DatiProduzione (Data,Id_reparto,Reparto,Id_linea,Linea,ProgressivoProduzioneStepPrecedente,ProduzioneStep,ProgressivoProduzione)VALUES ('" & DataFormatting(DateTime.Now) & "','" & LblIdDepartment.Text & "','" & LblDepartmentDescription.Text & "','" & LblIdLinea.Text & "','" & LblLineDescription.Text & "',0," & CInt(LabelContatoreProduzioneHidden.Text) & "," & CInt(LabelContatoreProduzioneHidden.Text) & ")")
        '    Else
        '        PreviousProduction = myCmd3.ExecuteScalar()
        '        myCmd3.Connection.Close()
        '        If (CInt(LabelContatoreProduzioneHidden.Text)) < 0 Then
        '            LabelContatoreProduzioneHidden.Text = Math.Abs(CInt(LabelContatoreProduzioneHidden.Text))
        '        End If
        '        If (CInt(LabelContatoreProduzioneHidden.Text) - CInt(PreviousProduction)) < 0 Then
        '            'We need to set 0 to the Progressivo Produzione Step precedente
        '            myCmd2.CommandText = ("INSERT INTO DatiProduzione (Data,Id_reparto,Reparto,Id_linea,Linea,ProgressivoProduzioneStepPrecedente,ProduzioneStep,ProgressivoProduzione)VALUES ('" & DataFormatting(DateTime.Now) & "','" & LblIdDepartment.Text & "','" & LblDepartmentDescription.Text & "','" & LblIdLinea.Text & "','" & LblLineDescription.Text & "',0," & CInt(LabelContatoreProduzioneHidden.Text) & "," & CInt(LabelContatoreProduzioneHidden.Text) & ")")
        '        Else
        '            myCmd2.CommandText = ("INSERT INTO DatiProduzione (Data,Id_reparto,Reparto,Id_linea,Linea,ProgressivoProduzioneStepPrecedente,ProduzioneStep,ProgressivoProduzione)VALUES ('" & DataFormatting(DateTime.Now) & "','" & LblIdDepartment.Text & "','" & LblDepartmentDescription.Text & "','" & LblIdLinea.Text & "','" & LblLineDescription.Text & "'," & PreviousProduction & "," & CInt(LabelContatoreProduzioneHidden.Text) - CInt(PreviousProduction) & "," & CInt(LabelContatoreProduzioneHidden.Text) & ")")
        '        End If
        '    End If
        'End If
        'myCmd2.Connection.Open()
        'Dim numberOfRow As Int16 = myCmd2.ExecuteNonQuery()
        'myCmd2.Connection.Close()


    End Sub

    Private Sub ButtonRitentaConnessione_Click(sender As Object, e As EventArgs) Handles ButtonRitentaConnessione.Click
        SetUpSerialConnection()
    End Sub

    Private Sub VisualizzaFermateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualizzaFermateToolStripMenuItem.Click

        'Query to update the table LineaAttiva, used later by the dataSet to show only the records of the current line

        Dim myConn = New SqlConnection(LblPathDatabase.Text)
        Dim myCmd As SqlCommand
        myCmd = myConn.CreateCommand()
        myCmd.CommandText = "UPDATE LineaAttiva SET IdReparto=" & LblIdDepartment.Text & ", IdLine=" & LblIdLinea.Text & " WHERE [Id]=1"
        myCmd.Connection.Open()
        myCmd.ExecuteNonQuery()
        myCmd.Connection.Close()

        VisualizzaFermate.Show()
    End Sub





    Private Sub UtilityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UtilityToolStripMenuItem.Click
        Utility.Show()
    End Sub



    Sub UpdateIstogram()

        ChartMacchine.Series.Clear()
        'Enable 3D chart
        ChartMacchine.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True
        'ChartMacchine.Series.Add("Serie2")
        ChartMacchine.Series.Add("Serie1")
        ChartMacchine.Series("Serie1").LegendText = "Totale minuti fermata"
        Dim myConn As New SqlConnection(LblPathDatabase.Text)
        Dim myCmd As SqlCommand
        myCmd = myConn.CreateCommand()

        Dim DataFine As DateTime = DateTime.Now()
        Dim DataInizio As DateTime = DateAdd(DateInterval.Hour, -8, DataFine)
        'myCmd.CommandText = "SELECT DESCMACCHINA,SUM(DURATA) AS DurataTot FROM FERMI WHERE ((IdReparto=" & LblIdDepartment.Text & ") AND (Idlinea=" & LblIdLinea.Text & ")AND(DATA >= '" & DataInizio.ToString("yyyy-dd-MM HH:mm:ss") & "')AND(DATA <= '" & DataFine.ToString("yyyy-dd-MM HH:mm:ss") & "')) GROUP BY DESCMACCHINA ORDER BY SUM(DURATA);"
        myCmd.CommandText = "SELECT DESCMACCHINA,SUM(DURATA) AS DurataTot FROM FERMI WHERE ((IdReparto=" & LblIdDepartment.Text & ") AND (Idlinea=" & LblIdLinea.Text & ")AND(DATA >= '" & DataFormatting(DataInizio) & "')AND(DATA <= '" & DataFormatting(DataFine) & "')) GROUP BY DESCMACCHINA ORDER BY SUM(DURATA);"

        'Open the connection    
        myCmd.Connection.Open()
        ' Create a database reader    
        Dim myReader As SqlDataReader = myCmd.ExecuteReader(CommandBehavior.CloseConnection)
        ChartMacchine.Series("Serie1").Points.DataBindXY(myReader, "DESCMACCHINA", myReader, "DurataTot")
        ' Close the reader and the connection
        myReader.Close()
        myCmd.Connection.Close()
        'aggiungo l'etichette dei dati
        ChartMacchine.Series("Serie1").IsValueShownAsLabel = True
        'faccio in modo che l'etichetta dell'asse x sia visualizzata per ogni colonna di dati
        ChartMacchine.ChartAreas("ChartArea1").AxisX.Interval = 1
    End Sub

    Sub UpdateChartCausali()

        '---------------------------
        ChartCausali.Series.Clear()
        'Enable 3D chart
        ChartCausali.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True
        ChartCausali.Series.Add("Serie1")
        ChartCausali.Series("Serie1").LegendText = "Totale minuti fermata"
        Dim myConn As New SqlConnection(LblPathDatabase.Text)
        Dim myCmd As SqlCommand
        myCmd = myConn.CreateCommand()
        Dim DataFine As DateTime = DateTime.Now()
        Dim DataInizio As DateTime = DateAdd(DateInterval.Hour, -8, DataFine)
        'myCmd.CommandText = "SELECT DESCFERMO,SUM(DURATA) AS DurataTot FROM FERMI WHERE ((IdReparto=" & LblIdDepartment.Text & ") AND (Idlinea=" & LblIdLinea.Text & ")AND(DATA >= '" & DataInizio.ToString("yyyy-MM-ddTHH:mm:ss") & "')AND(DATA <= '" & DataFine.ToString("yyyy-MM-ddTHH:mm:ss") & "')AND(IdMacchina=0)) GROUP BY DESCFERMO ORDER BY SUM(DURATA);"
        myCmd.CommandText = "SELECT DESCFERMO,SUM(DURATA) AS DurataTot FROM FERMI WHERE ((IdReparto=" & LblIdDepartment.Text & ") AND (Idlinea=" & LblIdLinea.Text & ")AND(DATA >= '" & DataFormatting(DataInizio) & "')AND(DATA <= '" & DataFormatting(DataFine) & "')AND(IdMacchina=0)) GROUP BY DESCFERMO ORDER BY SUM(DURATA);"

        ' Open the connection    
        myCmd.Connection.Open()
        ' Create a database reader    
        Dim myReader As SqlDataReader = myCmd.ExecuteReader(CommandBehavior.CloseConnection)
        ChartCausali.Series("Serie1").Points.DataBindXY(myReader, "DESCFERMO", myReader, "DurataTot")
        ' Close the reader and the connection
        myReader.Close()
        myCmd.Connection.Close()

        'aggiungo il riferimento all'asse y di destra

        'aggiungo l'etichette dei dati
        ChartCausali.Series("Serie1").IsValueShownAsLabel = True

        'faccio in modo che l'etichetta dell'asse x sia visualizzata per ogni colonna di dati
        ChartCausali.ChartAreas("ChartArea1").AxisX.Interval = 1
    End Sub

    Sub UpdateStatistic()
        'Dim fileAccess As String = ConfigurationManager.ConnectionStrings("ArduinoFermi.My.MySettings.DatabaseFermiConnectionString").ConnectionString
        'Dim conAccess = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & fileAccess & ";")
        'Dim DataFine As DateTime = DateTime.Now()
        'Dim DataInizio As DateTime = DateAdd(DateInterval.Hour, -8, DataFine)
        'Dim queryAccess As String = "SELECT SUM(DURATA) AS DurataTot FROM FERMI WHERE ((DATA >= #" & DataInizio.Month.ToString & "/" & DataInizio.Day.ToString & "/" & DataInizio.Year.ToString & " " & DataInizio.Hour.ToString & ":" & DataInizio.Minute.ToString & ":" & DataInizio.Second.ToString & "#)AND(DATA <= #" & DataFine.Month.ToString & "/" & DataFine.Day.ToString & "/" & DataFine.Year.ToString & " " & DataFine.Hour.ToString & ":" & DataFine.Minute.ToString & ":" & DataFine.Second.ToString & "#));"
        'Dim cmd As New OleDb.OleDbCommand(queryAccess, conAccess)
        'conAccess.Open()
        'LabelMinutiFermo.Text = cmd.ExecuteScalar()
        'LabelUptime.Text = Strings.Left((((480 - CInt(LabelMinutiFermo.Text)) / 480) * 100).ToString, 2) & " %"
        'conAccess.Close()
    End Sub

    Private Sub ButtonLineaGeneraleMontaggio_Click(sender As Object, e As EventArgs) Handles ButtonLineaGeneraleMontaggio.Click
        Dim pass As String = LabelIdFermo.Text
        Dim Frm As New FormLineaGeneraleMontaggio(pass)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonTranciasetti_Click(sender As Object, e As EventArgs) Handles ButtonTranciasetti.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "05"
        Dim DescMacchina As String = "Tranciasetti"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub


    Private Sub ButtonImbustatrice1_Click(sender As Object, e As EventArgs) Handles ButtonImbustatrice1.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "10"
        Dim DescMacchina As String = "Imbustatrice 1"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonImbustatrice2_Click(sender As Object, e As EventArgs) Handles ButtonImbustatrice2.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "15"
        Dim DescMacchina As String = "Imbustatrice 2"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonBuffer_Click(sender As Object, e As EventArgs) Handles ButtonBuffer.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "17"
        Dim DescMacchina As String = "Buffer"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonCOS_Click(sender As Object, e As EventArgs) Handles ButtonCOS.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "20"
        Dim DescMacchina As String = "COS"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonProvaCorti1_Click(sender As Object, e As EventArgs) Handles ButtonProvaCorti1.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "25"
        Dim DescMacchina As String = "Prova Corti 1"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonPuntatrice_Click(sender As Object, e As EventArgs) Handles ButtonPuntatrice.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "30"
        Dim DescMacchina As String = "Puntatrice"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonProvaCorti2_Click(sender As Object, e As EventArgs) Handles ButtonProvaCorti2.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "35"
        Dim DescMacchina As String = "Prova Corti 2"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonPosaCoperchi_Click(sender As Object, e As EventArgs) Handles ButtonPosaCoperchi.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "37"
        Dim DescMacchina As String = "Posa coperchi"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub


    Private Sub ButtonTermosaldatrice_Click(sender As Object, e As EventArgs) Handles ButtonTermosaldatrice.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "40"
        Dim DescMacchina As String = "Termosaldatrice"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub


    Private Sub ButtonSaldapolari_Click(sender As Object, e As EventArgs) Handles ButtonSaldapolari.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "50"
        Dim DescMacchina As String = "Saldapolari"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonProvaPneumatica_Click(sender As Object, e As EventArgs) Handles ButtonProvaPneumatica.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "60"
        Dim DescMacchina As String = "Prova pneumatica"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonProvaAltezzaPolari_Click(sender As Object, e As EventArgs) Handles ButtonProvaAltezzaPolari.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "70"
        Dim DescMacchina As String = "Prova altezza polari"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonMarcatore_Click(sender As Object, e As EventArgs) Handles ButtonMarcatore.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "75"
        Dim DescMacchina As String = "Marcatore"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonPinzaPaletizzatore_Click(sender As Object, e As EventArgs) Handles ButtonPinzaPaletizzatore.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "85"
        Dim DescMacchina As String = "Pinza/Paletizzatore"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonRobot_Click(sender As Object, e As EventArgs) Handles ButtonRobot.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "90"
        Dim DescMacchina As String = "Robot"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonNastriTrasportatori_Click(sender As Object, e As EventArgs) Handles ButtonNastriTrasportatori.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "95"
        Dim DescMacchina As String = "Nastri trasportatori"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonLineaGeneraleFormazione_Click(sender As Object, e As EventArgs) Handles ButtonLineaGeneraleFormazione.Click
        Dim pass As String = LabelIdFermo.Text
        Dim Frm As New FormLineaGeneraleFormazione(pass)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonLineaGeneraleCarica_Click(sender As Object, e As EventArgs) Handles ButtonLineaGeneraleCarica.Click
        Dim pass As String = LabelIdFermo.Text
        Dim Frm As New FormLineaGeneraleCarica(pass)
        Frm.ShowDialog()
    End Sub


    Private Sub ButtonRotatore_Click(sender As Object, e As EventArgs) Handles ButtonRotatore.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "05"
        Dim DescMacchina As String = "Rotatore e spintore 2° riemp."
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonRovesciatore_Click(sender As Object, e As EventArgs) Handles ButtonRovesciatore.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "10"
        Dim DescMacchina As String = "Rovesciatore"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonDiluitore_Click(sender As Object, e As EventArgs) Handles ButtonDiluitore.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "15"
        Dim DescMacchina As String = "Diluitore 2° riempimento"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub Button2Riempimento_Click(sender As Object, e As EventArgs) Handles Button2Riempimento.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "20"
        Dim DescMacchina As String = "2° riempimento"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonPosaTogliRampe_Click(sender As Object, e As EventArgs) Handles ButtonPosaTogliRampe.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "25"
        Dim DescMacchina As String = "Posa/Togli rampe"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonTunnelLavaggio_Click(sender As Object, e As EventArgs) Handles ButtonTunnelLavaggio.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "30"
        Dim DescMacchina As String = "Lavaggio"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonControlloLivelli_Click(sender As Object, e As EventArgs) Handles ButtonControlloLivelli.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "35"
        Dim DescMacchina As String = "Controllo livelli"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonTappatrice_Click(sender As Object, e As EventArgs) Handles ButtonTappatrice.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "40"
        Dim DescMacchina As String = "Tappatrice"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonPulisciPoli_Click(sender As Object, e As EventArgs) Handles ButtonPulisciPoli.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "45"
        Dim DescMacchina As String = "Pulisci poli"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonScaricaRapida_Click(sender As Object, e As EventArgs) Handles ButtonScaricaRapida.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "50"
        Dim DescMacchina As String = "Scarica rapida"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonDielettrico_Click(sender As Object, e As EventArgs) Handles ButtonDielettrico.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "55"
        Dim DescMacchina As String = "Controllo dielettrico"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonAKSI_Click(sender As Object, e As EventArgs) Handles ButtonAKSI.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "60"
        Dim DescMacchina As String = "Aksi"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonMarcatoreCarica_Click(sender As Object, e As EventArgs) Handles ButtonMarcatoreCarica.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "65"
        Dim DescMacchina As String = "Marcatore"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonVestizione_Click(sender As Object, e As EventArgs) Handles ButtonVestizione.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "70"
        Dim DescMacchina As String = "Vestizione"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonControlloVestizione_Click(sender As Object, e As EventArgs) Handles ButtonControlloVestizione.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "75"
        Dim DescMacchina As String = "Controllo vestizione"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonRobotCarica_Click(sender As Object, e As EventArgs) Handles ButtonRobotCarica.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "80"
        Dim DescMacchina As String = "Robot"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonScaricoManuale_Click(sender As Object, e As EventArgs) Handles ButtonScaricoManuale.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "85"
        Dim DescMacchina As String = "Scarico manuale"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonNastriTrasporto_Click(sender As Object, e As EventArgs) Handles ButtonNastriTrasporto.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "90"
        Dim DescMacchina As String = "Nastri trasp. Finitura"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Function DataFormatting(Datadaconvertire As DateTime)
        Dim dataconvertita As String
        dataconvertita = Datadaconvertire.Year().ToString() & "-" & Datadaconvertire.Day().ToString() & "-" & Datadaconvertire.Month().ToString() & " " & Datadaconvertire.Hour().ToString() & ":" & Datadaconvertire.Minute().ToString() & ":" & Datadaconvertire.Second().ToString()

        Return dataconvertita
    End Function

    Private Sub CheckOperatorLoadedInLine()
        Dim myConn As New SqlConnection(LblPathDatabase.Text)
        'first search the operator in the database
        Dim cmd As SqlCommand
        cmd = myConn.CreateCommand()
        cmd.CommandText = "SELECT COUNT (Cognome) FROM OreOperatori WHERE (Id_reparto=" & LblIdDepartment.Text & " AND Id_linea=" & LblIdLinea.Text & " AND DataUscita IS NULL)"
        cmd.Connection.Open()
        If cmd.ExecuteScalar() = 0 Then
            'There is no operator loaded in to the line
            cmd.Connection.Close()
            TimerForRoutineRegistrationData.Stop()
            LabelStatus.Text = "Registrazione dati in STOP"

            OvalShapeRed.FillColor = Color.Red
            'Turn on the red lamp
            SendToArduino("1")
            'Turn off yellow lamp
            OvalShapeYellow.FillColor = Color.Silver
            SendToArduino("2")
            'Turn off green lamp
            OvalShapeGreen.FillColor = Color.Silver
            SendToArduino("4")
            'We put the line in STOP in the DB


            Dim myCmd As SqlCommand
            myCmd = myConn.CreateCommand()
            myCmd.CommandText = "UPDATE StatoLinee SET Stato='Stop' WHERE (Id_Reparto=" & LblIdDepartment.Text & " AND Id_Linea=" & LblIdLinea.Text & ")"

            myCmd.Connection.Open()
            myCmd.ExecuteNonQuery()
            myCmd.Connection.Close()

        Else
            'There is at least one operator loaded in to the line
            cmd.Connection.Close()
            'Turn on the green lamp
            SendToArduino("5")
            OvalShapeGreen.FillColor = Color.Green
            'Turn off yellow lamp
            OvalShapeYellow.FillColor = Color.Silver
            SendToArduino("2")
            OvalShapeRed.FillColor = Color.Silver
            'Turn off the red lamp
            SendToArduino("0")


            Dim myCmd2 As SqlCommand
            myCmd2 = myConn.CreateCommand()
            myCmd2.CommandText = "UPDATE StatoLinee SET Stato='Marcia' WHERE (Id_Reparto=" & LblIdDepartment.Text & " AND Id_Linea=" & LblIdLinea.Text & ")"

            myCmd2.Connection.Open()
            myCmd2.ExecuteNonQuery()
            myCmd2.Connection.Close()
            TimerForRoutineRegistrationData.Start()
            LabelStatus.Text = "Registrazione dati in RUN"
        End If

    End Sub

    Private Sub SendToArduino(command As String)


        SerialPortArduino.Write(command)

    End Sub

    Private Sub EnableButton()
        'Enable the button of Stiratura
        ButtonLineaGenerale.Enabled = True
        ButtonSvolgitore.Enabled = True
        ButtonEspansore.Enabled = True
        ButtonTabBlanker.Enabled = True
        ButtonMolazza.Enabled = True
        ButtonSpalmatrice.Enabled = True
        ButtonDivider.Enabled = True
        ButtonTunnel.Enabled = True
        ButtonImpilatore.Enabled = True
        ButtonPaletizzatore.Enabled = True
        'Enable the button of Montaggio
        ButtonLineaGeneraleMontaggio.Enabled = True
        ButtonTranciasetti.Enabled = True
        ButtonImbustatrice1.Enabled = True
        ButtonImbustatrice2.Enabled = True
        ButtonBuffer.Enabled = True
        ButtonCOS.Enabled = True
        ButtonProvaCorti1.Enabled = True
        ButtonPuntatrice.Enabled = True
        ButtonProvaCorti2.Enabled = True
        ButtonPosaCoperchi.Enabled = True
        ButtonTermosaldatrice.Enabled = True
        ButtonSaldapolari.Enabled = True
        ButtonProvaPneumatica.Enabled = True
        ButtonProvaAltezzaPolari.Enabled = True
        ButtonMarcatore.Enabled = True
        ButtonPinzaPaletizzatore.Enabled = True
        ButtonRobot.Enabled = True
        ButtonNastriTrasportatori.Enabled = True
        'Disable the button of formazione
        ButtonLineaGeneraleFormazione.Enabled = True
        ButtonPinzaCarico.Enabled = True
        ButtonInseritoreOcchioMagico.Enabled = True
        ButtonPrimoRiempimento.Enabled = True
        ButtonPosaRampeFormazione.Enabled = True
        ButtonRotatoreSpintore1.Enabled = True
        ButtonCarrelloCarico.Enabled = True
        ButtonNastriCarico.Enabled = True
        ButtonNastriScarico.Enabled = True
        ButtonCarrelloScarico.Enabled = True
        'Enable the button of carica
        ButtonLineaGeneraleCarica.Enabled = True
        ButtonRotatore.Enabled = True
        ButtonRovesciatore.Enabled = True
        ButtonDiluitore.Enabled = True
        Button2Riempimento.Enabled = True
        ButtonPosaTogliRampe.Enabled = True
        ButtonTunnelLavaggio.Enabled = True
        ButtonControlloLivelli.Enabled = True
        ButtonTappatrice.Enabled = True
        ButtonPulisciPoli.Enabled = True
        ButtonScaricaRapida.Enabled = True
        ButtonDielettrico.Enabled = True
        ButtonAKSI.Enabled = True
        ButtonMarcatoreCarica.Enabled = True
        ButtonVestizione.Enabled = True
        ButtonControlloVestizione.Enabled = True
        ButtonRobotCarica.Enabled = True
        ButtonScaricoManuale.Enabled = True
        ButtonNastriTrasporto.Enabled = True

    End Sub

    Private Sub disableButton()

        ButtonLineaGenerale.Enabled = False
        ButtonSvolgitore.Enabled = False
        ButtonEspansore.Enabled = False
        ButtonTabBlanker.Enabled = False
        ButtonMolazza.Enabled = False
        ButtonSpalmatrice.Enabled = False
        ButtonDivider.Enabled = False
        ButtonTunnel.Enabled = False
        ButtonImpilatore.Enabled = False
        ButtonPaletizzatore.Enabled = False
        'We disable the button of the main form
        ButtonLineaGeneraleMontaggio.Enabled = False
        ButtonTranciasetti.Enabled = False
        ButtonImbustatrice1.Enabled = False
        ButtonImbustatrice2.Enabled = False
        ButtonBuffer.Enabled = False
        ButtonCOS.Enabled = False
        ButtonProvaCorti1.Enabled = False
        ButtonPuntatrice.Enabled = False
        ButtonProvaCorti2.Enabled = False
        ButtonTermosaldatrice.Enabled = False
        ButtonPosaCoperchi.Enabled = False
        ButtonSaldapolari.Enabled = False
        ButtonProvaPneumatica.Enabled = False
        ButtonProvaAltezzaPolari.Enabled = False
        ButtonMarcatore.Enabled = False
        ButtonPinzaPaletizzatore.Enabled = False
        ButtonRobot.Enabled = False
        ButtonNastriTrasportatori.Enabled = False
        'Disable the button of formazione
        ButtonLineaGeneraleFormazione.Enabled = False
        ButtonPinzaCarico.Enabled = False
        ButtonInseritoreOcchioMagico.Enabled = False
        ButtonPrimoRiempimento.Enabled = False
        ButtonPosaRampeFormazione.Enabled = False
        ButtonRotatoreSpintore1.Enabled = False
        ButtonCarrelloCarico.Enabled = False
        ButtonNastriCarico.Enabled = False
        ButtonNastriScarico.Enabled = False
        ButtonCarrelloScarico.Enabled = False
        'Disable the button of carica
        ButtonLineaGeneraleCarica.Enabled = False
        ButtonRotatore.Enabled = False
        ButtonRovesciatore.Enabled = False
        ButtonDiluitore.Enabled = False
        Button2Riempimento.Enabled = False
        ButtonPosaTogliRampe.Enabled = False
        ButtonTunnelLavaggio.Enabled = False
        ButtonControlloLivelli.Enabled = False
        ButtonTappatrice.Enabled = False
        ButtonPulisciPoli.Enabled = False
        ButtonScaricaRapida.Enabled = False
        ButtonDielettrico.Enabled = False
        ButtonAKSI.Enabled = False
        ButtonMarcatoreCarica.Enabled = False
        ButtonVestizione.Enabled = False
        ButtonControlloVestizione.Enabled = False
        ButtonRobotCarica.Enabled = False
        ButtonScaricoManuale.Enabled = False
        ButtonNastriTrasporto.Enabled = False
    End Sub

    

    Private Sub TextBoxTimbratura_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTimbratura.TextChanged
        If TextBoxTimbratura.Text.Length = 18 Then
            Dim myConn As New SqlConnection(LblPathDatabase.Text)
            'first search the operator in the database
            Dim cmd As SqlCommand
            cmd = myConn.CreateCommand()
            cmd.CommandText = "SELECT COUNT (Cognome) FROM Operatori WHERE IdBadge='" & TextBoxTimbratura.Text & "'"
            cmd.Connection.Open()
            If (cmd.ExecuteScalar()) = 0 Then
                'Do nothing
                cmd.Connection.Close()
                MsgBox("Operatore non riconosciuto", MsgBoxStyle.OkOnly)
                TextBoxTimbratura.Text = ""
            Else
                cmd.Connection.Close()
                'Operator recognized
                Dim myCmd4 As SqlCommand
                myCmd4 = myConn.CreateCommand()
                myCmd4.CommandText = "SELECT Cognome FROM Operatori WHERE ((IdBadge='" & TextBoxTimbratura.Text & "'))"
                myCmd4.Connection.Open()
                LabelCognome.Text = myCmd4.ExecuteScalar()
                myCmd4.Connection.Close()

                Dim myCmd5 As SqlCommand
                myCmd5 = myConn.CreateCommand()
                myCmd5.CommandText = "SELECT Nome FROM Operatori WHERE ((IdBadge='" & TextBoxTimbratura.Text & "'))"
                myCmd5.Connection.Open()
                LabelNome.Text = myCmd5.ExecuteScalar()
                myCmd5.Connection.Close()
                'Now check if the operator is leaving or loading
                Dim myCmd2 As SqlCommand
                myCmd2 = myConn.CreateCommand()
                myCmd2.CommandText = "SELECT COUNT (Cognome) FROM OreOperatori WHERE ((IdBadge='" & TextBoxTimbratura.Text & "')and(DataUscita IS NULL))"
                myCmd2.Connection.Open()
                If (myCmd2.ExecuteScalar()) = 1 Then
                    'The operator is leaving the line
                    myCmd2.Connection.Close()
                    Dim myCmd6 As SqlCommand
                    myCmd6 = myConn.CreateCommand()
                    myCmd6.CommandText = "UPDATE OreOperatori SET DataUscita='" & DataFormatting(DateTime.Now) & "' WHERE ((IdBadge='" & TextBoxTimbratura.Text & "')and(DataUscita IS NULL))"
                    myCmd6.Connection.Open()
                    LabelNome.Text = myCmd6.ExecuteNonQuery()
                    myCmd6.Connection.Close()
                    CheckOperatorLoadedInLineOUT()
                Else
                    'The operator is loading into the line
                    myCmd2.Connection.Close()
                    Dim myCmd3 As SqlCommand
                    myCmd3 = myConn.CreateCommand()
                    myCmd3.CommandText = "INSERT INTO OreOperatori (Id_reparto,Id_linea,Linea,IdBadge,Cognome,Nome,DataEntrata,Reparto)VALUES (" & LblIdDepartment.Text & "," & LblIdLinea.Text & ",'" & LblLineDescription.Text & "','" & TextBoxTimbratura.Text & "','" & LabelCognome.Text & "','" & LabelNome.Text & "','" & DataFormatting(DateTime.Now) & "','" & LblDepartmentDescription.Text & "')"
                    ' Open the connection    
                    myCmd3.Connection.Open()
                    myCmd3.ExecuteNonQuery()
                    myCmd3.Connection.Close()
                    CheckOperatorLoadedInLineIN()
                End If
                LoadManpower()
            End If
            TextBoxTimbratura.Text = ""
        Else
        End If
    End Sub

    Private Sub CheckOperatorLoadedInLineIN()
        'funzione lanciata quando un operatore si è caricato in linea
        Dim myConn As New SqlConnection(LblPathDatabase.Text)
        'first search the operator in the database
        Dim cmd As SqlCommand
        cmd = myConn.CreateCommand()
        cmd.CommandText = "SELECT COUNT (Cognome) FROM OreOperatori WHERE (Id_reparto=" & LblIdDepartment.Text & " AND Id_linea=" & LblIdLinea.Text & " AND DataUscita IS NULL)"
        cmd.Connection.Open()
        If cmd.ExecuteScalar() = 1 Then
            'It is the first operator loaded in line, so we start the line
            cmd.Connection.Close()
            'Turn on the green lamp
            SendToArduino("5")
            OvalShapeGreen.FillColor = Color.Green
            'Turn off yellow lamp
            OvalShapeYellow.FillColor = Color.Silver
            SendToArduino("2")
            OvalShapeRed.FillColor = Color.Silver
            'Turn off the red lamp
            SendToArduino("0")


            Dim myCmd2 As SqlCommand
            myCmd2 = myConn.CreateCommand()
            myCmd2.CommandText = "UPDATE StatoLinee SET Stato='Marcia' WHERE (Id_Reparto=" & LblIdDepartment.Text & " AND Id_Linea=" & LblIdLinea.Text & ")"

            myCmd2.Connection.Open()
            myCmd2.ExecuteNonQuery()
            myCmd2.Connection.Close()
            TimerForRoutineRegistrationData.Start()
            LabelStatus.Text = "Registrazione dati in RUN"

            SceltaLancio.Show()

        Else
            'There is already at least one operator loaded in to the line
            'we do nothing
        End If

    End Sub

    Private Sub CheckOperatorLoadedInLineOUT()

        Dim myConn As New SqlConnection(LblPathDatabase.Text)
        'first search the operator in the database
        Dim cmd As SqlCommand
        cmd = myConn.CreateCommand()
        cmd.CommandText = "SELECT COUNT (Cognome) FROM OreOperatori WHERE (Id_reparto=" & LblIdDepartment.Text & " AND Id_linea=" & LblIdLinea.Text & " AND DataUscita IS NULL)"
        cmd.Connection.Open()
        If cmd.ExecuteScalar() = 0 Then
            'There is no operator loaded in to the line, so we stop the line
            cmd.Connection.Close()
            TimerForRoutineRegistrationData.Stop()
            LabelStatus.Text = "Registrazione dati in STOP"

            OvalShapeRed.FillColor = Color.Red
            'Turn on the red lamp
            SendToArduino("1")
            'Turn off yellow lamp
            OvalShapeYellow.FillColor = Color.Silver
            SendToArduino("2")
            'Turn off green lamp
            OvalShapeGreen.FillColor = Color.Silver
            SendToArduino("4")
            'We put the line in STOP in the DB

            Dim myCmd As SqlCommand
            myCmd = myConn.CreateCommand()
            myCmd.CommandText = "UPDATE StatoLinee SET Stato='Stop' WHERE (Id_Reparto=" & LblIdDepartment.Text & " AND Id_Linea=" & LblIdLinea.Text & ")"

            myCmd.Connection.Open()
            myCmd.ExecuteNonQuery()
            myCmd.Connection.Close()

        Else
            'There is at least one more operator loaded in to the line
            'we do nothing
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonScegliLancioProduzione.Click
        SceltaLancio.Show()
    End Sub

 

    Private Sub ButtonPinzaCarico_Click(sender As Object, e As EventArgs) Handles ButtonPinzaCarico.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "05"
        Dim DescMacchina As String = "Pinza carico manuale"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonInseritoreOcchioMagico_Click(sender As Object, e As EventArgs) Handles ButtonInseritoreOcchioMagico.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "10"
        Dim DescMacchina As String = "Inseritore occhio magico"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonPrimoRiempimento_Click(sender As Object, e As EventArgs) Handles ButtonPrimoRiempimento.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "15"
        Dim DescMacchina As String = "1° riempimento"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonPosaRampeFormazione_Click(sender As Object, e As EventArgs) Handles ButtonPosaRampeFormazione.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "20"
        Dim DescMacchina As String = "Posa rampe"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonRotatoreSpintore1_Click(sender As Object, e As EventArgs) Handles ButtonRotatoreSpintore1.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "25"
        Dim DescMacchina As String = "Rotatore e spintore 1°riempimento"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonCarrelloCarico_Click(sender As Object, e As EventArgs) Handles ButtonCarrelloCarico.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "30"
        Dim DescMacchina As String = "Carrello carico"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonNastriCarico_Click(sender As Object, e As EventArgs) Handles ButtonNastriCarico.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "35"
        Dim DescMacchina As String = "Nastri carico"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonNastriScarico_Click(sender As Object, e As EventArgs) Handles ButtonNastriScarico.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "40"
        Dim DescMacchina As String = "Nastri scarico"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub

    Private Sub ButtonCarrelloScarico_Click(sender As Object, e As EventArgs) Handles ButtonCarrelloScarico.Click
        Dim pass As String = LabelIdFermo.Text
        Dim idMacchina As String = "45"
        Dim DescMacchina As String = "Carrello scarico"
        Dim Frm As New FormMacchina(pass, idMacchina, DescMacchina)
        Frm.ShowDialog()
    End Sub
End Class
