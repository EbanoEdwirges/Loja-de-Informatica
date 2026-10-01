using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Informatica
{
    //CLASSE FUNCIONÁRIO
    internal class Funcionario
    {
        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string CPF { get; set; }

        public string Funcao { get; set; }

        public double Salario { get; set; }

        /*
        //forma auternativa de declarar métodos Get e Set
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }
        */
    }
}
