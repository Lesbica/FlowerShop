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
    public partial class Shop : Form
    {
        private User user = new User();
        private BlueFlower blueFlower = new BlueFlower();
        private PurpleFlower purpleFlower = new PurpleFlower();
        private RedFlower redFlower = new RedFlower();

        public Shop()
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
            label1.Parent = pictureBox5;
            label1.Text += user.Money;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<podsobka>().Any())
            {
                podsobka podsobka1 = new podsobka(user, blueFlower, purpleFlower, redFlower);
                podsobka1.Show();
            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Settings settings1 = new Settings();
            settings1.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            inventar inventar = new inventar(user);
            inventar.ShowDialog();
        }
    }
}
