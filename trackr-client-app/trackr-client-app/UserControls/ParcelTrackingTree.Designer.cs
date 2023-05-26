namespace trackr_client_app.UserControls
{
    partial class ParcelTrackingTree
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.parcelTrackingTreeNode1 = new trackr_client_app.UserControls.ParcelTrackingTreeNode();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.titleLabel.Location = new System.Drawing.Point(18, 27);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(294, 38);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Hành trình đơn hàng";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.Controls.Add(this.parcelTrackingTreeNode1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 68);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(780, 303);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // parcelTrackingTreeNode1
            // 
            this.parcelTrackingTreeNode1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.parcelTrackingTreeNode1.BackColor = System.Drawing.Color.White;
            this.parcelTrackingTreeNode1.Location = new System.Drawing.Point(3, 207);
            this.parcelTrackingTreeNode1.Name = "parcelTrackingTreeNode1";
            this.parcelTrackingTreeNode1.Size = new System.Drawing.Size(780, 93);
            this.parcelTrackingTreeNode1.TabIndex = 0;
            // 
            // ParcelTrackingTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ParcelTrackingTree";
            this.Size = new System.Drawing.Size(780, 371);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ParcelTrackingTreeNode parcelTrackingTreeNode1;
    }
}
