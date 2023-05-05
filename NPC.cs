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
        public Image[] NPCImages = new Image[6];
        public NPC()
        {
            NPCImages[0] = Image.FromFile(@"textures\npc1-removebg-preview.png");
            NPCImages[1] = Image.FromFile(@"textures\npc2-removebg-preview.png");
            NPCImages[2] = Image.FromFile(@"textures\npc3-removebg-preview.png");
            NPCImages[3] = Image.FromFile(@"textures\npc4-removebg-preview.png");
            NPCImages[4] = Image.FromFile(@"textures\npc5-removebg-preview.png");
            NPCImages[5] = Image.FromFile(@"textures\npc6-removebg-preview.png");
        }

        public Image RandomNpc()
        {
            Random random = new Random();
            int randomNumber = random.Next(6);
            return NPCImages[randomNumber];
        }
    }
}
