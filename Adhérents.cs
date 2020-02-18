using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpGestionBibliothèque
{
    class Adhérents
    {
        //public List<Adhérent> lstAdhérents { get; set; }
        //public Adhérents()
        //{
        //    lstAdhérents = new List<Adhérent>();
        //}
        //or simply
        public List<Adhérent> lstAdhérents { get; set; } = new List<Adhérent>();

        public bool Add(Adhérent ad)
        {
            if (lstAdhérents.Contains(ad))
                return false;
            lstAdhérents.Add(ad);
            return true;
        }
    }
}
