using MyWebApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.DataAccess
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly MyWebAppContext _myWebAppContext;
        public ProdutoRepository(MyWebAppContext myWebAppContext)
        {
            _myWebAppContext = myWebAppContext;
        }

        public Produto Get(int id)
        {
            return _myWebAppContext.Produtos.FirstOrDefault(x=> x.Id == id);
        }

        public void Insert(Produto produto)
        {
            _myWebAppContext.Produtos.Add(produto);
            _myWebAppContext.SaveChanges();
        }

        public List<Produto> List()
        {
            return _myWebAppContext.Produtos.ToList();
        }
    }
}
