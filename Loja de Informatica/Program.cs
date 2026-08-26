using System;
using System.Collections.Generic;

namespace Loja_de_Informatica
{
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

            Console.WriteLine("Ébano Informática!\n");

            //Menu


            //Funcionários
            //Funcionários.Cadastrar
            while (true)
            {
                //variável "funcionário" armazena uma referência para objeto criado da Classe Funcionário
                //Add(funcionario), armazena a referência "funcionario a lista "funcionarios", e ao final do escopo em "}", a variável "funcionário" deixa de existir, mas a referência "funcionário" já foi guardada dentro da lista "funcionarios"
                //Ao iniciar novamente o "while" a variável "funcionário" poderá ser utilizada novamente e a referência para o primeiro objeto criado permanece guardado na lista "funcionários"
                Funcionario funcionario = new Funcionario();
                funcionario.Nome = "Joao";
                funcionarios.Add(funcionario);
            }


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








        }
    }
}
