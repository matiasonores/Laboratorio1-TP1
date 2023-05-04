Proceso Triangulo
	Definir segmento1,segmento2,segmento3 Como Real;
	Escribir 'Ingrese los tres segmentos:';
	Leer segmento1,segmento2,segmento3;
	Si segmento1>segmento2 Entonces
		Si segmento1>segmento3 Entonces
			Si segmento1<segmento2+segmento3 Entonces
				Escribir 'Puede formar un triangulo:';
			SiNo
				Escribir 'No puede formar un triangulo';
			FinSi
		FinSi
	FinSi
	Si segmento2>segmento1 Entonces
		Si segmento2>segmento3 Entonces
			Si segmento2<segmento1+segmento3 Entonces
				Escribir 'Puede formar un triangulo:';
			SiNo
				Escribir 'No puede formar un triangulo';
			FinSi
		FinSi
	FinSi
	Si segmento3>segmento2 Entonces
		Si segmento3>segmento1 Entonces
			Si segmento3<segmento2+segmento1 Entonces
				Escribir 'Puede formar un triangulo:';
			SiNo
				Escribir 'No puede formar un triangulo';
			FinSi
		FinSi
	FinSi
FinProceso