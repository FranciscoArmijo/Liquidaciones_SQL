--Se crea la tabla, par aahcer un correlativo se usa IDENTITY(1,1) EMPIEZA EN 1 Y VA DE 1 EN 1
Create table LiquidacionesFranciscoArmijo (
	Correlativo int not null identity(1,1) primary key,
	Rut_trabajador varchar(10) not null,
	Nombre_trabajador varchar (50) not null,
	Mes_remuneracion varchar (10) not null,
	Ano_remuneracion int not null,
	Sueldo_Base int not null,
	Otros_ingresos int,
	N_cargas int,
	Tramo_cargas char,
	Movilizacion int,
	AFP varchar(15) not null,
	Cotizacion_voluntaria int,
	Otros_descuentos int,
	Anticipos int,
	Empleador varchar(20) not null,
	Fecha_emicion date not null
	);  
--SE AÑADEN LOS DATOS A LA TABLA usuario 1
insert into LiquidacionesFranciscoArmijo(
	Rut_trabajador,
	Nombre_trabajador,
	Mes_remuneracion,
	Ano_remuneracion,
	Sueldo_Base,
	Otros_ingresos,
	N_cargas,
	Tramo_cargas,
	Movilizacion,
	AFP,
	Cotizacion_voluntaria,
	Otros_descuentos,
	Anticipos,
	Empleador,
	Fecha_emicion
	)
	values(
	'17974473-2',
	'Quentin Tarantino',
	'Enero',
	'2020',
	650000,
	0,
	2,
	'C',
	18000,
	'CAPITAL',
	0,
	0,
	20000,
	'Hollywood',
	SYSDATETIME()
	);

	--SE AÑADEN LOS DATOS A LA TABLA usuario 1 mes 2
insert into LiquidacionesFranciscoArmijo(
	Rut_trabajador,
	Nombre_trabajador,
	Mes_remuneracion,
	Ano_remuneracion,
	Sueldo_Base,
	Otros_ingresos,
	N_cargas,
	Tramo_cargas,
	Movilizacion,
	AFP,
	Cotizacion_voluntaria,
	Otros_descuentos,
	Anticipos,
	Empleador,
	Fecha_emicion
	)
	values(
	'17974473-2',
	'Quentin Tarantino',
	'Febrero',
	'2020',
	650000,
	150000,
	2,
	'C',
	18000,
	'CAPITAL',
	0,
	10000,
	0,
	'Hollywood',
	SYSDATETIME()
	);

--SE AÑADEN LOS DATOS A LA TABLA usuario 2
insert into LiquidacionesFranciscoArmijo(
	Rut_trabajador,
	Nombre_trabajador,
	Mes_remuneracion,
	Ano_remuneracion,
	Sueldo_Base,
	Otros_ingresos,
	Movilizacion,
	AFP,
	Cotizacion_voluntaria,
	Otros_descuentos,
	Anticipos,
	Empleador,
	Fecha_emicion
	)
	values(
	'17535268-6',
	'Christopher Nolan',
	'Enero',
	'2020',
	800000,
	18000,
	0,
	'MODELO',
	80000,
	150000,
	0,
	'Hollywood',
	SYSDATETIME()
	);

	--SE AÑADEN LOS DATOS A LA TABLA usuario 2 mes 2
insert into LiquidacionesFranciscoArmijo(
	Rut_trabajador,
	Nombre_trabajador,
	Mes_remuneracion,
	Ano_remuneracion,
	Sueldo_Base,
	Otros_ingresos,
	Movilizacion,
	AFP,
	Cotizacion_voluntaria,
	Otros_descuentos,
	Anticipos,
	Empleador,
	Fecha_emicion
	)
	values(
	'17535268-6',
	'Christopher Nolan',
	'Febrero',
	'2020',
	800000,
	0,
	18000,
	'MODELO',
	80000,
	75000,
	23000,
	'Hollywood',
	SYSDATETIME()
	);

