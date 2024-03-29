USE [master]
GO
/****** Object:  Database [BDListaProfesor]    Script Date: 23/06/2019 1:00:15 ******/
CREATE DATABASE [BDListaProfesor]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDListaProfesor', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\BDListaProfesor.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BDListaProfesor_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\BDListaProfesor_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BDListaProfesor] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDListaProfesor].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BDListaProfesor] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BDListaProfesor] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BDListaProfesor] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BDListaProfesor] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BDListaProfesor] SET ARITHABORT OFF 
GO
ALTER DATABASE [BDListaProfesor] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BDListaProfesor] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BDListaProfesor] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BDListaProfesor] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BDListaProfesor] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BDListaProfesor] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BDListaProfesor] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BDListaProfesor] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BDListaProfesor] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BDListaProfesor] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BDListaProfesor] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BDListaProfesor] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BDListaProfesor] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BDListaProfesor] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BDListaProfesor] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BDListaProfesor] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BDListaProfesor] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BDListaProfesor] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BDListaProfesor] SET  MULTI_USER 
GO
ALTER DATABASE [BDListaProfesor] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BDListaProfesor] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BDListaProfesor] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BDListaProfesor] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BDListaProfesor] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BDListaProfesor] SET QUERY_STORE = OFF
GO
USE [BDListaProfesor]
GO
/****** Object:  Table [dbo].[Estudiantes]    Script Date: 23/06/2019 1:00:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudiantes](
	[NroLista] [numeric](8, 0) IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Baja] [bigint] NULL,
	[Faltas] [numeric](8, 0) NOT NULL,
 CONSTRAINT [PK_Estudiantes] PRIMARY KEY CLUSTERED 
(
	[NroLista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Falta]    Script Date: 23/06/2019 1:00:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Falta](
	[ID] [numeric](8, 0) IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NOT NULL,
	[IDEstudiante] [numeric](8, 0) NOT NULL,
	[Justificada] [bit] NULL,
 CONSTRAINT [PK_Falta] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Estudiantes] ON 

INSERT [dbo].[Estudiantes] ([NroLista], [Nombre], [Baja], [Faltas]) VALUES (CAST(1 AS Numeric(8, 0)), N'gnd', 0, CAST(2 AS Numeric(8, 0)))
INSERT [dbo].[Estudiantes] ([NroLista], [Nombre], [Baja], [Faltas]) VALUES (CAST(2 AS Numeric(8, 0)), N'gnd', 0, CAST(9 AS Numeric(8, 0)))
INSERT [dbo].[Estudiantes] ([NroLista], [Nombre], [Baja], [Faltas]) VALUES (CAST(3 AS Numeric(8, 0)), N'dsnl', 0, CAST(4 AS Numeric(8, 0)))
INSERT [dbo].[Estudiantes] ([NroLista], [Nombre], [Baja], [Faltas]) VALUES (CAST(4 AS Numeric(8, 0)), N'nsdkl', 0, CAST(0 AS Numeric(8, 0)))
INSERT [dbo].[Estudiantes] ([NroLista], [Nombre], [Baja], [Faltas]) VALUES (CAST(5 AS Numeric(8, 0)), N'dfnfln', 1, CAST(0 AS Numeric(8, 0)))
INSERT [dbo].[Estudiantes] ([NroLista], [Nombre], [Baja], [Faltas]) VALUES (CAST(6 AS Numeric(8, 0)), N'gbjd', 0, CAST(0 AS Numeric(8, 0)))
INSERT [dbo].[Estudiantes] ([NroLista], [Nombre], [Baja], [Faltas]) VALUES (CAST(7 AS Numeric(8, 0)), N'gnad', 0, CAST(5 AS Numeric(8, 0)))
INSERT [dbo].[Estudiantes] ([NroLista], [Nombre], [Baja], [Faltas]) VALUES (CAST(8 AS Numeric(8, 0)), N'Pepito', 0, CAST(0 AS Numeric(8, 0)))
INSERT [dbo].[Estudiantes] ([NroLista], [Nombre], [Baja], [Faltas]) VALUES (CAST(9 AS Numeric(8, 0)), N'kns', 1, CAST(0 AS Numeric(8, 0)))
INSERT [dbo].[Estudiantes] ([NroLista], [Nombre], [Baja], [Faltas]) VALUES (CAST(10 AS Numeric(8, 0)), N'nfaksbnd', 1, CAST(0 AS Numeric(8, 0)))
INSERT [dbo].[Estudiantes] ([NroLista], [Nombre], [Baja], [Faltas]) VALUES (CAST(11 AS Numeric(8, 0)), N'dsbsdn', 1, CAST(0 AS Numeric(8, 0)))
INSERT [dbo].[Estudiantes] ([NroLista], [Nombre], [Baja], [Faltas]) VALUES (CAST(10009 AS Numeric(8, 0)), N'Lionel', 0, CAST(0 AS Numeric(8, 0)))
INSERT [dbo].[Estudiantes] ([NroLista], [Nombre], [Baja], [Faltas]) VALUES (CAST(10010 AS Numeric(8, 0)), N'lionelazo', 0, CAST(0 AS Numeric(8, 0)))
INSERT [dbo].[Estudiantes] ([NroLista], [Nombre], [Baja], [Faltas]) VALUES (CAST(10011 AS Numeric(8, 0)), N'uygu', 0, CAST(0 AS Numeric(8, 0)))
SET IDENTITY_INSERT [dbo].[Estudiantes] OFF
SET IDENTITY_INSERT [dbo].[Falta] ON 

INSERT [dbo].[Falta] ([ID], [Fecha], [IDEstudiante], [Justificada]) VALUES (CAST(41 AS Numeric(8, 0)), CAST(N'2019-05-04' AS Date), CAST(2 AS Numeric(8, 0)), 0)
INSERT [dbo].[Falta] ([ID], [Fecha], [IDEstudiante], [Justificada]) VALUES (CAST(42 AS Numeric(8, 0)), CAST(N'2019-06-13' AS Date), CAST(2 AS Numeric(8, 0)), 1)
INSERT [dbo].[Falta] ([ID], [Fecha], [IDEstudiante], [Justificada]) VALUES (CAST(43 AS Numeric(8, 0)), CAST(N'2019-06-16' AS Date), CAST(2 AS Numeric(8, 0)), 1)
INSERT [dbo].[Falta] ([ID], [Fecha], [IDEstudiante], [Justificada]) VALUES (CAST(44 AS Numeric(8, 0)), CAST(N'2019-06-19' AS Date), CAST(3 AS Numeric(8, 0)), 0)
INSERT [dbo].[Falta] ([ID], [Fecha], [IDEstudiante], [Justificada]) VALUES (CAST(45 AS Numeric(8, 0)), CAST(N'2019-06-19' AS Date), CAST(3 AS Numeric(8, 0)), 1)
INSERT [dbo].[Falta] ([ID], [Fecha], [IDEstudiante], [Justificada]) VALUES (CAST(46 AS Numeric(8, 0)), CAST(N'2019-06-19' AS Date), CAST(2 AS Numeric(8, 0)), 0)
INSERT [dbo].[Falta] ([ID], [Fecha], [IDEstudiante], [Justificada]) VALUES (CAST(47 AS Numeric(8, 0)), CAST(N'2019-06-19' AS Date), CAST(3 AS Numeric(8, 0)), 0)
INSERT [dbo].[Falta] ([ID], [Fecha], [IDEstudiante], [Justificada]) VALUES (CAST(48 AS Numeric(8, 0)), CAST(N'2019-06-19' AS Date), CAST(3 AS Numeric(8, 0)), 1)
INSERT [dbo].[Falta] ([ID], [Fecha], [IDEstudiante], [Justificada]) VALUES (CAST(49 AS Numeric(8, 0)), CAST(N'2019-06-19' AS Date), CAST(42 AS Numeric(8, 0)), 0)
INSERT [dbo].[Falta] ([ID], [Fecha], [IDEstudiante], [Justificada]) VALUES (CAST(50 AS Numeric(8, 0)), CAST(N'2019-06-19' AS Date), CAST(3 AS Numeric(8, 0)), 0)
INSERT [dbo].[Falta] ([ID], [Fecha], [IDEstudiante], [Justificada]) VALUES (CAST(51 AS Numeric(8, 0)), CAST(N'2019-06-19' AS Date), CAST(2 AS Numeric(8, 0)), 0)
INSERT [dbo].[Falta] ([ID], [Fecha], [IDEstudiante], [Justificada]) VALUES (CAST(52 AS Numeric(8, 0)), CAST(N'2019-06-19' AS Date), CAST(2 AS Numeric(8, 0)), 1)
INSERT [dbo].[Falta] ([ID], [Fecha], [IDEstudiante], [Justificada]) VALUES (CAST(53 AS Numeric(8, 0)), CAST(N'2019-06-19' AS Date), CAST(2 AS Numeric(8, 0)), 0)
INSERT [dbo].[Falta] ([ID], [Fecha], [IDEstudiante], [Justificada]) VALUES (CAST(54 AS Numeric(8, 0)), CAST(N'2019-06-19' AS Date), CAST(2 AS Numeric(8, 0)), 0)
INSERT [dbo].[Falta] ([ID], [Fecha], [IDEstudiante], [Justificada]) VALUES (CAST(55 AS Numeric(8, 0)), CAST(N'2019-06-19' AS Date), CAST(7 AS Numeric(8, 0)), 0)
INSERT [dbo].[Falta] ([ID], [Fecha], [IDEstudiante], [Justificada]) VALUES (CAST(56 AS Numeric(8, 0)), CAST(N'2019-06-19' AS Date), CAST(7 AS Numeric(8, 0)), 1)
INSERT [dbo].[Falta] ([ID], [Fecha], [IDEstudiante], [Justificada]) VALUES (CAST(57 AS Numeric(8, 0)), CAST(N'2019-06-19' AS Date), CAST(7 AS Numeric(8, 0)), 0)
INSERT [dbo].[Falta] ([ID], [Fecha], [IDEstudiante], [Justificada]) VALUES (CAST(58 AS Numeric(8, 0)), CAST(N'2019-06-19' AS Date), CAST(7 AS Numeric(8, 0)), 1)
INSERT [dbo].[Falta] ([ID], [Fecha], [IDEstudiante], [Justificada]) VALUES (CAST(59 AS Numeric(8, 0)), CAST(N'2019-06-19' AS Date), CAST(7 AS Numeric(8, 0)), 1)
INSERT [dbo].[Falta] ([ID], [Fecha], [IDEstudiante], [Justificada]) VALUES (CAST(60 AS Numeric(8, 0)), CAST(N'2019-06-22' AS Date), CAST(2 AS Numeric(8, 0)), 0)
INSERT [dbo].[Falta] ([ID], [Fecha], [IDEstudiante], [Justificada]) VALUES (CAST(61 AS Numeric(8, 0)), CAST(N'2019-06-22' AS Date), CAST(1 AS Numeric(8, 0)), 1)
INSERT [dbo].[Falta] ([ID], [Fecha], [IDEstudiante], [Justificada]) VALUES (CAST(62 AS Numeric(8, 0)), CAST(N'2019-06-22' AS Date), CAST(1 AS Numeric(8, 0)), 1)
SET IDENTITY_INSERT [dbo].[Falta] OFF
ALTER TABLE [dbo].[Estudiantes] ADD  CONSTRAINT [DF_Estudiantes_Baja]  DEFAULT ((0)) FOR [Baja]
GO
ALTER TABLE [dbo].[Estudiantes] ADD  CONSTRAINT [DF_Estudiantes_Faltas]  DEFAULT ((0)) FOR [Faltas]
GO
ALTER TABLE [dbo].[Falta] ADD  CONSTRAINT [DF_Falta_Justificada]  DEFAULT ((0)) FOR [Justificada]
GO
/****** Object:  StoredProcedure [dbo].[PAActualizarFalt]    Script Date: 23/06/2019 1:00:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PAActualizarFalt]
@IDEstudiante numeric(8,0),
@NumFalt int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	--Actualizo las faltas del estudiante calculándolas otra vez e ingresandolas en su campo
	SELECT @NumFalt= COUNT(Falta.ID) from Falta WHERE IDEstudiante=@IDEstudiante;
	UPDATE Estudiantes set Faltas= @NumFalt WHERE NroLista = @IDEstudiante;
END
GO
/****** Object:  StoredProcedure [dbo].[PAAFicta]    Script Date: 23/06/2019 1:00:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PAAFicta]
@IDEst numeric(8,0),
@NumFaltSin numeric(8,0) = null ,
@NumFJustificado numeric(8,0) = null,
@NumResultado numeric(8,0) = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON; 

    -- Insert statements for procedure here  
	--Calculo la ficta en base a resultados de otras consultas 
	SELECT @NumFaltSin = COUNT(Falta.ID) FROM Falta WHERE IDEstudiante = @IDEst AND Justificada= 0;
	SELECT @NumFJustificado = COUNT(Falta.ID) FROM Falta WHERE IDEstudiante = @IDEst AND Justificada= 1; 
	SELECT @NumResultado =  @NumFaltSin + (@NumFJustificado/2);
	SELECT @NumResultado;
END
GO
/****** Object:  StoredProcedure [dbo].[PAAgregarEstudiante]    Script Date: 23/06/2019 1:00:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PAAgregarEstudiante] 
 @Nombre nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Estudiantes (Nombre) values (@Nombre)
END
GO
/****** Object:  StoredProcedure [dbo].[PABajaEstudiante]    Script Date: 23/06/2019 1:00:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PABajaEstudiante]
@ID Numeric(8,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE dbo.Estudiantes SET Baja = 1 where NroLista = @ID;
END
GO
/****** Object:  StoredProcedure [dbo].[PACorroborarEstudiante]    Script Date: 23/06/2019 1:00:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PACorroborarEstudiante]
@Nombre nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT NroLista FROM Estudiantes WHERE Nombre = @Nombre;
END
GO
/****** Object:  StoredProcedure [dbo].[PAEstudianteselect]    Script Date: 23/06/2019 1:00:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PAEstudianteselect]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT NroLista, Nombre, Faltas from Estudiantes WHERE Baja= 0;
END
GO
/****** Object:  StoredProcedure [dbo].[PAFaltaselect]    Script Date: 23/06/2019 1:00:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PAFaltaselect]
@IDEstudiante numeric(8,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	SELECT dbo.Falta.ID, dbo.Falta.Fecha, dbo.Falta.IDEstudiante, dbo.Falta.Justificada from Falta WHERE IDEstudiante=@IDEstudiante;
END
GO
/****** Object:  StoredProcedure [dbo].[PAJustificarFalta]    Script Date: 23/06/2019 1:00:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PAJustificarFalta]
@IdFalt numeric(8,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Falta set Justificada= 1 where ID = @IdFalt;
END
GO
/****** Object:  StoredProcedure [dbo].[PAModificarEstudiante]    Script Date: 23/06/2019 1:00:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PAModificarEstudiante]
@ID numeric(8,0),
@Nombre nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE dbo.Estudiantes SET Nombre = @Nombre WHERE NroLista= @ID;
END
GO
/****** Object:  StoredProcedure [dbo].[PAPonerFalta]    Script Date: 23/06/2019 1:00:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PAPonerFalta]
	@Fecha date,
	@IDEstudiante numeric(8,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Falta (Fecha, IDEstudiante) values (@Fecha, @IDEstudiante);
END
GO
USE [master]
GO
ALTER DATABASE [BDListaProfesor] SET  READ_WRITE 
GO
