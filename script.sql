USE [master]
GO
/****** Object:  Database [tiendaPaletas]    Script Date: 20/05/2021 12:24:03 p. m. ******/
CREATE DATABASE [tiendaPaletas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'tiendaPaletas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER01\MSSQL\DATA\tiendaPaletas.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'tiendaPaletas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER01\MSSQL\DATA\tiendaPaletas_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [tiendaPaletas] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [tiendaPaletas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [tiendaPaletas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [tiendaPaletas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [tiendaPaletas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [tiendaPaletas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [tiendaPaletas] SET ARITHABORT OFF 
GO
ALTER DATABASE [tiendaPaletas] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [tiendaPaletas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [tiendaPaletas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [tiendaPaletas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [tiendaPaletas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [tiendaPaletas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [tiendaPaletas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [tiendaPaletas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [tiendaPaletas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [tiendaPaletas] SET  ENABLE_BROKER 
GO
ALTER DATABASE [tiendaPaletas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [tiendaPaletas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [tiendaPaletas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [tiendaPaletas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [tiendaPaletas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [tiendaPaletas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [tiendaPaletas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [tiendaPaletas] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [tiendaPaletas] SET  MULTI_USER 
GO
ALTER DATABASE [tiendaPaletas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [tiendaPaletas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [tiendaPaletas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [tiendaPaletas] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [tiendaPaletas] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'tiendaPaletas', N'ON'
GO
ALTER DATABASE [tiendaPaletas] SET QUERY_STORE = OFF
GO
USE [tiendaPaletas]
GO
/****** Object:  User [NT AUTHORITY\SYSTEM]    Script Date: 20/05/2021 12:24:03 p. m. ******/
CREATE USER [NT AUTHORITY\SYSTEM] FOR LOGIN [NT AUTHORITY\SYSTEM] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [NT AUTHORITY\SYSTEM]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 20/05/2021 12:24:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[imagen] [image] NULL,
 CONSTRAINT [PK_Categorias] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estadisticas]    Script Date: 20/05/2021 12:24:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estadisticas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[total] [float] NOT NULL,
 CONSTRAINT [PK_Estadisticas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Insumos]    Script Date: 20/05/2021 12:24:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Insumos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombreInsumo] [varchar](50) NOT NULL,
	[cantidadInsumo] [int] NOT NULL,
 CONSTRAINT [PK_Insumos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 20/05/2021 12:24:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](255) NOT NULL,
	[categoria_id] [int] NOT NULL,
	[precioProd] [float] NOT NULL,
	[cantidadProd] [int] NOT NULL,
	[tamañoProd] [varchar](50) NOT NULL,
	[imagenProd] [image] NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rols]    Script Date: 20/05/2021 12:24:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rols](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[rol_nombre] [varchar](255) NOT NULL,
 CONSTRAINT [PK_rols] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 20/05/2021 12:24:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](255) NOT NULL,
	[rol_id] [int] NOT NULL,
	[numero_empleado] [int] NOT NULL,
	[foto] [image] NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 20/05/2021 12:24:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[producto_id] [int] NOT NULL,
	[usuario_id] [int] NOT NULL,
	[total_venta] [float] NOT NULL,
 CONSTRAINT [PK_Ventas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Categorias] FOREIGN KEY([categoria_id])
REFERENCES [dbo].[Categorias] ([id])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Categorias]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_rols] FOREIGN KEY([rol_id])
REFERENCES [dbo].[rols] ([id])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_rols]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Productos] FOREIGN KEY([producto_id])
REFERENCES [dbo].[Productos] ([id])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Productos]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Usuarios] FOREIGN KEY([usuario_id])
REFERENCES [dbo].[Usuarios] ([id])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Usuarios]
GO
/****** Object:  StoredProcedure [dbo].[eliminarCategoria]    Script Date: 20/05/2021 12:24:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[eliminarCategoria]
	@id int
as
if exists(select nombre from Categorias where id = @id)
DELETE FROM Productos WHERE categoria_id = @id
DELETE FROM Categorias WHERE id = @id

GO
/****** Object:  StoredProcedure [dbo].[eliminarProducto]    Script Date: 20/05/2021 12:24:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[eliminarProducto] 
	@nombre varchar(50), @idCategoria int
as
if exists(select nombre from Productos where nombre = @nombre)
DELETE FROM Productos WHERE nombre = @nombre AND categoria_id = @idCategoria


GO
/****** Object:  StoredProcedure [dbo].[insertar_usuario]    Script Date: 20/05/2021 12:24:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_usuario]
@nombre varchar(255), @foto image, @numero_empleado int, @rol_id int
as 
if exists(select * from Usuarios where numero_empleado = @numero_empleado)
raiserror ('Este producto ya existe, prueba con otro',16,1)
else
insert into Usuarios values (@nombre, @rol_id, @numero_empleado, @foto)
GO
/****** Object:  StoredProcedure [dbo].[insertarCategoria]    Script Date: 20/05/2021 12:24:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertarCategoria]
@nombre varchar(50), @imagen image
as
if exists (select * from Categorias where nombre = @nombre)
UPDATE Categorias SET nombre = @nombre, imagen = @imagen WHERE nombre = @nombre;
else
if not exists (select * from Categorias where nombre = @nombre)
insert into Categorias values (@nombre,@imagen)
else
raiserror ('Esta categoria ya existe, prueba con otro nombre',16,1)
GO
/****** Object:  StoredProcedure [dbo].[insertarInsumo]    Script Date: 20/05/2021 12:24:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertarInsumo]
@nombreInsumo varchar(50), @cantidadInsumo  int
as
if not exists(select nombreInsumo from Insumos where nombreInsumo = @nombreInsumo)
insert into Insumos values (@nombreInsumo, @cantidadInsumo)
else
if exists(select nombreInsumo from Insumos where nombreInsumo = @nombreInsumo)
UPDATE Insumos 
SET cantidadInsumo = @cantidadInsumo
WHERE nombreInsumo = @nombreInsumo;
GO
/****** Object:  StoredProcedure [dbo].[insertarProducto]    Script Date: 20/05/2021 12:24:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertarProducto]
@nombre varchar(50), @idCategoria int, @precioProd float, @cantidadProd int, @tamañoProd varchar(50), @imagenProd image
as
if not exists(select nombre from Productos where nombre = @nombre)
insert into Productos values (@nombre,@idCategoria, @precioProd, @cantidadProd, @tamañoProd, @imagenProd)
else
if exists(select nombre from Productos where nombre = @nombre)
UPDATE Productos 
SET precioProd = @precioProd, cantidadProd = @cantidadProd, tamañoProd = @tamañoProd, imagenProd = @imagenProd
WHERE nombre = @nombre;
/*raiserror ('Este producto ya existe, intenta con otro nombre',16,1)*/
GO
/****** Object:  StoredProcedure [dbo].[mostrarProductos]    Script Date: 20/05/2021 12:24:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrarProductos]
@id int
as
select * from Productos inner join Categorias
on Categorias.id = Productos.categoria_id
where Productos.categoria_id = @id
GO
USE [master]
GO
ALTER DATABASE [tiendaPaletas] SET  READ_WRITE 
GO
