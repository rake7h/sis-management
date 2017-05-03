Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        OpenFileDialog1.Filter = "All Picture Files|*.jpg;*.gif;*.bmp;*.wmf;*.ico|JPEG Images(*.jpg)|*.jpg|Bitmap Images (*.bmp)|*.bmp|Word Meta Files (*.wmf)|*.wmf|GIF Images (*.gif)|*.gif"

        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then

            PictureBox1.ImageLocation = OpenFileDialog1.FileName
            PictureBox1.Name = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiChildren

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class