using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FISHOP
{
    public static class EnderecoService
    {
    
        private static List<Endereco> enderecos = new List<Endereco>();

        public static void AdicionarEndereco(Endereco e)
        {
            enderecos.Add(e);
        }

        public static void RemoverEndereco(Endereco e)
        {
            enderecos.Remove(e);
        }

        public static List<Endereco> ObterEnderecos()
        {
            return new List<Endereco>(enderecos); // cópia para segurança
        }

        public static void LimparEnderecos()
        {
            enderecos.Clear();
        }
    }
}
