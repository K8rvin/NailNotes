﻿namespace LizokasNail.Client.UserControls
{
    partial class UCPriceCost
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
            this.gridControlPriceCost = new DevExpress.XtraGrid.GridControl();
            this.gridViewPriceCost = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnProcedure = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDateEnd = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPriceCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPriceCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlPriceCost
            // 
            this.gridControlPriceCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPriceCost.Location = new System.Drawing.Point(0, 29);
            this.gridControlPriceCost.MainView = this.gridViewPriceCost;
            this.gridControlPriceCost.Name = "gridControlPriceCost";
            this.gridControlPriceCost.Size = new System.Drawing.Size(738, 429);
            this.gridControlPriceCost.TabIndex = 4;
            this.gridControlPriceCost.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPriceCost});
            // 
            // gridViewPriceCost
            // 
            this.gridViewPriceCost.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnType,
            this.gridColumnProcedure,
            this.gridColumnValue,
            this.gridColumnDateEnd});
            this.gridViewPriceCost.GridControl = this.gridControlPriceCost;
            this.gridViewPriceCost.Name = "gridViewPriceCost";
            this.gridViewPriceCost.OptionsBehavior.Editable = false;
            this.gridViewPriceCost.OptionsView.ShowAutoFilterRow = true;
            this.gridViewPriceCost.OptionsView.ShowFooter = true;
            this.gridViewPriceCost.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            // 
            // gridColumnType
            // 
            this.gridColumnType.Caption = "Тип";
            this.gridColumnType.FieldName = "Type";
            this.gridColumnType.Name = "gridColumnType";
            this.gridColumnType.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Name", "Всего: {0}")});
            this.gridColumnType.Visible = true;
            this.gridColumnType.VisibleIndex = 0;
            // 
            // gridColumnProcedure
            // 
            this.gridColumnProcedure.Caption = "Процедура";
            this.gridColumnProcedure.FieldName = "Procedure";
            this.gridColumnProcedure.Name = "gridColumnProcedure";
            this.gridColumnProcedure.Visible = true;
            this.gridColumnProcedure.VisibleIndex = 1;
            // 
            // gridColumnValue
            // 
            this.gridColumnValue.Caption = "Значение";
            this.gridColumnValue.FieldName = "Value";
            this.gridColumnValue.Name = "gridColumnValue";
            this.gridColumnValue.Visible = true;
            this.gridColumnValue.VisibleIndex = 2;
            // 
            // gridColumnDateEnd
            // 
            this.gridColumnDateEnd.Caption = "Срок действия";
            this.gridColumnDateEnd.DisplayFormat.FormatString = "Y";
            this.gridColumnDateEnd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnDateEnd.FieldName = "DateEnd";
            this.gridColumnDateEnd.Name = "gridColumnDateEnd";
            this.gridColumnDateEnd.Visible = true;
            this.gridColumnDateEnd.VisibleIndex = 3;
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
            this.barDockControlTop.Size = new System.Drawing.Size(738, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 458);
            this.barDockControlBottom.Size = new System.Drawing.Size(738, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 429);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(738, 29);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 429);
            // 
            // UCPriceCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlPriceCost);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UCPriceCost";
            this.Size = new System.Drawing.Size(738, 458);
            this.Load += new System.EventHandler(this.UCBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPriceCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPriceCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlPriceCost;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPriceCost;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnType;
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
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnProcedure;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnValue;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDateEnd;
    }
}
