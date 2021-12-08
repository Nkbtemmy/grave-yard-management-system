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
        frmRegistrant.Show()
        Me.Hide()
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        about.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String = String.Empty
        Dim firstName As String = TextBox1.Text
        Dim secondName As String = TextBox2.Text
        Dim nid As String = Val(TextBox3.Text)
        Dim telephone As String = TextBox4.Text
        Dim location As String = TextBox5.Text



        query &= "INSERT INTO Representers (First_Name,Second_Name,Nationalld,Telephone,Location)"
        query &= "VALUES (@firstName,@secondName,@nid,@telephone,@location)"

        cm = New OleDb.OleDbCommand

        With cm
            .Connection = cn
            .CommandType = CommandType.Text
            .CommandText = query
            .Parameters.AddWithValue("@firstName", firstName)
            .Parameters.AddWithValue("@secondName", secondName)
            .Parameters.AddWithValue("@nid", nid)
            .Parameters.AddWithValue("@telephone", telephone)
            .Parameters.AddWithValue("@location", location)
        End With

        Try
            If (firstName <> Nothing And secondName <> Nothing And nid <> Nothing And telephone <> Nothing And location <> Nothing) Then
                cm.ExecuteNonQuery()
                MsgBox("Well Inserted")
                View()
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
            Else
                MsgBox("Please fill all info")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error Message")
        End Try
    End Sub

    Private Sub View()
        Try
            Dim sql As String
            cm = New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            sql = "Select * from representers"
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

    Private Sub represent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        View()
    End Sub
End Class