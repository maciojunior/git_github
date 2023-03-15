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
            //Exercicio4();
            //Exercicio5();
              Exercicio6(); 
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
            /*Fazer um programa que leia o ngúmero de um funcionário, seu número de horas trabalhadas, o valor que recebe por
            hora e calcula o salário desse funcionário.A seguir, mostre o número e o salário do funcionário, com duas casas
            decimais.*/

            Double Func, JobTime, ValueTimeJob, Salary;

            Console.WriteLine("Informe o Número do funcionário");
            Func = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o Número de horas trabalhadas");
            JobTime = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o Valor de 1H de Jornada trabalhada");
            ValueTimeJob = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Salary = JobTime * ValueTimeJob;

            Console.WriteLine("NUMBER = " + Func);
            Console.WriteLine("SALARY = U$ " + Salary.ToString("F2", CultureInfo.InvariantCulture));
        }

        static void Exercicio5() 
        {
            /* Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
           código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago.*/
            int cod1, cod2, qte1, qte2;
            double preco1, preco2, total;

            string[] valores = Console.ReadLine().Split(' ');
            cod1 = int.Parse(valores[0]);
            qte1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores[0]);
            qte2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = preco1 * qte1 + preco2 * qte2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }

        static void Exercicio6() 
        {
            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            triangulo = A * C / 2.0;
            circulo = 3.14159 * C * C;
            trapezio = (A + B) / 2.0 * C;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}