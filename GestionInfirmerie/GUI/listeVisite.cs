using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using BLL;
using BO;

namespace GUI
{
    public partial class listeVisite : Form
    {
        public listeVisite()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionVisiteBLL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);

            // Création d'un objet List d'élèves à afficher dans le datagridview
            List<VisiteBO> liste = new List<VisiteBO>();
            liste = GestionVisiteBLL.GetVisite();

            // Rattachement de la List à la source de données du datagridview
            dgv.DataSource = liste;

            // Caché la colonne de l'id
            dgv.Columns[0].Visible = false;
            dgv.Columns[10].Visible = false;

            // Renommer les colonnes
            // -------------------
            // -------------------
            dgv.Columns[0].HeaderText = "iD";
            dgv.Columns[1].HeaderText = "Motif";
            dgv.Columns[2].HeaderText = "Commentaire";
            dgv.Columns[3].HeaderText = "Heure Arrivé";
            dgv.Columns[4].HeaderText = "Heure Départ";
            dgv.Columns[5].HeaderText = "Date Visite";
            dgv.Columns[6].HeaderText = "Retour Domicile";
            dgv.Columns[7].HeaderText = "Hopital";
            dgv.Columns[8].HeaderText = "Parents";
            dgv.Columns[9].HeaderText = "Pouls";
            dgv.Columns[10].HeaderText = "Eleve";
            dgv.Columns[11].HeaderText = "Nom";
            dgv.Columns[12].HeaderText = "Prenom";
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string search = rechercheNom.Text;
            List<VisiteBO> liste = new List<VisiteBO>();
            liste = GestionVisiteBLL.GetVisiteSearch(search);
            dgv.DataSource = liste;
        }

          
    }
}
