Proceso MedicionLluvia
	Definir medicion, promedio, mayor, totalMedicion como Real;
	Definir contador como Entero;
	
	contador=0;
	totalMedicion=0;
	mayor=-1;
	promedio=0;
	
	Escribir "Ingrese la primer medición o -1 para salir:";
	Leer medicion;
	
	Mientras medicion <>-1 Hacer		
		contador=contador+1;
		totalMedicion= totalMedicion+medicion;
		
		Si medicion>mayor Entonces
			mayor=medicion;
		FinSi
		
		Escribir "Ingrese otra medición o -1 para salir:";
		Leer medicion;
	FinMientras
	
	promedio=totalMedicion/30;
	
	Si promedio==0 Entonces
		Escribir "No se registraron mediciones.";
	Sino 
		Escribir "Cantidad de mediciones: ", contador;
		Escribir "Mayor medición registrada: ", mayor;
		Escribir "Promedio mensual: ", promedio;
	FinSi
FinProceso