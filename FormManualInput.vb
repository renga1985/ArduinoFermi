Imports System.Data.SqlClient
Imports System.IO

Public Class FormManualInput

    Private Sub FormManualInput_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Definisce la stringa path e gli assegna il percorso del file di configurazione
        Dim path As String = "C:\ArduinoFermi\config.txt"
        Try
            'Crea un oggetto della classe streamreader per leggere il file di testo path
            Dim sr As StreamReader = New StreamReader(path)
            'Lancia un ciclo do/while che continua fino a che non sono state lette tutte le righe del file di configurazione o fino a che trova la riga desiderata
            Do While sr.Peek() >= 0
                'Definisce la stringa RowString e gli assegna la riga che legge dall'oggetto sr tramite la funzione ReadLine
                Dim rowstring As String = sr.ReadLine()
                'Verifica se la stringa letta è quella della riga contenente il percorso del database
                If Strings.Left(rowstring, 14) = "[DatabasePath]" Then
                    'We save this also in a label of the application (salva la sottostringa che estrae nell'etichetta Label.Text dell'applicazione)
                    LabelPath.Text = rowstring.Substring(15, rowstring.Length - 15)
                    'Quando trova la riga interessata esce dal ciclo do
                    Exit Do
                End If
            Loop
            sr.Close()
        Catch ex As Exception
            MsgBox("Si è verificato un errore nel recupero delle informazioni dal file config.txt")
        End Try
    End Sub

    Private Sub ButtonRegistra_Click(sender As Object, e As EventArgs) Handles ButtonRegistra.Click

        'FARE ATTENZIONE AI FORMATI DATA, IN SQL VARIA: a-g-m oppure a-m-g, capire perchè varia e come impostarlo fisso in SQL

        'Inserisco una serie di controlli per verificare che tutti i dati siano stati inseriti

        If LabelRepartoSelected.Text = "" Then
            MsgBox("Inserire il reparto")
            TextBoxReparto.SelectAll()
            Exit Sub
        End If

        If LabelLineaSelected.Text = "" Then
            MsgBox("Inserire la linea")
            TextBoxLinea.SelectAll()
            Exit Sub
        End If

        If LabelMacchinaSelected.Text = "" Then
            MsgBox("Inserire la macchina")
            TextBoxMacchina.SelectAll()
            Exit Sub
        End If

        If LabelFermoSelected.Text = "" Then
            MsgBox("Inserire il fermo")
            TextBoxFermo.SelectAll()
            Exit Sub
        End If

        If TextBoxInizio.Text = "" Then
            MsgBox("Inserire l'ora di inizio del fermo")
            TextBoxInizio.SelectAll()
            Exit Sub
        End If

        If TextBoxDurata.Text = "" Then
            MsgBox("Inserire la durata del fermo")
            TextBoxReparto.SelectAll()
            Exit Sub
        End If

        'Id value of the new stop

        Dim ValoreId As Integer
        Dim myConn = New SqlConnection(LabelPath.Text)
        Dim myCmd1 As SqlCommand
        myCmd1 = myConn.CreateCommand()
        myCmd1.CommandText = "SELECT Id FROM Fermi ORDER BY Id DESC"
        myCmd1.Connection.Open()
        ValoreId = myCmd1.ExecuteScalar() + 1
        myCmd1.Connection.Close()

        Dim adesso As String
        'adesso = DateTime.Now().Year.ToString() & "-" & DateTime.Now().Month.ToString() & "-" & DateTime.Now.Day.ToString & " " & DateTime.Now.Hour.ToString & ":" & DateTime.Now.Minute.ToString & ":" & DateTime.Now.Second.ToString
        adesso = DateTime.Now().Year.ToString() & "-" & DateTime.Now().Day.ToString() & "-" & DateTime.Now.Month.ToString & " " & DateTime.Now.Hour.ToString & ":" & DateTime.Now.Minute.ToString & ":" & DateTime.Now.Second.ToString

        Dim data As Date
        data = DateTimePicker1.Text
        Dim inizio As String
        'inizio = data.Year.ToString() & "-" & data.Month.ToString() & "-" & data.Day.ToString() & " " & TextBoxInizio.Text.Substring(0, 2) & ":" & TextBoxInizio.Text.Substring(3, 2) & ":00"
        inizio = data.Year.ToString() & "-" & data.Day.ToString() & "-" & data.Month.ToString() & " " & TextBoxInizio.Text.Substring(0, 2) & ":" & TextBoxInizio.Text.Substring(3, 2) & ":00"

        'Definisco i dati che mi servono per impostare il formato data e lancio la funzione che calcola la data di fine fermo

        Dim fine As String
        Dim durata As Integer

        durata = TextBoxDurata.Text
        fine = CalcoloDataFine(data, durata)

        'Definisco il comando della query di inserimento di una riga alla tabella fermi del database
        'Dim myConn = New SqlConnection(LabelPath.Text)
        Dim myCmd2 As SqlCommand
        myCmd2 = myConn.CreateCommand()
        myCmd2.CommandText = "INSERT INTO Fermi (Id,Data,IdReparto,DescReparto,IdLinea,DescLInea,IdMacchina,DescMAcchina,IdFermo,DescFermo,Durata,Secondario,Da,A,DataInizioFermo,DataFineFermo,DescFermoEsteso)VALUES ('" & ValoreId & "','" & adesso & "','" & TextBoxReparto.Text & "','" & LabelRepartoSelected.Text & "','" & TextBoxLinea.Text & "','" & LabelLineaSelected.Text & "','" & TextBoxMacchina.Text & "','" & LabelMacchinaSelected.Text & "','" & TextBoxFermo.Text & "','" & LabelFermoSelected.Text & "','" & TextBoxDurata.Text & "','" & ComboBoxSecondario.Text & "','" & TextBoxDA.Text & "','" & TextBoxA.Text & "','" & inizio & "','" & fine & "','MANUALE')"

        myCmd2.Connection.Open()
        Dim numberOfRow As Int16 = myCmd2.ExecuteNonQuery()
        myCmd2.Connection.Close()

        'Copio i dati del fermo appena inserito nelle etichette per visualizzarli sulla maschera

        LastReparto.Text = LabelRepartoSelected.Text
        LastLinea.Text = LabelLineaSelected.Text
        LastMacchina.Text = LabelMacchinaSelected.Text
        LastFermo.Text = LabelFermoSelected.Text
        LastInizio.Text = TextBoxInizio.Text
        LastDurata.Text = TextBoxDurata.Text
        LastSecondario.Text = ComboBoxSecondario.Text
        LastDA.Text = TextBoxDA.Text
        LastA.Text = TextBoxA.Text

        TextBoxInizio.Text = ""
        TextBoxDA.Text = ""
        TextBoxA.Text = ""
        ComboBoxSecondario.Text = "FALSO"

        'Mi riposiziono sul box macchina per partire da qui con il nuovo fermo

        TextBoxMacchina.Select()

    End Sub

    Private Sub TextBoxReparto_Leave(sender As Object, e As EventArgs) Handles TextBoxReparto.Leave
        If TextBoxReparto.Text <> "" Then
            'Crea la connessione al database SQL
            Dim myConn = New SqlConnection(LabelPath.Text)

            'Crea il comando della query che seleziona il reparto inserito dalla tabella apposita
            Dim myCmd As SqlCommand
            myCmd = myConn.CreateCommand()
            myCmd.CommandText = "SELECT Reparto FROM Reparti WHERE IdReparto=" & TextBoxReparto.Text & ""
            myCmd.Connection.Open()
            'Esegue il comando e salva la prima colonna della prima riga della query sull'etichetta della Linea
            LabelRepartoSelected.Text = myCmd.ExecuteScalar()
            myCmd.Connection.Close()
        End If
        'TextBoxLinea.Select()
    End Sub


    Private Sub TextBoxLinea_Leave(sender As Object, e As EventArgs) Handles TextBoxLinea.Leave
        If TextBoxLinea.Text <> "" Then
            Dim myConn = New SqlConnection(LabelPath.Text)

            'Crea il comando della query che seleziona la linea inserita
            Dim myCmd As SqlCommand
            myCmd = myConn.CreateCommand()
            myCmd.CommandText = "SELECT Linea FROM Linee WHERE (IdReparto=" & TextBoxReparto.Text & " AND IdLinea=" & TextBoxLinea.Text & ")"
            myCmd.Connection.Open()
            LabelLineaSelected.Text = myCmd.ExecuteScalar()
            myCmd.Connection.Close()
        End If
    End Sub

    Private Sub TextBoxMacchina_Leave(sender As Object, e As EventArgs) Handles TextBoxMacchina.Leave
        If TextBoxMacchina.Text <> "" Then
            Dim myConn = New SqlConnection(LabelPath.Text)

            Dim myCmd As SqlCommand
            myCmd = myConn.CreateCommand()
            myCmd.CommandText = "SELECT Macchina FROM Macchine WHERE (IdReparto=" & TextBoxReparto.Text & "AND IdMacchina=" & TextBoxMacchina.Text & ")"
            myCmd.Connection.Open()
            LabelMacchinaSelected.Text = myCmd.ExecuteScalar()
            myCmd.Connection.Close()
        End If
    End Sub

    Private Sub TextBoxFermo_Leave(sender As Object, e As EventArgs) Handles TextBoxFermo.Leave
        If TextBoxFermo.Text <> "" Then
            Dim myConn = New SqlConnection(LabelPath.Text)

            Dim myCmd As SqlCommand
            myCmd = myConn.CreateCommand()
            myCmd.CommandText = "SELECT Fermo FROM CodiceFermi WHERE (IdReparto=" & TextBoxReparto.Text & "AND IdMacchina=" & TextBoxMacchina.Text & " AND IdFermo=" & TextBoxFermo.Text & ")"
            myCmd.Connection.Open()
            LabelFermoSelected.Text = myCmd.ExecuteScalar()
            myCmd.Connection.Close()
        End If
    End Sub

    Function CalcoloDataFine(data As Date, durata As Integer)

        Dim datafine As String

        'Calcolo la durata del fermo in ore e minuti
        Dim ore As Integer
        Dim min As Integer
        durata = TextBoxDurata.Text
        ore = Int(durata / 60)
        min = durata - ore * 60

        Dim minfine As Integer
        Dim orefine As Integer
        Dim giornofine As Integer
        Dim mesefine As Integer
        Dim annofine As Integer


        minfine = TextBoxInizio.Text.Substring(3, 2) + min
        orefine = TextBoxInizio.Text.Substring(0, 2)
        If minfine > 59 Then
            minfine = minfine - 60
            orefine = TextBoxInizio.Text.Substring(0, 2) + 1
        End If

        orefine = orefine + ore
        giornofine = data.Day.ToString()
        If orefine > 23 Then
            orefine = orefine - 24
            giornofine = data.Day.ToString() + 1
        End If

        mesefine = data.Month.ToString()
        If giornofine > 28 Then
            If giornofine > 30 Or data.Month.ToString() = "2" Then
                If giornofine > 31 Or data.Month.ToString() = "2" Or data.Month.ToString() = "4" Or data.Month.ToString() = "6" Or data.Month.ToString() = "9" Or data.Month.ToString() = "11" Then
                    giornofine = 1
                    mesefine = data.Month.ToString() + 1
                End If
            End If
        End If

        annofine = data.Year.ToString()
        If mesefine > 12 Then
            mesefine = 1
            annofine = data.Year.ToString() + 1
        End If

        'ifine = annofine & "-" & mesefine & "-" & giornofine & " " & orefine & ":" & minfine & ":00"
        datafine = annofine & "-" & giornofine & "-" & mesefine & " " & orefine & ":" & minfine & ":00"

        Return datafine

    End Function

    Private Sub TextBoxInizio_Leave(sender As Object, e As EventArgs) Handles TextBoxInizio.Leave

        Dim one As String
        Dim sx As String
        Dim dx As String

        If TextBoxInizio.Text = "" Then
        Else

            If TextBoxInizio.Text.Substring(1, 1) = "." Then
                one = Strings.Left(TextBoxInizio.Text, 1)
                sx = "0" & one
                dx = Strings.Right(TextBoxInizio.Text, 2)
                TextBoxInizio.Text = sx & "." & dx
            Else
            End If

            If TextBoxInizio.Text.Length = 5 Then
            Else
                MsgBox("Formato ora non corretto")
                TextBoxInizio.SelectAll()
            End If

        End If

    End Sub

    Private Sub ComboBoxSecondario_Leave(sender As Object, e As EventArgs) Handles ComboBoxSecondario.Leave

        If LabelFermoSelected.Text = "Cambio Produzione" Then
        Else
            ButtonRegistra.Select()
        End If

    End Sub

    'Queste istruzioni che si attivano quando si entra in un box è stato realizzato per far sì che ogni volta che si entra in un box tutto il suo contenuto 
    'viene selezionato e si può scrivere direttamente il nuovo valore senza dover tornare indietro o cancellare, l'inserimento sarà così più veloce

    Private Sub TextBoxReparto_Enter(sender As Object, e As EventArgs) Handles TextBoxReparto.Enter
        TextBoxReparto.SelectAll()
    End Sub

    Private Sub TextBoxLinea_Enter(sender As Object, e As EventArgs) Handles TextBoxLinea.Enter
        TextBoxLinea.SelectAll()
    End Sub

    Private Sub TextBoxMacchina_Enter(sender As Object, e As EventArgs) Handles TextBoxMacchina.Enter
        TextBoxMacchina.SelectAll()
    End Sub

    Private Sub TextBoxFermo_Enter(sender As Object, e As EventArgs) Handles TextBoxFermo.Enter
        TextBoxFermo.SelectAll()
    End Sub

    Private Sub TestBoxInizio_Enter(sender As Object, e As EventArgs) Handles TextBoxInizio.Enter
        TextBoxInizio.SelectAll()
    End Sub

    Private Sub TextBoxDurata_Enter(sender As Object, e As EventArgs) Handles TextBoxDurata.Enter
        TextBoxDurata.SelectAll()
    End Sub

    Private Sub TextBoxDA_Enter(sender As Object, e As EventArgs) Handles TextBoxDA.Enter
        TextBoxDA.SelectAll()
    End Sub

    Private Sub TextBoxA_Enter(sender As Object, e As EventArgs) Handles TextBoxA.Enter
        TextBoxA.SelectAll()
    End Sub

    Private Sub ButtonVisualizzaFermi_Click(sender As Object, e As EventArgs) Handles ButtonVisualizzaFermi.Click
        VisualizzaFermateManuale.Show()
    End Sub

End Class