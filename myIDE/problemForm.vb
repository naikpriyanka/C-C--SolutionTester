Imports System.Data.OleDb
Public Class problemForm

    Private Sub problemForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        loginForm.Show()
        loginForm.LoginForm1_Load(sender, e)
    End Sub

    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        backProblem.Visible = False
        code.Visible = False
        testRun.Visible = False
        Label1.Text = "Problem Statement"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letsCode.Click
        definition.Visible = False
        nextProblem.Visible = False
        letsCode.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        backProblem.Visible = True
        code.Visible = True
        testRun.Visible = True
        Label1.Text = "C/C++ Solution"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        allProblemsForm.Show()
        allProblemsForm.allProblemsForm_Load(sender, e)
    End Sub


    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextProblem.Click
        Me.RandomProblem()
    End Sub

    Public Function RandomProblem()
        Dim tableName As String = "problem_statement"
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Priyanka\Documents\Questions.accdb;"
        Dim maxQuery As String = "select max(Pr_number) from problem_statement;"
        Dim ds As New DataSet

        Dim cnn As OleDbConnection = New OleDbConnection(connString)
        cnn.Open()

        Dim cmd1 As New OleDbCommand(maxQuery, cnn)
        Dim cnt As Integer = Convert.ToInt32(cmd1.ExecuteScalar())
        Dim rows As Integer = CInt(Math.Floor((cnt - 1) * Rnd())) + 1
        Dim query As String = "select top " & rows & " * from problem_statement;"
        Dim cmd As New OleDbCommand(query, cnn)

        Dim da As New OleDbDataAdapter(cmd)


        da.Fill(ds, tableName)
        cnn.Close()

        Dim d1 As DataTable = ds.Tables(tableName)

        Dim i As Integer
        i = d1.Rows.Count - 1
        pr_title.Text = d1.Rows(i)(2)
        pr_number.Text = d1.Rows(i)(0)
        definition.Text = d1.Rows(i)(5)
        pr_code.Text = d1.Rows(i)(1)
        difficulty.Text = d1.Rows(i)(3)
        points.Text = d1.Rows(i)(4)
        constraint.Text = d1.Rows(i)(6)
        input.Text = d1.Rows(i)(7)
        output.Text = d1.Rows(i)(8)
    End Function


    Public Function ParticularProblem(ByVal id As Integer)
        Dim tableName As String = "problem_statement"
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Sony\Documents\Questions.accdb;"
        Dim ds As New DataSet

        Dim cnn As OleDbConnection = New OleDbConnection(connString)
        cnn.Open()

        Dim query As String = "select * from problem_statement where Pr_number = " & id & " ;"
        Dim cmd As New OleDbCommand(query, cnn)

        Dim da As New OleDbDataAdapter(cmd)


        da.Fill(ds, tableName)
        cnn.Close()

        Dim d1 As DataTable = ds.Tables(tableName)

        Dim i As Integer
        i = d1.Rows.Count - 1
        pr_title.Text = d1.Rows(i)(2)
        pr_number.Text = d1.Rows(i)(0)
        definition.Text = d1.Rows(i)(5)
        pr_code.Text = d1.Rows(i)(1)
        difficulty.Text = d1.Rows(i)(3)
        points.Text = d1.Rows(i)(4)
        constraint.Text = d1.Rows(i)(6)
        input.Text = d1.Rows(i)(7)
        output.Text = d1.Rows(i)(8)
    End Function

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backProblem.Click
        definition.Visible = True
        nextProblem.Visible = True
        letsCode.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        backProblem.Visible = False
        code.Visible = False
        testRun.Visible = False
        Label1.Text = "Problem Statement"
    End Sub
    
    Private Sub testRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles testRun.Click
        Dim objWriter As New System.IO.StreamWriter("testcases.txt")
        objWriter.Write(input.Text)
        objWriter.Close()

        Dim objWriter1 As New System.IO.StreamWriter("answer.cpp")
        objWriter1.Write(code.Text)
        objWriter1.Close()

        System.Diagnostics.Process.Start("AutoCompiler.exe")

        consoleForm.Show()
        consoleForm.Form1_Load(sender, e)
    End Sub

    Private Sub input_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles input.TextChanged

    End Sub

    Private Sub output_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles output.TextChanged

    End Sub
End Class
