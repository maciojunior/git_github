namespace Lista1
{
    internal class Program
    {
        static void Main(string[] args)
        {   /*Exercício 01
            Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
            mensagem explicativa, conforme exemplos.*/

            int OneNumber = int.Parse(Console.ReadLine());
            Console.Clear();
            int TwoNumber = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine(OneNumber+TwoNumber);
        }
    }
}