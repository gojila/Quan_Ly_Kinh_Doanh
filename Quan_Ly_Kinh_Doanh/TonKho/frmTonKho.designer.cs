namespace Do_An_Quan_Ly_Kho.TonKho
{
    partial class frmTonKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTonKho));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colSo_Luong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rptMayTinh = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.img = new DevExpress.Utils.ImageCollection(this.components);
            this.bm = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bbiXem = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSua = new DevExpress.XtraBars.BarButtonItem();
            this.bbiXoa = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtKhoHang = new DevExpress.XtraEditors.GridLookUpEdit();
            this.kHOHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTonKho = new Do_An_Quan_Ly_Kho.TonKho.DS.dsTonKho();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa_Kho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Kho1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.tONKHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTen_Kho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Hang_Hoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDon_Vi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Kho_Hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhom_Hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Nhom_Hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tON_KHOTableAdapter = new Do_An_Quan_Ly_Kho.TonKho.DS.dsTonKhoTableAdapters.TON_KHOTableAdapter();
            this.kHO_HANGTableAdapter = new Do_An_Quan_Ly_Kho.TonKho.DS.dsTonKhoTableAdapters.KHO_HANGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rptMayTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTonKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tONKHOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // colSo_Luong
            // 
            this.colSo_Luong.Caption = "Số Lượng";
            this.colSo_Luong.ColumnEdit = this.rptMayTinh;
            this.colSo_Luong.FieldName = "So_Luong";
            this.colSo_Luong.Name = "colSo_Luong";
            this.colSo_Luong.OptionsColumn.ReadOnly = true;
            this.colSo_Luong.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSo_Luong.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colSo_Luong.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSo_Luong.Visible = true;
            this.colSo_Luong.VisibleIndex = 3;
            this.colSo_Luong.Width = 109;
            // 
            // rptMayTinh
            // 
            this.rptMayTinh.AutoHeight = false;
            this.rptMayTinh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rptMayTinh.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.rptMayTinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rptMayTinh.EditFormat.FormatString = "{0:##,##0.###}";
            this.rptMayTinh.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rptMayTinh.Name = "rptMayTinh";
            // 
            // img
            // 
            this.img.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("img.ImageStream")));
            this.img.Images.SetKeyName(0, "abort.png");
            this.img.Images.SetKeyName(1, "about.png");
            this.img.Images.SetKeyName(2, "accept.png");
            this.img.Images.SetKeyName(3, "add.png");
            this.img.Images.SetKeyName(4, "application.png");
            this.img.Images.SetKeyName(5, "apply.png");
            this.img.Images.SetKeyName(6, "attention.png");
            this.img.Images.SetKeyName(7, "back.png");
            this.img.Images.SetKeyName(8, "cancel.png");
            this.img.Images.SetKeyName(9, "circulation.png");
            this.img.Images.SetKeyName(10, "close.png");
            this.img.Images.SetKeyName(11, "create.png");
            this.img.Images.SetKeyName(12, "cut.png");
            this.img.Images.SetKeyName(13, "danger.png");
            this.img.Images.SetKeyName(14, "delete.png");
            this.img.Images.SetKeyName(15, "down.png");
            this.img.Images.SetKeyName(16, "erase.png");
            this.img.Images.SetKeyName(17, "error.png");
            this.img.Images.SetKeyName(18, "forward.png");
            this.img.Images.SetKeyName(19, "help.png");
            this.img.Images.SetKeyName(20, "info.png");
            this.img.Images.SetKeyName(21, "information.png");
            this.img.Images.SetKeyName(22, "logout.png");
            this.img.Images.SetKeyName(23, "minus.png");
            this.img.Images.SetKeyName(24, "move.png");
            this.img.Images.SetKeyName(25, "next.png");
            this.img.Images.SetKeyName(26, "no entry.png");
            this.img.Images.SetKeyName(27, "no.png");
            this.img.Images.SetKeyName(28, "OK.png");
            this.img.Images.SetKeyName(29, "options.png");
            this.img.Images.SetKeyName(30, "plus.png");
            this.img.Images.SetKeyName(31, "previous.png");
            this.img.Images.SetKeyName(32, "problem.png");
            this.img.Images.SetKeyName(33, "question.png");
            this.img.Images.SetKeyName(34, "redo.png");
            this.img.Images.SetKeyName(35, "refresh.png");
            this.img.Images.SetKeyName(36, "remove.png");
            this.img.Images.SetKeyName(37, "renew.png");
            this.img.Images.SetKeyName(38, "repeat.png");
            this.img.Images.SetKeyName(39, "run.png");
            this.img.Images.SetKeyName(40, "save.png");
            this.img.Images.SetKeyName(41, "search.png");
            this.img.Images.SetKeyName(42, "settings.png");
            this.img.Images.SetKeyName(43, "stop.png");
            this.img.Images.SetKeyName(44, "switch.png");
            this.img.Images.SetKeyName(45, "sync.png");
            this.img.Images.SetKeyName(46, "system.png");
            this.img.Images.SetKeyName(47, "turn off.png");
            this.img.Images.SetKeyName(48, "undo.png");
            this.img.Images.SetKeyName(49, "up.png");
            this.img.Images.SetKeyName(50, "update.png");
            this.img.Images.SetKeyName(51, "view.png");
            this.img.Images.SetKeyName(52, "warning.png");
            this.img.Images.SetKeyName(53, "yes.png");
            // 
            // bm
            // 
            this.bm.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.bm.DockControls.Add(this.barDockControlTop);
            this.bm.DockControls.Add(this.barDockControlBottom);
            this.bm.DockControls.Add(this.barDockControlLeft);
            this.bm.DockControls.Add(this.barDockControlRight);
            this.bm.Form = this;
            this.bm.Images = this.img;
            this.bm.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiXem,
            this.bbiSua,
            this.bbiXoa,
            this.bbiDong});
            this.bm.LargeImages = this.img;
            this.bm.MainMenu = this.bar2;
            this.bm.MaxItemId = 12;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(49, 160);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiXem, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDong)});
            this.bar2.OptionsBar.AllowDelete = true;
            this.bar2.OptionsBar.DrawSizeGrip = true;
            this.bar2.Text = "Main menu";
            // 
            // bbiXem
            // 
            this.bbiXem.Caption = "Xem";
            this.bbiXem.Id = 0;
            this.bbiXem.ImageIndex = 35;
            this.bbiXem.Name = "bbiXem";
            this.bbiXem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiXem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiXem_ItemClick);
            // 
            // bbiSua
            // 
            this.bbiSua.Caption = "Sửa";
            this.bbiSua.Id = 1;
            this.bbiSua.ImageIndex = 29;
            this.bbiSua.Name = "bbiSua";
            this.bbiSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bbiXoa
            // 
            this.bbiXoa.Caption = "Xóa";
            this.bbiXoa.Id = 2;
            this.bbiXoa.ImageIndex = 16;
            this.bbiXoa.Name = "bbiXoa";
            this.bbiXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bbiDong
            // 
            this.bbiDong.Caption = "Đóng";
            this.bbiDong.Id = 6;
            this.bbiDong.ImageIndex = 10;
            this.bbiDong.Name = "bbiDong";
            this.bbiDong.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtKhoHang);
            this.layoutControl1.Controls.Add(this.layoutControl2);
            this.layoutControl1.Controls.Add(this.gcList);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 26);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1102, 633);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtKhoHang
            // 
            this.txtKhoHang.Location = new System.Drawing.Point(51, 2);
            this.txtKhoHang.MenuManager = this.bm;
            this.txtKhoHang.Name = "txtKhoHang";
            this.txtKhoHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtKhoHang.Properties.DataSource = this.kHOHANGBindingSource;
            this.txtKhoHang.Properties.DisplayMember = "Ten_Kho";
            this.txtKhoHang.Properties.NullText = "";
            this.txtKhoHang.Properties.NullValuePrompt = "(Kho Hàng)";
            this.txtKhoHang.Properties.ValueMember = "Ma_Kho";
            this.txtKhoHang.Properties.View = this.gridLookUpEdit1View;
            this.txtKhoHang.Size = new System.Drawing.Size(147, 20);
            this.txtKhoHang.StyleController = this.layoutControl1;
            this.txtKhoHang.TabIndex = 10;
            this.txtKhoHang.EditValueChanged += new System.EventHandler(this.txtKhoHang_EditValueChanged);
            // 
            // kHOHANGBindingSource
            // 
            this.kHOHANGBindingSource.DataMember = "KHO_HANG";
            this.kHOHANGBindingSource.DataSource = this.dsTonKho;
            // 
            // dsTonKho
            // 
            this.dsTonKho.DataSetName = "dsTonKho";
            this.dsTonKho.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Kho,
            this.colTen_Kho1});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colMa_Kho
            // 
            this.colMa_Kho.Caption = "Mã Kho";
            this.colMa_Kho.FieldName = "Ma_Kho";
            this.colMa_Kho.Name = "colMa_Kho";
            this.colMa_Kho.OptionsColumn.ReadOnly = true;
            this.colMa_Kho.Visible = true;
            this.colMa_Kho.VisibleIndex = 0;
            // 
            // colTen_Kho1
            // 
            this.colTen_Kho1.Caption = "Tên Kho";
            this.colTen_Kho1.FieldName = "Ten_Kho";
            this.colTen_Kho1.Name = "colTen_Kho1";
            this.colTen_Kho1.OptionsColumn.ReadOnly = true;
            this.colTen_Kho1.Visible = true;
            this.colTen_Kho1.VisibleIndex = 1;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Location = new System.Drawing.Point(202, 2);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(898, 20);
            this.layoutControl2.TabIndex = 8;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2";
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(898, 20);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Text = "layoutControlGroup2";
            this.layoutControlGroup2.TextVisible = false;
            // 
            // gcList
            // 
            this.gcList.DataSource = this.tONKHOBindingSource;
            this.gcList.Location = new System.Drawing.Point(2, 26);
            this.gcList.MainView = this.gbList;
            this.gcList.MenuManager = this.bm;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rptMayTinh});
            this.gcList.Size = new System.Drawing.Size(1098, 605);
            this.gcList.TabIndex = 4;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            // 
            // tONKHOBindingSource
            // 
            this.tONKHOBindingSource.DataMember = "TON_KHO";
            this.tONKHOBindingSource.DataSource = this.dsTonKho;
            // 
            // gbList
            // 
            this.gbList.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gbList.Appearance.GroupRow.ForeColor = System.Drawing.Color.Red;
            this.gbList.Appearance.GroupRow.Options.UseFont = true;
            this.gbList.Appearance.GroupRow.Options.UseForeColor = true;
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTen_Kho,
            this.colMa_Hang_Hoa,
            this.colTen_Hang,
            this.colDon_Vi,
            this.colMa_Kho_Hang,
            this.colNhom_Hang,
            this.colTen_Nhom_Hang,
            this.colSo_Luong});
            this.gbList.CustomizationFormBounds = new System.Drawing.Rectangle(854, 328, 216, 199);
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.Column = this.colSo_Luong;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition1.Expression = "Iif([So_Luong] < 0, True ,False )";
            this.gbList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gbList.GridControl = this.gcList;
            this.gbList.GroupCount = 1;
            this.gbList.GroupPanelText = "Kéo cột và thả vào đây để nhóm dữ liệu";
            this.gbList.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "So_Luong", null, " - Số Lượng: {0:##,##0.###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "So_Luong", this.colSo_Luong, "{0:##,##0.###}")});
            this.gbList.IndicatorWidth = 40;
            this.gbList.Name = "gbList";
            this.gbList.OptionsBehavior.AutoExpandAllGroups = true;
            this.gbList.OptionsView.ShowAutoFilterRow = true;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTen_Kho, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gbList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gbList_CustomDrawRowIndicator);
            // 
            // colTen_Kho
            // 
            this.colTen_Kho.Caption = "Kho Hàng";
            this.colTen_Kho.FieldName = "Ten_Kho";
            this.colTen_Kho.Name = "colTen_Kho";
            this.colTen_Kho.OptionsColumn.ReadOnly = true;
            this.colTen_Kho.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colMa_Hang_Hoa
            // 
            this.colMa_Hang_Hoa.Caption = "Mã Hàng";
            this.colMa_Hang_Hoa.FieldName = "Ma_Hang_Hoa";
            this.colMa_Hang_Hoa.Name = "colMa_Hang_Hoa";
            this.colMa_Hang_Hoa.OptionsColumn.ReadOnly = true;
            this.colMa_Hang_Hoa.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colMa_Hang_Hoa.Visible = true;
            this.colMa_Hang_Hoa.VisibleIndex = 0;
            this.colMa_Hang_Hoa.Width = 154;
            // 
            // colTen_Hang
            // 
            this.colTen_Hang.Caption = "Tên Hàng";
            this.colTen_Hang.FieldName = "Ten_Hang";
            this.colTen_Hang.Name = "colTen_Hang";
            this.colTen_Hang.OptionsColumn.ReadOnly = true;
            this.colTen_Hang.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTen_Hang.Visible = true;
            this.colTen_Hang.VisibleIndex = 1;
            this.colTen_Hang.Width = 354;
            // 
            // colDon_Vi
            // 
            this.colDon_Vi.Caption = "Đơn Vị";
            this.colDon_Vi.FieldName = "Don_Vi";
            this.colDon_Vi.Name = "colDon_Vi";
            this.colDon_Vi.OptionsColumn.ReadOnly = true;
            this.colDon_Vi.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDon_Vi.Visible = true;
            this.colDon_Vi.VisibleIndex = 2;
            this.colDon_Vi.Width = 132;
            // 
            // colMa_Kho_Hang
            // 
            this.colMa_Kho_Hang.Caption = "Mã Kho";
            this.colMa_Kho_Hang.FieldName = "Ma_Kho_Hang";
            this.colMa_Kho_Hang.Name = "colMa_Kho_Hang";
            this.colMa_Kho_Hang.OptionsColumn.ReadOnly = true;
            this.colMa_Kho_Hang.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colNhom_Hang
            // 
            this.colNhom_Hang.Caption = "Mã Nhóm Hàng";
            this.colNhom_Hang.FieldName = "Nhom_Hang";
            this.colNhom_Hang.Name = "colNhom_Hang";
            this.colNhom_Hang.OptionsColumn.ReadOnly = true;
            this.colNhom_Hang.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colTen_Nhom_Hang
            // 
            this.colTen_Nhom_Hang.Caption = "Nhóm Hàng";
            this.colTen_Nhom_Hang.FieldName = "Ten_Nhom_Hang";
            this.colTen_Nhom_Hang.Name = "colTen_Nhom_Hang";
            this.colTen_Nhom_Hang.OptionsColumn.ReadOnly = true;
            this.colTen_Nhom_Hang.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTen_Nhom_Hang.Visible = true;
            this.colTen_Nhom_Hang.VisibleIndex = 4;
            this.colTen_Nhom_Hang.Width = 318;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem5,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1102, 633);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcList;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1102, 609);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.layoutControl2;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(200, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(902, 24);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtKhoHang;
            this.layoutControlItem2.CustomizationFormText = "Kho hàng";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(250, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(103, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Kho hàng";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(45, 13);
            // 
            // tON_KHOTableAdapter
            // 
            this.tON_KHOTableAdapter.ClearBeforeFill = true;
            // 
            // kHO_HANGTableAdapter
            // 
            this.kHO_HANGTableAdapter.ClearBeforeFill = true;
            // 
            // TonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 659);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "TonKho";
            this.Text = "Tồn Kho";
            ((System.ComponentModel.ISupportInitialize)(this.rptMayTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTonKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tONKHOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ImageCollection img;
        private DevExpress.XtraBars.BarManager bm;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem bbiXem;
        private DevExpress.XtraBars.BarButtonItem bbiSua;
        private DevExpress.XtraBars.BarButtonItem bbiXoa;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gbList;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem bbiDong;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rptMayTinh;
        private Do_An_Quan_Ly_Kho.TonKho.DS.dsTonKho dsTonKho;
        private System.Windows.Forms.BindingSource tONKHOBindingSource;
        private Do_An_Quan_Ly_Kho.TonKho.DS.dsTonKhoTableAdapters.TON_KHOTableAdapter tON_KHOTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Kho;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Hang_Hoa;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Hang;
        private DevExpress.XtraGrid.Columns.GridColumn colDon_Vi;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Kho_Hang;
        private DevExpress.XtraGrid.Columns.GridColumn colNhom_Hang;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Nhom_Hang;
        private DevExpress.XtraGrid.Columns.GridColumn colSo_Luong;
        private DevExpress.XtraEditors.GridLookUpEdit txtKhoHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource kHOHANGBindingSource;
        private Do_An_Quan_Ly_Kho.TonKho.DS.dsTonKhoTableAdapters.KHO_HANGTableAdapter kHO_HANGTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Kho;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Kho1;
    }
}

