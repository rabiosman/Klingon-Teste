using System;
using System.IO;
using System.Linq;

namespace Klingon
{
    public static class Preposicoes
    {
        public static void PreposicoesTextoB()
        {
            try
            {
                StreamReader sr = new StreamReader(@"klingon-textoB.txt");
                string line = sr.ReadToEnd();
                ListsFooBar lists = new ListsFooBar();

                string[] letters = line.Split(" ");

                string[] preposition = letters
                    .Where(x => x.Length == 3 && lists.Bar()
                    .Contains(x.Substring(2, 1)))
                    .ToArray();

                preposition = preposition
                    .Where(y => !y
                    .Contains("d"))
                    .ToArray();

                Console.WriteLine($"Existem {preposition.Length} preposições.");
            }
            catch (Exception e)
            {
                Console.WriteLine("O arquivo apontado em \"Preposicoes.cs\" não pôde ser lido.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
