Imports System.IO
Imports System.Data.SqlClient

Public Class LineViewer

    Private Sub LineViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'We take some other parameters from config.txt
        Dim path As String = "C:\ArduinoFermi\config.txt"
        'Try
        Dim sr As StreamReader = New StreamReader(path)
        Do While sr.Peek() >= 0
            Dim rowstring As String = sr.ReadLine()
            'Retrive DatabasePath
            If Strings.Left(rowstring, 14) = "[DatabasePath]" Then
                'We save this also in a label of the application
                LabelPathDatabase.Text = rowstring.Substring(15, rowstring.Length - 15)
            End If
            'Retrive IdDepartment
            If Strings.Left(rowstring, 14) = "[IdDepartment]" Then
                ''We save this also in a label of the application
                LabelIdDepartment.Text = rowstring.Substring(15, rowstring.Length - 15)
            End If

            'Retrive DepartmentDescription
            If Strings.Left(rowstring, 23) = "[DepartmentDescription]" Then
                ''We save this also in a label of the application
                LabelReparto.Text = rowstring.Substring(24, rowstring.Length - 24)
                'We delete the tab page that we don not use
            End If

            'Retrive IdLine
            If Strings.Left(rowstring, 8) = "[IdLine]" Then
                ''We save this also in a label of the application
                LabelIdLine.Text = rowstring.Substring(9, rowstring.Length - 9)
            End If

            'Retrive LineDescription
            If Strings.Left(rowstring, 17) = "[LineDescription]" Then
                ''We save this also in a label of the application
                LabelLinea.Text = rowstring.Substring(18, rowstring.Length - 18)
                'Here we have to use Me instead of Form1 to don't have an error
                Me.Text = Me.Text & " - " & rowstring.Substring(18, rowstring.Length - 18)
            End If

        Loop
        sr.Close()

        LabelPz.Text = ShiftProduction(LabelIdDepartment.Text, LabelIdLine.Text)

        TimerUpdate.Start()

    End Sub

    Private Sub TimerUpdate_Tick(sender As Object, e As EventArgs) Handles TimerUpdate.Tick
        LabelPz.Text = ShiftProduction(LabelIdDepartment.Text, LabelIdLine.Text)
    End Sub

    Function ShiftProduction(Reparto As String, Linea As String)
        Dim ProductionofShift As String = 0
        Dim OraAttuale As DateTime
        OraAttuale = DateTime.Now()

        Dim myConn As New SqlConnection(LabelPathDatabase.Text)
        Dim myCmd As SqlCommand
        myCmd = myConn.CreateCommand()
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

        myCmd.CommandText = "SELECT SUM(ProduzioneStep) FROM DatiProduzione WHERE ((Id_reparto=" & Reparto & ")AND(Id_linea=" & Linea & ")AND(Data>='" & dataDa.ToString & "')AND(Data<='" & dataA.ToString() & "'))"

        'Section to update the production shift
        myCmd.Connection.Open()
        If (IsDBNull(myCmd.ExecuteScalar())) Then
        Else
            ProductionofShift = myCmd.ExecuteScalar()
        End If
        myCmd.Connection.Close()
        Return ProductionofShift
    End Function

End Class