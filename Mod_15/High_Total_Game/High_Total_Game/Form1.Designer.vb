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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtP1Name = New System.Windows.Forms.TextBox()
        Me.txtP2Name = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.bntNewGame = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblP1Lable = New System.Windows.Forms.Label()
        Me.lblP2Lable = New System.Windows.Forms.Label()
        Me.lblP1RandomNumOne = New System.Windows.Forms.Label()
        Me.lblP1RandomNumTwo = New System.Windows.Forms.Label()
        Me.lblP2RandomNumOne = New System.Windows.Forms.Label()
        Me.lblP2RandomNumTwo = New System.Windows.Forms.Label()
        Me.lblAnnounce = New System.Windows.Forms.Label()
        Me.lblP1Total = New System.Windows.Forms.Label()
        Me.lblP2Total = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblWinCountP1 = New System.Windows.Forms.Label()
        Me.lblWinCountP2 = New System.Windows.Forms.Label()
        Me.lblTieCount = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Javanese Text", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(217, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(726, 91)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "High Total Game - 2 Players Required"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Player 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Player 2"
        '
        'txtP1Name
        '
        Me.txtP1Name.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtP1Name.Location = New System.Drawing.Point(233, 158)
        Me.txtP1Name.Name = "txtP1Name"
        Me.txtP1Name.Size = New System.Drawing.Size(167, 26)
        Me.txtP1Name.TabIndex = 3
        '
        'txtP2Name
        '
        Me.txtP2Name.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtP2Name.Location = New System.Drawing.Point(233, 220)
        Me.txtP2Name.Name = "txtP2Name"
        Me.txtP2Name.Size = New System.Drawing.Size(167, 26)
        Me.txtP2Name.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(92, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(293, 40)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Enter your name:"
        '
        'btnRoll
        '
        Me.btnRoll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoll.Location = New System.Drawing.Point(27, 656)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(164, 70)
        Me.btnRoll.TabIndex = 6
        Me.btnRoll.Text = "&Roll"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'bntNewGame
        '
        Me.bntNewGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntNewGame.Location = New System.Drawing.Point(482, 656)
        Me.bntNewGame.Name = "bntNewGame"
        Me.bntNewGame.Size = New System.Drawing.Size(164, 70)
        Me.bntNewGame.TabIndex = 7
        Me.bntNewGame.Text = "&New Game"
        Me.bntNewGame.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(958, 656)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(164, 70)
        Me.btnQuit.TabIndex = 8
        Me.btnQuit.Text = "&Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(536, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(525, 40)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Click on Roll to begin the game!"
        '
        'lblP1Lable
        '
        Me.lblP1Lable.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblP1Lable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblP1Lable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1Lable.Location = New System.Drawing.Point(496, 164)
        Me.lblP1Lable.Name = "lblP1Lable"
        Me.lblP1Lable.Size = New System.Drawing.Size(291, 39)
        Me.lblP1Lable.TabIndex = 10
        '
        'lblP2Lable
        '
        Me.lblP2Lable.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblP2Lable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblP2Lable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2Lable.Location = New System.Drawing.Point(831, 164)
        Me.lblP2Lable.Name = "lblP2Lable"
        Me.lblP2Lable.Size = New System.Drawing.Size(291, 39)
        Me.lblP2Lable.TabIndex = 11
        '
        'lblP1RandomNumOne
        '
        Me.lblP1RandomNumOne.BackColor = System.Drawing.SystemColors.Info
        Me.lblP1RandomNumOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblP1RandomNumOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1RandomNumOne.Location = New System.Drawing.Point(543, 231)
        Me.lblP1RandomNumOne.Name = "lblP1RandomNumOne"
        Me.lblP1RandomNumOne.Size = New System.Drawing.Size(63, 55)
        Me.lblP1RandomNumOne.TabIndex = 12
        '
        'lblP1RandomNumTwo
        '
        Me.lblP1RandomNumTwo.BackColor = System.Drawing.SystemColors.Info
        Me.lblP1RandomNumTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblP1RandomNumTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1RandomNumTwo.Location = New System.Drawing.Point(672, 231)
        Me.lblP1RandomNumTwo.Name = "lblP1RandomNumTwo"
        Me.lblP1RandomNumTwo.Size = New System.Drawing.Size(63, 55)
        Me.lblP1RandomNumTwo.TabIndex = 13
        '
        'lblP2RandomNumOne
        '
        Me.lblP2RandomNumOne.BackColor = System.Drawing.SystemColors.Info
        Me.lblP2RandomNumOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblP2RandomNumOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2RandomNumOne.Location = New System.Drawing.Point(892, 231)
        Me.lblP2RandomNumOne.Name = "lblP2RandomNumOne"
        Me.lblP2RandomNumOne.Size = New System.Drawing.Size(63, 55)
        Me.lblP2RandomNumOne.TabIndex = 14
        '
        'lblP2RandomNumTwo
        '
        Me.lblP2RandomNumTwo.BackColor = System.Drawing.SystemColors.Info
        Me.lblP2RandomNumTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblP2RandomNumTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2RandomNumTwo.Location = New System.Drawing.Point(1010, 231)
        Me.lblP2RandomNumTwo.Name = "lblP2RandomNumTwo"
        Me.lblP2RandomNumTwo.Size = New System.Drawing.Size(63, 55)
        Me.lblP2RandomNumTwo.TabIndex = 15
        '
        'lblAnnounce
        '
        Me.lblAnnounce.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnnounce.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnnounce.Location = New System.Drawing.Point(651, 423)
        Me.lblAnnounce.Name = "lblAnnounce"
        Me.lblAnnounce.Size = New System.Drawing.Size(266, 122)
        Me.lblAnnounce.TabIndex = 16
        '
        'lblP1Total
        '
        Me.lblP1Total.BackColor = System.Drawing.SystemColors.Info
        Me.lblP1Total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblP1Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1Total.Location = New System.Drawing.Point(605, 330)
        Me.lblP1Total.Name = "lblP1Total"
        Me.lblP1Total.Size = New System.Drawing.Size(63, 55)
        Me.lblP1Total.TabIndex = 17
        '
        'lblP2Total
        '
        Me.lblP2Total.BackColor = System.Drawing.SystemColors.Info
        Me.lblP2Total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblP2Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2Total.Location = New System.Drawing.Point(949, 330)
        Me.lblP2Total.Name = "lblP2Total"
        Me.lblP2Total.Size = New System.Drawing.Size(63, 55)
        Me.lblP2Total.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(512, 341)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 32)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Total:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(856, 341)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 32)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Total:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(64, 401)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(189, 32)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Player 1 Wins"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(64, 478)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(189, 32)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Player 2 Wins"
        '
        'lblWinCountP1
        '
        Me.lblWinCountP1.BackColor = System.Drawing.SystemColors.Info
        Me.lblWinCountP1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWinCountP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinCountP1.Location = New System.Drawing.Point(292, 401)
        Me.lblWinCountP1.Name = "lblWinCountP1"
        Me.lblWinCountP1.Size = New System.Drawing.Size(63, 39)
        Me.lblWinCountP1.TabIndex = 23
        '
        'lblWinCountP2
        '
        Me.lblWinCountP2.BackColor = System.Drawing.SystemColors.Info
        Me.lblWinCountP2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWinCountP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinCountP2.Location = New System.Drawing.Point(292, 478)
        Me.lblWinCountP2.Name = "lblWinCountP2"
        Me.lblWinCountP2.Size = New System.Drawing.Size(63, 39)
        Me.lblWinCountP2.TabIndex = 24
        '
        'lblTieCount
        '
        Me.lblTieCount.BackColor = System.Drawing.SystemColors.Info
        Me.lblTieCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTieCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTieCount.Location = New System.Drawing.Point(292, 554)
        Me.lblTieCount.Name = "lblTieCount"
        Me.lblTieCount.Size = New System.Drawing.Size(63, 39)
        Me.lblTieCount.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(64, 554)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 32)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Ties"
        '
        'btnEnter
        '
        Me.btnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(182, 279)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(115, 42)
        Me.btnEnter.TabIndex = 27
        Me.btnEnter.Text = "&Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1154, 771)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblTieCount)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblWinCountP2)
        Me.Controls.Add(Me.lblWinCountP1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblP2Total)
        Me.Controls.Add(Me.lblP1Total)
        Me.Controls.Add(Me.lblAnnounce)
        Me.Controls.Add(Me.lblP2RandomNumTwo)
        Me.Controls.Add(Me.lblP2RandomNumOne)
        Me.Controls.Add(Me.lblP1RandomNumTwo)
        Me.Controls.Add(Me.lblP1RandomNumOne)
        Me.Controls.Add(Me.lblP2Lable)
        Me.Controls.Add(Me.lblP1Lable)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.bntNewGame)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtP2Name)
        Me.Controls.Add(Me.txtP1Name)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtP1Name As TextBox
    Friend WithEvents txtP2Name As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRoll As Button
    Friend WithEvents bntNewGame As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblP1Lable As Label
    Friend WithEvents lblP2Lable As Label
    Friend WithEvents lblP1RandomNumOne As Label
    Friend WithEvents lblP1RandomNumTwo As Label
    Friend WithEvents lblP2RandomNumOne As Label
    Friend WithEvents lblP2RandomNumTwo As Label
    Friend WithEvents lblAnnounce As Label
    Friend WithEvents lblP1Total As Label
    Friend WithEvents lblP2Total As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblWinCountP1 As Label
    Friend WithEvents lblWinCountP2 As Label
    Friend WithEvents lblTieCount As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnEnter As Button
End Class
