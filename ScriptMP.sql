USE [ProjectA]
GO
/****** Object:  Table [dbo].[Advisor]    Script Date: 5/2/2019 10:47:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Advisor](
	[Id] [int] NOT NULL,
	[Designation] [int] NOT NULL,
	[Salary] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Evaluation]    Script Date: 5/2/2019 10:47:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evaluation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[TotalMarks] [int] NOT NULL,
	[TotalWeightage] [int] NOT NULL,
 CONSTRAINT [PK_Evaluation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Group]    Script Date: 5/2/2019 10:47:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Created_On] [date] NOT NULL,
 CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GroupEvaluation]    Script Date: 5/2/2019 10:47:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupEvaluation](
	[GroupId] [int] NOT NULL,
	[EvaluationId] [int] NOT NULL,
	[ObtainedMarks] [int] NOT NULL,
	[EvaluationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_GroupEvaluation] PRIMARY KEY CLUSTERED 
(
	[GroupId] ASC,
	[EvaluationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GroupProject]    Script Date: 5/2/2019 10:47:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupProject](
	[ProjectId] [int] NOT NULL,
	[GroupId] [int] NOT NULL,
	[AssignmentDate] [datetime] NOT NULL,
 CONSTRAINT [PK_GroupProject] PRIMARY KEY CLUSTERED 
(
	[ProjectId] ASC,
	[GroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GroupStudent]    Script Date: 5/2/2019 10:47:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupStudent](
	[GroupId] [int] NOT NULL,
	[StudentId] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[AssignmentDate] [datetime] NOT NULL,
 CONSTRAINT [PK_GroupStudent] PRIMARY KEY CLUSTERED 
(
	[GroupId] ASC,
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lookup]    Script Date: 5/2/2019 10:47:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lookup](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Value] [varchar](100) NOT NULL,
	[Category] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Lookup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 5/2/2019 10:47:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](100) NOT NULL,
	[LastName] [varchar](100) NULL,
	[Contact] [varchar](20) NULL,
	[Email] [varchar](30) NOT NULL,
	[DateOfBirth] [datetime] NULL,
	[Gender] [int] NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Project]    Script Date: 5/2/2019 10:47:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Project](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](max) NULL,
	[Title] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectAdvisor]    Script Date: 5/2/2019 10:47:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectAdvisor](
	[AdvisorId] [int] NOT NULL,
	[ProjectId] [int] NOT NULL,
	[AdvisorRole] [int] NOT NULL,
	[AssignmentDate] [datetime] NOT NULL,
 CONSTRAINT [PK_ProjectAdvisor] PRIMARY KEY CLUSTERED 
(
	[AdvisorId] ASC,
	[ProjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 5/2/2019 10:47:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [int] NOT NULL,
	[RegistrationNo] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Advisor] ([Id], [Designation], [Salary]) VALUES (1, 6, CAST(300000 AS Decimal(18, 0)))
INSERT [dbo].[Advisor] ([Id], [Designation], [Salary]) VALUES (5, 7, CAST(250000 AS Decimal(18, 0)))
INSERT [dbo].[Advisor] ([Id], [Designation], [Salary]) VALUES (6, 9, CAST(100000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[Evaluation] ON 

INSERT [dbo].[Evaluation] ([Id], [Name], [TotalMarks], [TotalWeightage]) VALUES (2, N'Motor', 30, 80)
SET IDENTITY_INSERT [dbo].[Evaluation] OFF
SET IDENTITY_INSERT [dbo].[Group] ON 

INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (1, CAST(N'2019-05-12' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (2, CAST(N'2019-05-14' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (3, CAST(N'2019-05-13' AS Date))
SET IDENTITY_INSERT [dbo].[Group] OFF
INSERT [dbo].[GroupProject] ([ProjectId], [GroupId], [AssignmentDate]) VALUES (1, 1, CAST(N'2019-05-09T00:00:00.000' AS DateTime))
INSERT [dbo].[GroupProject] ([ProjectId], [GroupId], [AssignmentDate]) VALUES (2, 2, CAST(N'2019-05-09T00:00:00.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (1, 2, 3, CAST(N'2019-05-12T00:00:00.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (1, 3, 3, CAST(N'2019-05-12T00:00:00.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (1, 4, 3, CAST(N'2019-05-12T00:00:00.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (2, 7, 3, CAST(N'2019-05-09T00:00:00.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (2, 11, 3, CAST(N'2019-05-09T00:00:00.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (2, 12, 3, CAST(N'2019-05-09T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Lookup] ON 

INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (1, N'Male', N'GENDER')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (2, N'Female', N'GENDER')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (3, N'Active', N'STATUS')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (4, N'InActive', N'STATUS')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (6, N'Professor', N'DESIGNATION')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (7, N'Associate Professor', N'DESIGNATION')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (8, N'Assisstant Professor', N'DESIGNATION')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (9, N'Lecturer', N'DESIGNATION')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (10, N'Industry Professional', N'DESIGNATION')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (11, N'Main Advisor', N'ADVISOR_ROLE')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (12, N'Co-Advisror', N'ADVISOR_ROLE')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (14, N'Industry Advisor', N'ADVISOR_ROLE')
SET IDENTITY_INSERT [dbo].[Lookup] OFF
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (1, N'Ahmad', N'Ali', N'03224567876', N'themaverik@gmail.com', CAST(N'1990-08-12T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (2, N'Bilal', N'Ahmad', N'03225676543', N'bilal@gmail.com', CAST(N'1994-01-08T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (3, N'Maha', N'Abbas', N'03345465432', N'maha@gmail.com', CAST(N'1998-11-05T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (4, N'Anum', N'Tariq', N'04435676543', N'anum@gmail.com', CAST(N'1990-12-05T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (5, N'Sarah', N'Ajmal', N'03224354432', N'sarah@gmail.com', CAST(N'1990-12-02T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (6, N'Umar', N'Islam', N'03324565432', N'umar@gmail.com', CAST(N'1994-12-09T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (7, N'Abid', N'Ali', N'03345645342', N'abid@gmail.com', CAST(N'1990-12-02T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (11, N'Ayesha', N'Ali', N'03334576543', N'ayesha@gmail.com', CAST(N'1998-12-02T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (12, N'Komal', N'Aziz', N'03338765222', N'komal@gmail.com', CAST(N'1997-12-02T00:00:00.000' AS DateTime), 2)
SET IDENTITY_INSERT [dbo].[Person] OFF
SET IDENTITY_INSERT [dbo].[Project] ON 

INSERT [dbo].[Project] ([Id], [Description], [Title]) VALUES (1, N'Gdnfnddnnvcvn,nv', N'Motor')
INSERT [dbo].[Project] ([Id], [Description], [Title]) VALUES (2, N'ndknv vdffgkdfv', N'Sleeping aid')
INSERT [dbo].[Project] ([Id], [Description], [Title]) VALUES (3, N' vdnfdfn,ndf,fn,fd', N'Smart Wheelchair')
SET IDENTITY_INSERT [dbo].[Project] OFF
INSERT [dbo].[ProjectAdvisor] ([AdvisorId], [ProjectId], [AdvisorRole], [AssignmentDate]) VALUES (1, 1, 11, CAST(N'2019-05-09T00:00:00.000' AS DateTime))
INSERT [dbo].[ProjectAdvisor] ([AdvisorId], [ProjectId], [AdvisorRole], [AssignmentDate]) VALUES (1, 2, 12, CAST(N'2019-05-09T00:00:00.000' AS DateTime))
INSERT [dbo].[ProjectAdvisor] ([AdvisorId], [ProjectId], [AdvisorRole], [AssignmentDate]) VALUES (1, 3, 14, CAST(N'2019-05-09T00:00:00.000' AS DateTime))
INSERT [dbo].[ProjectAdvisor] ([AdvisorId], [ProjectId], [AdvisorRole], [AssignmentDate]) VALUES (5, 1, 12, CAST(N'2019-05-09T00:00:00.000' AS DateTime))
INSERT [dbo].[ProjectAdvisor] ([AdvisorId], [ProjectId], [AdvisorRole], [AssignmentDate]) VALUES (5, 2, 14, CAST(N'2019-05-09T00:00:00.000' AS DateTime))
INSERT [dbo].[ProjectAdvisor] ([AdvisorId], [ProjectId], [AdvisorRole], [AssignmentDate]) VALUES (6, 1, 12, CAST(N'2019-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[ProjectAdvisor] ([AdvisorId], [ProjectId], [AdvisorRole], [AssignmentDate]) VALUES (6, 3, 11, CAST(N'2019-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (2, N'2016-CE-83')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (3, N'2016-CE-84')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (4, N'2016-CE-88')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (7, N'2016-CE-89')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (11, N'2016-CE-90')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (12, N'2016-CE-80')
ALTER TABLE [dbo].[Advisor]  WITH CHECK ADD  CONSTRAINT [FK_Advisor_Lookup] FOREIGN KEY([Designation])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[Advisor] CHECK CONSTRAINT [FK_Advisor_Lookup]
GO
ALTER TABLE [dbo].[GroupEvaluation]  WITH CHECK ADD  CONSTRAINT [FK_GroupEvaluation_Evaluation] FOREIGN KEY([EvaluationId])
REFERENCES [dbo].[Evaluation] ([Id])
GO
ALTER TABLE [dbo].[GroupEvaluation] CHECK CONSTRAINT [FK_GroupEvaluation_Evaluation]
GO
ALTER TABLE [dbo].[GroupEvaluation]  WITH CHECK ADD  CONSTRAINT [FK_GroupEvaluation_Group] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Group] ([Id])
GO
ALTER TABLE [dbo].[GroupEvaluation] CHECK CONSTRAINT [FK_GroupEvaluation_Group]
GO
ALTER TABLE [dbo].[GroupProject]  WITH CHECK ADD  CONSTRAINT [FK_GroupProject_Group] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Group] ([Id])
GO
ALTER TABLE [dbo].[GroupProject] CHECK CONSTRAINT [FK_GroupProject_Group]
GO
ALTER TABLE [dbo].[GroupProject]  WITH CHECK ADD  CONSTRAINT [FK_GroupProject_Project] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([Id])
GO
ALTER TABLE [dbo].[GroupProject] CHECK CONSTRAINT [FK_GroupProject_Project]
GO
ALTER TABLE [dbo].[GroupStudent]  WITH CHECK ADD  CONSTRAINT [FK_GroupStudents_Lookup] FOREIGN KEY([Status])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[GroupStudent] CHECK CONSTRAINT [FK_GroupStudents_Lookup]
GO
ALTER TABLE [dbo].[GroupStudent]  WITH CHECK ADD  CONSTRAINT [FK_ProjectStudents_Group] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Group] ([Id])
GO
ALTER TABLE [dbo].[GroupStudent] CHECK CONSTRAINT [FK_ProjectStudents_Group]
GO
ALTER TABLE [dbo].[GroupStudent]  WITH CHECK ADD  CONSTRAINT [FK_ProjectStudents_Student] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([Id])
GO
ALTER TABLE [dbo].[GroupStudent] CHECK CONSTRAINT [FK_ProjectStudents_Student]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_Lookup] FOREIGN KEY([Gender])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_Lookup]
GO
ALTER TABLE [dbo].[ProjectAdvisor]  WITH CHECK ADD  CONSTRAINT [FK_ProjectAdvisor_Lookup] FOREIGN KEY([AdvisorRole])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[ProjectAdvisor] CHECK CONSTRAINT [FK_ProjectAdvisor_Lookup]
GO
ALTER TABLE [dbo].[ProjectAdvisor]  WITH CHECK ADD  CONSTRAINT [FK_ProjectAdvisor_Project] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([Id])
GO
ALTER TABLE [dbo].[ProjectAdvisor] CHECK CONSTRAINT [FK_ProjectAdvisor_Project]
GO
ALTER TABLE [dbo].[ProjectAdvisor]  WITH CHECK ADD  CONSTRAINT [FK_ProjectTeachers_Teacher] FOREIGN KEY([AdvisorId])
REFERENCES [dbo].[Advisor] ([Id])
GO
ALTER TABLE [dbo].[ProjectAdvisor] CHECK CONSTRAINT [FK_ProjectTeachers_Teacher]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Person] FOREIGN KEY([Id])
REFERENCES [dbo].[Person] ([Id])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Person]
GO
