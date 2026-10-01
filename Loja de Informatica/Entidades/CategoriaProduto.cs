using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Informatica
{
    //CLASSE CATEGORIA PRODUTO
    internal class CategoriaProduto
    {
        public string Nome { get; set; }

        public List<Produto> _produtos = new List<Produto>();
    }
}
