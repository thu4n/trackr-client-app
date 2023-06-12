namespace trackr_client_app.Views
{
    partial class CustomerParcelCancel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerParcelCancel));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelConfirmBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.reasonTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "waiting.png");
            this.imageList1.Images.SetKeyName(1, "processed.png");
            this.imageList1.Images.SetKeyName(2, "check.png");
            this.imageList1.Images.SetKeyName(3, "datetime.png");
            // 
            // titleLabel1
            // 
            this.titleLabel1.AutoSize = true;
            this.titleLabel1.BackColor = System.Drawing.Color.White;
            this.titleLabel1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.titleLabel1.Location = new System.Drawing.Point(133, 18);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(308, 38);
            this.titleLabel1.TabIndex = 84;
            this.titleLabel1.Text = "Yêu cầu hủy đơn hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 23);
            this.label1.TabIndex = 115;
            this.label1.Text = "Lý do hủy đơn (vui lòng không bỏ trống)";
            // 
            // cancelConfirmBtn
            // 
            this.cancelConfirmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.cancelConfirmBtn.FlatAppearance.BorderSize = 0;
            this.cancelConfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelConfirmBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelConfirmBtn.ForeColor = System.Drawing.Color.White;
            this.cancelConfirmBtn.Location = new System.Drawing.Point(46, 295);
            this.cancelConfirmBtn.Name = "cancelConfirmBtn";
            this.cancelConfirmBtn.Size = new System.Drawing.Size(209, 33);
            this.cancelConfirmBtn.TabIndex = 117;
            this.cancelConfirmBtn.Text = "Xác nhận gửi yêu cầu";
            this.cancelConfirmBtn.UseVisualStyleBackColor = false;
            this.cancelConfirmBtn.Click += new System.EventHandler(this.cancelConfirmBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.White;
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.cancelBtn.FlatAppearance.BorderSize = 2;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.cancelBtn.Location = new System.Drawing.Point(295, 295);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(209, 33);
            this.cancelBtn.TabIndex = 118;
            this.cancelBtn.Text = "Hủy bỏ";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // reasonTB
            // 
            this.reasonTB.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.reasonTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasonTB.Location = new System.Drawing.Point(46, 95);
            this.reasonTB.Multiline = true;
            this.reasonTB.Name = "reasonTB";
            this.reasonTB.Size = new System.Drawing.Size(458, 143);
            this.reasonTB.TabIndex = 119;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(457, 40);
            this.label2.TabIndex = 120;
            this.label2.Text = "Nếu yêu cầu không được chấp thuận, quý khách có thể liên lạc thêm\r\nqua mail của c" +
    "ửa hàng tại trackrservice@gmail.com\r\n";
            // 
            // CustomerParcelCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(575, 360);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reasonTB);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.cancelConfirmBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomerParcelCancel";
            this.Text = "Trackr - Yêu cầu hủy đơn hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label titleLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelConfirmBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox reasonTB;
        private System.Windows.Forms.Label label2;
    }
}