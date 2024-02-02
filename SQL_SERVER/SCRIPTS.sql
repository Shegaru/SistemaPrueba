

create database PRUEBA_YEMINUS

use PRUEBA_YEMINUS

 
create table Encriptados (
    idEncriptado int IDENTITY(1,1) PRIMARY KEY,
    frase varchar(50),
    clave int,
	encriptado varchar(1000)
	)


create table Productos (
    codigo int,
    descripcion varchar(50),
    listaPrecios int,
    imagen varchar (70),
    permiteVenta bit default 1,
    porcentajeIva int)


insert into Productos(codigo,descripcion,listaPrecios,imagen, porcentajeIva) values
(123,'Juguete inflable',1000,'http://url.delaimagen.com', 19),
(123,'Juguete inflable',2000,'http://url.delaimagen.com', 19),
(123,'Juguete inflable',3000,'http://url.delaimagen.com', 19)

SELECT * FROM Productos

