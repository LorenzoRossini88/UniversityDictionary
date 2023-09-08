using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDictionary
{
    public class Matricola
    {
        public int Numero { get; set; }
        public string NomeStudente { get; set; }
        public Dictionary<int, Esame> Esami { get; set; }

        public Matricola(int numero, string nomeStudente)
        {
            Numero = numero;
            NomeStudente = nomeStudente;
            Esami = new Dictionary<int, Esame>();
        }
    }
}
