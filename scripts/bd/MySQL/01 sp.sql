DELIMITER//
CREATE PROCEDURE altausuario (unNombre VARCHAR(45),
                              unApellido VARCHAR(45),
                              unTelefono TINYINT,
                              unEmail varchar(45),
                              unNombreUsuario VARCHAR(45),
                              unaContrasenia VARCHAR(45),
                              unidUsuario SMALLINT)
                            
BEGIN
       INSERT INTO Usuario (Nombre, Apellido, Telefono, Email, NombreUsuario, Contrasenia, idUsuario)
       VALUES (unNombre, unApellido, unTelefono, unEmail, unNombreUsuario, SHA1(unaContrasenia), unidUsuario);
END//

DELIMETER//
CREATE PROCEDURE altaproductoventa (unidProducto INT,
                                    unidUsuario INT, 
                                    unPrecio FLOAT,
                                    unaCantidad MEDIUMINT,
                                    unNombre VARCHAR(45),
                                    unDuenio VARCHAR(45),
                                    unaFechaPublicacion DATETIME)
                            
BEGIN
       INSERT INTO Producto (idProducto, idUsuario, Precio, Cantidad, Nombre, Duenio, FechaPublicacion)
       values (unidProducto, unidUsuario, unPrecio, unaCantidad, unNombre, unDuenio, unaFechaPublicacion);
END//


	

