using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetRetardMetier
{
    public class Classe
    {
        public int IdClasse { get; set; }
        public string NomClasse { get; set; }
        public List<Etudiant> LesEtudiants { get; set; }

        public Classe(int unId, string unNom)
        {
            IdClasse = unId;
            NomClasse = unNom;
            LesEtudiants = new List<Etudiant>();
        }
        public void AjouterEtudiant(Etudiant unEtudiant)
        {
            LesEtudiants.Add(unEtudiant);
        }
    }
}
