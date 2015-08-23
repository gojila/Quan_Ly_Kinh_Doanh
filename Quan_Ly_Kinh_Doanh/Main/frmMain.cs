using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using DevExpress.Skins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using Microsoft.VisualBasic.CompilerServices;
using Do_An_Quan_Ly_Kho.KhuVuc;
using Do_An_Quan_Ly_Kho.KhachHang;
using Do_An_Quan_Ly_Kho.Kho;
using Do_An_Quan_Ly_Kho.NhomHang;
using Do_An_Quan_Ly_Kho.HangHoa;
using Do_An_Quan_Ly_Kho.NhapKho;
using Do_An_Quan_Ly_Kho.XuatKho;
using Do_An_Quan_Ly_Kho.TonKho;
using Do_An_Quan_Ly_Kho;
using Do_An_Quan_Ly_Kho.HangHoa;
using Do_An_Quan_Ly_Kho.Test;
using Do_An_Quan_Ly_Kho.NhanVien;
using Do_An_Quan_Ly_Kho.CuaHang;
using Do_An_Quan_Ly_Kho.ThuChi;
using Do_An_Quan_Ly_Kho.CongNo;
using Do_An_Quan_Ly_Kho.TheNo;
using Do_An_Quan_Ly_Kho.DoanhThu;
using Do_An_Quan_Ly_Kho.CongNoChungTu;

namespace Do_An_Quan_Ly_Kho.Main
{
    public partial class FrmMain : RibbonForm
    {
        public FrmMain()
        {
            frmCauHinhCSDL cauhinhCSDL = new frmCauHinhCSDL();
            cauhinhCSDL.ThanhCong += cauhinhCSDL_ThanhCong;
            cauhinhCSDL.ShowDialog(this);

            //InitializeComponent();
        }

        private void cauhinhCSDL_ThanhCong(object sender)
        {
            InitializeComponent();
        }

        private void BbiCloseItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }        

