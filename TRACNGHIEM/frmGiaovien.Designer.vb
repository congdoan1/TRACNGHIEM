<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGiaovien
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
        Me.components = New System.ComponentModel.Container
        Dim MAGVLabel As System.Windows.Forms.Label
        Dim HOLabel As System.Windows.Forms.Label
        Dim TENLabel As System.Windows.Forms.Label
        Dim SODTLLLabel As System.Windows.Forms.Label
        Dim DIACHILabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.dgvGV = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bdsGV = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS = New TRACNGHIEM.DS
        Me.txtMAGV = New System.Windows.Forms.TextBox
        Me.txtHO = New System.Windows.Forms.TextBox
        Me.txtTEN = New System.Windows.Forms.TextBox
        Me.txtSODTLL = New System.Windows.Forms.TextBox
        Me.txtDIACHI = New System.Windows.Forms.TextBox
        Me.btnThem = New System.Windows.Forms.Button
        Me.btnHieuchinh = New System.Windows.Forms.Button
        Me.btnGhi = New System.Windows.Forms.Button
        Me.btnTim = New System.Windows.Forms.Button
        Me.btnXoa = New System.Windows.Forms.Button
        Me.btnPhuchoi = New System.Windows.Forms.Button
        Me.GIAOVIENTableAdapter = New TRACNGHIEM.DSTableAdapters.GIAOVIENTableAdapter
        Me.bdsBODE = New System.Windows.Forms.BindingSource(Me.components)
        Me.BODETableAdapter = New TRACNGHIEM.DSTableAdapters.BODETableAdapter
        Me.bdsGIAOVIEN_DANGKY = New System.Windows.Forms.BindingSource(Me.components)
        Me.GIAOVIEN_DANGKYTableAdapter = New TRACNGHIEM.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        MAGVLabel = New System.Windows.Forms.Label
        HOLabel = New System.Windows.Forms.Label
        TENLabel = New System.Windows.Forms.Label
        SODTLLLabel = New System.Windows.Forms.Label
        DIACHILabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        CType(Me.dgvGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsBODE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsGIAOVIEN_DANGKY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MAGVLabel
        '
        MAGVLabel.AutoSize = True
        MAGVLabel.Location = New System.Drawing.Point(31, 33)
        MAGVLabel.Name = "MAGVLabel"
        MAGVLabel.Size = New System.Drawing.Size(83, 16)
        MAGVLabel.TabIndex = 1
        MAGVLabel.Text = "Mã giáo viên:"
        '
        'HOLabel
        '
        HOLabel.AutoSize = True
        HOLabel.Location = New System.Drawing.Point(87, 77)
        HOLabel.Name = "HOLabel"
        HOLabel.Size = New System.Drawing.Size(27, 16)
        HOLabel.TabIndex = 3
        HOLabel.Text = "Họ:"
        '
        'TENLabel
        '
        TENLabel.AutoSize = True
        TENLabel.Location = New System.Drawing.Point(81, 121)
        TENLabel.Name = "TENLabel"
        TENLabel.Size = New System.Drawing.Size(33, 16)
        TENLabel.TabIndex = 5
        TENLabel.Text = "Tên:"
        '
        'SODTLLLabel
        '
        SODTLLLabel.AutoSize = True
        SODTLLLabel.Location = New System.Drawing.Point(248, 77)
        SODTLLLabel.Name = "SODTLLLabel"
        SODTLLLabel.Size = New System.Drawing.Size(92, 16)
        SODTLLLabel.TabIndex = 7
        SODTLLLabel.Text = "Số ĐT liên lạc:"
        '
        'DIACHILabel
        '
        DIACHILabel.AutoSize = True
        DIACHILabel.Location = New System.Drawing.Point(248, 105)
        DIACHILabel.Name = "DIACHILabel"
        DIACHILabel.Size = New System.Drawing.Size(0, 16)
        DIACHILabel.TabIndex = 9
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(289, 121)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(51, 16)
        Label1.TabIndex = 11
        Label1.Text = "Địa chỉ:"
        '
        'dgvGV
        '
        Me.dgvGV.AllowUserToResizeColumns = False
        Me.dgvGV.AllowUserToResizeRows = False
        Me.dgvGV.AutoGenerateColumns = False
        Me.dgvGV.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgvGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.dgvGV.DataSource = Me.bdsGV
        Me.dgvGV.Location = New System.Drawing.Point(71, 261)
        Me.dgvGV.Name = "dgvGV"
        Me.dgvGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvGV.Size = New System.Drawing.Size(743, 188)
        Me.dgvGV.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MAGV"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Mã giáo viên"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "HO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Họ"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TEN"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tên"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "SODTLL"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Số ĐT liên lạc"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DIACHI"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Địa chỉ"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 200
        '
        'bdsGV
        '
        Me.bdsGV.DataMember = "Giaovien"
        Me.bdsGV.DataSource = Me.DS
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtMAGV
        '
        Me.txtMAGV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsGV, "MAGV", True))
        Me.txtMAGV.Location = New System.Drawing.Point(117, 30)
        Me.txtMAGV.Name = "txtMAGV"
        Me.txtMAGV.Size = New System.Drawing.Size(100, 23)
        Me.txtMAGV.TabIndex = 2
        '
        'txtHO
        '
        Me.txtHO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsGV, "HO", True))
        Me.txtHO.Location = New System.Drawing.Point(117, 74)
        Me.txtHO.Name = "txtHO"
        Me.txtHO.Size = New System.Drawing.Size(100, 23)
        Me.txtHO.TabIndex = 4
        '
        'txtTEN
        '
        Me.txtTEN.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsGV, "TEN", True))
        Me.txtTEN.Location = New System.Drawing.Point(117, 118)
        Me.txtTEN.Name = "txtTEN"
        Me.txtTEN.Size = New System.Drawing.Size(100, 23)
        Me.txtTEN.TabIndex = 6
        '
        'txtSODTLL
        '
        Me.txtSODTLL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsGV, "SODTLL", True))
        Me.txtSODTLL.Location = New System.Drawing.Point(343, 74)
        Me.txtSODTLL.Name = "txtSODTLL"
        Me.txtSODTLL.Size = New System.Drawing.Size(132, 23)
        Me.txtSODTLL.TabIndex = 8
        '
        'txtDIACHI
        '
        Me.txtDIACHI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsGV, "DIACHI", True))
        Me.txtDIACHI.Location = New System.Drawing.Point(343, 118)
        Me.txtDIACHI.Name = "txtDIACHI"
        Me.txtDIACHI.Size = New System.Drawing.Size(218, 23)
        Me.txtDIACHI.TabIndex = 10
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(65, 206)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(100, 30)
        Me.btnThem.TabIndex = 11
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnHieuchinh
        '
        Me.btnHieuchinh.Location = New System.Drawing.Point(196, 206)
        Me.btnHieuchinh.Name = "btnHieuchinh"
        Me.btnHieuchinh.Size = New System.Drawing.Size(100, 30)
        Me.btnHieuchinh.TabIndex = 12
        Me.btnHieuchinh.Text = "Hiệu chỉnh"
        Me.btnHieuchinh.UseVisualStyleBackColor = True
        '
        'btnGhi
        '
        Me.btnGhi.Location = New System.Drawing.Point(327, 206)
        Me.btnGhi.Name = "btnGhi"
        Me.btnGhi.Size = New System.Drawing.Size(100, 30)
        Me.btnGhi.TabIndex = 13
        Me.btnGhi.Text = "Ghi"
        Me.btnGhi.UseVisualStyleBackColor = True
        '
        'btnTim
        '
        Me.btnTim.Location = New System.Drawing.Point(458, 206)
        Me.btnTim.Name = "btnTim"
        Me.btnTim.Size = New System.Drawing.Size(100, 30)
        Me.btnTim.TabIndex = 14
        Me.btnTim.Text = "Tìm"
        Me.btnTim.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(589, 206)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(100, 30)
        Me.btnXoa.TabIndex = 15
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnPhuchoi
        '
        Me.btnPhuchoi.Location = New System.Drawing.Point(720, 206)
        Me.btnPhuchoi.Name = "btnPhuchoi"
        Me.btnPhuchoi.Size = New System.Drawing.Size(100, 30)
        Me.btnPhuchoi.TabIndex = 16
        Me.btnPhuchoi.Text = "Phục hồi"
        Me.btnPhuchoi.UseVisualStyleBackColor = True
        '
        'GiaovienTableAdapter
        '
        Me.GiaovienTableAdapter.ClearBeforeFill = True
        '
        'bdsBODE
        '
        Me.bdsBODE.DataMember = "FK_BODE_Giaovien"
        Me.bdsBODE.DataSource = Me.bdsGV
        '
        'BODETableAdapter
        '
        Me.BODETableAdapter.ClearBeforeFill = True
        '
        'bdsGIAOVIEN_DANGKY
        '
        Me.bdsGIAOVIEN_DANGKY.DataMember = "FK_Giaovien_Dangky_Giaovien"
        Me.bdsGIAOVIEN_DANGKY.DataSource = Me.bdsGV
        '
        'GIAOVIEN_DANGKYTableAdapter
        '
        Me.GIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(MAGVLabel)
        Me.GroupBox1.Controls.Add(Me.txtMAGV)
        Me.GroupBox1.Controls.Add(Me.txtHO)
        Me.GroupBox1.Controls.Add(HOLabel)
        Me.GroupBox1.Controls.Add(Me.txtTEN)
        Me.GroupBox1.Controls.Add(TENLabel)
        Me.GroupBox1.Controls.Add(Me.txtSODTLL)
        Me.GroupBox1.Controls.Add(DIACHILabel)
        Me.GroupBox1.Controls.Add(SODTLLLabel)
        Me.GroupBox1.Controls.Add(Me.txtDIACHI)
        Me.GroupBox1.Location = New System.Drawing.Point(147, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(588, 163)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Quản lý giáo viên"
        '
        'frmGiaovien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 461)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnPhuchoi)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnTim)
        Me.Controls.Add(Me.btnGhi)
        Me.Controls.Add(Me.btnHieuchinh)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.dgvGV)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmGiaovien"
        Me.Text = "Quản lý giáo viên"
        CType(Me.dgvGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsBODE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsGIAOVIEN_DANGKY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DS As TRACNGHIEM.DS
    Friend WithEvents bdsGV As System.Windows.Forms.BindingSource
    Friend WithEvents GIAOVIENTableAdapter As TRACNGHIEM.DSTableAdapters.GIAOVIENTableAdapter
    Friend WithEvents dgvGV As System.Windows.Forms.DataGridView
    Friend WithEvents txtMAGV As System.Windows.Forms.TextBox
    Friend WithEvents txtHO As System.Windows.Forms.TextBox
    Friend WithEvents txtTEN As System.Windows.Forms.TextBox
    Friend WithEvents txtSODTLL As System.Windows.Forms.TextBox
    Friend WithEvents txtDIACHI As System.Windows.Forms.TextBox
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnHieuchinh As System.Windows.Forms.Button
    Friend WithEvents btnGhi As System.Windows.Forms.Button
    Friend WithEvents btnTim As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnPhuchoi As System.Windows.Forms.Button
    Friend WithEvents bdsBODE As System.Windows.Forms.BindingSource
    Friend WithEvents BODETableAdapter As TRACNGHIEM.DSTableAdapters.BODETableAdapter
    Friend WithEvents bdsGIAOVIEN_DANGKY As System.Windows.Forms.BindingSource
    Friend WithEvents GIAOVIEN_DANGKYTableAdapter As TRACNGHIEM.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
