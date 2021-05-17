using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travail2
{
    public class Ennemie
    {
        Random random = new Random();
        private Bitmap EnemyImage;
        private Image EnemyImageOriginal;
        private int PositionEnemyX;
        public int PositionEnemyY;
        private int Width;
        private int Height;
        private int Speed;
        public Ennemie(int speed)
        {
            Width = 50;
            Height = 75;
            EnemyImageOriginal = Image.FromFile("../../Images/Bear.png");
            EnemyImage = new Bitmap(EnemyImageOriginal, Width, Height);
            PositionEnemyX = random.Next(0, 800);
            PositionEnemyY = 0;
            Speed = speed;
        }
        public Bitmap GetEnemyImage()
        {
            return EnemyImage;
        }
        public void kill()
        {
            PositionEnemyX = 1000;
        }
        public void SetEnemy(Bitmap enemyImage)
        {
            EnemyImage = enemyImage;
        }
        public Image GetEnemyImageOriginal()
        {
            return EnemyImageOriginal;
        }

        public void SetEnemyImageOriginal(Image enemyImageOriginal)
        {
            EnemyImageOriginal = enemyImageOriginal;
        }
        public int GetWidth()
        {
            return Width;
        }

        public void SetEnemyWidth(int width)
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
        public int GetPositionEnemyX()
        {
            return PositionEnemyX;
        }

        public void SetPositionEnemyX(int positionEnemyX)
        {
            PositionEnemyX = positionEnemyX;
        }
        public int GetPositionEnemyY()
        {
            return PositionEnemyY;
        }

        public void SetPositionEnemyY(int positionEnemyY)
        {
            PositionEnemyY = positionEnemyY;
        }
        public int GetSpeed()
        {
            return Speed;
        }

        public void SetSpeed(int speed)
        {
            Speed = speed;
        }
        
    }
}
