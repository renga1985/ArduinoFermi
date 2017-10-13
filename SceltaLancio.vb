Imports System.Data.SqlClient

Public Class SceltaLancio

    Private Sub SceltaLancio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myConn As New SqlConnection(Form1.LblPathDatabase.Text)
        Dim myCmd As SqlCommand
        myCmd = myConn.CreateCommand()
        myCmd.CommandText = "SELECT * FROM LanciProduzione"

        myCmd.Connection.Open()
        
        Dim ds As New DataSet
        Dim adapter As New SqlDataAdapter(myCmd.CommandText, myConn)
        adapter.Fill(ds)
        'myReader.Close()
        myCmd.Connection.Close()

        ComboBoxLancio.DataSource = ds.Tables(0)
        ComboBoxLancio.ValueMember = "Ordpian"
        ComboBoxLancio.DisplayMember = "Ordpian"

    End Sub


    Private Sub ComboBoxLancio_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBoxLancio.SelectionChangeCommitted
        Dim myConn As New SqlConnection(Form1.LblPathDatabase.Text)
        Dim myCmd As SqlCommand
        myCmd = myConn.CreateCommand()
        myCmd.CommandText = "Update STATOLINEE SET LANCIOINCORSO=" & ComboBoxLancio.SelectedValue.ToString() & " WHERE (Id_reparto=" & Form1.LblIdDepartment.Text.ToString() & " AND Id_linea=" & Form1.LblIdLinea.Text & ")"

        myCmd.Connection.Open()
        myCmd.ExecuteNonQuery()
        myCmd.Connection.Close()
        Me.Close()
    End Sub
End Class