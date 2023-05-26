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
            this.parcelDetails1 = new trackr_client_app.ParcelDetails();
            this.SuspendLayout();
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
            this.ClientSize = new System.Drawing.Size(1104, 577);
            this.Controls.Add(this.parcelDetails1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerParcelView";
            this.Text = "Trackr - Parcel Details";
            this.Load += new System.EventHandler(this.CustomerParcelView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ParcelDetails parcelDetails1;
    }
}