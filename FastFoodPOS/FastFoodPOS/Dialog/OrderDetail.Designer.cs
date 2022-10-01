namespace FastFoodPOS.Dialog
{
    partial class OrderDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelButton = new System.Windows.Forms.Panel();
            this.ButtonNo = new Guna.UI2.WinForms.Guna2Button();
            this.labelTotalSatis = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridViewTransaction = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToplam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSuccess = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.lblFilename = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelLoading = new System.Windows.Forms.Panel();
            this.guna2WinProgressIndicator1 = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTransaction)).BeginInit();
            this.panelSuccess.SuspendLayout();
            this.panelLoading.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 54);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sipariş Detayı";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelButton);
            this.panel2.Controls.Add(this.panelSuccess);
            this.panel2.Controls.Add(this.panelLoading);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 405);
            this.panel2.TabIndex = 17;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.ButtonNo);
            this.panelButton.Controls.Add(this.labelTotalSatis);
            this.panelButton.Controls.Add(this.label2);
            this.panelButton.Controls.Add(this.DataGridViewTransaction);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButton.Location = new System.Drawing.Point(0, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(761, 405);
            this.panelButton.TabIndex = 17;
            // 
            // ButtonNo
            // 
            this.ButtonNo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonNo.BorderColor = System.Drawing.Color.Gray;
            this.ButtonNo.BorderThickness = 1;
            this.ButtonNo.CheckedState.Parent = this.ButtonNo;
            this.ButtonNo.CustomImages.Parent = this.ButtonNo;
            this.ButtonNo.FillColor = System.Drawing.Color.White;
            this.ButtonNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonNo.ForeColor = System.Drawing.Color.Gray;
            this.ButtonNo.HoverState.Parent = this.ButtonNo;
            this.ButtonNo.Location = new System.Drawing.Point(304, 352);
            this.ButtonNo.Name = "ButtonNo";
            this.ButtonNo.ShadowDecoration.Parent = this.ButtonNo;
            this.ButtonNo.Size = new System.Drawing.Size(125, 41);
            this.ButtonNo.TabIndex = 20;
            this.ButtonNo.Text = "Kapat";
            this.ButtonNo.Click += new System.EventHandler(this.ButtonNo_Click);
            // 
            // labelTotalSatis
            // 
            this.labelTotalSatis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalSatis.AutoSize = true;
            this.labelTotalSatis.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTotalSatis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelTotalSatis.Location = new System.Drawing.Point(670, 363);
            this.labelTotalSatis.Name = "labelTotalSatis";
            this.labelTotalSatis.Size = new System.Drawing.Size(73, 30);
            this.labelTotalSatis.TabIndex = 18;
            this.labelTotalSatis.Text = "0,00 €";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(538, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 30);
            this.label2.TabIndex = 19;
            this.label2.Text = "Toplam Satış:";
            // 
            // DataGridViewTransaction
            // 
            this.DataGridViewTransaction.AllowUserToAddRows = false;
            this.DataGridViewTransaction.AllowUserToDeleteRows = false;
            this.DataGridViewTransaction.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.DataGridViewTransaction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridViewTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewTransaction.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewTransaction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewTransaction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewTransaction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridViewTransaction.ColumnHeadersHeight = 40;
            this.DataGridViewTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colUrunAdi,
            this.colAdet,
            this.colFiyat,
            this.colToplam});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewTransaction.DefaultCellStyle = dataGridViewCellStyle11;
            this.DataGridViewTransaction.EnableHeadersVisualStyles = false;
            this.DataGridViewTransaction.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DataGridViewTransaction.Location = new System.Drawing.Point(3, 3);
            this.DataGridViewTransaction.MultiSelect = false;
            this.DataGridViewTransaction.Name = "DataGridViewTransaction";
            this.DataGridViewTransaction.ReadOnly = true;
            this.DataGridViewTransaction.RowHeadersVisible = false;
            this.DataGridViewTransaction.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(4, 4, 0, 4);
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewTransaction.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DataGridViewTransaction.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridViewTransaction.RowTemplate.Height = 40;
            this.DataGridViewTransaction.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewTransaction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewTransaction.Size = new System.Drawing.Size(755, 343);
            this.DataGridViewTransaction.TabIndex = 17;
            this.DataGridViewTransaction.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid;
            this.DataGridViewTransaction.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewTransaction.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewTransaction.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewTransaction.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewTransaction.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewTransaction.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewTransaction.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DataGridViewTransaction.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewTransaction.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGridViewTransaction.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewTransaction.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewTransaction.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewTransaction.ThemeStyle.HeaderStyle.Height = 40;
            this.DataGridViewTransaction.ThemeStyle.ReadOnly = true;
            this.DataGridViewTransaction.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewTransaction.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewTransaction.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewTransaction.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewTransaction.ThemeStyle.RowsStyle.Height = 40;
            this.DataGridViewTransaction.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DataGridViewTransaction.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // colNo
            // 
            this.colNo.HeaderText = "No";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.HeaderText = "Ürün Adı";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.ReadOnly = true;
            // 
            // colAdet
            // 
            this.colAdet.HeaderText = "Adet";
            this.colAdet.Name = "colAdet";
            this.colAdet.ReadOnly = true;
            // 
            // colFiyat
            // 
            this.colFiyat.HeaderText = "Fiyat";
            this.colFiyat.Name = "colFiyat";
            this.colFiyat.ReadOnly = true;
            // 
            // colToplam
            // 
            this.colToplam.HeaderText = "Toplam";
            this.colToplam.Name = "colToplam";
            this.colToplam.ReadOnly = true;
            // 
            // panelSuccess
            // 
            this.panelSuccess.Controls.Add(this.guna2Button1);
            this.panelSuccess.Controls.Add(this.lblFilename);
            this.panelSuccess.Controls.Add(this.label5);
            this.panelSuccess.Controls.Add(this.label4);
            this.panelSuccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSuccess.Location = new System.Drawing.Point(0, 0);
            this.panelSuccess.Name = "panelSuccess";
            this.panelSuccess.Size = new System.Drawing.Size(761, 405);
            this.panelSuccess.TabIndex = 17;
            this.panelSuccess.Visible = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button1.BorderRadius = 19;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.Gray;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(106, 83);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(146, 41);
            this.guna2Button1.TabIndex = 18;
            this.guna2Button1.Text = "Close";
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblFilename.ForeColor = System.Drawing.Color.Gray;
            this.lblFilename.Location = new System.Drawing.Point(108, 50);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(76, 20);
            this.lblFilename.TabIndex = 17;
            this.lblFilename.Text = "Filename: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(26, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Filename: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.label4.Location = new System.Drawing.Point(26, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Backup Created Successfully";
            // 
            // panelLoading
            // 
            this.panelLoading.Controls.Add(this.guna2WinProgressIndicator1);
            this.panelLoading.Controls.Add(this.label3);
            this.panelLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoading.Location = new System.Drawing.Point(0, 0);
            this.panelLoading.Name = "panelLoading";
            this.panelLoading.Size = new System.Drawing.Size(761, 405);
            this.panelLoading.TabIndex = 17;
            this.panelLoading.Visible = false;
            // 
            // guna2WinProgressIndicator1
            // 
            this.guna2WinProgressIndicator1.AutoStart = true;
            this.guna2WinProgressIndicator1.CircleSize = 1F;
            this.guna2WinProgressIndicator1.Location = new System.Drawing.Point(30, 35);
            this.guna2WinProgressIndicator1.Name = "guna2WinProgressIndicator1";
            this.guna2WinProgressIndicator1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.guna2WinProgressIndicator1.Size = new System.Drawing.Size(50, 50);
            this.guna2WinProgressIndicator1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(102, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Backing up data please wait...";
            // 
            // OrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 459);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderDetail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BackupDialogBox";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelButton.ResumeLayout(false);
            this.panelButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTransaction)).EndInit();
            this.panelSuccess.ResumeLayout(false);
            this.panelSuccess.PerformLayout();
            this.panelLoading.ResumeLayout(false);
            this.panelLoading.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelLoading;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator guna2WinProgressIndicator1;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel panelSuccess;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        internal Guna.UI2.WinForms.Guna2DataGridView DataGridViewTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToplam;
        private System.Windows.Forms.Label labelTotalSatis;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button ButtonNo;
    }
}