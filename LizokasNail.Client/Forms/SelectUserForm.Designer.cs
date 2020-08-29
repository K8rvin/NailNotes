namespace LizokasNail.Client.Forms
{
    partial class SelectUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectUserForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButtonOldUser = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonNewUser = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.imageCollectionCommunicationTypes = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionCommunicationTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButtonOldUser);
            this.layoutControl1.Controls.Add(this.simpleButtonNewUser);
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(646, 115, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(305, 92);
            this.layoutControl1.TabIndex = 100;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButtonOldUser
            // 
            this.simpleButtonOldUser.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonOldUser.Location = new System.Drawing.Point(154, 58);
            this.simpleButtonOldUser.Name = "simpleButtonOldUser";
            this.simpleButtonOldUser.Size = new System.Drawing.Size(139, 22);
            this.simpleButtonOldUser.StyleController = this.layoutControl1;
            this.simpleButtonOldUser.TabIndex = 99;
            this.simpleButtonOldUser.Text = "Старый";
            this.simpleButtonOldUser.Click += new System.EventHandler(this.simpleButtonOldUser_Click);
            // 
            // simpleButtonNewUser
            // 
            this.simpleButtonNewUser.Location = new System.Drawing.Point(12, 58);
            this.simpleButtonNewUser.Name = "simpleButtonNewUser";
            this.simpleButtonNewUser.Size = new System.Drawing.Size(138, 22);
            this.simpleButtonNewUser.StyleController = this.layoutControl1;
            this.simpleButtonNewUser.TabIndex = 98;
            this.simpleButtonNewUser.Text = "Новый";
            this.simpleButtonNewUser.Click += new System.EventHandler(this.simpleButtonNewUser_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.ShowToolTips = false;
            this.labelControl1.Size = new System.Drawing.Size(281, 24);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Клиент";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(305, 92);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.labelControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(285, 28);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.simpleButtonNewUser;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 46);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(142, 26);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.simpleButtonOldUser;
            this.layoutControlItem10.Location = new System.Drawing.Point(142, 46);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(143, 26);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 28);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(285, 18);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // imageCollectionCommunicationTypes
            // 
            this.imageCollectionCommunicationTypes.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollectionCommunicationTypes.ImageStream")));
            this.imageCollectionCommunicationTypes.InsertGalleryImage("mobilephone_16x16.png", "devav/contacts/mobilephone_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/contacts/mobilephone_16x16.png"), 0);
            this.imageCollectionCommunicationTypes.Images.SetKeyName(0, "mobilephone_16x16.png");
            this.imageCollectionCommunicationTypes.Images.SetKeyName(1, "icons8-whatsapp-48.png");
            this.imageCollectionCommunicationTypes.Images.SetKeyName(2, "icons8-viber-48.png");
            this.imageCollectionCommunicationTypes.Images.SetKeyName(3, "instagram.png");
            this.imageCollectionCommunicationTypes.Images.SetKeyName(4, "icons8-телеграмма-app-48.png");
            this.imageCollectionCommunicationTypes.Images.SetKeyName(5, "vk.png");
            this.imageCollectionCommunicationTypes.Images.SetKeyName(6, "210908_logo.png");
            this.imageCollectionCommunicationTypes.InsertGalleryImage("question_16x16.png", "images/support/question_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/support/question_16x16.png"), 7);
            this.imageCollectionCommunicationTypes.Images.SetKeyName(7, "question_16x16.png");
            // 
            // SelectUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 92);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиент новый/старый?";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionCommunicationTypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Utils.ImageCollection imageCollectionCommunicationTypes;
        private DevExpress.XtraEditors.SimpleButton simpleButtonNewUser;
        private DevExpress.XtraEditors.SimpleButton simpleButtonOldUser;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}