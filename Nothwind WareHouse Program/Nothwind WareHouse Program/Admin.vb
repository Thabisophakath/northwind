Imports System.Data.OleDb
Public Class Admin
    Dim inc As Integer = 0
    Dim dt As New DataTable()
    Dim con As New OleDbConnection
    Dim sql As String
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet

    Sub updatagrid(ByVal sqlstr As String)
        Dim dt As New DataTable()
        Dim connstr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=LoginDeatails.mdb"

        Dim dataadapter As New OleDb.OleDbDataAdapter(sqlstr, connstr)

        dataadapter.Fill(dt)
        dataadapter.Dispose()

        If dt.Rows.Count = 0 Then
            MsgBox("No Name in the database")
        Else
            DataGridView1.DataSource = dt

        End If
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("Application Is closing...")
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Admin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=LoginDeatails.mdb"
        sql = "select * from Login"
        da = New OleDbDataAdapter(sql, con)
        da.Fill(ds, "Login")
        inc = 0
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Manager.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        Dim cmd As New OleDbCommand
        cmd.CommandText = "INSERT INTO Login values ('" + txtUsername.Text + "', '" + txtPassword.Text + "','" + txtCatagory.Text + "')"
        cmd.Connection = con
        con.Open()
        cmd.ExecuteNonQuery()
        MsgBox("Record inserted into database.")
        con.Close()
    End Sub
    Sub updateTextboxes()
        txtUsername.Text = CStr(dt.Rows(inc)("Username"))
        txtPassword.Text = CStr(dt.Rows(inc)("Password"))
        txtCatagory.Text = CStr(dt.Rows(inc)("Catagory"))
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        updatagrid("SELECT * from Login")
    End Sub
End Class