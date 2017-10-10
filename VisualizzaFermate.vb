Imports System.Configuration
Imports System.Data.OleDb
Imports System.Data.SqlClient



Public Class VisualizzaFermate

    Sub UpdateGrid()

        'Definisco la stringa inizio e ci salvo la data di inizio fermo secondo il formato richiesto
        Dim data As Date
        data = DateTimePickerFrom.Text
        Dim inizio As String
        'inizio = data.Year.ToString() & "-" & data.Month.ToString() & "-" & data.Day.ToString() & " 00:00:00"
        inizio = data.Year.ToString() & "-" & data.Day.ToString() & "-" & data.Month.ToString() & " 00:00:00"

        'Definisco la stringa fine e ci salvo la data di inizio fermo secondo il formato richiesto
        Dim data2 As Date
        data2 = DateTimePickerTo.Text
        Dim fine As String
        'fine = data.Year.ToString() & "-" & data.Month.ToString() & "-" & data.Day.ToString() & " 00:00:00"
        fine = data.Year.ToString() & "-" & data.Day.ToString() & "-" & data.Month.ToString() & " 00:00:00"

        Dim myConn = New SqlConnection(Form1.LblPathDatabase.Text)
        Dim myCmd As SqlCommand
        myCmd = myConn.CreateCommand()
        'myCmd.CommandText = "SELECT Id,Data,DescReparto,DescLinea,DescMacchina,DescFermo,Durata,Datafinefermo FROM Fermi WHERE (DATA >= '" & DateTimePickerFrom.Value.ToString("yyyy-MM-ddTHH:mm:ss") & "')AND(DATA <= '" & DateTimePickerTo.Value.ToString("yyyy-MM-ddTHH:mm:ss") & "')AND(IdReparto=" & Form1.LblIdDepartment.Text & ")AND(IdLinea=" & Form1.LblIdLinea.Text & ")"
        'myCmd.CommandText = "SELECT Id,Data,DescReparto,DescLinea,DescMacchina,DescFermo,Durata,Datafinefermo FROM Fermi WHERE (DATA >= '" & inizio & "')AND(DATA <= '" & fine & "')AND(IdReparto=" & Form1.LblIdDepartment.Text & ")AND(IdLinea=" & Form1.LblIdLinea.Text & ")"
        'myCmd.CommandText = "SELECT Id,Data,IdReparto,DescReparto,IdLinea,DescLinea,IdMacchina,DescMacchina,IdFermo,DescFermo,Inizio,Durata,Datafinefermo FROM Fermi"
        myCmd.CommandText = "SELECT Id,DescMacchina,DescFermo,Durat FROM Fermi"

        myCmd.Connection.Open()
        Dim dtRegistro As DataTable = New DataTable
        Dim myDataAdapter As New SqlDataAdapter(myCmd)
        myDataAdapter.Fill(dtRegistro)
        DataGridViewFernate.DataSource = dtRegistro
        myCmd.Connection.Close()

        '------------------
        'Dim fileAccess As String = Form1.LblPathDatabase.Text
        'Dim conAccess = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & fileAccess & ";")
        'Dim queryAccess = "SELECT Id,Data,DescReparto,DescLinea,DescMacchina,DescFermo,Durata,Datafinefermo FROM Fermi WHERE (DATA >= #" & DateTimePickerFrom.Value.Month.ToString & "/" & DateTimePickerFrom.Value.Day.ToString & "/" & DateTimePickerFrom.Value.Year.ToString & " 00:00:00#)AND(DATA <= #" & DateTimePickerTo.Value.Month.ToString & "/" & DateTimePickerTo.Value.Day.ToString & "/" & DateTimePickerTo.Value.Year.ToString & " 23:59:59#)AND(IdReparto=" & Form1.LblIdDepartment.Text & ")AND(IdLinea=" & Form1.LblIdLinea.Text & ")"
        'Dim cmd As New OleDb.OleDbCommand(queryAccess, conAccess)
        'conAccess.Open()
        'Dim dtRegistro As DataTable = New DataTable
        'Dim myDataAdapter As New OleDbDataAdapter(cmd)
        'myDataAdapter.Fill(dtRegistro)
        'DataGridViewFernate.DataSource = dtRegistro
        'conAccess.Close()
    End Sub

    Private Sub VisualizzaFermate_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: questa riga di codice carica i dati nella tabella 'VRNFermiDataSet.Fermi'. È possibile spostarla o rimuoverla se necessario.
        Me.FermiTableAdapter.Fill(Me.VRNFermiDataSet.Fermi)

        'Dim myConn = New SqlConnection(Form1.LblPathDatabase.Text)
        'Dim myCmd As SqlCommand
        'myCmd = myConn.CreateCommand()
        'myCmd.CommandText = "UPDATE LineaAttiva SET [IdReparto]=" & Form1.LblIdDepartment.Text & ", [IdLine]=" & Form1.LblIdLinea.Text & " WHERE [Id]=1"

        'UpdateGrid()
        UpdateGrid2()
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        Dim myConn = New SqlConnection(Form1.LblPathDatabase.Text)
        Dim myCmd As SqlCommand
        myCmd = myConn.CreateCommand()
        myCmd.CommandText = "SELECT From LineaAttiva IdReparto WHERE [Id]=1"
        'myCmd.CommandText = "UPDATE LineaAttiva SET IdReparto=" & Form1.LblIdDepartment.Text & ", IdLine=" & Form1.LblIdLinea.Text & " WHERE [Id]=1"
    End Sub
    Sub UpdateGrid2()
        Me.FermiTableAdapter.Fill(Me.VRNFermiDataSet.Fermi)
    End Sub

    Sub UpdateDatabase()

        Dim myConn = New SqlConnection(Form1.LblPathDatabase.Text)
        Dim myCmd As SqlCommand
        myCmd = myConn.CreateCommand()
        'myCmd.CommandText = "UPDATE Fermi2 SET DescMacchina=@pDescMacchina,DescFermo=@pDescFermo,Durata=@pDurata WHERE Id=@pId"
        myCmd.CommandText = "UPDATE [dbo].[Fermi2] SET [Id] = @Id, [DescMacchina] = @DescMacchina, [DescFermo] = @DescFermo, [Durat] = @Durat WHERE (([Id] = @Original_Id) AND ((@IsNull_DescMacchina = 1 AND [DescMacchina] IS NULL) OR ([DescMacchina] = @Original_DescMacchina)) AND ((@IsNull_DescFermo = 1 AND [DescFermo] IS NULL) OR ([DescFermo] = @Original_DescFermo)) AND ((@IsNull_Durat = 1 AND [Durat] IS NULL) OR ([Durat] = @Original_Durat))); SELECT Id, DescMacchina, DescFermo, Durat FROM Fermi2 WHERE (Id = @Id)"
        myCmd.Connection.Open()
        Dim dtRegistro As DataTable = New DataTable
        Dim myDataAdapter As New SqlDataAdapter(myCmd)
        myDataAdapter.Update(dtRegistro)
        DataGridViewFernate.DataSource = dtRegistro
        myCmd.Connection.Close()

    End Sub

    Sub UpdateDatabase2()
        Me.FermiTableAdapter.Update(Me.VRNFermiDataSet.Fermi)
    End Sub
    'Private Sub BtnExportInExcel_Click(sender As Object, e As EventArgs) Handles BtnExportInExcel.Click
    '    'Funzione che esporta in excel ciò che è visualizzato in quel momento nella GridView della pagina Registro
    '    'NOTA: Utilizzo un secondo GridView in quanto nel primo ho la prima colonna contente un'immagine che potrebbe darmi problemi
    '    'nell'importazione, inoltre ignoro il fatto che la prima GridView è divisa in pagine
    '    If DataGridViewFernate.Rows.Count.ToString + 1 < 65536 Then
    '        Dim excel As Microsoft.Office.Interop.Excel.ApplicationClass
    '        Dim wBook As Microsoft.Office.Interop.Excel.Workbook
    '        Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

    '        wBook = excel.Workbooks.Add()
    '        wSheet = wBook.ActiveSheet()

    '        Dim dt As DataTable = New DataTable
    '        Dim dset As DataSet
    '        dt = dset.Tables(0)
    '        Dim dc As System.Data.DataColumn
    '        Dim dr As System.Data.DataRow
    '        Dim colIndex As Integer = 0
    '        Dim rowIndex As Integer = 0


    '        Dim fileAccess As String = ConfigurationManager.ConnectionStrings("ArduinoFermi.My.MySettings.DatabaseFermiConnectionString").ConnectionString
    '        Dim conAccess = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & fileAccess & ";")
    '        Dim queryAccess = "SELECT Id,Data,DescReparto,DescLinea,DescMacchina,DescFermo,Durata,Datafinefermo FROM Fermi WHERE (DATA >= #" & DateTimePickerFrom.Value.Month.ToString & "/" & DateTimePickerFrom.Value.Day.ToString & "/" & DateTimePickerFrom.Value.Year.ToString & " 00:00:00#)AND(DATA <= #" & DateTimePickerTo.Value.Month.ToString & "/" & DateTimePickerTo.Value.Day.ToString & "/" & DateTimePickerTo.Value.Year.ToString & " 23:59:59#)"
    '        Dim cmd As New OleDb.OleDbCommand(queryAccess, conAccess)
    '        conAccess.Open()
    '        ' Dim dt As DataTable = New DataTable
    '        Dim myDataAdapter As New OleDbDataAdapter(cmd)
    '        myDataAdapter.Fill(dt)
    '        DataGridViewFernate.DataSource = dt
    '        conAccess.Close()

    '        For Each dc In dt.Columns
    '            colIndex = colIndex + 1
    '            excel.Cells(1, colIndex) = dc.ColumnName
    '        Next

    '        For Each dr In dt.Rows
    '            rowIndex = rowIndex + 1
    '            colIndex = 0
    '            For Each dc In dt.Columns
    '                colIndex = colIndex + 1
    '                excel.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)

    '            Next
    '        Next

    '        wSheet.Columns.AutoFit()
    '        Dim strFileName As String = "D:\ss.xls"
    '        Dim blnFileOpen As Boolean = False
    '        Try
    '            Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strFileName)
    '            fileTemp.Close()
    '        Catch ex As Exception
    '            blnFileOpen = False
    '        End Try

    '        If System.IO.File.Exists(strFileName) Then
    '            System.IO.File.Delete(strFileName)
    '        End If

    '        wBook.SaveAs(strFileName)
    '        excel.Workbooks.Open(strFileName)
    '        excel.Visible = True
    '    Else

    '    End If
    'End Sub

    Private Sub SaveClick(sender As Object, e As EventArgs) Handles ButtonSave.Click

        'UpdateDatabase()
        UpdateDatabase2()

    End Sub
End Class