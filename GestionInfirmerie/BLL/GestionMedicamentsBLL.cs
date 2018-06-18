using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using BO;
using DAL;

namespace BLL
{
    public class GestionMedicamentsBLL
    {
        private static GestionMedicamentsBLL uneGestionMedicament; // objet BLL

        // Accesseur en lecture
        public static GestionMedicamentsBLL GetGestionMedicaments()
        {
            if (uneGestionMedicament == null)
            {
                uneGestionMedicament = new GestionMedicamentsBLL();
            }
            return uneGestionMedicament;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        #region // Méthode qui renvoit une List d'objets Medicament en faisant appel à la méthode GetMedicaments() de la DAL
        // Méthode qui renvoit une List d'objets Medicament en faisant appel à la méthode GetMedicaments() de la DAL
        public static List<MedicamentBO> GetMedicaments()
        {
            return MedicamentsDAL.GetMedicaments();
        }

        #endregion

        #region // Méthode qui modifie un nouveau Medicament avec la méthode UpdateUtilisateur de la DAL
        // Méthode qui modifie un nouveau Medicament avec la méthode UpdateUtilisateur de la DAL
        public static int ModifierMedicament(int id, string nom, bool archive, bool utilisation)
        {
            MedicamentBO med;
            med = new MedicamentBO(id, nom, archive, utilisation);
            return MedicamentsDAL.UpdateMedicament(med);
        }
        #endregion

        #region // Méthode qui créer un nouvel objet Medicament à partir de son id et de son nom
        // Méthode qui créer un nouvel objet Eleve à partir de son id et de son nom et qui le renvoi en l'ajoutant à la
        // BD avec la méthode AjoutEleve de la DAL
        public static int CreerUnMedicament(string nom, bool archive, bool utilisation)
        {
            MedicamentBO med;
            med = new MedicamentBO(nom, archive, utilisation);
            return MedicamentsDAL.AjoutMedicament(med);
        }
        #endregion

        #region // Méthode qui supprime un Medicament avec la méthode DeleteUtilisateur de la DAL
        // Méthode qui supprime un Eleve avec la méthode DeleteUtilisateur de la DAL
        public static int SupprimerMedicament(int id)
        {
            return MedicamentsDAL.DeleteMedicament(id);
        }
        #endregion

        #region // Méthode qui recherche un nom dans une List d'objets medicament en faisant appel à la méthode GetMedicament() de la DAL
        // Méthode qui cherche dans une List d'objets Visite en faisant appel à la méthode GetVisite() de la DAL
        public static List<MedicamentBO> GetMedicamentSearch(string search)
        {
            return MedicamentsDAL.GetMedicamentSearch(search);
        }

        #endregion

        #region // Méthode qui affiche le nombre de médicament par période avec les date de début et de fin passées en parametre
        // Méthode qui affiche le nombre de médicament par période avec les date de début et de fin passées en parametre
        // A l'aide de la méthode nbMedicamentParPeriode de la DAL
        public static int nbMedicamentParPeriode(string dateDebut, string dateFin)
        {
            return MedicamentsDAL.nbMedicamentParPeriode(dateDebut, dateFin);
        }
        #endregion

        #region // Méthode qui affiche le nombre de médicament par période, sur le nombre total de visite
        // Méthode qui affiche le nombre de visite par période, sur le nombre total d'élève
        public static double afficheNbMedicamentParPeriodeParVisite(int nbMedicament)
        {
            int nbVisite;
            float moyenneMedicamentParVisite;

            nbVisite = GestionVisiteBLL.afficheNbVisite();

            moyenneMedicamentParVisite = (float)nbMedicament / (float)nbVisite;

            // Méthode "Round" de la classe "Math" qui permet d'arrondir un nombre à virgule
            // Fonctionne que sur des variables de type "double"
            // Notre méthode est de type "double" donc les "return" peut contenir la méthode "Round" de la classe "Math"
            return Math.Round(moyenneMedicamentParVisite, 2);
        }
        #endregion

        #region // Méthode qui affiche le nombre total de visite
        // Méthode qui affiche le nombre total de visite
        // A l'aide de la méthode afficheNbTotalVisite de la DAL
        public static int afficheNbTotalVisite()
        {
            return MedicamentsDAL.nbTotalVisite();
        }
        #endregion

        #region // Méthode qui affiche la moyenne de médicament utilisée par visite
        // Méthode qui affiche la moyenne de médicament utilisée par visite
        public static double afficheNbMoyenMedParVisite()
        {
            int nbTotalVisite;
            int nbMedUtilise;
            float nbMoyenMedParVisite;

            nbTotalVisite = GestionMedicamentsBLL.afficheNbTotalVisite();
            nbMedUtilise = MedicamentsDAL.nbMedUtilise();

            nbMoyenMedParVisite = (float)nbMedUtilise / (float)nbTotalVisite;

            // Méthode "Round" de la classe "Math" qui permet d'arrondir un nombre à virgule
            // Fonctionne uniquement sur des variables de type "double"
            // Notre méthode est de type "double" donc les "return" peut contenir la méthode "Round" de la classe "Math"
            return Math.Round(nbMoyenMedParVisite, 2);
        }
        #endregion

        #region // Méthode qui retourne l'id d'un médicament
        //Méthode qui affiche l'id d'un médicament
        public static int afficheIdMedicament(int idVisite)
        {
            return MedicamentsDAL.idMedicament(idVisite);
        }
        #endregion

        #region // Méthode qui affiche le libellé d'un médicament
        // Méthode qui affiche le libellé d'un médicament
        public static string afficheLibMedicament(int idMedicament)
        {
            return MedicamentsDAL.libMedicament(idMedicament);
        }
        #endregion
    }
}
