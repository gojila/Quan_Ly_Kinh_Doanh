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
    public partial class NhomHang_Them_Sua : Form
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

        public NhomHang_Them_Sua()
        {
            InitializeComponent();
            tinh_trang = "them";

            txtMaNhomHang.Text = SqlHelper.GenCode("NHOM_HANG", "Ma_Nhom_Hang", "NH", 1);
        }

        public NhomHang_Them_Sua(string ma)
        {
            InitializeComponent();
            tinh_trang = "sua";

            var nh = (from n in db.NHOM_HANGs
                     where n.Ma_Nhom_Hang == ma
                     select n).FirstOrDefault();

            txtMaNhomHang.Text = nh.Ma_Nhom_Hang;
            txtMaNhomHang.Properties.ReadOnly = true;
            txtTenNhomHang.Text = nh.Ten_Nhom_Hang;
            txtGhiChu.Text = nh.Ghi_Chu;
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
                    NHOM_HANG nh = new NHOM_HANG 
                    { 
                        Ma_Nhom_Hang = txtMaNhomHang.Text,
                        Ten_Nhom_Hang = txtTenNhomHang.Text,
                        Ghi_Chu = txtGhiChu.Text

                    };

                    db.NHOM_HANGs.InsertOnSubmit(nh);
                }
                else
                {
                    var nh = (from n in db.NHOM_HANGs
                              where n.Ma_Nhom_Hang == txtMaNhomHang.Text
                              select n).FirstOrDefault();

                    nh.Ma_Nhom_Hang = txtMaNhomHang.Text;
                    nh.Ten_Nhom_Hang = txtTenNhomHang.Text;
                    nh.Ghi_Chu = txtGhiChu.Text;
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
            if (string.IsNullOrEmpty(txtMaNhomHang.Text))
            {
                MessageBox.Show("Mã nhóm hàng không được bỏ trống.");
                return false;
            }

            if (string.IsNullOrEmpty(txtTenNhomHang.Text))
            {
                MessageBox.Show("Tên nhóm hàng không được bỏ trống.");
                return false;
            }

            return true;
        }

        private void KhachHang_Them_Sua_Load(object sender, EventArgs e)
        {
        }
    }
}
