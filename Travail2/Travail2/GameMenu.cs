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
    public partial class GameMenu : Form
    {
        Parametres parametres = new Parametres();
        public GameMenu()
        {
            InitializeComponent();
        }
      
        
        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCommencer_Click(object sender, EventArgs e)
        {
            if (ChampsRempli() == true)
            {
                if (cmbParametre.SelectedItem.ToString() == "Facile")
                {
                    parametres.difficulte = Parametres.Difficulte.Facile;
                    FormGame MaForme = new FormGame(parametres);
                    MaForme.Show();
                    Visible = false;
                    

                }
                else if (cmbParametre.SelectedItem.ToString() == "Intermédiaire")
                {
                    parametres.difficulte = Parametres.Difficulte.Intermediaire;
                    FormGame MaForme = new FormGame(parametres);
                    MaForme.Show();
                    Visible = false;
                }
                else if (cmbParametre.SelectedItem.ToString() == "Difficile")
                {
                    parametres.difficulte = Parametres.Difficulte.Difficile;
                    FormGame MaForme = new FormGame(parametres);
                    MaForme.Show();
                    Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un niveau de difficutlé.");
            }
        }

        private void GameMenu_Load(object sender, EventArgs e)
        {
            RemplirComboBoxDifficulte();
        }
        private void RemplirComboBoxDifficulte()
        {
            cmbParametre.Items.Add("Facile");
            cmbParametre.Items.Add("Intermédiaire");
            cmbParametre.Items.Add("Difficile");
        }
        private Boolean ChampsRempli()
        {
            if (cmbParametre.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
