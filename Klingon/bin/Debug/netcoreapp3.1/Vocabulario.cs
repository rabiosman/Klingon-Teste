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
            var alfabeto = Alfabeto.DicionarioAlfabeto();

            try
            {
                StreamReader sr = new StreamReader(@"klingon-textoB.txt");
                string linha = sr.ReadToEnd();
                string[] letras = linha.Split(" ");

                string[] resultado = letras
                    .OrderBy(x => alfabeto[Convert.ToChar(x.Substring(0, 1))])
                    .ThenBy(x => alfabeto[Convert.ToChar(x.Substring(1, 1))])
                    .ThenBy(x => alfabeto[Convert.ToChar(x.Substring(2, 1))])
                    .Distinct()
                    .ToArray();

                Console.WriteLine($"\nA lista de vocabulário é:\n{string.Join(" ", resultado)}\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("O arquivo apontado em \"Vocabulario.cs\" não pôde ser lido.");
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
