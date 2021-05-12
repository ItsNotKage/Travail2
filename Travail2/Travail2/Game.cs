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
        Bitmap gameImage;
        PlayerInput playerInput = new PlayerInput();
        InterfaceGraphique graphic = new InterfaceGraphique();
        GameMaster gererJeu = new GameMaster();
        Joueur joueur = new Joueur();
        Projectile projectile = new Projectile();
        List<Projectile> projectiles = new List<Projectile>();
        Ennemie enemy = new Ennemie();
        bool gameOver;
        int score;
        Label lbl_ScoreTitle = new Label();
        Label lbl_Score = new Label();

        public FormGame()
        {
            InitializeComponent();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            StartNewGame();
        }
        private void CreateLabel()
        {
            lbl_ScoreTitle.Text = "Score :";
            lbl_ScoreTitle.Location = new Point(13, 13);
            lbl_ScoreTitle.AutoSize = true;
            lbl_ScoreTitle.Font = new Font("Microsoft Sans Serif", 14);
            lbl_ScoreTitle.ForeColor = Color.White;
            lbl_ScoreTitle.BackColor = Color.Transparent;
            lbl_Score.Text = score.ToString();
            lbl_Score.Location = new Point(78, 14);
            lbl_Score.AutoSize = true;
            lbl_Score.Font = new Font("Microsoft Sans Serif", 14);
            lbl_Score.ForeColor = Color.White;
            lbl_Score.BackColor = Color.Transparent;
            this.Controls.Add(lbl_ScoreTitle);
            this.Controls.Add(lbl_Score);

        }
        public void Colision()
        {
            RectangleF rectangleProjectile = new RectangleF(projectile.GetPositionProjectileX(), projectile.GetPositionProjectileY(), projectile.GetWidth(), projectile.GetHeight());
            RectangleF rectangleEnnemie = new RectangleF(enemy.GetPositionEnemyX(), enemy.GetPositionEnemyY(), enemy.GetWidth(), enemy.GetHeight());
            RectangleF rectangleJoueur = new RectangleF(joueur.GetPositionJoueurX(), joueur.GetPositionJoueurY(), joueur.GetWidth(), joueur.GetHeight());
            if (rectangleProjectile.IntersectsWith(rectangleEnnemie))
            {   
                score = score + 10;
            }
            if (rectangleEnnemie.IntersectsWith(rectangleJoueur))
            {
                GameOver();
            }
        }
        private void GamerTimer_Tick(object sender, EventArgs e)
        {
            StartNewGame();
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
            if (projectile.GetPositionProjectileY() > graphic.GetHeight())
            {
                gererJeu.RemoveBullet();
            }
            projectile.PositionProjectileY = projectile.GetPositionProjectileY() - projectile.GetSpeed();
            enemy.PositionEnemyY = enemy.GetPositionEnemyY() + enemy.GetSpeed();
            Colision();
            lbl_Score.Text = score.ToString();

            Draw();
        }

        private void Draw()
        {
            gameImage = new Bitmap(graphic.GetWidth(), graphic.GetHeight());
            graphic.GetGameImage().Dispose();
            using (Graphics graphics = Graphics.FromImage(gameImage))
            {
                graphics.DrawImage(graphic.GetBackgroundImage(), 0, 0);
                graphics.DrawImage(joueur.GetPlayerImage(), joueur.GetPositionJoueurX(), joueur.GetPositionJoueurY());
                graphics.DrawImage(projectile.GetProjectileImage(), projectile.GetPositionProjectileX(), projectile.GetPositionProjectileY());
                graphics.DrawImage(enemy.GetEnemyImage(), enemy.GetPositionEnemyX(), enemy.GetPositionEnemyY());
            }

            this.BackgroundImage = gameImage;
        }
        private void GameOver()
        {
            GameTimer.Stop();
            lbl_Score.Text = score.ToString();
            gameOver = true;
            MessageBox.Show("Bravo! Vous avez atteint le score suivant : " + score);
            DialogResult result = MessageBox.Show("Voulez-vous recommencer une partie ?", "Partie Terminée", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                RestartNewGame();
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }

        }
        public void RestartNewGame()
        {
            GameMenu maForme = new GameMenu();
            maForme.Show();
            this.Close();
        }
        private void StartNewGame()
        {
            CreateLabel();
            gameOver = false;
            graphic.LoadBackgroundImage();
            joueur.LoadPlayerImage();
            Colision();
            GameTimer.Start();
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
