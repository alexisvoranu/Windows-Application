using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectNou2
{
    [Serializable]
    public class Produse
    {
        public string denumire;
        public DateTime dataFabricatiei;
        public DateTime dataDeExpirare;
        public int nrLot;
        public List<string> compozitii = new List<string>();

        public Produse(string d, DateTime df, DateTime de, int l)
        {
            nrLot = l;
            denumire = d;
            dataFabricatiei = df;
            dataDeExpirare = de;
        }

        public void adauga(FisaConsum f)
        {
            string compozitie = f.materiePrima + ", " + f.proportie.ToString() + "%";
;           compozitii.Add(compozitie);
        }

        public Produse()
        { }

    }

   
}
