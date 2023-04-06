' Name: Excerise 7
' Purpose: Displays doughnut and coffee cost.
' Programmer: Bj Jackson on 4/5/23
Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblGlazed As Double
        Dim dblSugar As Double
        Dim dblChocolate As Double
        Dim dblFilled As Double
        Dim dblNone As Double
        Dim dblRegular As Double
        Dim dblCappuccino As Double
        Dim dblSales As Double




        dblCappuccino = 2.75
        dblGlazed = 1.05
        dblSugar = 1.05
        dblChocolate = 1.25
        dblFilled = 1.5
        dblNone = 0
        dblRegular = 1.5
        dblSales = 0.06D

        If radGlazed.Checked And radNone.Checked = True Then
            GetCostGN(dblGlazed, dblSales, dblNone)

        ElseIf radGlazed.Checked And radRegular.Checked = True Then
            GetCostGR(dblGlazed, dblSales, dblRegular)



        End If





    End Sub
    Private Sub GetCostGN(ByVal dblGlazed As Double, ByVal dblNone As Double, ByVal dblSales As Double)
        Dim dblTotal As Double
        Dim dblSub As Double
        Dim dblTax As Double

        dblSub = dblGlazed + dblNone
        dblTax = (dblGlazed + dblNone) * dblSales
        dblTotal = dblSub + dblTax
        lblSales.Text = dblTax.ToString("C2")
        lblTotal.Text = dblTotal.ToString("C2")
        lblSub.Text = dblSub.ToString("C2")
    End Sub

    Private Sub GetCostGR(ByVal dblGlazed As Double, ByVal dblRegular As Double, ByVal dblSales As Double)
        Dim dblTotal As Double
        Dim dblSub As Double
        Dim dblTax As Double

        dblSub = dblGlazed + dblRegular
        lblSub.Text = dblSub.ToString("C2")
        dblTax = (dblGlazed + dblRegular) * dblSales
        lblSales.Text = dblTax.ToString("C2")
        dblTotal = dblSub + dblTax
        lblTotal.Text = dblTotal.ToString("C2")


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
