using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {   //double:
            //Valores: decimais

            double raio = 4.5;
            const double PI = 3.14;
            double area = PI * raio * raio;
            Console.WriteLine("Área de um círculo de raio " + raio + " é de " + area);

            //bool:
            //Valores: true ou false

            Console.WriteLine("bool: permite apenas dois valores, true e false");


            //byte
            //Valores: mínimo 0, máximo 255

            Console.WriteLine("byte: pode ter valores entre " + byte.MinValue + " e " + byte.MaxValue);

            //sbyte
            //Valores: mínimo -128, máximo 127

            Console.WriteLine("sbyte: pode ter valores entre " + sbyte.MinValue + " e " + sbyte.MaxValue);

            //short
            //Valores: mínimo -32768, máximo 32767

            Console.WriteLine("short: pode ter valores entre " + short.MinValue + " e " + short.MaxValue);

            //int
            //Valores: mínimo -2147483648, máximo 2147483647
            Console.WriteLine("int: pode ter valores entre " + int.MinValue + " e " + int.MaxValue);

            //float
            //Valores: metade do double

            //long
            //Valores: maior que o int. Suporta negativos

            //ulong
            //Valores: pega o espaço de memória dos negativos de long e joga tudo pra positivo

            //decimal
            //Valores: maior que o long

            //char
            //Valores: suporta apenas uma letra

            //string
            //Valores: suporta palavras e sentenças

        }
    }
}
