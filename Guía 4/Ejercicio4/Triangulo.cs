using System;

namespace Ejercicio04
{
   class Triangulo
   {
      static void Main(string[] args)
      {
         double segmento1, segmento2, segmento3;

         Console.WriteLine("Ingrese los tres segmentos:");

         segmento1 = Convert.ToDouble(Console.ReadLine());
         segmento2 = Convert.ToDouble(Console.ReadLine());
         segmento3 = Convert.ToDouble(Console.ReadLine());

         if(segmento1>segmento2)
         { if(segmento1>segmento3)
            { if(segmento1<segmento2+segmento3)
                  Console.WriteLine("Puede formar un triangulo.");
            else
                  Console.WriteLine("No puede formar un triangulo.");
            }
         }

         if (segmento2 > segmento1)
         {
            if (segmento2 > segmento3)
            {
               if (segmento2 < segmento1 + segmento3)
                  Console.WriteLine("Puede formar un triangulo.");
               else
                  Console.WriteLine("No puede formar un triangulo.");
            }
         }

         if (segmento3 > segmento1)
         {
            if (segmento3 > segmento2)
            {
               if (segmento3 < segmento1 + segmento2)
                  Console.WriteLine("Puede formar un triangulo.");
               else
                  Console.WriteLine("No puede formar un triangulo.");
            }
         }

         Console.ReadKey();
      }
   }
}
