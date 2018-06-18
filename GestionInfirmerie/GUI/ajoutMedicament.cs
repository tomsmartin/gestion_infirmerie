using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using BO;
using System.Configuration;


namespace GUI
{
    public partial class ajoutMedicament : Form
    {
        public ajoutMedicament()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionMedicamentsBLL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

            if (this.txtNom.TextLength == 0)
            {
                errorProviderNomMedicament.SetError(txtNom, "Le champ ne peut pas être vide!");
            }
            else 
            {
                // Boite de dialogue qui demande confirmation de la volonté de supprimer l'enregistrement
                if (MessageBox.Show("Voulez-vous vraiment ajouter cet élèves ?", "Ajout", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Actions effectuées si Oui est cliqué dans la message box
                    // Appel de la méthode SupprimerEleve de la couche BLL

                    GestionMedicamentsBLL.CreerUnMedicament(txtNom.Text.ToString(), cbArchive.Checked, cbUtilisation.Checked);

                    // Boite de dialogue qui confirme la suppression en BD
                    MessageBox.Show("Ajout effectuée !", "Ajout");

                    //on vide les champs apres l'ajout
                    cbUtilisation.Checked = false;
                    cbArchive.Checked = false;
                    txtNom.Clear();
                }
            }
        }
    }
}
