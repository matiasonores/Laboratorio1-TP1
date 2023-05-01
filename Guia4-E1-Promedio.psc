Proceso Promedio
	Definir n1, n2, n3, prom, condicion Como Real;
	Escribir 'Ingrese nota de los parciales:';
	Leer n1,n2,n3;
	prom = (n1+n2+n3)/3;
	Escribir 'Ingrese condicion de promocion:';
	Leer condicion;
	si prom>=condicion Entonces
		Escribir 'Alumno promocionó';
	SiNo
		Escribir 'Alumno rinde final';
	FinSi
FinProceso