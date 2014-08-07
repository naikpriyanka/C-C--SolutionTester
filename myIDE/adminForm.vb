Imports System.Data.OleDb
Public Class adminForm

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim tableName As String = "problem_statement"

        Dim maxQuery As String = "select max(Pr_number) from problem_statement;"
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Sony\Documents\Questions.accdb;"
        Dim ds As New DataSet

        Dim cnn As OleDbConnection = New OleDbConnection(connString)
        cnn.Open()

       


        Dim cmd1 As New OleDbCommand(maxQuery, cnn)
        Dim cnt As Integer = Convert.ToInt32(cmd1.ExecuteScalar())

        Dim query As String = "insert into problem_statement values( """ & cnt + 1 & _
       """,""" & pr_code.Text & _
       """,""" & title.Text & _
       """,""" & difficulty.Text & _
       """,""" & points.Text & _
       """,""" & problem_statement.Text & _
       """,""" & constraint.Text & _
       """,""" & input.Text & _
       """,""" & output.Text & """);"



        Dim cmd As New OleDbCommand(query, cnn)
        cmd.ExecuteNonQuery()

        MsgBox("Successfully Inserted!!")
        pr_code.Text = ""
        title.Text = ""
        difficulty.Text = ""
        points.Text = ""
        problem_statement.Text = ""
        constraint.Text = ""
        input.Text = ""
        output.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub
End Class