using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            //Desconto: soma, subtração, multiplicação
            Console.WriteLine("");
            Console.WriteLine("Desconto:");
            Console.WriteLine("-----");

            var preco = 1000.0;
            var imposto = 300;
            var desconto = 0.2;

            double total = preco + imposto;
            double totalComDesconto = total - total * desconto;
            Console.WriteLine($"Preço: {total}");
            Console.WriteLine($"Preço com {desconto.ToString("P0")} de desconto: {totalComDesconto.ToString("C")}");

            //IMC: divisão, exponenciação
            Console.WriteLine("");
            Console.WriteLine("IMC");
            Console.WriteLine("-----");

            double peso = 72;
            double altura = 1.88;
            double IMC = peso / Math.Pow(altura, 2);
            Console.WriteLine($"Peso: {peso} \nAltura: {altura} \nIMC: {IMC.ToString("F2")}");

            //Ímpar, par: divisão, módulo
            Console.WriteLine("");
            Console.WriteLine("Ímpar, par");
            Console.WriteLine("-----");

            int impar = 3;
            int par = 2;
            Console.WriteLine($"{impar}/2 tem resto {impar % 2}");
            Console.WriteLine($"{par}/2 tem resto {par % 2}");

        }
    }
}
