using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class MedicamentsDAL
    {
        private static MedicamentsDAL unMedicament;

        // Accesseur en lecture, renvoi une instance
        public static MedicamentsDAL GetunMedicament()
        {
            if (unMedicament == null)
            {
                unMedicament = new MedicamentsDAL();
            }
            return unMedicament;
        }

        #region // Cette méthode retourne une List contenant les objets medicaments contenus dans la table medicament
        // Cette méthode retourne une List contenant les objets medicaments contenus dans la table medicament
        public static List<MedicamentBO> GetMedicaments()
        {
            int id;
            string nom;
            bool archive;
            bool utilisation;
            MedicamentBO unMedicament;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Medicaments
            List<MedicamentBO> lesMedicaments = new List<MedicamentBO>();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM medicament", maConnexion);
                SqlDataReader monReader = cmd.ExecuteReader();

                // Remplissage de la liste
                while (monReader.Read())
                {
                    id = Int32.Parse(monReader["Id_medicament"].ToString());

                    if (monReader["Libelle_medicament"] == DBNull.Value)
                    {
                        nom = default(string);
                    }
                    else
                    {
                        nom = monReader["Libelle_medicament"].ToString();
                    }

                    if (monReader["Archive_medicament"] == DBNull.Value)
                    {
                        archive = default(bool);
                    }
                    else
                    {
                        archive = Boolean.Parse(monReader["Archive_medicament"].ToString());
                    }

                    if (monReader["Possede_visite_medicament"] == DBNull.Value)
                    {
                        utilisation = default(bool);
                    }
                    else
                    {
                        utilisation = Boolean.Parse(monReader["Possede_visite_medicament"].ToString());
                    }

                    unMedicament = new MedicamentBO(id, nom, archive, utilisation);
                    lesMedicaments.Add(unMedicament);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            // Fermeture de la connexion
            maConnexion.Close();
            return lesMedicaments;
        }
        #endregion

        #region // Cette méthode modifie un Medicament passé en paramètre dans la BD
        // Cette méthode modifie un Medicament passé en paramètre dans la BD
        public static int UpdateMedicament(MedicamentBO unMedicament)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand("UPDATE medicament SET Libelle_medicament = @leNom, Archive_medicament = @leArchive," +
                " Possede_visite_medicament = @leUtilisationDansUneVisite  WHERE Id_medicament = @leId", maConnexion);

            // Création et déclaration des paramètres 
            cmd.Parameters.Add(new SqlParameter("@leNom", SqlDbType.NVarChar, 11));
            cmd.Parameters.Add(new SqlParameter("@leArchive", SqlDbType.Bit, 2));
            cmd.Parameters.Add(new SqlParameter("@leUtilisationDansUneVisite", SqlDbType.Bit, 2));
            cmd.Parameters.Add(new SqlParameter("@leId", SqlDbType.Int, 11));

            // Attribution des valeurs aux paramètres 
            cmd.Parameters["@leNom"].Value = unMedicament.NomMedicament;
            cmd.Parameters["@leArchive"].Value = Convert.ToBoolean(unMedicament.ArchiveMedicament);
            cmd.Parameters["@leUtilisationDansUneVisite"].Value = unMedicament.UtilisationDansUneVisite;
            cmd.Parameters["@leId"].Value = Convert.ToInt32(unMedicament.IdMedicament);

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
        #endregion

        #region // Cette méthode supprime de la BD un Medicament dont l'id est passé en paramètre
        // Cette méthode supprime de la BD un Eleve dont l'id est passé en paramètre
        public static int DeleteMedicament(int id)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand("DELETE FROM medicament WHERE Id_medicament = @leId", maConnexion);

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

        #region // Cette méthode insert un nouveau medicament passé en paramètre dans la BD
        // Cette méthode insert un nouvel Eleve passé en paramètre dans la BD
        public static int AjoutMedicament(MedicamentBO unMedicament)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand("INSERT INTO medicament (Libelle_medicament, Archive_medicament, Possede_visite_medicament) VALUES (@leLibelle, @leArchive, @leVisiteMedicament)", maConnexion);

            // Attribution des valeurs aux paramètres 
            cmd.Parameters.AddWithValue("@leLibelle", unMedicament.NomMedicament);
            cmd.Parameters.AddWithValue("@leArchive", unMedicament.ArchiveMedicament);
            cmd.Parameters.AddWithValue("@leVisiteMedicament", unMedicament.UtilisationDansUneVisite);

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            return nbEnr;
        }
        #endregion

        #region // Cette méthode retourne une List de recherche contenant les objets medicaments contenus dans la table medicament
        // Cette méthode retourne une List contenant les objets medicaments contenus dans la table medicament
        public static List<MedicamentBO> GetMedicamentSearch(string search)
        {
            int id;
            string nom;
            bool archive;
            bool utilisation;
            MedicamentBO unMedicament;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Medicaments
            List<MedicamentBO> lesMedicaments = new List<MedicamentBO>();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM medicament where Libelle_medicament LIKE '%" + search + "%'", maConnexion);
                SqlDataReader monReader = cmd.ExecuteReader();

                // Remplissage de la liste
                while (monReader.Read())
                {
                    id = Int32.Parse(monReader["Id_medicament"].ToString());

                    if (monReader["Libelle_medicament"] == DBNull.Value)
                    {
                        nom = default(string);
                    }
                    else
                    {
                        nom = monReader["Libelle_medicament"].ToString();
                    }

                    if (monReader["Archive_medicament"] == DBNull.Value)
                    {
                        archive = default(bool);
                    }
                    else
                    {
                        archive = Boolean.Parse(monReader["Archive_medicament"].ToString());
                    }

                    if (monReader["Possede_visite_medicament"] == DBNull.Value)
                    {
                        utilisation = default(bool);
                    }
                    else
                    {
                        utilisation = Boolean.Parse(monReader["Possede_visite_medicament"].ToString());
                    }

                    unMedicament = new MedicamentBO(id, nom, archive, utilisation);
                    lesMedicaments.Add(unMedicament);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            // Fermeture de la connexion
            maConnexion.Close();
            return lesMedicaments;
        }
        #endregion

        #region // Cette méthode affiche le nombre de médicament par période avec les date de début et de fin passées en parametre
        // Cette méthode affiche le nombre de médicament par période avec les date de début et de fin passées en parametre
        public static int nbMedicamentParPeriode(string dateDebut, string dateFin)
        {
            int nbMecicament = 0;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(Qte_medicament_visite) AS NbMedicament FROM visite WHERE Date_visite BETWEEN @dateDebut AND @dateFin", maConnexion);

            // Attribution des valeurs aux paramètres 
            cmd.Parameters.AddWithValue("@dateDebut", dateDebut);
            cmd.Parameters.AddWithValue("@dateFin", dateFin);

            nbMecicament = (int)cmd.ExecuteScalar();

            //SqlDataReader monReader = cmd.ExecuteScalar();

            //while (monReader.Read())
            //{
            //    nbVisite = Int32.Parse(monReader["NbVisite"].ToString());
            //}

            // Fermeture de la connexion
            maConnexion.Close();

            return nbMecicament;
        }
        #endregion

        #region // Cette méthode affiche le nombre de total visite
        // Cette méthode affiche le nombre de total visite
        public static int nbTotalVisite()
        {
            int nbVisite = 0;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(Id_visite) AS NbTotalVisite FROM visite", maConnexion);

            nbVisite = (int)cmd.ExecuteScalar();

            //SqlDataReader monReader = cmd.ExecuteScalar();

            //while (monReader.Read())
            //{
            //    nbVisite = Int32.Parse(monReader["NbVisite"].ToString());
            //}

            // Fermeture de la connexion
            maConnexion.Close();

            return nbVisite;
        }
        #endregion

        #region // Cette méthode affiche le nombre de médicament utilisé
        // Cette méthode affiche le nombre de médicament utilisé
        public static int nbMedUtilise()
        {
            int nbMedUtilise = 0;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(Id_medicament) AS NbMedUtilise FROM prescrire", maConnexion);

            nbMedUtilise = (int)cmd.ExecuteScalar();

            // Fermeture de la connexion
            maConnexion.Close();

            return nbMedUtilise;
        }
        #endregion

        #region // Cette méthode renvoie l'id d'un médicament
        // Cette méthode renvoie l'id d'un médicament
        public static int idMedicament(int idVisite)
        {
            int id = 0;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand("Select Id_medicament FROM prescrire WHERE Id_visite = @leId", maConnexion);

            cmd.Parameters.AddWithValue("@leId", Convert.ToInt32(idVisite));

            SqlDataReader monReader = cmd.ExecuteReader();
            while (monReader.Read())
            {
                id = Convert.ToInt32(monReader["Id_medicament"]);
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return id;
        }
        #endregion

        #region // Cette méthode renvoie le libellé d'un médicament
        // Cette méthode renvoie le libellé d'un médicament
        public static string libMedicament(int idMedicament)
        {
            string libMedicament = "";
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand("Select Libelle_medicament FROM medicament WHERE Id_medicament = @leId", maConnexion);

            cmd.Parameters.AddWithValue("@leId", Convert.ToInt32(idMedicament));

            SqlDataReader monReader = cmd.ExecuteReader();
            while (monReader.Read())
            {
                libMedicament = monReader["Libelle_medicament"].ToString();
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return libMedicament;
        }
        #endregion
    }
}
