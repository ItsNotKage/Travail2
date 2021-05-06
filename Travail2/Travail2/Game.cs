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
    public partial class FormGame : Form
    {
        private Bitmap gameImage;
        private PlayerInput playerInput;
        InterfaceGraphique graphic = new InterfaceGraphique();
        Joueur joueur = new Joueur();
        Projectile projectile = new Projectile();
        public FormGame()
        {
            InitializeComponent();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            graphic.LoadImage();

            playerInput = new PlayerInput();

            GameTimer.Start();
        }

        private void GamerTimer_Tick(object sender, EventArgs e)
        {
            MettreAJour();
        }
        private void MettreAJour()
        {
            if (playerInput.GetMoveLeft() == true && joueur.GetPositionJoueurX() > 10)
            {
                joueur.PositionJoueurX = joueur.GetPositionJoueurX() - joueur.GetSpeed();
            }
            if (playerInput.GetMoveRight() == true && joueur.GetPositionJoueurX() < 735)
            {
                joueur.PositionJoueurX = joueur.GetPositionJoueurX() + joueur.GetSpeed();
            }
            projectile.PositionProjectileY = projectile.GetPositionProjectileY() - projectile.GetSpeed();

            Draw();
        }

        private void Draw()
        {
            gameImage = new Bitmap(graphic.GetWidth(), graphic.GetHeight());
            graphic.GetGameImage().Dispose();
            using (Graphics graphics = Graphics.FromImage(gameImage))
            {
                graphics.DrawImage(graphic.GetBackgroundImage(), 0, 0);
                graphics.DrawImage(graphic.GetPlayerImage(), joueur.GetPositionJoueurX(), joueur.GetPositionJoueurY());
                graphics.DrawImage(projectile.GetProjectileImage(), projectile.GetPositionProjectileX(), projectile.GetPositionProjectileY());
            }

            this.BackgroundImage = gameImage;
        }
        private void IsGameOver()
        {

        }
        private void ResetGame()
        {

        }
        private void TirerProjectile()
        {
            projectile.SetPositionProjectileX(joueur.GetPositionJoueurX() + projectile.GetWidth());
            projectile.SetPositionProjectileY(joueur.GetPositionJoueurY() - projectile.GetHeight());
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                playerInput.SetMoveRight(true);
            }
            if (e.KeyCode == Keys.Left)
            {
                playerInput.SetMoveLeft(true);
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                playerInput.SetMoveRight(false);
            }
            if (e.KeyCode == Keys.Left)
            {
                playerInput.SetMoveLeft(false);
            }
            if (e.KeyCode == Keys.Space)
            {
                TirerProjectile();
            }
        }
    }
}
