Imports System.IO.Ports
Imports System.Data.OleDb
Imports System.Configuration
Imports System.IO
Imports System.Data.SqlClient

Public Class Utility
    Dim SerialPort As New IO.Ports.SerialPort

    Private Sub Utility_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim myConn As New SqlConnection(LabelPath.Text)

        Dim myCmd1 As SqlCommand
        myCmd1 = myConn.CreateCommand()
        myCmd1.CommandText = "SELECT [Codice Linea] FROM Linee WHERE (IdReparto='" & LblIdDepartment.Text & "') AND (IdLinea='" & LblIdLIne.Text & "')"
        myCmd1.Connection.Open()
        Dim CodiceLinea As String
        CodiceLinea = myCmd1.ExecuteScalar()
        myCmd1.Connection.Close()


        Dim myCmd2 As SqlCommand
        myCmd2 = myConn.CreateCommand()
        myCmd2.CommandText = "SELECT * FROM LanciProduzione WHERE (Linea='" & CodiceLinea & "') AND ((StatoLancio='Sospeso') OR (StatoLancio IS NULL))"

        myCmd2.Connection.Open()
        Dim ds As New DataSet
        Dim adapter As New SqlDataAdapter(myCmd2.CommandText, myConn)
        adapter.Fill(ds)
        'myReader.Close()
        myCmd2.Connection.Close()

        ComboBox1.DataSource = ds.Tables(0)
        ComboBox1.ValueMember = "Ordpian"
        ComboBox1.DisplayMember = "Ordpian"

        ComboBox1.Text = ""
        TextBox1.Text = ""

        'SetUpSerialConnection()
        'SerialPortArduino.Open()
        'SendToArduino("6")

    End Sub

    Private Sub SendToArduino(command As String)


        'SerialPortArduino.Write(command)

    End Sub

    Private Sub SetUpSerialConnection()
        '    Try
        'Now we can set up the serial connection
        'SerialPortArduino.BaudRate = 9600
        'SerialPortArduino.DataBits = 8
        'SerialPortArduino.Parity = Parity.None
        'SerialPortArduino.StopBits = StopBits.One
        'SerialPortArduino.Handshake = Handshake.None
        'SerialPortArduino.Encoding = System.Text.Encoding.Default 'very important!
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Text = ComboBox1.Text
    End Sub



End Class