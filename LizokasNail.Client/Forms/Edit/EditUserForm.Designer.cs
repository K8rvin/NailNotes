namespace LizokasNail.Client.Forms.Edit
{
    partial class EditUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUserForm));
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEditPhone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.imageComboBoxEditCommunication = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.imageCollectionCommunicationTypes = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEditCommunication.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionCommunicationTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(212, 123);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(293, 123);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textEditName
            // 
            this.textEditName.Location = new System.Drawing.Point(103, 12);
            this.textEditName.Name = "textEditName";
            this.textEditName.Size = new System.Drawing.Size(265, 20);
            this.textEditName.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(19, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Имя";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Телефон";
            // 
            // textEditPhone
            // 
            this.textEditPhone.Location = new System.Drawing.Point(103, 38);
            this.textEditPhone.Name = "textEditPhone";
            this.textEditPhone.Size = new System.Drawing.Size(265, 20);
            this.textEditPhone.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 67);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Связь";
            // 
            // imageComboBoxEditCommunication
            // 
            this.imageComboBoxEditCommunication.Location = new System.Drawing.Point(103, 64);
            this.imageComboBoxEditCommunication.Name = "imageComboBoxEditCommunication";
            this.imageComboBoxEditCommunication.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imageComboBoxEditCommunication.Properties.DropDownRows = 8;
            this.imageComboBoxEditCommunication.Properties.LargeImages = this.imageCollectionCommunicationTypes;
            this.imageComboBoxEditCommunication.Size = new System.Drawing.Size(265, 20);
            this.imageComboBoxEditCommunication.TabIndex = 8;
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
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 156);
            this.Controls.Add(this.imageComboBoxEditCommunication);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textEditPhone);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEditName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Name = "EditUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEditCommunication.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionCommunicationTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditPhone;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ImageComboBoxEdit imageComboBoxEditCommunication;
        private DevExpress.Utils.ImageCollection imageCollectionCommunicationTypes;
    }
}