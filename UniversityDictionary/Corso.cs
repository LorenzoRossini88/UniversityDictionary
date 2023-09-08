using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDictionary
{
    public class Corso
    {
        public string Nome { get; set; }
        public Dictionary<int, Matricola> Matricole { get; set; }

        public Corso(string nome)
        {
            Nome = nome;
            Matricole = new Dictionary<int, Matricola>();
        }
    }
}
