DELIMITER//
CREATE FUNCTION recaudacionPara (unidproducto INT, fechayhora1 DATETIME, fechayhora2 DATETIME)
                                 RETURNS FLOAT
BEGIN
     DECLARE suma FLOAT;
     
     SELECT SUM(precio)  INTO suma
     FROM CompraVenta
     WHERE idproducto = unidproducto
     AND fechayhora BETWEEN fechayhora1 AND fechayhora2;
     
     RETURN suma;
END//

DELIMITER//
CREATE FUNCTION recaudacionTotal(unidCliente INT, unafechayhora1 DATETIME, unafechayhora2 DATETIME)
                                 RETURNS FLOAT
BEGIN 
     DECLARE suma FLOAT;
     
     SELECT SUM(precio) INTO suma
     FROM CompraVenta
     WHERE idUsuario = unidUsuario
     AND fechayhora1 BETWEEN fechayhora1 AND fechayhora2;
     
     RETURN suma;
END//
