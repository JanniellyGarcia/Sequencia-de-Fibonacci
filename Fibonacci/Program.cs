using System;

namespace Fibonacci
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("__________SEQUÊNCIA DE FIBONACCI__________\n");
            Console.WriteLine("Quantos números da sequência você deseja ver?");
            int indice = Int32.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("\n__________SEQUÊNCIA DE FIBONACCI__________\n");
            for (int i = 0; i < indice; i++)
            {
                Console.WriteLine(FibonacciReturn(i));
            }
        }


        public static int FibonacciReturn(int numero)
        {
            int valor1 = 0;
            int valor2 = 1;
              
            for (int i = 0; i < numero; i++)
            {
                int auxiliar = valor1;
                valor1 = valor2;
                valor2 = auxiliar + valor2;
            }
            return valor1;
        }

        
        
    }
}
