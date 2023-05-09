using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FlowerShop
{
    public class NPC
    {
        private Image[] NPCImages = new Image[6];
        private List<string> NPCReplics = new List<string>();

        public NPC()
        {
            NPCImages[0] = Image.FromFile(@"textures\npc1-removebg-preview.png");
            NPCImages[1] = Image.FromFile(@"textures\npc2-removebg-preview.png");
            NPCImages[2] = Image.FromFile(@"textures\npc3-removebg-preview.png");
            NPCImages[3] = Image.FromFile(@"textures\npc4-removebg-preview.png");
            NPCImages[4] = Image.FromFile(@"textures\npc5-removebg-preview.png");
            NPCImages[5] = Image.FromFile(@"textures\npc6-removebg-preview.png");
            NPCReplics.Add("I have a date tonight and would like to buy some flowers for a girl. What about...");
            NPCReplics.Add("I go to my friend’s birthday. She adores flowers. Please give me...");
            NPCReplics.Add("I go to the theater tonight. | want to give a bouquet to my favorite actress. Sell me...");
            NPCReplics.Add("Today is a school graduation ceremony and I’d like to buy a bouquet for my daughter.");
            NPCReplics.Add("I have another blind date tonight and would like to buy some flowers. Give me...");

        }

        public Image RandomNpc()
        {
            Random random = new Random();
            int randomNumber = random.Next(6);
            return NPCImages[randomNumber];
        }

        public string RandomReplic()
        {
            Random random = new Random();
            int randomNumber = random.Next(5); 
            return NPCReplics[randomNumber];
        }
    }
}
