Imports System.Configuration
Imports System.Data.OleDb
Imports System.IO
Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Public Class DashboardProduzione


    Private Sub DashboardProduzione_Load1(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'VRNFermiDataSet.Fermi2' table. You can move, or remove it, as needed.

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
        sr.Close()
        TimerUpdate.Start()
    End Sub

    Function DataFormatting(Datadaconvertire As DateTime)
        Dim dataconvertita As String
        dataconvertita = Datadaconvertire.Year().ToString() & "-" & Datadaconvertire.Day().ToString() & "-" & Datadaconvertire.Month().ToString() & " " & Datadaconvertire.Hour().ToString() & ":" & Datadaconvertire.Minute().ToString() & ":" & Datadaconvertire.Second().ToString()

        Return dataconvertita
    End Function

    Private Sub TimerUpdate_Tick(sender As Object, e As EventArgs) Handles TimerUpdate.Tick
        'STIRATURA LINEA 1
        'Update the traffic light
        Dim status As String = UpdateTrafficLight(75, 1)
        If status = "Marcia" Then
            OvalShapeRedStirLin1.FillColor = Color.Silver
            OvalShapeYellowStirLin1.FillColor = Color.Silver
            OvalShapeGreenStirLin1.FillColor = Color.Lime
        End If

        If status = "Stop" Then
            OvalShapeRedStirLin1.FillColor = Color.Red
            OvalShapeYellowStirLin1.FillColor = Color.Silver
            OvalShapeGreenStirLin1.FillColor = Color.Silver
        End If

        If status = "Giustificativo" Then
            OvalShapeRedStirLin1.FillColor = Color.Silver
            OvalShapeYellowStirLin1.FillColor = Color.Yellow
            OvalShapeGreenStirLin1.FillColor = Color.Lime
        End If
        'Update the Production of the last hour
        LabelProductionSpeedStirLinea1.Text = ProductionOfLastHour(75, 1)
        Dim produzioneorariariportataa100 As Integer = ((CInt(LabelProductionSpeedStirLinea1.Text) - 100) / (250 - 100)) * 100
        'Dim produzioneorariariportataa100 As Integer = ((CInt(LabelProductionSpeedLinea1.Text) - 11250) / (22000 - 11250)) * 100
        If produzioneorariariportataa100 > 100 Then
            ProgressBarStirLinea1.Value = 100
        Else
            If produzioneorariariportataa100 < 0 Then
                ProgressBarStirLinea1.Value = 0
            Else
                ProgressBarStirLinea1.Value = produzioneorariariportataa100
            End If
        End If

        If ProgressBarStirLinea1.Value < 33 Then
            ProgressBarStirLinea1.ForeColor = Color.Red
        Else
            If ProgressBarStirLinea1.Value < 66 Then
                ProgressBarStirLinea1.ForeColor = Color.Yellow
            Else
                ProgressBarStirLinea1.ForeColor = Color.Green
            End If
        End If
        'Update the production of shift
        LabelProductionShiftStiratura1.Text = ShiftProduction(75, 1)
        '------------------------
        'Section to update the chart

        Dim ds As DataSet = UpdateChart(75, 1)
        If ds.Tables.Count = 0 Then
        Else

            ChartProduzioneOrariaStiratura1.DataSource = ds
            ChartProduzioneOrariaStiratura1.Series("Series1").XValueMember = ds.Tables("Table").Columns("Data").ToString()
            ChartProduzioneOrariaStiratura1.Series("Series1").YValueMembers = ds.Tables("Table").Columns("ProduzioneStep").ToString()
            ChartProduzioneOrariaStiratura1.DataBind()
        End If

        '-----------------------

        'STIRATURA LINEA 2
        'Update the traffic light
        status = UpdateTrafficLight(75, 2)
        If status = "Marcia" Then
            OvalShapeRedStirLin2.FillColor = Color.Silver
            OvalShapeYellowStirLin2.FillColor = Color.Silver
            OvalShapeGreenStirLin2.FillColor = Color.Lime
        End If

        If status = "Stop" Then
            OvalShapeRedStirLin2.FillColor = Color.Red
            OvalShapeYellowStirLin2.FillColor = Color.Silver
            OvalShapeGreenStirLin2.FillColor = Color.Silver
        End If

        If status = "Giustificativo" Then
            OvalShapeRedStirLin2.FillColor = Color.Silver
            OvalShapeYellowStirLin2.FillColor = Color.Yellow
            OvalShapeGreenStirLin2.FillColor = Color.Lime
        End If
        'Update the Production of the last hour
        LabelProductionSpeedStirLinea1.Text = ProductionOfLastHour(75, 2)
        produzioneorariariportataa100 = ((CInt(LabelProductionSpeedStirLinea2.Text) - 100) / (250 - 100)) * 100
        'Dim produzioneorariariportataa100 As Integer = ((CInt(LabelProductionSpeedLinea1.Text) - 11250) / (22000 - 11250)) * 100
        If produzioneorariariportataa100 > 100 Then
            ProgressBarStirLinea2.Value = 100
        Else
            If produzioneorariariportataa100 < 0 Then
                ProgressBarStirLinea2.Value = 0
            Else
                ProgressBarStirLinea2.Value = produzioneorariariportataa100
            End If
        End If

        If ProgressBarStirLinea2.Value < 33 Then
            ProgressBarStirLinea2.ForeColor = Color.Red
        Else
            If ProgressBarStirLinea2.Value < 66 Then
                ProgressBarStirLinea2.ForeColor = Color.Yellow
            Else
                ProgressBarStirLinea2.ForeColor = Color.Green
            End If
        End If
        'Update the production of shift
        LabelProductionShiftStiratura2.Text = ShiftProduction(75, 2)
        '------------------------
        'Section to update the chart
        ds = UpdateChart(75, 2)
        If ds.Tables.Count = 0 Then
        Else

            ChartProduzioneOrariaStiratura2.DataSource = ds
            ChartProduzioneOrariaStiratura2.Series("Series1").XValueMember = ds.Tables("Table").Columns("Data").ToString()
            ChartProduzioneOrariaStiratura2.Series("Series1").YValueMembers = ds.Tables("Table").Columns("ProduzioneStep").ToString()
            ChartProduzioneOrariaStiratura2.DataBind()
        End If
        '-----------------------
        '-----------------------

        'STIRATURA LINEA 3
        'Update the traffic light
        status = UpdateTrafficLight(75, 3)
        If status = "Marcia" Then
            OvalShapeRedStirLin3.FillColor = Color.Silver
            OvalShapeYellowStirLin3.FillColor = Color.Silver
            OvalShapeGreenStirLin3.FillColor = Color.Lime
        End If

        If status = "Stop" Then
            OvalShapeRedStirLin3.FillColor = Color.Red
            OvalShapeYellowStirLin3.FillColor = Color.Silver
            OvalShapeGreenStirLin3.FillColor = Color.Silver
        End If

        If status = "Giustificativo" Then
            OvalShapeRedStirLin3.FillColor = Color.Silver
            OvalShapeYellowStirLin3.FillColor = Color.Yellow
            OvalShapeGreenStirLin3.FillColor = Color.Lime
        End If
        'Update the Production of the last hour
        LabelProductionSpeedStirLinea3.Text = ProductionOfLastHour(75, 3)
        produzioneorariariportataa100 = ((CInt(LabelProductionSpeedStirLinea3.Text) - 100) / (250 - 100)) * 100
        'Dim produzioneorariariportataa100 As Integer = ((CInt(LabelProductionSpeedLinea1.Text) - 11250) / (22000 - 11250)) * 100
        If produzioneorariariportataa100 > 100 Then
            ProgressBarStirLinea3.Value = 100
        Else
            If produzioneorariariportataa100 < 0 Then
                ProgressBarStirLinea3.Value = 0
            Else
                ProgressBarStirLinea3.Value = produzioneorariariportataa100
            End If
        End If

        If ProgressBarStirLinea3.Value < 33 Then
            ProgressBarStirLinea3.ForeColor = Color.Red
        Else
            If ProgressBarStirLinea3.Value < 66 Then
                ProgressBarStirLinea3.ForeColor = Color.Yellow
            Else
                ProgressBarStirLinea3.ForeColor = Color.Green
            End If
        End If
        'Update the production of shift
        LabelProductionShiftStiratura3.Text = ShiftProduction(75, 3)
        '------------------------
        'Section to update the chart
        ds = UpdateChart(75, 3)
        If ds.Tables.Count = 0 Then
        Else

            ChartProduzioneOrariaStiratura3.DataSource = ds
            ChartProduzioneOrariaStiratura3.Series("Series1").XValueMember = ds.Tables("Table").Columns("Data").ToString()
            ChartProduzioneOrariaStiratura3.Series("Series1").YValueMembers = ds.Tables("Table").Columns("ProduzioneStep").ToString()
            ChartProduzioneOrariaStiratura3.DataBind()
        End If
        '-----------------------

        '-----------------------

        'STIRATURA LINEA 4
        'Update the traffic light
        status = UpdateTrafficLight(75, 4)
        If status = "Marcia" Then
            OvalShapeRedStirLin4.FillColor = Color.Silver
            OvalShapeYellowStirLin4.FillColor = Color.Silver
            OvalShapeGreenStirLin4.FillColor = Color.Lime
        End If

        If status = "Stop" Then
            OvalShapeRedStirLin4.FillColor = Color.Red
            OvalShapeYellowStirLin4.FillColor = Color.Silver
            OvalShapeGreenStirLin4.FillColor = Color.Silver
        End If

        If status = "Giustificativo" Then
            OvalShapeRedStirLin4.FillColor = Color.Silver
            OvalShapeYellowStirLin4.FillColor = Color.Yellow
            OvalShapeGreenStirLin4.FillColor = Color.Lime
        End If
        'Update the Production of the last hour
        LabelProductionSpeedStirLinea4.Text = ProductionOfLastHour(75, 4)
        produzioneorariariportataa100 = ((CInt(LabelProductionSpeedStirLinea4.Text) - 100) / (250 - 100)) * 100
        'Dim produzioneorariariportataa100 As Integer = ((CInt(LabelProductionSpeedLinea1.Text) - 11250) / (22000 - 11250)) * 100
        If produzioneorariariportataa100 > 100 Then
            ProgressBarStirLinea4.Value = 100
        Else
            If produzioneorariariportataa100 < 0 Then
                ProgressBarStirLinea4.Value = 0
            Else
                ProgressBarStirLinea4.Value = produzioneorariariportataa100
            End If
        End If

        If ProgressBarStirLinea4.Value < 33 Then
            ProgressBarStirLinea4.ForeColor = Color.Red
        Else
            If ProgressBarStirLinea4.Value < 66 Then
                ProgressBarStirLinea4.ForeColor = Color.Yellow
            Else
                ProgressBarStirLinea4.ForeColor = Color.Green
            End If
        End If
        'Update the production of shift
        LabelProductionShiftStiratura4.Text = ShiftProduction(75, 4)
        '------------------------
        'Section to update the chart
        ds = UpdateChart(75, 4)
        If ds.Tables.Count = 0 Then
        Else

            ChartProduzioneOrariaStiratura4.DataSource = ds
            ChartProduzioneOrariaStiratura4.Series("Series1").XValueMember = ds.Tables("Table").Columns("Data").ToString()
            ChartProduzioneOrariaStiratura4.Series("Series1").YValueMembers = ds.Tables("Table").Columns("ProduzioneStep").ToString()
            ChartProduzioneOrariaStiratura4.DataBind()
        End If
        '-----------------------

        'STIRATURA LINEA 5
        'Update the traffic light
        status = UpdateTrafficLight(75, 5)
        If status = "Marcia" Then
            OvalShapeRedStirLin5.FillColor = Color.Silver
            OvalShapeYellowStirLin5.FillColor = Color.Silver
            OvalShapeGreenStirLin5.FillColor = Color.Lime
        End If

        If status = "Stop" Then
            OvalShapeRedStirLin5.FillColor = Color.Red
            OvalShapeYellowStirLin5.FillColor = Color.Silver
            OvalShapeGreenStirLin5.FillColor = Color.Silver
        End If

        If status = "Giustificativo" Then
            OvalShapeRedStirLin5.FillColor = Color.Silver
            OvalShapeYellowStirLin5.FillColor = Color.Yellow
            OvalShapeGreenStirLin5.FillColor = Color.Lime
        End If
        'Update the Production of the last hour
        LabelProductionSpeedStirLinea5.Text = ProductionOfLastHour(75, 5)
        produzioneorariariportataa100 = ((CInt(LabelProductionSpeedStirLinea5.Text) - 100) / (250 - 100)) * 100
        'Dim produzioneorariariportataa100 As Integer = ((CInt(LabelProductionSpeedLinea1.Text) - 11250) / (22000 - 11250)) * 100
        If produzioneorariariportataa100 > 100 Then
            ProgressBarStirLinea5.Value = 100
        Else
            If produzioneorariariportataa100 < 0 Then
                ProgressBarStirLinea5.Value = 0
            Else
                ProgressBarStirLinea5.Value = produzioneorariariportataa100
            End If
        End If

        If ProgressBarStirLinea5.Value < 33 Then
            ProgressBarStirLinea5.ForeColor = Color.Red
        Else
            If ProgressBarStirLinea5.Value < 66 Then
                ProgressBarStirLinea5.ForeColor = Color.Yellow
            Else
                ProgressBarStirLinea5.ForeColor = Color.Green
            End If
        End If
        'Update the production of shift
        LabelProductionShiftStiratura5.Text = ShiftProduction(75, 5)
        '------------------------
        'Section to update the chart
        ds = UpdateChart(75, 5)
        If ds.Tables.Count = 0 Then
        Else

            ChartProduzioneOrariaStiratura5.DataSource = ds
            ChartProduzioneOrariaStiratura5.Series("Series1").XValueMember = ds.Tables("Table").Columns("Data").ToString()
            ChartProduzioneOrariaStiratura5.Series("Series1").YValueMembers = ds.Tables("Table").Columns("ProduzioneStep").ToString()
            ChartProduzioneOrariaStiratura5.DataBind()
        End If
        '-----------------------

        '-----------------------

        'STIRATURA LINEA 6
        'Update the traffic light
        status = UpdateTrafficLight(75, 6)
        If status = "Marcia" Then
            OvalShapeRedStirLin6.FillColor = Color.Silver
            OvalShapeYellowStirLin6.FillColor = Color.Silver
            OvalShapeGreenStirLin6.FillColor = Color.Lime
        End If

        If status = "Stop" Then
            OvalShapeRedStirLin6.FillColor = Color.Red
            OvalShapeYellowStirLin6.FillColor = Color.Silver
            OvalShapeGreenStirLin6.FillColor = Color.Silver
        End If

        If status = "Giustificativo" Then
            OvalShapeRedStirLin6.FillColor = Color.Silver
            OvalShapeYellowStirLin6.FillColor = Color.Yellow
            OvalShapeGreenStirLin6.FillColor = Color.Lime
        End If
        'Update the Production of the last hour
        LabelProductionSpeedStirLinea6.Text = ProductionOfLastHour(75, 6)
        produzioneorariariportataa100 = ((CInt(LabelProductionSpeedStirLinea6.Text) - 100) / (250 - 100)) * 100
        'Dim produzioneorariariportataa100 As Integer = ((CInt(LabelProductionSpeedLinea1.Text) - 11250) / (22000 - 11250)) * 100
        If produzioneorariariportataa100 > 100 Then
            ProgressBarStirLinea6.Value = 100
        Else
            If produzioneorariariportataa100 < 0 Then
                ProgressBarStirLinea6.Value = 0
            Else
                ProgressBarStirLinea6.Value = produzioneorariariportataa100
            End If
        End If

        If ProgressBarStirLinea6.Value < 33 Then
            ProgressBarStirLinea6.ForeColor = Color.Red
        Else
            If ProgressBarStirLinea6.Value < 66 Then
                ProgressBarStirLinea6.ForeColor = Color.Yellow
            Else
                ProgressBarStirLinea6.ForeColor = Color.Green
            End If
        End If
        'Update the production of shift
        LabelProductionShiftStiratura6.Text = ShiftProduction(75, 6)
        '------------------------
        'Section to update the chart
        ds = UpdateChart(75, 6)
        If ds.Tables.Count = 0 Then
        Else

            ChartProduzioneOrariaStiratura6.DataSource = ds
            ChartProduzioneOrariaStiratura6.Series("Series1").XValueMember = ds.Tables("Table").Columns("Data").ToString()
            ChartProduzioneOrariaStiratura6.Series("Series1").YValueMembers = ds.Tables("Table").Columns("ProduzioneStep").ToString()
            ChartProduzioneOrariaStiratura6.DataBind()
        End If
        '-----------------------
        'MONTAGGIO LINEA 1
        'Update the traffic light
        status = UpdateTrafficLight(80, 1)
        If status = "Marcia" Then
            OvalShapeRedMontLin1.FillColor = Color.Silver
            OvalShapeYellowMontLin1.FillColor = Color.Silver
            OvalShapeGreenMontLin1.FillColor = Color.Lime
        End If

        If status = "Stop" Then
            OvalShapeRedMontLin1.FillColor = Color.Red
            OvalShapeYellowMontLin1.FillColor = Color.Silver
            OvalShapeGreenMontLin1.FillColor = Color.Silver
        End If

        If status = "Giustificativo" Then
            OvalShapeRedMontLin1.FillColor = Color.Silver
            OvalShapeYellowMontLin1.FillColor = Color.Yellow
            OvalShapeGreenMontLin1.FillColor = Color.Lime
        End If
        'Update the Production of the last hour
        LabelProductionSpeedMontLinea1.Text = ProductionOfLastHour(80, 1)
        produzioneorariariportataa100 = ((CInt(LabelProductionSpeedMontLinea1.Text) - 100) / (250 - 100)) * 100
        'Dim produzioneorariariportataa100 As Integer = ((CInt(LabelProductionSpeedLinea1.Text) - 11250) / (22000 - 11250)) * 100
        If produzioneorariariportataa100 > 100 Then
            ProgressBarMontLinea1.Value = 100
        Else
            If produzioneorariariportataa100 < 0 Then
                ProgressBarMontLinea1.Value = 0
            Else
                ProgressBarMontLinea1.Value = produzioneorariariportataa100
            End If
        End If

        If ProgressBarMontLinea1.Value < 33 Then
            ProgressBarMontLinea1.ForeColor = Color.Red
        Else
            If ProgressBarMontLinea1.Value < 66 Then
                ProgressBarMontLinea1.ForeColor = Color.Yellow
            Else
                ProgressBarMontLinea1.ForeColor = Color.Green
            End If
        End If
        'Update the production of shift
        LabelProductionShiftMontaggio1.Text = ShiftProduction(80, 1)
        '------------------------
        'Section to update the chart
        ds = UpdateChart(80, 1)
        If ds.Tables.Count = 0 Then
        Else

            ChartProduzioneOrariaMontaggio1.DataSource = ds
            ChartProduzioneOrariaMontaggio1.Series("Series1").XValueMember = ds.Tables("Table").Columns("Data").ToString()
            ChartProduzioneOrariaMontaggio1.Series("Series1").YValueMembers = ds.Tables("Table").Columns("ProduzioneStep").ToString()
            ChartProduzioneOrariaMontaggio1.DataBind()
        End If
        '-----------------------



        '-----------------------
        'MONTAGGIO LINEA 2
        'Update the traffic light
        status = UpdateTrafficLight(80, 2)
        If status = "Marcia" Then
            OvalShapeRedMontLin2.FillColor = Color.Silver
            OvalShapeYellowMontLin2.FillColor = Color.Silver
            OvalShapeGreenMontLin2.FillColor = Color.Lime
        End If

        If status = "Stop" Then
            OvalShapeRedMontLin2.FillColor = Color.Red
            OvalShapeYellowMontLin2.FillColor = Color.Silver
            OvalShapeGreenMontLin2.FillColor = Color.Silver
        End If

        If status = "Giustificativo" Then
            OvalShapeRedMontLin2.FillColor = Color.Silver
            OvalShapeYellowMontLin2.FillColor = Color.Yellow
            OvalShapeGreenMontLin2.FillColor = Color.Lime
        End If
        'Update the Production of the last hour
        LabelProductionSpeedMontLinea2.Text = ProductionOfLastHour(80, 2)
        produzioneorariariportataa100 = ((CInt(LabelProductionSpeedMontLinea2.Text) - 100) / (250 - 100)) * 100
        'Dim produzioneorariariportataa100 As Integer = ((CInt(LabelProductionSpeedLinea1.Text) - 11250) / (22000 - 11250)) * 100
        If produzioneorariariportataa100 > 100 Then
            ProgressBarMontLinea2.Value = 100
        Else
            If produzioneorariariportataa100 < 0 Then
                ProgressBarMontLinea2.Value = 0
            Else
                ProgressBarMontLinea2.Value = produzioneorariariportataa100
            End If
        End If

        If ProgressBarMontLinea2.Value < 33 Then
            ProgressBarMontLinea2.ForeColor = Color.Red
        Else
            If ProgressBarMontLinea2.Value < 66 Then
                ProgressBarMontLinea2.ForeColor = Color.Yellow
            Else
                ProgressBarMontLinea2.ForeColor = Color.Green
            End If
        End If
        'Update the production of shift
        LabelProductionShiftMontaggio2.Text = ShiftProduction(80, 2)
        '------------------------
        'Section to update the chart
        ds = UpdateChart(80, 2)
        If ds.Tables.Count = 0 Then
        Else

            ChartProduzioneOrariaMontaggio2.DataSource = ds
            ChartProduzioneOrariaMontaggio2.Series("Series1").XValueMember = ds.Tables("Table").Columns("Data").ToString()
            ChartProduzioneOrariaMontaggio2.Series("Series1").YValueMembers = ds.Tables("Table").Columns("ProduzioneStep").ToString()
            ChartProduzioneOrariaMontaggio2.DataBind()
        End If
        '-----------------------

        '-----------------------
        'MONTAGGIO LINEA 3
        'Update the traffic light
        status = UpdateTrafficLight(80, 3)
        If status = "Marcia" Then
            OvalShapeRedMontLin3.FillColor = Color.Silver
            OvalShapeYellowMontLin3.FillColor = Color.Silver
            OvalShapeGreenMontLin3.FillColor = Color.Lime
        End If

        If status = "Stop" Then
            OvalShapeRedMontLin3.FillColor = Color.Red
            OvalShapeYellowMontLin3.FillColor = Color.Silver
            OvalShapeGreenMontLin3.FillColor = Color.Silver
        End If

        If status = "Giustificativo" Then
            OvalShapeRedMontLin3.FillColor = Color.Silver
            OvalShapeYellowMontLin3.FillColor = Color.Yellow
            OvalShapeGreenMontLin3.FillColor = Color.Lime
        End If
        'Update the Production of the last hour
        LabelProductionSpeedMontLinea3.Text = ProductionOfLastHour(80, 3)
        produzioneorariariportataa100 = ((CInt(LabelProductionSpeedMontLinea3.Text) - 100) / (250 - 100)) * 100
        'Dim produzioneorariariportataa100 As Integer = ((CInt(LabelProductionSpeedLinea1.Text) - 11250) / (22000 - 11250)) * 100
        If produzioneorariariportataa100 > 100 Then
            ProgressBarMontLinea3.Value = 100
        Else
            If produzioneorariariportataa100 < 0 Then
                ProgressBarMontLinea3.Value = 0
            Else
                ProgressBarMontLinea3.Value = produzioneorariariportataa100
            End If
        End If

        If ProgressBarMontLinea3.Value < 33 Then
            ProgressBarMontLinea3.ForeColor = Color.Red
        Else
            If ProgressBarMontLinea3.Value < 66 Then
                ProgressBarMontLinea3.ForeColor = Color.Yellow
            Else
                ProgressBarMontLinea3.ForeColor = Color.Green
            End If
        End If
        'Update the production of shift
        LabelProductionShiftMontaggio3.Text = ShiftProduction(80, 3)
        '------------------------
        'Section to update the chart
        ds = UpdateChart(80, 3)
        If ds.Tables.Count = 0 Then
        Else

            ChartProduzioneOrariaMontaggio3.DataSource = ds
            ChartProduzioneOrariaMontaggio3.Series("Series1").XValueMember = ds.Tables("Table").Columns("Data").ToString()
            ChartProduzioneOrariaMontaggio3.Series("Series1").YValueMembers = ds.Tables("Table").Columns("ProduzioneStep").ToString()
            ChartProduzioneOrariaMontaggio3.DataBind()
        End If
        '-----------------------


        '-----------------------
        'MONTAGGIO LINEA 4
        'Update the traffic light
        status = UpdateTrafficLight(80, 4)
        If status = "Marcia" Then
            OvalShapeRedMontLin4.FillColor = Color.Silver
            OvalShapeYellowMontLin4.FillColor = Color.Silver
            OvalShapeGreenMontLin4.FillColor = Color.Lime
        End If

        If status = "Stop" Then
            OvalShapeRedMontLin4.FillColor = Color.Red
            OvalShapeYellowMontLin4.FillColor = Color.Silver
            OvalShapeGreenMontLin4.FillColor = Color.Silver
        End If

        If status = "Giustificativo" Then
            OvalShapeRedMontLin4.FillColor = Color.Silver
            OvalShapeYellowMontLin4.FillColor = Color.Yellow
            OvalShapeGreenMontLin4.FillColor = Color.Lime
        End If
        'Update the Production of the last hour
        LabelProductionSpeedMontLinea4.Text = ProductionOfLastHour(80, 4)
        produzioneorariariportataa100 = ((CInt(LabelProductionSpeedMontLinea4.Text) - 100) / (250 - 100)) * 100
        'Dim produzioneorariariportataa100 As Integer = ((CInt(LabelProductionSpeedLinea1.Text) - 11250) / (22000 - 11250)) * 100
        If produzioneorariariportataa100 > 100 Then
            ProgressBarMontLinea4.Value = 100
        Else
            If produzioneorariariportataa100 < 0 Then
                ProgressBarMontLinea4.Value = 0
            Else
                ProgressBarMontLinea4.Value = produzioneorariariportataa100
            End If
        End If

        If ProgressBarMontLinea4.Value < 33 Then
            ProgressBarMontLinea4.ForeColor = Color.Red
        Else
            If ProgressBarMontLinea4.Value < 66 Then
                ProgressBarMontLinea4.ForeColor = Color.Yellow
            Else
                ProgressBarMontLinea4.ForeColor = Color.Green
            End If
        End If
        'Update the production of shift
        LabelProductionShiftMontaggio4.Text = ShiftProduction(80, 4)
        '------------------------
        'Section to update the chart
        ds = UpdateChart(80, 4)
        If ds.Tables.Count = 0 Then
        Else

            ChartProduzioneOrariaMontaggio4.DataSource = ds
            ChartProduzioneOrariaMontaggio4.Series("Series1").XValueMember = ds.Tables("Table").Columns("Data").ToString()
            ChartProduzioneOrariaMontaggio4.Series("Series1").YValueMembers = ds.Tables("Table").Columns("ProduzioneStep").ToString()
            ChartProduzioneOrariaMontaggio4.DataBind()
        End If
        '-----------------------


        '-----------------------
        'MONTAGGIO LINEA 5
        'Update the traffic light
        status = UpdateTrafficLight(80, 5)
        If status = "Marcia" Then
            OvalShapeRedMontLin5.FillColor = Color.Silver
            OvalShapeYellowMontLin5.FillColor = Color.Silver
            OvalShapeGreenMontLin5.FillColor = Color.Lime
        End If

        If status = "Stop" Then
            OvalShapeRedMontLin5.FillColor = Color.Red
            OvalShapeYellowMontLin5.FillColor = Color.Silver
            OvalShapeGreenMontLin5.FillColor = Color.Silver
        End If

        If status = "Giustificativo" Then
            OvalShapeRedMontLin5.FillColor = Color.Silver
            OvalShapeYellowMontLin5.FillColor = Color.Yellow
            OvalShapeGreenMontLin5.FillColor = Color.Lime
        End If
        'Update the Production of the last hour
        LabelProductionSpeedMontLinea5.Text = ProductionOfLastHour(80, 5)
        produzioneorariariportataa100 = ((CInt(LabelProductionSpeedMontLinea5.Text) - 100) / (250 - 100)) * 100
        'Dim produzioneorariariportataa100 As Integer = ((CInt(LabelProductionSpeedLinea1.Text) - 11250) / (22000 - 11250)) * 100
        If produzioneorariariportataa100 > 100 Then
            ProgressBarMontLinea5.Value = 100
        Else
            If produzioneorariariportataa100 < 0 Then
                ProgressBarMontLinea5.Value = 0
            Else
                ProgressBarMontLinea5.Value = produzioneorariariportataa100
            End If
        End If

        If ProgressBarMontLinea5.Value < 33 Then
            ProgressBarMontLinea5.ForeColor = Color.Red
        Else
            If ProgressBarMontLinea5.Value < 66 Then
                ProgressBarMontLinea5.ForeColor = Color.Yellow
            Else
                ProgressBarMontLinea5.ForeColor = Color.Green
            End If
        End If
        'Update the production of shift
        LabelProductionShiftMontaggio5.Text = ShiftProduction(80, 5)
        '------------------------
        'Section to update the chart
        ds = UpdateChart(80, 5)
        If ds.Tables.Count = 0 Then
        Else

            ChartProduzioneOrariaMontaggio5.DataSource = ds
            ChartProduzioneOrariaMontaggio5.Series("Series1").XValueMember = ds.Tables("Table").Columns("Data").ToString()
            ChartProduzioneOrariaMontaggio5.Series("Series1").YValueMembers = ds.Tables("Table").Columns("ProduzioneStep").ToString()
            ChartProduzioneOrariaMontaggio5.DataBind()
        End If
        '-----------------------


        '-----------------------
        'MONTAGGIO LINEA 6
        'Update the traffic light
        status = UpdateTrafficLight(80, 6)
        If status = "Marcia" Then
            OvalShapeRedMontLin6.FillColor = Color.Silver
            OvalShapeYellowMontLin6.FillColor = Color.Silver
            OvalShapeGreenMontLin6.FillColor = Color.Lime
        End If

        If status = "Stop" Then
            OvalShapeRedMontLin6.FillColor = Color.Red
            OvalShapeYellowMontLin6.FillColor = Color.Silver
            OvalShapeGreenMontLin6.FillColor = Color.Silver
        End If

        If status = "Giustificativo" Then
            OvalShapeRedMontLin6.FillColor = Color.Silver
            OvalShapeYellowMontLin6.FillColor = Color.Yellow
            OvalShapeGreenMontLin6.FillColor = Color.Lime
        End If
        'Update the Production of the last hour
        LabelProductionSpeedMontLinea6.Text = ProductionOfLastHour(80, 6)
        produzioneorariariportataa100 = ((CInt(LabelProductionSpeedMontLinea6.Text) - 100) / (250 - 100)) * 100
        'Dim produzioneorariariportataa100 As Integer = ((CInt(LabelProductionSpeedLinea1.Text) - 11250) / (22000 - 11250)) * 100
        If produzioneorariariportataa100 > 100 Then
            ProgressBarMontLinea6.Value = 100
        Else
            If produzioneorariariportataa100 < 0 Then
                ProgressBarMontLinea6.Value = 0
            Else
                ProgressBarMontLinea6.Value = produzioneorariariportataa100
            End If
        End If

        If ProgressBarMontLinea6.Value < 33 Then
            ProgressBarMontLinea6.ForeColor = Color.Red
        Else
            If ProgressBarMontLinea6.Value < 66 Then
                ProgressBarMontLinea6.ForeColor = Color.Yellow
            Else
                ProgressBarMontLinea6.ForeColor = Color.Green
            End If
        End If
        'Update the production of shift
        LabelProductionShiftMontaggio6.Text = ShiftProduction(80, 6)
        '------------------------
        'Section to update the chart
        ds = UpdateChart(80, 6)
        If ds.Tables.Count = 0 Then
        Else
            ChartProduzioneOrariaMontaggio6.DataSource = ds
            ChartProduzioneOrariaMontaggio6.Series("Series1").XValueMember = ds.Tables("Table").Columns("Data").ToString()
            ChartProduzioneOrariaMontaggio6.Series("Series1").YValueMembers = ds.Tables("Table").Columns("ProduzioneStep").ToString()
            ChartProduzioneOrariaMontaggio6.DataBind()
        End If
        '-----------------------



        '-----------------------
        'MONTAGGIO LINEA 7
        'Update the traffic light
        status = UpdateTrafficLight(80, 7)
        If status = "Marcia" Then
            OvalShapeRedMontLin7.FillColor = Color.Silver
            OvalShapeYellowMontLin7.FillColor = Color.Silver
            OvalShapeGreenMontLin7.FillColor = Color.Lime
        End If

        If status = "Stop" Then
            OvalShapeRedMontLin7.FillColor = Color.Red
            OvalShapeYellowMontLin7.FillColor = Color.Silver
            OvalShapeGreenMontLin7.FillColor = Color.Silver
        End If

        If status = "Giustificativo" Then
            OvalShapeRedMontLin7.FillColor = Color.Silver
            OvalShapeYellowMontLin7.FillColor = Color.Yellow
            OvalShapeGreenMontLin7.FillColor = Color.Lime
        End If
        'Update the Production of the last hour
        LabelProductionSpeedMontLinea7.Text = ProductionOfLastHour(80, 7)
        produzioneorariariportataa100 = ((CInt(LabelProductionSpeedMontLinea7.Text) - 100) / (250 - 100)) * 100
        'Dim produzioneorariariportataa100 As Integer = ((CInt(LabelProductionSpeedLinea1.Text) - 11250) / (22000 - 11250)) * 100
        If produzioneorariariportataa100 > 100 Then
            ProgressBarMontLinea7.Value = 100
        Else
            If produzioneorariariportataa100 < 0 Then
                ProgressBarMontLinea7.Value = 0
            Else
                ProgressBarMontLinea7.Value = produzioneorariariportataa100
            End If
        End If

        If ProgressBarMontLinea7.Value < 33 Then
            ProgressBarMontLinea7.ForeColor = Color.Red
        Else
            If ProgressBarMontLinea7.Value < 66 Then
                ProgressBarMontLinea7.ForeColor = Color.Yellow
            Else
                ProgressBarMontLinea7.ForeColor = Color.Green
            End If
        End If
        'Update the production of shift
        LabelProductionShiftMontaggio7.Text = ShiftProduction(80, 7)
        '------------------------
        'Section to update the chart
        ds = UpdateChart(80, 7)
        If ds.Tables.Count = 0 Then
        Else
            ChartProduzioneOrariaMontaggio7.DataSource = ds
            ChartProduzioneOrariaMontaggio7.Series("Series1").XValueMember = ds.Tables("Table").Columns("Data").ToString()
            ChartProduzioneOrariaMontaggio7.Series("Series1").YValueMembers = ds.Tables("Table").Columns("ProduzioneStep").ToString()
            ChartProduzioneOrariaMontaggio7.DataBind()
        End If
        '-----------------------



        '-----------------------
        'MONTAGGIO LINEA 8
        'Update the traffic light
        status = UpdateTrafficLight(80, 8)
        If status = "Marcia" Then
            OvalShapeRedMontLin8.FillColor = Color.Silver
            OvalShapeYellowMontLin8.FillColor = Color.Silver
            OvalShapeGreenMontLin8.FillColor = Color.Lime
        End If

        If status = "Stop" Then
            OvalShapeRedMontLin8.FillColor = Color.Red
            OvalShapeYellowMontLin8.FillColor = Color.Silver
            OvalShapeGreenMontLin8.FillColor = Color.Silver
        End If

        If status = "Giustificativo" Then
            OvalShapeRedMontLin8.FillColor = Color.Silver
            OvalShapeYellowMontLin8.FillColor = Color.Yellow
            OvalShapeGreenMontLin8.FillColor = Color.Lime
        End If
        'Update the Production of the last hour
        LabelProductionSpeedMontLinea8.Text = ProductionOfLastHour(80, 8)
        produzioneorariariportataa100 = ((CInt(LabelProductionSpeedMontLinea8.Text) - 100) / (250 - 100)) * 100
        'Dim produzioneorariariportataa100 As Integer = ((CInt(LabelProductionSpeedLinea1.Text) - 11250) / (22000 - 11250)) * 100
        If produzioneorariariportataa100 > 100 Then
            ProgressBarMontLinea8.Value = 100
        Else
            If produzioneorariariportataa100 < 0 Then
                ProgressBarMontLinea8.Value = 0
            Else
                ProgressBarMontLinea8.Value = produzioneorariariportataa100
            End If
        End If

        If ProgressBarMontLinea8.Value < 33 Then
            ProgressBarMontLinea8.ForeColor = Color.Red
        Else
            If ProgressBarMontLinea8.Value < 66 Then
                ProgressBarMontLinea8.ForeColor = Color.Yellow
            Else
                ProgressBarMontLinea8.ForeColor = Color.Green
            End If
        End If
        'Update the production of shift
        LabelProductionShiftMontaggio8.Text = ShiftProduction(80, 8)
        '------------------------
        'Section to update the chart
        ds = UpdateChart(80, 8)
        If ds.Tables.Count = 0 Then
        Else
            ChartProduzioneOrariaMontaggio8.DataSource = ds
            ChartProduzioneOrariaMontaggio8.Series("Series1").XValueMember = ds.Tables("Table").Columns("Data").ToString()
            ChartProduzioneOrariaMontaggio8.Series("Series1").YValueMembers = ds.Tables("Table").Columns("ProduzioneStep").ToString()
            ChartProduzioneOrariaMontaggio8.DataBind()
        End If

        '-----------------------
        'FORMAZIONE LINEA 1
        'Update the traffic light
        status = UpdateTrafficLight(82, 1)
        If status = "Marcia" Then
            OvalShapeRedFormLin1.FillColor = Color.Silver
            OvalShapeYellowFormLin1.FillColor = Color.Silver
            OvalShapeGreenFormLin1.FillColor = Color.Lime
        End If

        If status = "Stop" Then
            OvalShapeRedFormLin1.FillColor = Color.Red
            OvalShapeYellowFormLin1.FillColor = Color.Silver
            OvalShapeGreenFormLin1.FillColor = Color.Silver
        End If

        If status = "Giustificativo" Then
            OvalShapeRedFormLin1.FillColor = Color.Silver
            OvalShapeYellowFormLin1.FillColor = Color.Yellow
            OvalShapeGreenFormLin1.FillColor = Color.Lime
        End If
        'Update the Production of the last hour
        LabelProductionSpeedFormLinea1.Text = ProductionOfLastHour(82, 1)
        produzioneorariariportataa100 = ((CInt(LabelProductionSpeedFormLinea1.Text) - 100) / (250 - 100)) * 100
        'Dim produzioneorariariportataa100 As Integer = ((CInt(LabelProductionSpeedLinea1.Text) - 11250) / (22000 - 11250)) * 100
        If produzioneorariariportataa100 > 100 Then
            ProgressBarFormLinea1.Value = 100
        Else
            If produzioneorariariportataa100 < 0 Then
                ProgressBarFormLinea1.Value = 0
            Else
                ProgressBarFormLinea1.Value = produzioneorariariportataa100
            End If
        End If

        If ProgressBarFormLinea1.Value < 33 Then
            ProgressBarFormLinea1.ForeColor = Color.Red
        Else
            If ProgressBarFormLinea1.Value < 66 Then
                ProgressBarFormLinea1.ForeColor = Color.Yellow
            Else
                ProgressBarFormLinea1.ForeColor = Color.Green
            End If
        End If
        'Update the production of shift
        LabelProductionShiftFormazione1.Text = ShiftProduction(82, 1)
        '------------------------
        'Section to update the chart
        ds = UpdateChart(82, 1)
        If ds.Tables.Count = 0 Then
        Else
            ChartProduzioneOrariaFormazione1.DataSource = ds
            ChartProduzioneOrariaFormazione1.Series("Series1").XValueMember = ds.Tables("Table").Columns("Data").ToString()
            ChartProduzioneOrariaFormazione1.Series("Series1").YValueMembers = ds.Tables("Table").Columns("ProduzioneStep").ToString()
            ChartProduzioneOrariaFormazione1.DataBind()
        End If
        '-----------------------
        'FORMAZIONE LINEA 2
        'Update the traffic light
        status = UpdateTrafficLight(82, 2)
        If status = "Marcia" Then
            OvalShapeRedFormLin2.FillColor = Color.Silver
            OvalShapeYellowFormLin2.FillColor = Color.Silver
            OvalShapeGreenFormLin2.FillColor = Color.Lime
        End If

        If status = "Stop" Then
            OvalShapeRedFormLin2.FillColor = Color.Red
            OvalShapeYellowFormLin2.FillColor = Color.Silver
            OvalShapeGreenFormLin2.FillColor = Color.Silver
        End If

        If status = "Giustificativo" Then
            OvalShapeRedFormLin2.FillColor = Color.Silver
            OvalShapeYellowFormLin2.FillColor = Color.Yellow
            OvalShapeGreenFormLin2.FillColor = Color.Lime
        End If
        'Update the Production of the last hour
        LabelProductionSpeedFormLinea2.Text = ProductionOfLastHour(82, 2)
        produzioneorariariportataa100 = ((CInt(LabelProductionSpeedFormLinea2.Text) - 100) / (250 - 100)) * 100
        'Dim produzioneorariariportataa100 As Integer = ((CInt(LabelProductionSpeedLinea1.Text) - 11250) / (22000 - 11250)) * 100
        If produzioneorariariportataa100 > 100 Then
            ProgressBarFormLinea2.Value = 100
        Else
            If produzioneorariariportataa100 < 0 Then
                ProgressBarFormLinea2.Value = 0
            Else
                ProgressBarFormLinea2.Value = produzioneorariariportataa100
            End If
        End If

        If ProgressBarFormLinea2.Value < 33 Then
            ProgressBarFormLinea2.ForeColor = Color.Red
        Else
            If ProgressBarFormLinea2.Value < 66 Then
                ProgressBarFormLinea2.ForeColor = Color.Yellow
            Else
                ProgressBarFormLinea2.ForeColor = Color.Green
            End If
        End If
        'Update the production of shift
        LabelProductionShiftFormazione2.Text = ShiftProduction(82, 2)
        '------------------------
        'Section to update the chart
        ds = UpdateChart(82, 2)
        If ds.Tables.Count = 0 Then
        Else
            ChartProduzioneOrariaFormazione2.DataSource = ds
            ChartProduzioneOrariaFormazione2.Series("Series1").XValueMember = ds.Tables("Table").Columns("Data").ToString()
            ChartProduzioneOrariaFormazione2.Series("Series1").YValueMembers = ds.Tables("Table").Columns("ProduzioneStep").ToString()
            ChartProduzioneOrariaFormazione2.DataBind()
        End If
        '------------------------


        '-----------------------
        'FORMAZIONE LINEA 3
        'Update the traffic light
        status = UpdateTrafficLight(82, 3)
        If status = "Marcia" Then
            OvalShapeRedFormLin3.FillColor = Color.Silver
            OvalShapeYellowFormLin3.FillColor = Color.Silver
            OvalShapeGreenFormLin3.FillColor = Color.Lime
        End If

        If status = "Stop" Then
            OvalShapeRedFormLin3.FillColor = Color.Red
            OvalShapeYellowFormLin3.FillColor = Color.Silver
            OvalShapeGreenFormLin3.FillColor = Color.Silver
        End If

        If status = "Giustificativo" Then
            OvalShapeRedFormLin3.FillColor = Color.Silver
            OvalShapeYellowFormLin3.FillColor = Color.Yellow
            OvalShapeGreenFormLin3.FillColor = Color.Lime
        End If
        'Update the Production of the last hour
        LabelProductionSpeedFormLinea3.Text = ProductionOfLastHour(82, 3)
        produzioneorariariportataa100 = ((CInt(LabelProductionSpeedFormLinea3.Text) - 100) / (250 - 100)) * 100
        'Dim produzioneorariariportataa100 As Integer = ((CInt(LabelProductionSpeedLinea1.Text) - 11250) / (22000 - 11250)) * 100
        If produzioneorariariportataa100 > 100 Then
            ProgressBarFormLinea3.Value = 100
        Else
            If produzioneorariariportataa100 < 0 Then
                ProgressBarFormLinea3.Value = 0
            Else
                ProgressBarFormLinea3.Value = produzioneorariariportataa100
            End If
        End If

        If ProgressBarFormLinea3.Value < 33 Then
            ProgressBarFormLinea3.ForeColor = Color.Red
        Else
            If ProgressBarFormLinea3.Value < 66 Then
                ProgressBarFormLinea3.ForeColor = Color.Yellow
            Else
                ProgressBarFormLinea3.ForeColor = Color.Green
            End If
        End If
        'Update the production of shift
        LabelProductionShiftFormazione3.Text = ShiftProduction(82, 3)
        '------------------------
        'Section to update the chart
        ds = UpdateChart(82, 3)
        If ds.Tables.Count = 0 Then
        Else

            ChartProduzioneOrariaFormazione3.DataSource = ds
            ChartProduzioneOrariaFormazione3.Series("Series1").XValueMember = ds.Tables("Table").Columns("Data").ToString()
            ChartProduzioneOrariaFormazione3.Series("Series1").YValueMembers = ds.Tables("Table").Columns("ProduzioneStep").ToString()
            ChartProduzioneOrariaFormazione3.DataBind()
        End If
        '------------------------


        '-----------------------
        'FORMAZIONE LINEA 4
        'Update the traffic light
        status = UpdateTrafficLight(82, 4)
        If status = "Marcia" Then
            OvalShapeRedFormLin4.FillColor = Color.Silver
            OvalShapeYellowFormLin4.FillColor = Color.Silver
            OvalShapeGreenFormLin4.FillColor = Color.Lime
        End If

        If status = "Stop" Then
            OvalShapeRedFormLin4.FillColor = Color.Red
            OvalShapeYellowFormLin4.FillColor = Color.Silver
            OvalShapeGreenFormLin4.FillColor = Color.Silver
        End If

        If status = "Giustificativo" Then
            OvalShapeRedFormLin4.FillColor = Color.Silver
            OvalShapeYellowFormLin4.FillColor = Color.Yellow
            OvalShapeGreenFormLin4.FillColor = Color.Lime
        End If
        'Update the Production of the last hour
        LabelProductionSpeedFormLinea4.Text = ProductionOfLastHour(82, 4)
        produzioneorariariportataa100 = ((CInt(LabelProductionSpeedFormLinea4.Text) - 100) / (250 - 100)) * 100
        'Dim produzioneorariariportataa100 As Integer = ((CInt(LabelProductionSpeedLinea1.Text) - 11250) / (22000 - 11250)) * 100
        If produzioneorariariportataa100 > 100 Then
            ProgressBarFormLinea4.Value = 100
        Else
            If produzioneorariariportataa100 < 0 Then
                ProgressBarFormLinea4.Value = 0
            Else
                ProgressBarFormLinea4.Value = produzioneorariariportataa100
            End If
        End If

        If ProgressBarFormLinea4.Value < 33 Then
            ProgressBarFormLinea4.ForeColor = Color.Red
        Else
            If ProgressBarFormLinea4.Value < 66 Then
                ProgressBarFormLinea4.ForeColor = Color.Yellow
            Else
                ProgressBarFormLinea4.ForeColor = Color.Green
            End If
        End If
        'Update the production of shift
        LabelProductionShiftFormazione4.Text = ShiftProduction(82, 4)
        '------------------------
        'Section to update the chart
        ds = UpdateChart(82, 4)
        If ds.Tables.Count = 0 Then
        Else

            ChartProduzioneOrariaFormazione4.DataSource = ds
            ChartProduzioneOrariaFormazione4.Series("Series1").XValueMember = ds.Tables("Table").Columns("Data").ToString()
            ChartProduzioneOrariaFormazione4.Series("Series1").YValueMembers = ds.Tables("Table").Columns("ProduzioneStep").ToString()
            ChartProduzioneOrariaFormazione4.DataBind()
        End If
        '------------------------


        '-----------------------
        'FORMAZIONE LINEA 5
        'Update the traffic light
        status = UpdateTrafficLight(82, 5)
        If status = "Marcia" Then
            OvalShapeRedFormLin5.FillColor = Color.Silver
            OvalShapeYellowFormLin5.FillColor = Color.Silver
            OvalShapeGreenFormLin5.FillColor = Color.Lime
        End If

        If status = "Stop" Then
            OvalShapeRedFormLin5.FillColor = Color.Red
            OvalShapeYellowFormLin5.FillColor = Color.Silver
            OvalShapeGreenFormLin5.FillColor = Color.Silver
        End If

        If status = "Giustificativo" Then
            OvalShapeRedFormLin5.FillColor = Color.Silver
            OvalShapeYellowFormLin5.FillColor = Color.Yellow
            OvalShapeGreenFormLin5.FillColor = Color.Lime
        End If
        'Update the Production of the last hour
        LabelProductionSpeedFormLinea5.Text = ProductionOfLastHour(82, 5)
        produzioneorariariportataa100 = ((CInt(LabelProductionSpeedFormLinea5.Text) - 100) / (250 - 100)) * 100
        'Dim produzioneorariariportataa100 As Integer = ((CInt(LabelProductionSpeedLinea1.Text) - 11250) / (22000 - 11250)) * 100
        If produzioneorariariportataa100 > 100 Then
            ProgressBarFormLinea5.Value = 100
        Else
            If produzioneorariariportataa100 < 0 Then
                ProgressBarFormLinea5.Value = 0
            Else
                ProgressBarFormLinea5.Value = produzioneorariariportataa100
            End If
        End If

        If ProgressBarFormLinea5.Value < 33 Then
            ProgressBarFormLinea5.ForeColor = Color.Red
        Else
            If ProgressBarFormLinea5.Value < 66 Then
                ProgressBarFormLinea5.ForeColor = Color.Yellow
            Else
                ProgressBarFormLinea5.ForeColor = Color.Green
            End If
        End If
        'Update the production of shift
        LabelProductionShiftFormazione5.Text = ShiftProduction(82, 5)
        '------------------------
        'Section to update the chart
        ds = UpdateChart(82, 5)
        If ds.Tables.Count = 0 Then
        Else

            ChartProduzioneOrariaFormazione5.DataSource = ds
            ChartProduzioneOrariaFormazione5.Series("Series1").XValueMember = ds.Tables("Table").Columns("Data").ToString()
            ChartProduzioneOrariaFormazione5.Series("Series1").YValueMembers = ds.Tables("Table").Columns("ProduzioneStep").ToString()
            ChartProduzioneOrariaFormazione5.DataBind()
        End If
        '------------------------

        '-----------------------
        'FINITURA LINEA 1
        'Update the traffic light
        status = UpdateTrafficLight(81, 1)
        If status = "Marcia" Then
            OvalShapeRedFinLin1.FillColor = Color.Silver
            OvalShapeYellowFinLin1.FillColor = Color.Silver
            OvalShapeGreenFinLin1.FillColor = Color.Lime
        End If

        If status = "Stop" Then
            OvalShapeRedFinLin1.FillColor = Color.Red
            OvalShapeYellowFinLin1.FillColor = Color.Silver
            OvalShapeGreenFinLin1.FillColor = Color.Silver
        End If

        If status = "Giustificativo" Then
            OvalShapeRedFinLin1.FillColor = Color.Silver
            OvalShapeYellowFinLin1.FillColor = Color.Yellow
            OvalShapeGreenFinLin1.FillColor = Color.Lime
        End If
        'Update the Production of the last hour
        LabelProductionSpeedFinLinea1.Text = ProductionOfLastHour(81, 1)
        produzioneorariariportataa100 = ((CInt(LabelProductionSpeedFinLinea1.Text) - 100) / (250 - 100)) * 100
        'Dim produzioneorariariportataa100 As Integer = ((CInt(LabelProductionSpeedLinea1.Text) - 11250) / (22000 - 11250)) * 100
        If produzioneorariariportataa100 > 100 Then
            ProgressBarFinLinea1.Value = 100
        Else
            If produzioneorariariportataa100 < 0 Then
                ProgressBarFinLinea1.Value = 0
            Else
                ProgressBarFinLinea1.Value = produzioneorariariportataa100
            End If
        End If

        If ProgressBarFinLinea1.Value < 33 Then
            ProgressBarFinLinea1.ForeColor = Color.Red
        Else
            If ProgressBarFinLinea1.Value < 66 Then
                ProgressBarFinLinea1.ForeColor = Color.Yellow
            Else
                ProgressBarFinLinea1.ForeColor = Color.Green
            End If
        End If
        'Update the production of shift
        LabelProductionShiftFin1.Text = ShiftProduction(81, 1)
        '------------------------
        'Section to update the chart
        ds = UpdateChart(81, 1)
        If ds.Tables.Count = 0 Then
        Else

            ChartProduzioneOrariaFin1.DataSource = ds
            ChartProduzioneOrariaFin1.Series("Series1").XValueMember = ds.Tables("Table").Columns("Data").ToString()
            ChartProduzioneOrariaFin1.Series("Series1").YValueMembers = ds.Tables("Table").Columns("ProduzioneStep").ToString()
            ChartProduzioneOrariaFin1.DataBind()
        End If
        '------------------------

        '-----------------------
        'FINITURA LINEA 2
        'Update the traffic light
        status = UpdateTrafficLight(81, 2)
        If status = "Marcia" Then
            OvalShapeRedFinLin2.FillColor = Color.Silver
            OvalShapeYellowFinLin2.FillColor = Color.Silver
            OvalShapeGreenFinLin2.FillColor = Color.Lime
        End If

        If status = "Stop" Then
            OvalShapeRedFinLin2.FillColor = Color.Red
            OvalShapeYellowFinLin2.FillColor = Color.Silver
            OvalShapeGreenFinLin2.FillColor = Color.Silver
        End If

        If status = "Giustificativo" Then
            OvalShapeRedFinLin2.FillColor = Color.Silver
            OvalShapeYellowFinLin2.FillColor = Color.Yellow
            OvalShapeGreenFinLin2.FillColor = Color.Lime
        End If
        'Update the Production of the last hour
        LabelProductionSpeedFinLinea2.Text = ProductionOfLastHour(81, 2)
        produzioneorariariportataa100 = ((CInt(LabelProductionSpeedFinLinea2.Text) - 100) / (250 - 100)) * 100
        'Dim produzioneorariariportataa100 As Integer = ((CInt(LabelProductionSpeedLinea1.Text) - 11250) / (22000 - 11250)) * 100
        If produzioneorariariportataa100 > 100 Then
            ProgressBarFinLinea2.Value = 100
        Else
            If produzioneorariariportataa100 < 0 Then
                ProgressBarFinLinea2.Value = 0
            Else
                ProgressBarFinLinea2.Value = produzioneorariariportataa100
            End If
        End If

        If ProgressBarFinLinea2.Value < 33 Then
            ProgressBarFinLinea2.ForeColor = Color.Red
        Else
            If ProgressBarFinLinea2.Value < 66 Then
                ProgressBarFinLinea2.ForeColor = Color.Yellow
            Else
                ProgressBarFinLinea2.ForeColor = Color.Green
            End If
        End If
        'Update the production of shift
        LabelProductionShiftFin2.Text = ShiftProduction(81, 2)
        '------------------------
        'Section to update the chart
        ds = UpdateChart(81, 2)
        If ds.Tables.Count = 0 Then
        Else

            ChartProduzioneOrariaFin2.DataSource = ds
            ChartProduzioneOrariaFin2.Series("Series1").XValueMember = ds.Tables("Table").Columns("Data").ToString()
            ChartProduzioneOrariaFin2.Series("Series1").YValueMembers = ds.Tables("Table").Columns("ProduzioneStep").ToString()
            ChartProduzioneOrariaFin2.DataBind()
        End If
        '------------------------

        '-----------------------
        'FINITURA LINEA 3
        'Update the traffic light
        status = UpdateTrafficLight(81, 3)
        If status = "Marcia" Then
            OvalShapeRedFinLin3.FillColor = Color.Silver
            OvalShapeYellowFinLin3.FillColor = Color.Silver
            OvalShapeGreenFinLin3.FillColor = Color.Lime
        End If

        If status = "Stop" Then
            OvalShapeRedFinLin3.FillColor = Color.Red
            OvalShapeYellowFinLin3.FillColor = Color.Silver
            OvalShapeGreenFinLin3.FillColor = Color.Silver
        End If

        If status = "Giustificativo" Then
            OvalShapeRedFinLin3.FillColor = Color.Silver
            OvalShapeYellowFinLin3.FillColor = Color.Yellow
            OvalShapeGreenFinLin3.FillColor = Color.Lime
        End If
        'Update the Production of the last hour
        LabelProductionSpeedFinLinea3.Text = ProductionOfLastHour(81, 3)
        produzioneorariariportataa100 = ((CInt(LabelProductionSpeedFinLinea3.Text) - 100) / (250 - 100)) * 100
        'Dim produzioneorariariportataa100 As Integer = ((CInt(LabelProductionSpeedLinea1.Text) - 11250) / (22000 - 11250)) * 100
        If produzioneorariariportataa100 > 100 Then
            ProgressBarFinLinea3.Value = 100
        Else
            If produzioneorariariportataa100 < 0 Then
                ProgressBarFinLinea3.Value = 0
            Else
                ProgressBarFinLinea3.Value = produzioneorariariportataa100
            End If
        End If

        If ProgressBarFinLinea3.Value < 33 Then
            ProgressBarFinLinea3.ForeColor = Color.Red
        Else
            If ProgressBarFinLinea3.Value < 66 Then
                ProgressBarFinLinea3.ForeColor = Color.Yellow
            Else
                ProgressBarFinLinea3.ForeColor = Color.Green
            End If
        End If
        'Update the production of shift
        LabelProductionShiftFin3.Text = ShiftProduction(81, 3)
        '------------------------
        'Section to update the chart
        ds = UpdateChart(81, 3)
        If ds.Tables.Count = 0 Then
        Else

            ChartProduzioneOrariaFin3.DataSource = ds
            ChartProduzioneOrariaFin3.Series("Series1").XValueMember = ds.Tables("Table").Columns("Data").ToString()
            ChartProduzioneOrariaFin3.Series("Series1").YValueMembers = ds.Tables("Table").Columns("ProduzioneStep").ToString()
            ChartProduzioneOrariaFin3.DataBind()
        End If

        '-----------------------
        'FINITURA LINEA 4
        'Update the traffic light
        status = UpdateTrafficLight(81, 4)
        If status = "Marcia" Then
            OvalShapeRedFinLin4.FillColor = Color.Silver
            OvalShapeYellowFinLin4.FillColor = Color.Silver
            OvalShapeGreenFinLin4.FillColor = Color.Lime
        End If

        If status = "Stop" Then
            OvalShapeRedFinLin4.FillColor = Color.Red
            OvalShapeYellowFinLin4.FillColor = Color.Silver
            OvalShapeGreenFinLin4.FillColor = Color.Silver
        End If

        If status = "Giustificativo" Then
            OvalShapeRedFinLin4.FillColor = Color.Silver
            OvalShapeYellowFinLin4.FillColor = Color.Yellow
            OvalShapeGreenFinLin4.FillColor = Color.Lime
        End If
        'Update the Production of the last hour
        LabelProductionSpeedFinLinea4.Text = ProductionOfLastHour(81, 4)
        produzioneorariariportataa100 = ((CInt(LabelProductionSpeedFinLinea4.Text) - 100) / (250 - 100)) * 100
        'Dim produzioneorariariportataa100 As Integer = ((CInt(LabelProductionSpeedLinea1.Text) - 11250) / (22000 - 11250)) * 100
        If produzioneorariariportataa100 > 100 Then
            ProgressBarFinLinea4.Value = 100
        Else
            If produzioneorariariportataa100 < 0 Then
                ProgressBarFinLinea4.Value = 0
            Else
                ProgressBarFinLinea4.Value = produzioneorariariportataa100
            End If
        End If

        If ProgressBarFinLinea4.Value < 33 Then
            ProgressBarFinLinea4.ForeColor = Color.Red
        Else
            If ProgressBarFinLinea4.Value < 66 Then
                ProgressBarFinLinea4.ForeColor = Color.Yellow
            Else
                ProgressBarFinLinea4.ForeColor = Color.Green
            End If
        End If
        'Update the production of shift
        LabelProductionShiftFin4.Text = ShiftProduction(81, 4)
        '------------------------
        'Section to update the chart
        ds = UpdateChart(81, 4)
        If ds.Tables.Count = 0 Then
        Else

            ChartProduzioneOrariaFin4.DataSource = ds
            ChartProduzioneOrariaFin4.Series("Series1").XValueMember = ds.Tables("Table").Columns("Data").ToString()
            ChartProduzioneOrariaFin4.Series("Series1").YValueMembers = ds.Tables("Table").Columns("ProduzioneStep").ToString()
            ChartProduzioneOrariaFin4.DataBind()
        End If

        '-----------------------

        '-----------------------
        'FINITURA LINEA 5
        'Update the traffic light
        status = UpdateTrafficLight(81, 5)
        If status = "Marcia" Then
            OvalShapeRedFinLin5.FillColor = Color.Silver
            OvalShapeYellowFinLin5.FillColor = Color.Silver
            OvalShapeGreenFinLin5.FillColor = Color.Lime
        End If

        If status = "Stop" Then
            OvalShapeRedFinLin5.FillColor = Color.Red
            OvalShapeYellowFinLin5.FillColor = Color.Silver
            OvalShapeGreenFinLin5.FillColor = Color.Silver
        End If

        If status = "Giustificativo" Then
            OvalShapeRedFinLin5.FillColor = Color.Silver
            OvalShapeYellowFinLin5.FillColor = Color.Yellow
            OvalShapeGreenFinLin5.FillColor = Color.Lime
        End If
        'Update the Production of the last hour
        LabelProductionSpeedFinLinea5.Text = ProductionOfLastHour(81, 5)
        produzioneorariariportataa100 = ((CInt(LabelProductionSpeedFinLinea5.Text) - 100) / (250 - 100)) * 100
        'Dim produzioneorariariportataa100 As Integer = ((CInt(LabelProductionSpeedLinea1.Text) - 11250) / (22000 - 11250)) * 100
        If produzioneorariariportataa100 > 100 Then
            ProgressBarFinLinea5.Value = 100
        Else
            If produzioneorariariportataa100 < 0 Then
                ProgressBarFinLinea5.Value = 0
            Else
                ProgressBarFinLinea5.Value = produzioneorariariportataa100
            End If
        End If

        If ProgressBarFinLinea5.Value < 33 Then
            ProgressBarFinLinea5.ForeColor = Color.Red
        Else
            If ProgressBarFinLinea5.Value < 66 Then
                ProgressBarFinLinea5.ForeColor = Color.Yellow
            Else
                ProgressBarFinLinea5.ForeColor = Color.Green
            End If
        End If
        'Update the production of shift
        LabelProductionShiftFin5.Text = ShiftProduction(81, 5)
        '------------------------
        'Section to update the chart
        ds = UpdateChart(81, 5)
        If ds.Tables.Count = 0 Then
        Else

            ChartProduzioneOrariaFin5.DataSource = ds
            ChartProduzioneOrariaFin5.Series("Series1").XValueMember = ds.Tables("Table").Columns("Data").ToString()
            ChartProduzioneOrariaFin5.Series("Series1").YValueMembers = ds.Tables("Table").Columns("ProduzioneStep").ToString()
            ChartProduzioneOrariaFin5.DataBind()
        End If

        '-----------------------
        '-----------------------
        TotProduzioneStiratura.Text = (CInt(LabelProductionShiftStiratura1.Text) + CInt(LabelProductionShiftStiratura2.Text) + CInt(LabelProductionShiftStiratura3.Text) + CInt(LabelProductionShiftStiratura4.Text) + CInt(LabelProductionShiftStiratura5.Text) + CInt(LabelProductionShiftStiratura6.Text)).ToString
        TotProduzioneMontaggio.Text = (CInt(LabelProductionShiftMontaggio1.Text) + CInt(LabelProductionShiftMontaggio2.Text) + CInt(LabelProductionShiftMontaggio3.Text) + CInt(LabelProductionShiftMontaggio4.Text) + CInt(LabelProductionShiftMontaggio5.Text) + CInt(LabelProductionShiftMontaggio6.Text) + CInt(LabelProductionShiftMontaggio7.Text) + CInt(LabelProductionShiftMontaggio8.Text)).ToString
        TotProduzioneFormazione.Text = (CInt(LabelProductionShiftFormazione1.Text) + CInt(LabelProductionShiftFormazione2.Text) + CInt(LabelProductionShiftFormazione3.Text) + CInt(LabelProductionShiftFormazione4.Text) + CInt(LabelProductionShiftFormazione5.Text)).ToString
        TotProduzioneFinitura.Text = (CInt(LabelProductionShiftFin1.Text) + CInt(LabelProductionShiftFin2.Text) + CInt(LabelProductionShiftFin3.Text) + CInt(LabelProductionShiftFin4.Text) + CInt(LabelProductionShiftFin5.Text)).ToString

        LabelLancioMontLinea1.Text = ShowLanciProduzioneIncorso(80, 1)
        LabelLancioMontLinea2.Text = ShowLanciProduzioneIncorso(80, 2)

    End Sub

    Function ShowLanciProduzioneIncorso(Reparto As String, Linea As String)

        Dim myConn As New SqlConnection(LabelPathDatabase.Text)
        Dim myCmd As SqlCommand
        myCmd = myConn.CreateCommand()
        myCmd.CommandText = "SELECT LancioInCorso FROM StatoLinee WHERE (Id_Reparto=" & Reparto & ") AND (Id_linea=" & Linea & ")"
        myCmd.Connection.Open()
        Dim Lancio As String = myCmd.ExecuteScalar()
        myCmd.Connection.Close()

        Dim myCmd2 As SqlCommand
        myCmd2 = myConn.CreateCommand()
        myCmd2.CommandText = "SELECT Materiale FROM LanciProduzione WHERE (Ordpian='" & Lancio & "')"
        myCmd2.Connection.Open()
        Dim Testo As String = Lancio & " - " & myCmd2.ExecuteScalar()
        myCmd2.Connection.Close()

        Dim myCmd3 As SqlCommand
        myCmd3 = myConn.CreateCommand()
        myCmd3.CommandText = "SELECT Serie FROM LanciProduzione WHERE (Ordpian=" & Lancio & ")"
        myCmd3.Connection.Open()
        Testo = Testo & " - " & myCmd3.ExecuteScalar()
        myCmd3.Connection.Close()

        Return Testo

    End Function

    Function UpdateTrafficLight(Reparto As String, Linea As String)
        Dim Stato As String
        Dim myConn As New SqlConnection(LabelPathDatabase.Text)
        Dim myCmd As SqlCommand
        myCmd = myConn.CreateCommand()
        myCmd.CommandText = "SELECT Stato FROM StatoLinee WHERE (Id_Reparto=" & Reparto & ") AND (Id_linea=" & Linea & ")"
        myCmd.Connection.Open()
        Stato = myCmd.ExecuteScalar()
        myCmd.Connection.Close()
        Return Stato
    End Function

    Function ProductionOfLastHour(Reparto As String, Linea As String)
        Dim Production As Int32
        Dim myConn As New SqlConnection(LabelPathDatabase.Text)
        Dim myCmd As SqlCommand
        myCmd = myConn.CreateCommand()
        'find the production of the last hour
        myCmd.CommandText = "SELECT SUM(PRODUZIONESTEP) FROM datiProduzione WHERE ((Id_Reparto=" & Reparto & " ) AND (Id_linea=" & Linea & ")AND(DATA >= '" & DataFormatting(DateTime.Now.AddHours(-1)) & "')AND(DATA <= '" & DataFormatting(DateTime.Now) & "'));"

        myCmd.Connection.Open()
        If IsDBNull(myCmd.ExecuteScalar()) Then
        Else
            Production = myCmd.ExecuteScalar()
            myCmd.Connection.Close()
        End If
        Return Production

    End Function

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

    Function UpdateChart(Reparto As String, Linea As String)
        Dim myConn As New SqlConnection(LabelPathDatabase.Text)
        Dim myCmd As SqlCommand
        Dim ds As New DataSet
        myCmd = myConn.CreateCommand()
        myCmd.Connection.Open()
        myCmd.CommandText = ("SELECT Data, ProduzioneStep FROM DatiProduzione WHERE ((Id_Reparto='" & Reparto & "') AND (Id_linea='" & Linea & "')AND(DATA >= '" & DataFormatting(DateTime.Now().AddHours(-8)) & "')AND(DATA <= '" & DataFormatting(DateTime.Now()) & "'))ORDER BY Data ")
        Dim myReader As SqlDataReader = myCmd.ExecuteReader(CommandBehavior.CloseConnection)
        myReader.Close()
        Dim adapter As New SqlDataAdapter(myCmd.CommandText, myConn)
        adapter.Fill(ds)
        myCmd.Connection.Close()
        Return ds
    End Function

    Private Sub TimerCurrentTime_Tick(sender As Object, e As EventArgs) Handles TimerCurrentTime.Tick
        LabelCurrentTime.Text = DateTime.Now.ToString()
    End Sub

    Private Sub ButtonImportaLanci_Click(sender As Object, e As EventArgs) Handles ButtonImportaLanci.Click

        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim range As Excel.Range
        Dim rCnt As Integer
       Dim Obj As Object

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Open("\\fiammitfs02\CorporateShare\Prod\IB_Fermi\ArduinoFermi\lista lanci produzione.xlsx")
        xlWorkSheet = xlWorkBook.Worksheets("Foglio1")
        Dim myConn As New SqlConnection(LabelPathDatabase.Text)
        Dim myCmd As SqlCommand

        range = xlWorkSheet.UsedRange


        myCmd = myConn.CreateCommand()
        myCmd.Connection.Open()
        For rCnt = 1 To 9 'DA SISTEMARE IL CONTEGGIO DELLE RIGHE
            myCmd.CommandText = ("INSERT INTO LanciProduzione (Ordpian,Materiale,[Materiale pianif#],Linea,[Qtà ordine],UMO,[Fine card#],Sequenza,SERIE,ProgressivoQuantita)VALUES (" & range.Cells(rCnt + 1, 1).value.ToString & "," & range.Cells(rCnt + 1, 2).value.ToString & ",'" & range.Cells(rCnt + 1, 3).value.ToString & "','" & range.Cells(rCnt + 1, 4).value.ToString & "','" & range.Cells(rCnt + 1, 5).value.ToString & "','" & range.Cells(rCnt + 1, 6).value.ToString & "','" & CDate(range.Cells(rCnt + 1, 7).value.ToString) & "','" & range.Cells(rCnt + 1, 8).value.ToString & "','" & range.Cells(rCnt + 1, 9).value.ToString & "','" & range.Cells(rCnt + 1, 10).value.ToString & "')")
            myCmd.ExecuteNonQuery()
        Next
        myCmd.Connection.Close()

        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        MsgBox("Lanci correttamente importati", MsgBoxStyle.OkOnly)

    End Sub


    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub ButtonVisualizzaLanci_Click(sender As Object, e As EventArgs) Handles ButtonVisualizzaLanci.Click

        Dim myConn As New SqlConnection(LabelPathDatabase.Text)
        Dim myCmd As SqlCommand

        myCmd = myConn.CreateCommand()

        myCmd.CommandText = "SELECT * FROM LanciProduzione"

        myCmd.Connection.Open()
        Dim dtRegistro As DataTable = New DataTable
        Dim myDataAdapter As New SqlDataAdapter(myCmd)
        myDataAdapter.Fill(dtRegistro)
        DataGridViewLanciMontaggio.DataSource = dtRegistro
        myCmd.Connection.Close()


    End Sub

    
End Class