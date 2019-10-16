CREATE USER 'userLibre'@'%' identified by '1234';

GRANT select, update(telefono, contrasenia, email)on usuario to 'userLibre'@'%';
GRANT select, update(precio, cantidad) on producto to 'userLibre'@'%';
GRANT select on compraventa to 'userLibre'@'%';