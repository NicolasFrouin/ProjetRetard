using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetRetardMetier
{
    public class Retard
    {
        public string DateRetard { get; set; }
        public bool EstExcuse { get; set; }
        public int IdRetard { get; set; }
        public Motif LeMotif { get; set; }

        public Retard(int unId, string uneDate, Motif unMotif, bool unExcuse)
        {
            IdRetard = unId;
            DateRetard = uneDate;
            LeMotif = unMotif;
            EstExcuse = unExcuse;
        }
    }
}
