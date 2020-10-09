using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp {
    class EstruturaDoWhile {
        public static void Executar()
        {
            string nome;
            do {
                Console.Write("Qual o seu nome? ");
                nome = Console.ReadLine();

                Console.WriteLine($"Seja bem-vindo(a) {nome}!");
                Console.Write("Adicionar novo nome? (S/N) ");
                nome = Console.ReadLine();                
            } while (nome.ToLower() == "s");         
        }           
    }
}

