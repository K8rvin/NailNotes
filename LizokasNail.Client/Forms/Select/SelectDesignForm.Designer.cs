namespace LizokasNail.Client.Forms.Edit
{
    partial class SelectDesignForm
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.searchLookUpEditDesign = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridViewBase = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnComment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridColumnPriceVip = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditDesign.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 13);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Название";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.numericUpDownCount);
            this.layoutControl1.Controls.Add(this.searchLookUpEditDesign);
            this.layoutControl1.Controls.Add(this.simpleButtonCancel);
            this.layoutControl1.Controls.Add(this.simpleButtonAdd);
            this.layoutControl1.Controls.Add(this.labelControl2);
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(657, 108, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(380, 115);
            this.layoutControl1.TabIndex = 100;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Location = new System.Drawing.Point(85, 36);
            this.numericUpDownCount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(283, 20);
            this.numericUpDownCount.TabIndex = 2;
            // 
            // searchLookUpEditDesign
            // 
            this.searchLookUpEditDesign.Location = new System.Drawing.Point(85, 12);
            this.searchLookUpEditDesign.Name = "searchLookUpEditDesign";
            this.searchLookUpEditDesign.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEditDesign.Properties.View = this.gridViewBase;
            this.searchLookUpEditDesign.Size = new System.Drawing.Size(283, 20);
            this.searchLookUpEditDesign.StyleController = this.layoutControl1;
            this.searchLookUpEditDesign.TabIndex = 1;
            this.searchLookUpEditDesign.EditValueChanged += new System.EventHandler(this.searchLookUpEditDesign_EditValueChanged);
            // 
            // gridViewBase
            // 
            this.gridViewBase.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnName,
            this.gridColumnComment,
            this.gridColumnPrice,
            this.gridColumnPriceVip});
            this.gridViewBase.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewBase.Name = "gridViewBase";
            this.gridViewBase.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewBase.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnName
            // 
            this.gridColumnName.Caption = "Марка";
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 0;
            // 
            // gridColumnComment
            // 
            this.gridColumnComment.Caption = "Примечание";
            this.gridColumnComment.FieldName = "Comment";
            this.gridColumnComment.Name = "gridColumnComment";
            this.gridColumnComment.Visible = true;
            this.gridColumnComment.VisibleIndex = 1;
            // 
            // gridColumnPrice
            // 
            this.gridColumnPrice.Caption = "Цена";
            this.gridColumnPrice.FieldName = "Price";
            this.gridColumnPrice.Name = "gridColumnPrice";
            this.gridColumnPrice.Visible = true;
            this.gridColumnPrice.VisibleIndex = 2;
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonCancel.Location = new System.Drawing.Point(193, 81);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(175, 22);
            this.simpleButtonCancel.StyleController = this.layoutControl1;
            this.simpleButtonCancel.TabIndex = 99;
            this.simpleButtonCancel.Text = "Отмена";
            // 
            // simpleButtonAdd
            // 
            this.simpleButtonAdd.Location = new System.Drawing.Point(12, 81);
            this.simpleButtonAdd.Name = "simpleButtonAdd";
            this.simpleButtonAdd.Size = new System.Drawing.Size(177, 22);
            this.simpleButtonAdd.StyleController = this.layoutControl1;
            this.simpleButtonAdd.TabIndex = 98;
            this.simpleButtonAdd.Text = "Добавить";
            this.simpleButtonAdd.Click += new System.EventHandler(this.simpleButtonAdd_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(12, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 13);
            this.labelControl2.StyleController = this.layoutControl1;
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Кол-во";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem1,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(380, 115);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.labelControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(73, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.searchLookUpEditDesign;
            this.layoutControlItem2.Location = new System.Drawing.Point(73, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(287, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.labelControl2;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(73, 24);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButtonAdd;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 69);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(181, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.simpleButtonCancel;
            this.layoutControlItem6.Location = new System.Drawing.Point(181, 69);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(179, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 48);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(360, 21);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.numericUpDownCount;
            this.layoutControlItem4.Location = new System.Drawing.Point(73, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(287, 24);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // gridColumnPriceVip
            // 
            this.gridColumnPriceVip.Caption = "Цена (vip)";
            this.gridColumnPriceVip.FieldName = "PriceVip";
            this.gridColumnPriceVip.Name = "gridColumnPriceVip";
            this.gridColumnPriceVip.Visible = true;
            this.gridColumnPriceVip.VisibleIndex = 3;
            // 
            // SelectDesignForm
            // 
            this.AcceptButton = this.simpleButtonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.simpleButtonCancel;
            this.ClientSize = new System.Drawing.Size(380, 115);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectDesignForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление дизайна";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditDesign.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAdd;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEditDesign;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBase;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnComment;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPriceVip;
    }
}