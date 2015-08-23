using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Do_An_Quan_Ly_Kho.Bussiness;

namespace Do_An_Quan_Ly_Kho.Kho
{
    public partial class frmKhoHang_Them_Sua : Form
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

        public frmKhoHang_Them_Sua()
        {
            InitializeComponent();
            tinh_trang = "them";

            txtMaKho.Text = SqlHelper.GenCode("KHO_HANG", "Ma_Kho", "K", 1);
        }

        public frmKhoHang_Them_Sua(string ma)
        {
            InitializeComponent();
            tinh_trang = "sua";

            var kho = (from k in db.KHO_HANGs
                       where k.Ma_Kho == ma
                       select k).FirstOrDefault();

            txtMaKho.Text = kho.Ma_Kho;
            txtMaKho.Properties.ReadOnly = true;
            txtTenKho.Text = kho.Ten_Kho;
            txtDiaChi.Text = kho.Dia_Chi;
            txtDienThoai.Text = kho.Dien_Thoai;
            txtFax.Text = kho.Fax;
            txtEmail.Text = kho.Email;
            txtDiDong.Text = kho.Di_Dong;
            txtThuKho.Text = kho.Thu_Kho;
            txtGhiChu.Text = kho.Ghi_Chu;
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
                    KHO_HANG kho = new KHO_HANG
                    {
                        Ma_Kho = txtMaKho.Text,
                        Ten_Kho = txtTenKho.Text,
                        Dia_Chi = txtDiaChi.Text,
                        Email = txtEmail.Text,
                        Dien_Thoai = txtDienThoai.Text,
                        Fax = txtFax.Text,
                        Di_Dong = txtDiDong.Text,
                        Thu_Kho = txtThuKho.Text,
                        Ghi_Chu = txtGhiChu.Text
                    };

                    db.KHO_HANGs.InsertOnSubmit(kho);
                }
                else
                {
                    var kho = (from k in db.KHO_HANGs
                              where k.Ma_Kho == txtMaKho.Text
                              select k).FirstOrDefault();

                    kho.Ma_Kho = txtMaKho.Text;
                    kho.Ten_Kho = txtTenKho.Text;
                    kho.Dia_Chi = txtDiaChi.Text;
                    kho.Email = txtEmail.Text;
                    kho.Dien_Thoai = txtDienThoai.Text;
                    kho.Fax = txtFax.Text;
                    kho.Di_Dong = txtDiDong.Text;
                    kho.Thu_Kho = txtThuKho.Text;
                    kho.Ghi_Chu = txtGhiChu.Text;
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
            if (string.IsNullOrEmpty(txtMaKho.Text))
            {
                MessageBox.Show("Mã kho không được bỏ trống.");
                return false;
            }

            if (string.IsNullOrEmpty(txtTenKho.Text))
            {
                MessageBox.Show("Tên kho không được bỏ trống.");
                return false;
            }

            return true;
        }

        private void KhachHang_Them_Sua_Load(object sender, EventArgs e)
        {
        }
    }
}
