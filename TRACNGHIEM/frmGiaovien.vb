Public Class frmGiaovien
    Dim vitri As Integer 'khai báo vị trí mình đang chọn trong data gridview để thao tác

    Private Sub frmGiaovien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
        Me.GIAOVIEN_DANGKYTableAdapter.Fill(Me.DS.GIAOVIEN_DANGKY)
        'TODO: This line of code loads data into the 'DS.BODE' table. You can move, or remove it, as needed.
        Me.BODETableAdapter.Fill(Me.DS.BODE)
        'TODO: This line of code loads data into the 'DS.Giaovien' table. You can move, or remove it, as needed.
        Me.GIAOVIENTableAdapter.Fill(Me.DS.GIAOVIEN)
        btnGhi.Enabled = False
        btnPhuchoi.Enabled = False
    End Sub

   Private Sub btnThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        vitri = bdsGV.Position 'ghi lại vị trí mình click trước đó
        bdsGV.AddNew() 'thêm 1 dòng trống vào để nhập dữ liệu

        dgvGV.Enabled = False
        btnThem.Enabled = False
        btnGhi.Enabled = True 'sau khi Thêm sẽ sáng lên khi TRUE, còn lại FALSE sẽ bị mờ
        btnXoa.Enabled = False
        btnHieuchinh.Enabled = False
        btnTim.Enabled = False
        btnPhuchoi.Enabled = True

        txtMAGV.Focus() 'đưa con trỏ chuột vào ô đó
    End Sub


    Private Sub btnGhi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGhi.Click
        If txtMAGV.Text.Trim = "" Then
            MsgBox("Mã giáo viên không được để trống", MsgBoxStyle.Information)
            txtMAGV.Focus()
            Exit Sub
        End If

        If txtHO.Text.Trim = "" Then
            MsgBox("Họ không được để trống", MsgBoxStyle.Information)
            txtHO.Focus()
            Exit Sub
        End If

        If txtTEN.Text.Trim = "" Then
            MsgBox("Tên không được để trống", MsgBoxStyle.Information)
            txtTEN.Focus()
            Exit Sub
        End If
        'Thực hiện ghi 1 giáo viên mới vào database, nếu mà có lỗi xảy ra(gv đó đã tồn tại, or kết nối tới database bị lỗi..)
        'thì sẽ chạy vào dòng catch,hiện lên thông báo lỗi
        Try
            bdsGV.EndEdit()
            bdsGV.ResetCurrentItem()
            GIAOVIENTableAdapter.Update(DS.GIAOVIEN)
            MsgBox("Thêm giáo viên thành công", MsgBoxStyle.Information)
            btnGhi.Enabled = False
            btnThem.Enabled = True
            btnHieuchinh.Enabled = True
            btnTim.Enabled = True
            btnXoa.Enabled = True
            btnPhuchoi.Enabled = False
        Catch ex As DBConcurrencyException
        Catch ex As Exception
            MsgBox("Lỗi thêm giáo viên" & vbCrLf & _
            Err.Description & vbCrLf & Err.Source)

        End Try
        'enable data grid view để mình có thể chọn (click) trong đó
        dgvGV.Enabled = True
    End Sub

    Private Sub btnTim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTim.Click
        Dim tengv As String 'khai báo 1 chuỗi để chứa giá trị nhập vào khi mình tìm
        tengv = InputBox("Nhập tên giáo viên")

        If tengv.Trim = "" Then
            bdsGV.RemoveFilter() 'khi tìm xong và muốn trở lại bảng dl ban đầu thì KO NHẬP gì nó sẽ xóa lọc và hiện ra bảng dl ban đầu
        Else
            bdsGV.Filter = "[HO]+' '+[TEN] LIKE '%" & tengv & "%'"
        End If
    End Sub

    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        If bdsGV.Count = 0 Then
            MsgBox("Danh sách giáo viên trống", MsgBoxStyle.Information)
            Exit Sub
        End If
        If bdsBODE.Count > 0 Then
            MsgBox("Không thể xóa giáo viên này", MsgBoxStyle.Information)
            Exit Sub
        End If
        If bdsGIAOVIEN_DANGKY.Count > 0 Then
            MsgBox("Không thể xóa giáo viên này", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim yn As DialogResult 'yn là yes/no 
        yn = MsgBox("Bạn có muốn xóa giáo viên này?", MsgBoxStyle.YesNo)
        If yn = Windows.Forms.DialogResult.Yes Then
            Try
                bdsGV.RemoveCurrent() 'xóa dòng mình đang chọn
                GIAOVIENTableAdapter.Update(DS.GIAOVIEN) 'cập nhật lại data gridview
            Catch ex As Exception
                MsgBox("Không thể xóa giáo viên này", MsgBoxStyle.Information) 'nếu có lỗi database thì sẽ hiện ra câu này
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub btnHieuchinh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHieuchinh.Click
        If txtMAGV.Text.Trim = "" Then
            MsgBox("Mã giáo viên không được để trống", MsgBoxStyle.Information)
            txtMAGV.Focus()
            Exit Sub
        End If

        If txtHO.Text.Trim = "" Then
            MsgBox("Họ không được để trống", MsgBoxStyle.Information)
            txtHO.Focus()
            Exit Sub
        End If

        If txtTEN.Text.Trim = "" Then
            MsgBox("Tên không được để trống", MsgBoxStyle.Information)
            txtTEN.Focus()
            Exit Sub
        End If

        Try
            bdsGV.EndEdit()
            bdsGV.ResetCurrentItem()
            GIAOVIENTableAdapter.Update(DS.GIAOVIEN)
        Catch ex As DBConcurrencyException
        Catch ex As Exception
            MsgBox("Lỗi thêm giáo viên" & vbCrLf & _
            Err.Description & vbCrLf & Err.Source)

        End Try
        dgvGV.Enabled = True
    End Sub

    Private Sub btnPhuchoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhuchoi.Click
        bdsGV.CancelEdit()
        bdsGV.Position = vitri
        dgvGV.Enabled = True
        btnThem.Enabled = True
        btnGhi.Enabled = False
        btnXoa.Enabled = True
        btnHieuchinh.Enabled = True
        btnTim.Enabled = True
        btnPhuchoi.Enabled = False
    End Sub
End Class