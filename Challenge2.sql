USE [Challenge]
GO
/****** Object:  Table [dbo].[Encuestas]    Script Date: 6/1/2023 10:55:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Encuestas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Sexo] [char](1) NOT NULL,
	[Periodo] [int] NOT NULL,
	[CantidadPeliculas] [int] NOT NULL,
 CONSTRAINT [PK_Encuestas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Encuestas] ON 
GO
INSERT [dbo].[Encuestas] ([Id], [FechaNacimiento], [Sexo], [Periodo], [CantidadPeliculas]) VALUES (114, CAST(N'1988-12-29' AS Date), N'F', 201505, 1)
GO
INSERT [dbo].[Encuestas] ([Id], [FechaNacimiento], [Sexo], [Periodo], [CantidadPeliculas]) VALUES (115, CAST(N'1989-07-26' AS Date), N'M', 201109, 10)
GO
INSERT [dbo].[Encuestas] ([Id], [FechaNacimiento], [Sexo], [Periodo], [CantidadPeliculas]) VALUES (116, CAST(N'1990-01-03' AS Date), N'M', 201501, 40)
GO
INSERT [dbo].[Encuestas] ([Id], [FechaNacimiento], [Sexo], [Periodo], [CantidadPeliculas]) VALUES (117, CAST(N'1990-03-01' AS Date), N'O', 201109, 10)
GO
INSERT [dbo].[Encuestas] ([Id], [FechaNacimiento], [Sexo], [Periodo], [CantidadPeliculas]) VALUES (118, CAST(N'1990-05-10' AS Date), N'M', 201008, 5)
GO
INSERT [dbo].[Encuestas] ([Id], [FechaNacimiento], [Sexo], [Periodo], [CantidadPeliculas]) VALUES (119, CAST(N'1991-02-08' AS Date), N'M', 202012, 20)
GO
INSERT [dbo].[Encuestas] ([Id], [FechaNacimiento], [Sexo], [Periodo], [CantidadPeliculas]) VALUES (120, CAST(N'1991-02-09' AS Date), N'M', 201008, 3)
GO
INSERT [dbo].[Encuestas] ([Id], [FechaNacimiento], [Sexo], [Periodo], [CantidadPeliculas]) VALUES (121, CAST(N'1991-02-09' AS Date), N'M', 201505, 60)
GO
INSERT [dbo].[Encuestas] ([Id], [FechaNacimiento], [Sexo], [Periodo], [CantidadPeliculas]) VALUES (122, CAST(N'1996-01-05' AS Date), N'F', 201505, 5)
GO
INSERT [dbo].[Encuestas] ([Id], [FechaNacimiento], [Sexo], [Periodo], [CantidadPeliculas]) VALUES (123, CAST(N'1996-11-13' AS Date), N'F', 201008, 2)
GO
INSERT [dbo].[Encuestas] ([Id], [FechaNacimiento], [Sexo], [Periodo], [CantidadPeliculas]) VALUES (124, CAST(N'2001-01-03' AS Date), N'F', 202012, 50)
GO
INSERT [dbo].[Encuestas] ([Id], [FechaNacimiento], [Sexo], [Periodo], [CantidadPeliculas]) VALUES (125, CAST(N'2001-10-10' AS Date), N'M', 201505, 3)
GO
INSERT [dbo].[Encuestas] ([Id], [FechaNacimiento], [Sexo], [Periodo], [CantidadPeliculas]) VALUES (126, CAST(N'2001-12-12' AS Date), N'M', 201109, 3)
GO
INSERT [dbo].[Encuestas] ([Id], [FechaNacimiento], [Sexo], [Periodo], [CantidadPeliculas]) VALUES (127, CAST(N'2002-01-03' AS Date), N'F', 202012, 50)
GO
INSERT [dbo].[Encuestas] ([Id], [FechaNacimiento], [Sexo], [Periodo], [CantidadPeliculas]) VALUES (128, CAST(N'2003-01-03' AS Date), N'F', 202012, 50)
GO
INSERT [dbo].[Encuestas] ([Id], [FechaNacimiento], [Sexo], [Periodo], [CantidadPeliculas]) VALUES (129, CAST(N'2010-07-16' AS Date), N'M', 202012, 30)
GO
INSERT [dbo].[Encuestas] ([Id], [FechaNacimiento], [Sexo], [Periodo], [CantidadPeliculas]) VALUES (130, CAST(N'2010-07-16' AS Date), N'M', 202012, 32)
GO
INSERT [dbo].[Encuestas] ([Id], [FechaNacimiento], [Sexo], [Periodo], [CantidadPeliculas]) VALUES (131, CAST(N'2015-03-14' AS Date), N'M', 201502, 30)
GO
INSERT [dbo].[Encuestas] ([Id], [FechaNacimiento], [Sexo], [Periodo], [CantidadPeliculas]) VALUES (132, CAST(N'2018-03-08' AS Date), N'M', 201007, 0)
GO
INSERT [dbo].[Encuestas] ([Id], [FechaNacimiento], [Sexo], [Periodo], [CantidadPeliculas]) VALUES (133, CAST(N'2020-01-03' AS Date), N'M', 202012, 33)
GO
INSERT [dbo].[Encuestas] ([Id], [FechaNacimiento], [Sexo], [Periodo], [CantidadPeliculas]) VALUES (134, CAST(N'2020-01-03' AS Date), N'M', 202012, 33)
GO
INSERT [dbo].[Encuestas] ([Id], [FechaNacimiento], [Sexo], [Periodo], [CantidadPeliculas]) VALUES (137, CAST(N'2000-06-08' AS Date), N'F', 201303, 30)
GO
INSERT [dbo].[Encuestas] ([Id], [FechaNacimiento], [Sexo], [Periodo], [CantidadPeliculas]) VALUES (138, CAST(N'2000-06-08' AS Date), N'O', 201109, 30)
GO
INSERT [dbo].[Encuestas] ([Id], [FechaNacimiento], [Sexo], [Periodo], [CantidadPeliculas]) VALUES (139, CAST(N'2006-07-27' AS Date), N'F', 202003, 20)
GO
INSERT [dbo].[Encuestas] ([Id], [FechaNacimiento], [Sexo], [Periodo], [CantidadPeliculas]) VALUES (140, CAST(N'2014-07-11' AS Date), N'M', 201302, 30)
GO
INSERT [dbo].[Encuestas] ([Id], [FechaNacimiento], [Sexo], [Periodo], [CantidadPeliculas]) VALUES (141, CAST(N'2000-07-19' AS Date), N'F', 201203, 30)
GO
INSERT [dbo].[Encuestas] ([Id], [FechaNacimiento], [Sexo], [Periodo], [CantidadPeliculas]) VALUES (142, CAST(N'1994-06-16' AS Date), N'F', 201712, 30)
GO
INSERT [dbo].[Encuestas] ([Id], [FechaNacimiento], [Sexo], [Periodo], [CantidadPeliculas]) VALUES (143, CAST(N'2005-07-22' AS Date), N'F', 201204, 50)
GO
SET IDENTITY_INSERT [dbo].[Encuestas] OFF
GO
/****** Object:  StoredProcedure [dbo].[Add_Encuesta]    Script Date: 6/1/2023 10:55:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Add_Encuesta]
@FechaNacimiento date,
@Sexo char(1),
@Periodo int,
@CantidadPeliculas int
as begin
	INSERT INTO Encuestas VALUES (@FechaNacimiento,@Sexo,@Periodo,@CantidadPeliculas);
end
GO
/****** Object:  StoredProcedure [dbo].[Lista_Edades_PromPeliculas]    Script Date: 6/1/2023 10:55:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Lista_Edades_PromPeliculas]
@Edad int
as begin
	select datediff(year,FechaNacimiento,getdate())-
	(case
	/*Como esto solo resta los años y no toma en cuenta los meses,
	se resta un año si agregando la edad obtenida a la fecha de nacimiento
	resulta mayor a la fecha actual*/
		when dateadd(year,datediff(year,FechaNacimiento,GETDATE()),FechaNacimiento) > Getdate() 
			then
			1
			else
			0
		end) as Edad
	, avg(CantidadPeliculas) as Promedio_Peliculas 
	from Encuestas
	Where datediff(year,FechaNacimiento,getdate())-
	(case 
		when dateadd(year,datediff(year,FechaNacimiento,GETDATE()),FechaNacimiento) > Getdate() 
			then
			1
			else
			0
		end) = @Edad
	group by datediff(year,FechaNacimiento,getdate())-
	(case 
		when dateadd(year,datediff(year,FechaNacimiento,GETDATE()),FechaNacimiento) > Getdate() 
			then
			1
			else
			0
		end)
	order by Edad

