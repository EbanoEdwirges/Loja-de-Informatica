using Loja_de_Informatica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Informatica
{
    //CLASSE COMPRA
    internal class Compra
    {
        public string NomeFornecedor { get; set; }

        public string TelefoneFornecedor { get; set; }

        public string CnpjFornecedor { get; set; }

        public List<ItemCompra> _itensCompra = new List<ItemCompra>();

        public double ValorTotal { get; set; }

        public NotaFiscal NotaFiscal { get; set; }

        public string[] FormaPagamento { get; set; } = { "A Vista", "Pix", "Crédito", "Débito" };

        public string[] NumeroParcelasCredito { get; set; } = { "1x", "2x", "3x", "4x", "5x", "6x" };

        public bool Pago { get; set; }
    }
}
