using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Informatica
{
    //CLASSE PRODUTO
    internal class Produto
    {
        public string Nome { get; set; }

        public string CodigoBarra { get; set; }

        public string Fabricante { get; set; }

        public string NomeFornecedor { get; set; }

        public double ValorCompra { get; set; }

        public double ValorVenda { get; set; }

        public int Estoque { get; set; }
    }
}
