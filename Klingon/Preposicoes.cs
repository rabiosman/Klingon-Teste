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
                string linha = sr.ReadToEnd();
                ListsFooBar listas = new ListsFooBar();

                string[] letras = linha.Split(" ");

                string[] preposicao = letras
                    .Where(x => x.Length == 3 && listas.Bar()
                    .Contains(x.Substring(2, 1)))
                    .ToArray();

                preposicao = preposicao
                    .Where(y => !y
                    .Contains("d"))
                    .ToArray();

                Console.WriteLine($"Existem {preposicao.Length} preposições.");
            }
            catch (Exception e)
            {
                Console.WriteLine("O arquivo apontado em \"Preposicoes.cs\" não pôde ser lido.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
