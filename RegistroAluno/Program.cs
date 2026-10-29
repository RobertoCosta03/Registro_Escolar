using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nomeAluno = new List<string>();
            List<double> notas = new List<double>();
            int quantidadeAluno = 0;
            bool registroAluno = true;
            int op;

            while (registroAluno)
            {
                Console.WriteLine("REGISTRO ESCOLAR");
                Console.WriteLine("Digite o que deseja:");
                Console.WriteLine("1 - Registrar alunos e notas");
                Console.WriteLine("2 - Exibir Alunos e notas");
                Console.WriteLine("3 - Editar registro");
                Console.WriteLine("4 - Sair do sistema");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Registre os alunos");
                        bool registroEscolar = true;



                        while(registroEscolar)
                        {
                            Console.Write("Insira o NOME do aluno: ");
                            nomeAluno.Add(Console.ReadLine());

                            Console.Write("Insira a NOTA do aluno: ");
                            notas.Add(Convert.ToDouble(Console.ReadLine()));
                            quantidadeAluno += 1;

                            Console.WriteLine("Registro de aluno completo");
                            Console.WriteLine("\n");



                            bool continuarPergunta = true;

                            do
                            {
                                Console.WriteLine($"Deseja registrar mais?: \n 1 - sim  \n 2 - nao");
                                int respostaPergunta = Convert.ToInt32(Console.ReadLine());

                                switch (respostaPergunta)
                                {
                                    case 1:
                                        continuarPergunta = false;
                                        break;

                                    case 2:
                                        registroEscolar = false;
                                        continuarPergunta = false;
                                        break;

                                    default:
                                        Console.WriteLine("opcao invalida!");
                                        Console.ReadKey();
                                        break;
                                }
                                Console.Clear();
                            } while (continuarPergunta);
                        }

                        Console.Clear();

                        break;

                    case 2:
                        if (quantidadeAluno > 0)
                        {
                            for (int i = 0; i < quantidadeAluno; i++)
                            {
                                Console.WriteLine("Aluno: " + nomeAluno[i] + " Nota: " + notas[i]);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nenhum registro encontrado");

                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;


                    //editar registro escolar
                    case 3:
                        if (quantidadeAluno > 0)
                        {
                            for (int i = 0; i < quantidadeAluno; i++)
                            {
                                Console.WriteLine($"{i + 1} - Aluno: {nomeAluno[i]} Nota: {notas[i]}");
                            }

                            Console.Write("Informe qual registro deseja editar:");
                            int registro = Convert.ToInt32(Console.ReadLine());
                            int registroEditar = registro - 1;

                            if (registroEditar >= 0 && registroEditar < quantidadeAluno)
                            {
                                Console.Write("Insira o NOME do aluno: ");
                                nomeAluno[registroEditar] = Console.ReadLine();

                                Console.Write("Insira o NOTA do aluno: ");
                                notas[registroEditar] = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Registro editado com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("Nenhum registro encontrado");

                            }

                        }
                        else
                        {
                            Console.WriteLine("Nenhum registro encontrado");

                        }



                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        registroAluno = false;
                        break;

                    default:
                        Console.WriteLine("opcao invalida!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }

            Console.WriteLine("Obrigado por usar nosso sistema!");
            Console.ReadKey();

        }
    }
}
