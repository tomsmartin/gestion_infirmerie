using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class gestClasses : Form
    {
        ajoutClasses frmAjoutClasses;
        modifClasse frmModifClasse;

        public gestClasses()
        {
            InitializeComponent();
        }

        private void ajoutClasse_Click(object sender, EventArgs e)
        {
            frmAjoutClasses = new ajoutClasses();
            frmAjoutClasses.Show();
            this.Hide();
        }

        private void listeClasse_Click(object sender, EventArgs e)
        {
            frmModifClasse = new modifClasse();
            frmModifClasse.Show();
            this.Hide();
        }
    }
}
