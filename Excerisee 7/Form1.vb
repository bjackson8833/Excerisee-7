' Name: Excerise 7
' Purpose: Displays doughnut and coffee cost.
' Programmer: Bj Jackson on 4/5/23
Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
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
        Dim dblSub As Double
        Dim dblTax As Double
        Dim dblTotal As Double

        dblCappuccino = 2.75
        dblGlazed = 1.05
        dblSugar = 1.05
        dblChocolate = 1.25
        dblFilled = 1.5
        dblNone = 0
        dblRegular = 1.5
        dblSales = 0.06D

        If radGlazed.Checked = True Then
            GetCost(dblGlazed)

        End If





    End Sub

    Private Function GetCost(ByRef dblGlazed As Double) As Double

    End Function


End Class
