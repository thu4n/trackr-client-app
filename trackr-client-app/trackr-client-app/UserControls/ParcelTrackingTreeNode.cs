using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trackr_client_app.UserControls
{
    public partial class ParcelTrackingTreeNode : UserControl
    {
        public ParcelTrackingTreeNode()
        {
            InitializeComponent();
        }

        private void CreateCirlce(Graphics g, Pen pen, Brush brush,float centerX, float centerY, float radius)
        {
            g.DrawEllipse(pen, centerX - radius, centerY - radius, radius + radius, radius + radius);
            g.FillEllipse(brush, centerX - radius, centerY - radius, radius + radius, radius + radius);
        }

        private void ParcelTrackingTreeNode_Paint(object sender, PaintEventArgs e)
        {
            Color green = Color.FromArgb(255, 0, 255, 0);
            Pen greenPen = new Pen(green);
            greenPen.Width = 5;
            e.Graphics.DrawEllipse(greenPen, 400, 150, 400, 400);
        }
    }
}
