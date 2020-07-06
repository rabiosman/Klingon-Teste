using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Klingon
{
    public static class Verbos
    {
        public static void VerbosTextoB()
        {
            try
            {
                StreamReader sr = new StreamReader(@"klingon-textoB.txt");
                string linha = sr.ReadToEnd();
                string[] letras = linha.Split(" ");
                ListsFooBar listas = new ListsFooBar();

                string[] verbos = letras
                    .Where(x => x.Length >= 8 && listas.Foo()
                    .Contains(x.Substring(x.Length - 1, 1)))
                    .ToArray();

                string[] verbosPrimeiraPessoa = verbos
                    .Where(x => listas.Bar()
                    .Contains(x.Substring(0, 1)))
                    .ToArray();

                Console.WriteLine($"\nExistem {verbos.Length} verbos.\n");
                Console.WriteLine($"Existem {verbosPrimeiraPessoa.Length} verbos em primeira pessoa.\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("O arquivo apontado em \"Verbos.cs\" não pôde ser lido.");
                Console.WriteLine(e.Message);
            }            
        }
    }
}
