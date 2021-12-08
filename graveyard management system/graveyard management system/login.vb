Public Class frmLogin
    Public Id As String = Nothing
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Me.Id = Id
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        frmForget.Show()

        'Dim regist As New registrants(Id)
        'regist.Show()

    End Sub



    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbxPassword.PasswordChar = "*"
        tbxPassword.Text = "admin123"
        tbxEmail.Text = "nkbtemmy2@gmail.com"

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim password As String = tbxPassword.Text
        Dim email As String = tbxEmail.Text
        Dim Id As String
        ' Dim data As New List(Of String)()
        Try
            Dim sql As String
            cm = New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter


            'MsgBox(email)
            sql = "SELECT * FROM Registrants WHERE Email='" & email & "' AND Password='" & password & "'"

            cm.Connection = cn
            cm.CommandText = sql
            da.SelectCommand = cm
            dr = cm.ExecuteReader
            If (dr.Read()) Then
                'MsgBox(dr("RId"))
                Id = dr("RId")
                dead_people.Show()
                Me.Hide()

            Else
                MsgBox("Login Fails")
            End If


            'While dr.Read()
            'Id = dr.GetValue(2)
            'MsgBox("Value: {0}", Id)
            'End While
            'MsgBox(dr.GetValue(1))

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class