USE [master]
GO
/****** Object:  Database [HOSPITAL]    Script Date: 7/28/2020 12:34:09 PM ******/
CREATE DATABASE [HOSPITAL]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HOSPITAL', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\HOSPITAL.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HOSPITAL_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\HOSPITAL_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [HOSPITAL] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HOSPITAL].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HOSPITAL] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HOSPITAL] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HOSPITAL] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HOSPITAL] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HOSPITAL] SET ARITHABORT OFF 
GO
ALTER DATABASE [HOSPITAL] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HOSPITAL] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HOSPITAL] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HOSPITAL] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HOSPITAL] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HOSPITAL] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HOSPITAL] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HOSPITAL] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HOSPITAL] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HOSPITAL] SET  ENABLE_BROKER 
GO
ALTER DATABASE [HOSPITAL] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HOSPITAL] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HOSPITAL] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HOSPITAL] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HOSPITAL] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HOSPITAL] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HOSPITAL] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HOSPITAL] SET RECOVERY FULL 
GO
ALTER DATABASE [HOSPITAL] SET  MULTI_USER 
GO
ALTER DATABASE [HOSPITAL] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HOSPITAL] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HOSPITAL] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HOSPITAL] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HOSPITAL] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'HOSPITAL', N'ON'
GO
ALTER DATABASE [HOSPITAL] SET QUERY_STORE = OFF
GO
USE [HOSPITAL]
GO
/****** Object:  Table [dbo].[Altas]    Script Date: 7/28/2020 12:34:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Altas](
	[Id_Alta] [int] IDENTITY(1,1) NOT NULL,
	[Id_Ingreso_A] [int] NOT NULL,
	[Fecha_Ingreso] [date] NULL,
	[Paciente] [varchar](80) NULL,
	[habitacion] [varchar](80) NULL,
	[id_habitacion] [int] NULL,
	[Fecha_Salida] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Alta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Citas]    Script Date: 7/28/2020 12:34:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Citas](
	[Id_Cita] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NOT NULL,
	[Id_Paciente_C] [int] NOT NULL,
	[Id_Doctor_C] [int] NOT NULL,
	[Hora] [time](0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Cita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctores]    Script Date: 7/28/2020 12:34:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctores](
	[Id_Doctor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](150) NOT NULL,
	[Exequatur] [nchar](150) NOT NULL,
	[Especialidad] [varchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Doctor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Habitaciones]    Script Date: 7/28/2020 12:34:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Habitaciones](
	[Id_Habitacion] [int] IDENTITY(1,1) NOT NULL,
	[Numero] [nchar](30) NOT NULL,
	[Tipo] [varchar](150) NOT NULL,
	[Precio] [smallmoney] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Habitacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ingresos]    Script Date: 7/28/2020 12:34:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingresos](
	[id_Ingreso] [int] IDENTITY(1,1) NOT NULL,
	[id_Paciente_I] [int] NOT NULL,
	[Id_Habitacion_I] [int] NOT NULL,
	[Fecha_Inicio] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Ingreso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pacientes]    Script Date: 7/28/2020 12:34:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pacientes](
	[Id_Paciente] [int] IDENTITY(1,1) NOT NULL,
	[Cedula] [nvarchar](50) NOT NULL,
	[Nombre] [varchar](150) NOT NULL,
	[Asegurado] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Paciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Citas] ON 

INSERT [dbo].[Citas] ([Id_Cita], [Fecha], [Id_Paciente_C], [Id_Doctor_C], [Hora]) VALUES (3, CAST(N'2020-07-27' AS Date), 7, 2, CAST(N'18:30:00' AS Time))
INSERT [dbo].[Citas] ([Id_Cita], [Fecha], [Id_Paciente_C], [Id_Doctor_C], [Hora]) VALUES (5, CAST(N'2020-07-30' AS Date), 6, 2, CAST(N'18:30:00' AS Time))
SET IDENTITY_INSERT [dbo].[Citas] OFF
SET IDENTITY_INSERT [dbo].[Doctores] ON 

INSERT [dbo].[Doctores] ([Id_Doctor], [Nombre], [Exequatur], [Especialidad]) VALUES (2, N'Fraydeli Morelia', N'DR245-963258                                                                                                                                          ', N'Nutricion')
SET IDENTITY_INSERT [dbo].[Doctores] OFF
SET IDENTITY_INSERT [dbo].[Habitaciones] ON 

INSERT [dbo].[Habitaciones] ([Id_Habitacion], [Numero], [Tipo], [Precio]) VALUES (2, N'500-A                         ', N'Privada', 450.0000)
INSERT [dbo].[Habitaciones] ([Id_Habitacion], [Numero], [Tipo], [Precio]) VALUES (3, N'501-L                         ', N'Suit', 750.0000)
SET IDENTITY_INSERT [dbo].[Habitaciones] OFF
SET IDENTITY_INSERT [dbo].[Ingresos] ON 

INSERT [dbo].[Ingresos] ([id_Ingreso], [id_Paciente_I], [Id_Habitacion_I], [Fecha_Inicio]) VALUES (8, 5, 2, CAST(N'2020-07-27' AS Date))
INSERT [dbo].[Ingresos] ([id_Ingreso], [id_Paciente_I], [Id_Habitacion_I], [Fecha_Inicio]) VALUES (9, 6, 3, CAST(N'2020-07-30' AS Date))
SET IDENTITY_INSERT [dbo].[Ingresos] OFF
SET IDENTITY_INSERT [dbo].[Pacientes] ON 

INSERT [dbo].[Pacientes] ([Id_Paciente], [Cedula], [Nombre], [Asegurado]) VALUES (5, N'402-1850541-6', N'Rangel Acevedo', N'Asegurado')
INSERT [dbo].[Pacientes] ([Id_Paciente], [Cedula], [Nombre], [Asegurado]) VALUES (6, N'068-6584792-1', N'Ramona Frias', N'Asegurado')
INSERT [dbo].[Pacientes] ([Id_Paciente], [Cedula], [Nombre], [Asegurado]) VALUES (7, N'402-9658423-7', N'Miguel Rosa', N'No Asegurado')
SET IDENTITY_INSERT [dbo].[Pacientes] OFF
/****** Object:  Index [UQ__Altas__EB61903987AB5FD4]    Script Date: 7/28/2020 12:34:09 PM ******/
ALTER TABLE [dbo].[Altas] ADD UNIQUE NONCLUSTERED 
(
	[Id_Ingreso_A] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Doctores__914AB06B87075C04]    Script Date: 7/28/2020 12:34:09 PM ******/
