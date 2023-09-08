using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDictionary
{
    public class Universita
    {
        public string Nome { get; set; }
        public Dictionary<int, Corso> Corsi { get; set; }

        public Universita(string nome)
        {
            Nome = nome;
            Corsi = new Dictionary<int, Corso>();
        }
    }
}
