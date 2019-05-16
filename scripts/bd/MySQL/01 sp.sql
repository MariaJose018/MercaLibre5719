
create procedure altausuario (unNombre varchar(45),
                             unApellido varchar(45),
                             unTelefono TINYINT,
                             unEmail varchar(45),
                             unNombreusuario varchar (45),
                             unacontrasenia varchar(45),
                             unIdusuario smallint)
                            
begin
       insert into usuario (Nombre, Apellido, Telefono, Email, Nombreusuario, contrasenia, Idusuario)
       values (unNombre, unApellido, unTelefono, unEmail, unNombreusuario, unacontrasenia, unIdusuario);
end

create procedure altaproductoventa (unidProducto INT,
                                    unidUsuario INT, 
                                    unPrecio FLOAT,
                                    unaCantidad MEDIUMINT,
                                    unNombre VARCHAR(45),
                                    unDueño VARCHAR(45),
                                    unaFechaPublicacion DATETIME)
                            
begin
       insert into Producto (idProducto, idUsuario, Precio, Cantidad, Nombre, Dueño, FechaPublicacion)
       values (unidProducto, unidUsuario, unPrecio, unaCantidad, unNombre, unDueño, unaFechaPublicacion);
end

CREATE FUNCTION recaudacionPara (unidproducto INT, fechayhora1 DATETIME, fechayhora2 DATETIME)
                                 RETURN(FLOAT)
BEGIN
     DECLARE suma FLOAT;
     SELECT SUM(precio)  INTO suma
     FROM CompraVenta
     WHERE idproducto = unidproducto
     AND fechayhora BETWEEN fechayhora1 AND fechayhora2
	

