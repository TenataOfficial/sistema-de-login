Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class Form2

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Finalize()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.TextAlign >= 5 Then
            MsgBox("A senha deve ter no maximo 4 digitos")
            TextBox2.Text = ""
            TextBox3.Text = ""
        ElseIf TextBox3.Text <> TextBox2.Text Then
            MsgBox("As senhas não se coensidem")
        ElseIf TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Algum campo está vazio")
        ElseIf IO.File.Exists("C:\temp\TempG\profile\" & TextBox1.Text & "\" & TextBox1.Text & ".txt") Then
            MsgBox("Este usuario já existe")
        Else
            My.Computer.FileSystem.CreateDirectory("c:\temp\TempG\profile\" & TextBox1.Text)
            Dim path As String = "c:\temp\TempG\profile\" & TextBox1.Text & "\" & TextBox1.Text & ".txt"
            Dim fs As FileStream = File.Create(path)
            Dim info As Byte() = New UTF8Encoding(True).GetBytes(TextBox2.Text)
            fs.Write(info, 0, info.Length)
            fs.Close()
            Dim path2 As String = "c:\temp\TempG\profile\" & TextBox1.Text & "\" & "continue.txt"
            Dim tx As FileStream = File.Create(path2)
            Dim info2 As Byte() = New UTF8Encoding(True).GetBytes("")
            tx.Write(info2, 0, info2.Length)
            tx.Close()
            Form1.Show()
            Finalize()
        End If
    End Sub

   
End Class

