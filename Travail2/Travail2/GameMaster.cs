using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Travail2
{
    class GameMaster
    {
        Ennemie enemy = new Ennemie();
        List<Ennemie> enemies = new List<Ennemie>();
        List<Projectile> projectiles = new List<Projectile>();
        Random random = new Random();
        Projectile projectile = new Projectile();
        Joueur joueur = new Joueur();
        InterfaceGraphique graphic = new InterfaceGraphique();
        public void MakeEnemy()
        {
            for (int count = 0; count <=3; count++)
            {

            }
            if (enemy.GetPositionEnemyX() < graphic.GetWidth())
            {
                enemy.GetEnemyImageOriginal();
                enemy.GetEnemyImage();
            }

        }
        public void EnemiesList()
        {
            for (int frameCounter = 1; frameCounter <= 5; frameCounter++)
            {
                while (frameCounter == 5)
                {
                    frameCounter = 1;
                }
            }
        }
        public void RemoveBullet()
        {
            foreach (Projectile projectile in projectiles)
            {
                    projectiles.Remove(projectile);
                    projectile.GetProjectileImage().Dispose();
            }

        }
    }
}
