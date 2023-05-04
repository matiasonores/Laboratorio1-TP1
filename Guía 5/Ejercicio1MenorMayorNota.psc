Proceso MenorMayorNota
	Definir nota,menor,mayor,contador Como Entero;
	menor <- 11;
	mayor <- -1;
	Para contador<-1 Hasta 10 Hacer
		Escribir 'Ingrese la ',contador,'º nota (de 0 a 10)';
		Leer nota;
		Si nota<menor Entonces
			menor <- nota;
		FinSi
		Si nota>mayor Entonces
			mayor <- nota;
		FinSi
	FinPara
	Escribir 'La menor nota fue: ',menor;
	Escribir 'La mayor nota fue: ',mayor;
FinProceso