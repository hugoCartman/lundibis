using System;

namespace lundibis.Modeles
{
    class Mission
    {
        #region Attributs
        public static ArrayList CollClassMission = new ArrayList();

        private string nom;
        private string description;
        private int nbHeuresPrevues;
        private dictionnary releveHoraire = new Dictionary<DateTime, int>();
        private Intervenant executant;
        #endregion

        #region Constructeurs
        public Mission(string nom, string description, int nbHeuresPrevues, dictionnary releveHoraire, Intervenant executant)
        {
            this.nom = Nom;
            this.description = Description;
            this.nbHeuresPrevues = NbHeuresPrevues;
            this.releveHoraire = ReleveHoraire;
            this.executant = Executant;
            Mission.CollClassMission.Add(this);

        }
        #endregion

        #region Constructeurs
        public string Nom { get => nom; set => nom = value; }
        public string Description { get => description; set => description = value; }
        public int NbHeuresPrevues { get => nbHeuresPrevues; set => nbHeuresPrevues = value; }
        public dictionnary ReleveHoraire { get => releveHoraire; set => releveHoraire = value; }
        public Intervenant Executant { get => executant; set => executant = value; }
        #endregion
    }
}

