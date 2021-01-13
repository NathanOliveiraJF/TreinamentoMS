using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class ProdutoDAO : IDao<Produto>
    {
        public void Excluir(Produto objeto)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Produto objeto)
        {
            throw new NotImplementedException();
        }

        public IList<Produto> RetornarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
