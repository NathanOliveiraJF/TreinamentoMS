using System;
using System.Collections.Generic;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tamanho da Lista");
            var idades = new List<int>();
            idades.Add(30);
            idades.Add(20);
            idades.Add(10);
            idades.Add(20);

            if (idades.Contains(20))
                Console.Write("A idade 20 está presente");

            Console.ReadKey();



        }

        private static bool ExisteItem(List<int> idades, int idade)
        {
            return idades.Contains(idade);
        }

        private static void Imprimir(List<int> idades)
        {
            Console.WriteLine("idades informadas");

            for (int i = 0; i < idades.Count; i++)
                Console.Write($"{idades[i]}");
        }
    }
}
