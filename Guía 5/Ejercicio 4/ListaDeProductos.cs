using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
   class ListaDeProductos
   {
      static void Main(string[] args)
      {
         int producto, cantidad, totalProductos;
         double costo, totalCosto, totalConIva;

         producto = 0;
         totalProductos = 0;
         totalCosto = 0;

         do
         {
            Console.WriteLine("Indique la cantidad del: "+ (producto+1) + "º producto. Ingrese \"0\" y \"0\" en el siguiente paso para salir.");
            cantidad = Convert.ToInt32(Console.ReadLine());
            totalProductos = totalProductos + cantidad;

            Console.WriteLine("Indique el valor del producto: ");
            costo = Convert.ToDouble(Console.ReadLine());
            totalCosto = totalCosto + (costo * cantidad);
         } while (cantidad!=0&&costo!=0);

         totalConIva = totalCosto * 1.21;

         Console.WriteLine("La cantidad total de productos es: {0}", totalProductos);
         Console.WriteLine("El valor total de los productos es: {0:C2}", totalCosto);
         Console.WriteLine("El monto total a pagar aplicando IVA es: {0:C2}", totalConIva);

         Console.ReadKey();
      }
   }
}
