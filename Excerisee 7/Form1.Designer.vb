<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.radioButton4 = New System.Windows.Forms.RadioButton()
        Me.radChocolate = New System.Windows.Forms.RadioButton()
        Me.radSugar = New System.Windows.Forms.RadioButton()
        Me.radGlazed = New System.Windows.Forms.RadioButton()
        Me.grbCofee = New System.Windows.Forms.GroupBox()
        Me.radCap = New System.Windows.Forms.RadioButton()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.radNone = New System.Windows.Forms.RadioButton()
        Me.grpbSales = New System.Windows.Forms.GroupBox()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.lblTotalD = New System.Windows.Forms.Label()
        Me.lblSaleD = New System.Windows.Forms.Label()
        Me.lblSubD = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.groupBox1.SuspendLayout()
        Me.grbCofee.SuspendLayout()
        Me.grpbSales.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.radioButton4)
        Me.groupBox1.Controls.Add(Me.radChocolate)
        Me.groupBox1.Controls.Add(Me.radSugar)
        Me.groupBox1.Controls.Add(Me.radGlazed)
        Me.groupBox1.Location = New System.Drawing.Point(12, 26)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(254, 250)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Doughnut Choices"
        '
        'radioButton4
        '
        Me.radioButton4.AutoSize = True
        Me.radioButton4.Location = New System.Drawing.Point(23, 203)
        Me.radioButton4.Name = "radioButton4"
        Me.radioButton4.Size = New System.Drawing.Size(103, 20)
        Me.radioButton4.TabIndex = 3
        Me.radioButton4.TabStop = True
        Me.radioButton4.Text = "&Filled ($1.50)"
        Me.radioButton4.UseVisualStyleBackColor = True
        '
        'radChocolate
        '
        Me.radChocolate.AutoSize = True
        Me.radChocolate.Location = New System.Drawing.Point(23, 150)
        Me.radChocolate.Name = "radChocolate"
        Me.radChocolate.Size = New System.Drawing.Size(131, 20)
        Me.radChocolate.TabIndex = 2
        Me.radChocolate.TabStop = True
        Me.radChocolate.Text = "C&hocolate ($1.25)"
        Me.radChocolate.UseVisualStyleBackColor = True
        '
        'radSugar
        '
        Me.radSugar.AutoSize = True
        Me.radSugar.Location = New System.Drawing.Point(23, 100)
        Me.radSugar.Name = "radSugar"
        Me.radSugar.Size = New System.Drawing.Size(106, 20)
        Me.radSugar.TabIndex = 1
        Me.radSugar.TabStop = True
        Me.radSugar.Text = "&Sugar ($1.05)"
        Me.radSugar.UseVisualStyleBackColor = True
        '
        'radGlazed
        '
        Me.radGlazed.AutoSize = True
        Me.radGlazed.Location = New System.Drawing.Point(23, 50)
        Me.radGlazed.Name = "radGlazed"
        Me.radGlazed.Size = New System.Drawing.Size(113, 20)
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
        Me.grbCofee.Location = New System.Drawing.Point(9, 282)
        Me.grbCofee.Name = "grbCofee"
        Me.grbCofee.Size = New System.Drawing.Size(257, 167)
        Me.grbCofee.TabIndex = 2
        Me.grbCofee.TabStop = False
        Me.grbCofee.Text = "Coffee Choices"
        '
        'radCap
        '
        Me.radCap.AutoSize = True
        Me.radCap.Location = New System.Drawing.Point(23, 129)
        Me.radCap.Name = "radCap"
        Me.radCap.Size = New System.Drawing.Size(142, 20)
        Me.radCap.TabIndex = 6
        Me.radCap.TabStop = True
        Me.radCap.Text = "&Cappuccino ($2.75)"
        Me.radCap.UseVisualStyleBackColor = True
        '
        'radRegular
        '
        Me.radRegular.AutoSize = True
        Me.radRegular.Location = New System.Drawing.Point(23, 86)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(118, 20)
        Me.radRegular.TabIndex = 5
        Me.radRegular.TabStop = True
        Me.radRegular.Text = "&Regular ($1.50)"
        Me.radRegular.UseVisualStyleBackColor = True
        '
        'radNone
        '
        Me.radNone.AutoSize = True
        Me.radNone.Location = New System.Drawing.Point(23, 42)
        Me.radNone.Name = "radNone"
        Me.radNone.Size = New System.Drawing.Size(61, 20)
        Me.radNone.TabIndex = 4
        Me.radNone.TabStop = True
        Me.radNone.Text = "&None"
        Me.radNone.UseVisualStyleBackColor = True
        '
        'grpbSales
        '
        Me.grpbSales.Controls.Add(Me.lblSub)
        Me.grpbSales.Controls.Add(Me.label5)
        Me.grpbSales.Controls.Add(Me.label4)
        Me.grpbSales.Controls.Add(Me.lblTotalD)
        Me.grpbSales.Controls.Add(Me.lblSaleD)
        Me.grpbSales.Controls.Add(Me.lblSubD)
        Me.grpbSales.Location = New System.Drawing.Point(283, 26)
        Me.grpbSales.Name = "grpbSales"
        Me.grpbSales.Size = New System.Drawing.Size(177, 256)
        Me.grpbSales.TabIndex = 3
        Me.grpbSales.TabStop = False
        '
        'lblSub
        '
        Me.lblSub.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblSub.Location = New System.Drawing.Point(81, 30)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(78, 39)
        Me.lblSub.TabIndex = 5
        '
        'label5
        '
        Me.label5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.label5.Location = New System.Drawing.Point(81, 111)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(78, 39)
        Me.label5.TabIndex = 4
        '
        'label4
        '
        Me.label4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.label4.Location = New System.Drawing.Point(81, 195)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(78, 39)
        Me.label4.TabIndex = 3
        '
        'lblTotalD
        '
        Me.lblTotalD.AutoSize = True
        Me.lblTotalD.Location = New System.Drawing.Point(4, 195)
        Me.lblTotalD.Name = "lblTotalD"
        Me.lblTotalD.Size = New System.Drawing.Size(69, 16)
        Me.lblTotalD.TabIndex = 2
        Me.lblTotalD.Text = "Total Due:"
        '
        'lblSaleD
        '
        Me.lblSaleD.AutoSize = True
        Me.lblSaleD.Location = New System.Drawing.Point(4, 115)
        Me.lblSaleD.Name = "lblSaleD"
        Me.lblSaleD.Size = New System.Drawing.Size(71, 16)
        Me.lblSaleD.TabIndex = 1
        Me.lblSaleD.Text = "Sales Tax:"
        '
        'lblSubD
        '
        Me.lblSubD.AutoSize = True
        Me.lblSubD.Location = New System.Drawing.Point(6, 30)
        Me.lblSubD.Name = "lblSubD"
        Me.lblSubD.Size = New System.Drawing.Size(65, 16)
        Me.lblSubD.TabIndex = 0
        Me.lblSubD.Text = "SubTotal:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(292, 298)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(168, 72)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(290, 389)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(172, 49)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(153, 189)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 72)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "&Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.grpbSales)
        Me.Controls.Add(Me.grbCofee)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "Form1"
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
    Private WithEvents radioButton4 As RadioButton
    Private WithEvents radChocolate As RadioButton
    Private WithEvents radSugar As RadioButton
    Private WithEvents radGlazed As RadioButton
    Private WithEvents grbCofee As GroupBox
    Private WithEvents radCap As RadioButton
    Private WithEvents radRegular As RadioButton
    Private WithEvents radNone As RadioButton
    Private WithEvents grpbSales As GroupBox
    Private WithEvents lblSub As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents lblTotalD As Label
    Private WithEvents lblSaleD As Label
    Private WithEvents lblSubD As Label
    Private WithEvents btnCalc As Button
    Private WithEvents btnExit As Button
    Private WithEvents Button1 As Button
End Class
