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
    public partial class listeMedicament : Form
    {
        public listeMedicament()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionMedicamentsBLL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);

            // Création d'un objet List de Medicaments à afficher dans le datagridview
            List<MedicamentBO> liste = new List<MedicamentBO>();
            liste = GestionMedicamentsBLL.GetMedicaments();

            // Rattachement de la List à la source de données du datagridview
            dgv.DataSource = liste;

            // Caché la colonne de l'id
            dgv.Columns[0].Visible = false;

            // Renommer les colonnes
            // -------------------
            // -------------------
            dgv.Columns[1].HeaderText = "Libellé";
            dgv.Columns[2].HeaderText = "Archivé";
            dgv.Columns[3].HeaderText = "A été utilisé";
        }

        private void rechercheNom_KeyUp(object sender, KeyEventArgs e)
        {
            string search = rechercheNom.Text;
            List<MedicamentBO> liste = new List<MedicamentBO>();
            liste = GestionMedicamentsBLL.GetMedicamentSearch(search);
            dgv.DataSource = liste;
        }

      }
}
