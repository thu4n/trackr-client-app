namespace trackr_client_app.Views
{
    partial class DeliveryParcelView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryParcelView));
            this.distanceLabel = new System.Windows.Forms.Label();
            this.routePanel = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.titleLabel2 = new System.Windows.Forms.Label();
            this.noteTB = new System.Windows.Forms.TextBox();
            this.noteLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.parcelNameLabel = new System.Windows.Forms.Label();
            this.parcelCodeLabel = new System.Windows.Forms.Label();
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.estimateDateLabel = new System.Windows.Forms.Label();
            this.estimateDateTB = new System.Windows.Forms.TextBox();
            this.statusTB = new System.Windows.Forms.TextBox();
            this.orderDateTB = new System.Windows.Forms.TextBox();
            this.parcelNameTB = new System.Windows.Forms.TextBox();
            this.parcelCodeTB = new System.Windows.Forms.TextBox();
            this.cusAddressLabel = new System.Windows.Forms.Label();
            this.cusPhoneLabel = new System.Windows.Forms.Label();
            this.cusNameLabel = new System.Windows.Forms.Label();
            this.cusCodeLabel = new System.Windows.Forms.Label();
            this.cusAddressTB = new System.Windows.Forms.TextBox();
            this.cusPhoneTB = new System.Windows.Forms.TextBox();
            this.cusNameTB = new System.Windows.Forms.TextBox();
            this.cusCodeTB = new System.Windows.Forms.TextBox();
            this.parcelImg = new System.Windows.Forms.PictureBox();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.infoLabel = new System.Windows.Forms.Label();
            this.yesBtn = new System.Windows.Forms.Button();
            this.timeTB = new System.Windows.Forms.TextBox();
            this.locationTB = new System.Windows.Forms.ComboBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.payBtn = new System.Windows.Forms.Button();
            this.routePanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parcelImg)).BeginInit();
            this.updatePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceLabel.Location = new System.Drawing.Point(316, 23);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(249, 23);
            this.distanceLabel.TabIndex = 44;
            this.distanceLabel.Text = "Tổng khoảng cách ước lượng:";
            // 
            // routePanel
            // 
            this.routePanel.BackColor = System.Drawing.Color.White;
            this.routePanel.Controls.Add(this.distanceLabel);
            this.routePanel.Controls.Add(this.treeView1);
            this.routePanel.Controls.Add(this.titleLabel2);
            this.routePanel.Location = new System.Drawing.Point(368, 332);
            this.routePanel.Name = "routePanel";
            this.routePanel.Size = new System.Drawing.Size(659, 369);
            this.routePanel.TabIndex = 64;
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Indent = 35;
            this.treeView1.ItemHeight = 50;
            this.treeView1.Location = new System.Drawing.Point(86, 52);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(570, 314);
            this.treeView1.TabIndex = 43;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "waiting.png");
            this.imageList1.Images.SetKeyName(1, "processed.png");
            this.imageList1.Images.SetKeyName(2, "check.png");
            this.imageList1.Images.SetKeyName(3, "datetime.png");
            // 
            // titleLabel2
            // 
            this.titleLabel2.AutoSize = true;
            this.titleLabel2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.titleLabel2.Location = new System.Drawing.Point(16, 11);
            this.titleLabel2.Name = "titleLabel2";
            this.titleLabel2.Size = new System.Drawing.Size(294, 38);
            this.titleLabel2.TabIndex = 41;
            this.titleLabel2.Text = "Hành trình đơn hàng";
            // 
            // noteTB
            // 
            this.noteTB.BackColor = System.Drawing.Color.White;
            this.noteTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTB.Location = new System.Drawing.Point(670, 226);
            this.noteTB.Multiline = true;
            this.noteTB.Name = "noteTB";
            this.noteTB.ReadOnly = true;
            this.noteTB.Size = new System.Drawing.Size(335, 47);
            this.noteTB.TabIndex = 45;
            this.noteTB.Text = "blah";
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.BackColor = System.Drawing.Color.White;
            this.noteLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLabel.Location = new System.Drawing.Point(594, 226);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(75, 23);
            this.noteLabel.TabIndex = 45;
            this.noteLabel.Text = "Ghi chú:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.White;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(238, 206);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(179, 23);
            this.statusLabel.TabIndex = 49;
            this.statusLabel.Text = "Trạng thái đơn hàng:";
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.BackColor = System.Drawing.Color.White;
            this.orderDateLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDateLabel.Location = new System.Drawing.Point(238, 169);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(134, 23);
            this.orderDateLabel.TabIndex = 48;
            this.orderDateLabel.Text = "Ngày đặt hàng:";
            // 
            // parcelNameLabel
            // 
            this.parcelNameLabel.AutoSize = true;
            this.parcelNameLabel.BackColor = System.Drawing.Color.White;
            this.parcelNameLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parcelNameLabel.Location = new System.Drawing.Point(238, 131);
            this.parcelNameLabel.Name = "parcelNameLabel";
            this.parcelNameLabel.Size = new System.Drawing.Size(124, 23);
            this.parcelNameLabel.TabIndex = 47;
            this.parcelNameLabel.Text = "Tên đơn hàng:";
            // 
            // parcelCodeLabel
            // 
            this.parcelCodeLabel.AutoSize = true;
            this.parcelCodeLabel.BackColor = System.Drawing.Color.White;
            this.parcelCodeLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parcelCodeLabel.Location = new System.Drawing.Point(238, 94);
            this.parcelCodeLabel.Name = "parcelCodeLabel";
            this.parcelCodeLabel.Size = new System.Drawing.Size(110, 23);
            this.parcelCodeLabel.TabIndex = 46;
            this.parcelCodeLabel.Text = "Mã vận đơn:";
            // 
            // titleLabel1
            // 
            this.titleLabel1.AutoSize = true;
            this.titleLabel1.BackColor = System.Drawing.Color.White;
            this.titleLabel1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.titleLabel1.Location = new System.Drawing.Point(28, 33);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(247, 38);
            this.titleLabel1.TabIndex = 45;
            this.titleLabel1.Text = "Chi tiết đơn hàng";
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.White;
            this.infoPanel.Controls.Add(this.priceTB);
            this.infoPanel.Controls.Add(this.priceLabel);
            this.infoPanel.Controls.Add(this.noteTB);
            this.infoPanel.Controls.Add(this.noteLabel);
            this.infoPanel.Controls.Add(this.estimateDateLabel);
            this.infoPanel.Controls.Add(this.estimateDateTB);
            this.infoPanel.Location = new System.Drawing.Point(12, 23);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(1015, 284);
            this.infoPanel.TabIndex = 63;
            // 
            // priceTB
            // 
            this.priceTB.BackColor = System.Drawing.Color.White;
            this.priceTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTB.Location = new System.Drawing.Point(725, 25);
            this.priceTB.Name = "priceTB";
            this.priceTB.ReadOnly = true;
            this.priceTB.Size = new System.Drawing.Size(98, 23);
            this.priceTB.TabIndex = 68;
            this.priceTB.Text = "12345678";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.BackColor = System.Drawing.Color.White;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(594, 25);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(125, 23);
            this.priceLabel.TabIndex = 67;
            this.priceLabel.Text = "Phí giao hàng:";
            // 
            // estimateDateLabel
            // 
            this.estimateDateLabel.AutoSize = true;
            this.estimateDateLabel.BackColor = System.Drawing.Color.White;
            this.estimateDateLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estimateDateLabel.Location = new System.Drawing.Point(226, 226);
            this.estimateDateLabel.Name = "estimateDateLabel";
            this.estimateDateLabel.Size = new System.Drawing.Size(167, 23);
            this.estimateDateLabel.TabIndex = 25;
            this.estimateDateLabel.Text = "Dự kiến giao trước:";
            // 
            // estimateDateTB
            // 
            this.estimateDateTB.BackColor = System.Drawing.Color.White;
            this.estimateDateTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.estimateDateTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estimateDateTB.Location = new System.Drawing.Point(399, 226);
            this.estimateDateTB.Name = "estimateDateTB";
            this.estimateDateTB.ReadOnly = true;
            this.estimateDateTB.Size = new System.Drawing.Size(175, 23);
            this.estimateDateTB.TabIndex = 34;
            this.estimateDateTB.Text = "01/06/2023";
            this.estimateDateTB.WordWrap = false;
            // 
            // statusTB
            // 
            this.statusTB.BackColor = System.Drawing.Color.White;
            this.statusTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTB.Location = new System.Drawing.Point(423, 206);
            this.statusTB.Name = "statusTB";
            this.statusTB.ReadOnly = true;
            this.statusTB.Size = new System.Drawing.Size(175, 23);
            this.statusTB.TabIndex = 57;
            this.statusTB.Text = "Đang chuẩn bị";
            this.statusTB.WordWrap = false;
            // 
            // orderDateTB
            // 
            this.orderDateTB.BackColor = System.Drawing.Color.White;
            this.orderDateTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderDateTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDateTB.Location = new System.Drawing.Point(378, 169);
            this.orderDateTB.Name = "orderDateTB";
            this.orderDateTB.ReadOnly = true;
            this.orderDateTB.Size = new System.Drawing.Size(175, 23);
            this.orderDateTB.TabIndex = 56;
            this.orderDateTB.Text = "26/05/2023";
            this.orderDateTB.WordWrap = false;
            // 
            // parcelNameTB
            // 
            this.parcelNameTB.BackColor = System.Drawing.Color.White;
            this.parcelNameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.parcelNameTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parcelNameTB.Location = new System.Drawing.Point(368, 131);
            this.parcelNameTB.Name = "parcelNameTB";
            this.parcelNameTB.ReadOnly = true;
            this.parcelNameTB.Size = new System.Drawing.Size(175, 23);
            this.parcelNameTB.TabIndex = 55;
            this.parcelNameTB.Text = "Random parcel name";
            this.parcelNameTB.WordWrap = false;
            // 
            // parcelCodeTB
            // 
            this.parcelCodeTB.BackColor = System.Drawing.Color.White;
            this.parcelCodeTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.parcelCodeTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parcelCodeTB.Location = new System.Drawing.Point(354, 94);
            this.parcelCodeTB.Name = "parcelCodeTB";
            this.parcelCodeTB.ReadOnly = true;
            this.parcelCodeTB.Size = new System.Drawing.Size(98, 23);
            this.parcelCodeTB.TabIndex = 54;
            this.parcelCodeTB.Text = "12345678";
            // 
            // cusAddressLabel
            // 
            this.cusAddressLabel.AutoSize = true;
            this.cusAddressLabel.BackColor = System.Drawing.Color.White;
            this.cusAddressLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusAddressLabel.Location = new System.Drawing.Point(606, 206);
            this.cusAddressLabel.Name = "cusAddressLabel";
            this.cusAddressLabel.Size = new System.Drawing.Size(70, 23);
            this.cusAddressLabel.TabIndex = 53;
            this.cusAddressLabel.Text = "Địa chỉ:";
            // 
            // cusPhoneLabel
            // 
            this.cusPhoneLabel.AutoSize = true;
            this.cusPhoneLabel.BackColor = System.Drawing.Color.White;
            this.cusPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusPhoneLabel.Location = new System.Drawing.Point(606, 169);
            this.cusPhoneLabel.Name = "cusPhoneLabel";
            this.cusPhoneLabel.Size = new System.Drawing.Size(48, 23);
            this.cusPhoneLabel.TabIndex = 52;
            this.cusPhoneLabel.Text = "SĐT:";
            // 
            // cusNameLabel
            // 
            this.cusNameLabel.AutoSize = true;
            this.cusNameLabel.BackColor = System.Drawing.Color.White;
            this.cusNameLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusNameLabel.Location = new System.Drawing.Point(606, 131);
            this.cusNameLabel.Name = "cusNameLabel";
            this.cusNameLabel.Size = new System.Drawing.Size(139, 23);
            this.cusNameLabel.TabIndex = 51;
            this.cusNameLabel.Text = "Tên khách hàng:";
            // 
            // cusCodeLabel
            // 
            this.cusCodeLabel.AutoSize = true;
            this.cusCodeLabel.BackColor = System.Drawing.Color.White;
            this.cusCodeLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusCodeLabel.Location = new System.Drawing.Point(606, 94);
            this.cusCodeLabel.Name = "cusCodeLabel";
            this.cusCodeLabel.Size = new System.Drawing.Size(137, 23);
            this.cusCodeLabel.TabIndex = 50;
            this.cusCodeLabel.Text = "Mã khách hàng:";
            // 
            // cusAddressTB
            // 
            this.cusAddressTB.BackColor = System.Drawing.Color.White;
            this.cusAddressTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cusAddressTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusAddressTB.Location = new System.Drawing.Point(682, 206);
            this.cusAddressTB.Multiline = true;
            this.cusAddressTB.Name = "cusAddressTB";
            this.cusAddressTB.ReadOnly = true;
            this.cusAddressTB.Size = new System.Drawing.Size(335, 47);
            this.cusAddressTB.TabIndex = 61;
            this.cusAddressTB.Text = "Ký túc xá khu A: Đường Tạ Quang Bửu, khu phố 6, phường Linh Trung, thành phố Thủ " +
    "Đức, Thành phố Hồ Chí Minh.";
            // 
            // cusPhoneTB
            // 
            this.cusPhoneTB.BackColor = System.Drawing.Color.White;
            this.cusPhoneTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cusPhoneTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusPhoneTB.Location = new System.Drawing.Point(660, 169);
            this.cusPhoneTB.Name = "cusPhoneTB";
            this.cusPhoneTB.ReadOnly = true;
            this.cusPhoneTB.Size = new System.Drawing.Size(196, 23);
            this.cusPhoneTB.TabIndex = 60;
            this.cusPhoneTB.Text = "0785987612";
            // 
            // cusNameTB
            // 
            this.cusNameTB.BackColor = System.Drawing.Color.White;
            this.cusNameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cusNameTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusNameTB.Location = new System.Drawing.Point(749, 131);
            this.cusNameTB.Name = "cusNameTB";
            this.cusNameTB.ReadOnly = true;
            this.cusNameTB.Size = new System.Drawing.Size(196, 23);
            this.cusNameTB.TabIndex = 59;
            this.cusNameTB.Text = "Tống Võ Anh Thuận";
            // 
            // cusCodeTB
            // 
            this.cusCodeTB.BackColor = System.Drawing.Color.White;
            this.cusCodeTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cusCodeTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusCodeTB.Location = new System.Drawing.Point(749, 94);
            this.cusCodeTB.Name = "cusCodeTB";
            this.cusCodeTB.ReadOnly = true;
            this.cusCodeTB.Size = new System.Drawing.Size(98, 23);
            this.cusCodeTB.TabIndex = 58;
            this.cusCodeTB.Text = "12345678";
            // 
            // parcelImg
            // 
            this.parcelImg.BackColor = System.Drawing.Color.Transparent;
            this.parcelImg.BackgroundImage = global::trackr_client_app.Properties.Resources.logoSmall;
            this.parcelImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.parcelImg.Location = new System.Drawing.Point(35, 93);
            this.parcelImg.Name = "parcelImg";
            this.parcelImg.Size = new System.Drawing.Size(172, 172);
            this.parcelImg.TabIndex = 62;
            this.parcelImg.TabStop = false;
            // 
            // updatePanel
            // 
            this.updatePanel.BackColor = System.Drawing.Color.White;
            this.updatePanel.Controls.Add(this.infoLabel);
            this.updatePanel.Controls.Add(this.yesBtn);
            this.updatePanel.Controls.Add(this.timeTB);
            this.updatePanel.Controls.Add(this.locationTB);
            this.updatePanel.Controls.Add(this.timeLabel);
            this.updatePanel.Controls.Add(this.locationLabel);
            this.updatePanel.Controls.Add(this.label1);
            this.updatePanel.Location = new System.Drawing.Point(12, 332);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(336, 224);
            this.updatePanel.TabIndex = 65;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.BackColor = System.Drawing.Color.White;
            this.infoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(19, 137);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(269, 20);
            this.infoLabel.TabIndex = 73;
            this.infoLabel.Text = "Lưu ý: Chỉ cập nhật khi đã đến địa điểm";
            // 
            // yesBtn
            // 
            this.yesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.yesBtn.FlatAppearance.BorderSize = 0;
            this.yesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesBtn.ForeColor = System.Drawing.Color.White;
            this.yesBtn.Location = new System.Drawing.Point(23, 171);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(273, 33);
            this.yesBtn.TabIndex = 72;
            this.yesBtn.Text = "Cập nhật";
            this.yesBtn.UseVisualStyleBackColor = false;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // timeTB
            // 
            this.timeTB.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTB.Location = new System.Drawing.Point(113, 100);
            this.timeTB.Name = "timeTB";
            this.timeTB.ReadOnly = true;
            this.timeTB.Size = new System.Drawing.Size(183, 25);
            this.timeTB.TabIndex = 69;
            // 
            // locationTB
            // 
            this.locationTB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locationTB.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationTB.FormattingEnabled = true;
            this.locationTB.ItemHeight = 17;
            this.locationTB.Location = new System.Drawing.Point(113, 61);
            this.locationTB.Name = "locationTB";
            this.locationTB.Size = new System.Drawing.Size(183, 25);
            this.locationTB.TabIndex = 68;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.White;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(19, 100);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(91, 23);
            this.timeLabel.TabIndex = 67;
            this.timeLabel.Text = "Thời gian:";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.BackColor = System.Drawing.Color.White;
            this.locationLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(19, 62);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(88, 23);
            this.locationLabel.TabIndex = 66;
            this.locationLabel.Text = "Địa điểm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 38);
            this.label1.TabIndex = 45;
            this.label1.Text = "Cập nhật hành trình";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.payBtn);
            this.panel1.Controls.Add(this.paymentLabel);
            this.panel1.Location = new System.Drawing.Point(13, 581);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 117);
            this.panel1.TabIndex = 66;
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.paymentLabel.Location = new System.Drawing.Point(7, 9);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(302, 38);
            this.paymentLabel.TabIndex = 74;
            this.paymentLabel.Text = "Thanh toán đơn hàng";
            // 
            // payBtn
            // 
            this.payBtn.BackColor = System.Drawing.Color.Gray;
            this.payBtn.FlatAppearance.BorderSize = 0;
            this.payBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payBtn.ForeColor = System.Drawing.Color.White;
            this.payBtn.Location = new System.Drawing.Point(35, 59);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(252, 33);
            this.payBtn.TabIndex = 77;
            this.payBtn.Text = "Thanh toán qua ZaloPay";
            this.payBtn.UseVisualStyleBackColor = false;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // DeliveryParcelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 725);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.updatePanel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.orderDateLabel);
            this.Controls.Add(this.parcelNameLabel);
            this.Controls.Add(this.parcelCodeLabel);
            this.Controls.Add(this.titleLabel1);
            this.Controls.Add(this.statusTB);
            this.Controls.Add(this.orderDateTB);
            this.Controls.Add(this.parcelNameTB);
            this.Controls.Add(this.parcelCodeTB);
            this.Controls.Add(this.cusAddressLabel);
            this.Controls.Add(this.cusPhoneLabel);
            this.Controls.Add(this.cusNameLabel);
            this.Controls.Add(this.cusCodeLabel);
            this.Controls.Add(this.parcelImg);
            this.Controls.Add(this.cusAddressTB);
            this.Controls.Add(this.cusPhoneTB);
            this.Controls.Add(this.cusNameTB);
            this.Controls.Add(this.cusCodeTB);
            this.Controls.Add(this.routePanel);
            this.Controls.Add(this.infoPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeliveryParcelView";
            this.Text = "Trackr - Cập nhật đơn hàng";
            this.Load += new System.EventHandler(this.DeliveryParcelView_Load);
            this.routePanel.ResumeLayout(false);
            this.routePanel.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parcelImg)).EndInit();
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Panel routePanel;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label titleLabel2;
        private System.Windows.Forms.TextBox noteTB;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.Label parcelNameLabel;
        private System.Windows.Forms.Label parcelCodeLabel;
        private System.Windows.Forms.Label titleLabel1;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label estimateDateLabel;
        private System.Windows.Forms.TextBox estimateDateTB;
        private System.Windows.Forms.TextBox statusTB;
        private System.Windows.Forms.TextBox orderDateTB;
        private System.Windows.Forms.TextBox parcelNameTB;
        private System.Windows.Forms.TextBox parcelCodeTB;
        private System.Windows.Forms.Label cusAddressLabel;
        private System.Windows.Forms.Label cusPhoneLabel;
        private System.Windows.Forms.Label cusNameLabel;
        private System.Windows.Forms.Label cusCodeLabel;
        private System.Windows.Forms.PictureBox parcelImg;
        private System.Windows.Forms.TextBox cusAddressTB;
        private System.Windows.Forms.TextBox cusPhoneTB;
        private System.Windows.Forms.TextBox cusNameTB;
        private System.Windows.Forms.TextBox cusCodeTB;
        private System.Windows.Forms.Panel updatePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.ComboBox locationTB;
        private System.Windows.Forms.TextBox timeTB;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button yesBtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.Button payBtn;
    }
}