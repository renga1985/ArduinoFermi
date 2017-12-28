Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO

Public Class VisualizzaFermateManuale

    Private Sub VisualizzaFermateManuale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateGridFermi()
    End Sub


    Sub UpdateGridFermi()

        Dim myConn As New SqlConnection(FormManualInput.LabelPath.Text)
        Dim myCmd As SqlCommand
        myCmd = myConn.CreateCommand()
        myCmd.CommandText = "SELECT Id,DataInizioFermo,DataFineFermo,DescReparto,DescLinea,DescMacchina,DescFermo,Durata,SECONDARIO,Da,A FROM Fermi WHERE (DataInizioFermo >= '" & FormManualInput.DateTimePicker1.Value.Year().ToString() & "-" & FormManualInput.DateTimePicker1.Value.Day().ToString() & "-" & FormManualInput.DateTimePicker1.Value.Month().ToString() & " 00:00:00' ) AND (DataInizioFermo <= '" & FormManualInput.DateTimePicker1.Value.Year().ToString() & "-" & FormManualInput.DateTimePicker1.Value.Day().ToString() & "-" & FormManualInput.DateTimePicker1.Value.Month().ToString() & " 23:59:59') AND (DescFermoEsteso = 'MANUALE') ORDER BY Id"
        myCmd.Connection.Open()
        Dim dtRegistro As DataTable = New DataTable
        Dim myDataAdapter As New SqlDataAdapter(myCmd)
        myDataAdapter.Fill(dtRegistro)
        DataGridViewFermi.DataSource = dtRegistro
        myCmd.Connection.Close()

    End Sub

    Sub UpdateFermi()

        Dim myConn As New SqlConnection(FormManualInput.LabelPath.Text)
        Dim myCmd As SqlCommand
        Dim myCmd2 As SqlCommand
        myCmd = myConn.CreateCommand()
        myCmd2 = myConn.CreateCommand()
        myCmd.CommandText = "SELECT Id,DataInizioFermo,DataFineFermo,DescReparto,DescLinea,DescMacchina,DescFermo,Durata,SECONDARIO,Da,A FROM Fermi WHERE (DataInizioFermo >= '" & FormManualInput.DateTimePicker1.Value.Year().ToString() & "-" & FormManualInput.DateTimePicker1.Value.Day().ToString() & "-" & FormManualInput.DateTimePicker1.Value.Month().ToString() & " 00:00:00' ) AND (DataInizioFermo <= '" & FormManualInput.DateTimePicker1.Value.Year().ToString() & "-" & FormManualInput.DateTimePicker1.Value.Day().ToString() & "-" & FormManualInput.DateTimePicker1.Value.Month().ToString() & " 23:59:59') AND (DescFermoEsteso = 'MANUALE') ORDER BY Id"
        myCmd2.CommandText = "UPDATE Fermi SET DescReparto=@DescReparto WHERE Id=@OriginalId"
        myCmd.Connection.Open()
        Dim dtRegistro As DataTable = New DataTable
        Dim myDataAdapter As New SqlDataAdapter(myCmd)
        myDataAdapter.Fill(dtRegistro)
        DataGridViewFermi.DataSource = dtRegistro
        myCmd.Connection.Close()
        myCmd2.Connection.Open()
        myDataAdapter.Update(dtRegistro)
        myCmd2.Connection.Close()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateFermi()
    End Sub
End Class