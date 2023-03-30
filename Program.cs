using System;

namespace Ejercicio3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar cuatro números y 
            // luego mostrar por pantalla cuáles son mayores a 100.

            int A, B, C, D;
            
            Console.WriteLine("Introduzca el 1º numero");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el 2º numero");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el 3º numero");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el ultimo numero");
            D = int.Parse(Console.ReadLine());
            
            if (A > 100)
                Console.WriteLine("El 1º numero " + A + " es mayor a 100.");           
            if (B > 100)
                Console.WriteLine("El 2º numero " + B + " es mayor a 100.");            
            if (C > 100)
                Console.WriteLine("El 3º numero " + C + " es mayor a 100.");            
            if (D > 100)
                Console.WriteLine("El ultimo numero " + D + " es mayor a 100.");

            Console.WriteLine("Fin del programa");
        }
    }
}
