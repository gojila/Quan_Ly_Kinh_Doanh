using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using Do_An_Quan_Ly_Kho.Bussiness;

using System.IO;
using System.Data.SqlClient;

namespace Do_An_Quan_Ly_Kho
{
    public partial class frmCauHinhCSDL : Form
    {
        public delegate void ThanhCongEventHander(object sender);

        public event ThanhCongEventHander ThanhCong;
        private void KetThucThanhCongEventHander()
        {
            if (ThanhCong != null)
            {
                ThanhCong(this);
            }
        }

        public frmCauHinhCSDL()
        {
            InitializeComponent();

            var dt = new DataTable("CauHinhCSDL");
            dt.Columns.Add("MayChu");
            dt.Columns.Add("TaiKhoanSQL");
            dt.Columns.Add("Password");
            dt.Columns.Add("CSDL");


            var fi = new FileInfo(Application.StartupPath + "\\CauHinhCSDL.xml");
            if (!fi.Exists) return;
            
            dt.ReadXml(Application.StartupPath + "\\CauHinhCSDL.xml");
            try
            {
                if (dt.Rows.Count > 0)
                {
                    txtMayChuSQL.Text = dt.Rows[0]["MayChu"].ToString();
                    txtTaiKhoanSQL.Text = dt.Rows[0]["TaiKhoanSQL"].ToString();
                    txtPassword.Text = dt.Rows[0]["Password"].ToString();
                    txtTenCSDL.Text = dt.Rows[0]["CSDL"].ToString();
                }
            }
            catch (Exception ex)
            {
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //Data Source=.\SQLEXPRESS;Initial Catalog=QLK_quang_make;User ID=sa
            //Data Source=.\SQLEXPRESS;Initial Catalog=QLK_quang_make;Integrated Security=True

            if (!cbSuDungTaiKhoanWindows.Checked)
            {
                SqlHelper.ConnectionString = "Data Source=" + txtMayChuSQL.Text + ";Initial Catalog=" + txtTenCSDL.Text + ";User ID=" + txtTaiKhoanSQL.Text + ";Password=" + txtPassword.Text + ";";
            }
            else
            {
                SqlHelper.ConnectionString = "Data Source=" + txtMayChuSQL.Text + ";Initial Catalog=" + txtTenCSDL.Text + ";Integrated Security=True;";
            }

            SqlHelper.TenCSDL = txtTenCSDL.Text;
            
            //this.Close();

            //FrmMain main = new FrmMain();
            //main.WindowState = FormWindowState.Maximized;
            //main.Show();

            if (Kiem_Tra_Ket_Noi(SqlHelper.ConnectionString))
            {
                KetThucThanhCongEventHander();
                Close();
            }
            else
            {
                return;
            }

            
        }

        private void cbSuDungTaiKhoanWindows_CheckedChanged(object sender, EventArgs e)
        {
            txtTaiKhoanSQL.Properties.ReadOnly = cbSuDungTaiKhoanWindows.Checked;
            txtPassword.Properties.ReadOnly = cbSuDungTaiKhoanWindows.Checked;
        }

        public bool Kiem_Tra_Ket_Noi(string ConnectionString)
        {
            var connection = new SqlConnection(ConnectionString);
            
            try
            {
                connection.Open();
                connection.Close();
            }
            catch
            {
                MessageBox.Show(this, "Không thể kết nối với máy chủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            
            return true;
        }
    }
}
