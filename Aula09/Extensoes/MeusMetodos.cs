using System;
using System.Collections.Generic;
using System.Text;

namespace Extensoes
{
    public static class MeusMetodos
    {
        public static string AdicionarAspas(this string texto)
        {
            return "\"" + texto + "\"";
        }

        public static IEnumerable<T> Selecionar<T>(this IEnumerable<T> vetor, Func<T, bool> selections)
        {
            var vet = new List<T>();
            foreach (var item in vetor)
            {
                if (selections(item))
                {
                    vet.Add(item);
                }
            }

            return vet;
        }

        public static int ContaVogais(this string texto)
        {
            var qtdeVogais = 0;

            foreach (var caractere in texto)
            {
                if (EhVogal(caractere))
                    qtdeVogais++;
            }

            return qtdeVogais;
        }

        public static bool EhVogal(this char caractere)
        {
            return (caractere == 'a' || caractere == 'e' || caractere == 'i' || caractere == 'o' || caractere == 'u') ||
                (caractere == 'A' || caractere == 'E' || caractere == 'I' || caractere == 'O' || caractere == 'U');
        }
    }
}
