// See https://aka.ms/new-console-template for more information
using System;

namespace FigurasGeometricas
{
    // Clase para representar un Círculo
    public class Circulo
    {
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    // Clase para representar un Cuadrado
    public class Cuadrado
    {
        private double lado;

        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        public double CalcularArea()
        {
            return Math.Pow(lado, 2);
        }

        public double CalcularPerimetro()
        {
            return 4 * lado;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear un círculo con radio 5
            Circulo circulo = new Circulo(5);
            Console.WriteLine($"Área del círculo: {circulo.CalcularArea()}");
            Console.WriteLine($"Perímetro del círculo: {circulo.CalcularPerimetro()}");

            // Crear un cuadrado con lado 4
            Cuadrado cuadrado = new Cuadrado(4);
            Console.WriteLine($"Área del cuadrado: {cuadrado.CalcularArea()}");
            Console.WriteLine($"Perímetro del cuadrado: {cuadrado.CalcularPerimetro()}");
        }
    }
}