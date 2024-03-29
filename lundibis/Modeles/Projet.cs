﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lundibis.Modeles
{
    class Projet
    {
        #region Attribut
        public static ArrayList CollClassProjet = new ArrayList();
         
        private string nom;
        private DateTime debut;
        private DateTime fin;
        private int prixfactureMO;
        private Mission lesMissions;
        #endregion

        #region Constructeur
        public Projet(string nom, DateTime debut, DateTime fin, int prixfactureMO, Mission lesMissions)
        {
            this.Nom = nom;
            this.Debut = debut;
            this.Fin = fin;
            this.PrixfactureMO = prixfactureMO;
            this.LesMissions = lesMissions;
            Projet.CollClassProjet.Add(this);
            lesMissions = new ArrayList();
        }
        #endregion
        #region Getters / Setters 

        public string Nom { get => nom; set => nom = value; }
        public DateTime Debut { get => debut; set => debut = value; }
        public DateTime Fin { get => fin; set => fin = value; }
        public int PrixfactureMO { get => prixfactureMO; set => prixfactureMO = value; }
        public Mission LesMissions { get => lesMissions; set => lesMissions = value; }
        #endregion
        #region methode
        #endregion
    }
}
