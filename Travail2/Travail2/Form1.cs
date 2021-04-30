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
    public partial class JeuFuturama : Form
    {
        public JeuFuturama()
        {
            InitializeComponent();
        }

        private void JeuFuturama_Load(object sender, EventArgs e)
        {
            


        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCommencer_Click(object sender, EventArgs e)
        {
            FormGame MaForme = new FormGame();
            MaForme.ShowDialog();
        }
    }
}
