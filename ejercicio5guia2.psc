Proceso TiempoCaida
	definir altura,gravedad,velocidadFinal,tiempo como real;
	gravedad=9.8;
	escribir "Ingrese un valor de altura en metros:";
	leer altura;
	velocidadFinal=raiz((2*gravedad)*altura);
	tiempo=velocidadFinal/gravedad;	
	escribir "El tiempo que tardo en caer fue de:", tiempo, "segundos.";
	escribir "La velocidad final que alcanzó el objeto fue de:" ,velocidadFinal,"m/s.";
FinProceso
