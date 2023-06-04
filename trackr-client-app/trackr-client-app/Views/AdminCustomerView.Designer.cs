namespace trackr_client_app.Views
{
    partial class AdminCustomerView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCustomerView));
            this.infoPanel = new System.Windows.Forms.Panel();
            this.cusBirthTB = new System.Windows.Forms.TextBox();
            this.cusBirthLabel = new System.Windows.Forms.Label();
            this.cusAddressTB = new System.Windows.Forms.TextBox();
            this.cusPhoneTB = new System.Windows.Forms.TextBox();
            this.cusNameTB = new System.Windows.Forms.TextBox();
            this.cusCodeTB = new System.Windows.Forms.TextBox();
            this.cusAddressLabel = new System.Windows.Forms.Label();
            this.cusPhoneLabel = new System.Windows.Forms.Label();
            this.cusNameLabel = new System.Windows.Forms.Label();
            this.cusCodeLabel = new System.Windows.Forms.Label();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.tablePanel = new System.Windows.Forms.Panel();
            this.parcelGridView = new System.Windows.Forms.DataGridView();
            this.sttCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLabel = new System.Windows.Forms.Label();
            this.delBtn = new System.Windows.Forms.Button();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parcelGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.White;
            this.infoPanel.Controls.Add(this.delBtn);
            this.infoPanel.Controls.Add(this.cusBirthTB);
            this.infoPanel.Controls.Add(this.cusBirthLabel);
            this.infoPanel.Controls.Add(this.cusAddressTB);
            this.infoPanel.Controls.Add(this.cusPhoneTB);
            this.infoPanel.Controls.Add(this.cusNameTB);
            this.infoPanel.Controls.Add(this.cusCodeTB);
            this.infoPanel.Controls.Add(this.cusAddressLabel);
            this.infoPanel.Controls.Add(this.cusPhoneLabel);
            this.infoPanel.Controls.Add(this.cusNameLabel);
            this.infoPanel.Controls.Add(this.cusCodeLabel);
            this.infoPanel.Controls.Add(this.imgBox);
            this.infoPanel.Controls.Add(this.titleLabel);
            this.infoPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoPanel.Location = new System.Drawing.Point(18, 12);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(1015, 264);
            this.infoPanel.TabIndex = 0;
            // 
            // cusBirthTB
            // 
            this.cusBirthTB.BackColor = System.Drawing.Color.White;
            this.cusBirthTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cusBirthTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusBirthTB.Location = new System.Drawing.Point(343, 162);
            this.cusBirthTB.Name = "cusBirthTB";
            this.cusBirthTB.ReadOnly = true;
            this.cusBirthTB.Size = new System.Drawing.Size(96, 23);
            this.cusBirthTB.TabIndex = 78;
            this.cusBirthTB.Text = "0785987612";
            // 
            // cusBirthLabel
            // 
            this.cusBirthLabel.AutoSize = true;
            this.cusBirthLabel.BackColor = System.Drawing.Color.White;
            this.cusBirthLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusBirthLabel.Location = new System.Drawing.Point(243, 162);
            this.cusBirthLabel.Name = "cusBirthLabel";
            this.cusBirthLabel.Size = new System.Drawing.Size(94, 23);
            this.cusBirthLabel.TabIndex = 77;
            this.cusBirthLabel.Text = "Ngày sinh:";
            // 
            // cusAddressTB
            // 
            this.cusAddressTB.BackColor = System.Drawing.Color.White;
            this.cusAddressTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cusAddressTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusAddressTB.Location = new System.Drawing.Point(319, 194);
            this.cusAddressTB.Multiline = true;
            this.cusAddressTB.Name = "cusAddressTB";
            this.cusAddressTB.ReadOnly = true;
            this.cusAddressTB.Size = new System.Drawing.Size(335, 47);
            this.cusAddressTB.TabIndex = 76;
            this.cusAddressTB.Text = "Ký túc xá khu A: Đường Tạ Quang Bửu, khu phố 6, phường Linh Trung, thành phố Thủ " +
    "Đức, Thành phố Hồ Chí Minh.";
            // 
            // cusPhoneTB
            // 
            this.cusPhoneTB.BackColor = System.Drawing.Color.White;
            this.cusPhoneTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cusPhoneTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusPhoneTB.Location = new System.Drawing.Point(297, 130);
            this.cusPhoneTB.Name = "cusPhoneTB";
            this.cusPhoneTB.ReadOnly = true;
            this.cusPhoneTB.Size = new System.Drawing.Size(196, 23);
            this.cusPhoneTB.TabIndex = 75;
            this.cusPhoneTB.Text = "0785987612";
            // 
            // cusNameTB
            // 
            this.cusNameTB.BackColor = System.Drawing.Color.White;
            this.cusNameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cusNameTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusNameTB.Location = new System.Drawing.Point(386, 94);
            this.cusNameTB.Name = "cusNameTB";
            this.cusNameTB.ReadOnly = true;
            this.cusNameTB.Size = new System.Drawing.Size(196, 23);
            this.cusNameTB.TabIndex = 74;
            this.cusNameTB.Text = "Tống Võ Anh Thuận";
            // 
            // cusCodeTB
            // 
            this.cusCodeTB.BackColor = System.Drawing.Color.White;
            this.cusCodeTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cusCodeTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusCodeTB.Location = new System.Drawing.Point(386, 61);
            this.cusCodeTB.Name = "cusCodeTB";
            this.cusCodeTB.ReadOnly = true;
            this.cusCodeTB.Size = new System.Drawing.Size(98, 23);
            this.cusCodeTB.TabIndex = 73;
            this.cusCodeTB.Text = "12345678";
            // 
            // cusAddressLabel
            // 
            this.cusAddressLabel.AutoSize = true;
            this.cusAddressLabel.BackColor = System.Drawing.Color.White;
            this.cusAddressLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusAddressLabel.Location = new System.Drawing.Point(243, 194);
            this.cusAddressLabel.Name = "cusAddressLabel";
            this.cusAddressLabel.Size = new System.Drawing.Size(70, 23);
            this.cusAddressLabel.TabIndex = 72;
            this.cusAddressLabel.Text = "Địa chỉ:";
            // 
            // cusPhoneLabel
            // 
            this.cusPhoneLabel.AutoSize = true;
            this.cusPhoneLabel.BackColor = System.Drawing.Color.White;
            this.cusPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusPhoneLabel.Location = new System.Drawing.Point(243, 130);
            this.cusPhoneLabel.Name = "cusPhoneLabel";
            this.cusPhoneLabel.Size = new System.Drawing.Size(48, 23);
            this.cusPhoneLabel.TabIndex = 71;
            this.cusPhoneLabel.Text = "SĐT:";
            // 
            // cusNameLabel
            // 
            this.cusNameLabel.AutoSize = true;
            this.cusNameLabel.BackColor = System.Drawing.Color.White;
            this.cusNameLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusNameLabel.Location = new System.Drawing.Point(243, 94);
            this.cusNameLabel.Name = "cusNameLabel";
            this.cusNameLabel.Size = new System.Drawing.Size(139, 23);
            this.cusNameLabel.TabIndex = 70;
            this.cusNameLabel.Text = "Tên khách hàng:";
            // 
            // cusCodeLabel
            // 
            this.cusCodeLabel.AutoSize = true;
            this.cusCodeLabel.BackColor = System.Drawing.Color.White;
            this.cusCodeLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusCodeLabel.Location = new System.Drawing.Point(243, 61);
            this.cusCodeLabel.Name = "cusCodeLabel";
            this.cusCodeLabel.Size = new System.Drawing.Size(137, 23);
            this.cusCodeLabel.TabIndex = 69;
            this.cusCodeLabel.Text = "Mã khách hàng:";
            // 
            // imgBox
            // 
            this.imgBox.BackColor = System.Drawing.Color.White;
            this.imgBox.BackgroundImage = global::trackr_client_app.Properties.Resources.logoSmall;
            this.imgBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgBox.Location = new System.Drawing.Point(21, 61);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(172, 172);
            this.imgBox.TabIndex = 68;
            this.imgBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.White;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.titleLabel.Location = new System.Drawing.Point(14, 11);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(305, 38);
            this.titleLabel.TabIndex = 47;
            this.titleLabel.Text = "Thông tin khách hàng";
            // 
            // tablePanel
            // 
            this.tablePanel.BackColor = System.Drawing.Color.White;
            this.tablePanel.Controls.Add(this.parcelGridView);
            this.tablePanel.Controls.Add(this.tableLabel);
            this.tablePanel.Location = new System.Drawing.Point(18, 291);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(1015, 330);
            this.tablePanel.TabIndex = 72;
            // 
            // parcelGridView
            // 
            this.parcelGridView.AllowUserToAddRows = false;
            this.parcelGridView.AllowUserToDeleteRows = false;
            this.parcelGridView.AllowUserToResizeColumns = false;
            this.parcelGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.parcelGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.parcelGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parcelGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttCol,
            this.codeCol,
            this.nameCol,
            this.dateCol,
            this.statusCol});
            this.parcelGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.parcelGridView.Location = new System.Drawing.Point(0, 51);
            this.parcelGridView.Name = "parcelGridView";
            this.parcelGridView.RowHeadersWidth = 51;
            this.parcelGridView.RowTemplate.Height = 24;
            this.parcelGridView.Size = new System.Drawing.Size(1015, 279);
            this.parcelGridView.TabIndex = 47;
            // 
            // sttCol
            // 
            this.sttCol.HeaderText = "STT";
            this.sttCol.MinimumWidth = 6;
            this.sttCol.Name = "sttCol";
            this.sttCol.Width = 125;
            // 
            // codeCol
            // 
            this.codeCol.HeaderText = "Mã vận đơn";
            this.codeCol.MinimumWidth = 6;
            this.codeCol.Name = "codeCol";
            this.codeCol.Width = 125;
            // 
            // nameCol
            // 
            this.nameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameCol.HeaderText = "Tên đơn hàng";
            this.nameCol.MinimumWidth = 6;
            this.nameCol.Name = "nameCol";
            // 
            // dateCol
            // 
            this.dateCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dateCol.HeaderText = "Ngày đặt hàng";
            this.dateCol.MinimumWidth = 6;
            this.dateCol.Name = "dateCol";
            this.dateCol.Width = 136;
            // 
            // statusCol
            // 
            this.statusCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusCol.HeaderText = "Trạng thái";
            this.statusCol.MinimumWidth = 6;
            this.statusCol.Name = "statusCol";
            // 
            // tableLabel
            // 
            this.tableLabel.AutoSize = true;
            this.tableLabel.BackColor = System.Drawing.Color.White;
            this.tableLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.tableLabel.Location = new System.Drawing.Point(12, 10);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(405, 38);
            this.tableLabel.TabIndex = 46;
            this.tableLabel.Text = "Danh sách đơn hàng đặt mua\r\n";
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.White;
            this.delBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.delBtn.FlatAppearance.BorderSize = 2;
            this.delBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.delBtn.Location = new System.Drawing.Point(325, 18);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(189, 33);
            this.delBtn.TabIndex = 73;
            this.delBtn.Text = "Xóa khách hàng";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // AdminCustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 633);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.infoPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminCustomerView";
            this.Text = "Trackr - Thông tin khách hàng";
            this.Load += new System.EventHandler(this.AdminCustomerView_Load);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.tablePanel.ResumeLayout(false);
            this.tablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parcelGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.TextBox cusAddressTB;
        private System.Windows.Forms.TextBox cusPhoneTB;
        private System.Windows.Forms.TextBox cusNameTB;
        private System.Windows.Forms.TextBox cusCodeTB;
        private System.Windows.Forms.Label cusAddressLabel;
        private System.Windows.Forms.Label cusPhoneLabel;
        private System.Windows.Forms.Label cusNameLabel;
        private System.Windows.Forms.Label cusCodeLabel;
        private System.Windows.Forms.Panel tablePanel;
        private System.Windows.Forms.DataGridView parcelGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusCol;
        private System.Windows.Forms.Label tableLabel;
        private System.Windows.Forms.TextBox cusBirthTB;
        private System.Windows.Forms.Label cusBirthLabel;
        private System.Windows.Forms.Button delBtn;
    }
}