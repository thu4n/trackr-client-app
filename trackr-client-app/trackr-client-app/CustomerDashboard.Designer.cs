namespace trackr_client_app
{
    partial class CustomerDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboard));
            this.titleLabel = new System.Windows.Forms.Label();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.parcelGridView = new System.Windows.Forms.DataGridView();
            this.sttColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.parcelGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.titleLabel.Location = new System.Drawing.Point(276, 77);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(465, 62);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Danh sách đơn hàng";
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTB.Location = new System.Drawing.Point(287, 152);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(436, 30);
            this.searchTB.TabIndex = 12;
            // 
            // searchBtn
            // 
            this.searchBtn.BackgroundImage = global::trackr_client_app.Properties.Resources.search_icon;
            this.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(729, 152);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(49, 30);
            this.searchBtn.TabIndex = 13;
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(115, 155);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(166, 23);
            this.searchLabel.TabIndex = 14;
            this.searchLabel.Text = "Tra cứu mã vận đơn:";
            // 
            // parcelGridView
            // 
            this.parcelGridView.AllowUserToAddRows = false;
            this.parcelGridView.AllowUserToDeleteRows = false;
            this.parcelGridView.AllowUserToResizeColumns = false;
            this.parcelGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.parcelGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.parcelGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.parcelGridView.ColumnHeadersHeight = 30;
            this.parcelGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.parcelGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttColumn,
            this.codeColumn,
            this.nameColumn,
            this.orderDateColumn,
            this.statusColumn});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.parcelGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.parcelGridView.EnableHeadersVisualStyles = false;
            this.parcelGridView.Location = new System.Drawing.Point(66, 202);
            this.parcelGridView.Name = "parcelGridView";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.parcelGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.parcelGridView.RowHeadersWidth = 51;
            this.parcelGridView.RowTemplate.Height = 24;
            this.parcelGridView.Size = new System.Drawing.Size(904, 363);
            this.parcelGridView.TabIndex = 15;
            // 
            // sttColumn
            // 
            this.sttColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sttColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.sttColumn.HeaderText = "STT";
            this.sttColumn.MinimumWidth = 6;
            this.sttColumn.Name = "sttColumn";
            this.sttColumn.ReadOnly = true;
            this.sttColumn.Width = 60;
            // 
            // codeColumn
            // 
            this.codeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.codeColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.codeColumn.HeaderText = "Mã vận đơn";
            this.codeColumn.MinimumWidth = 6;
            this.codeColumn.Name = "codeColumn";
            this.codeColumn.ReadOnly = true;
            this.codeColumn.Width = 110;
            // 
            // nameColumn
            // 
            this.nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameColumn.HeaderText = "Tên đơn hàng";
            this.nameColumn.MinimumWidth = 6;
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // orderDateColumn
            // 
            this.orderDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.orderDateColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.orderDateColumn.HeaderText = "Ngày đặt hàng";
            this.orderDateColumn.MinimumWidth = 6;
            this.orderDateColumn.Name = "orderDateColumn";
            this.orderDateColumn.ReadOnly = true;
            this.orderDateColumn.Width = 128;
            // 
            // statusColumn
            // 
            this.statusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.statusColumn.HeaderText = "Trạng thái";
            this.statusColumn.MinimumWidth = 6;
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.ReadOnly = true;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(866, 24);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(104, 28);
            this.usernameLabel.TabIndex = 16;
            this.usernameLabel.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::trackr_client_app.Properties.Resources.logoSmall;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = global::trackr_client_app.Properties.Resources.logoSmall;
            this.pictureBox1.Location = new System.Drawing.Point(820, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 577);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.parcelGridView);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerDashboard";
            this.Text = "Trackr - Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerDashboard_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.parcelGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.DataGridView parcelGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}