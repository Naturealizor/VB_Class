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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtLodging = New System.Windows.Forms.TextBox()
        Me.txtTravel = New System.Windows.Forms.TextBox()
        Me.txtMeals = New System.Windows.Forms.TextBox()
        Me.txtEntertainment = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblAmountDeduct = New System.Windows.Forms.Label()
        Me.lblPercentageDeduct = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(163, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(431, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tax-Deductible Calculator"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEntertainment)
        Me.GroupBox1.Controls.Add(Me.txtMeals)
        Me.GroupBox1.Controls.Add(Me.txtTravel)
        Me.GroupBox1.Controls.Add(Me.txtLodging)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(262, 242)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(65, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Expenses"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(6, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Lodging"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(6, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Travel"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(6, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 25)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Meals"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(6, 209)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 25)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Entertainment"
        '
        'txtLodging
        '
        Me.txtLodging.Location = New System.Drawing.Point(144, 69)
        Me.txtLodging.Name = "txtLodging"
        Me.txtLodging.Size = New System.Drawing.Size(100, 26)
        Me.txtLodging.TabIndex = 7
        '
        'txtTravel
        '
        Me.txtTravel.Location = New System.Drawing.Point(144, 112)
        Me.txtTravel.Name = "txtTravel"
        Me.txtTravel.Size = New System.Drawing.Size(100, 26)
        Me.txtTravel.TabIndex = 8
        '
        'txtMeals
        '
        Me.txtMeals.Location = New System.Drawing.Point(144, 162)
        Me.txtMeals.Name = "txtMeals"
        Me.txtMeals.Size = New System.Drawing.Size(100, 26)
        Me.txtMeals.TabIndex = 9
        '
        'txtEntertainment
        '
        Me.txtEntertainment.Location = New System.Drawing.Point(144, 208)
        Me.txtEntertainment.Name = "txtEntertainment"
        Me.txtEntertainment.Size = New System.Drawing.Size(100, 26)
        Me.txtEntertainment.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(329, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 25)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Total expenses"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(319, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 25)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Amount deductible"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(301, 291)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(206, 25)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Percentage deductible"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.Info
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblTotal.Location = New System.Drawing.Point(548, 117)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(146, 25)
        Me.lblTotal.TabIndex = 5
        '
        'lblAmountDeduct
        '
        Me.lblAmountDeduct.BackColor = System.Drawing.SystemColors.Info
        Me.lblAmountDeduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAmountDeduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblAmountDeduct.Location = New System.Drawing.Point(548, 199)
        Me.lblAmountDeduct.Name = "lblAmountDeduct"
        Me.lblAmountDeduct.Size = New System.Drawing.Size(146, 25)
        Me.lblAmountDeduct.TabIndex = 6
        '
        'lblPercentageDeduct
        '
        Me.lblPercentageDeduct.BackColor = System.Drawing.SystemColors.Info
        Me.lblPercentageDeduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPercentageDeduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblPercentageDeduct.Location = New System.Drawing.Point(548, 291)
        Me.lblPercentageDeduct.Name = "lblPercentageDeduct"
        Me.lblPercentageDeduct.Size = New System.Drawing.Size(146, 25)
        Me.lblPercentageDeduct.TabIndex = 7
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnCalc.Location = New System.Drawing.Point(170, 368)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(128, 57)
        Me.btnCalc.TabIndex = 8
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnQuit.Location = New System.Drawing.Point(443, 368)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(128, 57)
        Me.btnQuit.TabIndex = 9
        Me.btnQuit.Text = "&Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblPercentageDeduct)
        Me.Controls.Add(Me.lblAmountDeduct)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtEntertainment As TextBox
    Friend WithEvents txtMeals As TextBox
    Friend WithEvents txtTravel As TextBox
    Friend WithEvents txtLodging As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblAmountDeduct As Label
    Friend WithEvents lblPercentageDeduct As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnQuit As Button
End Class
