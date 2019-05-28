SET FOREIGN_KEY_CHECKS=0;

drop schema if exists mercalibre5719;
CREATE SCHEMA mercalibre5719;
USE mercalibre5719;


DROP TABLE IF EXISTS CompraVenta
;
DROP TABLE IF EXISTS Producto
;
DROP TABLE IF EXISTS Usuario
;

CREATE TABLE CompraVenta
(
	idcompra MEDIUMINT NOT NULL,
	idproducto INTEGER NOT NULL,
	fechayhora DATETIME NOT NULL,
	cantunidades INTEGER NOT NULL,
	precio FLOAT(0) NOT NULL,
	idUsuarioCompra SMALLINT NOT NULL,
	PRIMARY KEY (idcompra),
	KEY (idUsuarioCompra),
	KEY (idproducto)
) 
;


CREATE TABLE Producto
(
	Precio FLOAT(0) NOT NULL,
	Cantidad MEDIUMINT NOT NULL,
	Nombre VARCHAR(50) NOT NULL,
	Duenio VARCHAR(50) NOT NULL,
	FechaPublicacion DATETIME NOT NULL,
	idProducto INTEGER NOT NULL,
	idUsuarioVendedor SMALLINT NOT NULL,
	PRIMARY KEY (idProducto),
	KEY (idUsuarioVendedor)
) 
;


CREATE TABLE Usuario
(
	Nombre VARCHAR(50) NOT NULL,
	Apellido VARCHAR(50) NOT NULL,
	Telefono TINYINT NOT NULL,
	NombreUsuario VARCHAR(50) NOT NULL,
	Email VARCHAR(50) NOT NULL,
	Contrasenia VARCHAR(50) NOT NULL,
	idUsuario SMALLINT NOT NULL,
	PRIMARY KEY (idUsuario)
) 
;



SET FOREIGN_KEY_CHECKS=1;


ALTER TABLE CompraVenta ADD CONSTRAINT FK_compra_Cliente 
	FOREIGN KEY (idUsuarioCompra) REFERENCES Usuario (idUsuario)
;

ALTER TABLE CompraVenta ADD CONSTRAINT FK_compra_Producto 
	FOREIGN KEY (idproducto) REFERENCES Producto (idProducto)
;

ALTER TABLE Producto ADD CONSTRAINT FK_Producto_Usuario 
	FOREIGN KEY (idUsuarioVendedor) REFERENCES Usuario (idUsuario)
;
