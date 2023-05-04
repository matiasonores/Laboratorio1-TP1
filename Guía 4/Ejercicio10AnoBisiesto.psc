Proceso AnoBisiesto
	Definir ano Como Entero;
	Escribir 'Ingrese un año para saber si es bisiesto o no.';
	Leer ano;
	Si ano%100<>0 Entonces
		Si ano%4==0 Entonces
			Escribir 'Es un año bisiesto';
		SiNo
			Escribir 'No es un año bisiesto';
		FinSi
	SiNo
		Si ano%400==0 Entonces
			Escribir 'Es un año bisiesto';
		SiNo
			Escribir 'No es un año bisiesto';
		FinSi
	FinSi
FinProceso