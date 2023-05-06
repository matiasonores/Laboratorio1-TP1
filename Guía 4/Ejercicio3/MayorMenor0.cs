using System;

namespace Ejercicio03
{
   class MayorMenor0
   {
      static void Main(string[] args)
      {
         double num;
         Console.WriteLine("Ingrese un número:");
         num = Convert.ToDouble(Console.ReadLine());

         if (num != 0)
         {
            if(num>0)
               Console.WriteLine("El número es mayor a 0.");
            else
               Console.WriteLine("El número es menor a 0.");
         }
         else
            Console.WriteLine("El número es 0.");

         Console.ReadKey();
      }
   }
}
