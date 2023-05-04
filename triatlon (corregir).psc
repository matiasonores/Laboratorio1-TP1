Algoritmo triatlon
	Definir tiempoHorasTotalesC, tiempoHorasTotalesN, tiempoHorasTotalesP, tiempoTotalHoras, tiempoTotalMinutos, tiempoTotalSegundos, tiempoHorasN, tiempoMinutosN, tiempoSegundosN, tiempoHorasC, tiempoMinutosC, tiempoSegundosC, tiempoHorasP, tiempoMinutosP, tiempoSegundosP, distanciaCiclismo, distanciaNatacion, distanciaPedestrismo, velocidadNatacion, velocidadCiclismo, velocidadPedestrismo Como Real
	Escribir 'Ingrese cantidad de horas de Natacion:' 
	Leer tiempoHorasN
	Escribir 'Ingrese cantidad de minutos de Natacion:'
	Leer tiempoMinutosN
	Escribir 'Ingrese cantidad de segundos de Natacion:'
	Leer tiempoSegundosN
	Escribir 'Ingrese cantidad de horas de Ciclismo:'
	Leer tiempoHorasC
	Escribir 'Ingrese cantidad de minutos de Ciclismo:'
	Leer tiempoMinutosC
	Escribir 'Ingrese cantidad de segundos de Ciclismo:'
	Leer tiempoSegundosC
	Escribir 'Ingrese cantidad de horas de Pedestrismo:'
	Leer tiempoHorasP
	Escribir 'Ingrese cantidad de minutos de Pedestrismo:'
	Leer tiempoMinutosP
	Escribir 'Ingrese cantidad de segundos de Pedestrismo:'
	Leer tiempoSegundosP
	Escribir 'Ingrese distancia de Ciclismo en km:'
	Leer distanciaCiclismo
	Escribir 'Ingrese distancia de Pedestrismo en km:'
	Leer distanciaPedestrismo
	Escribir 'Ingrese distancia de Natacion en km:'
	Leer distanciaNatacion
	tiempoTotalHoras = tiempoHorasC + tiempoHorasN + tiempoHorasP
	tiempoTotalMinutos = tiempoMinutosC + tiempoMinutosN + tiempoMinutosP
	tiempoTotalSegundos = tiempoSegundosC + tiempoSegundosN + tiempoSegundosP
	segundosAHorasN = tiempoSegundosN/3600
	minutosAHorasN = tiempoMinutosN/60
	segundosAHorasP = tiempoSegundosP/3600
	minutosAHorasP = tiempoMinutosP/60
	segundosAHorasC = tiempoSegundosC/3600
	minutosAHorasC = tiempoMinutosC/60
	tiempoHorasTotalesC = tiempoHorasC + segundosAHorasC + minutosAHorasC
	tiempoHorasTotalesN = tiempoHorasN + segundosAHorasN + minutosAHorasN
	tiempoHorasTotalesP = tiempoHorasP + segundosAHorasP + minutosAHorasP
	velocidadCiclismo = distanciaCiclismo/tiempoHorasTotalesC
	velocidadNatacion = distanciaNatacion/tiempoHorasTotalesN
	velocidadPedestrismo = distanciaPedestrismo/tiempoHorasTotalesP
	Escribir 'Tiempo total del parcipante:' ,tiempoTotalHoras ':',tiempoTotalMinutos ':',tiempoTotalSegundos
	Escribir 'Velocidad del participante en Ciclismo:' ,velocidadCiclismo
	Escribir 'Velocidad del participante en Natacion:' ,velocidadNatacion
	Escribir 'Velocidad del participante en Pedestrismo:' ,velocidadPedestrismo
	
FinAlgoritmo
