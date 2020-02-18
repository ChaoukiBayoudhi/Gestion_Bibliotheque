using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tpGestionBibliothèque
{
    class Livre
    {
        public int Code { get; set; }
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int NbExemplaire { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Livre livre &&
                   Titre == livre.Titre &&
                   Auteur == livre.Auteur;
        }

        public override int GetHashCode()
        {
            var hashCode = 185120634;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Titre);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Auteur);
            return hashCode;
        }
    }
}
