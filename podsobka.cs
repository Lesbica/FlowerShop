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
        public BlueFlower blueFlower;
        public podsobka()
        {
            InitializeComponent();
            blueFlower = new BlueFlower();
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
            BlueFlowerGrow.Interval = blueFlower.GetRipening_Time()/3;
            pictureBox13.Location = new Point(583, 495);
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

        private void BlueFlowerGrow_Tick(object sender, EventArgs e)
        {
            pictureBox13.Visible = true;
            if(BlueFlowerGrow.Interval == blueFlower.ripening_time)
            {
                BlueFlowerGrow.Stop();
            }

            if (pictureBox13.Image.Equals(blueFlower.images[0]))
            {
                pictureBox13.Image = blueFlower.images[1];
            }
            else
            {
                pictureBox13.Image = blueFlower.images[2];
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Seeds seeds = new Seeds();
            seeds.ShowDialog();
            pictureBox11.Visible = false;
        }
    }
}
