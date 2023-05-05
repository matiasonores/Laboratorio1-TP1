using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
   class MedicionLluvia
   {
      static void Main(string[] args)
      {
         double medicion, promedio, mayor, totalMedicion;
         int contador=0;

         totalMedicion = 0;
         mayor = -1;
         promedio = 0;

         Console.WriteLine("Ingrese la primer medición en mm o \"-1\" para salir");
         medicion = Convert.ToDouble(Console.ReadLine());
         
         while(medicion!=-1)
         {
            contador++;
            totalMedicion += medicion;

            if (medicion > mayor)
               mayor = medicion;

            Console.WriteLine("Ingrese otra medición en mm o \"-1 \" para salir.");
            medicion = Convert.ToDouble(Console.ReadLine());
         }
            promedio = totalMedicion / 30;

            if (promedio==0)
               Console.WriteLine("No se registraron mediciones.");

            else
            {
               Console.WriteLine("Cantidad de mediciones registradas: {0}", contador);
               Console.WriteLine("Mayor medición registrada: {0} mm", mayor);
               Console.WriteLine("Promedio mensual: {0:F2} mm", promedio);
            }
         Console.ReadKey();
      }
   }
}
