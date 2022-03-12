using System;

namespace exercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, soma, subtracao, multiplicacao, divisao;
            Console.WriteLine("Digite o primeiro numero: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            n2 = double.Parse(Console.ReadLine());
            soma = n1 + n2;
            Console.Write("A soma dos numeros é: ");
            Console.WriteLine(soma);
            subtracao = n1 - n2;
            Console.Write("A subtração dos numeros é: ");
            Console.WriteLine(subtracao);
            multiplicacao = n1 * n2;
            Console.Write("A multiplicação dos numeros é: ");
            Console.WriteLine(multiplicacao);
            if (n1 >= n2)
            {
                Console.WriteLine("A divisão é: ");
                divisao = n1 / n2;
                Console.WriteLine(divisao);
            }
            else {
                Console.WriteLine("Não é possivel realizar a divisão.");
            }

            
        }
    }
}

