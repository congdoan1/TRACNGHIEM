<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLSV
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
        Dim MALOPLabel As System.Windows.Forms.Label
        Dim TENLOPLabel As System.Windows.Forms.Label
        Dim MALOPLabel1 As System.Windows.Forms.Label
        Dim MASVLabel As System.Windows.Forms.Label
        Dim HOLabel As System.Windows.Forms.Label
        Dim TENLabel As System.Windows.Forms.Label
        Dim NGAYSINHLabel As System.Windows.Forms.Label
        Dim DIACHILabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dgvLOP = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bdsLOP = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS = New TRACNGHIEM.DS
        Me.txtMALOP = New System.Windows.Forms.TextBox
        Me.txtTENLOP = New System.Windows.Forms.TextBox
        Me.bdsSINHVIEN = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvSINHVIEN = New System.Windows.Forms.DataGridView
        Me.cmbMALOP = New System.Windows.Forms.ComboBox
        Me.txtMASV = New System.Windows.Forms.TextBox
        Me.txtHO = New System.Windows.Forms.TextBox
        Me.txtTEN = New System.Windows.Forms.TextBox
        Me.txtDIACHI = New System.Windows.Forms.TextBox
        Me.grbQuanlysinhvien = New System.Windows.Forms.GroupBox
        Me.dtpNGAYSINH = New System.Windows.Forms.DateTimePicker
        Me.grbQuanlylop = New System.Windows.Forms.GroupBox
        Me.btnQuanlylop = New System.Windows.Forms.Button
        Me.btnQuanlysinhvien = New System.Windows.Forms.Button
        Me.btnThem = New System.Windows.Forms.Button
        Me.btnPhuchoi = New System.Windows.Forms.Button
        Me.btnXoa = New System.Windows.Forms.Button
        Me.btnTim = New System.Windows.Forms.Button
        Me.btnGhi = New System.Windows.Forms.Button
        Me.btnHieuchinh = New System.Windows.Forms.Button
        Me.bdsGIAOVIEN_DANGKY = New System.Windows.Forms.BindingSource(Me.components)
        Me.bdsBANGDIEM = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOPTableAdapter = New TRACNGHIEM.DSTableAdapters.LOPTableAdapter
        Me.SINHVIENTableAdapter = New TRACNGHIEM.DSTableAdapters.SINHVIENTableAdapter
        Me.GIAOVIEN_DANGKYTableAdapter = New TRACNGHIEM.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter
        Me.BANGDIEMTableAdapter = New TRACNGHIEM.DSTableAdapters.BANGDIEMTableAdapter
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NGAYSINH = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        MALOPLabel = New System.Windows.Forms.Label
        TENLOPLabel = New System.Windows.Forms.Label
        MALOPLabel1 = New System.Windows.Forms.Label
        MASVLabel = New System.Windows.Forms.Label
        HOLabel = New System.Windows.Forms.Label
        TENLabel = New System.Windows.Forms.Label
        NGAYSINHLabel = New System.Windows.Forms.Label
        DIACHILabel = New System.Windows.Forms.Label
        CType(Me.dgvLOP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsLOP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsSINHVIEN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSINHVIEN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbQuanlysinhvien.SuspendLayout()
        Me.grbQuanlylop.SuspendLayout()
        CType(Me.bdsGIAOVIEN_DANGKY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsBANGDIEM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MALOPLabel
        '
        MALOPLabel.AutoSize = True
        MALOPLabel.Location = New System.Drawing.Point(13, 58)
        MALOPLabel.Name = "MALOPLabel"
        MALOPLabel.Size = New System.Drawing.Size(50, 16)
        MALOPLabel.TabIndex = 1
        MALOPLabel.Text = "Mã lớp:"
        '
        'TENLOPLabel
        '
        TENLOPLabel.AutoSize = True
        TENLOPLabel.Location = New System.Drawing.Point(9, 107)
        TENLOPLabel.Name = "TENLOPLabel"
        TENLOPLabel.Size = New System.Drawing.Size(54, 16)
        TENLOPLabel.TabIndex = 3
        TENLOPLabel.Text = "Tên lớp:"
        '
        'MALOPLabel1
        '
        MALOPLabel1.AutoSize = True
        MALOPLabel1.Location = New System.Drawing.Point(39, 44)
        MALOPLabel1.Name = "MALOPLabel1"
        MALOPLabel1.Size = New System.Drawing.Size(33, 16)
        MALOPLabel1.TabIndex = 6
        MALOPLabel1.Text = "Lớp:"
        '
        'MASVLabel
        '
        MASVLabel.AutoSize = True
        MASVLabel.Location = New System.Drawing.Point(180, 44)
        MASVLabel.Name = "MASVLabel"
        MASVLabel.Size = New System.Drawing.Size(83, 16)
        MASVLabel.TabIndex = 8
        MASVLabel.Text = "Mã sinh viên:"
        '
        'HOLabel
        '
        HOLabel.AutoSize = True
        HOLabel.Location = New System.Drawing.Point(378, 44)
        HOLabel.Name = "HOLabel"
        HOLabel.Size = New System.Drawing.Size(27, 16)
        HOLabel.TabIndex = 10
        HOLabel.Text = "Họ:"
        '
        'TENLabel
        '
        TENLabel.AutoSize = True
        TENLabel.Location = New System.Drawing.Point(501, 44)
        TENLabel.Name = "TENLabel"
        TENLabel.Size = New System.Drawing.Size(33, 16)
        TENLabel.TabIndex = 12
        TENLabel.Text = "Tên:"
        '
        'NGAYSINHLabel
        '
        NGAYSINHLabel.AutoSize = True
        NGAYSINHLabel.Location = New System.Drawing.Point(77, 105)
        NGAYSINHLabel.Name = "NGAYSINHLabel"
        NGAYSINHLabel.Size = New System.Drawing.Size(68, 16)
        NGAYSINHLabel.TabIndex = 14
        NGAYSINHLabel.Text = "Ngày sinh:"
        '
        'DIACHILabel
        '
        DIACHILabel.AutoSize = True
        DIACHILabel.Location = New System.Drawing.Point(354, 105)
        DIACHILabel.Name = "DIACHILabel"
        DIACHILabel.Size = New System.Drawing.Size(51, 16)
        DIACHILabel.TabIndex = 16
        DIACHILabel.Text = "Địa chỉ:"
        '
        'dgvLOP
        '
        Me.dgvLOP.AllowUserToResizeColumns = False
        Me.dgvLOP.AllowUserToResizeRows = False
        Me.dgvLOP.AutoGenerateColumns = False
        Me.dgvLOP.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgvLOP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvLOP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dgvLOP.DataSource = Me.bdsLOP
        Me.dgvLOP.Location = New System.Drawing.Point(12, 245)
        Me.dgvLOP.Name = "dgvLOP"
        Me.dgvLOP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvLOP.Size = New System.Drawing.Size(223, 204)
        Me.dgvLOP.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MALOP"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Mã lớp"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TENLOP"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tên lớp"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 110
        '
        'bdsLOP
        '
        Me.bdsLOP.DataMember = "LOP"
        Me.bdsLOP.DataSource = Me.DS
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtMALOP
        '
        Me.txtMALOP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsLOP, "MALOP", True))
        Me.txtMALOP.Location = New System.Drawing.Point(66, 55)
        Me.txtMALOP.Name = "txtMALOP"
        Me.txtMALOP.Size = New System.Drawing.Size(99, 23)
        Me.txtMALOP.TabIndex = 2
        '
        'txtTENLOP
        '
        Me.txtTENLOP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsLOP, "TENLOP", True))
        Me.txtTENLOP.Location = New System.Drawing.Point(66, 104)
        Me.txtTENLOP.Name = "txtTENLOP"
        Me.txtTENLOP.Size = New System.Drawing.Size(144, 23)
        Me.txtTENLOP.TabIndex = 4
        '
        'bdsSINHVIEN
        '
        Me.bdsSINHVIEN.DataMember = "FK_Sinhvien_Lop1"
        Me.bdsSINHVIEN.DataSource = Me.bdsLOP
        '
        'dgvSINHVIEN
        '
        Me.dgvSINHVIEN.AllowUserToResizeColumns = False
        Me.dgvSINHVIEN.AllowUserToResizeRows = False
        Me.dgvSINHVIEN.AutoGenerateColumns = False
        Me.dgvSINHVIEN.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgvSINHVIEN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSINHVIEN.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.NGAYSINH, Me.DataGridViewTextBoxColumn8})
        Me.dgvSINHVIEN.DataSource = Me.bdsSINHVIEN
        Me.dgvSINHVIEN.Location = New System.Drawing.Point(367, 245)
        Me.dgvSINHVIEN.Name = "dgvSINHVIEN"
        Me.dgvSINHVIEN.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvSINHVIEN.Size = New System.Drawing.Size(645, 201)
        Me.dgvSINHVIEN.TabIndex = 5
        '
        'cmbMALOP
        '
        Me.cmbMALOP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsLOP, "TENLOP", True))
        Me.cmbMALOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbMALOP.Enabled = False
        Me.cmbMALOP.FormattingEnabled = True
        Me.cmbMALOP.Location = New System.Drawing.Point(75, 41)
        Me.cmbMALOP.Name = "cmbMALOP"
        Me.cmbMALOP.Size = New System.Drawing.Size(95, 23)
        Me.cmbMALOP.TabIndex = 7
        '
        'txtMASV
        '
        Me.txtMASV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsSINHVIEN, "MASV", True))
        Me.txtMASV.Location = New System.Drawing.Point(266, 41)
        Me.txtMASV.Name = "txtMASV"
        Me.txtMASV.Size = New System.Drawing.Size(100, 23)
        Me.txtMASV.TabIndex = 9
        '
        'txtHO
        '
        Me.txtHO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsSINHVIEN, "HO", True))
        Me.txtHO.Location = New System.Drawing.Point(408, 41)
        Me.txtHO.Name = "txtHO"
        Me.txtHO.Size = New System.Drawing.Size(78, 23)
        Me.txtHO.TabIndex = 11
        '
        'txtTEN
        '
        Me.txtTEN.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsSINHVIEN, "TEN", True))
        Me.txtTEN.Location = New System.Drawing.Point(537, 41)
        Me.txtTEN.Name = "txtTEN"
        Me.txtTEN.Size = New System.Drawing.Size(129, 23)
        Me.txtTEN.TabIndex = 13
        '
        'txtDIACHI
        '
        Me.txtDIACHI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsSINHVIEN, "DIACHI", True))
        Me.txtDIACHI.Location = New System.Drawing.Point(408, 102)
        Me.txtDIACHI.Name = "txtDIACHI"
        Me.txtDIACHI.Size = New System.Drawing.Size(208, 23)
        Me.txtDIACHI.TabIndex = 17
        '
        'grbQuanlysinhvien
        '
        Me.grbQuanlysinhvien.Controls.Add(Me.dtpNGAYSINH)
        Me.grbQuanlysinhvien.Controls.Add(MASVLabel)
        Me.grbQuanlysinhvien.Controls.Add(DIACHILabel)
        Me.grbQuanlysinhvien.Controls.Add(Me.cmbMALOP)
        Me.grbQuanlysinhvien.Controls.Add(Me.txtDIACHI)
        Me.grbQuanlysinhvien.Controls.Add(MALOPLabel1)
        Me.grbQuanlysinhvien.Controls.Add(NGAYSINHLabel)
        Me.grbQuanlysinhvien.Controls.Add(Me.txtMASV)
        Me.grbQuanlysinhvien.Controls.Add(Me.txtHO)
        Me.grbQuanlysinhvien.Controls.Add(TENLabel)
        Me.grbQuanlysinhvien.Controls.Add(HOLabel)
        Me.grbQuanlysinhvien.Controls.Add(Me.txtTEN)
        Me.grbQuanlysinhvien.Location = New System.Drawing.Point(328, 12)
        Me.grbQuanlysinhvien.Name = "grbQuanlysinhvien"
        Me.grbQuanlysinhvien.Size = New System.Drawing.Size(686, 157)
        Me.grbQuanlysinhvien.TabIndex = 18
        Me.grbQuanlysinhvien.TabStop = False
        Me.grbQuanlysinhvien.Text = "Quản lý sinh viên"
        '
        'dtpNGAYSINH
        '
        Me.dtpNGAYSINH.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.bdsSINHVIEN, "NGAYSINH", True))
        Me.dtpNGAYSINH.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNGAYSINH.Location = New System.Drawing.Point(148, 101)
        Me.dtpNGAYSINH.Name = "dtpNGAYSINH"
        Me.dtpNGAYSINH.Size = New System.Drawing.Size(186, 23)
        Me.dtpNGAYSINH.TabIndex = 18
        '
        'grbQuanlylop
        '
        Me.grbQuanlylop.Controls.Add(MALOPLabel)
        Me.grbQuanlylop.Controls.Add(Me.txtMALOP)
        Me.grbQuanlylop.Controls.Add(Me.txtTENLOP)
        Me.grbQuanlylop.Controls.Add(TENLOPLabel)
        Me.grbQuanlylop.Location = New System.Drawing.Point(12, 12)
        Me.grbQuanlylop.Name = "grbQuanlylop"
        Me.grbQuanlylop.Size = New System.Drawing.Size(223, 156)
        Me.grbQuanlylop.TabIndex = 19
        Me.grbQuanlylop.TabStop = False
        Me.grbQuanlylop.Text = "Quản lý lớp"
        '
        'btnQuanlylop
        '
        Me.btnQuanlylop.BackColor = System.Drawing.SystemColors.Control
        Me.btnQuanlylop.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuanlylop.Location = New System.Drawing.Point(258, 286)
        Me.btnQuanlylop.Name = "btnQuanlylop"
        Me.btnQuanlylop.Size = New System.Drawing.Size(90, 50)
        Me.btnQuanlylop.TabIndex = 20
        Me.btnQuanlylop.Text = "Quản lý lớp"
        Me.btnQuanlylop.UseVisualStyleBackColor = False
        '
        'btnQuanlysinhvien
        '
        Me.btnQuanlysinhvien.BackColor = System.Drawing.SystemColors.Control
        Me.btnQuanlysinhvien.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuanlysinhvien.Location = New System.Drawing.Point(258, 362)
        Me.btnQuanlysinhvien.Name = "btnQuanlysinhvien"
        Me.btnQuanlysinhvien.Size = New System.Drawing.Size(90, 50)
        Me.btnQuanlysinhvien.TabIndex = 21
        Me.btnQuanlysinhvien.Text = "Quản lý sinh viên"
        Me.btnQuanlysinhvien.UseVisualStyleBackColor = False
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(90, 189)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(100, 30)
        Me.btnThem.TabIndex = 22
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnPhuchoi
        '
        Me.btnPhuchoi.Location = New System.Drawing.Point(835, 189)
        Me.btnPhuchoi.Name = "btnPhuchoi"
        Me.btnPhuchoi.Size = New System.Drawing.Size(100, 30)
        Me.btnPhuchoi.TabIndex = 23
        Me.btnPhuchoi.Text = "Phục hồi"
        Me.btnPhuchoi.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(686, 189)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(100, 30)
        Me.btnXoa.TabIndex = 24
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnTim
        '
        Me.btnTim.Location = New System.Drawing.Point(537, 189)
        Me.btnTim.Name = "btnTim"
        Me.btnTim.Size = New System.Drawing.Size(100, 30)
        Me.btnTim.TabIndex = 25
        Me.btnTim.Text = "Tìm"
        Me.btnTim.UseVisualStyleBackColor = True
        '
        'btnGhi
        '
        Me.btnGhi.Location = New System.Drawing.Point(388, 189)
        Me.btnGhi.Name = "btnGhi"
        Me.btnGhi.Size = New System.Drawing.Size(100, 30)
        Me.btnGhi.TabIndex = 26
        Me.btnGhi.Text = "Ghi"
        Me.btnGhi.UseVisualStyleBackColor = True
        '
        'btnHieuchinh
        '
        Me.btnHieuchinh.Location = New System.Drawing.Point(239, 189)
        Me.btnHieuchinh.Name = "btnHieuchinh"
        Me.btnHieuchinh.Size = New System.Drawing.Size(100, 30)
        Me.btnHieuchinh.TabIndex = 27
        Me.btnHieuchinh.Text = "Hiệu chỉnh"
        Me.btnHieuchinh.UseVisualStyleBackColor = True
        '
        'bdsGIAOVIEN_DANGKY
        '
        Me.bdsGIAOVIEN_DANGKY.DataMember = "FK_Giaovien_Dangky_Lop1"
        Me.bdsGIAOVIEN_DANGKY.DataSource = Me.bdsLOP
        '
        'bdsBANGDIEM
        '
        Me.bdsBANGDIEM.DataMember = "FK_BangDiem_Sinhvien"
        Me.bdsBANGDIEM.DataSource = Me.bdsSINHVIEN
        '
        'LOPTableAdapter
        '
        Me.LOPTableAdapter.ClearBeforeFill = True
        '
        'SINHVIENTableAdapter
        '
        Me.SINHVIENTableAdapter.ClearBeforeFill = True
        '
        'GIAOVIEN_DANGKYTableAdapter
        '
        Me.GIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = True
        '
        'BANGDIEMTableAdapter
        '
        Me.BANGDIEMTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MALOP"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.bdsLOP
        Me.DataGridViewTextBoxColumn3.DisplayMember = "TENLOP"
        Me.DataGridViewTextBoxColumn3.Frozen = True
        Me.DataGridViewTextBoxColumn3.HeaderText = "Lớp"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "MALOP"
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MASV"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Mã sinh viên"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "HO"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Họ"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TEN"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Tên"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 130
        '
        'NGAYSINH
        '
        Me.NGAYSINH.DataPropertyName = "NGAYSINH"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.NGAYSINH.DefaultCellStyle = DataGridViewCellStyle1
        Me.NGAYSINH.HeaderText = "Ngày sinh"
        Me.NGAYSINH.Name = "NGAYSINH"
        Me.NGAYSINH.ReadOnly = True
        Me.NGAYSINH.Width = 120
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "DIACHI"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Địa chỉ"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 122
        '
        'frmQLSV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 461)
        Me.Controls.Add(Me.btnHieuchinh)
        Me.Controls.Add(Me.btnGhi)
        Me.Controls.Add(Me.btnTim)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnPhuchoi)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnQuanlysinhvien)
        Me.Controls.Add(Me.btnQuanlylop)
        Me.Controls.Add(Me.grbQuanlylop)
        Me.Controls.Add(Me.grbQuanlysinhvien)
        Me.Controls.Add(Me.dgvSINHVIEN)
        Me.Controls.Add(Me.dgvLOP)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmQLSV"
        Me.Text = "Quản lý sinh viên"
        CType(Me.dgvLOP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsLOP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsSINHVIEN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSINHVIEN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbQuanlysinhvien.ResumeLayout(False)
        Me.grbQuanlysinhvien.PerformLayout()
        Me.grbQuanlylop.ResumeLayout(False)
        Me.grbQuanlylop.PerformLayout()
        CType(Me.bdsGIAOVIEN_DANGKY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsBANGDIEM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DS As TRACNGHIEM.DS
    Friend WithEvents bdsLOP As System.Windows.Forms.BindingSource
    Friend WithEvents LOPTableAdapter As TRACNGHIEM.DSTableAdapters.LOPTableAdapter
    Friend WithEvents dgvLOP As System.Windows.Forms.DataGridView
    Friend WithEvents txtMALOP As System.Windows.Forms.TextBox
    Friend WithEvents txtTENLOP As System.Windows.Forms.TextBox
    Friend WithEvents bdsSINHVIEN As System.Windows.Forms.BindingSource
    Friend WithEvents SINHVIENTableAdapter As TRACNGHIEM.DSTableAdapters.SINHVIENTableAdapter
    Friend WithEvents dgvSINHVIEN As System.Windows.Forms.DataGridView
    Friend WithEvents cmbMALOP As System.Windows.Forms.ComboBox
    Friend WithEvents txtMASV As System.Windows.Forms.TextBox
    Friend WithEvents txtHO As System.Windows.Forms.TextBox
    Friend WithEvents txtTEN As System.Windows.Forms.TextBox
    Friend WithEvents txtDIACHI As System.Windows.Forms.TextBox
    Friend WithEvents grbQuanlysinhvien As System.Windows.Forms.GroupBox
    Friend WithEvents grbQuanlylop As System.Windows.Forms.GroupBox
    Friend WithEvents btnQuanlylop As System.Windows.Forms.Button
    Friend WithEvents btnQuanlysinhvien As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnPhuchoi As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnTim As System.Windows.Forms.Button
    Friend WithEvents btnGhi As System.Windows.Forms.Button
    Friend WithEvents btnHieuchinh As System.Windows.Forms.Button
    Friend WithEvents bdsGIAOVIEN_DANGKY As System.Windows.Forms.BindingSource
    Friend WithEvents GIAOVIEN_DANGKYTableAdapter As TRACNGHIEM.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter
    Friend WithEvents bdsBANGDIEM As System.Windows.Forms.BindingSource
    Friend WithEvents BANGDIEMTableAdapter As TRACNGHIEM.DSTableAdapters.BANGDIEMTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtpNGAYSINH As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NGAYSINH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
