using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Klingon
{
    public static class Vocabulario
    {
        public static void ListaVocabulario()
        {
            var alphabet = Alphabet.AlphabetDictionary();

            try
            {
                StreamReader sr = new StreamReader(@"klingon-textoB.txt");
                string line = sr.ReadToEnd();
                string[] letters = line.Split(" ");

                string[] result = letters
                    .OrderBy(x => alphabet[Convert.ToChar(x.Substring(0, 1))])
                    .ThenBy(x => alphabet[Convert.ToChar(x.Substring(1, 1))])
                    .ThenBy(x => alphabet[Convert.ToChar(x.Substring(2, 1))])
                    .Distinct()
                    .ToArray();

                Console.WriteLine($"\nA lista de vocabulário é:\n{string.Join(" ", result)}\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("O arquivo apontado em \"Vocabulario.cs\" não pôde ser lido.");
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
