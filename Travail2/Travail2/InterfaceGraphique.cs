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
    public class InterfaceGraphique
    {
        private int Width;
        private int Height;
        private Bitmap gameImage;
        private Bitmap playerImage;
        private Bitmap backgroundImage;
        private PlayerInput playerInput;
        private int positionJoueurX;
        private int positionJoueurY;

        public InterfaceGraphique()
        {
            Width = 1024;
            Height = 750;
            positionJoueurX = 0;
            positionJoueurY = 450;
            playerInput = new PlayerInput();
            gameImage = new Bitmap(Width, Height);
           
        }
        public void LoadGraphicsInForm()
        {
            Image backgroundImage = Image.FromFile("../../Images/Background.png");
            Image playerImage = Image.FromFile("../../Images/xeon.png");

            backgroundImage = new Bitmap(backgroundImage, Width, Height);
            playerImage = new Bitmap(playerImage, 118, 200);
           ;


            
        }
        public void Draw()
        {
            gameImage.Dispose();
            gameImage = new Bitmap(Width, Height);

            using (Graphics graphics = Graphics.FromImage(gameImage))
            {
                Image backgroundImage = Image.FromFile("../../Images/Background.png");
                Image playerImage = Image.FromFile("../../Images/xeon.png");
                graphics.DrawImage(backgroundImage, 0, 0);
                graphics.DrawImage(playerImage, positionJoueurX, positionJoueurY);
            }

            this.backgroundImage = gameImage;
        }
        public void MettreAJour()
        {
            if (playerInput.GetMoveUp() == true && positionJoueurX >= 0)
            {

                positionJoueurX = positionJoueurX - 10;
            }
            else if (playerInput.GetMoveDown() && positionJoueurX <= 920)
            {
                positionJoueurX = positionJoueurX + 10;
            }

            Draw();
        }
    }
}
