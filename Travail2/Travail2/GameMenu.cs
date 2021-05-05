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
            FormGame MaForme = new FormGame();
            MaForme.Show();
            Visible = false;
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
    }
}
