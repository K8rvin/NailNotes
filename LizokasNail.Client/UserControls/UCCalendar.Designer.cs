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
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gridControlTomorrow = new DevExpress.XtraGrid.GridControl();
            this.gridViewTomorrow = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridViewCurrentDate = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlCurrentDate = new DevExpress.XtraGrid.GridControl();
            this.gridControlYesterday = new DevExpress.XtraGrid.GridControl();
            this.gridViewYesterday = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTomorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTomorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCurrentDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCurrentDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlYesterday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewYesterday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
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
            this.gridViewTomorrow.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewTomorrow.OptionsView.ShowViewCaption = true;
            this.gridViewTomorrow.ViewCaption = "Tomorrow";
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
            // gridViewCurrentDate
            // 
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
            this.gridViewCurrentDate.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewCurrentDate.OptionsView.ShowViewCaption = true;
            this.gridViewCurrentDate.ViewCaption = "CurrentDate";
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
            this.gridViewYesterday.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewYesterday.OptionsView.ShowViewCaption = true;
            this.gridViewYesterday.ViewCaption = "Yesterday";
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
            // UCCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl);
            this.Name = "UCCalendar";
            this.Size = new System.Drawing.Size(470, 600);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTomorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTomorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCurrentDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCurrentDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlYesterday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewYesterday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
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
    }
}
