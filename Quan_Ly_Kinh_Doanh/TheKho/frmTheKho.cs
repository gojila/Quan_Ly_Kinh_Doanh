using Do_An_Quan_Ly_Kho.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Do_An_Quan_Ly_Kho
{
    public partial class frmTheKho : Form
    {
        public frmTheKho()
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

        private void gbList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            int rowIndex = e.RowHandle;
            if (rowIndex >= 0)
            {
                rowIndex++;
                e.Info.DisplayText = rowIndex.ToString();
            }
        }

        private void bbiXem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string sql =
            @"
                /************************************************************
 * Code formatted by SoftTree SQL Assistant © v6.0.70
 * Time: 20/07/2015 5:07:34 CH
 ************************************************************/

--DECLARE @FromDate DATETIME
--DECLARE @ToDate DATETIME
--                
--SET @FromDate = '1/1/2000'
--SET @ToDate = '12/31/2016'

DECLARE @TheKho_TB TABLE (
            Ma_Chung_Tu VARCHAR(250) NULL,
            Ngay DATETIME NULL,
            Ngay_Sap_Xep DATETIME NULL,
            Ma_Hoa_Don VARCHAR(250) NULL,
            Ma_Hang_Hoa VARCHAR(250) NULL,
            Ma_Kho_Hang VARCHAR(250) NULL,
            Loai_Chung_Tu INT NULL,
            Dien_Giai NVARCHAR(250) NULL,
            So_Luong_Nhap MONEY NULL,
            So_Luong_Xuat MONEY NULL,
            So_Luong_Thuc MONEY NULL,
            So_Luong_Ton MONEY NULL,
            Ghi_Chu NVARCHAR(250) NULL
        )


DECLARE @Ma_Chung_Tu VARCHAR(250)
DECLARE @Ngay DATETIME
DECLARE @Ngay_Sap_Xep DATETIME
DECLARE @Ma_Hoa_Don VARCHAR(250)
DECLARE @Ma_Hang_Hoa VARCHAR(250)
DECLARE @Ma_Kho_Hang VARCHAR(250)
DECLARE @Loai_Chung_Tu INT
DECLARE @Dien_Giai NVARCHAR(250)
DECLARE @So_Luong_Nhap MONEY
DECLARE @So_Luong_Xuat MONEY
DECLARE @So_Luong_Thuc MONEY
DECLARE @So_Luong_Ton MONEY
DECLARE @Ghi_Chu NVARCHAR(250)

DECLARE @getTheKho CURSOR             
SET @getTheKho =              CURSOR FOR
SELECT *
FROM   (
           SELECT ct.Ma_Chung_Tu,
                  ct.Ngay,
                  ct.Ngay AS Ngay_Sap_Xep,
                  ct.Ma_Hoa_Don,
                  ctct.Ma_Hang_Hoa,
                  ctct.Ma_Kho_Hang,
                  ctct.Loai_Chung_Tu,
                  CASE 
                       WHEN ctct.Loai_Chung_Tu = 1 THEN N'Nhập'
                       ELSE N'Xuất'
                  END AS Dien_Giai,
                  CASE 
                       WHEN ctct.Loai_Chung_Tu = 1 THEN ctct.So_Luong
                  END AS So_Luong_Nhap,
                  CASE 
                       WHEN ctct.Loai_Chung_Tu = 2 THEN ctct.So_Luong
                  END AS So_Luong_Xuat,
                  CASE 
                       WHEN ctct.Loai_Chung_Tu = 1 THEN ctct.So_Luong
                       ELSE (ctct.So_Luong * -1)
                  END AS So_Luong_Thuc,
                  ctct.Ghi_Chu
           FROM   CHUNG_TU_CHI_TIET ctct
                  LEFT OUTER JOIN CHUNG_TU ct
                       ON  ct.Ma_Chung_Tu = ctct.Ma_Chung_Tu
           WHERE  DATEDIFF(DAY, @FromDate, ct.Ngay) >= 0
                  AND DATEDIFF(DAY, @ToDate, ct.Ngay) <= 0
           
           UNION ALL
           
           SELECT '',
                  CAST(NULL AS DATETIME),
                  CAST('1/1/1753' AS DATETIME),
                  '',
                  Ton_Kho_Dau_Ky.Ma_Hang_Hoa,
                  Ton_Kho_Dau_Ky.Ma_Kho_Hang,
                  CAST(NULL AS INT),
                  N'Đầu kỳ',
                  CAST(NULL AS MONEY),
                  CAST(NULL AS MONEY),
                  Ton_Kho_Dau_Ky.So_Luong_Thuc,
                  N'Đầu kỳ'
           FROM   (
                      SELECT ctct.Ma_Hang_Hoa,
                             ctct.Ma_Kho_Hang,
                             SUM(
                                 CASE 
                                      WHEN ctct.Loai_Chung_Tu = 1 THEN ctct.So_Luong
                                      ELSE (ctct.So_Luong * -1)
                                 END
                             ) AS So_Luong_Thuc
                      FROM   CHUNG_TU_CHI_TIET ctct
                             LEFT OUTER JOIN CHUNG_TU ct
                                  ON  ct.Ma_Chung_Tu = ctct.Ma_Chung_Tu
                      WHERE  DATEDIFF(DAY, @FromDate, ct.Ngay) < 0
                      GROUP BY
                             ctct.Ma_Hang_Hoa,
                             ctct.Ma_Kho_Hang
                  )Ton_Kho_Dau_Ky
       ) The_Kho
ORDER BY
       The_Kho.Ma_Hang_Hoa,
       The_Kho.Ma_Kho_Hang,
       The_Kho.Ngay_Sap_Xep
                --SELECT ct.Ma_Chung_Tu,
                --       ct.Ngay,
                --       ct.Ngay AS Ngay_Sap_Xep,
                --       ct.Ma_Hoa_Don,
                --       ctct.Ma_Hang_Hoa,
                --       ctct.Ma_Kho_Hang,
                --       ctct.Loai_Chung_Tu,
                --       CASE
                --            WHEN ctct.Loai_Chung_Tu = 1 THEN N'Nh?p'
                --            ELSE N'Xu?t'
                --       END AS Dien_Giai,
                --       CASE
                --            WHEN ctct.Loai_Chung_Tu = 1 THEN ctct.So_Luong
                --       END AS So_Luong_Nhap,
                --       CASE
                --            WHEN ctct.Loai_Chung_Tu = 2 THEN ctct.So_Luong
                --       END AS So_Luong_Xuat,
                --       CASE
                --            WHEN ctct.Loai_Chung_Tu = 1 THEN ctct.So_Luong
                --            ELSE (ctct.So_Luong * -1)
                --       END AS So_Luong_Thuc,
                --       ctct.Ghi_Chu
                --FROM   CHUNG_TU_CHI_TIET ctct
                --       LEFT OUTER JOIN CHUNG_TU ct
                --            ON  ct.Ma_Chung_Tu = ctct.Ma_Chung_Tu
                --WHERE  DATEDIFF(DAY, @FromDate, ct.Ngay) >= 0
                --       AND DATEDIFF(DAY, @ToDate, ct.Ngay) <= 0
                --ORDER BY
                --       ctct.Ma_Hang_Hoa,
                --       ctct.Ma_Kho_Hang,
                --       ct.Ngay


DECLARE @Ma_Hang_Hoa_Tam VARCHAR(250)
DECLARE @Ma_Kho_Hang_Tam VARCHAR(250)

SET @Ma_Hang_Hoa_Tam = ''
SET @Ma_Kho_Hang_Tam = ''
SET @So_Luong_Ton = 0

                OPEN @getTheKho
                FETCH NEXT
                FROM @getTheKho INTO @Ma_Chung_Tu, @Ngay, @Ngay_Sap_Xep, @Ma_Hoa_Don, 
@Ma_Hang_Hoa, 
                @Ma_Kho_Hang,
                                     @Loai_Chung_Tu, @Dien_Giai, @So_Luong_Nhap, 
@So_Luong_Xuat,
                                     @So_Luong_Thuc, @Ghi_Chu
WHILE @@FETCH_STATUS = 0
BEGIN
    --PRINT @Ma_Chung_Tu
    
    IF (
           @Ma_Hang_Hoa_Tam != @Ma_Hang_Hoa
           OR @Ma_Kho_Hang_Tam != @Ma_Kho_Hang
       )
    BEGIN
        SET @So_Luong_Ton = 0
    END
    
    SET @So_Luong_Ton = @So_Luong_Ton + @So_Luong_Thuc
    
    SET @Ma_Hang_Hoa_Tam = @Ma_Hang_Hoa 
    SET @Ma_Kho_Hang_Tam = @Ma_Kho_Hang
    INSERT INTO @TheKho_TB
      (
        Ma_Chung_Tu,
        Ngay,
        Ngay_Sap_Xep,
        Ma_Hoa_Don,
        Ma_Hang_Hoa,
        Ma_Kho_Hang,
        Loai_Chung_Tu,
        Dien_Giai,
        So_Luong_Nhap,
        So_Luong_Xuat,
        So_Luong_Thuc,
        So_Luong_Ton,
        Ghi_Chu
      )
    VALUES
      (
        @Ma_Chung_Tu,
        @Ngay,
        @Ngay_Sap_Xep,
        @Ma_Hoa_Don,
        @Ma_Hang_Hoa,
        @Ma_Kho_Hang,
        @Loai_Chung_Tu,
        @Dien_Giai,
        @So_Luong_Nhap,
        @So_Luong_Xuat,
        @So_Luong_Thuc,
        @So_Luong_Ton,
        @Ghi_Chu
      )
    
    FETCH NEXT
    FROM @getTheKho INTO @Ma_Chung_Tu, @Ngay, @Ngay_Sap_Xep, @Ma_Hoa_Don, @Ma_Hang_Hoa, 
    @Ma_Kho_Hang,
    @Loai_Chung_Tu, @Dien_Giai, @So_Luong_Nhap, @So_Luong_Xuat,
    @So_Luong_Thuc, @Ghi_Chu
END
                CLOSE @getTheKho
                DEALLOCATE @getTheKho

SELECT thekho.*,
       hh.Ten_Hang,
       hh.Don_Vi,
       kh.Ten_Kho
FROM   @TheKho_TB thekho
       LEFT OUTER JOIN HANG_HOA hh
            ON  hh.Ma_Hang = thekho.Ma_Hang_Hoa
       LEFT OUTER JOIN KHO_HANG kh
            ON  thekho.Ma_Kho_Hang = kh.Ma_Kho
            ";

            string[] myPara = { "@FromDate", "@ToDate" };
            object[] myValue = { dtTu.DateTime, dtDen.DateTime };

            var sqlHelper = new SqlHelper();

            dsTheKho.The_Kho_Theo_Ngay.Rows.Clear();
            dsTheKho.The_Kho_Theo_Ngay.Merge(sqlHelper.ExecuteDataTable(sql, myPara, myValue));

            gbList.BestFitColumns();
        }
    }
}
