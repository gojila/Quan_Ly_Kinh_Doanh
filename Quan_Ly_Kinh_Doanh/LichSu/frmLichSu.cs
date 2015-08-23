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
    public partial class frmLichSu : Form
    {
        public frmLichSu()
        {
            InitializeComponent();

            DateTime tu = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime den = tu.AddMonths(1).AddDays(-1);

            dtTu.DateTime = tu;
            dtDen.DateTime = den;

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
                SELECT ct.Ma_Chung_Tu,
                       ct.Ngay,
                       ct.Ma_Hoa_Don,
                       ct.Ma_Khach_Hang,
                       kh.Ten_Khach_Hang,
                       ct.Ly_Do,
                       ctct.Ma_Hang_Hoa,
                       hh.Ten_Hang,
                       hh.Don_Vi,
                       ctct.Loai_Chung_Tu,
                       ctct.Ma_Kho_Hang,
                       kh2.Ten_Kho,
                       CASE 
                            WHEN ctct.Loai_Chung_Tu = 1 THEN ctct.So_Luong
                       END AS So_Luong_Nhap,
                       CASE 
                            WHEN ctct.Loai_Chung_Tu = 1 THEN ctct.Don_Gia
                       END AS Don_Gia_Nhap,
                       CASE 
                            WHEN ctct.Loai_Chung_Tu = 1 THEN ctct.Thanh_Tien
                       END Thanh_Tien_Nhap,
                       CASE 
                            WHEN ctct.Loai_Chung_Tu = 2 THEN ctct.So_Luong
                       END AS So_Luong_Xuat,
                       CASE 
                            WHEN ctct.Loai_Chung_Tu = 2 THEN ctct.Don_Gia
                       END AS Don_Gia_Xuat,
                       CASE 
                            WHEN ctct.Loai_Chung_Tu = 2 THEN ctct.Thanh_Tien
                       END AS Thanh_Tien_Xuat,
                       ctct.So_Luong,
                       ctct.Don_Gia,
                       ctct.Thanh_Tien,
                       ctct.Ghi_Chu
                FROM   CHUNG_TU_CHI_TIET ctct
                       LEFT OUTER JOIN CHUNG_TU ct
                            ON  ct.Ma_Chung_Tu = ctct.Ma_Chung_Tu
                       LEFT OUTER JOIN HANG_HOA hh
                            ON  hh.Ma_Hang = ctct.Ma_Hang_Hoa
                       LEFT OUTER JOIN KHACH_HANG kh
                            ON  kh.Ma_Khach_Hang = ct.Ma_Khach_Hang
                       LEFT OUTER JOIN KHO_HANG kh2
                            ON  kh2.Ma_Kho = ctct.Ma_Kho_Hang
                WHERE  DATEDIFF(DAY, @FromDate, ct.Ngay) >= 0
                       AND DATEDIFF(DAY, @ToDate, ct.Ngay) <= 0
            ";

            string[] myPara = { "@FromDate", "@ToDate" };
            object[] myValue = { dtTu.DateTime, dtDen.DateTime };

            var sqlHelper = new SqlHelper();

            dsLichSu.Lich_Su_Theo_Ngay.Rows.Clear();
            dsLichSu.Lich_Su_Theo_Ngay.Merge(sqlHelper.ExecuteDataTable(sql, myPara, myValue));

            gbList.BestFitColumns();
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

        private void gbList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            int rowIndex = e.RowHandle;
            if (rowIndex >= 0)
            {
                rowIndex++;
                e.Info.DisplayText = rowIndex.ToString();
            }
        }
    }
}
