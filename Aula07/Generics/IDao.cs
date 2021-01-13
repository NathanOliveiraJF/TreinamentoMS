using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    interface IDao<T>
    {
        void Inserir(T objeto);
        void Excluir(T objeto);
        IList<T> RetornarTodos();
    }
}
