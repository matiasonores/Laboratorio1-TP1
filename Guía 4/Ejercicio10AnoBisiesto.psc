Proceso AnoBisiesto
	Definir ano Como Entero;
	Escribir 'Ingrese un a�o para saber si es bisiesto o no.';
	Leer ano;
	Si ano%100<>0 Entonces
		Si ano%4==0 Entonces
			Escribir 'Es un a�o bisiesto';
		SiNo
			Escribir 'No es un a�o bisiesto';
		FinSi
	SiNo
		Si ano%400==0 Entonces
			Escribir 'Es un a�o bisiesto';
		SiNo
			Escribir 'No es un a�o bisiesto';
		FinSi
	FinSi
FinProceso