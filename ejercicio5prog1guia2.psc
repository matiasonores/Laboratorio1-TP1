Algoritmo Ejercicio_5
	definir Numero1,numero2,numero3,auxiliarNumero Como Real;
	definir NombreLibreta1,NombreLibreta2,NombreLibreta3,auxiliarLibreta Como Caracter;
	Escribir "Ingrese Nombre Libreta 1" ;
	leer NombreLibreta1;
	Escribir "Ingrese Numero libreta 1" ;
	leer Numero1;
	Escribir "Ingrese Nombre Libreta 2" ;
	leer NombreLibreta2;
	Escribir "Ingrese Numero libreta 2" ;
	leer Numero2;
	Escribir "Ingrese Nombre Libreta 3" ;
	leer NombreLibreta3;
	Escribir "Ingrese Numero libreta 3" ;
	leer Numero3;
	si (Numero1 < Numero2 y Numero1 < Numero3) Entonces
		
		si (Numero2 > Numero3) Entonces
			auxiliarNumero = Numero2;
			Numero2 = Numero3;
			Numero3 = auxiliarNumero;
			auxiliarLibreta = NombreLibreta2;
		    NombreLibreta2 = NombreLibreta3;
			NombreLibreta3 = NombreLibreta2;
		FinSi
	FinSi
	
	si (Numero2 < Numero1 y Numero2 < Numero3) Entonces
		auxiliarNumero = Numero1;
		Numero1 = Numero2;
		Numero2 = auxiliarNumero;
		
		auxiliarLibreta = NombreLibreta1;
		NombreLibreta1 = NombreLibreta2;
		NombreLibreta2 = auxiliarLibreta;
		si (Numero2 > Numero3) Entonces
			auxiliarNumero = Numero2;
			Numero2 = Numero3;
			Numero3 = auxiliarNumero;
			
			auxiliarLibreta = NombreLibreta2;
			NombreLibreta2 = NombreLibreta3;
			NombreLibreta3 = auxiliarLibreta;
		FinSi
	FinSi
	
	si (Numero3 < Numero1 y Numero3 < Numero2) Entonces
		auxiliarNumero=Numero1;
		Numero1 = Numero3;
		Numero3 = auxiliarNumero;
		
		auxiliarLibreta = NombreLibreta1;
		NombreLibreta1 = NombreLibreta3;
		NombreLibreta3 = auxiliarLibreta;
		si (Numero3 < Numero2) Entonces
			auxiliarNumero = Numero3;
			Numero3 = Numero2;
			Numero2 = auxiliarNumero;
			
			auxiliarLibreta = NombreLibreta3;
			NombreLibreta3 = NombreLibreta2;
			NombreLibreta2 = auxiliarLibreta;
		FinSi
	FinSi
	Escribir "Nombre Libreta:", NombreLibreta1 , " Numero :", Numero1 , " Nombre Libreta:", NombreLibreta2 ," Numero :", Numero2 , " NombreLibreta3 ", NombreLibreta3 ," Numero :" , Numero3 ;
FinAlgoritmo

