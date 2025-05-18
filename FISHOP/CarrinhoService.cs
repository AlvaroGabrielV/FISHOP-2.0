using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FISHOP
{
    public static class CarrinhoService
    {
        public static List<Item> ProdutosNoCarrinho { get; private set; } = new List<Item>();

        public static void AdicionarProduto(Item p)
        {
            ProdutosNoCarrinho.Add(p);
        }

        public static void RemoverProduto(Item p)
        {
            ProdutosNoCarrinho.Remove(p);
        }

    }
}
