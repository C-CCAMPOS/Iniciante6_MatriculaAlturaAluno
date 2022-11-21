using System;

namespace MatriculaAlturaAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Leia a altura e a matricula - Faça um algoritmo que leia a altura e a matricula de dez aluno.
            //Mostre a matricula do aluno mais alto e do aluno mais baixo 

            Console.WriteLine("\n\n\n********************************************************************************");
            Console.WriteLine(">>>>> INFORME A ALTURA, MAIS ALTO, MAIS BAIXO E A MATRICULA DE CADA ALUNOS <<<<<");
            Console.WriteLine("********************************************************************************");

            int i = 0;
            int qtd = 0;
            int matricula = 0;

            Console.Write("\n\n\nInforme a quantidade de Aluno(s) que deseja buscar as informações: ");
            qtd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("\n\n\n");

            while (i < qtd)
            {
                i++;

                Console.Write("Digite a matrícula do Aluno |" + i + "|: ");
                matricula = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("********************************************************************************");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n********************************************************************************");
            Console.WriteLine("             >>>>>    APLICAÇÃO FINALIZADA COM SUCESSO    <<<<<");
            Console.WriteLine("********************************************************************************");
            Console.ReadKey();
        }
    }
}
