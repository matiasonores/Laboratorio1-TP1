using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
   class Adivinanza
   {
      static void Main(string[] args)
      {
         int puntaje, n, adivinar;
         bool bandera;
         Random random = new Random();

         bandera = true;
         puntaje = 10;
         adivinar = random.Next(1, 11);

         while (bandera)
         {
            Console.WriteLine("Tienes: "+ puntaje + " intentos restantes.");
            Console.WriteLine("Ingrese un número del 1 al 10");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == adivinar)
            {
               Console.WriteLine("¡Acertaste! Puntaje: " + puntaje);
               bandera = false;
            }
            else puntaje--;

            if (puntaje==0)
            { 
               Console.WriteLine("¡No te quedan intentos, perdiste!");
               bandera = false;
            }
         }
         Console.ReadKey();
      }
   }
}
