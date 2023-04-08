using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    public class Flower
    {
        public int Price { get; set; }
        public int Ripening_time { get; set; }
        public Image[] Images = new Image[3];
    }

    public class BlueFlower : Flower
    {
        public BlueFlower() 
        {
            Price = 13;
            Ripening_time = 9999;
            Images[0] = Image.FromFile(@"textures\smallBlueFlower-removebg-preview.png");
            Images[1] = Image.FromFile(@"textures\blueFlower-removebg-preview.png");
            Images[2] = Image.FromFile(@"textures\grownBlueFlower-removebg-preview.png");
        }
    }
}
