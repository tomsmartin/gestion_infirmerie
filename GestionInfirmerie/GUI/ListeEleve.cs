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
    public partial class ListeEleve : Form
    {
        public ListeEleve()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionElevesBLL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);

            // Création d'un objet List d'élèves à afficher dans le datagridview
            List<EleveBO> liste = new List<EleveBO>();
            liste = GestionElevesBLL.GetEleves();

            // Rattachement de la List à la source de données du datagridview
            dgv.DataSource = liste;

            // Caché la colonne de l'id
            dgv.Columns[11].Visible = false;

            // Renommer les colonnes
            // -------------------
            // -------------------
            dgv.Columns[0].HeaderText = "Nom";
            dgv.Columns[1].HeaderText = "Prénom";
            dgv.Columns[2].HeaderText = "Date de naissance";
            dgv.Columns[3].HeaderText = "Santé de l'élève";
            dgv.Columns[4].HeaderText = "Téléphone de l'élève";
            dgv.Columns[5].HeaderText = "Téléphone du père";
            dgv.Columns[6].HeaderText = "Téléphone de la mère";
            dgv.Columns[7].HeaderText = "Archivé(e)";
            dgv.Columns[8].HeaderText = "Possède un tiers temps";
            dgv.Columns[9].HeaderText = "A effectué une/des visite(s)";
        }

        private void rechercheNom_KeyUp_1(object sender, KeyEventArgs e)
        {
            string search = rechercheNom.Text;
            List<EleveBO> liste = new List<EleveBO>();
            liste = GestionElevesBLL.GetEleveSearch(search);
            dgv.DataSource = liste;
        }
    }
}
