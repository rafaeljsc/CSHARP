using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEmetodos {
    class Membros {
        public static void Executar() {

            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Rafael";
            sicrano.Idade = 28;

            Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos");
        }
    }
}
