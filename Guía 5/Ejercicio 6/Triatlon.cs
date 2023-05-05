using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
   class Triatlon
   {
      static void Main(string[] args)
      {
         int competidor, natacionM, natacionS, totalNatacion, ciclismoM, ciclismoS, totalCiclismo, pedestrismoM, pedestrismoS, totalPedestrismo, tiempoTotal, mejorN, mejorC, mejorP, competidores, tiempoGanador, ganador;

         mejorN = 0;
         mejorC = 0;
         mejorP = 0;
         tiempoGanador = 0;
         competidores = 0;
         ganador = 0;

         Console.WriteLine("Ingrese un número de competidor o -1 para salir.");
         competidor = Convert.ToInt32(Console.ReadLine());

         while(competidor!=-1)
         {
            competidores++;
            Console.WriteLine("Ingrese la cantidad de minutos en el tramo de natación:");
            natacionM = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de segundos en el tramo de natación:");
            natacionS = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de minutos en el tramo de ciclismo:");
            ciclismoM = Convert.ToInt32(Console.ReadLine());                 
            Console.WriteLine("Ingrese la cantidad de segundos en el tramo de ciclismo:");
            ciclismoS = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de minutos en el tramo de pedestrismo:");
            pedestrismoM = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de segundos en el tramo de pedestrismo:");
            pedestrismoS = Convert.ToInt32(Console.ReadLine());

            totalNatacion = (natacionM * 60) + natacionS;
            totalCiclismo = (ciclismoM * 60) + ciclismoS;
            totalPedestrismo = (pedestrismoM * 60) + pedestrismoS;

            tiempoTotal = totalNatacion + totalCiclismo + totalPedestrismo;

            if (totalNatacion > mejorN)
               mejorN = totalNatacion;

            if (totalNatacion > mejorC)
               mejorC = totalCiclismo;

            if (totalNatacion > mejorP)
               mejorP = totalPedestrismo;

            if(tiempoTotal>tiempoGanador)
            {
               tiempoGanador = tiempoTotal;
               ganador = competidor;
            }

            Console.WriteLine("Ingrese un número de competidor o -1 para salir.");
            competidor = Convert.ToInt32(Console.ReadLine());
         }

         Console.WriteLine("Mejor tiempo natación: {0} minutos {1} segundos", (mejorN/60), (mejorN%60));
         Console.WriteLine("Mejor tiempo ciclismo: {0} minutos {1} segundos", (mejorC / 60), (mejorC % 60));
         Console.WriteLine("Mejor tiempo pedestrismo: {0} minutos {1} segundos", (mejorP / 60), (mejorP % 60));

         Console.WriteLine("Total de competidores: {0}", competidores);

         Console.WriteLine("Mejor tiempo: {0} minutos {1} segundos", (tiempoGanador/60),(tiempoGanador%60));
         Console.WriteLine("Ganador: Competidor Nº: {0}", ganador);

         Console.ReadKey();
      }
   }
}
