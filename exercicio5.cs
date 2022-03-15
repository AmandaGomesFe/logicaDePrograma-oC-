using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            if(num1 == num2)
            {
                Console.WriteLine("O numero " + num1 + " é igual ao numero " + num2);
            }
            else
            {
                if(num1 > num2)
                {
                    Console.WriteLine("O numero " + num1 + " é maior que o numero " + num2);
                }
                else
                {
                    Console.WriteLine("O numero" + num2 + " é maior que o numero " + num1);
                }
            }


        }
    }
}
