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
        private RedFlower redFlower;
        private byte FlowerNumber13;
        private byte FlowerNumber14;

        public podsobka(User user, BlueFlower blueFlower, PurpleFlower purpleFlower, RedFlower redFlower)
        {
            InitializeComponent();
            this.user = user;
            this.blueFlower = blueFlower;
            this.purpleFlower = purpleFlower;
            this.redFlower = redFlower;
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
            if (!pictureBox12.Visible && !pictureBox14.Visible)
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
            switch (FlowerNumber13)
            {
                case 1:
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
                        break;
                    }
                case 2:
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
                        break;
                    }
                case 3:
                    {
                        if (pictureBox13.Image.Equals(redFlower.Images[0]))
                        {
                            pictureBox13.Location = new Point(pictureBox9.Location.X - 30, pictureBox9.Location.Y - 130);
                            pictureBox13.Image = redFlower.Images[1];
                        }
                        else
                        {
                            pictureBox13.Location = new Point(pictureBox9.Location.X - 85, pictureBox9.Location.Y - 230);
                            pictureBox13.Image = redFlower.Images[2];
                            VedroFirst.Stop();
                        }
                        break;
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
                FlowerNumber13 = 1;
                VedroFirst.Start();
            }
            else if (seeds.IsPurpleSeedsPictureBoxClicked)
            {
                pictureBox13.Visible = true;
                VedroFirst.Interval = purpleFlower.Ripening_time / 3;
                pictureBox13.Image = purpleFlower.Images[0];
                pictureBox13.Location = new Point(pictureBox9.Location.X - 10, pictureBox9.Location.Y - 60);
                FlowerNumber13 = 2;
                VedroFirst.Start();
            }
            else if(seeds.IsRedSeedsPictureBoxClicked)
            {
                pictureBox13.Visible = true;
                VedroFirst.Interval = redFlower.Ripening_time / 3;
                pictureBox13.Image = redFlower.Images[0];
                pictureBox13.Location = new Point(pictureBox9.Location.X -20, pictureBox9.Location.Y -100);
                FlowerNumber13 = 3;
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
                FlowerNumber14 = 1;
                VedroSecond.Start();
            }
            else if(seeds.IsPurpleSeedsPictureBoxClicked)
            {
                VedroSecond.Interval = purpleFlower.Ripening_time / 3;
                pictureBox14.Visible = true;
                pictureBox14.Image = purpleFlower.Images[0];
                pictureBox14.Location = new Point(pictureBox10.Location.X - 10, pictureBox10.Location.Y - 60);
                FlowerNumber14 = 2;
                VedroSecond.Start();
            }
            else if (seeds.IsRedSeedsPictureBoxClicked)
            {
                pictureBox14.Visible = true;
                VedroSecond.Interval = redFlower.Ripening_time / 3;
                pictureBox14.Image = redFlower.Images[0];
                pictureBox14.Location = new Point(pictureBox10.Location.X - 20, pictureBox10.Location.Y - 100);
                FlowerNumber14 = 3;
                VedroSecond.Start();
            }
            pictureBox12.Visible = false;
        }

        private void VedroSecond_Tick(object sender, EventArgs e)
        {
            switch (FlowerNumber14)
            {
                case 1:
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
                        break;
                    }
                case 2:
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
                        break;
                    }
                case 3:
                    {
                        if (pictureBox14.Image.Equals(redFlower.Images[0]))
                        {
                            pictureBox14.Location = new Point(pictureBox10.Location.X - 30, pictureBox10.Location.Y - 130);
                            pictureBox14.Image = redFlower.Images[1];
                        }
                        else
                        {
                            pictureBox14.Location = new Point(pictureBox10.Location.X - 85, pictureBox10.Location.Y - 230);
                            pictureBox14.Image = redFlower.Images[2];
                            VedroSecond.Stop();
                        }
                        break;
                    }
            }
        }
    }
}
