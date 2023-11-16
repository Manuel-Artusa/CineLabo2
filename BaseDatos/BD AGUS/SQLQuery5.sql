create database cine5
go
use cine5
go
--Formato 3D - 2D - 4D (Va contra funciones)
CREATE TABLE TIPO_FORMATO(
ID_TIPO_FORMATO INT IDENTITY (1,1)PRIMARY KEY,
DESCRIPCION VARCHAR(20),
)
--Genero de Peliculas
CREATE TABLE GENERO(
ID_GENERO INT IDENTITY (1,1)PRIMARY KEY,
DESCRIPCION VARCHAR(20)
)
--ATP, +13, +18, +21
CREATE TABLE CLASIFICACION(
ID_CLASIFICACION INT IDENTITY (1,1)PRIMARY KEY,
DESCRIPCION VARCHAR(20)
)
--CREATE TABLE ESTADOS_PAGO(
--ID_ESTADO_PAGO INT PRIMARY KEY,
--DESCRIPCION VARCHAR(20)
--)
CREATE TABLE FORMA_PAGO(
ID_FORMA_PAGO INT IDENTITY (1,1)PRIMARY KEY,
DESCRIPCION VARCHAR(20)
)
--CREATE TABLE FORMA_COMPRA(
--ID_FORMA_COMPRA INT PRIMARY KEY,
--DESCRIPCION VARCHAR(20)
--)
--CREATE TABLE TIPOS_SALA(
--ID_TIPO_SALA INT IDENTITY (1,1) PRIMARY KEY,
--DESCRIPCION VARCHAR(20)
--)
CREATE TABLE TIPOS_DOC(
ID_TIPO_DOC INT IDENTITY (1,1)PRIMARY KEY,
DESCRIPCION VARCHAR(20)
)

CREATE TABLE CARGOS(
ID_CARGO INT IDENTITY (1,1)PRIMARY KEY,
DESCRIPCION VARCHAR(20)
)

CREATE TABLE ACTORES(
ID_ACTOR INT IDENTITY (1,1)PRIMARY KEY,
NOMBRE VARCHAR(25),
APELLIDO VARCHAR(25),
FEC_COMIENZO DATETIME,
FEC_NAC DATETIME
)

CREATE TABLE DIRECTORES(
ID_DIRECTOR INT IDENTITY (1,1)PRIMARY KEY,
NOMBRE VARCHAR(25),
APELLIDO VARCHAR(25),
FEC_COMIENZO DATETIME,
FEC_NAC DATETIME
)

CREATE TABLE IDIOMAS(
ID_IDIOMA INT IDENTITY (1,1)PRIMARY KEY,
IDIOMA VARCHAR(20)
)

CREATE TABLE PAIS_ORIGEN(
ID_PAIS_ORIGEN INT IDENTITY (1,1 )PRIMARY KEY,
PAIS VARCHAR (30))
--CREATE TABLE TIPO_BUTACAS(
--ID_TIPO_BUTACA INT PRIMARY KEY,
--TIPO_BUTACA VARCHAR(20))

CREATE TABLE PROVINCIAS(
ID_PROVINCIA INT IDENTITY (1,1)PRIMARY KEY,
PROVINCIA VARCHAR(50))

CREATE TABLE LOCALIDADES(
ID_LOCALIDAD INT IDENTITY (1,1) PRIMARY KEY,
LOCACLIDAD VARCHAR(50),
ID_PROVINCIA INT
CONSTRAINT fk_prov_localidad  FOREIGN KEY (ID_PROVINCIA)
references PROVINCIAS(ID_PROVINCIA))

CREATE TABLE BARRIOS(
ID_BARRIO INT IDENTITY (1,1)PRIMARY KEY,
BARRIOS VARCHAR (50),
ID_LOCALIDAD INT
CONSTRAINT FK_LOCALIDAD_BARRIOS  FOREIGN KEY (ID_LOCALIDAD)
references LOCALIDADES(ID_LOCALIDAD))

