﻿namespace trackr_client_app.Views
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
            this.cusTB = new System.Windows.Forms.ComboBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.noteTB = new System.Windows.Forms.TextBox();
            this.dateTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uploadBtn
            // 
            this.uploadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.uploadBtn.FlatAppearance.BorderSize = 0;
            this.uploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBtn.ForeColor = System.Drawing.Color.White;
            this.uploadBtn.Location = new System.Drawing.Point(507, 53);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(179, 33);
            this.uploadBtn.TabIndex = 26;
            this.uploadBtn.Text = "Chọn hình ảnh";
            this.uploadBtn.UseVisualStyleBackColor = false;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // imgPathTB
            // 
            this.imgPathTB.BackColor = System.Drawing.Color.White;
            this.imgPathTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgPathTB.Location = new System.Drawing.Point(69, 53);
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
            this.realUploadBtn.Location = new System.Drawing.Point(69, 297);
            this.realUploadBtn.Name = "realUploadBtn";
            this.realUploadBtn.Size = new System.Drawing.Size(179, 33);
            this.realUploadBtn.TabIndex = 28;
            this.realUploadBtn.Text = "Upload";
            this.realUploadBtn.UseVisualStyleBackColor = false;
            this.realUploadBtn.Click += new System.EventHandler(this.realUploadBtn_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(65, 117);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(124, 23);
            this.nameLabel.TabIndex = 29;
            this.nameLabel.Text = "Tên đơn hàng:";
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLabel.Location = new System.Drawing.Point(65, 157);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(75, 23);
            this.noteLabel.TabIndex = 30;
            this.noteLabel.Text = "Ghi chú:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(65, 195);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(57, 23);
            this.dateLabel.TabIndex = 31;
            this.dateLabel.Text = "Ngày:";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(65, 236);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(137, 23);
            this.customerLabel.TabIndex = 32;
            this.customerLabel.Text = "Mã khách hàng:";
            // 
            // cusTB
            // 
            this.cusTB.FormattingEnabled = true;
            this.cusTB.Items.AddRange(new object[] {
            "111",
            "222",
            "333"});
            this.cusTB.Location = new System.Drawing.Point(211, 236);
            this.cusTB.Name = "cusTB";
            this.cusTB.Size = new System.Drawing.Size(279, 25);
            this.cusTB.TabIndex = 33;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(211, 117);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(279, 25);
            this.nameTB.TabIndex = 34;
            // 
            // noteTB
            // 
            this.noteTB.Location = new System.Drawing.Point(211, 155);
            this.noteTB.Name = "noteTB";
            this.noteTB.Size = new System.Drawing.Size(279, 25);
            this.noteTB.TabIndex = 35;
            // 
            // dateTB
            // 
            this.dateTB.Location = new System.Drawing.Point(211, 195);
            this.dateTB.Name = "dateTB";
            this.dateTB.Size = new System.Drawing.Size(279, 25);
            this.dateTB.TabIndex = 36;
            // 
            // AdminCreateParcelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 478);
            this.Controls.Add(this.dateTB);
            this.Controls.Add(this.noteTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.cusTB);
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
        private System.Windows.Forms.ComboBox cusTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox noteTB;
        private System.Windows.Forms.TextBox dateTB;
    }
}