Public Class frmQLSV

    Dim vitri As Integer
    Dim banglop As Boolean 'boolean là kiểu giá trị, có thể là true hoặc false

    Private Sub frmQLSV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS.BANGDIEM' table. You can move, or remove it, as needed.
        Me.BANGDIEMTableAdapter.Fill(Me.DS.BANGDIEM)
        'TODO: This line of code loads data into the 'DS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
        Me.GIAOVIEN_DANGKYTableAdapter.Fill(Me.DS.GIAOVIEN_DANGKY)
        'TODO: This line of code loads data into the 'DS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
        Me.GIAOVIEN_DANGKYTableAdapter.Fill(Me.DS.GIAOVIEN_DANGKY)
        'TODO: This line of code loads data into the 'DS.SINHVIEN' table. You can move, or remove it, as needed.
        Me.SINHVIENTableAdapter.Fill(Me.DS.SINHVIEN)
        'TODO: This line of code loads data into the 'DS.LOP' table. You can move, or remove it, as needed.
        Me.LOPTableAdapter.Fill(Me.DS.LOP)

        btnQuanlylop.Enabled = False
        btnQuanlysinhvien.Enabled = True
        dgvSINHVIEN.Enabled = False
        banglop = True
        grbQuanlysinhvien.Enabled = False

        btnGhi.Enabled = False
        btnPhuchoi.Enabled = False
    End Sub

    Private Sub btnQuanlylop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuanlylop.Click
        btnQuanlylop.Enabled = False
        btnQuanlysinhvien.Enabled = True
        dgvLOP.Enabled = True
        dgvSINHVIEN.Enabled = False
        grbQuanlylop.Enabled = True
        grbQuanlysinhvien.Enabled = False
        banglop = True
    End Sub

    Private Sub btnQuanlysinhvien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuanlysinhvien.Click
        btnQuanlylop.Enabled = True
        btnQuanlysinhvien.Enabled = False
        dgvLOP.Enabled = False
        dgvSINHVIEN.Enabled = True
        grbQuanlylop.Enabled = False
        grbQuanlysinhvien.Enabled = True
        banglop = False
    End Sub

    Private Sub themlop()
        vitri = bdsLOP.Position
        bdsLOP.AddNew()
        dgvLOP.Enabled = False
        btnThem.Enabled = False
        btnGhi.Enabled = True
        btnXoa.Enabled = False
        btnPhuchoi.Enabled = True
        btnTim.Enabled = False
        btnHieuchinh.Enabled = False

        btnQuanlysinhvien.Enabled = False

        txtMALOP.Focus()
    End Sub
    Private Sub ghilop()
        If txtMALOP.Text.Trim = "" Then
            MsgBox("Nhập mã lớp", MsgBoxStyle.Information)
            txtMALOP.Focus()
            Exit Sub
        End If
        If txtTENLOP.Text.Trim = "" Then
            MsgBox("Nhập tên lớp", MsgBoxStyle.Information)
            txtTENLOP.Focus()
            Exit Sub
        End If
        Try
            bdsLOP.EndEdit()
            bdsLOP.ResetCurrentItem()
            LOPTableAdapter.Update(DS.LOP)
            MsgBox("Thêm lớp thành công", MsgBoxStyle.Information)
            btnThem.Enabled = True
            btnHieuchinh.Enabled = True
            btnTim.Enabled = True
            btnXoa.Enabled = True
            btnGhi.Enabled = False
            btnPhuchoi.Enabled = False
            btnQuanlysinhvien.Enabled = True
        Catch ex As DBConcurrencyException
        Catch ex As Exception
            MsgBox("Lỗi ghi lớp" & vbCrLf & _
                Err.Description & vbCrLf & Err.Source)
        End Try
        dgvLOP.Enabled = True
    End Sub
    Private Sub phuchoilop()
        bdsLOP.CancelEdit()
        bdsLOP.Position = vitri
        dgvLOP.Enabled = True
        btnThem.Enabled = True
        btnXoa.Enabled = True
        btnGhi.Enabled = False
        btnPhuchoi.Enabled = False
        btnHieuchinh.Enabled = True
        btnTim.Enabled = True
        btnQuanlysinhvien.Enabled = True
    End Sub
    Private Sub hieuchinhlop()
        Try
            bdsLOP.EndEdit()
            bdsLOP.ResetCurrentItem()
            LOPTableAdapter.Update(DS.LOP)

        Catch ex As DBConcurrencyException
        Catch ex As Exception
            MsgBox("Lỗi hiệu chỉnh lớp" & vbCrLf & _
                Err.Description & vbCrLf & Err.Source)
        End Try
    End Sub
    Private Sub timlop()
        Dim tenlop As String
        tenlop = InputBox("Nhập tên lớp")
        If tenlop.Trim = "" Then
            bdsLOP.RemoveFilter()
        Else
            bdsLOP.Filter = "TENLOP ='" & tenlop & "'"

        End If
    End Sub
    Private Sub xoalop()
        If bdsLOP.Count = 0 Then
            MsgBox("Danh sách lớp trống", MsgBoxStyle.Information)
            Exit Sub
        End If
        If bdsSINHVIEN.Count > 0 Then
            MsgBox("Không thể xóa do đã có sinh viên thuộc lớp này", MsgBoxStyle.Information)
            Exit Sub
        End If
        If bdsGIAOVIEN_DANGKY.Count > 0 Then
            MsgBox("Không thể xóa do lớp này đã được đăng ký", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim yn As DialogResult

        yn = MsgBox("Bạn có muốn xóa lớp này?", MsgBoxStyle.YesNo)
        If yn = Windows.Forms.DialogResult.Yes Then
            Try

                bdsLOP.RemoveCurrent()
                LOPTableAdapter.Update(DS.LOP)
            Catch ex As Exception
                MsgBox("Lớp này không thể xóa", MsgBoxStyle.Information)
                Exit Sub
            End Try
        End If
    End Sub


    Private Sub themsinhvien()
        vitri = bdsSINHVIEN.Position
        bdsSINHVIEN.AddNew()
        dgvSINHVIEN.Enabled = False
        btnThem.Enabled = False
        btnGhi.Enabled = True
        btnXoa.Enabled = False
        btnPhuchoi.Enabled = True
        btnTim.Enabled = False
        btnHieuchinh.Enabled = False

        btnQuanlylop.Enabled = False

        cmbMALOP.Focus()
    End Sub
    Private Sub ghisinhvien()
        If cmbMALOP.Text.Trim = "" Then
            MsgBox("Chọn mã lớp", MsgBoxStyle.Information)
            cmbMALOP.Focus()
            Exit Sub
        End If
        If txtMASV.Text.Trim = "" Then
            MsgBox("Nhập mã sinh viên", MsgBoxStyle.Information)
            txtMASV.Focus()
            Exit Sub
        End If
        If txtHO.Text.Trim = "" Then
            MsgBox("Nhập họ sinh viên", MsgBoxStyle.Information)
            txtHO.Focus()
            Exit Sub
        End If
        If txtTEN.Text.Trim = "" Then
            MsgBox("Nhập tên sinh viên", MsgBoxStyle.Information)
            txtTEN.Focus()
            Exit Sub
        End If
        Try
            bdsSINHVIEN.EndEdit()
            bdsSINHVIEN.ResetCurrentItem()
            SINHVIENTableAdapter.Update(DS.SINHVIEN)
            MsgBox("Thêm sinh viên thành công", MsgBoxStyle.Information)
            btnThem.Enabled = True
            btnHieuchinh.Enabled = True
            btnTim.Enabled = True
            btnXoa.Enabled = True
            btnGhi.Enabled = False
            btnPhuchoi.Enabled = False
            btnQuanlylop.Enabled = True

        Catch ex As DBConcurrencyException
        Catch ex As Exception
            MsgBox("Lỗi ghi sinh viên" & vbCrLf & _
                Err.Description & vbCrLf & Err.Source)
        End Try
        dgvSINHVIEN.Enabled = True
    End Sub
    Private Sub phuchoisinhvien()
        bdsSINHVIEN.CancelEdit()
        bdsSINHVIEN.Position = vitri
        dgvSINHVIEN.Enabled = True
        btnThem.Enabled = True
        btnXoa.Enabled = True
        btnGhi.Enabled = False
        btnPhuchoi.Enabled = False
        btnHieuchinh.Enabled = True
        btnTim.Enabled = True
        btnQuanlylop.Enabled = True
    End Sub
    Private Sub hieuchinhsinhvien()
        Try
            bdsSINHVIEN.EndEdit()
            bdsSINHVIEN.ResetCurrentItem()
            SINHVIENTableAdapter.Update(DS.SINHVIEN)

        Catch ex As DBConcurrencyException
        Catch ex As Exception
            MsgBox("Lỗi hiệu chỉnh sinh viên" & vbCrLf & _
                Err.Description & vbCrLf & Err.Source)
        End Try
    End Sub
    Private Sub timsinhvien()
        Dim tensinhvien As String
        tensinhvien = InputBox("Nhập tên sinh viên")
        If tensinhvien.Trim = "" Then
            bdsSINHVIEN.RemoveFilter()
        Else
            bdsSINHVIEN.Filter = "TENSINHVIEN ='" & tensinhvien & "'"

        End If
    End Sub
    Private Sub xoasinhvien()
        If bdsSINHVIEN.Count = 0 Then
            MsgBox("Danh sách sinh viên trống", MsgBoxStyle.Information)
            Exit Sub
        End If
        If bdsBANGDIEM.Count > 0 Then
            MsgBox("Không thể xóa do sinh viên này đã có điểm trong hệ thống", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim yn As DialogResult

        yn = MsgBox("Bạn có muốn xóa sinh viên này?", MsgBoxStyle.YesNo)
        If yn = Windows.Forms.DialogResult.Yes Then
            Try

                bdsSINHVIEN.RemoveCurrent()
                SINHVIENTableAdapter.Update(DS.SINHVIEN)
            Catch ex As Exception
                MsgBox("Sinh viên này không thể xóa", MsgBoxStyle.Information)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub btnThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        If banglop = True Then
            themlop()
        Else
            themsinhvien()
        End If
    End Sub

    Private Sub btnHieuchinh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHieuchinh.Click

        If banglop = True Then
            hieuchinhlop()
        Else
            hieuchinhsinhvien()
        End If

    End Sub

    Private Sub btnGhi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGhi.Click
        If banglop = True Then
            ghilop()
        Else
            ghisinhvien()
        End If
    End Sub

    Private Sub btnTim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTim.Click
        If banglop = True Then
            timlop()
        Else
            timsinhvien()
        End If
    End Sub

    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        If banglop = True Then
            xoalop()
        Else
            xoasinhvien()
        End If
    End Sub

    Private Sub btnPhuchoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhuchoi.Click
        If banglop = True Then
            phuchoilop()
        Else
            phuchoisinhvien()
        End If
    End Sub
End Class
