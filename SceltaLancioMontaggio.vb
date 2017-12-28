Imports System.Data.SqlClient

Public Class SceltaLancioMontaggio

    Private Sub SceltaLancio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim myConn As New SqlConnection(Form1.LblPathDatabase.Text)
        'Dim myConn As New SqlConnection("Data Source=MATTI\SQLEXPRESS;initial Catalog=VRNFermi; Integrated Security=True")
        Dim myCmd As SqlCommand
        myCmd = myConn.CreateCommand()
        myCmd.CommandText = "SELECT COUNT (DataInizio) FROM Produzione WHERE (IdReparto=" & Form1.LblIdDepartment.Text & " AND IdLinea=" & Form1.LblIdLinea.Text & " AND DataFine IS NULL)"
        myCmd.Connection.Open()

        If myCmd.ExecuteScalar() = 0 Then

            'There is no opened production order for the line

            LabelLancio.Visible = False
            ComboBoxLancio.Visible = True
            myCmd.Connection.Close()

            Dim myCmd1 As SqlCommand
            myCmd1 = myConn.CreateCommand()
            myCmd1.CommandText = "SELECT [Codice Linea] FROM Linee WHERE (IdReparto='" & Form1.LblIdDepartment.Text & "') AND (IdLinea='" & Form1.LblIdLinea.Text & "')"
            myCmd1.Connection.Open()
            Dim CodiceLinea As String
            CodiceLinea = myCmd1.ExecuteScalar()
            myCmd1.Connection.Close()


            Dim myCmd2 As SqlCommand
            myCmd2 = myConn.CreateCommand()
            myCmd2.CommandText = "SELECT * FROM LanciProduzione WHERE (Linea='" & CodiceLinea & "') AND ((StatoLancio='Sospeso') OR (StatoLancio IS NULL))"
            myCmd2.Connection.Open()
            Dim ds As New DataSet
            Dim adapter As New SqlDataAdapter(myCmd2.CommandText, myConn)
            adapter.Fill(ds)
            'myReader.Close()
            myCmd2.Connection.Close()

            ComboBoxLancio.DataSource = ds.Tables(0)
            ComboBoxLancio.ValueMember = "Ordpian"
            ComboBoxLancio.DisplayMember = "Ordpian"

            ComboBoxLancio.Text = ""
            TextBoxLancioProduzione.Text = ""
            LabelCodice.Text = ""
            LabelQuantitàLancio.Text = ""
            LabelQuantitàMancante.Text = ""
            LabelProduzioneTurno.Visible = False
            LabelPallett.Visible = False
            LabelPezzi.Visible = False
            LabelPoliRifatti.Visible = False
            TextBoxPallett.Visible = False
            TextBoxProduzionePezzi.Visible = False
            TextBoxPoliRifatti.Visible = False
            LabelScartoTurno.Visible = False
            LabelFuoriCella.Visible = False
            LabelPoloPiantato.Visible = False
            LabelPoloFuso.Visible = False
            LabelAltro.Visible = False
            TextBoxScartoFuoriCella.Visible = False
            TextBoxScartoPoloPiantato.Visible = False
            TextBoxScartoPoloFuso.Visible = False
            TextBoxScartoAltro.Visible = False
            LabelControlloDistruttivo.Visible = False
            TextBoxControlloDistruttivo.Visible = False
            LabelNote.Visible = False
            RichTextBoxNote.Visible = False

            ComboBoxLancio.Visible = True

            ButtonChiudiLancio.Enabled = False
            ButtonConfermaLancio.Enabled = True
            ButtonCancella.Enabled = True

        Else
            'There is already an opened order in the line
            myCmd.Connection.Close()
            Dim myCmd3 As SqlCommand
            myCmd3 = myConn.CreateCommand()
            myCmd3.CommandText = "SELECT Lancio FROM Produzione WHERE (IdReparto='" & Form1.LblIdDepartment.Text & "' AND IdLinea='" & Form1.LblIdLinea.Text & "' AND DataFine IS NULL)"
            myCmd3.Connection.Open()
            TextBoxLancioProduzione.Text = myCmd3.ExecuteScalar()
            myCmd3.Connection.Close()

            Dim myCmd4 As SqlCommand
            myCmd4 = myConn.CreateCommand()
            myCmd4.CommandText = "SELECT Turno FROM Produzione WHERE (Lancio='" & TextBoxLancioProduzione.Text & "' AND DataFine IS NULL)"
            myCmd4.Connection.Open()
            ComboBoxTurno.Text = myCmd4.ExecuteScalar()
            myCmd4.Connection.Close()

            ComboBoxLancio.Visible = False

            ButtonChiudiLancio.Enabled = True
            ButtonConfermaLancio.Enabled = False
            ButtonCancella.Enabled = False

        End If

    End Sub

    Private Sub ComboBoxLancio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxLancio.SelectedIndexChanged

        'Importante inserire questo tipo di evento altrimenti non parte nel momento giusto
        TextBoxLancioProduzione.Text = ComboBoxLancio.Text
    End Sub

    '  Private Sub ComboBoxLancio_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBoxLancio.SelectionChangeCommitted

    ' Dim myConn As New SqlConnection(Form1.LblPathDatabase.Text)
    ' Dim myCmd As SqlCommand
    'myCmd = myConn.CreateCommand()
    'myCmd.CommandText = "SELECT Materiale FROM LanciProduzione WHERE (Ordpian='" & ComboBoxLancio.Text & "')"
    'myCmd.Connection.Open()
    'LabelCodice.Text = myCmd.ExecuteScalar()
    'myCmd.Connection.Close()

    'Dim myCmd2 As SqlCommand
    'myCmd2 = myConn.CreateCommand()
    'myCmd2.CommandText = "SELECT ([Qtà Ordine]) FROM LanciProduzione WHERE (Ordpian='" & ComboBoxLancio.Text & "')"
    'myCmd2.Connection.Open()
    'LabelQuantitàLancio.Text = myCmd2.ExecuteScalar()
    'myCmd2.Connection.Close()
    'LabelQuantitàMancante.Text = LabelQuantitàLancio.Text

    ' TextBoxLancioProduzione.Text = ComboBoxLancio.Text

    'Dim myConn As New SqlConnection(Form1.LblPathDatabase.Text)
    'Dim myCmd As SqlCommand
    'myCmd2 = myConn.CreateCommand()
    'myCmd2.CommandText = "Update STATOLINEE SET LANCIOINCORSO=" & ComboBoxLancio.SelectedValue.ToString() & " WHERE (Id_reparto=" & Form1.LblIdDepartment.Text.ToString() & " AND Id_linea=" & Form1.LblIdLinea.Text & ")"

    ' myCmd2.Connection.Open()
    'myCmd2.ExecuteNonQuery()
    'myCmd2.Connection.Close()
    ' Me.Close()

    ' End Sub

    Private Sub TextBoxLancioProduzione_TextChanged(sender As Object, e As EventArgs) Handles TextBoxLancioProduzione.TextChanged

        If TextBoxLancioProduzione.Text.Length >= 8 Then

            Dim myConn As New SqlConnection(Form1.LblPathDatabase.Text)
            Dim myCmd As SqlCommand
            myCmd = myConn.CreateCommand()
            myCmd.CommandText = "SELECT Materiale FROM LanciProduzione WHERE (Ordpian='" & TextBoxLancioProduzione.Text & "')"
            myCmd.Connection.Open()

            If IsDBNull(myCmd.ExecuteScalar()) Then
                'close the connection and do nothing
                myCmd.Connection.Close()
            Else

                LabelCodice.Text = myCmd.ExecuteScalar()
                myCmd.Connection.Close()

                Dim myCmd2 As SqlCommand
                myCmd2 = myConn.CreateCommand()
                myCmd2.CommandText = "SELECT ([Qtà Ordine]) FROM LanciProduzione WHERE (Ordpian='" & TextBoxLancioProduzione.Text & "')"
                myCmd2.Connection.Open()
                LabelQuantitàLancio.Text = myCmd2.ExecuteScalar()
                myCmd2.Connection.Close()
                LabelQuantitàMancante.Text = LabelQuantitàLancio.Text
                Dim myCmd3 As SqlCommand
                myCmd3 = myConn.CreateCommand()
                myCmd3.CommandText = "SELECT QuantitàMancante FROM LanciProduzione WHERE (Ordpian='" & TextBoxLancioProduzione.Text & "')"
                myCmd3.Connection.Open()
                LabelQuantitàMancante.Text = myCmd3.ExecuteScalar()
                myCmd3.Connection.Close()
            End If
        Else
            'do nothing
        End If
    End Sub
    Private Sub ButtonCancella_Click(sender As Object, e As EventArgs) Handles ButtonCancella.Click

        TextBoxLancioProduzione.Text = ""
        LabelCodice.Text = ""
        LabelQuantitàLancio.Text = ""
        LabelQuantitàMancante.Text = ""
        ComboBoxLancio.Text = ""
        TextBoxLancioProduzione.Select()

    End Sub
    Private Sub ButtonConfermaLancio_Click(sender As Object, e As EventArgs) Handles ButtonConfermaLancio.Click

        If ComboBoxTurno.Text = "" Then

            'Message error and do nothing 
            MsgBox("Inserire il turno di produzione corrente")

        Else

            Dim myConn As New SqlConnection(Form1.LblPathDatabase.Text)
            Dim myCmd As SqlCommand
            myCmd = myConn.CreateCommand()

            myCmd.CommandText = "INSERT INTO Produzione (DataInizio,Turno,IdReparto,Reparto,IdLinea,Linea,Lancio,Codice) VALUES ('" & DataFormatting(DateTime.Now) & "','" & ComboBoxTurno.Text & "','" & Form1.LblIdDepartment.Text & "','" & Form1.LblDepartmentDescription.Text & "','" & Form1.LblIdLinea.Text & "','" & Form1.LblLineDescription.Text & "','" & TextBoxLancioProduzione.Text & "','" & LabelCodice.Text & "')"
            myCmd.Connection.Open()
            myCmd.ExecuteNonQuery()
            myCmd.Connection.Close()

            Dim myCmd2 As SqlCommand
            myCmd2 = myConn.CreateCommand()
            myCmd2.CommandText = "UPDATE StatoLinee SET LancioInCorso ='" & TextBoxLancioProduzione.Text & "' WHERE (Id_reparto ='" & Form1.LblIdDepartment.Text & "' AND Id_linea='" & Form1.LblIdLinea.Text & "')"
            myCmd2.Connection.Open()
            myCmd2.ExecuteNonQuery()
            myCmd2.Connection.Close()

            Dim myCmd3 As SqlCommand
            myCmd3 = myConn.CreateCommand()
            myCmd3.CommandText = "UPDATE LanciProduzione SET StatoLancio ='In corso' WHERE (Ordpian ='" & TextBoxLancioProduzione.Text & "')"
            myCmd3.Connection.Open()
            myCmd3.ExecuteNonQuery()
            myCmd3.Connection.Close()

            'Show the label and textbox with production data

            LabelLancio.Visible = True
            LabelProduzioneTurno.Visible = True
            LabelPallett.Visible = True
            LabelPezzi.Visible = True
            LabelPoliRifatti.Visible = True
            TextBoxPallett.Visible = True
            TextBoxProduzionePezzi.Visible = True
            TextBoxPoliRifatti.Visible = True
            LabelScartoTurno.Visible = True
            LabelFuoriCella.Visible = True
            LabelPoloPiantato.Visible = True
            LabelPoloFuso.Visible = True
            LabelAltro.Visible = True
            TextBoxScartoFuoriCella.Visible = True
            TextBoxScartoPoloPiantato.Visible = True
            TextBoxScartoPoloFuso.Visible = True
            TextBoxScartoAltro.Visible = True
            LabelControlloDistruttivo.Visible = True
            TextBoxControlloDistruttivo.Visible = True
            LabelNote.Visible = True
            RichTextBoxNote.Visible = True

            ComboBoxLancio.Visible = False

            ButtonConfermaLancio.Enabled = False
            ButtonCancella.Enabled = False
            ButtonChiudiLancio.Enabled = True

        End If

    End Sub

    Function DataFormatting(Datadaconvertire As DateTime)
        Dim dataconvertita As String
        dataconvertita = Datadaconvertire.Year().ToString() & "-" & Datadaconvertire.Day().ToString() & "-" & Datadaconvertire.Month().ToString() & " " & Datadaconvertire.Hour().ToString() & ":" & Datadaconvertire.Minute().ToString() & ":" & Datadaconvertire.Second().ToString()

        Return dataconvertita
    End Function

    Private Sub ButtonChiudiLancio_Click(sender As Object, e As EventArgs) Handles ButtonChiudiLancio.Click

        If TextBoxProduzionePezzi.Text = "" Then
            MsgBox("Inserire il numero di pezzi prodotti")
            Exit Sub
        Else
        End If

        If TextBoxPallett.Text = "" Then
            MsgBox("Inserire il numero di pallett prodotti")
            Exit Sub
        Else
        End If

        Dim myConn As New SqlConnection(Form1.LblPathDatabase.Text)

        'Ricavo data di inizio e la durata della produzione 

        Dim myCmd As SqlCommand
        myCmd = myConn.CreateCommand()
        myCmd.CommandText = "SELECT DataInizio FROM Produzione WHERE (IdReparto=" & Form1.LblIdDepartment.Text & " AND IdLinea=" & Form1.LblIdLinea.Text & " AND DataFine IS NULL)"
        myCmd.Connection.Open()
        Dim DataInizio As Date
        DataInizio = myCmd.ExecuteScalar()
        myCmd.Connection.Close()

        Dim DataFine As Date
        DataFine = DateTime.Now

        Dim Duration As TimeSpan = DateTime.Now().Subtract(DataInizio)
        Dim TotalMinutesDuration As String = CInt(Duration.TotalMinutes()).ToString()

        'Calcolo fermi

        Dim myCmd2 As SqlCommand
        myCmd2 = myConn.CreateCommand()
        myCmd2.CommandText = ("SELECT Sum(Durata) FROM Fermi WHERE ((IdReparto='" & Form1.LblIdDepartment.Text & "') AND (IdLinea='" & Form1.LblIdLinea.Text & "')AND(DATA >= '" & DataFormatting(DataInizio) & "')AND(DATA <= '" & DataFormatting(DataFine) & "'))")
        Dim Durata As String
        myCmd2.Connection.Open()


        If IsDBNull(myCmd2.ExecuteScalar()) Then
            'close the connection and put stop duration as 0
            Durata = "0"
            myCmd.Connection.Close()
        Else
            Durata = myCmd2.ExecuteScalar().ToString
            myCmd2.Connection.Close()
        End If

        If TextBoxPoliRifatti.Text = "" Then
            TextBoxPoliRifatti.Text = "0"
        Else
        End If

        If TextBoxScartoFuoriCella.Text = "" Then
            TextBoxScartoFuoriCella.Text = "0"
        Else
        End If

        If TextBoxScartoPoloPiantato.Text = "" Then
            TextBoxScartoPoloPiantato.Text = "0"
        Else
        End If

        If TextBoxScartoPoloFuso.Text = "" Then
            TextBoxScartoPoloFuso.Text = "0"
        Else
        End If

        If TextBoxScartoAltro.Text = "" Then
            TextBoxScartoAltro.Text = "0"
        Else
        End If

        If TextBoxControlloDistruttivo.Text = "" Then
            TextBoxControlloDistruttivo.Text = "0"
        Else
        End If

        Dim myCmd3 As SqlCommand
        myCmd3 = myConn.CreateCommand()
        'myCmd3.CommandText = "UPDATE Produzione SET DataFine='" & DataFormatting(DateTime.Now) & "', Pallett='" & TextBoxPallett.Text & "', Produzione = '" & (CInt(TextBoxProduzionePezzi.Text) + CInt(TextBoxPoliRifatti.Text)).ToString & "', Scarto='" & (CInt(TextBoxScartoFuoriCella.Text) + CInt(TextBoxScartoPoloPiantato.Text) + CInt(TextBoxScartoPoloFuso.Text) + CInt(TextBoxScartoAltro.Text)).ToString & "', Minuti='" & (CInt(TotalMinutesDuration) - CInt(Durata)).ToString & "' WHERE (IdReparto='" & Form1.LblIdDepartment.Text & "' AND IdLinea='" & Form1.LblIdLinea.Text & "' AND DataFine IS NULL)"
        myCmd3.CommandText = "UPDATE Produzione SET DataFine='" & DataFormatting(DateTime.Now) & "', Pallett='" & TextBoxPallett.Text & "', Produzione = '" & TextBoxProduzionePezzi.Text & "',[Poli Rifatti]='" & TextBoxPoliRifatti.Text & "', Scarto='" & (CInt(TextBoxScartoFuoriCella.Text) + CInt(TextBoxScartoPoloPiantato.Text) + CInt(TextBoxScartoPoloFuso.Text) + CInt(TextBoxScartoAltro.Text)).ToString & "', Minuti = '" & (CInt(TotalMinutesDuration) - CInt(Durata)).ToString & "'  WHERE (IdReparto='" & Form1.LblIdDepartment.Text & "' AND IdLinea='" & Form1.LblIdLinea.Text & "' AND DataFine IS NULL)"
        myCmd3.Connection.Open()
        myCmd3.ExecuteNonQuery()
        myCmd3.Connection.Close()

        Dim myCmd4 As SqlCommand
        myCmd4 = myConn.CreateCommand()
        myCmd4.CommandText = "UPDATE LanciProduzione SET QuantitàMancante = '" & (CInt(LabelQuantitàMancante.Text) - CInt(TextBoxProduzionePezzi.Text) - CInt(TextBoxPoliRifatti.Text)).ToString & "' WHERE (Ordpian='" & TextBoxLancioProduzione.Text & "')"
        myCmd4.Connection.Open()
        myCmd4.ExecuteNonQuery()
        myCmd4.Connection.Close()

        If (CInt(LabelQuantitàMancante.Text) - CInt(TextBoxProduzionePezzi.Text)) <= 0 Then
            Dim myCmd5 As SqlCommand
            myCmd5 = myConn.CreateCommand()
            myCmd5.CommandText = "UPDATE LanciProduzione SET StatoLancio = 'Chiuso' WHERE (Ordpian='" & TextBoxLancioProduzione.Text & "')"
            myCmd5.Connection.Open()
            myCmd5.ExecuteNonQuery()
            myCmd5.Connection.Close()
        Else
            Dim myCmd6 As SqlCommand
            myCmd6 = myConn.CreateCommand()
            myCmd6.CommandText = "UPDATE LanciProduzione SET StatoLancio = 'Sospeso' WHERE (Ordpian='" & TextBoxLancioProduzione.Text & "')"
            myCmd6.Connection.Open()
            myCmd6.ExecuteNonQuery()
            myCmd6.Connection.Close()

        End If

        Dim myCmd7 As SqlCommand
        myCmd7 = myConn.CreateCommand()
        myCmd7.CommandText = "UPDATE StatoLinee SET LancioInCorso ='0' WHERE (Id_reparto ='" & Form1.LblIdDepartment.Text & "' AND Id_linea='" & Form1.LblIdLinea.Text & "')"
        myCmd7.Connection.Open()
        myCmd7.ExecuteNonQuery()
        myCmd7.Connection.Close()

        Dim myCmd8 As SqlCommand
        myCmd8 = myConn.CreateCommand()
        myCmd8.CommandText = "INSERT INTO ScartoMontaggio (Turno,IdReparto,Reparto,IdLinea,Linea,Codice,[Fuori Cella],[Polo Piantato],[Polo Fuso],Altro,[Scarto Totale],[Controllo Distruttivo]) VALUES ('" & ComboBoxTurno.Text & "','" & Form1.LblIdDepartment.Text & "','" & Form1.LblDepartmentDescription.Text & "','" & Form1.LblIdLinea.Text & "','" & Form1.LblLineDescription.Text & "','" & LabelCodice.Text & "','" & TextBoxScartoFuoriCella.Text & "','" & TextBoxScartoPoloPiantato.Text & "','" & TextBoxScartoPoloFuso.Text & "','" & TextBoxScartoAltro.Text & "','" & (CInt(TextBoxScartoFuoriCella.Text) + CInt(TextBoxScartoPoloPiantato.Text) + CInt(TextBoxScartoPoloFuso.Text) + CInt(TextBoxScartoAltro.Text)).ToString & "','" & TextBoxControlloDistruttivo.Text & "')"
        myCmd8.Connection.Open()
        myCmd8.ExecuteNonQuery()
        myCmd8.Connection.Close()

        TextBoxPallett.Text = ""
        TextBoxProduzionePezzi.Text = ""
        TextBoxPoliRifatti.Text = ""
        TextBoxScartoFuoriCella.Text = ""
        TextBoxScartoPoloPiantato.Text = ""
        TextBoxScartoPoloFuso.Text = ""
        TextBoxScartoAltro.Text = ""
        TextBoxControlloDistruttivo.Text = ""

        ComboBoxLancio.Text = ""
        TextBoxLancioProduzione.Text = ""
        ComboBoxTurno.Text = ""

        LabelLancio.Visible = False
        ComboBoxLancio.Visible = True

        Dim myCmd9 As SqlCommand
        myCmd9 = myConn.CreateCommand()
        myCmd9.CommandText = "SELECT [Codice Linea] FROM Linee WHERE (IdReparto='" & Form1.LblIdDepartment.Text & "') AND (IdLinea='" & Form1.LblIdLinea.Text & "')"
        myCmd9.Connection.Open()
        Dim CodiceLinea As String
        CodiceLinea = myCmd9.ExecuteScalar()
        myCmd9.Connection.Close()

        Dim myCmd10 As SqlCommand
        myCmd10 = myConn.CreateCommand()
        myCmd10.CommandText = "SELECT * FROM LanciProduzione WHERE (Linea='" & CodiceLinea & "') AND ((StatoLancio='Sospeso') OR (StatoLancio IS NULL))"
        myCmd10.Connection.Open()
        Dim ds As New DataSet
        Dim adapter As New SqlDataAdapter(myCmd10.CommandText, myConn)
        adapter.Fill(ds)
        myCmd10.Connection.Close()

        ComboBoxLancio.DataSource = ds.Tables(0)
        ComboBoxLancio.ValueMember = "Ordpian"
        ComboBoxLancio.DisplayMember = "Ordpian"

        'tutti i campi vanno riazzerati perchè quando carica i dati nel menù a tendina inserisce già il primo

        ComboBoxLancio.Text = ""
        TextBoxLancioProduzione.Text = ""
        LabelCodice.Text = ""
        LabelQuantitàLancio.Text = ""
        LabelQuantitàMancante.Text = ""

        LabelProduzioneTurno.Visible = False
        LabelPallett.Visible = False
        LabelPezzi.Visible = False
        LabelPoliRifatti.Visible = False
        TextBoxPallett.Visible = False
        TextBoxProduzionePezzi.Visible = False
        TextBoxPoliRifatti.Visible = False
        LabelScartoTurno.Visible = False
        LabelFuoriCella.Visible = False
        LabelPoloPiantato.Visible = False
        LabelPoloFuso.Visible = False
        LabelAltro.Visible = False
        TextBoxScartoFuoriCella.Visible = False
        TextBoxScartoPoloPiantato.Visible = False
        TextBoxScartoPoloFuso.Visible = False
        TextBoxScartoAltro.Visible = False
        LabelControlloDistruttivo.Visible = False
        TextBoxControlloDistruttivo.Visible = False
        LabelNote.Visible = False
        RichTextBoxNote.Visible = False

        ButtonChiudiLancio.Enabled = False
        ButtonConfermaLancio.Enabled = True
        ButtonCancella.Enabled = True

    End Sub

    Private Sub ButtonSalvaTurno_Click(sender As Object, e As EventArgs) Handles ButtonSalvaTurno.Click

        Dim msg = MsgBox("Chiudere il lancio di produzione in corso?", MsgBoxStyle.YesNo)

        If msg = MsgBoxResult.Yes Then
            ButtonChiudiLancio.PerformClick()
            ComboBoxLancio.Text = ""
        Else

            Dim myConn As New SqlConnection(Form1.LblPathDatabase.Text)

            'Ricavo data di inizio e la durata della produzione

            Dim myCmd As SqlCommand
            myCmd = myConn.CreateCommand()
            myCmd.CommandText = "SELECT DataInizio FROM Produzione WHERE (IdReparto=" & Form1.LblIdDepartment.Text & " AND IdLinea=" & Form1.LblIdLinea.Text & " AND DataFine IS NULL)"
            myCmd.Connection.Open()
            Dim DataInizio As Date
            DataInizio = myCmd.ExecuteScalar()
            myCmd.Connection.Close()

            Dim DataFine As Date
            DataFine = DateTime.Now

            Dim Duration As TimeSpan = DateTime.Now().Subtract(DataInizio)
            Dim TotalMinutesDuration As String = CInt(Duration.TotalMinutes()).ToString()

            'Calcolo fermi

            Dim myCmd2 As SqlCommand
            myCmd2 = myConn.CreateCommand()
            myCmd2.CommandText = ("SELECT Sum(Durata) FROM Fermi WHERE ((IdReparto='" & Form1.LblIdDepartment.Text & "') AND (IdLinea='" & Form1.LblIdLinea.Text & "')AND(DATA >= '" & DataFormatting(DataInizio) & "')AND(DATA <= '" & DataFormatting(DataFine) & "'))")
            Dim Durata As String
            myCmd2.Connection.Open()

            If IsDBNull(myCmd2.ExecuteScalar()) Then

                'close the connection and put stop duration as 0
                Durata = "0"
                myCmd.Connection.Close()

            Else
                Durata = myCmd2.ExecuteScalar().ToString
                myCmd2.Connection.Close()

            End If

            If TextBoxPoliRifatti.Text = "" Then
                TextBoxPoliRifatti.Text = "0"
            Else
            End If

            If TextBoxScartoFuoriCella.Text = "" Then
                TextBoxScartoFuoriCella.Text = "0"
            Else
            End If

            If TextBoxScartoPoloPiantato.Text = "" Then
                TextBoxScartoPoloPiantato.Text = "0"
            Else
            End If

            If TextBoxScartoPoloFuso.Text = "" Then
                TextBoxScartoPoloFuso.Text = "0"
            Else
            End If

            If TextBoxScartoAltro.Text = "" Then
                TextBoxScartoAltro.Text = "0"
            Else
            End If

            If TextBoxControlloDistruttivo.Text = "" Then
                TextBoxControlloDistruttivo.Text = "0"
            Else
            End If

            Dim myCmd3 As SqlCommand
            myCmd3 = myConn.CreateCommand()
            myCmd3.CommandText = "UPDATE Produzione SET DataFine='" & DataFormatting(DateTime.Now) & "', Pallett='" & TextBoxPallett.Text & "', Produzione = '" & (CInt(TextBoxProduzionePezzi.Text) + CInt(TextBoxPoliRifatti.Text)).ToString & "', [Poli Rifatti]='" & TextBoxPoliRifatti.Text & "', Scarto='" & (CInt(TextBoxScartoFuoriCella.Text) + CInt(TextBoxScartoPoloPiantato.Text) + CInt(TextBoxScartoPoloFuso.Text) + CInt(TextBoxScartoAltro.Text)).ToString & "', Minuti = '" & (CInt(TotalMinutesDuration) - CInt(Durata)).ToString & "' WHERE (IdReparto='" & Form1.LblIdDepartment.Text & "' AND IdLinea='" & Form1.LblIdLinea.Text & "' AND DataFine IS NULL)"
            myCmd3.Connection.Open()
            myCmd3.ExecuteNonQuery()
            myCmd3.Connection.Close()

            LabelQuantitàMancante.Text = (CInt(LabelQuantitàMancante.Text) - CInt(TextBoxProduzionePezzi.Text)).ToString

            Dim myCmd4 As SqlCommand
            myCmd4 = myConn.CreateCommand()
            myCmd4.CommandText = "UPDATE LanciProduzione SET QuantitàMancante = '" & LabelQuantitàMancante.Text & "' WHERE (Ordpian='" & TextBoxLancioProduzione.Text & "')"
            myCmd4.Connection.Open()
            myCmd4.ExecuteNonQuery()
            myCmd4.Connection.Close()

            'Azzero tutti i campi per i dati di produzione e aggiorno il campo della quantità mancante

            TextBoxPallett.Text = ""
            TextBoxProduzionePezzi.Text = ""
            TextBoxPoliRifatti.Text = ""
            TextBoxScartoFuoriCella.Text = ""
            TextBoxScartoPoloPiantato.Text = ""
            TextBoxScartoPoloFuso.Text = ""
            TextBoxScartoAltro.Text = ""
            TextBoxControlloDistruttivo.Text = ""

            Dim DataInizioNuovoTurno As String

            If ComboBoxTurno.Text = "1" Then
                DataInizioNuovoTurno = DateTime.Now.Year.ToString & "-" & DateTime.Now.Month.ToString & "-" & DateTime.Now.Day.ToString & " 14:00:00"
            Else
            End If

            If ComboBoxTurno.Text = "2" Then
                DataInizioNuovoTurno = DateTime.Now.Year.ToString & "-" & DateTime.Now.Month.ToString & "-" & DateTime.Now.Day.ToString & " 22:00:00"
            Else
            End If

            If ComboBoxTurno.Text = "3" Then
                DataInizioNuovoTurno = DateTime.Now.Year.ToString & "-" & DateTime.Now.Month.ToString & "-" & DateTime.Now.Day.ToString & " 06:00:00"
            Else
            End If

            If ComboBoxTurno.Text = "3" Then
                ComboBoxTurno.Text = "1"
            Else
                ComboBoxTurno.Text = ComboBoxTurno.Text + 1
            End If

            Dim myCmd5 As SqlCommand
            myCmd5 = myConn.CreateCommand()
            myCmd.CommandText = "INSERT INTO Produzione (DataInizio,Turno,IdReparto,Reparto,IdLinea,Linea,Lancio,Codice) VALUES ('" & DataFormatting(DataInizioNuovoTurno) & "','" & ComboBoxTurno.Text & "','" & Form1.LblIdDepartment.Text & "','" & Form1.LblDepartmentDescription.Text & "','" & Form1.LblIdLinea.Text & "','" & Form1.LblLineDescription.Text & "','" & TextBoxLancioProduzione.Text & "','" & LabelCodice.Text & "')"
            myCmd.Connection.Open()
            myCmd.ExecuteNonQuery()
            myCmd.Connection.Close()

        End If

    End Sub


End Class