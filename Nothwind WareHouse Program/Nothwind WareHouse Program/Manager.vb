Imports System.Data.OleDb
Public Class Manager
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

    Private Sub Manager_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LoginDeatailsDataSet2.Manager' table. You can move, or remove it, as needed.
        Me.ManagerTableAdapter.Fill(Me.LoginDeatailsDataSet2.Manager)

        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=LoginDeatails.mdb"
        sql = "select * from Manager"
        da = New OleDbDataAdapter(sql, con)
        da.Fill(ds, "Manager")
        inc = 0
    End Sub
    Sub fill()
        txtEmployeeID.Text = ds.Tables("Manager").Rows(inc).Item(1)
        txtEmployeeName.Text = ds.Tables("Manager").Rows(inc).Item(2)
        txtEmployeeSurname.Text = ds.Tables("Manager").Rows(inc).Item(3)
        txtIDNumber.Text = ds.Tables("Manager").Rows(inc).Item(4)
        txtStatus.Text = ds.Tables("Manager").Rows(inc).Item(5)
        txtJobDiscription.Text = ds.Tables("Manager").Rows(inc).Item(6)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim cmd As New OleDbCommand
        cmd.CommandText = "INSERT INTO Manager values ('" + txtEmployeeID.Text + "', '" + txtEmployeeName.Text + "','" + txtEmployeeSurname.Text + "','" + txtIDNumber.Text + "','" + txtStatus.Text + "','" + txtJobDiscription.Text + "')"
        cmd.Connection = con
        con.Open()
        cmd.ExecuteNonQuery()
        MsgBox("Record inserted into database.")
        con.Close()
    End Sub
    Sub updateTextboxes()
        txtEmployeeID.Text = CStr(dt.Rows(inc)("Employee ID"))
        txtEmployeeName.Text = CStr(dt.Rows(inc)("Employee Name"))
        txtEmployeeSurname.Text = CStr(dt.Rows(inc)("Employee Surname"))
        txtIDNumber.Text = CStr(dt.Rows(inc)("ID Number"))
        txtStatus.Text = CStr(dt.Rows(inc)("Status"))
        txtDiscription.Text = CStr(dt.Rows(inc)("Job Discription"))
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Warehouse.Show()
        Me.Hide()


    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim dataadapter As New OleDb.OleDbDataAdapter(sql, con)
        dataadapter.Fill(dt)
        dataadapter.Dispose()
        Dim EmployeeName As String
        Dim EmployeeFound As Boolean = False
        EmployeeName = InputBox("Enter Employee Name.")
        For i As Integer = 0 To (dt.Rows.Count - 1)
            If CStr(dt.Rows(i)("Employee Name")) = EmployeeName Then
                EmployeeFound = True
                inc = i
                updateTextboxes()
            End If
        Next
        If (Not EmployeeFound) Then MessageBox.Show("cannot find the requested Member")
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        updatagrid("SELECT * from Manager")
    End Sub
End Class