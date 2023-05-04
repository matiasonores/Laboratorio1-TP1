Proceso RecaudacionTotalViaje
	Definir pasajeros,bonificados,asientos Como Entero;
	Definir valorPasaje,recaudacion,recaudacionPromP,recaudacionPromU,recaudacionTotal,unidades Como Real;
	Escribir 'Ingresar la cantidad de pasajeros';
	Leer pasajeros;
	Escribir 'Ingresar la cantidad de pasajeros bonificados';
	Leer bonificados;
	Escribir 'Ingresar el valor del pasaje';
	Leer valorPasaje;
	recaudacion <- (pasajeros+bonificados)*valorPasaje;
	recaudacionPromP <- ((pasajeros*valorPasaje)+bonificados*(valorPasaje-(valorPasaje*30/100)))/(pasajeros+bonificados);
	recaudacionPromP = trunc(recaudacionPromP);
	Escribir "La recaudación promedio por pasajero es de:$" , recaudacionPromP;
	recaudacionPromU <- recaudacionPromP*42;
	recaudacionPromU = trunc(recaudacionPromU);
	Escribir "La recaudación promedio por unidad es de:$" ,recaudacionPromU;
	recaudacionTotal <- (pasajeros*valorPasaje)+bonificados*(valorPasaje-(valorPasaje*30/100));
	unidades <- (pasajeros+bonificados)/42;
	unidades <- trunc(unidades);
	asientos <- (pasajeros+bonificados) MOD 42;
	asientos <- 42-asientos;
	Escribir 'La recaudación total sin bonificación es de: $',recaudacion;
	Escribir 'La recaudación total es de: $',recaudacionTotal;
	Escribir 'Se completaron en total:',unidades,' unidades y quedaron libres en total:',asientos,' asientos.';
FinProceso
