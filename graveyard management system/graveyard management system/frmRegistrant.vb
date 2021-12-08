Public Class frmRegistrant
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String = String.Empty
        Dim firstName As String = TextBox1.Text
        Dim secondName As String = TextBox2.Text
        Dim email As String = TextBox3.Text
        Dim password As String = TextBox4.Text
        Dim confirmPassword As String = TextBox5.Text

        If (password <> confirmPassword) Then
            MsgBox("Passwords must much")
        Else

            query &= "INSERT INTO Registrants(First_Name,Second_Name,Email,Password)"
            query &= "VALUES (@firstName,@secondName,@email,@password)"

            cm = New OleDb.OleDbCommand

            With cm
                .Connection = cn
                .CommandType = CommandType.Text
                .CommandText = query
                .Parameters.AddWithValue("@firstName", firstName)
                .Parameters.AddWithValue("@secondName", secondName)
                .Parameters.AddWithValue("@email", email)
                .Parameters.AddWithValue("@password", password)
            End With

            Try
                If (firstName <> Nothing And secondName <> Nothing And email <> Nothing And password <> Nothing) Then
                    cm.ExecuteNonQuery()
                    MsgBox("Well Inserted")
                    View()
                    TextBox1.Clear()
                    TextBox2.Clear()
                    TextBox3.Clear()
                    TextBox4.Clear()
                Else
                    MsgBox("Please fill all info")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString(), "Error Message")
            End Try
        End If
    End Sub
    Private Sub View()
        Try
            Dim sql As String
            cm = New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            sql = "Select * from Registrants"
            cm.Connection = cn
            cm.CommandText = sql
            da.SelectCommand = cm

            da.Fill(dt)
            'MsgBox(da)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub

    Private Sub frmRegistrant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        View()
    End Sub
End Class