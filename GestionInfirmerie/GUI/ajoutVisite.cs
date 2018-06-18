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
    public partial class ajoutVisite : Form
    {
        public ajoutVisite()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionElevesBLL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);

            // Création d'un objet List d'élèves à afficher dans le datagridview
            List<EleveBO> liste = new List<EleveBO>();
            liste = GestionElevesBLL.GetEleves();

            // Rattachement de la List à la source de données du datagridview
            dgv.DataSource = liste;

            // Caché la colonne de l'id, date de naissance, santé, les téléphones, archives, tiers temps et visite
            dgv.Columns[11].Visible = false;
            dgv.Columns[3].Visible = false;
            dgv.Columns[4].Visible = false;
            dgv.Columns[5].Visible = false;
            dgv.Columns[6].Visible = false;
            dgv.Columns[7].Visible = false;
            dgv.Columns[8].Visible = false;
            dgv.Columns[9].Visible = false;
            dgv.Columns[10].Visible = false;

            // Renommer les colonnes
            // -------------------
            // -------------------
            dgv.Columns[0].HeaderText = "Nom";
            dgv.Columns[1].HeaderText = "Prénom";
            dgv.Columns[2].HeaderText = "Date de naissance";

            txtNom.Enabled = false;
            txtPrenom.Enabled = false;
            heureArriveVisite.Enabled = false;
            heureDepartVisite.Enabled = false;
            poulsVisite.Enabled = false;
            dateVisite.Enabled = false;
            motifVisite.Enabled = false;
            domicileVisite.Enabled = false;
            hopitalVisite.Enabled = false;
            parentsVisite.Enabled = false;
            comVisite.Enabled = false;
            btnApp.Enabled = false;
            comboBox1.Enabled = false;
            qteMedics.Enabled = false;

           
        }

        private void btnApp_Click(object sender, EventArgs e)
        {

            if (this.motifVisite.TextLength == 0 || this.txtNom.TextLength == 0 || this.txtPrenom.TextLength == 0 || this.poulsVisite.TextLength == 0 || this.poulsVisite.TextLength == 28)
            {
                if (this.motifVisite.TextLength == 0)
                {
                    errorPouls.SetError(this.poulsVisite, String.Empty);
                    errorQteMedic.SetError(this.qteMedics, String.Empty);
                    errorMotif.SetError(motifVisite, "Le champ ne peut pas être vide!");
                }
                else
                {
                    if (this.txtNom.TextLength == 0)
                    {
                        errorNom.SetError(txtNom, "Le champ ne peut pas être vide!");
                    }
                    else
                    {
                        if (this.txtPrenom.TextLength == 0)
                        {
                            errorPrenom.SetError(txtPrenom, "Le champ ne peut pas être vide!");
                        }
                        else
                        {
                            if (this.poulsVisite.TextLength == 0)
                            {
                                errorMotif.SetError(this.motifVisite, String.Empty);
                                errorQteMedic.SetError(this.qteMedics, String.Empty);
                                errorPouls.SetError(poulsVisite, "Le champ ne peut pas être vide!");
                            }
                            else
                            {
                                if (this.poulsVisite.TextLength == 28)
                                {
                                    errorMotif.SetError(this.motifVisite, String.Empty);
                                    errorPouls.SetError(this.poulsVisite, String.Empty);
                                    errorQteMedic.SetError(this.qteMedics, String.Empty);
                                    errorPouls.SetError(poulsVisite, "Vous devez saisir un chiffre!");
                                }
                                else
                                {
                                    if (this.comboBox1.Items.Count != 0 && this.qteMedics.TextLength == 0)
                                    {
                                        errorMotif.SetError(this.motifVisite, String.Empty);
                                        errorPouls.SetError(this.poulsVisite, String.Empty);
                                        errorQteMedic.SetError(this.qteMedics, String.Empty);
                                        errorQteMedic.SetError(qteMedics, "Vous devez saisir un chiffre!");

                                    }
                                }
                            }
                        }
                    }
                }

            }
            else
            {
                // Boite de dialogue qui demande confirmation de la volonté d'ajouter une visite
                if (MessageBox.Show("Voulez-vous vraiment ajout cette visite ?", "Visite", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Actions effectuées si Oui est cliqué dans la message box
                    // Appel de la méthode AjoutVisiter de la couche BLL

                    GestionVisiteBLL.CreerUneVisite(motifVisite.Text, comVisite.Text.ToString(), heureArriveVisite.Value, heureDepartVisite.Value, dateVisite.Value, domicileVisite.Checked, hopitalVisite.Checked, parentsVisite.Checked, poulsVisite.Text, Int32.Parse(qteMedics.Text.ToString()), Int32.Parse(textId.Text.ToString()));

                    VisiteBO uneVisite = new VisiteBO(motifVisite.Text, comVisite.Text.ToString(), heureArriveVisite.Value, heureDepartVisite.Value, dateVisite.Value, domicileVisite.Checked, hopitalVisite.Checked, parentsVisite.Checked, poulsVisite.Text, Int32.Parse(qteMedics.Text.ToString()), Int32.Parse(textId.Text.ToString()));
                    int idVisite = GestionVisiteBLL.GetIdVisite(uneVisite);

                    GestionVisiteBLL.AjoutPrescrire(idVisite, Convert.ToInt32(comboBox1.SelectedValue));

                    // Actualisation du datagridview
                    // Création d'un objet List d'Eleve à afficher dans le datagridview
                    List<EleveBO> liste = new List<EleveBO>();
                    liste = GestionElevesBLL.GetEleves();

                    //on rend inactif les champs
                    heureArriveVisite.Enabled = false;
                    heureDepartVisite.Enabled = false;
                    poulsVisite.Enabled = false;
                    dateVisite.Enabled = false;
                    motifVisite.Enabled = false;
                    domicileVisite.Enabled = false;
                    hopitalVisite.Enabled = false;
                    parentsVisite.Enabled = false;
                    comVisite.Enabled = false;
                    btnApp.Enabled = false;
                    comboBox1.Enabled = false;
                    qteMedics.Enabled = false;


                    //on enlève les erreurs providers
                    errorMotif.SetError(this.motifVisite, String.Empty);
                    errorDepart.SetError(this.heureDepartVisite, String.Empty);
                    errorArrivee.SetError(this.heureDepartVisite, String.Empty);
                    errorPouls.SetError(this.poulsVisite, String.Empty);

                    // Rattachement de la List à la source de données du datagridview
                    dgv.DataSource = liste;
                    // Boite de dialogue qui confirme l'ajout en BD
                    MessageBox.Show("Ajout effectuée !", "Ajout d'une visite");

                    //on vide les champs apres l'ajout
                    txtNom.Clear();
                    txtPrenom.Clear();
                    motifVisite.Clear();
                    poulsVisite.Clear();
                    comVisite.Clear();
                    domicileVisite.Checked = false;
                    hopitalVisite.Checked = false;
                    parentsVisite.Checked = false;
                    qteMedics.Clear();

                }
            }
        }


        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EleveBO ut = new EleveBO(Int32.Parse(dgv.CurrentRow.Cells[11].Value.ToString()), dgv.CurrentRow.Cells[0].Value.ToString(), dgv.CurrentRow.Cells[1].Value.ToString(), DateTime.Parse(dgv.CurrentRow.Cells[2].Value.ToString()), dgv.CurrentRow.Cells[3].Value.ToString(), dgv.CurrentRow.Cells[4].Value.ToString(), dgv.CurrentRow.Cells[5].Value.ToString(), dgv.CurrentRow.Cells[6].Value.ToString(), Boolean.Parse(dgv.CurrentRow.Cells[7].Value.ToString()), Boolean.Parse(dgv.CurrentRow.Cells[8].Value.ToString()), Boolean.Parse(dgv.CurrentRow.Cells[9].Value.ToString()), Int32.Parse(dgv.CurrentRow.Cells[11].Value.ToString()));
            textId.Text = ut.IdEleve.ToString();
            txtNom.Text = ut.NomEleve;
            txtPrenom.Text = ut.PrenomEleve;

            heureArriveVisite.Enabled = true;
            heureDepartVisite.Enabled = true;
            poulsVisite.Enabled = true;
            dateVisite.Enabled = true;
            motifVisite.Enabled = true;
            domicileVisite.Enabled = true;
            hopitalVisite.Enabled = true;
            parentsVisite.Enabled = true;
            comVisite.Enabled = true;
            btnApp.Enabled = true;
            comboBox1.Enabled = true;
            qteMedics.Enabled = true;
        }

        private void rechercheNom_KeyUp(object sender, KeyEventArgs e)
        {
            string search = rechercheNom.Text;
            List<EleveBO> liste = new List<EleveBO>();
            liste = GestionElevesBLL.GetEleveSearch(search);
            dgv.DataSource = liste;
        }

        private void poulsVisite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void ajoutVisite_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestion_infirmerieDataSet3.medicament'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.medicamentTableAdapter.Fill(this.gestion_infirmerieDataSet3.medicament);
            poulsVisite.Text = "Vous devez saisir un chiffre";
        }

        private void poulsVisite_Enter(object sender, EventArgs e)
        {
            if (poulsVisite.Text == "Vous devez saisir un chiffre")
            {
                poulsVisite.Text = "";
            }
        }

        private void poulsVisite_Leave(object sender, EventArgs e)
        {
            if (poulsVisite.Text == "")
            {
                poulsVisite.Text = "Vous devez saisir un chiffre";
                poulsVisite.ForeColor = Color.Gray;
            }
        }
    }
}
