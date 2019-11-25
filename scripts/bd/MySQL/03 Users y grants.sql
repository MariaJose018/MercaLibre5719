# "Usuario"
CREATE USER 'userLibre'@'%' identified by '1234';

GRANT select, update(Nombre,Apellido,Telefono,Contrasenia,Email)on usuario to 'userLibre'@'%';
GRANT select, update(Precio, Cantidad) on producto to 'userLibre'@'%';
GRANT select on compraventa to 'userLibre'@'%';

# "Administrador"
CREATE USER 'Administrador'@'10.3.120.%' IDENTIFIED BY 'passadmin';

GRANT SELECT,DELETE,UPDATE(Cantidad) ON producto TO 'Administrador'@'10.3.120.%';
GRANT SELECT ON compraventa TO 'Administrador'@'10.3.120.%';
GRANT SELECT,UPDATE(Nombre,Apellido,Telefono,Contrasenia,Email)ON usuario TO 'Administrador'@'10.3.120.%';
GRANT INSERT, SELECT, update on usuario to 'Administrador'@'10.3.120.%';

# "Administrador" Local
CREATE USER 'Administrador'@'localhost' IDENTIFIED BY 'passadmin';

GRANT SELECT,DELETE,UPDATE(Cantidad) ON producto TO 'Administrador'@'localhost';
GRANT SELECT ON compraventa TO 'Administrador'@'localhost';
GRANT SELECT,UPDATE(Nombre,Apellido,Telefono,Contrasenia,Email)ON usuario TO 'Administrador'@'localhost';
GRANT INSERT, SELECT, update on usuario to 'Administrador'@'localhost';

# "Usuario en LAN"
CREATE USER 'userLibre'@'10.120.0.%' identified by '1234';

GRANT select, update(Nombre,Apellido,Telefono,Contrasenia,Email)on usuario to 'userLibre'@'10.120.0.%';
GRANT select, update(Precio, Cantidad) on producto to 'userLibre'@'10.120.0.%';
GRANT select on compraventa to 'userLibre'@'10.120.0.%';
GRANT INSERT, SELECT, update on producto to 'userLibre'@'10.120.0.%';