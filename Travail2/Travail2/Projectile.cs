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
        private Bitmap ProjectileImage;
        private Image ProjectileImageOriginal;
        private int Width;
        private int Height;
        public int PositionProjectileX;
        public int PositionProjectileY;
        private int Speed;
        
        //a
        public Projectile()
        {
            Width = 15;
            Height = 35;
            Speed = 10;
            ProjectileImageOriginal = Image.FromFile("../../Images/BeerBottle.png");
            ProjectileImage = new Bitmap(ProjectileImageOriginal, Width, Height);
        }
        public Bitmap GetProjectileImage()
        {
            return ProjectileImage;
        }

        public void SetProjectileImage(Bitmap projectileImage)
        {
            ProjectileImage = projectileImage;
        }
        public int GetWidth()
        {
            return Width;
        }

        public void SetWidth(int width)
        {
            Width = width;
        }
        public int GetHeight()
        {
            return Height;
        }

        public void SetHeight(int height)
        {
            Height = height;
        }
        public int GetSpeed()
        {
            return Speed;
        }

        public void SetSpeed(int speed)
        {
            Speed = speed;
        }
        public int GetPositionProjectileX()
        {
            return PositionProjectileX;
        }

        public void SetPositionProjectileX(int positionProjectileX)
        {
            PositionProjectileX = positionProjectileX;
        }
        public int GetPositionProjectileY()
        {
            return PositionProjectileY;
        }

        public void SetPositionProjectileY(int positionProjectileY)
        {
            PositionProjectileY = positionProjectileY;
        }

    }
}