        private KhuVuc.frmKhuVuc _khuvuc; 
        private void bbiKhuVuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_khuvuc == null)
            {
                _khuvuc = new KhuVuc.frmKhuVuc();
                _khuvuc.FormClosing += (ss, ex) => 
                {
                    _khuvuc = null;
                };
                _khuvuc.MdiParent = this;
                _khuvuc.Show();
            }
            else
            {
                tabMdi.Pages[_khuvuc].MdiChild.Activate();
            }
        }

        private KhachHang.frmKhachHang _khachhang;
        private void bbiKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_khachhang == null)
            {
                _khachhang = new KhachHang.frmKhachHang();
                _khachhang.FormClosing += (ss, ex) =>
                {
                    _khachhang = null;
                };
                _khachhang.MdiParent = this;
                _khachhang.Show();
            }
            else
            {
                tabMdi.Pages[_khachhang].MdiChild.Activate();
            }
        }

        private frmKhoHang _khohang;
        private void bbiKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_khohang == null)
            {
                _khohang = new frmKhoHang();
                _khohang.FormClosing += (ss, ex) =>
                {
                    _khohang = null;
                };
                _khohang.MdiParent = this;
                _khohang.Show();
            }
            else
            {
                tabMdi.Pages[_khohang].MdiChild.Activate();
            }
        }

        private NhomHang.frmNhomHang _nhomhang;
        private void bbiNhomHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_nhomhang == null)
            {
                _nhomhang = new NhomHang.frmNhomHang();
                _nhomhang.FormClosing += (ss, ex) =>
                {
                    _nhomhang = null;
                };
                _nhomhang.MdiParent = this;
                _nhomhang.Show();
            }
            else
            {
                tabMdi.Pages[_nhomhang].MdiChild.Activate();
            }
        }

        private HangHoa.frmHangHoa _hanghoa;
        private void bbiHangHoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_hanghoa == null)
            {
                _hanghoa = new HangHoa.frmHangHoa();
                _hanghoa.FormClosing += (ss, ex) =>
                {
                    _hanghoa = null;
                };
                _hanghoa.MdiParent = this;
                _hanghoa.Show();
            }
            else
            {
                tabMdi.Pages[_hanghoa].MdiChild.Activate();
            }
        }

        private frmQuanLyNhapKho _quanlynhapkho;
        private void bbiNhapKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_quanlynhapkho == null)
            {
                _quanlynhapkho = new frmQuanLyNhapKho();
                _quanlynhapkho.FormClosing += (ss, ex) =>
                {
                    _quanlynhapkho = null;
                };
                _quanlynhapkho.MdiParent = this;
                _quanlynhapkho.Show();
            }
            else
            {
                tabMdi.Pages[_quanlynhapkho].MdiChild.Activate();
            }
        }

        private frmQuanLyXuatKho _quanlyxuatkho;
        private void bbiXuatKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_quanlyxuatkho == null)
            {
                _quanlyxuatkho = new frmQuanLyXuatKho();
                _quanlyxuatkho.FormClosing += (ss, ex) =>
                {
                    _quanlyxuatkho = null;
                };
                _quanlyxuatkho.MdiParent = this;
                _quanlyxuatkho.Show();
            }
            else
            {
                tabMdi.Pages[_quanlyxuatkho].MdiChild.Activate();
            }
        }

        private TonKho.frmTonKho _tonkho;
        private void bbiTonKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_tonkho == null)
            {
                _tonkho = new TonKho.frmTonKho();
                _tonkho.FormClosing += (ss, ex) =>
                {
                    _tonkho = null;
                };
                _tonkho.MdiParent = this;
                _tonkho.Show();
            }
            else
            {
                tabMdi.Pages[_tonkho].MdiChild.Activate();
            }
        }

        private SaoLuu.frmSaoLuu _saoluu;
        private void bbiBackUp_ItemClick(object sender, ItemClickEventArgs e)
        {
            _saoluu = new Do_An_Quan_Ly_Kho.SaoLuu.frmSaoLuu();
            _saoluu.ShowDialog();
        }

        private PhucHoi.frmPhucHoi _phuchoi;
        private void bbiPhucHoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            _phuchoi = new Do_An_Quan_Ly_Kho.PhucHoi.frmPhucHoi();
            _phuchoi.ShowDialog();
        }

        private frmTestList _frmTestList;
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_frmTestList == null)
            {
                _frmTestList = new frmTestList();
                _frmTestList.FormClosing += (ss, ex) =>
                {
                    _frmTestList = null;
                };
                _frmTestList.MdiParent = this;
                _frmTestList.Show();
            }
            else
            {
                tabMdi.Pages[_frmTestList].MdiChild.Activate();
            }
        }

        private frmXuatNhapTon _frmXuatNhapTon;
        private void bbiXuatNhapTon_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_frmXuatNhapTon == null)
            {
                _frmXuatNhapTon = new frmXuatNhapTon();
                _frmXuatNhapTon.FormClosing += (ss, ex) =>
                {
                    _frmXuatNhapTon = null;
                };
                _frmXuatNhapTon.MdiParent = this;
                _frmXuatNhapTon.Show();
            }
            else
            {
                tabMdi.Pages[_frmXuatNhapTon].MdiChild.Activate();
            }
        }

        private frmLichSu _frmLichSu;
        private void bbiLichSu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_frmLichSu == null)
            {
                _frmLichSu = new frmLichSu();
                _frmLichSu.FormClosing += (ss, ex) =>
                {
                    _frmLichSu = null;
                };
                _frmLichSu.MdiParent = this;
                _frmLichSu.Show();
            }
            else
            {
                tabMdi.Pages[_frmLichSu].MdiChild.Activate();
            }
        }

        private frmTheKho _frmTheKho;
        private void bbiTheKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_frmTheKho == null)
            {
                _frmTheKho = new frmTheKho();
                _frmTheKho.FormClosing += (ss, ex) =>
                {
                    _frmTheKho = null;
                };
                _frmTheKho.MdiParent = this;
                _frmTheKho.Show();
            }
            else
            {
                tabMdi.Pages[_frmTheKho].MdiChild.Activate();
            }
        }

        private frmNhanVien _frmNhanVien;
        private void bbiNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_frmNhanVien == null)
            {
                _frmNhanVien = new frmNhanVien();
                _frmNhanVien.FormClosing += (ss, ex) =>
                {
                    _frmNhanVien = null;
                };
                _frmNhanVien.MdiParent = this;
                _frmNhanVien.Show();
            }
            else
            {
                tabMdi.Pages[_frmNhanVien].MdiChild.Activate();
            }
        }

        private frmCuaHang _frmCuaHang;
        private void bbiCuaHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_frmCuaHang == null)
            {
                _frmCuaHang = new frmCuaHang();
                _frmCuaHang.FormClosing += (ss, ex) =>
                {
                    _frmCuaHang = null;
                };
                _frmCuaHang.MdiParent = this;
                _frmCuaHang.Show();
            }
            else
            {
                tabMdi.Pages[_frmCuaHang].MdiChild.Activate();
            }
        }

        private frmThuChi _frmThuChi;
        private void bbiThuChi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_frmThuChi == null)
            {
                _frmThuChi = new frmThuChi();
                _frmThuChi.FormClosing += (ss, ex) =>
                {
                    _frmThuChi = null;
                };
                _frmThuChi.MdiParent = this;
                _frmThuChi.Show();
            }
            else
            {
                tabMdi.Pages[_frmThuChi].MdiChild.Activate();
            }
        }

        private frmCongNo _frmCongNo;
        private void bbiCongNo_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_frmCongNo == null)
            {
                _frmCongNo = new frmCongNo();
                _frmCongNo.FormClosing += (ss, ex) =>
                {
                    _frmCongNo = null;
                };
                _frmCongNo.MdiParent = this;
                _frmCongNo.Show();
            }
            else
            {
                tabMdi.Pages[_frmCongNo].MdiChild.Activate();
            }
        }

        private frmTheNo _frmTheNo;
        private void bbiTheNo_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_frmTheNo == null)
            {
                _frmTheNo = new frmTheNo();
                _frmTheNo.FormClosing += (ss, ex) =>
                {
                    _frmTheNo = null;
                };
                _frmTheNo.MdiParent = this;
                _frmTheNo.Show();
            }
            else
            {
                tabMdi.Pages[_frmTheNo].MdiChild.Activate();
            }
        }

        private frmQuanLyDoanhThu _frmQuanLyDoanhThu;
        private void bbiDoanhThu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_frmQuanLyDoanhThu == null)
            {
                _frmQuanLyDoanhThu = new frmQuanLyDoanhThu();
                _frmQuanLyDoanhThu.FormClosing += (ss, ex) =>
                {
                    _frmQuanLyDoanhThu = null;
                };
                _frmQuanLyDoanhThu.MdiParent = this;
                _frmQuanLyDoanhThu.Show();
            }
            else
            {
                tabMdi.Pages[_frmQuanLyDoanhThu].MdiChild.Activate();
            }
        }

        private frmCongNoChungTu _frmCongNoChungTu;
        private void bbiCongNoChungTu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_frmCongNoChungTu == null)
            {
                _frmCongNoChungTu = new frmCongNoChungTu();
                _frmCongNoChungTu.FormClosing += (ss, ex) =>
                {
                    _frmCongNoChungTu = null;
                };
                _frmCongNoChungTu.MdiParent = this;
                _frmCongNoChungTu.Show();
            }
            else
            {
                tabMdi.Pages[_frmCongNoChungTu].MdiChild.Activate();
            }
        }
    }
}