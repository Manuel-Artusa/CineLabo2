CREATE PROCEDURE SP_CONSULTAR_PELICULAS_DETALLADO
AS
BEGIN
    SELECT
        P.id_pelicula,
        P.Titulo,
        P.duracion,
        G.id_genero,
        G.DESCRIPCION,
        C.id_clasificacion,
        C.Descripcion AS DescripcionClasificacion,
        I.id_idioma,
        I.IDIOMA,
        P.Fec_Estreno
    FROM
        Peliculas P
    JOIN
        Genero G ON P.id_genero = G.id_genero
    JOIN
        Clasificacion C ON P.id_clasificacion = C.id_clasificacion
    JOIN
        Idiomas I ON P.id_idioma = I.id_idioma;
END;
SELECT * FROM PELICULAS


CREATE PROCEDURE SP_CONSULTAR_PELICULAS_DETALLADO2
AS
BEGIN
    SELECT
        P.ID_PELICULA,
        P.TITULO,
        P.DURACION,
        G.ID_GENERO,
        G.DESCRIPCION AS NombreGenero,
        C.ID_CLASIFICACION,
        C.DESCRIPCION AS DescripcionClasificacion,
        I.ID_IDIOMA,
        I.IDIOMA AS Lenguaje,
        P.FEC_ESTRENO,
        PO.ID_PAIS_ORIGEN,
        PO.PAIS AS Pais
    FROM
        PELICULAS P
    INNER JOIN
        GENERO G ON P.ID_GENERO = G.ID_GENERO
    INNER JOIN
        CLASIFICACION C ON P.ID_CLASIFICACION = C.ID_CLASIFICACION
    INNER JOIN
        IDIOMAS I ON P.ID_IDIOMA = I.ID_IDIOMA
    INNER JOIN
        PAIS_ORIGEN PO ON P.ID_PAIS_ORIGEN = PO.ID_PAIS_ORIGEN
END

select * from PELICULAS



CREATE PROCEDURE SP_OBTENER_GENEROS
AS
BEGIN
    -- Obtener géneros
    SELECT ID_GENERO, DESCRIPCION
    FROM GENERO;
END

CREATE PROCEDURE SP_OBTENER_CLIENTES_DETALLADO
AS
BEGIN
    SELECT
        C.ID_CLIENTE,
        C.NOMBRE_CLIENTE,
        C.APELLIDO_CLIENTE,
        T.ID_TIPO_DOC,
        T.DESCRIPCION AS TIPO_DOCUMENTO,
        C.DOCUMENTO,
        C.TELEFONO,
        C.EMAIL
    FROM
        CLIENTES C
        INNER JOIN TIPOS_DOC T ON C.ID_TIPO_DOC = T.ID_TIPO_DOC
END

CREATE PROCEDURE SP_CONSULTAR_CLIENTES_CON_TOTAL_GASTADO
AS
BEGIN
    SELECT
        C.ID_CLIENTE,
        C.NOMBRE_CLIENTE,
        C.APELLIDO_CLIENTE,
        T.ID_TIPO_DOC,
        T.DESCRIPCION AS TIPO_DOCUMENTO,
        C.DOCUMENTO,
        C.TELEFONO,
        C.EMAIL,
        ISNULL(SUM(DC.PRECIO), 0) AS TOTAL_GASTADO
    FROM
        CLIENTES C
        INNER JOIN TIPOS_DOC T ON C.ID_TIPO_DOC = T.ID_TIPO_DOC
        LEFT JOIN COMPROBANTES CMP ON C.ID_CLIENTE = CMP.ID_CLIENTE
        LEFT JOIN DETALLES_COMPROBANTES DC ON CMP.ID_COMPROBANTE = DC.ID_COMPROBANTE
    GROUP BY
        C.ID_CLIENTE, C.NOMBRE_CLIENTE, C.APELLIDO_CLIENTE, T.ID_TIPO_DOC, T.DESCRIPCION, C.DOCUMENTO, C.TELEFONO, C.EMAIL
END

CREATE PROCEDURE SP_CONSULTAR_CLIENTES_POR_GENERO_PUNTAJE
    @GeneroPelicula VARCHAR(20)
