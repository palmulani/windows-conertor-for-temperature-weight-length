'pal mulani's convertor en  no 18
Public Class Form1



    Dim CELCIUS, FARENHEIT, KELVIN As Double
    Dim KILOGRAM, LITER, MILILITER, GRAM, CENTIMETER As Double
    Dim KILOMETER, METER, INCHES, FEET As Double

    Dim IOPERATION As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        IOPERATION = "KM"

    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        IOPERATION = "MF"
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        IOPERATION = "K"
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        IOPERATION = "CM"

    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        IOPERATION = "FI"

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        IOPERATION = "ML"
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        IOPERATION = "CF"

    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        IOPERATION = "FC"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        IOPERATION = "KG"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        IOPERATION = "GK"

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        IOPERATION = "LM"

    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        IOPERATION = "MK
"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case (IOPERATION)
            Case "KM"
                'Kilometer to Meter'
                KILOMETER = Double.Parse(TxtConvert.Text)
                IbICONVERT.Text = ((1000 * KILOMETER).ToString())

            Case "MK"
                'Meter to Kilometer '
                METER = Double.Parse(TxtConvert.Text)
                IbICONVERT.Text = ((METER / 1000).ToString())
            Case "MF"
                'Meter to Feet'
                INCHES = Double.Parse(TxtConvert.Text)
                IbICONVERT.Text = ((3 * INCHES).ToString())

            Case "FI"
                'Feet to Inches'
                FEET = Double.Parse(TxtConvert.Text)
                IbICONVERT.Text = ((FEET * 12).ToString())
            Case "KG"
                'Kilogram to Gram'
                KILOGRAM = Double.Parse(TxtConvert.Text)
                IbICONVERT.Text = ((1000 * KILOGRAM).ToString())

            Case "GK"
                'Gram to Kilogram'
                GRAM = Double.Parse(TxtConvert.Text)
                IbICONVERT.Text = ((GRAM / 1000).ToString())
            Case "LM"
                'Liter to Mililiter'
                LITER = Double.Parse(TxtConvert.Text)
                IbICONVERT.Text = ((1000 * LITER).ToString())
            Case "ML"
                'Mililiter to Liter'
                MILILITER = Double.Parse(TxtConvert.Text)
                IbICONVERT.Text = ((MILILITER / 1000).ToString())
            Case "CM"
                'Centimeter to Meter'
                CENTIMETER = Double.Parse(TxtConvert.Text)
                IbICONVERT.Text = ((CENTIMETER / 100).ToString())

            Case "CF"
                'Celsius to Fahrenheit'
                CELCIUS = Double.Parse(TxtConvert.Text)
                IbICONVERT.Text = ((((9 * CELCIUS) / 5) + 32).ToString())
            Case "FC"
                'Fahrenheit to Celsius'
                FARENHEIT = Double.Parse(TxtConvert.Text)
                IbICONVERT.Text = ((((FARENHEIT - 32) * 5) / 9).ToString())
            Case "K"
                'Convert to Kelvin
                KELVIN = Double.Parse(TxtConvert.Text)
                IbICONVERT.Text = (((((9 * KELVIN) / 5) + 32) + 273.15).ToString())
        End Select

    End Sub
End Class
