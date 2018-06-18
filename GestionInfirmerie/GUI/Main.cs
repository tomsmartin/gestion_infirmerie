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
    public partial class Main : Form
    {
        ListeEleve frmGestionEleve;
        ajoutEleves frmAjoutEleve;
        modifEleve frmModifEleve;
        modifMedicament frmModifMedicament;
        ajoutMedicament frmAjoutMedicament;
        gestClasses frmGestClasses;
        listeVisite frmListeVisites;
        ajoutVisite frmAjoutVisites;
        modifVisite frmModifVisites;
        listeMedicament frmListeMedicament;
        Synthese frmSynthese;
        SauvegardeBDD frmSaveBDD;


        public Main()
        {
            InitializeComponent();
        }

        // On ouvre en tant que child la form gestionEleve dans la form Main
        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionEleve = new ListeEleve();//initialise une instance de form
            frmGestionEleve.MdiParent = this;
            frmGestionEleve.Show();
        }


        // On ouvre en tant que child la form ajoutEleve dans la form Main
        private void ajoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjoutEleve = new ajoutEleves();//initialise une instance de form
            frmAjoutEleve.MdiParent = this;
            frmAjoutEleve.Show();
        }

        // On ouvre en tant que child la form supp/modifEleve dans la form Main
        private void supToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModifEleve = new modifEleve();//initialise une instance de form
            frmModifEleve.MdiParent = this;
            frmModifEleve.Show();
        }

        private void supModifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModifMedicament = new modifMedicament();//initialise une instance de form
            frmModifMedicament.MdiParent = this;
            frmModifMedicament.Show();
        }

        private void ajoutDesMédicamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjoutMedicament = new ajoutMedicament();//initialise une instance de form
            frmAjoutMedicament.MdiParent = this;
            frmAjoutMedicament.Show();
        }

        private void gestionDesClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestClasses = new gestClasses();//initialise une instance de form
            frmGestClasses.MdiParent = this;
            frmGestClasses.Show();
        }

        private void listesDesVistesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListeVisites = new listeVisite();//initialise une instance de form
            frmListeVisites.MdiParent = this;
            frmListeVisites.Show();
        }

        private void saisieDesVisitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjoutVisites = new ajoutVisite();//initialise une instance de form
            frmAjoutVisites.MdiParent = this;
            frmAjoutVisites.Show();
        }

        private void modifDesVisitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModifVisites = new modifVisite();//initialise une instance de form
            frmModifVisites.MdiParent = this;
            frmModifVisites.Show();
        }

        private void listeDesMédicamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListeMedicament = new listeMedicament();//initialise une instance de form
            frmListeMedicament.MdiParent = this;
            frmListeMedicament.Show();
        }

        private void synthèseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSynthese = new Synthese();//initialise une instance de form
            frmSynthese.MdiParent = this;
            frmSynthese.Show();
        }

        private void saveBDDToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            frmSaveBDD = new SauvegardeBDD();//initialise une instance de form
            frmSaveBDD.MdiParent = this;
            frmSaveBDD.Show();
        }
    }
}
