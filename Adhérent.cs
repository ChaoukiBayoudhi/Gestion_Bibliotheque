using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpGestionBibliothèque
{
    enum Genre { Homme, Femme}
    class Adhérent 
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public DateTime DateNaiss { get; set; }
        public Genre Sexe { get; set; }
        public int NbreEmpruntsEnCours{ get; set; }

        public override bool Equals(object obj)
        {
            return obj is Adhérent adhérent &&
                   Id == adhérent.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }
    }
}
