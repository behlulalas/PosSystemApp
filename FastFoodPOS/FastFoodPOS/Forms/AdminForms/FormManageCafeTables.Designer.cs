namespace FastFoodPOS.Forms.AdminForms
{
    partial class FormManageCafeTables
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TextSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonAddTable = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masa Yönetimi";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(35, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 398);
            this.panel1.TabIndex = 7;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(735, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(735, 0);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // TextSearch
            // 
            this.TextSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextSearch.Animated = true;
            this.TextSearch.AutoRoundedCorners = true;
            this.TextSearch.BorderRadius = 19;
            this.TextSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextSearch.DefaultText = "";
            this.TextSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextSearch.DisabledState.Parent = this.TextSearch;
            this.TextSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextSearch.FocusedState.Parent = this.TextSearch;
            this.TextSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TextSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextSearch.HoverState.Parent = this.TextSearch;
            this.TextSearch.IconLeft = global::FastFoodPOS.Properties.Resources.search_gray;
            this.TextSearch.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.TextSearch.IconLeftSize = new System.Drawing.Size(15, 15);
            this.TextSearch.Location = new System.Drawing.Point(458, 63);
            this.TextSearch.Margin = new System.Windows.Forms.Padding(0);
            this.TextSearch.Name = "TextSearch";
            this.TextSearch.PasswordChar = '\0';
            this.TextSearch.PlaceholderText = "Masa Ara";
            this.TextSearch.SelectedText = "";
            this.TextSearch.ShadowDecoration.Parent = this.TextSearch;
            this.TextSearch.Size = new System.Drawing.Size(326, 40);
            this.TextSearch.TabIndex = 8;
            this.TextSearch.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // ButtonAddTable
            // 
            this.ButtonAddTable.AutoRoundedCorners = true;
            this.ButtonAddTable.BorderRadius = 19;
            this.ButtonAddTable.CheckedState.Parent = this.ButtonAddTable;
            this.ButtonAddTable.CustomImages.Parent = this.ButtonAddTable;
            this.ButtonAddTable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.ButtonAddTable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonAddTable.ForeColor = System.Drawing.Color.White;
            this.ButtonAddTable.HoverState.Parent = this.ButtonAddTable;
            this.ButtonAddTable.Image = global::FastFoodPOS.Properties.Resources.coffee_table;
            this.ButtonAddTable.ImageOffset = new System.Drawing.Point(-2, 0);
            this.ButtonAddTable.Location = new System.Drawing.Point(25, 63);
            this.ButtonAddTable.Name = "ButtonAddTable";
            this.ButtonAddTable.ShadowDecoration.Parent = this.ButtonAddTable;
            this.ButtonAddTable.Size = new System.Drawing.Size(161, 40);
            this.ButtonAddTable.TabIndex = 9;
            this.ButtonAddTable.Text = "Masa Ekle";
            this.ButtonAddTable.Click += new System.EventHandler(this.ButtonAddProduct_Click);
            // 
            // FormManageCafeTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ButtonAddTable);
            this.Controls.Add(this.TextSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormManageCafeTables";
            this.Size = new System.Drawing.Size(837, 535);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox TextSearch;
        private Guna.UI2.WinForms.Guna2Button ButtonAddTable;
    }
}
