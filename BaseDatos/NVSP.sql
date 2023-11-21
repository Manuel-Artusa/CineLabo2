
CREATE PROCEDURE ObtenerButacasDisponiblesConInfo
    @Titulo VARCHAR(100),
    @fechaFuncion datetime ,
    @id_sala INT ,
    @HoraFuncion TIME 
AS
BEGIN
    -- Seleccionar el nombre de la película, la función, el día, la sala y las butacas disponibles
    SELECT P.Titulo AS NombrePelicula, F.Hora AS HoraFuncion, B.id_butaca, B.nro_butaca, B.fila
    FROM BUTACAS b 
	join butacas_salas bs on bs.id_butaca = b.ID_BUTACA
	join FUNCIONES_SALAS fs on fs.ID_SALA = bs.id_sala
	join Pelicula_Funciones pf on fs.ID_FUNCION = pf.id_funcion
	join PELICULAS p on p.ID_PELICULA = pf.id_pelicula
	join FUNCIONES f on f.ID_FUNCION = pf.id_funcion
    WHERE  NOT EXISTS (
        -- Excluir las butacas ya compradas para la película, función, sala y fecha seleccionadas
        SELECT dc.id_butaca
        FROM Detalle_Comprobante DC
		where dc.id_butaca = bs.id_butacas_Sala
    )
    AND P.Titulo LIKE '%' + @Titulo + '%'
	AND F.FECHA = @fechaFuncion
          AND F.Hora = @HoraFuncion
		  AND FS.id_sala = @id_sala
	 
END;


EXEC ObtenerButacasDisponiblesConInfo @titulo = 'Iron',@FechaFuncion ='17/11/2023', @HoraFuncion = '22:30:00', @id_sala = 1

---------------------------------------------------------------------------------------------------------------------------------------------------------------
  alter procedure SP_CONSULTAR_FUNCIONES
  @fecha varchar(50),
  @pelicula varchar(100)
  AS
  BEGIN
  set dateformat dmy
  SELECT f.ID_FUNCION,f.FECHA,f.HORA,p.ID_PELICULA,p.TITULO,f.PRECIO_ACTUAL 
  FROM FUNCIONES f 
  join PELICULAS p on p.id_pelicula = f.id_pelicula
  where @fecha = f.FECHA
  AND @pelicula = p.TITULO
  END;
  EXEC SP_CONSULTAR_FUNCIONES @Fecha = '17/11/2023', @pelicula = 'Iron Man'

 select * from FUNCIONES
 select * from PELICULAS
 update FUNCIONES 
 set ID_PELICULA = 16

  ---------------------------------------------------------------------------------------------------------------------------------------------------------------
   ------------------------------------------------------------------------------------------------------------------------------------------------
  drop procedure SP_CONSULTAR_PELICULAS
  create procedure SP_CONSULTAR_PELICULAS
  AS
  BEGIN
  SELECT  p.ID_PELICULA, p.TITULO,p.DURACION,p.ID_CLASIFICACION,p.ID_IDIOMA,p.FEC_ESTRENO,p.ID_PAIS_ORIGEN  
  FROM PELICULAS p
  END;

  EXEC SP_CONSULTAR_PELICULAS
   ------------------------------------------------------------------------------------------------------------------------------------------------
   drop procedure SP_CONSULTAR_DETALLES
   create procedure SP_CONSULTAR_DETALLES
   AS
   BEGIN
   SELECT * FROM DETALLE_COMPROBANTE
   END;
   ------------------------------------------------------------------------------------------------------------------------------------------------
   create procedure SP_CONSULTAR_COMPROBANTES
   AS
   BEGIN
   SELECT * FROM COMPROBANTES
   END;
   -------------------------------------------------------------------------------------------------------------------------------------------------
   alter procedure GenerarCompra
   @Cliente int,
   @Fecha datetime,
   @idComprobante int output
   as
   begin 
		Insert into COMPROBANTES (id_cliente,id_empleado,fecha,id_cine)
		VALUES (@Cliente,1,@Fecha,1)
		set @idComprobante = SCOPE_IDENTITY();
	end;
-------------------------------------------------------------------------------------------------------------------------------------------------
  alter procedure GenerarCliente
  @nombre varchar(20),
  @apellido varchar (20),
  @documento int,
  @telefono int,
  @email varchar (70),
  @id_cliente int OUTPUT
  as
  begin
		insert into Clientes(NOMBRE_CLIENTE,APELLIDO_CLIENTE,ID_TIPO_DOC,DOCUMENTO,TELEFONO,EMAIL)
		values (@nombre,@apellido,1,@documento,@telefono,@email)
		set @id_cliente = SCOPE_IDENTITY();
end;

exec GenerarCliente 'Franco', 'Lentini', 123123, 123, 'tummama'
		-------------------------------------------------------------------------------------------------------------------------------------------------
alter PROCEDURE GenerarDetalle
@idComprobante int,
@idCandy int,
@idFuncion int,
@idSala int,
@precio float
as
begin
     insert into DETALLE_COMPROBANTE(id_comprobante, id_venta_candy_bar, id_funcion, id_sala, precio_total)
	 values(@idComprobante, @idCandy, @idFuncion, @idSala, @precio)
	 end;
	 -------------------------------------------------------------------------------------------------------------------------------------------------
create proc SP_INSERTAR_BUTACA
@idButaca int 
as
begin 
insert into SALAS(id_butaca) values (@idButaca)
end

