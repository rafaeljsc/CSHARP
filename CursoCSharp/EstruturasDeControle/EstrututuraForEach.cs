using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp {
    class EstrututuraForEach {
        public static void Executar() {
            var palavra = "Rafael";
            foreach (var p in palavra) {
                Console.WriteLine(p);
            }
            var familia = new string[] { "Rafael", "Fernanda", "Claudio" };
            foreach (var pessoa in familia) {
                Console.WriteLine(pessoa);
            }
        }
    }
}
