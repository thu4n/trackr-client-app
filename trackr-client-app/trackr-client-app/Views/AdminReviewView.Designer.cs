namespace trackr_client_app.Views
{
    partial class AdminReviewView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminReviewView));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.feedbackTB = new System.Windows.Forms.TextBox();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.starLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.star1 = new System.Windows.Forms.Button();
            this.star2 = new System.Windows.Forms.Button();
            this.star3 = new System.Windows.Forms.Button();
            this.star5 = new System.Windows.Forms.Button();
            this.star4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "RatingStar.png");
            this.imageList1.Images.SetKeyName(1, "RatingStar_Fill.png");
            // 
            // feedbackTB
            // 
            this.feedbackTB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.feedbackTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackTB.Location = new System.Drawing.Point(32, 161);
            this.feedbackTB.Multiline = true;
            this.feedbackTB.Name = "feedbackTB";
            this.feedbackTB.ReadOnly = true;
            this.feedbackTB.Size = new System.Drawing.Size(436, 119);
            this.feedbackTB.TabIndex = 95;
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.BackColor = System.Drawing.Color.White;
            this.feedbackLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackLabel.Location = new System.Drawing.Point(28, 135);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(211, 23);
            this.feedbackLabel.TabIndex = 94;
            this.feedbackLabel.Text = "Nhận xét của khách hàng";
            // 
            // starLabel
            // 
            this.starLabel.AutoSize = true;
            this.starLabel.BackColor = System.Drawing.Color.White;
            this.starLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starLabel.Location = new System.Drawing.Point(28, 50);
            this.starLabel.Name = "starLabel";
            this.starLabel.Size = new System.Drawing.Size(145, 23);
            this.starLabel.TabIndex = 96;
            this.starLabel.Text = "Đánh giá dịch vụ";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.White;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.titleLabel.Location = new System.Drawing.Point(26, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(284, 31);
            this.titleLabel.TabIndex = 97;
            this.titleLabel.Text = "Đánh giá cho đơn hàng #";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.starLabel);
            this.panel1.Controls.Add(this.feedbackTB);
            this.panel1.Controls.Add(this.star1);
            this.panel1.Controls.Add(this.feedbackLabel);
            this.panel1.Controls.Add(this.star2);
            this.panel1.Controls.Add(this.star3);
            this.panel1.Controls.Add(this.star5);
            this.panel1.Controls.Add(this.star4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 292);
            this.panel1.TabIndex = 98;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // star1
            // 
            this.star1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.star1.FlatAppearance.BorderSize = 0;
            this.star1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.star1.ImageIndex = 0;
            this.star1.ImageList = this.imageList1;
            this.star1.Location = new System.Drawing.Point(32, 76);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(49, 49);
            this.star1.TabIndex = 89;
            this.star1.UseVisualStyleBackColor = true;
            // 
            // star2
            // 
            this.star2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.star2.FlatAppearance.BorderSize = 0;
            this.star2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.star2.ImageIndex = 0;
            this.star2.ImageList = this.imageList1;
            this.star2.Location = new System.Drawing.Point(91, 76);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(49, 49);
            this.star2.TabIndex = 90;
            this.star2.UseVisualStyleBackColor = true;
            // 
            // star3
            // 
            this.star3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.star3.FlatAppearance.BorderSize = 0;
            this.star3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.star3.ImageIndex = 0;
            this.star3.ImageList = this.imageList1;
            this.star3.Location = new System.Drawing.Point(150, 76);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(49, 49);
            this.star3.TabIndex = 91;
            this.star3.UseVisualStyleBackColor = true;
            // 
            // star5
            // 
            this.star5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.star5.FlatAppearance.BorderSize = 0;
            this.star5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.star5.ImageIndex = 0;
            this.star5.ImageList = this.imageList1;
            this.star5.Location = new System.Drawing.Point(268, 76);
            this.star5.Name = "star5";
            this.star5.Size = new System.Drawing.Size(49, 49);
            this.star5.TabIndex = 93;
            this.star5.UseVisualStyleBackColor = true;
            // 
            // star4
            // 
            this.star4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.star4.FlatAppearance.BorderSize = 0;
            this.star4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.star4.ImageIndex = 0;
            this.star4.ImageList = this.imageList1;
            this.star4.Location = new System.Drawing.Point(209, 76);
            this.star4.Name = "star4";
            this.star4.Size = new System.Drawing.Size(49, 49);
            this.star4.TabIndex = 92;
            this.star4.UseVisualStyleBackColor = true;
            // 
            // AdminReviewView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(499, 292);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminReviewView";
            this.Text = "Trackr - Đánh giá dịch vụ";
            this.Load += new System.EventHandler(this.AdminReviewView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button star5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button star4;
        private System.Windows.Forms.Button star3;
        private System.Windows.Forms.Button star2;
        private System.Windows.Forms.Button star1;
        private System.Windows.Forms.TextBox feedbackTB;
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.Label starLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel panel1;
    }
}