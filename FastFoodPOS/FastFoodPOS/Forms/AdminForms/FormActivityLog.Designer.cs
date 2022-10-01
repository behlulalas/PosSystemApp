namespace FastFoodPOS.Forms.AdminForms
{
    partial class FormActivityLog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.DataGridViewLogs = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cashier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTimeSpecifier = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etkinlik Günlükleri";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.DataGridViewLogs);
            this.guna2Panel1.Location = new System.Drawing.Point(40, 71);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(778, 387);
            this.guna2Panel1.TabIndex = 7;
            // 
            // DataGridViewLogs
            // 
            this.DataGridViewLogs.AllowUserToAddRows = false;
            this.DataGridViewLogs.AllowUserToDeleteRows = false;
            this.DataGridViewLogs.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.DataGridViewLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewLogs.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewLogs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewLogs.ColumnHeadersHeight = 40;
            this.DataGridViewLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Cashier,
            this.Total});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewLogs.DefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridViewLogs.EnableHeadersVisualStyles = false;
            this.DataGridViewLogs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DataGridViewLogs.Location = new System.Drawing.Point(1, 1);
            this.DataGridViewLogs.MultiSelect = false;
            this.DataGridViewLogs.Name = "DataGridViewLogs";
            this.DataGridViewLogs.ReadOnly = true;
            this.DataGridViewLogs.RowHeadersVisible = false;
            this.DataGridViewLogs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(4, 4, 0, 4);
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewLogs.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridViewLogs.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridViewLogs.RowTemplate.Height = 40;
            this.DataGridViewLogs.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewLogs.Size = new System.Drawing.Size(776, 385);
            this.DataGridViewLogs.TabIndex = 5;
            this.DataGridViewLogs.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid;
            this.DataGridViewLogs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewLogs.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewLogs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewLogs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewLogs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewLogs.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewLogs.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DataGridViewLogs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewLogs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGridViewLogs.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewLogs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewLogs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewLogs.ThemeStyle.HeaderStyle.Height = 40;
            this.DataGridViewLogs.ThemeStyle.ReadOnly = true;
            this.DataGridViewLogs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewLogs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewLogs.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewLogs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewLogs.ThemeStyle.RowsStyle.Height = 40;
            this.DataGridViewLogs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DataGridViewLogs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Date
            // 
            this.Date.HeaderText = "Tarih";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Cashier
            // 
            this.Cashier.HeaderText = "İsim";
            this.Cashier.Name = "Cashier";
            this.Cashier.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Etkinlik";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // DateTimeSpecifier
            // 
            this.DateTimeSpecifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DateTimeSpecifier.AutoRoundedCorners = true;
            this.DateTimeSpecifier.BorderRadius = 17;
            this.DateTimeSpecifier.CheckedState.Parent = this.DateTimeSpecifier;
            this.DateTimeSpecifier.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.DateTimeSpecifier.ForeColor = System.Drawing.Color.Black;
            this.DateTimeSpecifier.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimeSpecifier.HoverState.Parent = this.DateTimeSpecifier;
            this.DateTimeSpecifier.Location = new System.Drawing.Point(145, 474);
            this.DateTimeSpecifier.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimeSpecifier.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimeSpecifier.Name = "DateTimeSpecifier";
            this.DateTimeSpecifier.ShadowDecoration.Parent = this.DateTimeSpecifier;
            this.DateTimeSpecifier.Size = new System.Drawing.Size(178, 36);
            this.DateTimeSpecifier.TabIndex = 9;
            this.DateTimeSpecifier.Value = new System.DateTime(2021, 5, 14, 8, 41, 33, 985);
            this.DateTimeSpecifier.ValueChanged += new System.EventHandler(this.DateTimeSpecifier_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(40, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tarih Belirtin:";
            // 
            // FormActivityLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DateTimeSpecifier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormActivityLog";
            this.Size = new System.Drawing.Size(859, 529);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        internal Guna.UI2.WinForms.Guna2DataGridView DataGridViewLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cashier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimeSpecifier;
        private System.Windows.Forms.Label label2;
    }
}
