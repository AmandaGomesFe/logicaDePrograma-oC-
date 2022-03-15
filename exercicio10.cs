using System;

namespace exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, media;
            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número: ");  
            num3 = int.Parse(Console.ReadLine());

            media = (num1 + num2 + num3) / 3;
            Console.WriteLine("A média dos números é " + media);

        }
    }
}

