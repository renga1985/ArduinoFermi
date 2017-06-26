Imports System.Configuration
Imports System.Data.OleDb
Imports System.Data.SqlClient



Public Class VisualizzaFermate

    Sub UpdateGrid()


        Dim myConn = New SqlConnection(Form1.LblPathDatabase.Text)
        Dim myCmd As SqlCommand
        myCmd = myConn.CreateCommand()
        myCmd.CommandText = "SELECT Id,Data,DescReparto,DescLinea,DescMacchina,DescFermo,Durata,Datafinefermo FROM Fermi WHERE (DATA >= '" & DateTimePickerFrom.Value.ToString("yyyy-MM-ddTHH:mm:ss") & "')AND(DATA <= '" & DateTimePickerTo.Value.ToString("yyyy-MM-ddTHH:mm:ss") & "')AND(IdReparto=" & Form1.LblIdDepartment.Text & ")AND(IdLinea=" & Form1.LblIdLinea.Text & ")"

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
        UpdateGrid()
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        UpdateGrid()
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
End Class