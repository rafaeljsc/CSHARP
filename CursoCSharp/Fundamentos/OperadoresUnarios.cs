using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresUnarios

        //São operadores que não dependem de outros valores/variáveis para realizar uma operação
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var num1 = 2;
            var num2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo); //nesse caso o valor de "-5" será "5"
            Console.WriteLine(!booleano); //inversão para "false"


            num1++; //menor precedência no processamento
            --num2; //maior precedência no processamento

            Console.WriteLine(num1++ == --num2); //num2 será decrementado primeiro e em seguida comparado com num1, de menor precedência

        }
    }
}
