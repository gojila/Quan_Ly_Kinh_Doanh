namespace Do_An_Quan_Ly_Kho.HangHoa
{
    partial class frmHangHoa_Them_Sua
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnBoQua = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.txtDonVi = new DevExpress.XtraEditors.TextEdit();
            this.txtTenHang = new DevExpress.XtraEditors.TextEdit();
            this.txtMaHang = new DevExpress.XtraEditors.TextEdit();
            this.kHUVUCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsKhachHang = new Do_An_Quan_Ly_Kho.KhachHang.DS.dsKhachHang();
            this.kHU_VUCTableAdapter = new Do_An_Quan_Ly_Kho.KhachHang.DS.dsKhachHangTableAdapters.KHU_VUCTableAdapter();
            this.txtGiaNhapKho = new DevExpress.XtraEditors.CalcEdit();
            this.txtGiaXuatKho = new DevExpress.XtraEditors.CalcEdit();
            this.txtNhomHang = new DevExpress.XtraEditors.GridLookUpEdit();
            this.nHOMHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsHangHoa = new Do_An_Quan_Ly_Kho.HangHoa.DS.dsHangHoa();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa_Nhom_Hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Nhom_Hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhi_Chu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nHOM_HANGTableAdapter = new Do_An_Quan_Ly_Kho.HangHoa.DS.dsHangHoaTableAdapters.NHOM_HANGTableAdapter();
            this.picAnh = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUVUCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaNhapKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaXuatKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhomHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(489, 191);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(75, 23);
            this.btnBoQua.TabIndex = 35;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(408, 191);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 36;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(14, 168);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(41, 13);
            this.labelControl16.TabIndex = 24;
            this.labelControl16.Text = "Ghi Chú:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(14, 90);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(35, 13);
            this.labelControl7.TabIndex = 33;
            this.labelControl7.Text = "Đơn Vị:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(14, 142);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(65, 13);
            this.labelControl6.TabIndex = 34;
            this.labelControl6.Text = "Giá Xuất Kho:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(14, 116);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(68, 13);
            this.labelControl5.TabIndex = 31;
            this.labelControl5.Text = "Giá Nhập Kho:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 64);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 13);
            this.labelControl3.TabIndex = 29;
            this.labelControl3.Text = "Nhóm Hàng:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 30;
            this.labelControl2.Text = "Tên Hàng:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Mã Hàng:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(96, 165);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(245, 20);
            this.txtGhiChu.TabIndex = 8;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(96, 87);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(245, 20);
            this.txtDonVi.TabIndex = 10;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(96, 35);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(245, 20);
            this.txtTenHang.TabIndex = 12;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(96, 9);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(245, 20);
            this.txtMaHang.TabIndex = 14;
            // 
            // kHUVUCBindingSource
            // 
            this.kHUVUCBindingSource.DataMember = "KHU_VUC";
            this.kHUVUCBindingSource.DataSource = this.dsKhachHang;
            // 
            // dsKhachHang
            // 
            this.dsKhachHang.DataSetName = "dsKhachHang";
            this.dsKhachHang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHU_VUCTableAdapter
            // 
            this.kHU_VUCTableAdapter.ClearBeforeFill = true;
            // 
            // txtGiaNhapKho
            // 
            this.txtGiaNhapKho.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtGiaNhapKho.Location = new System.Drawing.Point(96, 113);
            this.txtGiaNhapKho.Name = "txtGiaNhapKho";
            this.txtGiaNhapKho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtGiaNhapKho.Properties.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.txtGiaNhapKho.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtGiaNhapKho.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtGiaNhapKho.Size = new System.Drawing.Size(245, 20);
            this.txtGiaNhapKho.TabIndex = 6;
            this.txtGiaNhapKho.TabStop = false;
            // 
            // txtGiaXuatKho
            // 
            this.txtGiaXuatKho.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtGiaXuatKho.Location = new System.Drawing.Point(96, 139);
            this.txtGiaXuatKho.Name = "txtGiaXuatKho";
            this.txtGiaXuatKho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtGiaXuatKho.Properties.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.txtGiaXuatKho.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtGiaXuatKho.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtGiaXuatKho.Size = new System.Drawing.Size(245, 20);
            this.txtGiaXuatKho.TabIndex = 4;
            this.txtGiaXuatKho.TabStop = false;
            // 
            // txtNhomHang
            // 
            this.txtNhomHang.Location = new System.Drawing.Point(96, 61);
            this.txtNhomHang.Name = "txtNhomHang";
            this.txtNhomHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNhomHang.Properties.DataSource = this.nHOMHANGBindingSource;
            this.txtNhomHang.Properties.DisplayMember = "Ten_Nhom_Hang";
            this.txtNhomHang.Properties.NullText = "";
            this.txtNhomHang.Properties.ValueMember = "Ma_Nhom_Hang";
            this.txtNhomHang.Properties.View = this.gridLookUpEdit1View;
            this.txtNhomHang.Size = new System.Drawing.Size(245, 20);
            this.txtNhomHang.TabIndex = 18;
            this.txtNhomHang.TabStop = false;
            // 
            // nHOMHANGBindingSource
            // 
            this.nHOMHANGBindingSource.DataMember = "NHOM_HANG";
            this.nHOMHANGBindingSource.DataSource = this.dsHangHoa;
            // 
            // dsHangHoa
            // 
            this.dsHangHoa.DataSetName = "dsHangHoa";
            this.dsHangHoa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Nhom_Hang,
            this.colTen_Nhom_Hang,
            this.colGhi_Chu});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colMa_Nhom_Hang
            // 
            this.colMa_Nhom_Hang.Caption = "Mã Nhóm Hàng";
            this.colMa_Nhom_Hang.FieldName = "Ma_Nhom_Hang";
            this.colMa_Nhom_Hang.Name = "colMa_Nhom_Hang";
            this.colMa_Nhom_Hang.Visible = true;
            this.colMa_Nhom_Hang.VisibleIndex = 0;
            // 
            // colTen_Nhom_Hang
            // 
            this.colTen_Nhom_Hang.Caption = "Tên Nhóm Hàng";
            this.colTen_Nhom_Hang.FieldName = "Ten_Nhom_Hang";
            this.colTen_Nhom_Hang.Name = "colTen_Nhom_Hang";
            this.colTen_Nhom_Hang.Visible = true;
            this.colTen_Nhom_Hang.VisibleIndex = 1;
            // 
            // colGhi_Chu
            // 
            this.colGhi_Chu.Caption = "Ghi Chú";
            this.colGhi_Chu.FieldName = "Ghi_Chu";
            this.colGhi_Chu.Name = "colGhi_Chu";
            this.colGhi_Chu.Visible = true;
            this.colGhi_Chu.VisibleIndex = 2;
            // 
            // nHOM_HANGTableAdapter
            // 
            this.nHOM_HANGTableAdapter.ClearBeforeFill = true;
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(347, 7);
            this.picAnh.Name = "picAnh";
            this.picAnh.Properties.NullText = "Ảnh";
            this.picAnh.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picAnh.Size = new System.Drawing.Size(217, 178);
            this.picAnh.TabIndex = 37;
            // 
            // HangHoa_Them_Sua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 223);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.labelControl16);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtDonVi);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.txtGiaNhapKho);
            this.Controls.Add(this.txtGiaXuatKho);
            this.Controls.Add(this.txtNhomHang);
            this.Name = "HangHoa_Them_Sua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hàng Hóa";
            this.Load += new System.EventHandler(this.KhachHang_Them_Sua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUVUCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaNhapKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaXuatKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhomHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnBoQua;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtGhiChu;
        private DevExpress.XtraEditors.TextEdit txtDonVi;
        private DevExpress.XtraEditors.TextEdit txtTenHang;
        private DevExpress.XtraEditors.TextEdit txtMaHang;
        private Do_An_Quan_Ly_Kho.KhachHang.DS.dsKhachHang dsKhachHang;
        private System.Windows.Forms.BindingSource kHUVUCBindingSource;
        private Do_An_Quan_Ly_Kho.KhachHang.DS.dsKhachHangTableAdapters.KHU_VUCTableAdapter kHU_VUCTableAdapter;
        private DevExpress.XtraEditors.CalcEdit txtGiaNhapKho;
        private DevExpress.XtraEditors.CalcEdit txtGiaXuatKho;
        private DevExpress.XtraEditors.GridLookUpEdit txtNhomHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private Do_An_Quan_Ly_Kho.HangHoa.DS.dsHangHoa dsHangHoa;
        private System.Windows.Forms.BindingSource nHOMHANGBindingSource;
        private Do_An_Quan_Ly_Kho.HangHoa.DS.dsHangHoaTableAdapters.NHOM_HANGTableAdapter nHOM_HANGTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Nhom_Hang;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Nhom_Hang;
        private DevExpress.XtraGrid.Columns.GridColumn colGhi_Chu;
        private DevExpress.XtraEditors.PictureEdit picAnh;
    }
}