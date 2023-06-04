namespace trackr_client_app.Views
{
    partial class CustomerInfoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerInfoView));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.birthLabel = new System.Windows.Forms.Label();
            this.birthTB = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityTB = new System.Windows.Forms.TextBox();
            this.districtLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.streetTB = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.accountLabel = new System.Windows.Forms.Label();
            this.accountTB = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.confBtn = new System.Windows.Forms.Button();
            this.noBtn = new System.Windows.Forms.Button();
            this.browseBtn = new System.Windows.Forms.Button();
            this.districtTB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::trackr_client_app.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(114, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthLabel.ForeColor = System.Drawing.Color.Black;
            this.birthLabel.Location = new System.Drawing.Point(397, 23);
            this.birthLabel.Margin = new System.Windows.Forms.Padding(0);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(89, 23);
            this.birthLabel.TabIndex = 44;
            this.birthLabel.Text = "Ngày sinh";
            // 
            // birthTB
            // 
            this.birthTB.BackColor = System.Drawing.Color.White;
            this.birthTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthTB.Location = new System.Drawing.Point(401, 49);
            this.birthTB.Name = "birthTB";
            this.birthTB.ReadOnly = true;
            this.birthTB.Size = new System.Drawing.Size(324, 30);
            this.birthTB.TabIndex = 43;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.ForeColor = System.Drawing.Color.Black;
            this.phoneLabel.Location = new System.Drawing.Point(397, 82);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(43, 23);
            this.phoneLabel.TabIndex = 42;
            this.phoneLabel.Text = "SĐT";
            // 
            // phoneTB
            // 
            this.phoneTB.BackColor = System.Drawing.Color.White;
            this.phoneTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTB.Location = new System.Drawing.Point(401, 109);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.ReadOnly = true;
            this.phoneTB.Size = new System.Drawing.Size(324, 30);
            this.phoneTB.TabIndex = 41;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.ForeColor = System.Drawing.Color.Black;
            this.cityLabel.Location = new System.Drawing.Point(397, 273);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(397, 23);
            this.cityLabel.TabIndex = 40;
            this.cityLabel.Text = "Tên thành phố (tạm thời chỉ ship trong TP HCM)";
            // 
            // cityTB
            // 
            this.cityTB.BackColor = System.Drawing.Color.White;
            this.cityTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTB.Location = new System.Drawing.Point(401, 299);
            this.cityTB.Name = "cityTB";
            this.cityTB.ReadOnly = true;
            this.cityTB.Size = new System.Drawing.Size(324, 30);
            this.cityTB.TabIndex = 39;
            this.cityTB.Text = "TP Hồ Chí Minh";
            // 
            // districtLabel
            // 
            this.districtLabel.AutoSize = true;
            this.districtLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.districtLabel.ForeColor = System.Drawing.Color.Black;
            this.districtLabel.Location = new System.Drawing.Point(397, 206);
            this.districtLabel.Margin = new System.Windows.Forms.Padding(0);
            this.districtLabel.Name = "districtLabel";
            this.districtLabel.Size = new System.Drawing.Size(138, 23);
            this.districtLabel.TabIndex = 38;
            this.districtLabel.Text = "Tên quận/huyện";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetLabel.ForeColor = System.Drawing.Color.Black;
            this.streetLabel.Location = new System.Drawing.Point(397, 142);
            this.streetLabel.Margin = new System.Windows.Forms.Padding(0);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(170, 23);
            this.streetLabel.TabIndex = 36;
            this.streetLabel.Text = "Tên đường, phường";
            // 
            // streetTB
            // 
            this.streetTB.BackColor = System.Drawing.Color.White;
            this.streetTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetTB.Location = new System.Drawing.Point(401, 168);
            this.streetTB.Name = "streetTB";
            this.streetTB.ReadOnly = true;
            this.streetTB.Size = new System.Drawing.Size(324, 30);
            this.streetTB.TabIndex = 35;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(25, 206);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(104, 23);
            this.nameLabel.TabIndex = 48;
            this.nameLabel.Text = "Tên của bạn";
            // 
            // nameTB
            // 
            this.nameTB.BackColor = System.Drawing.Color.White;
            this.nameTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTB.Location = new System.Drawing.Point(29, 233);
            this.nameTB.Name = "nameTB";
            this.nameTB.ReadOnly = true;
            this.nameTB.Size = new System.Drawing.Size(324, 30);
            this.nameTB.TabIndex = 47;
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountLabel.ForeColor = System.Drawing.Color.Black;
            this.accountLabel.Location = new System.Drawing.Point(25, 273);
            this.accountLabel.Margin = new System.Windows.Forms.Padding(0);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(114, 23);
            this.accountLabel.TabIndex = 46;
            this.accountLabel.Text = "Địa chỉ email";
            // 
            // accountTB
            // 
            this.accountTB.BackColor = System.Drawing.Color.White;
            this.accountTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTB.Location = new System.Drawing.Point(29, 300);
            this.accountTB.Name = "accountTB";
            this.accountTB.ReadOnly = true;
            this.accountTB.Size = new System.Drawing.Size(324, 30);
            this.accountTB.TabIndex = 45;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(238, 365);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(324, 33);
            this.updateBtn.TabIndex = 49;
            this.updateBtn.Text = "Cập nhật thông tin";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // confBtn
            // 
            this.confBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.confBtn.FlatAppearance.BorderSize = 0;
            this.confBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confBtn.ForeColor = System.Drawing.Color.White;
            this.confBtn.Location = new System.Drawing.Point(29, 365);
            this.confBtn.Name = "confBtn";
            this.confBtn.Size = new System.Drawing.Size(324, 33);
            this.confBtn.TabIndex = 50;
            this.confBtn.Text = "Xác nhận sửa đổi";
            this.confBtn.UseVisualStyleBackColor = false;
            this.confBtn.Visible = false;
            this.confBtn.Click += new System.EventHandler(this.confBtn_Click);
            // 
            // noBtn
            // 
            this.noBtn.BackColor = System.Drawing.Color.White;
            this.noBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.noBtn.FlatAppearance.BorderSize = 2;
            this.noBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.noBtn.Location = new System.Drawing.Point(401, 365);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(324, 33);
            this.noBtn.TabIndex = 71;
            this.noBtn.Text = "Hủy bỏ sửa đổi";
            this.noBtn.UseVisualStyleBackColor = false;
            this.noBtn.Visible = false;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // browseBtn
            // 
            this.browseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.browseBtn.FlatAppearance.BorderSize = 0;
            this.browseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseBtn.ForeColor = System.Drawing.Color.White;
            this.browseBtn.Location = new System.Drawing.Point(114, 9);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(150, 33);
            this.browseBtn.TabIndex = 72;
            this.browseBtn.Text = "Chọn ảnh khác";
            this.browseBtn.UseVisualStyleBackColor = false;
            this.browseBtn.Visible = false;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // districtTB
            // 
            this.districtTB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.districtTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.districtTB.FormattingEnabled = true;
            this.districtTB.Items.AddRange(new object[] {
            "Quận 1",
            "Quận 2",
            "Quận 3",
            "Quận 4",
            "Quận 5",
            "Quận 6",
            "Quận 7",
            "Quận 8",
            "Quận 9",
            "Quận 10",
            "Quận 11",
            "Quận 12",
            "Quận Bình Tân",
            "Quận Bình Thạnh",
            "Quận Gò Vấp",
            "Quận Phú Nhuận",
            "Quận Tân Phú",
            "Quận Thủ Đức",
            "Huyện Hóc Môn",
            "Huyện Củ Chi",
            "Huyện Bình Chánh",
            "Huyện Nhà Bè",
            "Huyện Cần Giờ"});
            this.districtTB.Location = new System.Drawing.Point(401, 235);
            this.districtTB.Name = "districtTB";
            this.districtTB.Size = new System.Drawing.Size(324, 28);
            this.districtTB.TabIndex = 73;
            // 
            // CustomerInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.districtTB);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.confBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.accountLabel);
            this.Controls.Add(this.accountTB);
            this.Controls.Add(this.birthLabel);
            this.Controls.Add(this.birthTB);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.cityTB);
            this.Controls.Add(this.districtLabel);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.streetTB);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerInfoView";
            this.Text = "Trackr - Thông tin cá nhân";
            this.Load += new System.EventHandler(this.CustomerInfoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.TextBox birthTB;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityTB;
        private System.Windows.Forms.Label districtLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.TextBox streetTB;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.TextBox accountTB;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button confBtn;
        private System.Windows.Forms.Button noBtn;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.ComboBox districtTB;
    }
}