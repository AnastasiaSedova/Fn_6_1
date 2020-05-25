using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Фоновая_6_1
{
    public partial class BtnForm : Form
    {
        public BtnForm()
        {
            InitializeComponent();
        }

        private void BtnForm_Load(object sender, EventArgs e)
        {
            A.BackColor = Color.Coral;
            B.BackColor = Color.BlueViolet;
            C.BackColor = Color.Gold;
            A.ForeColor = Color.BlueViolet;
            B.ForeColor = Color.White;
            C.ForeColor = Color.Black;
            A.Width = 100;
            A.Height = 100;
            B.Width = 100;
            B.Height = 100;
            C.Width = 100;
            C.Height = 100;
            A.Text = "A";
            B.Text = "B";
            C.Text = "C";
        }

        private void A_Click(object sender, EventArgs e)
        {
            if (B.Top >= 6)
                B.Top -= 6;
            else
            {
                B.Top -= (ClientSize.Height - B.Top - B.Height);
                B.Top = ClientSize.Height - B.Height;
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            if (ClientSize.Height - B.Top > 6 + B.Height)
                B.Top += 6;
            else if (ClientSize.Height - B.Top > B.Height)
            {
                B.Top += (ClientSize.Height - B.Height - B.Top);
            }
        }
    }
}