ALTER TABLE [dbo].[Doctores] ADD UNIQUE NONCLUSTERED 
(
	[Exequatur] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Habitaci__7E532BC6A9C09246]    Script Date: 7/28/2020 12:34:09 PM ******/
ALTER TABLE [dbo].[Habitaciones] ADD UNIQUE NONCLUSTERED 
(
	[Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Altas]  WITH CHECK ADD  CONSTRAINT [FK_Altas_Id_habitacion] FOREIGN KEY([id_habitacion])
REFERENCES [dbo].[Habitaciones] ([Id_Habitacion])
GO
ALTER TABLE [dbo].[Altas] CHECK CONSTRAINT [FK_Altas_Id_habitacion]
GO
ALTER TABLE [dbo].[Citas]  WITH CHECK ADD  CONSTRAINT [FK_Citas_Id_Doctor_C] FOREIGN KEY([Id_Doctor_C])
REFERENCES [dbo].[Doctores] ([Id_Doctor])
GO
ALTER TABLE [dbo].[Citas] CHECK CONSTRAINT [FK_Citas_Id_Doctor_C]
GO
ALTER TABLE [dbo].[Citas]  WITH CHECK ADD  CONSTRAINT [FK_Citas_Id_Paciente_C] FOREIGN KEY([Id_Paciente_C])
REFERENCES [dbo].[Pacientes] ([Id_Paciente])
GO
ALTER TABLE [dbo].[Citas] CHECK CONSTRAINT [FK_Citas_Id_Paciente_C]
GO
ALTER TABLE [dbo].[Ingresos]  WITH CHECK ADD  CONSTRAINT [FK_Ingresos_Id_Habitacion_I] FOREIGN KEY([Id_Habitacion_I])
REFERENCES [dbo].[Habitaciones] ([Id_Habitacion])
GO
ALTER TABLE [dbo].[Ingresos] CHECK CONSTRAINT [FK_Ingresos_Id_Habitacion_I]
GO
ALTER TABLE [dbo].[Ingresos]  WITH CHECK ADD  CONSTRAINT [FK_Ingresos_Id_Paciente_I] FOREIGN KEY([id_Paciente_I])
REFERENCES [dbo].[Pacientes] ([Id_Paciente])
GO
ALTER TABLE [dbo].[Ingresos] CHECK CONSTRAINT [FK_Ingresos_Id_Paciente_I]
GO
/****** Object:  StoredProcedure [dbo].[Citas_Por_Doctor]    Script Date: 7/28/2020 12:34:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Citas_Por_Doctor]
@doctor int
as
SELECT Citas.Id_Cita, Citas.Fecha, Pacientes.Nombre, Doctores.Nombre, Citas.Hora 
	FROM Citas Inner Join Pacientes On Citas.Id_Paciente_C = Pacientes.Id_Paciente
			   INNER JOIN Doctores ON Citas.Id_Doctor_C = Doctores.Id_Doctor WHERE Citas.Id_Doctor_C = @doctor
GO
/****** Object:  StoredProcedure [dbo].[Citas_Por_Fecha]    Script Date: 7/28/2020 12:34:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Citas_Por_Fecha]
@fecha Date
as
SELECT Citas.Id_Cita, Citas.Fecha, Pacientes.Nombre, Doctores.Nombre, Citas.Hora 
	FROM Citas Inner Join Pacientes On Citas.Id_Paciente_C = Pacientes.Id_Paciente
			   INNER JOIN Doctores ON Citas.Id_Doctor_C = Doctores.Id_Doctor WHERE Citas.Fecha = @fecha
GO
/****** Object:  StoredProcedure [dbo].[Citas_Por_Pacientes]    Script Date: 7/28/2020 12:34:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Citas_Por_Pacientes]
@paciente int
as
SELECT Citas.Id_Cita, Citas.Fecha, Pacientes.Nombre, Doctores.Nombre, Citas.Hora 
	FROM Citas Inner Join Pacientes On Citas.Id_Paciente_C = Pacientes.Id_Paciente
			   INNER JOIN Doctores ON Citas.Id_Doctor_C = Doctores.Id_Doctor WHERE Citas.Id_Paciente_C = @paciente
GO
/****** Object:  StoredProcedure [dbo].[CitasPorFecha]    Script Date: 7/28/2020 12:34:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[CitasPorFecha]
@fehca Date
as
SELECT * FROM Pacientes WHERE Pacientes.Nombre = @fehca
GO
/****** Object:  StoredProcedure [dbo].[HabitacionesPorTipo]    Script Date: 7/28/2020 12:34:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[HabitacionesPorTipo]
@tipo Varchar
as
SELECT * FROM Pacientes WHERE Pacientes.Nombre = @tipo
GO
/****** Object:  StoredProcedure [dbo].[Ingresos_Por_Habitacion]    Script Date: 7/28/2020 12:34:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Ingresos_Por_Habitacion]
@habitacion int
as
SELECT Ingresos.id_Ingreso, Pacientes.Nombre, Habitaciones.Numero, Ingresos.Fecha_Inicio 
	FROM Ingresos Inner Join Pacientes On Ingresos.id_Paciente_I = Pacientes.Id_Paciente
			   INNER JOIN Habitaciones ON Ingresos.Id_Habitacion_I = Habitaciones.Id_Habitacion WHERE Ingresos.Id_Habitacion_I = @habitacion
GO
/****** Object:  StoredProcedure [dbo].[ListaIngresos]    Script Date: 7/28/2020 12:34:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ListaIngresos]
@fecha_inicio DAte,
@habitacion nchar
as
BEGIN
SELECT Ingresos.id_Ingreso, Pacientes.Nombre As Paciente, Habitaciones.Numero As Habitacion, Ingresos.Fecha_Inicio AS Fecha
                            FROM Ingresos INNER JOIN Pacientes ON Ingresos.Id_Paciente_I = Pacientes.Id_Paciente
                                          INNER JOIN Habitaciones ON Ingresos.Id_Habitacion_I = Habitaciones.Id_Habitacion WHERE Fecha_Inicio = @fecha_inicio or Habitaciones.Numero = @habitacion
END
GO
/****** Object:  StoredProcedure [dbo].[ListaIngresosFecha]    Script Date: 7/28/2020 12:34:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ListaIngresosFecha]
@fecha_inicio DAte
as
BEGIN
SELECT Ingresos.id_Ingreso, Pacientes.Nombre As Paciente, Habitaciones.Numero As Habitacion, Ingresos.Fecha_Inicio AS Fecha
                            FROM Ingresos INNER JOIN Pacientes ON Ingresos.Id_Paciente_I = Pacientes.Id_Paciente
                                          INNER JOIN Habitaciones ON Ingresos.Id_Habitacion_I = Habitaciones.Id_Habitacion WHERE Fecha_Inicio = @fecha_inicio
END
GO
/****** Object:  StoredProcedure [dbo].[ListarHabitaciones]    Script Date: 7/28/2020 12:34:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[ListarHabitaciones]
as
SELECT * FROM Habitaciones
GO
/****** Object:  StoredProcedure [dbo].[ListarMedicos]    Script Date: 7/28/2020 12:34:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[ListarMedicos]
as
SELECT * FROM Doctores
GO
/****** Object:  StoredProcedure [dbo].[ListarPacientes]    Script Date: 7/28/2020 12:34:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[ListarPacientes]
as
SELECT * FROM Pacientes
GO
/****** Object:  StoredProcedure [dbo].[MedicosPorNombre]    Script Date: 7/28/2020 12:34:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[MedicosPorNombre]
@nombre Varchar
as
SELECT * FROM Pacientes WHERE Pacientes.Nombre = @nombre
GO
/****** Object:  StoredProcedure [dbo].[MostrarCitas]    Script Date: 7/28/2020 12:34:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MostrarCitas]
AS
SELECT Citas.Id_Cita, Citas.Fecha, Pacientes.Nombre As Paciente, Doctores.Nombre As Doctor, Citas.Hora
	FROM Citas INNER JOIN Pacientes ON Citas.Id_Paciente_C = Pacientes.Id_Paciente
			   INNER JOIN Doctores ON Citas.Id_Doctor_C = Doctores.Id_Doctor
GO
/****** Object:  StoredProcedure [dbo].[MostrarIngresados]    Script Date: 7/28/2020 12:34:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MostrarIngresados]
AS
SELECT Ingresos.id_Ingreso, Pacientes.Nombre As Paciente, Habitaciones.Numero As Habitacion, Ingresos.Fecha_Inicio AS Fecha
	FROM Ingresos INNER JOIN Pacientes ON Ingresos.Id_Paciente_I = Pacientes.Id_Paciente
			   INNER JOIN Habitaciones ON Ingresos.Id_Habitacion_I = Habitaciones.Id_Habitacion
GO
/****** Object:  StoredProcedure [dbo].[PacientesPorCedula]    Script Date: 7/28/2020 12:34:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[PacientesPorCedula]
@cedula nvarchar
as
SELECT * FROM Pacientes WHERE Pacientes.Nombre = @cedula
GO
/****** Object:  StoredProcedure [dbo].[PacientesPorEspecialidad]    Script Date: 7/28/2020 12:34:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[PacientesPorEspecialidad]
@especialidad Varchar
as
SELECT * FROM Pacientes WHERE Pacientes.Nombre = @especialidad
GO
/****** Object:  StoredProcedure [dbo].[PacientesPorSeguro]    Script Date: 7/28/2020 12:34:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[PacientesPorSeguro]
@seguro Varchar
as
SELECT * FROM Pacientes WHERE Pacientes.Nombre = @seguro
GO
USE [master]
GO
ALTER DATABASE [HOSPITAL] SET  READ_WRITE 
GO
