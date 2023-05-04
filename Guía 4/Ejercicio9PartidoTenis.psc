Proceso PartidoTenis
	Definir jug1,jug2,ganador Como Caracter;
	Definir puntos1,puntos2,set1,set2 Como Entero;
	set1 <- 0;
	set2 <- 0;
	Escribir 'Ingrese el nombre del jugador 1';
	Leer jug1;
	Escribir 'Ingrese el nombre del jugador 2';
	Leer jug2;
	Escribir 'Set 1. Ingrese los puntos del jugador 1';
	Leer puntos1;
	Escribir 'Set 1. Ingrese los puntos del jugador 2';
	Leer puntos2;
	Si puntos1<>puntos2 Entonces
		Si puntos1>puntos2 Entonces
			set1 <- set1+1;
			Escribir 'Resultados Set 1. ',jug1,': ',puntos1,' ',jug2,': ',puntos2;
		SiNo
			set2 <- set2+1;
			Escribir 'Resultados Set 1. ',jug1,': ',puntos1,' ',jug2,': ',puntos2;
		FinSi
	SiNo
		Escribir 'Resultado Set 1: Empate';
	FinSi
	Escribir 'Set 2. Ingrese los puntos del jugador 1';
	Leer puntos1;
	Escribir 'Set 2. Ingrese los puntos del jugador 2';
	Leer puntos2;
	Si puntos1<>puntos2 Entonces
		Si puntos1>puntos2 Entonces
			set1 <- set1+1;
			Escribir 'Resultados Set 2. ',jug1,': ',puntos1,' ',jug2,': ',puntos2;
		SiNo
			set2 <- set2+1;
			Escribir 'Resultados Set 2. ',jug1,': ',puntos1,' ',jug2,': ',puntos2;
		FinSi
	SiNo
		Escribir 'Resultado Set 2: Empate';
	FinSi
	Escribir 'Set 3. Ingrese los puntos del jugador 1';
	Leer puntos1;
	Escribir 'Set 3. Ingrese los puntos del jugador 2';
	Leer puntos2;
	Si puntos1<>puntos2 Entonces
		Si puntos1>puntos2 Entonces
			set1 <- set1+1;
			Escribir 'Resultados Set 3. ',jug1,': ',puntos1,' ',jug2,': ',puntos2;
		SiNo
			set2 <- set2+1;
			Escribir 'Resultados Set 3. ',jug1,': ',puntos1,' ',jug2,': ',puntos2;
		FinSi
	SiNo
		Escribir 'Resultado Set 3: Empate';
	FinSi
	Si set1<>set2 Entonces
		Si set1>set2 Entonces
			ganador <- jug1;
			Escribir 'El ganador es: ',jug1;
		SiNo
			Escribir 'El ganador es: ',jug2;
		FinSi
	SiNo
		Escribir 'Empate, todos ganaron :)';
	FinSi
FinProceso