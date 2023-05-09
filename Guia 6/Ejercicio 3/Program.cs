using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    //    III. Problema 3. Votación!

    //La junta electoral de la provincia va a requerir procesar los resultados electorales de los comicios próximos de todas
    //localidades de la provincia, cada localidad tiene varias mesas de votación y de cada una de estas mesas se van a elaborar
    //actas de cierre de comicios que tendrán tres resultados correspondiente a cada uno de los candidatos concursantes.

    //Cuando se disponen de las actas estas se envían de inmediato a la junta electoral para su procesamiento.La cantidad de
    //localidades es fija, ahora hay 25 localidades.
    //En cuanto a la cantidad de mesas por localidad es también fija, pero diferente en cada una.

    //Iniciado el comicio, en ese momento, se cuentan con los números de localidades, y luego cuando llegan las actas se conoce
    //cuántas son. 

    //Se requiere primero, por cada acta ingresada, informar los resultados de mayor a menor de los votos, indicando el ganador
    //y la cantidad de votos totales.Esto sirve para que el data entry pueda verificar en el momento de carga. 

    //Luego, una vez ingresada todas las actas de cada localidad, por cada localidad informar en orden los resultados, indicando
    //el ganador de la localidad e indicar la cantidad de votos en total.
    //Finalmente, generar el mismo informe que se realizó a nivel localidad pero ahora para todo el conjunto de localidades.
    //Informe también que localidad tuvo el mayor índice de votación  y su porcentaje correspondiente ().

    //En cuantos a los candidatos se debe ingresar el nombre de cada uno y también el nombre de las localidades. 
    //() Sería buscar la localidad con mayor cantidad de votos, cuando llegan al final del ciclo de localidades tener
    //contabilizados el total de votos de todas las localidades para poder calcular el porcentaje de esa localidad con
    //mayor cantidad de votos (votos mayor localidad/total de votos*100) y lo que deben informar es el nombre de la
    //localidad y su porcentaje calculado.
    //Si toman ese ejemplo, Figura 1, que es a nivel nacional, imprimiría algo como:
    //Localidad con mayor índice de votación: Buenos Aires(37% del electorado).

    //ENTRADA:
    //NOMBRE DE CADA CANDIDATO
    //NOMBRE DE CADA LOCALIDAD --> Tiene X Mesas ---> 1 Acta con 3 Resultados de cada Candidato



    //SALIDA:
    //CANTIDAD DE ACTAS
    // Quien salio 1ro 2do o 3ro por cada Acta   ---> Cantidad de votos totales x acta  ////////// RESUELTO
    // Mostrar Quien Gano por Localidad ---> Cantidad de Votos en total  ////////// RESUELTO
    // Mostrar Quien Gano por Todas las  Localidades ---> Cantidad de Votos en total en todas las localidades /////// Resuelto
    // Mostrar Que localidad tuvo mayor índice de votación y su Porcentaje


    internal class Program
    {
        static void Main(string[] args)
        {
            double porcentaje;
            string candidato1, candidato2, candidato3,ganadorEnTodasLocalidades, candidatoMayorLocalidad = "",localidadMayor = "";
            int votosMayor = 0,votoMayorLocalidad = 0,cantVotoPorLocalidad = 0,cantVotosProvinciaTotal, cantVotosCandidato1Final = 0, cantVotosCandidato2Final = 0, cantVotosCandidato3Final = 0, cantVotosTotales;
            Console.WriteLine("Ingrese Nombre Candidato 1:");
            candidato1 = Console.ReadLine();
            Console.WriteLine("Ingrese Nombre Candidato 2:");
            candidato2 = Console.ReadLine();
            Console.WriteLine("Ingrese Nombre Candidato 3:");
            candidato3 = Console.ReadLine();
          
            // Localidades
            for (int i =0; i< 2; i=i+1)
            {
                Console.WriteLine("Ingrese el Nombre de la Localidad");
                string localidad = Console.ReadLine();
                Console.WriteLine("Ingrese Cantidad de mesas para la localidad: "+ localidad);
                int cantMesas = Convert.ToInt32(Console.ReadLine());
                int votosLocalidadCandidat1 = 0, votosLocalidadCandidat2 = 0, votosLocalidadCandidat3 = 0;
                // MESAS
                for (int j = 0; j < cantMesas; j = j + 1)
                {
                    
                    string primero, segundo, tercero;
                    Console.WriteLine("Ingrese Cantidad de Votos de  " + candidato1 + ":" );
                   int votosCandidato1 = Convert.ToInt32(Console.ReadLine());
                    votosLocalidadCandidat1 += votosCandidato1;
                    Console.WriteLine("Ingrese Cantidad de Votos de  " + candidato2 + ":");
                    int votosCandidato2 = Convert.ToInt32(Console.ReadLine());
                    votosLocalidadCandidat2 += votosCandidato2;
                    Console.WriteLine("Ingrese Cantidad de Votos de  " + candidato3 + ":");
                    int votosCandidato3 = Convert.ToInt32(Console.ReadLine());
                    votosLocalidadCandidat3 += votosCandidato3;

                    int totalporActa = votosCandidato1 + votosCandidato2 + votosCandidato3;
                    if (votosMayor == 0)
                    {
                        votosMayor = votosCandidato1;
                    }
                    if (votosCandidato1 > votosCandidato2 && votosCandidato1 > votosCandidato3)
                    {
                        primero = candidato1;
                        if (votosCandidato2 > votosCandidato3)
                        {
                            segundo = candidato2;
                            tercero = candidato3;
                        }  else
                        {
                            segundo = candidato3;
                            tercero = candidato2;
                        }
                    } else if (votosCandidato2 > votosCandidato1 && votosCandidato2 > votosCandidato3)
                    {
                        primero = candidato2;
                        if (votosCandidato1 > votosCandidato3)
                        {
                            segundo = candidato1;
                            tercero = candidato3;
                        }
                        else
                        {
                            segundo = candidato3;
                            tercero = candidato1;
                        }
                    } else
                    {
                        primero = candidato3;
                        if (votosCandidato2 > votosCandidato1)
                        {
                            segundo = candidato2;
                            tercero = candidato1;
                        }
                        else
                        {
                            segundo = candidato1;
                            tercero = candidato2;
                        }
                    }
                    Console.WriteLine("El primer candidato de esta acta es: {0}, el segundo candidato es: {1}, el tercer candidato es: {2}", primero, segundo, tercero);
                    Console.WriteLine("La suma total de votos en este acta es de: {0} ", totalporActa);
                    cantVotoPorLocalidad = totalporActa + cantVotoPorLocalidad;

                }
                if (votosLocalidadCandidat1 > votosLocalidadCandidat2 && votosLocalidadCandidat1 > votosLocalidadCandidat3)
                {
                    Console.WriteLine("El Cantidato en la localidad de: {0} es {1}", localidad, candidato1);
                } else if (votosLocalidadCandidat2 > votosLocalidadCandidat3 && votosLocalidadCandidat2 > votosLocalidadCandidat1)
                {
                    Console.WriteLine("El Cantidato en la localidad de: {0} es {1}", localidad, candidato2);
                } else
                {
                    Console.WriteLine("El Cantidato en la localidad de: {0} es {1}", localidad, candidato3);
                }
                Console.WriteLine("La Cantidad de votos en la localidad de {0} fue de: {1}", localidad, cantVotoPorLocalidad);
                cantVotosCandidato1Final += votosLocalidadCandidat1;
                cantVotosCandidato2Final += votosLocalidadCandidat2;
                cantVotosCandidato3Final += votosLocalidadCandidat3;
                if (votoMayorLocalidad < cantVotoPorLocalidad)
                {
                    votoMayorLocalidad = cantVotoPorLocalidad;
                    localidadMayor = localidad;
                }
                cantVotoPorLocalidad = 0;
            }
            if (cantVotosCandidato1Final > cantVotosCandidato2Final && cantVotosCandidato1Final > cantVotosCandidato3Final)
            {
                Console.WriteLine("El Cantidato Ganador es: {0}",candidato1);
            }
            else if (cantVotosCandidato2Final > cantVotosCandidato3Final && cantVotosCandidato2Final > cantVotosCandidato1Final)
            {
                Console.WriteLine("El Cantidato Ganador es: {0}", candidato2);
            }
            else
            {
                Console.WriteLine("El Cantidato Ganador es: {0}", candidato3);
            }
            cantVotosTotales = cantVotosCandidato1Final + cantVotosCandidato2Final + cantVotosCandidato3Final;
            Console.WriteLine("El total de votos fue de: {0}", cantVotosTotales);
            porcentaje = (Convert.ToDouble(votoMayorLocalidad) / Convert.ToDouble(cantVotosTotales) * 100.0);
            Console.WriteLine("La localidad con mas votos fue: {0} con un porcentaje de: {1:F2}% ", localidadMayor, porcentaje);
            Console.ReadKey();


        }
    }
}
