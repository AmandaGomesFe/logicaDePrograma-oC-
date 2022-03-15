using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            float n1, n2, n3, media;

            Console.WriteLine("Digite o nome do Aluno: ");
            nome = Console.ReadLine();
            Console.WriteLine(nome);
            Console.WriteLine("Digite a primeira nota: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            n3 = float.Parse(Console.ReadLine());
            media = ((n1 * 2) + (n2 * 4) + (n3 * 6) / (2 + 4 + 6));
            Console.Write(" A media é ");
            Console.WriteLine(media);
        }
    }
}
