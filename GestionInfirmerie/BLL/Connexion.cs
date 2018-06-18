using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using BO;
using System.Data;

namespace BLL
{
    public class Connexion
    {
        // créer un objet utilisateur de la BO et envoie l'objet à la DAL
        public DataTable Con(string utilisateur, string mdp)
        {
            //creation de l'objet utilisateur afin de l'envoyer dans la DAL
            UtilisateursBO maVerifCon = new UtilisateursBO(utilisateur, mdp);
            LoginDAL reqVerif = new LoginDAL();

            // Récupère le nombre de ligne par rapport au nom d'utilisateur et du mot de passe (si mot de passe et nom utilisateur est trouvé dans la BDD, renvoie 1, sinon renvoie 0)
            DataTable monResultReq = reqVerif.verifCon(maVerifCon);

            return monResultReq;
        }
    }
}
