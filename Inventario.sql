USE [master]
GO
/****** Object:  Database [inventario]    Script Date: 24/02/2020 22:16:33 ******/
CREATE DATABASE [inventario]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'inventario', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\inventario.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'inventario_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\inventario_log.ldf' , SIZE = 1088KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
ALTER DATABASE [inventario] SET  ENABLE_BROKER 
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
/****** Object:  Table [dbo].[bodegas]    Script Date: 24/02/2020 22:16:33 ******/
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
/****** Object:  Table [dbo].[clasificacion]    Script Date: 24/02/2020 22:16:33 ******/
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
/****** Object:  Table [dbo].[medidas_peso]    Script Date: 24/02/2020 22:16:33 ******/
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
/****** Object:  Table [dbo].[medidas_peso_producto]    Script Date: 24/02/2020 22:16:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[medidas_peso_producto](
	[id_medidas_peso_productos] [int] NOT NULL,
	[id_medida_peso] [int] NULL,
	[id_producto] [int] NULL,
 CONSTRAINT [PK_medidas_peso_producto] PRIMARY KEY CLUSTERED 
(
	[id_medidas_peso_productos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[movimientos]    Script Date: 24/02/2020 22:16:33 ******/
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
	[id_producto] [int] NULL,
	[lote] [nvarchar](250) NULL,
	[fecha_vencimiento] [date] NULL,
	[id_bodega] [int] NULL,
	[cantidad_unitaria_entrada] [decimal](10, 2) NULL,
	[cantidad_unitaria_salida] [decimal](10, 2) NULL,
	[existencia_anterior] [decimal](10, 2) NULL,
	[costo_anterior] [decimal](10, 2) NULL,
	[costo_final] [decimal](10, 2) NULL,
	[id_usuario] [int] NULL,
 CONSTRAINT [pk_movimientos] PRIMARY KEY CLUSTERED 
