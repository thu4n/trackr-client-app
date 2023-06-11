namespace trackr_client_app.Views
{
    partial class CustomerConfirmView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerConfirmView));
            this.noBtn = new System.Windows.Forms.Button();
            this.yesBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // noBtn
            // 
            this.noBtn.BackColor = System.Drawing.Color.White;
            this.noBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.noBtn.FlatAppearance.BorderSize = 2;
            this.noBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.noBtn.Location = new System.Drawing.Point(364, 134);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(167, 47);
            this.noBtn.TabIndex = 73;
            this.noBtn.Text = "Hủy yêu cầu";
            this.noBtn.UseVisualStyleBackColor = false;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // yesBtn
            // 
            this.yesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.yesBtn.FlatAppearance.BorderSize = 0;
            this.yesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesBtn.ForeColor = System.Drawing.Color.White;
            this.yesBtn.Location = new System.Drawing.Point(121, 134);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(166, 47);
            this.yesBtn.TabIndex = 72;
            this.yesBtn.Text = "Gửi yêu cầu ";
            this.yesBtn.UseVisualStyleBackColor = false;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 90);
            this.label1.TabIndex = 71;
            this.label1.Text = "Bạn có chắc chắn muốn gửi yêu cầu hủy đơn không?\r\nĐơn của bạn chưa xác nhận được " +
    "hủy\r\nHệ thống sẽ thông báo nếu đơn hàng được chấp nhận hủy";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerConfirmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 204);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.yesBtn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerConfirmView";
            this.Text = "Trackr - Parcel Cancel Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button noBtn;
        private System.Windows.Forms.Button yesBtn;
        private System.Windows.Forms.Label label1;
    }
}