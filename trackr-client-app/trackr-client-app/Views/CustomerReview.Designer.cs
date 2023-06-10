namespace trackr_client_app.Views
{
    partial class CustomerReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerReview));
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reviewBtn = new System.Windows.Forms.Button();
            this.parcelNameTB = new System.Windows.Forms.TextBox();
            this.parcelCodeTB = new System.Windows.Forms.TextBox();
            this.parcelNameLabel = new System.Windows.Forms.Label();
            this.parcelCodeLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel1
            // 
            this.titleLabel1.AutoSize = true;
            this.titleLabel1.BackColor = System.Drawing.Color.White;
            this.titleLabel1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.titleLabel1.Location = new System.Drawing.Point(228, 21);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(318, 46);
            this.titleLabel1.TabIndex = 21;
            this.titleLabel1.Text = "Biểu mẫu đánh giá";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.parcelNameTB);
            this.panel1.Controls.Add(this.parcelCodeTB);
            this.panel1.Controls.Add(this.parcelNameLabel);
            this.panel1.Controls.Add(this.parcelCodeLabel);
            this.panel1.Controls.Add(this.reviewBtn);
            this.panel1.Controls.Add(this.titleLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 497);
            this.panel1.TabIndex = 22;
            // 
            // reviewBtn
            // 
            this.reviewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.reviewBtn.FlatAppearance.BorderSize = 0;
            this.reviewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reviewBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewBtn.ForeColor = System.Drawing.Color.White;
            this.reviewBtn.Location = new System.Drawing.Point(301, 428);
            this.reviewBtn.Name = "reviewBtn";
            this.reviewBtn.Size = new System.Drawing.Size(172, 33);
            this.reviewBtn.TabIndex = 78;
            this.reviewBtn.Text = "Gửi đánh giá";
            this.reviewBtn.UseVisualStyleBackColor = false;
            // 
            // parcelNameTB
            // 
            this.parcelNameTB.BackColor = System.Drawing.Color.White;
            this.parcelNameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.parcelNameTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parcelNameTB.Location = new System.Drawing.Point(153, 123);
            this.parcelNameTB.Name = "parcelNameTB";
            this.parcelNameTB.ReadOnly = true;
            this.parcelNameTB.Size = new System.Drawing.Size(175, 23);
            this.parcelNameTB.TabIndex = 82;
            this.parcelNameTB.Text = "Random parcel name";
            this.parcelNameTB.WordWrap = false;
            // 
            // parcelCodeTB
            // 
            this.parcelCodeTB.BackColor = System.Drawing.Color.White;
            this.parcelCodeTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.parcelCodeTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parcelCodeTB.Location = new System.Drawing.Point(139, 86);
            this.parcelCodeTB.Name = "parcelCodeTB";
            this.parcelCodeTB.ReadOnly = true;
            this.parcelCodeTB.Size = new System.Drawing.Size(98, 23);
            this.parcelCodeTB.TabIndex = 81;
            this.parcelCodeTB.Text = "12345678";
            // 
            // parcelNameLabel
            // 
            this.parcelNameLabel.AutoSize = true;
            this.parcelNameLabel.BackColor = System.Drawing.Color.White;
            this.parcelNameLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parcelNameLabel.Location = new System.Drawing.Point(23, 123);
            this.parcelNameLabel.Name = "parcelNameLabel";
            this.parcelNameLabel.Size = new System.Drawing.Size(124, 23);
            this.parcelNameLabel.TabIndex = 80;
            this.parcelNameLabel.Text = "Tên đơn hàng:";
            // 
            // parcelCodeLabel
            // 
            this.parcelCodeLabel.AutoSize = true;
            this.parcelCodeLabel.BackColor = System.Drawing.Color.White;
            this.parcelCodeLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parcelCodeLabel.Location = new System.Drawing.Point(23, 86);
            this.parcelCodeLabel.Name = "parcelCodeLabel";
            this.parcelCodeLabel.Size = new System.Drawing.Size(110, 23);
            this.parcelCodeLabel.TabIndex = 79;
            this.parcelCodeLabel.Text = "Mã vận đơn:";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Image = global::trackr_client_app.Properties.Resources.RatingStar;
            this.button1.Location = new System.Drawing.Point(27, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 49);
            this.button1.TabIndex = 83;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 84;
            this.label1.Text = "Đánh giá dịch vụ:";
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Image = global::trackr_client_app.Properties.Resources.RatingStar;
            this.button2.Location = new System.Drawing.Point(82, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 49);
            this.button2.TabIndex = 85;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Image = global::trackr_client_app.Properties.Resources.RatingStar;
            this.button3.Location = new System.Drawing.Point(137, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 49);
            this.button3.TabIndex = 86;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Image = global::trackr_client_app.Properties.Resources.RatingStar;
            this.button4.Location = new System.Drawing.Point(192, 186);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 49);
            this.button4.TabIndex = 87;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Image = global::trackr_client_app.Properties.Resources.RatingStar;
            this.button5.Location = new System.Drawing.Point(247, 186);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 49);
            this.button5.TabIndex = 88;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "RatingStar.png");
            this.imageList1.Images.SetKeyName(1, "RatingStar_Fill.png");
            // 
            // CustomerReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerReview";
            this.Text = "Trackr - Đánh giá dịch vụ giao hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button reviewBtn;
        private System.Windows.Forms.TextBox parcelNameTB;
        private System.Windows.Forms.TextBox parcelCodeTB;
        private System.Windows.Forms.Label parcelNameLabel;
        private System.Windows.Forms.Label parcelCodeLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
    }
}