namespace Update
{
    partial class FrmGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGuncelle));
            this.btnIndir = new DevExpress.XtraEditors.SimpleButton();
            this.progressUpdate = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblIndirilen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.progressUpdate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIndir
            // 
            this.btnIndir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIndir.ImageOptions.Image")));
            this.btnIndir.Location = new System.Drawing.Point(185, 38);
            this.btnIndir.Name = "btnIndir";
            this.btnIndir.Size = new System.Drawing.Size(176, 145);
            this.btnIndir.TabIndex = 0;
            this.btnIndir.Text = "Güncellemeyi indir";
            this.btnIndir.Click += new System.EventHandler(this.btnIndir_Click);
            // 
            // progressUpdate
            // 
            this.progressUpdate.Location = new System.Drawing.Point(12, 221);
            this.progressUpdate.Name = "progressUpdate";
            this.progressUpdate.Size = new System.Drawing.Size(530, 44);
            this.progressUpdate.TabIndex = 1;
            // 
            // lblIndirilen
            // 
            this.lblIndirilen.AutoSize = true;
            this.lblIndirilen.Location = new System.Drawing.Point(12, 268);
            this.lblIndirilen.Name = "lblIndirilen";
            this.lblIndirilen.Size = new System.Drawing.Size(0, 13);
            this.lblIndirilen.TabIndex = 2;
            // 
            // FrmGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 343);
            this.Controls.Add(this.lblIndirilen);
            this.Controls.Add(this.progressUpdate);
            this.Controls.Add(this.btnIndir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güncelleme İndir";
            ((System.ComponentModel.ISupportInitialize)(this.progressUpdate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnIndir;
        private DevExpress.XtraEditors.ProgressBarControl progressUpdate;
        private System.Windows.Forms.Label lblIndirilen;
    }
}

