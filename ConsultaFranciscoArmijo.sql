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

--buscar informacion con respecto a los datos guardados
select * from LiquidacionesFranciscoArmijo;
--ASIGNACION E IMPONIBLE
select Sueldo_base + Otros_ingresos as 'TOTAL_IMPONIBLE',
case
when Tramo_cargas = 'A' then  N_cargas * 12364 
when Tramo_cargas = 'B' then  N_cargas * 7587
when Tramo_cargas = 'C' then  N_cargas * 2398
when Tramo_cargas IS NULL then  0
end AS 'ASIGNACION_FAMILIAR'
from LiquidacionesFranciscoArmijo;
--TOTAL HABERES
select TOTAL_IMPONIBLE + ASIGNACION_FAMILIAR AS 'TOTAL_HABERES' FROM(
select Sueldo_base + Otros_ingresos as 'TOTAL_IMPONIBLE',
case
when Tramo_cargas = 'A' then  N_cargas * 12364 
when Tramo_cargas = 'B' then  N_cargas * 7587
when Tramo_cargas = 'C' then  N_cargas * 2398
when Tramo_cargas IS NULL then  0
end AS 'ASIGNACION_FAMILIAR'
from LiquidacionesFranciscoArmijo) T1;
--DESCUENTO AFP
select TOTAL_IMPONIBLE * DESCUENTO AS 'DESCUENTO_AFP' FROM(
select Sueldo_base + Otros_ingresos as 'TOTAL_IMPONIBLE',
case
when AFP = 'CAPITAL' then  11.44/100 
when AFP = 'CUPRUM' then  11.48/100
when AFP = 'HABITAT' then  11.27/100
when AFP = 'MODELO' then  10.77/100
when AFP = 'PLAN VITAL' then  10.41/100
when AFP = 'PROVIDA' then  11.45/100 
end AS 'DESCUENTO'
from LiquidacionesFranciscoArmijo) T1;
--DESCUENTO ISAPRE
select TOTAL_IMPONIBLE * 10/100 AS 'DESCUENTO_ISAPRE' FROM(
select Sueldo_base + Otros_ingresos as 'TOTAL_IMPONIBLE'
from LiquidacionesFranciscoArmijo) T1;
-- ------------------------------------

create table liquidaciones (correlativo int primary key identity(1,1) not null,
identificador2 nvarchar(14),
rut nvarchar(10),
nombre nvarchar(50),
mes nvarchar(2),anio int, base int); 

insert into liquidaciones(rut,nombre,mes,anio) values ('12345678-9', 'Francsico', '01',2020, 150000);
--actualizar concatenando
update liquidaciones set identificador2 = SUBSTRING(rut,1,8)+cast(mes as nvarchar)+cast(anio as nvarchar);

--actualizar concatenando con concat
update liquidaciones set identificador2 = concat(SUBSTRING(rut,1,8),mes,anio);

update liquidaciones set base = 600000;