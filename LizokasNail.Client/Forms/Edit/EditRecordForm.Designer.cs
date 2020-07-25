namespace LizokasNail.Client.Forms.Edit
{
    partial class EditRecordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRecordForm));
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.imageCollectionCommunicationTypes = new DevExpress.Utils.ImageCollection(this.components);
            this.searchLookUpEditUser = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dateEdit = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionCommunicationTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(212, 123);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(293, 123);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Клиент";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Дата";
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
            // searchLookUpEditUser
            // 
            this.searchLookUpEditUser.Location = new System.Drawing.Point(103, 12);
            this.searchLookUpEditUser.Name = "searchLookUpEditUser";
            this.searchLookUpEditUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEditUser.Properties.View = this.searchLookUpEdit1View;
            this.searchLookUpEditUser.Size = new System.Drawing.Size(265, 20);
            this.searchLookUpEditUser.TabIndex = 1;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // dateEdit
            // 
            this.dateEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateEdit.EditValue = null;
            this.dateEdit.Location = new System.Drawing.Point(103, 38);
            this.dateEdit.Name = "dateEdit";
            this.dateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.CalendarTimeProperties.Mask.EditMask = "t";
            this.dateEdit.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = true;
            this.dateEdit.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.dateEdit.Properties.DisplayFormat.FormatString = "";
            this.dateEdit.Properties.EditFormat.FormatString = "";
            this.dateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit.Properties.Mask.EditMask = "g";
            this.dateEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateEdit.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEdit.Size = new System.Drawing.Size(265, 20);
            this.dateEdit.TabIndex = 2;
            // 
            // EditRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 156);
            this.Controls.Add(this.searchLookUpEditUser);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dateEdit);
            this.Name = "EditRecordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionCommunicationTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.Utils.ImageCollection imageCollectionCommunicationTypes;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEditUser;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.DateEdit dateEdit;
    }
}