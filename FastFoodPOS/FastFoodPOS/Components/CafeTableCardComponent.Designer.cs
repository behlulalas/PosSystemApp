namespace FastFoodPOS.Components
{
    partial class CafeTableCardComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ButtonSetAvailability = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelTableName = new System.Windows.Forms.Label();
            this.PictureProductImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.ButtonSetAvailability);
            this.guna2Panel1.Controls.Add(this.ButtonUpdate);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(247, 287);
            this.guna2Panel1.TabIndex = 0;
            // 
            // ButtonSetAvailability
            // 
            this.ButtonSetAvailability.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSetAvailability.BorderColor = System.Drawing.Color.LightGray;
            this.ButtonSetAvailability.BorderThickness = 1;
            this.ButtonSetAvailability.CheckedState.Parent = this.ButtonSetAvailability;
            this.ButtonSetAvailability.CustomImages.Parent = this.ButtonSetAvailability;
            this.ButtonSetAvailability.FillColor = System.Drawing.Color.Gray;
            this.ButtonSetAvailability.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonSetAvailability.ForeColor = System.Drawing.Color.White;
            this.ButtonSetAvailability.HoverState.Parent = this.ButtonSetAvailability;
            this.ButtonSetAvailability.Location = new System.Drawing.Point(21, 231);
            this.ButtonSetAvailability.Name = "ButtonSetAvailability";
            this.ButtonSetAvailability.ShadowDecoration.Parent = this.ButtonSetAvailability;
            this.ButtonSetAvailability.Size = new System.Drawing.Size(204, 37);
            this.ButtonSetAvailability.TabIndex = 1;
            this.ButtonSetAvailability.Text = "Stokta:Mevcut";
            this.ButtonSetAvailability.Click += new System.EventHandler(this.ButtonSetAvailability_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.BorderColor = System.Drawing.Color.LightGray;
            this.ButtonUpdate.BorderThickness = 1;
            this.ButtonUpdate.CheckedState.Parent = this.ButtonUpdate;
            this.ButtonUpdate.CustomImages.Parent = this.ButtonUpdate;
            this.ButtonUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ButtonUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonUpdate.ForeColor = System.Drawing.Color.Black;
            this.ButtonUpdate.HoverState.Parent = this.ButtonUpdate;
            this.ButtonUpdate.Location = new System.Drawing.Point(21, 181);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.ShadowDecoration.Parent = this.ButtonUpdate;
            this.ButtonUpdate.Size = new System.Drawing.Size(205, 37);
            this.ButtonUpdate.TabIndex = 1;
            this.ButtonUpdate.Text = "Güncelle";
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.LabelTableName);
            this.panel1.Controls.Add(this.PictureProductImage);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 174);
            this.panel1.TabIndex = 0;
            // 
            // LabelTableName
            // 
            this.LabelTableName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTableName.AutoSize = true;
            this.LabelTableName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTableName.Location = new System.Drawing.Point(81, 133);
            this.LabelTableName.Name = "LabelTableName";
            this.LabelTableName.Size = new System.Drawing.Size(68, 21);
            this.LabelTableName.TabIndex = 1;
            this.LabelTableName.Text = "500.00€";
            this.LabelTableName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PictureProductImage
            // 
            this.PictureProductImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureProductImage.Image = global::FastFoodPOS.Properties.Resources.coffee_table;
            this.PictureProductImage.Location = new System.Drawing.Point(22, 13);
            this.PictureProductImage.Name = "PictureProductImage";
            this.PictureProductImage.ShadowDecoration.Parent = this.PictureProductImage;
            this.PictureProductImage.Size = new System.Drawing.Size(203, 100);
            this.PictureProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureProductImage.TabIndex = 0;
            this.PictureProductImage.TabStop = false;
            // 
            // CafeTableCardComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CafeTableCardComponent";
            this.Size = new System.Drawing.Size(247, 287);
            this.guna2Panel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox PictureProductImage;
        private Guna.UI2.WinForms.Guna2Button ButtonUpdate;
        private System.Windows.Forms.Label LabelTableName;
        private Guna.UI2.WinForms.Guna2Button ButtonSetAvailability;
    }
}
