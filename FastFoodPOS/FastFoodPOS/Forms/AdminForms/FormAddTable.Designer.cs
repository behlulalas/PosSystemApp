namespace FastFoodPOS.Forms.AdminForms
{
    partial class FormAddTable
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.LabelName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonReset = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonSave = new Guna.UI2.WinForms.Guna2Button();
            this.ToggleAvailability = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextName = new Guna.UI2.WinForms.Guna2TextBox();
            this.OpenFileDialogChangeImage = new System.Windows.Forms.OpenFileDialog();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.LinkBack = new System.Windows.Forms.LinkLabel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "Yeni Masa Ekle";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.LabelName);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.TextCode);
            this.guna2Panel1.Controls.Add(this.ButtonReset);
            this.guna2Panel1.Controls.Add(this.ButtonSave);
            this.guna2Panel1.Controls.Add(this.ToggleAvailability);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.TextName);
            this.guna2Panel1.Location = new System.Drawing.Point(35, 85);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(435, 299);
            this.guna2Panel1.TabIndex = 0;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.ForeColor = System.Drawing.Color.Red;
            this.LabelName.Location = new System.Drawing.Point(11, 37);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(38, 13);
            this.LabelName.TabIndex = 9;
            this.LabelName.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Masa Kodu";
            // 
            // TextCode
            // 
            this.TextCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextCode.Animated = true;
            this.TextCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextCode.DefaultText = "";
            this.TextCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextCode.DisabledState.Parent = this.TextCode;
            this.TextCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextCode.FocusedState.Parent = this.TextCode;
            this.TextCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextCode.HoverState.Parent = this.TextCode;
            this.TextCode.Location = new System.Drawing.Point(14, 127);
            this.TextCode.Name = "TextCode";
            this.TextCode.PasswordChar = '\0';
            this.TextCode.PlaceholderText = "(e.g. 001)";
            this.TextCode.SelectedText = "";
            this.TextCode.ShadowDecoration.Parent = this.TextCode;
            this.TextCode.Size = new System.Drawing.Size(384, 36);
            this.TextCode.TabIndex = 2;
            // 
            // ButtonReset
            // 
            this.ButtonReset.Animated = true;
            this.ButtonReset.BorderColor = System.Drawing.Color.LightGray;
            this.ButtonReset.BorderThickness = 1;
            this.ButtonReset.CheckedState.Parent = this.ButtonReset;
            this.ButtonReset.CustomImages.Parent = this.ButtonReset;
            this.ButtonReset.FillColor = System.Drawing.Color.White;
            this.ButtonReset.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ButtonReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonReset.HoverState.Parent = this.ButtonReset;
            this.ButtonReset.Location = new System.Drawing.Point(14, 238);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.ShadowDecoration.Parent = this.ButtonReset;
            this.ButtonReset.Size = new System.Drawing.Size(180, 45);
            this.ButtonReset.TabIndex = 5;
            this.ButtonReset.Text = "Sıfırla";
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Animated = true;
            this.ButtonSave.CheckedState.Parent = this.ButtonSave;
            this.ButtonSave.CustomImages.Parent = this.ButtonSave;
            this.ButtonSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.ButtonSave.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ButtonSave.ForeColor = System.Drawing.Color.White;
            this.ButtonSave.HoverState.Parent = this.ButtonSave;
            this.ButtonSave.Location = new System.Drawing.Point(218, 238);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.ShadowDecoration.Parent = this.ButtonSave;
            this.ButtonSave.Size = new System.Drawing.Size(180, 45);
            this.ButtonSave.TabIndex = 4;
            this.ButtonSave.Text = "Kaydet";
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ToggleAvailability
            // 
            this.ToggleAvailability.Animated = true;
            this.ToggleAvailability.Checked = true;
            this.ToggleAvailability.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ToggleAvailability.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ToggleAvailability.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleAvailability.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ToggleAvailability.CheckedState.Parent = this.ToggleAvailability;
            this.ToggleAvailability.Location = new System.Drawing.Point(130, 169);
            this.ToggleAvailability.Name = "ToggleAvailability";
            this.ToggleAvailability.ShadowDecoration.Parent = this.ToggleAvailability;
            this.ToggleAvailability.Size = new System.Drawing.Size(35, 20);
            this.ToggleAvailability.TabIndex = 3;
            this.ToggleAvailability.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleAvailability.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleAvailability.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleAvailability.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.ToggleAvailability.UncheckedState.Parent = this.ToggleAvailability;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Müsait Mi ?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Masa Adı";
            // 
            // TextName
            // 
            this.TextName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextName.Animated = true;
            this.TextName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextName.DefaultText = "";
            this.TextName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextName.DisabledState.Parent = this.TextName;
            this.TextName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextName.FocusedState.Parent = this.TextName;
            this.TextName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextName.HoverState.Parent = this.TextName;
            this.TextName.Location = new System.Drawing.Point(14, 52);
            this.TextName.Name = "TextName";
            this.TextName.PasswordChar = '\0';
            this.TextName.PlaceholderText = "(e.g. Masa-001)";
            this.TextName.SelectedText = "";
            this.TextName.ShadowDecoration.Parent = this.TextName;
            this.TextName.Size = new System.Drawing.Size(384, 36);
            this.TextName.TabIndex = 1;
            // 
            // OpenFileDialogChangeImage
            // 
            this.OpenFileDialogChangeImage.Filter = "Image Files|*.jpg;*.png;*.jpeg";
            this.OpenFileDialogChangeImage.RestoreDirectory = true;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(220, 30);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 30);
            this.guna2VSeparator1.TabIndex = 4;
            // 
            // LinkBack
            // 
            this.LinkBack.AutoSize = true;
            this.LinkBack.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkBack.Location = new System.Drawing.Point(246, 30);
            this.LinkBack.Name = "LinkBack";
            this.LinkBack.Size = new System.Drawing.Size(99, 30);
            this.LinkBack.TabIndex = 53;
            this.LinkBack.TabStop = true;
            this.LinkBack.Text = "Geri Dön";
            this.LinkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkBack_LinkClicked);
            // 
            // FormAddTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LinkBack);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormAddTable";
            this.Size = new System.Drawing.Size(492, 413);
            this.Load += new System.EventHandler(this.FormAddProduct_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ToggleAvailability;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox TextName;
        private Guna.UI2.WinForms.Guna2Button ButtonSave;
        private Guna.UI2.WinForms.Guna2Button ButtonReset;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogChangeImage;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.LinkLabel LinkBack;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TextCode;
        private System.Windows.Forms.Label LabelName;
    }
}
