using System;

namespace Ejercicio02
{
   class ParImpar
   {
      static void Main(string[] args)
      {
         int x;
         Console.WriteLine("Ingrese un número:");
         x = Convert.ToInt32(Console.ReadLine());

         if(x%2==0)
            Console.WriteLine("Número par.");
         else Console.WriteLine("Número impar.");

         Console.ReadKey();
      }    
   }
}
