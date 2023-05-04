Proceso CondicionAlumno
	definir nota,nota2,nota3, notaTotal como entero;
	definir prom como real;
	Escribir "Ingrese la nota de los tres parciales";
	Leer nota, nota2, nota3;
	notaTotal = nota+nota2+nota3;
	prom = notaTotal/3;
	Si prom>=80 Entonces
		Escribir "El alumno promocionó.";
	SiNo
		Escribir "El alumno debe rendir final.";
	FinSi
FinProceso
