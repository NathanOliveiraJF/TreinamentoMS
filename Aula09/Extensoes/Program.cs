using System;
using System.Linq;

namespace Extensoes
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "Juiz de Fora";

            Console.WriteLine(MeusMetodos.AdicionarAspas(texto));
            Console.WriteLine(texto.AdicionarAspas());
            Console.WriteLine($"{texto[0]} é {(MeusMetodos.EhVogal(texto[0]) ? "é vogal": "não é vogal" )}.");
            Console.WriteLine($"Existem {MeusMetodos.ContaVogais(texto)} vogais em '{texto}' .");

            var vet = new int[] { 1, 2, 3, 4, 5 };
            var newvet = vet.Selecionar(x => x != 2);
            Console.WriteLine();
        }
    }
}
