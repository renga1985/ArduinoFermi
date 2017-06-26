Public Class Utility

    Private Sub ButtonResetCounter_Click(sender As Object, e As EventArgs) Handles ButtonResetCounter.Click
        Form1.SerialPortArduino.Open()
        'Reset the counter
        Form1.SerialPortArduino.Write("7")
        Form1.SerialPortArduino.Close()
    End Sub
End Class