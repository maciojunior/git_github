using System.Globalization;
namespace Lista1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio1();
            Exercicio2();
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

            Console.WriteLine(OneNumber+TwoNumber);
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
    }
}