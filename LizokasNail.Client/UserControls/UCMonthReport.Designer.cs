namespace LizokasNail.Client.UserControls
{
    partial class UCMonthReport
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
            this.gridControlReport = new DevExpress.XtraGrid.GridControl();
            this.gridViewReport = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnProcedure = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCostPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnClientCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCostSumm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItemYear = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItemMonth = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemMonth1 = new DevExpress.XtraScheduler.UI.RepositoryItemMonth();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.numericUpDownTotalIncoming = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTotalPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTotalCost = new System.Windows.Forms.NumericUpDown();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMonth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalIncoming)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlReport
            // 
            this.gridControlReport.Location = new System.Drawing.Point(10, 10);
            this.gridControlReport.MainView = this.gridViewReport;
            this.gridControlReport.Name = "gridControlReport";
            this.gridControlReport.Size = new System.Drawing.Size(629, 393);
            this.gridControlReport.TabIndex = 0;
            this.gridControlReport.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewReport});
            // 
            // gridViewReport
            // 
            this.gridViewReport.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnType,
            this.gridColumnProcedure,
            this.gridColumnCostPrice,
            this.gridColumnClientCount,
            this.gridColumnCostSumm});
            this.gridViewReport.GridControl = this.gridControlReport;
            this.gridViewReport.Name = "gridViewReport";
            this.gridViewReport.OptionsCustomization.AllowSort = false;
            this.gridViewReport.OptionsMenu.ShowGroupSortSummaryItems = false;
            this.gridViewReport.OptionsView.AllowCellMerge = true;
            this.gridViewReport.OptionsView.ShowGroupPanel = false;
            this.gridViewReport.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewReport_CellValueChanged);
            // 
            // gridColumnType
            // 
            this.gridColumnType.Caption = "СТАТЬИ РАСХОДОВ";
            this.gridColumnType.FieldName = "Type";
            this.gridColumnType.Name = "gridColumnType";
            this.gridColumnType.OptionsColumn.AllowEdit = false;
            this.gridColumnType.Visible = true;
            this.gridColumnType.VisibleIndex = 0;
            // 
            // gridColumnProcedure
            // 
            this.gridColumnProcedure.Caption = "СТАТЬИ РАСХОДОВ";
            this.gridColumnProcedure.FieldName = "Procedure";
            this.gridColumnProcedure.Name = "gridColumnProcedure";
            this.gridColumnProcedure.OptionsColumn.AllowEdit = false;
            this.gridColumnProcedure.Visible = true;
            this.gridColumnProcedure.VisibleIndex = 1;
            // 
            // gridColumnCostPrice
            // 
            this.gridColumnCostPrice.Caption = "СЕБЕСТОИМОСТЬ";
            this.gridColumnCostPrice.FieldName = "CostPrice";
            this.gridColumnCostPrice.Name = "gridColumnCostPrice";
            this.gridColumnCostPrice.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnCostPrice.Visible = true;
            this.gridColumnCostPrice.VisibleIndex = 2;
            // 
            // gridColumnClientCount
            // 
            this.gridColumnClientCount.Caption = "КОЛ-ВО КЛИЕНТОВ";
            this.gridColumnClientCount.FieldName = "ClientCount";
            this.gridColumnClientCount.Name = "gridColumnClientCount";
            this.gridColumnClientCount.OptionsColumn.AllowEdit = false;
            this.gridColumnClientCount.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnClientCount.Visible = true;
            this.gridColumnClientCount.VisibleIndex = 3;
            // 
            // gridColumnCostSumm
            // 
            this.gridColumnCostSumm.Caption = "СУММА";
            this.gridColumnCostSumm.FieldName = "CostSumm";
            this.gridColumnCostSumm.Name = "gridColumnCostSumm";
            this.gridColumnCostSumm.OptionsColumn.AllowEdit = false;
            this.gridColumnCostSumm.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumnCostSumm.Visible = true;
            this.gridColumnCostSumm.VisibleIndex = 4;
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
            this.barStaticItem1,
            this.barEditItemMonth,
            this.barStaticItem2,
            this.barEditItemYear});
            this.barManager1.MaxItemId = 12;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2,
            this.repositoryItemMonth1,
            this.repositoryItemTextEdit1});
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditItemYear),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem2, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditItemMonth)});
            this.bar1.Text = "Tools";
            // 
            // barButtonItemRefresh
            // 
            this.barButtonItemRefresh.Caption = "Обновить";
            this.barButtonItemRefresh.Id = 0;
            this.barButtonItemRefresh.Name = "barButtonItemRefresh";
            this.barButtonItemRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemRefresh_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Год: ";
            this.barStaticItem1.Id = 4;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barEditItemYear
            // 
            this.barEditItemYear.Edit = this.repositoryItemTextEdit1;
            this.barEditItemYear.EditWidth = 58;
            this.barEditItemYear.Id = 11;
            this.barEditItemYear.Name = "barEditItemYear";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.BeepOnError = true;
            this.repositoryItemTextEdit1.Mask.EditMask = "20\\d{2}";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Месяц: ";
            this.barStaticItem2.Id = 9;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barEditItemMonth
            // 
            this.barEditItemMonth.Edit = this.repositoryItemMonth1;
            this.barEditItemMonth.EditWidth = 124;
            this.barEditItemMonth.Id = 8;
            this.barEditItemMonth.Name = "barEditItemMonth";
            // 
            // repositoryItemMonth1
            // 
            this.repositoryItemMonth1.AutoHeight = false;
            this.repositoryItemMonth1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMonth1.Name = "repositoryItemMonth1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(649, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 514);
            this.barDockControlBottom.Size = new System.Drawing.Size(649, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(649, 29);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 485);
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.numericUpDownTotalIncoming);
            this.layoutControl1.Controls.Add(this.numericUpDownTotalPrice);
            this.layoutControl1.Controls.Add(this.numericUpDownTotalCost);
            this.layoutControl1.Controls.Add(this.labelControl3);
            this.layoutControl1.Controls.Add(this.labelControl);
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.gridControlReport);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 29);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(649, 485);
            this.layoutControl1.TabIndex = 9;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // numericUpDownTotalIncoming
            // 
            this.numericUpDownTotalIncoming.Location = new System.Drawing.Point(518, 453);
            this.numericUpDownTotalIncoming.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDownTotalIncoming.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.numericUpDownTotalIncoming.Name = "numericUpDownTotalIncoming";
            this.numericUpDownTotalIncoming.ReadOnly = true;
            this.numericUpDownTotalIncoming.Size = new System.Drawing.Size(119, 20);
            this.numericUpDownTotalIncoming.TabIndex = 8;
            // 
            // numericUpDownTotalPrice
            // 
            this.numericUpDownTotalPrice.Location = new System.Drawing.Point(518, 429);
            this.numericUpDownTotalPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDownTotalPrice.Name = "numericUpDownTotalPrice";
            this.numericUpDownTotalPrice.ReadOnly = true;
            this.numericUpDownTotalPrice.Size = new System.Drawing.Size(119, 20);
            this.numericUpDownTotalPrice.TabIndex = 7;
            // 
            // numericUpDownTotalCost
            // 
            this.numericUpDownTotalCost.Location = new System.Drawing.Point(518, 405);
            this.numericUpDownTotalCost.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDownTotalCost.Name = "numericUpDownTotalCost";
            this.numericUpDownTotalCost.ReadOnly = true;
            this.numericUpDownTotalCost.Size = new System.Drawing.Size(119, 20);
            this.numericUpDownTotalCost.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(405, 453);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(109, 13);
            this.labelControl3.StyleController = this.layoutControl1;
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "ПРИБЫЛЬ:";
            // 
            // labelControl
            // 
            this.labelControl.Location = new System.Drawing.Point(405, 429);
            this.labelControl.Name = "labelControl";
            this.labelControl.Size = new System.Drawing.Size(109, 13);
            this.labelControl.StyleController = this.layoutControl1;
            this.labelControl.TabIndex = 4;
            this.labelControl.Text = "ДОХОД (ВЫРУЧКА):";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(405, 405);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 13);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "ИТОГО РАСХОДЫ:";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(649, 485);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlReport;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(629, 393);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.labelControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(393, 393);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(0, 17);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(96, 17);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(113, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.labelControl;
            this.layoutControlItem3.Location = new System.Drawing.Point(393, 417);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(0, 17);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(105, 17);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(113, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.labelControl3;
            this.layoutControlItem4.Location = new System.Drawing.Point(393, 441);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(0, 17);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(55, 17);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(113, 24);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.numericUpDownTotalCost;
            this.layoutControlItem5.Location = new System.Drawing.Point(506, 393);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(123, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.numericUpDownTotalPrice;
            this.layoutControlItem6.Location = new System.Drawing.Point(506, 417);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(123, 24);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.numericUpDownTotalIncoming;
            this.layoutControlItem7.Location = new System.Drawing.Point(506, 441);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(123, 24);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 393);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(393, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 417);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(393, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 441);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(393, 24);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // UCMonthReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UCMonthReport";
            this.Size = new System.Drawing.Size(649, 514);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMonth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalIncoming)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlReport;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewReport;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRefresh;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnProcedure;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCostPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnClientCount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCostSumm;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.NumericUpDown numericUpDownTotalIncoming;
        private System.Windows.Forms.NumericUpDown numericUpDownTotalPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownTotalCost;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarEditItem barEditItemMonth;
        private DevExpress.XtraScheduler.UI.RepositoryItemMonth repositoryItemMonth1;
        private DevExpress.XtraBars.BarEditItem barEditItemYear;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
    }
}
