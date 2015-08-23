using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Do_An_Quan_Ly_Kho.Bussiness;
using ConvertDB;

namespace Do_An_Quan_Ly_Kho.KhuVuc
{
    public partial class frmKhuVuc_Them_Sua : Form
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

        public frmKhuVuc_Them_Sua()
        {
            InitializeComponent();
            tinh_trang = "them";

            txtMaKhuVuc.Text = SqlHelper.GenCode("KHU_VUC", "Ma_Khu_Vuc", "KV", 1);
        }

        public frmKhuVuc_Them_Sua(string ma_khu_vuc)
        {
            InitializeComponent();
            var kv = (from k in db.KHU_VUCs
                     where k.Ma_Khu_Vuc == ma_khu_vuc
                     select k).FirstOrDefault();
            if (kv == null)
            {
                MessageBox.Show("Không tìm thấy khu vực này.");
                return;
            }

            txtMaKhuVuc.Text = kv.Ma_Khu_Vuc;
            txtMaKhuVuc.Properties.ReadOnly = true;

            txtTenKhuVuc.Text = kv.Ten_Khu_Vuc;
            txtGhiChu.Text = kv.Ghi_Chu;

            //string vniText = kv.Ghi_Chu;
            //ConvertFont convert = new ConvertFont();
            //convert.Convert(ref vniText, FontIndex.iUNI, FontIndex.iVNI);
            //txtTest.Text = vniText;

            tinh_trang = "sua";
        }

        private FontIndex GetIndex(int index)
        {
            if (index == 0) return FontIndex.iUNI;
            if (index == 1) return FontIndex.iVNI;
            if (index == 2) return FontIndex.iTCV;
            if (index == 3) return FontIndex.iUTH;
            if (index == 4) return FontIndex.iUTF;
            return FontIndex.iNCR;
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
                    KHU_VUC kv = new KHU_VUC
                    {
                        Ma_Khu_Vuc = txtMaKhuVuc.Text,
                        Ten_Khu_Vuc = txtTenKhuVuc.Text,
                        Ghi_Chu = txtGhiChu.Text
                        //Ghi_Chu = txtTest.Text
                    };
                    db.KHU_VUCs.InsertOnSubmit(kv);
                }
                else
                {
                    var kv = (from k in db.KHU_VUCs
                              where k.Ma_Khu_Vuc == txtMaKhuVuc.Text
                              select k).FirstOrDefault();

                    kv.Ten_Khu_Vuc = txtTenKhuVuc.Text;
                    kv.Ghi_Chu = txtGhiChu.Text;
                    //kv.Ghi_Chu = txtTest.Text;
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

        private bool Check()
        {
            if (string.IsNullOrEmpty(txtMaKhuVuc.Text))
            {
                MessageBox.Show("Mã khu vực không được bỏ trống.");
                return false;
            }

            if (string.IsNullOrEmpty(txtTenKhuVuc.Text))
            {
                MessageBox.Show("Tên khu vực không được bỏ trống.");
                return false;
            }

            return true;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            //var rpt = new XtraReport1();
            //rpt.ShowPreview();
        }
    }
}
