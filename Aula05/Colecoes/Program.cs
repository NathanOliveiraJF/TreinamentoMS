using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteLine(100);
            WriteLine(100.5);
            WriteLine("Teste");

            Console.WriteLine("Tamanho da Lista");
            IList<Aluno> alunos = new ObservableCollection<Aluno>();
            alunos.Add(RetornaAlunos(123));
            alunos.Add(RetornaAlunos(125));

            var turma = new Turma();
            turma.Alunos = alunos;

            object obj = alunos[0];


            Imprimir(alunos);

            Aluno recuperado = obj as Aluno;

            var b = RetornaAlunos(125);

            if (recuperado != null)
                Console.WriteLine($"{recuperado.Nome} recuperado");

            Console.WriteLine($"{recuperado.Nome}");

            if (alunos.Contains(b))
                Console.Write($"está presente");

            Console.ReadKey();



        }

        private static bool ExisteItem(List<Aluno> alunos, Aluno aluno)
        {
            return alunos.Contains(aluno);
        }

        private static void Imprimir(IList<Aluno> alunos)
        {
            Console.WriteLine("Alunos informados");

            foreach (var a in alunos)
                // Console.WriteLine($"  Nome: {a.Nome}, matrícula: {a.Matricula}, idade: {a.Idade}");
                Console.WriteLine(a);

       
            IEnumerable<Aluno> lista = alunos;
            IEnumerator<Aluno> enumerator = lista.GetEnumerator();
            enumerator.Reset();
            while (enumerator.MoveNext())
                Console.WriteLine($"Nome: {enumerator.Current.Nome} - matrícula: {enumerator.Current.Matricula}");
        }


        public static void WriteLine(int x)
        {
            Console.Write($"(int): {x}");
        }

        public static void WriteLine(double x)
        {
            Console.Write($"(double): {x}");
        }

        public static void WriteLine(object x)
        {
            Console.Write($"{x.GetType()}: {x.ToString()}");

        }
        private static Aluno RetornaAlunos(int matricula)
        {
            if (matricula == 123)
                return new Aluno { Matricula = 123, Nome = "Ana", Idade = 20 };
            else
                return new Aluno { Matricula = 123, Nome = "Bruno", Idade = 21 };

        }
    }
}
