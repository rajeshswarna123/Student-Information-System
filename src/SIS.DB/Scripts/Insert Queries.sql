

INSERT [SIS].[ClassCurriculum] ([Id], [ClassId], [SubjectId]) VALUES (1, 2, 1)
GO


INSERT [SIS].[Classes] ([Id], [Name]) VALUES (1, N'1')
GO

INSERT [SIS].[Classes] ([Id], [Name]) VALUES (2, N'2')
GO

INSERT [SIS].[Classes] ([Id], [Name]) VALUES (3, N'3')
GO


INSERT [SIS].[Marks] ([Id], [SubjectId], [StudentId], [MaxMarks], [ObtainedMarks]) VALUES (1, 1, 1, 100, 75)
GO


INSERT [SIS].[Students] ([Id], [Name], [RollNumber], [ClassId]) VALUES (1, N'Rajesh', 1, 2)
GO


INSERT [SIS].[Subjects] ([Id], [Name]) VALUES (1, N'Maths')
GO



INSERT [SIS].[Users] ([Id], [Name], [Email], [Password]) VALUES (1, N'Rajesh', N'rajesh@mailinator.com', N'Qaz@1234')
GO


