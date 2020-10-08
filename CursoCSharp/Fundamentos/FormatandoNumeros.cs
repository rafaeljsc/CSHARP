using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumeros
    {
        public static void Executar()
        {
            double num = 20.123;
    
            //Formatar para uma casa decimal: F + número de casas desejadas
            Console.WriteLine(num.ToString("F1"));

            //Formatar para valor monetário
            Console.WriteLine(num.ToString("C"));

            //Forçar formatação de valor monetário com base na localidade (por padrão, a formatação é de acordo com a definição do sistema operacional
            CultureInfo locale = new CultureInfo("en-us");
            Console.WriteLine(num.ToString("C",locale));

            //Formatar para porcentagem (multiplicar por 100 e adicionar o sinal "%")
            Console.WriteLine(num.ToString("P"));

            //Formatação específica
            Console.WriteLine(num.ToString("#.##"));

            //Completar com 0 à esquerda: D + número de casas desejadas
            int zeros = 28;
            Console.WriteLine(zeros.ToString("D10"));
        }
    }
}
