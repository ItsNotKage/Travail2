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
        private int PositionEnemyY;
        private int Speed;
        Ennemie enemy;
        List<Ennemie> Enemies;
        public Ennemie()
        {
            EnemyImageOriginal = Image.FromFile("../../Images/Bear.png");
            EnemyImage = new Bitmap(EnemyImageOriginal, 50, 100);
            PositionEnemyX = random.Next(0, 850);
            PositionEnemyY = 0;
            Speed = 5;
            enemy = new Ennemie();
            Enemies = new List<Ennemie>();
        }
        public Bitmap GetEnemyImage()
        {
            return EnemyImage;
        }

        public void SetEnemy(Bitmap enemyImage)
        {
            EnemyImage = enemyImage;
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
        //public void MakeEnemies()
        //{
        //    EnemyImageOriginal = Image.FromFile("../../Images/Bear.png");
        //    EnemyImage = new Bitmap(EnemyImageOriginal, 50, 100);
        //    enemy.SetPositionEnemyY(-100);
        //    enemy.SetPositionEnemyX(random.Next(0, 850));
        //}
    }
}
