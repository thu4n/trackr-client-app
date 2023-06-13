namespace trackr_client_app
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.label1 = new System.Windows.Forms.Label();
            this.accountLabel = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.accountTB = new System.Windows.Forms.TextBox();
            this.repwdLabel = new System.Windows.Forms.Label();
            this.repwdTB = new System.Windows.Forms.TextBox();
            this.returnLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.streetTB = new System.Windows.Forms.TextBox();
            this.districtLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityTB = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.birthLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgLabel = new System.Windows.Forms.Label();
            this.browseBtn = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.districtTB = new System.Windows.Forms.ComboBox();
            this.birthDTP = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 254);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mật khẩu";
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountLabel.ForeColor = System.Drawing.Color.Black;
            this.accountLabel.Location = new System.Drawing.Point(27, 174);
            this.accountLabel.Margin = new System.Windows.Forms.Padding(0);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(139, 30);
            this.accountLabel.TabIndex = 18;
            this.accountLabel.Text = "Địa chỉ email";
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.registerBtn.FlatAppearance.BorderSize = 0;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.Color.White;
            this.registerBtn.Location = new System.Drawing.Point(279, 639);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(364, 41);
            this.registerBtn.TabIndex = 14;
            this.registerBtn.Text = "Đăng ký";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.Color.White;
            this.passwordTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.Location = new System.Drawing.Point(32, 286);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '●';
            this.passwordTB.Size = new System.Drawing.Size(364, 35);
            this.passwordTB.TabIndex = 13;
            // 
            // accountTB
            // 
            this.accountTB.BackColor = System.Drawing.Color.White;
            this.accountTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTB.Location = new System.Drawing.Point(32, 208);
            this.accountTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accountTB.Name = "accountTB";
            this.accountTB.Size = new System.Drawing.Size(364, 35);
            this.accountTB.TabIndex = 12;
            // 
            // repwdLabel
            // 
            this.repwdLabel.AutoSize = true;
            this.repwdLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repwdLabel.ForeColor = System.Drawing.Color.Black;
            this.repwdLabel.Location = new System.Drawing.Point(27, 328);
            this.repwdLabel.Margin = new System.Windows.Forms.Padding(0);
            this.repwdLabel.Name = "repwdLabel";
            this.repwdLabel.Size = new System.Drawing.Size(195, 30);
            this.repwdLabel.TabIndex = 21;
            this.repwdLabel.Text = "Nhập lại mật khẩu";
            // 
            // repwdTB
            // 
            this.repwdTB.BackColor = System.Drawing.Color.White;
            this.repwdTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repwdTB.Location = new System.Drawing.Point(32, 360);
            this.repwdTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.repwdTB.Name = "repwdTB";
            this.repwdTB.PasswordChar = '●';
            this.repwdTB.Size = new System.Drawing.Size(364, 35);
            this.repwdTB.TabIndex = 20;
            // 
            // returnLabel
            // 
            this.returnLabel.AutoSize = true;
            this.returnLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnLabel.ForeColor = System.Drawing.Color.Black;
            this.returnLabel.Location = new System.Drawing.Point(366, 701);
            this.returnLabel.Margin = new System.Windows.Forms.Padding(0);
            this.returnLabel.Name = "returnLabel";
            this.returnLabel.Size = new System.Drawing.Size(205, 30);
            this.returnLabel.TabIndex = 22;
            this.returnLabel.Text = "Quay lại đăng nhập";
            this.returnLabel.Click += new System.EventHandler(this.returnLabel_Click);
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetLabel.ForeColor = System.Drawing.Color.Black;
            this.streetLabel.Location = new System.Drawing.Point(460, 248);
            this.streetLabel.Margin = new System.Windows.Forms.Padding(0);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(210, 30);
            this.streetLabel.TabIndex = 24;
            this.streetLabel.Text = "Tên đường, phường";
            // 
            // streetTB
            // 
            this.streetTB.BackColor = System.Drawing.Color.White;
            this.streetTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetTB.Location = new System.Drawing.Point(465, 280);
            this.streetTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.streetTB.Name = "streetTB";
            this.streetTB.Size = new System.Drawing.Size(364, 35);
            this.streetTB.TabIndex = 23;
            // 
            // districtLabel
            // 
            this.districtLabel.AutoSize = true;
            this.districtLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.districtLabel.ForeColor = System.Drawing.Color.Black;
            this.districtLabel.Location = new System.Drawing.Point(460, 328);
            this.districtLabel.Margin = new System.Windows.Forms.Padding(0);
            this.districtLabel.Name = "districtLabel";
            this.districtLabel.Size = new System.Drawing.Size(173, 30);
            this.districtLabel.TabIndex = 26;
            this.districtLabel.Text = "Tên quận/huyện";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.ForeColor = System.Drawing.Color.Black;
            this.cityLabel.Location = new System.Drawing.Point(460, 411);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(491, 30);
            this.cityLabel.TabIndex = 28;
            this.cityLabel.Text = "Tên thành phố (tạm thời chỉ ship trong TP HCM)";
            // 
            // cityTB
            // 
            this.cityTB.BackColor = System.Drawing.Color.White;
            this.cityTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTB.Location = new System.Drawing.Point(465, 444);
            this.cityTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cityTB.Name = "cityTB";
            this.cityTB.ReadOnly = true;
            this.cityTB.Size = new System.Drawing.Size(364, 35);
            this.cityTB.TabIndex = 27;
            this.cityTB.Text = "TP Hồ Chí Minh";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(27, 99);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(130, 30);
            this.nameLabel.TabIndex = 30;
            this.nameLabel.Text = "Tên của bạn";
            // 
            // nameTB
            // 
            this.nameTB.BackColor = System.Drawing.Color.White;
            this.nameTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTB.Location = new System.Drawing.Point(32, 132);
            this.nameTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(364, 35);
            this.nameTB.TabIndex = 29;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.ForeColor = System.Drawing.Color.Black;
            this.phoneLabel.Location = new System.Drawing.Point(460, 172);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(52, 30);
            this.phoneLabel.TabIndex = 32;
            this.phoneLabel.Text = "SĐT";
            // 
            // phoneTB
            // 
            this.phoneTB.BackColor = System.Drawing.Color.White;
            this.phoneTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTB.Location = new System.Drawing.Point(465, 206);
            this.phoneTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(364, 35);
            this.phoneTB.TabIndex = 31;
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthLabel.ForeColor = System.Drawing.Color.Black;
            this.birthLabel.Location = new System.Drawing.Point(460, 99);
            this.birthLabel.Margin = new System.Windows.Forms.Padding(0);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(112, 30);
            this.birthLabel.TabIndex = 34;
            this.birthLabel.Text = "Ngày sinh";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::trackr_client_app.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(190, 434);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 158);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // imgLabel
            // 
            this.imgLabel.AutoSize = true;
            this.imgLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgLabel.ForeColor = System.Drawing.Color.Black;
            this.imgLabel.Location = new System.Drawing.Point(28, 448);
            this.imgLabel.Margin = new System.Windows.Forms.Padding(0);
            this.imgLabel.Name = "imgLabel";
            this.imgLabel.Size = new System.Drawing.Size(139, 30);
            this.imgLabel.TabIndex = 36;
            this.imgLabel.Text = "Ảnh đại diện";
            // 
            // browseBtn
            // 
            this.browseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.browseBtn.FlatAppearance.BorderSize = 0;
            this.browseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseBtn.ForeColor = System.Drawing.Color.White;
            this.browseBtn.Location = new System.Drawing.Point(32, 480);
            this.browseBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(141, 41);
            this.browseBtn.TabIndex = 37;
            this.browseBtn.Text = "Chọn ảnh";
            this.browseBtn.UseVisualStyleBackColor = false;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Black;
            this.titleLabel.Location = new System.Drawing.Point(227, 26);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(494, 45);
            this.titleLabel.TabIndex = 38;
            this.titleLabel.Text = "Vui lòng điền đầy đủ thông tin";
            // 
            // districtTB
            // 
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
            this.districtTB.Location = new System.Drawing.Point(465, 360);
            this.districtTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.districtTB.Name = "districtTB";
            this.districtTB.Size = new System.Drawing.Size(364, 33);
            this.districtTB.TabIndex = 39;
            // 
            // birthDTP
            // 
            this.birthDTP.Location = new System.Drawing.Point(465, 137);
            this.birthDTP.MinimumSize = new System.Drawing.Size(2, 2);
            this.birthDTP.Name = "birthDTP";
            this.birthDTP.ShowUpDown = true;
            this.birthDTP.Size = new System.Drawing.Size(364, 26);
            this.birthDTP.TabIndex = 40;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 764);
            this.Controls.Add(this.birthDTP);
            this.Controls.Add(this.districtTB);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.imgLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.birthLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.cityTB);
            this.Controls.Add(this.districtLabel);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.streetTB);
            this.Controls.Add(this.returnLabel);
            this.Controls.Add(this.repwdLabel);
            this.Controls.Add(this.repwdTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accountLabel);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.accountTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RegisterForm";
            this.Text = "Trackr - Đăng ký";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox accountTB;
        private System.Windows.Forms.Label repwdLabel;
        private System.Windows.Forms.TextBox repwdTB;
        private System.Windows.Forms.Label returnLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.TextBox streetTB;
        private System.Windows.Forms.Label districtLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityTB;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label imgLabel;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox districtTB;
        private System.Windows.Forms.DateTimePicker birthDTP;
    }
}