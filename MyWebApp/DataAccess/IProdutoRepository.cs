using System.Collections.Generic;
using MyWebApp.Entidades;

namespace MyWebApp.DataAccess
{
    public interface IProdutoRepository
    {
        List<Produto> List();
        Produto Get(int id);
    }
}