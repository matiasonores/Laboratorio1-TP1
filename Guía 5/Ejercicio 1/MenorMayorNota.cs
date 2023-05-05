using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
   class MenorMayorNota
   {
      static void Main(string[] args)
      {
         int nota, menor, mayor;
         menor = 11;
         mayor = -1;

         for (int contador = 1; contador < 11; contador++)
         {
            Console.WriteLine("Ingrese la " + contador + "º nota (de 0 a 10)");
            nota = Convert.ToInt32(Console.ReadLine());

            if (nota < menor)
               menor = nota;

            if (nota > mayor)
               mayor = nota;

         }

         Console.WriteLine("La menor nota fue: " + menor);
         Console.WriteLine("La mayor nota fue: " + mayor);

         Console.ReadKey();
      }
   }
}
