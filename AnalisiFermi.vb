Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO

Public Class AnalisiFermi

    Dim IdReparto As String = ""
    Dim Reparto As String = ""
    Dim IdLinea As String = ""
    Dim Linea As String = ""
    Public Sub New(ByVal empidRep As String, ByVal empRep As String, ByVal empidLin As String, ByVal empLin As String)
        InitializeComponent()
        IdReparto = empidRep
        Reparto = empRep
        IdLinea = empidLin
        Linea = empLin
    End Sub

    Private Sub AnalisiFermi_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: questa riga di codice carica i dati nella tabella 'VRNFermiDataSet.Fermi'. È possibile spostarla o rimuoverla se necessario.
        ' Me.FermiTableAdapter.Fill(Me.VRNFermiDataSet.Fermi)
        'TODO: questa riga di codice carica i dati nella tabella 'VRNFermiDataSet.Fermi'. È possibile spostarla o rimuoverla se necessario.
        ' Me.FermiTableAdapter.Fill(Me.VRNFermiDataSet.Fermi)
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
        Loop
        Dim datada As DateTime = DateTime.Now().AddHours(-8)
        ComboBoxDa.SelectedItem = datada.Hour.ToString()
        ComboBoxA.SelectedItem = DateTime.Now().Hour.ToString()
        Dim dataGeneraleDa As DateTime = DateTime.Now().AddHours(-8)
        ComboBoxGeneraleDa.SelectedItem = dataGeneraleDa.Hour.ToString()
        ComboBoxGeneraleA.SelectedItem = DateTime.Now().Hour.ToString()
        UpdateChart()
        UpdateChartGenerale()
        UpdateGridFermi()
        UpdateGridOperatori()
        UpdateLanci()
        LabelTitolo.Text = Reparto + "-" + Linea
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        UpdateChart()
        UpdateChartGenerale()
        UpdateGridFermi()
        UpdateGridOperatori()
        UpdateLanci()
    End Sub

    Function DataFormatting(Datadaconvertire As DateTime)
        Dim dataconvertita As String
        dataconvertita = Datadaconvertire.Year().ToString() & "-" & Datadaconvertire.Day().ToString() & "-" & Datadaconvertire.Month().ToString() & " " & Datadaconvertire.Hour().ToString() & ":" & Datadaconvertire.Minute().ToString() & ":" & Datadaconvertire.Second().ToString()

        Return dataconvertita
    End Function

    Sub UpdateLanci()
        Dim myConn As New SqlConnection(LabelPathDatabase.Text)
        Dim myCmd As SqlCommand
        myCmd = myConn.CreateCommand()
        myCmd.CommandText = "SELECT Lancio,Codice,Pallett,Produzione,[Poli Rifatti],Scarto FROM Produzione WHERE (IdReparto=" & IdReparto & ") and (Idlinea=" & IdLinea & ")AND(DATAinizio >= '" & DateTimePickerDa.Value.Year().ToString() & "-" & DateTimePickerDa.Value.Day().ToString() & "-" & DateTimePickerDa.Value.Month().ToString() & " " & ComboBoxDa.SelectedItem.ToString() & ":00:00' )"
        myCmd.Connection.Open()
        Dim dtRegistro As DataTable = New DataTable
        Dim myDataAdapter As New SqlDataAdapter(myCmd)
        myDataAdapter.Fill(dtRegistro)
        DataGridViewLanci.DataSource = dtRegistro
        myCmd.Connection.Close()
    End Sub

    Sub UpdateGridOperatori()
        Dim myConn As New SqlConnection(LabelPathDatabase.Text)
        Dim myCmd As SqlCommand
        myCmd = myConn.CreateCommand()
        myCmd.CommandText = "SELECT Cognome,Nome,DataEntrata,DataUscita FROM OreOperatori WHERE (Id_Reparto=" & IdReparto & ") AND (Id_linea=" & IdLinea & ")AND"
        myCmd.CommandText = myCmd.CommandText + "(((DATAentrata >= '" & DateTimePickerDa.Value.Year().ToString() & "-" & DateTimePickerDa.Value.Day().ToString() & "-" & DateTimePickerDa.Value.Month().ToString() & " " & ComboBoxDa.SelectedItem.ToString() & ":00:00' )AND(DATAuscita >= '" & DateTimePickerA.Value.Year().ToString() & "-" & DateTimePickerA.Value.Day().ToString() & "-" & DateTimePickerA.Value.Month().ToString() & " " & ComboBoxA.SelectedItem.ToString() & ":00:00'))OR"
        myCmd.CommandText = myCmd.CommandText + "((DATAentrata <= '" & DateTimePickerDa.Value.Year().ToString() & "-" & DateTimePickerDa.Value.Day().ToString() & "-" & DateTimePickerDa.Value.Month().ToString() & " " & ComboBoxDa.SelectedItem.ToString() & ":00:00' )AND(DATAuscita >= '" & DateTimePickerDa.Value.Year().ToString() & "-" & DateTimePickerDa.Value.Day().ToString() & "-" & DateTimePickerDa.Value.Month().ToString() & " " & ComboBoxA.SelectedItem.ToString() & ":00:00'))OR"
        myCmd.CommandText = myCmd.CommandText + "((DATAentrata <= '" & DateTimePickerA.Value.Year().ToString() & "-" & DateTimePickerA.Value.Day().ToString() & "-" & DateTimePickerA.Value.Month().ToString() & " " & ComboBoxDa.SelectedItem.ToString() & ":00:00' )AND(DATAuscita >= '" & DateTimePickerA.Value.Year().ToString() & "-" & DateTimePickerA.Value.Day().ToString() & "-" & DateTimePickerA.Value.Month().ToString() & " " & ComboBoxA.SelectedItem.ToString() & ":00:00'))OR"
        myCmd.CommandText = myCmd.CommandText + "((DATAentrata <= '" & DateTimePickerDa.Value.Year().ToString() & "-" & DateTimePickerDa.Value.Day().ToString() & "-" & DateTimePickerDa.Value.Month().ToString() & " " & ComboBoxDa.SelectedItem.ToString() & ":00:00' )AND(DATAuscita >= '" & DateTimePickerA.Value.Year().ToString() & "-" & DateTimePickerA.Value.Day().ToString() & "-" & DateTimePickerA.Value.Month().ToString() & " " & ComboBoxA.SelectedItem.ToString() & ":00:00'))OR"
        myCmd.CommandText = myCmd.CommandText + "((DATAuscita ='')))"
        myCmd.Connection.Open()
        Dim dtRegistro As DataTable = New DataTable
        Dim myDataAdapter As New SqlDataAdapter(myCmd)
        myDataAdapter.Fill(dtRegistro)
        DataGridViewOperatori.DataSource = dtRegistro
        myCmd.Connection.Close()
    End Sub

    Sub UpdateGridFermi()
        Dim myConn As New SqlConnection(LabelPathDatabase.Text)
        Dim myCmd As SqlCommand
        myCmd = myConn.CreateCommand()
        myCmd.CommandText = "SELECT Datainiziofermo,Datafinefermo,DescMacchina,DescFermo,Durata,DescFermoEsteso FROM FERMI WHERE (IdReparto=" & IdReparto & ") and (Idlinea=" & IdLinea & ")AND(DATAinizioFermo >= '" & DateTimePickerDa.Value.Year().ToString() & "-" & DateTimePickerDa.Value.Day().ToString() & "-" & DateTimePickerDa.Value.Month().ToString() & " " & ComboBoxDa.SelectedItem.ToString() & ":00:00' )AND(DATAfinefermo <= '" & DateTimePickerA.Value.Year().ToString() & "-" & DateTimePickerA.Value.Day().ToString() & "-" & DateTimePickerA.Value.Month().ToString() & " " & ComboBoxA.SelectedItem.ToString() & ":00:00')"
        myCmd.Connection.Open()
        Dim dtRegistro As DataTable = New DataTable
        Dim myDataAdapter As New SqlDataAdapter(myCmd)
        myDataAdapter.Fill(dtRegistro)
        DataGridViewFermi.DataSource = dtRegistro
        myCmd.Connection.Close()

    End Sub

    Sub UpdateChart()
        ChartMacchine.Series.Clear()
        'Enable 3D chart
        ChartMacchine.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True

        ChartMacchine.Series.Add("Serie1")
        ChartMacchine.Series("Serie1").LegendText = "Totale minuti fermata"
        Dim myconn As New SqlConnection(LabelPathDatabase.Text)
        Dim myCmd As SqlCommand
        myCmd = myconn.CreateCommand()
        myCmd.CommandText = "SELECT DESCMACCHINA,SUM(DURATA) AS DurataTot FROM FERMI WHERE (IdReparto=" & IdReparto & ")AND(IdLinea=" & IdLinea & ")AND(DATAinizioFermo >= '" & DateTimePickerDa.Value.Year().ToString() & "-" & DateTimePickerDa.Value.Day().ToString() & "-" & DateTimePickerDa.Value.Month().ToString() & " " & ComboBoxDa.SelectedItem.ToString() & ":00:00' )AND(DATAfinefermo <= '" & DateTimePickerA.Value.Year().ToString() & "-" & DateTimePickerA.Value.Day().ToString() & "-" & DateTimePickerA.Value.Month().ToString() & " " & ComboBoxA.SelectedItem.ToString() & ":00:00') GROUP BY DESCMACCHINA ORDER BY SUM(DURATA);"
        ' Create a database command on the connection using query    

        ' Open the connection    
        myCmd.Connection.Open()
        ' Create a database reader    
        Dim myReader As SqlDataReader = myCmd.ExecuteReader(CommandBehavior.CloseConnection)
        ChartMacchine.Series("Serie1").Points.DataBindXY(myReader, "DESCMACCHINA", myReader, "DurataTot")
        ' Close the reader and the connection
        myReader.Close()
        myCmd.Connection.Close()

        'aggiungo il riferimento all'asse y di destra

        'aggiungo l'etichette dei dati
        ChartMacchine.Series("Serie1").IsValueShownAsLabel = True

        'faccio in modo che l'etichetta dell'asse x sia visualizzata per ogni colonna di dati
        ChartMacchine.ChartAreas("ChartArea1").AxisX.Interval = 1
    End Sub

    Sub UpdateChartGenerale()
        ChartCausali.Series.Clear()
        'Enable 3D chart
        ChartCausali.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True

        ChartCausali.Series.Add("Serie1")
        ChartCausali.Series("Serie1").LegendText = "Totale minuti fermata"
        Dim myConn As New SqlConnection(LabelPathDatabase.Text)
        Dim myCmd As SqlCommand
        myCmd = myConn.CreateCommand()

        myCmd.CommandText = "SELECT DESCFERMO,SUM(DURATA) AS DurataTot FROM FERMI WHERE (IdReparto=" & IdReparto & ")AND(IdLinea=" & IdLinea & ")AND(DATAInizioFermo >= '" & DateTimePickerGENERALIDa.Value.Year().ToString() & "-" & DateTimePickerGENERALIDa.Value.Day().ToString() & "-" & DateTimePickerGENERALIDa.Value.Month().ToString() & " " & ComboBoxGeneraleDa.SelectedItem.ToString() & ":00:00')AND(DATAFineFermo <= '" & DateTimePickerGENERALIA.Value.Year().ToString() & "-" & DateTimePickerGENERALIA.Value.Day().ToString() & "-" & DateTimePickerGENERALIA.Value.Month().ToString() & " " & ComboBoxGeneraleA.SelectedItem.ToString() & ":00:00')AND(IdMacchina=0) GROUP BY DESCFERMO ORDER BY SUM(DURATA);"

        ' Create a database command on the connection using query    

        ' Open the connection    
        myCmd.Connection.Open()
        ' Create a database reader    
        Dim myReader As SqlDataReader = myCmd.ExecuteReader(CommandBehavior.CloseConnection)
        ChartCausali.Series("Serie1").Points.DataBindXY(myReader, "DESCFERMO", myReader, "DurataTot")
        ' Close the reader and the connection
        myReader.Close()
        myCmd.Connection.Close()

        'aggiungo il riferimento all'asse y di destra

        'aggiungo l'etichette dei dati
        ChartCausali.Series("Serie1").IsValueShownAsLabel = True

        'faccio in modo che l'etichetta dell'asse x sia visualizzata per ogni colonna di dati
        ChartCausali.ChartAreas("ChartArea1").AxisX.Interval = 1
    End Sub
End Class
