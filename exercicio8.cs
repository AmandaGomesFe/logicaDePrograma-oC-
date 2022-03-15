using System;

namespace exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            Console.WriteLine("Informe a idade do jogador: ");
            idade = int.Parse(Console.ReadLine());

            switch (idade)
            {
                case <= 13:
                    Console.WriteLine("Categoria Infantil");
                    break;

                case <= 17:
                    Console.WriteLine("Categoria juvenil");
                    break;

                case > 17:
                    Console.WriteLine("Categoria sênior");
                    break;

                default:
                    Console.WriteLine("Insira uma idade válida");
                    break;


            }
        }
    }

}
