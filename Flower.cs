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

    public class PurpleFlower : Flower
    {
        public PurpleFlower()
        {
            Price = 8;
            Ripening_time = 15000;
            Images[0] = Image.FromFile(@"textures\smallPurpleFlower-removebg-preview.png");
            Images[1] = Image.FromFile(@"textures\purpleFlower-removebg-preview.png");
            Images[2] = Image.FromFile(@"textures\grownPurpleFlower-removebg-preview.png");
        }
    }

    public class RedFlower : Flower
    {
        public RedFlower()
        {
            Price = 14;
            Ripening_time = 18000;
            Images[0] = Image.FromFile(@"textures\smallRedFlower-removebg-preview.png");
            Images[1] = Image.FromFile(@"textures\redFlower-removebg-preview.png");
            Images[2] = Image.FromFile(@"textures\GrownRedFlower-removebg-preview.png");
        }
    }
}
