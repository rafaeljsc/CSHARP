using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp {
    class EstruturaFor {
        public static void Executar() {
            Console.Write("Informe o tamanho da turma: ");
            int.TryParse(Console.ReadLine(), out int tamanhoDaTurma);
            double nota = 0;
            double somatorio = 0;

            for (int i = 1; i <= tamanhoDaTurma; i++) {
                Console.Write($"Infome a nota do {i}º aluno: ");
                double.TryParse(Console.ReadLine(), out nota);
                somatorio+= nota;
            }
            double media = tamanhoDaTurma > 0 ? somatorio / tamanhoDaTurma : 0;
            Console.WriteLine($"Média da turma: {media.ToString("F2")}");
        }

    }
}