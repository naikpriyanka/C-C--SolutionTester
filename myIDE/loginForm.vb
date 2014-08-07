Imports System.Data.OleDb
Public Class loginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim tableName As String = "username_password"
        Dim query As String = "select password from username_password where username = """ & UsernameTextBox.Text & """;"
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Priyanka\Documents\Questions.accdb;"

        Dim ds As New DataSet

        Dim cnn As OleDbConnection = New OleDbConnection(connString)
        cnn.Open()

        Dim cmd As New OleDbCommand(query, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, tableName)
        cnn.Close()

        Dim d1 As DataTable = ds.Tables(tableName)

        If d1.Rows.Count > 0 Then

            If (d1.Rows(0)(0) = PasswordTextBox.Text) Then
                Me.Hide()
                If (UsernameTextBox.Text = "admin") Then
                    adminForm.Show()
                Else
                    problemForm.Show()
                    problemForm.RandomProblem()
                End If
            Else
                MsgBox("Invalid Password", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("User Not Found", MsgBoxStyle.Critical)
        End If

        

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Public Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""
        Dim tableName As String = "prob"
        Dim query As String = "select * from prob"
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Priyanka\Documents\Questions.accdb;"

        Dim ds As New DataSet

        Dim cnn As OleDbConnection = New OleDbConnection(connString)
        cnn.Open()

        Dim cmd As New OleDbCommand(query, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, tableName)
        cnn.Close()

        Dim d1 As DataTable = ds.Tables(tableName)

        'TextBox1.Text = d1.Rows(0)(0)
    End Sub

    Private Sub MessageBox(ByVal p1 As String)
        Throw New NotImplementedException
    End Sub

End Class
