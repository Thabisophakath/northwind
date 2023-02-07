Imports System.Data.OleDb
Public Class Warehouse
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

    Private Sub Warehouse_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LoginDeatailsDataSet3.Warehouse' table. You can move, or remove it, as needed.
        Me.WarehouseTableAdapter.Fill(Me.LoginDeatailsDataSet3.Warehouse)
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=LoginDeatails.mdb"
        sql = "select * from Warehouse"
        da = New OleDbDataAdapter(sql, con)
        da.Fill(ds, "Warehouse")
        inc = 0
    End Sub
    Sub fill()
        txtIteamCode.Text = ds.Tables("Warehouse").Rows(inc).Item(1)
        txtProductName.Text = ds.Tables("Warehouse").Rows(inc).Item(2)
        txtDiscription.Text = ds.Tables("Warehouse").Rows(inc).Item(3)
        txtBatchNo.Text = ds.Tables("Warehouse").Rows(inc).Item(4)
        txtDate.Text = ds.Tables("Warehouse").Rows(inc).Item(5)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim cmd As New OleDbCommand
        cmd.CommandText = "INSERT INTO Warehouse values ('" + txtIteamCode.Text + "', '" + txtProductName.Text + "','" + txtDiscription.Text + "','" + txtBatchNo.Text + "','" + txtDate.Text + "')"
        cmd.Connection = con
        con.Open()
        cmd.ExecuteNonQuery()
        MsgBox("Record inserted into database.")
        con.Close()
    End Sub
    Sub updateTextboxes()
        txtIteamCode.Text = CStr(dt.Rows(inc)("Iteam Code"))
        txtProductName.Text = CStr(dt.Rows(inc)("Product Name"))
        txtDiscription.Text = CStr(dt.Rows(inc)("Discription"))
        txtBatchNo.Text = CStr(dt.Rows(inc)("Batch No"))
        txtDate.Text = CStr(dt.Rows(inc)("Date Recived"))
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim dataadapter As New OleDb.OleDbDataAdapter(sql, con)
        dataadapter.Fill(dt)
        dataadapter.Dispose()
        Dim ProdName As String
        Dim ProdFound As Boolean = False
        ProdName = InputBox("Enter Product Name.")
        For i As Integer = 0 To (dt.Rows.Count - 1)
            If CStr(dt.Rows(i)("Product Name")) = ProdName Then
                ProdFound = True
                inc = i
                updateTextboxes()
            End If
        Next
        If (Not ProdFound) Then MessageBox.Show("cannot find the requested Product")
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        updatagrid("SELECT * from Warehouse")
    End Sub
End Class