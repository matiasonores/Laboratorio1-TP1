Proceso OrdenMenor
	
	Definir n, menor, pos como Entero;
	
	Escribir "Ingrese el primer n�mero";
	Leer n;
	menor=n;
	pos=1;
	
	Escribir "Ingrese el segundo n�mero";
	Leer n;
	
	Si n<menor Entonces
		menor=n;
		pos=2;
	FinSi;
	
	Escribir "Ingrese el tercer n�mero";
	Leer n;
	
	Si n<menor Entonces
		menor=n;
		pos=3;
	FinSi;
	Escribir "Ingrese el cuarto n�mero";
	Leer n;
	
	Si n<menor Entonces
		menor=n;
		pos=4;
	FinSi;
	Escribir "Ingrese el quinto n�mero";
	Leer n;
	
	Si n<menor Entonces
		menor=n;
		pos=5;
	FinSi;
	
	Escribir "El valor menor es:", menor,"y su n�mero de orden es:", pos;
FinProceso