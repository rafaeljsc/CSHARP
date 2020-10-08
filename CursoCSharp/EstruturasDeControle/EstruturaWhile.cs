using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaWhile {
        public static void Executar()
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.Write("Palpite: ");
                int.TryParse(Console.ReadLine(),out int palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Numero encontrado em {tentativas} tentativas");
                    Console.BackgroundColor = corAnterior;
                } else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Menor... Tente novamente.");
                    Console.WriteLine($"Tentaivas restantes: {tentativas} tentativas");
                }
                else
                {
                    Console.WriteLine("Maior... Tente novamente.");
                    Console.WriteLine($"Tentaivas restantes: {tentativas} tentativas");
                }
                
            }
        }
    }
}
