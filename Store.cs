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
    public partial class Store : Form
    {

        User user;
        public Store(User user)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.user = user;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(user.Money >= Convert.ToInt32(button3.Text))
            {
                user.RedSeeds += 5;
                user.Money -= Convert.ToUInt32(button3.Text);
            }
            else
            {
                MessageBox.Show("Not enough money");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (user.Money >= Convert.ToInt32(button2.Text))
            {
                user.PurpleSeeds += 5;
                user.Money -= Convert.ToUInt32(button2.Text);
            }
            else
            {
                MessageBox.Show("Not enough money");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user.Money >= Convert.ToInt32(button1.Text))
            {
                user.BlueSeeds += 5;
                user.Money -= Convert.ToUInt32(button1.Text);
            }
            else
            {
                MessageBox.Show("Not enough money");
            }
        }
    }
}
