using System;

namespace Ejercicio13
{
   class RuletaAleatoria
   {
      static void Main(string[] args)
      {
         int num;
         string mitad, docena, columna;
         Random random = new Random();

         num = random.Next(1,37);
         Console.WriteLine("El resultado es: {0}", num);
                  
            if (num != 0)//Verifica si no ganó la banca
            {
               if (num > 18)//Verifica Mayor o Menor
                  mitad = "Mayor";
               else
                  mitad = "Menor";

               if (num > 24)//Verifica Docena
                  docena = "Tercer";
               else
               {
                  if (num > 12)
                     docena = "Segunda";
                  else
                     docena = "Primer";
               }

               if (num % 3 == 0)//Verifica Columna
                  columna = "Tercer";
               else
               {
                  if ((num + 1) % 3 == 0)
                     columna = "Segunda";
                  else
                     columna = "Primer";
               }
               Console.WriteLine("El número es: {0}\nEsta en la: {1} docena y en la {2} columna.", mitad, docena, columna);
            }
            else
               Console.WriteLine("Ganó la banca.");
         
         Console.ReadKey();
      }
   }
}
