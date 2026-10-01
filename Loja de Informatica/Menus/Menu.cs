using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Informatica
{

    //CLASSE MENU
    internal class Menu
    {
        internal static string opcaoErro = ">> VALOR INFORMADO INVÁLIDO, FAVOR!! <<\n";

        internal static string nomeLoja = "\nLOJA DE INFORMÁTICA!\n\n\n";

        //MÉTODO EXIBIR MENU PRINCIPAL
        public string MenuPrincipal()
        {
            Console.WriteLine(nomeLoja);

            Console.WriteLine("Seguir para:\n");
            Console.WriteLine("1-Funcionários;");
            Console.WriteLine("2-Fornecedores;");
            Console.WriteLine("3-Produtos;");
            Console.WriteLine("4-Clientes;");
            Console.WriteLine("5-Compra;");
            Console.WriteLine("6-Venda;\n");
            Console.WriteLine("0-Sair.");
            string entrada = Console.ReadLine();

            while (entrada != "1" && entrada != "2" && entrada != "3" && entrada != "4" && entrada != "5" && entrada != "6" && entrada != "0")
            {
                Console.Clear();
                Console.WriteLine(nomeLoja);
                Console.WriteLine(opcaoErro);
                Console.WriteLine("Informe valor numérico para:\n");
                Console.WriteLine("1-Funcionários;");
                Console.WriteLine("2-Fornecedores;");
                Console.WriteLine("3-Produtos;");
                Console.WriteLine("4-Clientes;");
                Console.WriteLine("5-Compra;");
                Console.WriteLine("6-Venda;\n");
                Console.WriteLine("0-Sair.");
                entrada = Console.ReadLine();
            }
            Console.Clear();

            return entrada;
        }

        //MENU VENDAS
        public string MenuVenda()
        {
            Console.WriteLine(nomeLoja);
            Console.WriteLine("VENDAS:\n");
            Console.WriteLine("1-Nova Venda;");
            Console.WriteLine("2-Consultar;");
            Console.WriteLine("3-Editar;");
            Console.WriteLine("4-Remover;\n");
            Console.WriteLine("0-Retornar.");
            string entrada = Console.ReadLine();

            while (entrada != "1" && entrada != "2" && entrada != "3" && entrada != "4" && entrada != "0")
            {
                Console.Clear();
                Console.WriteLine(nomeLoja);
                Console.WriteLine("VENDAS:\n");
                Console.WriteLine(opcaoErro);
                Console.WriteLine("Informe:\n");
                Console.WriteLine("1-Nova Venda;");
                Console.WriteLine("2-Consultar;");
                Console.WriteLine("3-Editar;");
                Console.WriteLine("4-Remover;\n");
                Console.WriteLine("0-Retornar.");
                entrada = Console.ReadLine();
            }
            Console.Clear();

            return entrada;
        }

        //MENU COMPRAS
        public string MenuCompra()
        {
            Console.WriteLine(nomeLoja);
            Console.WriteLine("COMPRAS:\n");
            Console.WriteLine("1-Nova Compra;");
            Console.WriteLine("2-Consultar;");
            Console.WriteLine("3-Editar;");
            Console.WriteLine("4-Remover;\n");
            Console.WriteLine("0-Retornar.");
            string entrada = Console.ReadLine();

            while (entrada != "1" && entrada != "2" && entrada != "3" && entrada != "4" && entrada != "0")
            {

                Console.Clear();
                Console.WriteLine(nomeLoja);
                Console.WriteLine("COMPRAS:\n");
                Console.WriteLine(opcaoErro);
                Console.WriteLine("Informe:\n");
                Console.WriteLine("1-Nova Compra;");
                Console.WriteLine("2-Consultar;");
                Console.WriteLine("3-Editar;");
                Console.WriteLine("4-Remover;\n");
                Console.WriteLine("0-Retornar.");
                entrada = Console.ReadLine();
            }
            Console.Clear();

            return entrada;
        }

        //MENU CLIENTES
        public string MenuCliente()
        {
            Console.WriteLine(nomeLoja);
            Console.WriteLine("CLIENTES:\n");
            Console.WriteLine("1-Cadastrar Cliente;");
            Console.WriteLine("2-Consultar;");
            Console.WriteLine("3-Editar;");
            Console.WriteLine("4-Remover;\n");
            Console.WriteLine("0-Retornar.");
            string entrada = Console.ReadLine();

            while (entrada != "1" && entrada != "2" && entrada != "3" && entrada != "4" && entrada != "0")
            {

                Console.Clear();
                Console.WriteLine(nomeLoja);
                Console.WriteLine("CLIENTES:\n");
                Console.WriteLine(opcaoErro);
                Console.WriteLine("Informe:\n");
                Console.WriteLine("1-Cadastrar Cliente;");
                Console.WriteLine("2-Consultar;");
                Console.WriteLine("3-Editar;");
                Console.WriteLine("4-Remover;\n");
                Console.WriteLine("0-Retornar.");
                entrada = Console.ReadLine();
            }
            Console.Clear();

            return entrada;
        }

        //MENU FUNCIONÁRIOS
        public string MenuFuncionario()
        {
            Console.WriteLine(nomeLoja);
            Console.WriteLine("FUNCIONÁRIOS:\n");
            Console.WriteLine("1-Cadastrar Funcionário;");
            Console.WriteLine("2-Consultar;");
            Console.WriteLine("3-Editar;");
            Console.WriteLine("4-Remover;\n");
            Console.WriteLine("0-Retornar.");
            string entrada = Console.ReadLine();

            while (entrada != "1" && entrada != "2" && entrada != "3" && entrada != "4" && entrada != "0")
            {
                Console.Clear();
                Console.WriteLine(nomeLoja);
                Console.WriteLine("FUNCIONÁRIOS:\n");
                Console.WriteLine(opcaoErro);
                Console.WriteLine("Informe:\n");
                Console.WriteLine("1-Cadastrar Funcionário;");
                Console.WriteLine("2-Consultar;");
                Console.WriteLine("3-Editar;");
                Console.WriteLine("4-Remover;\n");
                Console.WriteLine("0-Retornar.");
                entrada = Console.ReadLine();
            }
            Console.Clear();

            return entrada;
        }

        //MENU FORNECEDORES
        public string MenuFornecedor()
        {
            Console.WriteLine(nomeLoja);
            Console.WriteLine("FORNECEDORES:\n");
            Console.WriteLine("1-Cadastrar Fornecedor;");
            Console.WriteLine("2-Consultar;");
            Console.WriteLine("3-Editar;");
            Console.WriteLine("4-Remover;");
            Console.WriteLine("5-Produtos Fornecedor;\n");
            Console.WriteLine("0-Retornar.");
            string entrada = Console.ReadLine();

            while (entrada != "1" && entrada != "2" && entrada != "3" && entrada != "4" && entrada != "5" && entrada != "0")
            {
                Console.Clear();
                Console.WriteLine(nomeLoja);
                Console.WriteLine("FORNECEDORES:\n");
                Console.WriteLine(opcaoErro);
                Console.WriteLine("Informe:\n");
                Console.WriteLine("1-Cadastrar Fornecedor;");
                Console.WriteLine("2-Consultar;");
                Console.WriteLine("3-Editar;");
                Console.WriteLine("4-Remover;");
                Console.WriteLine("5-Produtos Fornecedor;\n");
                Console.WriteLine("0-Retornar.");
                entrada = Console.ReadLine();
            }
            Console.Clear();

            return entrada;
        }

        //MENU PRODUTOS
        public string MenuProduto()
        {
            Console.WriteLine(nomeLoja);
            Console.WriteLine("PRODUTOS:\n");
            Console.WriteLine("1-Categoria Produto;\n");
            Console.WriteLine("2-Cadastrar Produto!");
            Console.WriteLine("3-Consultar!");
            Console.WriteLine("4-Editar;");
            Console.WriteLine("5-Remover;");
            Console.WriteLine("0-Retornar.");
            string entrada = Console.ReadLine();

            while (entrada != "1" && entrada != "2" && entrada != "3" && entrada != "4" && entrada != "5" && entrada != "0")
            {
                Console.Clear();
                Console.WriteLine(nomeLoja);
                Console.WriteLine("PRODUTOS:\n");
                Console.WriteLine(opcaoErro);
                Console.WriteLine("Informe:\n");
                Console.WriteLine("1-Categoria Produto;\n");
                Console.WriteLine("2-Cadastrar Produto!");
                Console.WriteLine("3-Consultar!");
                Console.WriteLine("4-Editar;");
                Console.WriteLine("5-Remover;");
                Console.WriteLine("0-Retornar.");
                entrada = Console.ReadLine();
            }
            Console.Clear();

            return entrada;
        }

    }
}