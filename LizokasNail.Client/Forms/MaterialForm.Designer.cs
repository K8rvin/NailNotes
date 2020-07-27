namespace LizokasNail.Client.Forms
{
    partial class MaterialForm
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
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageBase = new DevExpress.XtraTab.XtraTabPage();
            this.ucBase1 = new LizokasNail.Client.UserControls.UCBase();
            this.xtraTabPageColor = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageTop = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageDesign = new DevExpress.XtraTab.XtraTabPage();
            this.ucColor1 = new LizokasNail.Client.UserControls.UCColor();
            this.ucTop1 = new LizokasNail.Client.UserControls.UCTop();
            this.ucDesign1 = new LizokasNail.Client.UserControls.UCDesign();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.xtraTabControl.SuspendLayout();
            this.xtraTabPageBase.SuspendLayout();
            this.xtraTabPageColor.SuspendLayout();
            this.xtraTabPageTop.SuspendLayout();
            this.xtraTabPageDesign.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControl
            // 
            this.xtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.SelectedTabPage = this.xtraTabPageBase;
            this.xtraTabControl.Size = new System.Drawing.Size(800, 450);
            this.xtraTabControl.TabIndex = 5;
            this.xtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageBase,
            this.xtraTabPageColor,
            this.xtraTabPageTop,
            this.xtraTabPageDesign});
            // 
            // xtraTabPageBase
            // 
            this.xtraTabPageBase.Controls.Add(this.ucBase1);
            this.xtraTabPageBase.Name = "xtraTabPageBase";
            this.xtraTabPageBase.Size = new System.Drawing.Size(794, 422);
            this.xtraTabPageBase.Text = "Базы";
            // 
            // ucBase1
            // 
            this.ucBase1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBase1.Location = new System.Drawing.Point(0, 0);
            this.ucBase1.Name = "ucBase1";
            this.ucBase1.Size = new System.Drawing.Size(794, 422);
            this.ucBase1.TabIndex = 0;
            // 
            // xtraTabPageColor
            // 
            this.xtraTabPageColor.Controls.Add(this.ucColor1);
            this.xtraTabPageColor.Name = "xtraTabPageColor";
            this.xtraTabPageColor.Size = new System.Drawing.Size(794, 422);
            this.xtraTabPageColor.Text = "Цвета";
            // 
            // xtraTabPageTop
            // 
            this.xtraTabPageTop.Controls.Add(this.ucTop1);
            this.xtraTabPageTop.Name = "xtraTabPageTop";
            this.xtraTabPageTop.Size = new System.Drawing.Size(794, 422);
            this.xtraTabPageTop.Text = "Топы";
            // 
            // xtraTabPageDesign
            // 
            this.xtraTabPageDesign.Controls.Add(this.ucDesign1);
            this.xtraTabPageDesign.Name = "xtraTabPageDesign";
            this.xtraTabPageDesign.Size = new System.Drawing.Size(794, 422);
            this.xtraTabPageDesign.Text = "Дизайны";
            // 
            // ucColor1
            // 
            this.ucColor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucColor1.Location = new System.Drawing.Point(0, 0);
            this.ucColor1.Name = "ucColor1";
            this.ucColor1.Size = new System.Drawing.Size(794, 422);
            this.ucColor1.TabIndex = 0;
            // 
            // ucTop1
            // 
            this.ucTop1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTop1.Location = new System.Drawing.Point(0, 0);
            this.ucTop1.Name = "ucTop1";
            this.ucTop1.Size = new System.Drawing.Size(794, 422);
            this.ucTop1.TabIndex = 0;
            // 
            // ucDesign1
            // 
            this.ucDesign1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDesign1.Location = new System.Drawing.Point(0, 0);
            this.ucDesign1.Name = "ucDesign1";
            this.ucDesign1.Size = new System.Drawing.Size(794, 422);
            this.ucDesign1.TabIndex = 0;
            // 
            // MaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.xtraTabControl);
            this.Name = "MaterialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Материалы";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.xtraTabPageBase.ResumeLayout(false);
            this.xtraTabPageColor.ResumeLayout(false);
            this.xtraTabPageTop.ResumeLayout(false);
            this.xtraTabPageDesign.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageBase;
        private UserControls.UCBase ucBase1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageColor;
        private UserControls.UCColor ucColor1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageTop;
        private UserControls.UCTop ucTop1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageDesign;
        private UserControls.UCDesign ucDesign1;
    }
}