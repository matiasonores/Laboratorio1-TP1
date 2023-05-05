using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
   class MenorMayorIndeterminado
   {
      static void Main(string[] args)
      {
         int n, menor, mayor;
         menor = 0;
         mayor = 0;

         for (int contador = 1; contador < 11; contador++)
         {
            Console.WriteLine("Ingrese el " + contador + "º número.");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 1)
            {   menor = n;
               mayor = n;
                }
            else { 
            if (n < menor)
                  menor = n;

               if (n > mayor)
                  mayor = n;
            }
         }
         Console.WriteLine("Menor número: " + menor);
         Console.WriteLine("Mayor número: " + mayor);

         Console.ReadKey();
      }
   }
}
