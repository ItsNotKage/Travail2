using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail2
{
    public class Joueur
    {
        public int PositionJoueurX;
        public int PositionJoueurY;
        public int Speed;
        private int Vie;

        public Joueur()
        {
            PositionJoueurX = 25;
            PositionJoueurY = 325;
            Speed = 15;
            Vie = 100;     
        }
        public int GetPositionJoueurX()
        {
            return PositionJoueurX;
        }

        public void SetJoueurPositionX(int positionJoueurX)
        {
            PositionJoueurX = positionJoueurX;
        }
        public int GetPositionJoueurY()
        {
            return PositionJoueurY;
        }

        public void SetJoueurPositionY(int positionJoueurY)
        {
            PositionJoueurY = positionJoueurY;
        }
        public int GetSpeed()
        {
            return Speed;
        }

        public void SetSpeed(int speed)
        {
            Speed = speed;
        }
        private void PlayerHealth()
        {
            Vie = 100;
        }

    }
}
