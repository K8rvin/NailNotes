namespace LizokasNail.Client.UserControls
{
    partial class UCCheck
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
            this.components = new System.ComponentModel.Container();
            this.gridControlCheck = new DevExpress.XtraGrid.GridControl();
            this.gridViewCheck = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnComment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridColumnDesignNames = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTopNames = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnColorNames = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBaseNames = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlCheck
            // 
            this.gridControlCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCheck.Location = new System.Drawing.Point(0, 29);
            this.gridControlCheck.MainView = this.gridViewCheck;
            this.gridControlCheck.Name = "gridControlCheck";
            this.gridControlCheck.Size = new System.Drawing.Size(705, 485);
            this.gridControlCheck.TabIndex = 4;
            this.gridControlCheck.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCheck});
            this.gridControlCheck.DoubleClick += new System.EventHandler(this.gridViewUser_DoubleClick);
            // 
            // gridViewCheck
            // 
            this.gridViewCheck.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnUser,
            this.gridColumnDate,
            this.gridColumnBaseNames,
            this.gridColumnColorNames,
            this.gridColumnTopNames,
            this.gridColumnDesignNames,
            this.gridColumnPrice,
            this.gridColumnComment});
            this.gridViewCheck.GridControl = this.gridControlCheck;
            this.gridViewCheck.Name = "gridViewCheck";
            this.gridViewCheck.OptionsBehavior.Editable = false;
            this.gridViewCheck.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewCheck.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCheck.OptionsView.ShowFooter = true;
            // 
            // gridColumnUser
            // 
            this.gridColumnUser.Caption = "Клиент";
            this.gridColumnUser.FieldName = "UserName";
            this.gridColumnUser.Name = "gridColumnUser";
            this.gridColumnUser.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Name", "Всего: {0}")});
            this.gridColumnUser.Visible = true;
            this.gridColumnUser.VisibleIndex = 0;
            // 
            // gridColumnDate
            // 
            this.gridColumnDate.Caption = "Дата";
            this.gridColumnDate.FieldName = "RecordDate";
            this.gridColumnDate.Name = "gridColumnDate";
            this.gridColumnDate.Visible = true;
            this.gridColumnDate.VisibleIndex = 1;
            // 
            // gridColumnComment
            // 
            this.gridColumnComment.Caption = "Примечание";
            this.gridColumnComment.FieldName = "Comment";
            this.gridColumnComment.Name = "gridColumnComment";
            this.gridColumnComment.Visible = true;
            this.gridColumnComment.VisibleIndex = 7;
            // 
            // gridColumnPrice
            // 
            this.gridColumnPrice.Caption = "Стоимость";
            this.gridColumnPrice.FieldName = "Price";
            this.gridColumnPrice.Name = "gridColumnPrice";
            this.gridColumnPrice.Visible = true;
            this.gridColumnPrice.VisibleIndex = 6;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemRefresh,
            this.barButtonItemAdd,
            this.barButtonItemDelete,
            this.barButtonItemEdit});
            this.barManager1.MaxItemId = 4;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDelete)});
            this.bar1.Text = "Tools";
            // 
            // barButtonItemAdd
            // 
            this.barButtonItemAdd.Caption = "Добавить";
            this.barButtonItemAdd.Id = 1;
            this.barButtonItemAdd.Name = "barButtonItemAdd";
            this.barButtonItemAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAdd_ItemClick);
            // 
            // barButtonItemRefresh
            // 
            this.barButtonItemRefresh.Caption = "Обновить";
            this.barButtonItemRefresh.Id = 0;
            this.barButtonItemRefresh.Name = "barButtonItemRefresh";
            this.barButtonItemRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemRefresh_ItemClick);
            // 
            // barButtonItemEdit
            // 
            this.barButtonItemEdit.Caption = "Редактировать";
            this.barButtonItemEdit.Id = 3;
            this.barButtonItemEdit.Name = "barButtonItemEdit";
            this.barButtonItemEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemEdit_ItemClick);
            // 
            // barButtonItemDelete
            // 
            this.barButtonItemDelete.Caption = "Удалить";
            this.barButtonItemDelete.Id = 2;
            this.barButtonItemDelete.Name = "barButtonItemDelete";
            this.barButtonItemDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDelete_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(705, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 514);
            this.barDockControlBottom.Size = new System.Drawing.Size(705, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 485);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(705, 29);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 485);
            // 
            // gridColumnDesignNames
            // 
            this.gridColumnDesignNames.Caption = "Дизайны";
            this.gridColumnDesignNames.FieldName = "DesignNames";
            this.gridColumnDesignNames.Name = "gridColumnDesignNames";
            this.gridColumnDesignNames.Visible = true;
            this.gridColumnDesignNames.VisibleIndex = 5;
            // 
            // gridColumnTopNames
            // 
            this.gridColumnTopNames.Caption = "Топы";
            this.gridColumnTopNames.FieldName = "TopNames";
            this.gridColumnTopNames.Name = "gridColumnTopNames";
            this.gridColumnTopNames.Visible = true;
            this.gridColumnTopNames.VisibleIndex = 4;
            // 
            // gridColumnColorNames
            // 
            this.gridColumnColorNames.Caption = "Цвета";
            this.gridColumnColorNames.FieldName = "ColorNames";
            this.gridColumnColorNames.Name = "gridColumnColorNames";
            this.gridColumnColorNames.Visible = true;
            this.gridColumnColorNames.VisibleIndex = 3;
            // 
            // gridColumnBaseNames
            // 
            this.gridColumnBaseNames.Caption = "Базы";
            this.gridColumnBaseNames.FieldName = "BaseNames";
            this.gridColumnBaseNames.Name = "gridColumnBaseNames";
            this.gridColumnBaseNames.Visible = true;
            this.gridColumnBaseNames.VisibleIndex = 2;
            // 
            // UCCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlCheck);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UCCheck";
            this.Size = new System.Drawing.Size(705, 514);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlCheck;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCheck;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUser;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRefresh;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnComment;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBaseNames;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnColorNames;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTopNames;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDesignNames;
    }
}
