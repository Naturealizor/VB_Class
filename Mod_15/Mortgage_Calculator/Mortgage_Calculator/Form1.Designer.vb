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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtInitial = New System.Windows.Forms.TextBox()
        Me.cboInterest = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboTerm = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblFifteenYear = New System.Windows.Forms.Label()
        Me.lblTwentyYear = New System.Windows.Forms.Label()
        Me.lblTwentyFiveYear = New System.Windows.Forms.Label()
        Me.lblThirtyYear = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(180, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mortgage Calculator"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label2.Location = New System.Drawing.Point(21, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(294, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter the loan amount"
        '
        'txtInitial
        '
        Me.txtInitial.Location = New System.Drawing.Point(73, 158)
        Me.txtInitial.Name = "txtInitial"
        Me.txtInitial.Size = New System.Drawing.Size(177, 26)
        Me.txtInitial.TabIndex = 2
        '
        'cboInterest
        '
        Me.cboInterest.FormattingEnabled = True
        Me.cboInterest.Location = New System.Drawing.Point(473, 132)
        Me.cboInterest.Name = "cboInterest"
        Me.cboInterest.Size = New System.Drawing.Size(121, 28)
        Me.cboInterest.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label3.Location = New System.Drawing.Point(440, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Interest Rate"
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnCalc.Location = New System.Drawing.Point(73, 624)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(131, 56)
        Me.btnCalc.TabIndex = 5
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnQuit.Location = New System.Drawing.Point(475, 624)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(131, 56)
        Me.btnQuit.TabIndex = 6
        Me.btnQuit.Text = "&Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label4.Location = New System.Drawing.Point(21, 311)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 32)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "15 years"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label5.Location = New System.Drawing.Point(215, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 32)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "20 years"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label6.Location = New System.Drawing.Point(440, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 32)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Term length"
        '
        'cboTerm
        '
        Me.cboTerm.FormattingEnabled = True
        Me.cboTerm.Location = New System.Drawing.Point(473, 245)
        Me.cboTerm.Name = "cboTerm"
        Me.cboTerm.Size = New System.Drawing.Size(121, 28)
        Me.cboTerm.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label7.Location = New System.Drawing.Point(21, 447)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 32)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "25 years"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label8.Location = New System.Drawing.Point(215, 447)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 32)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "30 years"
        '
        'lblFifteenYear
        '
        Me.lblFifteenYear.BackColor = System.Drawing.SystemColors.Info
        Me.lblFifteenYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFifteenYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblFifteenYear.Location = New System.Drawing.Point(27, 366)
        Me.lblFifteenYear.Name = "lblFifteenYear"
        Me.lblFifteenYear.Size = New System.Drawing.Size(117, 40)
        Me.lblFifteenYear.TabIndex = 16
        '
        'lblTwentyYear
        '
        Me.lblTwentyYear.BackColor = System.Drawing.SystemColors.Info
        Me.lblTwentyYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTwentyYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblTwentyYear.Location = New System.Drawing.Point(221, 366)
        Me.lblTwentyYear.Name = "lblTwentyYear"
        Me.lblTwentyYear.Size = New System.Drawing.Size(117, 40)
        Me.lblTwentyYear.TabIndex = 17
        '
        'lblTwentyFiveYear
        '
        Me.lblTwentyFiveYear.BackColor = System.Drawing.SystemColors.Info
        Me.lblTwentyFiveYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTwentyFiveYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblTwentyFiveYear.Location = New System.Drawing.Point(27, 505)
        Me.lblTwentyFiveYear.Name = "lblTwentyFiveYear"
        Me.lblTwentyFiveYear.Size = New System.Drawing.Size(117, 40)
        Me.lblTwentyFiveYear.TabIndex = 18
        '
        'lblThirtyYear
        '
        Me.lblThirtyYear.BackColor = System.Drawing.SystemColors.Info
        Me.lblThirtyYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblThirtyYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblThirtyYear.Location = New System.Drawing.Point(221, 505)
        Me.lblThirtyYear.Name = "lblThirtyYear"
        Me.lblThirtyYear.Size = New System.Drawing.Size(117, 40)
        Me.lblThirtyYear.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 705)
        Me.Controls.Add(Me.lblThirtyYear)
        Me.Controls.Add(Me.lblTwentyFiveYear)
        Me.Controls.Add(Me.lblTwentyYear)
        Me.Controls.Add(Me.lblFifteenYear)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboTerm)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboInterest)
        Me.Controls.Add(Me.txtInitial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtInitial As TextBox
    Friend WithEvents cboInterest As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cboTerm As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblFifteenYear As Label
    Friend WithEvents lblTwentyYear As Label
    Friend WithEvents lblTwentyFiveYear As Label
    Friend WithEvents lblThirtyYear As Label
End Class
