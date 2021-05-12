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
        public Bitmap GameImage;
        private Bitmap BackgroundImage;
        private Image BackgroundImageOriginal;


        public InterfaceGraphique()
        {
            Width = 810;
            Height = 450;
            BackgroundImageOriginal = Image.FromFile("../../Images/Background.png");
            BackgroundImage = new Bitmap(BackgroundImageOriginal, Width, Height);
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
        public Bitmap GetGameImage()
        {
            return GameImage;
        }

        public void SetGameImage(Bitmap gameImage)
        {
            GameImage = gameImage;
        }

        public void LoadBackgroundImage()
        {
            BackgroundImageOriginal = Image.FromFile("../../Images/Background.png");
            BackgroundImage = new Bitmap(BackgroundImageOriginal, Width, Height);
        }
    }
}
