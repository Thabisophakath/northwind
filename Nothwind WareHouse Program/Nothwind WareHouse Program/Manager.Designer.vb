<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtBatchNo = New System.Windows.Forms.TextBox()
        Me.txtDiscription = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.Label()
        Me.txtIDNumber = New System.Windows.Forms.Label()
        Me.txtEmployeeSurname = New System.Windows.Forms.Label()
        Me.txtEmployeeName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtJobDiscription = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LoginDeatailsDataSet2 = New Nothwind_WareHouse_Program.LoginDeatailsDataSet2()
        Me.ManagerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ManagerTableAdapter = New Nothwind_WareHouse_Program.LoginDeatailsDataSet2TableAdapters.ManagerTableAdapter()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeSurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobDiscriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginDeatailsDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManagerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(987, 483)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Northwind "
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(613, 115)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(195, 20)
        Me.txtDate.TabIndex = 26
        '
        'txtBatchNo
        '
        Me.txtBatchNo.Location = New System.Drawing.Point(613, 77)
        Me.txtBatchNo.Name = "txtBatchNo"
        Me.txtBatchNo.Size = New System.Drawing.Size(195, 20)
        Me.txtBatchNo.TabIndex = 25
        '
        'txtDiscription
        '
        Me.txtDiscription.Location = New System.Drawing.Point(165, 152)
        Me.txtDiscription.Multiline = True
        Me.txtDiscription.Name = "txtDiscription"
        Me.txtDiscription.Size = New System.Drawing.Size(195, 20)
        Me.txtDiscription.TabIndex = 24
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(165, 112)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(195, 20)
        Me.txtProductName.TabIndex = 23
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Location = New System.Drawing.Point(165, 77)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(195, 20)
        Me.txtEmployeeID.TabIndex = 22
        '
        'txtStatus
        '
        Me.txtStatus.AutoSize = True
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(493, 115)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(43, 13)
        Me.txtStatus.TabIndex = 21
        Me.txtStatus.Text = "Status"
        '
        'txtIDNumber
        '
        Me.txtIDNumber.AutoSize = True
        Me.txtIDNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDNumber.Location = New System.Drawing.Point(493, 80)
        Me.txtIDNumber.Name = "txtIDNumber"
        Me.txtIDNumber.Size = New System.Drawing.Size(67, 13)
        Me.txtIDNumber.TabIndex = 20
        Me.txtIDNumber.Text = "ID Number"
        '
        'txtEmployeeSurname
        '
        Me.txtEmployeeSurname.AutoSize = True
        Me.txtEmployeeSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeSurname.Location = New System.Drawing.Point(44, 155)
        Me.txtEmployeeSurname.Name = "txtEmployeeSurname"
        Me.txtEmployeeSurname.Size = New System.Drawing.Size(114, 13)
        Me.txtEmployeeSurname.TabIndex = 19
        Me.txtEmployeeSurname.Text = "Employee Surname"
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.AutoSize = True
        Me.txtEmployeeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeName.Location = New System.Drawing.Point(44, 115)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.Size = New System.Drawing.Size(97, 13)
        Me.txtEmployeeName.TabIndex = 18
        Me.txtEmployeeName.Text = "Employee Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Employee ID"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(613, 152)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(195, 20)
        Me.TextBox1.TabIndex = 28
        '
        'txtJobDiscription
        '
        Me.txtJobDiscription.AutoSize = True
        Me.txtJobDiscription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJobDiscription.Location = New System.Drawing.Point(493, 152)
        Me.txtJobDiscription.Name = "txtJobDiscription"
        Me.txtJobDiscription.Size = New System.Drawing.Size(91, 13)
        Me.txtJobDiscription.TabIndex = 27
        Me.txtJobDiscription.Text = "Job Discription"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(158, 235)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 23)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Add New Employee"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(340, 235)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 23)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "Update "
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(527, 235)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(144, 23)
        Me.Button4.TabIndex = 31
        Me.Button4.Text = "Search"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(903, 85)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(144, 23)
        Me.Button5.TabIndex = 32
        Me.Button5.Text = "Warehouse"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(903, 142)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(144, 23)
        Me.Button6.TabIndex = 33
        Me.Button6.Text = "Register New User"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(722, 235)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(120, 23)
        Me.Button7.TabIndex = 34
        Me.Button7.Text = "Refresh"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeIDDataGridViewTextBoxColumn, Me.EmployeeNameDataGridViewTextBoxColumn, Me.EmployeeSurnameDataGridViewTextBoxColumn, Me.IDNumberDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.JobDiscriptionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ManagerBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(47, 279)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(967, 198)
        Me.DataGridView1.TabIndex = 35
        '
        'LoginDeatailsDataSet2
        '
        Me.LoginDeatailsDataSet2.DataSetName = "LoginDeatailsDataSet2"
        Me.LoginDeatailsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ManagerBindingSource
        '
        Me.ManagerBindingSource.DataMember = "Manager"
        Me.ManagerBindingSource.DataSource = Me.LoginDeatailsDataSet2
        '
        'ManagerTableAdapter
        '
        Me.ManagerTableAdapter.ClearBeforeFill = True
        '
        'EmployeeIDDataGridViewTextBoxColumn
        '
        Me.EmployeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.HeaderText = "Employee ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.Name = "EmployeeIDDataGridViewTextBoxColumn"
        Me.EmployeeIDDataGridViewTextBoxColumn.Width = 200
        '
        'EmployeeNameDataGridViewTextBoxColumn
        '
        Me.EmployeeNameDataGridViewTextBoxColumn.DataPropertyName = "Employee Name"
        Me.EmployeeNameDataGridViewTextBoxColumn.HeaderText = "Employee Name"
        Me.EmployeeNameDataGridViewTextBoxColumn.Name = "EmployeeNameDataGridViewTextBoxColumn"
        Me.EmployeeNameDataGridViewTextBoxColumn.Width = 200
        '
        'EmployeeSurnameDataGridViewTextBoxColumn
        '
        Me.EmployeeSurnameDataGridViewTextBoxColumn.DataPropertyName = "Employee Surname"
        Me.EmployeeSurnameDataGridViewTextBoxColumn.HeaderText = "Employee Surname"
        Me.EmployeeSurnameDataGridViewTextBoxColumn.Name = "EmployeeSurnameDataGridViewTextBoxColumn"
        Me.EmployeeSurnameDataGridViewTextBoxColumn.Width = 200
        '
        'IDNumberDataGridViewTextBoxColumn
        '
        Me.IDNumberDataGridViewTextBoxColumn.DataPropertyName = "ID Number"
        Me.IDNumberDataGridViewTextBoxColumn.HeaderText = "ID Number"
        Me.IDNumberDataGridViewTextBoxColumn.Name = "IDNumberDataGridViewTextBoxColumn"
        Me.IDNumberDataGridViewTextBoxColumn.Width = 200
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.Width = 200
        '
        'JobDiscriptionDataGridViewTextBoxColumn
        '
        Me.JobDiscriptionDataGridViewTextBoxColumn.DataPropertyName = "Job Discription"
        Me.JobDiscriptionDataGridViewTextBoxColumn.HeaderText = "Job Discription"
        Me.JobDiscriptionDataGridViewTextBoxColumn.Name = "JobDiscriptionDataGridViewTextBoxColumn"
        Me.JobDiscriptionDataGridViewTextBoxColumn.Width = 200
        '
        'Manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1074, 518)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtJobDiscription)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtBatchNo)
        Me.Controls.Add(Me.txtDiscription)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.txtIDNumber)
        Me.Controls.Add(Me.txtEmployeeSurname)
        Me.Controls.Add(Me.txtEmployeeName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Manager"
        Me.Text = "Manager"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginDeatailsDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManagerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents txtBatchNo As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscription As System.Windows.Forms.TextBox
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents txtStatus As System.Windows.Forms.Label
    Friend WithEvents txtIDNumber As System.Windows.Forms.Label
    Friend WithEvents txtEmployeeSurname As System.Windows.Forms.Label
    Friend WithEvents txtEmployeeName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtJobDiscription As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LoginDeatailsDataSet2 As Nothwind_WareHouse_Program.LoginDeatailsDataSet2
    Friend WithEvents ManagerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ManagerTableAdapter As Nothwind_WareHouse_Program.LoginDeatailsDataSet2TableAdapters.ManagerTableAdapter
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeSurnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JobDiscriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
