using System;

namespace Ejercicio07
{
   class MayorValor
   {
      static void Main(string[] args)
      {
         int valor, mayor;

         Console.WriteLine("Ingrese primero valor.");
         valor = Convert.ToInt32(Console.ReadLine());
         mayor = valor;

         Console.WriteLine("Ingrese segundo valor.");
         valor = Convert.ToInt32(Console.ReadLine());
         if (valor > mayor)
            mayor = valor;

         Console.WriteLine("Ingrese tercer valor.");
         valor = Convert.ToInt32(Console.ReadLine());
         if (valor > mayor)
            mayor = valor;

         Console.WriteLine("Ingrese cuarto valor.");
         valor = Convert.ToInt32(Console.ReadLine());
         if (valor > mayor)
            mayor = valor;

         Console.WriteLine("Ingrese quinto valor.");
         valor = Convert.ToInt32(Console.ReadLine());
         if (valor > mayor)
            mayor = valor;

         Console.WriteLine("El mayor valor es: {0}", mayor);

         Console.ReadKey();
      }
   }
}
