using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Do_An_Quan_Ly_Kho.Bussiness;
using Do_An_Quan_Ly_Kho.KhachHang;
using Do_An_Quan_Ly_Kho.Kho;
using DevExpress.XtraGrid.Views.Grid;

namespace Do_An_Quan_Ly_Kho.NhomHang
{
    public partial class frmNhomHang : Form
    {
        public frmNhomHang()
        {
            InitializeComponent();

            gbList.ShownEditor += (s, e) =>
            {
                var view = s as GridView;
                view.ActiveEditor.DoubleClick += ActiveEditor_DoubleClick;
            };

            bbiXem_ItemClick(this, null);
        }

        private void ActiveEditor_DoubleClick(object sender, EventArgs e)
        {
            bbiSua_ItemClick(this, null);
        }

        private void bbiThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NhomHang_Them_Sua frm = new NhomHang_Them_Sua();
            frm.Reload += frm_Reload;
            frm.ShowDialog();
        }

        void frm_Reload(object sender)
        {
            bbiXem_ItemClick(this, null);
        }

        private void bbiXem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nHOM_HANGTableAdapter.Connection.ConnectionString = SqlHelper.ConnectionString;
            nHOM_HANGTableAdapter.ClearBeforeFill = true;
            nHOM_HANGTableAdapter.Fill(dsNhomHang.NHOM_HANG);
        }

        private void gbList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            int rowIndex = e.RowHandle;
            if (rowIndex >= 0)
            {
                rowIndex++;
                e.Info.DisplayText = rowIndex.ToString();
            }
        }

        private void bbiSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ma = gbList.GetFocusedRowCellValue(colMa_Nhom_Hang);
            if (ma == null)
                return;
            
            NhomHang_Them_Sua frm = new NhomHang_Them_Sua(ma.ToString());
            frm.Reload += frm_Reload;
            frm.ShowDialog();
        }

        private void bbiXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            var db = new Data_QLKDataContext(SqlHelper.ConnectionString);

            int[] selectedRows = gbList.GetSelectedRows();
            string[] nhomhang = new string[selectedRows.Length];
            for (int i = selectedRows.Length; i > 0; i--)
            {
                var arg = gbList.GetRowCellValue(selectedRows[i - 1], colMa_Nhom_Hang);
                if (arg == null)
                    continue;
                nhomhang[i - 1] = arg.ToString();
            }

            var nh = from n in db.NHOM_HANGs
                     where nhomhang.Contains(n.Ma_Nhom_Hang)
                     select n;


            foreach (var n in nh)
            {
                db.NHOM_HANGs.DeleteOnSubmit(n);
            }

            try
            {
                db.SubmitChanges();
                bbiXem_ItemClick(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bbiDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Kho_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
