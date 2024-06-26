USE [master]
GO
/****** Object:  Database [firstDB]    Script Date: 26/5/2024 6:47:17 PM ******/
CREATE DATABASE [firstDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'firstDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\firstDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'firstDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\firstDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [firstDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [firstDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [firstDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [firstDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [firstDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [firstDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [firstDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [firstDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [firstDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [firstDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [firstDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [firstDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [firstDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [firstDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [firstDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [firstDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [firstDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [firstDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [firstDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [firstDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [firstDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [firstDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [firstDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [firstDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [firstDB] SET RECOVERY FULL 
GO
ALTER DATABASE [firstDB] SET  MULTI_USER 
GO
ALTER DATABASE [firstDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [firstDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [firstDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [firstDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [firstDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [firstDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'firstDB', N'ON'
GO
ALTER DATABASE [firstDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [firstDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [firstDB]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 26/5/2024 6:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[CourseID] [varchar](20) NOT NULL,
	[Name] [varchar](50) NULL,
	[StudyYear] [int] NULL,
	[TeacherID] [varchar](20) NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grade]    Script Date: 26/5/2024 6:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grade](
	[StudentID] [varchar](20) NOT NULL,
	[CourseID] [varchar](20) NOT NULL,
	[Points] [float] NULL,
	[Grading] [nchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[CourseID] ASC,
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 26/5/2024 6:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentID] [varchar](20) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[DateOfBirth] [date] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 26/5/2024 6:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[TeacherID] [varchar](20) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Address] [varchar](50) NULL,
 CONSTRAINT [PK_MSGV] PRIMARY KEY CLUSTERED 
(
	[TeacherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Course]  WITH CHECK ADD  CONSTRAINT [FK_Course_Teacher] FOREIGN KEY([TeacherID])
REFERENCES [dbo].[Teacher] ([TeacherID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Course] CHECK CONSTRAINT [FK_Course_Teacher]
GO
ALTER TABLE [dbo].[Grade]  WITH CHECK ADD  CONSTRAINT [fk_Grade_Course] FOREIGN KEY([CourseID])
REFERENCES [dbo].[Course] ([CourseID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Grade] CHECK CONSTRAINT [fk_Grade_Course]
GO
ALTER TABLE [dbo].[Grade]  WITH CHECK ADD  CONSTRAINT [fk_Grade_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([StudentID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Grade] CHECK CONSTRAINT [fk_Grade_Student]
GO
/****** Object:  StoredProcedure [dbo].[pr_deleteCourse]    Script Date: 26/5/2024 6:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_deleteCourse]
@CourseID varchar(20)
AS
delete from Course 
where CourseID = @CourseID
GO
/****** Object:  StoredProcedure [dbo].[pr_deleteGrade]    Script Date: 26/5/2024 6:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[pr_deleteGrade]
@StudentID varchar(20),
@CourseID varchar(20)
AS 
delete from Grade 
where @StudentID = StudentID and @CourseID = CourseID
GO
/****** Object:  StoredProcedure [dbo].[pr_deleteStudent]    Script Date: 26/5/2024 6:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pr_deleteStudent]
@StudentID varchar(20)
AS 
delete FROM Student
where StudentID = @StudentID 
GO
/****** Object:  StoredProcedure [dbo].[pr_deleteTeacher]    Script Date: 26/5/2024 6:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[pr_deleteTeacher]
@TeacherID varchar(20)
AS 
delete FROM Teacher
where TeacherID = @TeacherID
GO
/****** Object:  StoredProcedure [dbo].[pr_getAllCourse]    Script Date: 26/5/2024 6:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_getAllCourse]
AS
select 
c.CourseID as [Course ID], 
c.Name as [Course Name], 
c.StudyYear as [Year], 
t.Name as [Teacher Name]
from Course c
inner join Teacher t on c.TeacherID = t.TeacherID
GO
/****** Object:  StoredProcedure [dbo].[pr_getAllGrade]    Script Date: 26/5/2024 6:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_getAllGrade]
AS
SELECT
	g.StudentID AS [Student ID],
	g.CourseID AS [Course ID],
    s.Name AS [Student Name],
    c.Name AS [Course Name],
    g.Points,
    g.Grading,
    t.Name AS [Teacher Name]
FROM
    Grade g
INNER JOIN Student s ON g.StudentID = s.StudentID
INNER JOIN Course c ON g.CourseID = c.CourseID
INNER JOIN Teacher t ON c.TeacherID = t.TeacherID;
GO
/****** Object:  StoredProcedure [dbo].[pr_getAllStudent]    Script Date: 26/5/2024 6:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[pr_getAllStudent]
AS 
SELECT * FROM Student
GO
/****** Object:  StoredProcedure [dbo].[pr_getAllTeacher]    Script Date: 26/5/2024 6:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[pr_getAllTeacher]
AS
select 
*
from Teacher
GO
/****** Object:  StoredProcedure [dbo].[pr_getAverageScore]    Script Date: 26/5/2024 6:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pr_getAverageScore]
AS 
select sd.*, 
case  
	when g.studentID is null then 0
	else count(g.studentID)
end as CourseRegistered,
case  
	when g.studentID is null then 0
	else AVG(g.Points)
end as AverageScore
from Student sd
full outer join Grade g on sd.StudentID = g.StudentID
group by sd.StudentID, sd.Name, sd.Address, sd.DateOfBirth, g.StudentID
order by sd.StudentID
GO
/****** Object:  StoredProcedure [dbo].[pr_getTeacherTotalCourse]    Script Date: 26/5/2024 6:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pr_getTeacherTotalCourse]
AS 
select t.TeacherID, t.Name, t.Address, 
Case 
	when c.TeacherID is null then 0 
	else count(t.TeacherID) 
end as TotalCourseTeaching from Course c
full outer join Teacher t on c.TeacherID = t.TeacherID
group by t.TeacherID, c.TeacherID, t.Name, t.Address
order by t.TeacherID


GO
/****** Object:  StoredProcedure [dbo].[pr_getTotalStudentInCourse]    Script Date: 26/5/2024 6:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pr_getTotalStudentInCourse]
AS 
select c.CourseID, c.Name, c.StudyYear, count(g.CourseID) TotalStudent from Course c
full outer join Grade g on c.CourseID = g.CourseID
group by c.CourseID, c.Name, c.StudyYear
GO
/****** Object:  StoredProcedure [dbo].[pr_insertCourse]    Script Date: 26/5/2024 6:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[pr_insertCourse]
@CourseID varchar(20),
@CourseName varchar(50),
@StudyYear int,
@TeacherID varchar(20)
AS
insert into Course values 
(@CourseID, @CourseName, @StudyYear, @TeacherID)
GO
/****** Object:  StoredProcedure [dbo].[pr_insertGrade]    Script Date: 26/5/2024 6:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[pr_insertGrade]
@StudentID varchar(20),
@CourseID varchar(20),
@Points float,
@Grading nchar(1)
AS 
insert into Grade values 
(@StudentID, @CourseID, @Points, @Grading)
GO
/****** Object:  StoredProcedure [dbo].[pr_insertStudent]    Script Date: 26/5/2024 6:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[pr_insertStudent]
@StudentID varchar(20),
@Name nvarchar(50),
@Address nvarchar(50),
@DateOfBirth date
AS 
insert into Student values 
(@StudentID, @Name, @Address, @DateOfBirth)
GO
/****** Object:  StoredProcedure [dbo].[pr_insertTeacher]    Script Date: 26/5/2024 6:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[pr_insertTeacher]
@TeacherID varchar(20),
@Name nvarchar(50),
@Address nvarchar(50)
AS 
insert into Teacher values 
(@TeacherID, @Name, @Address)
GO
/****** Object:  StoredProcedure [dbo].[pr_updateCourse]    Script Date: 26/5/2024 6:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

DROP PROC IF EXISTS [dbo].[pr_updateGrade]
GO
CREATE PROCEDURE [dbo].[pr_updateGrade]
    @StudentID VARCHAR(20),
    @CourseID VARCHAR(20),
    @Points FLOAT,
    @Grading NCHAR(1)
AS 
    BEGIN
        UPDATE Grade 
        SET 
			Points = @Points,
            Grading = @Grading
        WHERE StudentID = @StudentID
          AND CourseID = @CourseID;
END
GO
/****** Object:  StoredProcedure [dbo].[pr_updateStudent]    Script Date: 26/5/2024 6:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[pr_updateStudent]
@StudentID varchar(20),
@Name nvarchar(50),
@Address nvarchar(50),
@DateOfBirth date
AS
UPDATE Student 
SET
StudentID = @StudentID,
Name = @Name,
Address = @Address, 
DateOfBirth = @DateOfBirth
WHERE StudentID = @StudentID
GO
/****** Object:  StoredProcedure [dbo].[pr_updateTeacher]    Script Date: 26/5/2024 6:47:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[pr_updateTeacher]
@TeacherID varchar(20),
@Name nvarchar(50),
@Address nvarchar(50)
AS
UPDATE Teacher 
SET
TeacherID = @TeacherID,
Name = @Name,
Address = @Address
WHERE TeacherID = @TeacherID
GO
USE [master]
GO
ALTER DATABASE [firstDB] SET  READ_WRITE 
GO
