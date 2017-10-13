Public Class VisualizzaFermate

    Private Sub VisualizzaFermate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'VRNFermiDataSet.Fermi'. È possibile spostarla o rimuoverla se necessario.
        Me.FermiTableAdapter.Fill(Me.VRNFermiDataSet.Fermi)

    End Sub
End Class