(
	[id_movimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[procedencias]    Script Date: 24/02/2020 22:16:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[procedencias](
	[id_procedencia] [int] IDENTITY(1,1) NOT NULL,
	[nombre_procedencia] [nchar](20) NULL,
	[estado_procedencia] [int] NULL,
 CONSTRAINT [PK_procedencias] PRIMARY KEY CLUSTERED 
(
	[id_procedencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[prodecencias_usuarios]    Script Date: 24/02/2020 22:16:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prodecencias_usuarios](
	[id_procedencias_usuarios] [int] IDENTITY(1,1) NOT NULL,
	[id_procedencia] [int] NULL,
	[id_usuario] [int] NULL,
 CONSTRAINT [PK_prodecencias_usuarios] PRIMARY KEY CLUSTERED 
(
	[id_procedencias_usuarios] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[productos]    Script Date: 24/02/2020 22:16:33 ******/
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
 CONSTRAINT [pk_productos] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[proveedores]    Script Date: 24/02/2020 22:16:33 ******/
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
/****** Object:  Table [dbo].[roles]    Script Date: 24/02/2020 22:16:33 ******/
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
/****** Object:  Table [dbo].[roles_usuarios]    Script Date: 24/02/2020 22:16:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles_usuarios](
	[id_roles_usuarios] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario] [int] NOT NULL,
	[id_rol] [int] NOT NULL,
 CONSTRAINT [PK_roles_usuarios] PRIMARY KEY CLUSTERED 
(
	[id_roles_usuarios] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sub_clasificaciones]    Script Date: 24/02/2020 22:16:33 ******/
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
/****** Object:  Table [dbo].[sucursales]    Script Date: 24/02/2020 22:16:33 ******/
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
/****** Object:  Table [dbo].[tipo_bodega]    Script Date: 24/02/2020 22:16:33 ******/
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
/****** Object:  Table [dbo].[tipo_bodega_bodegas]    Script Date: 24/02/2020 22:16:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_bodega_bodegas](
	[id_tipo_bodega_bodegas] [int] IDENTITY(1,1) NOT NULL,
	[id_tipo_bodega] [int] NULL,
	[id_bodega] [int] NULL,
 CONSTRAINT [PK_tipo_bodega_bodegas] PRIMARY KEY CLUSTERED 
(
	[id_tipo_bodega_bodegas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tipo_movimiento]    Script Date: 24/02/2020 22:16:33 ******/
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
/****** Object:  Table [dbo].[tipo_proveedor]    Script Date: 24/02/2020 22:16:33 ******/
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
/****** Object:  Table [dbo].[usuarios]    Script Date: 24/02/2020 22:16:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [nchar](10) NULL,
	[clave] [nchar](50) NULL,
	[nombre_completo] [nchar](200) NULL,
	[dui] [nchar](10) NULL,
	[estado] [int] NULL,
	[estado_sesion] [int] NULL,
	[fecha_ultimo_ingreso] [date] NULL,
	[hora_ultimo_ingreso] [time](7) NULL,
	[id_procedencia] [int] NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[vigencia_promedio]    Script Date: 24/02/2020 22:16:33 ******/
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
ALTER TABLE [dbo].[bodegas]  WITH CHECK ADD  CONSTRAINT [fk_bodegas_sucursales] FOREIGN KEY([id_sucursal])
REFERENCES [dbo].[sucursales] ([id_sucursal])
GO
ALTER TABLE [dbo].[bodegas] CHECK CONSTRAINT [fk_bodegas_sucursales]
GO
ALTER TABLE [dbo].[movimientos]  WITH CHECK ADD  CONSTRAINT [fk_movimientos_bodegas] FOREIGN KEY([id_bodega])
REFERENCES [dbo].[bodegas] ([id_bodega])
GO
ALTER TABLE [dbo].[movimientos] CHECK CONSTRAINT [fk_movimientos_bodegas]
GO
ALTER TABLE [dbo].[movimientos]  WITH CHECK ADD  CONSTRAINT [fk_movimientos_productos] FOREIGN KEY([id_producto])
REFERENCES [dbo].[productos] ([id_producto])
GO
ALTER TABLE [dbo].[movimientos] CHECK CONSTRAINT [fk_movimientos_productos]
GO
ALTER TABLE [dbo].[movimientos]  WITH CHECK ADD  CONSTRAINT [fk_movimientos_tipo_movimiento] FOREIGN KEY([id_tipo_movimiento])
REFERENCES [dbo].[tipo_movimiento] ([id_tipo_movimiento])
GO
ALTER TABLE [dbo].[movimientos] CHECK CONSTRAINT [fk_movimientos_tipo_movimiento]
GO
ALTER TABLE [dbo].[productos]  WITH CHECK ADD  CONSTRAINT [fk_productos_clasificaciones] FOREIGN KEY([id_clasificacion])
REFERENCES [dbo].[clasificacion] ([id_clasificacion])
GO
ALTER TABLE [dbo].[productos] CHECK CONSTRAINT [fk_productos_clasificaciones]
GO
ALTER TABLE [dbo].[productos]  WITH CHECK ADD  CONSTRAINT [fk_productos_proveedores] FOREIGN KEY([id_proveedor])
REFERENCES [dbo].[proveedores] ([id_proveedor])
GO
ALTER TABLE [dbo].[productos] CHECK CONSTRAINT [fk_productos_proveedores]
GO
ALTER TABLE [dbo].[productos]  WITH CHECK ADD  CONSTRAINT [fk_prouctos_viegncia_promedio] FOREIGN KEY([id_vigencia_promedio])
REFERENCES [dbo].[vigencia_promedio] ([id_vigencia_promedio])
GO
ALTER TABLE [dbo].[productos] CHECK CONSTRAINT [fk_prouctos_viegncia_promedio]
GO
ALTER TABLE [dbo].[proveedores]  WITH CHECK ADD  CONSTRAINT [fk_proveedores] FOREIGN KEY([id_tipo_proveedor])
REFERENCES [dbo].[tipo_proveedor] ([id_tipo_proveedor])
GO
ALTER TABLE [dbo].[proveedores] CHECK CONSTRAINT [fk_proveedores]
GO
ALTER TABLE [dbo].[roles_usuarios]  WITH CHECK ADD  CONSTRAINT [fk_roles_usuarios_roles] FOREIGN KEY([id_rol])
REFERENCES [dbo].[roles] ([id_rol])
GO
ALTER TABLE [dbo].[roles_usuarios] CHECK CONSTRAINT [fk_roles_usuarios_roles]
GO
ALTER TABLE [dbo].[roles_usuarios]  WITH CHECK ADD  CONSTRAINT [FK_roles_usuarios_usuarios] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[roles_usuarios] CHECK CONSTRAINT [FK_roles_usuarios_usuarios]
GO
ALTER TABLE [dbo].[sub_clasificaciones]  WITH CHECK ADD  CONSTRAINT [fk_sub_clasificacion_clasificaciones] FOREIGN KEY([id_clasificacion])
REFERENCES [dbo].[clasificacion] ([id_clasificacion])
GO
ALTER TABLE [dbo].[sub_clasificaciones] CHECK CONSTRAINT [fk_sub_clasificacion_clasificaciones]
GO
USE [master]
GO
ALTER DATABASE [inventario] SET  READ_WRITE 
GO
