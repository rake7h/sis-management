Public Class frm2010

    Private Sub SplitContainer1_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub frm2010_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Student2010DataSet.cse' table. You can move, or remove it, as needed.
        Me.CseTableAdapter.Fill(Me.Student2010DataSet.cse)

    End Sub
End Class