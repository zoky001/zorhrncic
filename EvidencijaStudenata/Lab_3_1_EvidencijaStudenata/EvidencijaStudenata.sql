USE [EvidencijaStudenata]
GO
/****** Object:  Table [dbo].[TipAktivnosti] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipAktivnosti](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tip] [varchar](255) NOT NULL,
 CONSTRAINT [PK_TipAktivnosti] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tim] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tim](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OznakaTima] [varchar](255) NOT NULL,
	[NazivProjekta] [varchar](255) NOT NULL,
	[OpisProjekta] [varchar](255) NULL,
	[Napomena] [varchar](255) NULL,
 CONSTRAINT [PK_Tim] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Aktivnost] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Aktivnost](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [varchar](255) NOT NULL,
	[MaxBodovi] [float] NOT NULL,
	[UvjetPotpis] [float] NOT NULL,
	[UvjetOcjena] [float] NOT NULL,
	[Pocetak] [datetime] NULL,
	[Kraj] [datetime] NULL,
	[Opis] [varchar](255) NULL,
	[TipAktivnostiId] [int] NOT NULL,
 CONSTRAINT [PK_Aktivnost] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Student] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [varchar](255) NOT NULL,
	[Prezime] [varchar](255) NOT NULL,
	[Status] [char](1) NULL,
	[OdabraniModel] [char](1) NULL,
	[Email] [varchar](255) NULL,
	[Napomena] [varchar](255) NULL,
	[TimId] [int] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AktivnostStudenta] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AktivnostStudenta](
	[AktivnostId] [int] NOT NULL,
	[StudentId] [int] NOT NULL,
	[Bodovi] [float] NOT NULL,
	[Datum] [datetime] NULL,
 CONSTRAINT [PK_AktivnostStudenta] PRIMARY KEY CLUSTERED 
(
	[AktivnostId] ASC,
	[StudentId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Aktivnost_TipAktivnosti] ******/
ALTER TABLE [dbo].[Aktivnost]  WITH CHECK ADD  CONSTRAINT [FK_Aktivnost_TipAktivnosti] FOREIGN KEY([TipAktivnostiId])
REFERENCES [dbo].[TipAktivnosti] ([Id])
GO
ALTER TABLE [dbo].[Aktivnost] CHECK CONSTRAINT [FK_Aktivnost_TipAktivnosti]
GO
/****** Object:  ForeignKey [FK_AktivnostStudenta_Aktivnost] ******/
ALTER TABLE [dbo].[AktivnostStudenta]  WITH CHECK ADD  CONSTRAINT [FK_AktivnostStudenta_Aktivnost] FOREIGN KEY([AktivnostId])
REFERENCES [dbo].[Aktivnost] ([Id])
GO
ALTER TABLE [dbo].[AktivnostStudenta] CHECK CONSTRAINT [FK_AktivnostStudenta_Aktivnost]
GO
/****** Object:  ForeignKey [FK_AktivnostStudenta_Student] ******/
ALTER TABLE [dbo].[AktivnostStudenta]  WITH CHECK ADD  CONSTRAINT [FK_AktivnostStudenta_Student] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([Id])
GO
ALTER TABLE [dbo].[AktivnostStudenta] CHECK CONSTRAINT [FK_AktivnostStudenta_Student]
GO
/****** Object:  ForeignKey [FK_Student_Tim] ******/
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Tim] FOREIGN KEY([TimId])
REFERENCES [dbo].[Tim] ([Id])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Tim]
GO
