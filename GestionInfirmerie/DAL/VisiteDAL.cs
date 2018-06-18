using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class VisiteDAL
    {
        private static VisiteDAL uneVisite;

        // Accesseur en lecture, renvoi une instance
        public static VisiteDAL GetuneVisite()
        {
            if (uneVisite == null)
            {
                uneVisite = new VisiteDAL();
            }
            return uneVisite;
        }

        #region // Cette méthode retourne une List contenant les objets visites contenus dans la table Identification
        // Cette méthode retourne une List contenant les objets Visites contenus dans la table Identification
        public static List<VisiteBO> GetVisite()
        {
            int id;
            string motif;
            string commentaire;
            DateTime heureArr;
            DateTime heureDep;
            DateTime dateVisite;
            bool retour;
            bool hopital;
            bool parent;
            string pouls;
            int qteMedicament;
            int eleveId;
            string nom;
            string prenom;
            VisiteBO uneVisite;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Visite
            List<VisiteBO> lesVisites = new List<VisiteBO>();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT visite.Id_visite, visite.Motif_visite ,visite.Commentaire_visite, visite.Heure_entree_visite, visite.Heure_sortie_visite, visite.Date_visite, visite.Retour_domicile_visite, visite.Hopital_visite, visite.Parents_prevenus_visite, visite.Pouls_eleve_visite, visite.Qte_medicament_visite, visite.Id_eleve, eleve.Nom_eleve, eleve.Prenom_eleve FROM eleve, visite where eleve.Id_eleve = visite.Id_eleve", maConnexion);
                SqlDataReader monReader = cmd.ExecuteReader();

                // Remplissage de la liste
                while (monReader.Read())
                {
                    id = Int32.Parse(monReader["Id_visite"].ToString());

                    if (monReader["Motif_visite"] == DBNull.Value)
                    {
                        motif = default(string);
                    }
                    else
                    {
                        motif = monReader["Motif_visite"].ToString();
                    }

                    if (monReader["Commentaire_visite"] == DBNull.Value)
                    {
                        commentaire = default(string);
                    }
                    else
                    {
                        commentaire = monReader["Commentaire_visite"].ToString();
                    }

                    if (monReader["Heure_entree_visite"] == DBNull.Value)
                    {
                        heureArr = default(DateTime);
                    }
                    else
                    {
                        heureArr = DateTime.Parse(monReader["Heure_entree_visite"].ToString());
                    }

                    if (monReader["Heure_sortie_visite"] == DBNull.Value)
                    {
                        heureDep = default(DateTime);
                    }
                    else
                    {
                        heureDep = DateTime.Parse(monReader["Heure_sortie_visite"].ToString());
                    }

                    if (monReader["Date_visite"] == DBNull.Value)
                    {
                        dateVisite = default(DateTime);
                    }
                    else
                    {
                        dateVisite = DateTime.Parse(monReader["Date_visite"].ToString());
                    }

                    if (monReader["Retour_domicile_visite"] == DBNull.Value)
                    {
                        retour = default(bool);
                    }
                    else
                    {
                        retour = Boolean.Parse(monReader["Retour_domicile_visite"].ToString());
                    }

                    if (monReader["Hopital_visite"] == DBNull.Value)
                    {
                        hopital = default(bool);
                    }
                    else
                    {
                        hopital = Boolean.Parse(monReader["Hopital_visite"].ToString());
                    }

                    if (monReader["Parents_prevenus_visite"] == DBNull.Value)
                    {
                        parent = default(bool);
                    }
                    else
                    {
                        parent = Boolean.Parse(monReader["Parents_prevenus_visite"].ToString());
                    }

                    if (monReader["Pouls_eleve_visite"] == DBNull.Value)
                    {
                        pouls = default(string);
                    }
                    else
                    {
                        pouls = monReader["Pouls_eleve_visite"].ToString();
                    }

                    qteMedicament = Int32.Parse(monReader["Qte_medicament_visite"].ToString());

                    eleveId = Int32.Parse(monReader["Id_eleve"].ToString());

                    if (monReader["Nom_Eleve"] == DBNull.Value)
                    {
                        nom = default(string);
                    }
                    else
                    {
                        nom = monReader["Nom_Eleve"].ToString();
                    }

                    if (monReader["Prenom_Eleve"] == DBNull.Value)
                    {
                        prenom = default(string);
                    }
                    else
                    {
                        prenom = monReader["Prenom_Eleve"].ToString();
                    }

                    uneVisite = new VisiteBO(id, motif, commentaire, heureArr, heureDep, dateVisite, retour, hopital, parent, pouls, qteMedicament, eleveId, nom, prenom);
                    lesVisites.Add(uneVisite);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return lesVisites;
        }
        #endregion

        #region // Cette méthode insert une nouvelle Visite passée en paramètre dans la BD
        // Cette méthode insert une nouvelle Visite passée en paramètre dans la BD
        public static int AjoutVisite(VisiteBO uneVisite)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand("INSERT INTO visite (Motif_visite, Commentaire_visite, Heure_entree_visite, Heure_sortie_visite, Date_visite, Retour_domicile_visite, Hopital_visite, Parents_prevenus_visite, Pouls_eleve_visite, Qte_medicament_visite, Id_eleve) " +
                "VALUES (@leMotif, @leCommentaire, @lHeureArrivee, @lheureDepart, @laDate, @leRetourDomicile, @lHopital, @lesParents, @lePoul, @laQteMedicament, @lIdEleve)", maConnexion);

            // Attribution des valeurs aux paramètres 
            cmd.Parameters.AddWithValue("@leMotif", uneVisite.Motif);
            cmd.Parameters.AddWithValue("@leCommentaire", uneVisite.Commentaire);
            cmd.Parameters.AddWithValue("@lHeureArrivee", uneVisite.HeureArrive);
            cmd.Parameters.AddWithValue("@lheureDepart", uneVisite.HeureDepart);
            cmd.Parameters.AddWithValue("@laDate", uneVisite.DateVisite);
            cmd.Parameters.AddWithValue("@leRetourDomicile", uneVisite.RetourDomicile);
            cmd.Parameters.AddWithValue("@lHopital", uneVisite.Hopital);
            cmd.Parameters.AddWithValue("@lesParents", uneVisite.ParentsPrevenus);
            cmd.Parameters.AddWithValue("@lePoul", Convert.ToInt32(uneVisite.Pouls));
            cmd.Parameters.AddWithValue("@laQteMedicament", Convert.ToInt32(uneVisite.QteMedicament));
            cmd.Parameters.AddWithValue("@lIdEleve", Convert.ToInt32(uneVisite.IdEleve));

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            return nbEnr;
        }
        #endregion

        #region // Cette méthode modifie une visite passé en paramètre dans la BD
        // Cette méthode modifie un Eleve passé en paramètre dans la BD
        public static int UpdateVisite(VisiteBO uneVisite)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand("UPDATE visite SET Motif_visite = @leMotif, Commentaire_visite = @leCommentaire, Heure_entree_visite = @heureEntre, Heure_sortie_visite = @heureSortie, Date_visite = @dateVisite, " +
                "Retour_domicile_visite = @retour, Hopital_visite = @hopital, Parents_prevenus_visite = @prevenu, Pouls_eleve_visite = @pouls, Qte_medicament_visite = @laQteMedicament, Id_eleve = @eleveId WHERE Id_visite = @visiteID", maConnexion);

            // Création et déclaration des paramètres 
            cmd.Parameters.AddWithValue("@leMotif", uneVisite.Motif);
            cmd.Parameters.AddWithValue("@leCommentaire", uneVisite.Commentaire);
            cmd.Parameters.AddWithValue("@dateVisite", Convert.ToDateTime(uneVisite.DateVisite));
            cmd.Parameters.AddWithValue("@heureEntre", uneVisite.HeureArrive);
            cmd.Parameters.AddWithValue("@heureSortie", uneVisite.HeureDepart);
            cmd.Parameters.AddWithValue("@retour", Convert.ToBoolean(uneVisite.RetourDomicile));
            cmd.Parameters.AddWithValue("@hopital", Convert.ToBoolean(uneVisite.Hopital));
            cmd.Parameters.AddWithValue("@prevenu", Convert.ToBoolean(uneVisite.ParentsPrevenus));
            cmd.Parameters.AddWithValue("@pouls", uneVisite.Pouls);
            cmd.Parameters.AddWithValue("@laQteMedicament", Convert.ToInt32(uneVisite.QteMedicament));
            cmd.Parameters.AddWithValue("@eleveId", Convert.ToInt32(uneVisite.IdEleve));
            cmd.Parameters.AddWithValue("@visiteID", Convert.ToInt32(uneVisite.IdVisite));

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            return nbEnr;
        }

        #endregion

        #region // Cette méthode recherche une visite passé en paramètre dans la BD
        public static List<VisiteBO> GetVisiteSearch(string search)
        {
            int id;
            string motif;
            string commentaire;
            DateTime heureArr;
            DateTime heureDep;
            DateTime dateVisite;
            bool retour;
            bool hopital;
            bool parent;
            int eleveId;
            string pouls;
            int qteMedicament;
            string nom;
            string prenom;
            VisiteBO uneVisite;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Eleves
            List<VisiteBO> lesVisites = new List<VisiteBO>();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT visite.Id_visite, visite.Motif_visite ,visite.Commentaire_visite, visite.Heure_entree_visite, visite.Heure_sortie_visite, visite.Date_visite, visite.Retour_domicile_visite, visite.Hopital_visite, visite.Parents_prevenus_visite, visite.pouls_eleve_visite, visite.medicament_visite, visite.qte_medicament_visite, visite.Id_eleve, eleve.Nom_eleve, eleve.Prenom_eleve FROM eleve, visite where eleve.Id_eleve = visite.id_eleve AND eleve.Nom_eleve LIKE '%" + search + "%'", maConnexion);
                SqlDataReader monReader = cmd.ExecuteReader();

                // Remplissage de la liste
                while (monReader.Read())
                {
                    id = Int32.Parse(monReader["Id_visite"].ToString());

                    if (monReader["Motif_visite"] == DBNull.Value)
                    {
                        motif = default(string);
                    }
                    else
                    {
                        motif = monReader["Motif_visite"].ToString();
                    }

                    if (monReader["Commentaire_visite"] == DBNull.Value)
                    {
                        commentaire = default(string);
                    }
                    else
                    {
                        commentaire = monReader["Commentaire_visite"].ToString();
                    }

                    if (monReader["Heure_entree_visite"] == DBNull.Value)
                    {
                        heureArr = default(DateTime);
                    }
                    else
                    {
                        heureArr = DateTime.Parse(monReader["Heure_entree_visite"].ToString());
                    }

                    if (monReader["Heure_sortie_visite"] == DBNull.Value)
                    {
                        heureDep = default(DateTime);
                    }
                    else
                    {
                        heureDep = DateTime.Parse(monReader["Heure_sortie_visite"].ToString());
                    }

                    if (monReader["Date_visite"] == DBNull.Value)
                    {
                        dateVisite = default(DateTime);
                    }
                    else
                    {
                        dateVisite = DateTime.Parse(monReader["Date_visite"].ToString());
                    }

                    if (monReader["Retour_domicile_visite"] == DBNull.Value)
                    {
                        retour = default(bool);
                    }
                    else
                    {
                        retour = Boolean.Parse(monReader["Retour_domicile_visite"].ToString());
                    }

                    if (monReader["Hopital_visite"] == DBNull.Value)
                    {
                        hopital = default(bool);
                    }
                    else
                    {
                        hopital = Boolean.Parse(monReader["Hopital_visite"].ToString());
                    }

                    if (monReader["Parents_prevenus_visite"] == DBNull.Value)
                    {
                        parent = default(bool);
                    }
                    else
                    {
                        parent = Boolean.Parse(monReader["Parents_prevenus_visite"].ToString());
                    }

                    if (monReader["Pouls_eleve_visite"] == DBNull.Value)
                    {
                        pouls = default(string);
                    }
                    else
                    {
                        pouls = monReader["Pouls_eleve_visite"].ToString();
                    }

                    qteMedicament = Int32.Parse(monReader["Qte_medicament_visite"].ToString());

                    eleveId = Int32.Parse(monReader["Id_eleve"].ToString());

                    if (monReader["Nom_Eleve"] == DBNull.Value)
                    {
                        nom = default(string);
                    }
                    else
                    {
                        nom = monReader["Nom_Eleve"].ToString();
                    }

                    if (monReader["Prenom_Eleve"] == DBNull.Value)
                    {
                        prenom = default(string);
                    }
                    else
                    {
                        prenom = monReader["Prenom_Eleve"].ToString();
                    }

                    uneVisite = new VisiteBO(id, motif, commentaire, heureArr, heureDep, dateVisite, retour, hopital, parent, pouls, qteMedicament, eleveId, nom, prenom);
                    lesVisites.Add(uneVisite);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return lesVisites;
        }
        #endregion

        #region // Cette méthode affiche le nombre de visite par période avec les date de début et de fin passées en parametre
        // Cette méthode affiche le nombre de visite par période avec les date de début et de fin passées en parametre
        public static int nbVisiteParPeriode(string dateDebut, string dateFin)
        {
            int nbVisite = 0;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(Id_visite) AS NbVisite FROM visite WHERE Date_visite BETWEEN @dateDebut AND @dateFin", maConnexion);

            // Attribution des valeurs aux paramètres 
            cmd.Parameters.AddWithValue("@dateDebut", dateDebut);
            cmd.Parameters.AddWithValue("@dateFin", dateFin);

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

        #region // Cette méthode affiche le nombre total de visite
        // Cette méthode affiche le nombre total d'élève
        public static int nbVisite()
        {
            int nbVisite = 0;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(Id_visite) AS NbVisite FROM visite", maConnexion);

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

        #region // Cette méthode affiche le nombre total de visite
        // Cette méthode affiche le nombre total d'élève
        public static double tempsVisite(DateTime Deb, DateTime Fin)
        {
            List<string> lesVisitesDebutS = new List<string>();
            List<string> lesVisitesFinS = new List<string>();
            List<DateTime> lesVisitesDebut = new List<DateTime>();
            List<DateTime> lesVisitesFin = new List<DateTime>();
            int i = 0;
            double sommeTemps = 0;

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand("SELECT Heure_entree_visite, Heure_sortie_visite FROM visite WHERE CONVERT(date,Date_visite) BETWEEN '" + Deb + "' AND '" + Fin + "'", maConnexion);

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                lesVisitesDebutS.Add(monReader["Heure_entree_visite"].ToString());
                lesVisitesFinS.Add(monReader["Heure_sortie_visite"].ToString());
            }

            foreach (string visiteDebut in lesVisitesDebutS)
            {
                DateTime visiteDebutDT = DateTime.Parse(visiteDebut);
                lesVisitesDebut.Add(visiteDebutDT);
            }

            foreach (string visiteFin in lesVisitesFinS)
            {
                DateTime visiteFinDT = DateTime.Parse(visiteFin);
                lesVisitesFin.Add(visiteFinDT);
            }

            while (i < lesVisitesDebut.Count())
            {
                TimeSpan span = lesVisitesFin[i].Subtract(lesVisitesDebut[i]);
                sommeTemps += span.TotalMinutes;
                i++;
            }
            maConnexion.Close();
            return sommeTemps;
        }
        #endregion

        #region // Cette méthode renvoie l'id de la visite
        // Cette méthode insert une nouvelle Visite passée en paramètre dans la BD
        public static int GetIdVisite(VisiteBO uneVisite)
        {
            int id = 0;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand("SELECT Id_visite FROM visite WHERE Motif_visite = @leMotif AND Pouls_eleve_visite = @lePoul AND Qte_medicament_visite = @laQteMedicament AND Id_eleve = @lIdEleve", maConnexion);


            // Attribution des valeurs aux paramètres 
            cmd.Parameters.AddWithValue("@leMotif", uneVisite.Motif);
            cmd.Parameters.AddWithValue("@lePoul", Convert.ToInt32(uneVisite.Pouls));
            cmd.Parameters.AddWithValue("@laQteMedicament", Convert.ToInt32(uneVisite.QteMedicament));
            cmd.Parameters.AddWithValue("@lIdEleve", Convert.ToInt32(uneVisite.IdEleve));

            SqlDataReader monReader = cmd.ExecuteReader();
            while (monReader.Read())
            {
                id = Convert.ToInt32(monReader["Id_visite"]);
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return id;
        }
        #endregion

        #region // Cette méthode insert une nouvelle Visite passée en paramètre dans la BD
        // Cette méthode insert une nouvelle Visite passée en paramètre dans la BD
        public static int AjoutPrescrire(int idVisite, int idMedic)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand("INSERT INTO prescrire (Id_medicament, Id_visite) VALUES (@lIdMedicament, @lIdVisite)", maConnexion);

            // Attribution des valeurs aux paramètres 

            cmd.Parameters.AddWithValue("@lIdMedicament", Convert.ToInt32(idMedic));
            cmd.Parameters.AddWithValue("@lIdVisite", Convert.ToInt32(idVisite));


            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            return nbEnr;
        }
        #endregion

        #region // Cette méthode modifie le médicament utilisé dans la visite séléctionnée par l'utilisateur
        // Cette méthode modifie le médicament utilisé (passé en paramètre) de la visite séléctionnée (passée en paramètre)
        public static int ModifTablePrescrire(int idVisite, int idMedic)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand("UPDATE prescrire SET Id_medicament = @lIdMedicament WHERE Id_visite = @lIdVisite", maConnexion);

            // Attribution des valeurs aux paramètres 

            cmd.Parameters.AddWithValue("@lIdMedicament", Convert.ToInt32(idMedic));
            cmd.Parameters.AddWithValue("@lIdVisite", Convert.ToInt32(idVisite));


            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            return nbEnr;
        }
        #endregion
    }
}
