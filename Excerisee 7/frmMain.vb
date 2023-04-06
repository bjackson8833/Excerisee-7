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
        ElseIf radGlazed.Checked And radCap.Checked = True Then
            GetCostGC(dblGlazed, dblSales, dblCappuccino)
        ElseIf radSugar.Checked And radNone.Checked = True Then
            GetCostSN(dblSugar, dblSales, dblNone)
        ElseIf radSugar.Checked And radRegular.Checked = True Then
            GetCostSR(dblSugar, dblSales, dblRegular)
        ElseIf radSugar.Checked And radCap.Checked = True Then
            GetCostSC(dblSugar, dblSales, dblCappuccino)
        ElseIf radChocolate.Checked And radNone.Checked = True Then
            GetCostCN(dblChocolate, dblSales, dblNone)
        ElseIf radChocolate.Checked And radRegular.Checked = True Then
            GetCostCR(dblChocolate, dblSales, dblRegular)
        ElseIf radChocolate.Checked And radCap.Checked = True Then
            GetCostCC(dblChocolate, dblSales, dblCappuccino)
        ElseIf radFilled.Checked And radNone.Checked = True Then
            GetCostFN(dblFilled, dblSales, dblNone)
        ElseIf radFilled.Checked And radRegular.Checked = True Then
            GetCostFR(dblFilled, dblSales, dblRegular)
        ElseIf radFilled.Checked And radCap.Checked = True Then
            GetCostFC(dblFilled, dblSales, dblCappuccino)
        End If





    End Sub
    Private Sub GetCostFC(ByVal dblFilled As Double, ByVal dblCappuccino As Double, ByVal dblSales As Double)
        Dim dblTotal As Double
        Dim dblSub As Double
        Dim dblTax As Double

        dblSub = dblFilled + dblCappuccino
        dblTax = (dblFilled + dblCappuccino) * dblSales
        dblTotal = dblSub + dblTax
        lblSales.Text = dblTax.ToString("C2")
        lblTotal.Text = dblTotal.ToString("C2")
        lblSub.Text = dblSub.ToString("C2")
    End Sub
    Private Sub GetCostFR(ByVal dblFilled As Double, ByVal dblRegular As Double, ByVal dblSales As Double)
        Dim dblTotal As Double
        Dim dblSub As Double
        Dim dblTax As Double

        dblSub = dblFilled + dblRegular
        dblTax = (dblFilled + dblRegular) * dblSales
        dblTotal = dblSub + dblTax
        lblSales.Text = dblTax.ToString("C2")
        lblTotal.Text = dblTotal.ToString("C2")
        lblSub.Text = dblSub.ToString("C2")
    End Sub
    Private Sub GetCostFN(ByVal dblFilled As Double, ByVal dblNone As Double, ByVal dblSales As Double)
        Dim dblTotal As Double
        Dim dblSub As Double
        Dim dblTax As Double

        dblSub = dblFilled + dblNone
        dblTax = (dblFilled + dblNone) * dblSales
        dblTotal = dblSub + dblTax
        lblSales.Text = dblTax.ToString("C2")
        lblTotal.Text = dblTotal.ToString("C2")
        lblSub.Text = dblSub.ToString("C2")
    End Sub
    Private Sub GetCostCC(ByVal dblChocolate As Double, ByVal dblCappuccino As Double, ByVal dblSales As Double)
        Dim dblTotal As Double
        Dim dblSub As Double
        Dim dblTax As Double

        dblSub = dblChocolate + dblCappuccino
        dblTax = (dblChocolate + dblCappuccino) * dblSales
        dblTotal = dblSub + dblTax
        lblSales.Text = dblTax.ToString("C2")
        lblTotal.Text = dblTotal.ToString("C2")
        lblSub.Text = dblSub.ToString("C2")
    End Sub
    Private Sub GetCostCR(ByVal dblChocolate As Double, ByVal dblRegular As Double, ByVal dblSales As Double)
        Dim dblTotal As Double
        Dim dblSub As Double
        Dim dblTax As Double

        dblSub = dblChocolate + dblRegular
        dblTax = (dblChocolate + dblRegular) * dblSales
        dblTotal = dblSub + dblTax
        lblSales.Text = dblTax.ToString("C2")
        lblTotal.Text = dblTotal.ToString("C2")
        lblSub.Text = dblSub.ToString("C2")
    End Sub
    Private Sub GetCostCN(ByVal dblChocolate As Double, ByVal dblNone As Double, ByVal dblSales As Double)
        Dim dblTotal As Double
        Dim dblSub As Double
        Dim dblTax As Double

        dblSub = dblChocolate + dblNone
        dblTax = (dblChocolate + dblNone) * dblSales
        dblTotal = dblSub + dblTax
        lblSales.Text = dblTax.ToString("C2")
        lblTotal.Text = dblTotal.ToString("C2")
        lblSub.Text = dblSub.ToString("C2")
    End Sub
    Private Sub GetCostSC(ByVal dblSugar As Double, ByVal dblCappuccino As Double, ByVal dblSales As Double)
        Dim dblTotal As Double
        Dim dblSub As Double
        Dim dblTax As Double

        dblSub = dblSugar + dblCappuccino
        dblTax = (dblSugar + dblCappuccino) * dblSales
        dblTotal = dblSub + dblTax
        lblSales.Text = dblTax.ToString("C2")
        lblTotal.Text = dblTotal.ToString("C2")
        lblSub.Text = dblSub.ToString("C2")
    End Sub
    Private Sub GetCostSR(ByVal dblSugar As Double, ByVal dblRegular As Double, ByVal dblSales As Double)
        Dim dblTotal As Double
        Dim dblSub As Double
        Dim dblTax As Double

        dblSub = dblSugar + dblRegular
        dblTax = (dblSugar + dblRegular) * dblSales
        dblTotal = dblSub + dblTax
        lblSales.Text = dblTax.ToString("C2")
        lblTotal.Text = dblTotal.ToString("C2")
        lblSub.Text = dblSub.ToString("C2")
    End Sub
    Private Sub GetCostSN(ByVal dblSugar As Double, ByVal dblNone As Double, ByVal dblSales As Double)
        Dim dblTotal As Double
        Dim dblSub As Double
        Dim dblTax As Double

        dblSub = dblSugar + dblNone
        dblTax = (dblSugar + dblNone) * dblSales
        dblTotal = dblSub + dblTax
        lblSales.Text = dblTax.ToString("C2")
        lblTotal.Text = dblTotal.ToString("C2")
        lblSub.Text = dblSub.ToString("C2")
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
    Private Sub GetCostGC(ByVal dblGlazed As Double, ByVal dblCappuccino As Double, ByVal dblSales As Double)
        Dim dblTotal As Double
        Dim dblSub As Double
        Dim dblTax As Double

        dblSub = dblGlazed + dblCappuccino
        lblSub.Text = dblSub.ToString("C2")
        dblTax = (dblGlazed + dblCappuccino) * dblSales
        lblSales.Text = dblTax.ToString("C2")
        dblTotal = dblSub + dblTax
        lblTotal.Text = dblTotal.ToString("C2")


    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub radGlazed_CheckedChanged(sender As Object, e As EventArgs) Handles radGlazed.CheckedChanged

    End Sub
End Class
