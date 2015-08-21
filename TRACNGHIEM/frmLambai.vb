Public Class frmLambai
    Dim mamh As String
    Dim trinhdo As String
    Dim magv As String
    Dim socauhoi As Integer

    Dim cauhientai As Integer
    Dim index As Integer
    Dim row As DataRow

    Dim socaudung As Integer

    Dim dapandung() As Char
    Dim dapanchon() As Char


    Private Sub frmLambai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS.CHONMONHOC' table. You can move, or remove it, as needed.
        Me.CHONMONHOCTableAdapter.Fill(Me.DS.CHONMONHOC)

        Me.SP_CHONLOPTableAdapter.Fill(DS.SP_CHONLOP, "sv1")

        cmbMH.SelectedIndex = -1
        cmbLAN.SelectedIndex = -1
    End Sub


    Private Sub cmbLAN_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLAN.SelectedIndexChanged
        Me.SP_XEMDANGKYTableAdapter.Fill(DS.SP_XEMDANGKY, "gv1", txtMALOP.Text, cmbMH.SelectedValue, "2015-08-03", cmbLAN.Text)
    End Sub

    Private Sub btnThi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThi.Click
        'ẩn 2 groupbox chọn
        GroupBox2.Visible = False
        GroupBox3.Visible = False

        'lưu mamh, trinhdo, magv, socauhoi lại trong các biến
        mamh = cmbMH.SelectedValue
        trinhdo = txtTRINHDO.Text
        magv = "gv1"
        socauhoi = txtSOCAUTHI.Text

        'lấy câu hỏi ngẫu nhiên
        Me.SP_CHONCAUHOITableAdapter.Fill(DS.SP_CHONCAUHOI, mamh, trinhdo, magv, socauhoi)

        'hiển thị khung câu hỏi để làm bài
        pnlLAMBAI.Enabled = True
        pnlLAMBAI.Dock = DockStyle.Fill

        'khởi tạo mảng rỗng chứa đáp án mà sinh viên chọn
        dapanchon = New Char(socauhoi) {}
        For i As Integer = 0 To socauhoi - 1
            dapanchon(i) = ""
        Next

        'hiển thị câu hỏi đầu tiên
        index = 0
        hienthicauhoi(index)

        txtCAUHIENTAI.Text = index + 1
        txtTONGSOCAU.Text = socauhoi
    End Sub

    Private Sub btnCautieptheo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCautieptheo.Click
        If index = socauhoi - 1 Then
            index = 0
        Else
            index += 1
        End If
        txtCAUHIENTAI.Text = index + 1
        hienthicauhoi(index)
        kiemtra(index)

    End Sub

    Private Sub btnCautruoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCautruoc.Click
        If index = 0 Then
            index = socauhoi - 1
        Else
            index -= 1
        End If
        txtCAUHIENTAI.Text = index + 1
        hienthicauhoi(index)
        kiemtra(index)

    End Sub

    Private Sub hienthicauhoi(ByVal index As Integer)
        row = DS.SP_CHONCAUHOI.Rows(index)
        txtNOIDUNG.Text = row("NOIDUNG")
        txtA.Text = row("A")
        txtB.Text = row("B")
        txtC.Text = row("C")
        txtD.Text = row("D")
        Dim caudung As Char = row("DAPAN")
        Dim caudachon As Char = dapanchon(index)
        Select Case caudachon
            Case "A"
                rdA.Checked = True
            Case "B"
                rdB.Checked = True
            Case "C"
                rdC.Checked = True
            Case "D"
                rdD.Checked = True
        End Select
    End Sub

    Private Sub kiemtra(ByVal index As Integer)
        row = DS.SP_CHONCAUHOI.Rows(index)
        Dim caudung As Char = row("DAPAN")
        Dim dapan As Char
        Select Case True
            Case rdA.Checked
                dapan = "A"
                rdA.Checked = False
            Case rdB.Checked
                dapan = "B"
                rdB.Checked = False
            Case rdC.Checked
                dapan = "C"
                rdC.Checked = False
            Case rdD.Checked
                dapan = "D"
                rdD.Checked = False
            Case Else
                dapan = ""
        End Select

        If dapan <> "" Then
            dapanchon.SetValue(dapan, index)
        End If

        If dapan = caudung Then
            socaudung += 1
        End If
    End Sub


    Private Sub btnNopbai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNopbai.Click
        MsgBox("Điểm của bạn: " & socaudung * 10 / socauhoi, MsgBoxStyle.Information)
        For i As Integer = 0 To socauhoi - 1
            Console.WriteLine(dapanchon(i))
        Next
        'Application.Exit()
    End Sub
End Class