using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using BO;
using DAL;

namespace BLL
{
    public class GestionClassesBLL
    {
        private static GestionClassesBLL uneGestionClasse; // objet BLL

        // Accesseur en lecture
        public static GestionClassesBLL GetGestionClasses()
        {
            if (uneGestionClasse == null)
            {
                uneGestionClasse = new GestionClassesBLL();
            }
            return uneGestionClasse;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        // Méthode qui renvoit une List d'objets Classe en faisant appel à la méthode GetClasses() de la DAL
        public static List<ClasseBO> GetClasses()
        {
            return ClassesDAL.GetClasses();
        }

        #region // Méthode qui modifie une classe, avec un EDT, avec la méthode UpdateClasseAvecEDT de la DAL
        // Méthode qui modifie une classe, avec un EDT, avec la méthode UpdateClasseAvecEDT de la DAL
        public static int ModifierClasseAvecEDT(int id, string nom, string emploiDuTemps, bool eleve, bool possedeEDT)
        {
            ClasseBO classe;
            classe = new ClasseBO(id, nom, emploiDuTemps, eleve, possedeEDT);
            return ClassesDAL.UpdateClasseAvecEDT(classe);
        }
        #endregion

        #region Méthode qui modifie une classe, sans EDT, avec la méthode UpdateClasseSansEDT de la DAL
        // Méthode qui modifie une classe, sans EDT, avec la méthode UpdateClasseSansEDT de la DAL
        public static int ModifierClasseSansEDT(int id, string nom, bool eleve)
        {
            ClasseBO classe;
            classe = new ClasseBO(id, nom, eleve);
            return ClassesDAL.UpdateClasseSansEDT(classe);
        }
        #endregion

        #region // Méthode qui créer une classe avec nom et emploi du temps
        // Méthode qui créer une classe avec nom et emploi du temps
        public static int CreerUneClasseAvecEDT(string nom, string emploiDuTemps)
        {
            ClasseBO classe;
            classe = new ClasseBO(nom, emploiDuTemps);
            return ClassesDAL.AjoutClasseAvecEDT(classe);
        }
        #endregion

        #region // Méthode qui créer une classe avec nom mais sans l'emploi du temps
        // Méthode qui créer une classe avec nom mais sans l'emploi du temps
        public static int CreerUneClasseSansEDT(string nom, string emploiDuTemps)
        {
            ClasseBO classe;
            classe = new ClasseBO(nom, emploiDuTemps);
            return ClassesDAL.AjoutClasseSansEDT(classe);
        }
        #endregion

        #region // Méthode qui supprime une Classe avec la méthode DeleteClasse de la DAL
        // Méthode qui supprime une Classe avec la méthode DeleteClasse de la DAL
        public static int SupprimerClasse(int id)
        {
            return ClassesDAL.DeleteClasse(id);
        }
        #endregion
    }
}
