Public Class Form1

    Dim Celsius, Fahrenheit, Kelvin As Double
    Dim Kilo, Liter, Mililiter, Gram As Double
    Dim Meter, Kilometer, Feet, Inches, Centimeter As Double
    Dim ioperation As String

    Private Sub RbtnCtoF_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnCtoF.CheckedChanged
        ioperation = "CF"

    End Sub
    Private Sub RbtnFtoC_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnFtoC.CheckedChanged
        ioperation = "FC"
    End Sub
    Private Sub RbtnKelvin_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnKelvin.CheckedChanged
        ioperation = "K"
    End Sub

    Private Sub RbtnKGtoG_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnKGtoG.CheckedChanged
        ioperation = "KG"
    End Sub

    Private Sub RbtnGtoKG_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnGtoKG.CheckedChanged
        ioperation = "GK"
    End Sub


    Private Sub RbtnLtoML_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnLtoML.CheckedChanged
        ioperation = "LM"
    End Sub

    Private Sub RbtnMLtoL_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnMLtoL.CheckedChanged
        ioperation = "ML"
    End Sub

    Private Sub RbtnKMtoM_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnKMtoM.CheckedChanged
        ioperation = "KM"
    End Sub

    Private Sub RbtnMtoKM_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnMtoKM.CheckedChanged
        ioperation = "MK"
    End Sub

    Private Sub RbtnMtoFT_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnMtoFT.CheckedChanged
        ioperation = "MF"
    End Sub

    Private Sub RbtmCMtoM_CheckedChanged(sender As Object, e As EventArgs) Handles RbtmCMtoM.CheckedChanged
        ioperation = "CM"
    End Sub

    Private Sub RbtnFTtoIN_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnFTtoIN.CheckedChanged
        ioperation = "FI"
    End Sub


    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        Select Case (ioperation)
            Case "KM"
                'Kilometer to Meter
                Kilometer = Double.Parse(txtConvert.Text)
                lblConvert.Text = ((1000 * Kilometer).ToString())

            Case "MK"
                'Meter to Kilometer
                Meter = Double.Parse(txtConvert.Text)
                lblConvert.Text = ((Meter / 1000).ToString())

            Case "MF"
                'Meter to Feet
                Inches = Double.Parse(txtConvert.Text)
                lblConvert.Text = ((3 * Inches).ToString())

            Case "FI"
                'Feet to Inches
                Feet = Double.Parse(txtConvert.Text)
                lblConvert.Text = ((Feet * 12).ToString())

            Case "KG"
                'Kilogram to Gram
                Kilo = Double.Parse(txtConvert.Text)
                lblConvert.Text = ((1000 * Kilo).ToString())

            Case "GK"
                'Gram to Kilogram
                Gram = Double.Parse(txtConvert.Text)
                lblConvert.Text = ((Gram / 1000).ToString())

            Case "LM"
                'Liter to Mili-Liter
                Liter = Double.Parse(txtConvert.Text)
                lblConvert.Text = ((1000 * Liter).ToString())

            Case "ML"
                'Mili-Liter to Liter
                Mililiter = Double.Parse(txtConvert.Text)
                lblConvert.Text = ((Mililiter / 1000).ToString())

            Case "CM"
                'Centimeter to Meter
                Centimeter = Double.Parse(txtConvert.Text)
                lblConvert.Text = ((Centimeter / 100).ToString())

            Case "CF"
                'Celsius to Fahrenheit
                Celsius = Double.Parse(txtConvert.Text)
                lblConvert.Text = ((((9 * Celsius) / 5) + 32).ToString())

            Case "FC"
                'Fahrenheit to Celsius
                Fahrenheit = Double.Parse(txtConvert.Text)
                lblConvert.Text = ((((Fahrenheit - 32) * 5) / 9).ToString())

            Case "K"
                'Convert to Kelvin
                Kelvin = Double.Parse(txtConvert.Text)
                lblConvert.Text = (((((9 * Kelvin) / 5) + 32) + 273.15).ToString())

        End Select
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtConvert.Clear()
        lblConvert.Text = ""
        txtConvert.Text = ""


        RbtnCtoF.Checked = False
        RbtnFtoC.Checked = False
        RbtnKelvin.Checked = False
        RbtnKGtoG.Checked = False
        RbtnGtoKG.Checked = False
        RbtnLtoML.Checked = False
        RbtnMLtoL.Checked = False
        RbtnKMtoM.Checked = False
        RbtnMtoKM.Checked = False
        RbtnMtoFT.Checked = False
        RbtnCtoF.Checked = False
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()


    End Sub





    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
