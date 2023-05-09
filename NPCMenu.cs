using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FlowerShop
{
    public partial class NPCMenu : Form
    {

        private User user;
        private BlueFlower blueFlower;
        private PurpleFlower purpleFlower;
        private RedFlower redFlower;
        private NPC nPC;
        private List<string> labelValues = new List<string>();

        public NPCMenu(User user, BlueFlower blueFlower, PurpleFlower purpleFlower, RedFlower redFlower, NPC nPC)
        {
            InitializeComponent();
            this.user = user;
            this.blueFlower = blueFlower;
            this.purpleFlower = purpleFlower;
            this.redFlower = redFlower;
            this.nPC = nPC;
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                Control control = this.Controls[i];

                if (this.Controls[i] is PictureBox)
                {
                    this.Controls[i].BackColor = Color.Transparent;
                }
            }

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            if(user.Money >= 10)
            {
                user.Money -= 10;
            }

        }

        private void NPCMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Проверяем значение DialogResult
            if (this.DialogResult == DialogResult.Cancel)
            {
                // Сохраняем значения лейблов во временном хранилище
                labelValues.Clear();
                labelValues.Add(label5.Text);
                labelValues.Add(label4.Text);
                labelValues.Add(label3.Text);
                labelValues.Add(label2.Text);

                string filePath = @"textures\NPCData.txt";

                // Записываем значения в файл
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string value in labelValues)
                    {
                        writer.WriteLine(value);
                    }
                }

            }
            else
            {
                System.IO.File.WriteAllText(@"textures\NPCData.txt", string.Empty);

            }

        }

        private void NPCMenu_Load(object sender, EventArgs e)
        {
            string filePath = @"textures\NPCData.txt";
            FileInfo fileInfo = new FileInfo(filePath);
            if (fileInfo.Length == 0)
            {
                Random rand = new Random();
                int randomnumber = rand.Next(11);
                label5.Text = randomnumber.ToString();
                randomnumber = rand.Next(11);
                label4.Text = randomnumber.ToString();
                randomnumber = rand.Next(11);
                label3.Text = randomnumber.ToString();
                label1.Text = (Convert.ToInt32(label5.Text) * 12 + Convert.ToInt32(label4.Text) * 14 + Convert.ToInt32(label3.Text) * 15).ToString();
                label2.Text = nPC.RandomReplic();

            }
            else
            {
                using (StreamReader reader = new StreamReader(filePath))
                {

                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        labelValues.Add(line);
                    }
                }

                label5.Text = labelValues[0];
                label4.Text = labelValues[1];
                label3.Text = labelValues[2];
                label2.Text = labelValues[3];
                label1.Text = (Convert.ToInt32(label5.Text) * 12 + Convert.ToInt32(label4.Text) * 14 + Convert.ToInt32(label3.Text) * 15).ToString();

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (user.BlueFlower >= Convert.ToUInt32(label5.Text) && user.PurpleFlower >= Convert.ToUInt32(label4.Text) && user.RedFlower >= Convert.ToUInt32(label3.Text))
            {
                user.BlueFlower -= Convert.ToUInt32(label5.Text);
                user.PurpleFlower -= Convert.ToUInt32(label4.Text);
                user.RedFlower -= Convert.ToUInt32(label3.Text);
                user.Money += Convert.ToUInt32(label1.Text);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Not enough flower");
            }
        }
    }
}
