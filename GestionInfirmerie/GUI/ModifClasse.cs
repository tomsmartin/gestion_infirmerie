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
    public partial class modifClasse : Form
    {
        ajoutClasses frmAjoutClasses;

        public modifClasse()
        {
            InitializeComponent();

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionClassesBLL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);

            // Création d'un objet List de Medicaments à afficher dans le datagridview
            List<ClasseBO> liste = new List<ClasseBO>();
            liste = GestionClassesBLL.GetClasses();

            // Rattachement de la List à la source de données du datagridview
            dgv.DataSource = liste;

            // Caché toutes les colonnes sauf le libellé
            dgv.Columns[0].Visible = false;
            dgv.Columns[2].Visible = false;
            dgv.Columns[3].Visible = false;
            dgv.Columns[4].Visible = false;

            // Renommer la colonne du libellé
            // -------------------
            // -------------------
            dgv.Columns[1].HeaderText = "Libellé";

            // Rendre innopérant les boutons et champs
            lblNomClasse.Enabled = false;
            txtNom.Enabled = false;
            cbPossedeEDT.Enabled = false;
            btnModif.Enabled = false;
            btnSupp.Enabled = false;
            btnAfficheEDT.Enabled = false;
            cbPossedeEleve.Enabled = false;
        }        

        // Bouton Modifier
        private void btnModif_Click(object sender, EventArgs e)
        {
            // Appel de la méthode ModifierMedicament de la couche BLL
            if (this.txtNom.TextLength == 0)
            {
                errorNomClasse.SetError(txtNom, "Le champ ne peut pas être vide!");
            }

            else
            {
                // Préparation du selecteur de fichier
                OpenFileDialog selectFichier = new OpenFileDialog();
                // Filtrer les fichiers
                selectFichier.Filter = "Fichiers PDF (*.pdf)|*.pdf";
                // Titre du selecteur de fichier
                selectFichier.Title = "Selectionnez un emploi du temps";

                // Si la classe ne possède pas d'emploi du temps
                if (cbPossedeEDT.Checked == false)
                {
                    // Si l'utilisateur a selectionné son fichier
                    if (selectFichier.ShowDialog() == DialogResult.OK)
                    {
                        // Cocher la checkbox qui information si un emploi du temps existe ou non
                        cbPossedeEDT.Checked = true;

                        GestionClassesBLL.ModifierClasseAvecEDT(Int32.Parse(txtId.Text.ToString()), txtNom.Text, selectFichier.FileName, Boolean.Parse(cbPossedeEleve.Checked.ToString()), Boolean.Parse(cbPossedeEDT.Checked.ToString()));
                    }
                    // Si l'utilisateur n'a pas selectionné de fichier
                    else
                    {
                        GestionClassesBLL.ModifierClasseSansEDT(Int32.Parse(txtId.Text.ToString()), txtNom.Text, Boolean.Parse(cbPossedeEleve.Checked.ToString()));
                    }
                }
                // Si la classe ne possède déjà un emploi du temps
                else
                {
                    GestionClassesBLL.ModifierClasseSansEDT(Int32.Parse(txtId.Text.ToString()), txtNom.Text, Boolean.Parse(cbPossedeEleve.Checked.ToString()));
                }

                dgv.Refresh();

                // Une fois la suppression effectuée, rendre innopérants certains contrôles
                lblNomClasse.Enabled = false;
                txtNom.Enabled = false;
                cbPossedeEDT.Enabled = false;
                btnAfficheEDT.Enabled = false;
                btnModif.Enabled = false;
                btnSupp.Enabled = false;

                // Actualisation du datagridview
                // Création d'un objet List Classe à afficher dans le datagridview
                List<ClasseBO> liste = new List<ClasseBO>();
                liste = GestionClassesBLL.GetClasses();

                // Rattachement de la List à la source de données du datagridview
                dgv.DataSource = liste;

                // Boite de dialogue qui confirme la modification en BD
                MessageBox.Show("Modification effectuée !", "Modification");
            }
        }

        private void btnModif_Validated(object sender, EventArgs e)
        {
            // Si toutes les conditions ont été remplisent : clear les errorProvider
            // Ou si on clique sur un row de la dgv : clear les errorProvider
            errorNomClasse.SetError(txtNom, "");
            errorSuppClasse.SetError(btnSupp, "");
        }

        // Bouton supprimer
        private void btnSupp_Click(object sender, EventArgs e)
        {
            // Boite de dialogue qui demande confirmation de la volonté de supprimer l'enregistrement
            if (MessageBox.Show("Voulez-vous vraiment supprimer cet classe ?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Actions effectuées si Oui est cliqué dans la message box

                // Si au moins un élève a été ajouté dans la classe
                if (cbPossedeEleve.Checked == true)
                {
                    errorSuppClasse.SetError(btnSupp, "Une classe possédant au moins un élève ne peut pas être supprimée");
                }
                // Sinon
                else
                {
                    // Appel de la méthode SupprimerClasse de la couche BLL

                    GestionClassesBLL.SupprimerClasse(Int32.Parse(dgv.CurrentRow.Cells[0].Value.ToString()));

                    dgv.Refresh();

                    // Une fois la suppression effectuée, rendre innopérants certains contrôles
                    lblNomClasse.Enabled = false;
                    txtNom.Enabled = false;
                    cbPossedeEDT.Enabled = false;
                    btnModif.Enabled = false;
                    btnSupp.Enabled = false;
                    btnAfficheEDT.Enabled = false;
                    // Vider le contenu dans le champ txtNom
                    txtNom.Clear();

                    // Actualisation du datagridview
                    // Création d'un objet List Classe à afficher dans le datagridview
                    List<ClasseBO> liste = new List<ClasseBO>();
                    liste = GestionClassesBLL.GetClasses();

                    // Rattachement de la List à la source de données du datagridview
                    dgv.DataSource = liste;

                    // Boite de dialogue qui confirme la suppression en BD
                    MessageBox.Show("Supression effectuée !", "Suppression");
                }
            }
        }

        // Redirection vers le formulaire d'ajout d'une classe
        private void btnFrmAjoutClasse_Click(object sender, EventArgs e)
        {
            frmAjoutClasses = new ajoutClasses();
            frmAjoutClasses.Show();
            this.Hide();
        }

        private void btnAfficheEDT_Click(object sender, EventArgs e)
        {
            OpenFileDialog edtAffiche = new OpenFileDialog();

            // Attribution à la source de AcrobatReader, le chemin de fichier (se trouvant dans le champs "txtEDT")
            pdfReaderEDT.src = txtEDT.Text;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClasseBO laClasse = new ClasseBO(Int32.Parse(dgv.CurrentRow.Cells[0].Value.ToString()), dgv.CurrentRow.Cells[1].Value.ToString(), dgv.CurrentRow.Cells[2].Value.ToString(), Boolean.Parse(dgv.CurrentRow.Cells[3].Value.ToString()), Boolean.Parse(dgv.CurrentRow.Cells[4].Value.ToString()));
            txtId.Text = laClasse.IdClasse.ToString();
            txtNom.Text = laClasse.NomClasse;
            txtEDT.Text = laClasse.EmploiDuTemps;
            cbPossedeEleve.Checked = laClasse.PossedeEleve;
            cbPossedeEDT.Checked = laClasse.PossedeEDT;

            // Dégriser les champs
            lblNomClasse.Enabled = true;
            txtNom.Enabled = true;
            btnModif.Enabled = true;
            btnSupp.Enabled = true;
            // Si une classe ne possède pas d'EDT
            if (cbPossedeEDT.Checked == false)
            {
                // Griser la checkbox et le bouton d'affichage de l'EDT
                cbPossedeEDT.Enabled = false;
                btnAfficheEDT.Enabled = false;
            }
            // Sinon
            else if (cbPossedeEDT.Checked == true)
            {
                // Dégriser la checkbox et le bouton d'affichage de l'EDT
                cbPossedeEDT.Enabled = true;
                btnAfficheEDT.Enabled = true;
            }

            // Si toutes les conditions ont été remplisent : clear les errorProvider
            // Ou si on clique sur un row de la dgv : clear les errorProvider
            errorNomClasse.SetError(txtNom, "");
            errorSuppClasse.SetError(btnSupp, "");
        }
    }
}
