Public Class dead_people
    Private Sub RegistrantsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrantsToolStripMenuItem.Click
        'registrants.Show()
        Me.Hide()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub RepresenterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RepresenterToolStripMenuItem.Click
        represent.Show()
        Me.Hide()
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        about.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim query As String = String.Empty
        Dim fisrtName As String = fname.Text
        Dim secondName As String = sname.Text
        Dim dateOfBirth As String = dob.Text.ToString()
        Dim dateOfDeath As String = dod.Text.ToString()
        Dim gender As String = ComboBox1.SelectedItem.ToString()
        Dim rep_ID As String = 1
        Dim reg_ID As String = 1


        query &= "INSERT INTO DEAD_PEOPLE (First_name,Second_name,Date_of_birth,Date_of_Death,Gender,Rep_id,Reg_id)"
        query &= "VALUES (@firstName,@secondName,@dateOfBirth,@dateOfDeath,@gender,@rep_ID,@req_ID)"

        With cm
            .Connection = cn
            .CommandType = CommandType.Text
            .CommandText = query
            ' .Parameters.AddWithValue("@C_Name", compname)
            '.Parameters.AddWithValue("@Serial_number", compSerial)
            'arameters.AddWithValue("@Student_Reg", registregno)

        End With

        Try
            '''If (crname.Text <> Nothing And regno.Text <> Nothing And crserial.Text <> Nothing) Then
            cm.ExecuteNonQuery()
                MsgBox("Well Inserted")
            '   View()
            ''serial.Clear()
            '  crname.Clear()
            ''regno.Clear()


            'Else
            MsgBox("Please fill all info")
            '''End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error Message")
        End Try
    End Sub

    Private Sub dead_people_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        View()
    End Sub
    Private Sub View()
        Try
            Dim sql As String
            cm = New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            sql = "Select * from dead_people"
            cm.Connection = cn
            cm.CommandText = sql
            da.SelectCommand = cm

            da.Fill(dt)

            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dob.ValueChanged

    End Sub
End Class