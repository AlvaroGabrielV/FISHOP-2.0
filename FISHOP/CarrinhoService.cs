using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FISHOP
{
    public static class CarrinhoService
    {
        private static List<Item> produtos = new List<Item>();

        public static void AdicionarProduto(Item p)
        {
            
            var existente = produtos.FirstOrDefault(x => x.Title == p.Title && x.Source == p.Source);
            if (existente != null)
            {
                existente.Quantidade += p.Quantidade;
            }
            else
            {
                produtos.Add(p);
            }
        }

        public static void RemoverProduto(Item p)
        {
            var existente = produtos.FirstOrDefault(x => x.Title == p.Title && x.Source == p.Source);
            if (existente != null)
            {
                produtos.Remove(existente);
            }
        }

        public static List<Item> ObterProdutos()
        {
            return new List<Item>(produtos); // Retorna cópia para evitar manipulação externa
        }

        public static void LimparCarrinho()
        {
            produtos.Clear();
        }

        public static decimal ObterTotal()
        {
            return produtos.Sum(p => p.ValorNumerico * p.Quantidade);
        }

        public static void AtualizarQuantidade(Item p, int novaQuantidade)
        {
            var existente = produtos.FirstOrDefault(x => x.Title == p.Title && x.Source == p.Source);
            if (existente != null)
            {
                existente.Quantidade = novaQuantidade;
            }
        }

        public static int ObterQuantidadeTotal()
        {
            return produtos.Sum(p => p.Quantidade);
        }

    }
}
