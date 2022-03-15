using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            float num;

            Console.WriteLine("Digite um número: ");
            num = float.Parse(Console.ReadLine());

            if (num >= 200 & num <= 300)
            {
                Console.WriteLine("O número " + num + " está entre 200 e 300");
            }
            else
            {
                Console.WriteLine("O número não está entre 200 e 300");
            }
        }
    }
}
