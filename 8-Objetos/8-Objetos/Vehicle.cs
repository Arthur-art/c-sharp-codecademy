using System;
using System.Collections.Generic;
using System.Text;

namespace _8_Objetos
{
    class Vehicle
    {
        public Vehicle(int rodas, string modelo)
        {
            Rodas = rodas;
            Modelo = modelo;
        }

        public int Rodas { get; set; }

        public string Modelo { get; set; }

        public void estoque()
        {
            Console.WriteLine($"Possuimos {Rodas} rodas para este modelo de carro {Modelo}");
        }
    }
}
