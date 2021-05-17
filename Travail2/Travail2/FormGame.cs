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
        public FormGame()
        {
            InitializeComponent();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            InterfaceGraphique graphics = new InterfaceGraphique();
            graphics.LoadGraphicsInForm();
            GamerTimer.Start();
        }

        private void GamerTimer_Tick(object sender, EventArgs e)
        {
            InterfaceGraphique graphique = new InterfaceGraphique();
            graphique.MettreAJour(); 
        }
    }
}
