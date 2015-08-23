using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Do_An_Quan_Ly_Kho.Bussiness;

namespace Do_An_Quan_Ly_Kho.NhanVien
{
    public partial class frmNhanVien_Them_Sua : Form
    {
        public delegate void ReloadEventHander(object sender);

        public event ReloadEventHander Reload;
        private void RaiseReloadEventHander()
        {
            if (Reload != null)
            {
                Reload(this);
            }
        }

        Data_QLKDataContext db = new Data_QLKDataContext(SqlHelper.ConnectionString);
        string tinh_trang = "them";

        public frmNhanVien_Them_Sua()
        {
            InitializeComponent();
            tinh_trang = "them";
            Nap_Danh_Sach_Cua_Hang();

            txtMaNhanVien.Text = SqlHelper.GenCode("NHAN_VIEN", "Ma_Nhan_Vien", "NV", 1);
        }

        public frmNhanVien_Them_Sua(string ma)
        {
            InitializeComponent();
            tinh_trang = "sua";
            Nap_Danh_Sach_Cua_Hang();

            var nhanvien = (from nv in db.NHAN_VIENs
                            where nv.Ma_Nhan_Vien == ma
                            select nv).FirstOrDefault();

            txtMaNhanVien.Text = nhanvien.Ma_Nhan_Vien;
            txtHoTen.Text = nhanvien.Ho_Ten;
            txtDiaChi.Text = nhanvien.Dia_Chi;
            txtNamSinh.Text = nhanvien.Nam_Sinh;
            txtDienThoai.Text = nhanvien.Dien_Thoai;
            txtNgayVaoLam.Text = nhanvien.Ngay_Vao_Lam;
            txtChucVu.Text = nhanvien.Chuc_Vu;
            txtBoPhan.Text = nhanvien.Bo_Phan;
            txtCuaHang.EditValue = nhanvien.Cua_Hang;
            txtGhiChu.Text = nhanvien.Ghi_Chu;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!Check())
            {
                return;
            }

            try
            {
                if (tinh_trang == "them")
                {
                    NHAN_VIEN nhanvien = new NHAN_VIEN
                    {
                        Ma_Nhan_Vien = txtMaNhanVien.Text,
                        Ho_Ten = txtHoTen.Text,
                        Dia_Chi = txtDiaChi.Text,
                        Nam_Sinh = txtNamSinh.Text,
                        Dien_Thoai = txtDienThoai.Text,
                        Ngay_Vao_Lam = txtNgayVaoLam.Text,
                        Chuc_Vu = txtChucVu.Text,
                        Bo_Phan = txtBoPhan.Text,
                        Cua_Hang = string.IsNullOrEmpty(txtCuaHang.Text) ? "" : txtCuaHang.EditValue.ToString(),
                        Ghi_Chu = txtGhiChu.Text
                    };

                    db.NHAN_VIENs.InsertOnSubmit(nhanvien);
                }
                else
                {
                    var nhanvien = (from nv in db.NHAN_VIENs
                                    where nv.Ma_Nhan_Vien == txtMaNhanVien.Text
                                    select nv).FirstOrDefault();

                    nhanvien.Ma_Nhan_Vien = txtMaNhanVien.Text;
                    nhanvien.Ho_Ten = txtHoTen.Text;
                    nhanvien.Dia_Chi = txtDiaChi.Text;
                    nhanvien.Nam_Sinh = txtNamSinh.Text;
                    nhanvien.Dien_Thoai = txtDienThoai.Text;
                    nhanvien.Ngay_Vao_Lam = txtNgayVaoLam.Text;
                    nhanvien.Chuc_Vu = txtChucVu.Text;
                    nhanvien.Bo_Phan = txtBoPhan.Text;
                    nhanvien.Cua_Hang = string.IsNullOrEmpty(txtCuaHang.Text) ? "" : txtCuaHang.EditValue.ToString();
                    nhanvien.Ghi_Chu = txtGhiChu.Text;
                }

                db.SubmitChanges();
                RaiseReloadEventHander();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Check()
        {
            if (string.IsNullOrEmpty(txtMaNhanVien.Text))
            {
                MessageBox.Show("Mã nhân viên không được bỏ trống.");
                return false;
            }

            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không được bỏ trống.");
                return false;
            }

            return true;
        }

        private void Nap_Danh_Sach_Cua_Hang()
        {
            cUA_HANGTableAdapter.Connection.ConnectionString = SqlHelper.ConnectionString;
            cUA_HANGTableAdapter.ClearBeforeFill = true;
            cUA_HANGTableAdapter.Fill(dsCuaHang.CUA_HANG);
        }
    }
}
