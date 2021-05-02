using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetRetardMetier
{
    public class Etudiant
    {
        public int IdEtudiant { get; set; }
        public string NomEtudiant { get; set; }
        public List<Retard> LesRetards { get; set; }


        public Etudiant(int unId, string unNom)
        {
            IdEtudiant = unId;
            NomEtudiant = unNom;
            LesRetards = new List<Retard>();
        }
        public void AjouterRetard(Retard unRetard)
        {
            LesRetards.Add(unRetard);
        }
        public int GetNbRetardExcuses()
        {
            return LesRetards.FindAll(r => r.EstExcuse).Count;

            //int nbRetardExcuses = 0;
            //foreach (Retard r in LesRetards)
            //{
            //    if (r.EstExcuse)
            //    {
            //        nbRetardExcuses++;
            //    }
            //}
            //return nbRetardExcuses;
        }
        public int GetNbRetardMotif(Motif unMotif)
        {
            return LesRetards.FindAll(r => r.LeMotif.NomMotif.CompareTo(unMotif.NomMotif) == 0).Count;

            //int nbRetardMotif = 0;
            //foreach (Retard r in LesRetards)
            //{
            //    if (r.LeMotif.NomMotif.CompareTo(unMotif.NomMotif) == 0)
            //    {
            //        nbRetardMotif++;
            //    }
            //}
            //return nbRetardMotif;
        }
        public int GetNbRetardTotal()
        {
            return LesRetards.Count;
        }
        public double GetPourcentageRetardExcuses()
        {
            return Math.Round((double) GetNbRetardExcuses() / GetNbRetardTotal() * 100, 2);
        }
        public double GetPourcentageRetardNonExcuses()
        {
            return 100 - GetPourcentageRetardExcuses();
        }
    }
}
