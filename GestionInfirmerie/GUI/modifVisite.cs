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
using System.Globalization;

namespace GUI
{
    public partial class modifVisite : Form
    {
        public modifVisite()
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

            motifTxt.Enabled = false;
            entreeTxt.Enabled = false;
            sortieTxt.Enabled = false;
            poulsTxt.Enabled = false;
            comboBox1.Enabled = false;
            qteMedics.Enabled = false;
            dateTxt.Enabled = false;
            commentaireTxt.Enabled = false;
            hopitalCk.Enabled = false;
            prevenuCk.Enabled = false;
            domicileCk.Enabled = false;
            nomTxt.Enabled = false;
            prenomTxt.Enabled = false;
            validerBtn.Enabled = false;
        }

        private void validerBtn_Click(object sender, EventArgs e)
        {
            if (this.motifTxt.TextLength == 0 || this.poulsTxt.TextLength == 0)
            {
                if (this.motifTxt.TextLength == 0)
                {
                    errorEntree.SetError(this.entreeTxt, String.Empty);
                    errorSortie.SetError(this.sortieTxt, String.Empty);
                    errorPouls.SetError(this.poulsTxt, String.Empty);
                    errorMotif.SetError(motifTxt, "Le champ ne peut pas être vide!");
                }
                else
                {
                    if (this.poulsTxt.TextLength == 0)
                    {
                        errorMotif.SetError(this.motifTxt, String.Empty);
                        errorEntree.SetError(this.entreeTxt, String.Empty);
                        errorSortie.SetError(this.sortieTxt, String.Empty);
                        errorPouls.SetError(poulsTxt, "Le champ ne peut pas être vide!");
                    }
                }

            }
            // Boite de dialogue qui demande confirmation de la volonté de modifier l'enregistrement
            else
            {
                if (MessageBox.Show("Voulez-vous vraiment modifier cet élèves ?", "Modif", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Actions effectuées si Oui est cliqué dans la message box
                    // Appel de la méthode ModifierEleve de la couche BLL

                    GestionVisiteBLL.ModifierVisite(Int32.Parse(visiteID.Text.ToString()), motifTxt.Text, commentaireTxt.Text, dateTxt.Value, entreeTxt.Value, sortieTxt.Value, domicileCk.Checked, hopitalCk.Checked, prevenuCk.Checked, poulsTxt.Text, Int32.Parse(qteMedics.Text.ToString()), Int32.Parse(eleveId.Text.ToString()));

                    //// Récupération de l'ID de la visite
                    int idVisite = Int32.Parse(visiteID.Text.ToString());

                    //// Récupération de l'ID médicament séléctionné
                    int idMedoc = Convert.ToInt32(comboBox1.SelectedValue);

                    //// Modification de la table Prescrire dans la base de donnée
                    GestionVisiteBLL.ModifPrescrire(idVisite, idMedoc);

                    // Actualisation du datagridview
                    // Création d'un objet List d'Utilisateur à afficher dans le datagridview
                    List<VisiteBO> liste = new List<VisiteBO>();
                    liste = GestionVisiteBLL.GetVisite();

                    //on rend inactif les champs
                    motifTxt.Enabled = false;
                    entreeTxt.Enabled = false;
                    sortieTxt.Enabled = false;
                    poulsTxt.Enabled = false;
                    comboBox1.Enabled = false;
                    qteMedics.Enabled = false;
                    dateTxt.Enabled = false;
                    commentaireTxt.Enabled = false;
                    hopitalCk.Enabled = false;
                    prevenuCk.Enabled = false;
                    domicileCk.Enabled = false;
                    nomTxt.Enabled = false;
                    prenomTxt.Enabled = false;
                    validerBtn.Enabled = false;

                    //on efface les erros providers
                    errorMotif.SetError(this.motifTxt, String.Empty);
                    errorEntree.SetError(this.entreeTxt, String.Empty);
                    errorSortie.SetError(this.sortieTxt, String.Empty);
                    errorPouls.SetError(this.poulsTxt, String.Empty);

                    // Rattachement de la List à la source de données du datagridview
                    dgv.DataSource = liste;
                    // Boite de dialogue qui confirme la modification en BD
                    MessageBox.Show("Modification effectuée !", "Modification");
                }
            }  
        }

        private void poulsTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            VisiteBO ut = new VisiteBO(Int32.Parse(dgv.CurrentRow.Cells[0].Value.ToString()),
                dgv.CurrentRow.Cells[1].Value.ToString(),
                dgv.CurrentRow.Cells[2].Value.ToString(),
                Convert.ToDateTime(dgv.CurrentRow.Cells[3].Value.ToString()),
                Convert.ToDateTime(dgv.CurrentRow.Cells[4].Value.ToString()),
                Convert.ToDateTime(dgv.CurrentRow.Cells[5].Value.ToString()),
                Boolean.Parse(dgv.CurrentRow.Cells[6].Value.ToString()),
                Boolean.Parse(dgv.CurrentRow.Cells[7].Value.ToString()),
                Boolean.Parse(dgv.CurrentRow.Cells[8].Value.ToString()),
                dgv.CurrentRow.Cells[9].Value.ToString(),
                Int32.Parse(dgv.CurrentRow.Cells[13].Value.ToString()),
                Int32.Parse(dgv.CurrentRow.Cells[10].Value.ToString()),
                dgv.CurrentRow.Cells[11].Value.ToString(),
                dgv.CurrentRow.Cells[12].Value.ToString());

            visiteID.Text = ut.IdVisite.ToString();
            motifTxt.Text = ut.Motif;
            commentaireTxt.Text = ut.Commentaire;
            dateTxt.Value = ut.DateVisite;
            entreeTxt.Value = ut.HeureArrive;
            sortieTxt.Value = ut.HeureDepart;
            domicileCk.Checked = ut.RetourDomicile;
            hopitalCk.Checked = ut.Hopital;
            prevenuCk.Checked = ut.ParentsPrevenus;
            poulsTxt.Text = ut.Pouls;
            qteMedics.Text = ut.QteMedicament.ToString();
            eleveId.Text = ut.IdEleve.ToString();
            nomTxt.Text = ut.NomEleve;
            prenomTxt.Text = ut.PrenomEleve;

            int idMedic ;
            idMedic = GestionMedicamentsBLL.afficheIdMedicament(ut.IdVisite);
            string libMedicament;
            libMedicament = GestionMedicamentsBLL.afficheLibMedicament(idMedic);
            comboBox1.SelectedValue = idMedic;



            motifTxt.Enabled = true;
            entreeTxt.Enabled = true;
            sortieTxt.Enabled = true;
            poulsTxt.Enabled = true;
            comboBox1.Enabled = true;
            qteMedics.Enabled = true;
            dateTxt.Enabled = true;
            commentaireTxt.Enabled = true;
            hopitalCk.Enabled = true;
            prevenuCk.Enabled = true;
            domicileCk.Enabled = true;
            validerBtn.Enabled = true;
        }

        private void modifVisite_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestion_infirmerieDataSet2.medicament'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.medicamentTableAdapter.Fill(this.gestion_infirmerieDataSet2.medicament);

        }
    }
}
