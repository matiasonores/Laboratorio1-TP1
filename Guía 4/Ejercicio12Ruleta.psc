Proceso Ruleta
	Definir num Como Entero;
	Definir mitad,docena,columna Como Caracter;
	Escribir 'Ingrese un n�mero';
	Leer num;
	// Verificar si es un n�mero v�lido
	Si ((num>-1) Y (num<37)) Entonces
		// Verificar si NO gana la banca
		Si num<>0 Entonces
			// Verificar Mayor o menor
			Si num>18 Entonces
				mitad <- 'Mayor';
			SiNo
				mitad <- 'Menor';
			FinSi
			// Verificar Docena
			Si num>24 Entonces
				docena <- 'Tercer';
			SiNo
				Si num>12 Entonces
					docena <- 'Segunda';
				SiNo
					docena <- 'Primer';
				FinSi
			FinSi
			// Verificar Columna
			Si num MOD 3==0 Entonces
				columna <- 'Tercer';
			SiNo
				Si num+1 MOD 3==0 Entonces
					columna <- 'Segunda';
				SiNo
					columna <- 'Primer';
				FinSi
			FinSi
			Escribir 'El n�mero es: ',mitad,' Esta en la: ',docena,' docena y la: ',columna,' columna.';
		SiNo
			Escribir 'Gan� la banca.';
		FinSi
	SiNo
		Escribir 'Se ingres� un n�mero invalido.';
	FinSi
FinProceso
