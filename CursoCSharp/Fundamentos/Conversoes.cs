using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            //Conversão implícita possível: o tipo double possui maior espaço de armazenamento que o int e também aceita valores inteiros
            //Não seria possível converter DOUBLE para INT implicitamente caso o double seja maior (em questão de armazenamento) que o INT ou possuir casa decimais.
            //Nesse caso, seria necessário realizar a conversão explícita por conta da perda de dados.

            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            //Conversão explícita:
            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine(notaTruncada);

            //Conversão de string para número:
            Console.Write("Idade: ");
            string idade = Console.ReadLine();
            int idadeInteiro = Convert.ToInt32(idade);
            Console.WriteLine(idadeInteiro);

            //Conversão com proteção contra exceção:
            Console.Write("Idade: ");
            int.TryParse(Console.ReadLine(), out int num);
            Console.WriteLine(num);





        }
    }
}
