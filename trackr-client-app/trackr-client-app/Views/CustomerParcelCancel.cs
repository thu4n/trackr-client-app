﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trackr_client_app.Views
{
    public partial class CustomerParcelCancel : Form
    {
        public CustomerParcelCancel()
        {
            InitializeComponent();
            reasonCancelParcelComboBox.Items.Add("Không thích mua nữa");
            reasonCancelParcelComboBox.Items.Add("Giá ở đây quá mắc");
            reasonCancelParcelComboBox.Items.Add("Dịch vụ này không ship đến chỗ tôi");
        }
    }
}
