using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Klingon
{
    public static class Numeros
    {
        public static void NumerosBonitos()
        {
            var alfabeto = Alfabeto.DicionarioAlfabeto();

            try
            {
                StreamReader arquivo = new StreamReader(@"klingon-textoB.txt");
                string linha = arquivo.ReadToEnd();
                List<long> lista = new List<long>();
                string[] palavras = linha.Split(" ");

                for (int coluna = 0; coluna < palavras.Length; coluna++)
                {
                    long total = 0;
                    var letras = palavras[coluna].ToCharArray();

                    for (int indice = 0; indice < letras.Length; indice++)
                    {
                        if (indice == 0)
                        {
                            var primeiroNumero = alfabeto.GetValueOrDefault(letras[indice]);
                            primeiroNumero *= 1;
                            total += primeiroNumero;
                        }
                        else if (indice == 1)
                        {
                            var segundoNumero = alfabeto.GetValueOrDefault(letras[indice]);
                            segundoNumero *= 20;
                            total += segundoNumero;
                        }
                        else if (indice == 2)
                        {
                            var terceiroNumero = alfabeto.GetValueOrDefault(letras[indice]);
                            terceiroNumero *= 400;
                            total += terceiroNumero;
                        }
                        else if (indice == 3)
                        {
                            var quartoNumero = alfabeto.GetValueOrDefault(letras[indice]);
                            quartoNumero *= 8000;
                            total += quartoNumero;
                        }
                        else if (indice == 4)
                        {
                            var quintoNumero = alfabeto.GetValueOrDefault(letras[indice]);
                            quintoNumero *= 160000;
                            total += quintoNumero;
                        }
                        else if (indice == 5)
                        {
                            var sextoNumero = alfabeto.GetValueOrDefault(letras[indice]);
                            sextoNumero *= 3200000;
                            total += sextoNumero;
                        }
                        else if (indice == 6)
                        {
                            var setimoNumero = alfabeto.GetValueOrDefault(letras[indice]);
                            setimoNumero *= 64000000;
                            total += setimoNumero;
                        }
                        else if (indice == 7)
                        {
                            var oitavoNumero = alfabeto.GetValueOrDefault(letras[indice]);
                            oitavoNumero *= 1280000000;
                            total += oitavoNumero;
                        }
                        else if (indice == 8)
                        {
                            var nonoNumero = alfabeto.GetValueOrDefault(letras[indice]);
                            nonoNumero *= 25600000000;
                            total += nonoNumero;
                        }
                        else if (indice == 9)
                        {
                            var decimoNumero = alfabeto.GetValueOrDefault(letras[indice]);
                            decimoNumero *= 512000000000;
                            total += decimoNumero;
                        }
                    }
                    if (total >= 440566 && (total % 3) == 0)
                    {
                        lista.Add(total);
                    }
                }
                Console.WriteLine($"Existem {lista.Distinct().Count()} números bonitos distintos.");

            }
            catch (Exception e)
            {
                Console.WriteLine("O arquivo apontado em \"Numeros.cs\" não pôde ser lido.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
