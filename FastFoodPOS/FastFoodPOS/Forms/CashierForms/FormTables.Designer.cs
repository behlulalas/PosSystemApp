namespace FastFoodPOS.Forms.CashierForms
{
    partial class FormTables
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.TextQuery = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonSearch = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.panel3);
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1010, 520);
            this.guna2Panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.PanelProducts);
            this.panel3.Location = new System.Drawing.Point(13, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(983, 436);
            this.panel3.TabIndex = 9;
            // 
            // PanelProducts
            // 
            this.PanelProducts.AutoSize = true;
            this.PanelProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelProducts.Location = new System.Drawing.Point(0, 0);
            this.PanelProducts.MinimumSize = new System.Drawing.Size(500, 0);
            this.PanelProducts.Name = "PanelProducts";
            this.PanelProducts.Size = new System.Drawing.Size(983, 0);
            this.PanelProducts.TabIndex = 0;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel3.AutoRoundedCorners = true;
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel3.BorderRadius = 19;
            this.guna2Panel3.Controls.Add(this.TextQuery);
            this.guna2Panel3.Controls.Add(this.ButtonSearch);
            this.guna2Panel3.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.guna2Panel3.Location = new System.Drawing.Point(13, 21);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(983, 40);
            this.guna2Panel3.TabIndex = 8;
            // 
            // TextQuery
            // 
            this.TextQuery.Animated = true;
            this.TextQuery.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextQuery.DefaultText = "";
            this.TextQuery.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextQuery.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextQuery.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextQuery.DisabledState.Parent = this.TextQuery;
            this.TextQuery.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextQuery.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextQuery.FocusedState.Parent = this.TextQuery;
            this.TextQuery.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextQuery.HoverState.Parent = this.TextQuery;
            this.TextQuery.Location = new System.Drawing.Point(0, 0);
            this.TextQuery.Margin = new System.Windows.Forms.Padding(0);
            this.TextQuery.Name = "TextQuery";
            this.TextQuery.PasswordChar = '\0';
            this.TextQuery.PlaceholderText = "Masa Ara";
            this.TextQuery.SelectedText = "";
            this.TextQuery.ShadowDecoration.Parent = this.TextQuery;
            this.TextQuery.Size = new System.Drawing.Size(906, 40);
            this.TextQuery.TabIndex = 3;
            this.TextQuery.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextQuery_KeyPress);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.CheckedState.Parent = this.ButtonSearch;
            this.ButtonSearch.CustomImages.Parent = this.ButtonSearch;
            this.ButtonSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.ButtonSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonSearch.ForeColor = System.Drawing.Color.Black;
            this.ButtonSearch.HoverState.Parent = this.ButtonSearch;
            this.ButtonSearch.Location = new System.Drawing.Point(906, 0);
            this.ButtonSearch.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.ShadowDecoration.Parent = this.ButtonSearch;
            this.ButtonSearch.Size = new System.Drawing.Size(77, 40);
            this.ButtonSearch.TabIndex = 4;
            this.ButtonSearch.Text = "Ara";
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // FormTables
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormTables";
            this.Size = new System.Drawing.Size(1010, 520);
            this.guna2Panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2TextBox TextQuery;
        private Guna.UI2.WinForms.Guna2Button ButtonSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel PanelProducts;
    }
}
