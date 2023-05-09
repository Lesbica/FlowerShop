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
    public partial class Shop : Form
    {
        private User user = new User();
        private BlueFlower blueFlower = new BlueFlower();
        private PurpleFlower purpleFlower = new PurpleFlower();
        private RedFlower redFlower = new RedFlower();
        private NPC nPC = new NPC();

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

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<podsobka>().Any())
            {
                podsobka podsobka1 = new podsobka(user, blueFlower, purpleFlower, redFlower);
                podsobka1.ShowDialog();
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

        private void Shop_Activated(object sender, EventArgs e)
        {
            label1.Text = user.Money.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Store store = new Store(user);
            store.ShowDialog();
        }

        private void NPCTimer_Tick(object sender, EventArgs e)
        {
            pictureBox8.BackgroundImage = nPC.RandomNpc();
            pictureBox8.Enabled = true;
            NPCTimer.Stop();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            NPCTimer.Stop();
            NPCMenu nPCMenu = new NPCMenu(user, blueFlower, purpleFlower, redFlower, nPC);
            nPCMenu.ShowDialog();

            if (nPCMenu.DialogResult != DialogResult.Cancel)
            {
                pictureBox8.BackgroundImage = null;
                pictureBox8.Enabled = false;
                timer2.Stop();
                timer2.Start();
                NPCTimer.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox8.BackgroundImage = null;
            pictureBox8.Enabled = false;
            NPCTimer.Start();
        }
    }
}
