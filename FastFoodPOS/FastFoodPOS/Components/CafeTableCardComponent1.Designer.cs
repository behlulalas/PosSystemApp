namespace FastFoodPOS.Components
{
    partial class CafeTableCardComponent1
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
            this.ButtonEditOrder = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonAddProduct = new Guna.UI2.WinForms.Guna2Button();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.PictureProductImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.ButtonEditOrder);
            this.guna2Panel1.Controls.Add(this.ButtonAddProduct);
            this.guna2Panel1.Controls.Add(this.LabelPrice);
            this.guna2Panel1.Controls.Add(this.PictureProductImage);
            this.guna2Panel1.Location = new System.Drawing.Point(5, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(265, 145);
            this.guna2Panel1.TabIndex = 0;
            // 
            // ButtonEditOrder
            // 
            this.ButtonEditOrder.Animated = true;
            this.ButtonEditOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.ButtonEditOrder.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonEditOrder.BorderThickness = 1;
            this.ButtonEditOrder.CheckedState.Parent = this.ButtonEditOrder;
            this.ButtonEditOrder.CustomImages.Parent = this.ButtonEditOrder;
            this.ButtonEditOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonEditOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonEditOrder.ForeColor = System.Drawing.Color.White;
            this.ButtonEditOrder.HoverState.Parent = this.ButtonEditOrder;
            this.ButtonEditOrder.Location = new System.Drawing.Point(10, 93);
            this.ButtonEditOrder.Name = "ButtonEditOrder";
            this.ButtonEditOrder.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonEditOrder.ShadowDecoration.Parent = this.ButtonEditOrder;
            this.ButtonEditOrder.Size = new System.Drawing.Size(240, 36);
            this.ButtonEditOrder.TabIndex = 5;
            this.ButtonEditOrder.Text = "Siparişi Düzenle";
            this.ButtonEditOrder.Click += new System.EventHandler(this.ButtonEditOrder_Click);
            // 
            // ButtonAddProduct
            // 
            this.ButtonAddProduct.Animated = true;
            this.ButtonAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.ButtonAddProduct.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAddProduct.BorderThickness = 1;
            this.ButtonAddProduct.CheckedState.Parent = this.ButtonAddProduct;
            this.ButtonAddProduct.CustomImages.Parent = this.ButtonAddProduct;
            this.ButtonAddProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.ButtonAddProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonAddProduct.ForeColor = System.Drawing.Color.Black;
            this.ButtonAddProduct.HoverState.Parent = this.ButtonAddProduct;
            this.ButtonAddProduct.Location = new System.Drawing.Point(10, 93);
            this.ButtonAddProduct.Name = "ButtonAddProduct";
            this.ButtonAddProduct.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonAddProduct.ShadowDecoration.Parent = this.ButtonAddProduct;
            this.ButtonAddProduct.Size = new System.Drawing.Size(240, 36);
            this.ButtonAddProduct.TabIndex = 4;
            this.ButtonAddProduct.Text = "Sipariş Ekle";
            this.ButtonAddProduct.Click += new System.EventHandler(this.ButtonAddProduct_Click);
            this.ButtonAddProduct.DoubleClick += new System.EventHandler(this.ButtonAddProduct_Click);
            // 
            // LabelPrice
            // 
            this.LabelPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LabelPrice.ForeColor = System.Drawing.Color.Black;
            this.LabelPrice.Location = new System.Drawing.Point(86, 41);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(68, 21);
            this.LabelPrice.TabIndex = 2;
            this.LabelPrice.Text = "200.25€";
            // 
            // PictureProductImage
            // 
            this.PictureProductImage.Image = global::FastFoodPOS.Properties.Resources.coffee_table;
            this.PictureProductImage.InitialImage = global::FastFoodPOS.Properties.Resources.product_default;
            this.PictureProductImage.Location = new System.Drawing.Point(10, 10);
            this.PictureProductImage.Name = "PictureProductImage";
            this.PictureProductImage.ShadowDecoration.Parent = this.PictureProductImage;
            this.PictureProductImage.Size = new System.Drawing.Size(70, 70);
            this.PictureProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureProductImage.TabIndex = 1;
            this.PictureProductImage.TabStop = false;
            // 
            // CafeTableCardComponent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CafeTableCardComponent1";
            this.Size = new System.Drawing.Size(275, 150);
            this.Load += new System.EventHandler(this.ProductCardComponent1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox PictureProductImage;
        private System.Windows.Forms.Label LabelPrice;
        private Guna.UI2.WinForms.Guna2Button ButtonAddProduct;
        private Guna.UI2.WinForms.Guna2Button ButtonEditOrder;
    }
}
