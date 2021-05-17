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
        const int DeuxsecondesEnTick = 125; 
        int tick;
        Parametres parametres = new Parametres();
        Bitmap gameImage;
        PlayerInput playerInput = new PlayerInput();
        InterfaceGraphique graphic = new InterfaceGraphique();
        Joueur joueur;
        List<Projectile> projectiles = new List<Projectile>();
        Ennemie enemy;
        int score;
        Label lbl_ScoreTitle = new Label();
        Label lbl_Score = new Label();

        public FormGame(Parametres parametres)
        {
            if (parametres.difficulte == Parametres.Difficulte.Facile)
            {
                this.joueur = new Joueur(15);
                this.enemy = new Ennemie(4);
            }
            else if (parametres.difficulte == Parametres.Difficulte.Intermediaire)
            {
                this.joueur = new Joueur(17);
                this.enemy = new Ennemie(4);
            }
            else 
            {
                this.joueur = new Joueur(18);
                this.enemy = new Ennemie(5);
            }
            this.parametres = parametres;
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
            RectangleF rectangleEnnemie = new RectangleF(enemy.GetPositionEnemyX(), enemy.GetPositionEnemyY(), enemy.GetWidth(), enemy.GetHeight());
            RectangleF rectangleJoueur = new RectangleF(joueur.GetPositionJoueurX(), joueur.GetPositionJoueurY(), joueur.GetWidth(), joueur.GetHeight());
            for (int i = 0; i < projectiles.Count; i++)
            {
                RectangleF rectangleProjectile = new RectangleF(projectiles[i].GetPositionProjectileX(), projectiles[i].GetPositionProjectileY(), projectiles[i].GetWidth(), projectiles[i].GetHeight());
                if (rectangleProjectile.IntersectsWith(rectangleEnnemie))
                {
                    score = score + 10;
                    enemy.kill();
                    projectiles.RemoveAt(i);
                }
            }
            if (rectangleEnnemie.IntersectsWith(rectangleJoueur))
            {
                GameOver();
            }
        }
        private void GamerTimer_Tick(object sender, EventArgs e)
        {
            MettreAJour();
            tick++;
        }
        private void MettreAJour()
        {
            Draw();
            if (playerInput.GetMoveLeft() == true && joueur.GetPositionJoueurX() > 10)
            {
                joueur.PositionJoueurX = joueur.GetPositionJoueurX() - joueur.GetSpeed();
            }
            if (playerInput.GetMoveRight() == true && joueur.GetPositionJoueurX() < 735)
            {
                joueur.PositionJoueurX = joueur.GetPositionJoueurX() + joueur.GetSpeed();
            }
            enemy.PositionEnemyY = enemy.GetPositionEnemyY() + enemy.GetSpeed();

            for (int i = 0; i < projectiles.Count; i++)
            {
               
                if (projectiles[i].GetPositionProjectileY() == 0)
                {
                    projectiles.RemoveAt(i);
                    

                }
                else
                {
                    projectiles[i].PositionProjectileY = projectiles[i].GetPositionProjectileY() - projectiles[i].GetSpeed();

                }




            }
            Colision();
            lbl_Score.Text = score.ToString();
        }

        private void Draw()
        {
            gameImage = new Bitmap(graphic.GetWidth(), graphic.GetHeight());
            graphic.GetGameImage().Dispose();
            using (Graphics graphics = Graphics.FromImage(gameImage))
            {
                graphics.DrawImage(graphic.GetBackgroundImage(), 0, 0);
                graphics.DrawImage(joueur.GetPlayerImage(), joueur.GetPositionJoueurX(), joueur.GetPositionJoueurY());
                for (int i = 0; i < projectiles.Count; i++)
                {
                    graphics.DrawImage(projectiles[i].GetProjectileImage(), projectiles[i].GetPositionProjectileX(), projectiles[i].GetPositionProjectileY());

                }
                if (enemy.GetPositionEnemyY() == 0 || enemy.GetPositionEnemyY() > graphic.GetHeight() )
                {
                    if (parametres.difficulte == Parametres.Difficulte.Facile)
                    {
                        this.enemy = new Ennemie(4);
                    }
                    else if (parametres.difficulte == Parametres.Difficulte.Intermediaire)
                    {
                        
                        this.enemy = new Ennemie(4);
                    }
                    else
                    {
                        
                        this.enemy = new Ennemie(5);
                    }
                    if (tick % DeuxsecondesEnTick == 0 || tick == 0)
                    {

                        
                        graphics.DrawImage(enemy.GetEnemyImage(), enemy.GetPositionEnemyX(), enemy.GetPositionEnemyY());

                    }
                }
                else
                {
                    graphics.DrawImage(enemy.GetEnemyImage(), enemy.GetPositionEnemyX(), enemy.GetPositionEnemyY());
                }
            }
            this.BackgroundImage = gameImage;
        }
        private void GameOver()
        {
            GameTimer.Stop();
            lbl_Score.Text = score.ToString();
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
            graphic.LoadBackgroundImage();
            joueur.LoadPlayerImage();
            GameTimer.Start();
        }
        private void TirerProjectile()
        {
            Projectile projectile;
            if (parametres.difficulte == Parametres.Difficulte.Facile)
            {
               projectile = new Projectile(6);
            }
            else if (parametres.difficulte == Parametres.Difficulte.Intermediaire)
            {

                 projectile = new Projectile(7);
            }
            else
            {

                 projectile = new Projectile(10);
            }

            projectile.SetPositionProjectileX(joueur.GetPositionJoueurX() + projectile.GetWidth());
            projectile.SetPositionProjectileY(joueur.GetPositionJoueurY() - projectile.GetHeight());
            projectiles.Add(projectile);
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
