using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail2
{
    public class InterfaceGraphique
    {
        private int Width;
        private int Height;
        private Bitmap GameImage;
        private Bitmap BackgroundImage;
        private Bitmap PlayerImage;
        private Image BackgroundImageOriginal;
        private Image PlayerImageOriginal;

        public InterfaceGraphique()
        {
            Width = 810;
            Height = 450;
            BackgroundImageOriginal = Image.FromFile("../../Images/Background.png");
            PlayerImageOriginal = Image.FromFile("../../Images/Bender.png");
            BackgroundImage = new Bitmap(BackgroundImageOriginal, Width, Height);
            PlayerImage = new Bitmap(PlayerImageOriginal, 50, 100);
            GameImage = new Bitmap(Width, Height);
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
        public Bitmap GetBackgroundImage()
        {
            return BackgroundImage;
        }

        public void SetBackgroundImage(Bitmap backgroundImage)
        {
            BackgroundImage = backgroundImage;
        }
        public Bitmap GetPlayerImage()
        {
            return PlayerImage;
        }

        public void SetPlayerImage(Bitmap playerImage)
        {
            PlayerImage = playerImage;
        }
        public Bitmap GetGameImage()
        {
            return GameImage;
        }

        public void SetGameImage(Bitmap gameImage)
        {
            GameImage = gameImage;
        }

        public void LoadImage()
        {
            BackgroundImageOriginal = Image.FromFile("../../Images/Background.png");
            PlayerImageOriginal = Image.FromFile("../../Images/Bender.png");
            BackgroundImage = new Bitmap(BackgroundImageOriginal, Width, Height);
            PlayerImage = new Bitmap(PlayerImageOriginal, 50, 100);
            GameImage = new Bitmap(Width, Height);
        }
    }
}
