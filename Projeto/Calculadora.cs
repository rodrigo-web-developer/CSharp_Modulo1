using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Calculadora
    {
        public Calculadora()
        {
            Console.WriteLine("Inicializando a calculadora");
        }

        public static double Somar(double x, double y)
        {
            return x + y;
        }
        public static double Subtrair(double x, double y = 0)
        {
            return x - y;
        }

        public static double Somar(params double[] valores)
        {
            var soma = 0.0;
            foreach (var v in valores)
            {
                soma += v;
            }
            return soma;
        }

        public static void Alertar(double x)
        {
            Console.WriteLine("O valor de x é: "+x);
        }
    }

}
