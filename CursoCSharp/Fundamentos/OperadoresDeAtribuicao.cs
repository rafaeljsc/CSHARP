using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresDeAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 = 7;
            num1 += 10;
            num1 -= 3;
            num1 *= 5;
            num1 /= 2;

            Console.WriteLine(num1);

            //Atribuição por valor

            int a = 1;
            int b = a;

            a++;
            b--;

            Console.WriteLine("{0} {1}", a, b);

            //Atribuição dinâmica

            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";
            dynamic d = c;
            d.nome = "Maria";

            Console.WriteLine(c.nome);

        }
    }
}