AS
BEGIN
    SELECT
        C.ID_CLIENTE,
        C.NOMBRE_CLIENTE +' '+C.APELLIDO_CLIENTE AS NOMBRE_APELLIDO,
        T.ID_TIPO_DOC,
        T.DESCRIPCION AS TIPO_DOCUMENTO,
        C.DOCUMENTO,
        C.TELEFONO,
        C.EMAIL,
        SUM(DC.PRECIO) AS TotalGastado
    FROM
        CLIENTES C
        INNER JOIN TIPOS_DOC T ON C.ID_TIPO_DOC = T.ID_TIPO_DOC
        LEFT JOIN COMPROBANTES CMP ON C.ID_CLIENTE = CMP.ID_CLIENTE
        LEFT JOIN DETALLES_COMPROBANTES DC ON CMP.ID_COMPROBANTE = DC.ID_COMPROBANTE
        LEFT JOIN FUNCIONES F ON DC.ID_FUNCION = F.ID_FUNCION
        LEFT JOIN PELICULAS P ON F.ID_PELICULA = P.ID_PELICULA
        LEFT JOIN GENERO G ON P.ID_GENERO = G.ID_GENERO
    WHERE
        G.DESCRIPCION = @GeneroPelicula
    GROUP BY
        C.ID_CLIENTE,
        C.NOMBRE_CLIENTE,
        C.APELLIDO_CLIENTE,
        T.ID_TIPO_DOC,
        T.DESCRIPCION,
        C.DOCUMENTO,
        C.TELEFONO,
        C.EMAIL
    ORDER BY
        TotalGastado DESC;
	END;

create PROCEDURE SP_CONSULTAR_TOP3_CLIENTES_POR_GENERO_PUNTAJE
    @GeneroPelicula VARCHAR(20)
AS
BEGIN
    WITH ClientesNumerados AS (
        SELECT
            C.ID_CLIENTE,
            C.NOMBRE_CLIENTE,
            C.APELLIDO_CLIENTE,
            T.ID_TIPO_DOC,
            T.DESCRIPCION AS TIPO_DOCUMENTO,
            C.DOCUMENTO,
            C.TELEFONO,
            C.EMAIL,
            SUM(DC.PRECIO) AS TotalGastado,
            ROW_NUMBER() OVER (ORDER BY SUM(DC.PRECIO) DESC) AS NumeroFila
        FROM
            CLIENTES C
            INNER JOIN TIPOS_DOC T ON C.ID_TIPO_DOC = T.ID_TIPO_DOC
            LEFT JOIN COMPROBANTES CMP ON C.ID_CLIENTE = CMP.ID_CLIENTE
            LEFT JOIN DETALLES_COMPROBANTES DC ON CMP.ID_COMPROBANTE = DC.ID_COMPROBANTE
            LEFT JOIN FUNCIONES F ON DC.ID_FUNCION = F.ID_FUNCION
            LEFT JOIN PELICULAS P ON F.ID_PELICULA = P.ID_PELICULA
            LEFT JOIN GENERO G ON P.ID_GENERO = G.ID_GENERO
        WHERE
            G.DESCRIPCION = @GeneroPelicula
        GROUP BY
            C.ID_CLIENTE,
            C.NOMBRE_CLIENTE,
            C.APELLIDO_CLIENTE,
            T.ID_TIPO_DOC,
            T.DESCRIPCION,
            C.DOCUMENTO,
            C.TELEFONO,
            C.EMAIL
    )
    
    SELECT
        ID_CLIENTE,
        NOMBRE_CLIENTE,
        APELLIDO_CLIENTE,
        TIPO_DOCUMENTO,
        DOCUMENTO,
        TELEFONO,
        EMAIL,
        TotalGastado
    FROM
        ClientesNumerados
    WHERE
        NumeroFila <= 3;
END


select * from PELICULAS
/*Informe de ventas por mes */
drop procedure InformeVentasPorMes
	CREATE PROCEDURE InformeVentasPorMes
  @FechaInicio DATETIME,
  @FechaFin DATETIME
