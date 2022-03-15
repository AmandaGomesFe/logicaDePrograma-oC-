using System;

namespace exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2;

            Console.WriteLine("Informe o primeiro número: ");
            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            num2 = float.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("O número " + num1 + " é maior que o número " + num2);
            }
            else
            {
                if (num2 > num1)
                {
                    Console.WriteLine("O número " + num2 + " é maior que o número " + num1);
                }
                else
                {
                    Console.WriteLine("Os números são iguais!");
                }
                
            }
        }
    }

}

