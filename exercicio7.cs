using System;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int folha;
            double preco;

            Console.WriteLine("Infome a quantidade de folhas: ");
            folha = int.Parse(Console.ReadLine());

            if (folha < 200)
            {
                preco = folha * 0.50;
                Console.WriteLine("O valor a ser pago é " + preco);
            }
            else
            {
                preco = folha * 0.30;
                Console.WriteLine("O valor a ser pago é " + preco);

            }
        }        
    }         
    
}
