Imports System.IO

Public Class Launcher

    Private Sub Launcher_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'We take some other parameters from config.txt
        Dim path As String = "C:\ArduinoFermi\config.txt"
        'Try
        Dim sr As StreamReader = New StreamReader(path)
        Do While sr.Peek() >= 0
            Dim rowstring As String = sr.ReadLine()
            'Retrive Auto or Manual Insert
            If Strings.Left(rowstring, 6) = "[Mode]" Then
                If rowstring.Substring(7, rowstring.Length - 7) = "Manual" Then
                    FormManualInput.Show()
                    Me.Close()
                End If
                If rowstring.Substring(7, rowstring.Length - 7) = "Auto" Then
                    Form1.Show()
                    Me.Close()
                End If
                If rowstring.Substring(7, rowstring.Length - 7) = "Viewer" Then
                    DashboardProduzione.Show()
                    Me.Close()
                End If
                Exit Do
            End If
        Loop
        sr.Close()

    End Sub

End Class