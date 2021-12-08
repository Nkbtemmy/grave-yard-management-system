Public Class about


    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub RepresenterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RepresenterToolStripMenuItem.Click
        represent.Show()
        Me.Hide()
    End Sub

    Private Sub DeadPeopleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeadPeopleToolStripMenuItem.Click
        dead_people.Show()
        Me.Hide()
    End Sub

    Private Sub RegistrantsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrantsToolStripMenuItem.Click
        frmRegistrant.Show()
        Me.Hide()
    End Sub




End Class