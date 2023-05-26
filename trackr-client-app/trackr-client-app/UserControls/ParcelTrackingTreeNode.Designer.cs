namespace trackr_client_app.UserControls
{
    partial class ParcelTrackingTreeNode
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
            this.circleLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // circleLabel
            // 
            this.circleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circleLabel.AutoSize = true;
            this.circleLabel.BackColor = System.Drawing.Color.Transparent;
            this.circleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.circleLabel.Location = new System.Drawing.Point(355, 26);
            this.circleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.circleLabel.Name = "circleLabel";
            this.circleLabel.Size = new System.Drawing.Size(51, 36);
            this.circleLabel.TabIndex = 0;
            this.circleLabel.Text = "⚫";
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(427, 30);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(147, 28);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Đã đến đâu đó";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "27/05/2023";
            // 
            // ParcelTrackingTreeNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.circleLabel);
            this.Name = "ParcelTrackingTreeNode";
            this.Size = new System.Drawing.Size(780, 93);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ParcelTrackingTreeNode_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label circleLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label1;
    }
}
