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
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.accountTB = new System.Windows.Forms.TextBox();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.repasswordLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.returnLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.Black;
            this.passwordLabel.Location = new System.Drawing.Point(236, 287);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(86, 23);
            this.passwordLabel.TabIndex = 19;
            this.passwordLabel.Text = "Mật khẩu";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Black;
            this.usernameLabel.Location = new System.Drawing.Point(236, 221);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(117, 23);
            this.usernameLabel.TabIndex = 18;
            this.usernameLabel.Text = "Tên tài khoản";
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.registerBtn.FlatAppearance.BorderSize = 0;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.Color.White;
            this.registerBtn.Location = new System.Drawing.Point(240, 563);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(324, 33);
            this.registerBtn.TabIndex = 14;
            this.registerBtn.Text = "Đăng ký";
            this.registerBtn.UseVisualStyleBackColor = false;
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.Color.White;
            this.passwordTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.Location = new System.Drawing.Point(240, 313);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '●';
            this.passwordTB.Size = new System.Drawing.Size(324, 30);
            this.passwordTB.TabIndex = 13;
            // 
            // accountTB
            // 
            this.accountTB.BackColor = System.Drawing.Color.White;
            this.accountTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTB.Location = new System.Drawing.Point(240, 248);
            this.accountTB.Name = "accountTB";
            this.accountTB.Size = new System.Drawing.Size(324, 30);
            this.accountTB.TabIndex = 12;
            // 
            // logoBox
            // 
            this.logoBox.Image = global::trackr_client_app.Properties.Resources.logoSmall;
            this.logoBox.Location = new System.Drawing.Point(344, 23);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(116, 114);
            this.logoBox.TabIndex = 11;
            this.logoBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.titleLabel.Location = new System.Drawing.Point(295, 119);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(215, 81);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "Trackr!";
            // 
            // repasswordLabel
            // 
            this.repasswordLabel.AutoSize = true;
            this.repasswordLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repasswordLabel.ForeColor = System.Drawing.Color.Black;
            this.repasswordLabel.Location = new System.Drawing.Point(236, 346);
            this.repasswordLabel.Margin = new System.Windows.Forms.Padding(0);
            this.repasswordLabel.Name = "repasswordLabel";
            this.repasswordLabel.Size = new System.Drawing.Size(158, 23);
            this.repasswordLabel.TabIndex = 21;
            this.repasswordLabel.Text = "Nhập lại mật khẩu";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(240, 372);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '●';
            this.textBox1.Size = new System.Drawing.Size(324, 30);
            this.textBox1.TabIndex = 20;
            // 
            // returnLabel
            // 
            this.returnLabel.AutoSize = true;
            this.returnLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnLabel.ForeColor = System.Drawing.Color.Black;
            this.returnLabel.Location = new System.Drawing.Point(317, 613);
            this.returnLabel.Margin = new System.Windows.Forms.Padding(0);
            this.returnLabel.Name = "returnLabel";
            this.returnLabel.Size = new System.Drawing.Size(166, 23);
            this.returnLabel.TabIndex = 22;
            this.returnLabel.Text = "Quay lại đăng nhập";
            this.returnLabel.Click += new System.EventHandler(this.returnLabel_Click);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.ForeColor = System.Drawing.Color.Black;
            this.phoneLabel.Location = new System.Drawing.Point(236, 412);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(116, 23);
            this.phoneLabel.TabIndex = 24;
            this.phoneLabel.Text = "Số điện thoại";
            // 
            // phoneTB
            // 
            this.phoneTB.BackColor = System.Drawing.Color.White;
            this.phoneTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTB.Location = new System.Drawing.Point(240, 437);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.PasswordChar = '●';
            this.phoneTB.Size = new System.Drawing.Size(324, 30);
            this.phoneTB.TabIndex = 23;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.ForeColor = System.Drawing.Color.Black;
            this.addressLabel.Location = new System.Drawing.Point(236, 479);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(123, 23);
            this.addressLabel.TabIndex = 26;
            this.addressLabel.Text = "Địa chỉ liên hệ";
            // 
            // addressTB
            // 
            this.addressTB.BackColor = System.Drawing.Color.White;
            this.addressTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTB.Location = new System.Drawing.Point(240, 505);
            this.addressTB.Name = "addressTB";
            this.addressTB.PasswordChar = '●';
            this.addressTB.Size = new System.Drawing.Size(324, 30);
            this.addressTB.TabIndex = 25;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 654);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.addressTB);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.returnLabel);
            this.Controls.Add(this.repasswordLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.accountTB);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.Text = "Trackr - Đăng ký";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox accountTB;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label repasswordLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label returnLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTB;
    }
}