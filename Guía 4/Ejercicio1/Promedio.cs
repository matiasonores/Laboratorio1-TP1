using System;

namespace Ejercicio01
{
   class Program
   {
      static void Main(string[] args)
      {
         double n1, n2, n3, promedio, condicion;

         Console.WriteLine("Ingrese la nota de los parciales:");
         n1 = Convert.ToDouble(Console.ReadLine());
         n2 = Convert.ToDouble(Console.ReadLine());
         n3 = Convert.ToDouble(Console.ReadLine());

         promedio = (n1 + n2 + n3) / 3;

         Console.WriteLine("Ingrese la condición de promoción:");
         condicion = Convert.ToDouble(Console.ReadLine());

         if (promedio>condicion)
            Console.WriteLine("Alumno promocionó.");
         else
         {
            Console.WriteLine("Alumno rinde final.");
         }
         Console.ReadKey();
      }
   }
}
