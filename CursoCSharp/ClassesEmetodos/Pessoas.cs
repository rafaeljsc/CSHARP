using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEmetodos {
    class Pessoa {
        public string Nome;
        public int Idade;

        public string Apresentar() {
            return string.Format(
                $"Olá! me chamo {Nome} e tenho {Idade} anos!");
        }
    }
}
