using System;

namespace Ejercicio10
{
   class AnoBisiesto
   {
      static void Main(string[] args)
      {
         int ano;

         Console.WriteLine("Ingrese un año para saber si es bisiesto o no:");
         ano = Convert.ToInt32(Console.ReadLine());

         if(ano%100!=0)
         {
            if(ano%4==0)
               Console.WriteLine("Es un año bisiesto.");
            else
               Console.WriteLine("No es un año bisiesto.");
         }
         else
         {
            if(ano%400==0)
               Console.WriteLine("Es un año bisiesto.");
            else
               Console.WriteLine("No es un año bisiesto.");
         }

         Console.ReadKey();
      }
   }
}