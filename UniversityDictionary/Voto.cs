using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDictionary
{
    public class Voto
    {
        public double Valore { get; set; }
        public Esame EsameAssociato { get; set; }

        public Voto(double valore, Esame esameAssociato)
        {
            Valore = valore;
            EsameAssociato = esameAssociato;
        }
    }
}
