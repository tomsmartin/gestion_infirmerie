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
    public partial class Synthese : Form
    {
        public Synthese()
        {
            InitializeComponent();
            GestionVisiteBLL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);
        }

        private void btnTempMoyen_Click(object sender, EventArgs e)
        {
            // Controles de saisie
            if (dtpDateDebut.Value.ToString() == dtpDateFin.Value.ToString())
            {
                errorPeriodeInfo.SetError(dtpDateDebut, "Une période entre \"deux moments identiques\" n'est pas possible");
                errorPeriode.SetError(dtpDateFin, "Date de début : " + dtpDateDebut.Value.ToString() + " || Date de fin : " + dtpDateFin.Value.ToString());
            }
            else if (DateTime.Parse(dtpDateDebut.Value.ToString()) > DateTime.Parse(dtpDateFin.Value.ToString()))
            {
                errorPeriode.SetError(dtpDateFin, "Veuillez modifier la date de fin afin qu'elle soit supérieur à la date de début !");
            }
            else
            {
                string dateDebut = dtpDateDebut.Value.ToShortDateString();
                string dateFin = dtpDateFin.Value.ToShortDateString();
                DateTime dateDebutDT = dtpDateDebut.Value;
                DateTime dateFinDT = dtpDateFin.Value;
                int nbVisite;

                nbVisite = GestionVisiteBLL.afficheNbVisiteParPeriode(dateDebut, dateFin);

                double sommeTemps = GestionVisiteBLL.tempsVisite(dateDebutDT, dateFinDT);

                double temps = (sommeTemps / nbVisite);
                temps = Math.Floor(temps);

                MessageBox.Show("Il y a une moyenne de " + temps.ToString() + " temps par visite");
            }
        }

        private void btnMoyVisite_Click(object sender, EventArgs e)
        {
            // Controles de saisie
            if (dtpDateDebut.Value.ToString() == dtpDateFin.Value.ToString())
            {
                errorPeriodeInfo.SetError(dtpDateDebut, "Une période entre \"deux moments identiques\" n'est pas possible");
                errorPeriode.SetError(dtpDateFin, "Date de début : " + dtpDateDebut.Value.ToString() + " || Date de fin : " + dtpDateFin.Value.ToString());
            }
            else if (DateTime.Parse(dtpDateDebut.Value.ToString()) > DateTime.Parse(dtpDateFin.Value.ToString()))
            {
                errorPeriode.SetError(dtpDateFin, "Veuillez modifier la date de fin afin qu'elle soit supérieur à la date de début !");
            }
            else
            {
                string dateDebut = dtpDateDebut.Value.ToShortDateString();
                string dateFin = dtpDateFin.Value.ToShortDateString();
                int nbVisite;
                double moyenneVisiteParPeriodeParEleve;

                nbVisite = GestionVisiteBLL.afficheNbVisiteParPeriode(dateDebut, dateFin);

                moyenneVisiteParPeriodeParEleve = GestionVisiteBLL.afficheNbVisiteParPeriodeParEleve(nbVisite);
                MessageBox.Show("Il y a une moyenne de " + moyenneVisiteParPeriodeParEleve + " visites par élève");
            }
        }

        private void btnTotalVisite_Click(object sender, EventArgs e)
        {
            // Controles de saisie
            if (dtpDateDebut.Value.ToString() == dtpDateFin.Value.ToString())
            {
                errorPeriodeInfo.SetError(dtpDateDebut, "Une période entre \"deux moments identiques\" n'est pas possible");
                errorPeriode.SetError(dtpDateFin, "Date de début : " + dtpDateDebut.Value.ToString() + " || Date de fin : " + dtpDateFin.Value.ToString());
            }
            else if (DateTime.Parse(dtpDateDebut.Value.ToString()) > DateTime.Parse(dtpDateFin.Value.ToString()))
            {
                errorPeriode.SetError(dtpDateFin, "Veuillez modifier la date de fin afin qu'elle soit supérieur à la date de début !");
            }
            else
            {
                string dateDebut = dtpDateDebut.Value.ToShortDateString();
                string dateFin = dtpDateFin.Value.ToShortDateString();
                int nbVisite;
                nbVisite = GestionVisiteBLL.afficheNbVisiteParPeriode(dateDebut, dateFin);

                MessageBox.Show("Il y a un total de " + nbVisite + " visites sur la période choisi");
            }
        }

        private void btnTotalEle_Click(object sender, EventArgs e)
        {
            // Controles de saisie
            if (dtpDateDebut.Value.ToString() == dtpDateFin.Value.ToString())
            {
                errorPeriodeInfo.SetError(dtpDateDebut, "Une période entre \"deux moments identiques\" n'est pas possible");
                errorPeriode.SetError(dtpDateFin, "Date de début : " + dtpDateDebut.Value.ToString() + " || Date de fin : " + dtpDateFin.Value.ToString());
            }
            else if (DateTime.Parse(dtpDateDebut.Value.ToString()) > DateTime.Parse(dtpDateFin.Value.ToString()))
            {
                errorPeriode.SetError(dtpDateFin, "Veuillez modifier la date de fin afin qu'elle soit supérieur à la date de début !");
            }
            else
            {
                string dateDebut = dtpDateDebut.Value.ToShortDateString();
                string dateFin = dtpDateFin.Value.ToShortDateString();
                int nbEleve;
                nbEleve = GestionElevesBLL.afficheNbEleveParPeriode(dateDebut, dateFin);

                MessageBox.Show("Il y a un total de " + nbEleve + " élève qui sont passé faire une visite sur la période choisi");
            }
        }

        private void btnTotalMedi_Click(object sender, EventArgs e)
        {
            // Controles de saisie
            if (dtpDateDebut.Value.ToString() == dtpDateFin.Value.ToString())
            {
                errorPeriodeInfo.SetError(dtpDateDebut, "Une période entre \"deux moments identiques\" n'est pas possible");
                errorPeriode.SetError(dtpDateFin, "Date de début : " + dtpDateDebut.Value.ToString() + " || Date de fin : " + dtpDateFin.Value.ToString());
            }
            else if (DateTime.Parse(dtpDateDebut.Value.ToString()) > DateTime.Parse(dtpDateFin.Value.ToString()))
            {
                errorPeriode.SetError(dtpDateFin, "Veuillez modifier la date de fin afin qu'elle soit supérieur à la date de début !");
            }
            else
            {
                string dateDebut = dtpDateDebut.Value.ToShortDateString();
                string dateFin = dtpDateFin.Value.ToShortDateString();
                int nbMecicament;
                nbMecicament = GestionMedicamentsBLL.nbMedicamentParPeriode(dateDebut, dateFin);

                MessageBox.Show("Il y a un total de " + nbMecicament + " médicaments qui a été distribué sur la période choisit");
            }
        }

        private void dtpDateFin_ValueChanged(object sender, EventArgs e)
        {
            // Controles de saisie
            if (DateTime.Parse(dtpDateDebut.Value.ToString()) > DateTime.Parse(dtpDateFin.Value.ToString()))
            {
                errorPeriode.SetError(dtpDateFin, "Erreur : La date de fin doit être supérieur à la date de début");
            }
            // Si toutes les conditions ont été remplisent : clear les errorProvider
            else
            {
                errorPeriode.SetError(dtpDateFin, "");
            }
        }

        private void btnNbMoyenMed_Click(object sender, EventArgs e)
        {
            int nbVisite;
            double moyenneVisiteParEleve;

            nbVisite = GestionMedicamentsBLL.afficheNbTotalVisite();
            moyenneVisiteParEleve = GestionMedicamentsBLL.afficheNbMoyenMedParVisite();

            // Controle de saisie
            if (nbVisite == 0)
            {
                erreurAucuneVisite.SetError(btnNbMoyenMed, "Il n'y a une visite d'enregistrée donc impossible d'effectuer la moyenne");
            }
            else
            {
                MessageBox.Show("Il y a en moyenne " + moyenneVisiteParEleve + " médicaments utilisés par visite");
            }
        }

        private void btnNbMoyenMed_Validated(object sender, EventArgs e)
        {
            // Si toutes les conditions ont été remplisent : clear les errorProvider
            erreurAucuneVisite.SetError(btnNbMoyenMed, "");
        }

        private void btnMoyVisite_Validated(object sender, EventArgs e)
        {
            // Si toutes les conditions ont été remplisent : clear les errorProvider
            errorPeriodeInfo.SetError(dtpDateDebut, "");
            errorPeriode.SetError(dtpDateFin, "");
        }
    }
}
