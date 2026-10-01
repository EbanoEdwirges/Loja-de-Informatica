using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Informatica
{
    //CLASSE VENDA
    internal class Venda
    {
        public string NomeCliente { get; set; }

        public string FoneCliente { get; set; }

        public string CpfCliente { get; set; }

        //verificar nCompras para confirmar se cliente ativo ou não e fornecer desconto se cliente com X compras
        private List<Cliente> NComprasCliente { get; set; }

        public List<Produto> IdProduto { get; set; }

        public List<Produto> NomeProduto { get; set; }

        public List<Produto> ValorVenda { get; set; }

        public long QtdVenda { get; set; }

        public double ValorTotal { get; set; }
    }
}
