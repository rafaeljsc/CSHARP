using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp
{
    class OperadoresTernarios
    {
        public static void Executar()
        {
            var nota = 6;
            bool bomComportamento = true;
            var resultado = nota >= 7.0 && bomComportamento
                ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}
