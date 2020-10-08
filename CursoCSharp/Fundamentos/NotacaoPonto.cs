using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            //Nada mais é do que o "." utilizado para acessar as propriedades de um objeto
            string generic = "Olá Mundo";
            Console.WriteLine(generic);
            Console.WriteLine(generic.ToUpper());
            Console.WriteLine(generic.ToLower());
            Console.WriteLine(generic.Length);
            
            //Assim como no Powershell, não é possível acessar uma propriedade de um valor nulo. Isso ocasiona uma exceção.
            //A NAVEGAÇÃO SEGURA (?) serve para proteger o código dessas exceções, fazendo com que o a propriedade seja acessada somente se o objeto não for nulo.

            string nulo = null;
            Console.WriteLine(nulo?.Length);
        }
    }
}
