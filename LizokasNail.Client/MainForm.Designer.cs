namespace LizokasNail.Client
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItemMenu = new DevExpress.XtraBars.BarSubItem();
            this.barSubItemDictionaries = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemMaterials = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemUsers = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRecords = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCheck = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barButtonItemRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItemBase = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemColor = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemTop = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemMaterials = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemDesign = new DevExpress.XtraBars.BarButtonItem();
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageMain = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControlMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.ucCalendar1 = new LizokasNail.Client.UserControls.UCCalendar();
            this.layoutControlButtons = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButtonMaterials = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonRecording = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemRecording = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemMaterials = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButtonUsers = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItemUsers = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.xtraTabControl.SuspendLayout();
            this.xtraTabPageMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlMain)).BeginInit();
            this.splitContainerControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlButtons)).BeginInit();
            this.layoutControlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemRecording)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItemMenu,
            this.barButtonItemUsers,
            this.barButtonItemRecords,
            this.barButtonItemBase,
            this.barButtonItemColor,
            this.barButtonItemTop,
            this.barSubItemDictionaries,
            this.barSubItemMaterials,
            this.barButtonItemDesign,
            this.barButtonItemCheck,
            this.barButtonItemMaterials,
            this.barButtonItemRefresh});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 18;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemMenu),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemDictionaries)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DisableClose = true;
            this.bar2.OptionsBar.DisableCustomization = true;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.RotateWhenVertical = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barSubItemMenu
            // 
            this.barSubItemMenu.Caption = "Основное";
            this.barSubItemMenu.Id = 1;
            this.barSubItemMenu.Name = "barSubItemMenu";
            // 
            // barSubItemDictionaries
            // 
            this.barSubItemDictionaries.Caption = "Статистика";
            this.barSubItemDictionaries.Id = 7;
            this.barSubItemDictionaries.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemMaterials),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemUsers),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemRecords),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemCheck)});
            this.barSubItemDictionaries.Name = "barSubItemDictionaries";
            // 
            // barButtonItemMaterials
            // 
            this.barButtonItemMaterials.Caption = "Материалы";
            this.barButtonItemMaterials.Id = 11;
            this.barButtonItemMaterials.Name = "barButtonItemMaterials";
            this.barButtonItemMaterials.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemMaterials_ItemClick);
            // 
            // barButtonItemUsers
            // 
            this.barButtonItemUsers.Caption = "Клиенты";
            this.barButtonItemUsers.Id = 2;
            this.barButtonItemUsers.Name = "barButtonItemUsers";
            this.barButtonItemUsers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemUsers_ItemClick);
            // 
            // barButtonItemRecords
            // 
            this.barButtonItemRecords.Caption = "Записи на прием";
            this.barButtonItemRecords.Id = 3;
            this.barButtonItemRecords.Name = "barButtonItemRecords";
            this.barButtonItemRecords.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemRecords_ItemClick);
            // 
            // barButtonItemCheck
            // 
            this.barButtonItemCheck.Caption = "Расчеты";
            this.barButtonItemCheck.Id = 10;
            this.barButtonItemCheck.Name = "barButtonItemCheck";
            this.barButtonItemCheck.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCheck_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemRefresh)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DisableClose = true;
            this.bar3.OptionsBar.DisableCustomization = true;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.RotateWhenVertical = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barButtonItemRefresh
            // 
            this.barButtonItemRefresh.Caption = "Обновить";
            this.barButtonItemRefresh.Id = 17;
            this.barButtonItemRefresh.Name = "barButtonItemRefresh";
            this.barButtonItemRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemRefresh_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(800, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 512);
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 490);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 22);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 490);
            // 
            // barButtonItemBase
            // 
            this.barButtonItemBase.Id = 12;
            this.barButtonItemBase.Name = "barButtonItemBase";
            // 
            // barButtonItemColor
            // 
            this.barButtonItemColor.Id = 13;
            this.barButtonItemColor.Name = "barButtonItemColor";
            // 
            // barButtonItemTop
            // 
            this.barButtonItemTop.Id = 14;
            this.barButtonItemTop.Name = "barButtonItemTop";
            // 
            // barSubItemMaterials
            // 
            this.barSubItemMaterials.Id = 15;
            this.barSubItemMaterials.Name = "barSubItemMaterials";
            // 
            // barButtonItemDesign
            // 
            this.barButtonItemDesign.Id = 16;
            this.barButtonItemDesign.Name = "barButtonItemDesign";
            // 
            // xtraTabControl
            // 
            this.xtraTabControl.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl.Location = new System.Drawing.Point(0, 22);
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.SelectedTabPage = this.xtraTabPageMain;
            this.xtraTabControl.Size = new System.Drawing.Size(800, 490);
            this.xtraTabControl.TabIndex = 4;
            this.xtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageMain});
            this.xtraTabControl.CloseButtonClick += new System.EventHandler(this.xtraTabControl_CloseButtonClick);
            // 
            // xtraTabPageMain
            // 
            this.xtraTabPageMain.Controls.Add(this.splitContainerControlMain);
            this.xtraTabPageMain.Name = "xtraTabPageMain";
            this.xtraTabPageMain.Size = new System.Drawing.Size(794, 462);
            this.xtraTabPageMain.Text = "Информация";
            // 
            // splitContainerControlMain
            // 
            this.splitContainerControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControlMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControlMain.Name = "splitContainerControlMain";
            this.splitContainerControlMain.Panel1.Controls.Add(this.ucCalendar1);
            this.splitContainerControlMain.Panel1.Text = "Panel1";
            this.splitContainerControlMain.Panel2.Controls.Add(this.layoutControlButtons);
            this.splitContainerControlMain.Panel2.Text = "Panel2";
            this.splitContainerControlMain.Size = new System.Drawing.Size(794, 462);
            this.splitContainerControlMain.SplitterPosition = 405;
            this.splitContainerControlMain.TabIndex = 0;
            // 
            // ucCalendar1
            // 
            this.ucCalendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCalendar1.Location = new System.Drawing.Point(0, 0);
            this.ucCalendar1.Name = "ucCalendar1";
            this.ucCalendar1.Size = new System.Drawing.Size(405, 462);
            this.ucCalendar1.TabIndex = 0;
            // 
            // layoutControlButtons
            // 
            this.layoutControlButtons.Controls.Add(this.simpleButtonUsers);
            this.layoutControlButtons.Controls.Add(this.simpleButtonMaterials);
            this.layoutControlButtons.Controls.Add(this.simpleButtonRecording);
            this.layoutControlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlButtons.Location = new System.Drawing.Point(0, 0);
            this.layoutControlButtons.Name = "layoutControlButtons";
            this.layoutControlButtons.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1072, 297, 725, 350);
            this.layoutControlButtons.Root = this.layoutControlGroup;
            this.layoutControlButtons.Size = new System.Drawing.Size(384, 462);
            this.layoutControlButtons.TabIndex = 0;
            // 
            // simpleButtonMaterials
            // 
            this.simpleButtonMaterials.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButtonMaterials.Appearance.Options.UseFont = true;
            this.simpleButtonMaterials.Location = new System.Drawing.Point(30, 84);
            this.simpleButtonMaterials.MinimumSize = new System.Drawing.Size(0, 50);
            this.simpleButtonMaterials.Name = "simpleButtonMaterials";
            this.simpleButtonMaterials.Size = new System.Drawing.Size(324, 50);
            this.simpleButtonMaterials.StyleController = this.layoutControlButtons;
            this.simpleButtonMaterials.TabIndex = 5;
            this.simpleButtonMaterials.Text = "Материалы";
            this.simpleButtonMaterials.Click += new System.EventHandler(this.simpleButtonMaterials_Click);
            // 
            // simpleButtonRecording
            // 
            this.simpleButtonRecording.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButtonRecording.Appearance.Options.UseFont = true;
            this.simpleButtonRecording.Location = new System.Drawing.Point(30, 12);
            this.simpleButtonRecording.MinimumSize = new System.Drawing.Size(0, 50);
            this.simpleButtonRecording.Name = "simpleButtonRecording";
            this.simpleButtonRecording.Size = new System.Drawing.Size(324, 50);
            this.simpleButtonRecording.StyleController = this.layoutControlButtons;
            this.simpleButtonRecording.TabIndex = 4;
            this.simpleButtonRecording.Text = "Запись";
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemRecording,
            this.layoutControlItemMaterials,
            this.layoutControlItemUsers});
            this.layoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup.Name = "Root";
            this.layoutControlGroup.Size = new System.Drawing.Size(384, 462);
            this.layoutControlGroup.TextVisible = false;
            // 
            // layoutControlItemRecording
            // 
            this.layoutControlItemRecording.Control = this.simpleButtonRecording;
            this.layoutControlItemRecording.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemRecording.Name = "layoutControlItemRecording";
            this.layoutControlItemRecording.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 2, 20);
            this.layoutControlItemRecording.Size = new System.Drawing.Size(364, 72);
            this.layoutControlItemRecording.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemRecording.TextVisible = false;
            // 
            // layoutControlItemMaterials
            // 
            this.layoutControlItemMaterials.Control = this.simpleButtonMaterials;
            this.layoutControlItemMaterials.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItemMaterials.Name = "layoutControlItemMaterials";
            this.layoutControlItemMaterials.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 2, 20);
            this.layoutControlItemMaterials.Size = new System.Drawing.Size(364, 72);
            this.layoutControlItemMaterials.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemMaterials.TextVisible = false;
            // 
            // simpleButtonUsers
            // 
            this.simpleButtonUsers.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButtonUsers.Appearance.Options.UseFont = true;
            this.simpleButtonUsers.Location = new System.Drawing.Point(30, 156);
            this.simpleButtonUsers.MinimumSize = new System.Drawing.Size(0, 50);
            this.simpleButtonUsers.Name = "simpleButtonUsers";
            this.simpleButtonUsers.Size = new System.Drawing.Size(324, 50);
            this.simpleButtonUsers.StyleController = this.layoutControlButtons;
            this.simpleButtonUsers.TabIndex = 6;
            this.simpleButtonUsers.Text = "Клиенты";
            this.simpleButtonUsers.Click += new System.EventHandler(this.simpleButtonUsers_Click);
            // 
            // layoutControlItemUsers
            // 
            this.layoutControlItemUsers.Control = this.simpleButtonUsers;
            this.layoutControlItemUsers.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItemUsers.Name = "layoutControlItemUsers";
            this.layoutControlItemUsers.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 2, 20);
            this.layoutControlItemUsers.Size = new System.Drawing.Size(364, 298);
            this.layoutControlItemUsers.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemUsers.TextVisible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.xtraTabControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LizokasNail";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.xtraTabPageMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlMain)).EndInit();
            this.splitContainerControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlButtons)).EndInit();
            this.layoutControlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemRecording)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItemMenu;
        private DevExpress.XtraBars.BarButtonItem barButtonItemUsers;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRecords;
        private DevExpress.XtraBars.BarButtonItem barButtonItemBase;
        private DevExpress.XtraBars.BarButtonItem barButtonItemColor;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageMain;
        private DevExpress.XtraBars.BarSubItem barSubItemDictionaries;
        private DevExpress.XtraBars.BarButtonItem barButtonItemTop;
        private DevExpress.XtraBars.BarSubItem barSubItemMaterials;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDesign;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCheck;
        private DevExpress.XtraBars.BarButtonItem barButtonItemMaterials;
        private DevExpress.XtraScheduler.UI.WeekDaysEdit weekDaysEdit1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControlMain;
        private UserControls.UCCalendar ucCalendar1;
        private DevExpress.XtraLayout.LayoutControl layoutControlButtons;
        private DevExpress.XtraEditors.SimpleButton simpleButtonMaterials;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRecording;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemRecording;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemMaterials;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRefresh;
        private DevExpress.XtraEditors.SimpleButton simpleButtonUsers;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemUsers;
    }
}

