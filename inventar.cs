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
    public partial class inventar : Form
    {
        private User user;

        public inventar(User user)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;

            this.user = user;
            label4.Text = user.BlueFlower.ToString();
            label5.Text = user.PurpleFlower.ToString();
            label3.Text = user.RedFlower.ToString();
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = true;
            label1.Visible = true;
            label2.Visible = false;
            this.BackgroundImage = Image.FromFile(@"textures\menuInventarFlower.jpg");
            label4.Text = user.BlueFlower.ToString();
            label5.Text = user.PurpleFlower.ToString();
            label3.Text = user.RedFlower.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = true; 
            pictureBox2.Enabled = false;
            label1.Visible = false;
            label2.Visible = true;
            this.BackgroundImage = Image.FromFile(@"textures\menuInventarSeeds.jpg");
            label4.Text = user.BlueSeeds.ToString();
            label5.Text = user.PurpleSeeds.ToString();
            label3.Text = user.RedSeeds.ToString();
        }
    }
}
