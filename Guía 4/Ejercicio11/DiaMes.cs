using System;

namespace Ejercicio11
{
   class DiaMes
   {
      static void Main(string[] args)
      {
         int num;

         Console.WriteLine("Ingrese un número del 1 al 12 para mostrar el mes y la cantidad de días.");
         num = Convert.ToInt32(Console.ReadLine());

         switch (num)
         {
            case 1:
               Console.WriteLine("El mes de Enero tiene 31 días.");
               break;
            case 2:
               Console.WriteLine("No se cuenta con la información necesaria para dar la respuesta correspondiente al mes de Febrero.");
               break;
            case 3:
               Console.WriteLine("El mes de Marzo tiene 31 días.");
               break;
            case 4:
               Console.WriteLine("El mes de Abril tiene 30 días.");
               break;
            case 5:
               Console.WriteLine("El mes de Mayo tiene 31 días.");
               break;
            case 6:
               Console.WriteLine("El mes de Junio tiene 30 días.");
               break;
            case 7:
               Console.WriteLine("El mes de Julio tiene 31 días.");
               break;
            case 8:
               Console.WriteLine("El mes de Agosto tiene 31 días.");
               break;
            case 9:
               Console.WriteLine("El mes de Septiembre tiene 30 días.");
               break;
            case 10:
               Console.WriteLine("El mes de Octubre tiene 31 días.");
               break;
            case 11:
               Console.WriteLine("El mes de Noviembre tiene 30 días.");
               break;
            case 12:
               Console.WriteLine("El mes de Diciembre tiene 31 días.");
               break;
            default:
               Console.WriteLine("No ingresó un número válido.");
               break;
         }
         Console.ReadKey();
      }
   }
}