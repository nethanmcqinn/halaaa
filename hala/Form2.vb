Public Class Form2
    Const life = 5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ans1 As Char
        Dim ans2 As Char
        Dim ans3 As Char
        Dim ans4 As Char
        Dim ans5 As Char
        Dim ans6 As Char
        Dim ans7 As Char
        Dim ans8 As Char
        ans1 = "h"
        ans2 = "a"
        ans3 = "l"
        ans4 = "a"
        ans5 = "a"
        ans6 = "a"
        ans7 = "a"
        ans8 = "a"


        If TextBox1.Text = ans1 And TextBox2.Text = ans2 And TextBox3.Text = ans3 And TextBox4.Text = ans4 And TextBox5.Text = ans5 And TextBox6.Text = ans6 And TextBox7.Text = ans7 And TextBox8.Text = ans8 Then
            MsgBox("hello")

        Else
            MsgBox("hala mali")
            Label1.Text = life - 1

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Visible = False
        Form1.Visible = True
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class