end
GO
/****** Object:  StoredProcedure [dbo].[Promedio_Historico]    Script Date: 6/1/2023 10:55:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Promedio_Historico]
as begin
	select avg(CantidadPeliculas) as Promedio_Historico from Encuestas
end
GO
/****** Object:  StoredProcedure [dbo].[Promedio_x_Edad]    Script Date: 6/1/2023 10:55:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Promedio_x_Edad]
@Edad int
as begin
	select datediff(year,FechaNacimiento,getdate())-
	(case
	/*Como esto solo resta los años y no toma en cuenta los meses,
	se resta un año si agregando la edad obtenida a la fecha de nacimiento
	resulta mayor a la fecha actual*/
		when dateadd(year,datediff(year,FechaNacimiento,GETDATE()),FechaNacimiento) > Getdate() 
			then
			1
			else
			0
		end) as Edad
	, avg(CantidadPeliculas) as Promedio_Peliculas 
	from Encuestas
	Where datediff(year,FechaNacimiento,getdate())-
	(case 
		when dateadd(year,datediff(year,FechaNacimiento,GETDATE()),FechaNacimiento) > Getdate() 
			then
			1
			else
			0
		end) = @Edad
	group by datediff(year,FechaNacimiento,getdate())-
	(case 
		when dateadd(year,datediff(year,FechaNacimiento,GETDATE()),FechaNacimiento) > Getdate() 
			then
			1
			else
			0
		end)
	order by Edad

