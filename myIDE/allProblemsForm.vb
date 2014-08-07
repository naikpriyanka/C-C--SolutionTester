Imports System.Data.OleDb

Public Class allProblemsForm

    Private Sub allProblemsForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'problemForm.Show()
        'Me.Hide()
        'Me.Close()
    End Sub

    Public Sub allProblemsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tableName As String = "problem_statement"
        Dim query As String = "select pr_number,pr_code,pr_title,difficulty,points from problem_statement;"
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Sony\Documents\Questions.accdb;"

        Dim ds As New DataSet

        Dim cnn As OleDbConnection = New OleDbConnection(connString)

        Dim cmd As New OleDbCommand(query, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        cnn.Open()
        da.Fill(ds, tableName)

        Dim d1 As DataTable = ds.Tables(tableName)

        DataGridView1.DataSource = d1
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()


        DataGridView1.DataSource = ds.Tables(tableName)

        cnn.Close()

    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick


        Dim r, id As Integer
        r = DataGridView1.CurrentCell.RowIndex
        id = Convert.ToInt32(DataGridView1(0, r).Value)
        Me.Hide()
        Me.Close()
        problemForm.Show()
        problemForm.ParticularProblem(id)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Me.Close()
        problemForm.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class