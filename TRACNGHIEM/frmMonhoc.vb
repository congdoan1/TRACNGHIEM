Public Class frmMonhoc
    Dim vitri As Integer

    Private Sub frmMonhoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS.BODE' table. You can move, or remove it, as needed.
        Me.BODETableAdapter.Fill(Me.DS.BODE)
        'TODO: This line of code loads data into the 'DS.BANGDIEM' table. You can move, or remove it, as needed.
        Me.BANGDIEMTableAdapter.Fill(Me.DS.BANGDIEM)
        'TODO: This line of code loads data into the 'DS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
        Me.GIAOVIEN_DANGKYTableAdapter.Fill(Me.DS.GIAOVIEN_DANGKY)
        daMH.Fill(DS, "MONHOC")
        btnGhi.Enabled = False
        btnPhuchoi.Enabled = False
    End Sub

    Private Sub btnThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        vitri = bdsMH.Position
        bdsMH.AddNew()

        dgvMH.Enabled = False
        btnThem.Enabled = False
        btnGhi.Enabled = True
        btnXoa.Enabled = False
        btnHieuchinh.Enabled = False
        btnTim.Enabled = False
        btnPhuchoi.Enabled = True

        txtMAMH.Focus()
    End Sub

    Private Sub btnPhuchoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhuchoi.Click
        bdsMH.CancelEdit()
        bdsMH.Position = vitri
        dgvMH.Enabled = True
        btnThem.Enabled = True
        btnGhi.Enabled = False
        btnXoa.Enabled = True
        btnHieuchinh.Enabled = True
        btnTim.Enabled = True
        btnPhuchoi.Enabled = False
    End Sub

    Private Sub btnGhi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGhi.Click

        If txtMAMH.Text.Trim = "" Then
            MsgBox("Mã môn học không được để trống", MsgBoxStyle.Information)
            txtMAMH.Focus()
            Exit Sub
        End If

        If txtTENMH.Text.Trim = "" Then
            MsgBox("Tên môn học không được để trống", MsgBoxStyle.Information)
            txtTENMH.Focus()
            Exit Sub
        End If
        Try
            bdsMH.EndEdit()
            bdsMH.ResetCurrentItem()
            daMH.Update(DS, "MONHOC")
            MsgBox("Thêm môn học thành công", MsgBoxStyle.Information)
            btnGhi.Enabled = False
            btnThem.Enabled = True
            btnHieuchinh.Enabled = True
            btnTim.Enabled = True
            btnXoa.Enabled = True
            btnPhuchoi.Enabled = False
        Catch ex As DBConcurrencyException
        Catch ex As Exception
            MsgBox("Lỗi thêm môn học" & vbCrLf & _
            Err.Description & vbCrLf & Err.Source)

        End Try
        dgvMH.Enabled = True
    End Sub

    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        If bdsMH.Count = 0 Then
            MsgBox("Danh sách môn học trống", MsgBoxStyle.Information)
            Exit Sub
        End If
        If bdsBANGDIEM.Count > 0 Then
            MsgBox("Không thể xóa môn học này", MsgBoxStyle.Information)
            Exit Sub
        End If
        If bdsBODE.Count > 0 Then
            MsgBox("Không thể xóa môn học này", MsgBoxStyle.Information)
            Exit Sub
        End If
        If bdsGIAOVIEN_DANGKY.Count > 0 Then
            MsgBox("Không thể xóa môn học", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim yn As DialogResult
        yn = MsgBox("Bạn có muốn xóa môn học này?", MsgBoxStyle.YesNo)
        If yn = Windows.Forms.DialogResult.Yes Then
            Try
                bdsMH.RemoveCurrent()
                daMH.Update(DS, "MONHOC")
            Catch ex As Exception
                MsgBox("Không thể xóa môn học này", MsgBoxStyle.Information)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub btnTim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTim.Click
        Dim tenmh As String
        tenmh = InputBox("Nhập tên môn học")

        If tenmh.Trim = "" Then
            bdsMH.RemoveFilter()
        Else
            bdsMH.Filter = "[TENMH] LIKE '%" & tenmh & "%'"
        End If

    End Sub

    Private Sub btnHieuchinh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHieuchinh.Click
        If txtMAMH.Text.Trim = "" Then
            MsgBox("Mã môn học không được để trống", MsgBoxStyle.Information)
            txtMAMH.Focus()
            Exit Sub
        End If

        If txtMAMH.Text.Trim = "" Then
            MsgBox("Mã môn học không được để trống", MsgBoxStyle.Information)
            txtMAMH.Focus()
            Exit Sub
        End If

        If txtTENMH.Text.Trim = "" Then
            MsgBox("Tên môn học không được để trống", MsgBoxStyle.Information)
            txtTENMH.Focus()
            Exit Sub
        End If

        Try
            bdsMH.EndEdit()
            bdsMH.ResetCurrentItem()
            daMH.Update(DS, "MONHOC")
        Catch ex As DBConcurrencyException
        Catch ex As Exception
            MsgBox("Lỗi chỉnh sửa môn học" & vbCrLf & _
            Err.Description & vbCrLf & Err.Source)

        End Try
        dgvMH.Enabled = True
    End Sub

End Class