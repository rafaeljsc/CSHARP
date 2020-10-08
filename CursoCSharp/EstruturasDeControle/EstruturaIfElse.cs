using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElse
    {
        public static void Executar()
        {
            double nota = 8;
            if (nota >= 7)
            {
                Console.WriteLine($"Nota: {nota} \nSituação: Aprovado");
            }else{
                Console.WriteLine($"Nota: {nota} \nSituação: Reprovado");
            }
        }
    }
}
