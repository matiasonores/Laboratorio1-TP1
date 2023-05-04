Proceso Figura
	Definir base,altura,area Como Entero;
	Escribir 'Ingrese la base y la altura de la figura.';
	Leer base,altura;
	area <- base*altura;
	Si base==altura Entonces
		Escribir 'La figura es un cuadrado y su área es: ',area;
	SiNo
		Si base>altura Entonces
			Escribir 'La figura es un rectangulo horizontal y su área es: ',area;
		SiNo
			Escribir 'La figura es un rectangulo vertical y su área es: ',area;
		FinSi
	FinSi
FinProceso