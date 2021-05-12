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
                    FormGame MaForme = new FormGame();
                    MaForme.Show();
                    Visible = false;
                }
                else if (cmbParametre.SelectedItem.ToString() == "Intermédiaire")
                {
                    FormGame MaForme = new FormGame();
                    MaForme.Show();
                    Visible = false;
                }
                else if (cmbParametre.SelectedItem.ToString() == "Difficile")
                {
                    FormGame MaForme = new FormGame();
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
