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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbDiv = New System.Windows.Forms.RadioButton()
        Me.rdbMult = New System.Windows.Forms.RadioButton()
        Me.rdbSub = New System.Windows.Forms.RadioButton()
        Me.rdbAdd = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStuName = New System.Windows.Forms.TextBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.bntQuit = New System.Windows.Forms.Button()
        Me.lblEquation = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bntRun = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(293, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Math Practice"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(506, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(231, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter your name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbDiv)
        Me.GroupBox1.Controls.Add(Me.rdbMult)
        Me.GroupBox1.Controls.Add(Me.rdbSub)
        Me.GroupBox1.Controls.Add(Me.rdbAdd)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(414, 174)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'rdbDiv
        '
        Me.rdbDiv.AutoSize = True
        Me.rdbDiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbDiv.Location = New System.Drawing.Point(226, 133)
        Me.rdbDiv.Name = "rdbDiv"
        Me.rdbDiv.Size = New System.Drawing.Size(105, 29)
        Me.rdbDiv.TabIndex = 4
        Me.rdbDiv.TabStop = True
        Me.rdbDiv.Text = "Division"
        Me.rdbDiv.UseVisualStyleBackColor = True
        '
        'rdbMult
        '
        Me.rdbMult.AutoSize = True
        Me.rdbMult.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMult.Location = New System.Drawing.Point(67, 133)
        Me.rdbMult.Name = "rdbMult"
        Me.rdbMult.Size = New System.Drawing.Size(149, 29)
        Me.rdbMult.TabIndex = 3
        Me.rdbMult.TabStop = True
        Me.rdbMult.Text = "Multiplication"
        Me.rdbMult.UseVisualStyleBackColor = True
        '
        'rdbSub
        '
        Me.rdbSub.AutoSize = True
        Me.rdbSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbSub.Location = New System.Drawing.Point(226, 77)
        Me.rdbSub.Name = "rdbSub"
        Me.rdbSub.Size = New System.Drawing.Size(136, 29)
        Me.rdbSub.TabIndex = 2
        Me.rdbSub.TabStop = True
        Me.rdbSub.Text = "Subtraction"
        Me.rdbSub.UseVisualStyleBackColor = True
        '
        'rdbAdd
        '
        Me.rdbAdd.AutoSize = True
        Me.rdbAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbAdd.Location = New System.Drawing.Point(67, 77)
        Me.rdbAdd.Name = "rdbAdd"
        Me.rdbAdd.Size = New System.Drawing.Size(99, 29)
        Me.rdbAdd.TabIndex = 1
        Me.rdbAdd.TabStop = True
        Me.rdbAdd.Text = "Adding"
        Me.rdbAdd.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(300, 29)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Pick which type of problem"
        '
        'txtStuName
        '
        Me.txtStuName.Location = New System.Drawing.Point(529, 174)
        Me.txtStuName.Name = "txtStuName"
        Me.txtStuName.Size = New System.Drawing.Size(176, 26)
        Me.txtStuName.TabIndex = 3
        '
        'btnCheck
        '
        Me.btnCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnCheck.Location = New System.Drawing.Point(52, 659)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(161, 64)
        Me.btnCheck.TabIndex = 4
        Me.btnCheck.Text = "&Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnReset.Location = New System.Drawing.Point(372, 659)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(161, 64)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "&Reset Counter"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'bntQuit
        '
        Me.bntQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.bntQuit.Location = New System.Drawing.Point(669, 659)
        Me.bntQuit.Name = "bntQuit"
        Me.bntQuit.Size = New System.Drawing.Size(161, 64)
        Me.bntQuit.TabIndex = 6
        Me.bntQuit.Text = "&Quit"
        Me.bntQuit.UseVisualStyleBackColor = True
        '
        'lblEquation
        '
        Me.lblEquation.BackColor = System.Drawing.SystemColors.Info
        Me.lblEquation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEquation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblEquation.Location = New System.Drawing.Point(12, 307)
        Me.lblEquation.Name = "lblEquation"
        Me.lblEquation.Size = New System.Drawing.Size(233, 120)
        Me.lblEquation.TabIndex = 7
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(123, 516)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(189, 26)
        Me.txtAnswer.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(97, 465)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(251, 32)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Enter your answer:"
        '
        'bntRun
        '
        Me.bntRun.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.bntRun.Location = New System.Drawing.Point(277, 342)
        Me.bntRun.Name = "bntRun"
        Me.bntRun.Size = New System.Drawing.Size(145, 59)
        Me.bntRun.TabIndex = 10
        Me.bntRun.Text = "Run"
        Me.bntRun.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 764)
        Me.Controls.Add(Me.bntRun)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblEquation)
        Me.Controls.Add(Me.bntQuit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.txtStuName)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtStuName As TextBox
    Friend WithEvents rdbDiv As RadioButton
    Friend WithEvents rdbMult As RadioButton
    Friend WithEvents rdbSub As RadioButton
    Friend WithEvents rdbAdd As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents bntQuit As Button
    Friend WithEvents lblEquation As Label
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents bntRun As Button
End Class
