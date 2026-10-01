using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Informatica
{
    //CLASSE CLIENTE
    internal class Cliente
    {
        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string CPF { get; set; }

        //incrementar +1 sempre que cliente realizar uma compra
        public List<long> _compras { get; set; } = new List<long>();
    }
}
