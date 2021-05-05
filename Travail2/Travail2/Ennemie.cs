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
        Ennemie enemy;
        List<Ennemie> Enemies;
        public Ennemie()
        {
            EnemyImageOriginal = Image.FromFile("../../Images/Bear.png");
            EnemyImage = new Bitmap(EnemyImageOriginal, 50, 100);
            PositionEnemyX = random.Next(0, 850);
            PositionEnemyY = 0;
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
        public void MakeEnemies()
        {
            Image EnemyImageOriginal = Image.FromFile("../../Images/BoltNut.png");
            EnemyImage = new Bitmap(EnemyImageOriginal, 50, 100);
            Enemies.Add(enemy);
        }
    }
}
