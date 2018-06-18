using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class ElevesDAL
    {
        private static ElevesDAL unEleve;

        // Accesseur en lecture, renvoi une instance
        public static ElevesDAL GetunEleve()
        {
            if (unEleve == null)
            {
                unEleve = new ElevesDAL();
            }
            return unEleve;
        }

        #region // Cette méthode retourne une List contenant les objets Utilisateurs contenus dans la table Identification
        // Cette méthode retourne une List contenant les objets Utilisateurs contenus dans la table Identification
        public static List<EleveBO> GetEleves()
        {
            int id;
            string nom;
            string prenom;
            DateTime dateNaissance;
            string sante;
            string telEleve;
            string telPere;
            string telMere;
            bool archive;
            bool tiersTemps;
            bool visite;
            int classId;
            EleveBO unEleve;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Eleves
            List<EleveBO> lesEleves = new List<EleveBO>();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM eleve", maConnexion);

                SqlDataReader monReader = cmd.ExecuteReader();

                // Remplissage de la liste
                while (monReader.Read())
                {
                    id = Int32.Parse(monReader["Id_eleve"].ToString());

                    if (monReader["Nom_eleve"] == DBNull.Value)
                    {
                        nom = default(string);
                    }
                    else
                    {
                        nom = monReader["Nom_eleve"].ToString();
                    }

                    if (monReader["Prenom_eleve"] == DBNull.Value)
                    {
                        prenom = default(string);
                    }
                    else
                    {
                        prenom = monReader["Prenom_eleve"].ToString();
                    }

                    if (monReader["Date_naissance_eleve"] == DBNull.Value)
                    {
                        dateNaissance = default(DateTime);
                    }
                    else
                    {
                        dateNaissance = DateTime.Parse(monReader["Date_naissance_eleve"].ToString());
                    }

                    if (monReader["Sante_eleve"] == DBNull.Value)
                    {
                        sante = default(string);
                    }
                    else
                    {
                        sante = monReader["Sante_eleve"].ToString();
                    }

                    if (monReader["Tel_eleve"] == DBNull.Value)
                    {
                        telEleve = default(string);
                    }
                    else
                    {
                        telEleve = monReader["Tel_eleve"].ToString();
                    }

                    if (monReader["Tel_pere_eleve"] == DBNull.Value)
                    {
                        telPere = default(string);
                    }
                    else
                    {
                        telPere = monReader["Tel_pere_eleve"].ToString();
                    }

                    if (monReader["Tel_mere_eleve"] == DBNull.Value)
                    {
                        telMere = default(string);
                    }
                    else
                    {
                        telMere = monReader["Tel_mere_eleve"].ToString();
                    }

                    if (monReader["Archive_eleve"] == DBNull.Value)
                    {
                        archive = default(bool);
                    }
                    else
                    {
                        archive = Boolean.Parse(monReader["Archive_eleve"].ToString());
                    }

                    if (monReader["Possede_tiers_temps_exam"] == DBNull.Value)
                    {
                        tiersTemps = default(bool);
                    }
                    else
                    {
                        tiersTemps = Boolean.Parse(monReader["Possede_tiers_temps_exam"].ToString());
                    }

                    if (monReader["Possede_visite"] == DBNull.Value)
                    {
                        visite = default(bool);
                    }
                    else
                    {
                        visite = Boolean.Parse(monReader["Possede_visite"].ToString());
                    }

                    classId = Int32.Parse(monReader["Id_classe"].ToString());

                    unEleve = new EleveBO(id, nom, prenom, dateNaissance, sante, telEleve, telPere, telMere, archive, tiersTemps, visite, classId);
                    lesEleves.Add(unEleve);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return lesEleves;
        }
        #endregion

        #region // Cette méthode insert un nouvel Eleve passé en paramètre dans la BD
        // Cette méthode insert un nouvel Eleve passé en paramètre dans la BD
        public static int AjoutEleve(EleveBO unEleve)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand("INSERT INTO eleve (Nom_eleve, Prenom_eleve, Date_naissance_eleve, Sante_eleve, Tel_eleve, Tel_pere_eleve, Tel_mere_eleve, dbo.classe.Id_classe) " +
                "VALUES (@leNom, @lePrenom, @leDateNaissance, @leSante, @leTelEleve, @leTelPere, @leTelMere, @classId)", maConnexion);

            // Attribution des valeurs aux paramètres 
            cmd.Parameters.AddWithValue("@leNom", unEleve.NomEleve);
            cmd.Parameters.AddWithValue("@lePrenom", unEleve.PrenomEleve);
            cmd.Parameters.AddWithValue("@leDateNaissance", Convert.ToDateTime(unEleve.DateNaissanceEleve));
            cmd.Parameters.AddWithValue("@leSante", unEleve.SanteEleve);
            cmd.Parameters.AddWithValue("@leTelEleve", unEleve.TelEleve);
            cmd.Parameters.AddWithValue("@leTelPere", unEleve.TelPereELeve);
            cmd.Parameters.AddWithValue("@leTelMere", unEleve.TelMereEleve);
            cmd.Parameters.AddWithValue("@classId", Convert.ToInt32(unEleve.IdClasseEleve));

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            return nbEnr;
        }
        #endregion

        #region // Cette méthode modifie un Eleve passé en paramètre dans la BD
        // Cette méthode modifie un Eleve passé en paramètre dans la BD
        public static int UpdateEleve(EleveBO unEleve)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand("UPDATE eleve SET Nom_eleve = @leNom, Prenom_eleve = @lePrenom, Date_naissance_eleve = @leDateNaissance, Sante_eleve = @leSante, Tel_eleve = @leTelEleve, " +
                "Tel_pere_eleve = @leTelPere, Tel_mere_eleve = @leTelMere, Archive_eleve = @leArchive, Possede_tiers_temps_exam = @leTiersTemps, Possede_visite = @leVisiteInfirmerie, Id_classe = @classId   WHERE Id_eleve = @leId", maConnexion);

            // Création et déclaration des paramètres 
            cmd.Parameters.AddWithValue("@leNom", unEleve.NomEleve);
            cmd.Parameters.AddWithValue("@lePrenom", unEleve.PrenomEleve);
            cmd.Parameters.AddWithValue("@leDateNaissance", Convert.ToDateTime(unEleve.DateNaissanceEleve));
            cmd.Parameters.AddWithValue("@leSante", unEleve.SanteEleve);
            cmd.Parameters.AddWithValue("@leTelEleve", unEleve.TelEleve);
            cmd.Parameters.AddWithValue("@leTelPere", unEleve.TelPereELeve);
            cmd.Parameters.AddWithValue("@leTelMere", unEleve.TelMereEleve);
            cmd.Parameters.AddWithValue("@leArchive", Convert.ToBoolean(unEleve.ArchiveEleve));
            cmd.Parameters.AddWithValue("@leTiersTemps", Convert.ToBoolean(unEleve.TiersTemps));
            cmd.Parameters.AddWithValue("@leVisiteInfirmerie", Convert.ToBoolean(unEleve.VisiteInfirmerie));
            cmd.Parameters.AddWithValue("@classId", Convert.ToInt32(unEleve.IdClasseEleve));
            cmd.Parameters.AddWithValue("@leId", Convert.ToInt32(unEleve.IdEleve));

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            return nbEnr;
        }
        #endregion

        #region // Cette méthode supprime de la BD un Eleve dont l'id est passé en paramètre
        // Cette méthode supprime de la BD un Eleve dont l'id est passé en paramètre
        public static int DeleteEleve(int id)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand("DELETE FROM eleve WHERE Id_Eleve = @leId AND Possede_visite = 0", maConnexion);

            // Création et déclaration des paramètres 
            cmd.Parameters.Add(new SqlParameter("@leId", SqlDbType.Int, 11));

            // Attribution des valeurs aux paramètres 
            cmd.Parameters["@leId"].Value = id;

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            return nbEnr;
        }
        #endregion

        #region // Cette méthode retourne une List contenant les objets eleve contenus dans la table eleve
        public static List<EleveBO> GetEleveSearch(string search)
        {
            int id;
            string nom;
            string prenom;
            DateTime dateNaissance;
            string sante;
            string telEleve;
            string telPere;
            string telMere;
            bool archive;
            bool tiersTemps;
            bool visite;
            int classId;
            EleveBO unEleve;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Eleves
            List<EleveBO> lesEleves = new List<EleveBO>();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM eleve where eleve.Nom_eleve LIKE '%" + search + "%'", maConnexion);

                SqlDataReader monReader = cmd.ExecuteReader();

                // Remplissage de la liste
                while (monReader.Read())
                {
                    id = Int32.Parse(monReader["Id_eleve"].ToString());

                    if (monReader["Nom_eleve"] == DBNull.Value)
                    {
                        nom = default(string);
                    }
                    else
                    {
                        nom = monReader["Nom_eleve"].ToString();
                    }

                    if (monReader["Prenom_eleve"] == DBNull.Value)
                    {
                        prenom = default(string);
                    }
                    else
                    {
                        prenom = monReader["Prenom_eleve"].ToString();
                    }

                    if (monReader["Date_naissance_eleve"] == DBNull.Value)
                    {
                        dateNaissance = default(DateTime);
                    }
                    else
                    {
                        dateNaissance = DateTime.Parse(monReader["Date_naissance_eleve"].ToString());
                    }

                    if (monReader["Sante_eleve"] == DBNull.Value)
                    {
                        sante = default(string);
                    }
                    else
                    {
                        sante = monReader["Sante_eleve"].ToString();
                    }

                    if (monReader["Tel_eleve"] == DBNull.Value)
                    {
                        telEleve = default(string);
                    }
                    else
                    {
                        telEleve = monReader["Tel_eleve"].ToString();
                    }

                    if (monReader["Tel_pere_eleve"] == DBNull.Value)
                    {
                        telPere = default(string);
                    }
                    else
                    {
                        telPere = monReader["Tel_pere_eleve"].ToString();
                    }

                    if (monReader["Tel_mere_eleve"] == DBNull.Value)
                    {
                        telMere = default(string);
                    }
                    else
                    {
                        telMere = monReader["Tel_mere_eleve"].ToString();
                    }

                    if (monReader["Archive_eleve"] == DBNull.Value)
                    {
                        archive = default(bool);
                    }
                    else
                    {
                        archive = Boolean.Parse(monReader["Archive_eleve"].ToString());
                    }

                    if (monReader["Possede_tiers_temps_exam"] == DBNull.Value)
                    {
                        tiersTemps = default(bool);
                    }
                    else
                    {
                        tiersTemps = Boolean.Parse(monReader["Possede_tiers_temps_exam"].ToString());
                    }

                    if (monReader["Possede_visite"] == DBNull.Value)
                    {
                        visite = default(bool);
                    }
                    else
                    {
                        visite = Boolean.Parse(monReader["Possede_visite"].ToString());
                    }

                    classId = Int32.Parse(monReader["Id_classe"].ToString());

                    unEleve = new EleveBO(id, nom, prenom, dateNaissance, sante, telEleve, telPere, telMere, archive, tiersTemps, visite, classId);
                    lesEleves.Add(unEleve);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return lesEleves;
        }
        #endregion

        #region Vérifie si l'eleve existe
        public bool checkStudentExist(string nom, string prenom)
        {
            bool existStudent = false;
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand maCommand = new SqlCommand("SELECT COUNT(*) as nblignes FROM eleve WHERE Nom_eleve = @nom AND Prenom_eleve = @prenom", maConnexion);
            maCommand.Parameters.Add(new SqlParameter("@nom", System.Data.SqlDbType.NVarChar, 50));
            maCommand.Parameters.Add(new SqlParameter("@prenom", System.Data.SqlDbType.NVarChar, 50));
            maCommand.Parameters["@nom"].Value = nom;
            maCommand.Parameters["@prenom"].Value = prenom;


            SqlDataReader myReader = null;
            maConnexion.Open();
            myReader = maCommand.ExecuteReader();
            int nbResult = 0;
            while (myReader.Read())
            {
                nbResult = Convert.ToInt32(myReader["nblignes"].ToString());
            }
            maConnexion.Close();
            if (nbResult == 0)
            {
                existStudent = true;
            }

            return existStudent;
        } 
        #endregion

        #region // Cette méthode affiche le nombre total d'élève
        // Cette méthode affiche le nombre total d'élève
        public static int nbEleve()
        {
            int nbEleve = 0;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(Id_eleve) AS NbEleve FROM eleve", maConnexion);

            nbEleve = (int)cmd.ExecuteScalar();

            //SqlDataReader monReader = cmd.ExecuteScalar();

            //while (monReader.Read())
            //{
            //    nbVisite = Int32.Parse(monReader["NbVisite"].ToString());
            //}

            // Fermeture de la connexion
            maConnexion.Close();

            return nbEleve;
        }
        #endregion

        #region // Cette méthode affiche le nombre d'élève par période avec les date de début et de fin passées en parametre
        // Cette méthode affiche le nombre d'élève par période avec les date de début et de fin passées en parametre
        public static int nbEleveParPeriode(string dateDebut, string dateFin)
        {
            int nbEleve = 0;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(DISTINCT Id_eleve) AS NbEleve FROM visite WHERE Date_visite BETWEEN @dateDebut AND @dateFin", maConnexion);

            // Attribution des valeurs aux paramètres 
            cmd.Parameters.AddWithValue("@dateDebut", dateDebut);
            cmd.Parameters.AddWithValue("@dateFin", dateFin);

            nbEleve = (int)cmd.ExecuteScalar();

            //SqlDataReader monReader = cmd.ExecuteScalar();

            //while (monReader.Read())
            //{
            //    nbVisite = Int32.Parse(monReader["NbVisite"].ToString());
            //}

            // Fermeture de la connexion
            maConnexion.Close();

            return nbEleve;
        }
        #endregion
    }
}
