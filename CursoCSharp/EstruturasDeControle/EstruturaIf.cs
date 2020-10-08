using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;

            Console.Write("Digite a nota do aluno: ");
            var entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.Write("Possui bom comportamento? (S/N): ");
            entrada = Console.ReadLine();
            bomComportamento = entrada.ToLower() == "s"; // if implícito
            if (nota >=9 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra!");
            }
        }
    }
}
