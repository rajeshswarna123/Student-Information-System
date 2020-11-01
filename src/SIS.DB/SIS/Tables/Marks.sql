CREATE TABLE [SIS].[Marks](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[SubjectId] [bigint] NOT NULL,
	[StudentId] [bigint] NOT NULL,
	[MaxMarks] [int] NOT NULL,
	[ObtainedMarks] [int] NOT NULL
) ON [PRIMARY]

