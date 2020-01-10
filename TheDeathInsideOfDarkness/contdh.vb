Imports System
Imports System.IO
Public Class contdh
    Dim fluxoTexto, lok As IO.StreamReader
    Dim linhaTexto As String
    Dim fp As String

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    
        If IO.File.Exists("C:\temp\TempG\continue.txt") Then
            fluxoTexto = New IO.StreamReader("C:\temp\TempG\continue.txt")
            linhaTexto = fluxoTexto.ReadLine
            IO.File.Exists("c:\temp\TempG\profile\" & linhaTexto & "\continue.txt")
            lok = New IO.StreamReader("c:\temp\TempG\profile\" & linhaTexto & "\continue.txt")
            fp = lok.ReadLine
            fluxoTexto.Close()
            lok.Close()
            If fp = "morte" Then
                MsgBox("funcionou")
                Exit Sub
            ElseIf fp = "" Then
                MsgBox("Você ainda não tem arquivos salvos")
                começo.Show()
                Finalize()

                Exit Sub
            End If


        End If

    End Sub

    Private Sub contdh_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class