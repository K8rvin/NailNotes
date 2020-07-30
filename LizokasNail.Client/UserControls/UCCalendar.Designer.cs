namespace LizokasNail.Client.UserControls
{
    partial class UCCalendar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.gridControlYesterday = new DevExpress.XtraGrid.GridControl();
            this.gridViewYesterday = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnRecordDateY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUserNameY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCheckPriceY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlTomorrow = new DevExpress.XtraGrid.GridControl();
            this.gridViewTomorrow = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnRecordDateT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUserNameT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCheckPriceT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlCurrentDate = new DevExpress.XtraGrid.GridControl();
            this.gridViewCurrentDate = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnRecordDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCheckPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlYesterday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewYesterday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTomorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTomorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCurrentDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCurrentDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.gridControlYesterday);
            this.layoutControl.Controls.Add(this.gridControlTomorrow);
            this.layoutControl.Controls.Add(this.gridControlCurrentDate);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(739, 331, 250, 350);
            this.layoutControl.Root = this.layoutControlGroup1;
            this.layoutControl.Size = new System.Drawing.Size(470, 600);
            this.layoutControl.TabIndex = 1;
            // 
            // gridControlYesterday
            // 
            this.gridControlYesterday.Location = new System.Drawing.Point(12, 12);
            this.gridControlYesterday.MainView = this.gridViewYesterday;
            this.gridControlYesterday.Name = "gridControlYesterday";
            this.gridControlYesterday.Size = new System.Drawing.Size(446, 191);
            this.gridControlYesterday.TabIndex = 5;
            this.gridControlYesterday.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewYesterday});
            // 
            // gridViewYesterday
            // 
            this.gridViewYesterday.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 13F);
            this.gridViewYesterday.Appearance.Row.Options.UseFont = true;
            this.gridViewYesterday.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnRecordDateY,
            this.gridColumnUserNameY,
            this.gridColumnCheckPriceY});
            this.gridViewYesterday.GridControl = this.gridControlYesterday;
            this.gridViewYesterday.Name = "gridViewYesterday";
            this.gridViewYesterday.OptionsBehavior.Editable = false;
            this.gridViewYesterday.OptionsBehavior.ReadOnly = true;
            this.gridViewYesterday.OptionsCustomization.AllowColumnMoving = false;
            this.gridViewYesterday.OptionsCustomization.AllowColumnResizing = false;
            this.gridViewYesterday.OptionsCustomization.AllowFilter = false;
            this.gridViewYesterday.OptionsCustomization.AllowGroup = false;
            this.gridViewYesterday.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridViewYesterday.OptionsCustomization.AllowSort = false;
            this.gridViewYesterday.OptionsView.ShowGroupPanel = false;
            this.gridViewYesterday.OptionsView.ShowIndicator = false;
            this.gridViewYesterday.OptionsView.ShowViewCaption = true;
            this.gridViewYesterday.ViewCaption = "Yesterday";
            this.gridViewYesterday.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            // 
            // gridColumnRecordDateY
            // 
            this.gridColumnRecordDateY.Caption = "Время";
            this.gridColumnRecordDateY.DisplayFormat.FormatString = "t";
            this.gridColumnRecordDateY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnRecordDateY.FieldName = "RecordDate";
            this.gridColumnRecordDateY.MaxWidth = 70;
            this.gridColumnRecordDateY.Name = "gridColumnRecordDateY";
            this.gridColumnRecordDateY.Visible = true;
            this.gridColumnRecordDateY.VisibleIndex = 0;
            this.gridColumnRecordDateY.Width = 70;
            // 
            // gridColumnUserNameY
            // 
            this.gridColumnUserNameY.Caption = "Клиент";
            this.gridColumnUserNameY.FieldName = "UserName";
            this.gridColumnUserNameY.Name = "gridColumnUserNameY";
            this.gridColumnUserNameY.Visible = true;
            this.gridColumnUserNameY.VisibleIndex = 1;
            // 
            // gridColumnCheckPriceY
            // 
            this.gridColumnCheckPriceY.Caption = "Чек";
            this.gridColumnCheckPriceY.DisplayFormat.FormatString = "c0";
            this.gridColumnCheckPriceY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnCheckPriceY.FieldName = "Check.Price";
            this.gridColumnCheckPriceY.MaxWidth = 80;
            this.gridColumnCheckPriceY.Name = "gridColumnCheckPriceY";
            this.gridColumnCheckPriceY.Visible = true;
            this.gridColumnCheckPriceY.VisibleIndex = 2;
            this.gridColumnCheckPriceY.Width = 80;
            // 
            // gridControlTomorrow
            // 
            this.gridControlTomorrow.Location = new System.Drawing.Point(12, 402);
            this.gridControlTomorrow.MainView = this.gridViewTomorrow;
            this.gridControlTomorrow.Name = "gridControlTomorrow";
            this.gridControlTomorrow.Size = new System.Drawing.Size(446, 186);
            this.gridControlTomorrow.TabIndex = 4;
            this.gridControlTomorrow.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTomorrow});
            // 
            // gridViewTomorrow
            // 
            this.gridViewTomorrow.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 13F);
            this.gridViewTomorrow.Appearance.Row.Options.UseFont = true;
            this.gridViewTomorrow.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnRecordDateT,
            this.gridColumnUserNameT,
            this.gridColumnCheckPriceT});
            this.gridViewTomorrow.GridControl = this.gridControlTomorrow;
            this.gridViewTomorrow.Name = "gridViewTomorrow";
            this.gridViewTomorrow.OptionsBehavior.Editable = false;
            this.gridViewTomorrow.OptionsBehavior.ReadOnly = true;
            this.gridViewTomorrow.OptionsCustomization.AllowColumnMoving = false;
            this.gridViewTomorrow.OptionsCustomization.AllowColumnResizing = false;
            this.gridViewTomorrow.OptionsCustomization.AllowFilter = false;
            this.gridViewTomorrow.OptionsCustomization.AllowGroup = false;
            this.gridViewTomorrow.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridViewTomorrow.OptionsCustomization.AllowSort = false;
            this.gridViewTomorrow.OptionsView.ShowGroupPanel = false;
            this.gridViewTomorrow.OptionsView.ShowIndicator = false;
            this.gridViewTomorrow.OptionsView.ShowViewCaption = true;
            this.gridViewTomorrow.ViewCaption = "Tomorrow";
            this.gridViewTomorrow.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            // 
            // gridColumnRecordDateT
            // 
            this.gridColumnRecordDateT.Caption = "Время";
            this.gridColumnRecordDateT.DisplayFormat.FormatString = "t";
            this.gridColumnRecordDateT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnRecordDateT.FieldName = "RecordDate";
            this.gridColumnRecordDateT.MaxWidth = 70;
            this.gridColumnRecordDateT.Name = "gridColumnRecordDateT";
            this.gridColumnRecordDateT.Visible = true;
            this.gridColumnRecordDateT.VisibleIndex = 0;
            this.gridColumnRecordDateT.Width = 70;
            // 
            // gridColumnUserNameT
            // 
            this.gridColumnUserNameT.Caption = "Клиент";
            this.gridColumnUserNameT.FieldName = "UserName";
            this.gridColumnUserNameT.Name = "gridColumnUserNameT";
            this.gridColumnUserNameT.Visible = true;
            this.gridColumnUserNameT.VisibleIndex = 1;
            // 
            // gridColumnCheckPriceT
            // 
            this.gridColumnCheckPriceT.Caption = "Чек";
            this.gridColumnCheckPriceT.DisplayFormat.FormatString = "c0";
            this.gridColumnCheckPriceT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnCheckPriceT.FieldName = "Check.Price";
            this.gridColumnCheckPriceT.MaxWidth = 80;
            this.gridColumnCheckPriceT.Name = "gridColumnCheckPriceT";
            this.gridColumnCheckPriceT.Visible = true;
            this.gridColumnCheckPriceT.VisibleIndex = 2;
            this.gridColumnCheckPriceT.Width = 80;
            // 
            // gridControlCurrentDate
            // 
            this.gridControlCurrentDate.Location = new System.Drawing.Point(12, 207);
            this.gridControlCurrentDate.MainView = this.gridViewCurrentDate;
            this.gridControlCurrentDate.Name = "gridControlCurrentDate";
            this.gridControlCurrentDate.Size = new System.Drawing.Size(446, 191);
            this.gridControlCurrentDate.TabIndex = 0;
            this.gridControlCurrentDate.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCurrentDate});
            // 
            // gridViewCurrentDate
            // 
            this.gridViewCurrentDate.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 13F);
            this.gridViewCurrentDate.Appearance.Row.Options.UseFont = true;
            this.gridViewCurrentDate.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnRecordDate,
            this.gridColumnUserName,
            this.gridColumnCheckPrice});
            this.gridViewCurrentDate.GridControl = this.gridControlCurrentDate;
            this.gridViewCurrentDate.Name = "gridViewCurrentDate";
            this.gridViewCurrentDate.OptionsBehavior.Editable = false;
            this.gridViewCurrentDate.OptionsBehavior.ReadOnly = true;
            this.gridViewCurrentDate.OptionsCustomization.AllowColumnMoving = false;
            this.gridViewCurrentDate.OptionsCustomization.AllowColumnResizing = false;
            this.gridViewCurrentDate.OptionsCustomization.AllowFilter = false;
            this.gridViewCurrentDate.OptionsCustomization.AllowGroup = false;
            this.gridViewCurrentDate.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridViewCurrentDate.OptionsCustomization.AllowSort = false;
            this.gridViewCurrentDate.OptionsView.ShowGroupPanel = false;
            this.gridViewCurrentDate.OptionsView.ShowIndicator = false;
            this.gridViewCurrentDate.OptionsView.ShowViewCaption = true;
            this.gridViewCurrentDate.ViewCaption = "CurrentDate";
            this.gridViewCurrentDate.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            // 
            // gridColumnRecordDate
            // 
            this.gridColumnRecordDate.Caption = "Время";
            this.gridColumnRecordDate.DisplayFormat.FormatString = "t";
            this.gridColumnRecordDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnRecordDate.FieldName = "RecordDate";
            this.gridColumnRecordDate.MaxWidth = 70;
            this.gridColumnRecordDate.Name = "gridColumnRecordDate";
            this.gridColumnRecordDate.Visible = true;
            this.gridColumnRecordDate.VisibleIndex = 0;
            this.gridColumnRecordDate.Width = 70;
            // 
            // gridColumnUserName
            // 
            this.gridColumnUserName.Caption = "Клиент";
            this.gridColumnUserName.FieldName = "UserName";
            this.gridColumnUserName.Name = "gridColumnUserName";
            this.gridColumnUserName.Visible = true;
            this.gridColumnUserName.VisibleIndex = 1;
            // 
            // gridColumnCheckPrice
            // 
            this.gridColumnCheckPrice.Caption = "Чек";
            this.gridColumnCheckPrice.DisplayFormat.FormatString = "c0";
            this.gridColumnCheckPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnCheckPrice.FieldName = "Check.Price";
            this.gridColumnCheckPrice.MaxWidth = 80;
            this.gridColumnCheckPrice.Name = "gridColumnCheckPrice";
            this.gridColumnCheckPrice.Visible = true;
            this.gridColumnCheckPrice.VisibleIndex = 2;
            this.gridColumnCheckPrice.Width = 80;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(470, 600);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControlTomorrow;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 390);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(450, 190);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridControlYesterday;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(450, 195);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlCurrentDate;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 195);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(201, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(450, 195);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // UCCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl);
            this.Name = "UCCalendar";
            this.Size = new System.Drawing.Size(470, 600);
            this.Load += new System.EventHandler(this.UCCalendar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlYesterday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewYesterday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTomorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTomorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCurrentDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCurrentDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraGrid.GridControl gridControlYesterday;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewYesterday;
        private DevExpress.XtraGrid.GridControl gridControlTomorrow;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTomorrow;
        private DevExpress.XtraGrid.GridControl gridControlCurrentDate;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCurrentDate;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRecordDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUserName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCheckPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRecordDateY;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUserNameY;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCheckPriceY;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRecordDateT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUserNameT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCheckPriceT;
    }
}
