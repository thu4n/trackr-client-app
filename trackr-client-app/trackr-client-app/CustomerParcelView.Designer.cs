namespace trackr_client_app
{
    partial class CustomerParcelView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerParcelView));
            this.parcelTrackingTree1 = new trackr_client_app.UserControls.ParcelTrackingTree();
            this.parcelDetails1 = new trackr_client_app.ParcelDetails();
            this.SuspendLayout();
            // 
            // parcelTrackingTree1
            // 
            this.parcelTrackingTree1.BackColor = System.Drawing.Color.White;
            this.parcelTrackingTree1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parcelTrackingTree1.Location = new System.Drawing.Point(26, 336);
            this.parcelTrackingTree1.Name = "parcelTrackingTree1";
            this.parcelTrackingTree1.Size = new System.Drawing.Size(1052, 371);
            this.parcelTrackingTree1.TabIndex = 1;
            // 
            // parcelDetails1
            // 
            this.parcelDetails1.BackColor = System.Drawing.Color.White;
            this.parcelDetails1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parcelDetails1.Location = new System.Drawing.Point(26, 12);
            this.parcelDetails1.Name = "parcelDetails1";
            this.parcelDetails1.Size = new System.Drawing.Size(1052, 318);
            this.parcelDetails1.TabIndex = 0;
            // 
            // CustomerParcelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(2, 2);
            this.ClientSize = new System.Drawing.Size(1098, 494);
            this.Controls.Add(this.parcelTrackingTree1);
            this.Controls.Add(this.parcelDetails1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerParcelView";
            this.Text = "Trackr - Parcel Details";
            this.Load += new System.EventHandler(this.CustomerParcelView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ParcelDetails parcelDetails1;
        private UserControls.ParcelTrackingTree parcelTrackingTree1;
    }
}