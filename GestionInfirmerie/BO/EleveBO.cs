using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BO
{
    public class EleveBO
    {
        private int idEleve;
        private string prenomEleve;
        private string nomEleve;
        private DateTime dateNaissanceEleve;
        private string santeEleve;
        private string telEleve;
        private string telPereELeve;
        private string telMereEleve;
        private bool archiveEleve;
        private bool tiersTemps;
        private bool visiteInfirmerie;
        private int idClasseEleve;

        #region //Constructeur avec l'id
        public EleveBO(int id, string leNom, string lePrenom, DateTime laDate, string laSante, string leTelEleve, string leTelPere, string leTelMere, bool lArchive, bool leTiersTemps, bool laVisiteInfirmerie, int classId)
        {
            this.idEleve = id;
            this.prenomEleve = lePrenom;
            this.nomEleve = leNom;
            this.dateNaissanceEleve = laDate;
            this.santeEleve = laSante;
            this.telEleve = leTelEleve;
            this.telPereELeve = leTelPere;
            this.telMereEleve = leTelMere;
            this.archiveEleve = lArchive;
            this.tiersTemps = leTiersTemps;
            this.visiteInfirmerie = laVisiteInfirmerie;
            this.idClasseEleve = classId;
        }
        #endregion

        #region // Constructeur sans l'id, la viste, le tier temps et l'archive
        // Constructeur sans l'id, la viste, le tier temps et l'archive
        public EleveBO(string leNom, string lePrenom, DateTime laDate, string laSante, string leTelEleve, string leTelPere, string leTelMere, int classId)
        {
            this.prenomEleve = lePrenom;
            this.nomEleve = leNom;
            this.dateNaissanceEleve = laDate;
            this.santeEleve = laSante;
            this.telEleve = leTelEleve;
            this.telPereELeve = leTelPere;
            this.telMereEleve = leTelMere;
            this.idClasseEleve = classId;
        }
        #endregion

        #region // Constructeur import csv
        // Constructeur import csv
        public EleveBO(string leNom, string lePrenom, DateTime laDate, string leTelEleve, string leTelPere, string leTelMere, int classId)
        {
            this.prenomEleve = lePrenom;
            this.nomEleve = leNom;
            this.dateNaissanceEleve = laDate;
            this.telEleve = leTelEleve;
            this.telPereELeve = leTelPere;
            this.telMereEleve = leTelMere;
            this.idClasseEleve = classId;
        }
        #endregion

        #region //getter/setter
        public string NomEleve
        {
            get { return nomEleve; }
            set { nomEleve = value; }
        }

        public string PrenomEleve
        {
            get { return prenomEleve; }
            set { prenomEleve = value; }
        }

        public DateTime DateNaissanceEleve
        {
            get { return dateNaissanceEleve; }
            set { dateNaissanceEleve = value; }
        }

        public string SanteEleve
        {
            get { return santeEleve; }
            set { santeEleve = value; }
        }

        public string TelEleve
        {
            get { return telEleve; }
            set { telEleve = value; }
        }

        public string TelPereELeve
        {
            get { return telPereELeve; }
            set { telPereELeve = value; }
        }

        public string TelMereEleve
        {
            get { return telMereEleve; }
            set { telMereEleve = value; }
        }

        public bool ArchiveEleve
        {
            get { return archiveEleve; }
            set { archiveEleve = value; }
        }

        public bool TiersTemps
        {
            get { return tiersTemps; }
            set { tiersTemps = value; }
        }

        public bool VisiteInfirmerie
        {
            get { return visiteInfirmerie; }
            set { visiteInfirmerie = value; }
        }

        public int IdClasseEleve
        {
            get { return idClasseEleve; }
            set { idClasseEleve = value; }
        }

        public int IdEleve
        {
            get { return idEleve; }
            set { idEleve = value; }
        }
        #endregion
    }
}
