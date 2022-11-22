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

            int i = 1;
            int qtd = 0;
            int matricula = 0;
            double maiorAltura = 0;
            double menorAltura = 0;
            int maiorMatricula = 0;
            int menorMatricula = 0;
            double altura = 0;

            Console.Write("\n\n\nInforme a quantidade de Aluno(s) que deseja buscar as informações: ");
            qtd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("********************************************************************************");


            Console.WriteLine("\n\n\n********************************************************************************");
            Console.WriteLine("obs.: A matricula dever ser informada por um número inteiro.");
            Console.WriteLine("      A altura de ser separada por '.'.");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("\n\n\n");

            Console.Write("Digite a matrícula do Aluno |" + 1 + "|: ");
            matricula = Convert.ToInt32(Console.ReadLine());

            Console.Write("   Digite a altura do Aluno |" + 1 + "|: ");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("*****************************************");

            maiorAltura = altura;
            menorAltura = altura;
            maiorMatricula = matricula;
            menorMatricula = matricula;

            while (i < qtd)
            {
                i++;

                Console.Write("Digite a matrícula do Aluno |" + i + "|: ");
                matricula = Convert.ToInt32(Console.ReadLine());

                Console.Write("   Digite a altura do Aluno |" + i + "|: ");
                altura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("*****************************************");

                if (altura > maiorAltura)
                {
                    maiorAltura = altura;
                    maiorMatricula = matricula;

                }
                if (altura < menorAltura)
                {
                    menorAltura = altura;
                    menorMatricula = matricula;
                }
            }
            Console.WriteLine("O aluno mais alto é o de numero: " + maiorMatricula + " com " + maiorAltura + " de altura.");
            Console.WriteLine("\nO aluno mais baixo é o de numero: " + menorMatricula + " com " + menorAltura + " de altura.");


            Console.WriteLine("*****************************************");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n********************************************************************************");
            Console.WriteLine("             >>>>>    APLICAÇÃO FINALIZADA COM SUCESSO!    <<<<<");
            Console.WriteLine("********************************************************************************");
            Console.ReadKey();


        }
    }
}
