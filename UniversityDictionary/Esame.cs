using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDictionary
{
    public class Esame
    {
        public string Nome { get; set; }
        public Corso CorsoAssociato { get; set; }
        public Voto VotoAssociato { get; set; }

        public Esame(string nome, Corso corsoAssociato)
        {
            Nome = nome;
            CorsoAssociato = corsoAssociato;
        }
    }
}
