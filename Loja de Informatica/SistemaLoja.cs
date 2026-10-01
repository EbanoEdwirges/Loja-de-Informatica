using Loja_de_Informatica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Informatica
{

    //CLASSE SISTEMA DA LOJA
    internal class SistemaLoja
    {
        //estaciando as listas de todos os objetos que irei precisar no meu sistema
        internal List<Funcionario> _funcionarios = new List<Funcionario>();

        internal List<Fornecedor> _fornecedores = new List<Fornecedor>();

        internal List<Cliente> _clientes = new List<Cliente>();

        internal List<NotaFiscal> _notaFiscais = new List<NotaFiscal>();

        internal List<Compra> _compras = new List<Compra>();

        internal List<Venda> _vendas = new List<Venda>();

        internal List<CategoriaProduto> _categoriasProdutos = new List<CategoriaProduto>();

        //MÉTODOS SISTEMA LOJA PARA MENU
        //MÉTODO EBIBIR MENU PRINCIPAL



        //MÉTODOS SISTEMA LOJA PARA FUNCIONÁRIO
        //MÉTODO CADASTRAR FUNCIONÁRIOO
        internal void CadastrarFuncionario()
        {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("CADASTRAR FUNCIONÁRIO\n");

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
        internal void ListarFuncionarios()
        {

            if (_funcionarios.Count == 0)
            {
                Console.WriteLine("Não existe funcionário cadastrado");
                Console.WriteLine("---------------------------------------------------------------------\n");

                return;
            }

            Console.WriteLine("FUNCIONÁRIOS JÁ CADASTRADOS:\n");

            //foreach está dizendo, Para cada funcionário existente dentro de _funcionarios: pegue esse funcionário e mostre seus dados(Nome, Telefone, Funcão)
            foreach (Funcionario funcionario in _funcionarios)
            {
                Console.Write($"Nome: {funcionario.Nome}");
                Console.Write($" - Telefone: {funcionario.Telefone}");
                Console.Write($" - CPF: {funcionario.CPF}");
                Console.WriteLine($" - Função: {funcionario.Funcao}");
            }

            Console.WriteLine("---------------------------------------------------------------------\n");
        }

        //MÉTODO BUSCAR FUNCIONÁRIO PELO CPF
        internal Funcionario BuscarFuncionarioPorCPF(string cpf)
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
        internal Funcionario BuscarFuncionarioPorNome(string nome)
        {
            foreach (Funcionario funcionario in _funcionarios)
            {
                if (funcionario.Nome == nome)
                {
                    return funcionario;
                }
            }
            return null;
        }

        //MÉTODO CONSULTAR FUNCIONÁRIO
        internal void ConsultarFuncionarioCPF()
        {
            Console.Write($"Informe CPF: ");
            string cpf = Console.ReadLine();

            Funcionario funcionario = BuscarFuncionarioPorCPF(cpf);

            if (funcionario == null)
            {
                Console.WriteLine(">>> Funcionario não encontrado!");

                return;
            }
            Console.WriteLine($"Nome: {funcionario.Nome}");
            Console.WriteLine($"Telefone: {funcionario.Telefone}");
            Console.WriteLine($"Função: {funcionario.Funcao}");
        }

        //CONSULTAR FUNCIONARIO PELO NOME
        internal void ConsultarFuncionarioNome()
        {
            Console.WriteLine(Menu.nomeLoja);
            Console.WriteLine("CONSULTAR FUNCIONÁRIO\n");

            Console.Write("Informe Nome: ");
            Funcionario funcionario = BuscarFuncionarioPorNome(Console.ReadLine());

            while (funcionario == null)
            {
                Console.Clear();

                Console.WriteLine(Menu.nomeLoja);
                Console.WriteLine("CONSULTAR FUNCIONÁRIO\n");

                Console.WriteLine(">>> Funcionário não encontrado!!\n");
                Console.WriteLine("1-Tentar novamente;");
                Console.WriteLine("0-Retornar.");

                string opcao = Console.ReadLine();

                while (opcao != "1" && opcao != "0")
                {
                    Console.WriteLine(Menu.nomeLoja);
                    Console.WriteLine("CONSULTAR FUNCIONÁRIO\n");

                    Console.WriteLine("1-Tentar novamente;");
                    Console.WriteLine("0-Retornar.");
                    opcao = Console.ReadLine();
                }

                if (opcao == "0")
                {
                    return;
                }
                Console.Clear();

                Console.WriteLine(Menu.nomeLoja);
                Console.WriteLine("CONSULTAR FUNCIONÁRIO\n");

                Console.Write("Informe Nome: ");
                funcionario = BuscarFuncionarioPorNome(Console.ReadLine());
            }
            Console.Clear();

            Console.Write($"Nome: {funcionario.Nome}");
            Console.WriteLine($" - Telefone: {funcionario.Telefone}");
            Console.WriteLine($"CPF: {funcionario.CPF}");

            Console.WriteLine("\nPrecione qualquer tecla para retornar!");

            Console.ReadKey();
        }

        //REMOVER FUNCIONARIO
        internal void RemoverFuncionarioCPF()
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
        internal void EditarFuncionarioCPF()
        {
            Console.WriteLine(Menu.nomeLoja);
            Console.WriteLine("EDITAR FUNCIONÁRIO\n");

            Console.WriteLine("Informe CPF: ");
            string cpf = Console.ReadLine();

            Funcionario funcionario = BuscarFuncionarioPorCPF(cpf);

            while (funcionario == null)
            {
                Console.Clear();
                Console.WriteLine(Menu.nomeLoja);
                Console.WriteLine("EDITAR FUNCIONÁRIO\n");
                Console.WriteLine("Funcionário não encontrado!");
                Console.WriteLine("1-Tentar novamente;");
                Console.WriteLine("0-Retornar.");

                string opcao = Console.ReadLine();

                while (opcao != "1" && opcao != "0")
                {
                    Console.Clear();
                    Console.WriteLine(Menu.nomeLoja);
                    Console.WriteLine("EDITAR FUNCIONÁRIO\n");
                    Console.WriteLine("1-Tentar novamente;");
                    Console.WriteLine("0-Retornar.");
                    opcao = Console.ReadLine();
                }

                if (opcao == "0")
                {
                    return;
                }

                Console.Clear();
                Console.WriteLine(Menu.nomeLoja);
                Console.WriteLine("EDITAR FUNCIONÁRIO\n");
                Console.WriteLine("Informe CPF: ");
                cpf = Console.ReadLine();
                funcionario = BuscarFuncionarioPorCPF(cpf);
            }

            //NOME
            Console.Clear();
            Console.WriteLine(Menu.nomeLoja);
            Console.WriteLine("EDITAR FUNCIONÁRIO\n");
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
            Console.WriteLine("\nFuncionário editado com sucesso!\n");
            Console.WriteLine("Precione qualquer tecla para retornar!");
            Console.ReadKey();
            Console.Clear();
        }


        //MÉTODOS SISTEMA LOJA PARA FORNECEDOR
        //MÉTODO CADASTRAR FORNECEDOR
        internal void CadastrarFornecedor()
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
        internal void ListarFornecedores()
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
        internal Fornecedor BuscarFornecedorPorCNPJ(string cnpj)
        {
            foreach (Fornecedor fornecedor in _fornecedores)
            {
                if (fornecedor.CNPJ == cnpj)
                {
                    return fornecedor;
                }
            }
            return null;
        }

        //BUSCAR FORNECEDOR POR NOME
        internal Fornecedor BuscarFornecedorPorNome(string nome)
        {
            foreach (Fornecedor fornecedor in _fornecedores)
            {
                if (fornecedor.Nome == nome)
                {
                    return fornecedor;
                }
            }
            return null;
        }

        //CONSULTAR FORNECEDOR POR CNPJ
        internal void ConsultarFornecedorCNPJ()
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
        internal void ConsultarFornecedorNome()
        {
            Console.Write("Informe Nome: ");

            Fornecedor fornecedor = BuscarFornecedorPorNome(Console.ReadLine());

            if (fornecedor == null)
            {
                Console.WriteLine("Fornecedor não encontrado!");

                return;
            }
            Console.Write($"Nome: {fornecedor.Nome}");
            Console.Write($"Telefone: {fornecedor.Telefone}");
        }

        //REMOVER FORNECEDOR
        internal void RemoverFornecedorCNPJ()
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
        internal void EditarFornecedorCNPJ()
        {
            //LOCALIZAR FORNECEDOR
            Console.Write("Informe CNPJ: ");
            string cnpj = Console.ReadLine();

            Fornecedor fornecedor = BuscarFornecedorPorCNPJ(cnpj);

            if (fornecedor == null)
            {
                Console.WriteLine("Fornecedor não encontrado!");

                return;
            }

            //NOME
            Console.WriteLine("Informe novo valor ou precione ENTER para próximo campo!\n");
            Console.WriteLine($"Nome: ({fornecedor.Nome}): ");
            string nome = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(nome))
            {
                fornecedor.Nome = nome;
            }

            //TELEFONE
            Console.WriteLine($"Telefone: ({fornecedor.Telefone}): ");
            string telefone = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(telefone))
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
        internal void CadastrarCLiente()
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
        internal void ListarCLientes()
        {
            if (_clientes.Count == 0)
            {
                Console.WriteLine("Não existe cliente cadastrado!");

                return;
            }

            foreach (Cliente cliente in _clientes)
            {
                Console.WriteLine($"Nome: {cliente.Nome}");
                Console.WriteLine($"Telefone: {cliente.Telefone}");
                Console.WriteLine($"CPF: {cliente.CPF}\n");
            }
        }

        //BUSCAR CLIENTE POR CPF
        internal Cliente BuscarClientePorCPF(string cpf)
        {
            foreach (Cliente cliente in _clientes)
            {
                if (cliente.CPF == cpf)
                {
                    return cliente;
                }
            }
            return null;
        }

        //BUSCAR CLIENTE POR NOME
        internal Cliente BuscarClientePorNome(string nome)
        {
            foreach (Cliente cliente in _clientes)
            {
                if (cliente.Nome == nome)
                {
                    return cliente;
                }
            }
            return null;
        }

        //CONSULTAR CLIENTE POR CPF
        internal void ConsultarClienteCPF()
        {
            Console.Write("InformeCPF: ");
            string cpf = Console.ReadLine();

            Cliente cliente = BuscarClientePorCPF(cpf);

            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado!");

                return;
            }
            Console.WriteLine($"Nome: {cliente.Nome}");
            Console.WriteLine($"Telefone: {cliente.Telefone}");
        }

        //CONSULTAR CLIENTE POR NOME
        internal void ConsultarClienteNome()
        {
            Console.Write("Informe Nome: ");

            Cliente cliente = BuscarClientePorNome(Console.ReadLine());

            if (cliente == null)
            {
                Console.WriteLine("Cliente não localizado!");

                return;
            }
            Console.Write($"Nome: {cliente.Nome}");
            Console.Write($"Telefone: {cliente.Telefone}");
        }

        //REMOVER CLIENTE
        internal void RemoverCLienteCPF()
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
        internal void EditarClienteCPF()
        {
            //LOCALIZAR CLIENTE
            Console.WriteLine("Informe CPF: ");
            string cpf = Console.ReadLine();

            Cliente cliente = BuscarClientePorCPF(cpf);

            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado!");

                return;
            }
            Console.WriteLine("Informe novo falor ou ENTER para próximo campo!\n");

            //NOME
            Console.Write($"Nome ({cliente.Nome}): ");
            string nome = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(nome))
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
        internal void CadastrarCategoriaProduto()
        {
            CategoriaProduto categoriaProduto = new CategoriaProduto();

            Console.WriteLine("Informe Nome: ");
            string nome = Console.ReadLine();

            //VERIFICAR SE NOME CATEGORIA PRODUTO JÁ EXISTE
            bool nomeExiste = true;

            while (nomeExiste)
            {
                nomeExiste = false;

                foreach (CategoriaProduto categoria in _categoriasProdutos)
                {
                    if (categoriaProduto.Nome == nome)
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
        internal void ListarCategoriasProdutos()
        {
            if (_categoriasProdutos.Count == 0)
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
        internal CategoriaProduto BuscarCategoriaProdutoPorNome(string nomeCategoriaProduto)
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
        internal void RemoverCategoriaProduto()
        {
            if (_categoriasProdutos.Count == 0)
            {
                Console.WriteLine("Não existe Categoria Produto Cadastrado!");

                return;
            }

            Console.Write("Informe Nome Categoria: ");

            CategoriaProduto categoriaProduto = BuscarCategoriaProdutoPorNome(Console.ReadLine());

            if (categoriaProduto == null)
            {
                Console.WriteLine("Categoria de Produto NÃO encontrado!");

                return;
            }
            _categoriasProdutos.Remove(categoriaProduto);
            Console.WriteLine("Categoria Produto removido com sucesso!");
        }

        //MÉTODO SISTEMA LOJA PARA PRODUTO
        //CADASTRAR PRODUTO
        internal void CadastrarProduto()
        {
            //VERIFICAR SE EXISTE ALGUMA CATEGORIA E FORNECEDOR JÁ CADASTRADO
            if (_categoriasProdutos.Count == 0)
            {
                Console.WriteLine("Não existe Categoria de Produto cadastrado!");
                Console.WriteLine("Necessário cadastrar Categoria antes de cadastrar Produto!!");

                return;
            }

            if (_fornecedores.Count == 0)
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

            if (categoriaProduto == null)
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
            while (fornecedor == null)
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
            while (nomeExiste)
            {
                nomeExiste = false;

                foreach (Produto produtoV in categoriaProduto._produtos)
                {
                    if (produto.Nome == nome)
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

            while (codigoExiste)
            {
                codigoExiste = false;

                foreach (Produto produtoV in categoriaProduto._produtos)
                {
                    if (produto.CodigoBarra == codigo)
                    {
                        codigoExiste = true;
                        break;
                    }
                }

                if (codigoExiste)
                {
                    Console.WriteLine("Código de Barra já existe!");
                    Console.WriteLine("1-Tentar novo Còdigo de Barra;");
                    Console.WriteLine("0-Retornar.");

                    string opcao = Console.ReadLine();

                    while (opcao != "1" && opcao != "0")
                    {
                        Console.WriteLine("1-Tentar novo Còdigo de Barra;");
                        Console.WriteLine("0-Retornar.");
                        opcao = Console.ReadLine();
                    }

                    if (opcao == "0")
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

        /*
        //LISTAR PRODUTOS
        private void ListarProdutos()
        {
            Console.WriteLine("Informe Categoria do Produto: \n");
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
                Console.WriteLine($"Valor de Compra: {produto.ValorCompra}" + $" - Valor de Venda: {produto.ValorVenda}\n");
            }
        }
        */

        //LISTAR PRODUTOS ESTOQUE
        internal void ListarProdutos(CategoriaProduto categoriaProduto)
        {
            foreach (Produto produto in categoriaProduto._produtos)
            {
                Console.WriteLine($"Código: {produto.CodigoBarra}" + $" - Nome: {produto.Nome}");
                Console.WriteLine($"Valor de Compra: {produto.ValorCompra}" + $" - Valor de Venda: {produto.ValorVenda}\n");
            }
        }

        //BUSCAR PRODUTO POR NOME POR NOME
        internal Produto BuscarProdutoPorNome(CategoriaProduto categoriaProduto, string nomeProduto)
        {
            foreach (Produto produto in categoriaProduto._produtos)
            {
                if (produto.Nome == nomeProduto)
                {
                    return produto;
                }
            }
            return null;
        }

        //BUSCAR PRODUTO POR CÓDIGO DE BARRA
        internal Produto BuscarProdutoPorCodigo(CategoriaProduto categoriaProduto, string codigoProduto)
        {
            foreach (Produto produto in categoriaProduto._produtos)
            {
                if (produto.CodigoBarra == codigoProduto)
                {
                    return produto;
                }
            }
            return null;
        }

        //CONSULTAR PRODUTO POR NOME
        internal void ConsultarProdutoPorNome()
        {
            if (_categoriasProdutos.Count == 0)
            {
                Console.WriteLine("Não existe Categoria de Produto cadastrado!");
                Console.WriteLine("Necessário Cadastrar Categoria e depois Produto antes de Consultar!");

                return;
            }

            Console.WriteLine("Informe Categoria desejada!");
            ListarCategoriasProdutos();
            Console.Write("Categoria: ");

            CategoriaProduto categoriaProduto = BuscarCategoriaProdutoPorNome(Console.ReadLine());

            string opcao;

            while (categoriaProduto == null)
            {
                Console.WriteLine("Categoria Não localizada!");
                Console.WriteLine("1-Tentar novo nome;");
                Console.WriteLine("0-Retornar.");

                opcao = Console.ReadLine();

                while (opcao != "1" && opcao != "0")
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

            if (categoriaProduto._produtos.Count == 0)
            {
                Console.WriteLine("Essa categoria ainda não possui Produto cadastrado!");

                return;
            }

            Console.WriteLine("Informe nome do Produto: ");
            ListarProdutos(categoriaProduto);
            Console.Write("\nProduto: ");

            string nomeProduto = Console.ReadLine();
            Produto produto = BuscarProdutoPorNome(categoriaProduto, nomeProduto);

            while (produto == null)
            {
                Console.WriteLine("Produto não localizado!");
                Console.WriteLine("1-Tentar novo nome;");
                Console.WriteLine("0-Retornar.");

                opcao = Console.ReadLine();

                while (opcao != "1" && opcao != "0")
                {
                    Console.WriteLine("1-Tentar novo nome;");
                    Console.WriteLine("0-Retornar.");
                    opcao = Console.ReadLine();
                }

                if (opcao == "0")
                {
                    return;
                }

                Console.Write("Produto: ");
                nomeProduto = Console.ReadLine();
                produto = BuscarProdutoPorNome(categoriaProduto, nomeProduto);
            }

            Console.WriteLine($"Código: {produto.CodigoBarra}" + $"Nome: {produto.Nome}");
            Console.WriteLine($"Valor: {produto.ValorVenda}");
        }

        //CONSULTAR PRODUTO POR CÓDIGO DE BARRA
        internal void ConsultarProdutoPorCodigo()
        {
            Console.WriteLine("Informe Cartegoria do Produto!");
            ListarCategoriasProdutos();
            Console.WriteLine("\nCategoria: ");

            CategoriaProduto categoriaProduto = BuscarCategoriaProdutoPorNome(Console.ReadLine());

            string opcao;

            while (categoriaProduto == null)
            {
                Console.WriteLine("Categoria não encontrado!");
                Console.WriteLine("1-Tentar novo nome;");
                Console.WriteLine("0-Retornar.");

                opcao = Console.ReadLine();

                while (opcao != "1" && opcao != "0")
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

            Console.WriteLine("Informe Código do Produto: ");
            ListarProdutos(categoriaProduto);
            Console.Write("\nCódigo do Produto: ");

            string codigoProduto = Console.ReadLine();
            Produto produto = BuscarProdutoPorCodigo(categoriaProduto, codigoProduto);

            while (produto == null)
            {
                Console.WriteLine("Produto não localizado!");
                Console.WriteLine("1-Tentar novo nome;");
                Console.WriteLine("0-Retornar.");

                opcao = Console.ReadLine();

                while (opcao != "1" && opcao != "0")
                {
                    Console.WriteLine("1-Tentar novo nome;");
                    Console.WriteLine("0-Retornar.");
                    opcao = Console.ReadLine();
                }

                if (opcao == "0")
                {
                    return;
                }

                Console.Write("Código: ");
                codigoProduto = Console.ReadLine();
                produto = BuscarProdutoPorCodigo(categoriaProduto, codigoProduto);
            }

            Console.WriteLine($"Código: {produto.CodigoBarra}" + $"Nome: {produto.Nome}");
            Console.WriteLine($"Valor: {produto.ValorVenda}");
        }

        //EXIBIR PRODUTO
        internal void ExibirProduto(Produto produto)
        {
            Console.WriteLine($"Código: {produto.CodigoBarra}" + $"Nome: {produto.Nome}");
            Console.WriteLine($"Valor: {produto.ValorVenda}");
        }

        //REMOVER PRODUTO
        internal void RemoverProduto()
        {
            if (_categoriasProdutos.Count == 0)
            {
                Console.WriteLine("Não existe Categoria de Produto cadastrado!");
                Console.WriteLine("Necessário Cadastrar Categoria e depois Produto antes de Consultar!");

                return;
            }

            Console.WriteLine("REMOVER PRODUTO!\n");

            Console.WriteLine("Informe Categoria do Produto");
            ListarCategoriasProdutos();
            Console.Write("\nCategoria: ");
            CategoriaProduto categoriaProduto = BuscarCategoriaProdutoPorNome(Console.ReadLine());

            string opcao;

            while (categoriaProduto == null)
            {
                Console.WriteLine("Categoria não encontrada!");
                Console.WriteLine("1-Tentar novo Nome;");
                Console.WriteLine("0-Retornar.");

                opcao = Console.ReadLine();

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

                Console.Write("Categoria: ");
                categoriaProduto = BuscarCategoriaProdutoPorNome(Console.ReadLine());
            }

            ListarProdutos(categoriaProduto);

            Console.WriteLine("\nInforme Código do Produto a Remover: ");
            string codigo = Console.ReadLine();

            Produto produto = BuscarProdutoPorCodigo(categoriaProduto, codigo);

            while (produto == null)
            {
                Console.WriteLine("Produto não localizado!");
                Console.WriteLine("1-Tentar novo dódigo;");
                Console.WriteLine("0-Retornar.");

                opcao = Console.ReadLine();

                while (opcao != "1" && opcao != "0")
                {
                    Console.WriteLine("1-Tentar novo dódigo;");
                    Console.WriteLine("0-Retornar.");
                    opcao = Console.ReadLine();
                }

                if (opcao == "0")
                {
                    return;
                }

                Console.WriteLine("Codigo do Produto: ");
                codigo = Console.ReadLine();
                produto = BuscarProdutoPorCodigo(categoriaProduto, codigo);
            }

            Console.WriteLine("Confirmar Remoção do Produdo!\n");

            ExibirProduto(produto);

            Console.WriteLine("\n1-Remover Produto;!\n");
            Console.WriteLine("0-Retornar.");

            opcao = Console.ReadLine();

            while (opcao != "1" && opcao != "0")
            {
                Console.WriteLine("\n1-Remover Produto;!\n");
                Console.WriteLine("0-Retornar.");
                opcao = Console.ReadLine();
            }

            if (opcao == "0")
            {
                return;
            }

            categoriaProduto._produtos.Remove(produto);

            Console.WriteLine("Produto removido com sucesso!");
        }

        //EDITAR PRODUTO
        internal void EditarProduto()
        {
            if (_categoriasProdutos.Count == 0)
            {
                Console.WriteLine("Não existe Categoria ou Produto cadastrado!");
                Console.WriteLine("Necessário cadastrar Categoria e Produto antes de Editar!,");

                return;
            }

            Console.WriteLine("Informe Categoria do Produto: ");
            ListarCategoriasProdutos();
            Console.Write("\nCategoria: ");
            CategoriaProduto categoriaProduto = BuscarCategoriaProdutoPorNome(Console.ReadLine());

            string opcao = Console.ReadLine();

            while (categoriaProduto == null)
            {
                Console.WriteLine("Categoria não encontrada!");
                Console.WriteLine("1-Tentar novo nome;");
                Console.WriteLine("0-Retornar.");

                opcao = Console.ReadLine();

                while (opcao != "1" && opcao != "0")
                {
                    Console.WriteLine("1-Tentar novo nome;");
                    Console.WriteLine("0-Retornar.");
                    opcao = Console.ReadLine();
                }

                if (opcao == "0")
                {
                    return;
                }

                Console.Write("\nCategoria: ");
                categoriaProduto = BuscarCategoriaProdutoPorNome(Console.ReadLine());
            }

            Console.WriteLine("Informe Código do Produto a Editar!");
            ListarProdutos(categoriaProduto);
            Console.Write("Código Produto: ");

            Produto produto = BuscarProdutoPorCodigo(categoriaProduto, Console.ReadLine());

            while (produto == null)
            {
                Console.WriteLine("Produto não localizado!");
                Console.WriteLine("1-Tentar novo Dódigo;");
                Console.WriteLine("0-Retornar.");

                opcao = Console.ReadLine();

                while (opcao != "1" && opcao != "0")
                {
                    Console.WriteLine("1-Tentar novo Dódigo;");
                    Console.WriteLine("0-Retornar.");
                    opcao = Console.ReadLine();
                }

                if (opcao == "0")
                {
                    return;
                }

                Console.Write("Código Produto: ");

                produto = BuscarProdutoPorCodigo(categoriaProduto, Console.ReadLine());
            }

            Console.WriteLine("Confirmar Edição do Produto!");
            ExibirProduto(produto);
            Console.WriteLine("\n1-Editar Produto;");
            Console.WriteLine("0-Retornar.");

            opcao = Console.ReadLine();

            while (opcao != "1" && opcao != "0")
            {
                Console.WriteLine("\n1-Editar Produto;");
                Console.WriteLine("0-Retornar.");
                opcao = Console.ReadLine();
            }

            if (opcao == "0")
            {
                return;
            }

            //EDITAR:
            //Nome, CodigoBarra, Fabricante,NomeFornecedor, ValorCompra, ValorVenda

            //NOME
            Console.WriteLine("Informe novo Valor ou ENTER para próximo campo!\n");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(nome))
            {
                produto.Nome = nome;
            }

            //CÓDIGO DE BARRA
            Console.Write("Código: ");

            string codigo = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(codigo))
            {
                produto.CodigoBarra = codigo;
            }

            //FABRICANTE
            Console.Write("Fabricante: ");

            string fabricante = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(fabricante))
            {
                produto.Fabricante = fabricante;
            }

            //FORNECEDOR
            Console.WriteLine("Informe CNPJ do Fornecedor!");
            ListarFornecedores();
            Console.Write("\nCNPJ Fornecedor: ");

            string CNPJFornecedor = Console.ReadLine();

            Fornecedor fornecedor = new Fornecedor();

            if (!string.IsNullOrWhiteSpace(CNPJFornecedor))
            {
                fornecedor = BuscarFornecedorPorCNPJ(CNPJFornecedor);

                while (fornecedor == null)
                {
                    Console.WriteLine("Fornecedor não localizado!");
                    Console.WriteLine("1-Tentar novo CNPJ;");
                    Console.WriteLine("0-Retornar.");

                    opcao = Console.ReadLine();

                    while (opcao != "1" && opcao != "0")
                    {
                        Console.WriteLine("1-Tentar novo CNPJ;");
                        Console.WriteLine("0-Retornar.");
                        opcao = Console.ReadLine();
                    }

                    if (opcao == "0")
                    {
                        return;
                    }

                    Console.Write("\nCNPJ Fornecedor: ");

                    fornecedor = BuscarFornecedorPorCNPJ(Console.ReadLine());
                }

                produto.NomeFornecedor = fornecedor.Nome;
            }


            //VALOR DE COMPRA
            Console.Write("Valor de Compra: ");

            string entrada = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(entrada))
            {
                if (double.TryParse(entrada, out double valorCompra))
                {
                    produto.ValorCompra = valorCompra;
                }
            }

            //VALOR DE VENDA
            Console.Write("Valor de Venda: ");

            entrada = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entrada))
            {
                if (double.TryParse(entrada, out double valorVenda))
                {
                    produto.ValorVenda = valorVenda;
                }
            }
        }

        //PRODUTOS FORNECEDOR
        //CADASTRAR PRODUTO FORNECEDOR
        internal void CadastrarProdutoFornecedor(Fornecedor fornecedor, string codigo, string nome, double valorCompra)
        {
            Produto produto = new Produto();

            produto.CodigoBarra = codigo;

            produto.Nome = nome;

            produto.ValorCompra = valorCompra;

            fornecedor._produtosFornecedor.Add(produto);
        }

        //BUSCAR PRODUTO FORNECEDOR POR CÓDIGO
        internal Produto BuscarProdutoFornecedorPorCodigo(Fornecedor fornecedor, string codigoProduto)
        {
            foreach (Produto produto in fornecedor._produtosFornecedor)
            {
                if (produto.CodigoBarra == codigoProduto)
                {
                    return produto;
                }
            }
            return null;
        }

        //EXIBIR PRODUTO FORNECEDOR POR CÓDIGO
        internal void ExibirProdutoFornecedor(Fornecedor fornecedor, string codigo)
        {
            Produto produto = BuscarProdutoFornecedorPorCodigo(fornecedor, codigo);

            Console.WriteLine($"Código: {produto.CodigoBarra}" + $" - Nome: {produto.Nome}");
            Console.WriteLine($"Valor Compra: {produto.ValorCompra}\n");
        }


        //LISTAR PRODUTOS FORNECEDOR POR CÓDIGO
        internal void ListarProdutosFornecedor()
        {
            Fornecedor fornecedor = new Fornecedor();

            foreach (Produto produto in fornecedor._produtosFornecedor)
            {
                Console.WriteLine($"Código: {produto.CodigoBarra}" + $" - Nome: {produto.Nome}");
                Console.WriteLine($"Valor Compra: {produto.ValorCompra}\n");
            }
        }

        //REMOVER PRODUTO FORNECEDOR POR CÓDIGO
        internal void RemoverProdutoFornecedor(Fornecedor fornecedor, string codigo)
        {
            Produto produto = BuscarProdutoFornecedorPorCodigo(fornecedor, codigo);

            fornecedor._produtosFornecedor.Remove(produto);
        }

        //EDITAR PRODUTO FORNECEDOR POR CÓDIGO
        internal void EditarProdutoFornecedor(Fornecedor fornecedor, string codigo, string nome, double valorCompra)
        {
            Produto produto = BuscarProdutoFornecedorPorCodigo(fornecedor, codigo);

            produto.CodigoBarra = codigo;

            produto.Nome = nome;

            produto.ValorCompra = valorCompra;
        }


        //SISTEMA LOJA DE INFORMÁTICA
        //CADASTRAR COMPRA
        //[1]NOTA FISCAL -  [1]COMPRA[...] - [1]CLIENTE
        internal void CadastrarCompra()
        {
            //NOVA COMPRA
            Compra compra = new Compra();

            NotaFiscal notaFiscal = new NotaFiscal();
            notaFiscal.IdNota = NotaFiscal.ProximoId++;

            //DADOS FORNECEDOR
            Console.WriteLine("COMPRAR PRODUTO(S)!\n");
            Console.WriteLine("Informe CNPJ do Fornecedor: ");
            ListarFornecedores();
            Console.Write("\nCNPJ Fornecedor: ");

            Fornecedor fornecedor = BuscarFornecedorPorCNPJ(Console.ReadLine());

            string opcao;

            while (fornecedor == null)
            {
                Console.WriteLine("Fornecedor não localizado!");
                Console.WriteLine("1-Tentar novo CNPJ;");
                Console.WriteLine("0-Retornar.");

                opcao = Console.ReadLine();

                while (opcao != "1" && opcao != "0")
                {
                    Console.WriteLine("1-Tentar novo CNPJ;");
                    Console.WriteLine("0-Retornar.");
                    opcao = Console.ReadLine();
                }

                if (opcao == "0")
                {
                    return;
                }

                Console.Write("\nFornecedor: ");
                fornecedor = BuscarFornecedorPorCNPJ(Console.ReadLine());
            }
            compra.CnpjFornecedor = fornecedor.CNPJ;

            compra.NomeFornecedor = fornecedor.Nome;

            compra.TelefoneFornecedor = fornecedor.Telefone;

            string entrada = "";

            while (entrada == "1")
            {
                //CATEGORIA
                Console.WriteLine("Informe Categoria do Produto: ");
                ListarCategoriasProdutos();
                Console.Write("Categoria Produdo: ");

                CategoriaProduto categoriaProduto = BuscarCategoriaProdutoPorNome(Console.ReadLine());

                while (categoriaProduto == null)
                {
                    Console.WriteLine("Categoria não localizada!");
                    Console.WriteLine("1-Tentar novo nome;");
                    Console.WriteLine("0-Retornar.");

                    opcao = Console.ReadLine();

                    while (opcao != "1" && opcao != "0")
                    {
                        Console.WriteLine("1-Tentar novo nome;");
                        Console.WriteLine("0-Retornar.");
                        opcao = Console.ReadLine();
                    }

                    if (opcao == "0")
                    {
                        return;
                    }

                    Console.Write("Categoria Produdo: ");
                    categoriaProduto = BuscarCategoriaProdutoPorNome(Console.ReadLine());
                }

                /*
                //PRODUTOS
                Console.WriteLine("1-Comprar Produto já cadastrado;");
                Console.WriteLine("2-Comprar novo Produto.");

                opcao = Console.ReadLine();

                while (opcao != "1" && opcao != "2")
                {
                    Console.WriteLine("1-Comprar Produto já cadastrado;");
                    Console.WriteLine("2-Comprar novo Produto.");
                    opcao = Console.ReadLine();
                }

                Console.WriteLine("Inoforme Código do Produtos!\n");
                ListarProdutosFornecedor();
                Console.Write("\nCódigo do Produto: ");

                Produto produto = BuscarProdutoFornecedorPorCodigo(fornecedor, Console.ReadLine());

                if (opcao == "1")
                {
                    while (produto == null)
                    {
                        Console.WriteLine("Produto não localizado!");
                        Console.WriteLine("1-Informar código;");
                        Console.WriteLine("0-Retornar.");

                        opcao = Console.ReadLine();

                        while (opcao != "1" && opcao != "0")
                        {
                            Console.WriteLine("1-Informar código;");
                            Console.WriteLine("0-Retornar.");
                            opcao = Console.ReadLine();
                        }

                        if (opcao == "0")
                        {
                            return;
                        }

                        Console.Write("\nCódigo do Produto: ");
                        produto = BuscarProdutoPorCodigo(categoriaProduto, Console.ReadLine());
                    }
                }

                else if (opcao == "2")
                {
                    Console.WriteLine("Informe Valor de Venda: ");
                    double.TryParse(Console.ReadLine(), out double valorVenda);
                    produto.ValorVenda = valorVenda;

                    categoriaProduto._produtos.Add(produto);
                }

                Console.WriteLine("Quantidade: ");
                int.TryParse(Console.ReadLine(), out int quantidade);

                Produto produtoNota = produto;

                produtoNota.Quantidade = quantidade;

                notaFiscal._produtosNota.Add(produto);

                produto.Quantidade += quantidade;

                notaFiscal.ValorTotal += produto.ValorCompra * quantidade;

                Console.WriteLine("1-Incluir outro Produto;");
                Console.WriteLine("0-Finalizar Compra.");

                while (entrada != "1" && entrada != "0")
                {
                    Console.WriteLine("1-Incluir outro Produto;");
                    Console.WriteLine("0-Finalizar Compra.");
                }

                entrada = Console.ReadLine();
            }

            //FINALIZAR COMPRA
            Console.WriteLine("1-Finalizar Compra;");
            Console.WriteLine("2-Modificar Compra;");
            Console.WriteLine("3-Cancelar Compra.");
            entrada = Console.ReadLine();

            while (entrada != "1" && entrada != "2" && entrada != "3")
            {
                Console.WriteLine("1-Finalizar Compra;");
                Console.WriteLine("2-Modificar Compra;");
                Console.WriteLine("3-Cancelar.");
                entrada = Console.ReadLine();
            }

            if (entrada == "3")
            {
                return;
            }

            else if (entrada == "2")
            {
                foreach (Produto produtoV in notaFiscal._produtosNota)
                {
                    Console.WriteLine($"Código: { }");
                }
            }

            else if (entrada == "1")
            {
                foreach (Produto produtoV in notaFiscal._produtosNota)
                {



                }
            */


            }



            Console.WriteLine("Compra Finalizada com Sucesso!");

            _notaFiscais.Add(notaFiscal);
        }


        //LISTAR COMPRAS CLIENTE


        //BUSCAR COMPRA CLIENTE


        //CONSULTAR COMPRA CLIENTE


        //EXIBIR COMPRA CLIENTE


        //REMOVER COMPRA


        //EDITAR COMPRA



        //SISTEMA DA LOJA DE INFORMÁTICA
        //EMITIR NOTA FISCAL
        //[1]NOTA FISCAL -  [1]COMPRA[...] - [1]CLIENTE



        //ELIMINAR NOTA FISCAL





    }//FIM DA CLASSE SISTEMA DA LOJA
}
