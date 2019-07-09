# Captcha-Generate-VB.NET
Captcha Generate VB.NET

This app is an idea I had to make to authenticate a user to know if it was a robot or not. This project is free for modifications, ideas and distributions. Make good use!
<br><br>

### Prerequisites
What things you need to install the software and how to install them
```
.NET FRAMEWORK 4.0
```
<br><br>
<img src="/Images/Captcha.gif" Width="900" Height="700">
<br>
### Exemples
```
'IMPORT THE CAPTCHA DLL FIRST
Imports System.CAPTCHA
Public Class Form1

    'DECLARE CAP AS GENERATE
    Private CAP As GENERATE

    'RESULT WILL OBTAIN THE RESULT
    Private RESULT As String = Nothing

    Private Sub Call_Captcha()
        'HERE YOU DECLARE A NEW AND POE THE SOURCE, SIZE AND HOW MANY CHARACTERS YOU WANT
        CAP = New GENERATE
        RESULT = CAP.GENERATE_IMAGE(PictureBox1, Width:=140, Height:=80, FontSize:=15, HowCaracters:=6)
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'CALL OUR RELOAD CAPTCHA
        Call Call_Captcha()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'HERE YOU MAKE THE VALIDATION OF THE CAPTCHA
        If TextBox1.Text = RESULT Then
            MsgBox("VALIDATE")
            'RELOAD CAPTCHA
            Call Call_Captcha()

        Else
            MsgBox("WRONG CAPTCHA")
            'RELOAD CAPTCHA
            Call Call_Captcha()
        End If
    End Sub
End Class
```
<br>
<img src="/Images/Captcha_01.png" Width="900" Height="700">
