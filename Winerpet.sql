/*CREAMOS LA BASE DE DATOS Y LA USAMOS*/
Create database WinnerPet;
use WinnerPet;

show databases

select *from cliente

describe table cliente


/*CREAMOS LAS TABLAS*/
CREATE TABLE CLIENTE(
cve_cliente varchar(4) NOT NULL,
nombre_cliente varchar(40) NOT NULL,
telefono_cliente varchar(10) NULL,
constraint PK_CLIENTE_cve_cliente PRIMARY KEY(cve_cliente));

CREATE TABLE GPS(
imei varchar(16) NOT NULL,
latitud varchar(40) NULL,
longitud varchar(40) NULL,
constraint PK_GPS_imei PRIMARY KEY(imei));

CREATE TABLE CATALOGO(
cve_producto varchar(4) NOT NULL,
tipo_producto int NULL,
nombre_producto varchar(30) NULL,
precio_producto FLOAT NULL,
clasificacion varchar(50) NULL,
constraint PK_CATALOGO_cve_producto PRIMARY KEY(cve_producto));

CREATE TABLE VENTAS(
cve_venta varchar(4) NOT NULL,
importe FLOAT NULL,
cantidad int NULL,
cve_producto varchar(4),
constraint PK_VENTAS_cve_venta PRIMARY KEY(cve_venta));

CREATE TABLE ALTAS(
id_alta varchar(4) NOT NULL,
cve_venta varchar(4),
imei varchar(16),
constraint PK_ALTAS_id_alta PRIMARY KEY(id_alta));

CREATE TABLE FACTURA(
cve_factura varchar(10) NOT NULL,
subtotal FLOAT NULL,
iva FLOAT NULL,
total FLOAT NULL,
cve_venta varchar(4),
cve_cliente varchar(4),
constraint PK_FACTURA_cve_factura PRIMARY KEY(cve_factura));


/*RELACIONAMOS LAS TABLAS CON CONSTRAINT*/
ALTER TABLE VENTAS
ADD CONSTRAINT FK_VENTAS_cve_producto
FOREIGN KEY (cve_producto) 
REFERENCES CATALOGO (cve_producto)
ON update CASCADE
ON delete CASCADE;

ALTER TABLE ALTAS
ADD CONSTRAINT FK_ALTAS_cve_venta
FOREIGN KEY (cve_venta)
REFERENCES VENTAS (cve_venta)
ON update CASCADE
ON delete CASCADE;

ALTER TABLE ALTAS
ADD CONSTRAINT FK_ALTAS_imei
FOREIGN KEY (imei)
REFERENCES GPS(imei)
ON update CASCADE
ON delete CASCADE;

ALTER TABLE FACTURA
ADD CONSTRAINT FK_FACTURA_cve_cliente 
FOREIGN KEY (cve_cliente)
REFERENCES CLIENTE (cve_cliente)
ON update CASCADE
ON delete CASCADE;

ALTER TABLE FACTURA
ADD CONSTRAINT FK_FACTURA_cve_venta 
FOREIGN KEY (cve_venta)
REFERENCES VENTAS (cve_venta)
ON update CASCADE
ON delete CASCADE;

/*USAMOS EL UNIQUE PARA DARLE RESTRICCIONES A LOS REGISTROS*/
Alter table ALTAS
add constraint UQ_ALTAS_id_alta
unique(id_alta);

alter table CATALOGO
add constraint UQ_CATALOGO_cve_producto
unique(cve_producto);

alter table CLIENTE
add constraint UQ_CLIENTE_cve_cliente
unique(cve_cliente);

alter table FACTURA
add constraint UQ_FACTURA_cve_factura
unique(cve_factura);

alter table GPS
add constraint UQ_GPS_imei
unique(imei);

alter table VENTAS
add constraint UQ_VENTAS_cve_venta
unique(cve_venta);

/*USAMOS EL CHECK PARA DARLE RESTRICCIONES A LOS REGISTROS*/
Alter table CATALOGO
add constraint CK_CATALOGO_tipo_producto
check(tipo_producto>0);

Alter table CATALOGO
add constraint CK_CATALOGO_precio_producto
check (precio_producto>0);

Alter table VENTAS
add constraint CK_VENTAS_cantidad
check (cantidad>0);
/*USAMOS EL DEFAULT PARA AGINARLE UN VALOR A LA COLUMNA EN CASO
DE QUE AL MOMENTO DE REGISTRARLO NO SE LE HAYA PUESTO VALOR */
Alter table ALTAS
add constraint DF_ALTAS_imei
Default 0 for imei;

Alter table CATALOGO
add constraint DF_CATALOGO_precio_producto
Default 1 for precio_producto;

Alter table CATALOGO
add constraint DF_CATALOGO_clasificacion
Default 'S/N' for clasificacion;

Alter table CLIENTE
add constraint DF_CLIENTE_telefono_cliente
Default 'S/N' for telefono_cliente;

Alter table FACTURA
add constraint DF_FACTURA_iva
Default 16 for iva;

Alter table GPS
add constraint DF_GPS_latitud
Default 'S/N' for latitud;

Alter table GPS
add constraint DF_GPS_longitud
Default 'S/N' for longitud;

