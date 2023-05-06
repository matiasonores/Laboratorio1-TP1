using System;

namespace Ejercicio08
{
   class OrdenMenor
   {
      static void Main(string[] args)
      {
         int n, menor, pos;

         Console.WriteLine("Ingrese el primer número");
         n = Convert.ToInt32(Console.ReadLine());
         menor = n;
         pos = 1;

         Console.WriteLine("Ingrese el segundo número");
         n = Convert.ToInt32(Console.ReadLine());

         if(n<menor)
         {
            menor = n;
            pos = 2;
         }

         Console.WriteLine("Ingrese el tercer número");
         n = Convert.ToInt32(Console.ReadLine());

         if (n < menor)
         {
            menor = n;
            pos = 3;
         }

         Console.WriteLine("Ingrese el cuarto número");
         n = Convert.ToInt32(Console.ReadLine());

         if (n < menor)
         {
            menor = n;
            pos = 4;
         }
         Console.WriteLine("Ingrese el quinto número");
         n = Convert.ToInt32(Console.ReadLine());

         if (n < menor)
         {
            menor = n;
            pos = 5;
         }

         Console.WriteLine("El valor menor es: {0} y su número de orden es {1}",menor, pos);
         Console.ReadKey();
      }
   }
}