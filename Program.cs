using System;
using System.Collections.Generic;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("==========================");
            Console.WriteLine("Bem vindo(a) a sua lista de contatos");
            Console.WriteLine("==========================");
            Console.WriteLine("Aperte qualquer botão para continuar");
            Console.ReadKey(); Console.Clear();


            while (true)
            {
                Console.WriteLine("===============================");
                Console.WriteLine("Escolha uma das opções listadas");
                Console.WriteLine("1 - Criar um novo contato");
                Console.WriteLine("2 - Visualizar o contato");
                int escolha = int.Parse(Console.ReadLine());

                if(escolha == 1)
                {
                    Console.WriteLine("Criação de Contatos:");
                    Console.WriteLine("Nome"); string Nome = Console.ReadLine();
                    Console.WriteLine("Nome: {0}", Nome);

                    List<Telefones> telefones = new List<Telefones>();
                    while (true)
                    {
                        Telefones telefone = new Telefones();
                        Console.WriteLine("Digite o número: "); string numero = Console.ReadLine();
                        if(numero.Length == 1)
                        {
                            Console.WriteLine("Aperte qualquer botão");
                            Console.ReadKey(); Console.Clear(); break;
                        }
                        else if(numero.Length == 10 || numero.Length == 11)
                        {
                            Console.WriteLine("Número cadastrado com sucesso");
                            Console.WriteLine("Aperte qualquer botão para continuar");
     
                            telefones.Add(telefone); Console.ReadKey(); Console.ResetColor();
                            
                            Console.ReadKey(); Console.Clear(); break;
                        }
                        else
                        {
                            Console.WriteLine("Número inválido");
                            Console.WriteLine("Aperte qualquer botão");
                            Console.ReadKey(); Console.Clear(); continue;
                        }
                    }
                }
                else if (escolha == 2)
                {
                    foreach(Contato contato in Agenda.contatos)
                    {
                        Console.WriteLine($"{contato.GetID()} - {contato.GetNome()} - {contato.GetIdade()} - {contato.GetEmail()}");
                        foreach(Telefones telefones in contato.GetTelefones())
                        {
                            Console.WriteLine($"{telefones.GetNumero()}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Nenhuma escolha feita");
                    Console.WriteLine("Aperte qualquer botão");
                    Console.ReadKey(); Console.Clear(); continue;
                }
            }
        }
        }

    }
    

