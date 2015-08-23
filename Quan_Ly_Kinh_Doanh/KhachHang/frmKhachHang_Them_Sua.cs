using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Do_An_Quan_Ly_Kho.Bussiness;
using Do_An_Quan_Ly_Kho.Bussiness;

namespace Do_An_Quan_Ly_Kho.KhachHang
{
    public partial class frmKhachHang_Them_Sua : Form
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

        public frmKhachHang_Them_Sua()
        {
            InitializeComponent();
            Khu_Vuc();
            tinh_trang = "them";

            txtMaKhachHang.Text = SqlHelper.GenCode("KHACH_HANG", "Ma_Khach_Hang", "KH", 1);
        }

        public frmKhachHang_Them_Sua(string ma)
        {
            InitializeComponent();
            Khu_Vuc();
            tinh_trang = "sua";

            var kh = (from k in db.KHACH_HANGs
                     where k.Ma_Khach_Hang == ma
                      select k).FirstOrDefault();

            txtMaKhachHang.Text = kh.Ma_Khach_Hang;
            txtTenKhachHang.Text = kh.Ten_Khach_Hang;
            txtKhuVuc.EditValue = kh.Ma_Khu_Vuc;
            txtDiaChi.Text = kh.Dia_Chi;
            txtMaSoThue.Text = kh.Ma_So_Thue;
            txtDienThoai.Text = kh.Dien_Thoai;
            txtFax.Text = kh.Fax;
            txtEmail.Text = kh.Email;
            txtDiDong.Text = kh.Di_Dong;
            txtWebsite.Text = kh.Website;
            txtNguoiLienHe.Text = kh.Nguoi_Lien_He;
            txtYahoo.Text = kh.NickYM;
            txtSkype.Text = kh.NickSky;
            txtTaiKhoanNganHang.Text = kh.Tai_Khoan_Ngan_Hang;
            txtTenNganHang.Text = kh.Ten_Ngan_Hang;
            txtGhiChu.Text = kh.Ghi_Chu;
        }

        void Khu_Vuc()
        {
            kHU_VUCTableAdapter.Connection.ConnectionString = SqlHelper.ConnectionString;
            kHU_VUCTableAdapter.ClearBeforeFill = true;
            kHU_VUCTableAdapter.Fill(dsKhachHang.KHU_VUC);
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
                    KHACH_HANG kh = new KHACH_HANG
                    {
                        Ma_Khach_Hang = txtMaKhachHang.Text,
                        Ten_Khach_Hang = txtTenKhachHang.Text,
                        Ma_Khu_Vuc = string.IsNullOrEmpty(txtKhuVuc.Text) ? "" : txtKhuVuc.EditValue.ToString(),
                        Dia_Chi = txtDiaChi.Text,
                        Ma_So_Thue = txtMaSoThue.Text,
                        Dien_Thoai = txtDienThoai.Text,
                        Fax = txtFax.Text,
                        Email = txtEmail.Text,
                        Di_Dong = txtDiDong.Text,
                        Website = txtWebsite.Text,
                        Nguoi_Lien_He = txtNguoiLienHe.Text,
                        NickYM = txtYahoo.Text,
                        NickSky = txtSkype.Text,
                        Tai_Khoan_Ngan_Hang = txtTaiKhoanNganHang.Text,
                        Ten_Ngan_Hang = txtTenNganHang.Text,
                        Ghi_Chu = txtGhiChu.Text
                    };

                    db.KHACH_HANGs.InsertOnSubmit(kh);
                }
                else
                {
                    var kh = (from k in db.KHACH_HANGs
                              where k.Ma_Khach_Hang == txtMaKhachHang.Text
                              select k).FirstOrDefault();

                    kh.Ma_Khach_Hang = txtMaKhachHang.Text;
                    kh.Ten_Khach_Hang = txtTenKhachHang.Text;
                    kh.Ma_Khu_Vuc = string.IsNullOrEmpty(txtKhuVuc.Text) ? "" : txtKhuVuc.EditValue.ToString();
                    kh.Dia_Chi = txtDiaChi.Text;
                    kh.Ma_So_Thue = txtMaSoThue.Text;
                    kh.Dien_Thoai = txtDienThoai.Text;
                    kh.Fax = txtFax.Text;
                    kh.Email = txtEmail.Text;
                    kh.Di_Dong = txtDiDong.Text;
                    kh.Website = txtWebsite.Text;
                    kh.Nguoi_Lien_He = txtNguoiLienHe.Text;
                    kh.NickYM = txtYahoo.Text;
                    kh.NickSky = txtSkype.Text;
                    kh.Tai_Khoan_Ngan_Hang = txtTaiKhoanNganHang.Text;
                    kh.Ten_Ngan_Hang = txtTenNganHang.Text;
                    kh.Ghi_Chu = txtGhiChu.Text;
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
            if (string.IsNullOrEmpty(txtMaKhachHang.Text))
            {
                MessageBox.Show("Mã khách hàng không được bỏ trống.");
                return false;
            }

            if (string.IsNullOrEmpty(txtTenKhachHang.Text))
            {
                MessageBox.Show("Tên khách hàng không được bỏ trống.");
                return false;
            }

            return true;
        }

        private void KhachHang_Them_Sua_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsKhachHang.KHU_VUC' table. You can move, or remove it, as needed.
            this.kHU_VUCTableAdapter.Fill(this.dsKhachHang.KHU_VUC);

        }
    }
}
