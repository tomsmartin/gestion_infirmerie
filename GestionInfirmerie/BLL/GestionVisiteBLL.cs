using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using BO;
using DAL;

namespace BLL
{
    public class GestionVisiteBLL
    {
        private static GestionVisiteBLL uneGestionVisite; // objet BLL

        // Accesseur en lecture
        public static GestionVisiteBLL GetGestionVisite()
        {
            if (uneGestionVisite == null)
            {
                uneGestionVisite = new GestionVisiteBLL();
            }
            return uneGestionVisite;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        #region // Méthode qui renvoit une List d'objets visite en faisant appel à la méthode GetVisite() de la DAL
        public static List<VisiteBO> GetVisite()
        {
            return VisiteDAL.GetVisite();
        }
        #endregion

        #region // Méthode qui recherche un nom dans une List d'objets Visite en faisant appel à la méthode GetVisite() de la DAL
        // Méthode qui cherche dans une List d'objets Visite en faisant appel à la méthode GetVisite() de la DAL
        public static List<VisiteBO> GetVisiteSearch(string search)
        {
            return VisiteDAL.GetVisiteSearch(search);
        }

        #endregion

        #region // Méthode qui créer un nouvel objet Visite
        // Méthode qui créer un nouvel objet Visite le renvoi en l'ajoutant à la
        // BD avec la méthode AjoutVisite de la DAL
        public static int CreerUneVisite(string motif, string commentaire, DateTime hArrive, DateTime hDepart, DateTime dateVisite, bool domicile, bool hopital, bool parents, string pouls, int qteMedicament, int eleve)
        {
            VisiteBO visi;
            visi = new VisiteBO(motif, commentaire, hArrive, hDepart, dateVisite, domicile, hopital, parents, pouls, qteMedicament, eleve);
            return VisiteDAL.AjoutVisite(visi);
        }
        #endregion

        #region // Méthode qui modifie une visite avec la méthode de la DAL
        // Méthode qui modifie un nouvel visite avec la méthode UpdateUtilisateur de la DAL
        public static int ModifierVisite(int id, string motif, string commentaire, DateTime dateAjout, DateTime heureArr, DateTime heureDep, bool retour, bool hopital, bool prevenu, string pouls, int qteMedicament, int eleve)
        {
            VisiteBO visi;
            visi = new VisiteBO(id, motif, commentaire, heureArr, heureDep, dateAjout, retour, hopital, prevenu, pouls, qteMedicament, eleve);
            return VisiteDAL.UpdateVisite(visi);
        }
        #endregion

        #region // Méthode qui affiche le nombre de visite par période avec les date de début et de fin passées en parametre
        // Méthode qui affiche le nombre de visite par période avec les date de début et de fin passées en parametre
        // A l'aide de la méthode nbVisiteParPeriode de la DAL
        public static int afficheNbVisiteParPeriode(string dateDebut, string dateFin)
        {
            return VisiteDAL.nbVisiteParPeriode(dateDebut, dateFin);
        }
        #endregion

        #region // Méthode qui affiche le nombre de visite par période, sur le nombre total d'élève
        // Méthode qui affiche le nombre de visite par période, sur le nombre total d'élève
        public static double afficheNbVisiteParPeriodeParEleve(int nbVisite)
        {
            int nbEleve;
            float moyenneVisiteParEleve;

            nbEleve = GestionElevesBLL.afficheNbEleve();

            moyenneVisiteParEleve = (float)nbVisite / (float)nbEleve;

            // Méthode "Round" de la classe "Math" qui permet d'arrondir un nombre à virgule
            // Fonctionne que sur des variables de type "double"
            // Notre méthode est de type "double" donc les "return" peut contenir la méthode "Round" de la classe "Math"
            return Math.Round(moyenneVisiteParEleve, 2);
        }
        #endregion

        #region // Méthode qui affiche le nombre total de visite avec la méthode nbVisite de la DAL
        // Méthode qui affiche le nombre total d'élève avec la méthode nbEleve de la DAL
        public static int afficheNbVisite()
        {
            return VisiteDAL.nbVisite();
        }
        #endregion

        #region // Méthode qui affiche le temps de visite total de visite 
        // Méthode qui affiche le nombre total d'élève avec la méthode nbEleve de la DAL
        public static double tempsVisite(DateTime dateDebutDT, DateTime dateFinDT)
        {
            return VisiteDAL.tempsVisite(dateDebutDT, dateFinDT);
        }
        #endregion

        #region // Méthode qui récupère l'id d'une visite
        // Méthode qui récupère l'id d'une visite
        // BD avec la méthode AjoutVisite de la DAL
        public static int GetIdVisite(VisiteBO uneVisite)
        {
            return VisiteDAL.GetIdVisite(uneVisite);
        }
        #endregion

        #region // Méthode qui ajoute les données dans la table prescrire
        // Méthode qui ajout les données dans la table prescrire
        // BD avec la méthode AjoutVisite de la DAL
        public static int AjoutPrescrire(int idVisite, int idMedic)
        {
            return VisiteDAL.AjoutPrescrire(idVisite, idMedic);
        }
        #endregion

        #region // Méthode qui modifie les données dans la table prescrire
        // Méthode qui modifie les données dans la table prescrire
        // BD avec la méthode ModifTablePrescrire de la DAL
        public static int ModifPrescrire(int idVisite, int idMedic)
        {
            return VisiteDAL.ModifTablePrescrire(idVisite, idMedic);
        }
        #endregion
        
    }
}
