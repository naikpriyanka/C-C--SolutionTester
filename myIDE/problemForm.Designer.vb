<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class problemForm
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
        Me.definition = New System.Windows.Forms.RichTextBox()
        Me.letsCode = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.constraint = New System.Windows.Forms.RichTextBox()
        Me.pr_title = New System.Windows.Forms.RichTextBox()
        Me.difficulty = New System.Windows.Forms.RichTextBox()
        Me.pr_code = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.input = New System.Windows.Forms.RichTextBox()
        Me.output = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.pr_number = New System.Windows.Forms.RichTextBox()
        Me.points = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nextProblem = New System.Windows.Forms.Button()
        Me.code = New System.Windows.Forms.RichTextBox()
        Me.backProblem = New System.Windows.Forms.Button()
        Me.testRun = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'definition
        '
        Me.definition.BackColor = System.Drawing.Color.White
        Me.definition.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.definition.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.definition.Location = New System.Drawing.Point(268, 151)
        Me.definition.Margin = New System.Windows.Forms.Padding(4)
        Me.definition.Name = "definition"
        Me.definition.ReadOnly = True
        Me.definition.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.definition.Size = New System.Drawing.Size(928, 641)
        Me.definition.TabIndex = 0
        Me.definition.Text = ""
        '
        'letsCode
        '
        Me.letsCode.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.letsCode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.letsCode.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.letsCode.FlatAppearance.BorderSize = 5
        Me.letsCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.letsCode.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.letsCode.ForeColor = System.Drawing.Color.MintCream
        Me.letsCode.Location = New System.Drawing.Point(16, 151)
        Me.letsCode.Margin = New System.Windows.Forms.Padding(4)
        Me.letsCode.Name = "letsCode"
        Me.letsCode.Size = New System.Drawing.Size(244, 78)
        Me.letsCode.TabIndex = 1
        Me.letsCode.Text = "Let's Code Now!"
        Me.letsCode.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.Button2.FlatAppearance.BorderSize = 5
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.MintCream
        Me.Button2.Location = New System.Drawing.Point(16, 238)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(244, 78)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = " Show Me All the Problems"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.Button3.FlatAppearance.BorderSize = 5
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.MintCream
        Me.Button3.Location = New System.Drawing.Point(16, 324)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(244, 78)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Take Me to My Profile"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(750, 13)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Difficulty"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Location = New System.Drawing.Point(750, 77)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Pr. Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label4.Location = New System.Drawing.Point(140, 14)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Problem Title"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label5.Location = New System.Drawing.Point(1201, 354)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(210, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "See, This is How Input will Look"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label6.Location = New System.Drawing.Point(1201, 124)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(187, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Have a Look At Constraints"
        '
        'constraint
        '
        Me.constraint.BackColor = System.Drawing.Color.White
        Me.constraint.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.constraint.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.constraint.Location = New System.Drawing.Point(1205, 151)
        Me.constraint.Margin = New System.Windows.Forms.Padding(4)
        Me.constraint.Name = "constraint"
        Me.constraint.ReadOnly = True
        Me.constraint.Size = New System.Drawing.Size(363, 199)
        Me.constraint.TabIndex = 17
        Me.constraint.Text = ""
        '
        'pr_title
        '
        Me.pr_title.BackColor = System.Drawing.Color.White
        Me.pr_title.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.pr_title.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pr_title.Location = New System.Drawing.Point(268, 13)
        Me.pr_title.Margin = New System.Windows.Forms.Padding(4)
        Me.pr_title.Name = "pr_title"
        Me.pr_title.ReadOnly = True
        Me.pr_title.Size = New System.Drawing.Size(480, 107)
        Me.pr_title.TabIndex = 18
        Me.pr_title.Text = ""
        '
        'difficulty
        '
        Me.difficulty.BackColor = System.Drawing.Color.White
        Me.difficulty.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.difficulty.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.difficulty.Location = New System.Drawing.Point(837, 14)
        Me.difficulty.Margin = New System.Windows.Forms.Padding(4)
        Me.difficulty.Name = "difficulty"
        Me.difficulty.ReadOnly = True
        Me.difficulty.Size = New System.Drawing.Size(147, 46)
        Me.difficulty.TabIndex = 19
        Me.difficulty.Text = ""
        '
        'pr_code
        '
        Me.pr_code.BackColor = System.Drawing.Color.White
        Me.pr_code.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.pr_code.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pr_code.Location = New System.Drawing.Point(839, 77)
        Me.pr_code.Margin = New System.Windows.Forms.Padding(4)
        Me.pr_code.Name = "pr_code"
        Me.pr_code.ReadOnly = True
        Me.pr_code.Size = New System.Drawing.Size(145, 46)
        Me.pr_code.TabIndex = 21
        Me.pr_code.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label9.Location = New System.Drawing.Point(992, 78)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 18)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Pr. No."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label10.Location = New System.Drawing.Point(992, 14)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 18)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Points"
        '
        'input
        '
        Me.input.BackColor = System.Drawing.Color.White
        Me.input.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.input.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input.Location = New System.Drawing.Point(1205, 382)
        Me.input.Margin = New System.Windows.Forms.Padding(4)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(366, 212)
        Me.input.TabIndex = 26
        Me.input.Text = ""
        '
        'output
        '
        Me.output.BackColor = System.Drawing.Color.White
        Me.output.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.output.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.output.Location = New System.Drawing.Point(1208, 625)
        Me.output.Margin = New System.Windows.Forms.Padding(4)
        Me.output.Name = "output"
        Me.output.Size = New System.Drawing.Size(366, 215)
        Me.output.TabIndex = 28
        Me.output.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label7.Location = New System.Drawing.Point(1201, 598)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(195, 18)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "And, This is What We Expect"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button4.Location = New System.Drawing.Point(41, 933)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(244, 78)
        Me.Button4.TabIndex = 29
        Me.Button4.Text = "Show Me Next Problem"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button5.Location = New System.Drawing.Point(41, 1019)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(244, 78)
        Me.Button5.TabIndex = 30
        Me.Button5.Text = "Wait, Show Me the Previous One"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'pr_number
        '
        Me.pr_number.BackColor = System.Drawing.Color.White
        Me.pr_number.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.pr_number.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pr_number.Location = New System.Drawing.Point(1061, 74)
        Me.pr_number.Margin = New System.Windows.Forms.Padding(4)
        Me.pr_number.Name = "pr_number"
        Me.pr_number.ReadOnly = True
        Me.pr_number.Size = New System.Drawing.Size(135, 46)
        Me.pr_number.TabIndex = 32
        Me.pr_number.Text = ""
        '
        'points
        '
        Me.points.BackColor = System.Drawing.Color.White
        Me.points.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.points.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.points.Location = New System.Drawing.Point(1059, 11)
        Me.points.Margin = New System.Windows.Forms.Padding(4)
        Me.points.Name = "points"
        Me.points.ReadOnly = True
        Me.points.Size = New System.Drawing.Size(137, 46)
        Me.points.TabIndex = 31
        Me.points.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(264, 124)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 18)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Problem Statement"
        '
        'nextProblem
        '
        Me.nextProblem.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.nextProblem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nextProblem.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.nextProblem.FlatAppearance.BorderSize = 5
        Me.nextProblem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.nextProblem.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextProblem.ForeColor = System.Drawing.Color.MintCream
        Me.nextProblem.Location = New System.Drawing.Point(923, 802)
        Me.nextProblem.Margin = New System.Windows.Forms.Padding(4)
        Me.nextProblem.Name = "nextProblem"
        Me.nextProblem.Size = New System.Drawing.Size(273, 40)
        Me.nextProblem.TabIndex = 35
        Me.nextProblem.Text = "Amm... No, Next Please..."
        Me.nextProblem.UseVisualStyleBackColor = False
        '
        'code
        '
        Me.code.AcceptsTab = True
        Me.code.BackColor = System.Drawing.Color.White
        Me.code.BulletIndent = 5
        Me.code.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.code.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.code.Location = New System.Drawing.Point(269, 151)
        Me.code.Margin = New System.Windows.Forms.Padding(4)
        Me.code.Name = "code"
        Me.code.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.code.Size = New System.Drawing.Size(928, 641)
        Me.code.TabIndex = 37
        Me.code.Text = "#include<iostream>" & Global.Microsoft.VisualBasic.ChrW(10) & "#include<stdio.h>" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "int main()" & Global.Microsoft.VisualBasic.ChrW(10) & "{" & Global.Microsoft.VisualBasic.ChrW(10) & "    return 0;" & Global.Microsoft.VisualBasic.ChrW(10) & "}"
        '
        'backProblem
        '
        Me.backProblem.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.backProblem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.backProblem.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.backProblem.FlatAppearance.BorderSize = 5
        Me.backProblem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.backProblem.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backProblem.ForeColor = System.Drawing.Color.MintCream
        Me.backProblem.Location = New System.Drawing.Point(16, 151)
        Me.backProblem.Margin = New System.Windows.Forms.Padding(4)
        Me.backProblem.Name = "backProblem"
        Me.backProblem.Size = New System.Drawing.Size(244, 78)
        Me.backProblem.TabIndex = 38
        Me.backProblem.Text = "Show Me the Problem Again"
        Me.backProblem.UseVisualStyleBackColor = False
        '
        'testRun
        '
        Me.testRun.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.testRun.Cursor = System.Windows.Forms.Cursors.Hand
        Me.testRun.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.testRun.FlatAppearance.BorderSize = 5
        Me.testRun.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.testRun.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.testRun.ForeColor = System.Drawing.Color.MintCream
        Me.testRun.Location = New System.Drawing.Point(923, 802)
        Me.testRun.Margin = New System.Windows.Forms.Padding(4)
        Me.testRun.Name = "testRun"
        Me.testRun.Size = New System.Drawing.Size(273, 40)
        Me.testRun.TabIndex = 39
        Me.testRun.Text = "I think Its' Done... Test it..."
        Me.testRun.UseVisualStyleBackColor = False
        '
        'problemForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(1376, 755)
        Me.Controls.Add(Me.testRun)
        Me.Controls.Add(Me.backProblem)
        Me.Controls.Add(Me.code)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nextProblem)
        Me.Controls.Add(Me.pr_number)
        Me.Controls.Add(Me.points)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.output)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.input)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.pr_code)
        Me.Controls.Add(Me.difficulty)
        Me.Controls.Add(Me.pr_title)
        Me.Controls.Add(Me.constraint)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.letsCode)
        Me.Controls.Add(Me.definition)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(2143, 1188)
        Me.MinimizeBox = False
        Me.Name = "problemForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "myIDE For C/C++ Problem Window"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents definition As System.Windows.Forms.RichTextBox
    Friend WithEvents letsCode As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents constraint As System.Windows.Forms.RichTextBox
    Friend WithEvents pr_title As System.Windows.Forms.RichTextBox
    Friend WithEvents difficulty As System.Windows.Forms.RichTextBox
    Friend WithEvents pr_code As System.Windows.Forms.RichTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents input As System.Windows.Forms.RichTextBox
    Friend WithEvents output As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents pr_number As System.Windows.Forms.RichTextBox
    Friend WithEvents points As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nextProblem As System.Windows.Forms.Button
    Friend WithEvents code As System.Windows.Forms.RichTextBox
    Friend WithEvents backProblem As System.Windows.Forms.Button
    Friend WithEvents testRun As System.Windows.Forms.Button

End Class
