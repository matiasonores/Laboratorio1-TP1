Proceso CobrarConsumo
	definir mesAnterior,mesActual,totalConsumo,precioKw,totalACobrar,mantenimiento,tasaMunicipal,iva como Real;
	Escribir "Ingrese el consumo del mes anterior en Kw.";
	leer mesAnterior;
	Escribir "Ingrese el consumo del mes actual en Kw.";
	leer mesActual;
	totalConsumo=mesAnterior+mesActual;
	precioKw=2.752;
	totalACobrar=totalConsumo*precioKw;
	mantenimiento=183;
	tasaMunicipal=7/100;
	iva=21/100;
	escribir "El total a cobrar sin impuestos es de:",totalACobrar;
	totalACobrar=totalACobrar+(totalACobrar*tasaMunicipal)+(totalACobrar*iva)+mantenimiento;
	escribir "El total a cobrar por el consumo de energia es de:", totalACobrar;
FinProceso
