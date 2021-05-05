using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Travail2
{
    public class Projectile
    {
        private Bitmap BoltNutImage;
        private Image BoltNutImageOriginal;

        public Projectile()
        {
            BoltNutImageOriginal = Image.FromFile("../../Images/BoltNut.png");
            BoltNutImage = new Bitmap(BoltNutImageOriginal, 50, 100);
        }
    }
}
