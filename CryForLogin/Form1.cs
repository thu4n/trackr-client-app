using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;

namespace CryForLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string ComputeSHA256(string s)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Cần chuyển đổi string sang dạng byte khi Hash
                byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(s));
                // Chuyển đổi chuỗi vừa hash sang dạng string để dễ sử dụng
                return BitConverter.ToString(hashValue).Replace("-", "").ToLower();
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == String.Empty)
            {
                MessageBox.Show("Giá trị rỗng", "Lỗi");
                return;
            }
            if (textBox2.Text == String.Empty)
            {
                MessageBox.Show("Giá trị rỗng", "Lỗi");
                return;
            }
            richTextBox1.Text = String.Empty;
            string padding = "@@@!0Di3m***";
            string hash = ComputeSHA256(textBox1.Text+padding);
            richTextBox1.Text += hash;
            string hash2 = ComputeSHA256(textBox2.Text+padding);
            richTextBox1.Text += "\n" + hash2;
            if(hash == hash2)
            {
                richTextBox1.Text += "\nLogin Success";
            }else
            {
                richTextBox1.Text += "\nLogin Failed";
            }
        }
    }
}
