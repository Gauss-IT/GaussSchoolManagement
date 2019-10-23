USE [GaussSchool]
GO
/****** Object:  Table [dbo].[Instruktore]    Script Date: 10/23/2019 17:07:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Instruktore](
	[InstruktorId] [int] IDENTITY(1,1) NOT NULL,
	[PersonId] [int] NULL,
 CONSTRAINT [PK_Instruktori] PRIMARY KEY CLUSTERED 
(
	[InstruktorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 10/23/2019 17:07:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[PersonId] [int] IDENTITY(1,1) NOT NULL,
	[Emri] [varchar](50) NULL,
	[Mbiemri] [varchar](50) NULL,
	[DataLindjes] [date] NULL,
	[EmailAdresa] [varchar](150) NULL,
	[Telefoni] [varchar](50) NULL,
	[Adresa] [nchar](400) NULL,
 CONSTRAINT [PK_Personi] PRIMARY KEY CLUSTERED 
(
	[PersonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[InstruktorDetails]    Script Date: 10/23/2019 17:07:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[InstruktorDetails]
AS
SELECT        dbo.Persona.Emri, dbo.Persona.Mbiemri, dbo.Persona.DataLindjes, dbo.Persona.EmailAdresa, dbo.Persona.Telefoni, dbo.Persona.Adresa
FROM            dbo.Instruktore INNER JOIN
                         dbo.Persona ON dbo.Instruktore.PersonId = dbo.Persona.PersonId
GO
/****** Object:  Table [dbo].[InstruktoreKurse]    Script Date: 10/23/2019 17:07:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InstruktoreKurse](
	[InstruktorKursId] [int] IDENTITY(1,1) NOT NULL,
	[InstruktorId] [int] NULL,
	[KursId] [int] NULL,
 CONSTRAINT [PK_InstruktoreKurse] PRIMARY KEY CLUSTERED 
(
	[InstruktorKursId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kurse]    Script Date: 10/23/2019 17:07:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kurse](
	[KursId] [int] IDENTITY(1,1) NOT NULL,
	[ShifraKursit] [varchar](50) NULL,
	[EmriKursit] [varchar](100) NULL,
	[Pershkrimi] [varchar](400) NULL,
	[Niveli] [varchar](50) NULL,
	[VitiShkollor] [varchar](50) NULL,
 CONSTRAINT [PK_Kurse] PRIMARY KEY CLUSTERED 
(
	[KursId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[InstruktoreKurseDetails]    Script Date: 10/23/2019 17:07:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[InstruktoreKurseDetails]
AS
SELECT        dbo.InstruktoreKurse.InstruktorKursId, dbo.Persona.Emri, dbo.Persona.Mbiemri, dbo.Kurse.ShifraKursit, dbo.Kurse.EmriKursit, dbo.Kurse.Pershkrimi, dbo.Kurse.Niveli, dbo.Kurse.VitiShkollor
FROM            dbo.Instruktore INNER JOIN
                         dbo.InstruktoreKurse ON dbo.Instruktore.InstruktorId = dbo.InstruktoreKurse.InstruktorId INNER JOIN
                         dbo.Kurse ON dbo.InstruktoreKurse.KursId = dbo.Kurse.KursId INNER JOIN
                         dbo.Persona ON dbo.Instruktore.PersonId = dbo.Persona.PersonId
GO
/****** Object:  Table [dbo].[Nxenes]    Script Date: 10/23/2019 17:07:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nxenes](
	[NxenesId] [int] IDENTITY(1,1) NOT NULL,
	[ShkollaId] [int] NULL,
	[Klasa] [varchar](50) NULL,
	[PrindId] [int] NULL,
	[PersonId] [int] NULL,
 CONSTRAINT [PK_Nxenesi] PRIMARY KEY CLUSTERED 
(
	[NxenesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shkolla]    Script Date: 10/23/2019 17:07:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shkolla](
	[ShkollaId] [int] IDENTITY(1,1) NOT NULL,
	[ShkollaEmri] [varchar](50) NULL,
	[ShkollaTipi] [varchar](50) NULL,
 CONSTRAINT [PK_Shkolla] PRIMARY KEY CLUSTERED 
(
	[ShkollaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prinder]    Script Date: 10/23/2019 17:07:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prinder](
	[PrindId] [int] IDENTITY(1,1) NOT NULL,
	[PersonId] [int] NULL,
 CONSTRAINT [PK_Prindi] PRIMARY KEY CLUSTERED 
(
	[PrindId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[NxenesDetails]    Script Date: 10/23/2019 17:07:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[NxenesDetails]
AS
SELECT        dbo.Nxenes.NxenesId, dbo.Persona.Emri, dbo.Persona.Mbiemri, dbo.Persona.DataLindjes, dbo.Persona.EmailAdresa, dbo.Persona.Telefoni, dbo.Persona.Adresa, dbo.Shkolla.ShkollaEmri, dbo.Shkolla.ShkollaTipi, 
                         dbo.Nxenes.Klasa
FROM            dbo.Nxenes INNER JOIN
                         dbo.Persona ON dbo.Nxenes.PersonId = dbo.Persona.PersonId INNER JOIN
                         dbo.Prinder ON dbo.Nxenes.PrindId = dbo.Prinder.PrindId INNER JOIN
                         dbo.Shkolla ON dbo.Nxenes.ShkollaId = dbo.Shkolla.ShkollaId
GO
/****** Object:  View [dbo].[PrindDetails]    Script Date: 10/23/2019 17:07:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[PrindDetails]
AS
SELECT        dbo.Prinder.PrindId, dbo.Persona.Emri, dbo.Persona.Mbiemri, dbo.Persona.DataLindjes, dbo.Persona.EmailAdresa, dbo.Persona.Telefoni, dbo.Persona.Adresa
FROM            dbo.Persona INNER JOIN
                         dbo.Prinder ON dbo.Persona.PersonId = dbo.Prinder.PersonId
GO
/****** Object:  Table [dbo].[NxenesKurse]    Script Date: 10/23/2019 17:07:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NxenesKurse](
	[NxenesKursId] [int] IDENTITY(1,1) NOT NULL,
	[KursId] [int] NULL,
	[NxenesId] [int] NULL,
 CONSTRAINT [PK_KurseNxenes] PRIMARY KEY CLUSTERED 
(
	[NxenesKursId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[NxenesKurseDetails]    Script Date: 10/23/2019 17:07:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[NxenesKurseDetails]
AS
SELECT        dbo.NxenesDetails.NxenesId, dbo.NxenesDetails.Emri, dbo.NxenesDetails.Mbiemri, dbo.Kurse.ShifraKursit, dbo.Kurse.EmriKursit, dbo.Kurse.Niveli, dbo.Kurse.VitiShkollor, dbo.NxenesDetails.Klasa
FROM            dbo.NxenesKurse INNER JOIN
                         dbo.Kurse ON dbo.NxenesKurse.KursId = dbo.Kurse.KursId INNER JOIN
                         dbo.NxenesDetails ON dbo.NxenesKurse.NxenesId = dbo.NxenesDetails.NxenesId
GO
/****** Object:  View [dbo].[SherbimiDetails]    Script Date: 10/23/2019 17:07:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[SherbimiDetails]
AS
SELECT        dbo.Sherbimet.SherbimiId, dbo.Kurse.ShifraKursit, dbo.Kurse.EmriKursit, dbo.Kurse.VitiShkollor, dbo.Sherbimet.Cmimi, dbo.Sherbimet.Pershkrimi
FROM            dbo.Kurse INNER JOIN
                         dbo.Sherbimet ON dbo.Kurse.KursId = dbo.Sherbimet.KursId
GO
/****** Object:  Table [dbo].[Pagesa]    Script Date: 10/23/2019 17:07:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pagesa](
	[PageseId] [int] IDENTITY(1,1) NOT NULL,
	[FormaPageses] [varchar](50) NULL,
	[PershkrimiPageses] [varchar](50) NULL,
	[Data] [date] NULL,
	[ShumaPaguar] [decimal](18, 0) NULL,
	[Zbritje] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Pagesat] PRIMARY KEY CLUSTERED 
(
	[PageseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[PagesaDetails]    Script Date: 10/23/2019 17:07:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[PagesaDetails]
AS
SELECT        dbo.Kurse.ShifraKursit, dbo.Kurse.EmriKursit, dbo.Kurse.VitiShkollor, dbo.Sherbimet.Pershkrimi, dbo.Pagesa.Data, dbo.Pagesa.SasiaSherbimeve, dbo.Sherbimet.Cmimi, dbo.Pagesa.Zbritje, dbo.Pagesa.ShumaPaguar
FROM            dbo.Pagesa INNER JOIN
                         dbo.Sherbimet ON dbo.Pagesa.SherbimiId = dbo.Sherbimet.SherbimiId INNER JOIN
                         dbo.Kurse ON dbo.Sherbimet.KursId = dbo.Kurse.KursId
GO
/****** Object:  Table [dbo].[InstruktorePagesa]    Script Date: 10/23/2019 17:07:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InstruktorePagesa](
	[InstruktorPagesaId] [int] IDENTITY(1,1) NOT NULL,
	[InstruktorId] [int] NULL,
	[PageseId] [int] NULL,
 CONSTRAINT [PK_InstruktorePagesa] PRIMARY KEY CLUSTERED 
(
	[InstruktorPagesaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NxenesPagesa]    Script Date: 10/23/2019 17:07:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NxenesPagesa](
	[NxenesPageseId] [int] IDENTITY(1,1) NOT NULL,
	[NxenesId] [int] NULL,
	[PageseId] [int] NULL,
 CONSTRAINT [PK_NxenesPagesa] PRIMARY KEY CLUSTERED 
(
	[NxenesPageseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Instruktore]  WITH CHECK ADD  CONSTRAINT [FK_Instruktori_Personi] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Persona] ([PersonId])
GO
ALTER TABLE [dbo].[Instruktore] CHECK CONSTRAINT [FK_Instruktori_Personi]
GO
ALTER TABLE [dbo].[InstruktoreKurse]  WITH CHECK ADD  CONSTRAINT [FK_InstruktoreKurse_Instruktore] FOREIGN KEY([InstruktorId])
REFERENCES [dbo].[Instruktore] ([InstruktorId])
GO
ALTER TABLE [dbo].[InstruktoreKurse] CHECK CONSTRAINT [FK_InstruktoreKurse_Instruktore]
GO
ALTER TABLE [dbo].[InstruktoreKurse]  WITH CHECK ADD  CONSTRAINT [FK_InstruktoreKurse_Kurse] FOREIGN KEY([KursId])
REFERENCES [dbo].[Kurse] ([KursId])
GO
ALTER TABLE [dbo].[InstruktoreKurse] CHECK CONSTRAINT [FK_InstruktoreKurse_Kurse]
GO
ALTER TABLE [dbo].[InstruktorePagesa]  WITH CHECK ADD  CONSTRAINT [FK_InstruktorePagesa_Instruktore1] FOREIGN KEY([InstruktorId])
REFERENCES [dbo].[Instruktore] ([InstruktorId])
GO
ALTER TABLE [dbo].[InstruktorePagesa] CHECK CONSTRAINT [FK_InstruktorePagesa_Instruktore1]
GO
ALTER TABLE [dbo].[InstruktorePagesa]  WITH CHECK ADD  CONSTRAINT [FK_InstruktorePagesa_Pagesa] FOREIGN KEY([PageseId])
REFERENCES [dbo].[Pagesa] ([PageseId])
GO
ALTER TABLE [dbo].[InstruktorePagesa] CHECK CONSTRAINT [FK_InstruktorePagesa_Pagesa]
GO
ALTER TABLE [dbo].[Nxenes]  WITH CHECK ADD  CONSTRAINT [FK_Nxenesi_Personi] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Persona] ([PersonId])
GO
ALTER TABLE [dbo].[Nxenes] CHECK CONSTRAINT [FK_Nxenesi_Personi]
GO
ALTER TABLE [dbo].[Nxenes]  WITH CHECK ADD  CONSTRAINT [FK_Nxenesi_Prindi] FOREIGN KEY([PrindId])
REFERENCES [dbo].[Prinder] ([PrindId])
GO
ALTER TABLE [dbo].[Nxenes] CHECK CONSTRAINT [FK_Nxenesi_Prindi]
GO
ALTER TABLE [dbo].[Nxenes]  WITH CHECK ADD  CONSTRAINT [FK_Nxenesi_Shkolla] FOREIGN KEY([ShkollaId])
REFERENCES [dbo].[Shkolla] ([ShkollaId])
GO
ALTER TABLE [dbo].[Nxenes] CHECK CONSTRAINT [FK_Nxenesi_Shkolla]
GO
ALTER TABLE [dbo].[NxenesKurse]  WITH CHECK ADD  CONSTRAINT [FK_KurseNxenes_Kurse] FOREIGN KEY([KursId])
REFERENCES [dbo].[Kurse] ([KursId])
GO
ALTER TABLE [dbo].[NxenesKurse] CHECK CONSTRAINT [FK_KurseNxenes_Kurse]
GO
ALTER TABLE [dbo].[NxenesKurse]  WITH CHECK ADD  CONSTRAINT [FK_KurseNxenes_Nxenesi] FOREIGN KEY([NxenesId])
REFERENCES [dbo].[Nxenes] ([NxenesId])
GO
ALTER TABLE [dbo].[NxenesKurse] CHECK CONSTRAINT [FK_KurseNxenes_Nxenesi]
GO
ALTER TABLE [dbo].[NxenesPagesa]  WITH CHECK ADD  CONSTRAINT [FK_NxenesPagesa_Nxenes] FOREIGN KEY([NxenesId])
REFERENCES [dbo].[Nxenes] ([NxenesId])
GO
ALTER TABLE [dbo].[NxenesPagesa] CHECK CONSTRAINT [FK_NxenesPagesa_Nxenes]
GO
ALTER TABLE [dbo].[NxenesPagesa]  WITH CHECK ADD  CONSTRAINT [FK_NxenesPagesa_Pagesa] FOREIGN KEY([PageseId])
REFERENCES [dbo].[Pagesa] ([PageseId])
GO
ALTER TABLE [dbo].[NxenesPagesa] CHECK CONSTRAINT [FK_NxenesPagesa_Pagesa]
GO
ALTER TABLE [dbo].[Prinder]  WITH CHECK ADD  CONSTRAINT [FK_Prindi_Personi] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Persona] ([PersonId])
GO
ALTER TABLE [dbo].[Prinder] CHECK CONSTRAINT [FK_Prindi_Personi]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[38] 4[29] 2[20] 3) )"
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
         Begin Table = "Instruktore"
            Begin Extent = 
               Top = 28
               Left = 41
               Bottom = 124
               Right = 211
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Persona"
            Begin Extent = 
               Top = 17
               Left = 332
               Bottom = 181
               Right = 502
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'InstruktorDetails'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'InstruktorDetails'
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
         Begin Table = "Instruktore"
            Begin Extent = 
               Top = 17
               Left = 243
               Bottom = 135
               Right = 413
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "InstruktoreKurse"
            Begin Extent = 
               Top = 37
               Left = 477
               Bottom = 150
               Right = 650
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Kurse"
            Begin Extent = 
               Top = 45
               Left = 709
               Bottom = 180
               Right = 879
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "Persona"
            Begin Extent = 
               Top = 62
               Left = 6
               Bottom = 192
               Right = 176
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
         Column = 1935
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'InstruktoreKurseDetails'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'InstruktoreKurseDetails'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[56] 4[5] 2[25] 3) )"
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
         Begin Table = "Nxenes"
            Begin Extent = 
               Top = 37
               Left = 244
               Bottom = 167
               Right = 414
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Prinder"
            Begin Extent = 
               Top = 20
               Left = 561
               Bottom = 131
               Right = 732
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Persona"
            Begin Extent = 
               Top = 156
               Left = 524
               Bottom = 286
               Right = 694
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Shkolla"
            Begin Extent = 
               Top = 62
               Left = 0
               Bottom = 197
               Right = 178
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'NxenesDetails'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'NxenesDetails'
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
         Begin Table = "NxenesDetails"
            Begin Extent = 
               Top = 11
               Left = 639
               Bottom = 194
               Right = 809
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "Kurse"
            Begin Extent = 
               Top = 22
               Left = 133
               Bottom = 152
               Right = 303
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "NxenesKurse"
            Begin Extent = 
               Top = 12
               Left = 371
               Bottom = 125
               Right = 541
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'NxenesKurseDetails'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'NxenesKurseDetails'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[42] 4[21] 2[21] 3) )"
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
         Begin Table = "Kurse"
            Begin Extent = 
               Top = 26
               Left = 502
               Bottom = 156
               Right = 672
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "Sherbimet"
            Begin Extent = 
               Top = 20
               Left = 266
               Bottom = 150
               Right = 436
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Pagesa"
            Begin Extent = 
               Top = 46
               Left = 33
               Bottom = 176
               Right = 210
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'PagesaDetails'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'PagesaDetails'
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
         Begin Table = "Persona"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "Prinder"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 102
               Right = 416
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'PrindDetails'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'PrindDetails'
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
         Begin Table = "Kurse"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Sherbimet"
            Begin Extent = 
               Top = 3
               Left = 336
               Bottom = 133
               Right = 506
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'SherbimiDetails'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'SherbimiDetails'
GO
