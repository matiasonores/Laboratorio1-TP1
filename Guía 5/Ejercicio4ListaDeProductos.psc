Proceso ListaDeProductos
	Definir producto,cantidad,totalProductos Como Entero;
	Definir costo,totalCosto,totalConIva Como Real;
	
	producto <- 0;
	totalProductos <- 0;
	
	Repetir
		Escribir 'Indique la cantidad del: ',producto+1,'º producto. Ingrese 0 y 0 en el siguiente paso para salir.';
		Leer cantidad;
		totalProductos <- totalProductos+cantidad;
		
		Escribir 'Indique el valor del producto: ';
		Leer costo;
		
		totalCosto <- totalCosto+(costo*cantidad);
		producto <- producto+1;
	Hasta Que cantidad==0&costo==0
	
	totalConIva <- totalCosto*1.21;
	
	Escribir 'La cantidad total de productos es: ',totalProductos;
	Escribir 'El valor total de los productos es: $',totalCosto;
	Escribir 'El monto total a pagar aplicando IVA es: $',totalConIva;
FinProceso