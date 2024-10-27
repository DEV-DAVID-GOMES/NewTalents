using System;
using NewCalculadora;

namespace NewCalculadoraApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            Console.WriteLine("Soma: " + calc.Somar(3, 2));
            Console.WriteLine("Subtração: " + calc.Subtrair(5, 2));
            Console.WriteLine("Multiplicação: " + calc.Multiplicar(3, 4));
            Console.WriteLine("Divisão: " + calc.Dividir(10, 2));

            Console.WriteLine("Histórico:");
            foreach (var item in calc.Historico())
            {
                Console.WriteLine(item);
            }
        }
    }
}
