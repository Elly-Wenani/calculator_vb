'This Is a visual basic calculator done by Elly Wenani that does the area and
'perameter of a rectangle, triangle, trapezium And circle.


Imports System.Console
Imports System.Math

Public Class Form1


    Dim area As Double
    Dim length As Double
    Dim parameter As Double
    Dim hight As Double
    Dim base As Double
    Dim radius As Double
    Dim lengthA As Double
    Dim lengthB As Double
    Dim diagonal As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        length = TextBox1.Text
        hight = TextBox2.Text

        parameter = 2 * (length + hight)
        area = length * hight

        Button3.Text = area
        Button4.Text = parameter
    End Sub

    'This button is used to clear the contents on the text boses and answer buttons
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        Button3.Text = ""
        Button4.Text = ""
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        base = TextBox3.Text
        hight = TextBox4.Text

        diagonal = (base ^ 2) + (hight ^ 2)

        area = 1 / 2 * (base * hight)
        parameter = base + hight + Sqrt(diagonal)

        Button5.Text = area
        Button6.Text = parameter
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox3.Clear()
        TextBox4.Clear()
        Button3.Text = ""
        Button4.Text = ""
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        radius = TextBox7.Text
        area = 3.142 * radius ^ 2
        parameter = 2 * (3.142 * radius)
        Button13.Text = area
        Button14.Text = parameter

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        hight = TextBox6.Text
        lengthA = TextBox8.Text
        lengthB = TextBox9.Text

        diagonal = ((lengthB - lengthA) ^ 2 + (hight ^ 2))

        area = 1 / 2 * (lengthA + lengthB) * hight
        parameter = lengthA + lengthB + hight + Sqrt(diagonal)

        Button9.Text = area
        Button10.Text = parameter
    End Sub
End Class
