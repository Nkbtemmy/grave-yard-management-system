Public Class represent
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

        frmLogin.Show()
        Me.Hide()
    End Sub
    Private Sub DeadPeopleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        dead_people.Show()
        Me.Hide()
    End Sub

    Private Sub RegistrantsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        'registrants.Show()
        Me.Hide()
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        about.Show()
        Me.Hide()
    End Sub

    Private Sub represent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class