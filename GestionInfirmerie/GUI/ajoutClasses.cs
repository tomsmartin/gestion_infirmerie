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
    public partial class ajoutClasses : Form
    {
        gestClasses frmGestClasses;
        modifClasse frmModifClasse;

        public ajoutClasses()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionClassesBLL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);
        }

        private void btnAjoutClasse_Click(object sender, EventArgs e)
        {
            if (this.txtNomClasse.TextLength == 0)
            {
                errorNomClasse.SetError(txtNomClasse, "Le champ ne peut pas être vide!");
            }
            else
            {
                // Boite de dialogue qui demande confirmation de la volonté d'ajouter l'enregistrement
                if (MessageBox.Show("Voulez-vous vraiment ajouter cette classe ?", "Ajout", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Préparation du selecteur de fichier
                    OpenFileDialog selectFichier = new OpenFileDialog();
                    // Filtrer les fichiers
                    selectFichier.Filter = "Fichiers PDF (*.pdf)|*.pdf";
                    // Titre du selecteur de fichier
                    selectFichier.Title = "Selectionnez un emploi du temps au format PDF";

                    // Si l'utilisateur a selectionné son fichier
                    if (selectFichier.ShowDialog() == DialogResult.OK)
                    {

                        GestionClassesBLL.CreerUneClasseAvecEDT(txtNomClasse.Text.ToString(), selectFichier.FileName);
                    }
                    // Si l'utilisateur n'a pas selectionné de fichier
                    else
                    {
                        // Utilisation d'un fichier par défaut
                        // Créer un dossier dans le disque dur C et le nommer "ppe_c_sharp" et y mettre un fichier pdf vide et le nommer "classe_sans_edt.pdf"
                        selectFichier.FileName = "C:\\Users\\Public\\Documents\\c_sharp\\gestion_infirmerie_sprint_5\\classe_sans_edt.pdf";

                        GestionClassesBLL.CreerUneClasseSansEDT(txtNomClasse.Text.ToString(), selectFichier.FileName);
                    }


                    // Redirection vers le formulaire contenant la liste des classes (dgv)
                    frmModifClasse = new modifClasse();
                    frmModifClasse.Show();
                    this.Hide();
                }
            }
        }

        // Bouton Annuler
        private void btnRetour_Click(object sender, EventArgs e)
        {
            frmGestClasses = new gestClasses();
            frmGestClasses.Show();
            this.Hide();
        }
    }
}
