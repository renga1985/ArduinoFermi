Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Configuration
Imports System.Data.SqlClient

Public Class AnalisiFermi

    Private Sub AnalisiFermi_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Form1.LblDepartmentDescription.Text = "Stiratura" Then
            'ComboBoxMacchina.Items.Item(
        End If

        UpdateChart()
        UpdateChartCausali()
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        UpdateChart()
        UpdateChartCausali()
    End Sub

    Sub UpdateChart()
        ChartMacchine.Series.Clear()
        'Enable 3D chart
        ChartMacchine.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True

        ChartMacchine.Series.Add("Serie1")
        ChartMacchine.Series("Serie1").LegendText = "Totale minuti fermata"
        Dim myconn As New SqlConnection(Form1.LblPathDatabase.Text)
        Dim myCmd As SqlCommand
        myCmd = myconn.CreateCommand()
        myCmd.CommandText = "SELECT DESCMACCHINA,SUM(DURATA) AS DurataTot FROM FERMI WHERE (DATA >= '" & DateTimePickerDa.Value.ToString("yyyy-MM-ddTHH:mm:ss") & "')AND(DATA <= '" & DateTimePickerA.Value.ToString("yyyy-MM-ddTHH:mm:ss") & "') GROUP BY DESCMACCHINA ORDER BY SUM(DURATA);"
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

    Sub UpdateChartCausali()
        ChartCausali.Series.Clear()
        'Enable 3D chart
        ChartCausali.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True

        ChartCausali.Series.Add("Serie1")
        ChartCausali.Series("Serie1").LegendText = "Totale minuti fermata"
        Dim myConn As New SqlConnection(Form1.LblPathDatabase.Text)
        Dim myCmd As SqlCommand
        myCmd = myConn.CreateCommand()

        myCmd.CommandText = "SELECT DESCFERMO,SUM(DURATA) AS DurataTot FROM FERMI WHERE (DATA >= '" & DateTimePickerCausaliDa.Value.ToString("yyyy-MM-ddTHH:mm:ss") & "')AND(DATA <= '" & DateTimePickerCausaliA.Value.ToString("yyyy-MM-ddTHH:mm:ss") & "')AND(IdMacchina=0) GROUP BY DESCFERMO ORDER BY SUM(DURATA);"

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
