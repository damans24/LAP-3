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
        Me.enterLabel = New System.Windows.Forms.Label()
        Me.luckyNumberText = New System.Windows.Forms.TextBox()
        Me.betweenLabel = New System.Windows.Forms.Label()
        Me.optionLabel = New System.Windows.Forms.Label()
        Me.fiftyButton = New System.Windows.Forms.Button()
        Me.twentyButton = New System.Windows.Forms.Button()
        Me.resultLabel = New System.Windows.Forms.Label()
        Me.resultText = New System.Windows.Forms.TextBox()
        Me.playButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'enterLabel
        '
        Me.enterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enterLabel.Location = New System.Drawing.Point(37, 32)
        Me.enterLabel.Name = "enterLabel"
        Me.enterLabel.Size = New System.Drawing.Size(286, 40)
        Me.enterLabel.TabIndex = 0
        Me.enterLabel.Text = "Enter your lucky number:"
        '
        'luckyNumberText
        '
        Me.luckyNumberText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.luckyNumberText.Location = New System.Drawing.Point(380, 32)
        Me.luckyNumberText.Multiline = True
        Me.luckyNumberText.Name = "luckyNumberText"
        Me.luckyNumberText.Size = New System.Drawing.Size(111, 40)
        Me.luckyNumberText.TabIndex = 1
        '
        'betweenLabel
        '
        Me.betweenLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.betweenLabel.Location = New System.Drawing.Point(539, 32)
        Me.betweenLabel.Name = "betweenLabel"
        Me.betweenLabel.Size = New System.Drawing.Size(214, 40)
        Me.betweenLabel.TabIndex = 2
        Me.betweenLabel.Text = "Between 1 and 3"
        '
        'optionLabel
        '
        Me.optionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optionLabel.Location = New System.Drawing.Point(37, 98)
        Me.optionLabel.Name = "optionLabel"
        Me.optionLabel.Size = New System.Drawing.Size(217, 82)
        Me.optionLabel.TabIndex = 3
        Me.optionLabel.Text = "Payment Options: Select One"
        Me.optionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fiftyButton
        '
        Me.fiftyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fiftyButton.Location = New System.Drawing.Point(312, 106)
        Me.fiftyButton.Name = "fiftyButton"
        Me.fiftyButton.Size = New System.Drawing.Size(194, 74)
        Me.fiftyButton.TabIndex = 4
        Me.fiftyButton.Text = "50% Upfront Payment"
        Me.fiftyButton.UseVisualStyleBackColor = True
        '
        'twentyButton
        '
        Me.twentyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.twentyButton.Location = New System.Drawing.Point(543, 106)
        Me.twentyButton.Name = "twentyButton"
        Me.twentyButton.Size = New System.Drawing.Size(194, 74)
        Me.twentyButton.TabIndex = 5
        Me.twentyButton.Text = "20 Annual Payments"
        Me.twentyButton.UseVisualStyleBackColor = True
        '
        'resultLabel
        '
        Me.resultLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultLabel.Location = New System.Drawing.Point(37, 192)
        Me.resultLabel.Name = "resultLabel"
        Me.resultLabel.Size = New System.Drawing.Size(113, 45)
        Me.resultLabel.TabIndex = 6
        Me.resultLabel.Text = "Result:"
        '
        'resultText
        '
        Me.resultText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultText.Location = New System.Drawing.Point(42, 230)
        Me.resultText.Multiline = True
        Me.resultText.Name = "resultText"
        Me.resultText.ReadOnly = True
        Me.resultText.Size = New System.Drawing.Size(695, 259)
        Me.resultText.TabIndex = 7
        '
        'playButton
        '
        Me.playButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playButton.Location = New System.Drawing.Point(42, 506)
        Me.playButton.Name = "playButton"
        Me.playButton.Size = New System.Drawing.Size(127, 48)
        Me.playButton.TabIndex = 8
        Me.playButton.Text = "Play"
        Me.playButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 594)
        Me.Controls.Add(Me.playButton)
        Me.Controls.Add(Me.resultText)
        Me.Controls.Add(Me.resultLabel)
        Me.Controls.Add(Me.twentyButton)
        Me.Controls.Add(Me.fiftyButton)
        Me.Controls.Add(Me.optionLabel)
        Me.Controls.Add(Me.betweenLabel)
        Me.Controls.Add(Me.luckyNumberText)
        Me.Controls.Add(Me.enterLabel)
        Me.Name = "Form1"
        Me.Text = "Lottery Simulation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents enterLabel As Label
    Friend WithEvents luckyNumberText As TextBox
    Friend WithEvents betweenLabel As Label
    Friend WithEvents optionLabel As Label
    Friend WithEvents fiftyButton As Button
    Friend WithEvents twentyButton As Button
    Friend WithEvents resultLabel As Label
    Friend WithEvents resultText As TextBox
    Friend WithEvents playButton As Button
End Class
