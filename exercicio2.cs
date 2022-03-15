using System;

namespace exercicios2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, soma, sub, divisao, mult;
            Console.WriteLine("Digite o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            n2 = int.Parse(Console.ReadLine());
            soma = n1 + n2;
            Console.Write("A soma é ");
            Console.WriteLine(soma);
            sub = n1 - n2;
            Console.Write("A subtraçao é ");
            Console.WriteLine(sub);
            divisao = n1 / n2;
            Console.Write("A divisao é ");
            Console.WriteLine(divisao);
            mult = n1 * n2;
            Console.Write("A multiplicação é ");
            Console.WriteLine(mult);

        }
    }
}
