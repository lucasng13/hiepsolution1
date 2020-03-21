' Name:         Mills Project
' Purpose:      Displays each skater's total score, number of scores, and average score.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Dim dblScores As Double
    Dim dblTotal As Double
    Dim intNumScores As Integer
    Dim dblAverage As Double
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        For dblScores As Double = 0.0 To 10.0 Step 0.5
            lstScores.Items.Add(dblScores.ToString("n1"))

        Next

        'If lstScores.Items.Count > 0 Then
        lstScores.SelectedIndex = 0
        'End If
    End Sub

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click


        Double.TryParse(lstScores.Text, dblScores).ToString()
        'Double.TryParse(lblTotal.Text, dblTotal)



        dblTotal = dblScores + dblTotal
        lblTotal.Text = dblTotal.ToString("n1")


        'Integer.TryParse(lblNumScores.Text, intNumScores)
        intNumScores += 1
        lblNumScores.Text = intNumScores.ToString



        'Double.TryParse(lblAverage.Text, dblAverage)
        dblAverage = (dblTotal / intNumScores)
        lblAverage.Text = dblAverage.ToString("n1")


    End Sub

    Private Sub btnNextSkater_Click(sender As Object, e As EventArgs) Handles btnNextSkater.Click
        lblAverage.Text = String.Empty
        lblNumScores.Text = String.Empty
        lblTotal.Text = String.Empty

        ' If lstScores.Items.Count > 0 Then
        lstScores.SelectedIndex = 0
        ' End If
        dblScores = 0
        dblTotal = 0
        intNumScores = 0
        dblAverage = 0

    End Sub

    'if user changes the selection of the lstScores, the label controls dsplaying the output values need to be cleared
    Private Sub lstScores_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstScores.SelectedValueChanged
        lblAverage.Text = String.Empty
        lblNumScores.Text = String.Empty
        lblTotal.Text = String.Empty

    End Sub

    'Private Sub ClearOutput(sender As Object, e As EventArgs) Handles lstScores.SelectedIndexChanged

    '    lblAverage.Text = String.Empty
    '    lblNumScores.Text = String.Empty
    '    lblTotal.Text = String.Empty
    'End Sub

End Class
