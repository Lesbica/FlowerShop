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
        private PurpleFlower purpleFlower;
        private bool IsBluePictureClicked13 = false;
        private bool IsBluePictureClicked14 = false;
        private bool IsPurplePictureClicked13 = false;
        private bool IsPurplePictureClicked14 = false;
        private bool IsRedPictureClicked13 = false;
        private bool IsRedPictureClicked14 = false;

        public podsobka(User user, BlueFlower blueFlower, PurpleFlower purpleFlower)
        {
            InitializeComponent();
            this.user = user;
            this.blueFlower = blueFlower;
            this.purpleFlower = purpleFlower;
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

        private void VedroFirst_Tick(object sender, EventArgs e)
        {
            if (IsBluePictureClicked13)
            {
                if (pictureBox13.Image.Equals(blueFlower.Images[0]))
                {
                    pictureBox13.Location = new Point(pictureBox9.Location.X + 10, pictureBox9.Location.Y - 120);
                    pictureBox13.Image = blueFlower.Images[1];
                }
                else
                {
                    pictureBox13.Location = new Point(pictureBox9.Location.X - 35, pictureBox9.Location.Y - 295);
                    pictureBox13.Image = blueFlower.Images[2];
                    VedroFirst.Stop();
                }
            }
            else if (IsPurplePictureClicked13)
            {
                if (pictureBox13.Image.Equals(purpleFlower.Images[0]))
                {
                    pictureBox13.Location = new Point(pictureBox9.Location.X - 20, pictureBox9.Location.Y - 130);
                    pictureBox13.Image = purpleFlower.Images[1];
                }
                else
                {
                    pictureBox13.Location = new Point(pictureBox9.Location.X - 45, pictureBox9.Location.Y - 270);
                    pictureBox13.Image = purpleFlower.Images[2];
                    VedroFirst.Stop();
                }
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Seeds seeds = new Seeds(user);
            seeds.ShowDialog();
            if (seeds.IsBlueSeedsPictureBoxClicked)
            {
                pictureBox13.Visible = true;
                VedroFirst.Interval = blueFlower.Ripening_time / 3;
                pictureBox13.Image = blueFlower.Images[0];
                pictureBox13.Location = new Point(pictureBox9.Location.X - 10, pictureBox9.Location.Y - 55);
                IsBluePictureClicked13 = true;
                VedroFirst.Start();
            }
            else if (seeds.IsPurpleSeedsPictureBoxClicked)
            {
                pictureBox13.Visible = true;
                VedroFirst.Interval = purpleFlower.Ripening_time / 3;
                pictureBox13.Image = purpleFlower.Images[0];
                pictureBox13.Location = new Point(pictureBox9.Location.X - 10, pictureBox9.Location.Y - 60);
                IsPurplePictureClicked13 = true;
                VedroFirst.Start();
            }
            pictureBox11.Visible = false;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Seeds seeds = new Seeds(user);
            seeds.ShowDialog();
            if (seeds.IsBlueSeedsPictureBoxClicked)
            {
                VedroSecond.Interval = blueFlower.Ripening_time / 3;
                pictureBox14.Visible = true;
                pictureBox14.Image = blueFlower.Images[0];
                pictureBox14.Location = new Point(pictureBox10.Location.X - 10, pictureBox10.Location.Y - 55);
                IsBluePictureClicked14 = true;
                VedroSecond.Start();
            }
            else if(seeds.IsPurpleSeedsPictureBoxClicked)
            {
                VedroSecond.Interval = purpleFlower.Ripening_time / 3;
                pictureBox14.Visible = true;
                pictureBox14.Image = purpleFlower.Images[0];
                pictureBox14.Location = new Point(pictureBox10.Location.X - 10, pictureBox10.Location.Y - 60);
                IsPurplePictureClicked14 = true;
                VedroSecond.Start();
            }
            pictureBox12.Visible = false;
        }

        private void VedroSecond_Tick(object sender, EventArgs e)
        {
            if (IsBluePictureClicked14)
            {
                if (pictureBox14.Image.Equals(blueFlower.Images[0]))
                {
                    pictureBox14.Location = new Point(pictureBox10.Location.X + 10, pictureBox10.Location.Y - 120);
                    pictureBox14.Image = blueFlower.Images[1];
                }
                else
                {
                    pictureBox14.Location = new Point(pictureBox10.Location.X - 35, pictureBox10.Location.Y - 295);
                    pictureBox14.Image = blueFlower.Images[2];
                    VedroSecond.Stop();
                }
            }else if (IsPurplePictureClicked14)
            {
                if (pictureBox14.Image.Equals(purpleFlower.Images[0]))
                {
                    pictureBox14.Location = new Point(pictureBox10.Location.X - 20, pictureBox10.Location.Y - 130);
                    pictureBox14.Image = purpleFlower.Images[1];
                }
                else
                {
                    pictureBox14.Location = new Point(pictureBox10.Location.X - 45, pictureBox10.Location.Y - 270);
                    pictureBox14.Image = purpleFlower.Images[2];
                    VedroSecond.Stop();
                }
            }
        }
    }
}
