USE [master]
GO
/****** Object:  Database [inventario]    Script Date: 24/04/2020 20:46:45 ******/
CREATE DATABASE [inventario]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'inventario', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\inventario.mdf' , SIZE = 8384KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'inventario_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\inventario_log.ldf' , SIZE = 2368KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [inventario] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [inventario].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [inventario] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [inventario] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [inventario] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [inventario] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [inventario] SET ARITHABORT OFF 
GO
ALTER DATABASE [inventario] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [inventario] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [inventario] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [inventario] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [inventario] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [inventario] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [inventario] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [inventario] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [inventario] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [inventario] SET  DISABLE_BROKER 
GO
ALTER DATABASE [inventario] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [inventario] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [inventario] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [inventario] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [inventario] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [inventario] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [inventario] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [inventario] SET RECOVERY FULL 
GO
ALTER DATABASE [inventario] SET  MULTI_USER 
GO
ALTER DATABASE [inventario] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [inventario] SET DB_CHAINING OFF 
GO
ALTER DATABASE [inventario] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [inventario] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [inventario] SET DELAYED_DURABILITY = DISABLED 
GO
USE [inventario]
GO
/****** Object:  Table [dbo].[bitacora]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bitacora](
	[id_bitacora] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NULL,
	[hora] [time](7) NULL,
	[accion] [text] NULL,
	[id_movimiento] [int] NULL,
 CONSTRAINT [PK_bitacora] PRIMARY KEY CLUSTERED 
(
	[id_bitacora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[bodegas]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bodegas](
	[id_bodega] [int] IDENTITY(1,1) NOT NULL,
	[nombre_bodega] [nvarchar](250) NOT NULL,
	[id_sucursal] [int] NULL,
	[id_tipo_bodega] [int] NULL,
	[estado] [int] NULL,
 CONSTRAINT [pk_bodegas] PRIMARY KEY CLUSTERED 
(
	[id_bodega] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[clasificacion]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clasificacion](
	[id_clasificacion] [int] IDENTITY(1,1) NOT NULL,
	[nombre_clasificacion] [nvarchar](250) NULL,
	[estado] [int] NULL,
 CONSTRAINT [pk_clasificacion] PRIMARY KEY CLUSTERED 
(
	[id_clasificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[detalles_movimientos]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalles_movimientos](
	[id_detalle_movimiento] [int] IDENTITY(1,1) NOT NULL,
	[fecha_vencimiento] [date] NULL,
	[lote] [nvarchar](250) NULL,
	[cantidad] [decimal](10, 2) NULL,
	[costo_unitario] [decimal](10, 2) NULL,
	[costo_unitario_promedio] [decimal](10, 2) NULL,
	[existencia_anterior] [decimal](10, 2) NULL,
	[existencia_total] [decimal](10, 2) NULL,
	[estado] [int] NULL,
	[id_producto] [int] NULL,
	[id_movimiento] [int] NULL,
	[id_bodega] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_detalle_movimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[medidas_peso]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[medidas_peso](
	[id_medida_peso] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](250) NULL,
	[abreviatura] [nvarchar](50) NULL,
	[estado] [int] NULL,
 CONSTRAINT [pk_medidas_peso] PRIMARY KEY CLUSTERED 
(
	[id_medida_peso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[movimientos]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[movimientos](
	[id_movimiento] [int] IDENTITY(1,1) NOT NULL,
	[id_tipo_movimiento] [int] NOT NULL,
	[fecha] [date] NULL,
	[hora] [time](7) NULL,
	[descripcion] [nvarchar](250) NULL,
	[costo_total_con_iva] [decimal](10, 2) NULL,
	[costo_total_sin_iva] [decimal](10, 2) NULL,
	[id_usuario] [int] NULL,
	[estado] [int] NULL,
	[id_proveedor] [int] NULL,
 CONSTRAINT [pk_movimientos] PRIMARY KEY CLUSTERED 
(
	[id_movimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[productos]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productos](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](250) NOT NULL,
	[codigo] [nvarchar](250) NULL,
	[descripcion] [nvarchar](250) NULL,
	[id_vigencia_promedio] [int] NULL,
	[id_clasificacion] [int] NULL,
	[id_sub_clasificacion] [int] NULL,
	[id_proveedor] [int] NULL,
	[fecha_creacion] [date] NULL,
	[hora_creacion] [time](7) NULL,
	[estado] [int] NULL CONSTRAINT [DF_productos_estado]  DEFAULT ((1)),
	[costo_unitario_con_iva] [decimal](18, 4) NULL,
 CONSTRAINT [pk_productos] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[proveedor_producto]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proveedor_producto](
	[id_proveedor_producto] [int] IDENTITY(1,1) NOT NULL,
	[id_proveedor] [int] NULL,
	[id_producto] [int] NULL,
	[estado] [int] NULL,
 CONSTRAINT [PK_proveedor_producto] PRIMARY KEY CLUSTERED 
(
	[id_proveedor_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[proveedores]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proveedores](
	[id_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](250) NULL,
	[direccion] [nvarchar](250) NULL,
	[nit] [nvarchar](250) NULL,
	[nrc] [nvarchar](250) NULL,
	[correo] [nvarchar](250) NULL,
	[razon_social] [nvarchar](250) NULL,
	[id_tipo_proveedor] [int] NULL,
	[estado] [int] NULL,
 CONSTRAINT [pk_proveedores] PRIMARY KEY CLUSTERED 
(
	[id_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[roles]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles](
	[id_rol] [int] IDENTITY(1,1) NOT NULL,
	[rol] [nvarchar](250) NULL,
	[estado] [int] NOT NULL,
 CONSTRAINT [pk_roles] PRIMARY KEY CLUSTERED 
(
	[id_rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sub_clasificaciones]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sub_clasificaciones](
	[id_sub_clasificacion] [int] IDENTITY(1,1) NOT NULL,
	[id_clasificacion] [int] NULL,
	[sub_clasificacion] [nvarchar](250) NULL,
	[estado] [int] NULL,
 CONSTRAINT [pk_sub_clasificacion] PRIMARY KEY CLUSTERED 
(
	[id_sub_clasificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sucursales]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sucursales](
	[id_sucursal] [int] IDENTITY(1,1) NOT NULL,
	[sucursal] [nvarchar](100) NULL,
	[estado] [int] NULL,
 CONSTRAINT [pk_sucursales] PRIMARY KEY CLUSTERED 
(
	[id_sucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tipo_bodega]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_bodega](
	[id_tipo_bodega] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [nvarchar](250) NULL,
	[estado] [int] NULL,
 CONSTRAINT [pk_tipo_bodega] PRIMARY KEY CLUSTERED 
(
	[id_tipo_bodega] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tipo_bodega_bodegas]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_bodega_bodegas](
	[id_tipo_bodega_bodegas] [int] IDENTITY(1,1) NOT NULL,
	[id_tipo_bodega] [int] NULL,
	[id_bodega] [int] NULL,
	[temperatura_promedio] [decimal](10, 2) NULL,
	[capacidad_maxima] [decimal](10, 2) NULL,
	[capacidad_actual] [decimal](10, 2) NULL,
 CONSTRAINT [PK_tipo_bodega_bodegas] PRIMARY KEY CLUSTERED 
(
	[id_tipo_bodega_bodegas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tipo_movimiento]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_movimiento](
	[id_tipo_movimiento] [int] IDENTITY(1,1) NOT NULL,
	[tipo_movimiento] [nvarchar](250) NULL,
	[estado] [int] NULL,
 CONSTRAINT [pk_tipos_movimientos] PRIMARY KEY CLUSTERED 
(
	[id_tipo_movimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tipo_proveedor]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_proveedor](
	[id_tipo_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[tipo_proveedor] [nvarchar](250) NULL,
	[estado] [int] NULL,
 CONSTRAINT [pk_tipo_proveedor] PRIMARY KEY CLUSTERED 
(
	[id_tipo_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](10) NULL,
	[clave] [varchar](50) NULL,
	[nombre_completo] [varchar](200) NULL,
	[dui] [varchar](10) NULL,
	[estado] [int] NULL CONSTRAINT [DF_usuarios_estado]  DEFAULT ((1)),
	[estado_sesion] [int] NULL,
	[fecha_ultimo_ingreso] [date] NULL,
	[hora_ultimo_ingreso] [time](7) NULL,
	[id_rol] [int] NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[vigencia_promedio]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vigencia_promedio](
	[id_vigencia_promedio] [int] IDENTITY(1,1) NOT NULL,
	[dias] [int] NULL,
	[estado] [int] NULL,
 CONSTRAINT [pk_vigencias_promedio] PRIMARY KEY CLUSTERED 
(
	[id_vigencia_promedio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[vw_bodegas]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_bodegas]
As
select a.id_bodega,a.nombre_bodega,b.sucursal,c.tipo,b.id_sucursal,c.id_tipo_bodega 
from bodegas a 
inner join sucursales b on b.id_sucursal=a.id_sucursal 
inner join tipo_bodega c on c.id_tipo_bodega=a.id_tipo_bodega 
where a.estado=1

GO
/****** Object:  View [dbo].[vw_login]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_login]
AS
SELECT        id_usuario, RTRIM(usuario) AS usuario, RTRIM(clave) AS clave, RTRIM(nombre_completo) AS nombre_completo, dui, estado, estado_sesion, fecha_ultimo_ingreso, hora_ultimo_ingreso, id_rol
FROM            dbo.usuarios
WHERE        (estado = 1) AND (estado_sesion = 0)

GO
/****** Object:  View [dbo].[vw_movimientos]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_movimientos]
AS
SELECT IIF(dbo.movimientos.estado = 1, 'Aprobado', 'Rechazado') AS estado, dbo.movimientos.id_movimiento, dbo.tipo_movimiento.tipo_movimiento, dbo.movimientos.fecha, dbo.movimientos.hora, dbo.movimientos.descripcion, dbo.movimientos.costo_total_con_iva, 
dbo.movimientos.costo_total_sin_iva, dbo.usuarios.usuario, dbo.proveedores.nombre
FROM dbo.movimientos 
INNER JOIN dbo.tipo_movimiento ON dbo.movimientos.id_tipo_movimiento = dbo.tipo_movimiento.id_tipo_movimiento 
INNER JOIN dbo.usuarios ON dbo.movimientos.id_usuario = dbo.usuarios.id_usuario
LEFT JOIN proveedores On movimientos.id_proveedor = proveedores.id_proveedor
GO
/****** Object:  View [dbo].[vw_producto]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_producto]
AS
SELECT        dbo.productos.id_producto, dbo.productos.nombre, dbo.vigencia_promedio.dias, dbo.productos.codigo, dbo.productos.hora_creacion, dbo.productos.fecha_creacion, dbo.proveedores.nombre AS proveedor, 
                         dbo.clasificacion.nombre_clasificacion AS categoria, dbo.sub_clasificaciones.sub_clasificacion AS subcategoia, dbo.productos.descripcion
FROM            dbo.productos INNER JOIN
                         dbo.proveedores ON dbo.productos.id_proveedor = dbo.proveedores.id_proveedor INNER JOIN
                         dbo.sub_clasificaciones ON dbo.productos.id_sub_clasificacion = dbo.sub_clasificaciones.id_sub_clasificacion INNER JOIN
                         dbo.clasificacion ON dbo.sub_clasificaciones.id_clasificacion = dbo.clasificacion.id_clasificacion INNER JOIN
                         dbo.vigencia_promedio ON dbo.productos.id_vigencia_promedio = dbo.vigencia_promedio.id_vigencia_promedio
WHERE        (dbo.productos.estado = 1)

GO
/****** Object:  View [dbo].[vw_proveedor]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_proveedor]
as

SELECT dbo.proveedores.id_proveedor, dbo.proveedores.nombre, dbo.proveedores.direccion, dbo.proveedores.nit, dbo.proveedores.nrc, dbo.proveedores.correo, dbo.proveedores.razon_social, 
dbo.tipo_proveedor.tipo_proveedor
FROM            dbo.proveedores INNER JOIN
dbo.tipo_proveedor ON dbo.proveedores.id_tipo_proveedor = dbo.tipo_proveedor.id_tipo_proveedor
WHERE        (dbo.proveedores.estado = 1)
GO
/****** Object:  View [dbo].[vw_sucursal]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[vw_sucursal]
As
select id_sucursal,sucursal,estado from sucursales where estado=1
GO
/****** Object:  View [dbo].[vw_tipo_movimiento]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_tipo_movimiento]
AS 
SELECT * FROM tipo_movimiento WHERE estado = 1;
GO
SET IDENTITY_INSERT [dbo].[bodegas] ON 

INSERT [dbo].[bodegas] ([id_bodega], [nombre_bodega], [id_sucursal], [id_tipo_bodega], [estado]) VALUES (1, N'Frutas Beethoven', 1, 1, 1)
INSERT [dbo].[bodegas] ([id_bodega], [nombre_bodega], [id_sucursal], [id_tipo_bodega], [estado]) VALUES (2, N'Carnes Metrosur', 2, 3, 1)
INSERT [dbo].[bodegas] ([id_bodega], [nombre_bodega], [id_sucursal], [id_tipo_bodega], [estado]) VALUES (3, N'Verduras El Centro', 1, 2, 1)
SET IDENTITY_INSERT [dbo].[bodegas] OFF
SET IDENTITY_INSERT [dbo].[clasificacion] ON 

INSERT [dbo].[clasificacion] ([id_clasificacion], [nombre_clasificacion], [estado]) VALUES (1, N'Carnes', 1)
INSERT [dbo].[clasificacion] ([id_clasificacion], [nombre_clasificacion], [estado]) VALUES (2, N'Frutas', 1)
INSERT [dbo].[clasificacion] ([id_clasificacion], [nombre_clasificacion], [estado]) VALUES (3, N'Verduras', 1)
INSERT [dbo].[clasificacion] ([id_clasificacion], [nombre_clasificacion], [estado]) VALUES (4, N'Harinas editado', 0)
SET IDENTITY_INSERT [dbo].[clasificacion] OFF
SET IDENTITY_INSERT [dbo].[detalles_movimientos] ON 

INSERT [dbo].[detalles_movimientos] ([id_detalle_movimiento], [fecha_vencimiento], [lote], [cantidad], [costo_unitario], [costo_unitario_promedio], [existencia_anterior], [existencia_total], [estado], [id_producto], [id_movimiento], [id_bodega]) VALUES (1, CAST(N'2020-05-27' AS Date), N'M00933', CAST(20.00 AS Decimal(10, 2)), CAST(1.26 AS Decimal(10, 2)), CAST(1.26 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(20.00 AS Decimal(10, 2)), 1, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[detalles_movimientos] OFF
SET IDENTITY_INSERT [dbo].[medidas_peso] ON 

INSERT [dbo].[medidas_peso] ([id_medida_peso], [nombre], [abreviatura], [estado]) VALUES (1, N'Onza', N'Oz', 1)
INSERT [dbo].[medidas_peso] ([id_medida_peso], [nombre], [abreviatura], [estado]) VALUES (2, N'Libra', N'Lb', 1)
INSERT [dbo].[medidas_peso] ([id_medida_peso], [nombre], [abreviatura], [estado]) VALUES (3, N'Miligramo', N'Ml', 1)
INSERT [dbo].[medidas_peso] ([id_medida_peso], [nombre], [abreviatura], [estado]) VALUES (4, N'Gramo', N'Ga', 1)
INSERT [dbo].[medidas_peso] ([id_medida_peso], [nombre], [abreviatura], [estado]) VALUES (5, N'Kilogramo', N'Kl', 1)
INSERT [dbo].[medidas_peso] ([id_medida_peso], [nombre], [abreviatura], [estado]) VALUES (6, N'Tonelada', N'Tn', 1)
SET IDENTITY_INSERT [dbo].[medidas_peso] OFF
SET IDENTITY_INSERT [dbo].[movimientos] ON 

INSERT [dbo].[movimientos] ([id_movimiento], [id_tipo_movimiento], [fecha], [hora], [descripcion], [costo_total_con_iva], [costo_total_sin_iva], [id_usuario], [estado], [id_proveedor]) VALUES (1, 1, CAST(N'2020-03-27' AS Date), CAST(N'22:21:00' AS Time), N'Ingreso de Ternera de leche', CAST(25.35 AS Decimal(10, 2)), CAST(22.43 AS Decimal(10, 2)), 1, 1, 5)
INSERT [dbo].[movimientos] ([id_movimiento], [id_tipo_movimiento], [fecha], [hora], [descripcion], [costo_total_con_iva], [costo_total_sin_iva], [id_usuario], [estado], [id_proveedor]) VALUES (2, 3, CAST(N'2020-03-28' AS Date), CAST(N'10:44:00' AS Time), N'Traslado', CAST(25.35 AS Decimal(10, 2)), CAST(22.43 AS Decimal(10, 2)), 1, 1, NULL)
INSERT [dbo].[movimientos] ([id_movimiento], [id_tipo_movimiento], [fecha], [hora], [descripcion], [costo_total_con_iva], [costo_total_sin_iva], [id_usuario], [estado], [id_proveedor]) VALUES (3, 1, CAST(N'2020-04-23' AS Date), CAST(N'00:00:00' AS Time), N'Entradas de Añojo', CAST(33.63 AS Decimal(10, 2)), CAST(29.76 AS Decimal(10, 2)), 1, 0, 4)
SET IDENTITY_INSERT [dbo].[movimientos] OFF
SET IDENTITY_INSERT [dbo].[productos] ON 

INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (1, N'Ternera de leche', N'C-000001', N'Ternera de leche', 3, 1, 1, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(10.2400 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (2, N'Añojo', N'C-000002', N'Añojo', 2, 1, 2, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(11.2100 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (3, N'Novillo', N'C-000003', N'Novillo', 1, 1, 3, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(12.3500 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (4, N'Vacuno mayo', N'C-000004', N'Vacuno mayo', 4, 1, 2, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(13.1600 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (5, N'Cordero', N'C-000005', N'Cordero', 2, 1, 1, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(12.2450 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (6, N'Ternero', N'C-000006', N'Ternero', 3, 1, 3, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(23.2100 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (7, N'Marrana', N'C-000007', N'Marrana', 2, 1, 1, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(25.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (8, N'Verraco', N'C-000008', N'Verraco', 1, 1, 1, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(52.2100 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (9, N'Gallina', N'C-000009', N'Gallina', 3, 1, 3, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(2.2230 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (10, N'Pato', N'C-000010', N'Pato', 2, 1, 1, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(3.2320 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (11, N'Pavo', N'C-000011', N'Pavo', 2, 1, 2, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(32.2100 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (12, N'Codorniz', N'C-000012', N'Codorniz', 4, 1, 2, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(231.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (13, N'Paloma', N'C-000013', N'Paloma', 5, 1, 2, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(213.1000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (14, N'Perdiz', N'C-000014', N'Perdiz', 6, 1, 2, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(75.1200 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (15, N'Cuy', N'C-000015', N'Cuy', 3, 1, 3, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(4735.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (16, N'Conejo', N'C-000016', N'Conejo', 2, 1, 1, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(230.1000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (17, N'Caballo', N'C-000017', N'Caballo', 1, 1, 1, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(38542.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (18, N'Camello', N'C-000018', N'Camello', 4, 1, 1, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(885.2000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (19, N'Avestruz', N'C-000019', N'Avestruz', 2, 1, 2, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(22.2500 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (20, N'Ballena', N'C-000020', N'Ballena', 3, 1, 2, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(21.1000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (21, N'Caballo', N'C-000021', N'Caballo', 2, 1, 3, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(832.5000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (22, N'Ternera', N'C-000022', N'Ternera', 1, 1, 2, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(235.1200 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (23, N'Pollo', N'C-000023', N'Pollo', 3, 1, 3, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(32.0200 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (24, N'Carne de res', N'C-000024', N'Carne de res', 2, 1, 1, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(23.1200 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (25, N'Cerdo', N'C-000025', N'Cerdo', 2, 1, 1, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(2.1210 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (26, N'Carne de buey', N'C-000026', N'Carne de buey', 4, 1, 2, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(7.2150 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (27, N'Ovino', N'C-000027', N'Ovino', 5, 1, 1, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(2132.1200 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (28, N'Solomillo', N'C-000028', N'Solomillo', 6, 1, 2, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(9.2300 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (29, N'Lomo', N'C-000029', N'Lomo', 2, 1, 3, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(8.2150 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (30, N'Babilla', N'C-000030', N'Babilla', 1, 1, 2, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(5.2100 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (31, N'Cadera', N'C-000031', N'Cadera', 3, 1, 1, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(6.2100 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (32, N'Tapilla de cadera', N'C-000032', N'Tapilla de cadera', 2, 1, 3, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(2.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (33, N'Redondo', N'C-000033', N'Redondo', 2, 1, 3, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(3.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (34, N'Tapa', N'C-000034', N'Tapa', 4, 1, 3, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(4.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (35, N'Aguja', N'C-000035', N'Aguja', 5, 1, 2, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(5.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (36, N'Espaldilla', N'C-000036', N'Espaldilla', 6, 1, 1, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(6.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (37, N'Pez', N'C-000037', N'Pez', 3, 1, 2, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(7.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (38, N'Llana', N'C-000038', N'Llana', 2, 1, 2, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(8.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (39, N'Brazuelo', N'C-000039', N'Brazuelo', 1, 1, 3, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(9.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (40, N'Aleta', N'C-000040', N'Aleta', 4, 1, 3, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(10.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (41, N'Bajada de pecho', N'C-000041', N'Bajada de pecho', 2, 1, 1, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(11.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (42, N'Morcillo', N'C-000042', N'Morcillo', 3, 1, 1, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(12.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (43, N'Morrillo', N'C-000043', N'Morrillo', 2, 1, 2, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(23.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (44, N'Pescuezo', N'C-000044', N'Pescuezo', 1, 1, 3, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(32.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (45, N'Cuello', N'C-000045', N'Cuello', 3, 1, 3, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(5.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (46, N'Costillar', N'C-000046', N'Costillar', 2, 1, 1, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(21.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (47, N'Pecho', N'C-000047', N'Pecho', 2, 1, 3, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(53.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (48, N'Rabo', N'C-000048', N'Rabo', 2, 1, 2, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(21.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (49, N'Falda', N'C-000049', N'Falda', 3, 1, 2, 1, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(13.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (50, N'Aguacate', N'F-000001', N'Aguacate', 2, 2, 1, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(5.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (51, N'Castaña', N'F-000002', N'Castaña', 1, 2, 3, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(2.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (52, N'Maní Almendra', N'F-000003', N'Maní Almendra', 3, 2, 3, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(32.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (53, N'Castaño', N'F-000004', N'Castaño', 2, 2, 2, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(15.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (54, N'Nuez Avellana', N'F-000005', N'Nuez Avellana', 7, 2, 1, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(22313.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (55, N'Coco', N'F-000006', N'Coco', 5, 2, 17, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(21.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (56, N'Cacahuate', N'F-000007', N'Cacahuate', 4, 2, 18, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(23.2000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (57, N'Corozo', N'F-000008', N'Corozo', 7, 2, 19, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(21.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (58, N'Cacao', N'F-000009', N'Cacao', 2, 2, 20, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(2.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (59, N'Macada', N'F-000010', N'Macada', 1, 2, 17, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(1.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (60, N'Albaricoque', N'F-000011', N'Albaricoque', 1, 2, 18, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(2.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (61, N'Ciruelo(variedad)', N'F-000012', N'Ciruelo(variedad)', 1, 2, 19, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(1.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (62, N'Mangostán', N'F-000013', N'Mangostán', 2, 2, 20, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(2.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (63, N'Pitahaya', N'F-000014', N'Pitahaya', 4, 2, 18, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(1.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (64, N'Anón', N'F-000015', N'Anón', 5, 2, 19, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(5.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (65, N'Datiles', N'F-000016', N'Datiles', 6, 2, 20, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(32.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (66, N'Manzana (variedad)', N'F-000017', N'Manzana (variedad)', 7, 2, 17, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(3.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (67, N'Sandia', N'F-000018', N'Sandia', 7, 2, 18, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(1.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (68, N'Banano', N'F-000019', N'Banano', 9, 2, 19, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(5.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (69, N'Melón (variedad)', N'F-000020', N'Melón (variedad)', 8, 2, 20, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(2.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (70, N'Granada', N'F-000021', N'Granada', 1, 2, 18, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(3.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (71, N'Uva (variedad)', N'F-000022', N'Uva (variedad)', 2, 2, 19, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(23.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (72, N'Cafeto', N'F-000023', N'Cafeto', 5, 2, 20, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(15.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (73, N'Grosella', N'F-000024', N'Grosella', 4, 2, 17, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(3.1000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (74, N'Níspero', N'F-000025', N'Níspero', 4, 2, 18, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(2.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (75, N'Caimo', N'F-000026', N'Caimo', 5, 2, 19, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, NULL)
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (76, N'Guanábana', N'F-000027', N'Guanábana', 1, 2, 20, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(5.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (77, N'Papaya', N'F-000028', N'Papaya', 5, 2, 18, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(32151.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (78, N'Cerez Guayaba (variedad)', N'F-000029', N'Cerez Guayaba (variedad)', 5, 2, 19, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(35.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (79, N'Chirimoya', N'F-000030', N'Chirimoya', 6, 2, 17, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(1.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (80, N'Higo', N'F-000031', N'Higo', 5, 2, 17, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(2.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (81, N'Pera ', N'F-000032', N'Pera ', 7, 2, 17, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(2.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (82, N'Caimito', N'F-000033', N'Caimito', 9, 2, 17, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(2.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (83, N'Fresa', N'F-000034', N'Fresa', 4, 2, 18, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(5.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (84, N'Manzana verde', N'F-000035', N'Manzana verde', 6, 2, 19, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(2.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (85, N'Ciruela(variedad)', N'F-000036', N'Ciruela(variedad)', 5, 2, 18, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(3.2521 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (86, N'Granadilla', N'F-000037', N'Granadilla', 8, 2, 18, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(5.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (87, N'Marañon', N'F-000038', N'Marañon', 7, 2, 19, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(3.2300 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (88, N'Jocote', N'F-000039', N'Jocote', 5, 2, 18, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(3.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (89, N'Guayaba (variedad)', N'F-000040', N'Guayaba (variedad)', 4, 2, 18, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(5.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (90, N'Membrillo', N'F-000041', N'Membrillo', 7, 2, 19, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(1.2100 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (91, N'Ciruelo (variedad)', N'F-000042', N'Ciruelo (variedad)', 4, 2, 20, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(32.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (92, N'Lima', N'F-000043', N'Lima', 6, 2, 20, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(32.0100 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (93, N'Níspero (variedad)', N'F-000044', N'Níspero (variedad)', 5, 2, 20, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(122.2100 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (94, N'Durazno', N'F-000045', N'Durazno', 8, 2, 20, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(21.2120 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (95, N'Mamoncilla', N'F-000046', N'Mamoncilla', 7, 2, 17, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(21.1230 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (96, N'Uchuva', N'F-000047', N'Uchuva', 5, 2, 18, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(3215.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (97, N'Melocotón', N'F-000048', N'Melocotón', 4, 2, 19, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(2.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (98, N'Mandarina', N'F-000049', N'Mandarina', 7, 2, 18, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(15.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (99, N'Frambuesa', N'F-000050', N'Frambuesa', 2, 2, 17, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(35.2100 AS Decimal(18, 4)))
GO
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (100, N'Mango', N'F-000051', N'Mango', 1, 2, 19, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(15.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (101, N'Arandano', N'F-000052', N'Arandano', 1, 2, 20, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(15.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (102, N'Limón', N'F-000053', N'Limón', 1, 2, 20, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(1.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (103, N'Piña', N'F-000054', N'Piña', 2, 2, 18, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(32.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (104, N'Borojo', N'F-000055', N'Borojo', 4, 2, 17, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(1312.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (105, N'Manzana (variedad)', N'F-000056', N'Manzana (variedad)', 5, 2, 17, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(13.2400 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (106, N'Piñuela', N'F-000057', N'Piñuela', 6, 2, 17, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(21.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (107, N'Caimo', N'F-000058', N'Caimo', 7, 2, 18, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(21.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (108, N'Maracuya', N'F-000059', N'Maracuya', 7, 2, 19, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(3.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (109, N'Pomelo', N'F-000060', N'Pomelo', 9, 2, 20, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(1.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (110, N'Guayaba', N'F-000061', N'Guayaba', 8, 2, 20, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(85.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (111, N'Mora', N'F-000062', N'Mora', 2, 2, 20, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(3.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (112, N'Tamarindo', N'F-000063', N'Tamarindo', 4, 2, 20, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(421.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (113, N'Kiwi', N'F-000064', N'Kiwi', 5, 2, 20, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(348.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (114, N'Naranja', N'F-000065', N'Naranja', 6, 2, 20, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(2411.2000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (115, N'Toronja', N'F-000066', N'Toronja', 7, 2, 20, 2, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(3.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (116, N'berenjena', N'V-000001', N'berenjena', 8, 3, 20, 3, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(21.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (117, N'pimientos', N'V-000002', N'pimientos', 8, 3, 19, 3, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(4.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (118, N'ajo ', N'V-000003', N'ajo ', 14, 3, 19, 3, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(534354.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (119, N'cebolla', N'V-000004', N'cebolla', 15, 3, 19, 3, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(5.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (120, N'puerro ', N'V-000005', N'puerro ', 16, 3, 21, 3, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(34.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (121, N'chalota', N'V-000006', N'chalota', 12, 3, 22, 3, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(534.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (122, N'repollo ', N'V-000007', N'repollo ', 11, 3, 23, 3, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(35.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (123, N'brécol ', N'V-000008', N'brécol ', 10, 3, 24, 3, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(45.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (124, N'coles de Bruselas ', N'V-000009', N'coles de Bruselas ', 9, 3, 25, 3, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(4.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (125, N'coliflor', N'V-000010', N'coliflor', 8, 3, 26, 3, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(32.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (126, N'acelga', N'V-000011', N'acelga', 4, 3, 27, 3, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(41.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (127, N'achicoria ', N'V-000012', N'achicoria ', 5, 3, 30, 3, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(42.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (128, N'borraja', N'V-000013', N'borraja', 6, 3, 21, 3, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(454.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (129, N'cardo ', N'V-000014', N'cardo ', 7, 3, 22, 3, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(34.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (130, N'endibias ', N'V-000015', N'endibias ', 14, 3, 25, 3, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(3.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (131, N'escarola ', N'V-000016', N'escarola ', 15, 3, 23, 3, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(4.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (132, N'espinacas ', N'V-000017', N'espinacas ', 16, 3, 25, 3, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(21.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (133, N'lechuga.', N'V-000018', N'lechuga.', 12, 3, 21, 3, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(231.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (134, N'alcachofa', N'V-000019', N'alcachofa', 2, 3, 25, 3, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(31.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (135, N'calabacín ', N'V-000020', N'calabacín ', 5, 3, 26, 3, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(2.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (136, N'calabaza ', N'V-000021', N'calabaza ', 4, 3, 25, 3, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(1.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (137, N'pepino', N'V-000022', N'pepino', 4, 3, 27, 3, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(2.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (138, N'nabo ', N'V-000023', N'nabo ', 5, 3, 24, 3, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(1.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (139, N'rábanos', N'V-000024', N'rábanos', 1, 3, 24, 3, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(31.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (140, N'remolacha de mesa ', N'V-000025', N'remolacha de mesa ', 5, 3, 26, 3, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(321.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (141, N'zanahoria', N'V-000026', N'zanahoria', 5, 3, 24, 3, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(85.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (142, N'apio ', N'V-000027', N'apio ', 6, 3, 23, 3, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(4.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (143, N'espárrago blanco ', N'V-000028', N'espárrago blanco ', 5, 3, 26, 3, CAST(N'2020-03-16' AS Date), CAST(N'12:25:26' AS Time), 1, CAST(3.0000 AS Decimal(18, 4)))
INSERT [dbo].[productos] ([id_producto], [nombre], [codigo], [descripcion], [id_vigencia_promedio], [id_clasificacion], [id_sub_clasificacion], [id_proveedor], [fecha_creacion], [hora_creacion], [estado], [costo_unitario_con_iva]) VALUES (1145, N'Prueba', N'C-000100', N'Prueba de insert', 12, NULL, 13, 0, CAST(N'2020-03-24' AS Date), CAST(N'23:29:10.8066095' AS Time), 1, CAST(4234.4000 AS Decimal(18, 4)))
SET IDENTITY_INSERT [dbo].[productos] OFF
SET IDENTITY_INSERT [dbo].[proveedores] ON 

INSERT [dbo].[proveedores] ([id_proveedor], [nombre], [direccion], [nit], [nrc], [correo], [razon_social], [id_tipo_proveedor], [estado]) VALUES (1, N'FIT-FRUIT', N'Calle San Antonio Abad No. 2123 Frente Colegio Cristóbal Col', N'0614-301096-117-0', N'004385-0', N'frurticolas@gmail.com', N'FIT-FRUIT', 1, 1)
INSERT [dbo].[proveedores] ([id_proveedor], [nombre], [direccion], [nit], [nrc], [correo], [razon_social], [id_tipo_proveedor], [estado]) VALUES (2, N'ECOFRUIT FRUTAS Y VERDURAS', N'CALLE LOS GRANADOS, COLONIA LAS MERCEDES CASA 28, SAN SALVAD', N'0614-260877-001-2', N'076132-0', N'verduricolas@hotmail.com', N'ECOFRUIT FRUTAS Y VERDURAS', 4, 1)
INSERT [dbo].[proveedores] ([id_proveedor], [nombre], [direccion], [nit], [nrc], [correo], [razon_social], [id_tipo_proveedor], [estado]) VALUES (3, N'DISTRIBUCIONES HORTOFRUTICOLAS', N'12 CALLE ORIENTE Y 9A. AVENIDA SUR NO.22-A, SANTA TECLA LA L', N'0614-301096-117-1', N'203703-3', N'carnicolas@yahoo.com', N'DISTRIBUCIONES HORTOFRUTICOLAS', 3, 1)
INSERT [dbo].[proveedores] ([id_proveedor], [nombre], [direccion], [nit], [nrc], [correo], [razon_social], [id_tipo_proveedor], [estado]) VALUES (4, N'AXARFRUIT', N'79 AV.SUR,C CALLE JUAN JOSE CAÑAS #250, COLONIA ESCALON, SAN', N'0614-120813-104-9', N'243762-7', N'verdifrutas@gmail.com', N'AXARFRUIT', 1, 1)
INSERT [dbo].[proveedores] ([id_proveedor], [nombre], [direccion], [nit], [nrc], [correo], [razon_social], [id_tipo_proveedor], [estado]) VALUES (5, N'CARNIPROV', N'75 AV. SUR, COL. ESCALON', N'0614-122345-110-4', N'24532-7', N'carniprov@gmail.com', N'CARNIPROV', 3, 1)
INSERT [dbo].[proveedores] ([id_proveedor], [nombre], [direccion], [nit], [nrc], [correo], [razon_social], [id_tipo_proveedor], [estado]) VALUES (6, N'Prueba', N'Direccion prueb', N'0614-121212-115-1', N'13245-4', N'prueba@gmail.com', N'que si', 8, 0)
SET IDENTITY_INSERT [dbo].[proveedores] OFF
SET IDENTITY_INSERT [dbo].[roles] ON 

INSERT [dbo].[roles] ([id_rol], [rol], [estado]) VALUES (1, N'Administrador', 1)
INSERT [dbo].[roles] ([id_rol], [rol], [estado]) VALUES (2, N'Encargado', 1)
SET IDENTITY_INSERT [dbo].[roles] OFF
SET IDENTITY_INSERT [dbo].[sub_clasificaciones] ON 

INSERT [dbo].[sub_clasificaciones] ([id_sub_clasificacion], [id_clasificacion], [sub_clasificacion], [estado]) VALUES (1, 1, N'Suprema', 1)
INSERT [dbo].[sub_clasificaciones] ([id_sub_clasificacion], [id_clasificacion], [sub_clasificacion], [estado]) VALUES (2, 1, N'Selecta', 1)
INSERT [dbo].[sub_clasificaciones] ([id_sub_clasificacion], [id_clasificacion], [sub_clasificacion], [estado]) VALUES (3, 1, N'Estandar', 1)
INSERT [dbo].[sub_clasificaciones] ([id_sub_clasificacion], [id_clasificacion], [sub_clasificacion], [estado]) VALUES (4, 1, N'Comercial', 1)
INSERT [dbo].[sub_clasificaciones] ([id_sub_clasificacion], [id_clasificacion], [sub_clasificacion], [estado]) VALUES (5, 1, N'Carne de cerdo', 1)
INSERT [dbo].[sub_clasificaciones] ([id_sub_clasificacion], [id_clasificacion], [sub_clasificacion], [estado]) VALUES (6, 1, N'Carne de caballo', 1)
INSERT [dbo].[sub_clasificaciones] ([id_sub_clasificacion], [id_clasificacion], [sub_clasificacion], [estado]) VALUES (7, 1, N'Carne de oveja', 1)
INSERT [dbo].[sub_clasificaciones] ([id_sub_clasificacion], [id_clasificacion], [sub_clasificacion], [estado]) VALUES (8, 1, N'Carne de corzo', 1)
INSERT [dbo].[sub_clasificaciones] ([id_sub_clasificacion], [id_clasificacion], [sub_clasificacion], [estado]) VALUES (9, 1, N'Carne de vaca', 1)
INSERT [dbo].[sub_clasificaciones] ([id_sub_clasificacion], [id_clasificacion], [sub_clasificacion], [estado]) VALUES (10, 1, N'Carne de cordero', 1)
INSERT [dbo].[sub_clasificaciones] ([id_sub_clasificacion], [id_clasificacion], [sub_clasificacion], [estado]) VALUES (11, 1, N'Carne de ternera', 1)
INSERT [dbo].[sub_clasificaciones] ([id_sub_clasificacion], [id_clasificacion], [sub_clasificacion], [estado]) VALUES (12, 1, N'Carne de pollo', 1)
INSERT [dbo].[sub_clasificaciones] ([id_sub_clasificacion], [id_clasificacion], [sub_clasificacion], [estado]) VALUES (13, 1, N'Carne de pezcado', 1)
INSERT [dbo].[sub_clasificaciones] ([id_sub_clasificacion], [id_clasificacion], [sub_clasificacion], [estado]) VALUES (14, 1, N'Carne de cangrejo', 1)
INSERT [dbo].[sub_clasificaciones] ([id_sub_clasificacion], [id_clasificacion], [sub_clasificacion], [estado]) VALUES (15, 1, N'Carne de conejo', 1)
INSERT [dbo].[sub_clasificaciones] ([id_sub_clasificacion], [id_clasificacion], [sub_clasificacion], [estado]) VALUES (16, 1, N'Carne de cabra', 1)
INSERT [dbo].[sub_clasificaciones] ([id_sub_clasificacion], [id_clasificacion], [sub_clasificacion], [estado]) VALUES (17, 2, N'Neutras', 1)
INSERT [dbo].[sub_clasificaciones] ([id_sub_clasificacion], [id_clasificacion], [sub_clasificacion], [estado]) VALUES (18, 2, N'Dulces', 1)
INSERT [dbo].[sub_clasificaciones] ([id_sub_clasificacion], [id_clasificacion], [sub_clasificacion], [estado]) VALUES (19, 2, N'Semi-acidas', 1)
INSERT [dbo].[sub_clasificaciones] ([id_sub_clasificacion], [id_clasificacion], [sub_clasificacion], [estado]) VALUES (20, 2, N'Acidas', 1)
INSERT [dbo].[sub_clasificaciones] ([id_sub_clasificacion], [id_clasificacion], [sub_clasificacion], [estado]) VALUES (21, 3, N'Hojas', 1)
INSERT [dbo].[sub_clasificaciones] ([id_sub_clasificacion], [id_clasificacion], [sub_clasificacion], [estado]) VALUES (22, 3, N'Bulbo', 1)
INSERT [dbo].[sub_clasificaciones] ([id_sub_clasificacion], [id_clasificacion], [sub_clasificacion], [estado]) VALUES (23, 3, N'Raíz', 1)
INSERT [dbo].[sub_clasificaciones] ([id_sub_clasificacion], [id_clasificacion], [sub_clasificacion], [estado]) VALUES (24, 3, N'Flor o Inflorescencias', 1)
INSERT [dbo].[sub_clasificaciones] ([id_sub_clasificacion], [id_clasificacion], [sub_clasificacion], [estado]) VALUES (25, 3, N'Brote', 1)
INSERT [dbo].[sub_clasificaciones] ([id_sub_clasificacion], [id_clasificacion], [sub_clasificacion], [estado]) VALUES (26, 3, N'Fruto', 1)
INSERT [dbo].[sub_clasificaciones] ([id_sub_clasificacion], [id_clasificacion], [sub_clasificacion], [estado]) VALUES (27, 3, N'Tubérculos', 1)
INSERT [dbo].[sub_clasificaciones] ([id_sub_clasificacion], [id_clasificacion], [sub_clasificacion], [estado]) VALUES (28, 3, N'Coles', 1)
INSERT [dbo].[sub_clasificaciones] ([id_sub_clasificacion], [id_clasificacion], [sub_clasificacion], [estado]) VALUES (29, 3, N'Pepónides', 1)
INSERT [dbo].[sub_clasificaciones] ([id_sub_clasificacion], [id_clasificacion], [sub_clasificacion], [estado]) VALUES (30, 3, N'Tallo', 1)
SET IDENTITY_INSERT [dbo].[sub_clasificaciones] OFF
SET IDENTITY_INSERT [dbo].[sucursales] ON 

INSERT [dbo].[sucursales] ([id_sucursal], [sucursal], [estado]) VALUES (1, N'Beethoven', 1)
INSERT [dbo].[sucursales] ([id_sucursal], [sucursal], [estado]) VALUES (2, N'Metrosur', 1)
INSERT [dbo].[sucursales] ([id_sucursal], [sucursal], [estado]) VALUES (3, N'Merliot', 1)
SET IDENTITY_INSERT [dbo].[sucursales] OFF
SET IDENTITY_INSERT [dbo].[tipo_bodega] ON 

INSERT [dbo].[tipo_bodega] ([id_tipo_bodega], [tipo], [estado]) VALUES (1, N'Seca', 1)
INSERT [dbo].[tipo_bodega] ([id_tipo_bodega], [tipo], [estado]) VALUES (2, N'Refrigeradora', 1)
INSERT [dbo].[tipo_bodega] ([id_tipo_bodega], [tipo], [estado]) VALUES (3, N'Congeladora', 1)
INSERT [dbo].[tipo_bodega] ([id_tipo_bodega], [tipo], [estado]) VALUES (4, N'Insumos', 1)
INSERT [dbo].[tipo_bodega] ([id_tipo_bodega], [tipo], [estado]) VALUES (5, N'Productos Procesados', 1)
SET IDENTITY_INSERT [dbo].[tipo_bodega] OFF
SET IDENTITY_INSERT [dbo].[tipo_bodega_bodegas] ON 

INSERT [dbo].[tipo_bodega_bodegas] ([id_tipo_bodega_bodegas], [id_tipo_bodega], [id_bodega], [temperatura_promedio], [capacidad_maxima], [capacidad_actual]) VALUES (1, 1, 1, CAST(23.00 AS Decimal(10, 2)), CAST(100000.00 AS Decimal(10, 2)), CAST(1000.01 AS Decimal(10, 2)))
INSERT [dbo].[tipo_bodega_bodegas] ([id_tipo_bodega_bodegas], [id_tipo_bodega], [id_bodega], [temperatura_promedio], [capacidad_maxima], [capacidad_actual]) VALUES (2, 1, 2, CAST(17.00 AS Decimal(10, 2)), CAST(50000.00 AS Decimal(10, 2)), CAST(2000.00 AS Decimal(10, 2)))
INSERT [dbo].[tipo_bodega_bodegas] ([id_tipo_bodega_bodegas], [id_tipo_bodega], [id_bodega], [temperatura_promedio], [capacidad_maxima], [capacidad_actual]) VALUES (3, 2, 3, CAST(14.00 AS Decimal(10, 2)), CAST(17000.00 AS Decimal(10, 2)), CAST(6000.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[tipo_bodega_bodegas] OFF
SET IDENTITY_INSERT [dbo].[tipo_movimiento] ON 

INSERT [dbo].[tipo_movimiento] ([id_tipo_movimiento], [tipo_movimiento], [estado]) VALUES (1, N'Entradas', 1)
INSERT [dbo].[tipo_movimiento] ([id_tipo_movimiento], [tipo_movimiento], [estado]) VALUES (2, N'Salidas', 1)
INSERT [dbo].[tipo_movimiento] ([id_tipo_movimiento], [tipo_movimiento], [estado]) VALUES (3, N'Traslados', 1)
INSERT [dbo].[tipo_movimiento] ([id_tipo_movimiento], [tipo_movimiento], [estado]) VALUES (4, N'Descartes', 1)
SET IDENTITY_INSERT [dbo].[tipo_movimiento] OFF
SET IDENTITY_INSERT [dbo].[tipo_proveedor] ON 

INSERT [dbo].[tipo_proveedor] ([id_tipo_proveedor], [tipo_proveedor], [estado]) VALUES (1, N'Frutas', 1)
INSERT [dbo].[tipo_proveedor] ([id_tipo_proveedor], [tipo_proveedor], [estado]) VALUES (2, N'Verduras', 1)
INSERT [dbo].[tipo_proveedor] ([id_tipo_proveedor], [tipo_proveedor], [estado]) VALUES (3, N'Carnes', 1)
INSERT [dbo].[tipo_proveedor] ([id_tipo_proveedor], [tipo_proveedor], [estado]) VALUES (4, N'Frutas y verduras', 1)
INSERT [dbo].[tipo_proveedor] ([id_tipo_proveedor], [tipo_proveedor], [estado]) VALUES (5, N'Verduras y carnes', 1)
INSERT [dbo].[tipo_proveedor] ([id_tipo_proveedor], [tipo_proveedor], [estado]) VALUES (6, N'Frutas y carnes', 1)
INSERT [dbo].[tipo_proveedor] ([id_tipo_proveedor], [tipo_proveedor], [estado]) VALUES (7, N'Internacional', 1)
INSERT [dbo].[tipo_proveedor] ([id_tipo_proveedor], [tipo_proveedor], [estado]) VALUES (8, N'Exportador', 1)
INSERT [dbo].[tipo_proveedor] ([id_tipo_proveedor], [tipo_proveedor], [estado]) VALUES (9, N'Importador', 1)
INSERT [dbo].[tipo_proveedor] ([id_tipo_proveedor], [tipo_proveedor], [estado]) VALUES (10, N'Nacional', 1)
SET IDENTITY_INSERT [dbo].[tipo_proveedor] OFF
SET IDENTITY_INSERT [dbo].[usuarios] ON 

INSERT [dbo].[usuarios] ([id_usuario], [usuario], [clave], [nombre_completo], [dui], [estado], [estado_sesion], [fecha_ultimo_ingreso], [hora_ultimo_ingreso], [id_rol]) VALUES (1, N'admin', N'admin', N'Administrador                                                                                                                                                                                           ', N'05443976-4', 1, 1, CAST(N'2020-04-24' AS Date), CAST(N'08:26:05' AS Time), 1)
INSERT [dbo].[usuarios] ([id_usuario], [usuario], [clave], [nombre_completo], [dui], [estado], [estado_sesion], [fecha_ultimo_ingreso], [hora_ultimo_ingreso], [id_rol]) VALUES (2, N'encargado', N'encargado', N'Encargado                                                                                                                                                                                               ', N'06143019-9', 1, 1, CAST(N'2020-04-24' AS Date), CAST(N'08:45:59' AS Time), 2)
INSERT [dbo].[usuarios] ([id_usuario], [usuario], [clave], [nombre_completo], [dui], [estado], [estado_sesion], [fecha_ultimo_ingreso], [hora_ultimo_ingreso], [id_rol]) VALUES (3, N'douglas', N'1234', N'Douglas', N'05498723-4', 1, 0, CAST(N'2020-04-23' AS Date), CAST(N'09:33:39' AS Time), 1)
INSERT [dbo].[usuarios] ([id_usuario], [usuario], [clave], [nombre_completo], [dui], [estado], [estado_sesion], [fecha_ultimo_ingreso], [hora_ultimo_ingreso], [id_rol]) VALUES (4, N'guido', N'1234', N'Guido', N'05424124-7', 1, 0, CAST(N'2020-04-23' AS Date), CAST(N'11:49:14' AS Time), 2)
SET IDENTITY_INSERT [dbo].[usuarios] OFF
SET IDENTITY_INSERT [dbo].[vigencia_promedio] ON 

INSERT [dbo].[vigencia_promedio] ([id_vigencia_promedio], [dias], [estado]) VALUES (1, 5, 1)
INSERT [dbo].[vigencia_promedio] ([id_vigencia_promedio], [dias], [estado]) VALUES (2, 10, 1)
INSERT [dbo].[vigencia_promedio] ([id_vigencia_promedio], [dias], [estado]) VALUES (3, 15, 1)
INSERT [dbo].[vigencia_promedio] ([id_vigencia_promedio], [dias], [estado]) VALUES (4, 20, 1)
INSERT [dbo].[vigencia_promedio] ([id_vigencia_promedio], [dias], [estado]) VALUES (5, 25, 1)
INSERT [dbo].[vigencia_promedio] ([id_vigencia_promedio], [dias], [estado]) VALUES (6, 30, 1)
INSERT [dbo].[vigencia_promedio] ([id_vigencia_promedio], [dias], [estado]) VALUES (7, 35, 1)
INSERT [dbo].[vigencia_promedio] ([id_vigencia_promedio], [dias], [estado]) VALUES (8, 40, 1)
INSERT [dbo].[vigencia_promedio] ([id_vigencia_promedio], [dias], [estado]) VALUES (9, 45, 1)
INSERT [dbo].[vigencia_promedio] ([id_vigencia_promedio], [dias], [estado]) VALUES (10, 50, 1)
INSERT [dbo].[vigencia_promedio] ([id_vigencia_promedio], [dias], [estado]) VALUES (11, 55, 1)
INSERT [dbo].[vigencia_promedio] ([id_vigencia_promedio], [dias], [estado]) VALUES (12, 60, 1)
INSERT [dbo].[vigencia_promedio] ([id_vigencia_promedio], [dias], [estado]) VALUES (13, 65, 1)
INSERT [dbo].[vigencia_promedio] ([id_vigencia_promedio], [dias], [estado]) VALUES (14, 70, 1)
INSERT [dbo].[vigencia_promedio] ([id_vigencia_promedio], [dias], [estado]) VALUES (15, 75, 1)
INSERT [dbo].[vigencia_promedio] ([id_vigencia_promedio], [dias], [estado]) VALUES (16, 80, 1)
SET IDENTITY_INSERT [dbo].[vigencia_promedio] OFF
ALTER TABLE [dbo].[bitacora]  WITH CHECK ADD  CONSTRAINT [FK_bitacora_movimientos] FOREIGN KEY([id_movimiento])
REFERENCES [dbo].[movimientos] ([id_movimiento])
GO
ALTER TABLE [dbo].[bitacora] CHECK CONSTRAINT [FK_bitacora_movimientos]
GO
ALTER TABLE [dbo].[bodegas]  WITH CHECK ADD  CONSTRAINT [fk_bodegas_sucursales] FOREIGN KEY([id_sucursal])
REFERENCES [dbo].[sucursales] ([id_sucursal])
GO
ALTER TABLE [dbo].[bodegas] CHECK CONSTRAINT [fk_bodegas_sucursales]
GO
ALTER TABLE [dbo].[detalles_movimientos]  WITH CHECK ADD  CONSTRAINT [FK_detalles_movimientos_bodegas] FOREIGN KEY([id_bodega])
REFERENCES [dbo].[bodegas] ([id_bodega])
GO
ALTER TABLE [dbo].[detalles_movimientos] CHECK CONSTRAINT [FK_detalles_movimientos_bodegas]
GO
ALTER TABLE [dbo].[detalles_movimientos]  WITH CHECK ADD  CONSTRAINT [FK_detalles_movimientos_movimientos] FOREIGN KEY([id_movimiento])
REFERENCES [dbo].[movimientos] ([id_movimiento])
GO
ALTER TABLE [dbo].[detalles_movimientos] CHECK CONSTRAINT [FK_detalles_movimientos_movimientos]
GO
ALTER TABLE [dbo].[detalles_movimientos]  WITH CHECK ADD  CONSTRAINT [FK_detalles_movimientos_productos] FOREIGN KEY([id_producto])
REFERENCES [dbo].[productos] ([id_producto])
GO
ALTER TABLE [dbo].[detalles_movimientos] CHECK CONSTRAINT [FK_detalles_movimientos_productos]
GO
ALTER TABLE [dbo].[movimientos]  WITH CHECK ADD  CONSTRAINT [FK_movimientos_proveedores] FOREIGN KEY([id_proveedor])
REFERENCES [dbo].[proveedores] ([id_proveedor])
GO
ALTER TABLE [dbo].[movimientos] CHECK CONSTRAINT [FK_movimientos_proveedores]
GO
ALTER TABLE [dbo].[movimientos]  WITH CHECK ADD  CONSTRAINT [fk_movimientos_tipo_movimiento] FOREIGN KEY([id_tipo_movimiento])
REFERENCES [dbo].[tipo_movimiento] ([id_tipo_movimiento])
GO
ALTER TABLE [dbo].[movimientos] CHECK CONSTRAINT [fk_movimientos_tipo_movimiento]
GO
ALTER TABLE [dbo].[movimientos]  WITH CHECK ADD  CONSTRAINT [FK_movimientos_usuarios] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[movimientos] CHECK CONSTRAINT [FK_movimientos_usuarios]
GO
ALTER TABLE [dbo].[productos]  WITH CHECK ADD  CONSTRAINT [FK_productos_sub_clasificaciones] FOREIGN KEY([id_sub_clasificacion])
REFERENCES [dbo].[sub_clasificaciones] ([id_sub_clasificacion])
GO
ALTER TABLE [dbo].[productos] CHECK CONSTRAINT [FK_productos_sub_clasificaciones]
GO
ALTER TABLE [dbo].[productos]  WITH CHECK ADD  CONSTRAINT [fk_prouctos_viegncia_promedio] FOREIGN KEY([id_vigencia_promedio])
REFERENCES [dbo].[vigencia_promedio] ([id_vigencia_promedio])
GO
ALTER TABLE [dbo].[productos] CHECK CONSTRAINT [fk_prouctos_viegncia_promedio]
GO
ALTER TABLE [dbo].[proveedor_producto]  WITH CHECK ADD  CONSTRAINT [FK_proveedor_producto_productos] FOREIGN KEY([id_producto])
REFERENCES [dbo].[productos] ([id_producto])
GO
ALTER TABLE [dbo].[proveedor_producto] CHECK CONSTRAINT [FK_proveedor_producto_productos]
GO
ALTER TABLE [dbo].[proveedor_producto]  WITH CHECK ADD  CONSTRAINT [FK_proveedor_producto_proveedores] FOREIGN KEY([id_proveedor])
REFERENCES [dbo].[proveedores] ([id_proveedor])
GO
ALTER TABLE [dbo].[proveedor_producto] CHECK CONSTRAINT [FK_proveedor_producto_proveedores]
GO
ALTER TABLE [dbo].[proveedores]  WITH CHECK ADD  CONSTRAINT [fk_proveedores] FOREIGN KEY([id_tipo_proveedor])
REFERENCES [dbo].[tipo_proveedor] ([id_tipo_proveedor])
GO
ALTER TABLE [dbo].[proveedores] CHECK CONSTRAINT [fk_proveedores]
GO
ALTER TABLE [dbo].[sub_clasificaciones]  WITH CHECK ADD  CONSTRAINT [fk_sub_clasificacion_clasificaciones] FOREIGN KEY([id_clasificacion])
REFERENCES [dbo].[clasificacion] ([id_clasificacion])
GO
ALTER TABLE [dbo].[sub_clasificaciones] CHECK CONSTRAINT [fk_sub_clasificacion_clasificaciones]
GO
ALTER TABLE [dbo].[tipo_bodega_bodegas]  WITH CHECK ADD  CONSTRAINT [FK_tipo_bodega_bodegas_bodegas] FOREIGN KEY([id_bodega])
REFERENCES [dbo].[bodegas] ([id_bodega])
GO
ALTER TABLE [dbo].[tipo_bodega_bodegas] CHECK CONSTRAINT [FK_tipo_bodega_bodegas_bodegas]
GO
ALTER TABLE [dbo].[tipo_bodega_bodegas]  WITH CHECK ADD  CONSTRAINT [FK_tipo_bodega_bodegas_tipo_bodega] FOREIGN KEY([id_tipo_bodega])
REFERENCES [dbo].[tipo_bodega] ([id_tipo_bodega])
GO
ALTER TABLE [dbo].[tipo_bodega_bodegas] CHECK CONSTRAINT [FK_tipo_bodega_bodegas_tipo_bodega]
GO
ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_roles] FOREIGN KEY([id_rol])
REFERENCES [dbo].[roles] ([id_rol])
GO
ALTER TABLE [dbo].[usuarios] CHECK CONSTRAINT [FK_usuarios_roles]
GO
/****** Object:  StoredProcedure [dbo].[sp_consulta_bodega_habilitada]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_consulta_bodega_habilitada]
@estado as int
AS
select * from dbo.bodegas b inner join dbo.sucursales s on b.id_sucursal = s.id_sucursal inner join dbo.tipo_bodega t on b.id_tipo_bodega = t.id_tipo_bodega inner join dbo.tipo_bodega_bodegas g on b.id_tipo_bodega = g.id_tipo_bodega where
b.estado = @estado

GO
/****** Object:  StoredProcedure [dbo].[sp_consulta_bodega_tipo]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_consulta_bodega_tipo]
@tipo as int
AS
select * from dbo.bodegas b inner join dbo.sucursales s on b.id_sucursal = s.id_sucursal inner join dbo.tipo_bodega t on b.id_tipo_bodega = t.id_tipo_bodega inner join dbo.tipo_bodega_bodegas g on b.id_tipo_bodega = g.id_tipo_bodega where
b.id_tipo_bodega = @tipo

GO
/****** Object:  StoredProcedure [dbo].[sp_consulta_kardex_tipo_f]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_consulta_kardex_tipo_f]
@fecha_inicio as date,
@fecha_fin as date

AS
select m.fecha, m.hora, m.descripcion, m.costo_total_con_iva, m.costo_total_sin_iva, m.estado, fecha_vencimiento, lote, cantidad, costo_unitario, 
costo_unitario_promedio, existencia_anterior, existencia_total, d.estado, usuario, nombre_completo, dui, u.estado, estado_sesion, 
fecha_ultimo_ingreso, hora_ultimo_ingreso, p.nombre, codigo, p.descripcion, fecha_creacion, hora_creacion, p.estado, 
costo_unitario_con_iva, dias, v.estado, nombre_clasificacion, sub_clasificacion from dbo.movimientos m

inner join dbo.detalles_movimientos d on m.id_movimiento = d.id_movimiento
inner join dbo.usuarios u on m.id_usuario = u.id_usuario
inner join dbo.productos p on d.id_producto = p.id_producto
inner join dbo.vigencia_promedio v on p.id_vigencia_promedio = v.id_vigencia_promedio
inner join dbo.clasificacion c on p.id_clasificacion = c.id_clasificacion
inner join dbo.sub_clasificaciones s on p.id_sub_clasificacion = s.id_sub_clasificacion
 where fecha >= @fecha_inicio and fecha <= @fecha_fin

GO
/****** Object:  StoredProcedure [dbo].[sp_consulta_kardex_tipo_m]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_consulta_kardex_tipo_m]
@tipo_m as int,
@fecha_inicio as date,
@fecha_fin as date

AS
select m.fecha, m.hora, m.descripcion, m.costo_total_con_iva, m.costo_total_sin_iva, m.estado, fecha_vencimiento, lote, cantidad, costo_unitario, costo_unitario_promedio, existencia_anterior, existencia_total, d.estado, usuario, nombre_completo, dui, u.estado, estado_sesion, fecha_ultimo_ingreso, hora_ultimo_ingreso, p.nombre, codigo, p.descripcion, fecha_creacion, hora_creacion, p.estado, costo_unitario_con_iva, dias, v.estado, nombre_clasificacion, sub_clasificacion, r.nombre, direccion, nit, nrc, correo, razon_social, p.estado, tipo_proveedor, t.estado, nombre_bodega, b.estado, sucursal, f.estado, tipo, h.estado, temperatura_promedio, capacidad_maxima, capacidad_actual from dbo.movimientos m
inner join dbo.detalles_movimientos d on m.id_movimiento = d.id_movimiento
inner join dbo.usuarios u on m.id_usuario = u.id_usuario
inner join dbo.productos p on d.id_producto = p.id_producto
inner join dbo.vigencia_promedio v on p.id_vigencia_promedio = v.id_vigencia_promedio
inner join dbo.clasificacion c on p.id_clasificacion = c.id_clasificacion
inner join dbo.sub_clasificaciones s on p.id_sub_clasificacion = s.id_sub_clasificacion
inner join dbo.proveedores r on p.id_proveedor = r.id_proveedor
inner join dbo.tipo_proveedor t on r.id_tipo_proveedor = t.id_tipo_proveedor
inner join dbo.bodegas b on d.id_bodega = b.id_bodega
inner join dbo.sucursales f on b.id_sucursal = f.id_sucursal
inner join dbo.tipo_bodega h on b.id_tipo_bodega = h.id_tipo_bodega
inner join dbo.tipo_bodega_bodegas g on b.id_tipo_bodega = g.id_tipo_bodega
 where fecha >= @fecha_inicio and fecha <= @fecha_fin  and m.id_tipo_movimiento = @tipo_m
 

GO
/****** Object:  StoredProcedure [dbo].[sp_consulta_producto]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_consulta_producto]
@Cod_prod as varchar(250)
AS
select * from dbo.productos p inner join dbo.vigencia_promedio v on p.id_vigencia_promedio = v.id_vigencia_promedio inner join dbo.clasificacion c on p.id_clasificacion = c.id_clasificacion inner join dbo.sub_clasificaciones s on p.id_sub_clasificacion = s.id_sub_clasificacion inner join dbo.proveedores r on p.id_proveedor = r.id_proveedor inner join dbo.tipo_proveedor t on r.id_tipo_proveedor = t.id_tipo_proveedor where
p.codigo = @cod_prod

GO
/****** Object:  StoredProcedure [dbo].[sp_consulta_producto_clas_fr]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_consulta_producto_clas_fr]
@fecha_inicio as date,
@fecha_fin as date,
@cla as int
AS
select * from dbo.productos p inner join dbo.vigencia_promedio v on p.id_vigencia_promedio = v.id_vigencia_promedio inner join dbo.clasificacion c on p.id_clasificacion = c.id_clasificacion inner join dbo.sub_clasificaciones s on p.id_sub_clasificacion = s.id_sub_clasificacion inner join dbo.proveedores r on p.id_proveedor = r.id_proveedor inner join dbo.tipo_proveedor t on r.id_tipo_proveedor = t.id_tipo_proveedor where
p.fecha_creacion >= @fecha_inicio and p.fecha_creacion <= @fecha_fin and p.id_clasificacion = @cla

GO
/****** Object:  StoredProcedure [dbo].[sp_consulta_producto_clas_sub_fr]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_consulta_producto_clas_sub_fr]
@fecha_inicio as date,
@fecha_fin as date,
@cla as int,
@sub_cla as int
AS
select * from dbo.productos p inner join dbo.vigencia_promedio v on p.id_vigencia_promedio = v.id_vigencia_promedio inner join dbo.clasificacion c on p.id_clasificacion = c.id_clasificacion inner join dbo.sub_clasificaciones s on p.id_sub_clasificacion = s.id_sub_clasificacion inner join dbo.proveedores r on p.id_proveedor = r.id_proveedor inner join dbo.tipo_proveedor t on r.id_tipo_proveedor = t.id_tipo_proveedor where
fecha_creacion >= @fecha_inicio and fecha_creacion <= @fecha_fin and p.id_clasificacion = @cla and p.id_sub_clasificacion = @sub_cla

GO
/****** Object:  StoredProcedure [dbo].[sp_consulta_producto_fr]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_consulta_producto_fr]
@fecha_inicio as date,
@fecha_fin as date
AS
select * from dbo.productos p inner join dbo.vigencia_promedio v on p.id_vigencia_promedio = v.id_vigencia_promedio inner join dbo.clasificacion c on p.id_clasificacion = c.id_clasificacion inner join dbo.sub_clasificaciones s on p.id_sub_clasificacion = s.id_sub_clasificacion inner join dbo.proveedores r on p.id_proveedor = r.id_proveedor inner join dbo.tipo_proveedor t on r.id_tipo_proveedor = t.id_tipo_proveedor where
fecha_creacion >= @fecha_inicio and fecha_creacion <= @fecha_fin

GO
/****** Object:  StoredProcedure [dbo].[sp_consulta_producto_nom]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_consulta_producto_nom]
@nom_prod as varchar(250)
AS
select * from dbo.productos p inner join dbo.vigencia_promedio v on p.id_vigencia_promedio = v.id_vigencia_promedio inner join dbo.clasificacion c on p.id_clasificacion = c.id_clasificacion inner join dbo.sub_clasificaciones s on p.id_sub_clasificacion = s.id_sub_clasificacion inner join dbo.proveedores r on p.id_proveedor = r.id_proveedor inner join dbo.tipo_proveedor t on r.id_tipo_proveedor = t.id_tipo_proveedor where
p.nombre = @nom_prod

GO
/****** Object:  StoredProcedure [dbo].[sp_consulta_producto_subc_fr]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_consulta_producto_subc_fr]
@fecha_inicio as date,
@fecha_fin as date,
@sub_cla as int
AS
select * from dbo.productos p inner join dbo.vigencia_promedio v on p.id_vigencia_promedio = v.id_vigencia_promedio inner join dbo.clasificacion c on p.id_clasificacion = c.id_clasificacion inner join dbo.sub_clasificaciones s on p.id_sub_clasificacion = s.id_sub_clasificacion inner join dbo.proveedores r on p.id_proveedor = r.id_proveedor inner join dbo.tipo_proveedor t on r.id_tipo_proveedor = t.id_tipo_proveedor where
fecha_creacion >= @fecha_inicio and fecha_creacion <= @fecha_fin and p.id_sub_clasificacion = @sub_cla

GO
/****** Object:  StoredProcedure [dbo].[sp_consulta_productos_por_vencer]    Script Date: 24/04/2020 20:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[sp_consulta_productos_por_vencer]
@fecha_inicio as date,
@fecha_fin as date

AS
select m.fecha, m.hora, m.descripcion, m.costo_total_con_iva, m.costo_total_sin_iva, m.estado, fecha_vencimiento, lote, cantidad, costo_unitario, 
costo_unitario_promedio, existencia_anterior, existencia_total, d.estado, usuario, nombre_completo, dui, u.estado, estado_sesion, 
fecha_ultimo_ingreso, hora_ultimo_ingreso, p.nombre, codigo, p.descripcion, fecha_creacion, hora_creacion, p.estado, 
costo_unitario_con_iva, dias, v.estado, nombre_clasificacion, sub_clasificacion

from dbo.movimientos m
inner join dbo.detalles_movimientos d on m.id_movimiento = d.id_movimiento
inner join dbo.usuarios u on m.id_usuario = u.id_usuario
inner join dbo.productos p on d.id_producto = p.id_producto
inner join dbo.vigencia_promedio v on p.id_vigencia_promedio = v.id_vigencia_promedio
inner join dbo.clasificacion c on p.id_clasificacion = c.id_clasificacion
inner join dbo.sub_clasificaciones s on p.id_sub_clasificacion = s.id_sub_clasificacion

where fecha_vencimiento >= @fecha_inicio and fecha_vencimiento <= @fecha_fin and existencia_total > 0

GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "usuarios"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 246
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_login'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_login'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "productos"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 246
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "proveedores"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 246
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "sub_clasificaciones"
            Begin Extent = 
               Top = 270
               Left = 38
               Bottom = 400
               Right = 246
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "clasificacion"
            Begin Extent = 
               Top = 402
               Left = 38
               Bottom = 515
               Right = 246
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vigencia_promedio"
            Begin Extent = 
               Top = 516
               Left = 38
               Bottom = 629
               Right = 246
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
    ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_producto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'     Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_producto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_producto'
GO
USE [master]
GO
ALTER DATABASE [inventario] SET  READ_WRITE 
GO
