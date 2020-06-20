--Crear tablas 
CREATE TABLE Tabla_descuento_afp(
codigo_plan int not null identity(1,1) primary key,
nombre_AFP nvarchar(50) not null,
nombre_plan nvarchar(50),
descuento_AFP decimal (4,2) not null,
);

INSERT INTO Tabla_descuento_afp(
nombre_AFP,
nombre_plan,
descuento_AFP
) VALUES (
'PROVIDA',
'A',
11.45
);

CREATE TABLE Tabla_salud(
codigo_salud int not null identity(1,1) primary key,
nombre_prevision nvarchar(50) not null,
nombre_plan nvarchar(50) not null,
descuento_salud int not null,
descuento_adicional int
);

INSERT INTO Tabla_salud(
nombre_prevision,
nombre_plan,
descuento_salud,
descuento_adicional
) VALUES (
'COLMENA',
'A',
7,
73000
);


CREATE TABLE Datos_personales(
rut nvarchar(12) not null primary key,
codigo_plan_afp int not null,
codigo_plan_salud int not null,
nombre_trabajador nvarchar(50) not null,
apellido_trabajador nvarchar(50) not null,
sueldo_base int not null,
n_cargas int,
foreign key (codigo_plan_afp) references Tabla_descuento_afp(codigo_plan),
foreign key (codigo_plan_salud) references Tabla_salud(codigo_salud)
);


INSERT INTO Datos_personales(
rut,
codigo_plan_afp,
codigo_plan_salud,
nombre_trabajador,
apellido_trabajador,
sueldo_base,
n_cargas
) VALUES (
'16795648-3',
5,
5,
'Rafael',
'Rojas',
850000,
2
);



create table asignacion_familiar(
tramo nvarchar(5) not null primary key,
asignacion int not null
);
insert into asignacion_familiar(
tramo, asignacion
) values(
'1',1
);

select codigo_salud from Tabla_salud where nombre_prevision = 'BANMEDICA';
