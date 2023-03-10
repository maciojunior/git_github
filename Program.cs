using System;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

namespace Lista1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio1();
            //Exercicio2();
            //Exercicio3();
              Exercicio4();
            
        }

        static void Exercicio1()
        {
            /*Exercício 01
            Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
            mensagem explicativa, conforme exemplos.*/

            int OneNumber = int.Parse(Console.ReadLine());
            Console.Clear();
            int TwoNumber = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine(OneNumber + TwoNumber);
        }

        static void Exercicio2()
        {
            /* Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
            casas decimais conforme exemplos.
            Fórmula da área: area = π . raio2
            Considere o valor de π = 3.14159*/

            double R, A, Pi = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A = Pi * R * R;

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));
        }

        static void Exercicio3()
        {
            /*Fazer um programa para ler quatro valores inteiros A, B, C e D.A seguir, calcule e mostre a diferença do produto
            de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).*/

            int A, B, C, D, dif;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            dif = A * B - C * D;

            Console.WriteLine("DIFERENCA = " + dif);

        }

        static void Exercicio4() 
        {
            /*Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
            hora e calcula o salário desse funcionário.A seguir, mostre o número e o salário do funcionário, com duas casas
            decimais.*/

            Double Func, JobTime, ValueTimeJob, Salary;

            Console.WriteLine("Informe o Número do funcionário");
            Func = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o Número de horas trabalhadas");
            JobTime = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Iforme o Valor de 1H de Jornada trabalhada");
            ValueTimeJob = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Salary = JobTime * ValueTimeJob;

            Console.WriteLine("NUMBER = " + Func);
            Console.WriteLine("SALARY = U$ " + Salary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}