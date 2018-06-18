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
    public partial class modifMedicament : Form
    {
        public modifMedicament()
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


            txtNom.Enabled = false;
            cbArchive.Enabled = false;
            cbUtilisation.Enabled = false;
            btnModif.Enabled = false;
            btnSup.Enabled = false;
        }

        // Bouton Modifier
        private void btnModif_Click(object sender, EventArgs e)
        {
            // Appel de la méthode ModifierMedicament de la couche BLL
            if (this.txtNom.TextLength == 0)
            {
                errorProviderNomMedicament.SetError(txtNom, "Le champ ne peut pas être vide!");
            }

            else
            {
                GestionMedicamentsBLL.ModifierMedicament(Int32.Parse(txtId.Text.ToString()), txtNom.Text, Boolean.Parse(cbArchive.Checked.ToString()), Boolean.Parse(cbUtilisation.Checked.ToString()));

                dgv.Refresh();

                // Une fois la modication effectuée, rendre innopérants certains contrôles
                txtNom.Enabled = false;
                cbArchive.Enabled = false;
                cbUtilisation.Enabled = false;
                btnModif.Enabled = false;
                btnSup.Enabled = false;

                // Actualisation du datagridview
                // Création d'un objet List Meciacament à afficher dans le datagridview
                List<MedicamentBO> liste = new List<MedicamentBO>();
                liste = GestionMedicamentsBLL.GetMedicaments();

                errorProviderNomMedicament.SetError(this.txtNom, String.Empty);

                // Rattachement de la List à la source de données du datagridview
                dgv.DataSource = liste;

                // Boite de dialogue qui confirme la suppression en BD
                MessageBox.Show("Modification effectuée !", "Modification");

                //on vide les champs apres la modification
                txtNom.Clear();
                cbArchive.Checked = false;
                cbUtilisation.Checked = false;
            }
        }


        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MedicamentBO leMedicament = new MedicamentBO(Int32.Parse(dgv.CurrentRow.Cells[0].Value.ToString()), dgv.CurrentRow.Cells[1].Value.ToString(), Boolean.Parse(dgv.CurrentRow.Cells[2].Value.ToString()), Boolean.Parse(dgv.CurrentRow.Cells[3].Value.ToString()));
            txtId.Text = leMedicament.IdMedicament.ToString();
            txtNom.Text = leMedicament.NomMedicament;
            cbArchive.Checked = leMedicament.ArchiveMedicament;
            cbUtilisation.Checked = leMedicament.UtilisationDansUneVisite;

            // Déblocage des boutons de modification et de suppression sur clique d'une ligne
            txtNom.Enabled = true;
            cbArchive.Enabled = true;
            cbUtilisation.Enabled = true;
            btnModif.Enabled = true;
            btnSup.Enabled = true;
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            // Boite de dialogue qui demande confirmation de la volonté de supprimer l'enregistrement
            if (MessageBox.Show("Voulez-vous vraiment supprimer cet élèves ?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Actions effectuées si Oui est cliqué dans la message box
                // Appel de la méthode SupprimerEleve de la couche BLL

                GestionMedicamentsBLL.SupprimerMedicament(Int32.Parse(dgv.CurrentRow.Cells[0].Value.ToString()));

                dgv.Refresh();

                // Une fois la modication effectuée, rendre innopérants certains contrôles
                txtNom.Enabled = false;
                cbArchive.Enabled = false;
                cbUtilisation.Enabled = false;
                btnModif.Enabled = false;
                btnSup.Enabled = false;

                // Actualisation du datagridview
                // Création d'un objet List Eleve à afficher dans le datagridview
                List<MedicamentBO> liste = new List<MedicamentBO>();
                liste = GestionMedicamentsBLL.GetMedicaments();

                errorProviderNomMedicament.SetError(this.txtNom, String.Empty);

                // Rattachement de la List à la source de données du datagridview
                dgv.DataSource = liste;

                // Boite de dialogue qui confirme la suppression en BD
                MessageBox.Show("Supression effectuée !", "Suppression");

                //on vide les champs apres la suppression
                txtNom.Clear();
                cbArchive.Checked = false;
                cbUtilisation.Checked = false;
            }
        }

        private void btnModif_Validated(object sender, EventArgs e)
        {
            // Si toutes les conditions ont été remplisent : clear l'errorProvider
            // Ou si on clique sur un row de la dgv : clear l'errorProvider
            errorProviderNomMedicament.SetError(txtNom, "");
        }
    }
}
