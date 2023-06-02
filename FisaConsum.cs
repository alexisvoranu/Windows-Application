using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectNou2
{
    [Serializable]
    public class FisaConsum
    {
        public int proportie;
        public string materiePrima;

        public FisaConsum(string m, int c)
        {
            proportie = c;
            materiePrima = m;
        }

        public FisaConsum()
        { }
    }
}
