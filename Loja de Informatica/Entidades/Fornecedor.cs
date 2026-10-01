using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Informatica
{
    internal class Fornecedor
    {
        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string CNPJ { get; set; }

        public List<Produto> _produtosFornecedor = new List<Produto>();
    }
}
