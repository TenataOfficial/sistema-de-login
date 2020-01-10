
Imports System.IO
Imports System.Text
Public Class Form1
    Dim fluxoTexto As IO.StreamReader
    Dim linhaTexto As String
    Dim linhaditext As String
    Dim fs1 As IO.StreamWriter
    Dim cont As IO.StreamWriter
    Dim context As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.TextLength > 4 Then
            TextBox2.Text = ""
            MsgBox("Senha deve ter no maximo 4 digitos")
            Exit Sub
        ElseIf TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("O Campo está vazio")
        Else

            If IO.File.Exists("C:\temp\TempG\profile\" & TextBox1.Text & "\" & TextBox1.Text & ".txt") Then
                fluxoTexto = New IO.StreamReader("C:\temp\TempG\profile\" & TextBox1.Text & "\" & TextBox1.Text & ".txt")
                linhaTexto = fluxoTexto.ReadLine
                While linhaTexto = TextBox2.Text
                    fluxoTexto.Close()
                    MsgBox("Você esta logado", MsgBoxStyle.OkOnly)
                    Dim path As String = "c:\temp\TempG\continue.txt"
                    Dim context As FileStream = File.Create(path)
                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(TextBox1.Text)
                    context.Write(info, 0, info.Length)
                    context.Close()
                    contdh.Show()
                    Finalize()
                    Exit Sub
                End While

                fluxoTexto.Close()
                While linhaTexto <> TextBox2.Text
                    MsgBox("As senhas não se são iguais", MsgBoxStyle.OkOnly)
                    fluxoTexto.Close()
                    Exit Sub
                End While
            Else
                MessageBox.Show("Arquivo não existe")


            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