CREATE TABLE CLIENTES(
ID_CLIENTE INT IDENTITY(1,1) PRIMARY KEY,
NOMBRE_CLIENTE VARCHAR(25),
/*SOCIO BOOL*/ 
APELLIDO_CLIENTE VARCHAR(20),
ID_TIPO_DOC INT,
DOCUMENTO BIGINT,
TELEFONO BIGINT,
EMAIL VARCHAR(50),
CONSTRAINT FK_CLIENTES_TIPODOC FOREIGN KEY(ID_TIPO_DOC)
REFERENCES TIPOS_DOC(ID_TIPO_DOC))

CREATE TABLE RESERVAS(
ID_RESERVA INT IDENTITY(1,1) PRIMARY KEY,
ID_CLIENTE INT,
FECHA_RESERVA DATETIME
CONSTRAINT FK_RESERVAS_CLIENTES FOREIGN KEY(ID_CLIENTE)
REFERENCES CLIENTES(ID_CLIENTE))


CREATE TABLE EMPLEADOS(
ID_EMPLEADO INT IDENTITY(1,1) PRIMARY KEY,
NOMBRE_EMPLEADO VARCHAR(20),
APELLIDO_EMPLEADO VARCHAR(20),
EMAIL VARCHAR(20),
ID_BARRIO INT,
ID_CARGO INT,
CONSTRAINT FK_EMPLEADOS_BARRIOS FOREIGN KEY (ID_BARRIO)
REFERENCES BARRIOS(ID_BARRIO),
CONSTRAINT FK_EMPLEADO_CARGO FOREIGN KEY(ID_CARGO)
REFERENCES CARGOS(ID_CARGO)
)


CREATE TABLE SALAS(
ID_SALA INT IDENTITY(1,1) PRIMARY KEY,
--ID_TIPO_SALA INT,
CANTIDAD_ASIENTOS INT
--CONSTRAINT FK_SALAS_TIPOSALA FOREIGN KEY(ID_TIPO_SALA)
--REFERENCES TIPOS_SALA(ID_TIPO_SALA)
)
CREATE TABLE BUTACAS(
ID_BUTACA INT IDENTITY(1,1) PRIMARY KEY ,
NRO_BUTACA INT,
FILA INT,
ID_SALA INT
--ID_TIPO_BUTACA INT

CONSTRAINT FK_BUTACAS_SALAS FOREIGN KEY (ID_SALA)
REFERENCES SALAS(ID_SALA)
--CONSTRAINT FK_BUTACAS_TIPO_BUTACA FOREIGN KEY (ID_TIPO_BUTACA)
--REFERENCES TIPO_BUTACAS(ID_TIPO_BUTACA)
)

CREATE TABLE PELICULAS(
ID_PELICULA INT IDENTITY(1,1) PRIMARY KEY,
TITULO VARCHAR(100),
DURACION TIME,
ID_GENERO INT,
ID_CLASIFICACION INT,
ID_TIPO_FORMATO INT,
ID_IDIOMA INT,
FEC_ESTRENO DATETIME,
ID_PAIS_ORIGEN INT
CONSTRAINT FK_PELI_GENERO FOREIGN KEY(ID_GENERO)
REFERENCES GENERO(ID_GENERO),
CONSTRAINT FK_PELI_CLASIFICACION FOREIGN KEY(ID_CLASIFICACION)
REFERENCES CLASIFICACION (ID_CLASIFICACION),
CONSTRAINT FK_PELI_IDIOMA FOREIGN KEY (ID_IDIOMA)
REFERENCES IDIOMAS(ID_IDIOMA),
CONSTRAINT FK_PELI_PAIS FOREIGN KEY(ID_PAIS_ORIGEN)
REFERENCES PAIS_ORIGEN(ID_PAIS_ORIGEN)
)


