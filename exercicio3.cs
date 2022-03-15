using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float salarioFixo, vendas, salarioFinal, comissao;
            string nome;

            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o seu sálario: ");
            salarioFixo = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o total de vendas em dinheiro: ");
            vendas = float.Parse(Console.ReadLine());
            comissao = (20 * 100) / vendas;
            salarioFinal = comissao + salarioFixo;
            Console.Write("O salario final é: ");
            Console.WriteLine(salarioFinal);
        }
    }
}
