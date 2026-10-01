using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Xml;
using Loja_de_Informatica;

namespace Loja_de_Informatica
{
    //CLASSE DO PROGRAMA
    internal class Program
    {

        //MÉTODO DO PROGRAMA
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            SistemaLoja sistemaLoja = new SistemaLoja();

            while (true) //Mantém no Menu Principal
            {

                string opcao = menu.MenuPrincipal();

                //1-Funcionário!
                if (opcao == "1")
                {
                    while (true) //Mantém no Menu Funcionário
                    {

                        opcao = menu.MenuFuncionario();

                        sistemaLoja.ListarFuncionarios();

                        //1-Cadastrar
                        if (opcao == "1")
                        {
                            Console.WriteLine(Menu.nomeLoja);

                            sistemaLoja.CadastrarFuncionario();

                            Console.Clear();
                        }

                        //2-Consultar
                        else if (opcao == "2")
                        {
                            if (sistemaLoja._funcionarios.Count == 0)
                            {
                                Console.WriteLine("Precione qualquer tecla para finalizar!");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }
                            sistemaLoja.ConsultarFuncionarioNome();

                            Console.Clear();
                        }

                        //3-Editar
                        else if (opcao == "3")
                        {
                            sistemaLoja.EditarFuncionarioCPF();
                        }

                        //4-Remover
                        else if (opcao == "4")
                        {
                            sistemaLoja.RemoverFuncionarioCPF();
                        }

                        //0-Retornar
                        else if (opcao == "0")
                        {
                            break;
                        }
                    }
                }

                //2-Fornecedor!
                else if (opcao == "2")
                {
                    menu.MenuFornecedor();
                }

                //3-Produto!
                else if (opcao == "3")
                {
                    menu.MenuProduto();
                }

                //4-Cliente!
                else if (opcao == "4")
                {
                    menu.MenuCliente();
                }

                //5-Compra!
                else if (opcao == "5")
                {
                    menu.MenuCompra();
                }

                //6-Venda!
                else if (opcao == "6")
                {
                    opcao = menu.MenuVenda();

                    if (opcao == "1")
                    {

                    }

                }

                //Sair
                if (opcao == "0")
                {
                    return;
                }

            }




        }

    }
}