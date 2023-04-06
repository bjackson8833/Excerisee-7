<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.radFilled = New System.Windows.Forms.RadioButton()
        Me.radChocolate = New System.Windows.Forms.RadioButton()
        Me.radSugar = New System.Windows.Forms.RadioButton()
        Me.radGlazed = New System.Windows.Forms.RadioButton()
        Me.grbCofee = New System.Windows.Forms.GroupBox()
        Me.radCap = New System.Windows.Forms.RadioButton()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.radNone = New System.Windows.Forms.RadioButton()
        Me.grpbSales = New System.Windows.Forms.GroupBox()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotalD = New System.Windows.Forms.Label()
        Me.lblSaleD = New System.Windows.Forms.Label()
        Me.lblSubD = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.groupBox1.SuspendLayout()
        Me.grbCofee.SuspendLayout()
        Me.grpbSales.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.radFilled)
        Me.groupBox1.Controls.Add(Me.radChocolate)
        Me.groupBox1.Controls.Add(Me.radSugar)
        Me.groupBox1.Controls.Add(Me.radGlazed)
        Me.groupBox1.Location = New System.Drawing.Point(9, 21)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.groupBox1.Size = New System.Drawing.Size(190, 203)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Doughnut Choices"
        '
        'radFilled
        '
        Me.radFilled.AutoSize = True
        Me.radFilled.Location = New System.Drawing.Point(17, 165)
        Me.radFilled.Margin = New System.Windows.Forms.Padding(2)
        Me.radFilled.Name = "radFilled"
        Me.radFilled.Size = New System.Drawing.Size(85, 17)
        Me.radFilled.TabIndex = 3
        Me.radFilled.TabStop = True
        Me.radFilled.Text = "&Filled ($1.50)"
        Me.radFilled.UseVisualStyleBackColor = True
        '
        'radChocolate
        '
        Me.radChocolate.AutoSize = True
        Me.radChocolate.Location = New System.Drawing.Point(17, 122)
        Me.radChocolate.Margin = New System.Windows.Forms.Padding(2)
        Me.radChocolate.Name = "radChocolate"
        Me.radChocolate.Size = New System.Drawing.Size(109, 17)
        Me.radChocolate.TabIndex = 2
        Me.radChocolate.TabStop = True
        Me.radChocolate.Text = "C&hocolate ($1.25)"
        Me.radChocolate.UseVisualStyleBackColor = True
        '
        'radSugar
        '
        Me.radSugar.AutoSize = True
        Me.radSugar.Location = New System.Drawing.Point(17, 81)
        Me.radSugar.Margin = New System.Windows.Forms.Padding(2)
        Me.radSugar.Name = "radSugar"
        Me.radSugar.Size = New System.Drawing.Size(89, 17)
        Me.radSugar.TabIndex = 1
        Me.radSugar.TabStop = True
        Me.radSugar.Text = "&Sugar ($1.05)"
        Me.radSugar.UseVisualStyleBackColor = True
        '
        'radGlazed
        '
        Me.radGlazed.AutoSize = True
        Me.radGlazed.Location = New System.Drawing.Point(17, 41)
        Me.radGlazed.Margin = New System.Windows.Forms.Padding(2)
        Me.radGlazed.Name = "radGlazed"
        Me.radGlazed.Size = New System.Drawing.Size(94, 17)
        Me.radGlazed.TabIndex = 0
        Me.radGlazed.TabStop = True
        Me.radGlazed.Text = "&Glazed ($1.05)"
        Me.radGlazed.UseVisualStyleBackColor = True
        '
        'grbCofee
        '
        Me.grbCofee.Controls.Add(Me.radCap)
        Me.grbCofee.Controls.Add(Me.radRegular)
        Me.grbCofee.Controls.Add(Me.radNone)
        Me.grbCofee.Location = New System.Drawing.Point(7, 229)
        Me.grbCofee.Margin = New System.Windows.Forms.Padding(2)
        Me.grbCofee.Name = "grbCofee"
        Me.grbCofee.Padding = New System.Windows.Forms.Padding(2)
        Me.grbCofee.Size = New System.Drawing.Size(193, 136)
        Me.grbCofee.TabIndex = 2
        Me.grbCofee.TabStop = False
        Me.grbCofee.Text = "Coffee Choices"
        '
        'radCap
        '
        Me.radCap.AutoSize = True
        Me.radCap.Location = New System.Drawing.Point(17, 105)
        Me.radCap.Margin = New System.Windows.Forms.Padding(2)
        Me.radCap.Name = "radCap"
        Me.radCap.Size = New System.Drawing.Size(118, 17)
        Me.radCap.TabIndex = 6
        Me.radCap.TabStop = True
        Me.radCap.Text = "&Cappuccino ($2.75)"
        Me.radCap.UseVisualStyleBackColor = True
        '
        'radRegular
        '
        Me.radRegular.AutoSize = True
        Me.radRegular.Location = New System.Drawing.Point(17, 70)
        Me.radRegular.Margin = New System.Windows.Forms.Padding(2)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(98, 17)
        Me.radRegular.TabIndex = 5
        Me.radRegular.TabStop = True
        Me.radRegular.Text = "&Regular ($1.50)"
        Me.radRegular.UseVisualStyleBackColor = True
        '
        'radNone
        '
        Me.radNone.AutoSize = True
        Me.radNone.Location = New System.Drawing.Point(17, 34)
        Me.radNone.Margin = New System.Windows.Forms.Padding(2)
        Me.radNone.Name = "radNone"
        Me.radNone.Size = New System.Drawing.Size(51, 17)
        Me.radNone.TabIndex = 4
        Me.radNone.TabStop = True
        Me.radNone.Text = "&None"
        Me.radNone.UseVisualStyleBackColor = True
        '
        'grpbSales
        '
        Me.grpbSales.Controls.Add(Me.lblSub)
        Me.grpbSales.Controls.Add(Me.lblSales)
        Me.grpbSales.Controls.Add(Me.lblTotal)
        Me.grpbSales.Controls.Add(Me.lblTotalD)
        Me.grpbSales.Controls.Add(Me.lblSaleD)
        Me.grpbSales.Controls.Add(Me.lblSubD)
        Me.grpbSales.Location = New System.Drawing.Point(212, 21)
        Me.grpbSales.Margin = New System.Windows.Forms.Padding(2)
        Me.grpbSales.Name = "grpbSales"
        Me.grpbSales.Padding = New System.Windows.Forms.Padding(2)
        Me.grpbSales.Size = New System.Drawing.Size(133, 208)
        Me.grpbSales.TabIndex = 3
        Me.grpbSales.TabStop = False
        '
        'lblSub
        '
        Me.lblSub.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblSub.Location = New System.Drawing.Point(61, 24)
        Me.lblSub.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(58, 32)
        Me.lblSub.TabIndex = 5
        '
        'lblSales
        '
        Me.lblSales.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblSales.Location = New System.Drawing.Point(61, 90)
        Me.lblSales.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(58, 32)
        Me.lblSales.TabIndex = 4
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblTotal.Location = New System.Drawing.Point(61, 158)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(58, 32)
        Me.lblTotal.TabIndex = 3
        '
        'lblTotalD
        '
        Me.lblTotalD.AutoSize = True
        Me.lblTotalD.Location = New System.Drawing.Point(3, 158)
        Me.lblTotalD.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalD.Name = "lblTotalD"
        Me.lblTotalD.Size = New System.Drawing.Size(57, 13)
        Me.lblTotalD.TabIndex = 2
        Me.lblTotalD.Text = "Total Due:"
        '
        'lblSaleD
        '
        Me.lblSaleD.AutoSize = True
        Me.lblSaleD.Location = New System.Drawing.Point(3, 93)
        Me.lblSaleD.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSaleD.Name = "lblSaleD"
        Me.lblSaleD.Size = New System.Drawing.Size(57, 13)
        Me.lblSaleD.TabIndex = 1
        Me.lblSaleD.Text = "Sales Tax:"
        '
        'lblSubD
        '
        Me.lblSubD.AutoSize = True
        Me.lblSubD.Location = New System.Drawing.Point(4, 24)
        Me.lblSubD.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSubD.Name = "lblSubD"
        Me.lblSubD.Size = New System.Drawing.Size(53, 13)
        Me.lblSubD.TabIndex = 0
        Me.lblSubD.Text = "SubTotal:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(219, 242)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(126, 58)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(218, 316)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(129, 40)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 366)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.grpbSales)
        Me.Controls.Add(Me.grbCofee)
        Me.Controls.Add(Me.groupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.grbCofee.ResumeLayout(False)
        Me.grbCofee.PerformLayout()
        Me.grpbSales.ResumeLayout(False)
        Me.grpbSales.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Private WithEvents radFilled As RadioButton
    Private WithEvents radChocolate As RadioButton
    Private WithEvents radSugar As RadioButton
    Private WithEvents radGlazed As RadioButton
    Private WithEvents grbCofee As GroupBox
    Private WithEvents radCap As RadioButton
    Private WithEvents radRegular As RadioButton
    Private WithEvents radNone As RadioButton
    Private WithEvents grpbSales As GroupBox
    Private WithEvents lblSub As Label
    Private WithEvents lblSales As Label
    Private WithEvents lblTotal As Label
    Private WithEvents lblTotalD As Label
    Private WithEvents lblSaleD As Label
    Private WithEvents lblSubD As Label
    Private WithEvents btnCalc As Button
    Private WithEvents btnExit As Button
End Class
