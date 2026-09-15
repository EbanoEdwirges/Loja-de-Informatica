using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
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

        private List<NotaFiscal> _notaFiscais = new List<NotaFiscal>();

        private List<Compra> _compras = new List<Compra>();

        private List<Venda> _vendas = new List<Venda>();

        private List<CategoriaProduto> _categoriasProdutos = new List<CategoriaProduto>();


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

        //BUSCAR FUNCIONÁRIO PELO NOME
        private Funcionario BuscarFuncionarioPorNome(string nome)
        {
            foreach(Funcionario funcionario in _funcionarios)
            {
                if(funcionario.Nome == nome)
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

        //CONSULTAR FUNCIONARIO PELO NOME
        private void ConsultarFuncionarioNome()
        {
            Console.Write("Informe Nome: ");
            Funcionario funcionario = BuscarFuncionarioPorNome(Console.ReadLine());

            if(funcionario == null)
            {
                Console.WriteLine("Funcionario não encontrado");

                return;
            }
            Console.Write($"Nome: {funcionario.Nome}");
            Console.Write($"Telefone: {funcionario.Telefone}");
            Console.Write($"CPF: {funcionario.Funcao}");
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

        //BUSCAR FORNECEDOR POR NOME
        private Fornecedor BuscarFornecedorPorNome(string nome)
        {
            foreach(Fornecedor fornecedor in _fornecedores)
            {
                if(fornecedor.Nome == nome)
                {
                    return fornecedor;
                }
            }
            return null;
        }

        //CONSULTAR FORNECEDOR POR CNPJ
        private void ConsultarFornecedorCNPJ()
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

        //CONULTAR FORNECEDOR PELO NOME
        private void ConsultarFornecedorNome()
        {
            Console.Write("Informe Nome: ");

            Fornecedor fornecedor = BuscarFornecedorPorNome(Console.ReadLine());

            if(fornecedor == null)
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

        //BUSCAR CLIENTE POR CPF
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

        //BUSCAR CLIENTE POR NOME
        private Cliente BuscarClientePorNome(string nome)
        {
            foreach(Cliente cliente in _clientes)
            {
                if(cliente.Nome == nome)
                {
                    return cliente;
                }
            }
            return null;
        }

        //CONSULTAR CLIENTE POR CPF
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

        //CONSULTAR CLIENTE POR NOME
        private void ConsultarClienteNome()
        {
            Console.Write("Informe Nome: ");

            Cliente cliente = BuscarClientePorNome(Console.ReadLine());

            if(cliente == null)
            {
                Console.WriteLine("Cliente não localizado!");

                return;
            }
            Console.Write($"Nome: {cliente.Nome}");
            Console.Write($"Telefone: {cliente.Telefone}");
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
            CategoriaProduto categoriaProduto = new CategoriaProduto();

            Console.WriteLine("Informe Nome: ");
            string nome = Console.ReadLine();

            //VERIFICAR SE NOME CATEGORIA PRODUTO JÁ EXISTE
            bool nomeExiste = true;

            while(nomeExiste)
            {
                nomeExiste = false;

                foreach(CategoriaProduto categoria in _categoriasProdutos)
                {
                    if(categoriaProduto.Nome == nome)
                    {
                        nomeExiste = true;

                        break;
                    }
                }

                if (nomeExiste)
                {
                    Console.WriteLine("Categoria Produto já existe!");
                    Console.WriteLine("1-Tentar novo nome; ");
                    Console.WriteLine("0-Retornar.");

                    string opcao = Console.ReadLine();

                    while (opcao != "1" && opcao != "0")
                    {
                        Console.WriteLine("1-Tentar novo nome; ");
                        Console.WriteLine("0-Retornar.");
                        opcao = Console.ReadLine();
                    }

                    if (opcao == "0")
                    {
                        return;
                    }
                    Console.Write("Nome: ");
                    nome = Console.ReadLine();
                }
            }
            categoriaProduto.Nome = nome;

            _categoriasProdutos.Add(categoriaProduto);

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
            foreach (CategoriaProduto categoriaProduto in _categoriasProdutos)
            {
                Console.WriteLine($"Categoria: {categoriaProduto.Nome}");
            }

        }

        //BUSCAR CATEGORIA PRODUTO POR NOME
        private CategoriaProduto BuscarCategoriaProdutoPorNome(string nomeCategoriaProduto)
        {
            foreach (CategoriaProduto categoriaProduto in _categoriasProdutos)
            {
                if (categoriaProduto.Nome == nomeCategoriaProduto)
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

            CategoriaProduto categoriaProduto = BuscarCategoriaProdutoPorNome(Console.ReadLine());

            if(categoriaProduto == null)
            {
                Console.WriteLine("Categoria de Produto NÃO encontrado!");

                return;
            }
            _categoriasProdutos.Remove(categoriaProduto);
            Console.WriteLine("Categoria Produto removido com sucesso!");  
        }

        //MÉTODO SISTEMA LOJA PARA PRODUTO
        //CADASTRAR PRODUTO
        private void CadastrarProduto()
        {
            //VERIFICAR SE EXISTE ALGUMA CATEGORIA E FORNECEDOR JÁ CADASTRADO
            if(_categoriasProdutos.Count == 0)
            {
                Console.WriteLine("Não existe Categoria de Produto cadastrado!");
                Console.WriteLine("Necessário cadastrar Categoria antes de cadastrar Produto!!");

                return;
            }

            if(_fornecedores.Count == 0)
            {
                Console.WriteLine("Não existe Fornecedor cadasrtrado!");
                Console.WriteLine("Necessário cadastrar Fornecedor antes de cadastrar Produto!!");

                return;
            }

            //BUSCAR CATEGORIA
            Console.WriteLine("Informe NOME Categoria para Cadastro!");
            ListarCategoriasProdutos();
            Console.Write("\nCategoria: ");
            CategoriaProduto categoriaProduto = BuscarCategoriaProdutoPorNome(Console.ReadLine());

            if(categoriaProduto == null)
            {
                Console.WriteLine("Não existe a Categoria informada!");
                Console.WriteLine("Necessário cadastrar Categoria para depois cadastrar Produto!!");

                return;
            }

            //CRIAR NOVO PRODUTO
            Produto produto = new Produto();

            //FORNECEDOR DESTE PRODUTO
            Console.WriteLine("Informe NOME do fornecedor!\n");
            ListarFornecedores();
            Console.Write("\nFornecedor: ");
            Fornecedor fornecedor = BuscarFornecedorPorNome(Console.ReadLine());
            while(fornecedor == null)
            {
                Console.WriteLine("Fornecedor não encontrado!");
                Console.WriteLine("Informe NOME Fornecedor válido!");
                ListarFornecedores();
                Console.Write("\nFornecedor: ");
                fornecedor = BuscarFornecedorPorNome(Console.ReadLine());
            }
            produto.NomeFornecedor = fornecedor.Nome;

            //NOME PRODUTO
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            //VERIFICAR SE JÁ EXISTE PRODUTO COM ESTE NOME
            bool nomeExiste = true;
            while(nomeExiste)
            {
                nomeExiste = false;

                foreach(Produto produtoV in categoriaProduto._produtos)
                {
                    if(produto.Nome == nome)
                    {
                        nomeExiste = true;
                        break;
                    }
                }

                if (nomeExiste)
                {
                    Console.WriteLine("Produto informado já existe!");
                    Console.WriteLine("1-Tentar novo Nome;");
                    Console.WriteLine("0-Retornar.");

                    string opcao = Console.ReadLine();

                    while (opcao != "1" && opcao != "0")
                    {
                        Console.WriteLine("1-Tentar novo Nome;");
                        Console.WriteLine("0-Retornar.");
                        opcao = Console.ReadLine();
                    }

                    if (opcao == "0")
                    {
                        return;
                    }
                    Console.WriteLine("Nome: ");
                    nome = Console.ReadLine();
                }
            }
            produto.Nome = nome;

            //CÓDIGO DE BARRA PRODUTO
            Console.Write("Código de barra: ");
            string codigo = Console.ReadLine();

            //VERIFICAR SE CÓDIGO DE BARRA JÁ EXISTE
            bool codigoExiste = true;

            while(codigoExiste)
            {
                codigoExiste = false;

                foreach(Produto produtoV in categoriaProduto._produtos)
                {
                    if(produto.CodigoBarra == codigo)
                    {
                        codigoExiste = true;
                        break;
                    }
                }

                if(codigoExiste)
                {
                    Console.WriteLine("Código de Barra já existe!");
                    Console.WriteLine("1-Tentar novo Còdigo de Barra;");
                    Console.WriteLine("0-Retornar.");

                    string opcao = Console.ReadLine();

                    while(opcao != "1" && opcao != "0")
                    {
                        Console.WriteLine("1-Tentar novo Còdigo de Barra;");
                        Console.WriteLine("0-Retornar.");
                        opcao = Console.ReadLine();
                    }

                    if(opcao == "0")
                    {
                        return;
                    }
                    Console.Write("Código de Barra: ");
                    codigo = Console.ReadLine();
                }
            }
            produto.CodigoBarra = codigo;

            //FABRICANTE PRODUTO
            Console.Write("Fabricante: ");
            produto.Fabricante = Console.ReadLine();

            //VALOR DE COMPRA
            Console.Write("Valor de compra: ");
            double.TryParse(Console.ReadLine(), out double valorCompra);
            produto.ValorCompra = valorCompra;

            //VALOR DE VENDA
            Console.Write("Valor de Venda: ");
            double.TryParse(Console.ReadLine(), out double valorVenda);
            produto.ValorVenda = valorVenda;

            //ADICIONANDO NOVO OBJETO PRODUTO A LISTA DE PRODUTOS DA CATEGORIA QUE FOI ENCONTRADA COM MÉTODO BUSCAR CATEGORIA E ALOCADO EM "categoriaProduto"
            categoriaProduto._produtos.Add(produto);
        }

        //LISTAR PRODUTOS
        private void ListarProdutos()
        {
            Console.WriteLine("Informe a Categoria desejada: \n");
            ListarCategoriasProdutos();
            CategoriaProduto categoriaProduto = BuscarCategoriaProdutoPorNome(Console.ReadLine());

            while(categoriaProduto == null)
            {
                Console.WriteLine("Categoria não encontrado!");
                Console.WriteLine("1-Tentar de novo;");
                Console.WriteLine("0-Retornar.");

                string opcao = Console.ReadLine();

                while(opcao != "1" && opcao != "0")
                {
                    Console.WriteLine("1-Tentar novo nome;");
                    Console.WriteLine("0-Retornar.");
                    opcao = Console.ReadLine();
                }

                if(opcao == "0")
                {
                    return;
                }

                Console.WriteLine("Informe categoria válida da lista: \n");
                ListarCategoriasProdutos();
                categoriaProduto = BuscarCategoriaProdutoPorNome(Console.ReadLine());
            }

            foreach(Produto produto in categoriaProduto._produtos)
            {
                Console.WriteLine($"Código: {produto.CodigoBarra}" + $" - Nome: {produto.Nome}");
            }
        }

        //BUSCAR PRODUTO POR NOME POR NOME
        private Produto BuscarProdutoPorNome(string nome)
        {
            CategoriaProduto categoriaProduto = new CategoriaProduto();

            foreach(Produto produto in categoriaProduto._produtos)
            {
                if(produto.Nome == nome)
                {
                    return produto;
                }
            }
            return null;
        }

        //BUSCAR PRODUTO POR CÓDIGO DE BARRA
        private Produto BuscarProdutoPorCodigo(string codigo)
        {
            CategoriaProduto categoriaProduto = new CategoriaProduto();

            foreach(Produto produto in categoriaProduto._produtos)
            {
                if(produto.CodigoBarra == codigo)
                {
                    return produto;
                }
            }
            return null;
        }

        //CONSULTAR PRODUTO POR NOME
        private void ConsultarProdutoPorNome()
        {
            if (_categoriasProdutos.Count == 0)
            {
                Console.WriteLine("Não existe Categoria de Produto cadastrado!");
                Console.WriteLine("Necessário Cadastrar Categoria e depois Produto antes de Consultar!");
            }

            Console.WriteLine("Informe Categoria desejada!");
            ListarCategoriasProdutos();
            Console.Write("Categoria: ");

            CategoriaProduto categoriaProduto = BuscarCategoriaProdutoPorNome(Console.ReadLine());

            while (categoriaProduto == null)
            {
                Console.WriteLine("Categoria Não localizada!");
                Console.WriteLine("1-Tentar novo nome;");
                Console.WriteLine("0-Retornar.");

                string opcao = Console.ReadLine();

                if (opcao != "1" && opcao != "0")
                {
                    Console.WriteLine("1-Tentar novo nome;");
                    Console.WriteLine("0-Retornar.");
                    opcao = Console.ReadLine();
                }

                if (opcao == "0")
                {
                    return;
                }
                Console.Write("Categoria: ");
                categoriaProduto = BuscarCategoriaProdutoPorNome(Console.ReadLine());
            }

            if(categoriaProduto._produtos.Count == 0)
            {
                Console.WriteLine("Essa categoria ainda não possui Produto cadastrado!");

                return;
            }

            Console.WriteLine("Informe nome do Produto: ");
            ListarProdutos();
            Console.Write("Produto: ");

            Produto produto = BuscarProdutoPorNome(Console.ReadLine());

            while(produto == null)
            {
                Console.WriteLine("Produto não localizado!");
                Console.WriteLine("1-Tentar novo nome;");
                Console.WriteLine("0-Retornar.");

                string opcao = Console.ReadLine();

                while(opcao != "1" && opcao != "0")
                {
                    Console.WriteLine("1-Tentar novo nome;");
                    Console.WriteLine("0-Retornar.");
                    opcao = Console.ReadLine();
                }
                
                if(opcao == "0")
                {
                    return;
                }

                Console.Write("Produto: ");
                produto = BuscarProdutoPorNome(Console.ReadLine());
            }

            Console.WriteLine($"Código: {produto.CodigoBarra}" + $"Nome: {produto.Nome}");
            Console.WriteLine($"Valor: {produto.ValorVenda}");
        }


        //CONSULTAR PRODUTO POR CÓDIGO DE BARRA


        //REMOVER PRODUTO


        //EDITAR PRODUTO



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
        public string Nome { get; set; }

        public string CodigoBarra { get; set; }

        public string Fabricante { get; set; }

        public string NomeFornecedor { get; set; }

        public double ValorCompra { get; set; }

        public double ValorVenda { get; set; }

        public int Estoque { get; set; }
    }

    //CLASSE CATEGORIA PRODUTO
    class CategoriaProduto
    {
        public string Nome { get; set; }

        public List<Produto> _produtos = new List<Produto>();
    }

    //CLASSE NOTA FISCAL
    class NotaFiscal
    {
        public long Id { get; set; } = 100000;

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