end
GO
/****** Object:  StoredProcedure [dbo].[Promedio_x_EdadTot]    Script Date: 6/1/2023 10:55:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Promedio_x_EdadTot]
as begin
	select datediff(year,FechaNacimiento,getdate())-
	(case
	/*Como esto solo resta los años y no toma en cuenta los meses,
	se resta un año si agregando la edad obtenida a la fecha de nacimiento
	resulta mayor a la fecha actual*/
		when dateadd(year,datediff(year,FechaNacimiento,GETDATE()),FechaNacimiento) > Getdate() 
			then
			1
			else
			0
		end) as Edad
	, avg(CantidadPeliculas) as Promedio_Peliculas 
	from Encuestas
	group by datediff(year,FechaNacimiento,getdate())-
	(case 
		when dateadd(year,datediff(year,FechaNacimiento,GETDATE()),FechaNacimiento) > Getdate() 
			then
			1
			else
			0
		end)
	order by Edad asc

end
GO
/****** Object:  StoredProcedure [dbo].[Promedio_x_Periodo]    Script Date: 6/1/2023 10:55:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Promedio_x_Periodo]
@Periodo int
as begin
	select Periodo, avg(CantidadPeliculas) as Peliculas_Vistas_AVG from Encuestas
	where Periodo = @Periodo
	group by Periodo
end
GO
/****** Object:  StoredProcedure [dbo].[Promedio_x_PeriodoTot]    Script Date: 6/1/2023 10:55:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Promedio_x_PeriodoTot]
as begin
	select Periodo, avg(CantidadPeliculas) as Peliculas_Vistas_AVG from Encuestas
	group by Periodo
	order by Periodo asc
end
GO
/****** Object:  StoredProcedure [dbo].[Promedio_x_Sexo]    Script Date: 6/1/2023 10:55:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Promedio_x_Sexo]
@Sexo varchar(10)
as begin
	select Sexo, avg(CantidadPeliculas) as Peliculas_Vistas_AVG from Encuestas
	where Sexo = @Sexo
	group by Sexo
end
GO
/****** Object:  StoredProcedure [dbo].[Promedio_x_Sexo_y_Periodo]    Script Date: 6/1/2023 10:55:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Promedio_x_Sexo_y_Periodo]
@Sexo char(1),
@Periodo int
as begin
	select Sexo, Periodo, avg(CantidadPeliculas) as Promedio_Sx_Per from Encuestas
	where Sexo = @Sexo and Periodo = @Periodo
	group by Sexo, Periodo

end
GO
/****** Object:  StoredProcedure [dbo].[Promedio_x_Sexo_y_Periodo3]    Script Date: 6/1/2023 10:55:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Promedio_x_Sexo_y_Periodo3]
@Sexo char(1)
as begin
	select Sexo, Periodo, avg(CantidadPeliculas) as Promedio_Sx_Per from Encuestas
	where Sexo = @Sexo 
	group by Sexo, Periodo

end
GO
/****** Object:  StoredProcedure [dbo].[Promedio_x_SexoTot]    Script Date: 6/1/2023 10:55:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Promedio_x_SexoTot]
as begin
	select Sexo, avg(CantidadPeliculas) as Peliculas_Vistas_AVG from Encuestas
	group by Sexo
end
GO
/****** Object:  StoredProcedure [dbo].[Show_All]    Script Date: 6/1/2023 10:55:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Show_All]
as begin
	select * from Encuestas
end
GO
