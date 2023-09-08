using System;
using System.Collections.Generic;

namespace UniversityDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Universita> universitaDict = new Dictionary<int, Universita>();
            Dictionary<int, Corso> corsoDict = new Dictionary<int, Corso>();
            Dictionary<int, Matricola> matricolaDict = new Dictionary<int, Matricola>();
            Dictionary<int, Esame> esameDict = new Dictionary<int, Esame>();
            Dictionary<int, Voto> votoDict = new Dictionary<int, Voto>();

            Universita universita = new Universita("Università Rossini");
            universitaDict.Add(1, universita);

            Corso giornalismo = new Corso("Giornalismo Sportivo");
            Corso matematica = new Corso("Matematica");
            corsoDict.Add(1, giornalismo);
            corsoDict.Add(2, matematica);

            Matricola lorenzo = new Matricola(1001, "Lorenzo Rossini");
            Matricola daniel = new Matricola(1002, "Daniel De Astis");
            matricolaDict.Add(1, lorenzo);
            matricolaDict.Add(2, daniel);

            universita.Corsi.Add(1, giornalismo);
            universita.Corsi.Add(2, matematica);

            giornalismo.Matricole.Add(1, lorenzo);
            matematica.Matricole.Add(2, daniel);

            Esame esame1 = new Esame("Comunicazione Sportiva", giornalismo);
            Esame esame2 = new Esame("Analisi II", matematica);
            esameDict.Add(1, esame1);
            esameDict.Add(2, esame2);

            Voto voto1 = new Voto(30, esame1);
            Voto voto2 = new Voto(27, esame2);
            votoDict.Add(1, voto1);
            votoDict.Add(2, voto2);

            esame1.VotoAssociato = voto1;
            esame2.VotoAssociato = voto2;

            lorenzo.Esami.Add(1, esame1);
            daniel.Esami.Add(2, esame2);

            // Esempio di accesso ai dati tramite le relazioni
            Console.WriteLine("Informazioni su Lorenzo Rossini:");
            Console.WriteLine("Nome: " + lorenzo.NomeStudente);
            Console.WriteLine("Università: " + universitaDict[1].Nome);
            Console.WriteLine("Corsi:");
            foreach (var corso in lorenzo.Esami.Values)
            {
                Console.WriteLine("- Corso: " + corso.CorsoAssociato.Nome);
                Console.WriteLine("  Esame: " + corso.Nome);
                Console.WriteLine("  Voto: " + corso.VotoAssociato.Valore);
            }

            Console.WriteLine("\nInformazioni su Daniel:");
            Console.WriteLine("Nome: " + daniel.NomeStudente);
            Console.WriteLine("Università: " + universitaDict[1].Nome);
            Console.WriteLine("Corsi:");
            foreach (var corso in daniel.Esami.Values)
            {
                Console.WriteLine("- Corso: " + corso.CorsoAssociato.Nome);
                Console.WriteLine("  Esame: " + corso.Nome);
                Console.WriteLine("  Voto: " + corso.VotoAssociato.Valore);
            }
        }
    }
}
