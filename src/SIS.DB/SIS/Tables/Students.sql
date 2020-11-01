CREATE TABLE [SIS].[Students](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[RollNumber] [int] NOT NULL,
	[ClassId] [bigint] NOT NULL
) ON [PRIMARY]

