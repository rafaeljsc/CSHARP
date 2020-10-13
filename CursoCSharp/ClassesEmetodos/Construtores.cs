using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEmetodos {
    class Carro {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano) {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        public Carro() { }
    }

    class Construtores {
        public static void Executar() {
            var carro1 = new Carro();
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2017;
            Console.WriteLine(
                $"\nFabricante: {carro1.Fabricante}\n" +
                $"Modelo: {carro1.Modelo}\n" +
                $"Ano: {carro1.Ano}");

            var carro2 = new Carro("Ka", "Ford", 2018);
            Console.WriteLine(
                $"\nFabricante: {carro2.Fabricante}\n" +
                $"Modelo: {carro2.Modelo}\n" +
                $"Ano: {carro2.Ano}");

            var carro3 = new Carro() {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2019
            };
            Console.WriteLine(
             $"\nFabricante: {carro3.Fabricante}\n" +
             $"Modelo: {carro3.Modelo}\n" +
             $"Ano: {carro3.Ano}");

        }
    }
}
