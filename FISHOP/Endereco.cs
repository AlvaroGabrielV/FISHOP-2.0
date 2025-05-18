using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FISHOP
{
    public class Endereco
    {
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Usuario { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is not Endereco other) return false;

            return Rua == other.Rua &&
                   Numero == other.Numero &&
                   Bairro == other.Bairro &&
                   Cidade == other.Cidade &&
                   Usuario == other.Usuario;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Rua, Numero, Bairro, Cidade, Usuario);
        }
    }
}
