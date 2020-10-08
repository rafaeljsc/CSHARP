using System;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaIfElseIf {
        public static void Executar()
        {
            Console.Write("Nota: ");
            string inputNota = Console.ReadLine();
            double.TryParse(inputNota, out double nota);

            if (nota >= 9)
            {
                Console.WriteLine($"Nota: {nota} \nQuadro de honra!");
            }
            else if (nota >= 7)
            {
                Console.WriteLine($"Nota: {nota} \nAprovado!");
            }
            else if (nota >= 5)
            {
                Console.WriteLine($"Nota: {nota} \nRecuperação");
            }
            else
            {
                Console.WriteLine($"Nota: {nota} \nInsuficiente");
            }
            Console.WriteLine("Fim!");

        }
    }
}
