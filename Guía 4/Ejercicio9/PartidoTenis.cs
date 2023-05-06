using System;

namespace Ejercicio09
{
   class PartidoTenis
   {
      static void Main(string[] args)
      {
         string jug1, jug2, ganador;
         int puntos1, puntos2, set1, set2;

         set1 = 0;
         set2 = 0;

         Console.WriteLine("Ingrese el nombre del jugador 1:");
         jug1 = Console.ReadLine();
         Console.WriteLine("Ingrese el nombre del jugador 2:");
         jug2 = Console.ReadLine();

         Console.WriteLine("Set 1. Ingrese los puntos del jugador 1:");
         puntos1 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Set 1. Ingrese los puntos del jugador 2:");
         puntos2 = Convert.ToInt32(Console.ReadLine());

         if(puntos1!=puntos2)
         {
            if (puntos1 > puntos2)
            {
               set1++;
               Console.WriteLine("Resultados Set 1. {0}: {1}, {2}: {3}", jug1, puntos1, jug2, puntos2);
            }
            else
            {
               set2++;
               Console.WriteLine("Resultados Set 1. {0}: {1}, {2}: {3}", jug1, puntos1, jug2, puntos2);
            }
         }
         else
            Console.WriteLine("Resultado Set 1. Empate.");

         Console.WriteLine("Set 2. Ingrese los puntos del jugador 1:");
         puntos1 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Set 2. Ingrese los puntos del jugador 2:");
         puntos2 = Convert.ToInt32(Console.ReadLine());

         if (puntos1 != puntos2)
         {
            if (puntos1 > puntos2)
            {
               set1++;
               Console.WriteLine("Resultados Set 2. {0}: {1}, {2}: {3}", jug1, puntos1, jug2, puntos2);
            }
            else
            {
               set2++;
               Console.WriteLine("Resultados Set 2. {0}: {1}, {2}: {3}", jug1, puntos1, jug2, puntos2);
            }
         }
         else
            Console.WriteLine("Resultado Set 2. Empate.");

         Console.WriteLine("Set 3. Ingrese los puntos del jugador 1:");
         puntos1 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Set 3. Ingrese los puntos del jugador 2:");
         puntos2 = Convert.ToInt32(Console.ReadLine());

         if (puntos1 != puntos2)
         {
            if (puntos1 > puntos2)
            {
               set1++;
               Console.WriteLine("Resultados Set 3. {0}: {1}, {2}: {3}", jug1, puntos1, jug2, puntos2);
            }
            else
            {
               set2++;
               Console.WriteLine("Resultados Set 3. {0}: {1}, {2}: {3}", jug1, puntos1, jug2, puntos2);
            }
         }
         else
            Console.WriteLine("Resultado Set 3. Empate.");

         if(set1!=set2)
         {
            if(set1>set2)
            {
               ganador = jug1;
               Console.WriteLine("El ganador es: {0}", jug1);
            }
            else
            {
               ganador = jug2;
               Console.WriteLine("El ganador es: {0}", jug2);
            }
         }
         else
            Console.WriteLine("¡Empate! Todos ganaron :)");

         Console.ReadKey();
      }
   }
}
