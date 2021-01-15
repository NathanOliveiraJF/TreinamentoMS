using System;
using System.Linq;
using Extensoes;
using System.Collections.Generic;


namespace IntroducaoLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            var vet = new int[] { 1, 2 };
            Console.WriteLine("Antes de passar para o metodo");
            foreach (var item in vet)
            {
                Console.WriteLine(item);
            }

            Imprimir(vet);
            Console.WriteLine("Depois do metodo");

            foreach (var item in vet)
            {
                Console.WriteLine(item);
            }

            


           
        }

        private static void Imprimir(int[] vet)
        {
            vet[0] = 3;
        }
    }
}
