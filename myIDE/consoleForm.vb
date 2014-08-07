Public Class consoleForm

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim objReader1 As New System.IO.StreamReader("errorLog.txt")
        RichTextBox1.Text = objReader1.ReadToEnd()
        objReader1.Close()

        'MsgBox("Characters:" & RichTextBox1.TextLength)
        If RichTextBox1.TextLength = 0 Then
            Dim objReader As New System.IO.StreamReader("output.txt")
            RichTextBox1.Text = objReader.ReadToEnd()
            objReader.Close()
        End If

    End Sub
End Class