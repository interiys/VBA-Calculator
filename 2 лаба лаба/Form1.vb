Public Class Form1
    Private IsText As String
    Private IsNumber As Double
    Private Point As Boolean
    Private op As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bt1_Click(sender As Object, e As EventArgs) Handles bt1.Click
        If IsText = "0" Or IsText = "+" Or IsText = "-" Or IsText = "/" Or IsText = "*" Then IsText = "1" Else IsText = IsText + "1"
        TextBoxIs.Text = IsText
    End Sub

    Private Sub bt2_Click(sender As Object, e As EventArgs) Handles bt2.Click
        If IsText = "0" Or IsText = "+" Or IsText = "-" Or IsText = "/" Or IsText = "*" Then IsText = "2" Else IsText = IsText + "2"
        TextBoxIs.Text = IsText
    End Sub

    Private Sub btpm_Click(sender As Object, e As EventArgs) Handles btpm.Click
        IsText = CStr(Val(IsText) * (-1))
        TextBoxIs.Text = IsText
    End Sub

    Private Sub btpoint_Click(sender As Object, e As EventArgs) Handles btpoint.Click
        If Point = False Then
            IsText = IsText + "."
            TextBoxIs.Text = IsText
            Point = True
        End If
    End Sub

    Private Sub btdel_Click(sender As Object, e As EventArgs) Handles btdel.Click
        IsNumber = Val(TextBoxIs.Text)
        op = 1
        IsText = "/"
        TextBoxIs.Text = IsText
        Point = False
    End Sub

    Private Sub btpr_Click(sender As Object, e As EventArgs) Handles btpr.Click
        IsNumber = Val(TextBoxIs.Text)
        op = 2
        IsText = "*"
        TextBoxIs.Text = IsText
        Point = False
    End Sub

    Private Sub btce_Click(sender As Object, e As EventArgs) Handles btce.Click
        IsNumber = 0
        IsText = "0"
        TextBoxIs.Text = IsText
        Point = False
    End Sub

    Private Sub bt3_Click(sender As Object, e As EventArgs) Handles bt3.Click
        If IsText = "0" Or IsText = "+" Or IsText = "-" Or IsText = "/" Or IsText = "*" Then IsText = "3" Else IsText = IsText + "3"
        TextBoxIs.Text = IsText
    End Sub

    Private Sub bt4_Click(sender As Object, e As EventArgs) Handles bt4.Click
        If IsText = "0" Or IsText = "+" Or IsText = "-" Or IsText = "/" Or IsText = "*" Then IsText = "4" Else IsText = IsText + "4"
        TextBoxIs.Text = IsText
    End Sub

    Private Sub bt5_Click(sender As Object, e As EventArgs) Handles bt5.Click
        If IsText = "0" Or IsText = "+" Or IsText = "-" Or IsText = "/" Or IsText = "*" Then IsText = "5" Else IsText = IsText + "5"
        TextBoxIs.Text = IsText
    End Sub

    Private Sub bt6_Click(sender As Object, e As EventArgs) Handles bt6.Click
        If IsText = "0" Or IsText = "+" Or IsText = "-" Or IsText = "/" Or IsText = "*" Then IsText = "6" Else IsText = IsText + "6"
        TextBoxIs.Text = IsText
    End Sub

    Private Sub bt7_Click(sender As Object, e As EventArgs) Handles bt7.Click
        If IsText = "0" Or IsText = "+" Or IsText = "-" Or IsText = "/" Or IsText = "*" Then IsText = "7" Else IsText = IsText + "7"
        TextBoxIs.Text = IsText
    End Sub

    Private Sub bt8_Click(sender As Object, e As EventArgs) Handles bt8.Click
        If IsText = "0" Or IsText = "+" Or IsText = "-" Or IsText = "/" Or IsText = "*" Then IsText = "8" Else IsText = IsText + "8"
        TextBoxIs.Text = IsText
    End Sub

    Private Sub bt9_Click(sender As Object, e As EventArgs) Handles bt9.Click
        If IsText = "0" Or IsText = "+" Or IsText = "-" Or IsText = "/" Or IsText = "*" Then IsText = "9" Else IsText = IsText + "9"
        TextBoxIs.Text = IsText
    End Sub

    Private Sub btmin_Click(sender As Object, e As EventArgs) Handles btmin.Click
        IsNumber = Val(TextBoxIs.Text)
        op = 3
        IsText = "-"
        TextBoxIs.Text = IsText
        Point = False
    End Sub

    Private Sub btplus_Click(sender As Object, e As EventArgs) Handles btplus.Click
        IsNumber = Val(TextBoxIs.Text)
        op = 4
        IsText = "+"
        TextBoxIs.Text = IsText
        Point = False
    End Sub

    Private Sub bt0_Click(sender As Object, e As EventArgs) Handles bt0.Click
        If IsText = "0" Or IsText = "+" Or IsText = "-" Or IsText = "/" Or IsText = "*" Then IsText = "0" Else IsText = IsText + "0"
        TextBoxIs.Text = IsText
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        IsText = IsText.Remove(IsText.Length - 1, 1)
        TextBoxIs.Text = IsText
    End Sub

    Private Sub btis_Click(sender As Object, e As EventArgs) Handles btis.Click
        Select Case op
            Case 1
                IsNumber = IsNumber / Val(TextBoxIs.Text)
            Case 2
                IsNumber = IsNumber * Val(TextBoxIs.Text)
            Case 3
                IsNumber = IsNumber - Val(TextBoxIs.Text)
            Case 4
                IsNumber = IsNumber + Val(TextBoxIs.Text)
        End Select
        IsText = CStr(IsNumber)
        TextBoxIs.Text = IsText
        IsText = ""
        Point = False
    End Sub

    Private Sub sqrt_Click(sender As Object, e As EventArgs) Handles sqrt.Click
        IsNumber = Math.Sqrt(TextBoxIs.Text)
        TextBoxIs.Text = IsNumber
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        IsNumber = 1 / Val(TextBoxIs.Text)
        TextBoxIs.Text = IsNumber
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        IsNumber = Val(TextBoxIs.Text) / 100
        TextBoxIs.Text = IsNumber
    End Sub
End Class
