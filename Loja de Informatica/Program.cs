using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
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
        public void ExibirMenuPrincipal()
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
        }

        //MENU VENDAS
        public void ExibirMenuVenda()
        {
            if (opcao == "1")
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
        }

        //MENU COMPRAS
        public void ExibirMenuCompra()
        {
            if (opcao == "2")
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
        }

        //MENU CLIENTES
        public void ExibirMenuCliente()
        {
            if (opcao == "3")
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
        }

        //MENU FUNCIONÁRIOS
        public void ExibirMenuFuncionario()
        {
            if (opcao == "4")
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
        }

        //MENU FORNECEDORES
        public void ExibirMenuFornecedor()
        {
            if (opcao == "5")
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
        }

        //MENU PRODUTOS
        public void ExibirMenuProduto()
        {
            if (opcao == "6")
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
        }

    }


    //CLASSE SISTEMA DA LOJA
    class SistemaLoja
    {
        //estaciando as listas de todos os objetos que irei precisar no meu sistema
        private List<Funcionario> _funcionarios = new List<Funcionario>();

        private List<Fornecedor> _fornecedores = new List<Fornecedor>();

        private List<Cliente> _clientes = new List<Cliente>();

        private List<Produto> _produtos = new List<Produto>();

        private List<NotaFiscal> _notaFiscais = new List<NotaFiscal>();

        private List<Compra> _compras = new List<Compra>();

        private List<Venda> _vendas = new List<Venda>();



        //MÉTODOS SISTEMA LOJA PARA FUNCIONÁRIO
        //MÉTODO CADASTRAR FUNCIONÁRIOO
        private void CadastrarFuncionario()
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Telefone: ");
            funcionario.Telefone = Console.ReadLine();
            Console.Write("CPF: ");
            funcionario.CPF = Console.ReadLine();
            Console.Write("Função: ");
            funcionario.Funcao = Console.ReadLine();

            Console.Write("Salário: ");
            double salario;
            while (!double.TryParse(Console.ReadLine(), out salario))
            {
                Console.Write("Salário inválido! Informe valor correto: ");
            }
            funcionario.Salario = salario;

            _funcionarios.Add(funcionario);
        }

        //MÉTODO LISTAR FUNCIONÁRIOS
        private void ListarFuncionarios()
        {

            if (_funcionarios.Count == 0)
            {
                Console.WriteLine("Não existe funcionário cadastrado");

                return;
            }
            //foreach está dizendo, Para cada funcionário existente dentro de _funcionarios: pegue esse funcionário e mostre seus dados(Nome, Telefone, Funcão)
            foreach (Funcionario funcionario in _funcionarios)
            {
                Console.WriteLine($"Nome: {funcionario.Nome}");
                Console.WriteLine($"Telefone: {funcionario.Telefone}");
                Console.WriteLine($"Função: {funcionario.Funcao}");
            }
        }


        //MÉTODO BUSCAR FUNCIONÁRIO PELO CPF
        private Funcionario BuscarFuncionarioPorCPF(string cpf)
        {
            foreach (Funcionario funcionario in _funcionarios)
            {
                if (funcionario.CPF == cpf)
                {
                    return funcionario;
                }
            }
            return null;
        }

        //MÉTODO CONSULTAR FUNCIONÁRIO
        private void ConsultarFuncionarioCPF()
        {
            Console.Write($"Informe CPF: ");
            string cpf = Console.ReadLine();

            Funcionario funcionario = BuscarFuncionarioPorCPF(cpf);

            if(funcionario == null)
            {
                Console.WriteLine("Funcionario não encontrado!");

                return;
            }
            Console.WriteLine($"Nome: {funcionario.Nome}");
            Console.WriteLine($"Telefone: {funcionario.Telefone}");
            Console.WriteLine($"Função: {funcionario.Funcao}");
        }


        //REMOVER FUNCIONARIO
        private void RemoverFuncionario()
        {
            Console.Write("Informe CPF: ");
            string cpf = Console.ReadLine();

            Funcionario funcionario = BuscarFuncionarioPorCPF(cpf);
            if (funcionario == null)
            {
                Console.WriteLine("Funcionário não encontrado!");

                return;
            }
            _funcionarios.Remove(funcionario);
            Console.WriteLine("Funcionário removido!");
        }


        //EDITAR FUNCIONÁRIO
        //Nome, Telefone, CPF, Função e Salário
        private void EditarFuncionario()
        {
            Console.WriteLine("Informe CPF: ");
            string cpf = Console.ReadLine();

            Funcionario funcionario = BuscarFuncionarioPorCPF(cpf);

            if (funcionario == null)
            {
                Console.WriteLine("Funcionário não encontrado!");

                return;
            }

            //NOME
            Console.WriteLine("Informe novo valor para editar ou precione ENTER para próximo campo!\n");
            Console.Write($"Nome ({funcionario.Nome}): ");

            string nome = Console.ReadLine();
            //verifica se parâmetro é "nulo", "vazio" ou "apenas espaços"
            // e "!" inverte valor booleano (true para false ou false para true)
            if (!string.IsNullOrWhiteSpace(nome))
            {
                funcionario.Nome = nome;
            }

            //TELEFONE
            Console.Write($"Telefone ({funcionario.Telefone}): ");

            string telefone = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(telefone))
            {
                funcionario.Telefone = telefone;
            }

            //CPF
            Console.Write($"CPF ({funcionario.CPF}): ");

            string Cpf = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(Cpf))
            {
                funcionario.CPF = Cpf;
            }

            //FUNÇÃO
            Console.Write($"Função ({funcionario.Funcao}): ");

            string funcao = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(funcao))
            {
                funcionario.Funcao = funcao;
            }

            //SALÁRIO
            Console.Write($"Salário ({funcionario.Salario}): ");

            string entradaSalario = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(entradaSalario))
            {
                double salario;
                while (!double.TryParse(entradaSalario, out salario))
                {
                    Console.WriteLine("Salário inválido! Informe valor compatível: ");
                    entradaSalario = Console.ReadLine();
                }

                funcionario.Salario = salario;
            }

            Console.WriteLine("Funcionário editado com sucesso!");
        }



        //MÉTODOS SISTEMA LOJA PARA FORNECEDOR
        //MÉTODO CADASTRAR FORNECEDOR
        private void CadastrarFornecedor()
        {
            Fornecedor fornecedor = new Fornecedor();

            Console.Write("Nome: ");
            fornecedor.Nome = Console.ReadLine();

            Console.Write("Telefone: ");
            fornecedor.Telefone = Console.ReadLine();

            Console.Write("CNPJ: ");
            fornecedor.CNPJ = Console.ReadLine();

            _fornecedores.Add(fornecedor);

            Console.WriteLine("Fornecedor cadastrado com sucesso!");
        }

        //LISTAR FORNECEDORES
        private void ListarFornecedores()
        {
            if (_fornecedores.Count == 0)
            {
                Console.WriteLine("Não existe Fornecedor cadastrado!");

                return;
            }
            foreach (Fornecedor fornecedor in _fornecedores)
            {
                Console.Write($"Nome: ({fornecedor.Nome})");
                Console.Write($"Telefone: ({fornecedor.Telefone})");
                Console.Write($"CNPJ: ({fornecedor.CNPJ})");
            }
        }

        //BUSCAR FORNECEDOR POR CNPJ
        private Fornecedor BuscarFornecedorPorCNPJ(string cnpj)
        {
            foreach(Fornecedor fornecedor in _fornecedores)
            {
                if (fornecedor.CNPJ == cnpj)
                {
                    return fornecedor;
                }
            }
            return null;
        }

        //CONSULTAR FORNECEDOR
        private void ConsultarFornecedor()
        {
            Console.Write("Informe CNPJ: ");
            string cnpj = Console.ReadLine();

            Fornecedor fornecedor = BuscarFornecedorPorCNPJ(cnpj);

            if (fornecedor == null)
            {
                Console.WriteLine("Fornecedor não encontrado!");

                return;
            }
            Console.Write($"Nome: {fornecedor.Nome}");
            Console.Write($"Telefone: {fornecedor.Telefone}");
        }



    }//FIM DA CLASSE SISTEMA DA LOJA


    //CLASSE FUNCIONÁRIO
    class Funcionario
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

    class Fornecedor
    {
        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string CNPJ { get; set; }
    }

    //CLASSE CLIENTE
    class Cliente
    {
        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string CPF { get; set; }

        //incrementar +1 sempre que cliente realizar uma compra
        public long NCompras { get; set; }
    }

    //CLASSE PRODUTO
    class Produto
    {
        public long Id { get; set; }

        public string Categoria { get; set; }

        public string Nome { get; set; }

        private Fornecedor NomeFornecedor { get; set; }

        public double ValorCompra { get; set; }

        public double ValorVenda { get; set; }

        static public long Estoque { get; set; }

    }

    //CLASSE NOTA FISCAL
    class NotaFiscal
    {
        public long Id { get; set; }

        public List<Produto> IdProduto { get; set; }

        public List<Produto> NomeProdutos { get; set; }

        public List<Produto> ValorVenda { get; set; }

        public double ValorTotal { get; set; }

    }

    //CLASSE COMPRA
    class Compra
    {
        public List<Fornecedor> NomeFornecedor { get; set; }

        public List<Fornecedor> FoneFornecedor { get; set; }

        public List<Fornecedor> CnpjFornecedor { get; set; }

        public List<Produto> IdProduto { get; set; }

        public List<Produto> NomeProduto { get; set; }

        public List<Produto> ValorCompra { get; set; }

        public long QtdCompra { get; set; }

        public double ValorTotal { get; set; }

    }

    //CLASSE VENDA
    class Venda
    {
        public List<Cliente> NomeCliente { get; set; }

        public List<Cliente> FoneCliente { get; set; }

        public List<Cliente> CpfCliente { get; set; }

        //verificar nCompras para confirmar se cliente ativo ou não e fornecer desconto se cliente com X compras
        private List<Cliente> NComprasCliente { get; set; }

        public List<Produto> IdProduto { get; set; }

        public List<Produto> NomeProduto { get; set; }

        public List<Produto> ValorVenda { get; set; }

        public long QtdVenda { get; set; }

        public double ValorTotal { get; set; }

    }

    //CLASSE DO PROGRAMA
    internal class Program
    {

        //MÉTODO DO PROGRAMA
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.ExibirMenuPrincipal();


            Console.ReadKey();
        }

    
    }
}
