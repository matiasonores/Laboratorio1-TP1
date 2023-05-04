Proceso MenorMayorIndeterminado
Definir n,menor,mayor,contador Como Entero;
Para contador<-1 Hasta 10 Hacer
	Escribir 'Ingrese el ',contador,'º número';
	Leer n;
	Si contador==1 Entonces
		menor <- n;
		mayor <- n;
	SiNo
		Si n<menor Entonces
			menor <- n;
		FinSi
		Si n>mayor Entonces
			mayor <- n;
		FinSi
	FinSi
FinPara
Escribir 'Menor número: ',menor;
Escribir 'Mayor número: ',mayor;
FinProceso