CREATE DATABASE [entregas]
GO

USE [entregas]
GO

CREATE TABLE [provincias] (
  [id_provincia] int NOT NULL PRIMARY KEY,
  [nombre_provincia] varchar(200) NOT NULL
)
GO

CREATE TABLE [clientes] (
  [dni] varchar(10) NOT NULL PRIMARY KEY,
  [nombre] varchar(80) NOT NULL,
  [apellidos] varchar(200) NOT NULL,
  [email] varchar(255) NULL,
  [domicilio] varchar(200) NOT NULL,
  [localidad] varchar(80) NOT NULL,
  [provincia] int NOT NULL
)
GO

CREATE TABLE [pedidos] (
  [id_pedido] int IDENTITY(1,1) NOT NULL PRIMARY KEY,
  [cliente] varchar(10) NOT NULL,
  [fecha_pedido] date NOT NULL,
  [descripcion] varchar(500) NOT NULL,
  [fecha_entrega] date NULL,
  [firma] varbinary(max) NULL
)
GO



ALTER TABLE [clientes] ADD CONSTRAINT [clientes_fk_prv] FOREIGN KEY ([provincia]) REFERENCES [provincias] ([id_provincia])
GO
ALTER TABLE [pedidos] ADD CONSTRAINT [pedidos_fk_cli] FOREIGN KEY ([cliente]) REFERENCES [clientes] ([dni])
GO

INSERT INTO provincias (id_provincia, nombre_provincia)
VALUES
	(1,'Álava'),
	(2,'Albacete'),
	(3,'Alicante'),
	(4,'Almería'),
	(33,'Asturias'),
	(5,'Ávila'),
	(6,'Badajoz'),
	(7,'Islas Baleares'),
	(8,'Barcelona'),
	(48,'Vizcaya'),
	(9,'Burgos'),
	(10,'Cáceres'),
	(11,'Cádiz'),
	(39,'Cantabria'),
	(12,'Castellón'),
	(51,'Ceuta'),
	(13,'Ciudad Real'),
	(14,'Córdoba'),
	(15,'La Coruña'),
	(16,'Cuenca'),
	(20,'Guipúzcoa'),
	(17,'Gerona'),
	(18,'Granada'),
	(19,'Guadalajara'),
	(21,'Huelva'),
	(22,'Huesca'),
	(23,'Jaén'),
	(24,'León'),
	(27,'Lugo'),
	(25,'Lérida'),
	(28,'Madrid'),
	(29,'Málaga'),
	(52,'Melilla'),
	(30,'Murcia'),
	(31,'Navarra'),
	(32,'Ourense'),
	(34,'Palencia'),
	(35,'Palmas, Las'),
	(36,'Pontevedra'),
	(26,'Rioja, La'),
	(37,'Salamanca'),
	(38,'Santa Cruz de Tenerife'),
	(40,'Segovia'),
	(41,'Sevilla'),
	(42,'Soria'),
	(43,'Tarragona'),
	(44,'Teruel'),
	(45,'Toledo'),
	(46,'Valencia'),
	(47,'Valladolid'),
	(49,'Zamora'),
	(50,'Zaragoza')

GO