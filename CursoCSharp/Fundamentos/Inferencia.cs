using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            Console.WriteLine("Inferências ocorrem quando uma o tipo da variável não é declarado explicitamente, deixando a cargo do compilador definir o seu tipo. \n"+
                "Inferências são invocadas com o tipo genérico 'var'.");

           //var generic = "Teste";
            //var genericNumber = 1;

            Console.WriteLine("");

            Console.WriteLine("O compilador irá definir generic como 'string' e genericNumber como 'int' com base no seu valor \n" +
            "Inferências precisam ser inicializadas no mesmo momento. Não é possível criar uma Inferência sem valor, assim como variáveis explícitas.");

        }
    }
}
