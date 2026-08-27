using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

namespace Loja_de_Informatica
{

    //CLASSE MENU
    internal class Menu
    {
        internal static string opcaoErro = ">> VALOR INFORMADO INVÁLIDO, FAVOR!! <<\n";

        internal static string nomeLoja = "LOJA DE INFORMÁTICA!\n\n\n";

        internal List<string> opcoes = new List<string>();

        internal static string opcao { get; set; }
        internal static string opcao2 { get; set; }

        //MÉTODO MENU
        public string OpcaoMenu()
        {
            opcao = "0";

            Console.WriteLine(nomeLoja);

            //MENUS
            //MENU PRINCIPAL
            if (opcao == "0")
            {
                Console.WriteLine("Informe valor numérico para:\n");
                Console.WriteLine("1-Vendas!");
                Console.WriteLine("2-Compras!");
                Console.WriteLine("3-CLientes!");
                Console.WriteLine("4-Funcionários!");
                Console.WriteLine("5-Fornecedores!");
                Console.WriteLine("6-Produtos!");
                opcao = Console.ReadLine();

                while (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5" && opcao != "6")
                {
                    Console.Clear();
                    Console.WriteLine(nomeLoja);
                    Console.WriteLine(opcaoErro);
                    Console.WriteLine("Informe valor numérico para:\n");
                    Console.WriteLine("1-Vendas!");
                    Console.WriteLine("2-Compras!");
                    Console.WriteLine("3-CLientes!");
                    Console.WriteLine("4-Funcionários!");
                    Console.WriteLine("5-Fornecedores!");
                    Console.WriteLine("6-Produtos!");
                    opcao = Console.ReadLine();
                }
            }
            //MENU VENDAS
            else if (opcao == "1")
            {
                opcao2 = "venda";
                Console.WriteLine(nomeLoja);
                Console.WriteLine("VENDAS:\n");
                Console.WriteLine("Informe:\n ");
                Console.WriteLine("1-Nova Venda!");
                Console.WriteLine("2-Buscar Venda!");
                opcao = Console.ReadLine();

                while (opcao != "1" && opcao != "2")
                {

                    Console.Clear();
                    Console.WriteLine(nomeLoja);
                    Console.WriteLine("VENDAS:\n");
                    Console.WriteLine(opcaoErro);
                    Console.WriteLine("Informe:\n");
                    Console.WriteLine("1-Nova Venda!");
                    Console.WriteLine("2-Buscar Venda!");
                    opcao = Console.ReadLine();
                }
                Console.Clear();
            }
            //MENU COMPRAS
            else if (opcao == "2")
            {
                opcao2 = "compra";
                Console.WriteLine(nomeLoja);
                Console.WriteLine("COMPRAS:\n");
                Console.WriteLine("Informe:\n ");
                Console.WriteLine("1-Nova Compra!");
                Console.WriteLine("2-Buscar Compra!");
                opcao = Console.ReadLine();

                while (opcao != "1" && opcao != "2")
                {

                    Console.Clear();
                    Console.WriteLine(nomeLoja);
                    Console.WriteLine("COMPRAS:\n");
                    Console.WriteLine(opcaoErro);
                    Console.WriteLine("Informe:\n");
                    Console.WriteLine("1-Nova Compra!");
                    Console.WriteLine("2-Buscar Compra!");
                    opcao = Console.ReadLine();
                }
                Console.Clear();
            }
            //MENU CLIENTES
            else if (opcao == "3")
            {
                opcao2 = "cliente";
                Console.WriteLine(nomeLoja);
                Console.WriteLine("CLIENTES:\n");
                Console.WriteLine("Informe:\n ");
                Console.WriteLine("1-Novo Cliente!");
                Console.WriteLine("2-Buscar Cliente!");
                opcao = Console.ReadLine();

                while (opcao != "1" && opcao != "2")
                {

                    Console.Clear();
                    Console.WriteLine(nomeLoja);
                    Console.WriteLine("CLIENTES:\n");
                    Console.WriteLine(opcaoErro);
                    Console.WriteLine("Informe:\n");
                    Console.WriteLine("1-Novo Cliente!");
                    Console.WriteLine("2-Buscar Cliente!");
                    opcao = Console.ReadLine();
                }
                Console.Clear();
            }
            //MENU FUNCIONÁRIOS
            else if (opcao == "4")
            {
                opcao2 = "funcionario";
                Console.WriteLine(nomeLoja);
                Console.WriteLine("FUNCIONÁRIOS:\n");
                Console.WriteLine("Informe:\n ");
                Console.WriteLine("1-Novo Funcionário!");
                Console.WriteLine("2-Buscar Funcionário!");
                opcao = Console.ReadLine();

                while (opcao != "1" && opcao != "2")
                {

                    Console.Clear();
                    Console.WriteLine(nomeLoja);
                    Console.WriteLine("FUNCIONÁRIOS:\n");
                    Console.WriteLine(opcaoErro);
                    Console.WriteLine("Informe:\n");
                    Console.WriteLine("1-Novo Funcionário!");
                    Console.WriteLine("2-Buscar Funcionário!");
                    opcao = Console.ReadLine();
                }
                Console.Clear();
            }
            //MENU FORNECEDORES
            else if (opcao == "5")
            {
                opcao2 = "fornecedor";
                Console.WriteLine(nomeLoja);
                Console.WriteLine("FORNECEDORES:\n");
                Console.WriteLine("Informe:\n ");
                Console.WriteLine("1-Novo Fornecedor!");
                Console.WriteLine("2-Buscar Fornecedor!");
                opcao = Console.ReadLine();

                while (opcao != "1" && opcao != "2")
                {

                    Console.Clear();
                    Console.WriteLine(nomeLoja);
                    Console.WriteLine("FORNECEDORES:\n");
                    Console.WriteLine(opcaoErro);
                    Console.WriteLine("Informe:\n");
                    Console.WriteLine("1-Novo Fornecedor!");
                    Console.WriteLine("2-Buscar Fornecedor!");
                    opcao = Console.ReadLine();
                }
                Console.Clear();
            }
            //MENU PRODUTOS
            else if (opcao == "6")
            {
                opcao2 = "produto";
                Console.WriteLine(nomeLoja);
                Console.WriteLine("PRODUTOS:\n");
                Console.WriteLine("Informe:\n ");
                Console.WriteLine("1-Novo Produto!");
                Console.WriteLine("2-Buscar Produto!");
                opcao = Console.ReadLine();

                while (opcao != "1" && opcao != "2")
                {

                    Console.Clear();
                    Console.WriteLine(nomeLoja);
                    Console.WriteLine("PRODUTOS:\n");
                    Console.WriteLine(opcaoErro);
                    Console.WriteLine("Informe:\n");
                    Console.WriteLine("1-Novo Produto!");
                    Console.WriteLine("2-Buscar Produto!");
                    opcao = Console.ReadLine();
                }
                Console.Clear();
            }
            Console.Clear();

            return opcao;
        }

    }

