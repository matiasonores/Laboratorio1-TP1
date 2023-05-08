using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//II.Problema 2.Baterías

//Una fábrica de baterías realiza testeo en sus líneas de producción. La fábrica ahora tiene 2 líneas de producción, pero se espera que
//se incorporen paulatinamente 2 líneas adicionales.

//Toda batería tiene un voltaje nominal esperado en vacío (sin conectar a nada) y si está por debajo de ese valor se considera fallada.
//Ejemplo una batería de 9 Volt debería superar los 10,3V en vacío para que se considere correcta. 

//Al iniciar cada línea se necesita conocer el valor en vacío de voltaje para las posteriores pruebas. En el ejemplo anterior sería 10,3 Volt,
//el valor de 9 Volt no tiene interés en este proceso.

//Al finalizar el ingreso de voltaje medido de cada batería se debe saber si se descarta o no y cuál fue su error en voltaje.
//Ese valor de aceptación/descarte se piensa luego enviar al mecanismo de la cinta transportadora para que expulse el producto fallado.

//Al finalizar el lote que ha realizado la línea de producción se debe informar el total de baterías no falladas.

//En el embarque, que incluiría el total de todas las líneas, se debe informar el total de baterías falladas. También
//se debe informar el número de batería que mayor error tiene (tener cuidado aquí, porque la numeración aquí es respecto a todo el embarque y no respecto al
//orden que se midió la batería)


namespace ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroBateria = 0,cantBateria = 0,cantBatFallada = 0,cantBatbuenEstado = 0, totalBateriaTodasLineas = 0, totalBateriasFalladaFinal = 0,
            numBateriaMayorError = 0;
            double valorASuperar = 10.3,voltaje,voltajeMenor = 99,VoltajeResta;

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Linea " + (i+1));
                    Console.WriteLine("Ingrese  Numero de Bateria");
                  numeroBateria = Convert.ToInt32(Console.ReadLine());

                while (numeroBateria != -1)
                {
                    Console.WriteLine("Ingrese Voltaje");
                    voltaje = Convert.ToDouble(Console.ReadLine());
                    if (voltaje < valorASuperar)
                    {
                        cantBatFallada++;
                    } else
                    {
                        cantBateria++;
                    }
                    VoltajeResta = voltaje - valorASuperar;
                    if (VoltajeResta < voltajeMenor)
                    {
                        voltajeMenor = VoltajeResta;
                        numBateriaMayorError = numeroBateria;
                    }
                    Console.WriteLine("Ingrese otro  Numero de Bateria para la Linea" + (i+1) + " Ingrese -1 para salir");
                    numeroBateria = Convert.ToInt32(Console.ReadLine());

                }
                Console.WriteLine("En la Linea " + (i + 1) + " hubo: "+ cantBatFallada +" de Baterias Falladas  y " + cantBateria  + " en buen estado");
                cantBatbuenEstado = cantBateria + cantBatbuenEstado;
                totalBateriasFalladaFinal = cantBatFallada + totalBateriasFalladaFinal;
                totalBateriaTodasLineas += cantBatbuenEstado + totalBateriasFalladaFinal;
                cantBatFallada = 0;
                cantBateria = 0;
            }
            Console.WriteLine("El Numero de Bateria con MAYOR Error fue: "+ numBateriaMayorError + " con una diferencia de voltaje de: " + Math.Abs(voltajeMenor) + "'v'");
            Console.ReadKey();



        }
    }
}
