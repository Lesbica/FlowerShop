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
        public int price { get; set; }
        public int quantity { get; set; }
        public int ripening_time { get; set; }
        public Image[] images = new Image[3];
    }

    public class BlueFlower : Flower
    {
        public BlueFlower() 
        {
            price = 13;
            quantity = 1;
            ripening_time = 9999;
            images[0] = Image.FromFile(@"C:\Users\Chara\Documents\RAD Studio\Projects\project\algoritm\courseProject\FlowerShop\textures\smallBlueFlower-removebg-preview.png");
            images[1] = Image.FromFile(@"C:\Users\Chara\Documents\RAD Studio\Projects\project\algoritm\courseProject\FlowerShop\textures\blueFlower-removebg-preview.png");
            images[2] = Image.FromFile(@"C:\Users\Chara\Documents\RAD Studio\Projects\project\algoritm\courseProject\FlowerShop\textures\grownBlueFlower-removebg-preview.png");
        }

        public int GetRipening_Time()
        {
            return ripening_time;
        }
    }
}
