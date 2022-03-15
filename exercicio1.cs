using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int b, altura, area;
            Console.WriteLine("Digite o valor da base: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura: ");
            altura = int.Parse(Console.ReadLine());
            area = (b * altura)/ 2;
            Console.Write("A área é ");
            Console.WriteLine(area);

        }
    }
}
