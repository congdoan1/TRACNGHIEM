Public Class MainForm

    Private Sub tsmiVaothi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiVaothi.Click
        Dim frmLambai = New frmLambai
        frmLambai.MdiParent = Me
        frmLambai.Dock = DockStyle.Fill
        frmLambai.Show()
    End Sub

    Private Sub tsmiNhapde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiNhapde.Click
        Dim frmDethi = New frmDethi
        frmDethi.MdiParent = Me
        frmDethi.Dock = DockStyle.Fill
        frmDethi.Show()
    End Sub

    Private Sub tsmiDangkythi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiDangkythi.Click
        Dim frmDangky = New frmDangky
        frmDangky.MdiParent = Me
        frmDangky.Dock = DockStyle.Fill
        frmDangky.Show()
    End Sub

    Private Sub tsmiMH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiMH.Click
        Dim frmMonhoc = New frmMonhoc
        frmMonhoc.MdiParent = Me
        frmMonhoc.Dock = DockStyle.Fill
        frmMonhoc.Show()
    End Sub

    Private Sub tsmiSV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiSV.Click
        Dim frmQLSV = New frmQLSV
        frmQLSV.MdiParent = Me
        frmQLSV.Dock = DockStyle.Fill
        frmQLSV.Show()
    End Sub

    Private Sub tsmiGV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiGV.Click
        Dim frmGiaovien = New frmGiaovien
        frmGiaovien.MdiParent = Me
        frmGiaovien.Dock = DockStyle.Fill
        frmGiaovien.Show()
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tsmiVaothi_Click(sender, e)
    End Sub
End Class
