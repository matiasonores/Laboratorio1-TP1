using System;

namespace Ejercicio05
{
   class NumeroLibreta
   {
      static void Main(string[] args)
      {
         double numero1, numero2, numero3, auxiliarNumero;
         string nombreLibreta1, nombreLibreta2, nombreLibreta3, auxiliarLibreta;

         Console.WriteLine("Ingrese Nombre libreta Nº1:");
         nombreLibreta1 = Console.ReadLine();
         Console.WriteLine("Ingrese Nombre libreta Nº2:");
         nombreLibreta2 = Console.ReadLine();
         Console.WriteLine("Ingrese Nombre libreta Nº3:");
         nombreLibreta3 = Console.ReadLine();

         Console.WriteLine("Ingrese número libreta 1:");
         numero1 = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Ingrese número libreta 2:");
         numero2 = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Ingrese número libreta 3:");
         numero3 = Convert.ToDouble(Console.ReadLine());

         if(numero1<numero2 && numero1<numero3)
         {
            if(numero2<numero3)
            {
               auxiliarNumero = numero2;
               numero2 = numero3;
               numero3 = auxiliarNumero;

               auxiliarLibreta = nombreLibreta2;
               nombreLibreta2 = nombreLibreta3;
               nombreLibreta3 = nombreLibreta2;
            }
         }

         if(numero2<numero1 && numero2<numero3)
         {
            auxiliarNumero = numero1;
            numero1 = numero2;
            numero2 = auxiliarNumero;

            auxiliarLibreta = nombreLibreta1;
            nombreLibreta1 = nombreLibreta2;
            nombreLibreta2 = auxiliarLibreta;

            if(numero2>numero3)
               {
               auxiliarNumero = numero2;
               numero2 = numero3;
               numero3 = auxiliarNumero;

               auxiliarLibreta = nombreLibreta2;
               nombreLibreta2 = nombreLibreta3;
               nombreLibreta3 = auxiliarLibreta;
            }
         }

         if(numero3<numero1 && numero3<numero2)
         {
            auxiliarNumero = numero1;
            numero1 = numero3;
            numero3 = auxiliarNumero;

            auxiliarLibreta = nombreLibreta1;
            nombreLibreta1 = nombreLibreta3;
            nombreLibreta3 = auxiliarLibreta;

            if(numero3<numero2)
            {
               auxiliarNumero = numero3;
               numero3 = numero2;
               numero2 = auxiliarNumero;

               auxiliarLibreta = nombreLibreta3;
               nombreLibreta3 = nombreLibreta2;
               nombreLibreta2 = auxiliarLibreta;
            }
         }

         Console.WriteLine("Nombre libreta nº1: {0} \nNº Libreta: {1}",nombreLibreta1,numero1);
         Console.WriteLine("Nombre libreta nº2: {0} \nNº Libreta: {1}", nombreLibreta2, numero2);
         Console.WriteLine("Nombre libreta nº3: {0} \nNº Libreta: {1}", nombreLibreta3, numero3);

         Console.ReadKey();
      }
   }
}
