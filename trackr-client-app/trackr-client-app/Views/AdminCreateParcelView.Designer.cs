namespace trackr_client_app.Views
{
    partial class AdminCreateParcelView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCreateParcelView));
            this.uploadBtn = new System.Windows.Forms.Button();
            this.imgPathTB = new System.Windows.Forms.TextBox();
            this.realUploadBtn = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.noteLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.cusCodeBox = new System.Windows.Forms.ComboBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.noteTB = new System.Windows.Forms.TextBox();
            this.dateTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.parcelSample = new System.Windows.Forms.PictureBox();
            this.cusNameLabel = new System.Windows.Forms.Label();
            this.cusNameTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.parcelSample)).BeginInit();
            this.SuspendLayout();
            // 
            // uploadBtn
            // 
            this.uploadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.uploadBtn.FlatAppearance.BorderSize = 0;
            this.uploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBtn.ForeColor = System.Drawing.Color.White;
            this.uploadBtn.Location = new System.Drawing.Point(524, 89);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(154, 33);
            this.uploadBtn.TabIndex = 26;
            this.uploadBtn.Text = "Chọn hình ảnh";
            this.uploadBtn.UseVisualStyleBackColor = false;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // imgPathTB
            // 
            this.imgPathTB.BackColor = System.Drawing.Color.White;
            this.imgPathTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgPathTB.Location = new System.Drawing.Point(86, 89);
            this.imgPathTB.Multiline = true;
            this.imgPathTB.Name = "imgPathTB";
            this.imgPathTB.ReadOnly = true;
            this.imgPathTB.Size = new System.Drawing.Size(421, 33);
            this.imgPathTB.TabIndex = 27;
            this.imgPathTB.WordWrap = false;
            // 
            // realUploadBtn
            // 
            this.realUploadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.realUploadBtn.FlatAppearance.BorderSize = 0;
            this.realUploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.realUploadBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realUploadBtn.ForeColor = System.Drawing.Color.White;
            this.realUploadBtn.Location = new System.Drawing.Point(86, 364);
            this.realUploadBtn.Name = "realUploadBtn";
            this.realUploadBtn.Size = new System.Drawing.Size(179, 33);
            this.realUploadBtn.TabIndex = 28;
            this.realUploadBtn.Text = "Xác nhận tạo";
            this.realUploadBtn.UseVisualStyleBackColor = false;
            this.realUploadBtn.Click += new System.EventHandler(this.realUploadBtn_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(82, 153);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(124, 23);
            this.nameLabel.TabIndex = 29;
            this.nameLabel.Text = "Tên đơn hàng:";
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLabel.Location = new System.Drawing.Point(82, 193);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(75, 23);
            this.noteLabel.TabIndex = 30;
            this.noteLabel.Text = "Ghi chú:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(82, 231);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(57, 23);
            this.dateLabel.TabIndex = 31;
            this.dateLabel.Text = "Ngày:";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(82, 272);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(137, 23);
            this.customerLabel.TabIndex = 32;
            this.customerLabel.Text = "Mã khách hàng:";
            // 
            // cusCodeBox
            // 
            this.cusCodeBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusCodeBox.FormattingEnabled = true;
            this.cusCodeBox.Location = new System.Drawing.Point(228, 272);
            this.cusCodeBox.Name = "cusCodeBox";
            this.cusCodeBox.Size = new System.Drawing.Size(279, 28);
            this.cusCodeBox.TabIndex = 33;
            this.cusCodeBox.SelectedValueChanged += new System.EventHandler(this.cusCodeBox_SelectedValueChanged);
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTB.Location = new System.Drawing.Point(228, 153);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(279, 27);
            this.nameTB.TabIndex = 34;
            // 
            // noteTB
            // 
            this.noteTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTB.Location = new System.Drawing.Point(228, 191);
            this.noteTB.Name = "noteTB";
            this.noteTB.Size = new System.Drawing.Size(279, 27);
            this.noteTB.TabIndex = 35;
            // 
            // dateTB
            // 
            this.dateTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTB.Location = new System.Drawing.Point(228, 231);
            this.dateTB.Name = "dateTB";
            this.dateTB.ReadOnly = true;
            this.dateTB.Size = new System.Drawing.Size(279, 27);
            this.dateTB.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 41);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tạo đơn hàng mới";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.White;
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.cancelBtn.FlatAppearance.BorderSize = 2;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.cancelBtn.Location = new System.Drawing.Point(328, 364);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(179, 33);
            this.cancelBtn.TabIndex = 71;
            this.cancelBtn.Text = "Hủy bỏ";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // parcelSample
            // 
            this.parcelSample.BackgroundImage = global::trackr_client_app.Properties.Resources.logo;
            this.parcelSample.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.parcelSample.Location = new System.Drawing.Point(524, 155);
            this.parcelSample.Name = "parcelSample";
            this.parcelSample.Size = new System.Drawing.Size(154, 142);
            this.parcelSample.TabIndex = 72;
            this.parcelSample.TabStop = false;
            // 
            // cusNameLabel
            // 
            this.cusNameLabel.AutoSize = true;
            this.cusNameLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusNameLabel.Location = new System.Drawing.Point(82, 316);
            this.cusNameLabel.Name = "cusNameLabel";
            this.cusNameLabel.Size = new System.Drawing.Size(139, 23);
            this.cusNameLabel.TabIndex = 73;
            this.cusNameLabel.Text = "Tên khách hàng:";
            // 
            // cusNameTB
            // 
            this.cusNameTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusNameTB.Location = new System.Drawing.Point(227, 314);
            this.cusNameTB.Name = "cusNameTB";
            this.cusNameTB.ReadOnly = true;
            this.cusNameTB.Size = new System.Drawing.Size(279, 27);
            this.cusNameTB.TabIndex = 74;
            // 
            // AdminCreateParcelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 478);
            this.Controls.Add(this.cusNameTB);
            this.Controls.Add(this.cusNameLabel);
            this.Controls.Add(this.parcelSample);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTB);
            this.Controls.Add(this.noteTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.cusCodeBox);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.realUploadBtn);
            this.Controls.Add(this.imgPathTB);
            this.Controls.Add(this.uploadBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminCreateParcelView";
            this.Text = "Trackr - Create Parcel";
            this.Load += new System.EventHandler(this.AdminCreateParcelView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parcelSample)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.TextBox imgPathTB;
        private System.Windows.Forms.Button realUploadBtn;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.ComboBox cusCodeBox;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox noteTB;
        private System.Windows.Forms.TextBox dateTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.PictureBox parcelSample;
        private System.Windows.Forms.Label cusNameLabel;
        private System.Windows.Forms.TextBox cusNameTB;
    }
}