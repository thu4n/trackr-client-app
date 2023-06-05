namespace trackr_client_app.Views
{
    partial class CustomerPaymentView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerPaymentView));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.moneyLabel1 = new System.Windows.Forms.Label();
            this.moneyLabel2 = new System.Windows.Forms.Label();
            this.codeLabel = new System.Windows.Forms.Label();
            this.codeLabel2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(520, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.BackColor = System.Drawing.SystemColors.Control;
            this.instructionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(64, 102);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(450, 56);
            this.instructionLabel.TabIndex = 22;
            this.instructionLabel.Text = "Mở ứng dụng ZaloPay trên điện thoại của bạn\r\n và quét mã QR bên cạnh:";
            // 
            // moneyLabel1
            // 
            this.moneyLabel1.AutoSize = true;
            this.moneyLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.moneyLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyLabel1.Location = new System.Drawing.Point(65, 210);
            this.moneyLabel1.Name = "moneyLabel1";
            this.moneyLabel1.Size = new System.Drawing.Size(195, 23);
            this.moneyLabel1.TabIndex = 23;
            this.moneyLabel1.Text = "Số tiền cần thanh toán:";
            // 
            // moneyLabel2
            // 
            this.moneyLabel2.AutoSize = true;
            this.moneyLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.moneyLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.moneyLabel2.Location = new System.Drawing.Point(266, 210);
            this.moneyLabel2.Name = "moneyLabel2";
            this.moneyLabel2.Size = new System.Drawing.Size(62, 23);
            this.moneyLabel2.TabIndex = 24;
            this.moneyLabel2.Text = "0 VNĐ";
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.codeLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeLabel.Location = new System.Drawing.Point(65, 176);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(122, 23);
            this.codeLabel.TabIndex = 25;
            this.codeLabel.Text = "Mã đơn hàng:";
            // 
            // codeLabel2
            // 
            this.codeLabel2.AutoSize = true;
            this.codeLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.codeLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.codeLabel2.Location = new System.Drawing.Point(193, 176);
            this.codeLabel2.Name = "codeLabel2";
            this.codeLabel2.Size = new System.Drawing.Size(42, 23);
            this.codeLabel2.TabIndex = 26;
            this.codeLabel2.Text = "2XX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 41);
            this.label1.TabIndex = 27;
            this.label1.Text = "Thanh toán thông qua ZaloPay";
            // 
            // confBtn
            // 
            this.confBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.confBtn.FlatAppearance.BorderSize = 0;
            this.confBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confBtn.ForeColor = System.Drawing.Color.White;
            this.confBtn.Location = new System.Drawing.Point(69, 269);
            this.confBtn.Name = "confBtn";
            this.confBtn.Size = new System.Drawing.Size(252, 33);
            this.confBtn.TabIndex = 76;
            this.confBtn.Text = "Xác nhận đã thanh toán";
            this.confBtn.UseVisualStyleBackColor = false;
            this.confBtn.Click += new System.EventHandler(this.confBtn_Click);
            // 
            // CustomerPaymentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 343);
            this.Controls.Add(this.confBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codeLabel2);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.moneyLabel2);
            this.Controls.Add(this.moneyLabel1);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CustomerPaymentView";
            this.Text = "Trackr - Thanh toán";
            this.Load += new System.EventHandler(this.CustomerPaymentView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label moneyLabel1;
        private System.Windows.Forms.Label moneyLabel2;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Label codeLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confBtn;
    }
}