CREATE TABLE FUNCIONES(
ID_FUNCION INT IDENTITY(1,1) PRIMARY KEY,
HORA TIME,
FECHA DATETIME,
ID_SALA INT,
ID_PELICULA INT,
PRECIO_ACTUAL MONEY,
ID_TIPO_FORMATO INT,
CONSTRAINT FK_FUNCION_SALA FOREIGN KEY(ID_SALA)
REFERENCES SALAS(ID_SALA),
CONSTRAINT FK_FUNCION_PELI FOREIGN KEY (ID_PELICULA)
REFERENCES PELICULAS(ID_PELICULA),
CONSTRAINT FK_FUNCION_TIPO_FORMATO FOREIGN KEY (ID_TIPO_FORMATO)
REFERENCES TIPO_FORMATO(ID_TIPO_FORMATO)
)
CREATE TABLE BUTACAS_FUNCION(
ID_BUTACAS_FUNCION INT PRIMARY KEY,
ID_BUTACA INT,
ID_FUNCION INT,
ID_RESERVA INT
CONSTRAINT BUT_FUNCION_BUTACA FOREIGN KEY(ID_BUTACA)
REFERENCES BUTACAS(ID_BUTACA),
CONSTRAINT BT_FUN_FUNCION FOREIGN KEY(ID_FUNCION)
REFERENCES FUNCIONES(ID_FUNCION),
CONSTRAINT BUT_FUN_RESERVA FOREIGN KEY(ID_RESERVA)
REFERENCES RESERVAS(ID_RESERVA)
)

CREATE TABLE ACTORES_PELICULAS(
ID_ACTORES_PELICULAS INT IDENTITY(1,1)PRIMARY KEY,
ID_PELICULA INT,
ID_ACTOR INT 
CONSTRAINT FK_ACTORES_PELICULAS_PELI FOREIGN KEY(ID_PELICULA)
REFERENCES PELICULAS(ID_PELICULA),
CONSTRAINT FK_ACT_PELI_ACTORES FOREIGN KEY(ID_ACTOR)
REFERENCES ACTORES(ID_ACTOR)
)

CREATE TABLE CINES(
ID_CINE INT IDENTITY (1,1)PRIMARY KEY,
ID_BARRIO INT,
NOMBRE_CINE VARCHAR(20),
CONSTRAINT FK_CINES_BARRIOS FOREIGN KEY(ID_BARRIO)
REFERENCES BARRIOS(ID_BARRIO)

)

CREATE TABLE COMPROBANTES(
ID_COMPROBANTE INT IDENTITY(1,1) PRIMARY KEY,
ID_CLIENTE INT,
ID_EMPLEADO INT,
FECHA DATETIME,
ID_CINE INT,
CONSTRAINT FK_COMP_CLIENTE FOREIGN KEY (ID_CLIENTE)
REFERENCES CLIENTES(ID_CLIENTE),
CONSTRAINT FK_COMP_EMPLEADO FOREIGN KEY(ID_EMPLEADO)
REFERENCES EMPLEADOS(ID_EMPLEADO),
CONSTRAINT FK_COMP_CINE FOREIGN KEY(ID_CINE)
REFERENCES CINES(ID_CINE)
--CONSTRAINT FK_COMP_FORMA_COMPRA FOREIGN KEY(ID_FORMA_COMPRA)
--REFERENCES FORMA_COMPRA(ID_FORMA_COMPRA),
--CONSTRAINT FK_COMP_ESTADO FOREIGN KEY(ID_ESTADO_PAGO)
--REFERENCES ESTADOS_PAGO(ID_ESTADO_PAGO),

)
CREATE TABLE DETALLES_COMPROBANTES(
ID_DET_COMPROBANTE INT IDENTITY(1,1) PRIMARY KEY,
ID_COMPROBANTE INT,
ID_FUNCION INT,
ID_BUTACAS_FUNCION INT,
ID_FORMA_PAGO INT,
PRECIO MONEY
CONSTRAINT FK_DET_COMP_COMP FOREIGN KEY(ID_COMPROBANTE)
REFERENCES COMPROBANTES(ID_COMPROBANTE),
CONSTRAINT FK_DET_COMP_FUNC FOREIGN KEY (ID_FUNCION)
REFERENCES FUNCIONES(ID_FUNCION),
CONSTRAINT FK_DET_COMP_BUT_FUN FOREIGN KEY(ID_BUTACAS_FUNCION)
REFERENCES BUTACAS_FUNCION(ID_BUTACAS_FUNCION),
CONSTRAINT FK_DET_COMP_FRMPAGO FOREIGN KEY(ID_FORMA_PAGO)
REFERENCES FORMA_PAGO(ID_FORMA_PAGO)
)

