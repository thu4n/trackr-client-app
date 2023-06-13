namespace trackr_client_app
{
    partial class ForgotPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordForm));
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.getCodeBtn = new System.Windows.Forms.Button();
            this.otpLabel = new System.Windows.Forms.Label();
            this.otpTB = new System.Windows.Forms.TextBox();
            this.pwdLabel = new System.Windows.Forms.Label();
            this.validateBtn = new System.Windows.Forms.Button();
            this.pwdTB = new System.Windows.Forms.TextBox();
            this.confBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(58, 59);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(231, 30);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Nhập địa chỉ email vào:";
            // 
            // emailTB
            // 
            this.emailTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTB.Location = new System.Drawing.Point(311, 54);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(328, 35);
            this.emailTB.TabIndex = 1;
            // 
            // getCodeBtn
            // 
            this.getCodeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.getCodeBtn.FlatAppearance.BorderSize = 0;
            this.getCodeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getCodeBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getCodeBtn.ForeColor = System.Drawing.Color.White;
            this.getCodeBtn.Location = new System.Drawing.Point(645, 54);
            this.getCodeBtn.Name = "getCodeBtn";
            this.getCodeBtn.Size = new System.Drawing.Size(176, 33);
            this.getCodeBtn.TabIndex = 5;
            this.getCodeBtn.Text = "Lấy OTP";
            this.getCodeBtn.UseVisualStyleBackColor = false;
            this.getCodeBtn.Click += new System.EventHandler(this.getCodeBtn_Click);
            // 
            // otpLabel
            // 
            this.otpLabel.AutoSize = true;
            this.otpLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otpLabel.Location = new System.Drawing.Point(58, 113);
            this.otpLabel.Name = "otpLabel";
            this.otpLabel.Size = new System.Drawing.Size(152, 30);
            this.otpLabel.TabIndex = 6;
            this.otpLabel.Text = "Nhập OTP vào:";
            // 
            // otpTB
            // 
            this.otpTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otpTB.Location = new System.Drawing.Point(311, 113);
            this.otpTB.Name = "otpTB";
            this.otpTB.Size = new System.Drawing.Size(328, 35);
            this.otpTB.TabIndex = 7;
            // 
            // pwdLabel
            // 
            this.pwdLabel.AutoSize = true;
            this.pwdLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdLabel.Location = new System.Drawing.Point(58, 162);
            this.pwdLabel.Name = "pwdLabel";
            this.pwdLabel.Size = new System.Drawing.Size(204, 30);
            this.pwdLabel.TabIndex = 8;
            this.pwdLabel.Text = "Nhập mật khẩu mới:";
            this.pwdLabel.Visible = false;
            // 
            // validateBtn
            // 
            this.validateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.validateBtn.FlatAppearance.BorderSize = 0;
            this.validateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validateBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateBtn.ForeColor = System.Drawing.Color.White;
            this.validateBtn.Location = new System.Drawing.Point(645, 115);
            this.validateBtn.Name = "validateBtn";
            this.validateBtn.Size = new System.Drawing.Size(176, 33);
            this.validateBtn.TabIndex = 9;
            this.validateBtn.Text = "Xác thực";
            this.validateBtn.UseVisualStyleBackColor = false;
            this.validateBtn.Click += new System.EventHandler(this.validateBtn_Click);
            // 
            // pwdTB
            // 
            this.pwdTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdTB.Location = new System.Drawing.Point(311, 162);
            this.pwdTB.Name = "pwdTB";
            this.pwdTB.Size = new System.Drawing.Size(328, 35);
            this.pwdTB.TabIndex = 10;
            this.pwdTB.Visible = false;
            // 
            // confBtn
            // 
            this.confBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.confBtn.FlatAppearance.BorderSize = 0;
            this.confBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confBtn.ForeColor = System.Drawing.Color.White;
            this.confBtn.Location = new System.Drawing.Point(645, 164);
            this.confBtn.Name = "confBtn";
            this.confBtn.Size = new System.Drawing.Size(176, 33);
            this.confBtn.TabIndex = 11;
            this.confBtn.Text = "Xác nhận";
            this.confBtn.UseVisualStyleBackColor = false;
            this.confBtn.Visible = false;
            this.confBtn.Click += new System.EventHandler(this.confBtn_Click);
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 239);
            this.Controls.Add(this.confBtn);
            this.Controls.Add(this.pwdTB);
            this.Controls.Add(this.validateBtn);
            this.Controls.Add(this.pwdLabel);
            this.Controls.Add(this.otpTB);
            this.Controls.Add(this.otpLabel);
            this.Controls.Add(this.getCodeBtn);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.emailLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgotPasswordForm";
            this.Text = "Trackr - Quên mật khẩu";
            this.Load += new System.EventHandler(this.ForgotPasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Button getCodeBtn;
        private System.Windows.Forms.Label otpLabel;
        private System.Windows.Forms.TextBox otpTB;
        private System.Windows.Forms.Label pwdLabel;
        private System.Windows.Forms.Button validateBtn;
        private System.Windows.Forms.TextBox pwdTB;
        private System.Windows.Forms.Button confBtn;
    }
}