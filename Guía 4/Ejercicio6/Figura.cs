using System;

namespace Ejercicio06
{
   class Figura
   {
      static void Main(string[] args)
      {
         int b, h, area;

         Console.WriteLine("Ingrese la base y la altura de la figura:");
         b = Convert.ToInt32(Console.ReadLine());
         h = Convert.ToInt32(Console.ReadLine());

         area = b * h;

         if(b==h)
            Console.WriteLine("La figura es un cuadrado y su área es: {0}", area);
         else
         {
            if(b>h)
               Console.WriteLine("La figura es un réctangulo horizontal y su área es: {0}", area);
            else
               Console.WriteLine("La figura es un réctangulo vertical y su área es: {0}", area);
         }
         Console.ReadKey();
      }
   }
}
