using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShop
{
    public partial class podsobka : Form
    {
        public podsobka()
        {
            InitializeComponent();
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                Control control = this.Controls[i];

                if (this.Controls[i] is PictureBox)
                {
                    this.Controls[i].BackColor = Color.Transparent;
                }
            }
            label1.BackColor = Color.Transparent;
            label1.Parent = pictureBox2;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (!pictureBox11.Visible) {
                pictureBox11.Visible = true;
            }
            else
            {
                pictureBox11.Visible = false;
            }
            
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (!pictureBox12.Visible)
            {
                pictureBox12.Visible = true;
            }
            else
            {
                pictureBox12.Visible = false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Settings settings1 = new Settings();
            settings1.ShowDialog();
        }
    }
}
