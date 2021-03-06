/****** Object:  Table [dbo].[Menu]    Script Date: 24/11/2015 19:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nchar](50) NOT NULL,
	[url] [nchar](500) NOT NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF)
)

GO
/****** Object:  Table [dbo].[Rol]    Script Date: 24/11/2015 19:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF)
)

GO
/****** Object:  Table [dbo].[RolesMenu]    Script Date: 24/11/2015 19:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RolesMenu](
	[idRol] [int] NOT NULL,
	[idMenu] [int] NOT NULL,
	[orden] [int] NOT NULL,
 CONSTRAINT [PK_RolesMenu] PRIMARY KEY CLUSTERED 
(
	[idRol] ASC,
	[idMenu] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF)
)

GO
/****** Object:  Table [dbo].[Tipos]    Script Date: 24/11/2015 19:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipos](
	[idTipo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nchar](250) NOT NULL,
	[descripcion] [nchar](500) NULL,
 CONSTRAINT [PK_Tipos] PRIMARY KEY CLUSTERED 
(
	[idTipo] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF)
)

GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 24/11/2015 19:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[login] [nchar](500) NOT NULL,
	[password] [nchar](500) NOT NULL,
	[nombre] [nchar](500) NULL,
	[imagen] [nchar](500) NULL,
	[apellidos] [nchar](500) NULL,
	[idRol] [int] NOT NULL,
	[email] [nchar](250) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF)
)

GO
/****** Object:  Table [dbo].[Vehiculos]    Script Date: 24/11/2015 19:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehiculos](
	[matricula] [nchar](10) NOT NULL,
	[marca] [nchar](150) NOT NULL,
	[modelo] [nchar](250) NOT NULL,
	[coste] [decimal](18, 0) NULL,
	[idTipo] [int] NULL,
 CONSTRAINT [PK_Vehiculos] PRIMARY KEY CLUSTERED 
(
	[matricula] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF)
)

GO
SET IDENTITY_INSERT [dbo].[Rol] ON 

INSERT [dbo].[Rol] ([id], [nombre]) VALUES (1, N'Admin                                             ')
SET IDENTITY_INSERT [dbo].[Rol] OFF
SET IDENTITY_INSERT [dbo].[Tipos] ON 

INSERT [dbo].[Tipos] ([idTipo], [nombre], [descripcion]) VALUES (1, N'Furgoneta                                                                                                                                                                                                                                                 ', N'Una furgoneta es un vehículo para transporte de objetos o grupos de personas, con un gran volumen de carga en relación a su batalla. Se asemejan estructuralmente a los monovolúmenes                                                                                                                                                                                                                                                                                                                               ')
INSERT [dbo].[Tipos] ([idTipo], [nombre], [descripcion]) VALUES (2, N'Monovolumen                                                                                                                                                                                                                                               ', N'Un monovolumen o Minivan es un automóvil relativamente alto en el que el compartimiento del motor, la cabina y el maletero están integrados en uno. Esta configuración de diseño pretende aumentar el espacio del habitáculo y el maletero para una longitud exterior dada. En algunos casos, los asientos pueden desplazarse e incluso desmontarse, para configurar el interior del automóvil de acuerdo con las necesidades del usuario en cada momento.                                                          ')
INSERT [dbo].[Tipos] ([idTipo], [nombre], [descripcion]) VALUES (3, N'Turismo                                                                                                                                                                                                                                                   ', N'es un automóvil relativamente clásico, con capacidad para transportar unas cuatro o cinco personas y equipaje. Las carrocerías asociadas a un turismo son hatchback, liftback, sedán y familiar.                                                                                                                                                                                                                                                                                                                    ')
INSERT [dbo].[Tipos] ([idTipo], [nombre], [descripcion]) VALUES (4, N'Camioneta                                                                                                                                                                                                                                                 ', N'es un automóvil de carga que tiene en su parte trasera una plataforma descubierta, en que se pueden colocar objetos grandes                                                                                                                                                                                                                                                                                                                                                                                         ')
INSERT [dbo].[Tipos] ([idTipo], [nombre], [descripcion]) VALUES (5, N'Trolebus                                                                                                                                                                                                                                                  ', N'Trolebus                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            ')
INSERT [dbo].[Tipos] ([idTipo], [nombre], [descripcion]) VALUES (6, N'Avion                                                                                                                                                                                                                                                     ', N'Avion                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               ')
INSERT [dbo].[Tipos] ([idTipo], [nombre], [descripcion]) VALUES (7, N'Submarino                                                                                                                                                                                                                                                 ', N'Submarino                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           ')
INSERT [dbo].[Tipos] ([idTipo], [nombre], [descripcion]) VALUES (8, N'Espacial                                                                                                                                                                                                                                                  ', N'Nave espacial                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       ')
SET IDENTITY_INSERT [dbo].[Tipos] OFF
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([id], [login], [password], [nombre], [imagen], [apellidos], [idRol], [email]) VALUES (1, N'luis                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                ', N'7110eda4d09e062aa5e4a390b0a572ac0d2c0220                                                                                                                                                                                                                                                                                                                                                                                                                                                                            ', N'Luis                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                ', N'url                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 ', N'Gil                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 ', 1, N'XMN0t6qp/PCtadqKHpH2bSF7jK5QeMfheU/ihajUjAnWpSBgZ9Jq70u3+2VYKifP                                                                                                                                                                                          ')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
INSERT [dbo].[Vehiculos] ([matricula], [marca], [modelo], [coste], [idTipo]) VALUES (N'LU6360X   ', N'Honda                                                                                                                                                 ', N'2014                                                                                                                                                                                                                                                      ', CAST(10000 AS Decimal(18, 0)), 3)
INSERT [dbo].[Vehiculos] ([matricula], [marca], [modelo], [coste], [idTipo]) VALUES (N'M6814ZX   ', N'Ford                                                                                                                                                  ', N'2015                                                                                                                                                                                                                                                      ', CAST(3000 AS Decimal(18, 0)), 3)
ALTER TABLE [dbo].[RolesMenu]  WITH CHECK ADD  CONSTRAINT [FK_RolesMenu_Menu] FOREIGN KEY([idMenu])
REFERENCES [dbo].[Menu] ([id])
GO
ALTER TABLE [dbo].[RolesMenu] CHECK CONSTRAINT [FK_RolesMenu_Menu]
GO
ALTER TABLE [dbo].[RolesMenu]  WITH CHECK ADD  CONSTRAINT [FK_RolesMenu_Rol] FOREIGN KEY([idRol])
REFERENCES [dbo].[Rol] ([id])
GO
ALTER TABLE [dbo].[RolesMenu] CHECK CONSTRAINT [FK_RolesMenu_Rol]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol] FOREIGN KEY([idRol])
REFERENCES [dbo].[Rol] ([id])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Rol]
GO
ALTER TABLE [dbo].[Vehiculos]  WITH CHECK ADD  CONSTRAINT [FK_Vehiculos_Tipos] FOREIGN KEY([idTipo])
REFERENCES [dbo].[Tipos] ([idTipo])
GO
ALTER TABLE [dbo].[Vehiculos] CHECK CONSTRAINT [FK_Vehiculos_Tipos]
GO
