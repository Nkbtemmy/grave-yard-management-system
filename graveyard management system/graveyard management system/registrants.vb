Public Class registrants
    Dim Id As String = Nothing
    Public Sub New(ByRef Id As String)

        ' This call is required by the designer.
        InitializeComponent()
        Me.Id = Id
        ' Add any initialization after the InitializeComponent() call.

    End Sub
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


    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        about.Show()
        Me.Hide()
    End Sub


End Class