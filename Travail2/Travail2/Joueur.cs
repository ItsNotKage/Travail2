using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Travail2
{
    public class Joueur
    {
        private Bitmap PlayerImage;
        private Image PlayerImageOriginal;
        private int Width;
        private int Height;
        public int PositionJoueurX;
        public int PositionJoueurY;
        private int Speed;

        public Joueur(int speed)
        {
            Width = 50;
            Height = 100;
            PositionJoueurX = 25;
            PositionJoueurY = 325;
            Speed = speed;   
        }
        public Bitmap GetPlayerImage()
        {
            return PlayerImage;
        }

        public void SetPlayerImage(Bitmap playerImage)
        {
            PlayerImage = playerImage;
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
        public void LoadPlayerImage()
        {
            PlayerImageOriginal = Image.FromFile("../../Images/Bender.png");
            PlayerImage = new Bitmap(PlayerImageOriginal, Width, Height);
        }

    }
}
