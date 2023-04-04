using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Secuencial1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe una palabra");

            string frase = Console.ReadLine().ToLower();
            int i = 0;
            int j = frase.Length - 1;
            bool esPalindromo = false;

            while( i < j)
            {
                if(frase[i] == frase[j])
                {
                    esPalindromo = true;
                    break;
                }

                i++;
                j--;
            }

            if (esPalindromo)
            {
                Console.WriteLine("Es un palindromo");
            } else
            {
                Console.WriteLine("No es un palindromo");
            }

        }
    }
}
