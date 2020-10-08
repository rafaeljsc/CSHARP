using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            //Interpolação são formas de concatenação

            var curso = "C#";
            var acao = "estudando";
            var objetivo = "futuro melhor";

            Console.WriteLine("Eu estou " + acao + " " + curso + " para garantir um " + objetivo);
            Console.WriteLine("Eu estou {0} {1} para garantir um {2}",acao,curso,objetivo);
            Console.WriteLine($"Eu estou {acao} {curso} para garantir um {objetivo}");
        }
    }
}