AS
BEGIN
  SELECT DATENAME(MONTH, c.FECHA) AS MES, SUM(dc.PRECIO) AS Ventas
  FROM COMPROBANTES c
  JOIN DETALLES_COMPROBANTES dc ON c.ID_COMPROBANTE = dc.ID_COMPROBANTE
  WHERE c.FECHA BETWEEN @FechaInicio AND @FechaFin
  GROUP BY DATEPART(YEAR, c.FECHA), DATENAME(MONTH, c.FECHA)
  order by DATENAME(MONTH, c.FECHA)
END;
------------------------------------------------------------------------------------------------------------------------------------------------
drop procedure InformeVentasPorMesConCine
CREATE PROCEDURE InformeVentasPorMesConCine
  @FechaInicio DATETIME,
  @FechaFin DATETIME,
  @NombreCine VARCHAR(100)
  as
  begin 
  select datename(month,c.FECHA) as MES, sum(dc.PRECIO) 'total de Ventas', ci.NOMBRE_CINE 'Cine'
  from COMPROBANTES c join
  DETALLES_COMPROBANTES dc on c.ID_COMPROBANTE = dc.ID_COMPROBANTE
  join CINES ci on ci.ID_CINE = c.ID_CINE 
  where @NombreCine like '%' + @NombreCine + '%'  and 
  c.FECHA between @FechaInicio and @FechaFin

  group by DATENAME(MONTH,c.FECHA), ci.NOMBRE_CINE
  order by MES desc
  end;
  exec InformeVentasPorMesConCine @fechaInicio = '2023/01/01',@FechaFin = '2023/10/10', @NombreCine = 'Cine Los Pinos'
	
------------------------------------------------------------------------------------------------------------------------------------------------
 create procedure SP_CONSULTAR_DETALLES
   AS
   BEGIN
   SELECT * FROM DETALLES_COMPROBANTES
   END;
   ------------------------------------------------------------------------------------------------------------------------------------------------
   create procedure SP_CONSULTAR_COMPROBANTES
   AS
   BEGIN
   SELECT * FROM COMPROBANTES
   END;
   ------------------------------------------------------------------------------------------------------------------------------------------------
   create procedure SP_CONSULTAR_CINES
   AS
   BEGIN 
   SELECT * FROM CINES
   END;

   ------------------------------------------------------------------------------------------------------------------------------------------------
   create procedure IMejoresFormasPago
@FechaInicio DATETIME,
  @FechaFin DATETIME
  as
  begin
  select fp.DESCRIPCION 'Forma de Pago', SUM(dc.PRECIO) 'Monto Recaudado'
  from DETALLES_COMPROBANTES dc
  join FORMA_PAGO fp on fp.ID_FORMA_PAGO = dc.ID_FORMA_PAGO
  join COMPROBANTES c on c.ID_COMPROBANTE = dc.ID_COMPROBANTE
  where c.FECHA between @FechaInicio and @FechaFin
  group by fp.DESCRIPCION
  order by SUM(dc.PRECIO) desc;
  end;

  
  exec IMejoresFormasPago '2023/01/01','2024/01/01'
  ------------------------------------------------------------------------------------------------------------------------------------------------

  create procedure ObtenerButacasDisponibles
  @TituloPelicula varchar(100),
  @HoraFuncion varchar(8),
  @NroSala int,
  @FechaFuncion datetime
  as 
  begin
	select distinct bf.ID_BUTACA
	from BUTACAS_FUNCION bf 
	join FUNCIONES f on f.ID_FUNCION = bf.ID_FUNCION
	join PELICULAS p on p.ID_PELICULA = f.ID_PELICULA
	where p.TITULO = @TituloPelicula
	and f.HORA = @HoraFuncion
	and f.ID_SALA = @NroSala
	and f.FECHA = @FechaFuncion
	and bf.ID_BUTACA not exists(select bff.ID_BUTACA
	from DETALLES_COMPROBANTES dc 
	join BUTACAS_FUNCION bff on bff.ID_BUTACAS_FUNCION = dc.ID_BUTACAS_FUNCION)


