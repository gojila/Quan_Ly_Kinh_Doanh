using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using Do_An_Quan_Ly_Kho.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Do_An_Quan_Ly_Kho
{
    public partial class frmXuatNhapTon : Form
    {
        public frmXuatNhapTon()
        {
            InitializeComponent();

            DateTime tu = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime den = tu.AddMonths(1).AddDays(-1);

            dtTu.DateTime = tu;
            dtDen.DateTime = den;
            Nap_Danh_Sach_Kho_Hang();
            bbiXem_ItemClick(this, null);
        }

        void Set_Date(int month)
        {
            DateTime tu = new DateTime(DateTime.Now.Year, month, 1);
            DateTime den = tu.AddMonths(1).AddDays(-1);

            dtTu.DateTime = tu;
            dtDen.DateTime = den;
        }

        private void cbChonNgay_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = cbChonNgay.SelectedItem.ToString();
            switch (item)
            {
                case "Tháng 1":
                    Set_Date(1);
                    break;
                case "Tháng 2":
                    Set_Date(2);
                    break;
                case "Tháng 3":
                    Set_Date(3);
                    break;
                case "Tháng 4":
                    Set_Date(4);
                    break;
                case "Tháng 5":
                    Set_Date(5);
                    break;
                case "Tháng 6":
                    Set_Date(6);
                    break;
                case "Tháng 7":
                    Set_Date(7);
                    break;
                case "Tháng 8":
                    Set_Date(8);
                    break;
                case "Tháng 9":
                    Set_Date(9);
                    break;
                case "Tháng 10":
                    Set_Date(10);
                    break;
                case "Tháng 12":
                    Set_Date(12);
                    break;
            }
        }

        private void bbiXem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string sql =
            @"
                --DECLARE @FromDate DATETIME
                --DECLARE @ToDate DATETIME
                --
                --SET @FromDate = '1/1/2000'
                --SET @ToDate = '12/31/2018'

                SELECT XNT.Ma_Hang_Hoa,
                       hh.Ten_Hang,
                       hh.Nhom_Hang,
                       nh.Ten_Nhom_Hang,
                       hh.Don_Vi,
                       XNT.Ma_Kho_Hang,
                       kh.Ten_Kho,
                       XNT.So_Luong_Dau_Ky,
                       XNT.So_Luong_Nhap_Trong_Ky,
                       XNT.So_Luong_Xuat_Trong_Ky,
                       XNT.So_Luong_Cuoi_Ky
                FROM   (
                           SELECT ctct.Ma_Hang_Hoa,
                                  ctct.Ma_Kho_Hang,
                                  SUM(
                                      CASE 
                                           WHEN ctct.Loai_Chung_Tu = 1
                                      AND DATEDIFF(DAY, @FromDate, ct.Ngay) < 0 THEN ctct.So_Luong 
                                          WHEN ctct.Loai_Chung_Tu = 2
                                      AND DATEDIFF(DAY, @FromDate, ct.Ngay) < 0 THEN (ctct.So_Luong * -1)
                                          ELSE 0 
                                          END
                                  ) AS So_Luong_Dau_Ky,
                                  SUM(
                                      CASE 
                                           WHEN ctct.Loai_Chung_Tu = 1
                                      AND DATEDIFF(DAY, @FromDate, ct.Ngay) >= 0
                                      AND DATEDIFF(DAY, @ToDate, ct.Ngay) <= 0 THEN ctct.So_Luong 
                                          ELSE 0 
                                          END
                                  ) AS So_Luong_Nhap_Trong_Ky,
                                  SUM(
                                      CASE 
                                           WHEN ctct.Loai_Chung_Tu = 2
                                      AND DATEDIFF(DAY, @FromDate, ct.Ngay) >= 0
                                      AND DATEDIFF(DAY, @ToDate, ct.Ngay) <= 0 THEN ctct.So_Luong 
                                          ELSE 0 
                                          END
                                  ) AS So_Luong_Xuat_Trong_Ky,
                                  SUM(
                                      CASE 
                                           WHEN ctct.Loai_Chung_Tu = 1
                                      AND DATEDIFF(DAY, @ToDate, ct.Ngay) <= 0 THEN ctct.So_Luong 
                                          WHEN ctct.Loai_Chung_Tu = 2
                                      AND DATEDIFF(DAY, @ToDate, ct.Ngay) <= 0 THEN (ctct.So_Luong * -1)
                                          ELSE 0 
                                          END
                                  ) AS So_Luong_Cuoi_Ky
                           FROM   CHUNG_TU_CHI_TIET ctct
                                  LEFT OUTER JOIN CHUNG_TU ct
                                       ON  ct.Ma_Chung_Tu = ctct.Ma_Chung_Tu
                           WHERE  DATEDIFF(DAY, @ToDate, ct.Ngay) <= 0
                                  AND (@KhoHang = 'all' OR ctct.Ma_Kho_Hang = @KhoHang)
                           GROUP BY
                                  ctct.Ma_Hang_Hoa,
                                  ctct.Ma_Kho_Hang
                       )
                       XNT
                       LEFT OUTER JOIN HANG_HOA hh
                            ON  XNT.Ma_Hang_Hoa = hh.Ma_Hang
                       LEFT OUTER JOIN NHOM_HANG nh
                            ON  nh.Ma_Nhom_Hang = hh.Nhom_Hang
                       LEFT OUTER JOIN KHO_HANG kh
                            ON  XNT.Ma_Kho_Hang = kh.Ma_Kho
            ";

            string[] myPara = { "@FromDate", "@ToDate", "@KhoHang" };
            object[] myValue = { dtTu.DateTime, dtDen.DateTime, txtKhoHang.EditValue.ToString() };

            var sqlHelper = new SqlHelper();
            dsXuatNhapTon.Xuat_Nhap_Ton_Theo_Ngay.Rows.Clear();
            dsXuatNhapTon.Xuat_Nhap_Ton_Theo_Ngay.Merge(sqlHelper.ExecuteDataTable(sql, myPara, myValue));

            gbList.BestFitColumns();
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

        private void bbiXuatExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string path = "";
            SaveFileDialog dialog1 = new SaveFileDialog();
            dialog1.Filter = "Excel Files (*.xls)|*.xls|All Files (*.*)|*.*";
            if (dialog1.ShowDialog() == DialogResult.OK)
            {
                path = dialog1.FileName;
                gcList.ExportToXls(path, new DevExpress.XtraPrinting.XlsExportOptions(TextExportMode.Text, true, true));

                if (File.Exists(dialog1.FileName))
                {
                    if (XtraMessageBox.Show("Bạn muốn mở không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                    Process.Start(dialog1.FileName);
                }
            }
            
        }

        private void Nap_Danh_Sach_Kho_Hang()
        {
            var db = new Data_QLKDataContext(SqlHelper.ConnectionString);
            var khoHangs = (from kh in db.KHO_HANGs
                           select kh).ToList();

            var tatCa = new KHO_HANG();
            tatCa.Ma_Kho = "all";
            tatCa.Ten_Kho = "Tất cả";

            //khoHangs.Add(tatCa);
            khoHangs.Insert(0, tatCa);

            txtKhoHang.Properties.DataSource = khoHangs;
            if(khoHangs.Count() > 0)
            {
                txtKhoHang.EditValue = "all";
            }
            txtKhoHang_View.BestFitColumns();
        }

        private void txtKhoHang_EditValueChanged(object sender, EventArgs e)
        {
            bbiXem_ItemClick(this, null);
        }        
    }
}
