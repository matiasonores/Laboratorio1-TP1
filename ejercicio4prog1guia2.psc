Proceso Triangulo
	definir lado,lado2,lado3,ladoMayor como real;
	Escribir "Ingrese la medida de los 3 lados.";
	Leer lado,lado2,lado3;
	Si lado>lado2 Entonces
		Si lado>lado3 Entonces
			ladoMayor = lado;
			Si ladoMayor<(lado2+lado3) Entonces
				Escribir "Puede formar un tri�ngulo.";
			SiNo
				Escribir "No puede formar un tri�ngulo.";
			FinSi
		SiNo
			ladoMayor = lado3;
			Si ladoMayor<(lado+lado2) Entonces
				Escribir "Puede formar un tri�ngulo.";
			SiNo
				Escribir "No puede formar un tri�ngulo.";
			FinSi
		FinSi
	SiNo
		Si lado2>lado3 Entonces
			ladoMayor = lado2;
			Si ladoMayor<(lado+lado3) Entonces
				Escribir "Puede formar un tri�ngulo.";
			SiNo
				Escribir "No puede formar un tri�ngulo.";
			FinSi
		SiNo
			ladoMayor = lado3;
			Si ladoMayor<(lado+lado2) Entonces
				Escribir 	"Puede formar un tri�ngulo.";
			SiNo
				Escribir "No puede formar un tri�ngulo."	;
			FinSi
		FinSi
	FinSi
FinProceso
