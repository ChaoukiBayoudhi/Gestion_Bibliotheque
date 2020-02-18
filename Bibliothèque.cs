using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpGestionBibliothèque
{
    class Bibliothèque
    {
        public Livres EnsembleLivres { get; set; } = new Livres();
        public Adhérents EnsembleAdhérents { get; set; } = new Adhérents();
        public Emprunts EnsembleEmprunts { get; set; } = new Emprunts();
    }
}
