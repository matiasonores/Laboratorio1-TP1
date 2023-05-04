Proceso TorneoDeTruco
	definir premio,premio1,premio2,premio3,premioPorPuntos como real;	
	definir puntos1,puntos2,puntos3,puntosTotales como entero;
	escribir "Ingrese el monto del premio.";
	leer premio;
	escribir "Ingrese los puntos de los tres jugadores";
	leer puntos1,puntos2,puntos3;
	puntosTotales=puntos1+puntos2+puntos3;
	premio1=(premio/2)/3;
	premio2=(premio/2)/3;
	premio3=(premio/2)/3;
	premioPorPuntos= (premio/2)/puntosTotales;
	premio1=premio1+(puntos1*premioPorPuntos);
	premio2=premio2+(puntos2*premioPorPuntos);
	premio3=premio3+(puntos3*premioPorPuntos);
	Escribir "Monto del premio jugador 1: $", premio1;
	Escribir "Monto del premio jugador 2: $", premio2;
	Escribir "Monto del premio jugador 3: $", premio3;
FinProceso
