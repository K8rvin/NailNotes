﻿namespace LizokasNail.Client
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
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItemMenu = new DevExpress.XtraBars.BarSubItem();
            this.barSubItemDictionaries = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemUsers = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRecords = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemMaterials = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemBase = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemColor = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemTop = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDesign = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageMain = new DevExpress.XtraTab.XtraTabPage();
            this.barButtonItemCheck = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.xtraTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3,
            this.bar1});
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
            this.barButtonItemCheck});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 11;
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
            this.barSubItemMenu.Caption = "Меню";
            this.barSubItemMenu.Id = 1;
            this.barSubItemMenu.Name = "barSubItemMenu";
            // 
            // barSubItemDictionaries
            // 
            this.barSubItemDictionaries.Caption = "Справочники";
            this.barSubItemDictionaries.Id = 7;
            this.barSubItemDictionaries.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemUsers),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemRecords),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemMaterials),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemCheck)});
            this.barSubItemDictionaries.Name = "barSubItemDictionaries";
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
            // barSubItemMaterials
            // 
            this.barSubItemMaterials.Caption = "Материалы";
            this.barSubItemMaterials.Id = 8;
            this.barSubItemMaterials.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemBase),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemColor),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemTop),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDesign)});
            this.barSubItemMaterials.Name = "barSubItemMaterials";
            // 
            // barButtonItemBase
            // 
            this.barButtonItemBase.Caption = "Базы";
            this.barButtonItemBase.Id = 4;
            this.barButtonItemBase.Name = "barButtonItemBase";
            this.barButtonItemBase.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemBase_ItemClick);
            // 
            // barButtonItemColor
            // 
            this.barButtonItemColor.Caption = "Цвета";
            this.barButtonItemColor.Id = 5;
            this.barButtonItemColor.Name = "barButtonItemColor";
            this.barButtonItemColor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemColor_ItemClick);
            // 
            // barButtonItemTop
            // 
            this.barButtonItemTop.Caption = "Топы";
            this.barButtonItemTop.Id = 6;
            this.barButtonItemTop.Name = "barButtonItemTop";
            this.barButtonItemTop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemTop_ItemClick);
            // 
            // barButtonItemDesign
            // 
            this.barButtonItemDesign.Caption = "Дизайны";
            this.barButtonItemDesign.Id = 9;
            this.barButtonItemDesign.Name = "barButtonItemDesign";
            this.barButtonItemDesign.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDesign_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DisableClose = true;
            this.bar3.OptionsBar.DisableCustomization = true;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.RotateWhenVertical = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.MinHeight = 50;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(800, 72);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 514);
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 72);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 442);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 72);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 442);
            // 
            // xtraTabControl
            // 
            this.xtraTabControl.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl.Location = new System.Drawing.Point(0, 72);
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.SelectedTabPage = this.xtraTabPageMain;
            this.xtraTabControl.Size = new System.Drawing.Size(800, 442);
            this.xtraTabControl.TabIndex = 4;
            this.xtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageMain});
            this.xtraTabControl.CloseButtonClick += new System.EventHandler(this.xtraTabControl_CloseButtonClick);
            // 
            // xtraTabPageMain
            // 
            this.xtraTabPageMain.Name = "xtraTabPageMain";
            this.xtraTabPageMain.Size = new System.Drawing.Size(794, 414);
            this.xtraTabPageMain.Text = "Информация";
            // 
            // barButtonItemCheck
            // 
            this.barButtonItemCheck.Caption = "Расчеты";
            this.barButtonItemCheck.Id = 10;
            this.barButtonItemCheck.Name = "barButtonItemCheck";
            this.barButtonItemCheck.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCheck_ItemClick);
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
            this.Name = "MainForm";
            this.Text = "Главная форма";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
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
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageMain;
        private DevExpress.XtraBars.BarSubItem barSubItemDictionaries;
        private DevExpress.XtraBars.BarButtonItem barButtonItemTop;
        private DevExpress.XtraBars.BarSubItem barSubItemMaterials;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDesign;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCheck;
    }
}

