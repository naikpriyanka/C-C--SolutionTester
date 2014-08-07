<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminForm
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
        Me.Button6 = New System.Windows.Forms.Button()
        Me.points = New System.Windows.Forms.RichTextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.output = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.input = New System.Windows.Forms.RichTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pr_code = New System.Windows.Forms.RichTextBox()
        Me.difficulty = New System.Windows.Forms.RichTextBox()
        Me.title = New System.Windows.Forms.RichTextBox()
        Me.constraint = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.problem_statement = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(252, 121)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 23)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Problem Statement"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.Button6.FlatAppearance.BorderSize = 5
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.MintCream
        Me.Button6.Location = New System.Drawing.Point(911, 797)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(273, 40)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Insert"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'points
        '
        Me.points.BackColor = System.Drawing.Color.White
        Me.points.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.points.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.points.Location = New System.Drawing.Point(1047, 8)
        Me.points.Margin = New System.Windows.Forms.Padding(4)
        Me.points.Name = "points"
        Me.points.Size = New System.Drawing.Size(137, 46)
        Me.points.TabIndex = 8
        Me.points.Text = ""
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button5.Location = New System.Drawing.Point(29, 1016)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(244, 78)
        Me.Button5.TabIndex = 56
        Me.Button5.Text = "Wait, Show Me the Previous One"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'output
        '
        Me.output.BackColor = System.Drawing.Color.White
        Me.output.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.output.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.output.Location = New System.Drawing.Point(1196, 622)
        Me.output.Margin = New System.Windows.Forms.Padding(4)
        Me.output.Name = "output"
        Me.output.Size = New System.Drawing.Size(366, 215)
        Me.output.TabIndex = 5
        Me.output.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label7.Location = New System.Drawing.Point(1189, 595)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 23)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Output"
        '
        'input
        '
        Me.input.BackColor = System.Drawing.Color.White
        Me.input.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.input.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input.Location = New System.Drawing.Point(1193, 379)
        Me.input.Margin = New System.Windows.Forms.Padding(4)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(366, 212)
        Me.input.TabIndex = 4
        Me.input.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label10.Location = New System.Drawing.Point(980, 11)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 23)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Points"
        '
        'pr_code
        '
        Me.pr_code.BackColor = System.Drawing.Color.White
        Me.pr_code.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.pr_code.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pr_code.Location = New System.Drawing.Point(827, 74)
        Me.pr_code.Margin = New System.Windows.Forms.Padding(4)
        Me.pr_code.Name = "pr_code"
        Me.pr_code.Size = New System.Drawing.Size(145, 46)
        Me.pr_code.TabIndex = 7
        Me.pr_code.Text = ""
        '
        'difficulty
        '
        Me.difficulty.BackColor = System.Drawing.Color.White
        Me.difficulty.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.difficulty.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.difficulty.Location = New System.Drawing.Point(825, 11)
        Me.difficulty.Margin = New System.Windows.Forms.Padding(4)
        Me.difficulty.Name = "difficulty"
        Me.difficulty.Size = New System.Drawing.Size(147, 46)
        Me.difficulty.TabIndex = 6
        Me.difficulty.Text = ""
        '
        'title
        '
        Me.title.BackColor = System.Drawing.Color.White
        Me.title.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.title.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(256, 10)
        Me.title.Margin = New System.Windows.Forms.Padding(4)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(480, 107)
        Me.title.TabIndex = 1
        Me.title.Text = ""
        '
        'constraint
        '
        Me.constraint.BackColor = System.Drawing.Color.White
        Me.constraint.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.constraint.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.constraint.Location = New System.Drawing.Point(1193, 148)
        Me.constraint.Margin = New System.Windows.Forms.Padding(4)
        Me.constraint.Name = "constraint"
        Me.constraint.Size = New System.Drawing.Size(363, 199)
        Me.constraint.TabIndex = 3
        Me.constraint.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label6.Location = New System.Drawing.Point(1189, 121)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Constraints"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label5.Location = New System.Drawing.Point(1189, 351)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 23)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Input"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label4.Location = New System.Drawing.Point(128, 11)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 23)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Problem Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Location = New System.Drawing.Point(738, 74)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 23)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Pr. Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(738, 10)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 23)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Difficulty"
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
        Me.Button2.Location = New System.Drawing.Point(5, 148)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(244, 78)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "All Problems till Now"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'problem_statement
        '
        Me.problem_statement.AcceptsTab = True
        Me.problem_statement.AutoWordSelection = True
        Me.problem_statement.BackColor = System.Drawing.Color.White
        Me.problem_statement.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.problem_statement.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.problem_statement.Location = New System.Drawing.Point(257, 148)
        Me.problem_statement.Margin = New System.Windows.Forms.Padding(4)
        Me.problem_statement.Name = "problem_statement"
        Me.problem_statement.Size = New System.Drawing.Size(928, 641)
        Me.problem_statement.TabIndex = 2
        Me.problem_statement.Text = ""
        '
        'adminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(1574, 847)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.points)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.output)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.input)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.pr_code)
        Me.Controls.Add(Me.difficulty)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.constraint)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.problem_statement)
        Me.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "adminForm"
        Me.Text = "myIDE For C/C++ Admin Window"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents points As System.Windows.Forms.RichTextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents output As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents input As System.Windows.Forms.RichTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents pr_code As System.Windows.Forms.RichTextBox
    Friend WithEvents difficulty As System.Windows.Forms.RichTextBox
    Friend WithEvents title As System.Windows.Forms.RichTextBox
    Friend WithEvents constraint As System.Windows.Forms.RichTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents problem_statement As System.Windows.Forms.RichTextBox
End Class
