using System;
using System.Collections.Generic;
using System.Text;

namespace Colecoes
{
    class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public override bool Equals(object obj)
        {

            var outro = obj as Aluno;

            return outro != null && this.Matricula == outro.Matricula;
        }

        public override int GetHashCode()
        {
            return $"##@Aluno@##{Matricula}".GetHashCode();
        }

        public override string ToString()
        {
            return $"{Matricula} - {Nome}";
        }
    }
}
