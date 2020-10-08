using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp {
    class EstruturaBreak {
        public static void Executar() {
            Random random = new Random();
            int numero = random.Next (1, 51);
            Console.WriteLine("Numero escolhido: {0}", numero);

            for (int i = 1; i <= 50; i++) {
                Console.Write($"{i} é o número escolhido? ");
                if (i == numero) {
                    Console.WriteLine("Sim");
                    break;
                } else {
                    Console.WriteLine("Não");
                }

                }
            }

        }
    }
