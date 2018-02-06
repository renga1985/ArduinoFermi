Imports System.IO.Ports
Imports System.Data.OleDb
Imports System.Configuration
Imports System.IO
Imports System.Data.SqlClient

Public Class Utility
    Dim SerialPort As New IO.Ports.SerialPort

    Private Sub Utility_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Dim myConn As New SqlConnection(LabelPath.Text)

        'Dim myCmd1 As SqlCommand
        'myCmd1 = myConn.CreateCommand()
        'myCmd1.CommandText = "SELECT [Codice Linea] FROM Linee WHERE (IdReparto='" & LblIdDepartment.Text & "') AND (IdLinea='" & LblIdLIne.Text & "')"
        'myCmd1.Connection.Open()
        'Dim CodiceLinea As String
        'CodiceLinea = myCmd1.ExecuteScalar()
        'myCmd1.Connection.Close()


        'Dim myCmd2 As SqlCommand
        'myCmd2 = myConn.CreateCommand()
        'myCmd2.CommandText = "SELECT * FROM LanciProduzione WHERE (Linea='" & CodiceLinea & "') AND ((StatoLancio='Sospeso') OR (StatoLancio IS NULL))"

        'myCmd2.Connection.Open()
        'Dim ds As New DataSet
        'Dim adapter As New SqlDataAdapter(myCmd2.CommandText, myConn)
        'adapter.Fill(ds)
        ''myReader.Close()
        'myCmd2.Connection.Close()

        'ComboBox1.DataSource = ds.Tables(0)
        'ComboBox1.ValueMember = "Ordpian"
        'ComboBox1.DisplayMember = "Ordpian"

        'ComboBox1.Text = ""
        'TextBox1.Text = ""

        RetriveParametersFromConfigTxt()
        SetUpSerialConnection()

        SerialPortpeso.Open()

        If SerialPortpeso.BytesToRead() > 0 Then
            LabelProduzioneNascosto.Text = SerialPortpeso.ReadLine()
        Else
        End If

        'SendToArduino("6")

    End Sub


    Private Sub RetriveParametersFromConfigTxt()
        'We take some other parameters from config.txt
        Dim path As String = "C:\ArduinoFermi\config.txt"
        'Try
        Dim sr As StreamReader = New StreamReader(path)
        Do While sr.Peek() >= 0
            Dim rowstring As String = sr.ReadLine()

            'We retrive the serial port for connection
            If Strings.Left(rowstring, 9) = "[COMPort]" Then
                ''We save this also in a string to set up after the serial connection
                Dim COMPort As String = rowstring.Substring(10, rowstring.Length - 10)
                'SerialPortArduino.Close()
                SerialPortpeso.PortName = COMPort 'change com port to match your Arduino port
            End If
        Loop
        sr.Close()
        'Now we have to check if into the DB there are a stop not closed in the correct way
        'If we erase it and we show a message to the user


    End Sub

    Private Sub SendToArduino(command As String)


        'SerialPortArduino.Write(command)

    End Sub

    Private Sub SetUpSerialConnection()
        '    Try
        'Now we can set up the serial connection
        SerialPortpeso.BaudRate = 9600
        SerialPortpeso.DataBits = 8
        SerialPortpeso.Parity = Parity.None
        SerialPortpeso.StopBits = StopBits.One
        SerialPortpeso.Handshake = Handshake.None
        SerialPortpeso.Encoding = System.Text.Encoding.Default 'very important!
        'SerialPortArduino.ReadTimeout = 200

        'LblStatus.Text = ""
        'ButtonRitentaConnessione.Visible = False
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

    Private Sub TimerForRoutineRegistrationData_Tick(sender As Object, e As EventArgs) Handles TimerForRoutineRegistrationData.Tick

        'LabelProduzioneNascosto.Text = SerialPortArduino.ReadLine()

    End Sub

    Private Sub ButtonResetCounter_Click(sender As Object, e As EventArgs) Handles ButtonResetCounter.Click
        'Form1.SerialPortArduino.Open()
        'Reset the counter
        'Form1.SerialPortArduino.Write("7")
        'Form1.SerialPortArduino.Close()
    End Sub




End Class