    //CLASSE CADASTRO


    //CLASSE FUNCIONÁRIO
    class Funcionario
    {
        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string CPF { get; set; }

        public string Funcao { get; set; }

        public double Salario { get; set; }

        public long QuantidadeFunc { get; set; }


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

        //MÉTODO CADASTRO
        private void Cadastro()
        {
            public List<Cliente> nomeCliente { get; set; }

            public List<Cliente> foneCliente { get; set; }

            public List<Cliente> cpfCliente { get; set; }

            //verificar nCompras para confirmar se cliente ativo ou não e fornecer desconto se cliente com X compras
            private List<Cliente> nComprasCliente { get; set; }

            public List<Produto> idProduto { get; set; }

            public List<Produto> nomeProduto { get; set; }

            public List<Produto> ValorVenda { get; set; }

            public long qtdVenda { get; set; }

            public double valorTotal { get; set; }

            if (Menu.opcao2 == "1")
            {
                Clientes List<Cliente>  = new List<Cliente>();

                Cliente cliente = new Cliente();

                Console.WriteLine(Menu.nomeLoja);
                Console.WriteLine("CADASTRO CLIENTE:\n");
                Console.WriteLine("Informe\n\n");
                Console.WriteLine("Nome do Cliente: ");
                cliente.nome = Console.ReadLine();
                Console.WriteLine("Telefone: ");
                cliente.telefone = Console.ReadLine();
                Console.WriteLine("CPF: ");
                cliente.CPF = Console.ReadLine();

                clientes.Add(cliente);



                Console.WriteLine(cliente.nome);
                Console.WriteLine(cliente.telefone);
                Console.WriteLine(cliente.CPF);
            }
            else if ()
            {

            }
        }



    }

    class Fornecedor
    {
        public string nome { get; set; }

        public string telefone { get; set; }

        public string CNPJ { get; set; }

        public long quantidadeForn { get; set; }

    }

    //CLASSE CLIENTE
    class Cliente
    {
        public string nome { get; set; }

        public string telefone { get; set; }

        public string CPF { get; set; }

        //incrementar +1 sempre que cliente realizar uma compra
        public long nCompras { get; set; }

        public long quantidadeCli { get; set; }


    }

    //CLASSE PRODUTO
    class Produto
    {
        public long id { get; set; }

        public string categoria { get; set; }

        public string nome { get; set; }

        private Fornecedor nomeFornecedor { get; set; }

        public double valorCompra { get; set; }

