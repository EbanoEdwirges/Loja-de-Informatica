using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

namespace Loja_de_Informatica
{ 

    class MenuPrincipal
    {
        static string opcaoErro = ">> VALOR INFORMADO INVÁLIDO, FAVOR!! <<\n";
        static string nomeLoja = "LOJA DE INFORMÁTICA!\n\n\n";
        public static string opcao { get; set; }

         


        public string OpcaoMenu()
        {

            Console.WriteLine(nomeLoja);

            //Menu Principal
            //Escolha
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
            Console.Clear();

            return opcao;
        }

    }

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

        //Cadastrar Funcionário



    }

    class Fornecedor
    {
        public string nome { get; set; }

        public string telefone { get; set; }

        public string CNPJ { get; set; }

        public long quantidadeForn { get; set; }

    }


    class Cliente
    {
        public string nome { get; set; }

        public string telefone { get; set; }

        public string CPF { get; set; }

        //incrementar +1 sempre que cliente realizar uma compra
        public long nCompras { get; set; }

        public long quantidadeCli { get; set; }

        //Cadastrar Cliente



    }

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

    class NotaFiscal
    {
        public long id { get; set; }

        public List<Produto> idProduto { get; set; }

        public List<Produto> nomeProdutos { get; set; }

        public List<Produto> valorVenda { get; set; }

        public double valorTotal { get; set; }

    }

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

        public string MenuVendas()
        {
            //Sub-Menus
            //Vendas
            string opcao;

            if (opcao == "1")
            {
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

                return opcao;
             
            }
        }

    }


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


        static void Main(string[] args)
        {

            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.OpcaoMenu();


            //Sub-Menus
            //Vendas
            if (opcao == "1")
            {
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

                //Cadastrar
                if (opcao == "1")
                {

                }
                //Buscar
                else if (opcao =="2")
                {

                }
            }
            //Compras
            else if (opcao == "2")
            {
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
            //Clientes
            else if (opcao == "3")
            {
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
            else if (opcao =="4")
            {
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
            //Fornecedores
            else if (opcao == "5")
            {
                Console.WriteLine(nomeLoja);
                Console.WriteLine("FORNECEDORES:\n");
                Console.WriteLine("Informe:\n ");
                Console.WriteLine("1-Novo Funcionário!");
                Console.WriteLine("2-Buscar Funcionário!");
                opcao = Console.ReadLine();

                while (opcao != "1" && opcao != "2")
                {
                    Console.Clear();
                    Console.WriteLine(nomeLoja);
                    Console.WriteLine("FORNECEDORES:\n");
                    Console.WriteLine(opcaoErro);
                    Console.WriteLine("Informe:\n");
                    Console.WriteLine("1-Novo Funcionário!");
                    Console.WriteLine("2-Buscar Funcionário!");
                    opcao = Console.ReadLine();
                }
                Console.Clear();
            }
            //Produtos
            else if (opcao == "6")
            {
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
