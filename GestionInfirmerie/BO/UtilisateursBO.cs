using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BO
{

    // creation d'une classe pour la table Utilisateur
    public class UtilisateursBO
    {
        private int id;
        private string Login_utilisateur;
        private string Mdp_utilisateur;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Login_utilisateur1
        {
            get { return Login_utilisateur; }
            set { Login_utilisateur = value; }
        }

        public string Mdp_utilisateur1
        {
            get { return Mdp_utilisateur; }
            set { Mdp_utilisateur = value; }
        }

        public UtilisateursBO(string monLogin, string monMdp)
        {
            this.Login_utilisateur = monLogin;
            this.Mdp_utilisateur = monMdp;
        }
        
    }
}