        public double valorVenda { get; set; }

        static public long estoque { get; set; }

    }

    //CLASSE NOTA FISCAL
    class NotaFiscal
    {
        public long id { get; set; }

        public List<Produto> idProduto { get; set; }

        public List<Produto> nomeProdutos { get; set; }

        public List<Produto> valorVenda { get; set; }

        public double valorTotal { get; set; }

    }

    //CLASSE COMPRA
    class Compra
    {
        public List<Fornecedor> nomeFornecedor { get; set; }

        public List<Fornecedor> foneFornecedor { get; set; }

        public List<Fornecedor> cnpjFornecedor { get; set; }

        public List<Produto> idProduto { get; set; }

        public List<Produto> nomeProduto { get; set; }

        public List<Produto> valorCompra { get; set; }

        public long qtdCompra { get; set; }

        public double valorTotal { get; set; }

    }

    //CLASSE VENDA
    class Venda
    {
        public List<Cliente> nomeCliente { get; set; }

        public List<Cliente> foneCliente { get; set; }

        public List<Cliente> cpfCliente { get; set; }

        //verificar nCompras para confirmar se cliente ativo ou não e fornecer desconto se cliente com X compras
        private List<Cliente> nComprasCliente { get; set; }

        public List<Produto> idProduto { get; set; }

        public List<Produto> nomeProduto { get; set; }

        public List<Produto> ValorVenda { get; set; }

        public long qtdVenda { get; set; }

        public double valorTotal { get; set; }

    }

    //CLASSE DO PROGRAMA
    internal class Program
    {

        //estaciando as listas de todos os objetos que irei precisar no meu sistema
        static public List<Funcionario> funcionarios = new List<Funcionario>();

        static public List<Fornecedor> fornecedores = new List<Fornecedor>();

        static public List<Cliente> clientes = new List<Cliente>();

        static public List<Produto> produtos = new List<Produto>();

        static public List<NotaFiscal> notaFiscais = new List<NotaFiscal>();

        static public List<Compra> compras = new List<Compra>();

        static public List<Venda> vendas = new List<Venda>();

        //MÉTODO DO PROGRAMA
        static void Main(string[] args)
        {

            Menu menu = new Menu();
            menu.OpcaoMenu();


            

                //Cadastrar (nome, telefone, CPF, nCompras, quantidadeCli)
                if (opcao == "1")
                {
                    Cliente cliente = new Cliente();

                    Console.WriteLine(nomeLoja);
                    Console.WriteLine("CADASTRO CLIENTE:\n");
                    Console.WriteLine("Informe\n\n");
                    Console.WriteLine("Nome do Cliente: ");
                    cliente.nome = Console.ReadLine();
                    Console.WriteLine("Telefone: ");
                    cliente.telefone = Console.ReadLine();
                    Console.WriteLine("CPF: ");
                    cliente.CPF = Console.ReadLine();

                    clientes.Add(cliente);



                    Console.WriteLine(cliente.nome);
                    Console.WriteLine(cliente.telefone);
                    Console.WriteLine(cliente.CPF);

                }
                //Buscar
                else if (opcao == "2")
                {
                    Cliente cliente = new Cliente();
                    cliente.nome = "Ebano da Silva Edwirges";
                    cliente.telefone = "986734227";
                    cliente.CPF = "019397873";
                    clientes.Add(cliente);

                    Console.WriteLine("BUSCAR CLIENTE:\n");

                }
            }


            //Funcionários
            //Funcionários.Cadastrar

            /*
            while (true)
            {
                //variável "funcionário" armazena uma referência para objeto criado da Classe Funcionário
                //Add(funcionario), armazena a referência "funcionario a lista "funcionarios", e ao final do escopo em "}", a variável "funcionário" deixa de existir, mas a referência "funcionário" já foi guardada dentro da lista "funcionarios"
                //Ao iniciar novamente o "while" a variável "funcionário" poderá ser utilizada novamente e a referência para o primeiro objeto criado permanece guardado na lista "funcionários"
                
                Funcionario funcionario = new Funcionario();
                funcionario.Nome = "Joao";
                funcionarios.Add(funcionario);
            }
            */


            //Funcionários.Consultar



            //Fornecedores
            //Fornecedores.Cadastrar
            //Fornecedores.Consultar

            //Produtos
            //Produtos.Cadastrar
            //Produtos.Consultar

            //Clientes
            //Clientes.Cadastrar
            //Clientes.Consultar

            //Compras
            //Compras.Cadastrar
            //Compras.Consultar

            //Vendas
            //Vendas.Cadastrar
            //Vendas.Consultar

            //Nota Fiscal
            //Nota Fiscal.Cadastrar
            //Nota Fiscal.Consultar







            Console.ReadKey();
        }
    }
}
