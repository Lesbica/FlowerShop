using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShop
{
    public partial class Seeds : Form
    {
        private User user;
        public bool IsBlueSeedsPictureBoxClicked { get; set; } = false;
        public bool IsPurpleSeedsPictureBoxClicked { get; set; } = false;
        public bool IsRedSeedsPictureBoxClicked { get; set; } = false;

        public Seeds(User user)
        {
            InitializeComponent();
            this.user = user;

            label1.BackColor = Color.Transparent;
            label1.Text = user.BlueSeeds.ToString();
            label1.Parent = pictureBox1;

            label2.BackColor = Color.Transparent;
            label2.Text = user.PurpleSeeds.ToString();
            label2.Location = new Point(pictureBox2.Location.X+80, pictureBox2.Location.Y+95);

            label3.BackColor = Color.Transparent;
            label3.Text = user.RedSeeds.ToString();
            label3.Location = new Point(pictureBox3.Location.X + 80, pictureBox3.Location.Y + 95);

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void Seeds_Deactivate(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(user.BlueSeeds == 0)
            {
                MessageBox.Show("Not enough seeds");
            }
            else
            {
                user.BlueSeeds -= 1;
                IsBlueSeedsPictureBoxClicked = true;
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (user.PurpleSeeds == 0)
            {
                MessageBox.Show("Not enough seeds");
            }
            else
            {
                user.PurpleSeeds -= 1;
                IsPurpleSeedsPictureBoxClicked = true;
                this.Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (user.RedSeeds == 0)
            {
                MessageBox.Show("Not enough seeds");
            }
            else
            {
                user.RedSeeds -= 1;
                IsRedSeedsPictureBoxClicked = true;
                this.Close();
            }
        }
    }
}
