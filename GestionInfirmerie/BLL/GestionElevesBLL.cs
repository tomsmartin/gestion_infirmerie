using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using BO;
using DAL;

namespace BLL
{
    public class GestionElevesBLL
    {
        private static GestionElevesBLL uneGestionEleve; // objet BLL

        // Accesseur en lecture
        public static GestionElevesBLL GetGestionEleves()
        {
            if (uneGestionEleve == null)
            {
                uneGestionEleve = new GestionElevesBLL();
            }
            return uneGestionEleve;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        #region // Méthode qui renvoit une List d'objets Eleve en faisant appel à la méthode GetEleves() de la DAL
        public static List<EleveBO> GetEleves()
        {
            return ElevesDAL.GetEleves();
        }
        #endregion

        #region // Méthode qui recherche un nom dans une List d'objets eleve en faisant appel à la méthode GetEleve() de la DAL
        // Méthode qui cherche dans une List d'objets Visite en faisant appel à la méthode GetVisite() de la DAL
        public static List<EleveBO> GetEleveSearch(string search)
        {
            return ElevesDAL.GetEleveSearch(search);
        }

        #endregion

        #region // Méthode qui créer un nouvel objet Eleve à partir de son id et de son nom
        // Méthode qui créer un nouvel objet Eleve à partir de son id et de son nom et qui le renvoi en l'ajoutant à la
        // BD avec la méthode AjoutEleve de la DAL
        public static int CreerUneleve(string nom, string prenom, DateTime dateNaissance, string sante, string telEleve, string telPere, string telMere, int classe)
        {
            EleveBO ele;
            ele = new EleveBO(nom, prenom, dateNaissance, sante, telEleve, telPere, telMere, classe);
            return ElevesDAL.AjoutEleve(ele);
        }
        #endregion

        #region // Méthode qui modifie un nouvel Eleve avec la méthode UpdateUtilisateur de la DAL
        // Méthode qui modifie un nouvel Eleve avec la méthode UpdateUtilisateur de la DAL
        public static int ModifierEleve(int id, string nom, string prenom, DateTime dateNaissance, string sante, string telEleve, string telPere, string telMere, bool archive, bool tierTemps, bool visite, int classe)
        {
            EleveBO ele;
            ele = new EleveBO(id, nom, prenom, dateNaissance, sante, telEleve, telPere, telMere, archive, tierTemps, visite, classe);
            return ElevesDAL.UpdateEleve(ele);
        }
        #endregion

        #region // Méthode qui supprime un Eleve avec la méthode DeleteUtilisateur de la DAL
        // Méthode qui supprime un Eleve avec la méthode DeleteUtilisateur de la DAL
        public static int SupprimerEleve(int id)
        {
            return ElevesDAL.DeleteEleve(id);
        }
        #endregion

        #region // Méthode qui affiche le nombre total d'élève avec la méthode nbEleve de la DAL
        // Méthode qui affiche le nombre total d'élève avec la méthode nbEleve de la DAL
        public static int afficheNbEleve()
        {
            return ElevesDAL.nbEleve();
        }
        #endregion

        #region // Méthode qui affiche le nombre d'élève par période avec les date de début et de fin passées en parametre
        // Méthode qui affiche le nombre d'élève par période avec les date de début et de fin passées en parametre
        // A l'aide de la méthode nbEleveParPeriode de la DAL
        public static int afficheNbEleveParPeriode(string dateDebut, string dateFin)
        {
            return ElevesDAL.nbEleveParPeriode(dateDebut, dateFin);
        }
        #endregion
    }
}
