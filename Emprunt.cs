using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpGestionBibliothèque
{
    class Emprunt
    {
        public int CodeLivre { get; set; }
        public int IdAdhérent { get; set; }
        public DateTime DateEmprunt { get; set; }
        public DateTime DateRetour { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Emprunt emprunt &&
                   CodeLivre == emprunt.CodeLivre &&
                   IdAdhérent == emprunt.IdAdhérent &&
                   DateEmprunt == emprunt.DateEmprunt;
        }

        public override int GetHashCode()
        {
            var hashCode = -28161095;
            hashCode = hashCode * -1521134295 + CodeLivre.GetHashCode();
            hashCode = hashCode * -1521134295 + IdAdhérent.GetHashCode();
            hashCode = hashCode * -1521134295 + DateEmprunt.GetHashCode();
            return hashCode;
        }
    }
}
