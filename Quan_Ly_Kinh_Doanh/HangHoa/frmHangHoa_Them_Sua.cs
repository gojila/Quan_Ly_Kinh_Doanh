using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Do_An_Quan_Ly_Kho.Bussiness;
using System.IO;

namespace Do_An_Quan_Ly_Kho.HangHoa
{
    public partial class frmHangHoa_Them_Sua : Form
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

        public frmHangHoa_Them_Sua()
        {
            InitializeComponent();
            Nhom_Hang();
            tinh_trang = "them";

            txtMaHang.Text = SqlHelper.GenCode("HANG_HOA", "Ma_Hang", "HH", 1);
        }

        public frmHangHoa_Them_Sua(string ma)
        {
            InitializeComponent();
            Nhom_Hang();
            tinh_trang = "sua";

            var hh = (from h in db.HANG_HOAs
                       where h.Ma_Hang == ma
                       select h).FirstOrDefault();

            txtMaHang.Text = hh.Ma_Hang;
            txtMaHang.Properties.ReadOnly = true;
            txtTenHang.Text = hh.Ten_Hang;
            txtNhomHang.EditValue = hh.Nhom_Hang;
            txtGiaNhapKho.EditValue = hh.Gia_Nhap;
            txtGiaXuatKho.EditValue = hh.Gia_Xuat;
            txtDonVi.Text = hh.Don_Vi;
            txtGhiChu.Text = hh.Ghi_Chu;

            if (hh.Anh != null)
            {
                byte[] imageBytes = hh.Anh.ToArray();
                if (imageBytes != null)
                {
                    var ms = new MemoryStream(imageBytes);
                    var image = Image.FromStream(ms);
                    picAnh.Image = (Image)image.Clone();
                }
            }
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
                    HANG_HOA hh = new HANG_HOA 
                    { 
                        Ma_Hang = txtMaHang.Text,
                        Ten_Hang = txtTenHang.Text,
                        Nhom_Hang = string.IsNullOrEmpty(txtNhomHang.Text) ? "" : txtNhomHang.EditValue.ToString(),
                        Don_Vi = txtDonVi.Text,
                        Gia_Nhap = txtGiaNhapKho.Value,
                        Gia_Xuat = txtGiaXuatKho.Value,
                        Ghi_Chu = txtGhiChu.Text
                    };

                    if (picAnh.Image != null)
                    {
                        Image anh = picAnh.Image;
                        MemoryStream ms = new MemoryStream();
                        anh.Save(ms, anh.RawFormat);
                        byte[] anh_Bytes = ms.GetBuffer();
                        ms.Close();

                        hh.Anh = anh_Bytes;
                    }


                    db.HANG_HOAs.InsertOnSubmit(hh);
                }
                else
                {
                    var hh = (from h in db.HANG_HOAs
                              where h.Ma_Hang == txtMaHang.Text
                              select h).FirstOrDefault();

                    hh.Ma_Hang = txtMaHang.Text;
                    hh.Ten_Hang = txtTenHang.Text;
                    hh.Nhom_Hang = string.IsNullOrEmpty(txtNhomHang.Text) ? "" : txtNhomHang.EditValue.ToString();
                    hh.Don_Vi = txtDonVi.Text;
                    hh.Gia_Nhap = txtGiaNhapKho.Value;
                    hh.Gia_Xuat = txtGiaXuatKho.Value;
                    hh.Ghi_Chu = txtGhiChu.Text;

                    if (picAnh.Image != null)
                    {
                        Image anh = picAnh.Image;
                        MemoryStream ms = new MemoryStream();
                        anh.Save(ms, anh.RawFormat);
                        byte[] anh_Bytes = ms.GetBuffer();
                        ms.Close();

                        hh.Anh = anh_Bytes;
                    }
                    else
                    {
                        hh.Anh = null;
                    }
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
            if (string.IsNullOrEmpty(txtMaHang.Text))
            {
                MessageBox.Show("Mã hàng không được bỏ trống.");
                return false;
            }

            if (string.IsNullOrEmpty(txtTenHang.Text))
            {
                MessageBox.Show("Tên hàng không được bỏ trống.");
                return false;
            }

            return true;
        }

        private void KhachHang_Them_Sua_Load(object sender, EventArgs e)
        {
        }

        void Nhom_Hang()
        {
            nHOM_HANGTableAdapter.Connection.ConnectionString = SqlHelper.ConnectionString;
            nHOM_HANGTableAdapter.ClearBeforeFill = true;
            nHOM_HANGTableAdapter.Fill(dsHangHoa.NHOM_HANG);
        }
    }
}
