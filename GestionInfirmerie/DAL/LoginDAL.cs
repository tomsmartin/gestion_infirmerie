using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class LoginDAL
    {
        public DataTable verifCon(UtilisateursBO monUtilisateur)
        {
            SqlConnection con = new SqlConnection("Persist Security Info = False; Trusted_Connection = True;database = gestion_infirmerie; server=localhost");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from utilisateur where Login_utilisateur ='" + monUtilisateur.Login_utilisateur1 + "' AND Mdp_utilisateur='" + monUtilisateur.Mdp_utilisateur1 + "'", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt;
        }

    }
}
