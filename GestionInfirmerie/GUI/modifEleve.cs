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
    public partial class modifEleve : Form
    {
        public modifEleve()
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

            txtNom.Enabled = false;
            txtPrenom.Enabled = false;
            dateNaissance.Enabled = false;
            txtSante.Enabled = false;
            txtTelEleve.Enabled = false;
            txtTelPere.Enabled = false;
            txtTelMere.Enabled = false;
            cbArchive.Enabled = false;
            cbTiersTemps.Enabled = false;
            cbVisite.Enabled = false;
            lblNom.Enabled = false;
            lblPrenom.Enabled = false;
            lblDateNaiss.Enabled = false;
            lblSante.Enabled = false;
            lblTelEleve.Enabled = false;
            lblTelPere.Enabled = false;
            lblTelMere.Enabled = false;
            btnApp.Enabled = false;
            btnSup.Enabled = false;
            cbClasse.Enabled = false;
        }

        // Bouton supprimer
        private void btnSup_CLick(object sender, EventArgs e)
        {
            // Boite de dialogue qui demande confirmation de la volonté de supprimer l'enregistrement
            if (MessageBox.Show("Voulez-vous vraiment supprimer cet élèves ?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Actions effectuées si Oui est cliqué dans la message box
                // Appel de la méthode SupprimerEleve de la couche BLL

                if (cbVisite.Checked == true)
                {
                    erreurSupEleve.SetError(cbVisite, "ATTENTION !");
                    MessageBox.Show("IMPOSSIBLE ! Cet élève possède une ou plusieurs visite(s) !", "ERREUR");
                }
                else
                {
                    GestionElevesBLL.SupprimerEleve(Int32.Parse(dgv.CurrentRow.Cells[11].Value.ToString()));

                    dgv.Refresh();

                    // Une fois la suppression effectuée, rendre innopérants certains contrôles
                    txtNom.Enabled = false;
                    txtPrenom.Enabled = false;
                    dateNaissance.Enabled = false;
                    txtSante.Enabled = false;
                    txtTelEleve.Enabled = false;
                    txtTelPere.Enabled = false;
                    txtTelMere.Enabled = false;
                    cbArchive.Enabled = false;
                    cbTiersTemps.Enabled = false;
                    cbVisite.Enabled = false;
                    lblNom.Enabled = false;
                    lblPrenom.Enabled = false;
                    lblDateNaiss.Enabled = false;
                    lblSante.Enabled = false;
                    lblTelEleve.Enabled = false;
                    lblTelPere.Enabled = false;
                    lblTelMere.Enabled = false;
                    btnApp.Enabled = false;
                    btnSup.Enabled = false;
                    cbClasse.Enabled = false;
                    label1.Enabled = false;


                    // Actualisation du datagridview
                    // Création d'un objet List Eleve à afficher dans le datagridview
                    List<EleveBO> liste = new List<EleveBO>();
                    liste = GestionElevesBLL.GetEleves();

                    // Rattachement de la List à la source de données du datagridview
                    dgv.DataSource = liste;

                    // Boite de dialogue qui confirme la suppression en BD
                    MessageBox.Show("Supression effectuée !", "Suppression");
                }
            }
        }


        private void txtId_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestion_infirmerieDataSet1.classe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.classeTableAdapter.Fill(this.gestion_infirmerieDataSet1.classe);
        }

        
        //Bouton modifier
        private void btnApp_Click_1(object sender, EventArgs e)
        {

            if (this.txtNom.TextLength == 0 || this.txtPrenom.TextLength == 0 || this.txtTelEleve.TextLength == 0 || this.txtTelPere.TextLength == 0 || this.txtTelMere.TextLength == 0)
            {
                if (this.txtNom.TextLength == 0)
                {
                    errorProviderPrenom.SetError(this.txtPrenom, String.Empty);
                    errorProviderTelEl.SetError(this.txtTelEleve, String.Empty);
                    errorProviderTelPere.SetError(this.txtTelPere, String.Empty);
                    errorProviderTelMere.SetError(this.txtTelMere, String.Empty);
                    errorProviderNom.SetError(txtNom, "Le champ ne peut pas être vide!");
                }
                else
                {
                    if (this.txtPrenom.TextLength == 0)
                    {
                        errorProviderNom.SetError(this.txtNom, String.Empty);
                        errorProviderTelEl.SetError(this.txtTelEleve, String.Empty);
                        errorProviderTelPere.SetError(this.txtTelPere, String.Empty);
                        errorProviderTelMere.SetError(this.txtTelMere, String.Empty);
                        errorProviderPrenom.SetError(txtPrenom, "Le champ ne peut pas être vide!");
                    }
                    else
                    {
                        if (this.txtTelEleve.TextLength == 0)
                        {
                            errorProviderNom.SetError(this.txtNom, String.Empty);
                            errorProviderPrenom.SetError(this.txtPrenom, String.Empty);
                            errorProviderTelPere.SetError(this.txtTelPere, String.Empty);
                            errorProviderTelMere.SetError(this.txtTelMere, String.Empty);
                            errorProviderTelEl.SetError(txtTelEleve, "Le champ ne peut pas être vide!");
                        }
                        else 
                        {
                            if (this.txtTelPere.TextLength == 0)
                            {
                                errorProviderNom.SetError(this.txtNom, String.Empty);
                                errorProviderPrenom.SetError(this.txtPrenom, String.Empty);
                                errorProviderTelEl.SetError(this.txtTelEleve, String.Empty);
                                errorProviderTelMere.SetError(this.txtTelMere, String.Empty);
                                errorProviderTelPere.SetError(txtTelPere, "Le champ ne peut pas être vide!");
                            }
                            else
                            {
                                if (this.txtTelMere.TextLength == 0)
                                {
                                    errorProviderNom.SetError(this.txtNom, String.Empty);
                                    errorProviderPrenom.SetError(this.txtPrenom, String.Empty);
                                    errorProviderTelEl.SetError(this.txtTelEleve, String.Empty);
                                    errorProviderTelPere.SetError(this.txtTelPere, String.Empty);
                                    errorProviderTelMere.SetError(txtTelMere, "Le champ ne peut pas être vide!");
                                }
                            }
                        }

                    }
                }

            }
            else
            {
                // Boite de dialogue qui demande confirmation de la volonté de modifier l'enregistrement
                if (MessageBox.Show("Voulez-vous vraiment modifier cet élèves ?", "Modif", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Actions effectuées si Oui est cliqué dans la message box
                    // Appel de la méthode ModifierEleve de la couche BLL

                    GestionElevesBLL.ModifierEleve(Int32.Parse(textId.Text.ToString()), txtNom.Text, txtPrenom.Text, dateNaissance.Value, txtSante.Text.ToString(), txtTelEleve.Text, txtTelPere.Text, txtTelMere.Text, cbArchive.Checked, cbTiersTemps.Checked, cbVisite.Checked, Int32.Parse(cbClasse.SelectedValue.ToString()));
                    
                    // Actualisation du datagridview
                    // Création d'un objet List d'Utilisateur à afficher dans le datagridview
                    List<EleveBO> liste = new List<EleveBO>();
                    liste = GestionElevesBLL.GetEleves();

                    //on efface les erros providers
                    errorProviderNom.SetError(this.txtNom, String.Empty);
                    errorProviderPrenom.SetError(this.txtPrenom, String.Empty);
                    errorProviderTelEl.SetError(this.txtTelEleve, String.Empty);
                    errorProviderTelPere.SetError(this.txtTelPere, String.Empty);
                    errorProviderTelMere.SetError(this.txtTelMere, String.Empty);

                    //on rend inactif les champs
                    txtNom.Enabled = false;
                    txtPrenom.Enabled = false;
                    dateNaissance.Enabled = false;
                    txtSante.Enabled = false;
                    txtTelEleve.Enabled = false;
                    txtTelPere.Enabled = false;
                    txtTelMere.Enabled = false;
                    cbArchive.Enabled = false;
                    cbTiersTemps.Enabled = false;
                    cbVisite.Enabled = false;
                    lblNom.Enabled = false;
                    lblPrenom.Enabled = false;
                    lblDateNaiss.Enabled = false;
                    lblSante.Enabled = false;
                    lblTelEleve.Enabled = false;
                    lblTelPere.Enabled = false;
                    lblTelMere.Enabled = false;
                    btnApp.Enabled = false;
                    btnSup.Enabled = false;
                    cbClasse.Enabled = false;

                    
                    // Rattachement de la List à la source de données du datagridview
                    dgv.DataSource = liste;
                    // Boite de dialogue qui confirme la modification en BD
                    MessageBox.Show("Modification effectuée !", "Modification");
                }            
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EleveBO ut = new EleveBO(Int32.Parse(dgv.CurrentRow.Cells[11].Value.ToString()), dgv.CurrentRow.Cells[0].Value.ToString(), dgv.CurrentRow.Cells[1].Value.ToString(), DateTime.Parse(dgv.CurrentRow.Cells[2].Value.ToString()), dgv.CurrentRow.Cells[3].Value.ToString(), dgv.CurrentRow.Cells[4].Value.ToString(), dgv.CurrentRow.Cells[5].Value.ToString(), dgv.CurrentRow.Cells[6].Value.ToString(), Boolean.Parse(dgv.CurrentRow.Cells[7].Value.ToString()), Boolean.Parse(dgv.CurrentRow.Cells[8].Value.ToString()), Boolean.Parse(dgv.CurrentRow.Cells[9].Value.ToString()), Int32.Parse(dgv.CurrentRow.Cells[11].Value.ToString()));
            textId.Text = ut.IdEleve.ToString();
            txtNom.Text = ut.NomEleve;
            txtPrenom.Text = ut.PrenomEleve;
            dateNaissance.Value = ut.DateNaissanceEleve;
            txtSante.Text = ut.SanteEleve;
            txtTelEleve.Text = ut.TelEleve;
            txtTelPere.Text = ut.TelPereELeve;
            txtTelMere.Text = ut.TelMereEleve;
            cbArchive.Checked = ut.ArchiveEleve;
            cbTiersTemps.Checked = ut.TiersTemps;
            cbVisite.Checked = ut.VisiteInfirmerie;
           
            dateNaissance.Enabled = true;
            txtSante.Enabled = true;
            txtTelEleve.Enabled = true;
            txtTelPere.Enabled = true;
            txtTelMere.Enabled = true;
            cbArchive.Enabled = true;
            cbTiersTemps.Enabled = true;
            cbVisite.Enabled = true;
            lblNom.Enabled = true;
            lblPrenom.Enabled = true;
            lblDateNaiss.Enabled = true;
            lblSante.Enabled = true;
            lblTelEleve.Enabled = true;
            lblTelPere.Enabled = true;
            lblTelMere.Enabled = true;
            btnApp.Enabled = true;
            btnSup.Enabled = true;
            cbClasse.Enabled = true;
            label1.Enabled = true;
        }
    }
}
