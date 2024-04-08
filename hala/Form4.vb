Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim random As New Random()
        Dim maxX As Integer = Me.ClientSize.Width - Button1.Width
        Dim maxY As Integer = Me.ClientSize.Height - Button1.Height

        Button1.Location = New Point(random.Next(0, maxX), random.Next(0, maxY))







    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim bt1 As New Random

        Button1.Location = New Point

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class