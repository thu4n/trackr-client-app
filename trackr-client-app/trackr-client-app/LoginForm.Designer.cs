namespace trackr_client_app
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.accountTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.registerLabel1 = new System.Windows.Forms.Label();
            this.registerLabel2 = new System.Windows.Forms.Label();
            this.navigateRegisterLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.forgotPwdLabel = new System.Windows.Forms.Label();
            this.logoBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.titleLabel.Location = new System.Drawing.Point(293, 108);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(215, 81);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Trackr!";
            // 
            // accountTB
            // 
            this.accountTB.BackColor = System.Drawing.Color.White;
            this.accountTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTB.Location = new System.Drawing.Point(238, 237);
            this.accountTB.Name = "accountTB";
            this.accountTB.Size = new System.Drawing.Size(324, 30);
            this.accountTB.TabIndex = 2;
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.Color.White;
            this.passwordTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.Location = new System.Drawing.Point(238, 302);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '●';
            this.passwordTB.Size = new System.Drawing.Size(324, 30);
            this.passwordTB.TabIndex = 3;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(238, 364);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(324, 33);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Đăng nhập";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // registerLabel1
            // 
            this.registerLabel1.AutoSize = true;
            this.registerLabel1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLabel1.Location = new System.Drawing.Point(235, 415);
            this.registerLabel1.Name = "registerLabel1";
            this.registerLabel1.Size = new System.Drawing.Size(168, 17);
            this.registerLabel1.TabIndex = 5;
            this.registerLabel1.Text = "Bạn chưa có tài khoản? Hãy";
            // 
            // registerLabel2
            // 
            this.registerLabel2.AutoSize = true;
            this.registerLabel2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLabel2.Location = new System.Drawing.Point(468, 415);
            this.registerLabel2.Name = "registerLabel2";
            this.registerLabel2.Size = new System.Drawing.Size(94, 17);
            this.registerLabel2.TabIndex = 6;
            this.registerLabel2.Text = "vì nó miễn phí!";
            // 
            // navigateRegisterLabel
            // 
            this.navigateRegisterLabel.AutoSize = true;
            this.navigateRegisterLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navigateRegisterLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigateRegisterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.navigateRegisterLabel.Location = new System.Drawing.Point(409, 415);
            this.navigateRegisterLabel.Name = "navigateRegisterLabel";
            this.navigateRegisterLabel.Size = new System.Drawing.Size(57, 17);
            this.navigateRegisterLabel.TabIndex = 7;
            this.navigateRegisterLabel.Text = "đăng ký";
            this.navigateRegisterLabel.Click += new System.EventHandler(this.navigateRegisterLabel_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Black;
            this.usernameLabel.Location = new System.Drawing.Point(234, 210);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(114, 23);
            this.usernameLabel.TabIndex = 8;
            this.usernameLabel.Text = "Địa chỉ email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(234, 276);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mật khẩu";
            // 
            // forgotPwdLabel
            // 
            this.forgotPwdLabel.AutoSize = true;
            this.forgotPwdLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgotPwdLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPwdLabel.ForeColor = System.Drawing.Color.Black;
            this.forgotPwdLabel.Location = new System.Drawing.Point(235, 335);
            this.forgotPwdLabel.Name = "forgotPwdLabel";
            this.forgotPwdLabel.Size = new System.Drawing.Size(109, 17);
            this.forgotPwdLabel.TabIndex = 10;
            this.forgotPwdLabel.Text = "Quên mật khẩu?";
            this.forgotPwdLabel.Click += new System.EventHandler(this.forgotPwdLabel_Click);
            // 
            // logoBox
            // 
            this.logoBox.Image = global::trackr_client_app.Properties.Resources.logoSmall;
            this.logoBox.Location = new System.Drawing.Point(342, 12);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(116, 114);
            this.logoBox.TabIndex = 1;
            this.logoBox.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.forgotPwdLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.navigateRegisterLabel);
            this.Controls.Add(this.registerLabel2);
            this.Controls.Add(this.registerLabel1);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.accountTB);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.TextBox accountTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label registerLabel1;
        private System.Windows.Forms.Label registerLabel2;
        private System.Windows.Forms.Label navigateRegisterLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label forgotPwdLabel;
    }
}

