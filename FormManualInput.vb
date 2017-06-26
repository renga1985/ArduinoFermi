Imports System.Data.SqlClient
Imports System.IO

Public Class FormManualInput

    Private Sub FormManualInput_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim path As String = "C:\ArduinoFermi\config.txt"
        Try
            Dim sr As StreamReader = New StreamReader(path)
            Do While sr.Peek() >= 0
                Dim rowstring As String = sr.ReadLine()

                'Retrive DatabasePath
                If Strings.Left(rowstring, 14) = "[DatabasePath]" Then
                    'We save this also in a label of the application
                    LabelPath.Text = rowstring.Substring(15, rowstring.Length - 15)
                End If
            Loop
            sr.Close()
        Catch ex As Exception
            MsgBox("Si è verificato un errore nel recupero delle informazioni dal file config.txt")
        End Try
    End Sub

    Private Sub ButtonRegistra_Click(sender As Object, e As EventArgs) Handles ButtonRegistra.Click

        Dim myConn = New SqlConnection(LabelPath.Text)

        Dim myCmd4 As SqlCommand
        myCmd4 = myConn.CreateCommand()
        myCmd4.CommandText = "INSERT INTO Fermi (Id,Data)VALUES (" & 1 & ",'" & DateTime.Now().Year.ToString() & "-" & DateTime.Now().Month.ToString() & "-" & DateTime.Now.Day.ToString & " " & DateTime.Now.Hour.ToString & ":" & DateTime.Now.Minute.ToString & ":" & DateTime.Now.Second.ToString & "')"

        myCmd4.Connection.Open()
        Dim numberOfRow As Int16 = myCmd4.ExecuteNonQuery()
        myCmd4.Connection.Close()



    End Sub

    Private Sub TextBoxReparto_TextChanged(sender As Object, e As EventArgs) Handles TextBoxReparto.TextChanged
        If TextBoxReparto.Text <> "" Then
            Dim myConn = New SqlConnection(LabelPath.Text)

            Dim myCmd As SqlCommand
            myCmd = myConn.CreateCommand()
            myCmd.CommandText = "SELECT Reparto FROM Reparti WHERE Id_reparto=" & TextBoxReparto.Text & ""
            myCmd.Connection.Open()
            LabelRepartoSelected.Text = myCmd.ExecuteScalar()
            myCmd.Connection.Close()
        End If

    End Sub


    Private Sub TextBoxLinea_TextChanged(sender As Object, e As EventArgs) Handles TextBoxLinea.TextChanged
        If TextBoxLinea.Text <> "" Then
            Dim myConn = New SqlConnection(LabelPath.Text)

            Dim myCmd As SqlCommand
            myCmd = myConn.CreateCommand()
            myCmd.CommandText = "SELECT Linea FROM Linee WHERE (Id_reparto=" & TextBoxReparto.Text & " AND Id_linea=" & TextBoxLinea.Text & ")"
            myCmd.Connection.Open()
            LabelLineaSelected.Text = myCmd.ExecuteScalar()
            myCmd.Connection.Close()
        End If
    End Sub

    Private Sub TextBoxMacchina_TextChanged(sender As Object, e As EventArgs) Handles TextBoxMacchina.TextChanged
        If TextBoxMacchina.Text <> "" Then
            Dim myConn = New SqlConnection(LabelPath.Text)

            Dim myCmd As SqlCommand
            myCmd = myConn.CreateCommand()
            myCmd.CommandText = "SELECT Macchina FROM Macchine WHERE (Id_reparto=" & TextBoxReparto.Text & " AND Id_linea=" & TextBoxLinea.Text & "AND Id_macchina=" & TextBoxMacchina.Text & ")"
            myCmd.Connection.Open()
            LabelMacchinaSelected.Text = myCmd.ExecuteScalar()
            myCmd.Connection.Close()
        End If
    End Sub
End Class