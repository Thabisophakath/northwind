Imports System.Data.OleDb
Public Class Form1

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        If MessageBox.Show("Are you sure you want to leave the system?,", "Exit Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        Else
            MessageBox.Show("Thank you, Please continue using the system")
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click

        Dim con As New OleDbConnection
        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand
        Dim rad As String

        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source= LoginDeatails.mdb"
        cmd.Connection = con

        If radAdmin.Checked Then
            rad = "Admin"
        ElseIf radManager.Checked Then
            rad = "Manager"
        ElseIf radWarehouse.Checked Then
            rad = "Warehouse"

        End If

        con.Open()
        cmd.CommandText = "SELECT Username,Password,Catagory FROM Login WHERE Username= '" & txtUsername.Text & "' and Password='" & txtPassword.Text & "' and Catagory ='" & rad & "'"
        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            MessageBox.Show("Welcome" & txtUsername.Text, "Login")
            If rad = "Admin" Then
                Admin.Show()
            ElseIf rad = "Manager" Then
                Manager.Show()
            ElseIf rad = "Warehouse" Then
                Warehouse.Show()
            End If
            Me.Visible = False
            con.Close()
        Else
            MessageBox.Show("Invalid Username or Password", "Credentials")
            txtUsername.Text = ""
            txtPassword.Text = ""
        End If



    End Sub
End Class
