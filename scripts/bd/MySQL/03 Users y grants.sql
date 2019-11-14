# "Usuario"
CREATE USER 'userLibre'@'%' identified by '1234';

GRANT select, update(Nombre,Apellido,Telefono,Contrasenia,Email)on usuario to 'userLibre'@'%';
GRANT select, update(Precio, Cantidad) on producto to 'userLibre'@'%';
GRANT select on compraventa to 'userLibre'@'%';

# "Administrador"
CREATE USER 'Administrador'@'10.3.45.%' IDENTIFIED BY 'passadmin';

GRANT SELECT,DELETE,UPDATE(Cantidad) ON producto TO 'Administrador'@'10.3.45.%';
GRANT SELECT ON compraventa TO 'Administrador'@'10.3.45.%';
GRANT SELECT,UPDATE(Nombre,Apellido,Telefono,Contrasenia,Email)ON usuario TO 'Administrador'@'10.3.45.%';