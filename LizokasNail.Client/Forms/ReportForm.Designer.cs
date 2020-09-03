namespace LizokasNail.Client.Forms
{
    partial class ReportForm
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
            this.xtraTabPageCosts = new DevExpress.XtraTab.XtraTabPage();
            this.ucMonthReport1 = new LizokasNail.Client.UserControls.UCMonthReport();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.xtraTabControl.SuspendLayout();
            this.xtraTabPageCosts.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControl
            // 
            this.xtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.SelectedTabPage = this.xtraTabPageCosts;
            this.xtraTabControl.Size = new System.Drawing.Size(800, 496);
            this.xtraTabControl.TabIndex = 5;
            this.xtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageCosts});
            // 
            // xtraTabPageCosts
            // 
            this.xtraTabPageCosts.Controls.Add(this.ucMonthReport1);
            this.xtraTabPageCosts.Name = "xtraTabPageCosts";
            this.xtraTabPageCosts.Size = new System.Drawing.Size(794, 468);
            this.xtraTabPageCosts.Text = "Анализ расходов";
            // 
            // ucMonthReport1
            // 
            this.ucMonthReport1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMonthReport1.Location = new System.Drawing.Point(0, 0);
            this.ucMonthReport1.Name = "ucMonthReport1";
            this.ucMonthReport1.Size = new System.Drawing.Size(794, 468);
            this.ucMonthReport1.TabIndex = 0;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.xtraTabControl);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчеты";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.xtraTabPageCosts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageCosts;
        private UserControls.UCMonthReport ucMonthReport1;
    }
}