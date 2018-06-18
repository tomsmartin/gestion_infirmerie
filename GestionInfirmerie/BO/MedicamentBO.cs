using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BO
{
    public class MedicamentBO
    {
        private int idMedicament;
        private string nomMedicament;
        private bool archiveMedicament;
        private bool utilisationDansUneVisite;

        #region // Constructeur avec l'id
        // Constructeur avec l'id
        public MedicamentBO(int id, string leNom, bool lArchive, bool lUtilisation)
        {
            this.idMedicament = id;
            this.nomMedicament = leNom;
            this.archiveMedicament = lArchive;
            this.utilisationDansUneVisite = lUtilisation;
        }
        #endregion

        #region // Constructeur sans l'id l'archive et lutilisation
        // Constructeur avec l'id
        public MedicamentBO(string leNom)
        {
            this.nomMedicament = leNom;
        }
        #endregion

        #region // Constructeur sans l'id
        // Constructeur sans l'id
        public MedicamentBO(string leNom, bool lArchive, bool lUtilisation)
        {
            this.nomMedicament = leNom;
            this.archiveMedicament = lArchive;
            this.utilisationDansUneVisite = lUtilisation;
        }
        #endregion

        #region // getter/setter
        public int IdMedicament
        {
            get { return idMedicament; }
            set { idMedicament = value; }
        }

        public string NomMedicament
        {
            get { return nomMedicament; }
            set { nomMedicament = value; }
        }


        public bool ArchiveMedicament
        {
            get { return archiveMedicament; }
            set { archiveMedicament = value; }
        }


        public bool UtilisationDansUneVisite
        {
            get { return utilisationDansUneVisite; }
            set { utilisationDansUneVisite = value; }
        }
        #endregion
    }
}
