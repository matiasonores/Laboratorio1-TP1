Proceso Triatlon
	Definir competidor, natacionM, natacionS, totalNatacion, ciclismoM, ciclismoS, totalCiclismo, pedestrismoM, pedestrismoS, totalPedestrismo, tiempoTotal, mejorN, mejorC, mejorP, competidores, tiempoGanador, ganador  Como Entero;
	mejorN <- 0;
	mejorC <- 0;
	mejorP <- 0;
	tiempoGanador <- 0;
	
	Escribir 'Ingrese un número de competidor o -1 para salir.';
	Leer competidor;
	
	Mientras competidor <>-1 Hacer
		
		competidores <- competidores+1;
		Escribir 'Ingrese la cantidad de minutos en el tramo de natación:';
		Leer natacionM;
		Escribir 'Ingrese la cantidad de segundos en el tramo de natación:';
		Leer natacionS;
		Escribir 'Ingrese la cantidad de minutos en el tramo de ciclismo:';
		Leer ciclismoM;
		Escribir 'Ingrese la cantidad de segundos en el tramo de ciclismo:';
		Leer ciclismoS;
		Escribir 'Ingrese la cantidad de minutos en el tramo de pedestrismo:';
		Leer pedestrismoM;
		Escribir 'Ingrese la cantidad de segundos en el tramo de pedestrismo:';
		Leer pedestrismoS;
		totalNatacion <- (natacionM*60)+natacionS;
		totalCiclismo <- (ciclismoM*60)+ciclismoS;
		totalPedestrismo <- (natacionM*60)+natacionS;
		tiempoTotal <- totalNatacion+totalCiclismo+totalPedestrismo;
		Si totalNatacion>mejorN Entonces
			mejorN <- totalNatacion;
		FinSi
		Si totalCiclismo>mejorC Entonces
			mejorC <- totalCiclismo;
		FinSi
		Si totalPedestrismo>mejorP Entonces
			mejorP <- totalPedestrismo;
		FinSi
		Si tiempoTotal>tiempoGanador Entonces
			tiempoGanador <- tiempoTotal;
			ganador <- competidor;
		FinSi
		
		Escribir 'Ingrese un número de competidor o -1 para salir.';
		Leer competidor;
	FinMientras
	
	Escribir 'Mejor tiempo natación: ',trunc(mejorN/60)," minutos ", trunc(mejorN%60), " segundos";
	Escribir 'Mejor tiempo ciclismo: ',trunc(mejorC/60)," minutos ", trunc(mejorC%60), " segundos";
	Escribir 'Mejor tiempo pedestrismo: ',trunc(mejorP/60)," minutos ", trunc(mejorP%60), " segundos";
	Escribir 'Total de competidores: ',competidores;
	Escribir 'Mejor tiempo: ',trunc(tiempoGanador/60)," minutos ", trunc(tiempoGanador%60), " segundos";
	Escribir 'Ganador: Competidor Nº ',ganador;
FinProceso