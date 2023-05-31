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
            this.SuspendLayout();
            // 
            // uploadBtn
            // 
            this.uploadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.uploadBtn.FlatAppearance.BorderSize = 0;
            this.uploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBtn.ForeColor = System.Drawing.Color.White;
            this.uploadBtn.Location = new System.Drawing.Point(442, 53);
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
            this.imgPathTB.Size = new System.Drawing.Size(367, 33);
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
            this.realUploadBtn.Location = new System.Drawing.Point(69, 121);
            this.realUploadBtn.Name = "realUploadBtn";
            this.realUploadBtn.Size = new System.Drawing.Size(179, 33);
            this.realUploadBtn.TabIndex = 28;
            this.realUploadBtn.Text = "Upload";
            this.realUploadBtn.UseVisualStyleBackColor = false;
            this.realUploadBtn.Click += new System.EventHandler(this.realUploadBtn_Click);
            // 
            // AdminCreateParcelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 478);
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
    }
}