using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia6Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantViajes, menores, nroPasaje, edad, nroPasajeMenor, edadMenor; 
            double recaudacionTotal, totalViaje, ticket, desc, totalTicket;

            Console.WriteLine("Ingrese la cantidad de viajes del día");
            cantViajes = Convert.ToInt32(Console.ReadLine());
            recaudacionTotal = 0;

            for (int n = 1; n <= cantViajes; n++)
            {
                menores = 0;
                totalViaje = 0;
                nroPasaje = 0;
                nroPasajeMenor = 0;
            edadMenor = 0;

                Console.WriteLine("Ingresar edad");
                edad= Convert.ToInt32(Console.ReadLine());

                

                while (edad > 0)
                {
                    nroPasaje++;
                        if (nroPasajeMenor == 0)
                    { nroPasajeMenor = nroPasaje;
                  edadMenor = edad;
                   }
                  
               else
                        if(edad < edadMenor)
                    {
                        edadMenor = edad;
                        nroPasajeMenor = nroPasaje;
                  }
                   
                    ticket = 3.0;
                    desc = 0;

                    if (edad < 12)
                    {
                        menores++;
                        desc = ticket / 2;
                    }
                    totalTicket = ticket - desc;

                    Console.WriteLine("Valor Ticket: {0}", ticket);
                    Console.WriteLine("Descuento: {0}",desc);
                    Console.WriteLine("Total Ticket: {0}", totalTicket);

                    totalViaje = totalViaje + totalTicket;

                    Console.WriteLine("Ingrese la edad del siguiente: (0: para finalizar viaje)");
                    edad = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Recaudacion viaje: ${0}", totalViaje);
                
                recaudacionTotal = recaudacionTotal + totalViaje;


                if (nroPasaje > 0)
                {
                    Console.WriteLine("Número de Pasaje de menor edad: {0} (edad: {1})", nroPasajeMenor , edadMenor);
                }
                else
                {
                    Console.WriteLine("No hubo pasaje menor");
                }
                Console.WriteLine(" Cantidad de menores: {0}", menores);
            }
            Console.WriteLine("Final del día");
            Console.WriteLine(" Recaudación del día: ${0}", recaudacionTotal);

            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }
    }
}
