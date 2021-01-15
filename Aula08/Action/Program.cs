using System;
using System.Collections.Generic;

namespace ActionFunc
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto[] produtos = RetornarProdutos();
            Cliente[] clientes = RetornarClientes();

            TestarFuncs(produtos, clientes);

            Console.ReadKey();
        }

        private static Cliente[] RetornarClientes()
        {
            return new Cliente[]
             {
                new Cliente { Nome = "Sirvir" },
                new Cliente { Nome = "Draven" },
                new Cliente { Nome = "Jinx" },
                new Cliente { Nome = "Malzahar" },
                new Cliente { Nome = "Ilaoi" },

             };
        }

        private static void TestarFuncs(Produto[] produtos, Cliente[] clientes)
        {
            Console.WriteLine("Produtos iniciados com P");
            Imprimir(produtos, prod => prod.Descricao.StartsWith('P'));

            Console.WriteLine("Produtos com preço menos que 10");
            Imprimir(produtos, x => x.Preco < 10);

            var clientesComNomeTerminadosEmA = Selecionar(clientes, x => x.Nome.EndsWith("a") || x.Nome.EndsWith("A"));
            var vetor = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            var pares = Selecionar(vetor, x => x % 2 == 0);

            vetor = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var impares = Selecionar(vetor, x => x % 2 != 0);

            Console.ReadKey();
        }

        private static IEnumerable<T> Selecionar<T>(IEnumerable<T> TObjetos, Func<T, bool> selecionar)
        {
            var resultados = new List<T>();

            foreach (var obj in TObjetos)
                if (selecionar(obj))
                    resultados.Add(obj);

            return TObjetos;
        }

        private static void Imprimir(Produto[] produtos, Func<Produto, bool> selecionar)
        {
            foreach (var item in produtos)
            {
                if (selecionar(item))
                    Console.WriteLine($"{item.Descricao}, preço: {item.Preco:C2}");
            }
        }

        private static void TestarActions(Produto[] produtos)
        {
            var produtosIniciadosPorP = Selecionar(produtos, x => x.Descricao.StartsWith("P"));

            var produtosComPrecoMaiorQue10 = Selecionar(produtos, x => x.Preco > 10);

            Console.ReadKey();
        }

        private static void ImprimirPrecoMaiorQue7(Produto prod)
        {

            if (prod.Preco > 7)
                Console.WriteLine($"{prod.Descricao}, {prod.Preco:C2}");
        }

        private static void ImprimirParaCada(Produto[] produtos, Action<Produto> metodoSelecao)
        {
            foreach (var item in produtos)
            {
                metodoSelecao(item);
            }
        }

        private static Produto[] RetornarProdutos()
        {
            return new Produto[]
            {
                new Produto { Codigo = 1, Descricao = "Coca-Cola", Preco = 5.5 },
                new Produto { Codigo = 2, Descricao = "Pizza A", Preco = 35.50 },
                new Produto { Codigo = 3, Descricao = "Pizza B", Preco = 25.5 },
                new Produto { Codigo = 4, Descricao = "Pastel A", Preco = 15.5 },
                new Produto { Codigo = 5, Descricao = "Batata Frita", Preco = 25.5 },
            };
        }
    }
}
