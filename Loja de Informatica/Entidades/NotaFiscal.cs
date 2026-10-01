using Loja_de_Informatica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Informatica
{
    //CLASSE NOTA FISCAL
    internal class NotaFiscal
    {
        public static long ProximoId { get; set; } = 100000;

        public long IdNota { get; set; }

        public List<ItemNotaFiscal> _itensNotaFiscal = new List<ItemNotaFiscal>();
    }
}
