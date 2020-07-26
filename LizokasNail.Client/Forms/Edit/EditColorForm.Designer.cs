namespace LizokasNail.Client.Forms.Edit
{
    partial class EditColorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBaseForm));
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.imageCollectionCommunicationTypes = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionCommunicationTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(212, 123);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Tag = "5";
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
            this.buttonCancel.Tag = "6";
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textEditName
            // 
            this.textEditName.Location = new System.Drawing.Point(103, 12);
            this.textEditName.Name = "textEditName";
            this.textEditName.Size = new System.Drawing.Size(265, 20);
            this.textEditName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Название";
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
            // EditBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 156);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEditName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Name = "EditBaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionCommunicationTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Utils.ImageCollection imageCollectionCommunicationTypes;
    }
}