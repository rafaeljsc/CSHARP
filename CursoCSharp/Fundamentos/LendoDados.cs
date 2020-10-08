using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Nome: ");
            var nome = Console.ReadLine();
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
        }
    }
}