CREATE TABLE TICKET(
ID_TICKET INT IDENTITY(1,1)PRIMARY KEY,
ID_COMPROBANTE INT,
ID_BUTACA INT,
ID_FUNCION INT,
PRECIO MONEY,
CONSTRAINT FK_TIC_COMP FOREIGN KEY(ID_COMPROBANTE)
REFERENCES COMPROBANTES(ID_COMPROBANTE),
CONSTRAINT FK_TIC_BUT FOREIGN KEY(ID_BUTACA)
REFERENCES BUTACAS(ID_BUTACA),
CONSTRAINT FK_TIC_FUN FOREIGN KEY(ID_FUNCION)
REFERENCES FUNCIONES(ID_FUNCION)
)

-- Tabla para los Productos del Candy Bar
CREATE TABLE PRODUCTOS_CANDY_BAR (
    ID_PRODUCTO_CANDY_BAR INT IDENTITY(1, 1) PRIMARY KEY,
    NOMBRE VARCHAR(50),
    DESCRIPCION VARCHAR(200),
    PRECIO MONEY,
    ID_CINE INT,
    CONSTRAINT FK_PRODUCTOS_CANDY_BAR_CINE FOREIGN KEY (ID_CINE)
        REFERENCES CINES (ID_CINE)
);

-- Tabla para las Ventas del Candy Bar
CREATE TABLE VENTAS_CANDY_BAR (
    ID_VENTA_CANDY_BAR INT IDENTITY(1, 1) PRIMARY KEY,
    ID_COMPROBANTE INT,
    ID_PRODUCTO_CANDY_BAR INT,
    CANTIDAD INT,
    PRECIO_TOTAL MONEY,
    CONSTRAINT FK_VENTAS_COMPROBANTE FOREIGN KEY (ID_COMPROBANTE)
        REFERENCES COMPROBANTES (ID_COMPROBANTE),
    CONSTRAINT FK_VENTAS_PRODUCTO_CANDY_BAR FOREIGN KEY (ID_PRODUCTO_CANDY_BAR)
        REFERENCES PRODUCTOS_CANDY_BAR (ID_PRODUCTO_CANDY_BAR)
);

-- Tabla para Productos Favoritos (opcional)
CREATE TABLE PRODUCTOS_FAVORITOS (
    ID_PRODUCTO_FAVORITO INT IDENTITY(1, 1) PRIMARY KEY,
    ID_CLIENTE INT,
    ID_PRODUCTO_CANDY_BAR INT,
    FECHA_ADICION DATETIME,
    CONSTRAINT FK_PRODUCTOS_FAVORITOS_CLIENTE FOREIGN KEY (ID_CLIENTE)
        REFERENCES CLIENTES (ID_CLIENTE),
    CONSTRAINT FK_PRODUCTOS_FAVORITOS_PRODUCTO_CANDY_BAR FOREIGN KEY (ID_PRODUCTO_CANDY_BAR)
        REFERENCES PRODUCTOS_CANDY_BAR (ID_PRODUCTO_CANDY_BAR)
);

