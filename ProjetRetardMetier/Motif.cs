using System;

namespace ProjetRetardMetier
{
    public class Motif
    {
        public int IdMotif { get; set; }
        public string NomMotif { get; set; }

        public Motif(int unId, string unNom)
        {
            IdMotif = unId;
            NomMotif = unNom;
        }
    }
}
