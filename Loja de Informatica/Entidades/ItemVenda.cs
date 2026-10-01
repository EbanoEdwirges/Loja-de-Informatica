using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Informatica
{
    //ITEM VENDA
    internal class ItemVenda
    {
        public Produto Produto { get; set; }

        public decimal PrecoUnitario { get; set; }

        public int Quantidade { get; set; }

        public decimal SubTotal { get; set; }
    }
}
