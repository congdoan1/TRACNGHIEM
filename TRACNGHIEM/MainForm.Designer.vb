<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DA = New System.Data.SqlClient.SqlDataAdapter
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.SinhViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiVaothi = New System.Windows.Forms.ToolStripMenuItem
        Me.GiáoViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiNhapde = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiDangkythi = New System.Windows.Forms.ToolStripMenuItem
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiMH = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiSV = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiGV = New System.Windows.Forms.ToolStripMenuItem
        Me.DS = New TRACNGHIEM.DS
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT MAMH, TENMH" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM Monhoc"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=PC;Initial Catalog=TRAC_NGHIEM;Persist Security Info=True;User ID=sa;" & _
            "Password=tram"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO [Monhoc] ([MAMH], [TENMH]) VALUES (@MAMH, @TENMH);" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SELECT MAMH, TENM" & _
            "H FROM Monhoc WHERE (MAMH = @MAMH)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@MAMH", System.Data.SqlDbType.[Char], 0, "MAMH"), New System.Data.SqlClient.SqlParameter("@TENMH", System.Data.SqlDbType.VarChar, 0, "TENMH")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE [Monhoc] SET [MAMH] = @MAMH, [TENMH] = @TENMH WHERE (([MAMH] = @Original_M" & _
            "AMH) AND ([TENMH] = @Original_TENMH));" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SELECT MAMH, TENMH FROM Monhoc WHERE (MA" & _
            "MH = @MAMH)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@MAMH", System.Data.SqlDbType.[Char], 0, "MAMH"), New System.Data.SqlClient.SqlParameter("@TENMH", System.Data.SqlDbType.VarChar, 0, "TENMH"), New System.Data.SqlClient.SqlParameter("@Original_MAMH", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MAMH", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TENMH", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TENMH", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM [Monhoc] WHERE (([MAMH] = @Original_MAMH) AND ([TENMH] = @Original_TE" & _
            "NMH))"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_MAMH", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MAMH", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TENMH", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TENMH", System.Data.DataRowVersion.Original, Nothing)})
        '
        'DA
        '
        Me.DA.DeleteCommand = Me.SqlDeleteCommand1
        Me.DA.InsertCommand = Me.SqlInsertCommand1
        Me.DA.SelectCommand = Me.SqlSelectCommand1
        Me.DA.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Monhoc", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MAMH", "MAMH"), New System.Data.Common.DataColumnMapping("TENMH", "TENMH")})})
        Me.DA.UpdateCommand = Me.SqlUpdateCommand1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SinhViênToolStripMenuItem, Me.GiáoViênToolStripMenuItem, Me.AdminToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1020, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SinhViênToolStripMenuItem
        '
        Me.SinhViênToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiVaothi})
        Me.SinhViênToolStripMenuItem.Name = "SinhViênToolStripMenuItem"
        Me.SinhViênToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.SinhViênToolStripMenuItem.Text = "Sinh viên"
        '
        'tsmiVaothi
        '
        Me.tsmiVaothi.Name = "tsmiVaothi"
        Me.tsmiVaothi.Size = New System.Drawing.Size(111, 22)
        Me.tsmiVaothi.Text = "Vào thi"
        '
        'GiáoViênToolStripMenuItem
        '
        Me.GiáoViênToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiNhapde, Me.tsmiDangkythi})
        Me.GiáoViênToolStripMenuItem.Name = "GiáoViênToolStripMenuItem"
        Me.GiáoViênToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.GiáoViênToolStripMenuItem.Text = "Giáo viên"
        '
        'tsmiNhapde
        '
        Me.tsmiNhapde.Name = "tsmiNhapde"
        Me.tsmiNhapde.Size = New System.Drawing.Size(134, 22)
        Me.tsmiNhapde.Text = "Nhập đề"
        '
        'tsmiDangkythi
        '
        Me.tsmiDangkythi.Name = "tsmiDangkythi"
        Me.tsmiDangkythi.Size = New System.Drawing.Size(134, 22)
        Me.tsmiDangkythi.Text = "Đăng ký thi"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiMH, Me.tsmiSV, Me.tsmiGV})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'tsmiMH
        '
        Me.tsmiMH.Name = "tsmiMH"
        Me.tsmiMH.Size = New System.Drawing.Size(166, 22)
        Me.tsmiMH.Text = "Quản lý môn học"
        '
        'tsmiSV
        '
        Me.tsmiSV.Name = "tsmiSV"
        Me.tsmiSV.Size = New System.Drawing.Size(166, 22)
        Me.tsmiSV.Text = "Quản lý sinh viên"
        '
        'tsmiGV
        '
        Me.tsmiGV.Name = "tsmiGV"
        Me.tsmiGV.Size = New System.Drawing.Size(166, 22)
        Me.tsmiGV.Text = "Quản lý giáo viên"
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 647)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DA As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DS As TRACNGHIEM.DS
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SinhViênToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiVaothi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GiáoViênToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiNhapde As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiDangkythi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiMH As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiSV As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiGV As System.Windows.Forms.ToolStripMenuItem

End Class
