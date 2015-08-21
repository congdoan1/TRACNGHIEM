<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLambai
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
        Dim MAMHLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim TENMHLabel As System.Windows.Forms.Label
        Dim TENMHLabel1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim NOIDUNGLabel As System.Windows.Forms.Label
        Dim ALabel As System.Windows.Forms.Label
        Dim BLabel As System.Windows.Forms.Label
        Dim CLabel As System.Windows.Forms.Label
        Dim DLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtTENLOP = New System.Windows.Forms.TextBox
        Me.SP_CHONLOPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS = New TRACNGHIEM.DS
        Me.txtMALOP = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmbLAN = New System.Windows.Forms.ComboBox
        Me.dtpNGAYTHI = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbMH = New System.Windows.Forms.ComboBox
        Me.CHONMONHOCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CHONMONHOCTableAdapter = New TRACNGHIEM.DSTableAdapters.CHONMONHOCTableAdapter
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnThi = New System.Windows.Forms.Button
        Me.txtTHOIGIANTHI = New System.Windows.Forms.TextBox
        Me.SP_XEMDANGKYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtTRINHDO = New System.Windows.Forms.TextBox
        Me.txtSOCAUTHI = New System.Windows.Forms.TextBox
        Me.SP_CHONLOPTableAdapter = New TRACNGHIEM.DSTableAdapters.SP_CHONLOPTableAdapter
        Me.SP_XEMDANGKYTableAdapter = New TRACNGHIEM.DSTableAdapters.SP_XEMDANGKYTableAdapter
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pnlLAMBAI = New System.Windows.Forms.Panel
        Me.txtTONGSOCAU = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtCAUHIENTAI = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnNopbai = New System.Windows.Forms.Button
        Me.btnCautieptheo = New System.Windows.Forms.Button
        Me.btnCautruoc = New System.Windows.Forms.Button
        Me.SP_CHONCAUHOIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CHONCAUHOITableAdapter = New TRACNGHIEM.DSTableAdapters.SP_CHONCAUHOITableAdapter
        Me.txtNOIDUNG = New System.Windows.Forms.Label
        Me.txtA = New System.Windows.Forms.Label
        Me.txtB = New System.Windows.Forms.Label
        Me.txtC = New System.Windows.Forms.Label
        Me.txtD = New System.Windows.Forms.Label
        Me.rdA = New System.Windows.Forms.RadioButton
        Me.rdC = New System.Windows.Forms.RadioButton
        Me.rdB = New System.Windows.Forms.RadioButton
        Me.rdD = New System.Windows.Forms.RadioButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        MAMHLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        TENMHLabel = New System.Windows.Forms.Label
        TENMHLabel1 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        NOIDUNGLabel = New System.Windows.Forms.Label
        ALabel = New System.Windows.Forms.Label
        BLabel = New System.Windows.Forms.Label
        CLabel = New System.Windows.Forms.Label
        DLabel = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.SP_CHONLOPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CHONMONHOCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.SP_XEMDANGKYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlLAMBAI.SuspendLayout()
        CType(Me.SP_CHONCAUHOIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MAMHLabel
        '
        MAMHLabel.AutoSize = True
        MAMHLabel.Location = New System.Drawing.Point(373, 20)
        MAMHLabel.Name = "MAMHLabel"
        MAMHLabel.Size = New System.Drawing.Size(50, 16)
        MAMHLabel.TabIndex = 0
        MAMHLabel.Text = "Mã lớp:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(608, 20)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(54, 16)
        Label1.TabIndex = 2
        Label1.Text = "Tên lớp:"
        '
        'TENMHLabel
        '
        TENMHLabel.AutoSize = True
        TENMHLabel.Location = New System.Drawing.Point(124, 25)
        TENMHLabel.Name = "TENMHLabel"
        TENMHLabel.Size = New System.Drawing.Size(62, 16)
        TENMHLabel.TabIndex = 0
        TENMHLabel.Text = "Môn học:"
        '
        'TENMHLabel1
        '
        TENMHLabel1.AutoSize = True
        TENMHLabel1.Location = New System.Drawing.Point(674, 25)
        TENMHLabel1.Name = "TENMHLabel1"
        TENMHLabel1.Size = New System.Drawing.Size(50, 16)
        TENMHLabel1.TabIndex = 4
        TENMHLabel1.Text = "Lần thi:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(46, 25)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(68, 16)
        Label3.TabIndex = 4
        Label3.Text = "Số câu thi:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(491, 25)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(61, 16)
        Label4.TabIndex = 6
        Label4.Text = "Trình độ:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(249, 25)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(82, 16)
        Label5.TabIndex = 8
        Label5.Text = "Thời gian thi:"
        '
        'NOIDUNGLabel
        '
        NOIDUNGLabel.AutoSize = True
        NOIDUNGLabel.Location = New System.Drawing.Point(157, 22)
        NOIDUNGLabel.Name = "NOIDUNGLabel"
        NOIDUNGLabel.Size = New System.Drawing.Size(63, 16)
        NOIDUNGLabel.TabIndex = 0
        NOIDUNGLabel.Text = "Nội dung:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.txtTENLOP)
        Me.GroupBox1.Controls.Add(MAMHLabel)
        Me.GroupBox1.Controls.Add(Me.txtMALOP)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(922, 49)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtTENLOP
        '
        Me.txtTENLOP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CHONLOPBindingSource, "TENLOP", True))
        Me.txtTENLOP.Location = New System.Drawing.Point(665, 17)
        Me.txtTENLOP.Name = "txtTENLOP"
        Me.txtTENLOP.ReadOnly = True
        Me.txtTENLOP.Size = New System.Drawing.Size(116, 23)
        Me.txtTENLOP.TabIndex = 3
        '
        'SP_CHONLOPBindingSource
        '
        Me.SP_CHONLOPBindingSource.DataMember = "SP_CHONLOP"
        Me.SP_CHONLOPBindingSource.DataSource = Me.DS
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtMALOP
        '
        Me.txtMALOP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CHONLOPBindingSource, "MALOP", True))
        Me.txtMALOP.Location = New System.Drawing.Point(426, 17)
        Me.txtMALOP.Name = "txtMALOP"
        Me.txtMALOP.ReadOnly = True
        Me.txtMALOP.Size = New System.Drawing.Size(125, 23)
        Me.txtMALOP.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(TENMHLabel1)
        Me.GroupBox2.Controls.Add(Me.cmbLAN)
        Me.GroupBox2.Controls.Add(Me.dtpNGAYTHI)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(TENMHLabel)
        Me.GroupBox2.Controls.Add(Me.cmbMH)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(922, 58)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'cmbLAN
        '
        Me.cmbLAN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLAN.FormattingEnabled = True
        Me.cmbLAN.Items.AddRange(New Object() {"1", "2"})
        Me.cmbLAN.Location = New System.Drawing.Point(730, 22)
        Me.cmbLAN.Name = "cmbLAN"
        Me.cmbLAN.Size = New System.Drawing.Size(121, 23)
        Me.cmbLAN.TabIndex = 5
        '
        'dtpNGAYTHI
        '
        Me.dtpNGAYTHI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNGAYTHI.Location = New System.Drawing.Point(418, 19)
        Me.dtpNGAYTHI.Name = "dtpNGAYTHI"
        Me.dtpNGAYTHI.Size = New System.Drawing.Size(194, 23)
        Me.dtpNGAYTHI.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(353, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ngày thi:"
        '
        'cmbMH
        '
        Me.cmbMH.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CHONMONHOCBindingSource, "TENMH", True))
        Me.cmbMH.DataSource = Me.CHONMONHOCBindingSource
        Me.cmbMH.DisplayMember = "TENMH"
        Me.cmbMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMH.FormattingEnabled = True
        Me.cmbMH.Location = New System.Drawing.Point(192, 22)
        Me.cmbMH.Name = "cmbMH"
        Me.cmbMH.Size = New System.Drawing.Size(121, 23)
        Me.cmbMH.TabIndex = 1
        Me.cmbMH.ValueMember = "MAMH"
        '
        'CHONMONHOCBindingSource
        '
        Me.CHONMONHOCBindingSource.DataMember = "CHONMONHOC"
        Me.CHONMONHOCBindingSource.DataSource = Me.DS
        '
        'CHONMONHOCTableAdapter
        '
        Me.CHONMONHOCTableAdapter.ClearBeforeFill = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnThi)
        Me.GroupBox3.Controls.Add(Label5)
        Me.GroupBox3.Controls.Add(Me.txtTHOIGIANTHI)
        Me.GroupBox3.Controls.Add(Label4)
        Me.GroupBox3.Controls.Add(Me.txtTRINHDO)
        Me.GroupBox3.Controls.Add(Label3)
        Me.GroupBox3.Controls.Add(Me.txtSOCAUTHI)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 67)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(922, 58)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        '
        'btnThi
        '
        Me.btnThi.Location = New System.Drawing.Point(677, 21)
        Me.btnThi.Name = "btnThi"
        Me.btnThi.Size = New System.Drawing.Size(163, 23)
        Me.btnThi.TabIndex = 10
        Me.btnThi.Text = "Bắt đầu thi"
        Me.btnThi.UseVisualStyleBackColor = True
        '
        'txtTHOIGIANTHI
        '
        Me.txtTHOIGIANTHI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_XEMDANGKYBindingSource, "THOIGIAN", True))
        Me.txtTHOIGIANTHI.Enabled = False
        Me.txtTHOIGIANTHI.Location = New System.Drawing.Point(337, 22)
        Me.txtTHOIGIANTHI.Name = "txtTHOIGIANTHI"
        Me.txtTHOIGIANTHI.ReadOnly = True
        Me.txtTHOIGIANTHI.Size = New System.Drawing.Size(109, 23)
        Me.txtTHOIGIANTHI.TabIndex = 9
        '
        'SP_XEMDANGKYBindingSource
        '
        Me.SP_XEMDANGKYBindingSource.DataMember = "SP_XEMDANGKY"
        Me.SP_XEMDANGKYBindingSource.DataSource = Me.DS
        '
        'txtTRINHDO
        '
        Me.txtTRINHDO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_XEMDANGKYBindingSource, "TRINHDO", True))
        Me.txtTRINHDO.Enabled = False
        Me.txtTRINHDO.Location = New System.Drawing.Point(558, 22)
        Me.txtTRINHDO.Name = "txtTRINHDO"
        Me.txtTRINHDO.ReadOnly = True
        Me.txtTRINHDO.Size = New System.Drawing.Size(81, 23)
        Me.txtTRINHDO.TabIndex = 7
        '
        'txtSOCAUTHI
        '
        Me.txtSOCAUTHI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_XEMDANGKYBindingSource, "SOCAUTHI", True))
        Me.txtSOCAUTHI.Enabled = False
        Me.txtSOCAUTHI.Location = New System.Drawing.Point(118, 22)
        Me.txtSOCAUTHI.Name = "txtSOCAUTHI"
        Me.txtSOCAUTHI.ReadOnly = True
        Me.txtSOCAUTHI.Size = New System.Drawing.Size(125, 23)
        Me.txtSOCAUTHI.TabIndex = 5
        '
        'SP_CHONLOPTableAdapter
        '
        Me.SP_CHONLOPTableAdapter.ClearBeforeFill = True
        '
        'SP_XEMDANGKYTableAdapter
        '
        Me.SP_XEMDANGKYTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.pnlLAMBAI)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Location = New System.Drawing.Point(12, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(943, 480)
        Me.Panel1.TabIndex = 7
        '
        'pnlLAMBAI
        '
        Me.pnlLAMBAI.Controls.Add(Me.GroupBox4)
        Me.pnlLAMBAI.Controls.Add(Me.txtNOIDUNG)
        Me.pnlLAMBAI.Controls.Add(Me.txtTONGSOCAU)
        Me.pnlLAMBAI.Controls.Add(Me.Label7)
        Me.pnlLAMBAI.Controls.Add(Me.txtCAUHIENTAI)
        Me.pnlLAMBAI.Controls.Add(Me.Label6)
        Me.pnlLAMBAI.Controls.Add(Me.btnNopbai)
        Me.pnlLAMBAI.Controls.Add(Me.btnCautieptheo)
        Me.pnlLAMBAI.Controls.Add(Me.btnCautruoc)
        Me.pnlLAMBAI.Controls.Add(NOIDUNGLabel)
        Me.pnlLAMBAI.Location = New System.Drawing.Point(10, 131)
        Me.pnlLAMBAI.Name = "pnlLAMBAI"
        Me.pnlLAMBAI.Size = New System.Drawing.Size(925, 337)
        Me.pnlLAMBAI.TabIndex = 7
        '
        'txtTONGSOCAU
        '
        Me.txtTONGSOCAU.AutoSize = True
        Me.txtTONGSOCAU.Location = New System.Drawing.Point(115, 22)
        Me.txtTONGSOCAU.Name = "txtTONGSOCAU"
        Me.txtTONGSOCAU.Size = New System.Drawing.Size(29, 16)
        Me.txtTONGSOCAU.TabIndex = 16
        Me.txtTONGSOCAU.Text = "100"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(96, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(12, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "/"
        '
        'txtCAUHIENTAI
        '
        Me.txtCAUHIENTAI.AutoSize = True
        Me.txtCAUHIENTAI.Location = New System.Drawing.Point(74, 22)
        Me.txtCAUHIENTAI.Name = "txtCAUHIENTAI"
        Me.txtCAUHIENTAI.Size = New System.Drawing.Size(15, 16)
        Me.txtCAUHIENTAI.TabIndex = 14
        Me.txtCAUHIENTAI.Text = "1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Câu hỏi"
        '
        'btnNopbai
        '
        Me.btnNopbai.Location = New System.Drawing.Point(657, 274)
        Me.btnNopbai.Name = "btnNopbai"
        Me.btnNopbai.Size = New System.Drawing.Size(146, 23)
        Me.btnNopbai.TabIndex = 12
        Me.btnNopbai.Text = "Nộp bài"
        Me.btnNopbai.UseVisualStyleBackColor = True
        '
        'btnCautieptheo
        '
        Me.btnCautieptheo.Location = New System.Drawing.Point(464, 274)
        Me.btnCautieptheo.Name = "btnCautieptheo"
        Me.btnCautieptheo.Size = New System.Drawing.Size(146, 23)
        Me.btnCautieptheo.TabIndex = 11
        Me.btnCautieptheo.Text = "Câu tiếp theo"
        Me.btnCautieptheo.UseVisualStyleBackColor = True
        '
        'btnCautruoc
        '
        Me.btnCautruoc.Location = New System.Drawing.Point(266, 274)
        Me.btnCautruoc.Name = "btnCautruoc"
        Me.btnCautruoc.Size = New System.Drawing.Size(146, 23)
        Me.btnCautruoc.TabIndex = 10
        Me.btnCautruoc.Text = "Câu trước"
        Me.btnCautruoc.UseVisualStyleBackColor = True
        '
        'SP_CHONCAUHOIBindingSource
        '
        Me.SP_CHONCAUHOIBindingSource.DataMember = "SP_CHONCAUHOI"
        Me.SP_CHONCAUHOIBindingSource.DataSource = Me.DS
        '
        'SP_CHONCAUHOITableAdapter
        '
        Me.SP_CHONCAUHOITableAdapter.ClearBeforeFill = True
        '
        'txtNOIDUNG
        '
        Me.txtNOIDUNG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNOIDUNG.Location = New System.Drawing.Point(231, 22)
        Me.txtNOIDUNG.Name = "txtNOIDUNG"
        Me.txtNOIDUNG.Size = New System.Drawing.Size(674, 107)
        Me.txtNOIDUNG.TabIndex = 17
        Me.txtNOIDUNG.Text = "Nội dung câu hỏi"
        '
        'ALabel
        '
        ALabel.AutoSize = True
        ALabel.Location = New System.Drawing.Point(38, 19)
        ALabel.Name = "ALabel"
        ALabel.Size = New System.Drawing.Size(21, 16)
        ALabel.TabIndex = 17
        ALabel.Text = "A."
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(64, 19)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(200, 23)
        Me.txtA.TabIndex = 18
        Me.txtA.Text = "Đáp án A"
        '
        'BLabel
        '
        BLabel.AutoSize = True
        BLabel.Location = New System.Drawing.Point(435, 19)
        BLabel.Name = "BLabel"
        BLabel.Size = New System.Drawing.Size(20, 16)
        BLabel.TabIndex = 18
        BLabel.Text = "B."
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(457, 19)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(200, 23)
        Me.txtB.TabIndex = 19
        Me.txtB.Text = "Đáp án B"
        '
        'CLabel
        '
        CLabel.AutoSize = True
        CLabel.Location = New System.Drawing.Point(38, 65)
        CLabel.Name = "CLabel"
        CLabel.Size = New System.Drawing.Size(21, 16)
        CLabel.TabIndex = 19
        CLabel.Text = "C."
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(64, 65)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(200, 23)
        Me.txtC.TabIndex = 20
        Me.txtC.Text = "Đáp án C"
        '
        'DLabel
        '
        DLabel.AutoSize = True
        DLabel.Location = New System.Drawing.Point(437, 65)
        DLabel.Name = "DLabel"
        DLabel.Size = New System.Drawing.Size(22, 16)
        DLabel.TabIndex = 20
        DLabel.Text = "D."
        '
        'txtD
        '
        Me.txtD.Location = New System.Drawing.Point(457, 65)
        Me.txtD.Name = "txtD"
        Me.txtD.Size = New System.Drawing.Size(200, 23)
        Me.txtD.TabIndex = 21
        Me.txtD.Text = "Đáp án D"
        '
        'rdA
        '
        Me.rdA.AutoSize = True
        Me.rdA.Location = New System.Drawing.Point(18, 20)
        Me.rdA.Name = "rdA"
        Me.rdA.Size = New System.Drawing.Size(14, 13)
        Me.rdA.TabIndex = 22
        Me.rdA.TabStop = True
        Me.rdA.UseVisualStyleBackColor = True
        '
        'rdC
        '
        Me.rdC.AutoSize = True
        Me.rdC.Location = New System.Drawing.Point(18, 66)
        Me.rdC.Name = "rdC"
        Me.rdC.Size = New System.Drawing.Size(14, 13)
        Me.rdC.TabIndex = 23
        Me.rdC.TabStop = True
        Me.rdC.UseVisualStyleBackColor = True
        '
        'rdB
        '
        Me.rdB.AutoSize = True
        Me.rdB.Location = New System.Drawing.Point(415, 20)
        Me.rdB.Name = "rdB"
        Me.rdB.Size = New System.Drawing.Size(14, 13)
        Me.rdB.TabIndex = 24
        Me.rdB.TabStop = True
        Me.rdB.UseVisualStyleBackColor = True
        '
        'rdD
        '
        Me.rdD.AutoSize = True
        Me.rdD.Location = New System.Drawing.Point(417, 66)
        Me.rdD.Name = "rdD"
        Me.rdD.Size = New System.Drawing.Size(14, 13)
        Me.rdD.TabIndex = 25
        Me.rdD.TabStop = True
        Me.rdD.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtA)
        Me.GroupBox4.Controls.Add(Me.rdD)
        Me.GroupBox4.Controls.Add(ALabel)
        Me.GroupBox4.Controls.Add(Me.rdB)
        Me.GroupBox4.Controls.Add(Me.txtB)
        Me.GroupBox4.Controls.Add(Me.rdC)
        Me.GroupBox4.Controls.Add(BLabel)
        Me.GroupBox4.Controls.Add(Me.rdA)
        Me.GroupBox4.Controls.Add(Me.txtC)
        Me.GroupBox4.Controls.Add(DLabel)
        Me.GroupBox4.Controls.Add(CLabel)
        Me.GroupBox4.Controls.Add(Me.txtD)
        Me.GroupBox4.Location = New System.Drawing.Point(231, 143)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(674, 100)
        Me.GroupBox4.TabIndex = 26
        Me.GroupBox4.TabStop = False
        '
        'frmLambai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 558)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmLambai"
        Me.Text = "frmLambai"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SP_CHONLOPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CHONMONHOCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.SP_XEMDANGKYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.pnlLAMBAI.ResumeLayout(False)
        Me.pnlLAMBAI.PerformLayout()
        CType(Me.SP_CHONCAUHOIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMALOP As System.Windows.Forms.TextBox
    Friend WithEvents txtTENLOP As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DS As TRACNGHIEM.DS
    Friend WithEvents CHONMONHOCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CHONMONHOCTableAdapter As TRACNGHIEM.DSTableAdapters.CHONMONHOCTableAdapter
    Friend WithEvents cmbMH As System.Windows.Forms.ComboBox
    Friend WithEvents dtpNGAYTHI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbLAN As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTHOIGIANTHI As System.Windows.Forms.TextBox
    Friend WithEvents txtTRINHDO As System.Windows.Forms.TextBox
    Friend WithEvents txtSOCAUTHI As System.Windows.Forms.TextBox
    Friend WithEvents SP_CHONLOPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SP_CHONLOPTableAdapter As TRACNGHIEM.DSTableAdapters.SP_CHONLOPTableAdapter
    Friend WithEvents SP_XEMDANGKYBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SP_XEMDANGKYTableAdapter As TRACNGHIEM.DSTableAdapters.SP_XEMDANGKYTableAdapter
    Friend WithEvents btnThi As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlLAMBAI As System.Windows.Forms.Panel
    Friend WithEvents SP_CHONCAUHOIBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SP_CHONCAUHOITableAdapter As TRACNGHIEM.DSTableAdapters.SP_CHONCAUHOITableAdapter
    Friend WithEvents btnNopbai As System.Windows.Forms.Button
    Friend WithEvents btnCautieptheo As System.Windows.Forms.Button
    Friend WithEvents btnCautruoc As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTONGSOCAU As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCAUHIENTAI As System.Windows.Forms.Label
    Friend WithEvents txtNOIDUNG As System.Windows.Forms.Label
    Friend WithEvents txtD As System.Windows.Forms.Label
    Friend WithEvents txtC As System.Windows.Forms.Label
    Friend WithEvents txtB As System.Windows.Forms.Label
    Friend WithEvents txtA As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rdD As System.Windows.Forms.RadioButton
    Friend WithEvents rdB As System.Windows.Forms.RadioButton
    Friend WithEvents rdC As System.Windows.Forms.RadioButton
    Friend WithEvents rdA As System.Windows.Forms.RadioButton
End Class
