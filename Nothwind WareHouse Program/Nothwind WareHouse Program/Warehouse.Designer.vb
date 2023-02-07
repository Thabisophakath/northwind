<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Warehouse
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIteamCode = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtDiscription = New System.Windows.Forms.TextBox()
        Me.txtBatchNo = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LoginDeatailsDataSet3 = New Nothwind_WareHouse_Program.LoginDeatailsDataSet3()
        Me.WarehouseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WarehouseTableAdapter = New Nothwind_WareHouse_Program.LoginDeatailsDataSet3TableAdapters.WarehouseTableAdapter()
        Me.IteamCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BatchNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateRecivedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button7 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginDeatailsDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarehouseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(985, 491)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Northwind "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Iteam Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(61, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Product Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(61, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Disciption"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(510, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Batch No"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(510, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Date Recived"
        '
        'txtIteamCode
        '
        Me.txtIteamCode.Location = New System.Drawing.Point(182, 92)
        Me.txtIteamCode.Name = "txtIteamCode"
        Me.txtIteamCode.Size = New System.Drawing.Size(100, 20)
        Me.txtIteamCode.TabIndex = 10
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(182, 127)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(195, 20)
        Me.txtProductName.TabIndex = 11
        '
        'txtDiscription
        '
        Me.txtDiscription.Location = New System.Drawing.Point(182, 167)
        Me.txtDiscription.Multiline = True
        Me.txtDiscription.Name = "txtDiscription"
        Me.txtDiscription.Size = New System.Drawing.Size(195, 43)
        Me.txtDiscription.TabIndex = 12
        '
        'txtBatchNo
        '
        Me.txtBatchNo.Location = New System.Drawing.Point(630, 92)
        Me.txtBatchNo.Name = "txtBatchNo"
        Me.txtBatchNo.Size = New System.Drawing.Size(195, 20)
        Me.txtBatchNo.TabIndex = 13
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(182, 257)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Insert new product"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(630, 130)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(195, 20)
        Me.txtDate.TabIndex = 16
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(378, 257)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 23)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Update "
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(580, 257)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(144, 23)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Search"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IteamCodeDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.DiscriptionDataGridViewTextBoxColumn, Me.BatchNoDataGridViewTextBoxColumn, Me.DateRecivedDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.WarehouseBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(64, 307)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(943, 178)
        Me.DataGridView1.TabIndex = 19
        '
        'LoginDeatailsDataSet3
        '
        Me.LoginDeatailsDataSet3.DataSetName = "LoginDeatailsDataSet3"
        Me.LoginDeatailsDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WarehouseBindingSource
        '
        Me.WarehouseBindingSource.DataMember = "Warehouse"
        Me.WarehouseBindingSource.DataSource = Me.LoginDeatailsDataSet3
        '
        'WarehouseTableAdapter
        '
        Me.WarehouseTableAdapter.ClearBeforeFill = True
        '
        'IteamCodeDataGridViewTextBoxColumn
        '
        Me.IteamCodeDataGridViewTextBoxColumn.DataPropertyName = "Iteam Code"
        Me.IteamCodeDataGridViewTextBoxColumn.HeaderText = "Iteam Code"
        Me.IteamCodeDataGridViewTextBoxColumn.Name = "IteamCodeDataGridViewTextBoxColumn"
        Me.IteamCodeDataGridViewTextBoxColumn.Width = 200
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "Product Name"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "Product Name"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.Width = 200
        '
        'DiscriptionDataGridViewTextBoxColumn
        '
        Me.DiscriptionDataGridViewTextBoxColumn.DataPropertyName = "Discription"
        Me.DiscriptionDataGridViewTextBoxColumn.HeaderText = "Discription"
        Me.DiscriptionDataGridViewTextBoxColumn.Name = "DiscriptionDataGridViewTextBoxColumn"
        Me.DiscriptionDataGridViewTextBoxColumn.Width = 200
        '
        'BatchNoDataGridViewTextBoxColumn
        '
        Me.BatchNoDataGridViewTextBoxColumn.DataPropertyName = "Batch No"
        Me.BatchNoDataGridViewTextBoxColumn.HeaderText = "Batch No"
        Me.BatchNoDataGridViewTextBoxColumn.Name = "BatchNoDataGridViewTextBoxColumn"
        Me.BatchNoDataGridViewTextBoxColumn.Width = 200
        '
        'DateRecivedDataGridViewTextBoxColumn
        '
        Me.DateRecivedDataGridViewTextBoxColumn.DataPropertyName = "Date Recived"
        Me.DateRecivedDataGridViewTextBoxColumn.HeaderText = "Date Recived"
        Me.DateRecivedDataGridViewTextBoxColumn.Name = "DateRecivedDataGridViewTextBoxColumn"
        Me.DateRecivedDataGridViewTextBoxColumn.Width = 200
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(780, 257)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(120, 23)
        Me.Button7.TabIndex = 35
        Me.Button7.Text = "Refresh"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Warehouse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 526)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtBatchNo)
        Me.Controls.Add(Me.txtDiscription)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.txtIteamCode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Warehouse"
        Me.Text = "Warehouse"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginDeatailsDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarehouseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtIteamCode As System.Windows.Forms.TextBox
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscription As System.Windows.Forms.TextBox
    Friend WithEvents txtBatchNo As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LoginDeatailsDataSet3 As Nothwind_WareHouse_Program.LoginDeatailsDataSet3
    Friend WithEvents WarehouseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WarehouseTableAdapter As Nothwind_WareHouse_Program.LoginDeatailsDataSet3TableAdapters.WarehouseTableAdapter
    Friend WithEvents IteamCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiscriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BatchNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateRecivedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button7 As System.Windows.Forms.Button
End Class
