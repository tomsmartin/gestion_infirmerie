using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BO
{
    public class ClasseBO
    {
        private int idClasse;
        private string nomClasse;
        private string emploiDuTemps;
        private bool possedeEleve;
        private bool possedeEDT;

        

        #region // Constructeur avec l'id
        // Constructeur pour la modification d'une classe avec un ajout d'EDT
        public ClasseBO(int id, string leNom, string lEmploiDuTemps, bool eleve, bool possedeEDT)
        {
            this.idClasse = id;
            this.nomClasse = leNom;
            this.emploiDuTemps = lEmploiDuTemps;
            this.possedeEleve = eleve;
            this.possedeEDT = possedeEDT;
        }
        #endregion

        #region // Constructeur pour la modification d'une classe sans EDT
        // Constructeur pour la modification d'une classe sans ajouter un EDT
        public ClasseBO(int id, string leNom, bool eleve)
        {
            this.idClasse = id;
            this.nomClasse = leNom;
            this.possedeEleve = eleve;
        }
        #endregion

        #region // Constructeur pour l'ajout d'une classe sans EDT
        // Constructeur pour l'ajout d'une classe sans EDT
        public ClasseBO(string leNom)
        {
            this.nomClasse = leNom;
        }
        #endregion

        #region // Constructeur pour l'ajout d'une classe avec EDT
        // Constructeur pour l'ajout d'une classe avec un EDT
        public ClasseBO(string leNom, string lEmploiDuTemps)
        {
            this.nomClasse = leNom;
            this.emploiDuTemps = lEmploiDuTemps;
        }
        #endregion

        #region // getter/setter
        public int IdClasse
        {
            get { return idClasse; }
            set { idClasse = value; }
        }

        public string NomClasse
        {
            get { return nomClasse; }
            set { nomClasse = value; }
        }

        public string EmploiDuTemps
        {
            get { return emploiDuTemps; }
            set { emploiDuTemps = value; }
        }


        public bool PossedeEleve
        {
            get { return possedeEleve; }
            set { possedeEleve = value; }
        }

        public bool PossedeEDT
        {
            get { return possedeEDT; }
            set { possedeEDT = value; }
        }
        #endregion
    }
}
