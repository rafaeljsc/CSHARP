using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEmetodos {

    class CalculadoraComum {
        public int Somar(int a, int b) {
            return a + b;
        }
        public int Subtrair(int a, int b) {
            return a - b;
        }
    }

    class CalculadoraCadeia {
        int memoria;

        public CalculadoraCadeia Somar(int a) {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Subtrair(int a) {
            memoria -= a;
            return this;
        }

        public CalculadoraCadeia Limpar() {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir() {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado() {
            return memoria;
        }

    }

    class MetodosComRetorno {
        public static void Executar() {
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(5, 3);
            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(10, 1));

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Subtrair(2).Imprimir().Limpar().Imprimir();
        }
    }
}
