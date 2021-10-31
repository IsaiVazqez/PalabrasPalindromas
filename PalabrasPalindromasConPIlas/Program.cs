using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PalabrasPalindromasConPIlas
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            string reverse = string.Empty;

            System.Console.WriteLine("\nIngresa la palabra\n");
            palabra = Console.ReadLine();

            Stack pila = new Stack();

            foreach (var c in palabra.ToArray())
                pila.Push(c);

            while (pila.Count > 0)
                reverse += pila.Pop();

            if (reverse.Equals(palabra))
                Console.WriteLine("Es palindromo");
            else
                Console.WriteLine("No es ....");

            Console.ReadKey();

        }
    }
}
