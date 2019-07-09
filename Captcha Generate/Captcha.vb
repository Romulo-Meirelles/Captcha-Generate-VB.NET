Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports System.Windows.Forms
'******************************************************************************
' Desenvolvido por Romulo Meirelles da Silva
' Contato: romulomeirelles@hotmail.com
'******************************************************************************

''' <summary>MÉTODO PARA RESOLUÇÃO DE CAPTCHA.</summary>
''' <remarks>CRIADO POR RÔMULO MEIRELLES.</remarks>
#Region "CAPTCHA"
Namespace CAPTCHA
    Public Class GENERATE
        'FUNÇÃO QUE EXECUTA O GERAMENTO DO CAPTCHA PARA VISUAL BASIC
        Public Function GENERATE_IMAGE(ByRef PictuteBox As PictureBox, ByVal Width As Integer, ByVal Height As Integer, ByVal FontSize As Integer, ByVal HowCaracters As Integer) As String

            Dim Numeric As String = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
            Dim CaptchaString As String = ""
            Dim Rand As New Random
            For i As Integer = 0 To HowCaracters
                CaptchaString = CaptchaString + Numeric(Rand.Next(0, 62))
            Next

            Dim Bitma As New Bitmap(Width, Height, Imaging.PixelFormat.Format32bppArgb)
            Dim Graphi As Graphics = Graphics.FromImage(Bitma)
            Dim hb As New HatchBrush(HatchStyle.Weave, Color.FromArgb(0, 128, 255), Color.Black)
            Graphi.FillRectangle(hb, New Rectangle(0, 0, Width, Height))
            Graphi.DrawString(CaptchaString, New Font("", FontSize, FontStyle.Strikeout, GraphicsUnit.Point), Brushes.White, 25, 25)
            PictuteBox.SizeMode = PictureBoxSizeMode.StretchImage
            PictuteBox.BackgroundImageLayout = ImageLayout.Center
            PictuteBox.Image = Bitma

            Return CaptchaString
        End Function

    End Class
End Namespace
#End Region

