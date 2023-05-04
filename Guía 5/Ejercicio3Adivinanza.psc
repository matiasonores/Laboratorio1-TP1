Proceso Adivinanza
	Definir puntaje, n, adivinar Como Entero;
	Definir bandera Como Logico;
	
	bandera= Verdadero;
	puntaje = 10;
	adivinar=Azar(10)+1;
	
	Mientras bandera = Verdadero Hacer
		Escribir "Ingrese un número del 1 al 10";
		Leer n;
		Si n==adivinar Entonces
			Escribir "¡Acertaste! Puntaje: ", puntaje;
			bandera=falso;
		Sino puntaje=puntaje-1;
		FinSi
		
		Si puntaje==0 Entonces
			Escribir "¡No te quedan intentos, perdiste!";
			bandera=falso;
		FinSi
	FinMientras
FinProceso