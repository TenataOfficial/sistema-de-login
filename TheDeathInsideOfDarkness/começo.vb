Public Class começo
    Dim io As IO.StreamReader
    Dim aqui As String
    Private Sub começo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim io = New IO.StreamReader("c:\temp\tempg\continue.txt")
        aqui = io.ReadLine
        io.Close()
        Label1.Text = "OIá  " & aqui & ", como é bom te ter aqui, vamos começar?"
        Exit Sub

    End Sub
End Class