using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Xml;

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

        private List<string> _categoriasProdutos = new List<string>();



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
            Console.WriteLine("Funcionário removido com sucesso!");
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
                Console.Write($"CNPJ: ({fornecedor.CNPJ})\n");
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

        //REMOVER FORNECEDOR
        private void RemoverFornecedor()
        {
            Console.Write("Informe CNPJ: ");
            string cnpj = Console.ReadLine();

            Fornecedor fornecedor = BuscarFornecedorPorCNPJ(cnpj);

            if (fornecedor == null)
            {
                Console.WriteLine("Fornecedor não encontrado!");

                return;
            }
            _fornecedores.Remove(fornecedor);

            Console.WriteLine("Fornecedor foi removido com sucesso!");
        }

        //EDITAR FORNECEDOR
        private void EditarFOrnecedor()
        {
            //LOCALIZAR FORNECEDOR
            Console.Write("Informe CNPJ: ");
            string cnpj = Console.ReadLine();

            Fornecedor fornecedor = BuscarFornecedorPorCNPJ(cnpj);

            if(fornecedor == null)
            {
                Console.WriteLine("Fornecedor não encontrado!");

                return;
            }

            //NOME
            Console.WriteLine("Informe novo valor ou precione ENTER para próximo campo!\n");
            Console.WriteLine($"Nome: ({fornecedor.Nome}): ");
            string nome = Console.ReadLine();

            if(!string.IsNullOrWhiteSpace(nome))
            {
                fornecedor.Nome = nome;
            }

            //TELEFONE
            Console.WriteLine($"Telefone: ({fornecedor.Telefone}): ");
            string telefone = Console.ReadLine();

            if(!string.IsNullOrWhiteSpace(telefone))
            {
                fornecedor.Telefone = telefone;
            }

            //CNPJ
            Console.WriteLine("CNPJ: ");
            string Cnpj = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(Cnpj))
            {
                fornecedor.CNPJ = Cnpj;
            }
            Console.WriteLine("Fornecedor editado com sucesso!");

        }


        //MÉTODOS SISTEMA LOJA PARA CLIENTE
        //CADASTRAR CLIENTE
        private void CadastrarCLiente()
        {
            Cliente cliente = new Cliente();

            Console.WriteLine("Nome: ");
            cliente.Nome = Console.ReadLine();

            Console.WriteLine("Telefone: ");
            cliente.Telefone = Console.ReadLine();

            Console.WriteLine("CPF: ");
            cliente.CPF = Console.ReadLine();

            _clientes.Add(cliente);

            Console.WriteLine("Cliente cadastrado com sucesso!");
        }

        //LISTAR CLIENTES
        private void ListarCLientes()
        {
            if(_clientes.Count == 0)
            {
                Console.WriteLine("Não existe cliente cadastrado!");

                return;
            }

            foreach(Cliente cliente in _clientes)
            {
                Console.WriteLine($"Nome: {cliente.Nome}");
                Console.WriteLine($"Telefone: {cliente.Telefone}");
                Console.WriteLine($"CPF: {cliente.CPF}\n");
            }
        }

        //BUSCAR CLIENTE
        private Cliente BuscarClientePorCPF (string cpf)
        {
            foreach(Cliente cliente in _clientes)
            {
                if(cliente.CPF == cpf)
                {
                    return cliente;
                }
            }
            return null;
        }

        //CONSULTAR CLIENTE
        private void ConsultarCliente()
        {
            Console.Write("InformeCPF: ");
            string cpf = Console.ReadLine();

            Cliente cliente = BuscarClientePorCPF(cpf);

            if(cliente == null)
            {
                Console.WriteLine("Cliente não encontrado!");

                return;
            }
            Console.WriteLine($"Nome: {cliente.Nome}");
            Console.WriteLine($"Telefone: {cliente.Telefone}");
        }

        //REMOVER CLIENTE
        private void RemoverCLiente()
        {
            Console.WriteLine("Informe CPF: ");
            string cpf = Console.ReadLine();

            Cliente cliente = BuscarClientePorCPF(cpf);

            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado!");

                return;
            }
            _clientes.Remove(cliente);

            Console.WriteLine("Cliente removido com sucesso!");
        }

        //EDITAR CLIENTE
        private void EditarCliente()
        {
            //LOCALIZAR CLIENTE
            Console.WriteLine("Informe CPF: ");
            string cpf = Console.ReadLine();

            Cliente cliente = BuscarClientePorCPF(cpf);

            if(cliente == null)
            {
                Console.WriteLine("Cliente não encontrado!");

                return;
            }
            Console.WriteLine("Informe novo falor ou ENTER para próximo campo!\n");

            //NOME
            Console.Write($"Nome ({cliente.Nome}): ");
            string nome = Console.ReadLine();
            if(!string.IsNullOrWhiteSpace(nome))
            {
                cliente.Nome = nome;
            }

            //TELEFONE
            Console.Write($"Telefone ({cliente.Telefone}): ");
            string telefone = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(telefone))
            {
                cliente.Telefone = telefone;
            }

            //CPF
            Console.Write($"CPF: ({cliente.CPF}): ");
            string Cpf = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(Cpf))
            {
                cliente.CPF = Cpf;
            }
            Console.WriteLine("Cliente editado com sucesso!");
        }

        //MÉTODO SISTEMA LOJA PARA CATEGORIA PRODUTO
        //CADASTRAR CATEGORIA PRODUTO
        private void CadastrarCategoriaProduto()
        {
            Console.WriteLine("Informe Nome: ");
            string categoriaProduto = Console.ReadLine();

            _categoriaProduto.Add(categoriaProduto);

            Console.WriteLine("Categoria produto cadastrado com sucesso!");
        }

        //LISTAR CATEGORIAS PRODUTOS
        private void ListarCategoriasProdutos()
        {
            if(_categoriasProdutos.Count == 0)
            {
                Console.WriteLine("Não existe Categoria Produto Cadastrado!");

                return;
            }
            foreach (string categoriaProduto in _categoriasProdutos)
            {
                Console.WriteLine($"Categoria: {categoriaProduto}");
            }

        }

        //BUSCAR CATEGORIA PRODUTO
        private string BuscarCategoriaProduto(string nomeCategoriaProduto)
        {
            foreach (string categoriaProduto in _categoriasProdutos)
            {
                if (categoriaProduto == nomeCategoriaProduto)
                {
                    return categoriaProduto;
                }
            }
            return null;
        }

        //REMOVER CATEGORIA PRODUTO
        private void RemoverCategoriaProduto()
        {
            if(_categoriasProdutos.Count == 0)
            {
                Console.WriteLine("Não existe Categoria Produto Cadastrado!");

                return;
            }

            Console.Write("Informe Nome Categoria: ");
            string Categoria_Produto = Console.ReadLine();

            string categoriaProduto = BuscarCategoriaProduto(Categoria_Produto);

            if(categoriaProduto == null)
            {
                Console.WriteLine("Categoria de Produto NÃO encontrado!");

                return;
            }
            _categoriasProdutos.Remove(categoriaProduto);
            Console.WriteLine("Categoria Produto removido com sucesso!");  
        }


        //MÉTODO SISTEMA LOJA PARA PRODUTO
        //CADASTRO PRODUTO
        private void CadastrarProduto()
        {
            //VERIFICAR SE EXISTE CATEGORIA PRODUTO CADASTRADA
            if (_categoriasProdutos.Count == 0)
            {
                Console.WriteLine("Não existe categoria de Produtos cadastrado!");
                Console.WriteLine("Necessário cadastrar categoria produto antes, para depois cadastrar o produto.");

                return;
            }

            //VERIFICAR SE EXISTE FORNECEDOR CADASTRADO
            if(_fornecedores.Count == 0)
            {
                Console.WriteLine("Não existe fornecedor cadastrado!");
                Console.WriteLine("Necessário cadastrar fornecedor, para depois cadastrar protudo.");

                return;
            }

            //NOVO PRODUTO
            Produto produto = new Produto();
            
            //CATEGORIA DO PRODUTO
            Console.WriteLine("Informe uma das categorias a baixo: \n");
            ListarCategoriasProdutos();
            Console.Write("Categoria: ");
            string nomeCategoriaProduto = Console.ReadLine();

            string categoriaProduto = null;

            while(categoriaProduto == null)
            {
                Console.WriteLine("Categoria não encontrada.");
                Console.WriteLine("Informe uma das categorias a baixo: \n");
                ListarCategoriasProdutos();
                categoriaProduto = BuscarCategoriaProduto(nomeCategoriaProduto);
            }
            produto.Categoria = categoriaProduto;

            //FORNECEDOR DO PRODUTO
            Console.WriteLine("Informe CNPJ de um Fornecedor a baixo: ");
            ListarFornecedores();

            string cnpjFornecedor = Console.ReadLine();

            Fornecedor fornecedor = null;

            while(fornecedor == null)
            {
                Console.WriteLine("Fornecedor não localizado!");
                Console.WriteLine("Informe CNPJ de um dos Fornecedores a baixo: ");
                fornecedor = BuscarFornecedorPorCNPJ(cnpjFornecedor);
            }
            produto.Fornecedor = fornecedor;


            //NOME PRODUTO
            Console.WriteLine("Nome: ");
            produto.Nome = Console.ReadLine();

            //VALOR DE COMPRA PRODUTO
            Console.WriteLine("Valor de Compra: ");
            double.TryParse(Console.ReadLine(), out double valorDaCompra);
            produto.ValorCompra = valorDaCompra;

            //VALOR DE VENDA PRODUTO
            Console.WriteLine("Valor de Venda: ");
            double.TryParse(Console.ReadLine(), out double valorDaVenda);
            produto.ValorVenda = valorDaVenda;

            


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