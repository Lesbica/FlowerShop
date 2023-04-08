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
        private User user;
        private BlueFlower blueFlower;
        public podsobka(User user, BlueFlower blueFlower)
        {
            InitializeComponent();
            this.user = user;
            this.blueFlower = blueFlower;
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

            label2.BackColor = Color.Transparent;
            label2.Parent = pictureBox3;
            BlueFlowerGrow.Interval = blueFlower.Ripening_time/3;
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
            if (!pictureBox11.Visible && !pictureBox13.Visible) {
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
            if (pictureBox13.Image.Equals(blueFlower.Images[0]))
            {
                pictureBox13.Image = blueFlower.Images[1];
            }
            else
            {
                pictureBox13.Image = blueFlower.Images[2];
                BlueFlowerGrow.Stop();
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Seeds seeds = new Seeds(user);
            seeds.ShowDialog();
            if (seeds.IsBlueSeedsPictureBoxClicked)
            {
                pictureBox13.Visible = true;
                pictureBox13.Image = blueFlower.Images[0];
                BlueFlowerGrow.Start();
            }
            pictureBox11.Visible = false;
        }
    }
}
