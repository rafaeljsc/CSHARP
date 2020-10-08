using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = false;
            var executouTrabalho2 = true;

            bool comprouTVde50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine($"Comprou TV de 50: {comprouTVde50}");

            bool comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine($"Comprou sorvete: {comprouSorvete}");

            bool comprouTVde32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine($"Comprou TV de 32: {comprouTVde32}");

            Console.WriteLine($"Mais saudável: {!comprouSorvete}");
        }
    }
}
