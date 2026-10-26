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
            string[] nomeAluno = new string[5];
            double[] notas = new double[5];
            int quantidadeAluno = 0;
            bool registroAluno = true;
            int op;
            int i = 0;

            while (registroAluno)
            {
                Console.WriteLine("REGISTRO ESCOLAR");
                Console.WriteLine("Digite o que deseja:");
                Console.WriteLine("1 - Registrar alunos e notas");
                Console.WriteLine("2 - Exibir Alunos e notas");
                Console.WriteLine("3 - Sair do sistema");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Registre os alunos");
                        bool saida = true;



                        while (saida)
                        {
                            Console.Write("Insira o NOME do aluno: ");
                            nomeAluno[i] = Console.ReadLine();

                            Console.Write("Insira a NOTA do aluno: ");
                            notas[i] = Convert.ToDouble(Console.ReadLine());
                            quantidadeAluno += 1;
                            i += 1;

                            Console.WriteLine("Registro de aluno completo");
                            Console.WriteLine("\n");


                            bool continuarRegistro = true;

                            do
                            {
                                Console.WriteLine($"Deseja registrar mais?: \n 1 - sim  \n 2 - nao");
                                int resposta = Convert.ToInt32(Console.ReadLine());

                                switch (resposta)
                                {
                                    case 1:
                                        saida = true;
                                        continuarRegistro = false;
                                        break;

                                    case 2:
                                        saida = false;
                                        continuarRegistro = false;
                                        break;

                                    default:
                                        Console.WriteLine("opcao invalida!");
                                        Console.ReadKey();
                                        break;
                                }
                                Console.Clear();
                            } while (continuarRegistro);
                        }

                        Console.Clear();

                        break;

                    case 2:
                        if (quantidadeAluno > 0)
                        {
                            for (i = 0; i < quantidadeAluno; i++)
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

                    case 3:
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
