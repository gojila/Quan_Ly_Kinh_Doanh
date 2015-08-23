namespace Do_An_Quan_Ly_Kho.NhanVien
{
    partial class frmNhanVien_Them_Sua
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
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtNamSinh = new DevExpress.XtraEditors.TextEdit();
            this.txtDienThoai = new DevExpress.XtraEditors.TextEdit();
            this.txtNgayVaoLam = new DevExpress.XtraEditors.TextEdit();
            this.txtChucVu = new DevExpress.XtraEditors.TextEdit();
            this.txtBoPhan = new DevExpress.XtraEditors.TextEdit();
            this.txtCuaHang = new DevExpress.XtraEditors.GridLookUpEdit();
            this.cUAHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCuaHang = new Do_An_Quan_Ly_Kho.CuaHang.DataSet.dsCuaHang();
            this.txtCuaHang_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa_Cua_Hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Cua_Hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDia_Chi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_So_Thue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDien_Thoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDi_Dong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuan_Ly = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhi_Chu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cUA_HANGTableAdapter = new Do_An_Quan_Ly_Kho.CuaHang.DataSet.dsCuaHangTableAdapters.CUA_HANGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamSinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienThoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayVaoLam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChucVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoPhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuaHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUAHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCuaHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuaHang_View)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(500, 139);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(75, 23);
            this.btnBoQua.TabIndex = 11;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(419, 139);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(12, 116);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(41, 13);
            this.labelControl16.TabIndex = 24;
            this.labelControl16.Text = "Ghi Chú:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(300, 64);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(44, 13);
            this.labelControl8.TabIndex = 32;
            this.labelControl8.Text = "Chức Vụ:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 90);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(48, 13);
            this.labelControl7.TabIndex = 33;
            this.labelControl7.Text = "Năm Sinh:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(300, 38);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(72, 13);
            this.labelControl6.TabIndex = 34;
            this.labelControl6.Text = "Ngày Vào Làm:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(300, 12);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 13);
            this.labelControl5.TabIndex = 31;
            this.labelControl5.Text = "Điện Thoại:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 64);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 13);
            this.labelControl3.TabIndex = 29;
            this.labelControl3.Text = "Địa Chỉ:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 13);
            this.labelControl2.TabIndex = 30;
            this.labelControl2.Text = "Họ Tên:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 13);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Mã Nhân Viên:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(96, 113);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(198, 20);
            this.txtGhiChu.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(300, 90);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 13);
            this.labelControl4.TabIndex = 32;
            this.labelControl4.Text = "Bộ Phận:";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(96, 9);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(198, 20);
            this.txtMaNhanVien.TabIndex = 0;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(300, 116);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(52, 13);
            this.labelControl9.TabIndex = 32;
            this.labelControl9.Text = "Cửa Hàng:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(96, 38);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(198, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(96, 64);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(198, 20);
            this.txtDiaChi.TabIndex = 2;
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.Location = new System.Drawing.Point(96, 87);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(198, 20);
            this.txtNamSinh.TabIndex = 3;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(377, 9);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(198, 20);
            this.txtDienThoai.TabIndex = 5;
            // 
            // txtNgayVaoLam
            // 
            this.txtNgayVaoLam.Location = new System.Drawing.Point(377, 35);
            this.txtNgayVaoLam.Name = "txtNgayVaoLam";
            this.txtNgayVaoLam.Size = new System.Drawing.Size(198, 20);
            this.txtNgayVaoLam.TabIndex = 6;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(377, 61);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(198, 20);
            this.txtChucVu.TabIndex = 7;
            // 
            // txtBoPhan
            // 
            this.txtBoPhan.Location = new System.Drawing.Point(377, 87);
            this.txtBoPhan.Name = "txtBoPhan";
            this.txtBoPhan.Size = new System.Drawing.Size(198, 20);
            this.txtBoPhan.TabIndex = 8;
            // 
            // txtCuaHang
            // 
            this.txtCuaHang.Location = new System.Drawing.Point(377, 113);
            this.txtCuaHang.Name = "txtCuaHang";
            this.txtCuaHang.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.txtCuaHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCuaHang.Properties.DataSource = this.cUAHANGBindingSource;
            this.txtCuaHang.Properties.DisplayMember = "Ten_Cua_Hang";
            this.txtCuaHang.Properties.NullText = "";
            this.txtCuaHang.Properties.NullValuePrompt = "(Cửa Hàng)";
            this.txtCuaHang.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtCuaHang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtCuaHang.Properties.ValueMember = "Ma_Cua_Hang";
            this.txtCuaHang.Properties.View = this.txtCuaHang_View;
            this.txtCuaHang.Size = new System.Drawing.Size(198, 20);
            this.txtCuaHang.TabIndex = 9;
            // 
            // cUAHANGBindingSource
            // 
            this.cUAHANGBindingSource.DataMember = "CUA_HANG";
            this.cUAHANGBindingSource.DataSource = this.dsCuaHang;
            // 
            // dsCuaHang
            // 
            this.dsCuaHang.DataSetName = "dsCuaHang";
            this.dsCuaHang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCuaHang_View
            // 
            this.txtCuaHang_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Cua_Hang,
            this.colTen_Cua_Hang,
            this.colDia_Chi,
            this.colMa_So_Thue,
            this.colDien_Thoai,
            this.colEmail,
            this.colFax,
            this.colDi_Dong,
            this.colQuan_Ly,
            this.colGhi_Chu});
            this.txtCuaHang_View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.txtCuaHang_View.Name = "txtCuaHang_View";
            this.txtCuaHang_View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.txtCuaHang_View.OptionsView.ShowAutoFilterRow = true;
            this.txtCuaHang_View.OptionsView.ShowGroupPanel = false;
            // 
            // colMa_Cua_Hang
            // 
            this.colMa_Cua_Hang.AppearanceHeader.Options.UseTextOptions = true;
            this.colMa_Cua_Hang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMa_Cua_Hang.Caption = "Mã Cửa Hàng";
            this.colMa_Cua_Hang.FieldName = "Ma_Cua_Hang";
            this.colMa_Cua_Hang.Name = "colMa_Cua_Hang";
            this.colMa_Cua_Hang.OptionsColumn.ReadOnly = true;
            this.colMa_Cua_Hang.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colMa_Cua_Hang.Visible = true;
            this.colMa_Cua_Hang.VisibleIndex = 0;
            // 
            // colTen_Cua_Hang
            // 
            this.colTen_Cua_Hang.AppearanceHeader.Options.UseTextOptions = true;
            this.colTen_Cua_Hang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTen_Cua_Hang.Caption = "Tên Cửa Hàng";
            this.colTen_Cua_Hang.FieldName = "Ten_Cua_Hang";
            this.colTen_Cua_Hang.Name = "colTen_Cua_Hang";
            this.colTen_Cua_Hang.OptionsColumn.ReadOnly = true;
            this.colTen_Cua_Hang.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTen_Cua_Hang.Visible = true;
            this.colTen_Cua_Hang.VisibleIndex = 1;
            // 
            // colDia_Chi
            // 
            this.colDia_Chi.AppearanceHeader.Options.UseTextOptions = true;
            this.colDia_Chi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDia_Chi.Caption = "Địa Chỉ";
            this.colDia_Chi.FieldName = "Dia_Chi";
            this.colDia_Chi.Name = "colDia_Chi";
            this.colDia_Chi.OptionsColumn.ReadOnly = true;
            this.colDia_Chi.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDia_Chi.Visible = true;
            this.colDia_Chi.VisibleIndex = 2;
            // 
            // colMa_So_Thue
            // 
            this.colMa_So_Thue.AppearanceHeader.Options.UseTextOptions = true;
            this.colMa_So_Thue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMa_So_Thue.Caption = "Mã Số Thuế";
            this.colMa_So_Thue.FieldName = "Ma_So_Thue";
            this.colMa_So_Thue.Name = "colMa_So_Thue";
            this.colMa_So_Thue.OptionsColumn.ReadOnly = true;
            this.colMa_So_Thue.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colMa_So_Thue.Visible = true;
            this.colMa_So_Thue.VisibleIndex = 3;
            // 
            // colDien_Thoai
            // 
            this.colDien_Thoai.AppearanceHeader.Options.UseTextOptions = true;
            this.colDien_Thoai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDien_Thoai.Caption = "Điện Thoại";
            this.colDien_Thoai.FieldName = "Dien_Thoai";
            this.colDien_Thoai.Name = "colDien_Thoai";
            this.colDien_Thoai.OptionsColumn.ReadOnly = true;
            this.colDien_Thoai.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDien_Thoai.Visible = true;
            this.colDien_Thoai.VisibleIndex = 4;
            // 
            // colEmail
            // 
            this.colEmail.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.ReadOnly = true;
            this.colEmail.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 5;
            // 
            // colFax
            // 
            this.colFax.AppearanceHeader.Options.UseTextOptions = true;
            this.colFax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFax.Caption = "Fax";
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.OptionsColumn.ReadOnly = true;
            this.colFax.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 6;
            // 
            // colDi_Dong
            // 
            this.colDi_Dong.AppearanceHeader.Options.UseTextOptions = true;
            this.colDi_Dong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDi_Dong.Caption = "Di Động";
            this.colDi_Dong.FieldName = "Di_Dong";
            this.colDi_Dong.Name = "colDi_Dong";
            this.colDi_Dong.OptionsColumn.ReadOnly = true;
            this.colDi_Dong.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDi_Dong.Visible = true;
            this.colDi_Dong.VisibleIndex = 7;
            // 
            // colQuan_Ly
            // 
            this.colQuan_Ly.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuan_Ly.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQuan_Ly.Caption = "Quản Lý";
            this.colQuan_Ly.FieldName = "Quan_Ly";
            this.colQuan_Ly.Name = "colQuan_Ly";
            this.colQuan_Ly.OptionsColumn.ReadOnly = true;
            this.colQuan_Ly.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colQuan_Ly.Visible = true;
            this.colQuan_Ly.VisibleIndex = 8;
            // 
            // colGhi_Chu
            // 
            this.colGhi_Chu.AppearanceHeader.Options.UseTextOptions = true;
            this.colGhi_Chu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGhi_Chu.Caption = "Ghi Chú";
            this.colGhi_Chu.FieldName = "Ghi_Chu";
            this.colGhi_Chu.Name = "colGhi_Chu";
            this.colGhi_Chu.OptionsColumn.ReadOnly = true;
            this.colGhi_Chu.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colGhi_Chu.Visible = true;
            this.colGhi_Chu.VisibleIndex = 9;
            // 
            // cUA_HANGTableAdapter
            // 
            this.cUA_HANGTableAdapter.ClearBeforeFill = true;
            // 
            // frmNhanVien_Them_Sua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 175);
            this.Controls.Add(this.txtCuaHang);
            this.Controls.Add(this.txtBoPhan);
            this.Controls.Add(this.txtChucVu);
            this.Controls.Add(this.txtNgayVaoLam);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtNamSinh);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.labelControl16);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtGhiChu);
            this.Name = "frmNhanVien_Them_Sua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên";
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamSinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienThoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayVaoLam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChucVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoPhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuaHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUAHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCuaHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuaHang_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnBoQua;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtGhiChu;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtMaNhanVien;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtNamSinh;
        private DevExpress.XtraEditors.TextEdit txtDienThoai;
        private DevExpress.XtraEditors.TextEdit txtNgayVaoLam;
        private DevExpress.XtraEditors.TextEdit txtChucVu;
        private DevExpress.XtraEditors.TextEdit txtBoPhan;
        private DevExpress.XtraEditors.GridLookUpEdit txtCuaHang;
        private DevExpress.XtraGrid.Views.Grid.GridView txtCuaHang_View;
        private CuaHang.DataSet.dsCuaHang dsCuaHang;
        private System.Windows.Forms.BindingSource cUAHANGBindingSource;
        private CuaHang.DataSet.dsCuaHangTableAdapters.CUA_HANGTableAdapter cUA_HANGTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Cua_Hang;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Cua_Hang;
        private DevExpress.XtraGrid.Columns.GridColumn colDia_Chi;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_So_Thue;
        private DevExpress.XtraGrid.Columns.GridColumn colDien_Thoai;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colDi_Dong;
        private DevExpress.XtraGrid.Columns.GridColumn colQuan_Ly;
        private DevExpress.XtraGrid.Columns.GridColumn colGhi_Chu;
    }
}