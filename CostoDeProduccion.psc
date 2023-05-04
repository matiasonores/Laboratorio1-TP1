Proceso  CostoDeProduccion
		
		Definir cantidadRemeras como Entero;
		Definir costoTela, metrosTela, costoPorRemera, recargoMateriales, recargoManoObra, costoProduccion, costoProduccionFinal como Real;
		
		Escribir "Ingresar cantidad de remeras fabricadas";
		Leer cantidadRemeras;
		
		Escribir "Ingresar valor del metro de tela";
		Leer costoTela;
		
		Escribir "Ingresar cantidad de tela necesaria para cada remera (en metros)";
		Leer metrosTela;
		
		costoPorRemera= costoTela*metrosTela;
		costoProduccion= costoPorRemera*cantidadRemeras;
		
		recargoMateriales= 23/100;
		recargoManoObra= 57/100;
		
		costoProduccionFinal= costoProduccion+(costoProduccion*recargoMateriales)+(costoProduccion*recargoManoObra);
		
		Escribir "El costo final de producción es: $", costoProduccionFinal;
		
FinProceso
