Proceso OrdenMenor
	
	Definir n, menor, pos como Entero;
	
	Escribir "Ingrese el primer número";
	Leer n;
	menor=n;
	pos=1;
	
	Escribir "Ingrese el segundo número";
	Leer n;
	
	Si n<menor Entonces
		menor=n;
		pos=2;
	FinSi;
	
	Escribir "Ingrese el tercer número";
	Leer n;
	
	Si n<menor Entonces
		menor=n;
		pos=3;
	FinSi;
	Escribir "Ingrese el cuarto número";
	Leer n;
	
	Si n<menor Entonces
		menor=n;
		pos=4;
	FinSi;
	Escribir "Ingrese el quinto número";
	Leer n;
	
	Si n<menor Entonces
		menor=n;
		pos=5;
	FinSi;
	
	Escribir "El valor menor es:", menor,"y su número de orden es:", pos;
FinProceso